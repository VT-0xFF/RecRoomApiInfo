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
		[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40")]
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
		[Cpp2IlInjected.Address(RVA = "0x632E6C0", Offset = "0x632DAC0", VA = "0x18632E6C0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6FB6F0", Offset = "0x6FAAF0", VA = "0x1806FB6F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x92A620", Offset = "0x929A20", VA = "0x18092A620")]
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
	[Cpp2IlInjected.Address(RVA = "0x632E520", Offset = "0x632D920", VA = "0x18632E520")]
	public NFIDGPANHEB(string EOPKCKAAGKI, float MMHBLDHDAIK = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2045A40", Offset = "0x2044E40", VA = "0x182045A40")]
	public void GLKICEEPKDG<T>(string MLIELKFMALM, T KPPLMEOMNGF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x632E390", Offset = "0x632D790", VA = "0x18632E390")]
	public void GLKICEEPKDG(string MLIELKFMALM, string KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x632E2A0", Offset = "0x632D6A0", VA = "0x18632E2A0")]
	public void COFNKDHFKIO(string BHDGMHBDDGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x632E410", Offset = "0x632D810", VA = "0x18632E410")]
	public void KBGCMFNGGBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x632E180", Offset = "0x632D580", VA = "0x18632E180")]
	private void CMEFOKBKHMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x632E4D0", Offset = "0x632D8D0", VA = "0x18632E4D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E1AC0", Offset = "0x6E0EC0", VA = "0x1806E1AC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E1AC0", Offset = "0x6E0EC0", VA = "0x1806E1AC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6E1120", Offset = "0x6E0520", VA = "0x1806E1120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x632F130", Offset = "0x632E530", VA = "0x18632F130", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E4250", Offset = "0x6E3650", VA = "0x1806E4250", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action FKFANDDHIJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x632AC40", Offset = "0x632A040", VA = "0x18632AC40", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x632A360", Offset = "0x6329760", VA = "0x18632A360", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action HPEDCNEDFNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x632B690", Offset = "0x632AA90", VA = "0x18632B690", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x632A2C0", Offset = "0x63296C0", VA = "0x18632A2C0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x632AFC0", Offset = "0x632A3C0", VA = "0x18632AFC0", Slot = "8")]
	public LLEFGLIPMKI JHHOMPLGCBC(string EDFCANILEGA, string GHJMMHFPFLD, [Optional] BMKBKKKFPGM LLNDGAJEMEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x632BB60", Offset = "0x632AF60", VA = "0x18632BB60", Slot = "16")]
	public LLEFGLIPMKI PKGIJLCJAMH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x632ADA0", Offset = "0x632A1A0", VA = "0x18632ADA0", Slot = "10")]
	public LLEFGLIPMKI JGMOMHJLLCJ(BMKBKKKFPGM LLNDGAJEMEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x632B730", Offset = "0x632AB30", VA = "0x18632B730", Slot = "11")]
	public LLEFGLIPMKI LMOHIJMFKBH(BMKBKKKFPGM LLNDGAJEMEN, Dictionary<string, string> DIIDCLKBADN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x632BAB0", Offset = "0x632AEB0", VA = "0x18632BAB0", Slot = "12")]
	public bool PCCNMJCBOCA(string CLGHJEOCFAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x632BCF0", Offset = "0x632B0F0", VA = "0x18632BCF0", Slot = "13")]
	public GBFBAIMMGEP PLGLEDMAMOA(string GABKMFALOME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x632ACE0", Offset = "0x632A0E0", VA = "0x18632ACE0", Slot = "14")]
	public CEEDGCKJFLK HKAOGPHEIDF(string PEFGAGJLFOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x632A1D0", Offset = "0x63295D0", VA = "0x18632A1D0", Slot = "15")]
	public GBFBAIMMGEP AKOOFJLDGFA(string GLJMNMKNGFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x632A650", Offset = "0x6329A50", VA = "0x18632A650")]
	private NPHCNBHPDGE FAKNAGKGPOP(BMKBKKKFPGM LLNDGAJEMEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x632B4F0", Offset = "0x632A8F0", VA = "0x18632B4F0")]
	private ANEJKMPFFMF JNFEJJCNBDP(string GHJMMHFPFLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x632A400", Offset = "0x6329800", VA = "0x18632A400")]
	private void EOFNMPJMOHO(string GABKMFALOME, GBFBAIMMGEP GKCAFNKAINH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
	public HBEMOMALKKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0xFC8700", Offset = "0xFC7B00", VA = "0x180FC8700")]
	[CompilerGenerated]
	private void FKIAHADNDJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x632BA20", Offset = "0x632AE20", VA = "0x18632BA20")]
	[CompilerGenerated]
	private void MGKEHAGLGEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x632B460", Offset = "0x632A860", VA = "0x18632B460")]
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
		[Cpp2IlInjected.Address(RVA = "0x6328AD0", Offset = "0x6327ED0", VA = "0x186328AD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool LCLDHDEMAPD
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x63288F0", Offset = "0x6327CF0", VA = "0x1863288F0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action FKFANDDHIJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6328C80", Offset = "0x6328080", VA = "0x186328C80", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6328BE0", Offset = "0x6327FE0", VA = "0x186328BE0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action HPEDCNEDFNM
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6329200", Offset = "0x6328600", VA = "0x186329200", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6328B40", Offset = "0x6327F40", VA = "0x186328B40", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
	[Preserve]
	public DEPDJBBDBDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x63289E0", Offset = "0x6327DE0", VA = "0x1863289E0")]
	[JDLBAGCFHIO(MEDANDNEHIF.GameOnly)]
	private static void BBHGKGEMGEL(DDFGGHLLPGI MBIOGPPGEOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6328F20", Offset = "0x6328320", VA = "0x186328F20", Slot = "8")]
	public LLEFGLIPMKI JHHOMPLGCBC(string EDFCANILEGA, string GHJMMHFPFLD, [Optional] BMKBKKKFPGM LLNDGAJEMEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6328E20", Offset = "0x6328220", VA = "0x186328E20", Slot = "10")]
	public LLEFGLIPMKI JGMOMHJLLCJ(BMKBKKKFPGM LLNDGAJEMEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x63292A0", Offset = "0x63286A0", VA = "0x1863292A0", Slot = "11")]
	public LLEFGLIPMKI LMOHIJMFKBH(BMKBKKKFPGM LLNDGAJEMEN, Dictionary<string, string> DIIDCLKBADN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x63293B0", Offset = "0x63287B0", VA = "0x1863293B0", Slot = "12")]
	public bool PCCNMJCBOCA(string CLGHJEOCFAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6329550", Offset = "0x6328950", VA = "0x186329550", Slot = "13")]
	public GBFBAIMMGEP PLGLEDMAMOA(string GABKMFALOME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6328D20", Offset = "0x6328120", VA = "0x186328D20", Slot = "14")]
	public CEEDGCKJFLK HKAOGPHEIDF(string PEFGAGJLFOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6328940", Offset = "0x6327D40", VA = "0x186328940", Slot = "15")]
	public GBFBAIMMGEP AKOOFJLDGFA(string GLJMNMKNGFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6329450", Offset = "0x6328850", VA = "0x186329450", Slot = "16")]
	public LLEFGLIPMKI PKGIJLCJAMH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0xFDF8A0", Offset = "0xFDECA0", VA = "0x180FDF8A0")]
	[CompilerGenerated]
	private void INOLHLMKCIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x12006E0", Offset = "0x11FFAE0", VA = "0x1812006E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x701020", Offset = "0x700420", VA = "0x180701020", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action FKFANDDHIJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x632D010", Offset = "0x632C410", VA = "0x18632D010", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x632CF70", Offset = "0x632C370", VA = "0x18632CF70", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action HPEDCNEDFNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x632D200", Offset = "0x632C600", VA = "0x18632D200", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x632CED0", Offset = "0x632C2D0", VA = "0x18632CED0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x632D160", Offset = "0x632C560", VA = "0x18632D160", Slot = "8")]
	public LLEFGLIPMKI JHHOMPLGCBC(string EDFCANILEGA, string GHJMMHFPFLD, [Optional] BMKBKKKFPGM LLNDGAJEMEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x632D0C0", Offset = "0x632C4C0", VA = "0x18632D0C0", Slot = "10")]
	public LLEFGLIPMKI JGMOMHJLLCJ(BMKBKKKFPGM LLNDGAJEMEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x632D2A0", Offset = "0x632C6A0", VA = "0x18632D2A0", Slot = "11")]
	public LLEFGLIPMKI LMOHIJMFKBH(BMKBKKKFPGM LLNDGAJEMEN, Dictionary<string, string> DIIDCLKBADN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6E3D00", Offset = "0x6E3100", VA = "0x1806E3D00", Slot = "12")]
	public bool PCCNMJCBOCA(string CLGHJEOCFAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x632CEC0", Offset = "0x632C2C0", VA = "0x18632CEC0", Slot = "13")]
	public GBFBAIMMGEP PLGLEDMAMOA(string GABKMFALOME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x632D0B0", Offset = "0x632C4B0", VA = "0x18632D0B0", Slot = "14")]
	public CEEDGCKJFLK HKAOGPHEIDF(string PEFGAGJLFOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x632CEC0", Offset = "0x632C2C0", VA = "0x18632CEC0", Slot = "15")]
	public GBFBAIMMGEP AKOOFJLDGFA(string GLJMNMKNGFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x632D340", Offset = "0x632C740", VA = "0x18632D340", Slot = "16")]
	public LLEFGLIPMKI PKGIJLCJAMH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	long BCPLABFCBHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BKNJODJHDLJ(string MFEOJPNCOBA, string HBAKLKJCKFJ, string KHKMPGGKJAB);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JOGLKFCIFIN(string MFEOJPNCOBA);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JHIIOCMDCMN(string MFEOJPNCOBA, string MAMBPAHAODF, string IBEAGGPPDML);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JGOBCHGMECP(string HBCALMLKPIA, object HCIFABFJCFJ, object HLBKABOABPF);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FPNEKINGIHN(long MFINFKIHBFD, bool FJFKKDFGEMC = true);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	long BLMAFAKOJGH();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface BMKBKKKFPGM
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool KKGKOCOKCKF
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool FKCEMEPLEKL
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool DKGJOIGEINP
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool NCKAELDGNFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool? DOFIKMKDPJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	int? CIIIINGBNPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int LNOEJOACJPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	string PEHDEINMEHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	string APPICCIADOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	string PAMNLHOLMAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	string HDPPAGPEFIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	string LBKBALOGJAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	string BBGLDEPOMKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	double HHEMHHPCNGG
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
		public AmplitudeAnalyticsClient.Settings GAAJDAHHPHA
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool GHNJFKCNGGI
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x6FB3D0", Offset = "0x6FA7D0", VA = "0x1806FB3D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xE09F70", Offset = "0xE09370", VA = "0x180E09F70")]
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

				[Cpp2IlInjected.Token(Token = "0x60000B8")]
				[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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

				[Cpp2IlInjected.Token(Token = "0x60000B9")]
				[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
				public PBOIMHKPFBP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000BA")]
				[Cpp2IlInjected.Address(RVA = "0x632E750", Offset = "0x632DB50", VA = "0x18632E750")]
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

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			public int? JJFHPIDGMHO
			{
				[Cpp2IlInjected.Token(Token = "0x60000AC")]
				[Cpp2IlInjected.Address(RVA = "0x6327CF0", Offset = "0x63270F0", VA = "0x186327CF0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			public int? DHAFIAMOHAE
			{
				[Cpp2IlInjected.Token(Token = "0x60000AD")]
				[Cpp2IlInjected.Address(RVA = "0x63279A0", Offset = "0x6326DA0", VA = "0x1863279A0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x6328760", Offset = "0x6327B60", VA = "0x186328760")]
			internal BHLFBOCEKAA(string MCBLGGNJOGF, string GHJMMHFPFLD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x63272C0", Offset = "0x63266C0", VA = "0x1863272C0")]
			public int DGHPBLBIJGC([Optional] int? NEJBOHEBLAL)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x6327A60", Offset = "0x6326E60", VA = "0x186327A60")]
			public List<Dictionary<string, object>> GNKBICFENAO(int KAFFBMLEIBH, int? NEJBOHEBLAL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x6327560", Offset = "0x6326960", VA = "0x186327560")]
			public void DPNDLNMPHAM(AmplitudeAnalyticsIdentifyMessage AELIHOPICED, bool EOMOILKFGLB = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x6327450", Offset = "0x6326850", VA = "0x186327450")]
			public void DPNDLNMPHAM(Dictionary<string, object> AELIHOPICED, bool EOMOILKFGLB = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x63285D0", Offset = "0x63279D0", VA = "0x1863285D0")]
			public void PILNPLNCIDJ(params Dictionary<string, object>[] AJIANFHALFB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x6328380", Offset = "0x6327780", VA = "0x186328380")]
			public void NPAKKLIAEOL(List<Dictionary<string, object>> DKGEFMDANEO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x6327D90", Offset = "0x6327190", VA = "0x186327D90")]
			private void LFEFHJDMPLF(Dictionary<string, object> AELIHOPICED, bool EOMOILKFGLB = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x6327600", Offset = "0x6326A00", VA = "0x186327600")]
			public void FDBMJOBPIIC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x6327ED0", Offset = "0x63272D0", VA = "0x186327ED0")]
			private void LJJFOIMPPOD([Optional] string NKGBJHPHBAA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x6327870", Offset = "0x6326C70", VA = "0x186327870")]
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

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x632F380", Offset = "0x632E780", VA = "0x18632F380")]
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

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			private FEEMOJCDGJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000C4")]
				[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x6E4200", Offset = "0x6E3600", VA = "0x1806E4200")]
			[DebuggerHidden]
			public GLLIBCOBHOI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x6329BA0", Offset = "0x6328FA0", VA = "0x186329BA0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x632A190", Offset = "0x6329590", VA = "0x18632A190", Slot = "8")]
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

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000CA")]
				[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x6E4200", Offset = "0x6E3600", VA = "0x1806E4200")]
			[DebuggerHidden]
			public ELEJOHJCBOE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x6329770", Offset = "0x6328B70", VA = "0x186329770", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x6329860", Offset = "0x6328C60", VA = "0x186329860", Slot = "8")]
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

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000D0")]
				[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x6E4200", Offset = "0x6E3600", VA = "0x1806E4200")]
			[DebuggerHidden]
			public KKCJOGLCDAD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x632D6C0", Offset = "0x632CAC0", VA = "0x18632D6C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x632D830", Offset = "0x632CC30", VA = "0x18632D830", Slot = "8")]
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

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			private FEEMOJCDGJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000D6")]
				[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x6E4200", Offset = "0x6E3600", VA = "0x1806E4200")]
			[DebuggerHidden]
			public JBHPPIGJFGM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x632CBE0", Offset = "0x632BFE0", VA = "0x18632CBE0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x632CE80", Offset = "0x632C280", VA = "0x18632CE80", Slot = "8")]
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

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			private FEEMOJCDGJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000DF")]
				[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x6E4200", Offset = "0x6E3600", VA = "0x1806E4200")]
			[DebuggerHidden]
			public KDGOFAGIEBO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x632D3E0", Offset = "0x632C7E0", VA = "0x18632D3E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x632D680", Offset = "0x632CA80", VA = "0x18632D680", Slot = "8")]
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

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
			public PJAOGKNNPMM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x632E7B0", Offset = "0x632DBB0", VA = "0x18632E7B0")]
			internal void <FlushFromCache>b__0(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x632EB20", Offset = "0x632DF20", VA = "0x18632EB20")]
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

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			private FEEMOJCDGJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000E8")]
				[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x6E4200", Offset = "0x6E3600", VA = "0x1806E4200")]
			[DebuggerHidden]
			public MLEBIKOFEPI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x632D870", Offset = "0x632CC70", VA = "0x18632D870", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x632E140", Offset = "0x632D540", VA = "0x18632E140", Slot = "8")]
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

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x14CA560", Offset = "0x14C9960", VA = "0x1814CA560")]
			public FOBDFOHOCEI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x2AADA80", Offset = "0x2AACE80", VA = "0x182AADA80")]
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

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x14CA560", Offset = "0x14C9960", VA = "0x1814CA560")]
			public FHCCGLNLKBD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x2AADA80", Offset = "0x2AACE80", VA = "0x182AADA80")]
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

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private JNBJAPHOFAJ BAGJGBDEJFL
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x6320E80", Offset = "0x6320280", VA = "0x186320E80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private static int KKCFOPODCON
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x6324230", Offset = "0x6323630", VA = "0x186324230")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static long HHKIMIDIJII
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x6325AD0", Offset = "0x6324ED0", VA = "0x186325AD0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x6325BD0", Offset = "0x6324FD0", VA = "0x186325BD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public static string ELKAOBHIFBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x6325A70", Offset = "0x6324E70", VA = "0x186325A70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public static string CNFFHHPNLAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x6325AA0", Offset = "0x6324EA0", VA = "0x186325AA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public string FPJLDBHDLFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x6F6740", Offset = "0x6F5B40", VA = "0x1806F6740")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x717DC0", Offset = "0x7171C0", VA = "0x180717DC0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int? CIIIINGBNPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x810840", Offset = "0x80FC40", VA = "0x180810840")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x1997430", Offset = "0x1996830", VA = "0x181997430")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool NNJLBNKIMCL
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x859820", Offset = "0x858C20", VA = "0x180859820")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x859920", Offset = "0x858D20", VA = "0x180859920")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public static bool JLAPJLECKJA
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x6325980", Offset = "0x6324D80", VA = "0x186325980")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<bool> KLBCMEMBBKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x63258E0", Offset = "0x6324CE0", VA = "0x1863258E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x6325B30", Offset = "0x6324F30", VA = "0x186325B30")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6321180", Offset = "0x6320580", VA = "0x186321180", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6322580", Offset = "0x6321980", VA = "0x186322580")]
		private void JEAICNEAKHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6325130", Offset = "0x6324530", VA = "0x186325130")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x63245F0", Offset = "0x63239F0", VA = "0x1863245F0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6325420", Offset = "0x6324820", VA = "0x186325420")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6324790", Offset = "0x6323B90", VA = "0x186324790")]
		public LLEFGLIPMKI PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x63224F0", Offset = "0x63218F0", VA = "0x1863224F0")]
		[IteratorStateMachine(typeof(GLLIBCOBHOI))]
		public IEnumerator<FEEMOJCDGJP> Initialize(AmplitudeAnalyticsEvent LFBACKMGDIA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6325310", Offset = "0x6324710", VA = "0x186325310")]
		public void UpdateLastAliveTime(float BOIHBMKHANN = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6324520", Offset = "0x6323920", VA = "0x186324520")]
		private LLEFGLIPMKI OPNKDJHKENM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6321AD0", Offset = "0x6320ED0", VA = "0x186321AD0")]
		private LLEFGLIPMKI FKGMBJLAHNC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6324CE0", Offset = "0x63240E0", VA = "0x186324CE0")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6321550", Offset = "0x6320950", VA = "0x186321550")]
		[IteratorStateMachine(typeof(ELEJOHJCBOE))]
		private IEnumerator CCHONAGIHKG(LCFGHKNEPEI PKIDGKFJLMM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6325690", Offset = "0x6324A90", VA = "0x186325690")]
		[IteratorStateMachine(typeof(KKCJOGLCDAD))]
		public IEnumerator WaitForFlush(float FAMGKJPNCKD = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x63251F0", Offset = "0x63245F0", VA = "0x1863251F0")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6325140", Offset = "0x6324540", VA = "0x186325140")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime PPIFMHEDLGN)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6322140", Offset = "0x6321540", VA = "0x186322140")]
		public static GIMAEFMKNHN Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6320FE0", Offset = "0x63203E0", VA = "0x186320FE0")]
		public static IEGHJCIAJCN AccountSelectionPostLoginEvent([NotNull] string JKBNEEENKCO, string NHKNPEOCEFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x63218C0", Offset = "0x6320CC0", VA = "0x1863218C0")]
		public static IEGHJCIAJCN Event([NotNull] string JKBNEEENKCO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x63247F0", Offset = "0x6323BF0", VA = "0x1863247F0")]
		public static IEGHJCIAJCN PreviousSessionEvent([NotNull] string JKBNEEENKCO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x63222A0", Offset = "0x63216A0", VA = "0x1863222A0")]
		public static IEGHJCIAJCN InitializeEvent(string NHKNPEOCEFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6324E40", Offset = "0x6324240", VA = "0x186324E40")]
		public static IEGHJCIAJCN StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x63215E0", Offset = "0x63209E0", VA = "0x1863215E0")]
		public static IEGHJCIAJCN CreateOutOfSessionEvent(string JKBNEEENKCO, bool GMNGBKGNOFG = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6323CF0", Offset = "0x63230F0", VA = "0x186323CF0")]
		public static LLEFGLIPMKI LogOutOfSessionEvent(IEGHJCIAJCN ONCOCGENLMC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6323A30", Offset = "0x6322E30", VA = "0x186323A30")]
		public void LogEventAsync(AmplitudeAnalyticsEvent FOCJFPDDOCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6324000", Offset = "0x6323400", VA = "0x186324000")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent FOCJFPDDOCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6324150", Offset = "0x6323550", VA = "0x186324150")]
		public void LogSerializedEventAsync(Dictionary<string, object> KANPCFLGKEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6323B80", Offset = "0x6322F80", VA = "0x186323B80")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage EEEBBLOPMIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6321470", Offset = "0x6320870", VA = "0x186321470")]
		private void BKPFEIOBPEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6320B10", Offset = "0x631FF10", VA = "0x186320B10")]
		private void ABANHKPDFOH(Dictionary<string, object> CHENOCAGDJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6320EF0", Offset = "0x63202F0", VA = "0x186320EF0")]
		private void APDECMNNAEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6321E00", Offset = "0x6321200", VA = "0x186321E00")]
		private void GGLBAGKDKGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6321D70", Offset = "0x6321170", VA = "0x186321D70")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6324690", Offset = "0x6323A90", VA = "0x186324690")]
		[IteratorStateMachine(typeof(JBHPPIGJFGM))]
		private IEnumerator<FEEMOJCDGJP> PGIDDFKLIMF(float FAMGKJPNCKD = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6324710", Offset = "0x6323B10", VA = "0x186324710")]
		[IteratorStateMachine(typeof(KDGOFAGIEBO))]
		private IEnumerator<FEEMOJCDGJP> PMAHFOADIBL(float FAMGKJPNCKD = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6320DA0", Offset = "0x63201A0", VA = "0x186320DA0")]
		[IteratorStateMachine(typeof(MLEBIKOFEPI))]
		private IEnumerator<FEEMOJCDGJP> AGBPIJKBFPH(BHLFBOCEKAA DAJPKNFIFBB, int? NEJBOHEBLAL, string JLEDGILHJAD, string LKFKOOKCPKH, float FAMGKJPNCKD, Action<int> FLEGJKGJGKP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6324400", Offset = "0x6323800", VA = "0x186324400")]
		private static void ONFJGDHCIPM(bool MIFCLBGJBAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6323630", Offset = "0x6322A30", VA = "0x186323630")]
		private global::MLDKKGKEACN<CDBEMIMIICL<Dictionary<string, object>>> LJPKGDKBFAL(string JLEDGILHJAD, string LKFKOOKCPKH, string MKCBFKGFGDB, string DHNMIKKKHCL, Dictionary<string, object> LMNMDNBFHIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6323760", Offset = "0x6322B60", VA = "0x186323760")]
		private global::MLDKKGKEACN<CDBEMIMIICL<List<Dictionary<string, object>>>> LJPKGDKBFAL(string JLEDGILHJAD, string LKFKOOKCPKH, string MKCBFKGFGDB, string DHNMIKKKHCL, List<Dictionary<string, object>> LMNMDNBFHIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x2BB4E10", Offset = "0x2BB4210", VA = "0x182BB4E10")]
		private global::MLDKKGKEACN<CDBEMIMIICL<T>> FLABLJANLEJ<T>(string JLEDGILHJAD, string LKFKOOKCPKH, string DHNMIKKKHCL, T LMNMDNBFHIK, Dictionary<string, object> GHBFCPCHCDG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x2BB50A0", Offset = "0x2BB44A0", VA = "0x182BB50A0")]
		private global::MLDKKGKEACN<CDBEMIMIICL<T>> NMEGNJNFKGI<T>(string JLEDGILHJAD, string LKFKOOKCPKH, string MKCBFKGFGDB, T LMNMDNBFHIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x63228A0", Offset = "0x6321CA0", VA = "0x1863228A0")]
		private bool KNBFOIAOMLL(float ADFLOADHGMB, float FAMGKJPNCKD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x63228F0", Offset = "0x6321CF0", VA = "0x1863228F0")]
		private Dictionary<string, object> LDCJNDCEPFG(string LKFKOOKCPKH, Dictionary<string, object> LMNMDNBFHIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6325770", Offset = "0x6324B70", VA = "0x186325770")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6321FE0", Offset = "0x63213E0", VA = "0x186321FE0")]
		[CompilerGenerated]
		private long IJJCNLFKAPN()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6321AC0", Offset = "0x6320EC0", VA = "0x186321AC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6326830", Offset = "0x6325C30", VA = "0x186326830")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x63268F0", Offset = "0x6325CF0", VA = "0x1863268F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public static string StableId
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x6326890", Offset = "0x6325C90", VA = "0x186326890")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x6326960", Offset = "0x6325D60", VA = "0x186326960")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x6F6780", Offset = "0x6F5B80", VA = "0x1806F6780")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6325C30", Offset = "0x6325030", VA = "0x186325C30")]
		public static IEGHJCIAJCN BMDGCEOIEEG(string LFMBJAIIPEH, [NotNull] string JFCJMBGMPGA, long MFINFKIHBFD, long HFHONBKKAPE, string NHKNPEOCEFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6325ED0", Offset = "0x63252D0", VA = "0x186325ED0")]
		public static IEGHJCIAJCN GNALPPOHMCG(string LFMBJAIIPEH, [NotNull] string JFCJMBGMPGA, long MFINFKIHBFD, long HFHONBKKAPE, string NHKNPEOCEFN, long DOMMNCONNPO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6326670", Offset = "0x6325A70", VA = "0x186326670")]
		private AmplitudeAnalyticsEvent(string LFMBJAIIPEH, [NotNull] string JFCJMBGMPGA, long MFINFKIHBFD, long HFHONBKKAPE, string NHKNPEOCEFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x91FFD0", Offset = "0x91F3D0", VA = "0x18091FFD0")]
		public void OIAKKBBCECF(long BFOFGLGBOKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6326550", Offset = "0x6325950", VA = "0x186326550", Slot = "5")]
		public override void NIAHKKJKGBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6325D20", Offset = "0x6325120", VA = "0x186325D20", Slot = "6")]
		public override void FBLOOOIBLFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6325FD0", Offset = "0x63253D0", VA = "0x186325FD0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x63295F0", Offset = "0x63289F0", VA = "0x1863295F0")]
			public void GPLCBJOPGPC(Dictionary<string, object> BFOMMKIPAIH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x632EFC0", Offset = "0x632E3C0", VA = "0x18632EFC0")]
			public void GPLCBJOPGPC(Dictionary<string, object> DBJNFKDCLAC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x103E3F0", Offset = "0x103D7F0", VA = "0x18103E3F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E1AC0", Offset = "0x6E0EC0", VA = "0x1806E1AC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x700130", Offset = "0x6FF530", VA = "0x180700130")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6326A50", Offset = "0x6325E50", VA = "0x186326A50")]
		public static GIMAEFMKNHN BMDGCEOIEEG(string LFMBJAIIPEH, string NHKNPEOCEFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6327050", Offset = "0x6326450", VA = "0x186327050")]
		protected AmplitudeAnalyticsIdentifyMessage(string LFMBJAIIPEH, string NHKNPEOCEFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x63269D0", Offset = "0x6325DD0", VA = "0x1863269D0")]
		public Dictionary<string, object> ABLLGKJDBLD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6326B80", Offset = "0x6325F80", VA = "0x186326B80", Slot = "4")]
		protected virtual Dictionary<string, object> JAPOOBBOKEB(Dictionary<string, object> NAGKFCEIELD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6326F30", Offset = "0x6326330", VA = "0x186326F30")]
		protected void MADEPHHLPOE(string EBOIOCBODNI, Dictionary<string, object> HECELBFBPAE, Dictionary<string, object> KEDJDOBMKEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6326EC0", Offset = "0x63262C0", VA = "0x186326EC0")]
		protected void JEKKPGJLBEG(string EBOIOCBODNI, string KPPLMEOMNGF, Dictionary<string, object> INAFJIMICJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6326FD0", Offset = "0x63263D0", VA = "0x186326FD0", Slot = "5")]
		public virtual void NIAHKKJKGBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6326B00", Offset = "0x6325F00", VA = "0x186326B00", Slot = "6")]
		public virtual void FBLOOOIBLFB()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class GIMAEFMKNHN : global::LHLAMMNOOJD<AmplitudeAnalyticsIdentifyMessage, GIMAEFMKNHN>
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public override GIMAEFMKNHN DMOOBPCCDHD
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7FEE20", Offset = "0x7FE220", VA = "0x1807FEE20", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6E1AC0", Offset = "0x6E0EC0", VA = "0x1806E1AC0", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage KOFGCLOCOHF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6329B50", Offset = "0x6328F50", VA = "0x186329B50")]
	public GIMAEFMKNHN(AmplitudeAnalyticsIdentifyMessage GOMILMNIGIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6329AB0", Offset = "0x6328EB0", VA = "0x186329AB0", Slot = "4")]
	public override void FBLOOOIBLFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class IEGHJCIAJCN : global::LHLAMMNOOJD<AmplitudeAnalyticsEvent, IEGHJCIAJCN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private bool CKPDEIBIMKG;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public override IEGHJCIAJCN DMOOBPCCDHD
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x7FEE20", Offset = "0x7FE220", VA = "0x1807FEE20", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public long EDPIKKKIEMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x374AEF0", Offset = "0x374A2F0", VA = "0x18374AEF0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6329A60", Offset = "0x6328E60", VA = "0x186329A60")]
	public IEGHJCIAJCN(AmplitudeAnalyticsEvent GOMILMNIGIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6E1AC0", Offset = "0x6E0EC0", VA = "0x1806E1AC0", Slot = "5")]
	public override AmplitudeAnalyticsEvent KOFGCLOCOHF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x632C610", Offset = "0x632BA10", VA = "0x18632C610", Slot = "4")]
	public override void FBLOOOIBLFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x632C910", Offset = "0x632BD10", VA = "0x18632C910")]
	public IEGHJCIAJCN GLKICEEPKDG(string MLIELKFMALM, long[] KPPLMEOMNGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x632C7D0", Offset = "0x632BBD0", VA = "0x18632C7D0")]
	public IEGHJCIAJCN GLKICEEPKDG(string MLIELKFMALM, ulong[] KPPLMEOMNGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x23DC6D0", Offset = "0x23DBAD0", VA = "0x1823DC6D0")]
	public IEGHJCIAJCN GLKICEEPKDG<T>(string MLIELKFMALM, T[] KPPLMEOMNGF) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x632CAE0", Offset = "0x632BEE0", VA = "0x18632CAE0")]
	public IEGHJCIAJCN GLKICEEPKDG(string MLIELKFMALM, string[] KPPLMEOMNGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x23DC660", Offset = "0x23DBA60", VA = "0x1823DC660")]
	public IEGHJCIAJCN GLKICEEPKDG<T>(string MLIELKFMALM, T KPPLMEOMNGF) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x632CA50", Offset = "0x632BE50", VA = "0x18632CA50")]
	public IEGHJCIAJCN GLKICEEPKDG(string MLIELKFMALM, long KPPLMEOMNGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x632C6D0", Offset = "0x632BAD0", VA = "0x18632C6D0")]
	public IEGHJCIAJCN GLKICEEPKDG(string MLIELKFMALM, ulong KPPLMEOMNGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x632C760", Offset = "0x632BB60", VA = "0x18632C760")]
	public IEGHJCIAJCN GLKICEEPKDG(string MLIELKFMALM, string KPPLMEOMNGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x632C6B0", Offset = "0x632BAB0", VA = "0x18632C6B0")]
	public IEGHJCIAJCN GCENMFNAEBG(string MLIELKFMALM, object? KPPLMEOMNGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x632C570", Offset = "0x632B970", VA = "0x18632C570")]
	public IEGHJCIAJCN EOBEBFJIDPO(string MLIELKFMALM, string KPPLMEOMNGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x632CAF0", Offset = "0x632BEF0", VA = "0x18632CAF0")]
	private IEGHJCIAJCN PBJGKDPCCEL(string MLIELKFMALM, object KPPLMEOMNGF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class FEBPOBPPPNF : IEGHJCIAJCN
{
	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6329A60", Offset = "0x6328E60", VA = "0x186329A60")]
	public FEBPOBPPPNF(AmplitudeAnalyticsEvent GOMILMNIGIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x63298A0", Offset = "0x6328CA0", VA = "0x1863298A0", Slot = "4")]
	public override void FBLOOOIBLFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public abstract class LHLAMMNOOJD<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : global::LHLAMMNOOJD<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	protected M GOMILMNIGIC;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public abstract BLDR DMOOBPCCDHD
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x1F8F3E0", Offset = "0x1F8E7E0", VA = "0x181F8F3E0")]
	public LHLAMMNOOJD(M GOMILMNIGIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x2A5E390", Offset = "0x2A5D790", VA = "0x182A5E390")]
	public BLDR HPOJBNOPBPJ(AmplitudeAnalyticsIdentifyMessage.DeviceInfo ICFIIPJFFNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x2A5E090", Offset = "0x2A5D490", VA = "0x182A5E090")]
	public BLDR BJBGGFDLNDG(AmplitudeAnalyticsIdentifyMessage.RevenueData KLHIGGHGGAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x2A5E270", Offset = "0x2A5D670", VA = "0x182A5E270")]
	public BLDR DAACNBEOEOD(string MLIELKFMALM, string KPPLMEOMNGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x26DAC70", Offset = "0x26DA070", VA = "0x1826DAC70")]
	public BLDR DAACNBEOEOD<T>(string MLIELKFMALM, T KPPLMEOMNGF) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x2A5E1C0", Offset = "0x2A5D5C0", VA = "0x182A5E1C0")]
	public BLDR DAACNBEOEOD(string MLIELKFMALM, long KPPLMEOMNGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x2A5E2E0", Offset = "0x2A5D6E0", VA = "0x182A5E2E0")]
	public BLDR DAACNBEOEOD(string MLIELKFMALM, ulong KPPLMEOMNGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void FBLOOOIBLFB();

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x2A5E3D0", Offset = "0x2A5D7D0", VA = "0x182A5E3D0")]
	internal static string IJIFIFBHEFL(string KPPLMEOMNGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x2A5E0D0", Offset = "0x2A5D4D0", VA = "0x182A5E0D0")]
	private BLDR CGOAHEFMBLB(string MLIELKFMALM, object KPPLMEOMNGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M KOFGCLOCOHF();
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class OAIGHHAOLHF
{
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public const string EKPKCDKFNCJ = "batch";

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public const string IFFGBGNPHGI = "type";

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public const string FJMEJJBEJPB = "identify";

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public const string IGFDICOIMCH = "track";

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public const string FMNKPLEHCFM = "userId";

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public const string LCEACKBLPCF = "anonymousId";

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public const string GLKAFGHCJAI = "stable_id";

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public const string OGNILEHFMHH = "messageId";

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public const string DAHDPMPFBBJ = "event";

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public const string OFOLOPAOPPM = "version";

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public const string HDJJBDLDNNC = "locale";

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public const string OEIMMMNKKAO = "name";

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public const string AGGPHMKBOPD = "properties";

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public const string LBAIHDEOCCD = "traits";

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public const string OJPHPKMKEHE = "context";

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public const string LGCNFMAACCA = "app";

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public const string HHLBHODKJJL = "os";

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public const string JJGKGKMDJHH = "device";

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public const string PLDADECIPHK = "originalTimestamp";

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public const string DJNHMEGIPOK = "brand";

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public const string EKOFLDAAPLP = "manufacturer";

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public const string GFLCAGNPHOM = "model";

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public const string FMGAKOLMFMN = "type";

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
	public OAIGHHAOLHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class BDHBMPJAEDJ
{
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public const int MEAPNICADKL = 2;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public const int JACEKKLLKFH = 100;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public const int MECLHJMGNEP = 1000;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public const long OCEDLEPJGFN = 1800000L;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public const int IAOCMOPJHAI = 1024;

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public const int HKEFHCABDHN = 1000;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public const string KJMJHEMHIIA = "amplitude_sequence_number";

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public const string DKEHBCODDAL = "amplitude_user_id";

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public const string EOCGIOIKEIB = "amplitude_last_time";

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public const string ELNHELCCKME = "initialize_analytics";

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public const string DMODPHMEGMH = "session_start";

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public const string DLOEGHIFMEM = "session_end";

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public const string BMKGKAHFLLN = "insert_id";

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public const string ILGKGOFMJMP = "event_time";

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public const string GLKEDPPFCDJ = "session_id";

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public const string PADJFPLIEBL = "session_tracking_data";

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public const string CLIGGMJKBAF = "user_properties";

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public const string NFCNDIJMJDI = "app_version";

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public const string JKFGLCCAKHO = "ip";

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public const string MAMPBDBAODH = "language";

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public const string GLKAFGHCJAI = "stable_id";

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public const string OOLLCIFDHPP = "platform";

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public const string LCDOEMLDNIB = "os_name";

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public const string JIOODNODMMI = "os_version";

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public const string KJKEDEIOMBK = "device_brand";

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public const string JHINIHKLAKL = "device_manufacturer";

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public const string PLNBBLAINCK = "device_model";

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public const string ADCHGMJBKHL = "device_type";

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public const string ADDKHAJEDDD = "price";

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public const string LCJIALGIMHE = "quantity";

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public const string AHGFJHFAMAF = "revenue";

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public const string NINDGBGDDFE = "productId";

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public const string FGACDAPAJKP = "revenueType";

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public const string MDHAMIGPOCG = "event_type";

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public const string FMNKPLEHCFM = "user_id";

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public const string GLHPCAFAAMI = "event_properties";

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public const int BCPBONAIADI = 10;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> GEEHNCHANNK;

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6327110", Offset = "0x6326510", VA = "0x186327110")]
	internal static bool OCAMBHIJLAI(string EBOIOCBODNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
	public BDHBMPJAEDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface HFEIMCJKHGH
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	bool OJKDPOFOLDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	string OJKDIKJNKLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	string DEMEDBHHEBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	string JIEGGMPODJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	string PEJAJIIKAGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::MLDKKGKEACN<LIDLFEOFMGL> LJPKGDKBFAL(string JLEDGILHJAD, Dictionary<string, string> EIBLJDCOKAN, bool KMMHANFEIOL = false);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "6")]
	global::MLDKKGKEACN<LIDLFEOFMGL> MPJPKCJDBFN(string JLEDGILHJAD, string HAHECJIJMBJ, string FIBKGBBGEPM, string NAFMPBJOPMF);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct LIDLFEOFMGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public readonly int AGFNINAPMFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public readonly string FEDHIKMHINN;

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x70B0B0", Offset = "0x70A4B0", VA = "0x18070B0B0")]
	public LIDLFEOFMGL(int FBMFHOLJFAJ, string CLNMDJOHJHK)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class HFBMMEPCDLM
{
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static byte[] JNCOHDGFJLD;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static int DPLNOEOFOIM;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private static int ICHAIMIBEGB;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static BigInteger GDFBBFKEIIP;

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
	public HFBMMEPCDLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x632BF40", Offset = "0x632B340", VA = "0x18632BF40")]
	private static string AEHPCHKGFJE(byte[] ICPOAGANOLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x632C050", Offset = "0x632B450", VA = "0x18632C050")]
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

		[Cpp2IlInjected.Token(Token = "0x400010D")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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

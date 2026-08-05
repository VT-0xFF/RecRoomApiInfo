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
		[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40")]
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
		[Cpp2IlInjected.Address(RVA = "0x61B6930", Offset = "0x61B5130", VA = "0x1861B6930")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6F06F0", Offset = "0x6EEEF0", VA = "0x1806F06F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x91F620", Offset = "0x91DE20", VA = "0x18091F620")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum EDGEFDKLHEB
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
public class NAEKCKEIHHM
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private const string OIAGCJCIDEC = "timed_flow";

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private const string IDCAGJJFGBG = "flowName";

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private const string EKFPJKEABII = "startedAt";

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private const string JKOHGDFDAJD = "endedAt";

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private const string GEOGPPLANJA = "durationInSeconds";

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private const string DMPAOAKJANK = "failure";

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private const string HHADIBPBICO = "failureMessage";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private long AODCHGHKJLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private MDGNKBGFGLD HJCKAIKDMGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private bool JPGEFINMABF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private float FLEGKKMDDAG;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x61B64B0", Offset = "0x61B4CB0", VA = "0x1861B64B0")]
	public NAEKCKEIHHM(string JJOPLLBFOOP, float FLEGKKMDDAG = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1F113C0", Offset = "0x1F0FBC0", VA = "0x181F113C0")]
	public void MBFFDAJNCCM<T>(string NPCKPCNEDPB, T NPHADDCNBHE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x61B6430", Offset = "0x61B4C30", VA = "0x1861B6430")]
	public void MBFFDAJNCCM(string NPCKPCNEDPB, string NPHADDCNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x61B6230", Offset = "0x61B4A30", VA = "0x1861B6230")]
	public void ELGILAGEOOL(string BNKPBBLMHGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x61B6320", Offset = "0x61B4B20", VA = "0x1861B6320")]
	public void FGPPFEBKDND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x61B6110", Offset = "0x61B4910", VA = "0x1861B6110")]
	private void CHIMKAMNPPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x61B63E0", Offset = "0x61B4BE0", VA = "0x1861B63E0")]
	private bool LPFDMDHBFLG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface MIJGMBFDPDO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool MMIMOGPFBMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action NIOKGPCGCGB;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action GKEKMCBEJKI;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "4")]
	LDGADANDBIO ODGJJHFNDHJ(string NKNGDPCMDDJ, string DBFMGFAPCKH, [Optional] CPAODMCDMNF ECEIHHEEHNP);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "6")]
	LDGADANDBIO DIIHNIHDAMN(CPAODMCDMNF ECEIHHEEHNP);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "7")]
	LDGADANDBIO LDFBKLJEMCF(CPAODMCDMNF ECEIHHEEHNP, Dictionary<string, string> LCGDJOEOINE);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool PKNLLPHBOKO(string ADNEAFPEAFI);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "9")]
	GNAOLMDHMGB LBKCGPGONID(string HFGILEGILPP);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "10")]
	NHEIFGGFHEL GMOGCMLDMLB(string CIEDACDCOCO);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "11")]
	GNAOLMDHMGB ICMGKCJIFPL(string DGKGCGGHIBG);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "12")]
	LDGADANDBIO EGMACIDIIDM();
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
			[Cpp2IlInjected.Address(RVA = "0x6D6AC0", Offset = "0x6D52C0", VA = "0x1806D6AC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x6D6AC0", Offset = "0x6D52C0", VA = "0x1806D6AC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6D6120", Offset = "0x6D4920", VA = "0x1806D6120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x61B7E60", Offset = "0x61B6660", VA = "0x1861B7E60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class GNLGDAABOKL : MIJGMBFDPDO
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private const string CFJBGJHPHOC = "GamePlatform";

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private const string LNFILJAAIBG = "InteractionCategory";

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private const string CBBHAKMKLKC = "JrActType";

	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private const string LCDAOBDCJLJ = "IsDeveloper";

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private const string GADAPBNKJLP = "IsModerator";

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private const string PANHFMHMPIK = "IsMember";

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private const string NONBONGLABG = "DaysSinceJoiningBucket";

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private const string ALJCEGPJIDD = "AccountCreationTimeAfterEpochMilliseconds";

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private const string LIJJIDMIBPF = "InGoodStanding";

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private const string BDLHFDINGIF = "FriendCount";

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private const string IKCPDHGGCEP = "LocaleName";

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly IReadOnlyDictionary<string, NGLNOPLBHPO> LCPMAFDFNLO;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private const int KHPNFMIJABG = 5000;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private bool BLFPNFCPBMJ;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool MMIMOGPFBMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6D9250", Offset = "0x6D7A50", VA = "0x1806D9250", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action NIOKGPCGCGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x61B27E0", Offset = "0x61B0FE0", VA = "0x1861B27E0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x61B38E0", Offset = "0x61B20E0", VA = "0x1861B38E0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action GKEKMCBEJKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x61B29D0", Offset = "0x61B11D0", VA = "0x1861B29D0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x61B3430", Offset = "0x61B1C30", VA = "0x1861B3430", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x61B3980", Offset = "0x61B2180", VA = "0x1861B3980", Slot = "8")]
	public LDGADANDBIO ODGJJHFNDHJ(string NKNGDPCMDDJ, string DBFMGFAPCKH, [Optional] CPAODMCDMNF ECEIHHEEHNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x61B2650", Offset = "0x61B0E50", VA = "0x1861B2650", Slot = "16")]
	public LDGADANDBIO EGMACIDIIDM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x61B2290", Offset = "0x61B0A90", VA = "0x1861B2290", Slot = "10")]
	public LDGADANDBIO DIIHNIHDAMN(CPAODMCDMNF ECEIHHEEHNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x61B35F0", Offset = "0x61B1DF0", VA = "0x1861B35F0", Slot = "11")]
	public LDGADANDBIO LDFBKLJEMCF(CPAODMCDMNF ECEIHHEEHNP, Dictionary<string, string> LCGDJOEOINE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x61B3E20", Offset = "0x61B2620", VA = "0x1861B3E20", Slot = "12")]
	public bool PKNLLPHBOKO(string ADNEAFPEAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x61B34D0", Offset = "0x61B1CD0", VA = "0x1861B34D0", Slot = "13")]
	public GNAOLMDHMGB LBKCGPGONID(string HFGILEGILPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x61B2910", Offset = "0x61B1110", VA = "0x1861B2910", Slot = "14")]
	public NHEIFGGFHEL GMOGCMLDMLB(string CIEDACDCOCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x61B2A70", Offset = "0x61B1270", VA = "0x1861B2A70", Slot = "15")]
	public GNAOLMDHMGB ICMGKCJIFPL(string DGKGCGGHIBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x61B2B60", Offset = "0x61B1360", VA = "0x1861B2B60")]
	private PGPJLPNALBB IPJLABFAPLI(CPAODMCDMNF ECEIHHEEHNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x61B24B0", Offset = "0x61B0CB0", VA = "0x1861B24B0")]
	private OCDIEFMBEPF EFEJLDPIJPP(string DBFMGFAPCKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x61B3150", Offset = "0x61B1950", VA = "0x1861B3150")]
	private void JBKLAJACNAN(string HFGILEGILPP, GNAOLMDHMGB LKCDKHEEMAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public GNLGDAABOKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0xDD6A20", Offset = "0xDD5220", VA = "0x180DD6A20")]
	[CompilerGenerated]
	private void NLAINGOBENF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x61B33A0", Offset = "0x61B1BA0", VA = "0x1861B33A0")]
	[CompilerGenerated]
	private void KEKPGJGLMFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x61B2880", Offset = "0x61B1080", VA = "0x1861B2880")]
	[CompilerGenerated]
	private void GMLDPCLKBBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class OAJFPCDMCGN : MIJGMBFDPDO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private MIJGMBFDPDO BFNKEPLIHAP;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private MIJGMBFDPDO LMJDBGJMKEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x61B69C0", Offset = "0x61B51C0", VA = "0x1861B69C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool MMIMOGPFBMH
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x61B6F10", Offset = "0x61B5710", VA = "0x1861B6F10", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action NIOKGPCGCGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x61B6C30", Offset = "0x61B5430", VA = "0x1861B6C30", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x61B71B0", Offset = "0x61B59B0", VA = "0x1861B71B0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action GKEKMCBEJKI
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x61B6DD0", Offset = "0x61B55D0", VA = "0x1861B6DD0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x61B6F60", Offset = "0x61B5760", VA = "0x1861B6F60", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	[Preserve]
	public OAJFPCDMCGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x61B75D0", Offset = "0x61B5DD0", VA = "0x1861B75D0")]
	[HAHBDBPNEOA(MDCFJLLNHDJ.GameOnly)]
	private static void PMMFNMJIDAM(BENLBCJOMLF NDEFPJDAEEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x61B7250", Offset = "0x61B5A50", VA = "0x1861B7250", Slot = "8")]
	public LDGADANDBIO ODGJJHFNDHJ(string NKNGDPCMDDJ, string DBFMGFAPCKH, [Optional] CPAODMCDMNF ECEIHHEEHNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x61B6A30", Offset = "0x61B5230", VA = "0x1861B6A30", Slot = "10")]
	public LDGADANDBIO DIIHNIHDAMN(CPAODMCDMNF ECEIHHEEHNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x61B70A0", Offset = "0x61B58A0", VA = "0x1861B70A0", Slot = "11")]
	public LDGADANDBIO LDFBKLJEMCF(CPAODMCDMNF ECEIHHEEHNP, Dictionary<string, string> LCGDJOEOINE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x61B7530", Offset = "0x61B5D30", VA = "0x1861B7530", Slot = "12")]
	public bool PKNLLPHBOKO(string ADNEAFPEAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x61B7000", Offset = "0x61B5800", VA = "0x1861B7000", Slot = "13")]
	public GNAOLMDHMGB LBKCGPGONID(string HFGILEGILPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x61B6CD0", Offset = "0x61B54D0", VA = "0x1861B6CD0", Slot = "14")]
	public NHEIFGGFHEL GMOGCMLDMLB(string CIEDACDCOCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x61B6E70", Offset = "0x61B5670", VA = "0x1861B6E70", Slot = "15")]
	public GNAOLMDHMGB ICMGKCJIFPL(string DGKGCGGHIBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x61B6B30", Offset = "0x61B5330", VA = "0x1861B6B30", Slot = "16")]
	public LDGADANDBIO EGMACIDIIDM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x1053580", Offset = "0x1051D80", VA = "0x181053580")]
	[CompilerGenerated]
	private void GMFJMNAEADF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x10BC150", Offset = "0x10BA950", VA = "0x1810BC150")]
	[CompilerGenerated]
	private void OLMOCABGIPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class KOHINJBKFFM : MIJGMBFDPDO
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool MMIMOGPFBMH
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6F6020", Offset = "0x6F4820", VA = "0x1806F6020", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action NIOKGPCGCGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x61B4D90", Offset = "0x61B3590", VA = "0x1861B4D90", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x61B5030", Offset = "0x61B3830", VA = "0x1861B5030", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action GKEKMCBEJKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x61B4E40", Offset = "0x61B3640", VA = "0x1861B4E40", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x61B4EF0", Offset = "0x61B36F0", VA = "0x1861B4EF0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x61B50D0", Offset = "0x61B38D0", VA = "0x1861B50D0", Slot = "8")]
	public LDGADANDBIO ODGJJHFNDHJ(string NKNGDPCMDDJ, string DBFMGFAPCKH, [Optional] CPAODMCDMNF ECEIHHEEHNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x61B4C50", Offset = "0x61B3450", VA = "0x1861B4C50", Slot = "10")]
	public LDGADANDBIO DIIHNIHDAMN(CPAODMCDMNF ECEIHHEEHNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x61B4F90", Offset = "0x61B3790", VA = "0x1861B4F90", Slot = "11")]
	public LDGADANDBIO LDFBKLJEMCF(CPAODMCDMNF ECEIHHEEHNP, Dictionary<string, string> LCGDJOEOINE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6D8D00", Offset = "0x6D7500", VA = "0x1806D8D00", Slot = "12")]
	public bool PKNLLPHBOKO(string ADNEAFPEAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x61B4EE0", Offset = "0x61B36E0", VA = "0x1861B4EE0", Slot = "13")]
	public GNAOLMDHMGB LBKCGPGONID(string HFGILEGILPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x61B4E30", Offset = "0x61B3630", VA = "0x1861B4E30", Slot = "14")]
	public NHEIFGGFHEL GMOGCMLDMLB(string CIEDACDCOCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x61B4EE0", Offset = "0x61B36E0", VA = "0x1861B4EE0", Slot = "15")]
	public GNAOLMDHMGB ICMGKCJIFPL(string DGKGCGGHIBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x61B4CF0", Offset = "0x61B34F0", VA = "0x1861B4CF0", Slot = "16")]
	public LDGADANDBIO EGMACIDIIDM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public KOHINJBKFFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface BGGOJBJPOGM
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NAEKCKEIHHM JCOOEJOFKNJ(string JJOPLLBFOOP);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface CGJGFNPNNOI
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DGJKGMKCMBH(string CDBJCAAPIOD, string DDNGKBLMDEK, string HEGJJEECCNG);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NJFOJKNGOHE(string CDBJCAAPIOD);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ANDPBHCOPFK(string CDBJCAAPIOD, string EKANIELAHJG, string AFFAKMKHDLP);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KJBJAKNEEKO(string MNPEFBDEFJK, object AKBJFIDFFAN, object PJOIMJCEBDK);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DIECHIANPHE(long DDDLKCBFDIO, bool ENPMMEGHPNC = true);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface CPAODMCDMNF
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool KCBOPCPHEDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool GCNCOCOIFCK
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool OAJABAPBFFO
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool OCCCBBKOCAK
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool? DNLMOBJBIEH
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	int? CCOJJABGIOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	int ABDDOONPJCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	string FNFMGPAAOOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	string OLNNHFCEAJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	string NGOAJHHLLCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	string KGJGDKONNLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	string DFCBKGOMLKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	string EGIJOKGGGMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	double EJHNFLAJIPP
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
		public AmplitudeAnalyticsClient.Settings EEFPHEKDHBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool HNBBJDBHIPE
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x6F03D0", Offset = "0x6EEBD0", VA = "0x1806F03D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xE06850", Offset = "0xE05050", VA = "0x180E06850")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		private enum DCIMPKIDPPM
		{
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		internal class AGKCMOPDFEG
		{
			[Cpp2IlInjected.Token(Token = "0x2000014")]
			private class GLBAAMHENPD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000074")]
				public int BBFKOKCNCGO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000075")]
				public Dictionary<string, object> MGOLEPEDFAG;

				[Cpp2IlInjected.Token(Token = "0x60000B6")]
				[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
				public GLBAAMHENPD()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000015")]
			[CompilerGenerated]
			private sealed class KEEJOAAJEPE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000076")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x60000B7")]
				[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
				public KEEJOAAJEPE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000B8")]
				[Cpp2IlInjected.Address(RVA = "0x61B4910", Offset = "0x61B3110", VA = "0x1861B4910")]
				internal bool <GetBatch>b__0(GLBAAMHENPD item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000071")]
			private const string KLJLMBIEOCA = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			private readonly string EKLHOMDDPCF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private List<GLBAAMHENPD> JKLNJNHDGKD;

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			public int? EMBOOEMDAHK
			{
				[Cpp2IlInjected.Token(Token = "0x60000AA")]
				[Cpp2IlInjected.Address(RVA = "0x61AA3C0", Offset = "0x61A8BC0", VA = "0x1861AA3C0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			public int? BAFPHBGGLFN
			{
				[Cpp2IlInjected.Token(Token = "0x60000AB")]
				[Cpp2IlInjected.Address(RVA = "0x61AA0B0", Offset = "0x61A88B0", VA = "0x1861AA0B0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x61AAE60", Offset = "0x61A9660", VA = "0x1861AAE60")]
			internal AGKCMOPDFEG(string CIMLIFPBMIM, string DBFMGFAPCKH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x61A9F20", Offset = "0x61A8720", VA = "0x1861A9F20")]
			public int CGAABHBMALJ([Optional] int? IDHEDLDPOJA)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x61AA5F0", Offset = "0x61A8DF0", VA = "0x1861AA5F0")]
			public List<Dictionary<string, object>> OOBAHAFPLAO(int GCGJHOBGDGP, int? IDHEDLDPOJA)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x61A9AD0", Offset = "0x61A82D0", VA = "0x1861A9AD0")]
			public void ADPFKEJNPII(AmplitudeAnalyticsIdentifyMessage BFHAMCLNCKB, bool OPBCPLIHJON = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x61A99C0", Offset = "0x61A81C0", VA = "0x1861A99C0")]
			public void ADPFKEJNPII(Dictionary<string, object> BFHAMCLNCKB, bool OPBCPLIHJON = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x61AA460", Offset = "0x61A8C60", VA = "0x1861AA460")]
			public void KIBIHJLLGGC(params Dictionary<string, object>[] IGIKOAJFHGP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x61AA170", Offset = "0x61A8970", VA = "0x1861AA170")]
			public void EKEHDFPMMBF(List<Dictionary<string, object>> GEENKOKKJNE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x61A9DE0", Offset = "0x61A85E0", VA = "0x1861A9DE0")]
			private void BLFFCNGMCGN(Dictionary<string, object> BFHAMCLNCKB, bool OPBCPLIHJON = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x61A9B70", Offset = "0x61A8370", VA = "0x1861A9B70")]
			public void BDBIMGGMAKJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x61AA880", Offset = "0x61A9080", VA = "0x1861AA880")]
			private void OOBPLMJIBAD([Optional] string JJGBHBLGMNG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x61AAD30", Offset = "0x61A9530", VA = "0x1861AAD30")]
			private static string PGHBBNPDBJH(string NPHADDCNBHE, string NHBANLNJEIH)
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
			[Cpp2IlInjected.Address(RVA = "0x61B80B0", Offset = "0x61B68B0", VA = "0x1861B80B0")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public struct JFEPJMFLFIA<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public int DKOGJICFAEP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public string LCFOKADNGEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public T MDGNBBPPPGH;
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class IMBNKJFOLIP : IEnumerator<MBIPJOOACNE>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private MBIPJOOACNE <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			private MBIPJOOACNE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000C2")]
				[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x6D9200", Offset = "0x6D7A00", VA = "0x1806D9200")]
			[DebuggerHidden]
			public IMBNKJFOLIP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x61B41B0", Offset = "0x61B29B0", VA = "0x1861B41B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x61B47A0", Offset = "0x61B2FA0", VA = "0x1861B47A0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class JHCKCGFAKCB : IEnumerator<object>, IEnumerator, IDisposable
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
			public MAMJDBJDFAF quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000C8")]
				[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x6D9200", Offset = "0x6D7A00", VA = "0x1806D9200")]
			[DebuggerHidden]
			public JHCKCGFAKCB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x61B47E0", Offset = "0x61B2FE0", VA = "0x1861B47E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x61B48D0", Offset = "0x61B30D0", VA = "0x1861B48D0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class HJNFDCCFMEJ : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x6D9200", Offset = "0x6D7A00", VA = "0x1806D9200")]
			[DebuggerHidden]
			public HJNFDCCFMEJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x61B4000", Offset = "0x61B2800", VA = "0x1861B4000", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x61B4170", Offset = "0x61B2970", VA = "0x1861B4170", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class KEIFBLLAAEJ : IEnumerator<MBIPJOOACNE>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private MBIPJOOACNE <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			private MBIPJOOACNE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000D4")]
				[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x6D9200", Offset = "0x6D7A00", VA = "0x1806D9200")]
			[DebuggerHidden]
			public KEIFBLLAAEJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x61B4970", Offset = "0x61B3170", VA = "0x1861B4970", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x61B4C10", Offset = "0x61B3410", VA = "0x1861B4C10", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class NJIOMCKAKMJ : IEnumerator<MBIPJOOACNE>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			private MBIPJOOACNE <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			private MBIPJOOACNE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000DD")]
				[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x6D9200", Offset = "0x6D7A00", VA = "0x1806D9200")]
			[DebuggerHidden]
			public NJIOMCKAKMJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x61B6650", Offset = "0x61B4E50", VA = "0x1861B6650", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x61B68F0", Offset = "0x61B50F0", VA = "0x1861B68F0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class BPABJLEIGAN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public List<Dictionary<string, object>> batch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public AGKCMOPDFEG cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
			public BPABJLEIGAN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x61B1600", Offset = "0x61AFE00", VA = "0x1861B1600")]
			internal void <FlushFromCache>b__0(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x61B1970", Offset = "0x61B0170", VA = "0x1861B1970")]
			internal void <FlushFromCache>b__1(JFEPJMFLFIA<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class MNEBODHBEON : IEnumerator<MBIPJOOACNE>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			private MBIPJOOACNE <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public AGKCMOPDFEG cache;

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
			private BPABJLEIGAN <>8__1;

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
			private MBIPJOOACNE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000E6")]
				[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x6D9200", Offset = "0x6D7A00", VA = "0x1806D9200")]
			[DebuggerHidden]
			public MNEBODHBEON(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x61B5800", Offset = "0x61B4000", VA = "0x1861B5800", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x61B60D0", Offset = "0x61B48D0", VA = "0x1861B60D0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[CompilerGenerated]
		private sealed class PHGBOFCIIDF<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x1063840", Offset = "0x1062040", VA = "0x181063840")]
			public PHGBOFCIIDF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x2E9D390", Offset = "0x2E9BB90", VA = "0x182E9D390")]
			internal JFEPJMFLFIA<T> <PostRudderStackJson>b__0(INHFMFOGBLF postResponse)
			{
				return default(JFEPJMFLFIA<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class ANACJAEMEKP<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x1063840", Offset = "0x1062040", VA = "0x181063840")]
			public ANACJAEMEKP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x2E9D390", Offset = "0x2E9BB90", VA = "0x182E9D390")]
			internal JFEPJMFLFIA<T> <PostAmplitudeJson>b__0(INHFMFOGBLF postResponse)
			{
				return default(JFEPJMFLFIA<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private GCIJEEDBMMC MPKKCPCHGPH;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private const string NDGADPFAGHM = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private const string MEICLNLFDPJ = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private const string GMNFCEPACDH = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private const int EKFFADOBGJF = 15;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private const int OFMDMAIBFPK = 10;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private const int JDPPAKKLJHO = 5;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private const float FAFEPOCDELH = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private const long CNGDGOHDOGO = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private const string FHPAECFLPEN = "f1779b982f1c09aed3adb3cca563cbc2";

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private const string BONIOKBKLNB = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private static bool JBHEEHEBNGL;

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private static bool MEIGLAMOPBG;

		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private static int CJACDCGFMGM;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static int LFBLMFFJNFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private NIBCCLFGFKK IGKOLHOKHIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private bool HNLADKDHOBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private float BLDOLBABIHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private float LPBKABJHJDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private int OBFOIONDIEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private int CFHOKEKBNKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private int? ALJBKAMICKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private int? MCONOAIJHPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private long MNLAKKOILBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private string GHGBMGCBBBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private long FFCHPBENJNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private Dictionary<string, object> GFNMFEHCICO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private DCIMPKIDPPM OJONNDMLKDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private int BJADELBPCEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private int IOGPKCIHMPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private float COBCAFALGDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private bool IICDCHDGOCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x89")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private bool GKOFBMFIFJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private AGKCMOPDFEG LEOMOLGLEMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private AGKCMOPDFEG BJHKNFMDDMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private AGKCMOPDFEG MEMHKAFLPDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> PKPKBKAAMPH;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo IICBCBEHIBH;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static string HHENMKFLLCG;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private const string HLGDNHMODOM = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly string JOIMFBELJDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private readonly string APLDFGHMBCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private readonly string OGANAFHCFGF;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private GCIJEEDBMMC BHIGNKJFEKL
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x61ABB10", Offset = "0x61AA310", VA = "0x1861ABB10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private static int HFMBDOJOCMF
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x61AD910", Offset = "0x61AC110", VA = "0x1861AD910")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static long OIFAPCLGJHH
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x61AFF70", Offset = "0x61AE770", VA = "0x1861AFF70")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x61B0070", Offset = "0x61AE870", VA = "0x1861B0070")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static string DFAIFLCOBIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x61AFF10", Offset = "0x61AE710", VA = "0x1861AFF10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public static string KOKCGNFEFJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x61AFF40", Offset = "0x61AE740", VA = "0x1861AFF40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public string DGIMPFPLEEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x6EB740", Offset = "0x6E9F40", VA = "0x1806EB740")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x70CDC0", Offset = "0x70B5C0", VA = "0x18070CDC0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public int? CCOJJABGIOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x805840", Offset = "0x804040", VA = "0x180805840")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x16F6450", Offset = "0x16F4C50", VA = "0x1816F6450")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool MBDOFLGHBBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x84E820", Offset = "0x84D020", VA = "0x18084E820")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x84E920", Offset = "0x84D120", VA = "0x18084E920")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public static bool EHDFDEECHJG
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x61AFE20", Offset = "0x61AE620", VA = "0x1861AFE20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<bool> HMGGMLEJLIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x61AFD80", Offset = "0x61AE580", VA = "0x1861AFD80")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x61AFFD0", Offset = "0x61AE7D0", VA = "0x1861AFFD0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x61AB190", Offset = "0x61A9990", VA = "0x1861AB190", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x61ADC10", Offset = "0x61AC410", VA = "0x1861ADC10")]
		private void PKMCFHFGCJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x61AF5D0", Offset = "0x61ADDD0", VA = "0x1861AF5D0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x61AD870", Offset = "0x61AC070", VA = "0x1861AD870", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x61AF8C0", Offset = "0x61AE0C0", VA = "0x1861AF8C0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x61AEC30", Offset = "0x61AD430", VA = "0x1861AEC30")]
		public LDGADANDBIO PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x61AC690", Offset = "0x61AAE90", VA = "0x1861AC690")]
		[IteratorStateMachine(typeof(IMBNKJFOLIP))]
		public IEnumerator<MBIPJOOACNE> Initialize(AmplitudeAnalyticsEvent DGICGAMNLIH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x61AF7B0", Offset = "0x61ADFB0", VA = "0x1861AF7B0")]
		public void UpdateLastAliveTime(float JJJELGCEOLG = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x61AC9C0", Offset = "0x61AB1C0", VA = "0x1861AC9C0")]
		private LDGADANDBIO KBIFHADAFJE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x61AC720", Offset = "0x61AAF20", VA = "0x1861AC720")]
		private LDGADANDBIO JOCJCKODHHH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x61AF180", Offset = "0x61AD980", VA = "0x1861AF180")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x61ACA90", Offset = "0x61AB290", VA = "0x1861ACA90")]
		[IteratorStateMachine(typeof(JHCKCGFAKCB))]
		private IEnumerator LNPNDNFAHBO(MAMJDBJDFAF NBGCNBOMKBO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x61AFB30", Offset = "0x61AE330", VA = "0x1861AFB30")]
		[IteratorStateMachine(typeof(HJNFDCCFMEJ))]
		public IEnumerator WaitForFlush(float NCNCMLGEIJM = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x61AF690", Offset = "0x61ADE90", VA = "0x1861AF690")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x61AF5E0", Offset = "0x61ADDE0", VA = "0x1861AF5E0")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime ILJBLEGFDIO)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x61AC2E0", Offset = "0x61AAAE0", VA = "0x1861AC2E0")]
		public static GCDIADLEBEA Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x61AAFF0", Offset = "0x61A97F0", VA = "0x1861AAFF0")]
		public static MDGNKBGFGLD AccountSelectionPostLoginEvent([NotNull] string ABCOABJMCFC, string MMNFIHMFIGD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x61AB910", Offset = "0x61AA110", VA = "0x1861AB910")]
		public static MDGNKBGFGLD Event([NotNull] string ABCOABJMCFC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x61AEC90", Offset = "0x61AD490", VA = "0x1861AEC90")]
		public static MDGNKBGFGLD PreviousSessionEvent([NotNull] string ABCOABJMCFC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x61AC440", Offset = "0x61AAC40", VA = "0x1861AC440")]
		public static MDGNKBGFGLD InitializeEvent(string MMNFIHMFIGD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x61AF2E0", Offset = "0x61ADAE0", VA = "0x1861AF2E0")]
		public static MDGNKBGFGLD StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x61AB500", Offset = "0x61A9D00", VA = "0x1861AB500")]
		public static MDGNKBGFGLD CreateOutOfSessionEvent(string ABCOABJMCFC, bool LEJGIMCMKOP = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x61ACDE0", Offset = "0x61AB5E0", VA = "0x1861ACDE0")]
		public static LDGADANDBIO LogOutOfSessionEvent(MDGNKBGFGLD GAJIEBBKIFH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x61ACB20", Offset = "0x61AB320", VA = "0x1861ACB20")]
		public void LogEventAsync(AmplitudeAnalyticsEvent JABDGMEHCBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x61AD0F0", Offset = "0x61AB8F0", VA = "0x1861AD0F0")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent JABDGMEHCBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x61AD240", Offset = "0x61ABA40", VA = "0x1861AD240")]
		public void LogSerializedEventAsync(Dictionary<string, object> CJNDPKKHEGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x61ACC70", Offset = "0x61AB470", VA = "0x1861ACC70")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage CIIPACAHBIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x61ADAE0", Offset = "0x61AC2E0", VA = "0x1861ADAE0")]
		private void PEDIFDJHNOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x61AD5E0", Offset = "0x61ABDE0", VA = "0x1861AD5E0")]
		private void OLBKEAJNMIC(Dictionary<string, object> CKDDIDABPBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x61ABC10", Offset = "0x61AA410", VA = "0x1861ABC10")]
		private void GJMHONPGEDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x61ABD00", Offset = "0x61AA500", VA = "0x1861ABD00")]
		private void HPGDODCNLPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x61ABB80", Offset = "0x61AA380", VA = "0x1861ABB80")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x61AB480", Offset = "0x61A9C80", VA = "0x1861AB480")]
		[IteratorStateMachine(typeof(KEIFBLLAAEJ))]
		private IEnumerator<MBIPJOOACNE> BEAKJOLNACL(float NCNCMLGEIJM = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x61AD480", Offset = "0x61ABC80", VA = "0x1861AD480")]
		[IteratorStateMachine(typeof(NJIOMCKAKMJ))]
		private IEnumerator<MBIPJOOACNE> OBLHDDDBJLB(float NCNCMLGEIJM = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x61AD500", Offset = "0x61ABD00", VA = "0x1861AD500")]
		[IteratorStateMachine(typeof(MNEBODHBEON))]
		private IEnumerator<MBIPJOOACNE> OFGKFIBKIAP(AGKCMOPDFEG KOOFLAHMFBG, int? IDHEDLDPOJA, string GBBDKECOGDK, string POCENBDLFEO, float NCNCMLGEIJM, Action<int> KMPBCFMODHA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x61AB7E0", Offset = "0x61A9FE0", VA = "0x1861AB7E0")]
		private static void EBAPADNNIFO(bool ADADHONDCOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x61AC1B0", Offset = "0x61AA9B0", VA = "0x1861AC1B0")]
		private global::FGLDKEJLAKB<JFEPJMFLFIA<Dictionary<string, object>>> ICEKFOBBIGH(string GBBDKECOGDK, string POCENBDLFEO, string BFEBGFJPFPL, string LFLBGOHMPCD, Dictionary<string, object> MDGNBBPPPGH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x61ABEE0", Offset = "0x61AA6E0", VA = "0x1861ABEE0")]
		private global::FGLDKEJLAKB<JFEPJMFLFIA<List<Dictionary<string, object>>>> ICEKFOBBIGH(string GBBDKECOGDK, string POCENBDLFEO, string BFEBGFJPFPL, string LFLBGOHMPCD, List<Dictionary<string, object>> MDGNBBPPPGH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x346D960", Offset = "0x346C160", VA = "0x18346D960")]
		private global::FGLDKEJLAKB<JFEPJMFLFIA<T>> LPADAKBOEAD<T>(string GBBDKECOGDK, string POCENBDLFEO, string LFLBGOHMPCD, T MDGNBBPPPGH, Dictionary<string, object> KFPIMHOIDHI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x346D620", Offset = "0x346BE20", VA = "0x18346D620")]
		private global::FGLDKEJLAKB<JFEPJMFLFIA<T>> HEJLLIEFGAE<T>(string GBBDKECOGDK, string POCENBDLFEO, string BFEBGFJPFPL, T MDGNBBPPPGH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x61ADBC0", Offset = "0x61AC3C0", VA = "0x1861ADBC0")]
		private bool PIOLKBHKOAG(float DMNOELPOJOF, float NCNCMLGEIJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x61ADF30", Offset = "0x61AC730", VA = "0x1861ADF30")]
		private Dictionary<string, object> PONHGLOIDKI(string POCENBDLFEO, Dictionary<string, object> MDGNBBPPPGH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x61AFC10", Offset = "0x61AE410", VA = "0x1861AFC10")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x61AD320", Offset = "0x61ABB20", VA = "0x1861AD320")]
		[CompilerGenerated]
		private long NDJECMMPMBC()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x61AB900", Offset = "0x61AA100", VA = "0x1861AB900")]
		[CompilerGenerated]
		private void EJMHBDAOAAO(int BPGHPDAKJHH)
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
			[Cpp2IlInjected.Address(RVA = "0x61B0C40", Offset = "0x61AF440", VA = "0x1861B0C40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x61B0CA0", Offset = "0x61AF4A0", VA = "0x1861B0CA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x6EB780", Offset = "0x6E9F80", VA = "0x1806EB780")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x61B07E0", Offset = "0x61AEFE0", VA = "0x1861B07E0")]
		public static MDGNKBGFGLD OJONNLHFKNA(string OGPINCOPHCL, [NotNull] string AKDHPBGHKBH, long DDDLKCBFDIO, long KFBJCHFPGLB, string MMNFIHMFIGD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x61B06E0", Offset = "0x61AEEE0", VA = "0x1861B06E0")]
		public static MDGNKBGFGLD MKPAGNMEKLC(string OGPINCOPHCL, [NotNull] string AKDHPBGHKBH, long DDDLKCBFDIO, long KFBJCHFPGLB, string MMNFIHMFIGD, long FDEMCPOFMIN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x61B0A80", Offset = "0x61AF280", VA = "0x1861B0A80")]
		private AmplitudeAnalyticsEvent(string OGPINCOPHCL, [NotNull] string AKDHPBGHKBH, long DDDLKCBFDIO, long KFBJCHFPGLB, string MMNFIHMFIGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x914FD0", Offset = "0x9137D0", VA = "0x180914FD0")]
		public void BBJLJOGILMK(long KEDDPBLIAEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x61B05C0", Offset = "0x61AEDC0", VA = "0x1861B05C0", Slot = "5")]
		public override void IANNAIAFJII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x61B08D0", Offset = "0x61AF0D0", VA = "0x1861B08D0", Slot = "6")]
		public override void PBBKFBGHPNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x61B00D0", Offset = "0x61AE8D0", VA = "0x1861B00D0", Slot = "4")]
		protected override Dictionary<string, object> EOFCJMHBPCB(Dictionary<string, object> NDEOJKAIKHM)
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
			[Cpp2IlInjected.Address(RVA = "0x61B2020", Offset = "0x61B0820", VA = "0x1861B2020")]
			public void HJDPEILJDNJ(Dictionary<string, object> HAEFBGLABEB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x61B7CF0", Offset = "0x61B64F0", VA = "0x1861B7CF0")]
			public void HJDPEILJDNJ(Dictionary<string, object> KIOKMFMICID)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x10DC400", Offset = "0x10DAC00", VA = "0x1810DC400")]
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
			[Cpp2IlInjected.Address(RVA = "0x6D6AC0", Offset = "0x6D52C0", VA = "0x1806D6AC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x6F5130", Offset = "0x6F3930", VA = "0x1806F5130")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x61B1260", Offset = "0x61AFA60", VA = "0x1861B1260")]
		public static GCDIADLEBEA OJONNLHFKNA(string OGPINCOPHCL, string MMNFIHMFIGD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x61B1390", Offset = "0x61AFB90", VA = "0x1861B1390")]
		protected AmplitudeAnalyticsIdentifyMessage(string OGPINCOPHCL, string MMNFIHMFIGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x61B0D10", Offset = "0x61AF510", VA = "0x1861B0D10")]
		public Dictionary<string, object> DFGDOFLGBCN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x61B0D90", Offset = "0x61AF590", VA = "0x1861B0D90", Slot = "4")]
		protected virtual Dictionary<string, object> EOFCJMHBPCB(Dictionary<string, object> NDEOJKAIKHM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x61B11C0", Offset = "0x61AF9C0", VA = "0x1861B11C0")]
		protected void MDLEIPDLHKF(string NHBANLNJEIH, Dictionary<string, object> GPLIGPIKCNO, Dictionary<string, object> CFOMNHCMFJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x61B10D0", Offset = "0x61AF8D0", VA = "0x1861B10D0")]
		protected void FOCHEKOMNOG(string NHBANLNJEIH, string NPHADDCNBHE, Dictionary<string, object> FBJCBJAIECF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x61B1140", Offset = "0x61AF940", VA = "0x1861B1140", Slot = "5")]
		public virtual void IANNAIAFJII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x61B1310", Offset = "0x61AFB10", VA = "0x1861B1310", Slot = "6")]
		public virtual void PBBKFBGHPNI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class GCDIADLEBEA : global::GGGKDFFECBO<AmplitudeAnalyticsIdentifyMessage, GCDIADLEBEA>
{
	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public override GCDIADLEBEA NFKKILPNLNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7F3E20", Offset = "0x7F2620", VA = "0x1807F3E20", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6D6AC0", Offset = "0x6D52C0", VA = "0x1806D6AC0", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage FGHNOKLDOKO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x61B2240", Offset = "0x61B0A40", VA = "0x1861B2240")]
	public GCDIADLEBEA(AmplitudeAnalyticsIdentifyMessage EPAIMCEIMPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x61B21A0", Offset = "0x61B09A0", VA = "0x1861B21A0", Slot = "4")]
	public override void PBBKFBGHPNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class MDGNKBGFGLD : global::GGGKDFFECBO<AmplitudeAnalyticsEvent, MDGNKBGFGLD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private bool EBAECEMKMNN;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public override MDGNKBGFGLD NFKKILPNLNO
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x7F3E20", Offset = "0x7F2620", VA = "0x1807F3E20", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public long OHHGCJJGKJE
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x61B5170", Offset = "0x61B3970", VA = "0x1861B5170")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x61B1FD0", Offset = "0x61B07D0", VA = "0x1861B1FD0")]
	public MDGNKBGFGLD(AmplitudeAnalyticsEvent EPAIMCEIMPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6D6AC0", Offset = "0x6D52C0", VA = "0x1806D6AC0", Slot = "5")]
	public override AmplitudeAnalyticsEvent FGHNOKLDOKO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x61B5760", Offset = "0x61B3F60", VA = "0x1861B5760", Slot = "4")]
	public override void PBBKFBGHPNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x61B53C0", Offset = "0x61B3BC0", VA = "0x1861B53C0")]
	public MDGNKBGFGLD MBFFDAJNCCM(string NPCKPCNEDPB, long[] NPHADDCNBHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x61B5500", Offset = "0x61B3D00", VA = "0x1861B5500")]
	public MDGNKBGFGLD MBFFDAJNCCM(string NPCKPCNEDPB, ulong[] NPHADDCNBHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x24F6DB0", Offset = "0x24F55B0", VA = "0x1824F6DB0")]
	public MDGNKBGFGLD MBFFDAJNCCM<T>(string NPCKPCNEDPB, T[] NPHADDCNBHE) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x61B53B0", Offset = "0x61B3BB0", VA = "0x1861B53B0")]
	public MDGNKBGFGLD MBFFDAJNCCM(string NPCKPCNEDPB, string[] NPHADDCNBHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x24F6D40", Offset = "0x24F5540", VA = "0x1824F6D40")]
	public MDGNKBGFGLD MBFFDAJNCCM<T>(string NPCKPCNEDPB, T NPHADDCNBHE) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x61B56D0", Offset = "0x61B3ED0", VA = "0x1861B56D0")]
	public MDGNKBGFGLD MBFFDAJNCCM(string NPCKPCNEDPB, long NPHADDCNBHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x61B5640", Offset = "0x61B3E40", VA = "0x1861B5640")]
	public MDGNKBGFGLD MBFFDAJNCCM(string NPCKPCNEDPB, ulong NPHADDCNBHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x61B5340", Offset = "0x61B3B40", VA = "0x1861B5340")]
	public MDGNKBGFGLD MBFFDAJNCCM(string NPCKPCNEDPB, string NPHADDCNBHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x61B5320", Offset = "0x61B3B20", VA = "0x1861B5320")]
	public MDGNKBGFGLD JGHODLBJEAE(string NPCKPCNEDPB, object? NPHADDCNBHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x61B5280", Offset = "0x61B3A80", VA = "0x1861B5280")]
	public MDGNKBGFGLD DIEDEHDGMKF(string NPCKPCNEDPB, string NPHADDCNBHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x61B5190", Offset = "0x61B3990", VA = "0x1861B5190")]
	private MDGNKBGFGLD CHKANENJBBF(string NPCKPCNEDPB, object NPHADDCNBHE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class DFIPPNECFCL : MDGNKBGFGLD
{
	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x61B1FD0", Offset = "0x61B07D0", VA = "0x1861B1FD0")]
	public DFIPPNECFCL(AmplitudeAnalyticsEvent EPAIMCEIMPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x61B1E10", Offset = "0x61B0610", VA = "0x1861B1E10", Slot = "4")]
	public override void PBBKFBGHPNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public abstract class GGGKDFFECBO<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : global::GGGKDFFECBO<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	protected M EPAIMCEIMPA;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public abstract BLDR NFKKILPNLNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x1C56F20", Offset = "0x1C55720", VA = "0x181C56F20")]
	public GGGKDFFECBO(M EPAIMCEIMPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x272C8F0", Offset = "0x272B0F0", VA = "0x18272C8F0")]
	public BLDR BLLIJHMDNCL(AmplitudeAnalyticsIdentifyMessage.DeviceInfo EGMMGBKCLAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x272CC20", Offset = "0x272B420", VA = "0x18272CC20")]
	public BLDR JAKDABJBMKO(AmplitudeAnalyticsIdentifyMessage.RevenueData GMBLDJIGEHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x272CBB0", Offset = "0x272B3B0", VA = "0x18272CBB0")]
	public BLDR GPIMAHLMLCF(string NPCKPCNEDPB, string NPHADDCNBHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x2A65E70", Offset = "0x2A64670", VA = "0x182A65E70")]
	public BLDR GPIMAHLMLCF<T>(string NPCKPCNEDPB, T NPHADDCNBHE) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x272CA50", Offset = "0x272B250", VA = "0x18272CA50")]
	public BLDR GPIMAHLMLCF(string NPCKPCNEDPB, long NPHADDCNBHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x272CB00", Offset = "0x272B300", VA = "0x18272CB00")]
	public BLDR GPIMAHLMLCF(string NPCKPCNEDPB, ulong NPHADDCNBHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void PBBKFBGHPNI();

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x272C930", Offset = "0x272B130", VA = "0x18272C930")]
	internal static string COAEHLHKHGH(string NPHADDCNBHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x272C960", Offset = "0x272B160", VA = "0x18272C960")]
	private BLDR DAOCDMPLFIB(string NPCKPCNEDPB, object NPHADDCNBHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M FGHNOKLDOKO();
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class ACHDBOGIBPA
{
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public const string PALNICIHIBG = "batch";

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public const string CKDIPBIFJNN = "type";

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public const string PKDHIBIJFGJ = "identify";

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public const string CDAGNFNDBNK = "track";

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public const string MGLCNDFLHID = "userId";

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public const string LCFNEHGFCNM = "anonymousId";

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public const string NAOBKIHKEGJ = "messageId";

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public const string NGPLCKFDFEO = "event";

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public const string ILABPLOBKEB = "version";

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public const string LPIAKPOKKLB = "locale";

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public const string MFFBODGDCEL = "name";

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public const string BPFOBHJHNPD = "properties";

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public const string LOPKEHFGPCG = "traits";

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public const string ANPAHCEIPGI = "context";

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public const string CJANMFFAFKE = "app";

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public const string JADPKEDDFOI = "os";

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public const string JDNNFHGINLP = "device";

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public const string PEFHNKGODAD = "originalTimestamp";

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public const string GNJHFLOOLGJ = "brand";

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public const string JCPPNPPHJEG = "manufacturer";

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public const string DOPDJDFNIPL = "model";

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public const string MBPPJGMFFAF = "type";

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public ACHDBOGIBPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class BIDDNEFOIJD
{
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public const int KDOKJLBMJCI = 2;

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public const int GJKKBFFNKOH = 100;

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public const int LCLFNNIOBDK = 1000;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public const long LDNIICALLKE = 1800000L;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public const int DHHGOIGDBOM = 1024;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public const int JGLEOLLPIJM = 1000;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public const string MNABOLLJMFM = "amplitude_sequence_number";

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public const string KGBHLNJNFLC = "amplitude_user_id";

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public const string AAJOHDDMPID = "amplitude_last_time";

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public const string PBAPPECHLOB = "initialize_analytics";

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public const string NIAMODGJFEI = "session_start";

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public const string DHKEDDKGBKH = "session_end";

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public const string KLDBOHNILCF = "insert_id";

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public const string LOOAFOLCMIC = "event_time";

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public const string GLDNJNHBMKI = "session_id";

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public const string KEBIJLKAOKH = "session_tracking_data";

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public const string KAJDNIDKLLE = "user_properties";

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public const string AJNCBGFINDI = "app_version";

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public const string GNBBOPIAEMA = "ip";

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public const string OJBILOEHIFC = "language";

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public const string BEILJPOFBLD = "platform";

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public const string PHOCDDEFBME = "os_name";

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public const string NNOJANHGBII = "os_version";

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public const string AKFCNBCGDDP = "device_brand";

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public const string AEOLHALNHHH = "device_manufacturer";

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public const string JODAANHEKGN = "device_model";

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public const string DFKPGIGOFFI = "device_type";

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public const string IINMLCLPHEN = "price";

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public const string IFCIKAHJLHE = "quantity";

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public const string DKNPBDKICME = "revenue";

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public const string JHCNOLKKILB = "productId";

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public const string LGNFGBHKJLJ = "revenueType";

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public const string HEDNPOIHPLE = "event_type";

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public const string MGLCNDFLHID = "user_id";

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public const string NHPMKDNNJNP = "event_properties";

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public const int FCNIDCCCGJL = 10;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> ECBOMBCCCJO;

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x61B1450", Offset = "0x61AFC50", VA = "0x1861B1450")]
	internal static bool PNELDHIHOOF(string NHBANLNJEIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public BIDDNEFOIJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface NIBCCLFGFKK
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool JFMEKEEOFLI
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	string PHIJKBHMBHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	string DKDIOKHPMJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	string MAKJGPBEHCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	string NPAJFLIGEII
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::FGLDKEJLAKB<INHFMFOGBLF> ICEKFOBBIGH(string GBBDKECOGDK, Dictionary<string, string> NCAKPAALFJG, bool LIPIFCACBIJ = false);

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "6")]
	global::FGLDKEJLAKB<INHFMFOGBLF> IJFPGPBCNBN(string GBBDKECOGDK, string OIOLLAMAMNH, string IMHOKIFKEBK, string EHIJLHOIJKC);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct INHFMFOGBLF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public readonly int CBBNBNECKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public readonly string BLNEBIFLPGK;

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x7000B0", Offset = "0x6FE8B0", VA = "0x1807000B0")]
	public INHFMFOGBLF(int DKOGJICFAEP, string LCFOKADNGEN)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class PDJLMBMEBDL
{
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private static byte[] MEBJOHCMOJE;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private static int JLNKJPMHNDA;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static int JMCMMIDKHCA;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static BigInteger PCHDNPNKOJB;

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public PDJLMBMEBDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x61B7A10", Offset = "0x61B6210", VA = "0x1861B7A10")]
	private static string FEOGEGMPIMJ(byte[] JBKIIGINOKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x61B76C0", Offset = "0x61B5EC0", VA = "0x1861B76C0")]
	public static string CIDKAEMCDOH(byte[] EBBNNMNMLOE, bool IGCCOAIPDPG)
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
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
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

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
		[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40")]
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
		[Cpp2IlInjected.Address(RVA = "0x60FADF0", Offset = "0x60F97F0", VA = "0x1860FADF0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6DC6F0", Offset = "0x6DB0F0", VA = "0x1806DC6F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x90B660", Offset = "0x90A060", VA = "0x18090B660")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum APBKFCEHODD
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
public class MDGDPNDIGOE
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private const string DFFDOLKHABJ = "timed_flow";

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private const string NKDNBBNMIDC = "flowName";

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private const string PEELOFKPICJ = "startedAt";

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private const string EDELDIIAHFH = "endedAt";

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private const string NPMLHGNOPCD = "durationInSeconds";

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private const string KGOEPKLOFJD = "failure";

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private const string GPKPHNICPOB = "failureMessage";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private long PHCHFNNEDMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private BJDCAFFNNNE HHLNNIAPHBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private bool FGMFMDEBPGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private float DNMLOAAGLHE;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x60F9460", Offset = "0x60F7E60", VA = "0x1860F9460")]
	public MDGDPNDIGOE(string GDNBABGMIDC, float DNMLOAAGLHE = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2603E10", Offset = "0x2602810", VA = "0x182603E10")]
	public void ICEELEPGJBF<T>(string OPPPBNFKNOC, T MNIAGKNOHEJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x60F9390", Offset = "0x60F7D90", VA = "0x1860F9390")]
	public void ICEELEPGJBF(string OPPPBNFKNOC, string MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x60F90C0", Offset = "0x60F7AC0", VA = "0x1860F90C0")]
	public void CJAGNIJCODD(string DHKFMEJHJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x60F92D0", Offset = "0x60F7CD0", VA = "0x1860F92D0")]
	public void FDJHJJNJNHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x60F91B0", Offset = "0x60F7BB0", VA = "0x1860F91B0")]
	private void CNJCCECECMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x60F9410", Offset = "0x60F7E10", VA = "0x1860F9410")]
	private bool OFAMLLICNBJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface DEHGKBGPCPM
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GPMDAFELAJF JGKFDHOAMGH(string IDAOAMCOLID, string IFMDLBDCIAL, [Optional] FCIEJAHGBCD GMAIIFBNOIM);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GPMDAFELAJF JAGHLAEONDH(FCIEJAHGBCD GMAIIFBNOIM);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GPMDAFELAJF DGPNIJCHNED(FCIEJAHGBCD GMAIIFBNOIM, Dictionary<string, string> BBJEMPFHDLD);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OKGCBMEPJKC(string ELMMMHHMACM);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "4")]
	OOHABFLEHNA JMAHMLAJCME(string MJNDCFPECHN);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "5")]
	LCGFEKEKFFN FOJDHJLGOIO(string FKMFPNHFCLB);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "6")]
	OOHABFLEHNA EBBIOKAJKNA(string MNIPOLLHOLE);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GPMDAFELAJF OKKNIDLOKFM();
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
			[Cpp2IlInjected.Address(RVA = "0x6C2AC0", Offset = "0x6C14C0", VA = "0x1806C2AC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x6C2AC0", Offset = "0x6C14C0", VA = "0x1806C2AC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6C2120", Offset = "0x6C0B20", VA = "0x1806C2120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x60FB2E0", Offset = "0x60F9CE0", VA = "0x1860FB2E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class CGGDNEHMBFH : DEHGKBGPCPM
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private const string CNPEJHDIFBF = "GamePlatform";

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private const string ADGMBJEHMIJ = "InteractionCategory";

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private const string COBKIHAJBDL = "JrActType";

	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private const string OOFHKCJDHFK = "IsDeveloper";

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private const string DMJGPMPKFAA = "IsModerator";

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private const string MHFGNGJKBCL = "IsMember";

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private const string AAAIBMDKIJE = "DaysSinceJoiningBucket";

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private const string HCNHGCGGILH = "AccountCreationTimeAfterEpochMilliseconds";

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private const string MGDHIOEPCFP = "InGoodStanding";

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private const string BGCHCFFOFLF = "FriendCount";

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private const string DKIEOEEDHOC = "LocaleName";

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly IReadOnlyDictionary<string, JPECFFOEOJF> DCGHPEKLNDD;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private const int BHHMDIGBGEK = 5000;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private bool OEOLNLMCABA;

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x60F5540", Offset = "0x60F3F40", VA = "0x1860F5540", Slot = "4")]
	public GPMDAFELAJF JGKFDHOAMGH(string IDAOAMCOLID, string IFMDLBDCIAL, [Optional] FCIEJAHGBCD GMAIIFBNOIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x60F6590", Offset = "0x60F4F90", VA = "0x1860F6590", Slot = "11")]
	public GPMDAFELAJF OKKNIDLOKFM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x60F5390", Offset = "0x60F3D90", VA = "0x1860F5390", Slot = "5")]
	public GPMDAFELAJF JAGHLAEONDH(FCIEJAHGBCD GMAIIFBNOIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x60F4EF0", Offset = "0x60F38F0", VA = "0x1860F4EF0", Slot = "6")]
	public GPMDAFELAJF DGPNIJCHNED(FCIEJAHGBCD GMAIIFBNOIM, Dictionary<string, string> BBJEMPFHDLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x60F64E0", Offset = "0x60F4EE0", VA = "0x1860F64E0", Slot = "7")]
	public bool OKGCBMEPJKC(string ELMMMHHMACM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x60F59E0", Offset = "0x60F43E0", VA = "0x1860F59E0", Slot = "8")]
	public OOHABFLEHNA JMAHMLAJCME(string MJNDCFPECHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x60F52D0", Offset = "0x60F3CD0", VA = "0x1860F52D0", Slot = "9")]
	public LCGFEKEKFFN FOJDHJLGOIO(string FKMFPNHFCLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x60F51E0", Offset = "0x60F3BE0", VA = "0x1860F51E0", Slot = "10")]
	public OOHABFLEHNA EBBIOKAJKNA(string MNIPOLLHOLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x60F5B00", Offset = "0x60F4500", VA = "0x1860F5B00")]
	private LEGNHKPHCJF LAOKBLEOPOK(FCIEJAHGBCD GMAIIFBNOIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x60F6340", Offset = "0x60F4D40", VA = "0x1860F6340")]
	private GBEDPOKBCOP NACGPIJGLKE(string IFMDLBDCIAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x60F60F0", Offset = "0x60F4AF0", VA = "0x1860F60F0")]
	private void LNAJBIKEDJB(string MJNDCFPECHN, OOHABFLEHNA NIFCFEIBHMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public CGGDNEHMBFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x144F6B0", Offset = "0x144E0B0", VA = "0x18144F6B0")]
	[CompilerGenerated]
	private void LEIJLGGAGPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class LIMHICECHGL : DEHGKBGPCPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private DEHGKBGPCPM ABPBAGOHMBI;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private DEHGKBGPCPM GCDBCKCLBIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x60F8EB0", Offset = "0x60F78B0", VA = "0x1860F8EB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	[Preserve]
	public LIMHICECHGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x60F88F0", Offset = "0x60F72F0", VA = "0x1860F88F0")]
	[CJJNALDLMHL(HFKENCJEONK.GameOnly)]
	private static void FCELENDPCOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x60F8BF0", Offset = "0x60F75F0", VA = "0x1860F8BF0", Slot = "4")]
	public GPMDAFELAJF JGKFDHOAMGH(string IDAOAMCOLID, string IFMDLBDCIAL, [Optional] FCIEJAHGBCD GMAIIFBNOIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x60F8AF0", Offset = "0x60F74F0", VA = "0x1860F8AF0", Slot = "5")]
	public GPMDAFELAJF JAGHLAEONDH(FCIEJAHGBCD GMAIIFBNOIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x60F8740", Offset = "0x60F7140", VA = "0x1860F8740", Slot = "6")]
	public GPMDAFELAJF DGPNIJCHNED(FCIEJAHGBCD GMAIIFBNOIM, Dictionary<string, string> BBJEMPFHDLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x60F8F20", Offset = "0x60F7920", VA = "0x1860F8F20", Slot = "7")]
	public bool OKGCBMEPJKC(string ELMMMHHMACM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x60F8E10", Offset = "0x60F7810", VA = "0x1860F8E10", Slot = "8")]
	public OOHABFLEHNA JMAHMLAJCME(string MJNDCFPECHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x60F89F0", Offset = "0x60F73F0", VA = "0x1860F89F0", Slot = "9")]
	public LCGFEKEKFFN FOJDHJLGOIO(string FKMFPNHFCLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x60F8850", Offset = "0x60F7250", VA = "0x1860F8850", Slot = "10")]
	public OOHABFLEHNA EBBIOKAJKNA(string MNIPOLLHOLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x60F8FC0", Offset = "0x60F79C0", VA = "0x1860F8FC0", Slot = "11")]
	public GPMDAFELAJF OKKNIDLOKFM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class OAADGMJOGBA : DEHGKBGPCPM
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x60FAFE0", Offset = "0x60F99E0", VA = "0x1860FAFE0", Slot = "4")]
	public GPMDAFELAJF JGKFDHOAMGH(string IDAOAMCOLID, string IFMDLBDCIAL, [Optional] FCIEJAHGBCD GMAIIFBNOIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x60FAF40", Offset = "0x60F9940", VA = "0x1860FAF40", Slot = "5")]
	public GPMDAFELAJF JAGHLAEONDH(FCIEJAHGBCD GMAIIFBNOIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x60FAE80", Offset = "0x60F9880", VA = "0x1860FAE80", Slot = "6")]
	public GPMDAFELAJF DGPNIJCHNED(FCIEJAHGBCD GMAIIFBNOIM, Dictionary<string, string> BBJEMPFHDLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6C4D00", Offset = "0x6C3700", VA = "0x1806C4D00", Slot = "7")]
	public bool OKGCBMEPJKC(string ELMMMHHMACM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x60FAF20", Offset = "0x60F9920", VA = "0x1860FAF20", Slot = "8")]
	public OOHABFLEHNA JMAHMLAJCME(string MJNDCFPECHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x60FAF30", Offset = "0x60F9930", VA = "0x1860FAF30", Slot = "9")]
	public LCGFEKEKFFN FOJDHJLGOIO(string FKMFPNHFCLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x60FAF20", Offset = "0x60F9920", VA = "0x1860FAF20", Slot = "10")]
	public OOHABFLEHNA EBBIOKAJKNA(string MNIPOLLHOLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x60FB080", Offset = "0x60F9A80", VA = "0x1860FB080", Slot = "11")]
	public GPMDAFELAJF OKKNIDLOKFM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public OAADGMJOGBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface LEMJHBAGJMD
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IsExperimentSegmentActive(string MJNDCFPECHN, string FJOBMKCEOFC, bool HMCDGOMPGEP = true);
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
			[Cpp2IlInjected.Address(RVA = "0x6C2AC0", Offset = "0x6C14C0", VA = "0x1806C2AC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x6C2AC0", Offset = "0x6C14C0", VA = "0x1806C2AC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string ExperimentSegment
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x60FB290", Offset = "0x60F9C90", VA = "0x1860FB290", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public SerializedSplitTestExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface DMNDNJBCGPE
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MDGDPNDIGOE MLOJOLKIFMI(string GDNBABGMIDC);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface NNDNCLOJDHF
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NMLPGIGALBK(string CGFEOLDGFLJ, string EFDBMIAIDIG, string GNPHOEIBMBD);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CAOBCHHGABK(string CGFEOLDGFLJ);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CEPECPMALEI(string CGFEOLDGFLJ, string JEKANADNFPF, string GDHMOEDPIED);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BMODOMBFKOI(string JBGIOGBCJPF, object GINKKHJNPNJ, object MHEKDMGGIEJ);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ONNEKGDMEOO(long BIMOILFHLHN, bool LJEGFNHMLMO = true);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface FCIEJAHGBCD
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool GMKBIDHFBAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool JJEAIEAIFAO
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool HEBHNCJDFPH
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool IGBAEKPHMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool? OBNOBOKOIIK
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	int? JHMDLBPEOLN
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	int IPNFILLNMIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	string CJJEPAFNAEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	string BICIAMJLEKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	string MGGLHKDNLBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	string IJPJBPBPILL
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	string FFHHEJGIFPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	string BNBKGIEFNMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	double AGKMDDCJEMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
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
		public AmplitudeAnalyticsClient.Settings DFMFDDFDEIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool LIOGGLPMGFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x6DC3D0", Offset = "0x6DADD0", VA = "0x1806DC3D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xE1E960", Offset = "0xE1D360", VA = "0x180E1E960")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public enum DGAOIAAKMDG
		{
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			Disabled,
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			RudderStackOnly,
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			Both
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		private enum HEHBOEBMPEJ
		{
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		internal class NMJDNKEAOLK
		{
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			private class EEBCAFKKGKM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000076")]
				public int HBOGJHIKGOC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000077")]
				public Dictionary<string, object> OKNOEGDJIGI;

				[Cpp2IlInjected.Token(Token = "0x60000A7")]
				[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
				public EEBCAFKKGKM()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000019")]
			[CompilerGenerated]
			private sealed class HDOPNLJFCAB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000078")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x60000A8")]
				[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
				public HDOPNLJFCAB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000A9")]
				[Cpp2IlInjected.Address(RVA = "0x60F75C0", Offset = "0x60F5FC0", VA = "0x1860F75C0")]
				internal bool <GetBatch>b__0(EEBCAFKKGKM item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private const string ILMKMEKKCHI = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private readonly string NKNOOFILFKG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private List<EEBCAFKKGKM> CEBOLMMAFKI;

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			public int? DOLDGDFIHLN
			{
				[Cpp2IlInjected.Token(Token = "0x600009B")]
				[Cpp2IlInjected.Address(RVA = "0x60F9E10", Offset = "0x60F8810", VA = "0x1860F9E10")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			public int? IKHGPGEAFIJ
			{
				[Cpp2IlInjected.Token(Token = "0x600009C")]
				[Cpp2IlInjected.Address(RVA = "0x60FA510", Offset = "0x60F8F10", VA = "0x1860FA510")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x60FAC60", Offset = "0x60F9660", VA = "0x1860FAC60")]
			internal NMJDNKEAOLK(string CFBKCNBEPDB, string IFMDLBDCIAL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x60F9C80", Offset = "0x60F8680", VA = "0x1860F9C80")]
			public int CNEAJMFHJPE([Optional] int? LIKLKIODKLK)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x60FA9D0", Offset = "0x60F93D0", VA = "0x1860FA9D0")]
			public List<Dictionary<string, object>> NOAMFLGJDCN(int PGNPKFAKILC, int? LIKLKIODKLK)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x60F9FC0", Offset = "0x60F89C0", VA = "0x1860F9FC0")]
			public void DPOLLDDKAHM(AmplitudeAnalyticsIdentifyMessage LAFPICAOEAI, bool IOLCEOIIIGI = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x60F9EB0", Offset = "0x60F88B0", VA = "0x1860F9EB0")]
			public void DPOLLDDKAHM(Dictionary<string, object> LAFPICAOEAI, bool IOLCEOIIIGI = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x60FA840", Offset = "0x60F9240", VA = "0x1860FA840")]
			public void MAKOHDFFHGE(params Dictionary<string, object>[] BPCBFFOMDAK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x60F97C0", Offset = "0x60F81C0", VA = "0x1860F97C0")]
			public void AKCEBJKPKLC(List<Dictionary<string, object>> CFDCFECAFLG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x60FA700", Offset = "0x60F9100", VA = "0x1860FA700")]
			private void IBBHOHJHMOD(Dictionary<string, object> LAFPICAOEAI, bool IOLCEOIIIGI = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x60F9A10", Offset = "0x60F8410", VA = "0x1860F9A10")]
			public void BHCJJCOJAKM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x60FA060", Offset = "0x60F8A60", VA = "0x1860FA060")]
			private void EEGMBCFFIMF([Optional] string BJJPGEOAONK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x60FA5D0", Offset = "0x60F8FD0", VA = "0x1860FA5D0")]
			private static string IABDGMJLHAL(string MNIAGKNOHEJ, string AJPNMLHDHNM)
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

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x60FB530", Offset = "0x60F9F30", VA = "0x1860FB530")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public struct AIBBNGCDEIK<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public int APNJOFCMENM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public string BOHELGOJKNB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public T AJFBNKMMGNO;
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class GPFOIHPJEDP : IEnumerator<MJOGGKCIPED>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			private MJOGGKCIPED <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			private MJOGGKCIPED System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000B3")]
				[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000B5")]
				[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x6C5200", Offset = "0x6C3C00", VA = "0x1806C5200")]
			[DebuggerHidden]
			public GPFOIHPJEDP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x60F6F90", Offset = "0x60F5990", VA = "0x1860F6F90", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x60F7580", Offset = "0x60F5F80", VA = "0x1860F7580", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class EDEMLCJMHBJ : IEnumerator<object>, IEnumerator, IDisposable
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
			public AMHJHFKKEOP quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000B9")]
				[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000BB")]
				[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x6C5200", Offset = "0x6C3C00", VA = "0x1806C5200")]
			[DebuggerHidden]
			public EDEMLCJMHBJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x60F69D0", Offset = "0x60F53D0", VA = "0x1860F69D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x60F6AC0", Offset = "0x60F54C0", VA = "0x1860F6AC0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class AFJGOFFKDEG : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Token(Token = "0x60000BF")]
				[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000C1")]
				[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x6C5200", Offset = "0x6C3C00", VA = "0x1806C5200")]
			[DebuggerHidden]
			public AFJGOFFKDEG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x60ED650", Offset = "0x60EC050", VA = "0x1860ED650", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x60ED7C0", Offset = "0x60EC1C0", VA = "0x1860ED7C0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class JOHCFHJHGIA : IEnumerator<MJOGGKCIPED>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			private MJOGGKCIPED <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			private MJOGGKCIPED System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000C5")]
				[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000C7")]
				[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x6C5200", Offset = "0x6C3C00", VA = "0x1806C5200")]
			[DebuggerHidden]
			public JOHCFHJHGIA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x60F7E30", Offset = "0x60F6830", VA = "0x1860F7E30", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x60F80D0", Offset = "0x60F6AD0", VA = "0x1860F80D0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class FHMNODJGGDF : IEnumerator<MJOGGKCIPED>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			private MJOGGKCIPED <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			private MJOGGKCIPED System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000CE")]
				[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000D0")]
				[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x6C5200", Offset = "0x6C3C00", VA = "0x1806C5200")]
			[DebuggerHidden]
			public FHMNODJGGDF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x60F6B00", Offset = "0x60F5500", VA = "0x1860F6B00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x60F6DA0", Offset = "0x60F57A0", VA = "0x1860F6DA0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private sealed class IAEHBCMECNB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			public List<Dictionary<string, object>> batch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public NMJDNKEAOLK cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
			public IAEHBCMECNB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x60F7620", Offset = "0x60F6020", VA = "0x1860F7620")]
			internal void <FlushFromCache>b__0(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x60F7990", Offset = "0x60F6390", VA = "0x1860F7990")]
			internal void <FlushFromCache>b__1(AIBBNGCDEIK<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class BIOKHPDKFBM : IEnumerator<MJOGGKCIPED>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			private MJOGGKCIPED <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public NMJDNKEAOLK cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			public float timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			private IAEHBCMECNB <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public int? earlierThanFrame;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public string url;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public string dataIdentifier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private string <apiKey>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			private float <startTime>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			private bool <timedOut>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			private int <batchSize>5__5;

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			private MJOGGKCIPED System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000D7")]
				[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000D9")]
				[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x6C5200", Offset = "0x6C3C00", VA = "0x1806C5200")]
			[DebuggerHidden]
			public BIOKHPDKFBM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x60F3EC0", Offset = "0x60F28C0", VA = "0x1860F3EC0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x60F47D0", Offset = "0x60F31D0", VA = "0x1860F47D0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private sealed class GJGPFLDFGLB<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0xF581E0", Offset = "0xF56BE0", VA = "0x180F581E0")]
			public GJGPFLDFGLB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x311A5F0", Offset = "0x3118FF0", VA = "0x18311A5F0")]
			internal AIBBNGCDEIK<T> <PostRudderStackJson>b__0(IACIFGMBHDL postResponse)
			{
				return default(AIBBNGCDEIK<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class KKHAEGKEHAA<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0xF581E0", Offset = "0xF56BE0", VA = "0x180F581E0")]
			public KKHAEGKEHAA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x311A5F0", Offset = "0x3118FF0", VA = "0x18311A5F0")]
			internal AIBBNGCDEIK<T> <PostAmplitudeJson>b__0(IACIFGMBHDL postResponse)
			{
				return default(AIBBNGCDEIK<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private DOAIHBCLGLJ NIAMFDPEMLG;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private const string IAEACPFOOFA = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const string MPJMDLBDHJD = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const string FNIJGBJAMJH = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private const int ECNEDEJCLOG = 15;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private const int JHJPJLIBNLO = 10;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private const int EBHCHDLCCOI = 5;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private const float KIGCANLKKLD = 10f;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private const long BMMLHMJFIGH = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private const string BLCDAIEJLMD = "f1779b982f1c09aed3adb3cca563cbc2";

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private const string CMOMHKLGBPL = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private static bool HKLCMBAJDMM;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static bool PKHAEBMOFGH;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static int LDBCBPHPFCJ;

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private static int PHPJHCJIDAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private BHHENJADJIB HBPPNPKOHKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private bool CLKIMFNAGLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private float IAIBIDABINF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private float FGBJOPCPGMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private int KOBKPPONOND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private int MIIGLGDFOBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private int? MGGELOKKFFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private int? PCLJDBNADIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private long OCCAPIHOJGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private string OHOGHEMIOKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private long HEEPAGNIFDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private Dictionary<string, object> DGAIEGGEGOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private HEHBOEBMPEJ KDJAJMEFBID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private int JLPKEBEFOJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private int CCIOENHGCCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private float JEAJPPAOLJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private bool HHIIDMPMFEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x89")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private bool BADMOCLAAKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private NMJDNKEAOLK DEHKMAHODCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private NMJDNKEAOLK BHPGKHDPKKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private NMJDNKEAOLK HGFJOJCFBAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> AMCFNJHIAAH;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo FKEHECALNEN;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static string EGEPCLENEBO;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private const string PGOIAKJDKLJ = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly string HGPAKIECJFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly string HODCGALPIMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly string BFEGAIJFDHC;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private DOAIHBCLGLJ AEDIOINMMFN
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x60EECE0", Offset = "0x60ED6E0", VA = "0x1860EECE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private static int NIHCMBOGNKK
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x60EFCA0", Offset = "0x60EE6A0", VA = "0x1860EFCA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static long EBCAFGCCHKL
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x60F29F0", Offset = "0x60F13F0", VA = "0x1860F29F0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x60F2AF0", Offset = "0x60F14F0", VA = "0x1860F2AF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static string OJEFJNBIIOM
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x60F2990", Offset = "0x60F1390", VA = "0x1860F2990")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static string JEOCHLBPDIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x60F29C0", Offset = "0x60F13C0", VA = "0x1860F29C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public string NIDAPNIOENB
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x6D7740", Offset = "0x6D6140", VA = "0x1806D7740")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x6F8DC0", Offset = "0x6F77C0", VA = "0x1806F8DC0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int? JHMDLBPEOLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x7F1820", Offset = "0x7F0220", VA = "0x1807F1820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x1568BF0", Offset = "0x15675F0", VA = "0x181568BF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public DGAOIAAKMDG? KGIFLPHOKOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x7797A0", Offset = "0x7781A0", VA = "0x1807797A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x2D9F300", Offset = "0x2D9DD00", VA = "0x182D9F300")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool CHMMLCPCPHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x1316AB0", Offset = "0x13154B0", VA = "0x181316AB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x1316410", Offset = "0x1314E10", VA = "0x181316410")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public static bool EGBBLCMPHDB
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x60F28A0", Offset = "0x60F12A0", VA = "0x1860F28A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> JCHCEMPFGEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x60F2800", Offset = "0x60F1200", VA = "0x1860F2800")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x60F2A50", Offset = "0x60F1450", VA = "0x1860F2A50")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x60EDF90", Offset = "0x60EC990", VA = "0x1860EDF90", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x60EE6F0", Offset = "0x60ED0F0", VA = "0x1860EE6F0")]
		private void CDCDAPGJJFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x60F2050", Offset = "0x60F0A50", VA = "0x1860F2050")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x60F1610", Offset = "0x60F0010", VA = "0x1860F1610", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x60F2340", Offset = "0x60F0D40", VA = "0x1860F2340")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x60F16B0", Offset = "0x60F00B0", VA = "0x1860F16B0")]
		public GPMDAFELAJF PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x60EFA30", Offset = "0x60EE430", VA = "0x1860EFA30")]
		[IteratorStateMachine(typeof(GPFOIHPJEDP))]
		public IEnumerator<MJOGGKCIPED> Initialize(AmplitudeAnalyticsEvent MPAFCCOHFGA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x60F2230", Offset = "0x60F0C30", VA = "0x1860F2230")]
		public void UpdateLastAliveTime(float NPLLDPKOMIC = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x60F1530", Offset = "0x60EFF30", VA = "0x1860F1530")]
		private GPMDAFELAJF OHEBPNIFJJF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x60EE280", Offset = "0x60ECC80", VA = "0x1860EE280")]
		private GPMDAFELAJF BEFLDEEGLDF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x60F1C00", Offset = "0x60F0600", VA = "0x1860F1C00")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x60EF1B0", Offset = "0x60EDBB0", VA = "0x1860EF1B0")]
		[IteratorStateMachine(typeof(EDEMLCJMHBJ))]
		private IEnumerator FKKEHODAEOM(AMHJHFKKEOP MPOLOHKPDLO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x60F25B0", Offset = "0x60F0FB0", VA = "0x1860F25B0")]
		[IteratorStateMachine(typeof(AFJGOFFKDEG))]
		public IEnumerator WaitForFlush(float BPABCDMAKOP = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x60F2110", Offset = "0x60F0B10", VA = "0x1860F2110")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x60F2060", Offset = "0x60F0A60", VA = "0x1860F2060")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime AHOJLECBNNM)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x60EF680", Offset = "0x60EE080", VA = "0x1860EF680")]
		public static AIONFOKIAID Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x60EDDF0", Offset = "0x60EC7F0", VA = "0x1860EDDF0")]
		public static BJDCAFFNNNE AccountSelectionPostLoginEvent([NotNull] string IOCPHGCEIJF, string AONFCLLBBJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x60EEFB0", Offset = "0x60ED9B0", VA = "0x1860EEFB0")]
		public static BJDCAFFNNNE Event([NotNull] string IOCPHGCEIJF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x60F1710", Offset = "0x60F0110", VA = "0x1860F1710")]
		public static BJDCAFFNNNE PreviousSessionEvent([NotNull] string IOCPHGCEIJF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x60EF7E0", Offset = "0x60EE1E0", VA = "0x1860EF7E0")]
		public static BJDCAFFNNNE InitializeEvent(string AONFCLLBBJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x60F1D60", Offset = "0x60F0760", VA = "0x1860F1D60")]
		public static BJDCAFFNNNE StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x60EEA10", Offset = "0x60ED410", VA = "0x1860EEA10")]
		public static BJDCAFFNNNE CreateOutOfSessionEvent(string IOCPHGCEIJF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x60F0260", Offset = "0x60EEC60", VA = "0x1860F0260")]
		public static GPMDAFELAJF LogOutOfSessionEvent(BJDCAFFNNNE ONAKOBMFKNL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x60EFFA0", Offset = "0x60EE9A0", VA = "0x1860EFFA0")]
		public void LogEventAsync(AmplitudeAnalyticsEvent FMBFFJEDAOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x60F0600", Offset = "0x60EF000", VA = "0x1860F0600")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent FMBFFJEDAOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x60F0750", Offset = "0x60EF150", VA = "0x1860F0750")]
		public void LogSerializedEventAsync(Dictionary<string, object> KOMPPGMOCLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x60F00F0", Offset = "0x60EEAF0", VA = "0x1860F00F0")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage EIEKCCECNAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x60EFE70", Offset = "0x60EE870", VA = "0x1860EFE70")]
		private void KONLNEGEECL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x60EF2D0", Offset = "0x60EDCD0", VA = "0x1860EF2D0")]
		private void GNCEFEBDNJH(Dictionary<string, object> JHMHIFHEEJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x60EE600", Offset = "0x60ED000", VA = "0x1860EE600")]
		private void CCHHFNGKCGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x60EFAC0", Offset = "0x60EE4C0", VA = "0x1860EFAC0")]
		private void KBPLMBJLOEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x60EF240", Offset = "0x60EDC40", VA = "0x1860EF240")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x60EEF30", Offset = "0x60ED930", VA = "0x1860EEF30")]
		[IteratorStateMachine(typeof(JOHCFHJHGIA))]
		private IEnumerator<MJOGGKCIPED> EPPNCCKOBAJ(float BPABCDMAKOP = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x60EED50", Offset = "0x60ED750", VA = "0x1860EED50")]
		[IteratorStateMachine(typeof(FHMNODJGGDF))]
		private IEnumerator<MJOGGKCIPED> ENGGCFPIJPA(float BPABCDMAKOP = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x60EE520", Offset = "0x60ECF20", VA = "0x1860EE520")]
		[IteratorStateMachine(typeof(BIOKHPDKFBM))]
		private IEnumerator<MJOGGKCIPED> BEOFKPDJGBA(NMJDNKEAOLK MPDNFFFOBPO, int? LIKLKIODKLK, string FMJHKANELBK, string AEHGFGBDIKC, float BPABCDMAKOP, Action<int> GDDHMKHBLEK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x60EF560", Offset = "0x60EDF60", VA = "0x1860EF560")]
		private static void HNDMKCJOEKB(bool JBHAIHBMNML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x60EDC40", Offset = "0x60EC640", VA = "0x1860EDC40")]
		private global::OHPLDOPGNGG<AIBBNGCDEIK<Dictionary<string, object>>> AMDDHNNOFNC(string FMJHKANELBK, string AEHGFGBDIKC, string CNJHJPJKHHP, string BPEOAJOBGEC, Dictionary<string, object> AJFBNKMMGNO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x60ED8F0", Offset = "0x60EC2F0", VA = "0x1860ED8F0")]
		private global::OHPLDOPGNGG<AIBBNGCDEIK<List<Dictionary<string, object>>>> AMDDHNNOFNC(string FMJHKANELBK, string AEHGFGBDIKC, string CNJHJPJKHHP, string BPEOAJOBGEC, List<Dictionary<string, object>> AJFBNKMMGNO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x23F4100", Offset = "0x23F2B00", VA = "0x1823F4100")]
		private global::OHPLDOPGNGG<AIBBNGCDEIK<T>> FABMNJNFNBB<T>(string FMJHKANELBK, string AEHGFGBDIKC, string BPEOAJOBGEC, T AJFBNKMMGNO, Dictionary<string, object> OMKMGLPOKLK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x23F3DC0", Offset = "0x23F27C0", VA = "0x1823F3DC0")]
		private global::OHPLDOPGNGG<AIBBNGCDEIK<T>> CFGLNOLDJFF<T>(string FMJHKANELBK, string AEHGFGBDIKC, string CNJHJPJKHHP, T AJFBNKMMGNO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x60EFF50", Offset = "0x60EE950", VA = "0x1860EFF50")]
		private bool LDELJECEEPM(float AGFKMBIACDJ, float BPABCDMAKOP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x60F0830", Offset = "0x60EF230", VA = "0x1860F0830")]
		private Dictionary<string, object> MOAJABELLDK(string AEHGFGBDIKC, Dictionary<string, object> AJFBNKMMGNO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x60F2690", Offset = "0x60F1090", VA = "0x1860F2690")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x60EEDD0", Offset = "0x60ED7D0", VA = "0x1860EEDD0")]
		[CompilerGenerated]
		private long EOIJNCJIKAP()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x60F1600", Offset = "0x60F0000", VA = "0x1860F1600")]
		[CompilerGenerated]
		private void ONFOPNKJPIP(int MEDMOJAMPCN)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class AmplitudeAnalyticsEvent : AmplitudeAnalyticsIdentifyMessage
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private readonly string uuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private readonly string eventType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private readonly long sequenceNumber;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		internal Dictionary<string, object> eventProperties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private string language;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private long time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private long sessionId;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public static string SessionTrackingData
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x60F36B0", Offset = "0x60F20B0", VA = "0x1860F36B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x60F3710", Offset = "0x60F2110", VA = "0x1860F3710")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x6D7780", Offset = "0x6D6180", VA = "0x1806D7780")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x60F2DF0", Offset = "0x60F17F0", VA = "0x1860F2DF0")]
		public static BJDCAFFNNNE GANMJPNFBJN(string FMHBAJCDDEI, [NotNull] string JMMHPLCCLIP, long BIMOILFHLHN, long EKADIHFLMGL, string AONFCLLBBJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x60F2CF0", Offset = "0x60F16F0", VA = "0x1860F2CF0")]
		public static BJDCAFFNNNE FAEDPKPGPKN(string FMHBAJCDDEI, [NotNull] string JMMHPLCCLIP, long BIMOILFHLHN, long EKADIHFLMGL, string AONFCLLBBJG, long FJGIDAHCAGA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x60F34F0", Offset = "0x60F1EF0", VA = "0x1860F34F0")]
		private AmplitudeAnalyticsEvent(string FMHBAJCDDEI, [NotNull] string JMMHPLCCLIP, long BIMOILFHLHN, long EKADIHFLMGL, string AONFCLLBBJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x901010", Offset = "0x8FFA10", VA = "0x180901010")]
		public void CFLFBFBIJMG(long IMJNGAMBHEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x60F33D0", Offset = "0x60F1DD0", VA = "0x1860F33D0", Slot = "5")]
		public override void PKCDHNBPMNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x60F2B50", Offset = "0x60F1550", VA = "0x1860F2B50", Slot = "6")]
		public override void ELFMDKAEKOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x60F2EE0", Offset = "0x60F18E0", VA = "0x1860F2EE0", Slot = "4")]
		protected override Dictionary<string, object> LFIBHMDCJNH(Dictionary<string, object> MPKFOFMDADE)
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
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public string platform;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public string osName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public string osVersion;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public string deviceBrand;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public string deviceManufacturer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public string deviceModel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public string deviceType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public string carrier;

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x60F6850", Offset = "0x60F5250", VA = "0x1860F6850")]
			public void HACALPBIJAK(Dictionary<string, object> NEGKCGKDPEH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
			public DeviceInfo()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public class RevenueData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public float price;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public int quantity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public float revenue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public string productId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public string revenueType;

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x60FB120", Offset = "0x60F9B20", VA = "0x1860FB120")]
			public void HACALPBIJAK(Dictionary<string, object> IBFIEDFHBBG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x12C7C30", Offset = "0x12C6630", VA = "0x1812C7C30")]
			public RevenueData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		internal DeviceInfo deviceInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		internal RevenueData revenueData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private readonly string buildVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private readonly string language;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		internal Dictionary<string, object> userProperties;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		protected string UserId
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x6C2AC0", Offset = "0x6C14C0", VA = "0x1806C2AC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x6E1130", Offset = "0x6DFB30", VA = "0x1806E1130")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x60F38A0", Offset = "0x60F22A0", VA = "0x1860F38A0")]
		public static AIONFOKIAID GANMJPNFBJN(string FMHBAJCDDEI, string AONFCLLBBJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x60F3E00", Offset = "0x60F2800", VA = "0x1860F3E00")]
		protected AmplitudeAnalyticsIdentifyMessage(string FMHBAJCDDEI, string AONFCLLBBJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x60F3D00", Offset = "0x60F2700", VA = "0x1860F3D00")]
		public Dictionary<string, object> MLIOPCEBLMN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x60F39C0", Offset = "0x60F23C0", VA = "0x1860F39C0", Slot = "4")]
		protected virtual Dictionary<string, object> LFIBHMDCJNH(Dictionary<string, object> MPKFOFMDADE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x60F3780", Offset = "0x60F2180", VA = "0x1860F3780")]
		protected void AJBKIFJIMFD(string AJPNMLHDHNM, Dictionary<string, object> LEFIGOFFOBK, Dictionary<string, object> ICMGJIDNLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x60F3950", Offset = "0x60F2350", VA = "0x1860F3950")]
		protected void LEDLBKINCCG(string AJPNMLHDHNM, string MNIAGKNOHEJ, Dictionary<string, object> MGCOBICJGON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x60F3D80", Offset = "0x60F2780", VA = "0x1860F3D80", Slot = "5")]
		public virtual void PKCDHNBPMNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x60F3820", Offset = "0x60F2220", VA = "0x1860F3820", Slot = "6")]
		public virtual void ELFMDKAEKOO()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class AIONFOKIAID : global::BKGCMLMIGPC<AmplitudeAnalyticsIdentifyMessage, AIONFOKIAID>
{
	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public override AIONFOKIAID IMFMONEEJML
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7DFE00", Offset = "0x7DE800", VA = "0x1807DFE00", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6C2AC0", Offset = "0x6C14C0", VA = "0x1806C2AC0", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage KFJCGBLMIPN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x60ED8A0", Offset = "0x60EC2A0", VA = "0x1860ED8A0")]
	public AIONFOKIAID(AmplitudeAnalyticsIdentifyMessage EJEIJOMMNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x60ED800", Offset = "0x60EC200", VA = "0x1860ED800", Slot = "4")]
	public override void ELFMDKAEKOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class BJDCAFFNNNE : global::BKGCMLMIGPC<AmplitudeAnalyticsEvent, BJDCAFFNNNE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private bool AFPPNPBEAPN;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public override BJDCAFFNNNE IMFMONEEJML
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7DFE00", Offset = "0x7DE800", VA = "0x1807DFE00", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public long IPBFLPPLGGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x60F4E80", Offset = "0x60F3880", VA = "0x1860F4E80")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x60F4EA0", Offset = "0x60F38A0", VA = "0x1860F4EA0")]
	public BJDCAFFNNNE(AmplitudeAnalyticsEvent EJEIJOMMNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6C2AC0", Offset = "0x6C14C0", VA = "0x1806C2AC0", Slot = "5")]
	public override AmplitudeAnalyticsEvent KFJCGBLMIPN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x60F4830", Offset = "0x60F3230", VA = "0x1860F4830", Slot = "4")]
	public override void ELFMDKAEKOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x60F4B40", Offset = "0x60F3540", VA = "0x1860F4B40")]
	public BJDCAFFNNNE ICEELEPGJBF(string OPPPBNFKNOC, long[] MNIAGKNOHEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x60F4A00", Offset = "0x60F3400", VA = "0x1860F4A00")]
	public BJDCAFFNNNE ICEELEPGJBF(string OPPPBNFKNOC, ulong[] MNIAGKNOHEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x26782D0", Offset = "0x2676CD0", VA = "0x1826782D0")]
	public BJDCAFFNNNE ICEELEPGJBF<T>(string OPPPBNFKNOC, T[] MNIAGKNOHEJ) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x60F4D80", Offset = "0x60F3780", VA = "0x1860F4D80")]
	public BJDCAFFNNNE ICEELEPGJBF(string OPPPBNFKNOC, string[] MNIAGKNOHEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x2678260", Offset = "0x2676C60", VA = "0x182678260")]
	public BJDCAFFNNNE ICEELEPGJBF<T>(string OPPPBNFKNOC, T MNIAGKNOHEJ) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x60F4C80", Offset = "0x60F3680", VA = "0x1860F4C80")]
	public BJDCAFFNNNE ICEELEPGJBF(string OPPPBNFKNOC, long MNIAGKNOHEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x60F4970", Offset = "0x60F3370", VA = "0x1860F4970")]
	public BJDCAFFNNNE ICEELEPGJBF(string OPPPBNFKNOC, ulong MNIAGKNOHEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x60F4D10", Offset = "0x60F3710", VA = "0x1860F4D10")]
	public BJDCAFFNNNE ICEELEPGJBF(string OPPPBNFKNOC, string MNIAGKNOHEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x60F4810", Offset = "0x60F3210", VA = "0x1860F4810")]
	public BJDCAFFNNNE BLJNPDKCEFG(string OPPPBNFKNOC, object? MNIAGKNOHEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x60F48D0", Offset = "0x60F32D0", VA = "0x1860F48D0")]
	public BJDCAFFNNNE GGFKPCOEBDN(string OPPPBNFKNOC, string MNIAGKNOHEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x60F4D90", Offset = "0x60F3790", VA = "0x1860F4D90")]
	private BJDCAFFNNNE JJHGLNGDEDJ(string OPPPBNFKNOC, object MNIAGKNOHEJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class NEBDEFNICIH : BJDCAFFNNNE
{
	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x60F4EA0", Offset = "0x60F38A0", VA = "0x1860F4EA0")]
	public NEBDEFNICIH(AmplitudeAnalyticsEvent EJEIJOMMNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x60F9600", Offset = "0x60F8000", VA = "0x1860F9600", Slot = "4")]
	public override void ELFMDKAEKOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public abstract class BKGCMLMIGPC<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : global::BKGCMLMIGPC<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	protected M EJEIJOMMNGK;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public abstract BLDR IMFMONEEJML
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x1FDE890", Offset = "0x1FDD290", VA = "0x181FDE890")]
	public BKGCMLMIGPC(M EJEIJOMMNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x3192470", Offset = "0x3190E70", VA = "0x183192470")]
	public BLDR ONGPGMEKKKB(AmplitudeAnalyticsIdentifyMessage.DeviceInfo HHIHDAGFKNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x3192260", Offset = "0x3190C60", VA = "0x183192260")]
	public BLDR HFHOHLPKNNL(AmplitudeAnalyticsIdentifyMessage.RevenueData POPEODJNDBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x3192400", Offset = "0x3190E00", VA = "0x183192400")]
	public BLDR JDMELGEEPFB(string OPPPBNFKNOC, string MNIAGKNOHEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x24A69C0", Offset = "0x24A53C0", VA = "0x1824A69C0")]
	public BLDR JDMELGEEPFB<T>(string OPPPBNFKNOC, T MNIAGKNOHEJ) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x31922A0", Offset = "0x3190CA0", VA = "0x1831922A0")]
	public BLDR JDMELGEEPFB(string OPPPBNFKNOC, long MNIAGKNOHEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x3192350", Offset = "0x3190D50", VA = "0x183192350")]
	public BLDR JDMELGEEPFB(string OPPPBNFKNOC, ulong MNIAGKNOHEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void ELFMDKAEKOO();

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3192230", Offset = "0x3190C30", VA = "0x183192230")]
	internal static string CAPJDOMFPHN(string MNIAGKNOHEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x31924B0", Offset = "0x3190EB0", VA = "0x1831924B0")]
	private BLDR PLFCGGJGKPG(string OPPPBNFKNOC, object MNIAGKNOHEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M KFJCGBLMIPN();
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class LIKOAICLAMJ
{
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public const string LKLOKFKCHFP = "batch";

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public const string JLPHJGOBDHF = "type";

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public const string JMKIIICGCFG = "identify";

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public const string HLJNOOKMHDF = "track";

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public const string FLMGFICNAHN = "userId";

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public const string JMNBPLBENMH = "anonymousId";

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public const string NCCBMDIMMPG = "messageId";

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public const string MNLPBOOKFKI = "event";

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public const string MOAOLBMPMHJ = "version";

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public const string FEJCDNLNFEI = "locale";

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public const string EIFJEGHHBFM = "name";

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public const string HOILODCFFOP = "properties";

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public const string ELPPKHFFLFP = "traits";

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public const string JELLOOFKOCG = "context";

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public const string FNMFHCEMDDM = "app";

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public const string IPFPKOIGOGM = "os";

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public const string KDPIKMNJNCH = "device";

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public const string LMINKHANNEH = "originalTimestamp";

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public const string CIGCGPJEIKF = "brand";

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public const string KIJNMNLDMJG = "manufacturer";

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public const string FANNAOMJKKL = "model";

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public const string AOBEMDGLDBI = "type";

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public LIKOAICLAMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class FKEPMPDHGGP
{
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public const int BCPOMNOGAFO = 2;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public const int CCCHHHEMFED = 100;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public const int OKCCOALBDIC = 1000;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public const long PLOGMENPOAF = 1800000L;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public const int DPFDKEGLHKI = 1024;

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public const int FAANMMPCDBP = 1000;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public const string JPDNAGOAGDF = "amplitude_sequence_number";

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public const string KNHNMGHHKLF = "amplitude_user_id";

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public const string LPICBJKGFLB = "amplitude_last_time";

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public const string DOLELMBOBJF = "initialize_analytics";

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public const string JAGHIPFEILN = "session_start";

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public const string OAGKBJJGOAF = "session_end";

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public const string JGDKDLCPDML = "insert_id";

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public const string MGAOBPGBILJ = "event_time";

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public const string OPLNCAAGLIF = "session_id";

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public const string PMMKMMCHFLD = "session_tracking_data";

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public const string OPHGAHODFMO = "user_properties";

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public const string NCBEBDDACCH = "app_version";

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public const string JBLKMFBOPEO = "ip";

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public const string BHPHCBBNLPG = "language";

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public const string BFNNILAPAIP = "platform";

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public const string LFKBOINCGHH = "os_name";

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public const string OHEJNMBPIBP = "os_version";

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public const string ANDJIFBOCDB = "device_brand";

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public const string BGBBCMFHNMG = "device_manufacturer";

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public const string EONANMHMBFO = "device_model";

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public const string EOFPPJDECBB = "device_type";

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public const string GKPGMNNOGGK = "price";

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public const string FCBKEBMOGKD = "quantity";

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public const string IPIEJJNPGDH = "revenue";

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public const string EMDMONGIEJO = "productId";

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public const string EDOAPBKEIJK = "revenueType";

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public const string DLGPBFJBKDH = "event_type";

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public const string FLMGFICNAHN = "user_id";

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public const string OMLBPPACGBP = "event_properties";

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public const int LGOLOMKOIJH = 10;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> JHJANLGICGE;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x60F6DE0", Offset = "0x60F57E0", VA = "0x1860F6DE0")]
	internal static bool JMDMLBBCHEE(string AJPNMLHDHNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public FKEPMPDHGGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface BHHENJADJIB
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool PHJJOBGJBOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	string CPLFAFBKJGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	string NPOEAAMOBHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	string MDMIKMNJKGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	string AJMFAEBOBCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::OHPLDOPGNGG<IACIFGMBHDL> AMDDHNNOFNC(string FMJHKANELBK, Dictionary<string, string> EKHNKOMICJI, bool CGIJODGMFIC = false);

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "6")]
	global::OHPLDOPGNGG<IACIFGMBHDL> AKEBKBDCPJI(string FMJHKANELBK, string AHJFMFLLBLP, string EGCDOJLBILK, string JANCMLMBGLE);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct IACIFGMBHDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public readonly int MIOHGBHBFIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public readonly string LCDOJFLMAPH;

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6EC0B0", Offset = "0x6EAAB0", VA = "0x1806EC0B0")]
	public IACIFGMBHDL(int APNJOFCMENM, string BOHELGOJKNB)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class KEBPIDDMFLP
{
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static byte[] PACJNBAODEE;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static int CIPMBADAHHP;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static int EAOHPIEEBJK;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private static BigInteger CAFOPFCNDHG;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public KEBPIDDMFLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x60F8460", Offset = "0x60F6E60", VA = "0x1860F8460")]
	private static string PBGMOKJNJDM(byte[] DLAMIJMLOOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x60F8110", Offset = "0x60F6B10", VA = "0x1860F8110")]
	public static string NPAMJBENNGG(byte[] FMIGDHLBIKP, bool BLHGHBBBDBI)
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

		[Cpp2IlInjected.Token(Token = "0x400010C")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
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

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
		[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780")]
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
		[Cpp2IlInjected.Address(RVA = "0x6139DB0", Offset = "0x61391B0", VA = "0x186139DB0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x72ABD0", Offset = "0x729FD0", VA = "0x18072ABD0")]
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
		[Cpp2IlInjected.Address(RVA = "0xC60960", Offset = "0xC5FD60", VA = "0x180C60960")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum JIBFGKLHLBF
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
public class MGDJHDKDPKB
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private const string BNNJBFGLLPB = "timed_flow";

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private const string BOBGCMMFGGL = "flowName";

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private const string EAAMPLDDFDK = "startedAt";

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private const string HJFCOJAMKHP = "endedAt";

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private const string MHJAEJNKGCM = "durationInSeconds";

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private const string EIGNCHIGCHP = "failure";

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private const string HMIFOLCLFED = "failureMessage";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private long JDFDJONEHDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private ACEAKGABADC KGGJDIMFFGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private bool MBJIKICFIDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private float OANDPKHFOFK;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6138100", Offset = "0x6137500", VA = "0x186138100")]
	public MGDJHDKDPKB(string DLLCIGKLPFP, float OANDPKHFOFK = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x33BB800", Offset = "0x33BAC00", VA = "0x1833BB800")]
	public void IJBCOBCOBMC<T>(string LKAENGEIFGG, T JFBPNBNBHOE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6137F90", Offset = "0x6137390", VA = "0x186137F90")]
	public void IJBCOBCOBMC(string LKAENGEIFGG, string JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6138010", Offset = "0x6137410", VA = "0x186138010")]
	public void PCFCMBMIGGE(string HPDGPGFCDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6137DB0", Offset = "0x61371B0", VA = "0x186137DB0")]
	public void EIKEALGHEPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6137E70", Offset = "0x6137270", VA = "0x186137E70")]
	private void FIGCEMCJMNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6137D60", Offset = "0x6137160", VA = "0x186137D60")]
	private bool DEGCKFPGKFG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface COJBCBJOMJK
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PMOAFBNPLHC BNACPANAOEJ(string EMIDKKGGDNI, string HDPANMIFFKG, [Optional] MEKBBHHFLDO PKDDAIOFEKG);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PMOAFBNPLHC KLJLCPJIADB(MEKBBHHFLDO PKDDAIOFEKG);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PMOAFBNPLHC HDFKPOIMIIA(MEKBBHHFLDO PKDDAIOFEKG, Dictionary<string, string> GIIMDGFFJEE);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DMNKGKAIOCB(string JPNCGPPDOPG);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "4")]
	DKBLPLBIMNK EPOBGOPKPGE(string GKGCGBHGGCF);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "5")]
	JHOOABLONHN GDNAODEGKBI(string OFAEDIBLIFH);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "6")]
	DKBLPLBIMNK BCEKNHADNAD(string NBONGEOCBEP);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "7")]
	PMOAFBNPLHC HJMHDPAOPEJ();
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
			[Cpp2IlInjected.Address(RVA = "0x6E1E40", Offset = "0x6E1240", VA = "0x1806E1E40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E1E40", Offset = "0x6E1240", VA = "0x1806E1E40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6E4130", Offset = "0x6E3530", VA = "0x1806E4130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x613A410", Offset = "0x6139810", VA = "0x18613A410", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class NABBADPHHEM : COJBCBJOMJK
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private const string PHMNKIGNANK = "GamePlatform";

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private const string LAGNJDKNHDA = "InteractionCategory";

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private const string DEJENPCFKBF = "JrActType";

	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private const string IBCAOCBHLPD = "IsDeveloper";

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private const string FCMJNJPDOEK = "IsModerator";

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private const string LMHMEEDEBIG = "IsMember";

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private const string OIDLGPEHMDH = "DaysSinceJoiningBucket";

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private const string CKLJHDEGOJC = "AccountCreationTimeAfterEpochMilliseconds";

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private const string FPMCGIIOCDA = "InGoodStanding";

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private const string EKAFEHEDHFL = "FriendCount";

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private const string AGOGFEPFFOC = "LocaleName";

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly IReadOnlyDictionary<string, ALIOCLKAHNH> MGJKGCLEGGF;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private const int JDCAFPHDANE = 5000;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private bool NBIOPFJPPJK;

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6138390", Offset = "0x6137790", VA = "0x186138390", Slot = "4")]
	public PMOAFBNPLHC BNACPANAOEJ(string EMIDKKGGDNI, string HDPANMIFFKG, [Optional] MEKBBHHFLDO PKDDAIOFEKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6139790", Offset = "0x6138B90", VA = "0x186139790", Slot = "11")]
	public PMOAFBNPLHC HJMHDPAOPEJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6139920", Offset = "0x6138D20", VA = "0x186139920", Slot = "5")]
	public PMOAFBNPLHC KLJLCPJIADB(MEKBBHHFLDO PKDDAIOFEKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6139300", Offset = "0x6138700", VA = "0x186139300", Slot = "6")]
	public PMOAFBNPLHC HDFKPOIMIIA(MEKBBHHFLDO PKDDAIOFEKG, Dictionary<string, string> GIIMDGFFJEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6138830", Offset = "0x6137C30", VA = "0x186138830", Slot = "7")]
	public bool DMNKGKAIOCB(string JPNCGPPDOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x61388E0", Offset = "0x6137CE0", VA = "0x1861388E0", Slot = "8")]
	public DKBLPLBIMNK EPOBGOPKPGE(string GKGCGBHGGCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6138A00", Offset = "0x6137E00", VA = "0x186138A00", Slot = "9")]
	public JHOOABLONHN GDNAODEGKBI(string OFAEDIBLIFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x61382A0", Offset = "0x61376A0", VA = "0x1861382A0", Slot = "10")]
	public DKBLPLBIMNK BCEKNHADNAD(string NBONGEOCBEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6138AC0", Offset = "0x6137EC0", VA = "0x186138AC0")]
	private JNIPBNFMPJA GMFBPDAJBCL(MEKBBHHFLDO PKDDAIOFEKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x61395F0", Offset = "0x61389F0", VA = "0x1861395F0")]
	private HADIKJDCFKK HHJLHLNDCNG(string HDPANMIFFKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x61390B0", Offset = "0x61384B0", VA = "0x1861390B0")]
	private void GPKGOKAEJBI(string GKGCGBHGGCF, DKBLPLBIMNK HPHLIJIBJEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public NABBADPHHEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xAC51E0", Offset = "0xAC45E0", VA = "0x180AC51E0")]
	[CompilerGenerated]
	private void BACPILLAFPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class CHAOBPBMGOD : COJBCBJOMJK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private COJBCBJOMJK OIOOLLBIJAA;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private COJBCBJOMJK AJDCHLHALFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x61339F0", Offset = "0x6132DF0", VA = "0x1861339F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	[Preserve]
	public CHAOBPBMGOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6133E70", Offset = "0x6133270", VA = "0x186133E70")]
	[ELNMOMKNGKB(LBAHANGFDMJ.GameOnly)]
	private static void LPHLOEKPLLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6133690", Offset = "0x6132A90", VA = "0x186133690", Slot = "4")]
	public PMOAFBNPLHC BNACPANAOEJ(string EMIDKKGGDNI, string HDPANMIFFKG, [Optional] MEKBBHHFLDO PKDDAIOFEKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6133D70", Offset = "0x6133170", VA = "0x186133D70", Slot = "5")]
	public PMOAFBNPLHC KLJLCPJIADB(MEKBBHHFLDO PKDDAIOFEKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6133B60", Offset = "0x6132F60", VA = "0x186133B60", Slot = "6")]
	public PMOAFBNPLHC HDFKPOIMIIA(MEKBBHHFLDO PKDDAIOFEKG, Dictionary<string, string> GIIMDGFFJEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x61338B0", Offset = "0x6132CB0", VA = "0x1861338B0", Slot = "7")]
	public bool DMNKGKAIOCB(string JPNCGPPDOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6133950", Offset = "0x6132D50", VA = "0x186133950", Slot = "8")]
	public DKBLPLBIMNK EPOBGOPKPGE(string GKGCGBHGGCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6133A60", Offset = "0x6132E60", VA = "0x186133A60", Slot = "9")]
	public JHOOABLONHN GDNAODEGKBI(string OFAEDIBLIFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x61335F0", Offset = "0x61329F0", VA = "0x1861335F0", Slot = "10")]
	public DKBLPLBIMNK BCEKNHADNAD(string NBONGEOCBEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6133C70", Offset = "0x6133070", VA = "0x186133C70", Slot = "11")]
	public PMOAFBNPLHC HJMHDPAOPEJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class JGPDBDBMFHP : COJBCBJOMJK
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6137AD0", Offset = "0x6136ED0", VA = "0x186137AD0", Slot = "4")]
	public PMOAFBNPLHC BNACPANAOEJ(string EMIDKKGGDNI, string HDPANMIFFKG, [Optional] MEKBBHHFLDO PKDDAIOFEKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6137CC0", Offset = "0x61370C0", VA = "0x186137CC0", Slot = "5")]
	public PMOAFBNPLHC KLJLCPJIADB(MEKBBHHFLDO PKDDAIOFEKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6137B80", Offset = "0x6136F80", VA = "0x186137B80", Slot = "6")]
	public PMOAFBNPLHC HDFKPOIMIIA(MEKBBHHFLDO PKDDAIOFEKG, Dictionary<string, string> GIIMDGFFJEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6F98E0", Offset = "0x6F8CE0", VA = "0x1806F98E0", Slot = "7")]
	public bool DMNKGKAIOCB(string JPNCGPPDOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6137AC0", Offset = "0x6136EC0", VA = "0x186137AC0", Slot = "8")]
	public DKBLPLBIMNK EPOBGOPKPGE(string GKGCGBHGGCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6137B70", Offset = "0x6136F70", VA = "0x186137B70", Slot = "9")]
	public JHOOABLONHN GDNAODEGKBI(string OFAEDIBLIFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6137AC0", Offset = "0x6136EC0", VA = "0x186137AC0", Slot = "10")]
	public DKBLPLBIMNK BCEKNHADNAD(string NBONGEOCBEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6137C20", Offset = "0x6137020", VA = "0x186137C20", Slot = "11")]
	public PMOAFBNPLHC HJMHDPAOPEJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public JGPDBDBMFHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface IOGILEJELPO
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IsExperimentSegmentActive(string GKGCGBHGGCF, string LKKOHPFCFGD, bool OCGNOGDDBGH = true);
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
			[Cpp2IlInjected.Address(RVA = "0x6E1E40", Offset = "0x6E1240", VA = "0x1806E1E40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E1E40", Offset = "0x6E1240", VA = "0x1806E1E40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string ExperimentSegment
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x613A3C0", Offset = "0x61397C0", VA = "0x18613A3C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public SerializedSplitTestExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface HIFIDBJOBFL
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MGDJHDKDPKB MAJBPDLNINE(string DLLCIGKLPFP);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface HAJIHANPHCH
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MDLCPLADKIM(string MAFDHEKFLMG, string MPLBEDBIAID, string HEBLIJMLFJH);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AOLEOHEFAKC(string MAFDHEKFLMG);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DLFFCKACLCO(string MAFDHEKFLMG, string BHMHLMJPBGF, string JDDIMGKIJAF);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface MEKBBHHFLDO
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool NDIKIMEAAOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool KAFFLJLCIAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool CDFLNDEHNCB
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool JDPHMNBMGDB
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool? ODDAKBOOOIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	int? CFHMFLLJAHN
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	int EJFKCPFPONM
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	string GCHHBNMKECM
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	string FHLEEIIBCCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	string ILMMEDDGPAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	string BOMJNGLCCCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	string FJECJHELFKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	string NBDDMCDMELI
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	double BPNHCFAIIBG
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
		public AmplitudeAnalyticsClient.Settings OCGCLHFJKFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool IJDOGJMBKPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x7D3DD0", Offset = "0x7D31D0", VA = "0x1807D3DD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6E4110", Offset = "0x6E3510", VA = "0x1806E4110")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public enum OLDDCNEKCBI
		{
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			Disabled,
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			RudderStackOnly,
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			Both
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		private enum FAOLCDNGPDH
		{
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		internal class IDFCBDFCNEI
		{
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			private class BNFMCCAKBKI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000076")]
				public int PNHAAFPDCGP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000077")]
				public Dictionary<string, object> AJCDGDBOHGK;

				[Cpp2IlInjected.Token(Token = "0x60000A5")]
				[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
				public BNFMCCAKBKI()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000019")]
			[CompilerGenerated]
			private sealed class EANBFLADFEP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000078")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x60000A6")]
				[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
				public EANBFLADFEP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000A7")]
				[Cpp2IlInjected.Address(RVA = "0x6134BE0", Offset = "0x6133FE0", VA = "0x186134BE0")]
				internal bool <GetBatch>b__0(BNFMCCAKBKI item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private const string CABLJJEBHAG = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private readonly string BENGLHDIHMD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private List<BNFMCCAKBKI> OPABNKGHHFJ;

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			public int? PMDBCBFIMAI
			{
				[Cpp2IlInjected.Token(Token = "0x6000099")]
				[Cpp2IlInjected.Address(RVA = "0x6136720", Offset = "0x6135B20", VA = "0x186136720")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			public int? GBPDJFFIFEC
			{
				[Cpp2IlInjected.Token(Token = "0x600009A")]
				[Cpp2IlInjected.Address(RVA = "0x6136660", Offset = "0x6135A60", VA = "0x186136660")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x6137300", Offset = "0x6136700", VA = "0x186137300")]
			internal IDFCBDFCNEI(string EHGFDAOOGKP, string HDPANMIFFKG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x6136340", Offset = "0x6135740", VA = "0x186136340")]
			public int BDMFPPJPLJE([Optional] int? PLLBMDOMCNJ)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x61360B0", Offset = "0x61354B0", VA = "0x1861360B0")]
			public List<Dictionary<string, object>> AOCGOKEPFNK(int JCNLJDEMALC, int? PLLBMDOMCNJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x6137150", Offset = "0x6136550", VA = "0x186137150")]
			public void PEHMBAFODMB(AmplitudeAnalyticsIdentifyMessage ADHHHFDPAPI, bool KKJFAAGFNHF = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x61371F0", Offset = "0x61365F0", VA = "0x1861371F0")]
			public void PEHMBAFODMB(Dictionary<string, object> ADHHHFDPAPI, bool KKJFAAGFNHF = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x61364D0", Offset = "0x61358D0", VA = "0x1861364D0")]
			public void BHJMNLIPJPN(params Dictionary<string, object>[] OCDMCNCLDLL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x6135E60", Offset = "0x6135260", VA = "0x186135E60")]
			public void ACOOHGAHNDO(List<Dictionary<string, object>> JEDBPHDHBJF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x61367C0", Offset = "0x6135BC0", VA = "0x1861367C0")]
			private void JNNKABEELGN(Dictionary<string, object> ADHHHFDPAPI, bool KKJFAAGFNHF = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x6136DB0", Offset = "0x61361B0", VA = "0x186136DB0")]
			public void NFPEIFHIABH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x6136900", Offset = "0x6135D00", VA = "0x186136900")]
			private void KAJPCKDDBJI([Optional] string ONIMEKFKAGH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x6137020", Offset = "0x6136420", VA = "0x186137020")]
			private static string NPFPAMAPNIL(string JFBPNBNBHOE, string EBOEHIFNNLM)
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
			[Cpp2IlInjected.Address(RVA = "0x613A660", Offset = "0x6139A60", VA = "0x18613A660")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public struct MCKFCHAGOJO<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public int OBHNBAGOABK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public string ICCAPPDFJNF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public T OBHKJJDHGAA;
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class IPIGOMNKGFM : IEnumerator<MOELIBACAGH>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			private MOELIBACAGH <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			private MOELIBACAGH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000B1")]
				[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x783640", Offset = "0x782A40", VA = "0x180783640")]
			[DebuggerHidden]
			public IPIGOMNKGFM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x6137490", Offset = "0x6136890", VA = "0x186137490", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x6137A80", Offset = "0x6136E80", VA = "0x186137A80", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class PNOHGDNDDGO : IEnumerator<object>, IEnumerator, IDisposable
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
			public AEOJOFIFGIK quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000B7")]
				[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x783640", Offset = "0x782A40", VA = "0x180783640")]
			[DebuggerHidden]
			public PNOHGDNDDGO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x613A120", Offset = "0x6139520", VA = "0x18613A120", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x613A210", Offset = "0x6139610", VA = "0x18613A210", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class NHMGLAJKPOM : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x783640", Offset = "0x782A40", VA = "0x180783640")]
			[DebuggerHidden]
			public NHMGLAJKPOM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x6139C00", Offset = "0x6139000", VA = "0x186139C00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x6139D70", Offset = "0x6139170", VA = "0x186139D70", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class OFJAIKBCKLP : IEnumerator<MOELIBACAGH>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			private MOELIBACAGH <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			private MOELIBACAGH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000C3")]
				[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x783640", Offset = "0x782A40", VA = "0x180783640")]
			[DebuggerHidden]
			public OFJAIKBCKLP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x6139E40", Offset = "0x6139240", VA = "0x186139E40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x613A0E0", Offset = "0x61394E0", VA = "0x18613A0E0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class CLJGMJBEFOE : IEnumerator<MOELIBACAGH>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			private MOELIBACAGH <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			private MOELIBACAGH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000CC")]
				[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x783640", Offset = "0x782A40", VA = "0x180783640")]
			[DebuggerHidden]
			public CLJGMJBEFOE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x6133F70", Offset = "0x6133370", VA = "0x186133F70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x6134210", Offset = "0x6133610", VA = "0x186134210", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private sealed class DOGCNIOHNGH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			public List<Dictionary<string, object>> batch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public IDFCBDFCNEI cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
			public DOGCNIOHNGH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x6134250", Offset = "0x6133650", VA = "0x186134250")]
			internal void <FlushFromCache>b__0(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x61345C0", Offset = "0x61339C0", VA = "0x1861345C0")]
			internal void <FlushFromCache>b__1(MCKFCHAGOJO<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class GDBCMHHDPBP : IEnumerator<MOELIBACAGH>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			private MOELIBACAGH <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public IDFCBDFCNEI cache;

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
			private DOGCNIOHNGH <>8__1;

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
			private MOELIBACAGH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000D5")]
				[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x783640", Offset = "0x782A40", VA = "0x180783640")]
			[DebuggerHidden]
			public GDBCMHHDPBP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x6135510", Offset = "0x6134910", VA = "0x186135510", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x6135E20", Offset = "0x6135220", VA = "0x186135E20", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private sealed class JMIMEODLJLG<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x1B71870", Offset = "0x1B70C70", VA = "0x181B71870")]
			public JMIMEODLJLG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x3A99010", Offset = "0x3A98410", VA = "0x183A99010")]
			internal MCKFCHAGOJO<T> <PostRudderStackJson>b__0(EEBCPNJFAKB postResponse)
			{
				return default(MCKFCHAGOJO<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class MHMLGMCJNDH<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x1B71870", Offset = "0x1B70C70", VA = "0x181B71870")]
			public MHMLGMCJNDH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x3A99010", Offset = "0x3A98410", VA = "0x183A99010")]
			internal MCKFCHAGOJO<T> <PostAmplitudeJson>b__0(EEBCPNJFAKB postResponse)
			{
				return default(MCKFCHAGOJO<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private MKBBBKJBKGN DIEDCOKOBBM;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private const string LLPJPLNOLKO = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const string MDINLDJLHKG = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const string MDICBBCPOJB = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private const int NHLDMFIPAGB = 15;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private const int NOEMDNGEJJG = 10;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private const int GMBFOIDOEKK = 5;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private const float HHIFEGIBMNC = 10f;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private const long ACAKIMAHIJK = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private const string EPOJLNKFCJF = "f1779b982f1c09aed3adb3cca563cbc2";

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private const string KBKNHMMAGDC = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private static bool JJHIIAHJFDM;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static bool KHFMBPICIOO;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static int EIBNDGJDCCL;

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private static int GLBGBFKKBPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private EGHEHCFJKDD JDADHJMDFOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private bool OKLIJACGIFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private float MHNJEMLHJJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private float FLCMCJDKAJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private int PCNHLIJJIAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private int IOKCCJFPIDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private int? LJDJOPGPEDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private int? HOGAHIECFIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private long HNAFDNHNHFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private string DIMKBNMBCBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private long IHNLILLGGDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private Dictionary<string, object> KHHDDPACOGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private FAOLCDNGPDH COHKNAAIFOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private int KCELFMPLHEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private int NMBHOIAGEEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private float OGGMPGEPIND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private bool KJPOLPIMDOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x89")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private bool EJKMIFLGCEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private IDFCBDFCNEI DDHOBJIHJLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private IDFCBDFCNEI EELKIMHEAGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private IDFCBDFCNEI DGILPMCEBJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> MEAOEMNJKGN;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo EDCDPNCFENF;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static string MLKFNLCEMPJ;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private const string JAMCGMMBIEL = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly string DKOKNODEBML;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly string PBFEFFFDAKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly string KFMGKNDJEAH;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private MKBBBKJBKGN JFBMNFHLIFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x612E060", Offset = "0x612D460", VA = "0x18612E060")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private static int HFLOAANLOIM
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x612F8B0", Offset = "0x612ECB0", VA = "0x18612F8B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static long KADPDCMBOID
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x6131F60", Offset = "0x6131360", VA = "0x186131F60")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x6132060", Offset = "0x6131460", VA = "0x186132060")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static string NDHJKPBOGHA
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x6131F00", Offset = "0x6131300", VA = "0x186131F00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static string NDFLKLDALLM
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x6131F30", Offset = "0x6131330", VA = "0x186131F30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public string IMEBCKCHFEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x6EC2F0", Offset = "0x6EB6F0", VA = "0x1806EC2F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x6EC5C0", Offset = "0x6EB9C0", VA = "0x1806EC5C0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int? CFHMFLLJAHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x702380", Offset = "0x701780", VA = "0x180702380")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x6EEF70", Offset = "0x6EE370", VA = "0x1806EEF70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public OLDDCNEKCBI? JFCJKOBFPPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8E1270", Offset = "0x8E0670", VA = "0x1808E1270")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x6EEF80", Offset = "0x6EE380", VA = "0x1806EEF80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool NAJADPJEHGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x152D570", Offset = "0x152C970", VA = "0x18152D570")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x1BE1FF0", Offset = "0x1BE13F0", VA = "0x181BE1FF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public static bool FLFAPBPMENO
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x6131E10", Offset = "0x6131210", VA = "0x186131E10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> PCHMADDJEEJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x6131D70", Offset = "0x6131170", VA = "0x186131D70")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x6131FC0", Offset = "0x61313C0", VA = "0x186131FC0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x612D0F0", Offset = "0x612C4F0", VA = "0x18612D0F0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x612EDD0", Offset = "0x612E1D0", VA = "0x18612EDD0")]
		private void HIAIFNFAFOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x61315C0", Offset = "0x61309C0", VA = "0x1861315C0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6130B80", Offset = "0x612FF80", VA = "0x186130B80", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x61318B0", Offset = "0x6130CB0", VA = "0x1861318B0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6130C20", Offset = "0x6130020", VA = "0x186130C20")]
		public PMOAFBNPLHC PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x612F580", Offset = "0x612E980", VA = "0x18612F580")]
		[IteratorStateMachine(typeof(IPIGOMNKGFM))]
		public IEnumerator<MOELIBACAGH> Initialize(AmplitudeAnalyticsEvent KGFPLMBLBAO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x61317A0", Offset = "0x6130BA0", VA = "0x1861317A0")]
		public void UpdateLastAliveTime(float KLCEDMFFMFB = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x612DA60", Offset = "0x612CE60", VA = "0x18612DA60")]
		private PMOAFBNPLHC DFDFLAIOEHI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x612F610", Offset = "0x612EA10", VA = "0x18612F610")]
		private PMOAFBNPLHC JAAJGDAIIGB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6131170", Offset = "0x6130570", VA = "0x186131170")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x61309F0", Offset = "0x612FDF0", VA = "0x1861309F0")]
		[IteratorStateMachine(typeof(PNOHGDNDDGO))]
		private IEnumerator MHHANCOMBDL(AEOJOFIFGIK IACMHMAHPNB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6131B20", Offset = "0x6130F20", VA = "0x186131B20")]
		[IteratorStateMachine(typeof(NHMGLAJKPOM))]
		public IEnumerator WaitForFlush(float JLCJBKDPAKA = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6131680", Offset = "0x6130A80", VA = "0x186131680")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x61315D0", Offset = "0x61309D0", VA = "0x1861315D0")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime KMIINHDMOMG)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x612F1D0", Offset = "0x612E5D0", VA = "0x18612F1D0")]
		public static GCGKPKKKBAM Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x612CF50", Offset = "0x612C350", VA = "0x18612CF50")]
		public static ACEAKGABADC AccountSelectionPostLoginEvent([NotNull] string MELJAODGOBO, string JMOIADKHOGH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x612DC90", Offset = "0x612D090", VA = "0x18612DC90")]
		public static ACEAKGABADC Event([NotNull] string MELJAODGOBO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6130C80", Offset = "0x6130080", VA = "0x186130C80")]
		public static ACEAKGABADC PreviousSessionEvent([NotNull] string MELJAODGOBO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x612F330", Offset = "0x612E730", VA = "0x18612F330")]
		public static ACEAKGABADC InitializeEvent(string JMOIADKHOGH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x61312D0", Offset = "0x61306D0", VA = "0x1861312D0")]
		public static ACEAKGABADC StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x612D500", Offset = "0x612C900", VA = "0x18612D500")]
		public static ACEAKGABADC CreateOutOfSessionEvent(string MELJAODGOBO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6130420", Offset = "0x612F820", VA = "0x186130420")]
		public static PMOAFBNPLHC LogOutOfSessionEvent(ACEAKGABADC JGLGAJHHOKF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6130160", Offset = "0x612F560", VA = "0x186130160")]
		public void LogEventAsync(AmplitudeAnalyticsEvent OAGNIIODIEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x61307C0", Offset = "0x612FBC0", VA = "0x1861307C0")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent OAGNIIODIEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6130910", Offset = "0x612FD10", VA = "0x186130910")]
		public void LogSerializedEventAsync(Dictionary<string, object> MKNAFPAJBLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x61302B0", Offset = "0x612F6B0", VA = "0x1861302B0")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage DAIPGADHDOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x612CE70", Offset = "0x612C270", VA = "0x18612CE70")]
		private void ANLDEPHAFDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x612D7D0", Offset = "0x612CBD0", VA = "0x18612D7D0")]
		private void DBPMCAENHJN(Dictionary<string, object> GIENCMBCINK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x612DE90", Offset = "0x612D290", VA = "0x18612DE90")]
		private void FJKJGPOMLOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x612FF80", Offset = "0x612F380", VA = "0x18612FF80")]
		private void LGIJLFNEOML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x612DF80", Offset = "0x612D380", VA = "0x18612DF80")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6130B00", Offset = "0x612FF00", VA = "0x186130B00")]
		[IteratorStateMachine(typeof(OFJAIKBCKLP))]
		private IEnumerator<MOELIBACAGH> OKIBHFMPCIE(float JLCJBKDPAKA = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6130A80", Offset = "0x612FE80", VA = "0x186130A80")]
		[IteratorStateMachine(typeof(CLJGMJBEFOE))]
		private IEnumerator<MOELIBACAGH> MPBCDBKLHJA(float JLCJBKDPAKA = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x612F0F0", Offset = "0x612E4F0", VA = "0x18612F0F0")]
		[IteratorStateMachine(typeof(GDBCMHHDPBP))]
		private IEnumerator<MOELIBACAGH> HMCJBMLEFOD(IDFCBDFCNEI LDNMOPPGONB, int? PLLBMDOMCNJ, string EPEGOCIFBCB, string OKBMEBLDJOJ, float JLCJBKDPAKA, Action<int> DILBILMKMND)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x612D3E0", Offset = "0x612C7E0", VA = "0x18612D3E0")]
		private static void CNMCMLDEPBG(bool BLDJDKBLJBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x612FA80", Offset = "0x612EE80", VA = "0x18612FA80")]
		private global::HCPIAAEIKCB<MCKFCHAGOJO<Dictionary<string, object>>> KONKODBIICB(string EPEGOCIFBCB, string OKBMEBLDJOJ, string BAFEKGEBAFE, string HGJNHEMFPGD, Dictionary<string, object> OBHKJJDHGAA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x612FC30", Offset = "0x612F030", VA = "0x18612FC30")]
		private global::HCPIAAEIKCB<MCKFCHAGOJO<List<Dictionary<string, object>>>> KONKODBIICB(string EPEGOCIFBCB, string OKBMEBLDJOJ, string BAFEKGEBAFE, string HGJNHEMFPGD, List<Dictionary<string, object>> OBHKJJDHGAA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x383A170", Offset = "0x3839570", VA = "0x18383A170")]
		private global::HCPIAAEIKCB<MCKFCHAGOJO<T>> DICCOOLJLCH<T>(string EPEGOCIFBCB, string OKBMEBLDJOJ, string HGJNHEMFPGD, T OBHKJJDHGAA, Dictionary<string, object> JKKEOCHLNLB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x3839E30", Offset = "0x3839230", VA = "0x183839E30")]
		private global::HCPIAAEIKCB<MCKFCHAGOJO<T>> BDHBHCEPAAC<T>(string EPEGOCIFBCB, string OKBMEBLDJOJ, string BAFEKGEBAFE, T OBHKJJDHGAA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x612E010", Offset = "0x612D410", VA = "0x18612E010")]
		private bool GALKBCBLJEC(float BIAABCJFCOF, float JLCJBKDPAKA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x612E0D0", Offset = "0x612D4D0", VA = "0x18612E0D0")]
		private Dictionary<string, object> HHPDOHHGIJD(string OKBMEBLDJOJ, Dictionary<string, object> OBHKJJDHGAA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6131C00", Offset = "0x6131000", VA = "0x186131C00")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x612DB30", Offset = "0x612CF30", VA = "0x18612DB30")]
		[CompilerGenerated]
		private long DFEMMEHBKOK()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x612CE60", Offset = "0x612C260", VA = "0x18612CE60")]
		[CompilerGenerated]
		private void ACFDMIEDPCA(int GJKBMELFGDM)
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
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x6132C20", Offset = "0x6132020", VA = "0x186132C20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x6132C80", Offset = "0x6132080", VA = "0x186132C80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x77D600", Offset = "0x77CA00", VA = "0x18077D600")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x61320C0", Offset = "0x61314C0", VA = "0x1861320C0")]
		public static ACEAKGABADC BFPHDDBHNEE(string FLPPPNDNNNB, [NotNull] string MGPNMJKAHOK, long HOJKPOFDJIE, long EMKDAKCFFHF, string JMOIADKHOGH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x6132350", Offset = "0x6131750", VA = "0x186132350")]
		public static ACEAKGABADC GAFFGKAKGAK(string FLPPPNDNNNB, [NotNull] string MGPNMJKAHOK, long HOJKPOFDJIE, long EMKDAKCFFHF, string JMOIADKHOGH, long FCAPMKLODGD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6132A60", Offset = "0x6131E60", VA = "0x186132A60")]
		private AmplitudeAnalyticsEvent(string FLPPPNDNNNB, [NotNull] string MGPNMJKAHOK, long HOJKPOFDJIE, long EMKDAKCFFHF, string JMOIADKHOGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0xC268F0", Offset = "0xC25CF0", VA = "0x180C268F0")]
		public void LMJKMOAMEJN(long CDLJDOLCBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x6132940", Offset = "0x6131D40", VA = "0x186132940", Slot = "5")]
		public override void MKCBPJNCGPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x61321B0", Offset = "0x61315B0", VA = "0x1861321B0", Slot = "6")]
		public override void BJLKEBPOOFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6132450", Offset = "0x6131850", VA = "0x186132450", Slot = "4")]
		protected override Dictionary<string, object> KMKACDGFAAG(Dictionary<string, object> CPKKIBGBEFM)
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

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x6134A60", Offset = "0x6133E60", VA = "0x186134A60")]
			public void IIEDNHDELFA(Dictionary<string, object> JEECAEDJDFK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x613A250", Offset = "0x6139650", VA = "0x18613A250")]
			public void IIEDNHDELFA(Dictionary<string, object> KJKMDOBOPHO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x1B266C0", Offset = "0x1B25AC0", VA = "0x181B266C0")]
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
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x6E1E40", Offset = "0x6E1240", VA = "0x1806E1E40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x6E1F10", Offset = "0x6E1310", VA = "0x1806E1F10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6132CF0", Offset = "0x61320F0", VA = "0x186132CF0")]
		public static GCGKPKKKBAM BFPHDDBHNEE(string FLPPPNDNNNB, string JMOIADKHOGH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6133370", Offset = "0x6132770", VA = "0x186133370")]
		protected AmplitudeAnalyticsIdentifyMessage(string FLPPPNDNNNB, string JMOIADKHOGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6132E90", Offset = "0x6132290", VA = "0x186132E90")]
		public Dictionary<string, object> GEKFJMNKCPM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6132FB0", Offset = "0x61323B0", VA = "0x186132FB0", Slot = "4")]
		protected virtual Dictionary<string, object> KMKACDGFAAG(Dictionary<string, object> CPKKIBGBEFM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6132F10", Offset = "0x6132310", VA = "0x186132F10")]
		protected void HEEDIBKKEJF(string EBOEHIFNNLM, Dictionary<string, object> IEMLHKEGFDN, Dictionary<string, object> EINCGGDDECI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6132E20", Offset = "0x6132220", VA = "0x186132E20")]
		protected void FDLAIAMEIGD(string EBOEHIFNNLM, string JFBPNBNBHOE, Dictionary<string, object> PNHOLEPOIAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x61332F0", Offset = "0x61326F0", VA = "0x1861332F0", Slot = "5")]
		public virtual void MKCBPJNCGPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6132DA0", Offset = "0x61321A0", VA = "0x186132DA0", Slot = "6")]
		public virtual void BJLKEBPOOFO()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class GCGKPKKKBAM : global::JLBKONEPHFL<AmplitudeAnalyticsIdentifyMessage, GCGKPKKKBAM>
{
	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public override GCGKPKKKBAM EOPCFMDEAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7260B0", Offset = "0x7254B0", VA = "0x1807260B0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6E1E40", Offset = "0x6E1240", VA = "0x1806E1E40", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage KOFBOKIEAFE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x61354C0", Offset = "0x61348C0", VA = "0x1861354C0")]
	public GCGKPKKKBAM(AmplitudeAnalyticsIdentifyMessage DENPJAMCNLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6135420", Offset = "0x6134820", VA = "0x186135420", Slot = "4")]
	public override void BJLKEBPOOFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class ACEAKGABADC : global::JLBKONEPHFL<AmplitudeAnalyticsEvent, ACEAKGABADC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private bool OPLOKOGHFKA;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public override ACEAKGABADC EOPCFMDEAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7260B0", Offset = "0x7254B0", VA = "0x1807260B0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public long KNNGAJIICLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x612CDF0", Offset = "0x612C1F0", VA = "0x18612CDF0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x612CE10", Offset = "0x612C210", VA = "0x18612CE10")]
	public ACEAKGABADC(AmplitudeAnalyticsEvent DENPJAMCNLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6E1E40", Offset = "0x6E1240", VA = "0x1806E1E40", Slot = "5")]
	public override AmplitudeAnalyticsEvent KOFBOKIEAFE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x612C780", Offset = "0x612BB80", VA = "0x18612C780", Slot = "4")]
	public override void BJLKEBPOOFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x612CA60", Offset = "0x612BE60", VA = "0x18612CA60")]
	public ACEAKGABADC IJBCOBCOBMC(string LKAENGEIFGG, long[] JFBPNBNBHOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x612CBA0", Offset = "0x612BFA0", VA = "0x18612CBA0")]
	public ACEAKGABADC IJBCOBCOBMC(string LKAENGEIFGG, ulong[] JFBPNBNBHOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x213CC00", Offset = "0x213C000", VA = "0x18213CC00")]
	public ACEAKGABADC IJBCOBCOBMC<T>(string LKAENGEIFGG, T[] JFBPNBNBHOE) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x612CD50", Offset = "0x612C150", VA = "0x18612CD50")]
	public ACEAKGABADC IJBCOBCOBMC(string LKAENGEIFGG, string[] JFBPNBNBHOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x213CB90", Offset = "0x213BF90", VA = "0x18213CB90")]
	public ACEAKGABADC IJBCOBCOBMC<T>(string LKAENGEIFGG, T JFBPNBNBHOE) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x612CD60", Offset = "0x612C160", VA = "0x18612CD60")]
	public ACEAKGABADC IJBCOBCOBMC(string LKAENGEIFGG, long JFBPNBNBHOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x612C9D0", Offset = "0x612BDD0", VA = "0x18612C9D0")]
	public ACEAKGABADC IJBCOBCOBMC(string LKAENGEIFGG, ulong JFBPNBNBHOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x612CCE0", Offset = "0x612C0E0", VA = "0x18612CCE0")]
	public ACEAKGABADC IJBCOBCOBMC(string LKAENGEIFGG, string JFBPNBNBHOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x612C9B0", Offset = "0x612BDB0", VA = "0x18612C9B0")]
	public ACEAKGABADC FPEPEHHLFOJ(string LKAENGEIFGG, object? JFBPNBNBHOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x612C820", Offset = "0x612BC20", VA = "0x18612C820")]
	public ACEAKGABADC DMGEGBBODBF(string LKAENGEIFGG, string JFBPNBNBHOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x612C8C0", Offset = "0x612BCC0", VA = "0x18612C8C0")]
	private ACEAKGABADC FDGNNKKPONE(string LKAENGEIFGG, object JFBPNBNBHOE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class BFHOEKJICPJ : ACEAKGABADC
{
	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x612CE10", Offset = "0x612C210", VA = "0x18612CE10")]
	public BFHOEKJICPJ(AmplitudeAnalyticsEvent DENPJAMCNLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6133430", Offset = "0x6132830", VA = "0x186133430", Slot = "4")]
	public override void BJLKEBPOOFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public abstract class JLBKONEPHFL<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : global::JLBKONEPHFL<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	protected M DENPJAMCNLD;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public abstract BLDR EOPCFMDEAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x2B7F450", Offset = "0x2B7E850", VA = "0x182B7F450")]
	public JLBKONEPHFL(M DENPJAMCNLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x3EAD3A0", Offset = "0x3EAC7A0", VA = "0x183EAD3A0")]
	public BLDR MKPNMBNPABO(AmplitudeAnalyticsIdentifyMessage.DeviceInfo PNPHCEMIDPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x3EAD240", Offset = "0x3EAC640", VA = "0x183EAD240")]
	public BLDR CKFDKFGEFGB(AmplitudeAnalyticsIdentifyMessage.RevenueData MFCNOGGOPGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x3EAD120", Offset = "0x3EAC520", VA = "0x183EAD120")]
	public BLDR BCALDLMPLCO(string LKAENGEIFGG, string JFBPNBNBHOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x2721000", Offset = "0x2720400", VA = "0x182721000")]
	public BLDR BCALDLMPLCO<T>(string LKAENGEIFGG, T JFBPNBNBHOE) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x3EAD070", Offset = "0x3EAC470", VA = "0x183EAD070")]
	public BLDR BCALDLMPLCO(string LKAENGEIFGG, long JFBPNBNBHOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x3EAD190", Offset = "0x3EAC590", VA = "0x183EAD190")]
	public BLDR BCALDLMPLCO(string LKAENGEIFGG, ulong JFBPNBNBHOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void BJLKEBPOOFO();

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x3EAD370", Offset = "0x3EAC770", VA = "0x183EAD370")]
	internal static string HNJBKBHJCKG(string JFBPNBNBHOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x3EAD280", Offset = "0x3EAC680", VA = "0x183EAD280")]
	private BLDR HAKOAAENILP(string LKAENGEIFGG, object JFBPNBNBHOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M KOFBOKIEAFE();
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class ONANKADMPPI
{
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public const string ILFPAHAALOJ = "batch";

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public const string HPPGOJPECBA = "type";

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public const string DGELBDPNMCC = "identify";

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public const string PINEPHGMGGB = "track";

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public const string FEJFNBEEAMB = "userId";

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public const string AEKEIGEMEEP = "anonymousId";

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public const string BGHIOICPANA = "messageId";

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public const string DLJCDFNOHMC = "event";

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public const string OGOAAGJNIKP = "version";

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public const string MAJJNFBGCMO = "locale";

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public const string PMCIPILIFKH = "name";

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public const string JJHKOCONCNB = "properties";

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public const string HCMMLDIAHMO = "traits";

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public const string OAMACMDLKFO = "context";

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public const string EOJKPAPEMCA = "app";

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public const string PJAPEKBBJBC = "os";

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public const string IFEMCDMCDGI = "device";

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public const string CNJIGDENHDO = "originalTimestamp";

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public const string OEHODAKCPIL = "brand";

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public const string FKGICPFGEBN = "manufacturer";

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public const string KOGMNNGKOEG = "model";

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public const string CLDPOGBBNJA = "type";

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public ONANKADMPPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class FGOIEIGIGNL
{
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public const int GPLKILLPFGD = 2;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public const int CGEGNJBCLJE = 100;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public const int AIHELLBLJAM = 1000;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public const long PFDHKLAIHFL = 1800000L;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public const int KIIDEBMOCPL = 1024;

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public const int NAFCBKBNACA = 1000;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public const string BJFFODMDIKN = "amplitude_sequence_number";

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public const string BGGOFGCMAGG = "amplitude_user_id";

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public const string PLDGABKIBCD = "amplitude_last_time";

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public const string OCBFLMLHNJD = "initialize_analytics";

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public const string IENKAHDNLAM = "session_start";

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public const string OKAHPGMFKOO = "session_end";

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public const string FBEGPAEKKOD = "insert_id";

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public const string KLMBPKPIEKE = "event_time";

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public const string FLICKFELIPO = "session_id";

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public const string HIFBMIHJMNA = "session_tracking_data";

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public const string BLEMMELLCED = "user_properties";

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public const string HFGEJGHEPDG = "app_version";

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public const string BLDNIEJPDGO = "ip";

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public const string BOLKHFKJHHL = "language";

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public const string IDKAALCHLDG = "platform";

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public const string GMPGFPNJEPL = "os_name";

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public const string CBHBPOJJHLK = "os_version";

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public const string KDNHHOLFDKN = "device_brand";

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public const string JFEFOJKDOHH = "device_manufacturer";

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public const string PMLECABEAIJ = "device_model";

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public const string KLGIFCLJNBH = "device_type";

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public const string HIAFPOLIKKJ = "price";

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public const string EPAHOIEOIEH = "quantity";

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public const string CANNDLGFLFN = "revenue";

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public const string INMKABEEMAG = "productId";

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public const string BLDGENJLDPJ = "revenueType";

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public const string AFCOLPLOBCO = "event_type";

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public const string FEJFNBEEAMB = "user_id";

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public const string BEJLDJPDKEC = "event_properties";

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public const int EGJAOCKMMHC = 10;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> OBAEKMADOGJ;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6135270", Offset = "0x6134670", VA = "0x186135270")]
	internal static bool HLLDHOCHFBG(string EBOEHIFNNLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public FGOIEIGIGNL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface EGHEHCFJKDD
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool EBPLEPCAHLK
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	string HJPMOBKGMKA
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	string IOHEHOMFJNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	string EIFCBIMIPBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	string PJOMPFDPFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::HCPIAAEIKCB<EEBCPNJFAKB> KONKODBIICB(string EPEGOCIFBCB, Dictionary<string, string> DJLFHJPOLAC, bool INBJIFGHHGL = false);

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "6")]
	global::HCPIAAEIKCB<EEBCPNJFAKB> IFIMJHPKAHA(string EPEGOCIFBCB, string FIHFHEELAJD, string LKLNMOPFNGO, string EMLOFDPOOGA);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct EEBCPNJFAKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public readonly int OGMBIENPGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public readonly string HHMMCFGIKJC;

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x7E39E0", Offset = "0x7E2DE0", VA = "0x1807E39E0")]
	public EEBCPNJFAKB(int OBHNBAGOABK, string ICCAPPDFJNF)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class EGIIOKJKKGL
{
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static byte[] LAFDEEMEPDM;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static int AHBPGGLKEKP;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static int MAHPDNGMMFO;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private static BigInteger NMOJFJKJLEG;

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public EGIIOKJKKGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6134C40", Offset = "0x6134040", VA = "0x186134C40")]
	private static string CIEKLEOAFAL(byte[] GPHMIGDKMEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6134D50", Offset = "0x6134150", VA = "0x186134D50")]
	public static string NOFFLEGCGLA(byte[] NPNCGJAPKIL, bool FBFFLNHILGA)
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

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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

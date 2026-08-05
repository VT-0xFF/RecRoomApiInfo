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
		[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40")]
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
		[Cpp2IlInjected.Address(RVA = "0x60DF450", Offset = "0x60DE650", VA = "0x1860DF450")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6E26F0", Offset = "0x6E18F0", VA = "0x1806E26F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9116C0", Offset = "0x9108C0", VA = "0x1809116C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x60DD7A0", Offset = "0x60DC9A0", VA = "0x1860DD7A0")]
	public MGDJHDKDPKB(string DLLCIGKLPFP, float OANDPKHFOFK = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3080090", Offset = "0x307F290", VA = "0x183080090")]
	public void IJBCOBCOBMC<T>(string LKAENGEIFGG, T JFBPNBNBHOE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x60DD630", Offset = "0x60DC830", VA = "0x1860DD630")]
	public void IJBCOBCOBMC(string LKAENGEIFGG, string JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x60DD6B0", Offset = "0x60DC8B0", VA = "0x1860DD6B0")]
	public void PCFCMBMIGGE(string HPDGPGFCDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x60DD450", Offset = "0x60DC650", VA = "0x1860DD450")]
	public void EIKEALGHEPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x60DD510", Offset = "0x60DC710", VA = "0x1860DD510")]
	private void FIGCEMCJMNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x60DD400", Offset = "0x60DC600", VA = "0x1860DD400")]
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
			[Cpp2IlInjected.Address(RVA = "0x6C8AC0", Offset = "0x6C7CC0", VA = "0x1806C8AC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x6C8AC0", Offset = "0x6C7CC0", VA = "0x1806C8AC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6C8120", Offset = "0x6C7320", VA = "0x1806C8120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x60DFAB0", Offset = "0x60DECB0", VA = "0x1860DFAB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x60DDA30", Offset = "0x60DCC30", VA = "0x1860DDA30", Slot = "4")]
	public PMOAFBNPLHC BNACPANAOEJ(string EMIDKKGGDNI, string HDPANMIFFKG, [Optional] MEKBBHHFLDO PKDDAIOFEKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x60DEE30", Offset = "0x60DE030", VA = "0x1860DEE30", Slot = "11")]
	public PMOAFBNPLHC HJMHDPAOPEJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x60DEFC0", Offset = "0x60DE1C0", VA = "0x1860DEFC0", Slot = "5")]
	public PMOAFBNPLHC KLJLCPJIADB(MEKBBHHFLDO PKDDAIOFEKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x60DE9A0", Offset = "0x60DDBA0", VA = "0x1860DE9A0", Slot = "6")]
	public PMOAFBNPLHC HDFKPOIMIIA(MEKBBHHFLDO PKDDAIOFEKG, Dictionary<string, string> GIIMDGFFJEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x60DDED0", Offset = "0x60DD0D0", VA = "0x1860DDED0", Slot = "7")]
	public bool DMNKGKAIOCB(string JPNCGPPDOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x60DDF80", Offset = "0x60DD180", VA = "0x1860DDF80", Slot = "8")]
	public DKBLPLBIMNK EPOBGOPKPGE(string GKGCGBHGGCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x60DE0A0", Offset = "0x60DD2A0", VA = "0x1860DE0A0", Slot = "9")]
	public JHOOABLONHN GDNAODEGKBI(string OFAEDIBLIFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x60DD940", Offset = "0x60DCB40", VA = "0x1860DD940", Slot = "10")]
	public DKBLPLBIMNK BCEKNHADNAD(string NBONGEOCBEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x60DE160", Offset = "0x60DD360", VA = "0x1860DE160")]
	private JNIPBNFMPJA GMFBPDAJBCL(MEKBBHHFLDO PKDDAIOFEKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x60DEC90", Offset = "0x60DDE90", VA = "0x1860DEC90")]
	private HADIKJDCFKK HHJLHLNDCNG(string HDPANMIFFKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x60DE750", Offset = "0x60DD950", VA = "0x1860DE750")]
	private void GPKGOKAEJBI(string GKGCGBHGGCF, DKBLPLBIMNK HPHLIJIBJEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public NABBADPHHEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x1033750", Offset = "0x1032950", VA = "0x181033750")]
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
		[Cpp2IlInjected.Address(RVA = "0x60D9090", Offset = "0x60D8290", VA = "0x1860D9090")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	[Preserve]
	public CHAOBPBMGOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x60D9510", Offset = "0x60D8710", VA = "0x1860D9510")]
	[ELNMOMKNGKB(LBAHANGFDMJ.GameOnly)]
	private static void LPHLOEKPLLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x60D8D30", Offset = "0x60D7F30", VA = "0x1860D8D30", Slot = "4")]
	public PMOAFBNPLHC BNACPANAOEJ(string EMIDKKGGDNI, string HDPANMIFFKG, [Optional] MEKBBHHFLDO PKDDAIOFEKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x60D9410", Offset = "0x60D8610", VA = "0x1860D9410", Slot = "5")]
	public PMOAFBNPLHC KLJLCPJIADB(MEKBBHHFLDO PKDDAIOFEKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x60D9200", Offset = "0x60D8400", VA = "0x1860D9200", Slot = "6")]
	public PMOAFBNPLHC HDFKPOIMIIA(MEKBBHHFLDO PKDDAIOFEKG, Dictionary<string, string> GIIMDGFFJEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x60D8F50", Offset = "0x60D8150", VA = "0x1860D8F50", Slot = "7")]
	public bool DMNKGKAIOCB(string JPNCGPPDOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x60D8FF0", Offset = "0x60D81F0", VA = "0x1860D8FF0", Slot = "8")]
	public DKBLPLBIMNK EPOBGOPKPGE(string GKGCGBHGGCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x60D9100", Offset = "0x60D8300", VA = "0x1860D9100", Slot = "9")]
	public JHOOABLONHN GDNAODEGKBI(string OFAEDIBLIFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x60D8C90", Offset = "0x60D7E90", VA = "0x1860D8C90", Slot = "10")]
	public DKBLPLBIMNK BCEKNHADNAD(string NBONGEOCBEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x60D9310", Offset = "0x60D8510", VA = "0x1860D9310", Slot = "11")]
	public PMOAFBNPLHC HJMHDPAOPEJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class JGPDBDBMFHP : COJBCBJOMJK
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x60DD170", Offset = "0x60DC370", VA = "0x1860DD170", Slot = "4")]
	public PMOAFBNPLHC BNACPANAOEJ(string EMIDKKGGDNI, string HDPANMIFFKG, [Optional] MEKBBHHFLDO PKDDAIOFEKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x60DD360", Offset = "0x60DC560", VA = "0x1860DD360", Slot = "5")]
	public PMOAFBNPLHC KLJLCPJIADB(MEKBBHHFLDO PKDDAIOFEKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x60DD220", Offset = "0x60DC420", VA = "0x1860DD220", Slot = "6")]
	public PMOAFBNPLHC HDFKPOIMIIA(MEKBBHHFLDO PKDDAIOFEKG, Dictionary<string, string> GIIMDGFFJEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6CAD00", Offset = "0x6C9F00", VA = "0x1806CAD00", Slot = "7")]
	public bool DMNKGKAIOCB(string JPNCGPPDOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x60DD160", Offset = "0x60DC360", VA = "0x1860DD160", Slot = "8")]
	public DKBLPLBIMNK EPOBGOPKPGE(string GKGCGBHGGCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x60DD210", Offset = "0x60DC410", VA = "0x1860DD210", Slot = "9")]
	public JHOOABLONHN GDNAODEGKBI(string OFAEDIBLIFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x60DD160", Offset = "0x60DC360", VA = "0x1860DD160", Slot = "10")]
	public DKBLPLBIMNK BCEKNHADNAD(string NBONGEOCBEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x60DD2C0", Offset = "0x60DC4C0", VA = "0x1860DD2C0", Slot = "11")]
	public PMOAFBNPLHC HJMHDPAOPEJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x6C8AC0", Offset = "0x6C7CC0", VA = "0x1806C8AC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x6C8AC0", Offset = "0x6C7CC0", VA = "0x1806C8AC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string ExperimentSegment
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x60DFA60", Offset = "0x60DEC60", VA = "0x1860DFA60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
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

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CLLFCMKGDOM(string LJFJPGNDKGJ, object NPPNMDKDEDG, object PHKFLFFOOPO);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FOIPDAHKHAB(long HOJKPOFDJIE, bool FMDENIMEMFG = true);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface MEKBBHHFLDO
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool NDIKIMEAAOG
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool KAFFLJLCIAM
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool CDFLNDEHNCB
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool JDPHMNBMGDB
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool? ODDAKBOOOIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	int? CFHMFLLJAHN
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	int EJFKCPFPONM
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	string GCHHBNMKECM
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	string FHLEEIIBCCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	string ILMMEDDGPAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	string BOMJNGLCCCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	string FJECJHELFKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	string NBDDMCDMELI
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	double BPNHCFAIIBG
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
		public AmplitudeAnalyticsClient.Settings OCGCLHFJKFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool IJDOGJMBKPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x6E23D0", Offset = "0x6E15D0", VA = "0x1806E23D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xE24550", Offset = "0xE23750", VA = "0x180E24550")]
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

				[Cpp2IlInjected.Token(Token = "0x60000A7")]
				[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
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

				[Cpp2IlInjected.Token(Token = "0x60000A8")]
				[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
				public EANBFLADFEP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000A9")]
				[Cpp2IlInjected.Address(RVA = "0x60DA280", Offset = "0x60D9480", VA = "0x1860DA280")]
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
				[Cpp2IlInjected.Token(Token = "0x600009B")]
				[Cpp2IlInjected.Address(RVA = "0x60DBDC0", Offset = "0x60DAFC0", VA = "0x1860DBDC0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			public int? GBPDJFFIFEC
			{
				[Cpp2IlInjected.Token(Token = "0x600009C")]
				[Cpp2IlInjected.Address(RVA = "0x60DBD00", Offset = "0x60DAF00", VA = "0x1860DBD00")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x60DC9A0", Offset = "0x60DBBA0", VA = "0x1860DC9A0")]
			internal IDFCBDFCNEI(string EHGFDAOOGKP, string HDPANMIFFKG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x60DB9E0", Offset = "0x60DABE0", VA = "0x1860DB9E0")]
			public int BDMFPPJPLJE([Optional] int? PLLBMDOMCNJ)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x60DB750", Offset = "0x60DA950", VA = "0x1860DB750")]
			public List<Dictionary<string, object>> AOCGOKEPFNK(int JCNLJDEMALC, int? PLLBMDOMCNJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x60DC7F0", Offset = "0x60DB9F0", VA = "0x1860DC7F0")]
			public void PEHMBAFODMB(AmplitudeAnalyticsIdentifyMessage ADHHHFDPAPI, bool KKJFAAGFNHF = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x60DC890", Offset = "0x60DBA90", VA = "0x1860DC890")]
			public void PEHMBAFODMB(Dictionary<string, object> ADHHHFDPAPI, bool KKJFAAGFNHF = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x60DBB70", Offset = "0x60DAD70", VA = "0x1860DBB70")]
			public void BHJMNLIPJPN(params Dictionary<string, object>[] OCDMCNCLDLL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x60DB500", Offset = "0x60DA700", VA = "0x1860DB500")]
			public void ACOOHGAHNDO(List<Dictionary<string, object>> JEDBPHDHBJF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x60DBE60", Offset = "0x60DB060", VA = "0x1860DBE60")]
			private void JNNKABEELGN(Dictionary<string, object> ADHHHFDPAPI, bool KKJFAAGFNHF = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x60DC450", Offset = "0x60DB650", VA = "0x1860DC450")]
			public void NFPEIFHIABH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x60DBFA0", Offset = "0x60DB1A0", VA = "0x1860DBFA0")]
			private void KAJPCKDDBJI([Optional] string ONIMEKFKAGH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x60DC6C0", Offset = "0x60DB8C0", VA = "0x1860DC6C0")]
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

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x60DFD00", Offset = "0x60DEF00", VA = "0x1860DFD00")]
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
				[Cpp2IlInjected.Token(Token = "0x60000B3")]
				[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x6CB200", Offset = "0x6CA400", VA = "0x1806CB200")]
			[DebuggerHidden]
			public IPIGOMNKGFM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x60DCB30", Offset = "0x60DBD30", VA = "0x1860DCB30", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x60DD120", Offset = "0x60DC320", VA = "0x1860DD120", Slot = "8")]
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
				[Cpp2IlInjected.Token(Token = "0x60000B9")]
				[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x6CB200", Offset = "0x6CA400", VA = "0x1806CB200")]
			[DebuggerHidden]
			public PNOHGDNDDGO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x60DF7C0", Offset = "0x60DE9C0", VA = "0x1860DF7C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x60DF8B0", Offset = "0x60DEAB0", VA = "0x1860DF8B0", Slot = "8")]
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
				[Cpp2IlInjected.Token(Token = "0x60000BF")]
				[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x6CB200", Offset = "0x6CA400", VA = "0x1806CB200")]
			[DebuggerHidden]
			public NHMGLAJKPOM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x60DF2A0", Offset = "0x60DE4A0", VA = "0x1860DF2A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x60DF410", Offset = "0x60DE610", VA = "0x1860DF410", Slot = "8")]
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
				[Cpp2IlInjected.Token(Token = "0x60000C5")]
				[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x6CB200", Offset = "0x6CA400", VA = "0x1806CB200")]
			[DebuggerHidden]
			public OFJAIKBCKLP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x60DF4E0", Offset = "0x60DE6E0", VA = "0x1860DF4E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x60DF780", Offset = "0x60DE980", VA = "0x1860DF780", Slot = "8")]
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
				[Cpp2IlInjected.Token(Token = "0x60000CE")]
				[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x6CB200", Offset = "0x6CA400", VA = "0x1806CB200")]
			[DebuggerHidden]
			public CLJGMJBEFOE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x60D9610", Offset = "0x60D8810", VA = "0x1860D9610", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x60D98B0", Offset = "0x60D8AB0", VA = "0x1860D98B0", Slot = "8")]
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

			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
			public DOGCNIOHNGH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x60D98F0", Offset = "0x60D8AF0", VA = "0x1860D98F0")]
			internal void <FlushFromCache>b__0(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x60D9C60", Offset = "0x60D8E60", VA = "0x1860D9C60")]
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
				[Cpp2IlInjected.Token(Token = "0x60000D7")]
				[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x6CB200", Offset = "0x6CA400", VA = "0x1806CB200")]
			[DebuggerHidden]
			public GDBCMHHDPBP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x60DABB0", Offset = "0x60D9DB0", VA = "0x1860DABB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x60DB4C0", Offset = "0x60DA6C0", VA = "0x1860DB4C0", Slot = "8")]
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

			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x14F6ED0", Offset = "0x14F60D0", VA = "0x1814F6ED0")]
			public JMIMEODLJLG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x2E5FF30", Offset = "0x2E5F130", VA = "0x182E5FF30")]
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

			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x14F6ED0", Offset = "0x14F60D0", VA = "0x1814F6ED0")]
			public MHMLGMCJNDH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x2E5FF30", Offset = "0x2E5F130", VA = "0x182E5FF30")]
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
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x60D3700", Offset = "0x60D2900", VA = "0x1860D3700")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private static int HFLOAANLOIM
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x60D4F50", Offset = "0x60D4150", VA = "0x1860D4F50")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static long KADPDCMBOID
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x60D7600", Offset = "0x60D6800", VA = "0x1860D7600")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x60D7700", Offset = "0x60D6900", VA = "0x1860D7700")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static string NDHJKPBOGHA
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x60D75A0", Offset = "0x60D67A0", VA = "0x1860D75A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static string NDFLKLDALLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x60D75D0", Offset = "0x60D67D0", VA = "0x1860D75D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public string IMEBCKCHFEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x6DD740", Offset = "0x6DC940", VA = "0x1806DD740")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x6FEDC0", Offset = "0x6FDFC0", VA = "0x1806FEDC0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int? CFHMFLLJAHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x7F7820", Offset = "0x7F6A20", VA = "0x1807F7820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x168BB80", Offset = "0x168AD80", VA = "0x18168BB80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public OLDDCNEKCBI? JFCJKOBFPPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x77F7A0", Offset = "0x77E9A0", VA = "0x18077F7A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x2D387D0", Offset = "0x2D379D0", VA = "0x182D387D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool NAJADPJEHGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x1256860", Offset = "0x1255A60", VA = "0x181256860")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x1255610", Offset = "0x1254810", VA = "0x181255610")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public static bool FLFAPBPMENO
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x60D74B0", Offset = "0x60D66B0", VA = "0x1860D74B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> PCHMADDJEEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x60D7410", Offset = "0x60D6610", VA = "0x1860D7410")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x60D7660", Offset = "0x60D6860", VA = "0x1860D7660")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x60D2790", Offset = "0x60D1990", VA = "0x1860D2790", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x60D4470", Offset = "0x60D3670", VA = "0x1860D4470")]
		private void HIAIFNFAFOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x60D6C60", Offset = "0x60D5E60", VA = "0x1860D6C60")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x60D6220", Offset = "0x60D5420", VA = "0x1860D6220", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x60D6F50", Offset = "0x60D6150", VA = "0x1860D6F50")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x60D62C0", Offset = "0x60D54C0", VA = "0x1860D62C0")]
		public PMOAFBNPLHC PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x60D4C20", Offset = "0x60D3E20", VA = "0x1860D4C20")]
		[IteratorStateMachine(typeof(IPIGOMNKGFM))]
		public IEnumerator<MOELIBACAGH> Initialize(AmplitudeAnalyticsEvent KGFPLMBLBAO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x60D6E40", Offset = "0x60D6040", VA = "0x1860D6E40")]
		public void UpdateLastAliveTime(float KLCEDMFFMFB = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x60D3100", Offset = "0x60D2300", VA = "0x1860D3100")]
		private PMOAFBNPLHC DFDFLAIOEHI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x60D4CB0", Offset = "0x60D3EB0", VA = "0x1860D4CB0")]
		private PMOAFBNPLHC JAAJGDAIIGB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x60D6810", Offset = "0x60D5A10", VA = "0x1860D6810")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x60D6090", Offset = "0x60D5290", VA = "0x1860D6090")]
		[IteratorStateMachine(typeof(PNOHGDNDDGO))]
		private IEnumerator MHHANCOMBDL(AEOJOFIFGIK IACMHMAHPNB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x60D71C0", Offset = "0x60D63C0", VA = "0x1860D71C0")]
		[IteratorStateMachine(typeof(NHMGLAJKPOM))]
		public IEnumerator WaitForFlush(float JLCJBKDPAKA = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x60D6D20", Offset = "0x60D5F20", VA = "0x1860D6D20")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x60D6C70", Offset = "0x60D5E70", VA = "0x1860D6C70")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime KMIINHDMOMG)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x60D4870", Offset = "0x60D3A70", VA = "0x1860D4870")]
		public static GCGKPKKKBAM Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x60D25F0", Offset = "0x60D17F0", VA = "0x1860D25F0")]
		public static ACEAKGABADC AccountSelectionPostLoginEvent([NotNull] string MELJAODGOBO, string JMOIADKHOGH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x60D3330", Offset = "0x60D2530", VA = "0x1860D3330")]
		public static ACEAKGABADC Event([NotNull] string MELJAODGOBO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x60D6320", Offset = "0x60D5520", VA = "0x1860D6320")]
		public static ACEAKGABADC PreviousSessionEvent([NotNull] string MELJAODGOBO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x60D49D0", Offset = "0x60D3BD0", VA = "0x1860D49D0")]
		public static ACEAKGABADC InitializeEvent(string JMOIADKHOGH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x60D6970", Offset = "0x60D5B70", VA = "0x1860D6970")]
		public static ACEAKGABADC StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x60D2BA0", Offset = "0x60D1DA0", VA = "0x1860D2BA0")]
		public static ACEAKGABADC CreateOutOfSessionEvent(string MELJAODGOBO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x60D5AC0", Offset = "0x60D4CC0", VA = "0x1860D5AC0")]
		public static PMOAFBNPLHC LogOutOfSessionEvent(ACEAKGABADC JGLGAJHHOKF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x60D5800", Offset = "0x60D4A00", VA = "0x1860D5800")]
		public void LogEventAsync(AmplitudeAnalyticsEvent OAGNIIODIEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x60D5E60", Offset = "0x60D5060", VA = "0x1860D5E60")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent OAGNIIODIEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x60D5FB0", Offset = "0x60D51B0", VA = "0x1860D5FB0")]
		public void LogSerializedEventAsync(Dictionary<string, object> MKNAFPAJBLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x60D5950", Offset = "0x60D4B50", VA = "0x1860D5950")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage DAIPGADHDOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x60D2510", Offset = "0x60D1710", VA = "0x1860D2510")]
		private void ANLDEPHAFDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x60D2E70", Offset = "0x60D2070", VA = "0x1860D2E70")]
		private void DBPMCAENHJN(Dictionary<string, object> GIENCMBCINK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x60D3530", Offset = "0x60D2730", VA = "0x1860D3530")]
		private void FJKJGPOMLOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x60D5620", Offset = "0x60D4820", VA = "0x1860D5620")]
		private void LGIJLFNEOML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x60D3620", Offset = "0x60D2820", VA = "0x1860D3620")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x60D61A0", Offset = "0x60D53A0", VA = "0x1860D61A0")]
		[IteratorStateMachine(typeof(OFJAIKBCKLP))]
		private IEnumerator<MOELIBACAGH> OKIBHFMPCIE(float JLCJBKDPAKA = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x60D6120", Offset = "0x60D5320", VA = "0x1860D6120")]
		[IteratorStateMachine(typeof(CLJGMJBEFOE))]
		private IEnumerator<MOELIBACAGH> MPBCDBKLHJA(float JLCJBKDPAKA = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x60D4790", Offset = "0x60D3990", VA = "0x1860D4790")]
		[IteratorStateMachine(typeof(GDBCMHHDPBP))]
		private IEnumerator<MOELIBACAGH> HMCJBMLEFOD(IDFCBDFCNEI LDNMOPPGONB, int? PLLBMDOMCNJ, string EPEGOCIFBCB, string OKBMEBLDJOJ, float JLCJBKDPAKA, Action<int> DILBILMKMND)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x60D2A80", Offset = "0x60D1C80", VA = "0x1860D2A80")]
		private static void CNMCMLDEPBG(bool BLDJDKBLJBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x60D5120", Offset = "0x60D4320", VA = "0x1860D5120")]
		private global::HCPIAAEIKCB<MCKFCHAGOJO<Dictionary<string, object>>> KONKODBIICB(string EPEGOCIFBCB, string OKBMEBLDJOJ, string BAFEKGEBAFE, string HGJNHEMFPGD, Dictionary<string, object> OBHKJJDHGAA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x60D52D0", Offset = "0x60D44D0", VA = "0x1860D52D0")]
		private global::HCPIAAEIKCB<MCKFCHAGOJO<List<Dictionary<string, object>>>> KONKODBIICB(string EPEGOCIFBCB, string OKBMEBLDJOJ, string BAFEKGEBAFE, string HGJNHEMFPGD, List<Dictionary<string, object>> OBHKJJDHGAA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x26BB1F0", Offset = "0x26BA3F0", VA = "0x1826BB1F0")]
		private global::HCPIAAEIKCB<MCKFCHAGOJO<T>> DICCOOLJLCH<T>(string EPEGOCIFBCB, string OKBMEBLDJOJ, string HGJNHEMFPGD, T OBHKJJDHGAA, Dictionary<string, object> JKKEOCHLNLB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x26BAEB0", Offset = "0x26BA0B0", VA = "0x1826BAEB0")]
		private global::HCPIAAEIKCB<MCKFCHAGOJO<T>> BDHBHCEPAAC<T>(string EPEGOCIFBCB, string OKBMEBLDJOJ, string BAFEKGEBAFE, T OBHKJJDHGAA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x60D36B0", Offset = "0x60D28B0", VA = "0x1860D36B0")]
		private bool GALKBCBLJEC(float BIAABCJFCOF, float JLCJBKDPAKA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x60D3770", Offset = "0x60D2970", VA = "0x1860D3770")]
		private Dictionary<string, object> HHPDOHHGIJD(string OKBMEBLDJOJ, Dictionary<string, object> OBHKJJDHGAA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x60D72A0", Offset = "0x60D64A0", VA = "0x1860D72A0")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x60D31D0", Offset = "0x60D23D0", VA = "0x1860D31D0")]
		[CompilerGenerated]
		private long DFEMMEHBKOK()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x60D2500", Offset = "0x60D1700", VA = "0x1860D2500")]
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
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x60D82C0", Offset = "0x60D74C0", VA = "0x1860D82C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x60D8320", Offset = "0x60D7520", VA = "0x1860D8320")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x6DD780", Offset = "0x6DC980", VA = "0x1806DD780")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x60D7760", Offset = "0x60D6960", VA = "0x1860D7760")]
		public static ACEAKGABADC BFPHDDBHNEE(string FLPPPNDNNNB, [NotNull] string MGPNMJKAHOK, long HOJKPOFDJIE, long EMKDAKCFFHF, string JMOIADKHOGH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x60D79F0", Offset = "0x60D6BF0", VA = "0x1860D79F0")]
		public static ACEAKGABADC GAFFGKAKGAK(string FLPPPNDNNNB, [NotNull] string MGPNMJKAHOK, long HOJKPOFDJIE, long EMKDAKCFFHF, string JMOIADKHOGH, long FCAPMKLODGD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x60D8100", Offset = "0x60D7300", VA = "0x1860D8100")]
		private AmplitudeAnalyticsEvent(string FLPPPNDNNNB, [NotNull] string MGPNMJKAHOK, long HOJKPOFDJIE, long EMKDAKCFFHF, string JMOIADKHOGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x907070", Offset = "0x906270", VA = "0x180907070")]
		public void LMJKMOAMEJN(long CDLJDOLCBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x60D7FE0", Offset = "0x60D71E0", VA = "0x1860D7FE0", Slot = "5")]
		public override void MKCBPJNCGPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x60D7850", Offset = "0x60D6A50", VA = "0x1860D7850", Slot = "6")]
		public override void BJLKEBPOOFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x60D7AF0", Offset = "0x60D6CF0", VA = "0x1860D7AF0", Slot = "4")]
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

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x60DA100", Offset = "0x60D9300", VA = "0x1860DA100")]
			public void IIEDNHDELFA(Dictionary<string, object> JEECAEDJDFK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x60DF8F0", Offset = "0x60DEAF0", VA = "0x1860DF8F0")]
			public void IIEDNHDELFA(Dictionary<string, object> KJKMDOBOPHO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x11A1430", Offset = "0x11A0630", VA = "0x1811A1430")]
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
			[Cpp2IlInjected.Address(RVA = "0x6C8AC0", Offset = "0x6C7CC0", VA = "0x1806C8AC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x6E7130", Offset = "0x6E6330", VA = "0x1806E7130")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x60D8390", Offset = "0x60D7590", VA = "0x1860D8390")]
		public static GCGKPKKKBAM BFPHDDBHNEE(string FLPPPNDNNNB, string JMOIADKHOGH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x60D8A10", Offset = "0x60D7C10", VA = "0x1860D8A10")]
		protected AmplitudeAnalyticsIdentifyMessage(string FLPPPNDNNNB, string JMOIADKHOGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x60D8530", Offset = "0x60D7730", VA = "0x1860D8530")]
		public Dictionary<string, object> GEKFJMNKCPM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x60D8650", Offset = "0x60D7850", VA = "0x1860D8650", Slot = "4")]
		protected virtual Dictionary<string, object> KMKACDGFAAG(Dictionary<string, object> CPKKIBGBEFM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x60D85B0", Offset = "0x60D77B0", VA = "0x1860D85B0")]
		protected void HEEDIBKKEJF(string EBOEHIFNNLM, Dictionary<string, object> IEMLHKEGFDN, Dictionary<string, object> EINCGGDDECI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x60D84C0", Offset = "0x60D76C0", VA = "0x1860D84C0")]
		protected void FDLAIAMEIGD(string EBOEHIFNNLM, string JFBPNBNBHOE, Dictionary<string, object> PNHOLEPOIAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x60D8990", Offset = "0x60D7B90", VA = "0x1860D8990", Slot = "5")]
		public virtual void MKCBPJNCGPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x60D8440", Offset = "0x60D7640", VA = "0x1860D8440", Slot = "6")]
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
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7E5E00", Offset = "0x7E5000", VA = "0x1807E5E00", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6C8AC0", Offset = "0x6C7CC0", VA = "0x1806C8AC0", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage KOFBOKIEAFE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x60DAB60", Offset = "0x60D9D60", VA = "0x1860DAB60")]
	public GCGKPKKKBAM(AmplitudeAnalyticsIdentifyMessage DENPJAMCNLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x60DAAC0", Offset = "0x60D9CC0", VA = "0x1860DAAC0", Slot = "4")]
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
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7E5E00", Offset = "0x7E5000", VA = "0x1807E5E00", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public long KNNGAJIICLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x60D2490", Offset = "0x60D1690", VA = "0x1860D2490")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x60D24B0", Offset = "0x60D16B0", VA = "0x1860D24B0")]
	public ACEAKGABADC(AmplitudeAnalyticsEvent DENPJAMCNLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6C8AC0", Offset = "0x6C7CC0", VA = "0x1806C8AC0", Slot = "5")]
	public override AmplitudeAnalyticsEvent KOFBOKIEAFE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x60D1E20", Offset = "0x60D1020", VA = "0x1860D1E20", Slot = "4")]
	public override void BJLKEBPOOFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x60D2100", Offset = "0x60D1300", VA = "0x1860D2100")]
	public ACEAKGABADC IJBCOBCOBMC(string LKAENGEIFGG, long[] JFBPNBNBHOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x60D2240", Offset = "0x60D1440", VA = "0x1860D2240")]
	public ACEAKGABADC IJBCOBCOBMC(string LKAENGEIFGG, ulong[] JFBPNBNBHOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x269BE30", Offset = "0x269B030", VA = "0x18269BE30")]
	public ACEAKGABADC IJBCOBCOBMC<T>(string LKAENGEIFGG, T[] JFBPNBNBHOE) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x60D23F0", Offset = "0x60D15F0", VA = "0x1860D23F0")]
	public ACEAKGABADC IJBCOBCOBMC(string LKAENGEIFGG, string[] JFBPNBNBHOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x269BDC0", Offset = "0x269AFC0", VA = "0x18269BDC0")]
	public ACEAKGABADC IJBCOBCOBMC<T>(string LKAENGEIFGG, T JFBPNBNBHOE) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x60D2400", Offset = "0x60D1600", VA = "0x1860D2400")]
	public ACEAKGABADC IJBCOBCOBMC(string LKAENGEIFGG, long JFBPNBNBHOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x60D2070", Offset = "0x60D1270", VA = "0x1860D2070")]
	public ACEAKGABADC IJBCOBCOBMC(string LKAENGEIFGG, ulong JFBPNBNBHOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x60D2380", Offset = "0x60D1580", VA = "0x1860D2380")]
	public ACEAKGABADC IJBCOBCOBMC(string LKAENGEIFGG, string JFBPNBNBHOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x60D2050", Offset = "0x60D1250", VA = "0x1860D2050")]
	public ACEAKGABADC FPEPEHHLFOJ(string LKAENGEIFGG, object? JFBPNBNBHOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x60D1EC0", Offset = "0x60D10C0", VA = "0x1860D1EC0")]
	public ACEAKGABADC DMGEGBBODBF(string LKAENGEIFGG, string JFBPNBNBHOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x60D1F60", Offset = "0x60D1160", VA = "0x1860D1F60")]
	private ACEAKGABADC FDGNNKKPONE(string LKAENGEIFGG, object JFBPNBNBHOE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class BFHOEKJICPJ : ACEAKGABADC
{
	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x60D24B0", Offset = "0x60D16B0", VA = "0x1860D24B0")]
	public BFHOEKJICPJ(AmplitudeAnalyticsEvent DENPJAMCNLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x60D8AD0", Offset = "0x60D7CD0", VA = "0x1860D8AD0", Slot = "4")]
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
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x1CD01B0", Offset = "0x1CCF3B0", VA = "0x181CD01B0")]
	public JLBKONEPHFL(M DENPJAMCNLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x3B1A9B0", Offset = "0x3B19BB0", VA = "0x183B1A9B0")]
	public BLDR MKPNMBNPABO(AmplitudeAnalyticsIdentifyMessage.DeviceInfo PNPHCEMIDPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x3B1A850", Offset = "0x3B19A50", VA = "0x183B1A850")]
	public BLDR CKFDKFGEFGB(AmplitudeAnalyticsIdentifyMessage.RevenueData MFCNOGGOPGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x3B1A730", Offset = "0x3B19930", VA = "0x183B1A730")]
	public BLDR BCALDLMPLCO(string LKAENGEIFGG, string JFBPNBNBHOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x1CE9DB0", Offset = "0x1CE8FB0", VA = "0x181CE9DB0")]
	public BLDR BCALDLMPLCO<T>(string LKAENGEIFGG, T JFBPNBNBHOE) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x3B1A680", Offset = "0x3B19880", VA = "0x183B1A680")]
	public BLDR BCALDLMPLCO(string LKAENGEIFGG, long JFBPNBNBHOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x3B1A7A0", Offset = "0x3B199A0", VA = "0x183B1A7A0")]
	public BLDR BCALDLMPLCO(string LKAENGEIFGG, ulong JFBPNBNBHOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void BJLKEBPOOFO();

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3B1A980", Offset = "0x3B19B80", VA = "0x183B1A980")]
	internal static string HNJBKBHJCKG(string JFBPNBNBHOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3B1A890", Offset = "0x3B19A90", VA = "0x183B1A890")]
	private BLDR HAKOAAENILP(string LKAENGEIFGG, object JFBPNBNBHOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
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

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
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

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x60DA910", Offset = "0x60D9B10", VA = "0x1860DA910")]
	internal static bool HLLDHOCHFBG(string EBOEHIFNNLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
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
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	string HJPMOBKGMKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	string IOHEHOMFJNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	string EIFCBIMIPBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	string PJOMPFDPFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::HCPIAAEIKCB<EEBCPNJFAKB> KONKODBIICB(string EPEGOCIFBCB, Dictionary<string, string> DJLFHJPOLAC, bool INBJIFGHHGL = false);

	[Cpp2IlInjected.Token(Token = "0x6000126")]
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

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6F20B0", Offset = "0x6F12B0", VA = "0x1806F20B0")]
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

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public EGIIOKJKKGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x60DA2E0", Offset = "0x60D94E0", VA = "0x1860DA2E0")]
	private static string CIEKLEOAFAL(byte[] GPHMIGDKMEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x60DA3F0", Offset = "0x60D95F0", VA = "0x1860DA3F0")]
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

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
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

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
		[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6244590", Offset = "0x6243990", VA = "0x186244590")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x778380", Offset = "0x777780", VA = "0x180778380")]
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
		[Cpp2IlInjected.Address(RVA = "0xFCBE90", Offset = "0xFCB290", VA = "0x180FCBE90")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum CLHEJHJAHBM
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
public class KKELPEJLJFP
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private const string EDPHDNENCHI = "timed_flow";

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private const string GFJDBNMHKGL = "flowName";

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private const string PGFFPPAGPCN = "startedAt";

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private const string GLKEGKPKDGI = "endedAt";

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private const string FMBEAAPCBIF = "durationInSeconds";

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private const string PPOHECNLLLN = "failure";

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private const string LDELLJOFKKD = "failureMessage";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private long EMIPLHDHCFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private IGGFPJPDNDC PHPHCCJHKLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private bool EBPGNFJHCJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private float BJDGGDAMOEM;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6241620", Offset = "0x6240A20", VA = "0x186241620")]
	public KKELPEJLJFP(string HCGPNOAACMF, float BJDGGDAMOEM = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x296A040", Offset = "0x2969440", VA = "0x18296A040")]
	public void NAPPCMGNGEE<T>(string JGMFKPLFFDI, T FPLJCBGEJAP) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x62414B0", Offset = "0x62408B0", VA = "0x1862414B0")]
	public void NAPPCMGNGEE(string JGMFKPLFFDI, string FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6241530", Offset = "0x6240930", VA = "0x186241530")]
	public void OLAGJPPHPHG(string OFAGFCNMELJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6241280", Offset = "0x6240680", VA = "0x186241280")]
	public void AGLBOOIHGIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6241340", Offset = "0x6240740", VA = "0x186241340")]
	private void DCKNLOBAEOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6241460", Offset = "0x6240860", VA = "0x186241460")]
	private bool EPIAIOEMOIP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface GGEKGDKECIA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool BFCALEBFFJP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NDNJBANLHJC NPFGFFCDMGH(string CADCPIJFBIA, string EDANCCPGMKH, [Optional] BPODCINFAJK FHOAHIOHPNB);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NDNJBANLHJC MAIGMNGIFPJ(BPODCINFAJK FHOAHIOHPNB);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NDNJBANLHJC JNGJHFFLDIG(BPODCINFAJK FHOAHIOHPNB, Dictionary<string, string> EJFAFBBEGJA);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool MDPMJNHBEAD(string DFFPJJDOMFB);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "5")]
	HPFBDLJHKJO FFKAFKHMHHB(string NKGBMOGPLOG);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "6")]
	KGLGGNKCODP BEHGIFKMMHI(string FCCLLGIGMHH);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "7")]
	HPFBDLJHKJO IAAEGCOAIHC(string ILFBKKOLENH);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "8")]
	NDNJBANLHJC FJIHDCKDEDF();
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
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x705B90", Offset = "0x704F90", VA = "0x180705B90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
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
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x705B90", Offset = "0x704F90", VA = "0x180705B90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x75A350", Offset = "0x759750", VA = "0x18075A350")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6244E10", Offset = "0x6244210", VA = "0x186244E10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class DDKHOOAGANJ : GGEKGDKECIA
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private const string OFAILDOLMHC = "GamePlatform";

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private const string JBKKNKEBDOL = "InteractionCategory";

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private const string PMNFNHJHDOE = "JrActType";

	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private const string NAEANGKEKCH = "IsDeveloper";

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private const string CDLJKHHFOAA = "IsModerator";

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private const string LKPJBMOEDAG = "IsMember";

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private const string GAHCIBPLONJ = "DaysSinceJoiningBucket";

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private const string NLMAJDJNJCP = "AccountCreationTimeAfterEpochMilliseconds";

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private const string PNNAPALGNDG = "InGoodStanding";

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private const string HFEBPBACLKM = "FriendCount";

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private const string AJIFLIFADCP = "LocaleName";

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly IReadOnlyDictionary<string, IJCNEAGLAHO> CDJNKMMLNEE;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private const int JDMFBFDMMIA = 5000;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private bool JAPKBNGHDGB;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool BFCALEBFFJP
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x826290", Offset = "0x825690", VA = "0x180826290", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x623F150", Offset = "0x623E550", VA = "0x18623F150", Slot = "4")]
	public NDNJBANLHJC NPFGFFCDMGH(string CADCPIJFBIA, string EDANCCPGMKH, [Optional] BPODCINFAJK FHOAHIOHPNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x623E1F0", Offset = "0x623D5F0", VA = "0x18623E1F0", Slot = "12")]
	public NDNJBANLHJC FJIHDCKDEDF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x623E900", Offset = "0x623DD00", VA = "0x18623E900", Slot = "6")]
	public NDNJBANLHJC MAIGMNGIFPJ(BPODCINFAJK FHOAHIOHPNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x623E610", Offset = "0x623DA10", VA = "0x18623E610", Slot = "7")]
	public NDNJBANLHJC JNGJHFFLDIG(BPODCINFAJK FHOAHIOHPNB, Dictionary<string, string> EJFAFBBEGJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x623EAB0", Offset = "0x623DEB0", VA = "0x18623EAB0", Slot = "8")]
	public bool MDPMJNHBEAD(string DFFPJJDOMFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x623E0D0", Offset = "0x623D4D0", VA = "0x18623E0D0", Slot = "9")]
	public HPFBDLJHKJO FFKAFKHMHHB(string NKGBMOGPLOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x623E010", Offset = "0x623D410", VA = "0x18623E010", Slot = "10")]
	public KGLGGNKCODP BEHGIFKMMHI(string FCCLLGIGMHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x623E380", Offset = "0x623D780", VA = "0x18623E380", Slot = "11")]
	public HPFBDLJHKJO IAAEGCOAIHC(string ILFBKKOLENH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x623EB60", Offset = "0x623DF60", VA = "0x18623EB60")]
	private CBHAJKJDJEE NMPKKCMJCGP(BPODCINFAJK FHOAHIOHPNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x623E470", Offset = "0x623D870", VA = "0x18623E470")]
	private BBPGAPBEBAB JGPIFLNJCOD(string EDANCCPGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x623F5F0", Offset = "0x623E9F0", VA = "0x18623F5F0")]
	private void PBODMAOGJGN(string NKGBMOGPLOG, HPFBDLJHKJO PNMMLHPKIGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public DDKHOOAGANJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0xBD0220", Offset = "0xBCF620", VA = "0x180BD0220")]
	[CompilerGenerated]
	private void DJMLLNDCOEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class JJHDHDGGDHG : GGEKGDKECIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private GGEKGDKECIA IENBKPMNPIC;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private GGEKGDKECIA LAFDJCIIPKH
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x62409B0", Offset = "0x623FDB0", VA = "0x1862409B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool BFCALEBFFJP
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6240CC0", Offset = "0x62400C0", VA = "0x186240CC0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	[Preserve]
	public JJHDHDGGDHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6240A20", Offset = "0x623FE20", VA = "0x186240A20")]
	[KPHLIICFIPJ(OEKFJILJDLM.GameOnly)]
	private static void CMDKOGFGPHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6241060", Offset = "0x6240460", VA = "0x186241060", Slot = "4")]
	public NDNJBANLHJC NPFGFFCDMGH(string CADCPIJFBIA, string EDANCCPGMKH, [Optional] BPODCINFAJK FHOAHIOHPNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6240EC0", Offset = "0x62402C0", VA = "0x186240EC0", Slot = "6")]
	public NDNJBANLHJC MAIGMNGIFPJ(BPODCINFAJK FHOAHIOHPNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6240DB0", Offset = "0x62401B0", VA = "0x186240DB0", Slot = "7")]
	public NDNJBANLHJC JNGJHFFLDIG(BPODCINFAJK FHOAHIOHPNB, Dictionary<string, string> EJFAFBBEGJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6240FC0", Offset = "0x62403C0", VA = "0x186240FC0", Slot = "8")]
	public bool MDPMJNHBEAD(string DFFPJJDOMFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6240B20", Offset = "0x623FF20", VA = "0x186240B20", Slot = "9")]
	public HPFBDLJHKJO FFKAFKHMHHB(string NKGBMOGPLOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x62408B0", Offset = "0x623FCB0", VA = "0x1862408B0", Slot = "10")]
	public KGLGGNKCODP BEHGIFKMMHI(string FCCLLGIGMHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6240D10", Offset = "0x6240110", VA = "0x186240D10", Slot = "11")]
	public HPFBDLJHKJO IAAEGCOAIHC(string ILFBKKOLENH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6240BC0", Offset = "0x623FFC0", VA = "0x186240BC0", Slot = "12")]
	public NDNJBANLHJC FJIHDCKDEDF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class GIOKONMMOIL : GGEKGDKECIA
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool BFCALEBFFJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x798260", Offset = "0x797660", VA = "0x180798260", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6240030", Offset = "0x623F430", VA = "0x186240030", Slot = "4")]
	public NDNJBANLHJC NPFGFFCDMGH(string CADCPIJFBIA, string EDANCCPGMKH, [Optional] BPODCINFAJK FHOAHIOHPNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x623FF90", Offset = "0x623F390", VA = "0x18623FF90", Slot = "6")]
	public NDNJBANLHJC MAIGMNGIFPJ(BPODCINFAJK FHOAHIOHPNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x623FEF0", Offset = "0x623F2F0", VA = "0x18623FEF0", Slot = "7")]
	public NDNJBANLHJC JNGJHFFLDIG(BPODCINFAJK FHOAHIOHPNB, Dictionary<string, string> EJFAFBBEGJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6C6ED0", Offset = "0x6C62D0", VA = "0x1806C6ED0", Slot = "8")]
	public bool MDPMJNHBEAD(string DFFPJJDOMFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x623FE40", Offset = "0x623F240", VA = "0x18623FE40", Slot = "9")]
	public HPFBDLJHKJO FFKAFKHMHHB(string NKGBMOGPLOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x623FE30", Offset = "0x623F230", VA = "0x18623FE30", Slot = "10")]
	public KGLGGNKCODP BEHGIFKMMHI(string FCCLLGIGMHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x623FE40", Offset = "0x623F240", VA = "0x18623FE40", Slot = "11")]
	public HPFBDLJHKJO IAAEGCOAIHC(string ILFBKKOLENH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x623FE50", Offset = "0x623F250", VA = "0x18623FE50", Slot = "12")]
	public NDNJBANLHJC FJIHDCKDEDF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public GIOKONMMOIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface DMAMONLOFDP
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IsExperimentSegmentActive(string NKGBMOGPLOG, string BHJEKIKEAGI, bool JPFNCGKOFPP = true);
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

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string ExperimentName
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x705B90", Offset = "0x704F90", VA = "0x180705B90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
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

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public string ExperimentName
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x705B90", Offset = "0x704F90", VA = "0x180705B90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string ExperimentSegment
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6244DC0", Offset = "0x62441C0", VA = "0x186244DC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public SerializedSplitTestExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface DDJMANCPKNO
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KKELPEJLJFP KOJIPEIAEHK(string HCGPNOAACMF);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface MDDMOHNNJIM
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KAGPBGODOIG(string OEGBAMNPENI, string DGIECBLIEHJ, string APMMLGCLMFP);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CLGPCIHIDLI(string OEGBAMNPENI);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HLGGPLHBJKA(string OEGBAMNPENI, string IJNOMLNDKCL, string NDGEDGONNCI);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DOJLOMMPLGK(string ILEBAMKAJND, object BDAIDAAAIFA, object BCDICKNMCOJ);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AOPKLILCDNK(long PAEEICPPKGH, bool FPJCDMGMKEK = true);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface BPODCINFAJK
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool NEGAHIAANAK
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool DNAFKGBKCLF
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool BGJDDBEJAPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool IFBMGIMELAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool? PANJEHCPLPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	int? PEFLHAPIDIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	int IMGKCJCILJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	string HAPNOMDBNAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	string ACOKLEHHICJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	string GHNCKMEJEFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	string NNMAOHKMIKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	string CPAIMPHCLPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	string MKLFLNNBCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	double PCLBOJECJJA
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
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

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public AmplitudeAnalyticsClient.Settings BHCFKHOBECG
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool KHABCAAJGNF
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x91B8C0", Offset = "0x91ACC0", VA = "0x18091B8C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x782BC0", Offset = "0x781FC0", VA = "0x180782BC0")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public enum DBMJHDDONEF
		{
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			Disabled,
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			RudderStackOnly,
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			Both
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		private enum NIAGMKIIPLA
		{
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		internal class LFJJAHNKCPD
		{
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			private class FDHHBHFDOJM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000076")]
				public int BFLMPCBBIIG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000077")]
				public Dictionary<string, object> HDDPKNALGHE;

				[Cpp2IlInjected.Token(Token = "0x60000AB")]
				[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
				public FDHHBHFDOJM()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000019")]
			[CompilerGenerated]
			private sealed class HFNFFEIOEEO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000078")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x60000AC")]
				[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
				public HFNFFEIOEEO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000AD")]
				[Cpp2IlInjected.Address(RVA = "0x62400D0", Offset = "0x623F4D0", VA = "0x1862400D0")]
				internal bool <GetBatch>b__0(FDHHBHFDOJM item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private const string DEOEKOIHLMH = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private readonly string NMGICKMLDFI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private List<FDHHBHFDOJM> LHMEFKPPIFK;

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			public int? HDLBCIJHGFA
			{
				[Cpp2IlInjected.Token(Token = "0x600009F")]
				[Cpp2IlInjected.Address(RVA = "0x62437F0", Offset = "0x6242BF0", VA = "0x1862437F0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			public int? EEDFDPODGEI
			{
				[Cpp2IlInjected.Token(Token = "0x60000A0")]
				[Cpp2IlInjected.Address(RVA = "0x6243310", Offset = "0x6242710", VA = "0x186243310")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x6243890", Offset = "0x6242C90", VA = "0x186243890")]
			internal LFJJAHNKCPD(string EANLHJBOPCP, string EDANCCPGMKH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x6242CA0", Offset = "0x62420A0", VA = "0x186242CA0")]
			public int ECEBBJIHKDP([Optional] int? AEJHCIHELOM)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x6242E30", Offset = "0x6242230", VA = "0x186242E30")]
			public List<Dictionary<string, object>> EPEHPICKAHI(int MAJANEAPLDK, int? AEJHCIHELOM)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x62433D0", Offset = "0x62427D0", VA = "0x1862433D0")]
			public void LKENCDHADJH(AmplitudeAnalyticsIdentifyMessage JGHFLANLLNE, bool OMFOIHEEDFG = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x6243470", Offset = "0x6242870", VA = "0x186243470")]
			public void LKENCDHADJH(Dictionary<string, object> JGHFLANLLNE, bool OMFOIHEEDFG = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x62428A0", Offset = "0x6241CA0", VA = "0x1862428A0")]
			public void CMGKGFMLCFE(params Dictionary<string, object>[] FJKBBALLMJD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x62430C0", Offset = "0x62424C0", VA = "0x1862430C0")]
			public void FGHKFDHAIKP(List<Dictionary<string, object>> IBJNCLNBNHP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x6242A30", Offset = "0x6241E30", VA = "0x186242A30")]
			private void DAFKGPGPPIB(Dictionary<string, object> JGHFLANLLNE, bool OMFOIHEEDFG = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x6243580", Offset = "0x6242980", VA = "0x186243580")]
			public void NDOHJFIGJCD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x62423F0", Offset = "0x62417F0", VA = "0x1862423F0")]
			private void BDNCEIFPHCG([Optional] string IFLELKJMIFB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x6242B70", Offset = "0x6241F70", VA = "0x186242B70")]
			private static string DOPMLEGONPF(string FPLJCBGEJAP, string NPBDKCONLNC)
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

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x6245060", Offset = "0x6244460", VA = "0x186245060")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public struct NPMPAKDDEFN<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public int ABGPLEJECOA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public string FLAGJBCOLCD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public T BKMICDGBPAM;
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class OBKADEBOLJL : IEnumerator<HHHNIDIHMIA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			private HHHNIDIHMIA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			private HHHNIDIHMIA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000B7")]
				[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000B9")]
				[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x8815D0", Offset = "0x8809D0", VA = "0x1808815D0")]
			[DebuggerHidden]
			public OBKADEBOLJL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x6244620", Offset = "0x6243A20", VA = "0x186244620", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x6244C10", Offset = "0x6244010", VA = "0x186244C10", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class DMEHAMPNMBK : IEnumerator<object>, IEnumerator, IDisposable
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
			public HAAHJPGNIMD quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000BD")]
				[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000BF")]
				[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x8815D0", Offset = "0x8809D0", VA = "0x1808815D0")]
			[DebuggerHidden]
			public DMEHAMPNMBK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x623F970", Offset = "0x623ED70", VA = "0x18623F970", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x623FA60", Offset = "0x623EE60", VA = "0x18623FA60", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class LMADFBMCKPJ : IEnumerator<object>, IEnumerator, IDisposable
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

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000C3")]
				[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000C5")]
				[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x8815D0", Offset = "0x8809D0", VA = "0x1808815D0")]
			[DebuggerHidden]
			public LMADFBMCKPJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x62443E0", Offset = "0x62437E0", VA = "0x1862443E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x6244550", Offset = "0x6243950", VA = "0x186244550", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class AEGDJKKNDDI : IEnumerator<HHHNIDIHMIA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			private HHHNIDIHMIA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			private HHHNIDIHMIA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000C9")]
				[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000CB")]
				[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x8815D0", Offset = "0x8809D0", VA = "0x1808815D0")]
			[DebuggerHidden]
			public AEGDJKKNDDI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x6237750", Offset = "0x6236B50", VA = "0x186237750", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x62379F0", Offset = "0x6236DF0", VA = "0x1862379F0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class KPGJEKEOAGH : IEnumerator<HHHNIDIHMIA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			private HHHNIDIHMIA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			private HHHNIDIHMIA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000D2")]
				[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000D4")]
				[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x8815D0", Offset = "0x8809D0", VA = "0x1808815D0")]
			[DebuggerHidden]
			public KPGJEKEOAGH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x62417C0", Offset = "0x6240BC0", VA = "0x1862417C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x6241A60", Offset = "0x6240E60", VA = "0x186241A60", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private sealed class LJMJBLLJKHM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			public List<Dictionary<string, object>> batch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public LFJJAHNKCPD cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
			public LJMJBLLJKHM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x6243BD0", Offset = "0x6242FD0", VA = "0x186243BD0")]
			internal void <FlushFromCache>b__0(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x6243F40", Offset = "0x6243340", VA = "0x186243F40")]
			internal void <FlushFromCache>b__1(NPMPAKDDEFN<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class LCHEAEGCALL : IEnumerator<HHHNIDIHMIA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			private HHHNIDIHMIA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public LFJJAHNKCPD cache;

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
			private LJMJBLLJKHM <>8__1;

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

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			private HHHNIDIHMIA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000DB")]
				[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000DD")]
				[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x8815D0", Offset = "0x8809D0", VA = "0x1808815D0")]
			[DebuggerHidden]
			public LCHEAEGCALL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x6241AA0", Offset = "0x6240EA0", VA = "0x186241AA0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x62423B0", Offset = "0x62417B0", VA = "0x1862423B0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private sealed class PNENNDMIBCJ<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x1F13E30", Offset = "0x1F13230", VA = "0x181F13E30")]
			public PNENNDMIBCJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x32D6480", Offset = "0x32D5880", VA = "0x1832D6480")]
			internal NPMPAKDDEFN<T> <PostRudderStackJson>b__0(CDAGOJCFGKK postResponse)
			{
				return default(NPMPAKDDEFN<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class JBJNMCAFIMC<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x1F13E30", Offset = "0x1F13230", VA = "0x181F13E30")]
			public JBJNMCAFIMC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x32D6480", Offset = "0x32D5880", VA = "0x1832D6480")]
			internal NPMPAKDDEFN<T> <PostAmplitudeJson>b__0(CDAGOJCFGKK postResponse)
			{
				return default(NPMPAKDDEFN<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private BEFJBNCFADF FOFFFLMCNKH;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private const string AFFBOCMJPEP = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const string EOLAGINOGEN = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const string FOGLGHMNIKO = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private const int DEIAIKOOEEE = 15;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private const int HIHLMJJEEBE = 10;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private const int HMJNPFEFABI = 5;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private const float IJFMFEJKMFB = 10f;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private const long AIPDGLHCEND = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private const string BAJIKKOHDMH = "f1779b982f1c09aed3adb3cca563cbc2";

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private const string AFDJGPEKDPJ = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private static bool IEDMMGIKCCE;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static bool JKFAACFOHIE;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static int GFDOGKCFOCM;

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private static int DDGFDKCBDJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private CLDAODFEBIB PGFIEDIJEKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private bool IIEDNKLJHLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private float PBBJOICKJNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private float IDGBLKGHCFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private int PKHGKOPBLFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private int JJDLLGNECIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private int? FDPKOMDLFAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private int? NCJNCNCHFIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private long AGFBHBMCEAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private string ILKJPLCAGBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private long PODCBJHNJLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private Dictionary<string, object> FCDNCBHCDEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private NIAGMKIIPLA PIFCDFOCBKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private int DOKGMADPPPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private int HJPPDMINANM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private float PJLAAMFNCKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private bool DLPKCDKHLPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x89")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private bool OCPNKLGFNLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private LFJJAHNKCPD NGFLPCBFGOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private LFJJAHNKCPD DABKHPIGDMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private LFJJAHNKCPD ACMBNIICABB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> FDJMACBAHIM;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo GAJMLIOGIDJ;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static string OFHJGPAHKJD;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private const string HGJPMENBOBF = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly string KCIOMMBGMNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly string LPMBIDOHOPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly string MBKGNNBJCPJ;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private BEFJBNCFADF IMIAIGIGCKF
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x623B660", Offset = "0x623AA60", VA = "0x18623B660")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private static int GDCPDDIBKPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x6237A30", Offset = "0x6236E30", VA = "0x186237A30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public static long LJEINGHJECN
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x623CB40", Offset = "0x623BF40", VA = "0x18623CB40")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x623CC40", Offset = "0x623C040", VA = "0x18623CC40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public static string CCGMNGCBBLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x623CAE0", Offset = "0x623BEE0", VA = "0x18623CAE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public static string DAIJAIPKAOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x623CB10", Offset = "0x623BF10", VA = "0x18623CB10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public string JPHCKLIINFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x78AD20", Offset = "0x78A120", VA = "0x18078AD20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x78AFF0", Offset = "0x78A3F0", VA = "0x18078AFF0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public int? PEFLHAPIDIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x7CA9E0", Offset = "0x7C9DE0", VA = "0x1807CA9E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x78D9A0", Offset = "0x78CDA0", VA = "0x18078D9A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public DBMJHDDONEF? JIPKPDPKMJI
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xA18820", Offset = "0xA17C20", VA = "0x180A18820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x78D9B0", Offset = "0x78CDB0", VA = "0x18078D9B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool GLJGIPOCKAO
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xCE7050", Offset = "0xCE6450", VA = "0x180CE7050")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xCEAC60", Offset = "0xCEA060", VA = "0x180CEAC60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public static bool MKEGCCAOKFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x623C9F0", Offset = "0x623BDF0", VA = "0x18623C9F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> CLOFCKADFMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x623C950", Offset = "0x623BD50", VA = "0x18623C950")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x623CBA0", Offset = "0x623BFA0", VA = "0x18623CBA0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6237DA0", Offset = "0x62371A0", VA = "0x186237DA0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6238090", Offset = "0x6237490", VA = "0x186238090")]
		private void BEGJKNBIDNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x623C1A0", Offset = "0x623B5A0", VA = "0x18623C1A0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x623B6D0", Offset = "0x623AAD0", VA = "0x18623B6D0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x623C490", Offset = "0x623B890", VA = "0x18623C490")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x623B800", Offset = "0x623AC00", VA = "0x18623B800")]
		public NDNJBANLHJC PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x623A860", Offset = "0x6239C60", VA = "0x18623A860")]
		[IteratorStateMachine(typeof(OBKADEBOLJL))]
		public IEnumerator<HHHNIDIHMIA> Initialize(AmplitudeAnalyticsEvent LNMAEKLMMOO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x623C380", Offset = "0x623B780", VA = "0x18623C380")]
		public void UpdateLastAliveTime(float GKOOKPKALDG = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x623A1F0", Offset = "0x62395F0", VA = "0x18623A1F0")]
		private NDNJBANLHJC HKDNJOEGOAN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x623B3C0", Offset = "0x623A7C0", VA = "0x18623B3C0")]
		private NDNJBANLHJC MPKBCCIBDIN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x623BD50", Offset = "0x623B150", VA = "0x18623BD50")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x623B770", Offset = "0x623AB70", VA = "0x18623B770")]
		[IteratorStateMachine(typeof(DMEHAMPNMBK))]
		private IEnumerator PJBHEJACBIN(HAAHJPGNIMD MBLDMIEJOAL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x623C700", Offset = "0x623BB00", VA = "0x18623C700")]
		[IteratorStateMachine(typeof(LMADFBMCKPJ))]
		public IEnumerator WaitForFlush(float OHFDFDCBAGK = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x623C260", Offset = "0x623B660", VA = "0x18623C260")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x623C1B0", Offset = "0x623B5B0", VA = "0x18623C1B0")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime AHNEEFEJHDH)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x623A4B0", Offset = "0x62398B0", VA = "0x18623A4B0")]
		public static JIMDLKKKDOF Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6237C00", Offset = "0x6237000", VA = "0x186237C00")]
		public static IGGFPJPDNDC AccountSelectionPostLoginEvent([NotNull] string IBDGGEIHAOP, string PLPJMJLMOMF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6238D50", Offset = "0x6238150", VA = "0x186238D50")]
		public static IGGFPJPDNDC Event([NotNull] string IBDGGEIHAOP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x623B860", Offset = "0x623AC60", VA = "0x18623B860")]
		public static IGGFPJPDNDC PreviousSessionEvent([NotNull] string IBDGGEIHAOP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x623A610", Offset = "0x6239A10", VA = "0x18623A610")]
		public static IGGFPJPDNDC InitializeEvent(string PLPJMJLMOMF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x623BEB0", Offset = "0x623B2B0", VA = "0x18623BEB0")]
		public static IGGFPJPDNDC StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x62388B0", Offset = "0x6237CB0", VA = "0x1862388B0")]
		public static IGGFPJPDNDC CreateOutOfSessionEvent(string IBDGGEIHAOP, bool EJDCENECOPO = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x623ADA0", Offset = "0x623A1A0", VA = "0x18623ADA0")]
		public static NDNJBANLHJC LogOutOfSessionEvent(IGGFPJPDNDC KAFOGGLHGMK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x623AAE0", Offset = "0x6239EE0", VA = "0x18623AAE0")]
		public void LogEventAsync(AmplitudeAnalyticsEvent JFPEDIGGDMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x623B140", Offset = "0x623A540", VA = "0x18623B140")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent JFPEDIGGDMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x623B290", Offset = "0x623A690", VA = "0x18623B290")]
		public void LogSerializedEventAsync(Dictionary<string, object> IDFNCKEBGLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x623AC30", Offset = "0x623A030", VA = "0x18623AC30")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage GPKJFIIFNKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6238B90", Offset = "0x6237F90", VA = "0x186238B90")]
		private void EBJFKEGGEOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6239260", Offset = "0x6238660", VA = "0x186239260")]
		private void HECKIPGAFNE(Dictionary<string, object> AOHMGFJIPGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x623A340", Offset = "0x6239740", VA = "0x18623A340")]
		private void IBEFDHANNBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x623A900", Offset = "0x6239D00", VA = "0x18623A900")]
		private void LCCCDNPKAOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6239070", Offset = "0x6238470", VA = "0x186239070")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x623A430", Offset = "0x6239830", VA = "0x18623A430")]
		[IteratorStateMachine(typeof(AEGDJKKNDDI))]
		private IEnumerator<HHHNIDIHMIA> INPCLJLPGIN(float OHFDFDCBAGK = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x623A2C0", Offset = "0x62396C0", VA = "0x18623A2C0")]
		[IteratorStateMachine(typeof(KPGJEKEOAGH))]
		private IEnumerator<HHHNIDIHMIA> HLOCMJNGDNA(float OHFDFDCBAGK = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6238C70", Offset = "0x6238070", VA = "0x186238C70")]
		[IteratorStateMachine(typeof(LCHEAEGCALL))]
		private IEnumerator<HHHNIDIHMIA> ECIDFHCCDBA(LFJJAHNKCPD KMIGLIJPMNF, int? AEJHCIHELOM, string NAOGCMAMMGF, string GCCPINKNIGJ, float OHFDFDCBAGK, Action<int> HOADJJPNLIN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6238F50", Offset = "0x6238350", VA = "0x186238F50")]
		private static void FKIIEICIJKD(bool GJELHPAPBIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6238700", Offset = "0x6237B00", VA = "0x186238700")]
		private global::HPHDJAFFHCN<NPMPAKDDEFN<Dictionary<string, object>>> BLHDPEOFAJB(string NAOGCMAMMGF, string GCCPINKNIGJ, string ODOOFKHJGGK, string PAGAIALNIKO, Dictionary<string, object> BKMICDGBPAM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x62383B0", Offset = "0x62377B0", VA = "0x1862383B0")]
		private global::HPHDJAFFHCN<NPMPAKDDEFN<List<Dictionary<string, object>>>> BLHDPEOFAJB(string NAOGCMAMMGF, string GCCPINKNIGJ, string ODOOFKHJGGK, string PAGAIALNIKO, List<Dictionary<string, object>> BKMICDGBPAM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x382B0E0", Offset = "0x382A4E0", VA = "0x18382B0E0")]
		private global::HPHDJAFFHCN<NPMPAKDDEFN<T>> EEINAOPHAKJ<T>(string NAOGCMAMMGF, string GCCPINKNIGJ, string PAGAIALNIKO, T BKMICDGBPAM, Dictionary<string, object> MFFLLDLLCLN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x382B370", Offset = "0x382A770", VA = "0x18382B370")]
		private global::HPHDJAFFHCN<NPMPAKDDEFN<T>> OGEBIOOJLCF<T>(string NAOGCMAMMGF, string GCCPINKNIGJ, string ODOOFKHJGGK, T BKMICDGBPAM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x623B370", Offset = "0x623A770", VA = "0x18623B370")]
		private bool MCHCABKFBJI(float HLGGLCGNNLC, float OHFDFDCBAGK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x62394F0", Offset = "0x62388F0", VA = "0x1862394F0")]
		private Dictionary<string, object> HEHCIHBAPNK(string GCCPINKNIGJ, Dictionary<string, object> BKMICDGBPAM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x623C7E0", Offset = "0x623BBE0", VA = "0x18623C7E0")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6239100", Offset = "0x6238500", VA = "0x186239100")]
		[CompilerGenerated]
		private long GFPDNHOHBEB()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x623A8F0", Offset = "0x6239CF0", VA = "0x18623A8F0")]
		[CompilerGenerated]
		private void KMEAJBAFFCL(int AAMONNCIHPK)
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

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public static string SessionTrackingData
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x623D800", Offset = "0x623CC00", VA = "0x18623D800")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x623D860", Offset = "0x623CC60", VA = "0x18623D860")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x845B40", Offset = "0x844F40", VA = "0x180845B40")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x623D450", Offset = "0x623C850", VA = "0x18623D450")]
		public static IGGFPJPDNDC PELCFOCODBC(string IIMAMIPIKFH, [NotNull] string BGAACJLPLPA, long PAEEICPPKGH, long IFPHCDGOJJL, string PLPJMJLMOMF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x623D540", Offset = "0x623C940", VA = "0x18623D540")]
		public static IGGFPJPDNDC PMGNEJPHJFP(string IIMAMIPIKFH, [NotNull] string BGAACJLPLPA, long PAEEICPPKGH, long IFPHCDGOJJL, string PLPJMJLMOMF, long DBAKGOLMPLK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x623D640", Offset = "0x623CA40", VA = "0x18623D640")]
		private AmplitudeAnalyticsEvent(string IIMAMIPIKFH, [NotNull] string BGAACJLPLPA, long PAEEICPPKGH, long IFPHCDGOJJL, string PLPJMJLMOMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xDA1370", Offset = "0xDA0770", VA = "0x180DA1370")]
		public void EILFGAMAONH(long BFAMHDLGBON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x623D330", Offset = "0x623C730", VA = "0x18623D330", Slot = "5")]
		public override void NANECLDBBCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x623CCA0", Offset = "0x623C0A0", VA = "0x18623CCA0", Slot = "6")]
		public override void CJKFOPLPBPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x623CE40", Offset = "0x623C240", VA = "0x18623CE40", Slot = "4")]
		protected override Dictionary<string, object> GFGOPCCJHBA(Dictionary<string, object> GKKEJFABPIN)
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

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x623FCB0", Offset = "0x623F0B0", VA = "0x18623FCB0")]
			public void BDLJDJKMCNE(Dictionary<string, object> CDINDCFEBMK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
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

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x6244C50", Offset = "0x6244050", VA = "0x186244C50")]
			public void BDLJDJKMCNE(Dictionary<string, object> MLBHHNHKCFM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x1CC7470", Offset = "0x1CC6870", VA = "0x181CC7470")]
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

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		protected string UserId
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x705B90", Offset = "0x704F90", VA = "0x180705B90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x773890", Offset = "0x772C90", VA = "0x180773890")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x623DE30", Offset = "0x623D230", VA = "0x18623DE30")]
		public static JIMDLKKKDOF PELCFOCODBC(string IIMAMIPIKFH, string PLPJMJLMOMF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x623DF50", Offset = "0x623D350", VA = "0x18623DF50")]
		protected AmplitudeAnalyticsIdentifyMessage(string IIMAMIPIKFH, string PLPJMJLMOMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x623DD30", Offset = "0x623D130", VA = "0x18623DD30")]
		public Dictionary<string, object> IDGLDAOGLJM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x623D9F0", Offset = "0x623CDF0", VA = "0x18623D9F0", Slot = "4")]
		protected virtual Dictionary<string, object> GFGOPCCJHBA(Dictionary<string, object> GKKEJFABPIN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x623D950", Offset = "0x623CD50", VA = "0x18623D950")]
		protected void DHCBAMCIMIO(string NPBDKCONLNC, Dictionary<string, object> IKKJKHFDFBP, Dictionary<string, object> MFCNLFPDPOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x623DEE0", Offset = "0x623D2E0", VA = "0x18623DEE0")]
		protected void POICEDEDPHN(string NPBDKCONLNC, string FPLJCBGEJAP, Dictionary<string, object> EGCOOEIAPAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x623DDB0", Offset = "0x623D1B0", VA = "0x18623DDB0", Slot = "5")]
		public virtual void NANECLDBBCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x623D8D0", Offset = "0x623CCD0", VA = "0x18623D8D0", Slot = "6")]
		public virtual void CJKFOPLPBPG()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class JIMDLKKKDOF : global::CCNICLPKAIJ<AmplitudeAnalyticsIdentifyMessage, JIMDLKKKDOF>
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public override JIMDLKKKDOF CMBPHNAJJAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7738A0", Offset = "0x772CA0", VA = "0x1807738A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x705B90", Offset = "0x704F90", VA = "0x180705B90", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage OLAKHGFKJAM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6240860", Offset = "0x623FC60", VA = "0x186240860")]
	public JIMDLKKKDOF(AmplitudeAnalyticsIdentifyMessage CIBBLLOHCGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x62407C0", Offset = "0x623FBC0", VA = "0x1862407C0", Slot = "4")]
	public override void CJKFOPLPBPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class IGGFPJPDNDC : global::CCNICLPKAIJ<AmplitudeAnalyticsEvent, IGGFPJPDNDC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private bool PKFEKOFHNBE;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public override IGGFPJPDNDC CMBPHNAJJAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x7738A0", Offset = "0x772CA0", VA = "0x1807738A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public long OMNPLBGJMNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x62402C0", Offset = "0x623F6C0", VA = "0x1862402C0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x623FC60", Offset = "0x623F060", VA = "0x18623FC60")]
	public IGGFPJPDNDC(AmplitudeAnalyticsEvent CIBBLLOHCGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x705B90", Offset = "0x704F90", VA = "0x180705B90", Slot = "5")]
	public override AmplitudeAnalyticsEvent OLAKHGFKJAM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6240130", Offset = "0x623F530", VA = "0x186240130", Slot = "4")]
	public override void CJKFOPLPBPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x62405B0", Offset = "0x623F9B0", VA = "0x1862405B0")]
	public IGGFPJPDNDC NAPPCMGNGEE(string JGMFKPLFFDI, long[] FPLJCBGEJAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x62402E0", Offset = "0x623F6E0", VA = "0x1862402E0")]
	public IGGFPJPDNDC NAPPCMGNGEE(string JGMFKPLFFDI, ulong[] FPLJCBGEJAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x3428A50", Offset = "0x3427E50", VA = "0x183428A50")]
	public IGGFPJPDNDC NAPPCMGNGEE<T>(string JGMFKPLFFDI, T[] FPLJCBGEJAP) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x62406F0", Offset = "0x623FAF0", VA = "0x1862406F0")]
	public IGGFPJPDNDC NAPPCMGNGEE(string JGMFKPLFFDI, string[] FPLJCBGEJAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x34289E0", Offset = "0x3427DE0", VA = "0x1834289E0")]
	public IGGFPJPDNDC NAPPCMGNGEE<T>(string JGMFKPLFFDI, T FPLJCBGEJAP) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6240520", Offset = "0x623F920", VA = "0x186240520")]
	public IGGFPJPDNDC NAPPCMGNGEE(string JGMFKPLFFDI, long FPLJCBGEJAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6240490", Offset = "0x623F890", VA = "0x186240490")]
	public IGGFPJPDNDC NAPPCMGNGEE(string JGMFKPLFFDI, ulong FPLJCBGEJAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6240420", Offset = "0x623F820", VA = "0x186240420")]
	public IGGFPJPDNDC NAPPCMGNGEE(string JGMFKPLFFDI, string FPLJCBGEJAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x62407A0", Offset = "0x623FBA0", VA = "0x1862407A0")]
	public IGGFPJPDNDC PPALDHIPJCD(string JGMFKPLFFDI, object? FPLJCBGEJAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6240700", Offset = "0x623FB00", VA = "0x186240700")]
	public IGGFPJPDNDC OFEPEDNGEKI(string JGMFKPLFFDI, string FPLJCBGEJAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x62401D0", Offset = "0x623F5D0", VA = "0x1862401D0")]
	private IGGFPJPDNDC FPGIDEJHEDH(string JGMFKPLFFDI, object FPLJCBGEJAP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class DOHPLAPMPNB : IGGFPJPDNDC
{
	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x623FC60", Offset = "0x623F060", VA = "0x18623FC60")]
	public DOHPLAPMPNB(AmplitudeAnalyticsEvent CIBBLLOHCGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x623FAA0", Offset = "0x623EEA0", VA = "0x18623FAA0", Slot = "4")]
	public override void CJKFOPLPBPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public abstract class CCNICLPKAIJ<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : global::CCNICLPKAIJ<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	protected M CIBBLLOHCGM;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public abstract BLDR CMBPHNAJJAA
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x280B190", Offset = "0x280A590", VA = "0x18280B190")]
	public CCNICLPKAIJ(M CIBBLLOHCGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x3B61760", Offset = "0x3B60B60", VA = "0x183B61760")]
	public BLDR KCGBCIENICF(AmplitudeAnalyticsIdentifyMessage.DeviceInfo JDDEDLNIDBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x3B61720", Offset = "0x3B60B20", VA = "0x183B61720")]
	public BLDR DMBMHCGFMCK(AmplitudeAnalyticsIdentifyMessage.RevenueData MDGFIAKEGOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x3B61850", Offset = "0x3B60C50", VA = "0x183B61850")]
	public BLDR MFFHFPBAJNF(string JGMFKPLFFDI, string FPLJCBGEJAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3457DF0", Offset = "0x34571F0", VA = "0x183457DF0")]
	public BLDR MFFHFPBAJNF<T>(string JGMFKPLFFDI, T FPLJCBGEJAP) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3B617A0", Offset = "0x3B60BA0", VA = "0x183B617A0")]
	public BLDR MFFHFPBAJNF(string JGMFKPLFFDI, long FPLJCBGEJAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3B618C0", Offset = "0x3B60CC0", VA = "0x183B618C0")]
	public BLDR MFFHFPBAJNF(string JGMFKPLFFDI, ulong FPLJCBGEJAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void CJKFOPLPBPG();

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3B61A60", Offset = "0x3B60E60", VA = "0x183B61A60")]
	internal static string PHKHFIOEECN(string FPLJCBGEJAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x3B61970", Offset = "0x3B60D70", VA = "0x183B61970")]
	private BLDR ODEKMKCABLF(string JGMFKPLFFDI, object FPLJCBGEJAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M OLAKHGFKJAM();
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class FDJHKAFENAD
{
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public const string HLNPGGEIMKE = "batch";

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public const string OLDNGMFJNGJ = "type";

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public const string BJGILNIINLH = "identify";

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public const string DHNANCAKMJG = "track";

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public const string CGBGMANMIBB = "userId";

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public const string KBGGBLFEGLC = "anonymousId";

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public const string CLCNLABJCLN = "messageId";

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public const string DPNEBCICMOI = "event";

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public const string MNCHNACOGHA = "version";

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public const string MEOPIMACGNE = "locale";

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public const string FEBINJAKBFE = "name";

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public const string EKAKBDCCBGB = "properties";

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public const string LCHPDLKJJFM = "traits";

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public const string COIKPMOOCLB = "context";

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public const string LMFKCOEHLCD = "app";

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public const string MNHCDDNDLHC = "os";

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public const string NAHAMIOOHEP = "device";

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public const string FEOBLLHFBII = "originalTimestamp";

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public const string EIAIGBNCKGI = "brand";

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public const string BCDMPGMLLHH = "manufacturer";

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public const string OFKJJDMLCFI = "model";

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public const string ENNADAPGDGM = "type";

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public FDJHKAFENAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class LIMDFAELEOO
{
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public const int GABECICPMJB = 2;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public const int PPJHNNFHNIA = 100;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public const int ILKCPBFIAPL = 1000;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public const long BBMFLKLOFDF = 1800000L;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public const int OPGEFOJMNNK = 1024;

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public const int AMOHHABLPLF = 1000;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public const string AANBJOABGBJ = "amplitude_sequence_number";

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public const string EOJACEAPDFF = "amplitude_user_id";

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public const string DHCGBBLLDAE = "amplitude_last_time";

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public const string FLGGOEOJHPA = "initialize_analytics";

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public const string NFGOJDEEJDC = "session_start";

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public const string FBGMNNDHCLJ = "session_end";

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public const string FHAHBIICHCN = "insert_id";

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public const string BIFKILCLEMH = "event_time";

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public const string OJKEOPBCMDE = "session_id";

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public const string DMEJEIHBAFN = "session_tracking_data";

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public const string JNFDAMGNEKI = "user_properties";

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public const string EEDBKECIING = "app_version";

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public const string AHGHIGPNOMC = "ip";

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public const string GCAOOHNKFLB = "language";

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public const string KCFLGJFNMEG = "platform";

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public const string HBIBMFLFJPJ = "os_name";

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public const string HNOFGOCGHJA = "os_version";

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public const string EJNFCNKLBFI = "device_brand";

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public const string AEFIPIAOKPB = "device_manufacturer";

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public const string FICBDANNEHP = "device_model";

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public const string BKINNDKMNMI = "device_type";

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public const string KODCKLPDFKI = "price";

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public const string JOCEJFOPPJL = "quantity";

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public const string APMALDNOOLC = "revenue";

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public const string MBAOLFOFCDN = "productId";

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public const string KEMCMIGPPHN = "revenueType";

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public const string JJDLENAICLH = "event_type";

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public const string CGBGMANMIBB = "user_id";

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public const string HOBKBGNPPCE = "event_properties";

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public const int OPGHPEMIJLJ = 10;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> BECJLGEFIJG;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6243A20", Offset = "0x6242E20", VA = "0x186243A20")]
	internal static bool BDJANCKFICG(string NPBDKCONLNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public LIMDFAELEOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface CLDAODFEBIB
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	bool OBNABCDKLIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	string IEDOGFKCJBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	string FCPIIPMCIHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	string PLKMNKHJLLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	string ICMKBKDIIKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::HPHDJAFFHCN<CDAGOJCFGKK> BLHDPEOFAJB(string NAOGCMAMMGF, Dictionary<string, string> OHKCFHJIELD, bool MIEIMJOFAGA = false);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	global::HPHDJAFFHCN<CDAGOJCFGKK> GAELOKDCJME(string NAOGCMAMMGF, string HJOBBMCGJDK, string ECPNJICOAOL, string AIGAKJGJPOD);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct CDAGOJCFGKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public readonly int CHEPHPEPILO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public readonly string AKGMMMPGJAJ;

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x92B460", Offset = "0x92A860", VA = "0x18092B460")]
	public CDAGOJCFGKK(int ABGPLEJECOA, string FLAGJBCOLCD)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class ABFMAPAPCGL
{
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static byte[] CFDBFPKMJCL;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static int NBKCFIGJMGE;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static int BKBNJMLFPCH;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private static BigInteger IHOABMABNGK;

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public ABFMAPAPCGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6237470", Offset = "0x6236870", VA = "0x186237470")]
	private static string OGMGDCCGOFL(byte[] CFEKEMJOJGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6237120", Offset = "0x6236520", VA = "0x186237120")]
	public static string DFBBLGFDDMJ(byte[] GJDBLJLIDDI, bool JLJMGNGGBON)
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

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
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

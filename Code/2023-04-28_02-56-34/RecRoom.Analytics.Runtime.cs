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
		[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x65E8C40", Offset = "0x65E7640", VA = "0x1865E8C40")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x72C090", Offset = "0x72AA90", VA = "0x18072C090")]
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
		[Cpp2IlInjected.Address(RVA = "0xA36880", Offset = "0xA35280", VA = "0x180A36880")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum LNCNJGKNJCA
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
public class JAJCHHAKGHL
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private const string NNBDBIOMICI = "timed_flow";

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private const string BNHMEFIEAGB = "flowName";

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private const string GKECNFNMIFA = "startedAt";

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private const string ABAMGKOJECD = "endedAt";

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private const string HKJIODMDHCG = "durationInSeconds";

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private const string BJDHHCCCMLL = "failure";

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private const string LOOOKKIGBFJ = "failureMessage";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private long PIPGPNCBPDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private DEDFJEOANEB MOEMFLPDFGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private bool BNNPMDCDNGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private float MJPEOFADNMJ;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x65E60A0", Offset = "0x65E4AA0", VA = "0x1865E60A0")]
	public JAJCHHAKGHL(string DGOAHJFPDBN, float MJPEOFADNMJ = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1992AA0", Offset = "0x19914A0", VA = "0x181992AA0")]
	public void HJOANGCMHFN<T>(string GJEJKJANAJD, T LPJDDLMPNCG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x65E5E20", Offset = "0x65E4820", VA = "0x1865E5E20")]
	public void HJOANGCMHFN(string GJEJKJANAJD, string LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x65E5EF0", Offset = "0x65E48F0", VA = "0x1865E5EF0")]
	public void MJJKNIBJNKB(string NPHGNBMLDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x65E5FE0", Offset = "0x65E49E0", VA = "0x1865E5FE0")]
	public void PLEOOGINKDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x65E5D00", Offset = "0x65E4700", VA = "0x1865E5D00")]
	private void CLEPNANHHJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x65E5EA0", Offset = "0x65E48A0", VA = "0x1865E5EA0")]
	private bool KONDHFMOJFJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface IODJOPPJCKG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool CDOMMGFPCNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action GKGHDCIHPCK;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action KNNINIKBGCK;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JKAHJLGEFLE KADCCJJCHBP(string MFIJEMOJNLA, string AKJBPGJIFED, [Optional] ACEGHDJBCOE OCKKJMDJAHB);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "6")]
	JKAHJLGEFLE FLPFFBPLJOG(ACEGHDJBCOE OCKKJMDJAHB);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "7")]
	JKAHJLGEFLE CHCNHOEBENL(ACEGHDJBCOE OCKKJMDJAHB, Dictionary<string, string> OACJPIBDMLL);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool BHAHOHJBGDA(string PFKEMJBOPNP);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "9")]
	BEBPECHBGLI PHEMLCGDPEO(string JJHDHCBILOM);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "10")]
	BNAJGEODMHD HPCOEOCDDOC(string LKHAODBOFMI);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "11")]
	BEBPECHBGLI CCACLFAFMGE(string OAPLFMKFGEO);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "12")]
	JKAHJLGEFLE ADNDKLGKHAH();
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
			[Cpp2IlInjected.Address(RVA = "0x727010", Offset = "0x725A10", VA = "0x180727010")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
			[Cpp2IlInjected.Address(RVA = "0x727010", Offset = "0x725A10", VA = "0x180727010")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x72B250", Offset = "0x729C50", VA = "0x18072B250")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x65E9F50", Offset = "0x65E8950", VA = "0x1865E9F50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class AJAPJNIJNHE : IODJOPPJCKG
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private const string FGKPBLDEBDI = "GamePlatform";

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private const string EAEHAJNBNDA = "InteractionCategory";

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private const string ACIBBMGEIGP = "JrActType";

	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private const string LAECKHFFBFL = "IsDeveloper";

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private const string IPCCOLPMBJA = "IsModerator";

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private const string FHGLJCNMFHG = "IsMember";

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private const string ACCIHAACKKM = "DaysSinceJoiningBucket";

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private const string HGEOMLLDIEP = "AccountCreationTimeAfterEpochMilliseconds";

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private const string FMFBGIKBGGO = "InGoodStanding";

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private const string HGHMLNIJDGO = "FriendCount";

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private const string DMLIMKMLCFI = "LocaleName";

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly IReadOnlyDictionary<string, EEAEEKGFFNI> EDMOPLHAKPN;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private const int KGFBNHOHFOA = 5000;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private bool MCNADHLKJEG;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool CDOMMGFPCNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x754640", Offset = "0x753040", VA = "0x180754640", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action GKGHDCIHPCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x65DBEC0", Offset = "0x65DA8C0", VA = "0x1865DBEC0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x65DD440", Offset = "0x65DBE40", VA = "0x1865DD440", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action KNNINIKBGCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x65DCDA0", Offset = "0x65DB7A0", VA = "0x1865DCDA0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x65DD3A0", Offset = "0x65DBDA0", VA = "0x1865DD3A0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x65DCF00", Offset = "0x65DB900", VA = "0x1865DCF00", Slot = "8")]
	public JKAHJLGEFLE KADCCJJCHBP(string MFIJEMOJNLA, string AKJBPGJIFED, [Optional] ACEGHDJBCOE OCKKJMDJAHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x65DBAE0", Offset = "0x65DA4E0", VA = "0x1865DBAE0", Slot = "16")]
	public JKAHJLGEFLE ADNDKLGKHAH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x65DCB80", Offset = "0x65DB580", VA = "0x1865DCB80", Slot = "10")]
	public JKAHJLGEFLE FLPFFBPLJOG(ACEGHDJBCOE OCKKJMDJAHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x65DC050", Offset = "0x65DAA50", VA = "0x1865DC050", Slot = "11")]
	public JKAHJLGEFLE CHCNHOEBENL(ACEGHDJBCOE OCKKJMDJAHB, Dictionary<string, string> OACJPIBDMLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x65DBE10", Offset = "0x65DA810", VA = "0x1865DBE10", Slot = "12")]
	public bool BHAHOHJBGDA(string PFKEMJBOPNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x65DD570", Offset = "0x65DBF70", VA = "0x1865DD570", Slot = "13")]
	public BEBPECHBGLI PHEMLCGDPEO(string JJHDHCBILOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x65DCE40", Offset = "0x65DB840", VA = "0x1865DCE40", Slot = "14")]
	public BNAJGEODMHD HPCOEOCDDOC(string LKHAODBOFMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x65DBF60", Offset = "0x65DA960", VA = "0x1865DBF60", Slot = "15")]
	public BEBPECHBGLI CCACLFAFMGE(string OAPLFMKFGEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x65DC590", Offset = "0x65DAF90", VA = "0x1865DC590")]
	private OBDDMNCKBPD FIBDBBLMLMH(ACEGHDJBCOE OCKKJMDJAHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x65DBC70", Offset = "0x65DA670", VA = "0x1865DBC70")]
	private CDAECBDFAAK AEINHLNJMKL(string AKJBPGJIFED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x65DC340", Offset = "0x65DAD40", VA = "0x1865DC340")]
	private void ENKDNBMGIHD(string JJHDHCBILOM, BEBPECHBGLI ELAELJDAGOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	public AJAPJNIJNHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x13934D0", Offset = "0x1391ED0", VA = "0x1813934D0")]
	[CompilerGenerated]
	private void FBLJCPIKAFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x65DD4E0", Offset = "0x65DBEE0", VA = "0x1865DD4E0")]
	[CompilerGenerated]
	private void OJLKHALAEEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x65DD690", Offset = "0x65DC090", VA = "0x1865DD690")]
	[CompilerGenerated]
	private void PHKLCHHNHEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class EONFFPCIHPM : IODJOPPJCKG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private IODJOPPJCKG EBNBCHPMEFD;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private IODJOPPJCKG EOOOGHAIOAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x65E5060", Offset = "0x65E3A60", VA = "0x1865E5060")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool CDOMMGFPCNB
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x65E53B0", Offset = "0x65E3DB0", VA = "0x1865E53B0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action GKGHDCIHPCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x65E4B70", Offset = "0x65E3570", VA = "0x1865E4B70", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x65E54A0", Offset = "0x65E3EA0", VA = "0x1865E54A0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action KNNINIKBGCK
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x65E4EC0", Offset = "0x65E38C0", VA = "0x1865E4EC0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x65E5400", Offset = "0x65E3E00", VA = "0x1865E5400", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	[Preserve]
	public EONFFPCIHPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x65E5540", Offset = "0x65E3F40", VA = "0x1865E5540")]
	[JDDIJBKLPJE(GHILFLKBMBN.GameOnly)]
	private static void OCDEDEBHPIB(AOONKACGDKK ONILLNPEPMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x65E50D0", Offset = "0x65E3AD0", VA = "0x1865E50D0", Slot = "8")]
	public JKAHJLGEFLE KADCCJJCHBP(string MFIJEMOJNLA, string AKJBPGJIFED, [Optional] ACEGHDJBCOE OCKKJMDJAHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x65E4DC0", Offset = "0x65E37C0", VA = "0x1865E4DC0", Slot = "10")]
	public JKAHJLGEFLE FLPFFBPLJOG(ACEGHDJBCOE OCKKJMDJAHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x65E4CB0", Offset = "0x65E36B0", VA = "0x1865E4CB0", Slot = "11")]
	public JKAHJLGEFLE CHCNHOEBENL(ACEGHDJBCOE OCKKJMDJAHB, Dictionary<string, string> OACJPIBDMLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x65E4AD0", Offset = "0x65E34D0", VA = "0x1865E4AD0", Slot = "12")]
	public bool BHAHOHJBGDA(string PFKEMJBOPNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x65E5630", Offset = "0x65E4030", VA = "0x1865E5630", Slot = "13")]
	public BEBPECHBGLI PHEMLCGDPEO(string JJHDHCBILOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x65E4F60", Offset = "0x65E3960", VA = "0x1865E4F60", Slot = "14")]
	public BNAJGEODMHD HPCOEOCDDOC(string LKHAODBOFMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x65E4C10", Offset = "0x65E3610", VA = "0x1865E4C10", Slot = "15")]
	public BEBPECHBGLI CCACLFAFMGE(string OAPLFMKFGEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x65E49D0", Offset = "0x65E33D0", VA = "0x1865E49D0", Slot = "16")]
	public JKAHJLGEFLE ADNDKLGKHAH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0xE5FB00", Offset = "0xE5E500", VA = "0x180E5FB00")]
	[CompilerGenerated]
	private void GCBDBDNNCHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0xE601B0", Offset = "0xE5EBB0", VA = "0x180E601B0")]
	[CompilerGenerated]
	private void DDPBEOJAPGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class OPELNAELKGH : IODJOPPJCKG
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool CDOMMGFPCNB
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7319E0", Offset = "0x7303E0", VA = "0x1807319E0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action GKGHDCIHPCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x65E9960", Offset = "0x65E8360", VA = "0x1865E9960", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x65E9D40", Offset = "0x65E8740", VA = "0x1865E9D40", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action KNNINIKBGCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x65E9B50", Offset = "0x65E8550", VA = "0x1865E9B50", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x65E9CA0", Offset = "0x65E86A0", VA = "0x1865E9CA0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x65E9C00", Offset = "0x65E8600", VA = "0x1865E9C00", Slot = "8")]
	public JKAHJLGEFLE KADCCJJCHBP(string MFIJEMOJNLA, string AKJBPGJIFED, [Optional] ACEGHDJBCOE OCKKJMDJAHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x65E9AB0", Offset = "0x65E84B0", VA = "0x1865E9AB0", Slot = "10")]
	public JKAHJLGEFLE FLPFFBPLJOG(ACEGHDJBCOE OCKKJMDJAHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x65E9A10", Offset = "0x65E8410", VA = "0x1865E9A10", Slot = "11")]
	public JKAHJLGEFLE CHCNHOEBENL(ACEGHDJBCOE OCKKJMDJAHB, Dictionary<string, string> OACJPIBDMLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x72A820", Offset = "0x729220", VA = "0x18072A820", Slot = "12")]
	public bool BHAHOHJBGDA(string PFKEMJBOPNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x65E9A00", Offset = "0x65E8400", VA = "0x1865E9A00", Slot = "13")]
	public BEBPECHBGLI PHEMLCGDPEO(string JJHDHCBILOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x65E9BF0", Offset = "0x65E85F0", VA = "0x1865E9BF0", Slot = "14")]
	public BNAJGEODMHD HPCOEOCDDOC(string LKHAODBOFMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x65E9A00", Offset = "0x65E8400", VA = "0x1865E9A00", Slot = "15")]
	public BEBPECHBGLI CCACLFAFMGE(string OAPLFMKFGEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x65E98C0", Offset = "0x65E82C0", VA = "0x1865E98C0", Slot = "16")]
	public JKAHJLGEFLE ADNDKLGKHAH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	public OPELNAELKGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface CHNCCHFNKGF
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JAJCHHAKGHL CFACHIGNGLJ(string DGOAHJFPDBN);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface IOEDIDINOGF
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	long MHGOOGAAFPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IFMDEELFION(string PKDAKJPDDGD, string EMGILIBAICH, string JMNBJPOLLFO);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HPKGCFBMCHG(string PKDAKJPDDGD);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NECLLFGHDAP(string PKDAKJPDDGD, string AMJPNOGENAP, string DLHDOPFDNMK);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HAJAKIADMKC(string IFCELFAKOBP, object NAKCDNLAFIO, object JLDDCNHDGDE);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DLJFOIAPEHN(long EOHIDDNIPKN, bool EKANKPGGCOD = true);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	long IKNJIGPELHJ();

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DOPBKOBMEFF(string AOOHOGKBFOF, string IAJLCFCEIII, DateTime GMBIDOKCHHB, string JALEHBMHNHI, string PKDAKJPDDGD);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface ACEGHDJBCOE
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool AIJPNPLGDLK
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool LCCPAPJOPML
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool KNHNBFANPMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool OEPNBEJEPMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool? LONBNKPMDAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	int? NHKGJJOFFPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int JPKGAIPADPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	string EINOIFGIDBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	string GFPJMDOCNEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	string FICPHMOJDLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	string PPKJHAINBGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	string JMMKKDKJIHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	string JJEACFFOJPA
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	double BFLPENNDNKI
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
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
		public AmplitudeAnalyticsClient.Settings GMJBCGKDOMA
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool PGIJCBHLOBJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x72BD70", Offset = "0x72A770", VA = "0x18072BD70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xE67660", Offset = "0xE66060", VA = "0x180E67660")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		private enum NHEFPDNCJHG
		{
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		internal class LMGOCGLFNLA
		{
			[Cpp2IlInjected.Token(Token = "0x2000014")]
			private class MIBJKPAGFHC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000074")]
				public int NPHNPIIEAIH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000075")]
				public Dictionary<string, object> PLAGLAOAOKC;

				[Cpp2IlInjected.Token(Token = "0x60000B9")]
				[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
				public MIBJKPAGFHC()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000015")]
			[CompilerGenerated]
			private sealed class CLFGPDMJKAA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000076")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x60000BA")]
				[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
				public CLFGPDMJKAA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000BB")]
				[Cpp2IlInjected.Address(RVA = "0x65E3E50", Offset = "0x65E2850", VA = "0x1865E3E50")]
				internal bool <GetBatch>b__0(MIBJKPAGFHC item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000071")]
			private const string GCCFJNFMOKA = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			private readonly string CCJFOCJJBJG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private List<MIBJKPAGFHC> LBJMPAKEDGO;

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			public int? MDGODOPBKDK
			{
				[Cpp2IlInjected.Token(Token = "0x60000AD")]
				[Cpp2IlInjected.Address(RVA = "0x65E7960", Offset = "0x65E6360", VA = "0x1865E7960")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			public int? MPFIENBCBPH
			{
				[Cpp2IlInjected.Token(Token = "0x60000AE")]
				[Cpp2IlInjected.Address(RVA = "0x65E73F0", Offset = "0x65E5DF0", VA = "0x1865E73F0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x65E8890", Offset = "0x65E7290", VA = "0x1865E8890")]
			internal LMGOCGLFNLA(string KGAGAPKOJFN, string AKJBPGJIFED)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x65E85C0", Offset = "0x65E6FC0", VA = "0x1865E85C0")]
			public int NEHCIDNAPMH([Optional] int? DJCANJPHLND)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x65E7C50", Offset = "0x65E6650", VA = "0x1865E7C50")]
			public List<Dictionary<string, object>> GPELNFNOALC(int GJBPBLBLKJD, int? DJCANJPHLND)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x65E8410", Offset = "0x65E6E10", VA = "0x1865E8410")]
			public void KPANBBNPHBO(AmplitudeAnalyticsIdentifyMessage NBNOMDAKOCG, bool HEMLKJCFMMP = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x65E84B0", Offset = "0x65E6EB0", VA = "0x1865E84B0")]
			public void KPANBBNPHBO(Dictionary<string, object> NBNOMDAKOCG, bool HEMLKJCFMMP = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x65E8150", Offset = "0x65E6B50", VA = "0x1865E8150")]
			public void HGDFLKCOPLL(params Dictionary<string, object>[] DNAHDAOENLO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x65E7A00", Offset = "0x65E6400", VA = "0x1865E7A00")]
			public void EKABCHGIEHG(List<Dictionary<string, object>> JOCJJDBNDDK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x65E8750", Offset = "0x65E7150", VA = "0x1865E8750")]
			private void OKAEKNCEOOJ(Dictionary<string, object> NBNOMDAKOCG, bool HEMLKJCFMMP = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x65E7EE0", Offset = "0x65E68E0", VA = "0x1865E7EE0")]
			public void HCIMBFAGEMO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x65E74B0", Offset = "0x65E5EB0", VA = "0x1865E74B0")]
			private void AEJNDNJBEDL([Optional] string KCDOKAJDOKO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x65E82E0", Offset = "0x65E6CE0", VA = "0x1865E82E0")]
			private static string JFPALGMPIFH(string LPJDDLMPNCG, string OGFDNCPKECB)
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

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x65EA1A0", Offset = "0x65E8BA0", VA = "0x1865EA1A0")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public struct FDBKKNCCCFB<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public int KKNAKDFGECM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public string JNBFMKCCJPP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public T LPAILGJIJMP;
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class ICDENGADJHB : IEnumerator<MEOADLJIECK>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private MEOADLJIECK <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			private MEOADLJIECK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000C5")]
				[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000C7")]
				[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x80F8E0", Offset = "0x80E2E0", VA = "0x18080F8E0")]
			[DebuggerHidden]
			public ICDENGADJHB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x65E56D0", Offset = "0x65E40D0", VA = "0x1865E56D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x65E5CC0", Offset = "0x65E46C0", VA = "0x1865E5CC0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class MIBGPJPAOPM : IEnumerator<object>, IEnumerator, IDisposable
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
			public IDFJJMAGGAN quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000CB")]
				[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000CD")]
				[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x80F8E0", Offset = "0x80E2E0", VA = "0x18080F8E0")]
			[DebuggerHidden]
			public MIBGPJPAOPM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x65E8B10", Offset = "0x65E7510", VA = "0x1865E8B10", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x65E8C00", Offset = "0x65E7600", VA = "0x1865E8C00", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class AAEPIBFEMEP : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Token(Token = "0x60000D1")]
				[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000D3")]
				[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x80F8E0", Offset = "0x80E2E0", VA = "0x18080F8E0")]
			[DebuggerHidden]
			public AAEPIBFEMEP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x65DB930", Offset = "0x65DA330", VA = "0x1865DB930", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x65DBAA0", Offset = "0x65DA4A0", VA = "0x1865DBAA0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class CPJNNEKGPGI : IEnumerator<MEOADLJIECK>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private MEOADLJIECK <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			private MEOADLJIECK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000D7")]
				[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000D9")]
				[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x80F8E0", Offset = "0x80E2E0", VA = "0x18080F8E0")]
			[DebuggerHidden]
			public CPJNNEKGPGI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x65E3EB0", Offset = "0x65E28B0", VA = "0x1865E3EB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x65E4150", Offset = "0x65E2B50", VA = "0x1865E4150", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class OJOJHPLGMIF : IEnumerator<MEOADLJIECK>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			private MEOADLJIECK <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			private MEOADLJIECK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000E0")]
				[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000E2")]
				[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x80F8E0", Offset = "0x80E2E0", VA = "0x18080F8E0")]
			[DebuggerHidden]
			public OJOJHPLGMIF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x65E95E0", Offset = "0x65E7FE0", VA = "0x1865E95E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x65E9880", Offset = "0x65E8280", VA = "0x1865E9880", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class LHIBNOMGHFG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public List<Dictionary<string, object>> batch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public LMGOCGLFNLA cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
			public LHIBNOMGHFG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x65E6A30", Offset = "0x65E5430", VA = "0x1865E6A30")]
			internal void <FlushFromCache>b__0(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x65E6DA0", Offset = "0x65E57A0", VA = "0x1865E6DA0")]
			internal void <FlushFromCache>b__1(FDBKKNCCCFB<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class OIKNBIOAJPF : IEnumerator<MEOADLJIECK>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			private MEOADLJIECK <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public LMGOCGLFNLA cache;

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
			private LHIBNOMGHFG <>8__1;

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
			private MEOADLJIECK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000E9")]
				[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000EB")]
				[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x80F8E0", Offset = "0x80E2E0", VA = "0x18080F8E0")]
			[DebuggerHidden]
			public OIKNBIOAJPF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x65E8CD0", Offset = "0x65E76D0", VA = "0x1865E8CD0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x65E95A0", Offset = "0x65E7FA0", VA = "0x1865E95A0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[CompilerGenerated]
		private sealed class IALLPDGOCDE<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x13760C0", Offset = "0x1374AC0", VA = "0x1813760C0")]
			public IALLPDGOCDE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x2AA8130", Offset = "0x2AA6B30", VA = "0x182AA8130")]
			internal FDBKKNCCCFB<T> <PostRudderStackJson>b__0(PGALIBCKNEJ postResponse)
			{
				return default(FDBKKNCCCFB<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class AFEGGJKENLA<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x13760C0", Offset = "0x1374AC0", VA = "0x1813760C0")]
			public AFEGGJKENLA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x2AA8130", Offset = "0x2AA6B30", VA = "0x182AA8130")]
			internal FDBKKNCCCFB<T> <PostAmplitudeJson>b__0(PGALIBCKNEJ postResponse)
			{
				return default(FDBKKNCCCFB<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private ENIMFIBLMKI BNPNAIHHGKO;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private const string PPKGPCEGFAI = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private const string PDIOGHICIHC = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private const string OCDJEBEMEFD = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private const int EDLLBEJLAIO = 15;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private const int BJIDOFDGGOJ = 10;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private const int PKLCNGPLEID = 5;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private const float KCEEFDPAKDO = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private const long GPMIDFHAAJE = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private const string COAHKJLBOHI = "f1779b982f1c09aed3adb3cca563cbc2";

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private const string GNNOCKGGMHF = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private static bool LEJDIIEOMAE;

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private static bool INFCFJFNGBI;

		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private static int EDKBDALONNJ;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static int DEEGCNKOHMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private EHFHANGOAHP HOEFJICEKFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private bool DCHDACMEIJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private float HAIKAAFBNHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private float EFBHAFAKEOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private int CNKFKEJLILK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private int CMMBFOHPHPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private int? FBCGKIKIIGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private int? FOLDEHNAFPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private long DCFCBIKMGBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private string OCBBAADCHOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private long KGFPJCDGLMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private Dictionary<string, object> EIIFNJBPDGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private NHEFPDNCJHG INBMCBJINLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private int GMHBIEFFCOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private int EHJGDMJNGLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private float FLEHLKDFHHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private bool CMCBACCLGPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x89")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private bool PFPCCKCIHLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private LMGOCGLFNLA CBIOGCDCJOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private LMGOCGLFNLA KLLMAPCMAPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private LMGOCGLFNLA NMHALPDALCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> OLELICMINFE;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo OEKDGCBPLAE;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static string PPKEICEFBLC;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private const string NBDAKHABGLE = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly string LHIGJENNODD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private readonly string PLMKGGEIILL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private readonly string ELDEHADNOEI;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private ENIMFIBLMKI MFKJGOHOLHL
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x65E0970", Offset = "0x65DF370", VA = "0x1865E0970")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private static int EFLBFNLGCID
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x65DDCE0", Offset = "0x65DC6E0", VA = "0x1865DDCE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static long POALAMEILIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x65E2810", Offset = "0x65E1210", VA = "0x1865E2810")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x65E2910", Offset = "0x65E1310", VA = "0x1865E2910")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public static string CFGDLMEDKNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x65E27B0", Offset = "0x65E11B0", VA = "0x1865E27B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public static string PDMAKKKIODA
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x65E27E0", Offset = "0x65E11E0", VA = "0x1865E27E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public string ODKIPFACBAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x727080", Offset = "0x725A80", VA = "0x180727080")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x748830", Offset = "0x747230", VA = "0x180748830")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int? NHKGJJOFFPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x82B350", Offset = "0x829D50", VA = "0x18082B350")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x16FCC90", Offset = "0x16FB690", VA = "0x1816FCC90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool OEMDIOBAJPN
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x874360", Offset = "0x872D60", VA = "0x180874360")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x874460", Offset = "0x872E60", VA = "0x180874460")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public static bool PNNIOGGNFEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x65E26C0", Offset = "0x65E10C0", VA = "0x1865E26C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<bool> DBHAIAHEJPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x65E2620", Offset = "0x65E1020", VA = "0x1865E2620")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x65E2870", Offset = "0x65E1270", VA = "0x1865E2870")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x65DD9F0", Offset = "0x65DC3F0", VA = "0x1865DD9F0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x65DFC80", Offset = "0x65DE680", VA = "0x1865DFC80")]
		private void EPCCEILNEAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x65E1E70", Offset = "0x65E0870", VA = "0x1865E1E70")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x65E1430", Offset = "0x65DFE30", VA = "0x1865E1430", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x65E2160", Offset = "0x65E0B60", VA = "0x1865E2160")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x65E14D0", Offset = "0x65DFED0", VA = "0x1865E14D0")]
		public JKAHJLGEFLE PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x65E0860", Offset = "0x65DF260", VA = "0x1865E0860")]
		[IteratorStateMachine(typeof(ICDENGADJHB))]
		public IEnumerator<MEOADLJIECK> Initialize(AmplitudeAnalyticsEvent POPGDPPPGCM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x65E2050", Offset = "0x65E0A50", VA = "0x1865E2050")]
		public void UpdateLastAliveTime(float FFHPDJCFLBI = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x65DF820", Offset = "0x65DE220", VA = "0x1865DF820")]
		private JKAHJLGEFLE DEIJLKCFCCK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x65DF8F0", Offset = "0x65DE2F0", VA = "0x1865DF8F0")]
		private JKAHJLGEFLE DKLDFHAMBLE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x65E1A20", Offset = "0x65E0420", VA = "0x1865E1A20")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x65E03A0", Offset = "0x65DEDA0", VA = "0x1865E03A0")]
		[IteratorStateMachine(typeof(MIBGPJPAOPM))]
		private IEnumerator HAAEGJJJNNC(IDFJJMAGGAN HAGLICANIBG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x65E23D0", Offset = "0x65E0DD0", VA = "0x1865E23D0")]
		[IteratorStateMachine(typeof(AAEPIBFEMEP))]
		public IEnumerator WaitForFlush(float AOEGDFNBHBG = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x65E1F30", Offset = "0x65E0930", VA = "0x1865E1F30")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x65E1E80", Offset = "0x65E0880", VA = "0x1865E1E80")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime LAOEDLDFAJL)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x65E04B0", Offset = "0x65DEEB0", VA = "0x1865E04B0")]
		public static MBMMOOPEJDA Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x65DD850", Offset = "0x65DC250", VA = "0x1865DD850")]
		public static DEDFJEOANEB AccountSelectionPostLoginEvent([NotNull] string MLJJKDLKJBF, string BKFMEKLDIBK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x65DFFA0", Offset = "0x65DE9A0", VA = "0x1865DFFA0")]
		public static DEDFJEOANEB Event([NotNull] string MLJJKDLKJBF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x65E1530", Offset = "0x65DFF30", VA = "0x1865E1530")]
		public static DEDFJEOANEB PreviousSessionEvent([NotNull] string MLJJKDLKJBF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x65E0610", Offset = "0x65DF010", VA = "0x1865E0610")]
		public static DEDFJEOANEB InitializeEvent(string BKFMEKLDIBK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x65E1B80", Offset = "0x65E0580", VA = "0x1865E1B80")]
		public static DEDFJEOANEB StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x65DF140", Offset = "0x65DDB40", VA = "0x1865DF140")]
		public static DEDFJEOANEB CreateOutOfSessionEvent(string MLJJKDLKJBF, bool DOHLDJKGKPP = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x65E0D90", Offset = "0x65DF790", VA = "0x1865E0D90")]
		public static JKAHJLGEFLE LogOutOfSessionEvent(DEDFJEOANEB MNGMAMNLFBI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x65E0AD0", Offset = "0x65DF4D0", VA = "0x1865E0AD0")]
		public void LogEventAsync(AmplitudeAnalyticsEvent BJDKGAIDEHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x65E10A0", Offset = "0x65DFAA0", VA = "0x1865E10A0")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent BJDKGAIDEHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x65E11F0", Offset = "0x65DFBF0", VA = "0x1865E11F0")]
		public void LogSerializedEventAsync(Dictionary<string, object> PCOCJBNKEMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x65E0C20", Offset = "0x65DF620", VA = "0x1865E0C20")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage MPAIADOPAJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x65E09E0", Offset = "0x65DF3E0", VA = "0x1865E09E0")]
		private void JMDHABHPMBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x65DEEB0", Offset = "0x65DD8B0", VA = "0x1865DEEB0")]
		private void CNKFOHBNLGL(Dictionary<string, object> KPOMAEBEHKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x65DFB90", Offset = "0x65DE590", VA = "0x1865DFB90")]
		private void EOFNKKEOJCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x65DDF90", Offset = "0x65DC990", VA = "0x1865DDF90")]
		private void BJFBPHHECNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x65E02C0", Offset = "0x65DECC0", VA = "0x1865E02C0")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x65E0430", Offset = "0x65DEE30", VA = "0x1865E0430")]
		[IteratorStateMachine(typeof(CPJNNEKGPGI))]
		private IEnumerator<MEOADLJIECK> ILGBMAOMLOG(float AOEGDFNBHBG = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x65E08F0", Offset = "0x65DF2F0", VA = "0x1865E08F0")]
		[IteratorStateMachine(typeof(OJOJHPLGMIF))]
		private IEnumerator<MEOADLJIECK> JBBLOOJIOAA(float AOEGDFNBHBG = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x65DDEB0", Offset = "0x65DC8B0", VA = "0x1865DDEB0")]
		[IteratorStateMachine(typeof(OIKNBIOAJPF))]
		private IEnumerator<MEOADLJIECK> BJDOKIMGPLP(LMGOCGLFNLA PGFLNEHBIAH, int? DJCANJPHLND, string LMKDFAEJHLB, string IAMLPGBDCLN, float AOEGDFNBHBG, Action<int> FCEIGBEOINJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x65E01A0", Offset = "0x65DEBA0", VA = "0x1865E01A0")]
		private static void FHCJIAOLDIF(bool CNPGMLIAGPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x65DF6F0", Offset = "0x65DE0F0", VA = "0x1865DF6F0")]
		private global::ODHJGGEEIEO<FDBKKNCCCFB<Dictionary<string, object>>> DECBADIEFBC(string LMKDFAEJHLB, string IAMLPGBDCLN, string IEBKFDEIEBH, string KFDENLIGHGM, Dictionary<string, object> LPAILGJIJMP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x65DF420", Offset = "0x65DDE20", VA = "0x1865DF420")]
		private global::ODHJGGEEIEO<FDBKKNCCCFB<List<Dictionary<string, object>>>> DECBADIEFBC(string LMKDFAEJHLB, string IAMLPGBDCLN, string IEBKFDEIEBH, string KFDENLIGHGM, List<Dictionary<string, object>> LPAILGJIJMP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x37185A0", Offset = "0x3716FA0", VA = "0x1837185A0")]
		private global::ODHJGGEEIEO<FDBKKNCCCFB<T>> GKPNINLGDLN<T>(string LMKDFAEJHLB, string IAMLPGBDCLN, string KFDENLIGHGM, T LPAILGJIJMP, Dictionary<string, object> BECBDJJGNKG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x3718260", Offset = "0x3716C60", VA = "0x183718260")]
		private global::ODHJGGEEIEO<FDBKKNCCCFB<T>> GAKLKAFMADK<T>(string LMKDFAEJHLB, string IAMLPGBDCLN, string IEBKFDEIEBH, T LPAILGJIJMP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x65E0350", Offset = "0x65DED50", VA = "0x1865E0350")]
		private bool GHLPMMGACEN(float DELPKOCBGIP, float AOEGDFNBHBG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x65DE170", Offset = "0x65DCB70", VA = "0x1865DE170")]
		private Dictionary<string, object> CCAPODCDKKC(string IAMLPGBDCLN, Dictionary<string, object> LPAILGJIJMP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x65E24B0", Offset = "0x65E0EB0", VA = "0x1865E24B0")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x65E12D0", Offset = "0x65DFCD0", VA = "0x1865E12D0")]
		[CompilerGenerated]
		private long ONHMCAFBHKD()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x65E0AC0", Offset = "0x65DF4C0", VA = "0x1865E0AC0")]
		[CompilerGenerated]
		private void JMPOEJGBHII(int LELNFOIGMKL)
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
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x65E3570", Offset = "0x65E1F70", VA = "0x1865E3570")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x65E3630", Offset = "0x65E2030", VA = "0x1865E3630")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public static string StableId
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x65E35D0", Offset = "0x65E1FD0", VA = "0x1865E35D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x65E36A0", Offset = "0x65E20A0", VA = "0x1865E36A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x7270C0", Offset = "0x725AC0", VA = "0x1807270C0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x65E3010", Offset = "0x65E1A10", VA = "0x1865E3010")]
		public static DEDFJEOANEB IDIKGABNBEI(string NHBDMCDLELK, [NotNull] string EAAMFEFLALL, long EOHIDDNIPKN, long NELLMOLNDFE, string BKFMEKLDIBK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x65E3100", Offset = "0x65E1B00", VA = "0x1865E3100")]
		public static DEDFJEOANEB JDAEHDIMAEN(string NHBDMCDLELK, [NotNull] string EAAMFEFLALL, long EOHIDDNIPKN, long NELLMOLNDFE, string BKFMEKLDIBK, long DKHKAABNFCF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x65E33B0", Offset = "0x65E1DB0", VA = "0x1865E33B0")]
		private AmplitudeAnalyticsEvent(string NHBDMCDLELK, [NotNull] string EAAMFEFLALL, long EOHIDDNIPKN, long NELLMOLNDFE, string BKFMEKLDIBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x22BFF70", Offset = "0x22BE970", VA = "0x1822BFF70")]
		public void POMICOOJBBA(long CDLAEGFMJGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x65E2EF0", Offset = "0x65E18F0", VA = "0x1865E2EF0", Slot = "5")]
		public override void HLMFENAONIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x65E3200", Offset = "0x65E1C00", VA = "0x1865E3200", Slot = "6")]
		public override void KCDKNGMFANK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x65E2970", Offset = "0x65E1370", VA = "0x1865E2970", Slot = "4")]
		protected override Dictionary<string, object> GKNCMEKCKCN(Dictionary<string, object> HEFOKGCOPJN)
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

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x65E4850", Offset = "0x65E3250", VA = "0x1865E4850")]
			public void PEIFPNMNAGP(Dictionary<string, object> MMAKDMBHFAB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x65E9DE0", Offset = "0x65E87E0", VA = "0x1865E9DE0")]
			public void PEIFPNMNAGP(Dictionary<string, object> BHEIANEJELM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x12396B0", Offset = "0x12380B0", VA = "0x1812396B0")]
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
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x727010", Offset = "0x725A10", VA = "0x180727010")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x730AE0", Offset = "0x72F4E0", VA = "0x180730AE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x65E3C60", Offset = "0x65E2660", VA = "0x1865E3C60")]
		public static MBMMOOPEJDA IDIKGABNBEI(string NHBDMCDLELK, string BKFMEKLDIBK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x65E3D90", Offset = "0x65E2790", VA = "0x1865E3D90")]
		protected AmplitudeAnalyticsIdentifyMessage(string NHBDMCDLELK, string BKFMEKLDIBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x65E3BE0", Offset = "0x65E25E0", VA = "0x1865E3BE0")]
		public Dictionary<string, object> HPMHFMCIKID()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x65E3820", Offset = "0x65E2220", VA = "0x1865E3820", Slot = "4")]
		protected virtual Dictionary<string, object> GKNCMEKCKCN(Dictionary<string, object> HEFOKGCOPJN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x65E3710", Offset = "0x65E2110", VA = "0x1865E3710")]
		protected void ADFEBNJLKNF(string OGFDNCPKECB, Dictionary<string, object> HLKKMAFIMNA, Dictionary<string, object> JAJNIEMLINC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x65E37B0", Offset = "0x65E21B0", VA = "0x1865E37B0")]
		protected void GJMDICFAIDE(string OGFDNCPKECB, string LPJDDLMPNCG, Dictionary<string, object> EJLCKGIMPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x65E3B60", Offset = "0x65E2560", VA = "0x1865E3B60", Slot = "5")]
		public virtual void HLMFENAONIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x65E3D10", Offset = "0x65E2710", VA = "0x1865E3D10", Slot = "6")]
		public virtual void KCDKNGMFANK()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class MBMMOOPEJDA : global::AAJMEFCMPPE<AmplitudeAnalyticsIdentifyMessage, MBMMOOPEJDA>
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public override MBMMOOPEJDA CKCKONAGKOP
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x84FC20", Offset = "0x84E620", VA = "0x18084FC20", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x727010", Offset = "0x725A10", VA = "0x180727010", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage HHHGPANOPOC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x65E8AC0", Offset = "0x65E74C0", VA = "0x1865E8AC0")]
	public MBMMOOPEJDA(AmplitudeAnalyticsIdentifyMessage BALNMHDNCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x65E8A20", Offset = "0x65E7420", VA = "0x1865E8A20", Slot = "4")]
	public override void KCDKNGMFANK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class DEDFJEOANEB : global::AAJMEFCMPPE<AmplitudeAnalyticsEvent, DEDFJEOANEB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private bool LOHEDJBJEGD;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public override DEDFJEOANEB CKCKONAGKOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x84FC20", Offset = "0x84E620", VA = "0x18084FC20", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public long OGECFICLBDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x4082010", Offset = "0x4080A10", VA = "0x184082010")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x65E4800", Offset = "0x65E3200", VA = "0x1865E4800")]
	public DEDFJEOANEB(AmplitudeAnalyticsEvent BALNMHDNCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x727010", Offset = "0x725A10", VA = "0x180727010", Slot = "5")]
	public override AmplitudeAnalyticsEvent HHHGPANOPOC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x65E46A0", Offset = "0x65E30A0", VA = "0x1865E46A0", Slot = "4")]
	public override void KCDKNGMFANK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x65E4400", Offset = "0x65E2E00", VA = "0x1865E4400")]
	public DEDFJEOANEB HJOANGCMHFN(string GJEJKJANAJD, long[] LPJDDLMPNCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x65E42C0", Offset = "0x65E2CC0", VA = "0x1865E42C0")]
	public DEDFJEOANEB HJOANGCMHFN(string GJEJKJANAJD, ulong[] LPJDDLMPNCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x28B2280", Offset = "0x28B0C80", VA = "0x1828B2280")]
	public DEDFJEOANEB HJOANGCMHFN<T>(string GJEJKJANAJD, T[] LPJDDLMPNCG) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x65E42B0", Offset = "0x65E2CB0", VA = "0x1865E42B0")]
	public DEDFJEOANEB HJOANGCMHFN(string GJEJKJANAJD, string[] LPJDDLMPNCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x28B2210", Offset = "0x28B0C10", VA = "0x1828B2210")]
	public DEDFJEOANEB HJOANGCMHFN<T>(string GJEJKJANAJD, T LPJDDLMPNCG) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x65E4190", Offset = "0x65E2B90", VA = "0x1865E4190")]
	public DEDFJEOANEB HJOANGCMHFN(string GJEJKJANAJD, long LPJDDLMPNCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x65E4220", Offset = "0x65E2C20", VA = "0x1865E4220")]
	public DEDFJEOANEB HJOANGCMHFN(string GJEJKJANAJD, ulong LPJDDLMPNCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x65E4540", Offset = "0x65E2F40", VA = "0x1865E4540")]
	public DEDFJEOANEB HJOANGCMHFN(string GJEJKJANAJD, string LPJDDLMPNCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x65E47E0", Offset = "0x65E31E0", VA = "0x1865E47E0")]
	public DEDFJEOANEB PBAIDCAAOJN(string GJEJKJANAJD, object? LPJDDLMPNCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x65E4740", Offset = "0x65E3140", VA = "0x1865E4740")]
	public DEDFJEOANEB MNOMNEOMGGA(string GJEJKJANAJD, string LPJDDLMPNCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x65E45B0", Offset = "0x65E2FB0", VA = "0x1865E45B0")]
	private DEDFJEOANEB ICFFMGEGHAI(string GJEJKJANAJD, object LPJDDLMPNCG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class KCEOMANNCFN : DEDFJEOANEB
{
	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x65E4800", Offset = "0x65E3200", VA = "0x1865E4800")]
	public KCEOMANNCFN(AmplitudeAnalyticsEvent BALNMHDNCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x65E6240", Offset = "0x65E4C40", VA = "0x1865E6240", Slot = "4")]
	public override void KCDKNGMFANK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public abstract class AAJMEFCMPPE<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : global::AAJMEFCMPPE<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	protected M BALNMHDNCIN;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public abstract BLDR CKCKONAGKOP
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x225EE20", Offset = "0x225D820", VA = "0x18225EE20")]
	public AAJMEFCMPPE(M BALNMHDNCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x37DC620", Offset = "0x37DB020", VA = "0x1837DC620")]
	public BLDR GIDJBALHHMD(AmplitudeAnalyticsIdentifyMessage.DeviceInfo MMBFCLNJOGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x37DC750", Offset = "0x37DB150", VA = "0x1837DC750")]
	public BLDR PAHLACFFPNN(AmplitudeAnalyticsIdentifyMessage.RevenueData AGBJIALAAJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x37DC450", Offset = "0x37DAE50", VA = "0x1837DC450")]
	public BLDR EIKEGHEKGHG(string GJEJKJANAJD, string LPJDDLMPNCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x276B2F0", Offset = "0x2769CF0", VA = "0x18276B2F0")]
	public BLDR EIKEGHEKGHG<T>(string GJEJKJANAJD, T LPJDDLMPNCG) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x37DC570", Offset = "0x37DAF70", VA = "0x1837DC570")]
	public BLDR EIKEGHEKGHG(string GJEJKJANAJD, long LPJDDLMPNCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x37DC4C0", Offset = "0x37DAEC0", VA = "0x1837DC4C0")]
	public BLDR EIKEGHEKGHG(string GJEJKJANAJD, ulong LPJDDLMPNCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void KCDKNGMFANK();

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x37DC420", Offset = "0x37DAE20", VA = "0x1837DC420")]
	internal static string AKAHFPBJACG(string LPJDDLMPNCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x37DC660", Offset = "0x37DB060", VA = "0x1837DC660")]
	private BLDR IKEPGLMFEPN(string GJEJKJANAJD, object LPJDDLMPNCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M HHHGPANOPOC();
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class CLGLHBNNKCC
{
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public const string ILEOFGFPAPH = "batch";

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public const string FFCEJGDMMAM = "type";

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public const string JCGHNGLDFGC = "identify";

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public const string DDGDBJBBOBO = "track";

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public const string EGEMAPOEPKL = "userId";

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public const string INHHHOOIBFJ = "anonymousId";

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public const string IAHNBEJAAEJ = "stable_id";

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public const string FLGLHBFCKLN = "messageId";

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public const string JIAEAOMOCOB = "event";

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public const string ICAECOAFJNB = "version";

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public const string NOBDNHKJJBG = "locale";

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public const string HPPKCKNJKOC = "name";

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public const string KNJHHKJGBCB = "properties";

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public const string PPLGIIDHCNJ = "traits";

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public const string BJEIIMKMCEB = "context";

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public const string AABMLOMAOFP = "app";

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public const string BMHCOODJCJM = "os";

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public const string IDFKPOEJEMA = "device";

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public const string HDCCPLNLBFG = "originalTimestamp";

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public const string NJGILGIJGGG = "brand";

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public const string BGMDLODHOAC = "manufacturer";

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public const string DBEKLPEGLAC = "model";

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public const string IDGPBMOKPNJ = "type";

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	public CLGLHBNNKCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class LKIEMEBOILD
{
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public const int EJMIAGJFPAL = 2;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public const int HFJMLKAKBNK = 100;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public const int IBNDLHIMOPK = 1000;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public const long GAAGCONOBGL = 1800000L;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public const int BHEMIJFPNIF = 1024;

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public const int NIBFJOPJMOK = 1000;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public const string OJDAKDMJDMD = "amplitude_sequence_number";

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public const string EHINEKCCGPC = "amplitude_user_id";

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public const string PJKFDKPIGKP = "amplitude_last_time";

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public const string JGHCDIBNOPD = "initialize_analytics";

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public const string MDGEBLAMDIP = "session_start";

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public const string BLECAKNJOLB = "session_end";

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public const string KPHIMIIODJP = "insert_id";

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public const string OGMKBDBIHKE = "event_time";

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public const string GDBPDBIENIJ = "session_id";

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public const string HKKFNLGKFCH = "session_tracking_data";

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public const string DGDHNGBFLBC = "user_properties";

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public const string CINFIFHIKDE = "app_version";

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public const string OFPNMCBADME = "ip";

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public const string ECNEMCHAJEB = "language";

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public const string IAHNBEJAAEJ = "stable_id";

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public const string JOAPNGIPIGI = "platform";

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public const string INHELOADMBI = "os_name";

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public const string CAJCNAIBHJO = "os_version";

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public const string MLLOCDPLHBD = "device_brand";

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public const string DMMECGMKLEF = "device_manufacturer";

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public const string CPOIHEIJEGF = "device_model";

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public const string BONCKCFIANF = "device_type";

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public const string NDPOBNPPGLG = "price";

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public const string PNCLGDNHENC = "quantity";

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public const string OIHFIJLFICG = "revenue";

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public const string NDMHEIICDDO = "productId";

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public const string JNGAMNALBBO = "revenueType";

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public const string OBCFBKPHMIG = "event_type";

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public const string EGEMAPOEPKL = "user_id";

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public const string APNCKIPKALG = "event_properties";

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public const int EPIEGDDNKNN = 10;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> APHNINAPEDD;

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x65E7240", Offset = "0x65E5C40", VA = "0x1865E7240")]
	internal static bool LDJBPCMAMAC(string OGFDNCPKECB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	public LKIEMEBOILD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface EHFHANGOAHP
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	bool GJMKCNLKIGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	string MBFMALIGBMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	string AEKGCNCKPDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	string HCKGELOFEEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	string OHAGBIOKBPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::ODHJGGEEIEO<PGALIBCKNEJ> DECBADIEFBC(string LMKDFAEJHLB, Dictionary<string, string> CLGCLNMAGPN, bool BOBIHPEBCAI = false);

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	global::ODHJGGEEIEO<PGALIBCKNEJ> LPCGPDFJEBL(string LMKDFAEJHLB, string PLMNAPHNMFA, string NGGBJCEOEBC, string ADMGEJAECHD);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct PGALIBCKNEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public readonly int BJECDFODMCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public readonly string FGONMAIFOPD;

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x73BAF0", Offset = "0x73A4F0", VA = "0x18073BAF0")]
	public PGALIBCKNEJ(int KKNAKDFGECM, string JNBFMKCCJPP)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class KKMDFNBFHNC
{
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static byte[] BKNPCMHFKCN;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static int KPMJKGHHDMP;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private static int JFAKBFOPBGJ;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static BigInteger JMHPFPLGCJL;

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	public KKMDFNBFHNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x65E6750", Offset = "0x65E5150", VA = "0x1865E6750")]
	private static string JOPJDHMEFPC(byte[] GFCGIJPPCBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x65E6400", Offset = "0x65E4E00", VA = "0x1865E6400")]
	public static string GLIIACIKPKK(byte[] EMIAMELGKNF, bool LLPOIDPCGKE)
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

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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

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
using RecRoom.NoEngine.Common;
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
		[Cpp2IlInjected.Address(RVA = "0x8484E0", Offset = "0x8474E0", VA = "0x1808484E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6C26CB0", Offset = "0x6C25CB0", VA = "0x186C26CB0")]
		public NullableAttribute(byte P_0)
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

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x183B060", Offset = "0x183A060", VA = "0x18183B060")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class MDONBJMEGLB
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> LKCINIEMDAC;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6C26750", Offset = "0x6C25750", VA = "0x186C26750")]
	internal static bool FPJHBDEHBGG(string CDBHHMNALJL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface JLPDMMFJGAM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool AGAFBMHANKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string DIGGKAGEJMI
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	string KDCCKDFLGKN
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	string BOHDJGCJGBP
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	string EBBIJPHELAG
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	LJAJHHFEMAM<DPCJLMLANOP> ONLLOLMDALG(string FKIFALONLFB, Dictionary<string, string> LOLPKNKPEBK, bool KPHHCIHCDIO = false);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	LJAJHHFEMAM<DPCJLMLANOP> FCNIEHBIEAO(string FKIFALONLFB, string PNMOPOBEKJG, string IJIOEDPCCEP, string JFNANFIEDBG);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct DPCJLMLANOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly int LHICHLLKNDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly string GCFDJPIOOGA;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xE4A250", Offset = "0xE49250", VA = "0x180E4A250")]
	public DPCJLMLANOP(int PALINENHAHH, string BBKEIJNCHGF)
	{
	}
}
namespace AmplitudeAnalytics
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class AGAmplitudeAnalyticsSettings : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		private AmplitudeAnalyticsClient.Settings editorSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		private bool forceEditorSettingsForDevelopers;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public AmplitudeAnalyticsClient.Settings KDPFPKINNDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x978A80", Offset = "0x977A80", VA = "0x180978A80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool KAPPEMKKGHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xC2F6D0", Offset = "0xC2E6D0", VA = "0x180C2F6D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x966250", Offset = "0x965250", VA = "0x180966250")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class AmplitudeAnalyticsEvent : AmplitudeAnalyticsIdentifyMessage
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly string uuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly string eventType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly long sequenceNumber;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly bool isBrazeUser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		internal Dictionary<string, object> eventProperties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private string language;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private long time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private long sessionId;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static string SessionTrackingData
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x6C1EE80", Offset = "0x6C1DE80", VA = "0x186C1EE80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x6C1EF50", Offset = "0x6C1DF50", VA = "0x186C1EF50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static string StableId
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6C1EEC0", Offset = "0x6C1DEC0", VA = "0x186C1EEC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6C1EFA0", Offset = "0x6C1DFA0", VA = "0x186C1EFA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static string ClientLauncher
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6C1EE40", Offset = "0x6C1DE40", VA = "0x186C1EE40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6C1EF00", Offset = "0x6C1DF00", VA = "0x186C1EF00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x94AC50", Offset = "0x949C50", VA = "0x18094AC50")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6C1E810", Offset = "0x6C1D810", VA = "0x186C1E810")]
		public static LOLHNDDHBLB GGPPECCFBMF(string DFLAEIEBLPA, [NotNull] string NIJGNGEHGMP, long CFLLBMFDAAN, long JCGOIIAFHHF, string CCBCMGPHDLJ, bool IOCBLICMIID)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6C1E1C0", Offset = "0x6C1D1C0", VA = "0x186C1E1C0")]
		public static LOLHNDDHBLB BEMMNLLHDNG(string DFLAEIEBLPA, [NotNull] string NIJGNGEHGMP, long CFLLBMFDAAN, long JCGOIIAFHHF, string CCBCMGPHDLJ, long CLDLMIFKDCM, bool IOCBLICMIID)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6C1EC60", Offset = "0x6C1DC60", VA = "0x186C1EC60")]
		private AmplitudeAnalyticsEvent(string DFLAEIEBLPA, [NotNull] string NIJGNGEHGMP, long CFLLBMFDAAN, long JCGOIIAFHHF, string CCBCMGPHDLJ, bool IOCBLICMIID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x185AED0", Offset = "0x1859ED0", VA = "0x18185AED0")]
		public void CFKJEMLDMKD(long JJDOEMEEPLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6C1E900", Offset = "0x6C1D900", VA = "0x186C1E900", Slot = "5")]
		public override void JHOADFPHPMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6C1E9F0", Offset = "0x6C1D9F0", VA = "0x186C1E9F0", Slot = "6")]
		public override void KNAAFLKOLAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6C1E2D0", Offset = "0x6C1D2D0", VA = "0x186C1E2D0", Slot = "4")]
		protected override Dictionary<string, object> EBNBKDANOBN(Dictionary<string, object> DJAKGLKFKEL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6C1EB50", Offset = "0x6C1DB50", VA = "0x186C1EB50")]
		private void MNELCDMJHAC(string CDBHHMNALJL, string CKMKMNKGMMC, bool ODFDPIBIDNO = false)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class GJNDPLDFHGB : EJPDLJEEMFK<AmplitudeAnalyticsIdentifyMessage, GJNDPLDFHGB>
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override GJNDPLDFHGB LKGPKEHOPBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x93AC90", Offset = "0x939C90", VA = "0x18093AC90", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0xA1FB30", Offset = "0xA1EB30", VA = "0x180A1FB30", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage EJBHGJELEDC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6C24950", Offset = "0x6C23950", VA = "0x186C24950")]
	public GJNDPLDFHGB(AmplitudeAnalyticsIdentifyMessage FANKIHBOOPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6C248E0", Offset = "0x6C238E0", VA = "0x186C248E0", Slot = "4")]
	public override void KNAAFLKOLAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class LOLHNDDHBLB : EJPDLJEEMFK<AmplitudeAnalyticsEvent, LOLHNDDHBLB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private bool DLNNKOGMNPE;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override LOLHNDDHBLB LKGPKEHOPBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x93AC90", Offset = "0x939C90", VA = "0x18093AC90", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public long LJBKBJALDBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x21AF4A0", Offset = "0x21AE4A0", VA = "0x1821AF4A0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6C23F30", Offset = "0x6C22F30", VA = "0x186C23F30")]
	public LOLHNDDHBLB(AmplitudeAnalyticsEvent FANKIHBOOPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0xA1FB30", Offset = "0xA1EB30", VA = "0x180A1FB30", Slot = "5")]
	public override AmplitudeAnalyticsEvent EJBHGJELEDC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6C26240", Offset = "0x6C25240", VA = "0x186C26240", Slot = "4")]
	public override void KNAAFLKOLAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2DD1430", Offset = "0x2DD0430", VA = "0x182DD1430")]
	public LOLHNDDHBLB MDDKNKFOJOO<T>(string FJCNAJDOIIE, T[] CKMKMNKGMMC) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6C26370", Offset = "0x6C25370", VA = "0x186C26370")]
	public LOLHNDDHBLB MDDKNKFOJOO(string FJCNAJDOIIE, string[] CKMKMNKGMMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2DD13C0", Offset = "0x2DD03C0", VA = "0x182DD13C0")]
	public LOLHNDDHBLB MDDKNKFOJOO<T>(string FJCNAJDOIIE, T CKMKMNKGMMC) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6C262E0", Offset = "0x6C252E0", VA = "0x186C262E0")]
	public LOLHNDDHBLB MDDKNKFOJOO(string FJCNAJDOIIE, long CKMKMNKGMMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6C26380", Offset = "0x6C25380", VA = "0x186C26380")]
	public LOLHNDDHBLB MDDKNKFOJOO(string FJCNAJDOIIE, string CKMKMNKGMMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6C263F0", Offset = "0x6C253F0", VA = "0x186C263F0")]
	public LOLHNDDHBLB NNHONBLJINP(string FJCNAJDOIIE, object? CKMKMNKGMMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6C260A0", Offset = "0x6C250A0", VA = "0x186C260A0")]
	public LOLHNDDHBLB APFLOOCDILK(string FJCNAJDOIIE, string CKMKMNKGMMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6C26140", Offset = "0x6C25140", VA = "0x186C26140")]
	private LOLHNDDHBLB DHGGADHPBEB(string FJCNAJDOIIE, object CKMKMNKGMMC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class EOGNILCEMNM : LOLHNDDHBLB
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6C23F30", Offset = "0x6C22F30", VA = "0x186C23F30")]
	public EOGNILCEMNM(AmplitudeAnalyticsEvent FANKIHBOOPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6C23DA0", Offset = "0x6C22DA0", VA = "0x186C23DA0", Slot = "4")]
	public override void KNAAFLKOLAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class EJPDLJEEMFK<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : EJPDLJEEMFK<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected M FANKIHBOOPE;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public abstract BLDR LKGPKEHOPBB
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0xEDE1E0", Offset = "0xEDD1E0", VA = "0x180EDE1E0")]
	public EJPDLJEEMFK(M FANKIHBOOPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3792A00", Offset = "0x3791A00", VA = "0x183792A00")]
	public BLDR PMGFPEGGNDN(AmplitudeAnalyticsIdentifyMessage.DeviceInfo BAPFJOFFLHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3792820", Offset = "0x3791820", VA = "0x183792820")]
	public BLDR AGLODDKPNJM(AmplitudeAnalyticsIdentifyMessage.RevenueData GDPHHKGIDPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3792860", Offset = "0x3791860", VA = "0x183792860")]
	public BLDR EMLGLGLGCBF(string FJCNAJDOIIE, string CKMKMNKGMMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x29CEDF0", Offset = "0x29CDDF0", VA = "0x1829CEDF0")]
	public BLDR EMLGLGLGCBF<T>(string FJCNAJDOIIE, T CKMKMNKGMMC) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void KNAAFLKOLAG();

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x37929D0", Offset = "0x37919D0", VA = "0x1837929D0")]
	internal static string HGNJBPPECCA(string CKMKMNKGMMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x37928D0", Offset = "0x37918D0", VA = "0x1837928D0")]
	private BLDR FCNEKOJLDGE(string FJCNAJDOIIE, object CKMKMNKGMMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M EJBHGJELEDC();
}
namespace AmplitudeAnalytics
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class AmplitudeAnalyticsIdentifyMessage
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public class DeviceInfo
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public string platform;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public string osName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public string osVersion;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public string deviceBrand;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public string deviceManufacturer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public string deviceModel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public string deviceType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public string carrier;

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6C20750", Offset = "0x6C1F750", VA = "0x186C20750")]
			public void DJEMDKKCMLK(Dictionary<string, object> OOEBNHKFIFP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
			public DeviceInfo()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public class RevenueData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public float price;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public int quantity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public float revenue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public string productId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public string revenueType;

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6C26D40", Offset = "0x6C25D40", VA = "0x186C26D40")]
			public void DJEMDKKCMLK(Dictionary<string, object> CMAMPNPDGOK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6C26EB0", Offset = "0x6C25EB0", VA = "0x186C26EB0")]
			public RevenueData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		internal DeviceInfo deviceInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		internal RevenueData revenueData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly string buildVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly string language;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		internal Dictionary<string, object> userProperties;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		protected string UserId
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x83A5D0", Offset = "0x8395D0", VA = "0x18083A5D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x92FA60", Offset = "0x92EA60", VA = "0x18092FA60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6C1F450", Offset = "0x6C1E450", VA = "0x186C1F450")]
		public static GJNDPLDFHGB GGPPECCFBMF(string DFLAEIEBLPA, string CCBCMGPHDLJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6C1F630", Offset = "0x6C1E630", VA = "0x186C1F630")]
		protected AmplitudeAnalyticsIdentifyMessage(string DFLAEIEBLPA, string CCBCMGPHDLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6C1F5B0", Offset = "0x6C1E5B0", VA = "0x186C1F5B0")]
		public Dictionary<string, object> PIGGNGGBMDB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6C1EFF0", Offset = "0x6C1DFF0", VA = "0x186C1EFF0", Slot = "4")]
		protected virtual Dictionary<string, object> EBNBKDANOBN(Dictionary<string, object> DJAKGLKFKEL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6C1F330", Offset = "0x6C1E330", VA = "0x186C1F330")]
		protected void FBJAMMGDEEM(string CDBHHMNALJL, Dictionary<string, object> IIPBOAELKNG, Dictionary<string, object> MKFCNFJPGFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6C1F3E0", Offset = "0x6C1E3E0", VA = "0x186C1F3E0")]
		protected void FPJNAIPGKHF(string CDBHHMNALJL, string CKMKMNKGMMC, Dictionary<string, object> KNLPMGADPLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6C1F500", Offset = "0x6C1E500", VA = "0x186C1F500", Slot = "5")]
		public virtual void JHOADFPHPMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6C1F560", Offset = "0x6C1E560", VA = "0x186C1F560", Slot = "6")]
		public virtual void KNAAFLKOLAG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		private enum JNBPBLNKDHA
		{
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		internal class EMNBKFEOPML
		{
			[Cpp2IlInjected.Token(Token = "0x2000015")]
			private class FFNDDCDPEFD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000067")]
				public int JJIMMLGKMAH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000068")]
				public Dictionary<string, object> CPGCGIPMBBM;

				[Cpp2IlInjected.Token(Token = "0x6000098")]
				[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
				public FFNDDCDPEFD()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000016")]
			[CompilerGenerated]
			private sealed class DHAHAALPCEO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000069")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000099")]
				[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
				public DHAHAALPCEO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600009A")]
				[Cpp2IlInjected.Address(RVA = "0x6C206F0", Offset = "0x6C1F6F0", VA = "0x186C206F0")]
				internal bool ALOJBJBNAAH(FFNDDCDPEFD item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private const string LPHPKMNIAND = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			private readonly string JAGGOBHOHJG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private List<FFNDDCDPEFD> FCFNENJDFHL;

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public int? IFMGLCPDFOM
			{
				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0x6C23350", Offset = "0x6C22350", VA = "0x186C23350")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x6C23C10", Offset = "0x6C22C10", VA = "0x186C23C10")]
			internal EMNBKFEOPML(string ICFMPHNCJAC, string JAIGIKEHGGJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x6C233F0", Offset = "0x6C223F0", VA = "0x186C233F0")]
			public int IGFPILDNFNA([Optional] int? KBLKINAGJNI)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x6C237E0", Offset = "0x6C227E0", VA = "0x186C237E0")]
			public List<Dictionary<string, object>> MFLHPABBLOP(int IFJFIMOHNJL, int? KBLKINAGJNI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x6C22AE0", Offset = "0x6C21AE0", VA = "0x186C22AE0")]
			public void FPDOFDJNGMM(AmplitudeAnalyticsIdentifyMessage DCGPCJKHCOO, bool FCGAGIFGBDD = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x6C229D0", Offset = "0x6C219D0", VA = "0x186C229D0")]
			public void FPDOFDJNGMM(Dictionary<string, object> DCGPCJKHCOO, bool FCGAGIFGBDD = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x6C23A80", Offset = "0x6C22A80", VA = "0x186C23A80")]
			public void NNIFFJMAGIN(params Dictionary<string, object>[] AJAIPMLFLNJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x6C23100", Offset = "0x6C22100", VA = "0x186C23100")]
			public void HHLDCBKNOIM(List<Dictionary<string, object>> MNBEAPFNBGN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x6C22890", Offset = "0x6C21890", VA = "0x186C22890")]
			private void BDCIILJFNBC(Dictionary<string, object> DCGPCJKHCOO, bool FCGAGIFGBDD = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x6C23570", Offset = "0x6C22570", VA = "0x186C23570")]
			public void KONHGEPECAI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x6C22B80", Offset = "0x6C21B80", VA = "0x186C22B80")]
			private void GFPPMJLIGHH([Optional] string EHPHFKEFKFO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x6C22FD0", Offset = "0x6C21FD0", VA = "0x186C22FD0")]
			private static string GNNMGFGHFGC(string CKMKMNKGMMC, string CDBHHMNALJL)
			{
				return null;
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public class Settings
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public float BatchIntervalSeconds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public bool verboseLogging;

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x6C27110", Offset = "0x6C26110", VA = "0x186C27110")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public struct CCKJFAJJNBI<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public int PALINENHAHH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public string BBKEIJNCHGF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public T FLDCGCNEMKH;
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class CJDPKBPIFDA : IEnumerator<KNGCLBDEHMD>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private KNGCLBDEHMD <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			private List<AmplitudeAnalyticsIdentifyMessage>.Enumerator <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			private AmplitudeAnalyticsIdentifyMessage <queuedEvent>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			private KNGCLBDEHMD System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000A4")]
				[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000A6")]
				[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xB1F9D0", Offset = "0xB1E9D0", VA = "0x180B1F9D0")]
			[DebuggerHidden]
			public CJDPKBPIFDA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x6C1FF40", Offset = "0x6C1EF40", VA = "0x186C1FF40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x6C206B0", Offset = "0x6C1F6B0", VA = "0x186C206B0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class ECMDAMHOLBL : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public JIPDPKKGEMC quitCompletePromise;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			private float <timeout>5__1;

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000AA")]
				[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000AC")]
				[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xB1F9D0", Offset = "0xB1E9D0", VA = "0x180B1F9D0")]
			[DebuggerHidden]
			public ECMDAMHOLBL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x6C20AA0", Offset = "0x6C1FAA0", VA = "0x186C20AA0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x6C20BC0", Offset = "0x6C1FBC0", VA = "0x186C20BC0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class ECHEMCNCJNM : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public float timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000B0")]
				[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000B2")]
				[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xB1F9D0", Offset = "0xB1E9D0", VA = "0x180B1F9D0")]
			[DebuggerHidden]
			public ECHEMCNCJNM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x6C208D0", Offset = "0x6C1F8D0", VA = "0x186C208D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x6C20A60", Offset = "0x6C1FA60", VA = "0x186C20A60", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class NJHJLAHCFEM : IEnumerator<KNGCLBDEHMD>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			private KNGCLBDEHMD <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public float timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			private bool <shouldSendBatch>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			private EMNBKFEOPML <cache>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			private string <url>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			private Action<int> <eventBatchSent>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			private int? <earlierThanFrame>5__5;

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			private KNGCLBDEHMD System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000B6")]
				[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000B8")]
				[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xB1F9D0", Offset = "0xB1E9D0", VA = "0x180B1F9D0")]
			[DebuggerHidden]
			public NJHJLAHCFEM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x6C26900", Offset = "0x6C25900", VA = "0x186C26900", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x6C26C70", Offset = "0x6C25C70", VA = "0x186C26C70", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class MCGOGOLJNGC : IEnumerator<KNGCLBDEHMD>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			private KNGCLBDEHMD <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public float timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			private EMNBKFEOPML <cache>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			private string <url>5__2;

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			private KNGCLBDEHMD System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000C0")]
				[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000C2")]
				[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0xB1F9D0", Offset = "0xB1E9D0", VA = "0x180B1F9D0")]
			[DebuggerHidden]
			public MCGOGOLJNGC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x6C26420", Offset = "0x6C25420", VA = "0x186C26420", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x6C26710", Offset = "0x6C25710", VA = "0x186C26710", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class BLOPEINCCOL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public List<Dictionary<string, object>> batch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			public EMNBKFEOPML cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
			public BLOPEINCCOL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x6C1F730", Offset = "0x6C1E730", VA = "0x186C1F730")]
			internal void EPINJDKOFEJ(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x6C1FAA0", Offset = "0x6C1EAA0", VA = "0x186C1FAA0")]
			internal void GLAFICHJAOB(CCKJFAJJNBI<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[CompilerGenerated]
		private sealed class GJKCDPBPOAA : IEnumerator<KNGCLBDEHMD>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			private KNGCLBDEHMD <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			public EMNBKFEOPML cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public int? earlierThanFrame;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public string url;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public string dataIdentifier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public float timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			private BLOPEINCCOL <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			private string <apiKey>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			private float <startTime>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			private bool <timedOut>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			private int <batchSize>5__5;

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			private KNGCLBDEHMD System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000C9")]
				[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000CB")]
				[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xB1F9D0", Offset = "0xB1E9D0", VA = "0x180B1F9D0")]
			[DebuggerHidden]
			public GJKCDPBPOAA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x6C23F80", Offset = "0x6C22F80", VA = "0x186C23F80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x6C248A0", Offset = "0x6C238A0", VA = "0x186C248A0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class CDDKGODIDBN<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x9B1010", Offset = "0x9B0010", VA = "0x1809B1010")]
			public CDDKGODIDBN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x216F8F0", Offset = "0x216E8F0", VA = "0x18216F8F0")]
			internal CCKJFAJJNBI<T> NKFLKHPODBE(DPCJLMLANOP postResponse)
			{
				return default(CCKJFAJJNBI<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private sealed class LODNMGNMOFI<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x9B1010", Offset = "0x9B0010", VA = "0x1809B1010")]
			public LODNMGNMOFI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x216F8F0", Offset = "0x216E8F0", VA = "0x18216F8F0")]
			internal CCKJFAJJNBI<T> PDPLCFIAAAD(DPCJLMLANOP postResponse)
			{
				return default(CCKJFAJJNBI<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private CDNJAGBMOFC GICMALKBCFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private Lazy<FNHDOPIJDOL> IJCLIABJBHB;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private const string PIPNGNKCANF = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const string INNLHFHLEOK = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private const string JPBMCIDNEHE = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private const int OHKEHPCDNCI = 15;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private const int HBGJMJABJKB = 10;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private const int EALIEAMPFGF = 5;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private const float NIBCJFKPKDN = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private const long MLFBFJDAKFA = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private const string BHCKGJGEBLC = "f1779b982f1c09aed3adb3cca563cbc2";

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private const string PIMJLIMMHCA = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static bool MCEHDLANJKH;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static bool ECCOEILHLCL;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static int GBCMHICJDMC;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static int HDHBNMKLLLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private JLPDMMFJGAM HCBJKGAOBPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private bool NBJCANLALCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private float CEJANEBEFCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private float LJGIMEDFPPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private int MIAPOKJAECO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private int HHFMNOEOGGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private int? ICNLBAAHHOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private int? ELJCIJBGCBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private long IFDAOLIGAEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private string LHKOHDBALKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private bool ANIOBLLLCBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private long ILBANHGEANN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private Dictionary<string, object> FHFGAOHMAAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private JNBPBLNKDHA EILIFIMKKDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private int GBDDDLFLONF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private int DLJGJABHAGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private float CKGHMEHDJBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private bool GFAECHFIFBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private bool EHOAIFNDFGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private EMNBKFEOPML CABIJEOMJJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private EMNBKFEOPML ENKEHCKABJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private EMNBKFEOPML KMMIJPPPGOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> HHOMDCAMBIG;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo EJBJLMKPGEE;

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private static string NKMAHOGGDLF;

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private const string DILEHAAFKOD = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private readonly string NCHEJMCOBAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private readonly string GKNGJCKFMBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly string GLFKFLAPAJH;

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private CDNJAGBMOFC HFJJKELOOFE
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x6C1C250", Offset = "0x6C1B250", VA = "0x186C1C250")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private FNHDOPIJDOL OJICJEIAPIO
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x6C19CE0", Offset = "0x6C18CE0", VA = "0x186C19CE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private static int IPGJMABGNAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6C1C8D0", Offset = "0x6C1B8D0", VA = "0x186C1C8D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static long GLLDDHPLMCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x6C1E060", Offset = "0x6C1D060", VA = "0x186C1E060")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x6C1E160", Offset = "0x6C1D160", VA = "0x186C1E160")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static string OKJEDOFMBDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6C1E000", Offset = "0x6C1D000", VA = "0x186C1E000")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static string IJNDGELMKGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6C1E030", Offset = "0x6C1D030", VA = "0x186C1E030")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public string LPKFNCALFDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x9950C0", Offset = "0x9940C0", VA = "0x1809950C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x97EC90", Offset = "0x97DC90", VA = "0x18097EC90")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public int? DCDGLPIDNIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xA2A240", Offset = "0xA29240", VA = "0x180A2A240")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xA29C90", Offset = "0xA28C90", VA = "0x180A29C90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool EOGDCJIMHCI
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xE7C1A0", Offset = "0xE7B1A0", VA = "0x180E7C1A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xE7B580", Offset = "0xE7A580", VA = "0x180E7B580")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static bool JNCPAEABNBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x6C1DF70", Offset = "0x6C1CF70", VA = "0x186C1DF70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> DHPJLCIDJCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6C1DED0", Offset = "0x6C1CED0", VA = "0x186C1DED0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6C1E0C0", Offset = "0x6C1D0C0", VA = "0x186C1E0C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6C19060", Offset = "0x6C18060", VA = "0x186C19060", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6C1A1B0", Offset = "0x6C191B0", VA = "0x186C1A1B0")]
		private void IFLFNCCCEAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6C1D600", Offset = "0x6C1C600", VA = "0x186C1D600")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6C1C830", Offset = "0x6C1B830", VA = "0x186C1C830", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6C1D8E0", Offset = "0x6C1C8E0", VA = "0x186C1D8E0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6C1CAA0", Offset = "0x6C1BAA0", VA = "0x186C1CAA0")]
		public FHJJKILLDME PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6C1A970", Offset = "0x6C19970", VA = "0x186C1A970")]
		[IteratorStateMachine(typeof(CJDPKBPIFDA))]
		public IEnumerator<KNGCLBDEHMD> Initialize(AmplitudeAnalyticsEvent EPJEAEHMKHA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6C1D7E0", Offset = "0x6C1C7E0", VA = "0x186C1D7E0")]
		public void UpdateLastAliveTime(float BIEGLBAOOPP = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6C19D30", Offset = "0x6C18D30", VA = "0x186C19D30")]
		private FHJJKILLDME EHMANMBJDKA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6C1C6C0", Offset = "0x6C1B6C0", VA = "0x186C1C6C0")]
		private FHJJKILLDME OOALIKGMGLE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6C1D100", Offset = "0x6C1C100", VA = "0x186C1D100")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6C19350", Offset = "0x6C18350", VA = "0x186C19350")]
		[IteratorStateMachine(typeof(ECMDAMHOLBL))]
		private IEnumerator BNNCCGEIIFA(JIPDPKKGEMC IMOLEDFAFON)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6C1DB60", Offset = "0x6C1CB60", VA = "0x186C1DB60")]
		[IteratorStateMachine(typeof(ECHEMCNCJNM))]
		public IEnumerator WaitForFlush(float OPIACMMDOAI = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6C1D6C0", Offset = "0x6C1C6C0", VA = "0x186C1D6C0")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6C1D610", Offset = "0x6C1C610", VA = "0x186C1D610")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime CPDGKFHMGPK)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6C1A5C0", Offset = "0x6C195C0", VA = "0x186C1A5C0")]
		public static GJNDPLDFHGB Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6C18F00", Offset = "0x6C17F00", VA = "0x186C18F00")]
		public static LOLHNDDHBLB AccountSelectionPostLoginEvent([NotNull] string JBOBCIBHPOL, string CCBCMGPHDLJ, bool IOCBLICMIID)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6C19E00", Offset = "0x6C18E00", VA = "0x186C19E00")]
		public static LOLHNDDHBLB Event([NotNull] string JBOBCIBHPOL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6C1CC60", Offset = "0x6C1BC60", VA = "0x186C1CC60")]
		public static LOLHNDDHBLB PreviousSessionEvent([NotNull] string JBOBCIBHPOL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6C1A6F0", Offset = "0x6C196F0", VA = "0x186C1A6F0")]
		public static LOLHNDDHBLB InitializeEvent(string CCBCMGPHDLJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6C1D2E0", Offset = "0x6C1C2E0", VA = "0x186C1D2E0")]
		public static LOLHNDDHBLB StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6C19840", Offset = "0x6C18840", VA = "0x186C19840")]
		public static LOLHNDDHBLB CreateOutOfSessionEvent(string JBOBCIBHPOL, bool OHIGDFCJJDE = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6C1BD20", Offset = "0x6C1AD20", VA = "0x186C1BD20")]
		public static FHJJKILLDME LogOutOfSessionEvent(LOLHNDDHBLB OEJPANNDCCE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6C1BA80", Offset = "0x6C1AA80", VA = "0x186C1BA80")]
		public void LogEventAsync(AmplitudeAnalyticsEvent IEPHGCBNFIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6C1C010", Offset = "0x6C1B010", VA = "0x186C1C010")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent IEPHGCBNFIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6C1C160", Offset = "0x6C1B160", VA = "0x186C1C160")]
		public void LogSerializedEventAsync(Dictionary<string, object> LMMIJEHABOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6C1BBD0", Offset = "0x6C1ABD0", VA = "0x186C1BBD0")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage OGGCCGPHOPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6C19AF0", Offset = "0x6C18AF0", VA = "0x186C19AF0")]
		private void DAONFEDPAEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6C1B7D0", Offset = "0x6C1A7D0", VA = "0x186C1B7D0")]
		private void LKFPEMPJJOJ(Dictionary<string, object> DHMIBILCIEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6C19BE0", Offset = "0x6C18BE0", VA = "0x186C19BE0")]
		private void DBHKNJGCLGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6C19660", Offset = "0x6C18660", VA = "0x186C19660")]
		private void CEMCLAFBOAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6C19FF0", Offset = "0x6C18FF0", VA = "0x186C19FF0")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6C1B750", Offset = "0x6C1A750", VA = "0x186C1B750")]
		[IteratorStateMachine(typeof(NJHJLAHCFEM))]
		private IEnumerator<KNGCLBDEHMD> KNAILHKOIKJ(float OPIACMMDOAI = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6C1B6D0", Offset = "0x6C1A6D0", VA = "0x186C1B6D0")]
		[IteratorStateMachine(typeof(MCGOGOLJNGC))]
		private IEnumerator<KNGCLBDEHMD> KKLKCKHMPCG(float OPIACMMDOAI = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6C1A080", Offset = "0x6C19080", VA = "0x186C1A080")]
		[IteratorStateMachine(typeof(GJKCDPBPOAA))]
		private IEnumerator<KNGCLBDEHMD> HDNAKCAOEPO(EMNBKFEOPML JMFNDFLLKPI, int? KBLKINAGJNI, string FKIFALONLFB, string JADDCPGFGLD, float OPIACMMDOAI, Action<int> GBJKNFFPECC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6C193E0", Offset = "0x6C183E0", VA = "0x186C193E0")]
		private static void BOPGFCBJFGO(bool FBMKCHPBDLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6C1C590", Offset = "0x6C1B590", VA = "0x186C1C590")]
		private LJAJHHFEMAM<CCKJFAJJNBI<Dictionary<string, object>>> ONLLOLMDALG(string FKIFALONLFB, string JADDCPGFGLD, string GMFMCHDAKDD, string MDCNNGKLKKA, Dictionary<string, object> FLDCGCNEMKH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6C1C2C0", Offset = "0x6C1B2C0", VA = "0x186C1C2C0")]
		private LJAJHHFEMAM<CCKJFAJJNBI<List<Dictionary<string, object>>>> ONLLOLMDALG(string FKIFALONLFB, string JADDCPGFGLD, string GMFMCHDAKDD, string MDCNNGKLKKA, List<Dictionary<string, object>> FLDCGCNEMKH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x1B602B0", Offset = "0x1B5F2B0", VA = "0x181B602B0")]
		private LJAJHHFEMAM<CCKJFAJJNBI<T>> AGEMAFBADMO<T>(string FKIFALONLFB, string JADDCPGFGLD, string MDCNNGKLKKA, T FLDCGCNEMKH, Dictionary<string, object> MHOGCKFKHIM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x1B60540", Offset = "0x1B5F540", VA = "0x181B60540")]
		private LJAJHHFEMAM<CCKJFAJJNBI<T>> GIDHIOLMPCB<T>(string FKIFALONLFB, string JADDCPGFGLD, string GMFMCHDAKDD, T FLDCGCNEMKH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6C1A160", Offset = "0x6C19160", VA = "0x186C1A160")]
		private bool HPIBANAJOKK(float LCHBLBGEFHN, float OPIACMMDOAI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6C1AA00", Offset = "0x6C19A00", VA = "0x186C1AA00")]
		private Dictionary<string, object> JAHAOCMNFLE(string JADDCPGFGLD, Dictionary<string, object> FLDCGCNEMKH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6C1DC40", Offset = "0x6C1CC40", VA = "0x186C1DC40")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6C19500", Offset = "0x6C18500", VA = "0x186C19500")]
		[CompilerGenerated]
		private long CCJHHKKAOAC()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6C1C240", Offset = "0x6C1B240", VA = "0x186C1C240")]
		[CompilerGenerated]
		private void MOCEAIKPOLI(int GDJFGMPPCAD)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class LKLBAPMFDJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private long MGOEMGMAEAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private LOLHNDDHBLB AJMOBJMDNLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private bool GDJEDCJJAKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private float IHPJOHBJLGL;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6C25F00", Offset = "0x6C24F00", VA = "0x186C25F00")]
	public LKLBAPMFDJB(string FJOKDFDHKNG, float IHPJOHBJLGL = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x235B090", Offset = "0x235A090", VA = "0x18235B090")]
	public void MDDKNKFOJOO<T>(string FJCNAJDOIIE, T CKMKMNKGMMC) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6C25C80", Offset = "0x6C24C80", VA = "0x186C25C80")]
	public void MDDKNKFOJOO(string FJCNAJDOIIE, string CKMKMNKGMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6C25D00", Offset = "0x6C24D00", VA = "0x186C25D00")]
	public void MNGPGNNLJLA(string IMIKEFHKBCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6C25DF0", Offset = "0x6C24DF0", VA = "0x186C25DF0")]
	public void OAFLAEIKCPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6C25B60", Offset = "0x6C24B60", VA = "0x186C25B60")]
	private void COIIOKKCKLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6C25EB0", Offset = "0x6C24EB0", VA = "0x186C25EB0")]
	private bool PGCIHCIOMJM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public enum ODKAECLELLO
{
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	ChatPage,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	PlayerDetailsScreen,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	ActionCode,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	FriendImport,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	PlatformFriendInvite,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	PlatformNotification,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	WatchNotification,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	LegacyHomeScreen,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	NavigationBar,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	LegacyChatPage,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	MobileHomeChat,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	PlayerProfile,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	ShareContent,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	HUDHotbarShortcut
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class HHDCELGCFMN : ADCIIIEIBCH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private ADCIIIEIBCH ECAMAFLMGKL;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private ADCIIIEIBCH FOCDIDELANI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x6C24D40", Offset = "0x6C23D40", VA = "0x186C24D40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool HFIGPCOJDMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6C24AB0", Offset = "0x6C23AB0", VA = "0x186C24AB0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action MGELIDODEDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x6C24CA0", Offset = "0x6C23CA0", VA = "0x186C24CA0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x6C254A0", Offset = "0x6C244A0", VA = "0x186C254A0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action LDFPHJIDFHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x6C24B00", Offset = "0x6C23B00", VA = "0x186C24B00", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6C25400", Offset = "0x6C24400", VA = "0x186C25400", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
	[UnityEngine.Scripting.Preserve]
	public HHDCELGCFMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6C24A40", Offset = "0x6C23A40", VA = "0x186C24A40")]
	[OHDKPIIHCBL(BGEACDHIFOF.GameOnly)]
	private static void BMODLJDCFCE(ECDJHHJLGGB LADPAJPBFMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6C24FB0", Offset = "0x6C23FB0", VA = "0x186C24FB0")]
	[OHDKPIIHCBL(BGEACDHIFOF.EditorOnly)]
	private static void IGELEHEFIDC(ECDJHHJLGGB LADPAJPBFMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6C25020", Offset = "0x6C24020", VA = "0x186C25020", Slot = "8")]
	public FHJJKILLDME JFGMJMMFADK(string JIEELPBEKJL, string JAIGIKEHGGJ, [Optional] DGDKECIOHBM IDLDJLNGPMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6C24BA0", Offset = "0x6C23BA0", VA = "0x186C24BA0", Slot = "10")]
	public FHJJKILLDME EPLGIAAFKBJ(DGDKECIOHBM IDLDJLNGPMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6C24DB0", Offset = "0x6C23DB0", VA = "0x186C24DB0", Slot = "11")]
	public FHJJKILLDME HCLOFABBPBD(DGDKECIOHBM IDLDJLNGPMO, Dictionary<string, string> IDBJONGFHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6C249A0", Offset = "0x6C239A0", VA = "0x186C249A0", Slot = "12")]
	public bool ANBNPMBAIKM(string KPONLHKNHKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6C25540", Offset = "0x6C24540", VA = "0x186C25540", Slot = "13")]
	public MICHFLJJKEH PDBJCBCFGML(string GMLIEGMNEKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x6C25300", Offset = "0x6C24300", VA = "0x186C25300", Slot = "14")]
	public BCJNHDJGFOA LHIEFCOGPIA(string LNCDNPAPNLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6C24EC0", Offset = "0x6C23EC0", VA = "0x186C24EC0", Slot = "15")]
	public FHJJKILLDME HDCNMIMBOFP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x9476C0", Offset = "0x9466C0", VA = "0x1809476C0")]
	[CompilerGenerated]
	private void LOMECMOBCEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x9232E0", Offset = "0x9222E0", VA = "0x1809232E0")]
	[CompilerGenerated]
	private void KJFCOHNAHIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class EKABIANFHPL : ADCIIIEIBCH
{
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static readonly IReadOnlyDictionary<string, HACKMAPINAB> NOLNMLOOIMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private bool FDFLFJMGDFL;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool HFIGPCOJDMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x8401D0", Offset = "0x83F1D0", VA = "0x1808401D0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action MGELIDODEDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6C211A0", Offset = "0x6C201A0", VA = "0x186C211A0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6C223D0", Offset = "0x6C213D0", VA = "0x186C223D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action LDFPHJIDFHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6C20EE0", Offset = "0x6C1FEE0", VA = "0x186C20EE0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6C21D40", Offset = "0x6C20D40", VA = "0x186C21D40", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x6C216C0", Offset = "0x6C206C0", VA = "0x186C216C0", Slot = "8")]
	public FHJJKILLDME JFGMJMMFADK(string JIEELPBEKJL, string JAIGIKEHGGJ, [Optional] DGDKECIOHBM IDLDJLNGPMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6C21530", Offset = "0x6C20530", VA = "0x186C21530", Slot = "15")]
	public FHJJKILLDME HDCNMIMBOFP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x6C20F80", Offset = "0x6C1FF80", VA = "0x186C20F80", Slot = "10")]
	public FHJJKILLDME EPLGIAAFKBJ(DGDKECIOHBM IDLDJLNGPMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x6C21240", Offset = "0x6C20240", VA = "0x186C21240", Slot = "11")]
	public FHJJKILLDME HCLOFABBPBD(DGDKECIOHBM IDLDJLNGPMO, Dictionary<string, string> IDBJONGFHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x6C20C00", Offset = "0x6C1FC00", VA = "0x186C20C00", Slot = "12")]
	public bool ANBNPMBAIKM(string KPONLHKNHKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6C22610", Offset = "0x6C21610", VA = "0x186C22610", Slot = "13")]
	public MICHFLJJKEH PDBJCBCFGML(string GMLIEGMNEKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x6C21C80", Offset = "0x6C20C80", VA = "0x186C21C80", Slot = "14")]
	public BCJNHDJGFOA LHIEFCOGPIA(string LNCDNPAPNLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x6C21DE0", Offset = "0x6C20DE0", VA = "0x186C21DE0")]
	private MFGKCENDJDE ODIFHFGHLKD(DGDKECIOHBM IDLDJLNGPMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6C22470", Offset = "0x6C21470", VA = "0x186C22470")]
	private KMFJLGHEPOP PAJBGLHLFHG(string JAIGIKEHGGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x6C20CB0", Offset = "0x6C1FCB0", VA = "0x186C20CB0")]
	private void DALFNHCEENK(string GMLIEGMNEKL, MICHFLJJKEH MNBJEIBNFOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6C22860", Offset = "0x6C21860", VA = "0x186C22860")]
	public EKABIANFHPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0xAB72B0", Offset = "0xAB62B0", VA = "0x180AB72B0")]
	[CompilerGenerated]
	private void OEOEFBCHLEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6C21B60", Offset = "0x6C20B60", VA = "0x186C21B60")]
	[CompilerGenerated]
	private void KOCMCJMDACI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6C21BF0", Offset = "0x6C20BF0", VA = "0x186C21BF0")]
	[CompilerGenerated]
	private void LCIAEMPLNAO()
	{
	}
}
namespace RecRoom.Analytics.Statsig
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class SerializedStatsigExperimentSegment
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		[SerializeField]
		private string experimentName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		[SerializeField]
		private string parameterName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		[SerializeField]
		private string parameterValue;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public string ExperimentName
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x83A5D0", Offset = "0x8395D0", VA = "0x18083A5D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x91FD40", Offset = "0x91ED40", VA = "0x18091FD40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6C26EC0", Offset = "0x6C25EC0", VA = "0x186C26EC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface ADCIIIEIBCH
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	bool HFIGPCOJDMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action MGELIDODEDN;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action LDFPHJIDFHE;

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FHJJKILLDME JFGMJMMFADK(string JIEELPBEKJL, string JAIGIKEHGGJ, [Optional] DGDKECIOHBM IDLDJLNGPMO);

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "6")]
	FHJJKILLDME EPLGIAAFKBJ(DGDKECIOHBM IDLDJLNGPMO);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "7")]
	FHJJKILLDME HCLOFABBPBD(DGDKECIOHBM IDLDJLNGPMO, Dictionary<string, string> IDBJONGFHKK);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool ANBNPMBAIKM(string KPONLHKNHKL);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	MICHFLJJKEH PDBJCBCFGML(string GMLIEGMNEKL);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	BCJNHDJGFOA LHIEFCOGPIA(string LNCDNPAPNLE);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	FHJJKILLDME HDCNMIMBOFP();
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class IEADJHNGEFB : ADCIIIEIBCH
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool HFIGPCOJDMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8401F0", Offset = "0x83F1F0", VA = "0x1808401F0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action MGELIDODEDN
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6C25780", Offset = "0x6C24780", VA = "0x186C25780", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x6C25AB0", Offset = "0x6C24AB0", VA = "0x186C25AB0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action LDFPHJIDFHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6C25640", Offset = "0x6C24640", VA = "0x186C25640", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x6C25A10", Offset = "0x6C24A10", VA = "0x186C25A10", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
	[RecRoom.NoEngine.Common.Preserve]
	public IEADJHNGEFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6C25960", Offset = "0x6C24960", VA = "0x186C25960", Slot = "8")]
	public FHJJKILLDME JFGMJMMFADK(string JIEELPBEKJL, string JAIGIKEHGGJ, [Optional] DGDKECIOHBM IDLDJLNGPMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6C256E0", Offset = "0x6C246E0", VA = "0x186C256E0", Slot = "10")]
	public FHJJKILLDME EPLGIAAFKBJ(DGDKECIOHBM IDLDJLNGPMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6C25820", Offset = "0x6C24820", VA = "0x186C25820", Slot = "11")]
	public FHJJKILLDME HCLOFABBPBD(DGDKECIOHBM IDLDJLNGPMO, Dictionary<string, string> IDBJONGFHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x840160", Offset = "0x83F160", VA = "0x180840160", Slot = "12")]
	public bool ANBNPMBAIKM(string KPONLHKNHKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6C25B50", Offset = "0x6C24B50", VA = "0x186C25B50", Slot = "13")]
	public MICHFLJJKEH PDBJCBCFGML(string GMLIEGMNEKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6C25A00", Offset = "0x6C24A00", VA = "0x186C25A00", Slot = "14")]
	public BCJNHDJGFOA LHIEFCOGPIA(string LNCDNPAPNLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6C258C0", Offset = "0x6C248C0", VA = "0x186C258C0", Slot = "15")]
	public FHJJKILLDME HDCNMIMBOFP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface DGDKECIOHBM
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	bool NHFFHEFFNEG
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	bool IDMIKNPMHGI
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	bool OKBIOBAMLAO
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	bool? ELFMFGNHNGA
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	int? DCDGLPIDNIO
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	int IOBMGLJDMKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	string MBHLLIBGNCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	string NLHPNCNMENE
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	string MEMJPAILAGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	string KIIHHFGDPLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	string FGJPPJBMHBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	string NNECKDJCINM
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	double HIMMJJEJAIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface FMFNDBDECMB
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	long BDOEHBNKAIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "1")]
	long EJIIHHKAAOI();

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DADFCDNKKFJ(long CFLLBMFDAAN, bool ODFDPIBIDNO = true);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DPEABDBNBGC(string HBLIBBFCHOD, string HHFPBJEPIKJ, string JLCLGDKHGGH);

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MPIEIBOBNMG(string HBLIBBFCHOD);

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BOENMFDFKMG(string HBLIBBFCHOD, string HEOMJJKDHAG, string JJEHHPCDNOH);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EEFJPIBHPCP(string LJDDKLAKIKO, object NIOBBGGBJPE, object CIPLHLNEKBK);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface PPDIHBOPLPD
{
	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LKLBAPMFDJB FENFJENODPE(string FJOKDFDHKNG);
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

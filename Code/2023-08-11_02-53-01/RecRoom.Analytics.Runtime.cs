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
		[Cpp2IlInjected.Address(RVA = "0x7E01F0", Offset = "0x7DE9F0", VA = "0x1807E01F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6823930", Offset = "0x6822130", VA = "0x186823930")]
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
		[Cpp2IlInjected.Address(RVA = "0xA14660", Offset = "0xA12E60", VA = "0x180A14660")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class FPEOLMGFOBI
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> AJLEHNOFDNP;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x681FE40", Offset = "0x681E640", VA = "0x18681FE40")]
	internal static bool AEEHAPIMCJA(string EECINICJCLK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface LHJMODMGJNB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool IMJLBAANEIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string BLCLAKBJEKI
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	string IKNOECGGGHC
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	string KFDLFOBNENP
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	string MJHOIJAIENK
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	JJMNNLLBAJO<MPCDOMBFJIJ> DDPPOOEOHNK(string JOIKFGFAGHF, Dictionary<string, string> BBKFIPFFDPA, bool JCAIHHBBBLO = false);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	JJMNNLLBAJO<MPCDOMBFJIJ> KJJHOJMNHBC(string JOIKFGFAGHF, string FCFOOLEIHNO, string CDMOBCKPPPP, string KOHOOFFOPCI);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct MPCDOMBFJIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly int PCPILOMDAOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly string BOEALFHAKFA;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xCB4DA0", Offset = "0xCB35A0", VA = "0x180CB4DA0")]
	public MPCDOMBFJIJ(int DFGNLPGACFI, string AFOMKBIAEIO)
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
		public AmplitudeAnalyticsClient.Settings LAIOIEIEOPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xA48BE0", Offset = "0xA473E0", VA = "0x180A48BE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool JMFLOKBNJOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xF6D970", Offset = "0xF6C170", VA = "0x180F6D970")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x90A150", Offset = "0x908950", VA = "0x18090A150")]
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
			[Cpp2IlInjected.Address(RVA = "0x681E520", Offset = "0x681CD20", VA = "0x18681E520")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x681E5F0", Offset = "0x681CDF0", VA = "0x18681E5F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static string StableId
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x681E560", Offset = "0x681CD60", VA = "0x18681E560")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x681E640", Offset = "0x681CE40", VA = "0x18681E640")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static string ClientLauncher
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x681E4E0", Offset = "0x681CCE0", VA = "0x18681E4E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x681E5A0", Offset = "0x681CDA0", VA = "0x18681E5A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8E8B60", Offset = "0x8E7360", VA = "0x1808E8B60")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x681E210", Offset = "0x681CA10", VA = "0x18681E210")]
		public static HGECIPNFCEG OIAKNFDBOOD(string MNJCDKNLLPF, [NotNull] string MLJMKKCOHMB, long HMJKNDANMKK, long FAOHBBDLHDB, string EHKIONDBEDO, bool DCNPHCBDKNI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x681D860", Offset = "0x681C060", VA = "0x18681D860")]
		public static HGECIPNFCEG BJJBFIMAELN(string MNJCDKNLLPF, [NotNull] string MLJMKKCOHMB, long HMJKNDANMKK, long FAOHBBDLHDB, string EHKIONDBEDO, long AFKJLOEIDHP, bool DCNPHCBDKNI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x681E300", Offset = "0x681CB00", VA = "0x18681E300")]
		private AmplitudeAnalyticsEvent(string MNJCDKNLLPF, [NotNull] string MLJMKKCOHMB, long HMJKNDANMKK, long FAOHBBDLHDB, string EHKIONDBEDO, bool DCNPHCBDKNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xFCA1F0", Offset = "0xFC89F0", VA = "0x180FCA1F0")]
		public void CCLLMEILMME(long CHENMPDHHJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x681DFC0", Offset = "0x681C7C0", VA = "0x18681DFC0", Slot = "5")]
		public override void GGPCOFMEHDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x681E0B0", Offset = "0x681C8B0", VA = "0x18681E0B0", Slot = "6")]
		public override void JBPCHBHGCDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x681D970", Offset = "0x681C170", VA = "0x18681D970", Slot = "4")]
		protected override Dictionary<string, object> EJNCEFODCOE(Dictionary<string, object> LLJLJOPNACG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x681DEB0", Offset = "0x681C6B0", VA = "0x18681DEB0")]
		private void GGMODEPHGDD(string EECINICJCLK, string MENBIMCLIOI, bool IABNOMFHPFI = false)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class OMKBAHENDPC : FNIPCBBGNKK<AmplitudeAnalyticsIdentifyMessage, OMKBAHENDPC>
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override OMKBAHENDPC MNJNMEFGPGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8A8EB0", Offset = "0x8A76B0", VA = "0x1808A8EB0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x979150", Offset = "0x977950", VA = "0x180979150", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage EJOKLEOGAAI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6824F40", Offset = "0x6823740", VA = "0x186824F40")]
	public OMKBAHENDPC(AmplitudeAnalyticsIdentifyMessage AKADEFDGONP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6824ED0", Offset = "0x68236D0", VA = "0x186824ED0", Slot = "4")]
	public override void JBPCHBHGCDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class HGECIPNFCEG : FNIPCBBGNKK<AmplitudeAnalyticsEvent, HGECIPNFCEG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private bool AONHBPAMHBL;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override HGECIPNFCEG MNJNMEFGPGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8A8EB0", Offset = "0x8A76B0", VA = "0x1808A8EB0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public long GMAMEFGLIBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2026BE0", Offset = "0x20253E0", VA = "0x182026BE0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6820800", Offset = "0x681F000", VA = "0x186820800")]
	public HGECIPNFCEG(AmplitudeAnalyticsEvent AKADEFDGONP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x979150", Offset = "0x977950", VA = "0x180979150", Slot = "5")]
	public override AmplitudeAnalyticsEvent EJOKLEOGAAI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6820B30", Offset = "0x681F330", VA = "0x186820B30", Slot = "4")]
	public override void JBPCHBHGCDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1CB4910", Offset = "0x1CB3110", VA = "0x181CB4910")]
	public HGECIPNFCEG EFCHPOEHFAM<T>(string OPCEAOKDBMJ, T[] MENBIMCLIOI) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6820AB0", Offset = "0x681F2B0", VA = "0x186820AB0")]
	public HGECIPNFCEG EFCHPOEHFAM(string OPCEAOKDBMJ, string[] MENBIMCLIOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1CB48A0", Offset = "0x1CB30A0", VA = "0x181CB48A0")]
	public HGECIPNFCEG EFCHPOEHFAM<T>(string OPCEAOKDBMJ, T MENBIMCLIOI) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6820A20", Offset = "0x681F220", VA = "0x186820A20")]
	public HGECIPNFCEG EFCHPOEHFAM(string OPCEAOKDBMJ, long MENBIMCLIOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6820AC0", Offset = "0x681F2C0", VA = "0x186820AC0")]
	public HGECIPNFCEG EFCHPOEHFAM(string OPCEAOKDBMJ, string MENBIMCLIOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x68209F0", Offset = "0x681F1F0", VA = "0x1868209F0")]
	public HGECIPNFCEG EEIMMPHPJMN(string OPCEAOKDBMJ, object? MENBIMCLIOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6820950", Offset = "0x681F150", VA = "0x186820950")]
	public HGECIPNFCEG DPJLACCPOPN(string OPCEAOKDBMJ, string MENBIMCLIOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6820850", Offset = "0x681F050", VA = "0x186820850")]
	private HGECIPNFCEG CGBECAGJOPN(string OPCEAOKDBMJ, object MENBIMCLIOI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class HDHIJPLHDHB : HGECIPNFCEG
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6820800", Offset = "0x681F000", VA = "0x186820800")]
	public HDHIJPLHDHB(AmplitudeAnalyticsEvent AKADEFDGONP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6820670", Offset = "0x681EE70", VA = "0x186820670", Slot = "4")]
	public override void JBPCHBHGCDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class FNIPCBBGNKK<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : FNIPCBBGNKK<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected M AKADEFDGONP;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public abstract BLDR MNJNMEFGPGO
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x18FBCA0", Offset = "0x18FA4A0", VA = "0x1818FBCA0")]
	public FNIPCBBGNKK(M AKADEFDGONP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2240520", Offset = "0x223ED20", VA = "0x182240520")]
	public BLDR LCDNAPKPJKA(AmplitudeAnalyticsIdentifyMessage.DeviceInfo OKIIJPJPFDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2240340", Offset = "0x223EB40", VA = "0x182240340")]
	public BLDR EKCHMHNKMNJ(AmplitudeAnalyticsIdentifyMessage.RevenueData PNHNFJJNDIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x22404B0", Offset = "0x223ECB0", VA = "0x1822404B0")]
	public BLDR ICMENBKLEJN(string OPCEAOKDBMJ, string MENBIMCLIOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1F62ED0", Offset = "0x1F616D0", VA = "0x181F62ED0")]
	public BLDR ICMENBKLEJN<T>(string OPCEAOKDBMJ, T MENBIMCLIOI) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void JBPCHBHGCDP();

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2240380", Offset = "0x223EB80", VA = "0x182240380")]
	internal static string EMHEOPNACCP(string MENBIMCLIOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x22403B0", Offset = "0x223EBB0", VA = "0x1822403B0")]
	private BLDR FFACLJPGLJO(string OPCEAOKDBMJ, object MENBIMCLIOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M EJOKLEOGAAI();
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
			[Cpp2IlInjected.Address(RVA = "0x681F910", Offset = "0x681E110", VA = "0x18681F910")]
			public void AEBOKHHKION(Dictionary<string, object> PJGEABCONNA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
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
			[Cpp2IlInjected.Address(RVA = "0x6825C30", Offset = "0x6824430", VA = "0x186825C30")]
			public void AEBOKHHKION(Dictionary<string, object> JECIBAHENAB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6825DA0", Offset = "0x68245A0", VA = "0x186825DA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x7DF170", Offset = "0x7DD970", VA = "0x1807DF170")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x892CB0", Offset = "0x8914B0", VA = "0x180892CB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x681EBA0", Offset = "0x681D3A0", VA = "0x18681EBA0")]
		public static OMKBAHENDPC OIAKNFDBOOD(string MNJCDKNLLPF, string EHKIONDBEDO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x681ECD0", Offset = "0x681D4D0", VA = "0x18681ECD0")]
		protected AmplitudeAnalyticsIdentifyMessage(string MNJCDKNLLPF, string EHKIONDBEDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x681EC50", Offset = "0x681D450", VA = "0x18681EC50")]
		public Dictionary<string, object> PHEGHKHJFLH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x681E690", Offset = "0x681CE90", VA = "0x18681E690", Slot = "4")]
		protected virtual Dictionary<string, object> EJNCEFODCOE(Dictionary<string, object> LLJLJOPNACG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x681EA30", Offset = "0x681D230", VA = "0x18681EA30")]
		protected void HEFINBMHCPD(string EECINICJCLK, Dictionary<string, object> KFEKHLHJMLD, Dictionary<string, object> HOGEGMONCKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x681EB30", Offset = "0x681D330", VA = "0x18681EB30")]
		protected void JOCJHEOJLPM(string EECINICJCLK, string MENBIMCLIOI, Dictionary<string, object> PAODDIPCLGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x681E9D0", Offset = "0x681D1D0", VA = "0x18681E9D0", Slot = "5")]
		public virtual void GGPCOFMEHDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x681EAE0", Offset = "0x681D2E0", VA = "0x18681EAE0", Slot = "6")]
		public virtual void JBPCHBHGCDP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		private enum PFAGCEMOLGE
		{
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		internal class OAADKFLBBHE
		{
			[Cpp2IlInjected.Token(Token = "0x2000015")]
			private class ANGFMLCNLCB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000067")]
				public int DPABOMOEABP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000068")]
				public Dictionary<string, object> HMJOFHMMNME;

				[Cpp2IlInjected.Token(Token = "0x6000098")]
				[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
				public ANGFMLCNLCB()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000016")]
			[CompilerGenerated]
			private sealed class NGAHKAKGANH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000069")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000099")]
				[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
				public NGAHKAKGANH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600009A")]
				[Cpp2IlInjected.Address(RVA = "0x68238D0", Offset = "0x68220D0", VA = "0x1868238D0")]
				internal bool CFNNOBIGLPJ(ANGFMLCNLCB item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private const string DBKEGBNLLIF = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			private readonly string NFJIPFJDKNL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private List<ANGFMLCNLCB> LHFBLLOJCLL;

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public int? AEHPCHHKELI
			{
				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0x6824360", Offset = "0x6822B60", VA = "0x186824360")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x6824D40", Offset = "0x6823540", VA = "0x186824D40")]
			internal OAADKFLBBHE(string JJHOGKEPIFD, string KBBPLGIMMNH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x6823CB0", Offset = "0x68224B0", VA = "0x186823CB0")]
			public int CKFFCGPOFCH([Optional] int? NLEFALMICLE)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x6824AA0", Offset = "0x68232A0", VA = "0x186824AA0")]
			public List<Dictionary<string, object>> KGLFCFFEDCF(int KLBEFKKDHNN, int? NLEFALMICLE)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x6823AD0", Offset = "0x68222D0", VA = "0x186823AD0")]
			public void BCBMOJPHLIL(AmplitudeAnalyticsIdentifyMessage CEPDEAHBHLF, bool GDEMLKFDIEO = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x68239C0", Offset = "0x68221C0", VA = "0x1868239C0")]
			public void BCBMOJPHLIL(Dictionary<string, object> CEPDEAHBHLF, bool GDEMLKFDIEO = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x68241D0", Offset = "0x68229D0", VA = "0x1868241D0")]
			public void GNCKAFCGBAO(params Dictionary<string, object>[] GFPKNJJODKG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x6824400", Offset = "0x6822C00", VA = "0x186824400")]
			public void IBMFPLFJCGI(List<Dictionary<string, object>> FLJODNPLFDM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x6823B70", Offset = "0x6822370", VA = "0x186823B70")]
			private void CCGEEPAAFFD(Dictionary<string, object> CEPDEAHBHLF, bool GDEMLKFDIEO = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x6823F60", Offset = "0x6822760", VA = "0x186823F60")]
			public void GIOKDKOJLEE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x6824650", Offset = "0x6822E50", VA = "0x186824650")]
			private void IKEBDMBMBGB([Optional] string CDDPFJOANEJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x6823E30", Offset = "0x6822630", VA = "0x186823E30")]
			private static string GGIMLBNNNBO(string MENBIMCLIOI, string EECINICJCLK)
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
			[Cpp2IlInjected.Address(RVA = "0x6826000", Offset = "0x6824800", VA = "0x186826000")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public struct MCJAPCPFPKG<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public int DFGNLPGACFI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public string AFOMKBIAEIO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public T BPOJBLHKLIK;
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class AGIDCGAJPDJ : IEnumerator<EPHOKNIGMNK>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private EPHOKNIGMNK <>2__current;

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
			private EPHOKNIGMNK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000A4")]
				[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xA2B190", Offset = "0xA29990", VA = "0x180A2B190")]
			[DebuggerHidden]
			public AGIDCGAJPDJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x6817DF0", Offset = "0x68165F0", VA = "0x186817DF0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x6818560", Offset = "0x6816D60", VA = "0x186818560", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class GOJODFNKGBN : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public ACOJIJEEGAO quitCompletePromise;

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
				[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xA2B190", Offset = "0xA29990", VA = "0x180A2B190")]
			[DebuggerHidden]
			public GOJODFNKGBN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x6820510", Offset = "0x681ED10", VA = "0x186820510", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x6820630", Offset = "0x681EE30", VA = "0x186820630", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class KLAFIFHFECA : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xA2B190", Offset = "0xA29990", VA = "0x180A2B190")]
			[DebuggerHidden]
			public KLAFIFHFECA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x68231C0", Offset = "0x68219C0", VA = "0x1868231C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x6823350", Offset = "0x6821B50", VA = "0x186823350", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class EKGEKHBGPDI : IEnumerator<EPHOKNIGMNK>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			private EPHOKNIGMNK <>2__current;

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
			private OAADKFLBBHE <cache>5__2;

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
			private EPHOKNIGMNK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000B6")]
				[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xA2B190", Offset = "0xA29990", VA = "0x180A2B190")]
			[DebuggerHidden]
			public EKGEKHBGPDI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x681FA90", Offset = "0x681E290", VA = "0x18681FA90", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x681FE00", Offset = "0x681E600", VA = "0x18681FE00", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class BGALHMBOHDG : IEnumerator<EPHOKNIGMNK>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			private EPHOKNIGMNK <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public float timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			private OAADKFLBBHE <cache>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			private string <url>5__2;

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			private EPHOKNIGMNK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000C0")]
				[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0xA2B190", Offset = "0xA29990", VA = "0x180A2B190")]
			[DebuggerHidden]
			public BGALHMBOHDG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x681F5E0", Offset = "0x681DDE0", VA = "0x18681F5E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x681F8D0", Offset = "0x681E0D0", VA = "0x18681F8D0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class BDNEHNLPOBP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public List<Dictionary<string, object>> batch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			public OAADKFLBBHE cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
			public BDNEHNLPOBP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x681F270", Offset = "0x681DA70", VA = "0x18681F270")]
			internal void EHKDMCONLLI(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x681EDD0", Offset = "0x681D5D0", VA = "0x18681EDD0")]
			internal void COOHGCIKICI(MCJAPCPFPKG<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[CompilerGenerated]
		private sealed class JFBLMHHMCKK : IEnumerator<EPHOKNIGMNK>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			private EPHOKNIGMNK <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			public OAADKFLBBHE cache;

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
			private BDNEHNLPOBP <>8__1;

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
			private EPHOKNIGMNK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000C9")]
				[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xA2B190", Offset = "0xA29990", VA = "0x180A2B190")]
			[DebuggerHidden]
			public JFBLMHHMCKK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x6822860", Offset = "0x6821060", VA = "0x186822860", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x6823180", Offset = "0x6821980", VA = "0x186823180", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class EMJLHDHLKPO<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0xC2D400", Offset = "0xC2BC00", VA = "0x180C2D400")]
			public EMJLHDHLKPO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x24860D0", Offset = "0x24848D0", VA = "0x1824860D0")]
			internal MCJAPCPFPKG<T> OKHCFAEOKFN(MPCDOMBFJIJ postResponse)
			{
				return default(MCJAPCPFPKG<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private sealed class LPFEJKHOAII<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0xC2D400", Offset = "0xC2BC00", VA = "0x180C2D400")]
			public LPFEJKHOAII()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x24860D0", Offset = "0x24848D0", VA = "0x1824860D0")]
			internal MCJAPCPFPKG<T> HLJPDFGHEKM(MPCDOMBFJIJ postResponse)
			{
				return default(MCJAPCPFPKG<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private EPJPDLNCDIN OLFACHFFCBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private Lazy<LEOJCOHKGOF> NLODMACBBAK;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private const string OLIHMGOPNPG = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const string GHMPJNADINJ = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private const string FPAHCDHJOJB = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private const int DDJKPLDAFMG = 15;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private const int GJKEDGJGIHD = 10;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private const int NEHHHDALDLC = 5;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private const float DFCBDENNNCM = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private const long DPGCEGOILAI = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private const string MOEODEDMCGK = "f1779b982f1c09aed3adb3cca563cbc2";

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private const string KOACDOCIACM = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static bool BJFAOPJCHDF;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static bool GCPBLKAGKPD;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static int LBHMICOPBCO;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static int EIGEHNCBCCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private LHJMODMGJNB KMELCHHGGCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private bool ELPDCAHNEEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private float NCCFDBPDNFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private float GFIMBHKPIEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private int ONDJKPFLBCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private int AFMBKEGAHAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private int? OMLKHFMBIPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private int? HEJMCDDMDBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private long EEDNOPBHCEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private string DNDKODECDMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private bool GCHGMLKGGLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private long GCFEDMCIIFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private Dictionary<string, object> ODJJBICOMCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private PFAGCEMOLGE EBCHPHGACKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private int HAOCECFBJDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private int CFPCHEMICBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private float BEIOPCFGNPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private bool GFDEIFAKANG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private bool BCDPJIIOKEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private OAADKFLBBHE CANIOAIJBMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private OAADKFLBBHE KNELGJDFEJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private OAADKFLBBHE CMLCEBMPJJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> KFMHMGHILAB;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo ILIMLEFGHOJ;

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private static string IIDBCNIOGED;

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private const string HIOPDHMLHNG = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private readonly string EKJNNFOCOAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private readonly string GGKHCBELGMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly string BICDBOKJNCE;

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private EPJPDLNCDIN NEADGAKFLCE
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x681BBE0", Offset = "0x681A3E0", VA = "0x18681BBE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private LEOJCOHKGOF DFINOCIBMIA
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x681BC50", Offset = "0x681A450", VA = "0x18681BC50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private static int JNBPMIPKGKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x681BD30", Offset = "0x681A530", VA = "0x18681BD30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static long HLKPJGCCCIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x681D700", Offset = "0x681BF00", VA = "0x18681D700")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x681D800", Offset = "0x681C000", VA = "0x18681D800")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static string OGIDPFMKPPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x681D6A0", Offset = "0x681BEA0", VA = "0x18681D6A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static string JCFIPEABDHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x681D6D0", Offset = "0x681BED0", VA = "0x18681D6D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public string CAKGJKFHJFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x907500", Offset = "0x905D00", VA = "0x180907500")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xD86930", Offset = "0xD85130", VA = "0x180D86930")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public int? JDDFJDFIHBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x92DCB0", Offset = "0x92C4B0", VA = "0x18092DCB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xCCFD40", Offset = "0xCCE540", VA = "0x180CCFD40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool LEKBAIJGBDH
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x9243D0", Offset = "0x922BD0", VA = "0x1809243D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x922370", Offset = "0x920B70", VA = "0x180922370")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static bool IPBLAMJBDLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x681D610", Offset = "0x681BE10", VA = "0x18681D610")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> CKLHEMCBJMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x681D570", Offset = "0x681BD70", VA = "0x18681D570")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x681D760", Offset = "0x681BF60", VA = "0x18681D760")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x68188E0", Offset = "0x68170E0", VA = "0x1868188E0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x681A500", Offset = "0x6818D00", VA = "0x18681A500")]
		private void HIAMLANLCDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x681CCA0", Offset = "0x681B4A0", VA = "0x18681CCA0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x681BF00", Offset = "0x681A700", VA = "0x18681BF00", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x681CF80", Offset = "0x681B780", VA = "0x18681CF80")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x681C140", Offset = "0x681A940", VA = "0x18681C140")]
		public GHJKEMFHLHG PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x681ADA0", Offset = "0x68195A0", VA = "0x18681ADA0")]
		[IteratorStateMachine(typeof(AGIDCGAJPDJ))]
		public IEnumerator<EPHOKNIGMNK> Initialize(AmplitudeAnalyticsEvent IMHLPDHJCCO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x681CE80", Offset = "0x681B680", VA = "0x18681CE80")]
		public void UpdateLastAliveTime(float KMCBFGDKCFK = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x681A430", Offset = "0x6818C30", VA = "0x18681A430")]
		private GHJKEMFHLHG HGNLAFKFPPK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x681A2C0", Offset = "0x6818AC0", VA = "0x18681A2C0")]
		private GHJKEMFHLHG GKEDHBKBLLF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x681C7A0", Offset = "0x681AFA0", VA = "0x18681C7A0")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x681BCA0", Offset = "0x681A4A0", VA = "0x18681BCA0")]
		[IteratorStateMachine(typeof(GOJODFNKGBN))]
		private IEnumerator NFDJEPCNPCB(ACOJIJEEGAO LCDODHNNMPC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x681D200", Offset = "0x681BA00", VA = "0x18681D200")]
		[IteratorStateMachine(typeof(KLAFIFHFECA))]
		public IEnumerator WaitForFlush(float FKDBGBDFJED = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x681CD60", Offset = "0x681B560", VA = "0x18681CD60")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x681CCB0", Offset = "0x681B4B0", VA = "0x18681CCB0")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime MJLKABMFGJA)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x681A9F0", Offset = "0x68191F0", VA = "0x18681A9F0")]
		public static OMKBAHENDPC Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6818780", Offset = "0x6816F80", VA = "0x186818780")]
		public static HGECIPNFCEG AccountSelectionPostLoginEvent([NotNull] string OICOOPKLAOI, string EHKIONDBEDO, bool DCNPHCBDKNI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6819370", Offset = "0x6817B70", VA = "0x186819370")]
		public static HGECIPNFCEG Event([NotNull] string OICOOPKLAOI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x681C300", Offset = "0x681AB00", VA = "0x18681C300")]
		public static HGECIPNFCEG PreviousSessionEvent([NotNull] string OICOOPKLAOI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x681AB20", Offset = "0x6819320", VA = "0x18681AB20")]
		public static HGECIPNFCEG InitializeEvent(string EHKIONDBEDO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x681C980", Offset = "0x681B180", VA = "0x18681C980")]
		public static HGECIPNFCEG StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6818BD0", Offset = "0x68173D0", VA = "0x186818BD0")]
		public static HGECIPNFCEG CreateOutOfSessionEvent(string OICOOPKLAOI, bool MIIOMFJMCKL = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x681B6C0", Offset = "0x6819EC0", VA = "0x18681B6C0")]
		public static GHJKEMFHLHG LogOutOfSessionEvent(HGECIPNFCEG GDNOEJOMOPN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x681B420", Offset = "0x6819C20", VA = "0x18681B420")]
		public void LogEventAsync(AmplitudeAnalyticsEvent DOOCICNKBLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x681B9B0", Offset = "0x681A1B0", VA = "0x18681B9B0")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent DOOCICNKBLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x681BB00", Offset = "0x681A300", VA = "0x18681BB00")]
		public void LogSerializedEventAsync(Dictionary<string, object> HDGJJLDJKCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x681B570", Offset = "0x6819D70", VA = "0x18681B570")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage NFABPNMILPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6819280", Offset = "0x6817A80", VA = "0x186819280")]
		private void EENAFADCFLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x681B070", Offset = "0x6819870", VA = "0x18681B070")]
		private void LLKLLDHIICI(Dictionary<string, object> DELKFNCDMKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x681B320", Offset = "0x6819B20", VA = "0x18681B320")]
		private void LPHBOEKJJNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x68185A0", Offset = "0x6816DA0", VA = "0x1868185A0")]
		private void AABCMBHEEOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x681A230", Offset = "0x6818A30", VA = "0x18681A230")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x681BFA0", Offset = "0x681A7A0", VA = "0x18681BFA0")]
		[IteratorStateMachine(typeof(EKGEKHBGPDI))]
		private IEnumerator<EPHOKNIGMNK> PBMGLBDKCBJ(float FKDBGBDFJED = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x681A910", Offset = "0x6819110", VA = "0x18681A910")]
		[IteratorStateMachine(typeof(BGALHMBOHDG))]
		private IEnumerator<EPHOKNIGMNK> IAMLGCBNHML(float FKDBGBDFJED = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x681AF90", Offset = "0x6819790", VA = "0x18681AF90")]
		[IteratorStateMachine(typeof(JFBLMHHMCKK))]
		private IEnumerator<EPHOKNIGMNK> JKMHMKGKMIE(OAADKFLBBHE LOEBLGMOKAJ, int? NLEFALMICLE, string JOIKFGFAGHF, string OCNPDEKINML, float FKDBGBDFJED, Action<int> MCCACLLHMAI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x681C020", Offset = "0x681A820", VA = "0x18681C020")]
		private static void PKOKILAFCLL(bool BGLEGLELNAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6818E80", Offset = "0x6817680", VA = "0x186818E80")]
		private JJMNNLLBAJO<MCJAPCPFPKG<Dictionary<string, object>>> DDPPOOEOHNK(string JOIKFGFAGHF, string OCNPDEKINML, string DMHFFGBOCEA, string PGNAAFANCJP, Dictionary<string, object> BPOJBLHKLIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6818FB0", Offset = "0x68177B0", VA = "0x186818FB0")]
		private JJMNNLLBAJO<MCJAPCPFPKG<List<Dictionary<string, object>>>> DDPPOOEOHNK(string JOIKFGFAGHF, string OCNPDEKINML, string DMHFFGBOCEA, string PGNAAFANCJP, List<Dictionary<string, object>> BPOJBLHKLIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x48BBB30", Offset = "0x48BA330", VA = "0x1848BBB30")]
		private JJMNNLLBAJO<MCJAPCPFPKG<T>> MENLEFGEAMF<T>(string JOIKFGFAGHF, string OCNPDEKINML, string PGNAAFANCJP, T BPOJBLHKLIK, Dictionary<string, object> ANLIEIKHJBH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x48BB7F0", Offset = "0x48B9FF0", VA = "0x1848BB7F0")]
		private JJMNNLLBAJO<MCJAPCPFPKG<T>> AMBFHKMENBF<T>(string JOIKFGFAGHF, string OCNPDEKINML, string DMHFFGBOCEA, T BPOJBLHKLIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x681A9A0", Offset = "0x68191A0", VA = "0x18681A9A0")]
		private bool IHILPGLLJIC(float MJALINOKJHE, float FKDBGBDFJED)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6819560", Offset = "0x6817D60", VA = "0x186819560")]
		private Dictionary<string, object> FBFPBDLHJED(string OCNPDEKINML, Dictionary<string, object> BPOJBLHKLIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x681D2E0", Offset = "0x681BAE0", VA = "0x18681D2E0")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x681AE30", Offset = "0x6819630", VA = "0x18681AE30")]
		[CompilerGenerated]
		private long JAGFEKCMEOO()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x681A990", Offset = "0x6819190", VA = "0x18681A990")]
		[CompilerGenerated]
		private void IEMJHHAGDJM(int AFLONMEGMJM)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class LACNGBKOEFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private long BKFJMNCNDKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private HGECIPNFCEG KIJNPBFBKFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private bool IJFJKCICDAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private float MCEGFJIBJCF;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6823730", Offset = "0x6821F30", VA = "0x186823730")]
	public LACNGBKOEFA(string MOBAHLPOJFO, float MCEGFJIBJCF = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x1D9C910", Offset = "0x1D9B110", VA = "0x181D9C910")]
	public void EFCHPOEHFAM<T>(string OPCEAOKDBMJ, T MENBIMCLIOI) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x68235F0", Offset = "0x6821DF0", VA = "0x1868235F0")]
	public void EFCHPOEHFAM(string OPCEAOKDBMJ, string MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x68233E0", Offset = "0x6821BE0", VA = "0x1868233E0")]
	public void CFNDOJCDHNB(string FDEBNFDLGBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6823670", Offset = "0x6821E70", VA = "0x186823670")]
	public void GNOPMELNICA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x68234D0", Offset = "0x6821CD0", VA = "0x1868234D0")]
	private void DIGOFADBDOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6823390", Offset = "0x6821B90", VA = "0x186823390")]
	private bool BMLMDLLKMGF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public enum EDACIEAPDGD
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
	HUDHotbarShortcut,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	GameInvite
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class PKMAKAPIADM : FCNDCIMMMAN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private FCNDCIMMMAN BADKHCHOCEE;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private FCNDCIMMMAN MOJFAFLNEFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x6825750", Offset = "0x6823F50", VA = "0x186825750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool CENAPLLCNNC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6825410", Offset = "0x6823C10", VA = "0x186825410", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action ALMEPNGJJBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x6825610", Offset = "0x6823E10", VA = "0x186825610", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x68256B0", Offset = "0x6823EB0", VA = "0x1868256B0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action IEKGGGHNJCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x6825A20", Offset = "0x6824220", VA = "0x186825A20", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6825460", Offset = "0x6823C60", VA = "0x186825460", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	[UnityEngine.Scripting.Preserve]
	public PKMAKAPIADM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x68257C0", Offset = "0x6823FC0", VA = "0x1868257C0")]
	[NFOBBCLLFPP(BGPNPCEMJLD.GameOnly)]
	private static void ICOGGLLGJEI(LIFDIPFHEEA KEMGJJIKGPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6825BC0", Offset = "0x68243C0", VA = "0x186825BC0")]
	[NFOBBCLLFPP(BGPNPCEMJLD.EditorOnly)]
	private static void OJLGFAKCKMB(LIFDIPFHEEA KEMGJJIKGPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6825130", Offset = "0x6823930", VA = "0x186825130", Slot = "8")]
	public GHJKEMFHLHG BDCEDMLOOPD(string PIIANNGIBHG, string KBBPLGIMMNH, [Optional] IJOMLLKMIAF GABJJBPMBKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6825920", Offset = "0x6824120", VA = "0x186825920", Slot = "10")]
	public GHJKEMFHLHG INDILAOFCBF(IJOMLLKMIAF GABJJBPMBKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6825500", Offset = "0x6823D00", VA = "0x186825500", Slot = "11")]
	public GHJKEMFHLHG EKHFONLPHEO(IJOMLLKMIAF GABJJBPMBKD, Dictionary<string, string> KBIOJNPAPNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6825090", Offset = "0x6823890", VA = "0x186825090", Slot = "12")]
	public bool BCKKIHBAPAL(string CLBMAHPAKHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6824F90", Offset = "0x6823790", VA = "0x186824F90", Slot = "13")]
	public PFEDGCBPALD ANFJCCLBPLK(string BCHFINPGIPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x6825AC0", Offset = "0x68242C0", VA = "0x186825AC0", Slot = "14")]
	public MIHOPLLDJBG NFNPCAIPNOD(string EGFAMFAGJBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6825830", Offset = "0x6824030", VA = "0x186825830", Slot = "15")]
	public GHJKEMFHLHG IDKCBNGHHNB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x7F4390", Offset = "0x7F2B90", VA = "0x1807F4390")]
	[CompilerGenerated]
	private void CDIGPPJPJFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x7F43B0", Offset = "0x7F2BB0", VA = "0x1807F43B0")]
	[CompilerGenerated]
	private void CCCKJPHMHGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class IKLINDHOGAB : FCNDCIMMMAN
{
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static readonly IReadOnlyDictionary<string, KKAEBPLOHLP> EMEFDPAHBIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private bool DKLEJLCIFCC;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool CENAPLLCNNC
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x97D920", Offset = "0x97C120", VA = "0x18097D920", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action ALMEPNGJJBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x68215D0", Offset = "0x681FDD0", VA = "0x1868215D0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6821670", Offset = "0x681FE70", VA = "0x186821670", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action IEKGGGHNJCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6821B50", Offset = "0x6820350", VA = "0x186821B50", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6821240", Offset = "0x681FA40", VA = "0x186821240", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x6820DA0", Offset = "0x681F5A0", VA = "0x186820DA0", Slot = "8")]
	public GHJKEMFHLHG BDCEDMLOOPD(string PIIANNGIBHG, string KBBPLGIMMNH, [Optional] IJOMLLKMIAF GABJJBPMBKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6821710", Offset = "0x681FF10", VA = "0x186821710", Slot = "15")]
	public GHJKEMFHLHG IDKCBNGHHNB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x68218A0", Offset = "0x68200A0", VA = "0x1868218A0", Slot = "10")]
	public GHJKEMFHLHG INDILAOFCBF(IJOMLLKMIAF GABJJBPMBKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x68212E0", Offset = "0x681FAE0", VA = "0x1868212E0", Slot = "11")]
	public GHJKEMFHLHG EKHFONLPHEO(IJOMLLKMIAF GABJJBPMBKD, Dictionary<string, string> KBIOJNPAPNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x6820CF0", Offset = "0x681F4F0", VA = "0x186820CF0", Slot = "12")]
	public bool BCKKIHBAPAL(string CLBMAHPAKHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6820BD0", Offset = "0x681F3D0", VA = "0x186820BD0", Slot = "13")]
	public PFEDGCBPALD ANFJCCLBPLK(string BCHFINPGIPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x6822050", Offset = "0x6820850", VA = "0x186822050", Slot = "14")]
	public MIHOPLLDJBG NFNPCAIPNOD(string EGFAMFAGJBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x6822110", Offset = "0x6820910", VA = "0x186822110")]
	private OMONGCKKCCI PBBHMIMLJMH(IJOMLLKMIAF GABJJBPMBKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6821BF0", Offset = "0x68203F0", VA = "0x186821BF0")]
	private FHJNGPGDDNN MPAIJJPEPAN(string KBBPLGIMMNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x6821D90", Offset = "0x6820590", VA = "0x186821D90")]
	private void NCNICCIKFIO(string BCHFINPGIPK, PFEDGCBPALD GGGECKCCDMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6822830", Offset = "0x6821030", VA = "0x186822830")]
	public IKLINDHOGAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x1056440", Offset = "0x1054C40", VA = "0x181056440")]
	[CompilerGenerated]
	private void DDMALFPFIAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6821AC0", Offset = "0x68202C0", VA = "0x186821AC0")]
	[CompilerGenerated]
	private void KKDOGHCJFEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6821FC0", Offset = "0x68207C0", VA = "0x186821FC0")]
	[CompilerGenerated]
	private void NFKLDELLMMC()
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
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		[SerializeField]
		private string experimentName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		[SerializeField]
		private string parameterName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		[SerializeField]
		private string parameterValue;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public string ExperimentName
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x7DF170", Offset = "0x7DD970", VA = "0x1807DF170")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x7EC6C0", Offset = "0x7EAEC0", VA = "0x1807EC6C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6825DB0", Offset = "0x68245B0", VA = "0x186825DB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface FCNDCIMMMAN
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	bool CENAPLLCNNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action ALMEPNGJJBC;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action IEKGGGHNJCH;

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GHJKEMFHLHG BDCEDMLOOPD(string PIIANNGIBHG, string KBBPLGIMMNH, [Optional] IJOMLLKMIAF GABJJBPMBKD);

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GHJKEMFHLHG INDILAOFCBF(IJOMLLKMIAF GABJJBPMBKD);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GHJKEMFHLHG EKHFONLPHEO(IJOMLLKMIAF GABJJBPMBKD, Dictionary<string, string> KBIOJNPAPNA);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool BCKKIHBAPAL(string CLBMAHPAKHA);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	PFEDGCBPALD ANFJCCLBPLK(string BCHFINPGIPK);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	MIHOPLLDJBG NFNPCAIPNOD(string EGFAMFAGJBJ);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	GHJKEMFHLHG IDKCBNGHHNB();
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class GEIKECHKMEK : FCNDCIMMMAN
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool CENAPLLCNNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x7EE860", Offset = "0x7ED060", VA = "0x1807EE860", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action ALMEPNGJJBC
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x68201E0", Offset = "0x681E9E0", VA = "0x1868201E0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x6820280", Offset = "0x681EA80", VA = "0x186820280", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action IEKGGGHNJCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6820460", Offset = "0x681EC60", VA = "0x186820460", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x68200A0", Offset = "0x681E8A0", VA = "0x1868200A0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	[RecRoom.NoEngine.Common.Preserve]
	public GEIKECHKMEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6820000", Offset = "0x681E800", VA = "0x186820000", Slot = "8")]
	public GHJKEMFHLHG BDCEDMLOOPD(string PIIANNGIBHG, string KBBPLGIMMNH, [Optional] IJOMLLKMIAF GABJJBPMBKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x68203C0", Offset = "0x681EBC0", VA = "0x1868203C0", Slot = "10")]
	public GHJKEMFHLHG INDILAOFCBF(IJOMLLKMIAF GABJJBPMBKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6820140", Offset = "0x681E940", VA = "0x186820140", Slot = "11")]
	public GHJKEMFHLHG EKHFONLPHEO(IJOMLLKMIAF GABJJBPMBKD, Dictionary<string, string> KBIOJNPAPNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x7EE870", Offset = "0x7ED070", VA = "0x1807EE870", Slot = "12")]
	public bool BCKKIHBAPAL(string CLBMAHPAKHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x681FFF0", Offset = "0x681E7F0", VA = "0x18681FFF0", Slot = "13")]
	public PFEDGCBPALD ANFJCCLBPLK(string BCHFINPGIPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6820500", Offset = "0x681ED00", VA = "0x186820500", Slot = "14")]
	public MIHOPLLDJBG NFNPCAIPNOD(string EGFAMFAGJBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6820320", Offset = "0x681EB20", VA = "0x186820320", Slot = "15")]
	public GHJKEMFHLHG IDKCBNGHHNB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface IJOMLLKMIAF
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	bool MJPOJJBCEPL
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	bool NFBAMMEHONI
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	bool NEOBLDGDAGG
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	bool? PBEGJANFEIN
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	int? JDDFJDFIHBD
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	int BCODMPBEIAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	string JJCKDNBPODJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	string CBBODNJIDNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	string BCJDMKMFGEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	string COPGHGKNPGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	string JBIPLLONBNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	string MANGAKBEFIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	double MCJFBGJPMMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface LOLAADIIBLL
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	long KFKKEODKBCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "1")]
	long OHJIANEOILP();

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NMCNOMMMBOA(long HMJKNDANMKK, bool IABNOMFHPFI = true);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JOCJEEHHKAI(string HNBDDLBIIOF, string GEPFCICAEJF, string GICPIAMINAA);

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MCDADKLCKGH(string HNBDDLBIIOF);

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LCDAGBBCEFL(string HNBDDLBIIOF, string INNECPGAPEN, string GGPDFODIJNA);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FKBPGCGMLMI(string NBKOLIOINOJ, object MDLBEFJCFPD, object FOIDJBDEFLC);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface JABCJBCINGJ
{
	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LACNGBKOEFA LHKIGILJBNA(string MOBAHLPOJFO);
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

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
		[Cpp2IlInjected.Address(RVA = "0x86EBE0", Offset = "0x86DBE0", VA = "0x18086EBE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6BF6750", Offset = "0x6BF5750", VA = "0x186BF6750")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA3FB40", Offset = "0xA3EB40", VA = "0x180A3FB40")]
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
		[Cpp2IlInjected.Address(RVA = "0xCF9C40", Offset = "0xCF8C40", VA = "0x180CF9C40")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class LFHJKDKKNIP
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public const string PBJFIBJADJG = "batch";

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public const string BLBGAPAKKPB = "type";

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public const string IHGMJODGMKA = "identify";

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public const string DPLBIAADJOB = "track";

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public const string MFPKDBBOGPO = "userId";

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public const string BAPOCCFFNJH = "anonymousId";

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public const string CGGNBEFIIDA = "stable_id";

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public const string KDLIDPAIJHB = "messageId";

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public const string OMEMPLJLCPF = "event";

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public const string BNGEOJKCEBA = "version";

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public const string LFLJMBJIOHL = "locale";

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public const string COHCHIBCFNJ = "name";

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public const string BPJJHAKKOBL = "properties";

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public const string GAHNAILDDMN = "traits";

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public const string AMADCNFELEH = "context";

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public const string HNMMFKCGLCA = "app";

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public const string LGGGCJIHKOF = "os";

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public const string HKBOIIBGCGJ = "device";

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public const string MKGCOECDKMN = "originalTimestamp";

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public const string AFMBIAOIBPG = "brand";

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public const string NEEMMJGOJJB = "manufacturer";

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public const string HCDPFIBBJJP = "model";

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public const string NPCOIEKCIED = "type";

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	public LFHJKDKKNIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class FBCOHACLAON
{
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public const int GPFCOCJLKBJ = 2;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public const int PMDNJCOGFBP = 100;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public const int LBMNEDNBABA = 1000;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public const long JHEGANLHMGO = 1800000L;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public const int OOHLBPOMBPC = 1024;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public const int KDGJJPJBHCH = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public const string NODDKELFFAM = "amplitude_sequence_number";

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public const string IEDNMEDKBCK = "amplitude_user_id";

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public const string EHPFPJJMODH = "amplitude_last_time";

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public const string LPJOJHCLEKL = "initialize_analytics";

	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public const string JELMEFCODMO = "session_start";

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public const string JGEIBKPJLAN = "session_end";

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public const string IPMPEONFBPP = "insert_id";

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public const string DLKJDKICBPA = "event_time";

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public const string HCPFPKJNHGI = "session_id";

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public const string NADAEPIMDGC = "session_tracking_data";

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public const string KFEHHDHGPPC = "user_properties";

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public const string KGGEFIJHJDI = "app_version";

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public const string KNPMIILDCNP = "ip";

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public const string LFMLMPOKBPF = "language";

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public const string CGGNBEFIIDA = "stable_id";

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public const string OOLHJALPMMP = "client_launcher";

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public const string PKHKFFPLLEN = "platform";

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public const string FIDPGPBNDAJ = "os_name";

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public const string HENDOKHHFME = "os_version";

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public const string JPNMMDCNLOB = "device_brand";

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public const string JLDHFKOIMAG = "device_manufacturer";

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public const string BCFEAIELIHN = "device_model";

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public const string HJMEIHOOOIJ = "device_type";

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public const string EAGHOLPAGPP = "price";

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public const string CDMBBIDPKPF = "quantity";

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public const string EAPLIDKCCFC = "revenue";

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public const string POHKKJCCOCP = "productId";

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public const string OHEEGHBMNDL = "revenueType";

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public const string KJPHELDODHD = "event_type";

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public const string MFPKDBBOGPO = "user_id";

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public const string CHDLKICMCML = "event_properties";

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public const int GCPLGHNFCFA = 10;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> NOMIGPKFPBO;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6BF2100", Offset = "0x6BF1100", VA = "0x186BF2100")]
	internal static bool JINHNFAPJIH(string LOHIKDGDMPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	public FBCOHACLAON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface PAPFCOOKAOD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool EOJAGAHKOJO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string NMEMJJFLLEC
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	string LKMDJBJBLML
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	string INBLNKGHILL
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	string ACFFGEFFAFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IBHBGBJGJHP<HNCKNOBPHDH> MCPKEOMMCGE(string PMHLGIBAFNH, Dictionary<string, string> NJAELMDAEDM, bool NPFHCKFJKAG = false);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "6")]
	IBHBGBJGJHP<HNCKNOBPHDH> KFAGNHBBPCM(string PMHLGIBAFNH, string COEFMFPFIDN, string KIFLEDJAONF, string LNJDEFDFIJJ);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct HNCKNOBPHDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly int KLFPHLDKLKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly string CMBEEPJFAHB;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0xFDAA40", Offset = "0xFD9A40", VA = "0x180FDAA40")]
	public HNCKNOBPHDH(int IGDMHLDDIBD, string MIJIFCGFOJO)
	{
	}
}
namespace AmplitudeAnalytics
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class AGAmplitudeAnalyticsSettings : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[SerializeField]
		private AmplitudeAnalyticsClient.Settings editorSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		private bool forceEditorSettingsForDevelopers;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public AmplitudeAnalyticsClient.Settings IPPLOJFLKCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x85E990", Offset = "0x85D990", VA = "0x18085E990")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool PHBEEALBJJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xCF9D10", Offset = "0xCF8D10", VA = "0x180CF9D10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x85F0C0", Offset = "0x85E0C0", VA = "0x18085F0C0")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class AmplitudeAnalyticsEvent : AmplitudeAnalyticsIdentifyMessage
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly string uuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly string eventType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly long sequenceNumber;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal Dictionary<string, object> eventProperties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private string language;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private long time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private long sessionId;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static string SessionTrackingData
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6BF0470", Offset = "0x6BEF470", VA = "0x186BF0470")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6BF0540", Offset = "0x6BEF540", VA = "0x186BF0540")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static string StableId
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6BF04B0", Offset = "0x6BEF4B0", VA = "0x186BF04B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6BF0590", Offset = "0x6BEF590", VA = "0x186BF0590")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static string ClientLauncher
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6BF0430", Offset = "0x6BEF430", VA = "0x186BF0430")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6BF04F0", Offset = "0x6BEF4F0", VA = "0x186BF04F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x992280", Offset = "0x991280", VA = "0x180992280")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6BEFD00", Offset = "0x6BEED00", VA = "0x186BEFD00")]
		public static FIPJKKHCLOC HFOCJEBDOBL(string ELKCHAMAHHH, [NotNull] string NEILJLJDFKL, long MFKLMHEIHNH, long LFIKEAJGGFB, string OAFEHDIJMMB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6BEFDF0", Offset = "0x6BEEDF0", VA = "0x186BEFDF0")]
		public static FIPJKKHCLOC HOPNBBBKOHC(string ELKCHAMAHHH, [NotNull] string NEILJLJDFKL, long MFKLMHEIHNH, long LFIKEAJGGFB, string OAFEHDIJMMB, long HJPHACBIEBL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6BF0250", Offset = "0x6BEF250", VA = "0x186BF0250")]
		private AmplitudeAnalyticsEvent(string ELKCHAMAHHH, [NotNull] string NEILJLJDFKL, long MFKLMHEIHNH, long LFIKEAJGGFB, string OAFEHDIJMMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1D42AC0", Offset = "0x1D41AC0", VA = "0x181D42AC0")]
		public void NEPNJINOCKJ(long KAGEFGKFODN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6BF0160", Offset = "0x6BEF160", VA = "0x186BF0160", Slot = "5")]
		public override void PLKFLAHCKMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6BEFEF0", Offset = "0x6BEEEF0", VA = "0x186BEFEF0", Slot = "6")]
		public override void IGJFKDOKKLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6BEF8C0", Offset = "0x6BEE8C0", VA = "0x186BEF8C0", Slot = "4")]
		protected override Dictionary<string, object> FCBEDHKLNDK(Dictionary<string, object> OAAONFILEBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6BF0050", Offset = "0x6BEF050", VA = "0x186BF0050")]
		private void KMCBKNLCCHL(string LOHIKDGDMPP, string CKDFGEALFAK, bool GOPBGOJFDOE = false)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class IDFFPJHHIPD : KKNLKEOMCKA<AmplitudeAnalyticsIdentifyMessage, IDFFPJHHIPD>
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override IDFFPJHHIPD BHDENHFAGMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1131E90", Offset = "0x1130E90", VA = "0x181131E90", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x90AAB0", Offset = "0x909AB0", VA = "0x18090AAB0", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage EJOKIDBHGOL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6BF4860", Offset = "0x6BF3860", VA = "0x186BF4860")]
	public IDFFPJHHIPD(AmplitudeAnalyticsIdentifyMessage HJJLMCEMDKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6BF47F0", Offset = "0x6BF37F0", VA = "0x186BF47F0", Slot = "4")]
	public override void IGJFKDOKKLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class FIPJKKHCLOC : KKNLKEOMCKA<AmplitudeAnalyticsEvent, FIPJKKHCLOC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private bool EDGPKBDDOED;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override FIPJKKHCLOC BHDENHFAGMC
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x1131E90", Offset = "0x1130E90", VA = "0x181131E90", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public long NKHACFAACBN
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6BF22B0", Offset = "0x6BF12B0", VA = "0x186BF22B0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6BF2960", Offset = "0x6BF1960", VA = "0x186BF2960")]
	public FIPJKKHCLOC(AmplitudeAnalyticsEvent HJJLMCEMDKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x90AAB0", Offset = "0x909AB0", VA = "0x18090AAB0", Slot = "5")]
	public override AmplitudeAnalyticsEvent EJOKIDBHGOL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6BF24A0", Offset = "0x6BF14A0", VA = "0x186BF24A0", Slot = "4")]
	public override void IGJFKDOKKLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6BF26F0", Offset = "0x6BF16F0", VA = "0x186BF26F0")]
	public FIPJKKHCLOC KHLKIAPGJKM(string LDJJMGJLECK, long[] CKDFGEALFAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6BF2540", Offset = "0x6BF1540", VA = "0x186BF2540")]
	public FIPJKKHCLOC KHLKIAPGJKM(string LDJJMGJLECK, ulong[] CKDFGEALFAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x1B6FC20", Offset = "0x1B6EC20", VA = "0x181B6FC20")]
	public FIPJKKHCLOC KHLKIAPGJKM<T>(string LDJJMGJLECK, T[] CKDFGEALFAK) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6BF2830", Offset = "0x6BF1830", VA = "0x186BF2830")]
	public FIPJKKHCLOC KHLKIAPGJKM(string LDJJMGJLECK, string[] CKDFGEALFAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1B6FBB0", Offset = "0x1B6EBB0", VA = "0x181B6FBB0")]
	public FIPJKKHCLOC KHLKIAPGJKM<T>(string LDJJMGJLECK, T CKDFGEALFAK) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6BF2840", Offset = "0x6BF1840", VA = "0x186BF2840")]
	public FIPJKKHCLOC KHLKIAPGJKM(string LDJJMGJLECK, long CKDFGEALFAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6BF28D0", Offset = "0x6BF18D0", VA = "0x186BF28D0")]
	public FIPJKKHCLOC KHLKIAPGJKM(string LDJJMGJLECK, ulong CKDFGEALFAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6BF2680", Offset = "0x6BF1680", VA = "0x186BF2680")]
	public FIPJKKHCLOC KHLKIAPGJKM(string LDJJMGJLECK, string CKDFGEALFAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6BF22D0", Offset = "0x6BF12D0", VA = "0x186BF22D0")]
	public FIPJKKHCLOC DNPGNOFJGLF(string LDJJMGJLECK, object? CKDFGEALFAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6BF2300", Offset = "0x6BF1300", VA = "0x186BF2300")]
	public FIPJKKHCLOC HDFBJKDEBCN(string LDJJMGJLECK, string CKDFGEALFAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6BF23A0", Offset = "0x6BF13A0", VA = "0x186BF23A0")]
	private FIPJKKHCLOC HOJBFGIDCJL(string LDJJMGJLECK, object CKDFGEALFAK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class IABFBMOJBAB : FIPJKKHCLOC
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6BF2960", Offset = "0x6BF1960", VA = "0x186BF2960")]
	public IABFBMOJBAB(AmplitudeAnalyticsEvent HJJLMCEMDKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6BF4660", Offset = "0x6BF3660", VA = "0x186BF4660", Slot = "4")]
	public override void IGJFKDOKKLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class KKNLKEOMCKA<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : KKNLKEOMCKA<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	protected M HJJLMCEMDKN;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public abstract BLDR BHDENHFAGMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0xBFE350", Offset = "0xBFD350", VA = "0x180BFE350")]
	public KKNLKEOMCKA(M HJJLMCEMDKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x30DA1E0", Offset = "0x30D91E0", VA = "0x1830DA1E0")]
	public BLDR NNHODMILFNJ(AmplitudeAnalyticsIdentifyMessage.DeviceInfo FPJADAFAMKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x30DA1A0", Offset = "0x30D91A0", VA = "0x1830DA1A0")]
	public BLDR NDMNKIPKDOE(AmplitudeAnalyticsIdentifyMessage.RevenueData FPBEPLLINGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x30D9FD0", Offset = "0x30D8FD0", VA = "0x1830D9FD0")]
	public BLDR HEJGBEPCNAF(string LDJJMGJLECK, string CKDFGEALFAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x22A6E10", Offset = "0x22A5E10", VA = "0x1822A6E10")]
	public BLDR HEJGBEPCNAF<T>(string LDJJMGJLECK, T CKDFGEALFAK) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x30DA0F0", Offset = "0x30D90F0", VA = "0x1830DA0F0")]
	public BLDR HEJGBEPCNAF(string LDJJMGJLECK, long CKDFGEALFAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x30DA040", Offset = "0x30D9040", VA = "0x1830DA040")]
	public BLDR HEJGBEPCNAF(string LDJJMGJLECK, ulong CKDFGEALFAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void IGJFKDOKKLP();

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x30D9FA0", Offset = "0x30D8FA0", VA = "0x1830D9FA0")]
	internal static string DLCNBHNDIFK(string CKDFGEALFAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x30D9EA0", Offset = "0x30D8EA0", VA = "0x1830D9EA0")]
	private BLDR APOOENFEBNC(string LDJJMGJLECK, object CKDFGEALFAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M EJOKIDBHGOL();
}
namespace AmplitudeAnalytics
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class AmplitudeAnalyticsIdentifyMessage
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public class DeviceInfo
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public string platform;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public string osName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public string osVersion;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public string deviceBrand;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public string deviceManufacturer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public string deviceModel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public string deviceType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public string carrier;

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x6BF1F80", Offset = "0x6BF0F80", VA = "0x186BF1F80")]
			public void HBPODMPHIOI(Dictionary<string, object> NFGMCLGGLOI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
			public DeviceInfo()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public class RevenueData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public float price;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public int quantity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public float revenue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public string productId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public string revenueType;

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6BF6A10", Offset = "0x6BF5A10", VA = "0x186BF6A10")]
			public void HBPODMPHIOI(Dictionary<string, object> OAMKBOLGHOJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6BF6B80", Offset = "0x6BF5B80", VA = "0x186BF6B80")]
			public RevenueData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		internal DeviceInfo deviceInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		internal RevenueData revenueData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private readonly string buildVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private readonly string language;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		internal Dictionary<string, object> userProperties;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		protected string UserId
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x85E070", Offset = "0x85D070", VA = "0x18085E070")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x9132F0", Offset = "0x9122F0", VA = "0x1809132F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6BF0920", Offset = "0x6BEF920", VA = "0x186BF0920")]
		public static IDFFPJHHIPD HFOCJEBDOBL(string ELKCHAMAHHH, string OAFEHDIJMMB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6BF0C20", Offset = "0x6BEFC20", VA = "0x186BF0C20")]
		protected AmplitudeAnalyticsIdentifyMessage(string ELKCHAMAHHH, string OAFEHDIJMMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6BF0A90", Offset = "0x6BEFA90", VA = "0x186BF0A90")]
		public Dictionary<string, object> OODMEHOGIKN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6BF05E0", Offset = "0x6BEF5E0", VA = "0x186BF05E0", Slot = "4")]
		protected virtual Dictionary<string, object> FCBEDHKLNDK(Dictionary<string, object> OAAONFILEBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6BF0B10", Offset = "0x6BEFB10", VA = "0x186BF0B10")]
		protected void PCBEBFFFNIM(string LOHIKDGDMPP, Dictionary<string, object> GIADONJHFMP, Dictionary<string, object> MAIEGMFAPHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6BF0A20", Offset = "0x6BEFA20", VA = "0x186BF0A20")]
		protected void IKJBAMFHJPK(string LOHIKDGDMPP, string CKDFGEALFAK, Dictionary<string, object> PCAAFKBKPCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6BF0BC0", Offset = "0x6BEFBC0", VA = "0x186BF0BC0", Slot = "5")]
		public virtual void PLKFLAHCKMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6BF09D0", Offset = "0x6BEF9D0", VA = "0x186BF09D0", Slot = "6")]
		public virtual void IGJFKDOKKLP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		private enum LPELHLJMKMC
		{
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		internal class HKNGEKELFMD
		{
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			private class NCDPKOFIPDM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000A1")]
				public int DBCHAGAOJPO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000A2")]
				public Dictionary<string, object> GAJNMCMNDMK;

				[Cpp2IlInjected.Token(Token = "0x60000A0")]
				[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
				public NCDPKOFIPDM()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000017")]
			[CompilerGenerated]
			private sealed class PIGMCAALKOH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000A3")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x60000A1")]
				[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
				public PIGMCAALKOH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000A2")]
				[Cpp2IlInjected.Address(RVA = "0x6BF69B0", Offset = "0x6BF59B0", VA = "0x186BF69B0")]
				internal bool KHMPJPJPPEG(NCDPKOFIPDM item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400009E")]
			private const string MHJMBGGJCAC = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			private readonly string CDLBCMHHGDO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			private List<NCDPKOFIPDM> JMLNLGHLJEK;

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public int? IBNDMPAALMH
			{
				[Cpp2IlInjected.Token(Token = "0x6000094")]
				[Cpp2IlInjected.Address(RVA = "0x6BF3FE0", Offset = "0x6BF2FE0", VA = "0x186BF3FE0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public int? MDEDMLDJDCH
			{
				[Cpp2IlInjected.Token(Token = "0x6000095")]
				[Cpp2IlInjected.Address(RVA = "0x6BF3350", Offset = "0x6BF2350", VA = "0x186BF3350")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x6BF44D0", Offset = "0x6BF34D0", VA = "0x186BF44D0")]
			internal HKNGEKELFMD(string JDGCFGDHIBE, string DNCMAFMMDDP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x6BF3410", Offset = "0x6BF2410", VA = "0x186BF3410")]
			public int GEFDOLOBDPM([Optional] int? PLNIHIPGKCO)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x6BF3AD0", Offset = "0x6BF2AD0", VA = "0x186BF3AD0")]
			public List<Dictionary<string, object>> MNINNLNENGL(int GLDGIGJDGEG, int? PLNIHIPGKCO)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x6BF36A0", Offset = "0x6BF26A0", VA = "0x186BF36A0")]
			public void GLKIIHDAHOM(AmplitudeAnalyticsIdentifyMessage EOHGDDIECBJ, bool KMMIPBHBLKL = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x6BF3590", Offset = "0x6BF2590", VA = "0x186BF3590")]
			public void GLKIIHDAHOM(Dictionary<string, object> EOHGDDIECBJ, bool KMMIPBHBLKL = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x6BF3090", Offset = "0x6BF2090", VA = "0x186BF3090")]
			public void ACMAIMAMDKM(params Dictionary<string, object>[] JNIILDFDKFE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x6BF3740", Offset = "0x6BF2740", VA = "0x186BF3740")]
			public void KEKKANNNHEK(List<Dictionary<string, object>> NIPLNKDANMP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x6BF3990", Offset = "0x6BF2990", VA = "0x186BF3990")]
			private void MKGFPGGDPOP(Dictionary<string, object> EOHGDDIECBJ, bool KMMIPBHBLKL = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x6BF3D70", Offset = "0x6BF2D70", VA = "0x186BF3D70")]
			public void OCDOCGFDMPJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x6BF4080", Offset = "0x6BF3080", VA = "0x186BF4080")]
			private void PMHDJOGFEPF([Optional] string AKBKIBJBAHE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x6BF3220", Offset = "0x6BF2220", VA = "0x186BF3220")]
			private static string EOPINMOMBMM(string CKDFGEALFAK, string LOHIKDGDMPP)
			{
				return null;
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public class Settings
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public float BatchIntervalSeconds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public bool verboseLogging;

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x6BF6DE0", Offset = "0x6BF5DE0", VA = "0x186BF6DE0")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public struct MFEMHCFNOIP<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public int IGDMHLDDIBD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			public string MIJIFCGFOJO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public T GNIPKLHGABI;
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class GIHGOIDGEFM : IEnumerator<OJAHJFHMFIA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			private OJAHJFHMFIA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			private List<AmplitudeAnalyticsIdentifyMessage>.Enumerator <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			private AmplitudeAnalyticsIdentifyMessage <queuedEvent>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			private OJAHJFHMFIA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000AC")]
				[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000AE")]
				[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xA80FD0", Offset = "0xA7FFD0", VA = "0x180A80FD0")]
			[DebuggerHidden]
			public GIHGOIDGEFM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x6BF29B0", Offset = "0x6BF19B0", VA = "0x186BF29B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x6BF3050", Offset = "0x6BF2050", VA = "0x186BF3050", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class DPIKOHOHCMN : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public NHFPGJIFDOB quitCompletePromise;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			private float <timeout>5__1;

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000B2")]
				[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000B4")]
				[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xA80FD0", Offset = "0xA7FFD0", VA = "0x180A80FD0")]
			[DebuggerHidden]
			public DPIKOHOHCMN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x6BF1E20", Offset = "0x6BF0E20", VA = "0x186BF1E20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x6BF1F40", Offset = "0x6BF0F40", VA = "0x186BF1F40", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class PCKCFGOLHAI : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public float timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000B8")]
				[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000BA")]
				[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xA80FD0", Offset = "0xA7FFD0", VA = "0x180A80FD0")]
			[DebuggerHidden]
			public PCKCFGOLHAI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x6BF67E0", Offset = "0x6BF57E0", VA = "0x186BF67E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x6BF6970", Offset = "0x6BF5970", VA = "0x186BF6970", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class BLNHHJOEBOM : IEnumerator<OJAHJFHMFIA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private OJAHJFHMFIA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public float timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			private bool <shouldSendBatch>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			private HKNGEKELFMD <cache>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private string <url>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			private Action<int> <eventBatchSent>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			private int? <earlierThanFrame>5__5;

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			private OJAHJFHMFIA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000BE")]
				[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000C0")]
				[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0xA80FD0", Offset = "0xA7FFD0", VA = "0x180A80FD0")]
			[DebuggerHidden]
			public BLNHHJOEBOM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x6BF1A70", Offset = "0x6BF0A70", VA = "0x186BF1A70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x6BF1DE0", Offset = "0x6BF0DE0", VA = "0x186BF1DE0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class KHCGBIINNBO : IEnumerator<OJAHJFHMFIA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			private OJAHJFHMFIA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public float timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			private HKNGEKELFMD <cache>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			private string <url>5__2;

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			private OJAHJFHMFIA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000C7")]
				[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000C9")]
				[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xA80FD0", Offset = "0xA7FFD0", VA = "0x180A80FD0")]
			[DebuggerHidden]
			public KHCGBIINNBO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x6BF5730", Offset = "0x6BF4730", VA = "0x186BF5730", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x6BF5A20", Offset = "0x6BF4A20", VA = "0x186BF5A20", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[CompilerGenerated]
		private sealed class BHLBFGGKLOM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public List<Dictionary<string, object>> batch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public HKNGEKELFMD cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
			public BHLBFGGKLOM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x6BF1260", Offset = "0x6BF0260", VA = "0x186BF1260")]
			internal void EIMHLKMBJJI(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x6BF15D0", Offset = "0x6BF05D0", VA = "0x186BF15D0")]
			internal void PPFEFPNEKMN(MFEMHCFNOIP<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class JKMGCJEGFBD : IEnumerator<OJAHJFHMFIA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			private OJAHJFHMFIA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public HKNGEKELFMD cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public int? earlierThanFrame;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public string url;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			public string dataIdentifier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public float timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			private BHLBFGGKLOM <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			private string <apiKey>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			private float <startTime>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			private bool <timedOut>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			private int <batchSize>5__5;

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			private OJAHJFHMFIA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000D0")]
				[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000D2")]
				[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0xA80FD0", Offset = "0xA7FFD0", VA = "0x180A80FD0")]
			[DebuggerHidden]
			public JKMGCJEGFBD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x6BF4DD0", Offset = "0x6BF3DD0", VA = "0x186BF4DD0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x6BF56F0", Offset = "0x6BF46F0", VA = "0x186BF56F0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private sealed class BJLCLFCHMHL<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0xBDEB80", Offset = "0xBDDB80", VA = "0x180BDEB80")]
			public BJLCLFCHMHL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x23B8F40", Offset = "0x23B7F40", VA = "0x1823B8F40")]
			internal MFEMHCFNOIP<T> DBNAOAJBPDD(HNCKNOBPHDH postResponse)
			{
				return default(MFEMHCFNOIP<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class NONNGLLLAFF<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0xBDEB80", Offset = "0xBDDB80", VA = "0x180BDEB80")]
			public NONNGLLLAFF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x23B8F40", Offset = "0x23B7F40", VA = "0x1823B8F40")]
			internal MFEMHCFNOIP<T> PFEEAFDHMII(HNCKNOBPHDH postResponse)
			{
				return default(MFEMHCFNOIP<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private PCCHDNKCHLM MMJPIIMLLHL;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private const string BLODHHMBEHP = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private const string FNMCLJDOFFH = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private const string DCJHBBJPNHC = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private const int OKPLMCBLLIE = 15;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private const int EEHCDLAKPGG = 10;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private const int KLDACOOEMEC = 5;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private const float EBFGLCHPPDJ = 10f;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private const long EKNNHONELFO = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private const string FOMBPKCJHLE = "f1779b982f1c09aed3adb3cca563cbc2";

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private const string HCLKCCILALE = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static bool JNBPKMBNJCM;

		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private static bool CKLLOIHIMCK;

		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private static int KOOKNCIEPMM;

		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private static int DICJANNNOMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private PAPFCOOKAOD AOMOJJCFKAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private bool CKCBKOGEDJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private float DGMEJDDFKHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private float JEJMJDDCLLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int GEJIKFGNDLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int DAIPBLOHMOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private int? IIPEOOIBMFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int? EGJOPEMGEMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private long FIBOBABFMJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private string OJLGCNKMLFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private long MHKIKGPDDPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private Dictionary<string, object> BFHIHAAKACN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private LPELHLJMKMC HDHKHDHJACA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private int FNPJHMEBDJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private int FGIGNNEEICG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private float PBBNNCNGCHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private bool EPBADGPJMHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x89")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private bool NNJHDFCKKFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private HKNGEKELFMD ALIECOOCAHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private HKNGEKELFMD OLEALCKOLDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private HKNGEKELFMD HHCMHHIOPHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> IFMPPCMBOHI;

		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo LCMBCOOOLOB;

		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private static string JFKNDKILLEK;

		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private const string MIAEBHKEPHA = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly string PMBJLDBOFCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly string LMPNDNGPFAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly string OFDNECENHCI;

		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private PCCHDNKCHLM OFLJMAKDBKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6BEC170", Offset = "0x6BEB170", VA = "0x186BEC170")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private static int LHHLKNNFJEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6BEB280", Offset = "0x6BEA280", VA = "0x186BEB280")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static long PHBHMKDJFMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x6BEF760", Offset = "0x6BEE760", VA = "0x186BEF760")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x6BEF860", Offset = "0x6BEE860", VA = "0x186BEF860")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static string GEOEGAFIBLL
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x6BEF700", Offset = "0x6BEE700", VA = "0x186BEF700")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static string HMDFFBJNPMG
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x6BEF730", Offset = "0x6BEE730", VA = "0x186BEF730")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public string FAOCCIACNGC
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xBC7CF0", Offset = "0xBC6CF0", VA = "0x180BC7CF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xBC7EA0", Offset = "0xBC6EA0", VA = "0x180BC7EA0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public int? OJOOGNLKJHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x11EC0D0", Offset = "0x11EB0D0", VA = "0x1811EC0D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x301DE00", Offset = "0x301CE00", VA = "0x18301DE00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool ECIMFDIIIOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x14F44A0", Offset = "0x14F34A0", VA = "0x1814F44A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x14F26F0", Offset = "0x14F16F0", VA = "0x1814F26F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public static bool KAPMFLBOCHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x6BEF670", Offset = "0x6BEE670", VA = "0x186BEF670")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> AKFHBDDNHFG
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x6BEF5D0", Offset = "0x6BEE5D0", VA = "0x186BEF5D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x6BEF7C0", Offset = "0x6BEE7C0", VA = "0x186BEF7C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6BEACF0", Offset = "0x6BE9CF0", VA = "0x186BEACF0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6BEC780", Offset = "0x6BEB780", VA = "0x186BEC780")]
		private void LDLNGHOGONM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6BEEE40", Offset = "0x6BEDE40", VA = "0x186BEEE40")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6BEE500", Offset = "0x6BED500", VA = "0x186BEE500", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6BEF120", Offset = "0x6BEE120", VA = "0x186BEF120")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6BEE5F0", Offset = "0x6BED5F0", VA = "0x186BEE5F0")]
		public GAEMIFNLIHB PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6BEC660", Offset = "0x6BEB660", VA = "0x186BEC660")]
		[IteratorStateMachine(typeof(GIHGOIDGEFM))]
		public IEnumerator<OJAHJFHMFIA> Initialize(AmplitudeAnalyticsEvent GJBGJGOCCEK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6BEF020", Offset = "0x6BEE020", VA = "0x186BEF020")]
		public void UpdateLastAliveTime(float ICKIFAGNODH = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6BEBE70", Offset = "0x6BEAE70", VA = "0x186BEBE70")]
		private GAEMIFNLIHB FOCGIINAMDE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6BEBA40", Offset = "0x6BEAA40", VA = "0x186BEBA40")]
		private GAEMIFNLIHB EEFNGNNMPDE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6BEEA40", Offset = "0x6BEDA40", VA = "0x186BEEA40")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6BEC6F0", Offset = "0x6BEB6F0", VA = "0x186BEC6F0")]
		[IteratorStateMachine(typeof(DPIKOHOHCMN))]
		private IEnumerator JPGNGPNBHAB(NHFPGJIFDOB NCNPDMABECD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6BEF3A0", Offset = "0x6BEE3A0", VA = "0x186BEF3A0")]
		[IteratorStateMachine(typeof(PCKCFGOLHAI))]
		public IEnumerator WaitForFlush(float MLIKJMAKNBL = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6BEEF00", Offset = "0x6BEDF00", VA = "0x186BEEF00")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6BEEE50", Offset = "0x6BEDE50", VA = "0x186BEEE50")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime AILHHDAIAFL)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6BEC340", Offset = "0x6BEB340", VA = "0x186BEC340")]
		public static IDFFPJHHIPD Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6BEABB0", Offset = "0x6BE9BB0", VA = "0x186BEABB0")]
		public static FIPJKKHCLOC AccountSelectionPostLoginEvent([NotNull] string CHABNHFABIF, string OAFEHDIJMMB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6BEBCF0", Offset = "0x6BEACF0", VA = "0x186BEBCF0")]
		public static FIPJKKHCLOC Event([NotNull] string CHABNHFABIF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6BEE650", Offset = "0x6BED650", VA = "0x186BEE650")]
		public static FIPJKKHCLOC PreviousSessionEvent([NotNull] string CHABNHFABIF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6BEC470", Offset = "0x6BEB470", VA = "0x186BEC470")]
		public static FIPJKKHCLOC InitializeEvent(string OAFEHDIJMMB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6BEEBB0", Offset = "0x6BEDBB0", VA = "0x186BEEBB0")]
		public static FIPJKKHCLOC StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6BEB4E0", Offset = "0x6BEA4E0", VA = "0x186BEB4E0")]
		public static FIPJKKHCLOC CreateOutOfSessionEvent(string CHABNHFABIF, bool HHAGGANHFGI = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6BECE20", Offset = "0x6BEBE20", VA = "0x186BECE20")]
		public static GAEMIFNLIHB LogOutOfSessionEvent(FIPJKKHCLOC LGBFNJPCPOM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6BECB80", Offset = "0x6BEBB80", VA = "0x186BECB80")]
		public void LogEventAsync(AmplitudeAnalyticsEvent FLNAGJIAMLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6BED110", Offset = "0x6BEC110", VA = "0x186BED110")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent FLNAGJIAMLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6BED260", Offset = "0x6BEC260", VA = "0x186BED260")]
		public void LogSerializedEventAsync(Dictionary<string, object> BDEEEKKGMPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6BECCD0", Offset = "0x6BEBCD0", VA = "0x186BECCD0")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage HKJKGFACCEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6BECA90", Offset = "0x6BEBA90", VA = "0x186BECA90")]
		private void LDMCLIDJKCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6BEAFE0", Offset = "0x6BE9FE0", VA = "0x186BEAFE0")]
		private void BBOFEOKLDHG(Dictionary<string, object> IEEMKMNHPKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6BEE410", Offset = "0x6BED410", VA = "0x186BEE410")]
		private void OHMIMKMFJJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6BEB780", Offset = "0x6BEA780", VA = "0x186BEB780")]
		private void DKCCOMJMKII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6BEBF40", Offset = "0x6BEAF40", VA = "0x186BEBF40")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6BEB460", Offset = "0x6BEA460", VA = "0x186BEB460")]
		[IteratorStateMachine(typeof(BLNHHJOEBOM))]
		private IEnumerator<OJAHJFHMFIA> CIEKFPHHLIG(float MLIKJMAKNBL = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6BEBFD0", Offset = "0x6BEAFD0", VA = "0x186BEBFD0")]
		[IteratorStateMachine(typeof(KHCGBIINNBO))]
		private IEnumerator<OJAHJFHMFIA> HBKJPHBFBFM(float MLIKJMAKNBL = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6BEB960", Offset = "0x6BEA960", VA = "0x186BEB960")]
		[IteratorStateMachine(typeof(JKMGCJEGFBD))]
		private IEnumerator<OJAHJFHMFIA> EDPNNGKIMEH(HKNGEKELFMD MJNADKLHKAE, int? PLNIHIPGKCO, string PMHLGIBAFNH, string LFENEPCIEDA, float MLIKJMAKNBL, Action<int> HAHIKOLEPDP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6BEC050", Offset = "0x6BEB050", VA = "0x186BEC050")]
		private static void HOGPKIDOADC(bool ACGCFEKDNBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6BED340", Offset = "0x6BEC340", VA = "0x186BED340")]
		private IBHBGBJGJHP<MFEMHCFNOIP<Dictionary<string, object>>> MCPKEOMMCGE(string PMHLGIBAFNH, string LFENEPCIEDA, string IBJIMNEKJHP, string MJFMBPAOCMD, Dictionary<string, object> GNIPKLHGABI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6BED470", Offset = "0x6BEC470", VA = "0x186BED470")]
		private IBHBGBJGJHP<MFEMHCFNOIP<List<Dictionary<string, object>>>> MCPKEOMMCGE(string PMHLGIBAFNH, string LFENEPCIEDA, string IBJIMNEKJHP, string MJFMBPAOCMD, List<Dictionary<string, object>> GNIPKLHGABI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x19C2920", Offset = "0x19C1920", VA = "0x1819C2920")]
		private IBHBGBJGJHP<MFEMHCFNOIP<T>> LPOHFCEBOIG<T>(string PMHLGIBAFNH, string LFENEPCIEDA, string MJFMBPAOCMD, T GNIPKLHGABI, Dictionary<string, object> GFMGANBNOLI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x19C2BB0", Offset = "0x19C1BB0", VA = "0x1819C2BB0")]
		private IBHBGBJGJHP<MFEMHCFNOIP<T>> NLGFHGJHJNI<T>(string PMHLGIBAFNH, string LFENEPCIEDA, string IBJIMNEKJHP, T GNIPKLHGABI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6BEE5A0", Offset = "0x6BED5A0", VA = "0x186BEE5A0")]
		private bool PCDJFCDGCIA(float ONMGEGGIKGD, float MLIKJMAKNBL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6BED740", Offset = "0x6BEC740", VA = "0x186BED740")]
		private Dictionary<string, object> NNMAMJEEIHO(string LFENEPCIEDA, Dictionary<string, object> GNIPKLHGABI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6BEF480", Offset = "0x6BEE480", VA = "0x186BEF480")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6BEC1E0", Offset = "0x6BEB1E0", VA = "0x186BEC1E0")]
		[CompilerGenerated]
		private long ILLGLOOOPPC()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6BEB450", Offset = "0x6BEA450", VA = "0x186BEB450")]
		[CompilerGenerated]
		private void CBHIDBCJOHL(int PGBLFIKPIIG)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class BCEIGJKGMBD
{
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private const string BAOFICPFJDO = "timed_flow";

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private const string ENCLGMEPOJC = "flowName";

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private const string BNPIJHGDMIO = "startedAt";

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private const string MNJPGAMJBAB = "endedAt";

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private const string PCCPKJEOEGP = "durationInSeconds";

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private const string EMNCEFIEEEF = "failure";

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private const string FLOABBCBJHG = "failureMessage";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private long ADAHPIDPLEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private FIPJKKHCLOC BHGGFLJDIGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private bool JHBFNCKBGOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private float PGMCAJOGKKO;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6BF10C0", Offset = "0x6BF00C0", VA = "0x186BF10C0")]
	public BCEIGJKGMBD(string BGJPMGEHLFD, float PGMCAJOGKKO = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x16AD010", Offset = "0x16AC010", VA = "0x1816AD010")]
	public void KHLKIAPGJKM<T>(string LDJJMGJLECK, T CKDFGEALFAK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6BF0F20", Offset = "0x6BEFF20", VA = "0x186BF0F20")]
	public void KHLKIAPGJKM(string LDJJMGJLECK, string CKDFGEALFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6BF0D20", Offset = "0x6BEFD20", VA = "0x186BF0D20")]
	public void CBAMAIJMOLF(string EAOOJBHCOFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6BF0E60", Offset = "0x6BEFE60", VA = "0x186BF0E60")]
	public void FFBHCCKOCPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6BF0FA0", Offset = "0x6BEFFA0", VA = "0x186BF0FA0")]
	private void PDKFPJDPFIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6BF0E10", Offset = "0x6BEFE10", VA = "0x186BF0E10")]
	private bool EICAFDDAFKD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public enum FMHJBCDAOOK
{
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	ChatPage,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	PlayerDetailsScreen,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	ActionCode,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	FriendImport,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	PlatformFriendInvite,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	PlatformNotification,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	WatchNotification,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	LegacyHomeScreen,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	NavigationBar,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	LegacyChatPage,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	MobileHomeChat,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	PlayerProfile,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	ShareContent,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	HUDHotbarShortcut
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class LEDBGBBIKDJ : OCBALFEOJPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private OCBALFEOJPM DEGLIGEAGMG;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private OCBALFEOJPM OGHMAKLGJOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6BF5CF0", Offset = "0x6BF4CF0", VA = "0x186BF5CF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool IHDFKNGPKBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6BF5BA0", Offset = "0x6BF4BA0", VA = "0x186BF5BA0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action BLPJNKIAFDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6BF5FB0", Offset = "0x6BF4FB0", VA = "0x186BF5FB0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6BF61E0", Offset = "0x6BF51E0", VA = "0x186BF61E0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action PIPLPAOLMGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x6BF5A60", Offset = "0x6BF4A60", VA = "0x186BF5A60", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6BF5D60", Offset = "0x6BF4D60", VA = "0x186BF5D60", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	[Preserve]
	public LEDBGBBIKDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6BF6660", Offset = "0x6BF5660", VA = "0x186BF6660")]
	[FBCFLFBFGIL(LAFFCBAHJKM.GameOnly)]
	private static void NEBGAHBEGJB(CNALHHIKJDD DBGHBAHCJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x6BF6380", Offset = "0x6BF5380", VA = "0x186BF6380", Slot = "8")]
	public GAEMIFNLIHB LLEBBJIFEDK(string POFKOEDNNNC, string DNCMAFMMDDP, [Optional] HCFKGBNNNKF KHNBHEBAGMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6BF5BF0", Offset = "0x6BF4BF0", VA = "0x186BF5BF0", Slot = "10")]
	public GAEMIFNLIHB DOLDAKDMBBM(HCFKGBNNNKF KHNBHEBAGMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x6BF5E00", Offset = "0x6BF4E00", VA = "0x186BF5E00", Slot = "11")]
	public GAEMIFNLIHB FLKMBDCIHOF(HCFKGBNNNKF KHNBHEBAGMG, Dictionary<string, string> NKNNBHPJBFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x6BF5B00", Offset = "0x6BF4B00", VA = "0x186BF5B00", Slot = "12")]
	public bool AOMKBMELCCO(string BKINOJFIHFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x6BF6140", Offset = "0x6BF5140", VA = "0x186BF6140", Slot = "13")]
	public GDDALNDKGMI JAGBOADOBEN(string BLCAJBAAAMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x6BF6280", Offset = "0x6BF5280", VA = "0x186BF6280", Slot = "14")]
	public JKGGELCPOLK JPAKHAPGAGH(string IKPDBGKAIKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x6BF5F10", Offset = "0x6BF4F10", VA = "0x186BF5F10", Slot = "15")]
	public GDDALNDKGMI GMPLMFMIGCD(string KLFEJBLOBMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x6BF6050", Offset = "0x6BF5050", VA = "0x186BF6050", Slot = "16")]
	public GAEMIFNLIHB HJBAICAPBMK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x96AF20", Offset = "0x969F20", VA = "0x18096AF20")]
	[CompilerGenerated]
	private void ICOEAGGEGOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x96B0F0", Offset = "0x96A0F0", VA = "0x18096B0F0")]
	[CompilerGenerated]
	private void APCKBMLCMKP()
	{
	}
}
namespace RecRoom.Analytics.Statsig
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class SerializedStatsigExperiment
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		[SerializeField]
		private string experimentName;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public string ExperimentName
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x85E070", Offset = "0x85D070", VA = "0x18085E070")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public SerializedStatsigExperiment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class ADADLMKMMEI : OCBALFEOJPM
{
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private const string GMJNICNMOJO = "GamePlatform";

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private const string ECMOLPCDGDL = "InteractionCategory";

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private const string MEIBNFLLFJO = "JrActType";

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private const string KFBDFMLHHBJ = "IsDeveloper";

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private const string EFGOPILBAOP = "IsModerator";

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private const string BHBIHIDHBCK = "IsMember";

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private const string FPOJHLFHCDL = "DaysSinceJoiningBucket";

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private const string BPEPGMFMNOJ = "AccountCreationTimeAfterEpochMilliseconds";

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private const string FLHGKBMCOBP = "InGoodStanding";

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private const string OJGELKFEGHO = "FriendCount";

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private const string DCEPLNDHCJH = "LocaleName";

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private static readonly IReadOnlyDictionary<string, AGONMLPCIIC> KAEJNFALGBK;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private const int AEHGPHOLPAA = 5000;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private bool EDLGKGHIMDO;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool IHDFKNGPKBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x9127F0", Offset = "0x9117F0", VA = "0x1809127F0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action BLPJNKIAFDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6BE98D0", Offset = "0x6BE88D0", VA = "0x186BE98D0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6BE9C20", Offset = "0x6BE8C20", VA = "0x186BE9C20", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action PIPLPAOLMGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6BE8E20", Offset = "0x6BE7E20", VA = "0x186BE8E20", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6BE9220", Offset = "0x6BE8220", VA = "0x186BE9220", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6BE9F20", Offset = "0x6BE8F20", VA = "0x186BE9F20", Slot = "8")]
	public GAEMIFNLIHB LLEBBJIFEDK(string POFKOEDNNNC, string DNCMAFMMDDP, [Optional] HCFKGBNNNKF KHNBHEBAGMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6BE9970", Offset = "0x6BE8970", VA = "0x186BE9970", Slot = "16")]
	public GAEMIFNLIHB HJBAICAPBMK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x6BE9000", Offset = "0x6BE8000", VA = "0x186BE9000", Slot = "10")]
	public GAEMIFNLIHB DOLDAKDMBBM(HCFKGBNNNKF KHNBHEBAGMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6BE94F0", Offset = "0x6BE84F0", VA = "0x186BE94F0", Slot = "11")]
	public GAEMIFNLIHB FLKMBDCIHOF(HCFKGBNNNKF KHNBHEBAGMG, Dictionary<string, string> NKNNBHPJBFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6BE8EC0", Offset = "0x6BE7EC0", VA = "0x186BE8EC0", Slot = "12")]
	public bool AOMKBMELCCO(string BKINOJFIHFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6BE9B00", Offset = "0x6BE8B00", VA = "0x186BE9B00", Slot = "13")]
	public GDDALNDKGMI JAGBOADOBEN(string BLCAJBAAAMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6BE9CC0", Offset = "0x6BE8CC0", VA = "0x186BE9CC0", Slot = "14")]
	public JKGGELCPOLK JPAKHAPGAGH(string IKPDBGKAIKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6BE97E0", Offset = "0x6BE87E0", VA = "0x186BE97E0", Slot = "15")]
	public GDDALNDKGMI GMPLMFMIGCD(string KLFEJBLOBMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6BEA3C0", Offset = "0x6BE93C0", VA = "0x186BEA3C0")]
	private IOJJKPJKOKD NFJDFNINGEN(HCFKGBNNNKF KHNBHEBAGMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6BE9D80", Offset = "0x6BE8D80", VA = "0x186BE9D80")]
	private CDOEKOKKKNH KKGOBGJANEA(string DNCMAFMMDDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6BE92C0", Offset = "0x6BE82C0", VA = "0x186BE92C0")]
	private void ELNELJANDBM(string BLCAJBAAAMA, GDDALNDKGMI LCFBHAKNLEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6BEAB80", Offset = "0x6BE9B80", VA = "0x186BEAB80")]
	public ADADLMKMMEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0xE73560", Offset = "0xE72560", VA = "0x180E73560")]
	[CompilerGenerated]
	private void PENOPGKINJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6BEA9C0", Offset = "0x6BE99C0", VA = "0x186BEA9C0")]
	[CompilerGenerated]
	private void NHHFMPMDKEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6BE8F70", Offset = "0x6BE7F70", VA = "0x186BE8F70")]
	[CompilerGenerated]
	private void BKJOBGLOAIC()
	{
	}
}
namespace RecRoom.Analytics.Statsig
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class SerializedStatsigExperimentSegment
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		[SerializeField]
		private string experimentName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		[SerializeField]
		private string parameterName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		[SerializeField]
		private string parameterValue;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public string ExperimentName
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x85E070", Offset = "0x85D070", VA = "0x18085E070")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x85E980", Offset = "0x85D980", VA = "0x18085E980")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x6BF6B90", Offset = "0x6BF5B90", VA = "0x186BF6B90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface OCBALFEOJPM
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	bool IHDFKNGPKBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action BLPJNKIAFDL;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action PIPLPAOLMGL;

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GAEMIFNLIHB LLEBBJIFEDK(string POFKOEDNNNC, string DNCMAFMMDDP, [Optional] HCFKGBNNNKF KHNBHEBAGMG);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GAEMIFNLIHB DOLDAKDMBBM(HCFKGBNNNKF KHNBHEBAGMG);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GAEMIFNLIHB FLKMBDCIHOF(HCFKGBNNNKF KHNBHEBAGMG, Dictionary<string, string> NKNNBHPJBFO);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool AOMKBMELCCO(string BKINOJFIHFN);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "9")]
	GDDALNDKGMI JAGBOADOBEN(string BLCAJBAAAMA);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "10")]
	JKGGELCPOLK JPAKHAPGAGH(string IKPDBGKAIKM);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "11")]
	GDDALNDKGMI GMPLMFMIGCD(string KLFEJBLOBMO);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "12")]
	GAEMIFNLIHB HJBAICAPBMK();
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class IDPJGFDJHEK : OCBALFEOJPM
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool IHDFKNGPKBE
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x85F430", Offset = "0x85E430", VA = "0x18085F430", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action BLPJNKIAFDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6BF4B40", Offset = "0x6BF3B40", VA = "0x186BF4B40", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x6BF4C80", Offset = "0x6BF3C80", VA = "0x186BF4C80", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action PIPLPAOLMGL
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x6BF48B0", Offset = "0x6BF38B0", VA = "0x186BF48B0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6BF49F0", Offset = "0x6BF39F0", VA = "0x186BF49F0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6BF4D30", Offset = "0x6BF3D30", VA = "0x186BF4D30", Slot = "8")]
	public GAEMIFNLIHB LLEBBJIFEDK(string POFKOEDNNNC, string DNCMAFMMDDP, [Optional] HCFKGBNNNKF KHNBHEBAGMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6BF4950", Offset = "0x6BF3950", VA = "0x186BF4950", Slot = "10")]
	public GAEMIFNLIHB DOLDAKDMBBM(HCFKGBNNNKF KHNBHEBAGMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6BF4A90", Offset = "0x6BF3A90", VA = "0x186BF4A90", Slot = "11")]
	public GAEMIFNLIHB FLKMBDCIHOF(HCFKGBNNNKF KHNBHEBAGMG, Dictionary<string, string> NKNNBHPJBFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x867480", Offset = "0x866480", VA = "0x180867480", Slot = "12")]
	public bool AOMKBMELCCO(string BKINOJFIHFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6BF4B30", Offset = "0x6BF3B30", VA = "0x186BF4B30", Slot = "13")]
	public GDDALNDKGMI JAGBOADOBEN(string BLCAJBAAAMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6BF4D20", Offset = "0x6BF3D20", VA = "0x186BF4D20", Slot = "14")]
	public JKGGELCPOLK JPAKHAPGAGH(string IKPDBGKAIKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6BF4B30", Offset = "0x6BF3B30", VA = "0x186BF4B30", Slot = "15")]
	public GDDALNDKGMI GMPLMFMIGCD(string KLFEJBLOBMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6BF4BE0", Offset = "0x6BF3BE0", VA = "0x186BF4BE0", Slot = "16")]
	public GAEMIFNLIHB HJBAICAPBMK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	public IDPJGFDJHEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface HCFKGBNNNKF
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	bool KBPPIBJLKDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	bool JALGBLAJELD
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	bool DEAPDIGIAPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool NHPPIGBJJLN
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	bool? CLIJFCOJGBO
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	int? OJOOGNLKJHA
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	int ALGAOFCCGFH
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	string JHIDOBPDFMN
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	string PHKMHJHIDJA
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	string OGNDFGDODPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	string GMDMJCIHNGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	string ADGOIAEAIDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	string GPKEDBJPBDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	double LCKDGGHBEDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface FAJNDLHCGKH
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	long LAPHLFIJAMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "1")]
	long LJHHFOPEPLP();

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CIEIJPPMCOB(long MFKLMHEIHNH, bool GOPBGOJFDOE = true);

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EBODFOOBDCA(string AEOEKGNDHFM, string BAHNPNPNBKH, string HMDIENEPLDI);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EOJFANBKELG(string AEOEKGNDHFM);

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PPDCDFALMHC(string AEOEKGNDHFM, string EBOHKCBONDM, string HDJAGIGFLGO);

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LLCJIOIJDLA(string MHDPLHDMGFC, object BLCFPJINEMD, object ENPDCJBGEHC);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface AGDJMPGOCPE
{
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BCEIGJKGMBD EFPNNEIHPKP(string BGJPMGEHLFD);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class MHGFMJKAFPI
{
	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	public MHGFMJKAFPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0xBB9C20", Offset = "0xBB8C20", VA = "0x180BB9C20")]
	public static string KILOLNAHAFI(byte[] BKIADALNNFJ, byte[] EEICCMPLMOJ)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
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

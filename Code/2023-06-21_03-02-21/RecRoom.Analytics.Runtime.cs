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
		[Cpp2IlInjected.Address(RVA = "0x841A80", Offset = "0x840C80", VA = "0x180841A80")]
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
		[Cpp2IlInjected.Address(RVA = "0x6C034C0", Offset = "0x6C026C0", VA = "0x186C034C0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8F3350", Offset = "0x8F2550", VA = "0x1808F3350")]
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
		[Cpp2IlInjected.Address(RVA = "0xE73C20", Offset = "0xE72E20", VA = "0x180E73C20")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class FJIDFFJKFAE
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public const string FBGKAJNOAMO = "batch";

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public const string JHHJHAPLBCM = "type";

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public const string HGBEDHHHGBK = "identify";

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public const string JLBAKPAPBOM = "track";

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public const string IHAEPNHGCMC = "userId";

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public const string GCMLLICPMHD = "anonymousId";

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public const string LDFGNPKDPFP = "stable_id";

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public const string EECNOJEMHJG = "messageId";

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public const string IGJDNNFELBJ = "event";

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public const string PMHAKOMFBEK = "version";

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public const string MOPANDAEKKF = "locale";

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public const string KJNAHBLKKBB = "name";

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public const string LDLJILFNGLO = "properties";

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public const string CJCPKHBPPPG = "traits";

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public const string HGLKCOOIALP = "context";

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public const string JKGGBLGFLLH = "app";

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public const string LJMPIDFIGLK = "os";

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public const string KJBNNDFDKCA = "device";

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public const string IDMLNBNNJOG = "originalTimestamp";

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public const string KBHJEALEHMA = "brand";

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public const string CHNOGBGDDEC = "manufacturer";

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public const string OBIMNJDIIBB = "model";

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public const string JPOJEPPFAGG = "type";

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
	public FJIDFFJKFAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class CCECEHNMDJH
{
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public const int JJABMKFNFEN = 2;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public const int NHKNIEJNBFF = 100;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public const int KFDMIIFKOEK = 1000;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public const long FDPBJEGLADP = 1800000L;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public const int EDOHCKFDKBO = 1024;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public const int CKKNDKJLLBJ = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public const string KGLEMBHKFLI = "amplitude_sequence_number";

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public const string NPBKKNFGPND = "amplitude_user_id";

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public const string PFPMALLLJNA = "amplitude_last_time";

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public const string OPMLIPELNDK = "initialize_analytics";

	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public const string CDFAOKACNHI = "session_start";

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public const string NKFFFOHBDBL = "session_end";

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public const string DEPBEGLIBAJ = "insert_id";

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public const string DFBMAKLEHBG = "event_time";

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public const string KIMFFBJJFIN = "session_id";

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public const string GMJDFHJJMGA = "session_tracking_data";

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public const string GOHAPMCOLDN = "user_properties";

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public const string NGDKFIPIJNI = "app_version";

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public const string AEEJJAOLNGL = "ip";

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public const string LIHAHIOPPHJ = "language";

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public const string LDFGNPKDPFP = "stable_id";

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public const string AIEGNMNHNMM = "platform";

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public const string OIOHPOOPJPN = "os_name";

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public const string DKOOBIEKJFH = "os_version";

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public const string KBNAABDFLDD = "device_brand";

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public const string IKNNNFADBDB = "device_manufacturer";

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public const string KKANMCPMBGJ = "device_model";

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public const string MOBBLKNPACG = "device_type";

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public const string KHEACDGCCIK = "price";

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public const string FIPBNDFKLEL = "quantity";

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public const string NLPCGDNKCGM = "revenue";

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public const string JGODFGBCBKK = "productId";

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public const string HCDPPAINEIA = "revenueType";

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public const string GMHHDKHKIHK = "event_type";

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public const string IHAEPNHGCMC = "user_id";

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public const string IFDEGDEBEAM = "event_properties";

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public const int DDOANPMBHKF = 10;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> ELHIFMCOIHD;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6BFE540", Offset = "0x6BFD740", VA = "0x186BFE540")]
	internal static bool GGEECLHJAKA(string PPNIGBBPGOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
	public CCECEHNMDJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface EJNCICBMAGH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool OLJMJEGPAFO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string FPNOGKMHAMN
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	string HIABJNKHMFN
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	string AHIOBPEOKFD
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	string JHLOHAIBEKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NHJDNADPIAN<HNAFHGCADIG> OFKGPBGEJPA(string GBIGHGGHAHJ, Dictionary<string, string> MDLDJEEDKDN, bool PBEAEJICLFI = false);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NHJDNADPIAN<HNAFHGCADIG> PPMHNKFDMOM(string GBIGHGGHAHJ, string DCKNFBJKHAB, string NOLFCPHBLBO, string GACCDGBLFBF);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct HNAFHGCADIG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly int CMDFPBACKHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly string OMJFDNPNBDG;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x902C30", Offset = "0x901E30", VA = "0x180902C30")]
	public HNAFHGCADIG(int JKOLGGLEGME, string HHCABNHMIDO)
	{
	}
}
namespace AmplitudeAnalytics
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class AGAmplitudeAnalyticsSettings : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[SerializeField]
		private AmplitudeAnalyticsClient.Settings editorSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[SerializeField]
		private bool forceEditorSettingsForDevelopers;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public AmplitudeAnalyticsClient.Settings NODAFIHPJJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x96EA60", Offset = "0x96DC60", VA = "0x18096EA60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool HGKIBNAHCKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xB83780", Offset = "0xB82980", VA = "0x180B83780")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x931070", Offset = "0x930270", VA = "0x180931070")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class AmplitudeAnalyticsEvent : AmplitudeAnalyticsIdentifyMessage
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly string uuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly string eventType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly long sequenceNumber;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		internal Dictionary<string, object> eventProperties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private string language;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private long time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private long sessionId;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static string SessionTrackingData
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6BFD600", Offset = "0x6BFC800", VA = "0x186BFD600")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6BFD680", Offset = "0x6BFC880", VA = "0x186BFD680")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static string StableId
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6BFD640", Offset = "0x6BFC840", VA = "0x186BFD640")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6BFD6D0", Offset = "0x6BFC8D0", VA = "0x186BFD6D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x8EE430", Offset = "0x8ED630", VA = "0x1808EE430")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6BFD1D0", Offset = "0x6BFC3D0", VA = "0x186BFD1D0")]
		public static MCEMAICELCB LNIGJBIDADO(string EJEDLELNMDA, [NotNull] string EMBMAMNHNPM, long FIACEINHMCI, long EBBHNJJCNLJ, string CBGANMBGMML)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6BFCB10", Offset = "0x6BFBD10", VA = "0x186BFCB10")]
		public static MCEMAICELCB BCODPFEENNJ(string EJEDLELNMDA, [NotNull] string EMBMAMNHNPM, long FIACEINHMCI, long EBBHNJJCNLJ, string CBGANMBGMML, long FAOIKGJMLGC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6BFD420", Offset = "0x6BFC620", VA = "0x186BFD420")]
		private AmplitudeAnalyticsEvent(string EJEDLELNMDA, [NotNull] string EMBMAMNHNPM, long FIACEINHMCI, long EBBHNJJCNLJ, string CBGANMBGMML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xBFB850", Offset = "0xBFAA50", VA = "0x180BFB850")]
		public void BILBCHDDHOJ(long GHCPFCIPLIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6BFCC10", Offset = "0x6BFBE10", VA = "0x186BFCC10", Slot = "5")]
		public override void CPGDLPMEHAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6BFD2C0", Offset = "0x6BFC4C0", VA = "0x186BFD2C0", Slot = "6")]
		public override void NKHOPJNAJMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6BFCD00", Offset = "0x6BFBF00", VA = "0x186BFCD00", Slot = "4")]
		protected override Dictionary<string, object> KFLABENDMKF(Dictionary<string, object> HIAKMIHMCMI)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class ABLHMNNDBIM : BJJHBJOJKOF<AmplitudeAnalyticsIdentifyMessage, ABLHMNNDBIM>
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override ABLHMNNDBIM FMAGINGFFCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x853280", Offset = "0x852480", VA = "0x180853280", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8D44A0", Offset = "0x8D36A0", VA = "0x1808D44A0", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage LGCLMGOMLAM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6BF6020", Offset = "0x6BF5220", VA = "0x186BF6020")]
	public ABLHMNNDBIM(AmplitudeAnalyticsIdentifyMessage CEOMJLPEFPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6BF5FB0", Offset = "0x6BF51B0", VA = "0x186BF5FB0", Slot = "4")]
	public override void NKHOPJNAJMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class MCEMAICELCB : BJJHBJOJKOF<AmplitudeAnalyticsEvent, MCEMAICELCB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private bool LJNMMKHNDGJ;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override MCEMAICELCB FMAGINGFFCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x853280", Offset = "0x852480", VA = "0x180853280", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public long FHCEOPLLJKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6C02C60", Offset = "0x6C01E60", VA = "0x186C02C60")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6C032E0", Offset = "0x6C024E0", VA = "0x186C032E0")]
	public MCEMAICELCB(AmplitudeAnalyticsEvent CEOMJLPEFPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8D44A0", Offset = "0x8D36A0", VA = "0x1808D44A0", Slot = "5")]
	public override AmplitudeAnalyticsEvent LGCLMGOMLAM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6C03240", Offset = "0x6C02440", VA = "0x186C03240", Slot = "4")]
	public override void NKHOPJNAJMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6C02D90", Offset = "0x6C01F90", VA = "0x186C02D90")]
	public MCEMAICELCB JHDECDKFEGM(string CKAKOJLMGFA, long[] ACKOJNNBEBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6C02FF0", Offset = "0x6C021F0", VA = "0x186C02FF0")]
	public MCEMAICELCB JHDECDKFEGM(string CKAKOJLMGFA, ulong[] ACKOJNNBEBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x38ADF40", Offset = "0x38AD140", VA = "0x1838ADF40")]
	public MCEMAICELCB JHDECDKFEGM<T>(string CKAKOJLMGFA, T[] ACKOJNNBEBO) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6C03130", Offset = "0x6C02330", VA = "0x186C03130")]
	public MCEMAICELCB JHDECDKFEGM(string CKAKOJLMGFA, string[] ACKOJNNBEBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x38ADED0", Offset = "0x38AD0D0", VA = "0x1838ADED0")]
	public MCEMAICELCB JHDECDKFEGM<T>(string CKAKOJLMGFA, T ACKOJNNBEBO) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6C02F60", Offset = "0x6C02160", VA = "0x186C02F60")]
	public MCEMAICELCB JHDECDKFEGM(string CKAKOJLMGFA, long ACKOJNNBEBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6C02ED0", Offset = "0x6C020D0", VA = "0x186C02ED0")]
	public MCEMAICELCB JHDECDKFEGM(string CKAKOJLMGFA, ulong ACKOJNNBEBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6C02D20", Offset = "0x6C01F20", VA = "0x186C02D20")]
	public MCEMAICELCB JHDECDKFEGM(string CKAKOJLMGFA, string ACKOJNNBEBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6C02C30", Offset = "0x6C01E30", VA = "0x186C02C30")]
	public MCEMAICELCB CBJMLIKOLHM(string CKAKOJLMGFA, object? ACKOJNNBEBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6C02C80", Offset = "0x6C01E80", VA = "0x186C02C80")]
	public MCEMAICELCB JADOGBGCCEB(string CKAKOJLMGFA, string ACKOJNNBEBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6C03140", Offset = "0x6C02340", VA = "0x186C03140")]
	private MCEMAICELCB MMBJMEGEMJJ(string CKAKOJLMGFA, object ACKOJNNBEBO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class MPPFCKMINBJ : MCEMAICELCB
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6C032E0", Offset = "0x6C024E0", VA = "0x186C032E0")]
	public MPPFCKMINBJ(AmplitudeAnalyticsEvent CEOMJLPEFPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6C03330", Offset = "0x6C02530", VA = "0x186C03330", Slot = "4")]
	public override void NKHOPJNAJMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class BJJHBJOJKOF<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : BJJHBJOJKOF<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	protected M CEOMJLPEFPB;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public abstract BLDR FMAGINGFFCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x1CCC600", Offset = "0x1CCB800", VA = "0x181CCC600")]
	public BJJHBJOJKOF(M CEOMJLPEFPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x33FC4B0", Offset = "0x33FB6B0", VA = "0x1833FC4B0")]
	public BLDR LLAIKFEHOBC(AmplitudeAnalyticsIdentifyMessage.DeviceInfo LPDKBLCGDKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x33FC4F0", Offset = "0x33FB6F0", VA = "0x1833FC4F0")]
	public BLDR POOMMFKNPAO(AmplitudeAnalyticsIdentifyMessage.RevenueData EFEGDHPJIIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x33FC410", Offset = "0x33FB610", VA = "0x1833FC410")]
	public BLDR CGAHOOBMLNO(string CKAKOJLMGFA, string ACKOJNNBEBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x30F7250", Offset = "0x30F6450", VA = "0x1830F7250")]
	public BLDR CGAHOOBMLNO<T>(string CKAKOJLMGFA, T ACKOJNNBEBO) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x33FC2B0", Offset = "0x33FB4B0", VA = "0x1833FC2B0")]
	public BLDR CGAHOOBMLNO(string CKAKOJLMGFA, long ACKOJNNBEBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x33FC360", Offset = "0x33FB560", VA = "0x1833FC360")]
	public BLDR CGAHOOBMLNO(string CKAKOJLMGFA, ulong ACKOJNNBEBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void NKHOPJNAJMI();

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x33FC480", Offset = "0x33FB680", VA = "0x1833FC480")]
	internal static string JGGFLPBGCND(string ACKOJNNBEBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x33FC1B0", Offset = "0x33FB3B0", VA = "0x1833FC1B0")]
	private BLDR CFGKFAKHOAD(string CKAKOJLMGFA, object ACKOJNNBEBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M LGCLMGOMLAM();
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
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public string platform;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public string osName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public string osVersion;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public string deviceBrand;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public string deviceManufacturer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public string deviceModel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public string deviceType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public string carrier;

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x6BFFDE0", Offset = "0x6BFEFE0", VA = "0x186BFFDE0")]
			public void LNIKAABCBCL(Dictionary<string, object> LCAMIONBFOI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
			public DeviceInfo()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public class RevenueData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public float price;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public int quantity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public float revenue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public string productId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public string revenueType;

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x6C03A90", Offset = "0x6C02C90", VA = "0x186C03A90")]
			public void LNIKAABCBCL(Dictionary<string, object> NNOMLNJPKBL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x6C03C00", Offset = "0x6C02E00", VA = "0x186C03C00")]
			public RevenueData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal DeviceInfo deviceInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal RevenueData revenueData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private readonly string buildVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private readonly string language;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal Dictionary<string, object> userProperties;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		protected string UserId
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8D4AB0", Offset = "0x8D3CB0", VA = "0x1808D4AB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8F7D20", Offset = "0x8F6F20", VA = "0x1808F7D20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6BFDBB0", Offset = "0x6BFCDB0", VA = "0x186BFDBB0")]
		public static ABLHMNNDBIM LNIGJBIDADO(string EJEDLELNMDA, string CBGANMBGMML)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6BFDD60", Offset = "0x6BFCF60", VA = "0x186BFDD60")]
		protected AmplitudeAnalyticsIdentifyMessage(string EJEDLELNMDA, string CBGANMBGMML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6BFD720", Offset = "0x6BFC920", VA = "0x186BFD720")]
		public Dictionary<string, object> CDMPFNNGPNH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6BFD800", Offset = "0x6BFCA00", VA = "0x186BFD800", Slot = "4")]
		protected virtual Dictionary<string, object> KFLABENDMKF(Dictionary<string, object> HIAKMIHMCMI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6BFDC60", Offset = "0x6BFCE60", VA = "0x186BFDC60")]
		protected void MCCKFFFGKEK(string PPNIGBBPGOI, Dictionary<string, object> LGJCGALPKAD, Dictionary<string, object> NBEBIBODCGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6BFDB40", Offset = "0x6BFCD40", VA = "0x186BFDB40")]
		protected void LFGKADCKHCA(string PPNIGBBPGOI, string ACKOJNNBEBO, Dictionary<string, object> GLAKBFAJMJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6BFD7A0", Offset = "0x6BFC9A0", VA = "0x186BFD7A0", Slot = "5")]
		public virtual void CPGDLPMEHAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6BFDD10", Offset = "0x6BFCF10", VA = "0x186BFDD10", Slot = "6")]
		public virtual void NKHOPJNAJMI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		private enum DAGBKDEGKDH
		{
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		internal class GNJAPOGKKBK
		{
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			private class ABLJCCHAKGK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400009F")]
				public int LBFENAEONCE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000A0")]
				public Dictionary<string, object> AAKGDJFBPLI;

				[Cpp2IlInjected.Token(Token = "0x600009D")]
				[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
				public ABLJCCHAKGK()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000017")]
			[CompilerGenerated]
			private sealed class DMEDEPIGNPE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000A1")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x600009E")]
				[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
				public DMEDEPIGNPE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600009F")]
				[Cpp2IlInjected.Address(RVA = "0x6BFFD80", Offset = "0x6BFEF80", VA = "0x186BFFD80")]
				internal bool OHMCOJJNPBE(ABLJCCHAKGK item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400009C")]
			private const string JLLKMHODENI = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			private readonly string KMBFNDAPCGA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			private List<ABLJCCHAKGK> EJFIFFGCMBN;

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			public int? MMPMBAMNMLA
			{
				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(RVA = "0x6C01090", Offset = "0x6C00290", VA = "0x186C01090")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public int? OPDKDPNBHBG
			{
				[Cpp2IlInjected.Token(Token = "0x6000092")]
				[Cpp2IlInjected.Address(RVA = "0x6C01580", Offset = "0x6C00780", VA = "0x186C01580")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x6C018B0", Offset = "0x6C00AB0", VA = "0x186C018B0")]
			internal GNJAPOGKKBK(string HEKDOPBDIEJ, string IKGFGLILKPG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x6C00F10", Offset = "0x6C00110", VA = "0x186C00F10")]
			public int KILLKOJNCMD([Optional] int? CFIBMNIHHKG)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x6C00470", Offset = "0x6BFF670", VA = "0x186C00470")]
			public List<Dictionary<string, object>> CGKNAGDJOCG(int KCMDLBKPHIL, int? CFIBMNIHHKG)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x6C00D30", Offset = "0x6BFFF30", VA = "0x186C00D30")]
			public void JMHGFFMEIMI(AmplitudeAnalyticsIdentifyMessage BHEOHCEHIBM, bool AKCHEFMOHLH = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x6C00C20", Offset = "0x6BFFE20", VA = "0x186C00C20")]
			public void JMHGFFMEIMI(Dictionary<string, object> BHEOHCEHIBM, bool AKCHEFMOHLH = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x6C00960", Offset = "0x6BFFB60", VA = "0x186C00960")]
			public void IFMDIODBLOG(params Dictionary<string, object>[] JPFJBHMFJLC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x6C00710", Offset = "0x6BFF910", VA = "0x186C00710")]
			public void CMGCDIFHLIG(List<Dictionary<string, object>> PGJKFAEFNHP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x6C00DD0", Offset = "0x6BFFFD0", VA = "0x186C00DD0")]
			private void KGMLKAJAHOP(Dictionary<string, object> BHEOHCEHIBM, bool AKCHEFMOHLH = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x6C01640", Offset = "0x6C00840", VA = "0x186C01640")]
			public void POCDDKPOEPD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x6C01130", Offset = "0x6C00330", VA = "0x186C01130")]
			private void NEHKOOJIHLJ([Optional] string JOHBEDGKEMC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x6C00AF0", Offset = "0x6BFFCF0", VA = "0x186C00AF0")]
			private static string ILBBPHHLOOC(string ACKOJNNBEBO, string PPNIGBBPGOI)
			{
				return null;
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public class Settings
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public float BatchIntervalSeconds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			public bool verboseLogging;

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x6C03E60", Offset = "0x6C03060", VA = "0x186C03E60")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public struct ALDLJCAJCLH<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public int JKOLGGLEGME;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public string HHCABNHMIDO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public T HMILPKEPICF;
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class BHAKHKJMEKL : IEnumerator<HGAIOCFFOOA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			private HGAIOCFFOOA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			private List<AmplitudeAnalyticsIdentifyMessage>.Enumerator <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			private AmplitudeAnalyticsIdentifyMessage <queuedEvent>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			private HGAIOCFFOOA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000A9")]
				[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000AB")]
				[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x8DC2E0", Offset = "0x8DB4E0", VA = "0x1808DC2E0")]
			[DebuggerHidden]
			public BHAKHKJMEKL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x6BFDE60", Offset = "0x6BFD060", VA = "0x186BFDE60", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x6BFE500", Offset = "0x6BFD700", VA = "0x186BFE500", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class FGFBPDGAHDG : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public DAFGDOMLDFF quitCompletePromise;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			private float <timeout>5__1;

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000AF")]
				[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000B1")]
				[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x8DC2E0", Offset = "0x8DB4E0", VA = "0x1808DC2E0")]
			[DebuggerHidden]
			public FGFBPDGAHDG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x6BFFF60", Offset = "0x6BFF160", VA = "0x186BFFF60", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x6C00080", Offset = "0x6BFF280", VA = "0x186C00080", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class JGCEKJNFPIN : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public float timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000B5")]
				[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000B7")]
				[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x8DC2E0", Offset = "0x8DB4E0", VA = "0x1808DC2E0")]
			[DebuggerHidden]
			public JGCEKJNFPIN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x6C02730", Offset = "0x6C01930", VA = "0x186C02730", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x6C028C0", Offset = "0x6C01AC0", VA = "0x186C028C0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class GBLEKLFAJNK : IEnumerator<HGAIOCFFOOA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			private HGAIOCFFOOA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public float timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			private bool <shouldSendBatch>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			private GNJAPOGKKBK <cache>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			private string <url>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			private Action<int> <eventBatchSent>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private int? <earlierThanFrame>5__5;

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			private HGAIOCFFOOA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000BB")]
				[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000BD")]
				[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x8DC2E0", Offset = "0x8DB4E0", VA = "0x1808DC2E0")]
			[DebuggerHidden]
			public GBLEKLFAJNK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x6C000C0", Offset = "0x6BFF2C0", VA = "0x186C000C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x6C00430", Offset = "0x6BFF630", VA = "0x186C00430", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class LEDCBHEJHIF : IEnumerator<HGAIOCFFOOA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			private HGAIOCFFOOA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public float timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			private GNJAPOGKKBK <cache>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			private string <url>5__2;

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			private HGAIOCFFOOA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000C4")]
				[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000C6")]
				[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x8DC2E0", Offset = "0x8DB4E0", VA = "0x1808DC2E0")]
			[DebuggerHidden]
			public LEDCBHEJHIF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x6C02900", Offset = "0x6C01B00", VA = "0x186C02900", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x6C02BF0", Offset = "0x6C01DF0", VA = "0x186C02BF0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[CompilerGenerated]
		private sealed class CIGDKNBEFAI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public List<Dictionary<string, object>> batch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public GNJAPOGKKBK cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
			public CIGDKNBEFAI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x6BFF0B0", Offset = "0x6BFE2B0", VA = "0x186BFF0B0")]
			internal void NIIFHCJIJOD(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x6BFEC10", Offset = "0x6BFDE10", VA = "0x186BFEC10")]
			internal void FLBEHIKLMFG(ALDLJCAJCLH<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class DJDIDBGBFJI : IEnumerator<HGAIOCFFOOA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			private HGAIOCFFOOA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public GNJAPOGKKBK cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public int? earlierThanFrame;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public string url;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public string dataIdentifier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public float timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			private CIGDKNBEFAI <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			private string <apiKey>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			private float <startTime>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			private bool <timedOut>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			private int <batchSize>5__5;

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			private HGAIOCFFOOA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000CD")]
				[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000CF")]
				[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x8DC2E0", Offset = "0x8DB4E0", VA = "0x1808DC2E0")]
			[DebuggerHidden]
			public DJDIDBGBFJI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x6BFF420", Offset = "0x6BFE620", VA = "0x186BFF420", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x6BFFD40", Offset = "0x6BFEF40", VA = "0x186BFFD40", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private sealed class JFIEGPFHNEL<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x1913A50", Offset = "0x1912C50", VA = "0x181913A50")]
			public JFIEGPFHNEL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x34ECCA0", Offset = "0x34EBEA0", VA = "0x1834ECCA0")]
			internal ALDLJCAJCLH<T> PGMABBLDEMP(HNAFHGCADIG postResponse)
			{
				return default(ALDLJCAJCLH<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class GJNOILPAFMA<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x1913A50", Offset = "0x1912C50", VA = "0x181913A50")]
			public GJNOILPAFMA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x34ECCA0", Offset = "0x34EBEA0", VA = "0x1834ECCA0")]
			internal ALDLJCAJCLH<T> FJADHOIAKAD(HNAFHGCADIG postResponse)
			{
				return default(ALDLJCAJCLH<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private NMEPAPEIDNF HLKPACMADJJ;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private const string DMIMOOMHCEE = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private const string DPFCGECAMLB = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private const string ABIHFEMOHCA = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private const int EFLMPBPLDBH = 15;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private const int CNJEGCGLBNL = 10;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private const int OKAJAHMIMMF = 5;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private const float IIGANJFKDPP = 10f;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private const long IJGECINPBAM = -1L;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private const string BNJJDDMDDEE = "f1779b982f1c09aed3adb3cca563cbc2";

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private const string FFKNGCFAKIM = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private static bool EABCCMFJBHK;

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static bool ONBLCBBNJDI;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static int PLPOPJGBDHN;

		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private static int OCMLBHENKHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private EJNCICBMAGH KOIKDLEGJEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private bool CNPLLHHIPHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private float NGCECIKNGPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private float JMPNIBAOLFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int CNPPMLOGCLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private int ENEACOCODCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int? IKGLOAHGHEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int? JHENFIGLPMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private long MLPAPAOMMJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private string HIPJONNHLJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private long BHIKNPMCIKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private Dictionary<string, object> LKIPIIJJEJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private DAGBKDEGKDH JOIMNEMAKPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private int DNNLGIFEFDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private int AFKMINGHBPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private float LGKBBEPFIFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private bool JGGJCPGAGEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x89")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private bool IODPJEOPDNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private GNJAPOGKKBK CBPEBNBIECG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private GNJAPOGKKBK EMFNHBNBMPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private GNJAPOGKKBK EKAABOKJBCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> LEINBMAACCO;

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo KLDIANLJIDJ;

		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private static string AIPIPPAIOLH;

		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private const string CJFHPLFJNPF = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private readonly string PLOENPNGBMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private readonly string JHHMAHIDPNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly string IKNOGNAJCDK;

		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private NMEPAPEIDNF OCMLDNMAHID
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6BFA760", Offset = "0x6BF9960", VA = "0x186BFA760")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private static int FBMHOJAICCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6BF8F10", Offset = "0x6BF8110", VA = "0x186BF8F10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static long HBHFOIAKMLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6BFC9B0", Offset = "0x6BFBBB0", VA = "0x186BFC9B0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6BFCAB0", Offset = "0x6BFBCB0", VA = "0x186BFCAB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static string ONANOOOMAHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6BFC950", Offset = "0x6BFBB50", VA = "0x186BFC950")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static string NOFKDADJMGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x6BFC980", Offset = "0x6BFBB80", VA = "0x186BFC980")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public string CNKBOJDOIBB
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x8EE3F0", Offset = "0x8ED5F0", VA = "0x1808EE3F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x90DFC0", Offset = "0x90D1C0", VA = "0x18090DFC0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public int? COKBHNEMHNF
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xB0E240", Offset = "0xB0D440", VA = "0x180B0E240")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x3C0BE60", Offset = "0x3C0B060", VA = "0x183C0BE60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool DCNNGDPMCOG
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xB54D20", Offset = "0xB53F20", VA = "0x180B54D20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xB54E20", Offset = "0xB54020", VA = "0x180B54E20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static bool IOKIMOIHEFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x6BFC8C0", Offset = "0x6BFBAC0", VA = "0x186BFC8C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> OIEBOAMBBHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x6BFC820", Offset = "0x6BFBA20", VA = "0x186BFC820")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x6BFCA10", Offset = "0x6BFBC10", VA = "0x186BFCA10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6BF8C20", Offset = "0x6BF7E20", VA = "0x186BF8C20", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6BFA450", Offset = "0x6BF9650", VA = "0x186BFA450")]
		private void KOILJPPANIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6BFC090", Offset = "0x6BFB290", VA = "0x186BFC090")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6BFB6B0", Offset = "0x6BFA8B0", VA = "0x186BFB6B0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6BFC370", Offset = "0x6BFB570", VA = "0x186BFC370")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6BFB840", Offset = "0x6BFAA40", VA = "0x186BFB840")]
		public OOPPNGPPPLE PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6BFA1E0", Offset = "0x6BF93E0", VA = "0x186BFA1E0")]
		[IteratorStateMachine(typeof(BHAKHKJMEKL))]
		public IEnumerator<HGAIOCFFOOA> Initialize(AmplitudeAnalyticsEvent NPGEBHFFMMI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6BFC270", Offset = "0x6BFB470", VA = "0x186BFC270")]
		public void UpdateLastAliveTime(float OMKPMLCMMMA = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6BFAF90", Offset = "0x6BFA190", VA = "0x186BFAF90")]
		private OOPPNGPPPLE NLMJPLKBGLK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6BF9BC0", Offset = "0x6BF8DC0", VA = "0x186BF9BC0")]
		private OOPPNGPPPLE GPHOLNMACMM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6BFBC90", Offset = "0x6BFAE90", VA = "0x186BFBC90")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6BF98A0", Offset = "0x6BF8AA0", VA = "0x186BF98A0")]
		[IteratorStateMachine(typeof(FGFBPDGAHDG))]
		private IEnumerator DOLCGLFDMEB(DAFGDOMLDFF HJFIHFCAJGH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6BFC5F0", Offset = "0x6BFB7F0", VA = "0x186BFC5F0")]
		[IteratorStateMachine(typeof(JGCEKJNFPIN))]
		public IEnumerator WaitForFlush(float HJLEAHGMGHL = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6BFC150", Offset = "0x6BFB350", VA = "0x186BFC150")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6BFC0A0", Offset = "0x6BFB2A0", VA = "0x186BFC0A0")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime LNBMFKNJEDF)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6BF9EC0", Offset = "0x6BF90C0", VA = "0x186BF9EC0")]
		public static ABLHMNNDBIM Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6BF8AE0", Offset = "0x6BF7CE0", VA = "0x186BF8AE0")]
		public static MCEMAICELCB AccountSelectionPostLoginEvent([NotNull] string MANBLCBIDNA, string CBGANMBGMML)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6BF99B0", Offset = "0x6BF8BB0", VA = "0x186BF99B0")]
		public static MCEMAICELCB Event([NotNull] string MANBLCBIDNA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6BFB8A0", Offset = "0x6BFAAA0", VA = "0x186BFB8A0")]
		public static MCEMAICELCB PreviousSessionEvent([NotNull] string MANBLCBIDNA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6BF9FF0", Offset = "0x6BF91F0", VA = "0x186BF9FF0")]
		public static MCEMAICELCB InitializeEvent(string CBGANMBGMML)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6BFBE00", Offset = "0x6BFB000", VA = "0x186BFBE00")]
		public static MCEMAICELCB StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6BF9600", Offset = "0x6BF8800", VA = "0x186BF9600")]
		public static MCEMAICELCB CreateOutOfSessionEvent(string MANBLCBIDNA, bool EEFIIBONDCF = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6BFAA70", Offset = "0x6BF9C70", VA = "0x186BFAA70")]
		public static OOPPNGPPPLE LogOutOfSessionEvent(MCEMAICELCB MMOJEIDOJOD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6BFA7D0", Offset = "0x6BF99D0", VA = "0x186BFA7D0")]
		public void LogEventAsync(AmplitudeAnalyticsEvent JAGGHCALHHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6BFAD60", Offset = "0x6BF9F60", VA = "0x186BFAD60")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent JAGGHCALHHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6BFAEB0", Offset = "0x6BFA0B0", VA = "0x186BFAEB0")]
		public void LogSerializedEventAsync(Dictionary<string, object> BNKMCMKMNMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6BFA920", Offset = "0x6BF9B20", VA = "0x186BFA920")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage AJGANHAONGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6BFB460", Offset = "0x6BFA660", VA = "0x186BFB460")]
		private void OODFCCBLOEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6BF9360", Offset = "0x6BF8560", VA = "0x186BF9360")]
		private void COHIHKOBNMK(Dictionary<string, object> LLAEABMBHMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6BFB750", Offset = "0x6BFA950", VA = "0x186BFB750")]
		private void PLGDBCIMEKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6BFA270", Offset = "0x6BF9470", VA = "0x186BFA270")]
		private void JMAENHFDGBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6BF9B30", Offset = "0x6BF8D30", VA = "0x186BF9B30")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6BF90E0", Offset = "0x6BF82E0", VA = "0x186BF90E0")]
		[IteratorStateMachine(typeof(GBLEKLFAJNK))]
		private IEnumerator<HGAIOCFFOOA> BIABOPKFDOP(float HJLEAHGMGHL = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6BF9930", Offset = "0x6BF8B30", VA = "0x186BF9930")]
		[IteratorStateMachine(typeof(LEDCBHEJHIF))]
		private IEnumerator<HGAIOCFFOOA> EFHLMOEMKDF(float HJLEAHGMGHL = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6BF9280", Offset = "0x6BF8480", VA = "0x186BF9280")]
		[IteratorStateMachine(typeof(DJDIDBGBFJI))]
		private IEnumerator<HGAIOCFFOOA> CINCBCOFNKP(GNJAPOGKKBK NJDJIKKDMOA, int? CFIBMNIHHKG, string GBIGHGGHAHJ, string AAIBAKPGBMF, float HJLEAHGMGHL, Action<int> IAJBFKABLIB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6BF9160", Offset = "0x6BF8360", VA = "0x186BF9160")]
		private static void BKPIIGKBMCD(bool HEDDCIFDMPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6BFB060", Offset = "0x6BFA260", VA = "0x186BFB060")]
		private NHJDNADPIAN<ALDLJCAJCLH<Dictionary<string, object>>> OFKGPBGEJPA(string GBIGHGGHAHJ, string AAIBAKPGBMF, string FNBHMFHKLEP, string IAFOPIGJNLM, Dictionary<string, object> HMILPKEPICF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6BFB190", Offset = "0x6BFA390", VA = "0x186BFB190")]
		private NHJDNADPIAN<ALDLJCAJCLH<List<Dictionary<string, object>>>> OFKGPBGEJPA(string GBIGHGGHAHJ, string AAIBAKPGBMF, string FNBHMFHKLEP, string IAFOPIGJNLM, List<Dictionary<string, object>> HMILPKEPICF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x31A24E0", Offset = "0x31A16E0", VA = "0x1831A24E0")]
		private NHJDNADPIAN<ALDLJCAJCLH<T>> ACOHJHHHOAN<T>(string GBIGHGGHAHJ, string AAIBAKPGBMF, string IAFOPIGJNLM, T HMILPKEPICF, Dictionary<string, object> JKCMCIGOBKC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x31A2770", Offset = "0x31A1970", VA = "0x1831A2770")]
		private NHJDNADPIAN<ALDLJCAJCLH<T>> JALLMNGBKLA<T>(string GBIGHGGHAHJ, string AAIBAKPGBMF, string FNBHMFHKLEP, T HMILPKEPICF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6BF9E70", Offset = "0x6BF9070", VA = "0x186BF9E70")]
		private bool IPDCGCCNKEN(float KIGKDLBBLOO, float HJLEAHGMGHL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6BF7E00", Offset = "0x6BF7000", VA = "0x186BF7E00")]
		private Dictionary<string, object> AFAJKFIBCOA(string AAIBAKPGBMF, Dictionary<string, object> HMILPKEPICF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6BFC6D0", Offset = "0x6BFB8D0", VA = "0x186BFC6D0")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6BFB550", Offset = "0x6BFA750", VA = "0x186BFB550")]
		[CompilerGenerated]
		private long OPLDMFHGDGC()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6BF8AD0", Offset = "0x6BF7CD0", VA = "0x186BF8AD0")]
		[CompilerGenerated]
		private void AMCCLAMOJEA(int IGIODFCAEOK)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class OEMJGAMJFGP
{
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private const string MMBJPOLNIPF = "timed_flow";

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private const string PCJEOOFPEJD = "flowName";

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private const string MLJEFLDLJLI = "startedAt";

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private const string NKHBCIMBGCG = "endedAt";

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private const string JEFAPLLBMND = "durationInSeconds";

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private const string KAEJNJJDPLF = "failure";

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private const string EPDCKDPHEHN = "failureMessage";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private long OGBIGNCGJDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private MCEMAICELCB DEFDIIMMKGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private bool MOIICADHAOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private float NCHEHALPBJJ;

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6C038F0", Offset = "0x6C02AF0", VA = "0x186C038F0")]
	public OEMJGAMJFGP(string OOLICJGFLDH, float NCHEHALPBJJ = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x34C1A20", Offset = "0x34C0C20", VA = "0x1834C1A20")]
	public void JHDECDKFEGM<T>(string CKAKOJLMGFA, T ACKOJNNBEBO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6C037B0", Offset = "0x6C029B0", VA = "0x186C037B0")]
	public void JHDECDKFEGM(string CKAKOJLMGFA, string ACKOJNNBEBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6C03550", Offset = "0x6C02750", VA = "0x186C03550")]
	public void DIALJEPOFLE(string GGEDLDBIEJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6C03830", Offset = "0x6C02A30", VA = "0x186C03830")]
	public void PLNBOOBJHOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6C03640", Offset = "0x6C02840", VA = "0x186C03640")]
	private void FLCIMLIAJBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6C03760", Offset = "0x6C02960", VA = "0x186C03760")]
	private bool GBIIHHBNIOL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public enum DKEIJDLHKMG
{
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	ChatPage,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	PlayerDetailsScreen,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	ActionCode,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	FriendImport,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	PlatformFriendInvite,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	PlatformNotification,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	WatchNotification,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	LegacyHomeScreen,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	NavigationBar,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	LegacyChatPage,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	MobileHomeChat,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	PlayerProfile,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	ShareContent,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	HUDHotbarShortcut
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class IFADFJLNFDL : AAPEKDAMDII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private AAPEKDAMDII ABCGEIACAED;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private AAPEKDAMDII FKLJLBMDNAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x6C01A40", Offset = "0x6C00C40", VA = "0x186C01A40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool GAIAFJLIGLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x6C01AB0", Offset = "0x6C00CB0", VA = "0x186C01AB0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action AJOHHGNNIFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6C020D0", Offset = "0x6C012D0", VA = "0x186C020D0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x6C02310", Offset = "0x6C01510", VA = "0x186C02310", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action LHFPBDOGPLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6C02690", Offset = "0x6C01890", VA = "0x186C02690", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6C02170", Offset = "0x6C01370", VA = "0x186C02170", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
	[Preserve]
	public IFADFJLNFDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6C01FE0", Offset = "0x6C011E0", VA = "0x186C01FE0")]
	[MPKPGFJAEKF(OJBJGAAILBP.GameOnly)]
	private static void KIKBKMCOHCN(JLCNCEFHLIA HPKKDLHOJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6C023B0", Offset = "0x6C015B0", VA = "0x186C023B0", Slot = "8")]
	public OOPPNGPPPLE OHLMLHJNBAL(string LBOLDEECDGO, string IKGFGLILKPG, [Optional] CGLJEOPFDFH LNEMGPDGNED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6C02210", Offset = "0x6C01410", VA = "0x186C02210", Slot = "10")]
	public OOPPNGPPPLE MIKNAJJJFBO(CGLJEOPFDFH LNEMGPDGNED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x6C01BA0", Offset = "0x6C00DA0", VA = "0x186C01BA0", Slot = "11")]
	public OOPPNGPPPLE GCICMAEEEDA(CGLJEOPFDFH LNEMGPDGNED, Dictionary<string, string> PMFECKINGON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6C01B00", Offset = "0x6C00D00", VA = "0x186C01B00", Slot = "12")]
	public bool DHIOCCONEPE(string LFGCPOBHCCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6C01CB0", Offset = "0x6C00EB0", VA = "0x186C01CB0", Slot = "13")]
	public NBDAHHFHDNB GDEOGOPJALG(string KBINMOKHNND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x6C01DF0", Offset = "0x6C00FF0", VA = "0x186C01DF0", Slot = "14")]
	public BJJAEDHBOHP KEDHPBEMOID(string OHLGACKEDIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x6C01D50", Offset = "0x6C00F50", VA = "0x186C01D50", Slot = "15")]
	public NBDAHHFHDNB GDHAGPINEDE(string KLOFDDLECFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x6C01EF0", Offset = "0x6C010F0", VA = "0x186C01EF0", Slot = "16")]
	public OOPPNGPPPLE KIFJHPHHMFL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x843EF0", Offset = "0x8430F0", VA = "0x180843EF0")]
	[CompilerGenerated]
	private void FIFHIDBFHPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x1909B80", Offset = "0x1908D80", VA = "0x181909B80")]
	[CompilerGenerated]
	private void JKEFOMBCMKI()
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
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		[SerializeField]
		private string experimentName;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public string ExperimentName
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x8D4AB0", Offset = "0x8D3CB0", VA = "0x1808D4AB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public SerializedStatsigExperiment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class AJMFDOFEFJB : AAPEKDAMDII
{
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private const string EADFOKMPLMP = "GamePlatform";

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private const string GLLBEFLCLLH = "InteractionCategory";

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private const string NMELNLCFKGA = "JrActType";

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private const string NBGGFFLINPN = "IsDeveloper";

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private const string CJEALEHPHNB = "IsModerator";

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private const string MGEPHLEICFL = "IsMember";

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private const string AIOFEDKGOOB = "DaysSinceJoiningBucket";

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private const string LAMALFIAJIE = "AccountCreationTimeAfterEpochMilliseconds";

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private const string LJONCMFKEBB = "InGoodStanding";

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private const string JDFLDMKLAHJ = "FriendCount";

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private const string GJECBKOOOBJ = "LocaleName";

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly IReadOnlyDictionary<string, AEDOEAKAJCO> EMLJEBNPDEH;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private const int FBMIPDLJKJH = 5000;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private bool NKGBKHNHCID;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool GAIAFJLIGLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x844720", Offset = "0x843920", VA = "0x180844720", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action AJOHHGNNIFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6BF72D0", Offset = "0x6BF64D0", VA = "0x186BF72D0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6BF7630", Offset = "0x6BF6830", VA = "0x186BF7630", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action LHFPBDOGPLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6BF7C00", Offset = "0x6BF6E00", VA = "0x186BF7C00", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6BF7370", Offset = "0x6BF6570", VA = "0x186BF7370", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6BF7760", Offset = "0x6BF6960", VA = "0x186BF7760", Slot = "8")]
	public OOPPNGPPPLE OHLMLHJNBAL(string LBOLDEECDGO, string IKGFGLILKPG, [Optional] CGLJEOPFDFH LNEMGPDGNED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x6BF7140", Offset = "0x6BF6340", VA = "0x186BF7140", Slot = "16")]
	public OOPPNGPPPLE KIFJHPHHMFL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6BF7410", Offset = "0x6BF6610", VA = "0x186BF7410", Slot = "10")]
	public OOPPNGPPPLE MIKNAJJJFBO(CGLJEOPFDFH LNEMGPDGNED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x6BF6B80", Offset = "0x6BF5D80", VA = "0x186BF6B80", Slot = "11")]
	public OOPPNGPPPLE GCICMAEEEDA(CGLJEOPFDFH LNEMGPDGNED, Dictionary<string, string> PMFECKINGON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6BF6440", Offset = "0x6BF5640", VA = "0x186BF6440", Slot = "12")]
	public bool DHIOCCONEPE(string LFGCPOBHCCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x6BF6E70", Offset = "0x6BF6070", VA = "0x186BF6E70", Slot = "13")]
	public NBDAHHFHDNB GDEOGOPJALG(string KBINMOKHNND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6BF7080", Offset = "0x6BF6280", VA = "0x186BF7080", Slot = "14")]
	public BJJAEDHBOHP KEDHPBEMOID(string OHLGACKEDIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6BF6F90", Offset = "0x6BF6190", VA = "0x186BF6F90", Slot = "15")]
	public NBDAHHFHDNB GDHAGPINEDE(string KLOFDDLECFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6BF6580", Offset = "0x6BF5780", VA = "0x186BF6580")]
	private FBCIPGOFCFP FBBFPBHMOGG(CGLJEOPFDFH LNEMGPDGNED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6BF6070", Offset = "0x6BF5270", VA = "0x186BF6070")]
	private AFOKEELKKLC BJMKANEDDAJ(string IKGFGLILKPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6BF6210", Offset = "0x6BF5410", VA = "0x186BF6210")]
	private void CFPCPBIGIPH(string KBINMOKHNND, NBDAHHFHDNB PEPOGGMJFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6BF7DD0", Offset = "0x6BF6FD0", VA = "0x186BF7DD0")]
	public AJMFDOFEFJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x189C950", Offset = "0x189BB50", VA = "0x18189C950")]
	[CompilerGenerated]
	private void CABOGNAALBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6BF76D0", Offset = "0x6BF68D0", VA = "0x186BF76D0")]
	[CompilerGenerated]
	private void OBMEBAFCPFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6BF64F0", Offset = "0x6BF56F0", VA = "0x186BF64F0")]
	[CompilerGenerated]
	private void ENCFBDBIIGN()
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
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		[SerializeField]
		private string experimentName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		[SerializeField]
		private string parameterName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		[SerializeField]
		private string parameterValue;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public string ExperimentName
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x8D4AB0", Offset = "0x8D3CB0", VA = "0x1808D4AB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x8D7C00", Offset = "0x8D6E00", VA = "0x1808D7C00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6C03C10", Offset = "0x6C02E10", VA = "0x186C03C10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface AAPEKDAMDII
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	bool GAIAFJLIGLP
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action AJOHHGNNIFC;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action LHFPBDOGPLP;

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	OOPPNGPPPLE OHLMLHJNBAL(string LBOLDEECDGO, string IKGFGLILKPG, [Optional] CGLJEOPFDFH LNEMGPDGNED);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	OOPPNGPPPLE MIKNAJJJFBO(CGLJEOPFDFH LNEMGPDGNED);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "7")]
	OOPPNGPPPLE GCICMAEEEDA(CGLJEOPFDFH LNEMGPDGNED, Dictionary<string, string> PMFECKINGON);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool DHIOCCONEPE(string LFGCPOBHCCE);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "9")]
	NBDAHHFHDNB GDEOGOPJALG(string KBINMOKHNND);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "10")]
	BJJAEDHBOHP KEDHPBEMOID(string OHLGACKEDIA);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NBDAHHFHDNB GDHAGPINEDE(string KLOFDDLECFE);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "12")]
	OOPPNGPPPLE KIFJHPHHMFL();
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class CFJADMGNDLK : AAPEKDAMDII
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool GAIAFJLIGLP
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x844770", Offset = "0x843970", VA = "0x180844770", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action AJOHHGNNIFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6BFE850", Offset = "0x6BFDA50", VA = "0x186BFE850", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x6BFEA30", Offset = "0x6BFDC30", VA = "0x186BFEA30", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action LHFPBDOGPLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x6BFEB70", Offset = "0x6BFDD70", VA = "0x186BFEB70", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6BFE8F0", Offset = "0x6BFDAF0", VA = "0x186BFE8F0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6BFEAD0", Offset = "0x6BFDCD0", VA = "0x186BFEAD0", Slot = "8")]
	public OOPPNGPPPLE OHLMLHJNBAL(string LBOLDEECDGO, string IKGFGLILKPG, [Optional] CGLJEOPFDFH LNEMGPDGNED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6BFE990", Offset = "0x6BFDB90", VA = "0x186BFE990", Slot = "10")]
	public OOPPNGPPPLE MIKNAJJJFBO(CGLJEOPFDFH LNEMGPDGNED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6BFE6F0", Offset = "0x6BFD8F0", VA = "0x186BFE6F0", Slot = "11")]
	public OOPPNGPPPLE GCICMAEEEDA(CGLJEOPFDFH LNEMGPDGNED, Dictionary<string, string> PMFECKINGON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x844710", Offset = "0x843910", VA = "0x180844710", Slot = "12")]
	public bool DHIOCCONEPE(string LFGCPOBHCCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6BFE790", Offset = "0x6BFD990", VA = "0x186BFE790", Slot = "13")]
	public NBDAHHFHDNB GDEOGOPJALG(string KBINMOKHNND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6BFE7A0", Offset = "0x6BFD9A0", VA = "0x186BFE7A0", Slot = "14")]
	public BJJAEDHBOHP KEDHPBEMOID(string OHLGACKEDIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6BFE790", Offset = "0x6BFD990", VA = "0x186BFE790", Slot = "15")]
	public NBDAHHFHDNB GDHAGPINEDE(string KLOFDDLECFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6BFE7B0", Offset = "0x6BFD9B0", VA = "0x186BFE7B0", Slot = "16")]
	public OOPPNGPPPLE KIFJHPHHMFL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
	public CFJADMGNDLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface CGLJEOPFDFH
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	bool KMPOIMNBDLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	bool PBDIAKBJPOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	bool PHGEJGHKBLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	bool EHIBAIPCLLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool? HOHHKMCLOFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	int? COKBHNEMHNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	int BJHODCPDFAM
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	string JPPJGGACNGN
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	string AABJFJNOFGM
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	string JNIHNLNBJAI
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	string EDPPECHJBEK
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	string OLLBNOLOPKK
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	string DIIONIEAAID
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	double AOIPNJMAGPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface OOJDFGKDNMH
{
	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	long OLDLDAICNJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "1")]
	long PKOPGANKAHF();

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DCOBCJJNKMJ(long FIACEINHMCI, bool EDFDKFLDOAD = true);

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BKHOLGLLKHB(string APPLJOFCBIB, string CNPABJHOKBM, string GGDOJNHNDKP);

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IIMPMBPNKND(string APPLJOFCBIB);

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JGMDHCFJBKB(string APPLJOFCBIB, string DGPIADEEKHM, string FOMLPLECACF);

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FKGKCNHBOEH(string ABEFDBJEOBE, object JPALLJOMPKN, object DEOBALHAKHI);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface ALOBLDMKFCB
{
	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OEMJGAMJFGP OEKPKLJHGKO(string OOLICJGFLDH);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class CGEPNPBBKEG
{
	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
	public CGEPNPBBKEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x892120", Offset = "0x891320", VA = "0x180892120")]
	public static string AADLLEBJPEC(byte[] MJAMHAEGDEA, byte[] ELNJHIHGPEE)
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

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
		[Cpp2IlInjected.Address(RVA = "0x956600", Offset = "0x954C00", VA = "0x180956600")]
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
		[Cpp2IlInjected.Address(RVA = "0x6B8E4B0", Offset = "0x6B8CAB0", VA = "0x186B8E4B0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xBD9AB0", Offset = "0xBD80B0", VA = "0x180BD9AB0")]
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
		[Cpp2IlInjected.Address(RVA = "0xEA93B0", Offset = "0xEA79B0", VA = "0x180EA93B0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class COFFCPKHKBO
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public const string LAFHJHCIGNO = "batch";

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public const string GCGPMALCFIG = "type";

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public const string MHDLICCCBKE = "identify";

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public const string LOGKJECLCNC = "track";

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public const string DPPMGIOGCDI = "userId";

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public const string LBNPEJHAHOA = "anonymousId";

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public const string EDEEECBLPBE = "stable_id";

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public const string LJHIEJPMFHF = "messageId";

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public const string LHHFLDJPKGL = "event";

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public const string AGECPPLPCLM = "version";

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public const string LFJAPGKICIE = "locale";

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public const string HKBABLFPILJ = "name";

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public const string PDHEHAIKHPP = "properties";

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public const string FMGHEEKIKOH = "traits";

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public const string GNAPIKCBDAA = "context";

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public const string HHKADCNJAHH = "app";

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public const string HGJMFGFOEJM = "os";

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public const string PGBBDAOMKJK = "device";

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public const string BLNAPJJGBCD = "originalTimestamp";

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public const string GGMFDKKFEDF = "brand";

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public const string CHEEJGCCFEF = "manufacturer";

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public const string IHALLOHAAAH = "model";

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public const string HOMOKJKDILB = "type";

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
	public COFFCPKHKBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class HKOAPADKILE
{
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public const int OGFKHFNNHIM = 2;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public const int FJNAGFGALHE = 100;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public const int CCABMBEEINO = 1000;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public const long MBDJCIFMCHH = 1800000L;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public const int OOIMFOLKHIH = 1024;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public const int EDFCPFOELHG = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public const string PEFOFPGHIBE = "amplitude_sequence_number";

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public const string JLHDODPHFNF = "amplitude_user_id";

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public const string EKNENGPLPGB = "amplitude_last_time";

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public const string PKFODFGBKAJ = "initialize_analytics";

	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public const string OFLOGHIMFFB = "session_start";

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public const string KLBNPCIJDPM = "session_end";

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public const string NDJPDACAEON = "insert_id";

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public const string KKLPGAOFJPI = "event_time";

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public const string NJBPLPCGEPA = "session_id";

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public const string LPAAPJLHLFC = "session_tracking_data";

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public const string EIECHAFAMDE = "user_properties";

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public const string MFHPPOMDJOK = "app_version";

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public const string NOGHNNLAPJM = "ip";

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public const string BJBCEKGJBMJ = "language";

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public const string EDEEECBLPBE = "stable_id";

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public const string HPOCMDBFGEN = "client_launcher";

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public const string MCAFBDBIJKN = "platform";

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public const string IGIHCPHGICB = "os_name";

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public const string DPHKFKLKKJD = "os_version";

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public const string OPIMMDILLAM = "device_brand";

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public const string FFNLKNHBDNP = "device_manufacturer";

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public const string KLPPLGGLOMB = "device_model";

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public const string CBHCBKHPIGB = "device_type";

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public const string BHKMOBKPGKH = "price";

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public const string AKKMBNLIFDF = "quantity";

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public const string OACODDGHHJF = "revenue";

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public const string ILHNBJGEMJG = "productId";

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public const string ODOAFFMGMOI = "revenueType";

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public const string IOEAJDKMCDM = "event_type";

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public const string DPPMGIOGCDI = "user_id";

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public const string AHHAFGHAJCL = "event_properties";

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public const int IHOGHEIPALK = 10;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> CIOHOPGMEHE;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6B8C2D0", Offset = "0x6B8A8D0", VA = "0x186B8C2D0")]
	internal static bool GJIAHHPDLGN(string NAJDAPHOGEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
	public HKOAPADKILE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface DDNLDFENGDL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool BBPFBAKAJHM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string MOMKDOHCGEM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	string KGNGMDIPEEI
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	string FMFEJHJAFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	string LMCGBEBHJHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "5")]
	LEKACFEIBBA<LDPHOJDFIFA> IKEGDDABGKL(string EEGJJKOBBNO, Dictionary<string, string> KJHILFPLGAK, bool AEFHPMGNIIG = false);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "6")]
	LEKACFEIBBA<LDPHOJDFIFA> EAEOJAGHCLG(string EEGJJKOBBNO, string AADEPFOAFPG, string IHINKGPHPOI, string JEOBCHDMPCI);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct LDPHOJDFIFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly int NGNBEBOFBKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly string ONGFDNIMAEF;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0xC3D540", Offset = "0xC3BB40", VA = "0x180C3D540")]
	public LDPHOJDFIFA(int FPLLLKGKGOE, string BMBDECKAOAC)
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
		public AmplitudeAnalyticsClient.Settings HAMGBLAOLFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xA46F90", Offset = "0xA45590", VA = "0x180A46F90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool AFCLIIKGCBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x11C1710", Offset = "0x11BFD10", VA = "0x1811C1710")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x996120", Offset = "0x994720", VA = "0x180996120")]
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
			[Cpp2IlInjected.Address(RVA = "0x6B88E90", Offset = "0x6B87490", VA = "0x186B88E90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6B88F60", Offset = "0x6B87560", VA = "0x186B88F60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static string StableId
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6B88ED0", Offset = "0x6B874D0", VA = "0x186B88ED0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6B88FB0", Offset = "0x6B875B0", VA = "0x186B88FB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static string ClientLauncher
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6B88E50", Offset = "0x6B87450", VA = "0x186B88E50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6B88F10", Offset = "0x6B87510", VA = "0x186B88F10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x9259D0", Offset = "0x923FD0", VA = "0x1809259D0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6B88B80", Offset = "0x6B87180", VA = "0x186B88B80")]
		public static MIMFLODMING PJDMJLOGMBM(string BOBBHCFAPPK, [NotNull] string PJPCMAKJPGI, long CHGJJNNNLMM, long NBIAFLEKLLG, string NFGHEACKCPE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6B88A80", Offset = "0x6B87080", VA = "0x186B88A80")]
		public static MIMFLODMING NMJGGFKIHML(string BOBBHCFAPPK, [NotNull] string PJPCMAKJPGI, long CHGJJNNNLMM, long NBIAFLEKLLG, string NFGHEACKCPE, long KDMBFALEPHK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6B88C70", Offset = "0x6B87270", VA = "0x186B88C70")]
		private AmplitudeAnalyticsEvent(string BOBBHCFAPPK, [NotNull] string PJPCMAKJPGI, long CHGJJNNNLMM, long NBIAFLEKLLG, string NFGHEACKCPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x13F1E20", Offset = "0x13F0420", VA = "0x1813F1E20")]
		public void GLCELCOOLCB(long IDGKDKBFAMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6B88990", Offset = "0x6B86F90", VA = "0x186B88990", Slot = "5")]
		public override void IGHGHJEGAFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6B883F0", Offset = "0x6B869F0", VA = "0x186B883F0", Slot = "6")]
		public override void DKGBFEGFMIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6B88550", Offset = "0x6B86B50", VA = "0x186B88550", Slot = "4")]
		protected override Dictionary<string, object> GOMICFMPOIB(Dictionary<string, object> OKDGKGPLKOJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6B882E0", Offset = "0x6B868E0", VA = "0x186B882E0")]
		private void AIGKFJCBDPM(string NAJDAPHOGEH, string FEBHELIDNED, bool IHNJLGJKLLF = false)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class NLOEOANIPMB : GOOOOJOPOGA<AmplitudeAnalyticsIdentifyMessage, NLOEOANIPMB>
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override NLOEOANIPMB BAIABHOKINB
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xBEBDE0", Offset = "0xBEA3E0", VA = "0x180BEBDE0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x9584E0", Offset = "0x956AE0", VA = "0x1809584E0", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage ABOFDBEGCCJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6B8E460", Offset = "0x6B8CA60", VA = "0x186B8E460")]
	public NLOEOANIPMB(AmplitudeAnalyticsIdentifyMessage JIEHBANCLJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6B8E3F0", Offset = "0x6B8C9F0", VA = "0x186B8E3F0", Slot = "4")]
	public override void DKGBFEGFMIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class MIMFLODMING : GOOOOJOPOGA<AmplitudeAnalyticsEvent, MIMFLODMING>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private bool KIAINBEIMKG;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override MIMFLODMING BAIABHOKINB
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xBEBDE0", Offset = "0xBEA3E0", VA = "0x180BEBDE0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public long KJOCMEKPJGD
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6B8DFA0", Offset = "0x6B8C5A0", VA = "0x186B8DFA0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6B89E50", Offset = "0x6B88450", VA = "0x186B89E50")]
	public MIMFLODMING(AmplitudeAnalyticsEvent JIEHBANCLJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x9584E0", Offset = "0x956AE0", VA = "0x1809584E0", Slot = "5")]
	public override AmplitudeAnalyticsEvent ABOFDBEGCCJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6B8DE60", Offset = "0x6B8C460", VA = "0x186B8DE60", Slot = "4")]
	public override void DKGBFEGFMIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6B8DA40", Offset = "0x6B8C040", VA = "0x186B8DA40")]
	public MIMFLODMING DDDFFGMMCLG(string OMEMEFEKGAP, long[] FEBHELIDNED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6B8DCA0", Offset = "0x6B8C2A0", VA = "0x186B8DCA0")]
	public MIMFLODMING DDDFFGMMCLG(string OMEMEFEKGAP, ulong[] FEBHELIDNED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x1788530", Offset = "0x1786B30", VA = "0x181788530")]
	public MIMFLODMING DDDFFGMMCLG<T>(string OMEMEFEKGAP, T[] FEBHELIDNED) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6B8DE50", Offset = "0x6B8C450", VA = "0x186B8DE50")]
	public MIMFLODMING DDDFFGMMCLG(string OMEMEFEKGAP, string[] FEBHELIDNED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x17884C0", Offset = "0x1786AC0", VA = "0x1817884C0")]
	public MIMFLODMING DDDFFGMMCLG<T>(string OMEMEFEKGAP, T FEBHELIDNED) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6B8DC10", Offset = "0x6B8C210", VA = "0x186B8DC10")]
	public MIMFLODMING DDDFFGMMCLG(string OMEMEFEKGAP, long FEBHELIDNED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6B8DB80", Offset = "0x6B8C180", VA = "0x186B8DB80")]
	public MIMFLODMING DDDFFGMMCLG(string OMEMEFEKGAP, ulong FEBHELIDNED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6B8DDE0", Offset = "0x6B8C3E0", VA = "0x186B8DDE0")]
	public MIMFLODMING DDDFFGMMCLG(string OMEMEFEKGAP, string FEBHELIDNED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6B8DA10", Offset = "0x6B8C010", VA = "0x186B8DA10")]
	public MIMFLODMING CNPBJPLMBBE(string OMEMEFEKGAP, object? FEBHELIDNED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6B8DF00", Offset = "0x6B8C500", VA = "0x186B8DF00")]
	public MIMFLODMING JOCCHKNKDPB(string OMEMEFEKGAP, string FEBHELIDNED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6B8DFC0", Offset = "0x6B8C5C0", VA = "0x186B8DFC0")]
	private MIMFLODMING PBHDEJOMFNO(string OMEMEFEKGAP, object FEBHELIDNED)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class DABABNJINGO : MIMFLODMING
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6B89E50", Offset = "0x6B88450", VA = "0x186B89E50")]
	public DABABNJINGO(AmplitudeAnalyticsEvent JIEHBANCLJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6B89CC0", Offset = "0x6B882C0", VA = "0x186B89CC0", Slot = "4")]
	public override void DKGBFEGFMIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class GOOOOJOPOGA<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : GOOOOJOPOGA<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	protected M JIEHBANCLJP;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public abstract BLDR BAIABHOKINB
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x15BDFA0", Offset = "0x15BC5A0", VA = "0x1815BDFA0")]
	public GOOOOJOPOGA(M JIEHBANCLJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3D9CC30", Offset = "0x3D9B230", VA = "0x183D9CC30")]
	public BLDR AMMEBGDHPHC(AmplitudeAnalyticsIdentifyMessage.DeviceInfo DOOGKOPPHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3D9CCA0", Offset = "0x3D9B2A0", VA = "0x183D9CCA0")]
	public BLDR IPAOIKOJBLG(AmplitudeAnalyticsIdentifyMessage.RevenueData ILHEHJFJKHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3D9CA60", Offset = "0x3D9B060", VA = "0x183D9CA60")]
	public BLDR AHKEAJPJKND(string OMEMEFEKGAP, string FEBHELIDNED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x1991F40", Offset = "0x1990540", VA = "0x181991F40")]
	public BLDR AHKEAJPJKND<T>(string OMEMEFEKGAP, T FEBHELIDNED) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3D9CB80", Offset = "0x3D9B180", VA = "0x183D9CB80")]
	public BLDR AHKEAJPJKND(string OMEMEFEKGAP, long FEBHELIDNED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3D9CAD0", Offset = "0x3D9B0D0", VA = "0x183D9CAD0")]
	public BLDR AHKEAJPJKND(string OMEMEFEKGAP, ulong FEBHELIDNED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void DKGBFEGFMIL();

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3D9CC70", Offset = "0x3D9B270", VA = "0x183D9CC70")]
	internal static string AOBNOMLBKGL(string FEBHELIDNED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3D9CCE0", Offset = "0x3D9B2E0", VA = "0x183D9CCE0")]
	private BLDR NLKBHBBAIFB(string OMEMEFEKGAP, object FEBHELIDNED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M ABOFDBEGCCJ();
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
			[Cpp2IlInjected.Address(RVA = "0x6B8BC30", Offset = "0x6B8A230", VA = "0x186B8BC30")]
			public void COODHFBEPON(Dictionary<string, object> NCALHDOGEAF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
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
			[Cpp2IlInjected.Address(RVA = "0x6B90470", Offset = "0x6B8EA70", VA = "0x186B90470")]
			public void COODHFBEPON(Dictionary<string, object> MINLHNNPJCI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6B905E0", Offset = "0x6B8EBE0", VA = "0x186B905E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x86D400", Offset = "0x86BA00", VA = "0x18086D400")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x943F50", Offset = "0x942550", VA = "0x180943F50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6B89590", Offset = "0x6B87B90", VA = "0x186B89590")]
		public static NLOEOANIPMB PJDMJLOGMBM(string BOBBHCFAPPK, string NFGHEACKCPE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6B89640", Offset = "0x6B87C40", VA = "0x186B89640")]
		protected AmplitudeAnalyticsIdentifyMessage(string BOBBHCFAPPK, string NFGHEACKCPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6B89510", Offset = "0x6B87B10", VA = "0x186B89510")]
		public Dictionary<string, object> PFGAGGHCIPE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6B89170", Offset = "0x6B87770", VA = "0x186B89170", Slot = "4")]
		protected virtual Dictionary<string, object> GOMICFMPOIB(Dictionary<string, object> OKDGKGPLKOJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6B890C0", Offset = "0x6B876C0", VA = "0x186B890C0")]
		protected void FDDOFNEPFDE(string NAJDAPHOGEH, Dictionary<string, object> PJPBPDKFFND, Dictionary<string, object> IMPHEMMKJOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6B89000", Offset = "0x6B87600", VA = "0x186B89000")]
		protected void AOKPAFGIGAJ(string NAJDAPHOGEH, string FEBHELIDNED, Dictionary<string, object> JCCEJGOBBKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6B894B0", Offset = "0x6B87AB0", VA = "0x186B894B0", Slot = "5")]
		public virtual void IGHGHJEGAFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6B89070", Offset = "0x6B87670", VA = "0x186B89070", Slot = "6")]
		public virtual void DKGBFEGFMIL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		private enum CBJJGEJDKDE
		{
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		internal class OFFFOEKLALE
		{
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			private class OALEBCCHGIA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000A1")]
				public int ADFLODHCJEC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000A2")]
				public Dictionary<string, object> FFBIHOOPGJL;

				[Cpp2IlInjected.Token(Token = "0x60000A0")]
				[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
				public OALEBCCHGIA()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000017")]
			[CompilerGenerated]
			private sealed class APHDEOOFIDM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000A3")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x60000A1")]
				[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
				public APHDEOOFIDM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000A2")]
				[Cpp2IlInjected.Address(RVA = "0x6B83570", Offset = "0x6B81B70", VA = "0x186B83570")]
				internal bool MAELOFFBBFB(OALEBCCHGIA item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400009E")]
			private const string NDKHJLEMGAI = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			private readonly string PCCHHIAICLC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			private List<OALEBCCHGIA> GGLADOMDHDD;

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public int? DCPGLMOEDOB
			{
				[Cpp2IlInjected.Token(Token = "0x6000094")]
				[Cpp2IlInjected.Address(RVA = "0x6B8F7B0", Offset = "0x6B8DDB0", VA = "0x186B8F7B0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public int? ELDFPOJEIAA
			{
				[Cpp2IlInjected.Token(Token = "0x6000095")]
				[Cpp2IlInjected.Address(RVA = "0x6B8EEA0", Offset = "0x6B8D4A0", VA = "0x186B8EEA0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x6B902E0", Offset = "0x6B8E8E0", VA = "0x186B902E0")]
			internal OFFFOEKLALE(string CCNCNNOBMNC, string LPPEEEFJAPG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x6B8FD40", Offset = "0x6B8E340", VA = "0x186B8FD40")]
			public int JGNGKLIIMEM([Optional] int? PJNBPEPOEDH)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x6B8FAA0", Offset = "0x6B8E0A0", VA = "0x186B8FAA0")]
			public List<Dictionary<string, object>> IHMBNFONNFD(int GNHCMAMFNPK, int? PJNBPEPOEDH)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x6B8FFD0", Offset = "0x6B8E5D0", VA = "0x186B8FFD0")]
			public void LCNDFFNKNIO(AmplitudeAnalyticsIdentifyMessage IAMEECMGPIF, bool NBNHNPNFCMM = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x6B8FEC0", Offset = "0x6B8E4C0", VA = "0x186B8FEC0")]
			public void LCNDFFNKNIO(Dictionary<string, object> IAMEECMGPIF, bool NBNHNPNFCMM = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x6B8F620", Offset = "0x6B8DC20", VA = "0x186B8F620")]
			public void CIIHMHDHBJN(params Dictionary<string, object>[] FPIAJGJHPDF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x6B8F850", Offset = "0x6B8DE50", VA = "0x186B8F850")]
			public void FKBJDFFLENN(List<Dictionary<string, object>> DFBLEOEOCGH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x6B90070", Offset = "0x6B8E670", VA = "0x186B90070")]
			private void LLANEPNDNOI(Dictionary<string, object> IAMEECMGPIF, bool NBNHNPNFCMM = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x6B8EF60", Offset = "0x6B8D560", VA = "0x186B8EF60")]
			public void BHLKKJHDAAA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x6B8F1D0", Offset = "0x6B8D7D0", VA = "0x186B8F1D0")]
			private void BOPPDCPBDFC([Optional] string EAABNHLCFED)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x6B901B0", Offset = "0x6B8E7B0", VA = "0x186B901B0")]
			private static string PPMLEEIGBIG(string FEBHELIDNED, string NAJDAPHOGEH)
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
			[Cpp2IlInjected.Address(RVA = "0x6B90840", Offset = "0x6B8EE40", VA = "0x186B90840")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public struct PDIENHJLJJJ<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public int FPLLLKGKGOE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			public string BMBDECKAOAC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public T NHFNAJOEABI;
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class KHDJJDMDLKF : IEnumerator<NGCINEPJDAB>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			private NGCINEPJDAB <>2__current;

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
			private NGCINEPJDAB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000AC")]
				[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x9E6400", Offset = "0x9E4A00", VA = "0x1809E6400")]
			[DebuggerHidden]
			public KHDJJDMDLKF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x6B8C5E0", Offset = "0x6B8ABE0", VA = "0x186B8C5E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x6B8CC80", Offset = "0x6B8B280", VA = "0x186B8CC80", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class HOKAHCNOHHK : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public MDOIJNHMNCN quitCompletePromise;

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
				[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x9E6400", Offset = "0x9E4A00", VA = "0x1809E6400")]
			[DebuggerHidden]
			public HOKAHCNOHHK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x6B8C480", Offset = "0x6B8AA80", VA = "0x186B8C480", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x6B8C5A0", Offset = "0x6B8ABA0", VA = "0x186B8C5A0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class CPEMICHMNIM : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x9E6400", Offset = "0x9E4A00", VA = "0x1809E6400")]
			[DebuggerHidden]
			public CPEMICHMNIM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x6B89740", Offset = "0x6B87D40", VA = "0x186B89740", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x6B898D0", Offset = "0x6B87ED0", VA = "0x186B898D0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class CPGEPIHNFAL : IEnumerator<NGCINEPJDAB>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private NGCINEPJDAB <>2__current;

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
			private OFFFOEKLALE <cache>5__2;

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
			private NGCINEPJDAB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000BE")]
				[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x9E6400", Offset = "0x9E4A00", VA = "0x1809E6400")]
			[DebuggerHidden]
			public CPGEPIHNFAL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x6B89910", Offset = "0x6B87F10", VA = "0x186B89910", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x6B89C80", Offset = "0x6B88280", VA = "0x186B89C80", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class MNBDAOPAJOJ : IEnumerator<NGCINEPJDAB>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			private NGCINEPJDAB <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public float timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			private OFFFOEKLALE <cache>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			private string <url>5__2;

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			private NGCINEPJDAB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000C7")]
				[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x9E6400", Offset = "0x9E4A00", VA = "0x1809E6400")]
			[DebuggerHidden]
			public MNBDAOPAJOJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x6B8E0C0", Offset = "0x6B8C6C0", VA = "0x186B8E0C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x6B8E3B0", Offset = "0x6B8C9B0", VA = "0x186B8E3B0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[CompilerGenerated]
		private sealed class LHJFKCKJAPC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public List<Dictionary<string, object>> batch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public OFFFOEKLALE cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
			public LHJFKCKJAPC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x6B8D160", Offset = "0x6B8B760", VA = "0x186B8D160")]
			internal void PALFLJFIECD(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x6B8CCC0", Offset = "0x6B8B2C0", VA = "0x186B8CCC0")]
			internal void GPCJFLKGJAG(PDIENHJLJJJ<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class OAJIPPAKCKI : IEnumerator<NGCINEPJDAB>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			private NGCINEPJDAB <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public OFFFOEKLALE cache;

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
			private LHJFKCKJAPC <>8__1;

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
			private NGCINEPJDAB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000D0")]
				[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x9E6400", Offset = "0x9E4A00", VA = "0x1809E6400")]
			[DebuggerHidden]
			public OAJIPPAKCKI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x6B8E540", Offset = "0x6B8CB40", VA = "0x186B8E540", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x6B8EE60", Offset = "0x6B8D460", VA = "0x186B8EE60", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private sealed class PNLDKDBMJHP<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x97F990", Offset = "0x97DF90", VA = "0x18097F990")]
			public PNLDKDBMJHP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x1EEEA60", Offset = "0x1EED060", VA = "0x181EEEA60")]
			internal PDIENHJLJJJ<T> FMEKJIMKIPP(LDPHOJDFIFA postResponse)
			{
				return default(PDIENHJLJJJ<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class FDMBJHHKBNM<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x97F990", Offset = "0x97DF90", VA = "0x18097F990")]
			public FDMBJHHKBNM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x1EEEA60", Offset = "0x1EED060", VA = "0x181EEEA60")]
			internal PDIENHJLJJJ<T> CBPOAJDLJJA(LDPHOJDFIFA postResponse)
			{
				return default(PDIENHJLJJJ<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private LCECFIIKLCN BGHPEJHMNJF;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private const string AKODFNJOPLK = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private const string CGGDKMEDDGM = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private const string PDAHLCFFKAL = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private const int OHOHEHCPNDD = 15;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private const int AHDHOLEIFNN = 10;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private const int LFGBHPCHILL = 5;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private const float AMFKEBDEDOH = 10f;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private const long HKEIBCPGBIN = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private const string INEMGFOJKAH = "f1779b982f1c09aed3adb3cca563cbc2";

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private const string PENMBKBHGNE = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static bool FIPLIOCJAGP;

		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private static bool POOLADFACEG;

		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private static int FCPIPNEPHCA;

		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private static int HNLHHNEKBGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private DDNLDFENGDL HNMNHPEFBAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private bool EOEKCGEJBMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private float LPGKKCEPPBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private float IKKIAOKPLKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int GFJBAHOKALN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int GNCFGBBKAGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private int? NDFDCANOOKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int? OGPBBHCJOLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private long FAFHJGBLBFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private string HJOFBEGFJKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private long CPAGMLKHCDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private Dictionary<string, object> JFODOFMGDJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private CBJJGEJDKDE JLGBPHNNOFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private int HNBKKDFJCHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private int OOEEPIBFKEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private float CAGMGACBHOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private bool GBPJFEBGLDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x89")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private bool CFBCOJCMEMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private OFFFOEKLALE BOOGENGCNGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private OFFFOEKLALE MOFGBJLHGDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private OFFFOEKLALE COJMLPFNBPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> DJHKMCGIIME;

		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo EMDJPIGHHEE;

		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private static string PEDCEKMKDEB;

		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private const string IMECPPNFIOA = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly string IPGPEDHDLCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly string GJHBABCHFKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly string MCNKHIPJCMM;

		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private LCECFIIKLCN OHDJGKMMBED
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6B84030", Offset = "0x6B82630", VA = "0x186B84030")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private static int JCAHMBHLPEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6B85C80", Offset = "0x6B84280", VA = "0x186B85C80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static long CPLCBJFHPCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x6B88180", Offset = "0x6B86780", VA = "0x186B88180")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x6B88280", Offset = "0x6B86880", VA = "0x186B88280")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static string NHDHLBJNABA
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x6B88120", Offset = "0x6B86720", VA = "0x186B88120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static string MJGBKOHMPPE
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x6B88150", Offset = "0x6B86750", VA = "0x186B88150")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public string FFJJFIHNDHD
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xA4C150", Offset = "0xA4A750", VA = "0x180A4C150")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xA4C300", Offset = "0xA4A900", VA = "0x180A4C300")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public int? PAMABPJPGOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x1244180", Offset = "0x1242780", VA = "0x181244180")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x2F59600", Offset = "0x2F57C00", VA = "0x182F59600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool IBGJGPILLAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x1387400", Offset = "0x1385A00", VA = "0x181387400")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x1383770", Offset = "0x1381D70", VA = "0x181383770")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public static bool PJLGCGGNKGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x6B88090", Offset = "0x6B86690", VA = "0x186B88090")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> PNGOAJODDCB
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x6B87FF0", Offset = "0x6B865F0", VA = "0x186B87FF0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x6B881E0", Offset = "0x6B867E0", VA = "0x186B881E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6B83810", Offset = "0x6B81E10", VA = "0x186B83810", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6B85970", Offset = "0x6B83F70", VA = "0x186B85970")]
		private void JDBAKEHCDFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6B87860", Offset = "0x6B85E60", VA = "0x186B87860")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6B86D90", Offset = "0x6B85390", VA = "0x186B86D90", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6B87B40", Offset = "0x6B86140", VA = "0x186B87B40")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6B87010", Offset = "0x6B85610", VA = "0x186B87010")]
		public ADCACBFKFKM PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6B85890", Offset = "0x6B83E90", VA = "0x186B85890")]
		[IteratorStateMachine(typeof(KHDJJDMDLKF))]
		public IEnumerator<NGCINEPJDAB> Initialize(AmplitudeAnalyticsEvent KIMNCHPEGGL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6B87A40", Offset = "0x6B86040", VA = "0x186B87A40")]
		public void UpdateLastAliveTime(float BAIPGDICONI = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6B86A10", Offset = "0x6B85010", VA = "0x186B86A10")]
		private ADCACBFKFKM OBKKEEOEHHP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6B86AE0", Offset = "0x6B850E0", VA = "0x186B86AE0")]
		private ADCACBFKFKM OEEJPOEOCCC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6B87460", Offset = "0x6B85A60", VA = "0x186B87460")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6B83E80", Offset = "0x6B82480", VA = "0x186B83E80")]
		[IteratorStateMachine(typeof(HOKAHCNOHHK))]
		private IEnumerator DADJKBECPJP(MDOIJNHMNCN OMMNOHODMPP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6B87DC0", Offset = "0x6B863C0", VA = "0x186B87DC0")]
		[IteratorStateMachine(typeof(CPEMICHMNIM))]
		public IEnumerator WaitForFlush(float FPFPGODCNAC = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6B87920", Offset = "0x6B85F20", VA = "0x186B87920")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6B87870", Offset = "0x6B85E70", VA = "0x186B87870")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime EKIGKJOOCNK)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6B85570", Offset = "0x6B83B70", VA = "0x186B85570")]
		public static NLOEOANIPMB Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6B836D0", Offset = "0x6B81CD0", VA = "0x186B836D0")]
		public static MIMFLODMING AccountSelectionPostLoginEvent([NotNull] string HMPIMBKLBOC, string NFGHEACKCPE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6B84120", Offset = "0x6B82720", VA = "0x186B84120")]
		public static MIMFLODMING Event([NotNull] string HMPIMBKLBOC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6B87070", Offset = "0x6B85670", VA = "0x186B87070")]
		public static MIMFLODMING PreviousSessionEvent([NotNull] string HMPIMBKLBOC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6B856A0", Offset = "0x6B83CA0", VA = "0x186B856A0")]
		public static MIMFLODMING InitializeEvent(string NFGHEACKCPE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6B875D0", Offset = "0x6B85BD0", VA = "0x186B875D0")]
		public static MIMFLODMING StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6B83BE0", Offset = "0x6B821E0", VA = "0x186B83BE0")]
		public static MIMFLODMING CreateOutOfSessionEvent(string HMPIMBKLBOC, bool HJKLIHPLPBB = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6B86390", Offset = "0x6B84990", VA = "0x186B86390")]
		public static ADCACBFKFKM LogOutOfSessionEvent(MIMFLODMING NIEHAOBOGJO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6B860F0", Offset = "0x6B846F0", VA = "0x186B860F0")]
		public void LogEventAsync(AmplitudeAnalyticsEvent BNBDEONIKGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6B86680", Offset = "0x6B84C80", VA = "0x186B86680")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent BNBDEONIKGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6B867D0", Offset = "0x6B84DD0", VA = "0x186B867D0")]
		public void LogSerializedEventAsync(Dictionary<string, object> JNCOHIEMFJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6B86240", Offset = "0x6B84840", VA = "0x186B86240")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage FIAPEFMNHAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6B84330", Offset = "0x6B82930", VA = "0x186B84330")]
		private void GBFDLBDHKJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6B85E50", Offset = "0x6B84450", VA = "0x186B85E50")]
		private void JOOJFBLNEBG(Dictionary<string, object> OBDGKOOMMEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6B835E0", Offset = "0x6B81BE0", VA = "0x186B835E0")]
		private void APIAMJCJDAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6B86E30", Offset = "0x6B85430", VA = "0x186B86E30")]
		private void PJKLFCIPJLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6B842A0", Offset = "0x6B828A0", VA = "0x186B842A0")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6B84420", Offset = "0x6B82A20", VA = "0x186B84420")]
		[IteratorStateMachine(typeof(CPGEPIHNFAL))]
		private IEnumerator<NGCINEPJDAB> IIGCCJGDFJO(float FPFPGODCNAC = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6B840A0", Offset = "0x6B826A0", VA = "0x186B840A0")]
		[IteratorStateMachine(typeof(MNBDAOPAJOJ))]
		private IEnumerator<NGCINEPJDAB> EPAHIEMLOJE(float FPFPGODCNAC = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6B83B00", Offset = "0x6B82100", VA = "0x186B83B00")]
		[IteratorStateMachine(typeof(OAJIPPAKCKI))]
		private IEnumerator<NGCINEPJDAB> CJDMCGMDGMD(OFFFOEKLALE FBKIEMHDLKB, int? PJNBPEPOEDH, string EEGJJKOBBNO, string GPLJLKFMJAA, float FPFPGODCNAC, Action<int> BJHFOMBLELO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6B83F10", Offset = "0x6B82510", VA = "0x186B83F10")]
		private static void EFJONMJLGPG(bool EGKPFKONEIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6B84770", Offset = "0x6B82D70", VA = "0x186B84770")]
		private LEKACFEIBBA<PDIENHJLJJJ<Dictionary<string, object>>> IKEGDDABGKL(string EEGJJKOBBNO, string GPLJLKFMJAA, string OFEHLOIAHGG, string MAFELKMCMND, Dictionary<string, object> NHFNAJOEABI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6B844A0", Offset = "0x6B82AA0", VA = "0x186B844A0")]
		private LEKACFEIBBA<PDIENHJLJJJ<List<Dictionary<string, object>>>> IKEGDDABGKL(string EEGJJKOBBNO, string GPLJLKFMJAA, string OFEHLOIAHGG, string MAFELKMCMND, List<Dictionary<string, object>> NHFNAJOEABI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x2B00320", Offset = "0x2AFE920", VA = "0x182B00320")]
		private LEKACFEIBBA<PDIENHJLJJJ<T>> JJLIGJBJKLD<T>(string EEGJJKOBBNO, string GPLJLKFMJAA, string MAFELKMCMND, T NHFNAJOEABI, Dictionary<string, object> IHCNNEIADLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x2AFFFE0", Offset = "0x2AFE5E0", VA = "0x182AFFFE0")]
		private LEKACFEIBBA<PDIENHJLJJJ<T>> DELPMIHFJGI<T>(string EEGJJKOBBNO, string GPLJLKFMJAA, string OFEHLOIAHGG, T NHFNAJOEABI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6B85920", Offset = "0x6B83F20", VA = "0x186B85920")]
		private bool JCEPPMCPICN(float BALBDAAMGGG, float FPFPGODCNAC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6B848A0", Offset = "0x6B82EA0", VA = "0x186B848A0")]
		private Dictionary<string, object> ILCKECMEANJ(string GPLJLKFMJAA, Dictionary<string, object> NHFNAJOEABI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6B87EA0", Offset = "0x6B864A0", VA = "0x186B87EA0")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6B868B0", Offset = "0x6B84EB0", VA = "0x186B868B0")]
		[CompilerGenerated]
		private long MPDMPHFIHIC()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6B835D0", Offset = "0x6B81BD0", VA = "0x186B835D0")]
		[CompilerGenerated]
		private void AJBKKHIACNP(int AOCNGPANPBN)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class MEFPIPDEADC
{
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private const string JGMIIJGJNIG = "timed_flow";

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private const string HDFELKPJBHI = "flowName";

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private const string IKGLAHOHIAC = "startedAt";

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private const string GGKBDLGBBAP = "endedAt";

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private const string NILGEGELPLH = "durationInSeconds";

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private const string JFFLAJFMHBA = "failure";

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private const string JBPPBPMDOJA = "failureMessage";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private long IEKANJNJEOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private MIMFLODMING MADGDLJMAKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private bool IDAIBAKLEBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private float JPIDPCIHCBL;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6B8D870", Offset = "0x6B8BE70", VA = "0x186B8D870")]
	public MEFPIPDEADC(string HJKAJEMOAIM, float JPIDPCIHCBL = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x23543D0", Offset = "0x23529D0", VA = "0x1823543D0")]
	public void DDDFFGMMCLG<T>(string OMEMEFEKGAP, T FEBHELIDNED) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6B8D4D0", Offset = "0x6B8BAD0", VA = "0x186B8D4D0")]
	public void DDDFFGMMCLG(string OMEMEFEKGAP, string FEBHELIDNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6B8D550", Offset = "0x6B8BB50", VA = "0x186B8D550")]
	public void FFNADKDCDII(string NABAMJICLIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6B8D7B0", Offset = "0x6B8BDB0", VA = "0x186B8D7B0")]
	public void OLPIPEADBGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6B8D690", Offset = "0x6B8BC90", VA = "0x186B8D690")]
	private void MAEAOGNGJIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6B8D640", Offset = "0x6B8BC40", VA = "0x186B8D640")]
	private bool KIGFJPBKLDJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public enum BNBCMPCOGPD
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
public class AHEEFEEIPNC : KADEJCMCOAK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private KADEJCMCOAK KLNPLDMJOKN;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private KADEJCMCOAK LIPHOMAOMMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6B83500", Offset = "0x6B81B00", VA = "0x186B83500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool AGOOCBLDBDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6B83070", Offset = "0x6B81670", VA = "0x186B83070", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action BKMGIILFDIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6B83270", Offset = "0x6B81870", VA = "0x186B83270", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6B82BB0", Offset = "0x6B811B0", VA = "0x186B82BB0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action LHNDOLIDGMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x6B831D0", Offset = "0x6B817D0", VA = "0x186B831D0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6B82A20", Offset = "0x6B81020", VA = "0x186B82A20", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
	[Preserve]
	public AHEEFEEIPNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6B83410", Offset = "0x6B81A10", VA = "0x186B83410")]
	[PJEDGFFEDPC(PDIHHCLCNFI.GameOnly)]
	private static void OFDCCEGIAJP(EIHIACACEHJ GEAGAOEEJFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x6B82D90", Offset = "0x6B81390", VA = "0x186B82D90", Slot = "8")]
	public ADCACBFKFKM KGHKJOCLFMF(string CKELOFKCFOO, string LPPEEEFJAPG, [Optional] HKGGGOJKKKA FGKBJKGANJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6B83310", Offset = "0x6B81910", VA = "0x186B83310", Slot = "10")]
	public ADCACBFKFKM OAPAOLDGGDP(HKGGGOJKKKA FGKBJKGANJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x6B830C0", Offset = "0x6B816C0", VA = "0x186B830C0", Slot = "11")]
	public ADCACBFKFKM LCDPGEEKABB(HKGGGOJKKKA FGKBJKGANJG, Dictionary<string, string> IABCAIDFNED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x6B82CF0", Offset = "0x6B812F0", VA = "0x186B82CF0", Slot = "12")]
	public bool KFOBNBHBNBO(string OBDMFFIDLDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x6B82C50", Offset = "0x6B81250", VA = "0x186B82C50", Slot = "13")]
	public FOBONJFDFNP INAHOOPMJJB(string BAGOHDOGKAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x6B82880", Offset = "0x6B80E80", VA = "0x186B82880", Slot = "14")]
	public GMCGFBLIADJ BFLOBJODAIC(string IDFDOFAIIIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x6B82980", Offset = "0x6B80F80", VA = "0x186B82980", Slot = "15")]
	public FOBONJFDFNP GEOGOIDPMLN(string KEBMBJPIEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x6B82AC0", Offset = "0x6B810C0", VA = "0x186B82AC0", Slot = "16")]
	public ADCACBFKFKM HFEGOOFBJOD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x950630", Offset = "0x94EC30", VA = "0x180950630")]
	[CompilerGenerated]
	private void MJBBDNEBFEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x94FF20", Offset = "0x94E520", VA = "0x18094FF20")]
	[CompilerGenerated]
	private void DKCELOEBBDB()
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
			[Cpp2IlInjected.Address(RVA = "0x86D400", Offset = "0x86BA00", VA = "0x18086D400")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public SerializedStatsigExperiment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class DIALLCFGOKN : KADEJCMCOAK
{
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private const string LNNAOLLGHKD = "GamePlatform";

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private const string JAJMKGPOOBH = "InteractionCategory";

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private const string KIKKKOPGPGC = "JrActType";

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private const string JKHEFPKNOAE = "IsDeveloper";

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private const string LCMHBMCDFMC = "IsModerator";

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private const string EMMHCBOCDDN = "IsMember";

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private const string BMGIJCIFGEK = "DaysSinceJoiningBucket";

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private const string AAEEIDCCOKP = "AccountCreationTimeAfterEpochMilliseconds";

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private const string DJPHCLLKMEC = "InGoodStanding";

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private const string DPLIBHANJFB = "FriendCount";

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private const string NLEJPIBJDCF = "LocaleName";

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private static readonly IReadOnlyDictionary<string, ALHJOEFLLHJ> MFPNODGPMGC;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private const int BFIKJLNNFGH = 5000;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private bool PMIAKOBNINN;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool AGOOCBLDBDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xA33AD0", Offset = "0xA320D0", VA = "0x180A33AD0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action BKMGIILFDIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6B8B5E0", Offset = "0x6B89BE0", VA = "0x186B8B5E0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6B8AA20", Offset = "0x6B89020", VA = "0x186B8AA20", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action LHNDOLIDGMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6B8B4B0", Offset = "0x6B89AB0", VA = "0x186B8B4B0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6B8A650", Offset = "0x6B88C50", VA = "0x186B8A650", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6B8AD20", Offset = "0x6B89320", VA = "0x186B8AD20", Slot = "8")]
	public ADCACBFKFKM KGHKJOCLFMF(string CKELOFKCFOO, string LPPEEEFJAPG, [Optional] HKGGGOJKKKA FGKBJKGANJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6B8A6F0", Offset = "0x6B88CF0", VA = "0x186B8A6F0", Slot = "16")]
	public ADCACBFKFKM HFEGOOFBJOD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x6B8B680", Offset = "0x6B89C80", VA = "0x186B8B680", Slot = "10")]
	public ADCACBFKFKM OAPAOLDGGDP(HKGGGOJKKKA FGKBJKGANJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6B8B1C0", Offset = "0x6B897C0", VA = "0x186B8B1C0", Slot = "11")]
	public ADCACBFKFKM LCDPGEEKABB(HKGGGOJKKKA FGKBJKGANJG, Dictionary<string, string> IABCAIDFNED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6B8AC70", Offset = "0x6B89270", VA = "0x186B8AC70", Slot = "12")]
	public bool KFOBNBHBNBO(string OBDMFFIDLDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6B8AAC0", Offset = "0x6B890C0", VA = "0x186B8AAC0", Slot = "13")]
	public FOBONJFDFNP INAHOOPMJJB(string BAGOHDOGKAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6B89EA0", Offset = "0x6B884A0", VA = "0x186B89EA0", Slot = "14")]
	public GMCGFBLIADJ BFLOBJODAIC(string IDFDOFAIIIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6B8A560", Offset = "0x6B88B60", VA = "0x186B8A560", Slot = "15")]
	public FOBONJFDFNP GEOGOIDPMLN(string KEBMBJPIEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6B89F60", Offset = "0x6B88560", VA = "0x186B89F60")]
	private CDJMGKCDICE BIFLHHGEKKE(HKGGGOJKKKA FGKBJKGANJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6B8A880", Offset = "0x6B88E80", VA = "0x186B8A880")]
	private KDBJBGJKDGN HGJPALKLEOB(string LPPEEEFJAPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6B8B8A0", Offset = "0x6B89EA0", VA = "0x186B8B8A0")]
	private void OOLACEHLJHP(string BAGOHDOGKAH, FOBONJFDFNP GKLJDKMPGML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6B8BC00", Offset = "0x6B8A200", VA = "0x186B8BC00")]
	public DIALLCFGOKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0xEE64E0", Offset = "0xEE4AE0", VA = "0x180EE64E0")]
	[CompilerGenerated]
	private void DJGIGHJICHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6B8B550", Offset = "0x6B89B50", VA = "0x186B8B550")]
	[CompilerGenerated]
	private void MGALKDMPDCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6B8ABE0", Offset = "0x6B891E0", VA = "0x186B8ABE0")]
	[CompilerGenerated]
	private void KAKJGMBCOCE()
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
			[Cpp2IlInjected.Address(RVA = "0x86D400", Offset = "0x86BA00", VA = "0x18086D400")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x86F2A0", Offset = "0x86D8A0", VA = "0x18086F2A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x6B905F0", Offset = "0x6B8EBF0", VA = "0x186B905F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface KADEJCMCOAK
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	bool AGOOCBLDBDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action BKMGIILFDIF;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action LHNDOLIDGMI;

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ADCACBFKFKM KGHKJOCLFMF(string CKELOFKCFOO, string LPPEEEFJAPG, [Optional] HKGGGOJKKKA FGKBJKGANJG);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "6")]
	ADCACBFKFKM OAPAOLDGGDP(HKGGGOJKKKA FGKBJKGANJG);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "7")]
	ADCACBFKFKM LCDPGEEKABB(HKGGGOJKKKA FGKBJKGANJG, Dictionary<string, string> IABCAIDFNED);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool KFOBNBHBNBO(string OBDMFFIDLDO);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "9")]
	FOBONJFDFNP INAHOOPMJJB(string BAGOHDOGKAH);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "10")]
	GMCGFBLIADJ BFLOBJODAIC(string IDFDOFAIIIO);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "11")]
	FOBONJFDFNP GEOGOIDPMLN(string KEBMBJPIEFJ);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "12")]
	ADCACBFKFKM HFEGOOFBJOD();
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class GOHFNPFFAEP : KADEJCMCOAK
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool AGOOCBLDBDE
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x9146D0", Offset = "0x912CD0", VA = "0x1809146D0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action BKMGIILFDIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6B8C190", Offset = "0x6B8A790", VA = "0x186B8C190", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x6B8BF10", Offset = "0x6B8A510", VA = "0x186B8BF10", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action LHNDOLIDGMI
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x6B8C0F0", Offset = "0x6B8A6F0", VA = "0x186B8C0F0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6B8BDD0", Offset = "0x6B8A3D0", VA = "0x186B8BDD0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6B8BFB0", Offset = "0x6B8A5B0", VA = "0x186B8BFB0", Slot = "8")]
	public ADCACBFKFKM KGHKJOCLFMF(string CKELOFKCFOO, string LPPEEEFJAPG, [Optional] HKGGGOJKKKA FGKBJKGANJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6B8C230", Offset = "0x6B8A830", VA = "0x186B8C230", Slot = "10")]
	public ADCACBFKFKM OAPAOLDGGDP(HKGGGOJKKKA FGKBJKGANJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6B8C050", Offset = "0x6B8A650", VA = "0x186B8C050", Slot = "11")]
	public ADCACBFKFKM LCDPGEEKABB(HKGGGOJKKKA FGKBJKGANJG, Dictionary<string, string> IABCAIDFNED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x915250", Offset = "0x913850", VA = "0x180915250", Slot = "12")]
	public bool KFOBNBHBNBO(string OBDMFFIDLDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6B8BDC0", Offset = "0x6B8A3C0", VA = "0x186B8BDC0", Slot = "13")]
	public FOBONJFDFNP INAHOOPMJJB(string BAGOHDOGKAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6B8BDB0", Offset = "0x6B8A3B0", VA = "0x186B8BDB0", Slot = "14")]
	public GMCGFBLIADJ BFLOBJODAIC(string IDFDOFAIIIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6B8BDC0", Offset = "0x6B8A3C0", VA = "0x186B8BDC0", Slot = "15")]
	public FOBONJFDFNP GEOGOIDPMLN(string KEBMBJPIEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6B8BE70", Offset = "0x6B8A470", VA = "0x186B8BE70", Slot = "16")]
	public ADCACBFKFKM HFEGOOFBJOD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
	public GOHFNPFFAEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface HKGGGOJKKKA
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	bool BHOPJLGIBKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	bool CJDCLCELGKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	bool DADNBHLKLND
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool KMCJMPCMKFL
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	bool? GPILAHPGILM
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	int? PAMABPJPGOH
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	int JDNMFNBIOLL
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	string KEAMOJKNPGO
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	string CBNOBCDHLJA
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	string KGDCNCIOMME
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	string OKPDHJCGBNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	string LAOPLCJKGHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	string KACGJBLGMMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	double CFAAONPFFPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface ACFDIFHKEAI
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	long CDFEHHEJBCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "1")]
	long CGDJJGEBKLB();

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KFGDKIMPNDN(long CHGJJNNNLMM, bool IHNJLGJKLLF = true);

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FPFDJEKJJFH(string JHAKINLMMJL, string AEOGHCFHGCK, string FNJNCCIMDJC);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LFFCOIDFGOJ(string JHAKINLMMJL);

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PMLCAHFDFDK(string JHAKINLMMJL, string ILNOJCIPLMA, string DKAHPDBPIKO);

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GFEABAACCAE(string PLKIEMDKNHI, object BLAKAJBOLBP, object DGJHGJNBCEO);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface DHPFNDDAEKC
{
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MEFPIPDEADC OMKAANJMMGJ(string HJKAJEMOAIM);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class IMLHFCPJGKL
{
	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
	public IMLHFCPJGKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD111C0", VA = "0x180D12BC0")]
	public static string GOMDFOEHABF(byte[] CEBGDHINIFO, byte[] FGJCLMKLDKK)
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

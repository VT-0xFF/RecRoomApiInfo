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
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80DE80", VA = "0x18080EA80")]
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
		[Cpp2IlInjected.Address(RVA = "0x6AC8CB0", Offset = "0x6AC80B0", VA = "0x186AC8CB0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x881BC0", Offset = "0x880FC0", VA = "0x180881BC0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD72FB0", Offset = "0xD723B0", VA = "0x180D72FB0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class GCBJCAICEKN
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public const string KHICEHMEGBM = "batch";

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public const string GFFAPNLCOFF = "type";

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public const string DCFNBCFNBLP = "identify";

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public const string GAPJEOFDCJK = "track";

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public const string MEHPJOICDPA = "userId";

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public const string KKAOBEBHNKE = "anonymousId";

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public const string AJALGLHFDLN = "stable_id";

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public const string JIIAPEAPAII = "messageId";

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public const string EJBACGHFBIJ = "event";

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public const string LKGDMOPKCPL = "version";

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public const string DBLMFOOCMDK = "locale";

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public const string HICNAHDHNEN = "name";

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public const string FGFAPAEDGEH = "properties";

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public const string PPELDLNAOOK = "traits";

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public const string FOJLPDDBKPB = "context";

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public const string HDFOJBCKMJO = "app";

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public const string HGDOHHDCJKN = "os";

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public const string KPEDFGKKFML = "device";

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public const string OLDEHELBCGH = "originalTimestamp";

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public const string EIEPPADGHGE = "brand";

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public const string FMFMFIGABFK = "manufacturer";

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public const string ICBBNJMNCCJ = "model";

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public const string MCAJCLJIKLJ = "type";

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
	public GCBJCAICEKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class OCHOPGKBLJK
{
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public const int NECFKLOAEMJ = 2;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public const int DOLILCMOAGE = 100;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public const int HFAMBFLMBIL = 1000;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public const long EEGOIGFJLKB = 1800000L;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public const int MKKFFLLEJOO = 1024;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public const int HJMEJBOABFM = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public const string EBLMLGDNDII = "amplitude_sequence_number";

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public const string GGJCFFMPIDD = "amplitude_user_id";

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public const string OPHONIBENIJ = "amplitude_last_time";

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public const string FJCEMLNIEDB = "initialize_analytics";

	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public const string JGIAMGPOOML = "session_start";

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public const string EFLGJHFHNDK = "session_end";

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public const string FCKLBICDIIG = "insert_id";

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public const string AADKAIBDEGG = "event_time";

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public const string NNFPPCLNBCI = "session_id";

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public const string KMIDLCMBMCL = "session_tracking_data";

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public const string BDAHDJBFPAF = "user_properties";

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public const string CJOJOAAEFGB = "app_version";

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public const string DBBFFPCELJB = "ip";

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public const string BHKGKKPHJDM = "language";

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public const string AJALGLHFDLN = "stable_id";

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public const string LJKJCCBHOPP = "platform";

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public const string DBNPEJBMDGP = "os_name";

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public const string KIHLOOCNLHE = "os_version";

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public const string AGJMGPDIPMD = "device_brand";

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public const string JBINCPLNJIM = "device_manufacturer";

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public const string KIMNNNNKGPB = "device_model";

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public const string CMMJMNJAJKB = "device_type";

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public const string ACFOILCDFBF = "price";

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public const string NDCAIBILAAB = "quantity";

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public const string MDIDKLGIJOP = "revenue";

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public const string OILNAEEGILL = "productId";

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public const string ODDGBDPOJOA = "revenueType";

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public const string DAOCPLEIAFJ = "event_type";

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public const string MEHPJOICDPA = "user_id";

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public const string OHAHLHPMFEH = "event_properties";

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public const int OOENNCBHNAK = 10;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> NBPOOIGAFAF;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6AC8D40", Offset = "0x6AC8140", VA = "0x186AC8D40")]
	internal static bool PEKJCLIBENK(string LOLIOKKJLEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
	public OCHOPGKBLJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface IGLNFOCNCED
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool BKGMFCJJNFK
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string PKLPGGANFIA
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	string FGBAMFBBHCE
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	string CNIHDKCLMJD
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	string EPNPPCEMBNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::CBFHNKNAJIN<ALNALBOHGNM> PDHJPDKAIEO(string LECPJCEBFIN, Dictionary<string, string> AJJMDONEGIF, bool NKBIAJKOEKO = false);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "6")]
	global::CBFHNKNAJIN<ALNALBOHGNM> NCGDDKCGENL(string LECPJCEBFIN, string FOJGKMJHHFO, string DHPLCGHKACD, string GAOFJJAPECF);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct ALNALBOHGNM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly int EKPJBIOPDGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly string FFELMEHCDMM;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x91E060", Offset = "0x91D460", VA = "0x18091E060")]
	public ALNALBOHGNM(int FHHNICKGPAJ, string NCLHCJHOFOM)
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
		public AmplitudeAnalyticsClient.Settings LAFNIAFKIIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x87B360", Offset = "0x87A760", VA = "0x18087B360")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool MHHLAPAGDFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xB1A650", Offset = "0xB19A50", VA = "0x180B1A650")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x94E2B0", Offset = "0x94D6B0", VA = "0x18094E2B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6AC2760", Offset = "0x6AC1B60", VA = "0x186AC2760")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6AC27E0", Offset = "0x6AC1BE0", VA = "0x186AC27E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static string StableId
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6AC27A0", Offset = "0x6AC1BA0", VA = "0x186AC27A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6AC2830", Offset = "0x6AC1C30", VA = "0x186AC2830")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x89ED20", Offset = "0x89E120", VA = "0x18089ED20")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6AC1EF0", Offset = "0x6AC12F0", VA = "0x186AC1EF0")]
		public static KDJMFICMHNK EDGHPEHNECD(string EGPHDEMHMDI, [NotNull] string JOMNHFIBFHK, long GGEIIAHFKKJ, long PBPMBNEHAIA, string NEDCFAMHCFG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6AC1C90", Offset = "0x6AC1090", VA = "0x186AC1C90")]
		public static KDJMFICMHNK BAJMOKILLPB(string EGPHDEMHMDI, [NotNull] string JOMNHFIBFHK, long GGEIIAHFKKJ, long PBPMBNEHAIA, string NEDCFAMHCFG, long CGHGGNLOENF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6AC2590", Offset = "0x6AC1990", VA = "0x186AC2590")]
		private AmplitudeAnalyticsEvent(string EGPHDEMHMDI, [NotNull] string JOMNHFIBFHK, long GGEIIAHFKKJ, long PBPMBNEHAIA, string NEDCFAMHCFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x89EBE0", Offset = "0x89DFE0", VA = "0x18089EBE0")]
		public void JBLHGOLEEHM(long FGFPDJIOAFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6AC24A0", Offset = "0x6AC18A0", VA = "0x186AC24A0", Slot = "5")]
		public override void LPIGCDDMIGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6AC1D90", Offset = "0x6AC1190", VA = "0x186AC1D90", Slot = "6")]
		public override void BBMEIIPGPMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6AC1FE0", Offset = "0x6AC13E0", VA = "0x186AC1FE0", Slot = "4")]
		protected override Dictionary<string, object> HDFINAPBNLG(Dictionary<string, object> JKFDCDDFLDB)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class CFMMJIGHNIL : global::CCAPIKJCILG<AmplitudeAnalyticsIdentifyMessage, CFMMJIGHNIL>
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override CFMMJIGHNIL NMCPFCGOILN
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x820230", Offset = "0x81F630", VA = "0x180820230", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x86EF30", Offset = "0x86E330", VA = "0x18086EF30", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage ENPINIIGFIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6AC3710", Offset = "0x6AC2B10", VA = "0x186AC3710")]
	public CFMMJIGHNIL(AmplitudeAnalyticsIdentifyMessage HGJOENLBDNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6AC36A0", Offset = "0x6AC2AA0", VA = "0x186AC36A0", Slot = "4")]
	public override void BBMEIIPGPMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class KDJMFICMHNK : global::CCAPIKJCILG<AmplitudeAnalyticsEvent, KDJMFICMHNK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private bool GHPLHIFLDGB;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override KDJMFICMHNK NMCPFCGOILN
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x820230", Offset = "0x81F630", VA = "0x180820230", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public long FBPHCBNGFLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x45535F0", Offset = "0x45529F0", VA = "0x1845535F0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6AC57D0", Offset = "0x6AC4BD0", VA = "0x186AC57D0")]
	public KDJMFICMHNK(AmplitudeAnalyticsEvent HGJOENLBDNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x86EF30", Offset = "0x86E330", VA = "0x18086EF30", Slot = "5")]
	public override AmplitudeAnalyticsEvent ENPINIIGFIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6AC5240", Offset = "0x6AC4640", VA = "0x186AC5240", Slot = "4")]
	public override void BBMEIIPGPMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6AC54C0", Offset = "0x6AC48C0", VA = "0x186AC54C0")]
	public KDJMFICMHNK HBKMDONCOBC(string MMNEFCOHNGA, long[] EOEKGHMNIDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6AC52F0", Offset = "0x6AC46F0", VA = "0x186AC52F0")]
	public KDJMFICMHNK HBKMDONCOBC(string MMNEFCOHNGA, ulong[] EOEKGHMNIDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2CF9800", Offset = "0x2CF8C00", VA = "0x182CF9800")]
	public KDJMFICMHNK HBKMDONCOBC<T>(string MMNEFCOHNGA, T[] EOEKGHMNIDN) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6AC52E0", Offset = "0x6AC46E0", VA = "0x186AC52E0")]
	public KDJMFICMHNK HBKMDONCOBC(string MMNEFCOHNGA, string[] EOEKGHMNIDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2CF9790", Offset = "0x2CF8B90", VA = "0x182CF9790")]
	public KDJMFICMHNK HBKMDONCOBC<T>(string MMNEFCOHNGA, T EOEKGHMNIDN) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6AC5430", Offset = "0x6AC4830", VA = "0x186AC5430")]
	public KDJMFICMHNK HBKMDONCOBC(string MMNEFCOHNGA, long EOEKGHMNIDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6AC5670", Offset = "0x6AC4A70", VA = "0x186AC5670")]
	public KDJMFICMHNK HBKMDONCOBC(string MMNEFCOHNGA, ulong EOEKGHMNIDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6AC5600", Offset = "0x6AC4A00", VA = "0x186AC5600")]
	public KDJMFICMHNK HBKMDONCOBC(string MMNEFCOHNGA, string EOEKGHMNIDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6AC57A0", Offset = "0x6AC4BA0", VA = "0x186AC57A0")]
	public KDJMFICMHNK OFJPLJDIKHM(string MMNEFCOHNGA, object? EOEKGHMNIDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6AC5700", Offset = "0x6AC4B00", VA = "0x186AC5700")]
	public KDJMFICMHNK JEGIDJIONDM(string MMNEFCOHNGA, string EOEKGHMNIDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6AC5150", Offset = "0x6AC4550", VA = "0x186AC5150")]
	private KDJMFICMHNK AMKGJMLOBIF(string MMNEFCOHNGA, object EOEKGHMNIDN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class LOBPFIBJOHJ : KDJMFICMHNK
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6AC57D0", Offset = "0x6AC4BD0", VA = "0x186AC57D0")]
	public LOBPFIBJOHJ(AmplitudeAnalyticsEvent HGJOENLBDNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6AC6DA0", Offset = "0x6AC61A0", VA = "0x186AC6DA0", Slot = "4")]
	public override void BBMEIIPGPMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class CCAPIKJCILG<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : global::CCAPIKJCILG<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	protected M HGJOENLBDNH;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public abstract BLDR NMCPFCGOILN
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x25DFEC0", Offset = "0x25DF2C0", VA = "0x1825DFEC0")]
	public CCAPIKJCILG(M HGJOENLBDNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x35A7110", Offset = "0x35A6510", VA = "0x1835A7110")]
	public BLDR JJKOIKEBICI(AmplitudeAnalyticsIdentifyMessage.DeviceInfo COLHEMBHJAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x35A70D0", Offset = "0x35A64D0", VA = "0x1835A70D0")]
	public BLDR IILAABCEKCL(AmplitudeAnalyticsIdentifyMessage.RevenueData NJBDLOBFJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x35A72B0", Offset = "0x35A66B0", VA = "0x1835A72B0")]
	public BLDR JOKPNIGBMMD(string MMNEFCOHNGA, string EOEKGHMNIDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2CA8E20", Offset = "0x2CA8220", VA = "0x182CA8E20")]
	public BLDR JOKPNIGBMMD<T>(string MMNEFCOHNGA, T EOEKGHMNIDN) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x35A7150", Offset = "0x35A6550", VA = "0x1835A7150")]
	public BLDR JOKPNIGBMMD(string MMNEFCOHNGA, long EOEKGHMNIDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x35A7200", Offset = "0x35A6600", VA = "0x1835A7200")]
	public BLDR JOKPNIGBMMD(string MMNEFCOHNGA, ulong EOEKGHMNIDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void BBMEIIPGPMN();

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x35A70A0", Offset = "0x35A64A0", VA = "0x1835A70A0")]
	internal static string AHIPIOLIJIJ(string EOEKGHMNIDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x35A7320", Offset = "0x35A6720", VA = "0x1835A7320")]
	private BLDR KAFNEOFFICA(string MMNEFCOHNGA, object EOEKGHMNIDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M ENPINIIGFIO();
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
			[Cpp2IlInjected.Address(RVA = "0x6AC3B00", Offset = "0x6AC2F00", VA = "0x186AC3B00")]
			public void FHHCDCBCDBP(Dictionary<string, object> AGMGCGCFFFB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6ACA9D0", Offset = "0x6AC9DD0", VA = "0x186ACA9D0")]
			public void FHHCDCBCDBP(Dictionary<string, object> GJNMJFCGPHA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x6ACAB40", Offset = "0x6AC9F40", VA = "0x186ACAB40")]
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
			[Cpp2IlInjected.Address(RVA = "0x856480", Offset = "0x855880", VA = "0x180856480")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x87D040", Offset = "0x87C440", VA = "0x18087D040")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6AC2970", Offset = "0x6AC1D70", VA = "0x186AC2970")]
		public static CFMMJIGHNIL EDGHPEHNECD(string EGPHDEMHMDI, string NEDCFAMHCFG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6AC2EB0", Offset = "0x6AC22B0", VA = "0x186AC2EB0")]
		protected AmplitudeAnalyticsIdentifyMessage(string EGPHDEMHMDI, string NEDCFAMHCFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6AC2E30", Offset = "0x6AC2230", VA = "0x186AC2E30")]
		public Dictionary<string, object> OLCBKMINOJI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6AC2A20", Offset = "0x6AC1E20", VA = "0x186AC2A20", Slot = "4")]
		protected virtual Dictionary<string, object> HDFINAPBNLG(Dictionary<string, object> JKFDCDDFLDB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6AC28D0", Offset = "0x6AC1CD0", VA = "0x186AC28D0")]
		protected void EABIALMJHCB(string LOLIOKKJLEH, Dictionary<string, object> FAONMBOAPJM, Dictionary<string, object> OBNGGOIJMJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6AC2D60", Offset = "0x6AC2160", VA = "0x186AC2D60")]
		protected void KNKABPAEODE(string LOLIOKKJLEH, string EOEKGHMNIDN, Dictionary<string, object> HEKIAEOGHIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6AC2DD0", Offset = "0x6AC21D0", VA = "0x186AC2DD0", Slot = "5")]
		public virtual void LPIGCDDMIGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6AC2880", Offset = "0x6AC1C80", VA = "0x186AC2880", Slot = "6")]
		public virtual void BBMEIIPGPMN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		private enum HLJJEGBDOMO
		{
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		internal class OHEILBOGMJO
		{
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			private class OFCNNBJNGBL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400009F")]
				public int GHKCGOCKCJF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000A0")]
				public Dictionary<string, object> PKKINNCLEDI;

				[Cpp2IlInjected.Token(Token = "0x600009D")]
				[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
				public OFCNNBJNGBL()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000017")]
			[CompilerGenerated]
			private sealed class KHJBMNPAGDI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000A1")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x600009E")]
				[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
				public KHJBMNPAGDI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600009F")]
				[Cpp2IlInjected.Address(RVA = "0x6AC5820", Offset = "0x6AC4C20", VA = "0x186AC5820")]
				internal bool DKJEBNNJEMO(OFCNNBJNGBL item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400009C")]
			private const string GIDDANJABMF = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			private readonly string PHCGGMEPABN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			private List<OFCNNBJNGBL> EDMGCHMMAND;

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			public int? DKGNKMHDCJG
			{
				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(RVA = "0x6AC9270", Offset = "0x6AC8670", VA = "0x186AC9270")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public int? KIOGMGIFKCP
			{
				[Cpp2IlInjected.Token(Token = "0x6000092")]
				[Cpp2IlInjected.Address(RVA = "0x6AC9B30", Offset = "0x6AC8F30", VA = "0x186AC9B30")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x6ACA320", Offset = "0x6AC9720", VA = "0x186ACA320")]
			internal OHEILBOGMJO(string BBJJHGIKEDH, string PADOGCOKLHF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x6ACA1A0", Offset = "0x6AC95A0", VA = "0x186ACA1A0")]
			public int OBNOHHMGGKG([Optional] int? LPGECBKMIJB)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x6AC9450", Offset = "0x6AC8850", VA = "0x186AC9450")]
			public List<Dictionary<string, object>> FDPPGOEKBJA(int HAOKLDHNLHN, int? LPGECBKMIJB)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x6ACA100", Offset = "0x6AC9500", VA = "0x186ACA100")]
			public void JGHMFNJGGKM(AmplitudeAnalyticsIdentifyMessage GHHNOPFOGCC, bool DLPECMNJJJA = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x6AC9FF0", Offset = "0x6AC93F0", VA = "0x186AC9FF0")]
			public void JGHMFNJGGKM(Dictionary<string, object> GHHNOPFOGCC, bool DLPECMNJJJA = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x6AC9BF0", Offset = "0x6AC8FF0", VA = "0x186AC9BF0")]
			public void HIJPPGIPNMO(params Dictionary<string, object>[] JCPNGNGJBAI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x6AC8EF0", Offset = "0x6AC82F0", VA = "0x186AC8EF0")]
			public void BNFIEILIHMA(List<Dictionary<string, object>> FADPHJHHBAO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x6AC9310", Offset = "0x6AC8710", VA = "0x186AC9310")]
			private void EILLFJOPHEM(Dictionary<string, object> GHHNOPFOGCC, bool DLPECMNJJJA = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x6AC9D80", Offset = "0x6AC9180", VA = "0x186AC9D80")]
			public void IACOFEOAMKP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x6AC96F0", Offset = "0x6AC8AF0", VA = "0x186AC96F0")]
			private void GCGBCHHDGMF([Optional] string FEMBAFJLEBI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x6AC9140", Offset = "0x6AC8540", VA = "0x186AC9140")]
			private static string DBPAAONGCFP(string EOEKGHMNIDN, string LOLIOKKJLEH)
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
			[Cpp2IlInjected.Address(RVA = "0x6ACADA0", Offset = "0x6ACA1A0", VA = "0x186ACADA0")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public struct DPIINLBDFPD<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public int FHHNICKGPAJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public string NCLHCJHOFOM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public T LGDCIFFOMJB;
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class CDNCCBLONHL : IEnumerator<IPNFOPMMOKI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			private IPNFOPMMOKI <>2__current;

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
			private IPNFOPMMOKI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000A9")]
				[Cpp2IlInjected.Address(RVA = "0x8117E0", Offset = "0x810BE0", VA = "0x1808117E0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x8117E0", Offset = "0x810BE0", VA = "0x1808117E0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x85A1C0", Offset = "0x8595C0", VA = "0x18085A1C0")]
			[DebuggerHidden]
			public CDNCCBLONHL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x6AC2FB0", Offset = "0x6AC23B0", VA = "0x186AC2FB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x6AC3660", Offset = "0x6AC2A60", VA = "0x186AC3660", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class IGIPBNFEGHI : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public LNFGPGAJEHA quitCompletePromise;

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
				[Cpp2IlInjected.Address(RVA = "0x8117E0", Offset = "0x810BE0", VA = "0x1808117E0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x8117E0", Offset = "0x810BE0", VA = "0x1808117E0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x85A1C0", Offset = "0x8595C0", VA = "0x18085A1C0")]
			[DebuggerHidden]
			public IGIPBNFEGHI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x6AC4AB0", Offset = "0x6AC3EB0", VA = "0x186AC4AB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x6AC4BD0", Offset = "0x6AC3FD0", VA = "0x186AC4BD0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class FDPKFIHEEPN : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x8117E0", Offset = "0x810BE0", VA = "0x1808117E0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x8117E0", Offset = "0x810BE0", VA = "0x1808117E0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x85A1C0", Offset = "0x8595C0", VA = "0x18085A1C0")]
			[DebuggerHidden]
			public FDPKFIHEEPN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x6AC3C80", Offset = "0x6AC3080", VA = "0x186AC3C80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x6AC3E00", Offset = "0x6AC3200", VA = "0x186AC3E00", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class DGCJDCNDGGB : IEnumerator<IPNFOPMMOKI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			private IPNFOPMMOKI <>2__current;

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
			private OHEILBOGMJO <cache>5__2;

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
			private IPNFOPMMOKI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000BB")]
				[Cpp2IlInjected.Address(RVA = "0x8117E0", Offset = "0x810BE0", VA = "0x1808117E0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x8117E0", Offset = "0x810BE0", VA = "0x1808117E0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x85A1C0", Offset = "0x8595C0", VA = "0x18085A1C0")]
			[DebuggerHidden]
			public DGCJDCNDGGB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x6AC3760", Offset = "0x6AC2B60", VA = "0x186AC3760", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x6AC3AC0", Offset = "0x6AC2EC0", VA = "0x186AC3AC0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class FENAIFEKPOE : IEnumerator<IPNFOPMMOKI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			private IPNFOPMMOKI <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public float timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			private OHEILBOGMJO <cache>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			private string <url>5__2;

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			private IPNFOPMMOKI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000C4")]
				[Cpp2IlInjected.Address(RVA = "0x8117E0", Offset = "0x810BE0", VA = "0x1808117E0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x8117E0", Offset = "0x810BE0", VA = "0x1808117E0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x85A1C0", Offset = "0x8595C0", VA = "0x18085A1C0")]
			[DebuggerHidden]
			public FENAIFEKPOE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x6AC3E40", Offset = "0x6AC3240", VA = "0x186AC3E40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x6AC4130", Offset = "0x6AC3530", VA = "0x186AC4130", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[CompilerGenerated]
		private sealed class KJIONKLCKNC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public List<Dictionary<string, object>> batch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public OHEILBOGMJO cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
			public KJIONKLCKNC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x6AC5D20", Offset = "0x6AC5120", VA = "0x186AC5D20")]
			internal void GOGGBHPLLOF(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x6AC5880", Offset = "0x6AC4C80", VA = "0x186AC5880")]
			internal void APKKLFBEMOF(DPIINLBDFPD<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class HONEPJLFFDH : IEnumerator<IPNFOPMMOKI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			private IPNFOPMMOKI <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public OHEILBOGMJO cache;

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
			private KJIONKLCKNC <>8__1;

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
			private IPNFOPMMOKI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000CD")]
				[Cpp2IlInjected.Address(RVA = "0x8117E0", Offset = "0x810BE0", VA = "0x1808117E0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x8117E0", Offset = "0x810BE0", VA = "0x1808117E0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x85A1C0", Offset = "0x8595C0", VA = "0x18085A1C0")]
			[DebuggerHidden]
			public HONEPJLFFDH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x6AC4170", Offset = "0x6AC3570", VA = "0x186AC4170", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x6AC4A70", Offset = "0x6AC3E70", VA = "0x186AC4A70", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private sealed class FEKNIBAFOGJ<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x1939780", Offset = "0x1938B80", VA = "0x181939780")]
			public FEKNIBAFOGJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x341F7A0", Offset = "0x341EBA0", VA = "0x18341F7A0")]
			internal DPIINLBDFPD<T> NBDLGAGIJLB(ALNALBOHGNM postResponse)
			{
				return default(DPIINLBDFPD<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class LJFLAILFPGA<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x1939780", Offset = "0x1938B80", VA = "0x181939780")]
			public LJFLAILFPGA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x341F7A0", Offset = "0x341EBA0", VA = "0x18341F7A0")]
			internal DPIINLBDFPD<T> BMFLEBLCOLE(ALNALBOHGNM postResponse)
			{
				return default(DPIINLBDFPD<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private ODGLAHCCHJO LLFAOJIEEFC;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private const string LJGGJAOIMEE = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private const string AMANCICPFHH = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private const string LBPOLPANJAA = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private const int HDNIIAFMLJM = 15;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private const int KEMNMHGFHHK = 10;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private const int DNOMKJKFKKF = 5;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private const float GPIBPMBFLNN = 10f;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private const long OGGBPBEHNAE = -1L;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private const string HLFJPDMKLCC = "f1779b982f1c09aed3adb3cca563cbc2";

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private const string OLKJBINPCHI = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private static bool IGKAAIJNEAE;

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static bool GOKJHKDMLDO;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static int AAELKFICNOB;

		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private static int FILEJMNHLPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private IGLNFOCNCED PPHBDPAPLME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private bool AIMEOGHDFLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private float MCIDAOECCDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private float NKLNOMNEPGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int BIPIEBLCLDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private int JEGFAAGDJOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int? NGGBIMLCPDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int? GBBDECDDNGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private long KLDAKFLONHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private string PNNCFJOPGEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private long CAHFCCLNMBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private Dictionary<string, object> IBLEMBLFJEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private HLJJEGBDOMO DNKOMJHGMNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private int LHLBGLOACBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private int KLAOAFNMHKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private float FBLGEFKGEGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private bool OBNKJHEIIGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x89")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private bool AKMEKLOJLIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private OHEILBOGMJO FDAIFEBLGID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private OHEILBOGMJO DKHGHPGCJBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private OHEILBOGMJO DKFKKAMAKKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> KHOBKBLMBMK;

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo MJIOGGGANJB;

		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private static string NKMGFEEKHJO;

		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private const string HEAJNENMJNJ = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private readonly string CLKBLFOHPFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private readonly string ACCFMPOFCJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly string LJCFKAFDNGD;

		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private ODGLAHCCHJO GEIDDMDIMDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6ABDD70", Offset = "0x6ABD170", VA = "0x186ABDD70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private static int MNJAHJKOANA
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6AC07E0", Offset = "0x6ABFBE0", VA = "0x186AC07E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static long DMJOFBNBGDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6AC1B30", Offset = "0x6AC0F30", VA = "0x186AC1B30")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6AC1C30", Offset = "0x6AC1030", VA = "0x186AC1C30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static string DBOLEIPGJOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6AC1AD0", Offset = "0x6AC0ED0", VA = "0x186AC1AD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static string MJJKBEHKGGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x6AC1B00", Offset = "0x6AC0F00", VA = "0x186AC1B00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public string IADAIJAANIK
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x909860", Offset = "0x908C60", VA = "0x180909860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x92AD70", Offset = "0x92A170", VA = "0x18092AD70")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public int? KFOCMEDJOKC
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xAA2C60", Offset = "0xAA2060", VA = "0x180AA2C60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x3B6C020", Offset = "0x3B6B420", VA = "0x183B6C020")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool GIDJMHHDMON
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xAEBBC0", Offset = "0xAEAFC0", VA = "0x180AEBBC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xAEBCC0", Offset = "0xAEB0C0", VA = "0x180AEBCC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static bool MMEFMHCLGAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x6AC1A40", Offset = "0x6AC0E40", VA = "0x186AC1A40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> OBNKNBKJKGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x6AC19A0", Offset = "0x6AC0DA0", VA = "0x186AC19A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x6AC1B90", Offset = "0x6AC0F90", VA = "0x186AC1B90")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6ABD090", Offset = "0x6ABC490", VA = "0x186ABD090", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6AC0020", Offset = "0x6ABF420", VA = "0x186AC0020")]
		private void OJAJFKIAKJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6AC1200", Offset = "0x6AC0600", VA = "0x186AC1200")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6AC0340", Offset = "0x6ABF740", VA = "0x186AC0340", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6AC14F0", Offset = "0x6AC08F0", VA = "0x186AC14F0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6AC09B0", Offset = "0x6ABFDB0", VA = "0x186AC09B0")]
		public FKADHPEOOEO PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6ABE510", Offset = "0x6ABD910", VA = "0x186ABE510")]
		[IteratorStateMachine(typeof(CDNCCBLONHL))]
		public IEnumerator<IPNFOPMMOKI> Initialize(AmplitudeAnalyticsEvent MGJDKCLDEDP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6AC13E0", Offset = "0x6AC07E0", VA = "0x186AC13E0")]
		public void UpdateLastAliveTime(float PBGBLKDKIMK = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6ABE780", Offset = "0x6ABDB80", VA = "0x186ABE780")]
		private FKADHPEOOEO LAMMEDMOOMA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6ABD7C0", Offset = "0x6ABCBC0", VA = "0x186ABD7C0")]
		private FKADHPEOOEO EKNBPGDACAI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6AC0E00", Offset = "0x6AC0200", VA = "0x186AC0E00")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6ABD490", Offset = "0x6ABC890", VA = "0x186ABD490")]
		[IteratorStateMachine(typeof(IGIPBNFEGHI))]
		private IEnumerator CMJMMLNNIKM(LNFGPGAJEHA CMNFMDGOCMB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6AC1770", Offset = "0x6AC0B70", VA = "0x186AC1770")]
		[IteratorStateMachine(typeof(FDPKFIHEEPN))]
		public IEnumerator WaitForFlush(float KGMNGICIPNF = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6AC12C0", Offset = "0x6AC06C0", VA = "0x186AC12C0")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6AC1210", Offset = "0x6AC0610", VA = "0x186AC1210")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime BPCFECOOAOP)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6ABE1F0", Offset = "0x6ABD5F0", VA = "0x186ABE1F0")]
		public static CFMMJIGHNIL Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6ABCF50", Offset = "0x6ABC350", VA = "0x186ABCF50")]
		public static KDJMFICMHNK AccountSelectionPostLoginEvent([NotNull] string CCLPGFDKGIC, string NEDCFAMHCFG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6ABDA80", Offset = "0x6ABCE80", VA = "0x186ABDA80")]
		public static KDJMFICMHNK Event([NotNull] string CCLPGFDKGIC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6AC0A10", Offset = "0x6ABFE10", VA = "0x186AC0A10")]
		public static KDJMFICMHNK PreviousSessionEvent([NotNull] string CCLPGFDKGIC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6ABE320", Offset = "0x6ABD720", VA = "0x186ABE320")]
		public static KDJMFICMHNK InitializeEvent(string NEDCFAMHCFG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6AC0F70", Offset = "0x6AC0370", VA = "0x186AC0F70")]
		public static KDJMFICMHNK StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6ABD520", Offset = "0x6ABC920", VA = "0x186ABD520")]
		public static KDJMFICMHNK CreateOutOfSessionEvent(string CCLPGFDKGIC, bool ALAIOHJCPOA = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6ABEB70", Offset = "0x6ABDF70", VA = "0x186ABEB70")]
		public static FKADHPEOOEO LogOutOfSessionEvent(KDJMFICMHNK INKOBKGCJKL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6ABE8D0", Offset = "0x6ABDCD0", VA = "0x186ABE8D0")]
		public void LogEventAsync(AmplitudeAnalyticsEvent AADBOMICCKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6ABEE60", Offset = "0x6ABE260", VA = "0x186ABEE60")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent AADBOMICCKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6ABEFB0", Offset = "0x6ABE3B0", VA = "0x186ABEFB0")]
		public void LogSerializedEventAsync(Dictionary<string, object> ACGDNPPALHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6ABEA20", Offset = "0x6ABDE20", VA = "0x186ABEA20")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage INMMALNIHAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6ABF180", Offset = "0x6ABE580", VA = "0x186ABF180")]
		private void MHHCIBNDNGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6ABDDE0", Offset = "0x6ABD1E0", VA = "0x186ABDDE0")]
		private void ICOEHOPCDNC(Dictionary<string, object> FNHBJEBLHHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6ABF090", Offset = "0x6ABE490", VA = "0x186ABF090")]
		private void MEHCCIENMHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6ABE5A0", Offset = "0x6ABD9A0", VA = "0x186ABE5A0")]
		private void JNPDJPDHICB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6ABDC00", Offset = "0x6ABD000", VA = "0x186ABDC00")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6ABF260", Offset = "0x6ABE660", VA = "0x186ABF260")]
		[IteratorStateMachine(typeof(DGCJDCNDGGB))]
		private IEnumerator<IPNFOPMMOKI> NEGIBFMCKAA(float KGMNGICIPNF = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6ABE850", Offset = "0x6ABDC50", VA = "0x186ABE850")]
		[IteratorStateMachine(typeof(FENAIFEKPOE))]
		private IEnumerator<IPNFOPMMOKI> LIBODBHLMDB(float KGMNGICIPNF = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6ABDC90", Offset = "0x6ABD090", VA = "0x186ABDC90")]
		[IteratorStateMachine(typeof(HONEPJLFFDH))]
		private IEnumerator<IPNFOPMMOKI> GFBDFIJBEAF(OHEILBOGMJO BBOGLLHMOGL, int? LPGECBKMIJB, string LECPJCEBFIN, string IKAKGBADONH, float KGMNGICIPNF, Action<int> GMMPONKAIJH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6ABD370", Offset = "0x6ABC770", VA = "0x186ABD370")]
		private static void BCDBIJCFPLP(bool DMOEBNLMABB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6AC06B0", Offset = "0x6ABFAB0", VA = "0x186AC06B0")]
		private global::CBFHNKNAJIN<DPIINLBDFPD<Dictionary<string, object>>> PDHJPDKAIEO(string LECPJCEBFIN, string IKAKGBADONH, string CBNLKJOOOND, string DFLELDPPOFD, Dictionary<string, object> LGDCIFFOMJB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6AC03E0", Offset = "0x6ABF7E0", VA = "0x186AC03E0")]
		private global::CBFHNKNAJIN<DPIINLBDFPD<List<Dictionary<string, object>>>> PDHJPDKAIEO(string LECPJCEBFIN, string IKAKGBADONH, string CBNLKJOOOND, string DFLELDPPOFD, List<Dictionary<string, object>> LGDCIFFOMJB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x3EEBEC0", Offset = "0x3EEB2C0", VA = "0x183EEBEC0")]
		private global::CBFHNKNAJIN<DPIINLBDFPD<T>> JCFBJLMKFHE<T>(string LECPJCEBFIN, string IKAKGBADONH, string DFLELDPPOFD, T LGDCIFFOMJB, Dictionary<string, object> EJAMICHDFEF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x3EEC160", Offset = "0x3EEB560", VA = "0x183EEC160")]
		private global::CBFHNKNAJIN<DPIINLBDFPD<T>> JOJBKHKIBEA<T>(string LECPJCEBFIN, string IKAKGBADONH, string CBNLKJOOOND, T LGDCIFFOMJB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6ABF2E0", Offset = "0x6ABE6E0", VA = "0x186ABF2E0")]
		private bool NKLFLGKMPGN(float FCHEKHELBEL, float KGMNGICIPNF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6ABF330", Offset = "0x6ABE730", VA = "0x186ABF330")]
		private Dictionary<string, object> NOMKMHNDEOK(string IKAKGBADONH, Dictionary<string, object> LGDCIFFOMJB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6AC1850", Offset = "0x6AC0C50", VA = "0x186AC1850")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6ABE080", Offset = "0x6ABD480", VA = "0x186ABE080")]
		[CompilerGenerated]
		private long IHACJCNNKPB()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6ABDA70", Offset = "0x6ABCE70", VA = "0x186ABDA70")]
		[CompilerGenerated]
		private void ELAKABLHNOH(int PBIMPECHGIL)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class JBNEEEEBAIM
{
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private const string HNHJCCDJAFD = "timed_flow";

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private const string LNIIKODLGNO = "flowName";

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private const string CJMNIMNJOLG = "startedAt";

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private const string HJHOMKAOLKM = "endedAt";

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private const string KOHDGMOBFIM = "durationInSeconds";

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private const string OMDJOKEPNAK = "failure";

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private const string KFGPLEBNAPE = "failureMessage";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private long NCPEEDFDBFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private KDJMFICMHNK BNJBAFJOCKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private bool POKINMDGJCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private float FDMNKIGKENP;

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6AC4FB0", Offset = "0x6AC43B0", VA = "0x186AC4FB0")]
	public JBNEEEEBAIM(string IDIBICFHPHB, float FDMNKIGKENP = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x20C5290", Offset = "0x20C4690", VA = "0x1820C5290")]
	public void HBKMDONCOBC<T>(string MMNEFCOHNGA, T EOEKGHMNIDN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6AC4E20", Offset = "0x6AC4220", VA = "0x186AC4E20")]
	public void HBKMDONCOBC(string MMNEFCOHNGA, string EOEKGHMNIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6AC4C10", Offset = "0x6AC4010", VA = "0x186AC4C10")]
	public void ABLCJMPIKCM(string KCDHNBEIJEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6AC4EF0", Offset = "0x6AC42F0", VA = "0x186AC4EF0")]
	public void MGNOHKPIDJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6AC4D00", Offset = "0x6AC4100", VA = "0x186AC4D00")]
	private void GDJMONAHCDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6AC4EA0", Offset = "0x6AC42A0", VA = "0x186AC4EA0")]
	private bool LFBIHNNPNFK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public enum DAFGIPMCBBF
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
public class LGEMIJODMHL : MLLBCFKBPOO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private MLLBCFKBPOO GNAFLJJPCIM;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private MLLBCFKBPOO NCENENHCKFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x6AC6090", Offset = "0x6AC5490", VA = "0x186AC6090")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool GEKLMBBMKNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x6AC6530", Offset = "0x6AC5930", VA = "0x186AC6530", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action KDOEOIOBPDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6AC63F0", Offset = "0x6AC57F0", VA = "0x186AC63F0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x6AC6D00", Offset = "0x6AC6100", VA = "0x186AC6D00", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action MEEDPPMELHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6AC61A0", Offset = "0x6AC55A0", VA = "0x186AC61A0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6AC6240", Offset = "0x6AC5640", VA = "0x186AC6240", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
	[Preserve]
	public LGEMIJODMHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6AC6820", Offset = "0x6AC5C20", VA = "0x186AC6820")]
	[HECCOHDEPAK(JCKMLGOOEHJ.GameOnly)]
	private static void MEFLNAKPGFG(HECDEIOAEPJ BFLCNPAPJDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6AC6A10", Offset = "0x6AC5E10", VA = "0x186AC6A10", Slot = "8")]
	public FKADHPEOOEO OAGJEKOOFKN(string DJOBBBCCBNO, string PADOGCOKLHF, [Optional] FEPLNDDAOPM EJIFDDGHCML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6AC6910", Offset = "0x6AC5D10", VA = "0x186AC6910", Slot = "10")]
	public FKADHPEOOEO NCOICFIMIKM(FEPLNDDAOPM EJIFDDGHCML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x6AC62E0", Offset = "0x6AC56E0", VA = "0x186AC62E0", Slot = "11")]
	public FKADHPEOOEO DHFEILBJPOD(FEPLNDDAOPM EJIFDDGHCML, Dictionary<string, string> FDIMJAMGCJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6AC6100", Offset = "0x6AC5500", VA = "0x186AC6100", Slot = "12")]
	public bool AKEHBMEFCMO(string APAGLLNMHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6AC6490", Offset = "0x6AC5890", VA = "0x186AC6490", Slot = "13")]
	public CFJONDFBOMC GLKGOFPPEHN(string MPMFCOKPFKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x6AC6720", Offset = "0x6AC5B20", VA = "0x186AC6720", Slot = "14")]
	public LJBGPJIDIKB KOECOPDNBHF(string OAGOJHFIDLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x6AC6680", Offset = "0x6AC5A80", VA = "0x186AC6680", Slot = "15")]
	public CFJONDFBOMC KGDCNFACNKJ(string PODKMGAOIIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x6AC6580", Offset = "0x6AC5980", VA = "0x186AC6580", Slot = "16")]
	public FKADHPEOOEO JPGCBINGCLP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x810EE0", Offset = "0x8102E0", VA = "0x180810EE0")]
	[CompilerGenerated]
	private void NEJCAMEDOPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x188CC90", Offset = "0x188C090", VA = "0x18188CC90")]
	[CompilerGenerated]
	private void IJHHLNPMCIK()
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
			[Cpp2IlInjected.Address(RVA = "0x856480", Offset = "0x855880", VA = "0x180856480")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public SerializedStatsigExperiment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class MKIEFOEEBJM : MLLBCFKBPOO
{
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private const string AKGKFJMJFMO = "GamePlatform";

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private const string BGAPFLEHEFJ = "InteractionCategory";

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private const string HKHAOFGGOLM = "JrActType";

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private const string KBEMHPHNNMN = "IsDeveloper";

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private const string JGFJDHLBKCC = "IsModerator";

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private const string NDEMJEHLIEF = "IsMember";

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private const string NPGJPFFLMCA = "DaysSinceJoiningBucket";

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private const string CGAEICNJAEC = "AccountCreationTimeAfterEpochMilliseconds";

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private const string NPBGCEPEBOD = "InGoodStanding";

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private const string CFCCEJBPIPI = "FriendCount";

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private const string EPNIDJIELBC = "LocaleName";

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly IReadOnlyDictionary<string, DPGLNIHMCJN> MBCCAFGDLBI;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private const int JCOOMLGAHKL = 5000;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private bool PALEDPMCPFL;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool GEKLMBBMKNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8116E0", Offset = "0x810AE0", VA = "0x1808116E0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action KDOEOIOBPDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6AC7C30", Offset = "0x6AC7030", VA = "0x186AC7C30", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6AC8AB0", Offset = "0x6AC7EB0", VA = "0x186AC8AB0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action MEEDPPMELHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6AC6FE0", Offset = "0x6AC63E0", VA = "0x186AC6FE0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6AC7080", Offset = "0x6AC6480", VA = "0x186AC7080", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6AC8610", Offset = "0x6AC7A10", VA = "0x186AC8610", Slot = "8")]
	public FKADHPEOOEO OAGJEKOOFKN(string DJOBBBCCBNO, string PADOGCOKLHF, [Optional] FEPLNDDAOPM EJIFDDGHCML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x6AC8020", Offset = "0x6AC7420", VA = "0x186AC8020", Slot = "16")]
	public FKADHPEOOEO JPGCBINGCLP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6AC83F0", Offset = "0x6AC77F0", VA = "0x186AC83F0", Slot = "10")]
	public FKADHPEOOEO NCOICFIMIKM(FEPLNDDAOPM EJIFDDGHCML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x6AC7350", Offset = "0x6AC6750", VA = "0x186AC7350", Slot = "11")]
	public FKADHPEOOEO DHFEILBJPOD(FEPLNDDAOPM EJIFDDGHCML, Dictionary<string, string> FDIMJAMGCJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6AC6F30", Offset = "0x6AC6330", VA = "0x186AC6F30", Slot = "12")]
	public bool AKEHBMEFCMO(string APAGLLNMHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x6AC7CD0", Offset = "0x6AC70D0", VA = "0x186AC7CD0", Slot = "13")]
	public CFJONDFBOMC GLKGOFPPEHN(string MPMFCOKPFKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6AC8330", Offset = "0x6AC7730", VA = "0x186AC8330", Slot = "14")]
	public LJBGPJIDIKB KOECOPDNBHF(string OAGOJHFIDLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6AC81B0", Offset = "0x6AC75B0", VA = "0x186AC81B0", Slot = "15")]
	public CFJONDFBOMC KGDCNFACNKJ(string PODKMGAOIIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6AC7640", Offset = "0x6AC6A40", VA = "0x186AC7640")]
	private LJOBBFMKHMI FFKGPEEMNIH(FEPLNDDAOPM EJIFDDGHCML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6AC7DF0", Offset = "0x6AC71F0", VA = "0x186AC7DF0")]
	private BKMIAAJPNKE HJELPPBLHLI(string PADOGCOKLHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6AC7120", Offset = "0x6AC6520", VA = "0x186AC7120")]
	private void CFBAAFILCHE(string MPMFCOKPFKE, CFJONDFBOMC GBKHEJGDEOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6AC8C80", Offset = "0x6AC8080", VA = "0x186AC8C80")]
	public MKIEFOEEBJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x1713CE0", Offset = "0x17130E0", VA = "0x181713CE0")]
	[CompilerGenerated]
	private void JEAACCELOCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6AC82A0", Offset = "0x6AC76A0", VA = "0x186AC82A0")]
	[CompilerGenerated]
	private void KMHKCGMAOBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6AC7F90", Offset = "0x6AC7390", VA = "0x186AC7F90")]
	[CompilerGenerated]
	private void JDGPEAPCLMM()
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
			[Cpp2IlInjected.Address(RVA = "0x856480", Offset = "0x855880", VA = "0x180856480")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x8117E0", Offset = "0x810BE0", VA = "0x1808117E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x855AE0", Offset = "0x854EE0", VA = "0x180855AE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6ACAB50", Offset = "0x6AC9F50", VA = "0x186ACAB50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface MLLBCFKBPOO
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	bool GEKLMBBMKNK
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action KDOEOIOBPDO;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action MEEDPPMELHN;

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FKADHPEOOEO OAGJEKOOFKN(string DJOBBBCCBNO, string PADOGCOKLHF, [Optional] FEPLNDDAOPM EJIFDDGHCML);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	FKADHPEOOEO NCOICFIMIKM(FEPLNDDAOPM EJIFDDGHCML);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "7")]
	FKADHPEOOEO DHFEILBJPOD(FEPLNDDAOPM EJIFDDGHCML, Dictionary<string, string> FDIMJAMGCJG);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool AKEHBMEFCMO(string APAGLLNMHHG);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "9")]
	CFJONDFBOMC GLKGOFPPEHN(string MPMFCOKPFKE);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "10")]
	LJBGPJIDIKB KOECOPDNBHF(string OAGOJHFIDLG);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "11")]
	CFJONDFBOMC KGDCNFACNKJ(string PODKMGAOIIN);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "12")]
	FKADHPEOOEO JPGCBINGCLP();
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class OILPMJBLEGN : MLLBCFKBPOO
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool GEKLMBBMKNK
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x811730", Offset = "0x810B30", VA = "0x180811730", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action KDOEOIOBPDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6ACA690", Offset = "0x6AC9A90", VA = "0x186ACA690", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x6ACA930", Offset = "0x6AC9D30", VA = "0x186ACA930", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action MEEDPPMELHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x6ACA4B0", Offset = "0x6AC98B0", VA = "0x186ACA4B0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6ACA550", Offset = "0x6AC9950", VA = "0x186ACA550", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6ACA890", Offset = "0x6AC9C90", VA = "0x186ACA890", Slot = "8")]
	public FKADHPEOOEO OAGJEKOOFKN(string DJOBBBCCBNO, string PADOGCOKLHF, [Optional] FEPLNDDAOPM EJIFDDGHCML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6ACA7F0", Offset = "0x6AC9BF0", VA = "0x186ACA7F0", Slot = "10")]
	public FKADHPEOOEO NCOICFIMIKM(FEPLNDDAOPM EJIFDDGHCML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6ACA5F0", Offset = "0x6AC99F0", VA = "0x186ACA5F0", Slot = "11")]
	public FKADHPEOOEO DHFEILBJPOD(FEPLNDDAOPM EJIFDDGHCML, Dictionary<string, string> FDIMJAMGCJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x7FB3B0", Offset = "0x7FA7B0", VA = "0x1807FB3B0", Slot = "12")]
	public bool AKEHBMEFCMO(string APAGLLNMHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6ACA730", Offset = "0x6AC9B30", VA = "0x186ACA730", Slot = "13")]
	public CFJONDFBOMC GLKGOFPPEHN(string MPMFCOKPFKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6ACA7E0", Offset = "0x6AC9BE0", VA = "0x186ACA7E0", Slot = "14")]
	public LJBGPJIDIKB KOECOPDNBHF(string OAGOJHFIDLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6ACA730", Offset = "0x6AC9B30", VA = "0x186ACA730", Slot = "15")]
	public CFJONDFBOMC KGDCNFACNKJ(string PODKMGAOIIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6ACA740", Offset = "0x6AC9B40", VA = "0x186ACA740", Slot = "16")]
	public FKADHPEOOEO JPGCBINGCLP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
	public OILPMJBLEGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface FEPLNDDAOPM
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	bool OKBFGAGGMAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	bool NPPHPBJILJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	bool NMEBBHINJGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	bool KLHCHLOELAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool? JINHICHNDBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	int? KFOCMEDJOKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	int ACPCBOGKNNG
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	string HEHALILINBF
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	string COOGNJGNBDK
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	string MJJPAIBCPLG
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	string GAEOCAEDNHI
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	string KFIPPAPAIMN
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	string OAOLGPKAGAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	double NHKFAHGADIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface DMMCNOLOEJE
{
	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	long KPBKFBJPKND
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "1")]
	long KMPHHPNOPBB();

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EDJJGNKHOHJ(long GGEIIAHFKKJ, bool JDBNBDBGCND = true);

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CHDMHABICGN(string GEKPLLKAIKG, string BALNEKPMALO, string GCHJGMGBHMJ);

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DJIIEBKACHB(string GEKPLLKAIKG);

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NKEAMAFAEGI(string GEKPLLKAIKG, string OBGMDKDBOHK, string IPNKPNMOKKG);

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NMDBKIGKFGB(string GCMKPCAFBKP, object FFFLAHEANAM, object LOEBNAANKDE);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface PNEHJDAJPNE
{
	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JBNEEEEBAIM LALAGFAFLBE(string IDIBICFHPHB);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class AOIEPJGNBNP
{
	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
	public AOIEPJGNBNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x8C6BB0", Offset = "0x8C5FB0", VA = "0x1808C6BB0")]
	public static string NLHKAJNPDJN(byte[] AMGPPENALAL, byte[] DKDGFKIJFBC)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class __BB_OBFUSCATOR_VERSION_3_9_9
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

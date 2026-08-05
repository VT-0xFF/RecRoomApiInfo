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
		[Cpp2IlInjected.Address(RVA = "0x7F1AF0", Offset = "0x7F0EF0", VA = "0x1807F1AF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x68C9B80", Offset = "0x68C8F80", VA = "0x1868C9B80")]
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
		[Cpp2IlInjected.Address(RVA = "0x9D7910", Offset = "0x9D6D10", VA = "0x1809D7910")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class GJHDIIDFAEA
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> DJHFILDFHPE;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x68C6D60", Offset = "0x68C6160", VA = "0x1868C6D60")]
	internal static bool ICGKGMPNJDE(string KOFPKIJDAMC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface IPLAJFBCEKM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool PKFCEBBFNIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string APKIJDCBHHB
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	string CEAEJFNKMGL
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	string JNFOIAHCPDK
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	string PBBCMFHLGDH
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	MCFFIFIPNKE<JDOBNEPGPBO> ICMICOPKEBM(string MBKCCFIECLE, Dictionary<string, string> NHFDMJIBDFJ, bool GLAPCMALKPH = false);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	MCFFIFIPNKE<JDOBNEPGPBO> IFPKLACPBED(string MBKCCFIECLE, string ACGIKIHOGMA, string JPCCCFJIOEM, string CCHGAGENKNI);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct JDOBNEPGPBO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly int JIECCGOGAKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly string IFNIIBBFHMG;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xB96660", Offset = "0xB95A60", VA = "0x180B96660")]
	public JDOBNEPGPBO(int GKCDAHPLAEJ, string MDPBDMJCHNI)
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
		public AmplitudeAnalyticsClient.Settings HBGIBEOKEAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x98CB30", Offset = "0x98BF30", VA = "0x18098CB30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool LCIDGHCPPCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x11846B0", Offset = "0x1183AB0", VA = "0x1811846B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8CEA50", Offset = "0x8CDE50", VA = "0x1808CEA50")]
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
			[Cpp2IlInjected.Address(RVA = "0x68C3D00", Offset = "0x68C3100", VA = "0x1868C3D00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x68C3DD0", Offset = "0x68C31D0", VA = "0x1868C3DD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static string StableId
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x68C3D40", Offset = "0x68C3140", VA = "0x1868C3D40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x68C3E20", Offset = "0x68C3220", VA = "0x1868C3E20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static string ClientLauncher
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x68C3CC0", Offset = "0x68C30C0", VA = "0x1868C3CC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x68C3D80", Offset = "0x68C3180", VA = "0x1868C3D80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x94CDE0", Offset = "0x94C1E0", VA = "0x18094CDE0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x68C34B0", Offset = "0x68C28B0", VA = "0x1868C34B0")]
		public static KPPJDLMHEII OBPHLOEIGIJ(string HEGEMCIFGEI, [NotNull] string EDNGDELIOBC, long GLHEAIAHIPL, long JKJGGOGGOND, string OFOLDFODADE, bool DGKFGGLAEJK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x68C31A0", Offset = "0x68C25A0", VA = "0x1868C31A0")]
		public static KPPJDLMHEII GHGINDAMJGF(string HEGEMCIFGEI, [NotNull] string EDNGDELIOBC, long GLHEAIAHIPL, long JKJGGOGGOND, string OFOLDFODADE, long LBJCHAKONKE, bool DGKFGGLAEJK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x68C3AE0", Offset = "0x68C2EE0", VA = "0x1868C3AE0")]
		private AmplitudeAnalyticsEvent(string HEGEMCIFGEI, [NotNull] string EDNGDELIOBC, long GLHEAIAHIPL, long JKJGGOGGOND, string OFOLDFODADE, bool DGKFGGLAEJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x97CE50", Offset = "0x97C250", VA = "0x18097CE50")]
		public void HEBICDJDFMH(long MPIIPCBOBFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x68C33C0", Offset = "0x68C27C0", VA = "0x1868C33C0", Slot = "5")]
		public override void LGOCMPEHCIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x68C3040", Offset = "0x68C2440", VA = "0x1868C3040", Slot = "6")]
		public override void EAOAALBJJCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x68C35A0", Offset = "0x68C29A0", VA = "0x1868C35A0", Slot = "4")]
		protected override Dictionary<string, object> PEPMIHHHFFP(Dictionary<string, object> KIBINFEMDHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x68C32B0", Offset = "0x68C26B0", VA = "0x1868C32B0")]
		private void JOMOLKIDCFA(string KOFPKIJDAMC, string KKIAKNLLHIO, bool PBPFADAMMEF = false)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class LIFJNHIGDCJ : HHEDEJICEID<AmplitudeAnalyticsIdentifyMessage, LIFJNHIGDCJ>
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override LIFJNHIGDCJ AGOMLHPBOHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xBD2AA0", Offset = "0xBD1EA0", VA = "0x180BD2AA0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x10687F0", Offset = "0x1067BF0", VA = "0x1810687F0", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage EPPDAOBIIGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x68C7530", Offset = "0x68C6930", VA = "0x1868C7530")]
	public LIFJNHIGDCJ(AmplitudeAnalyticsIdentifyMessage HGJHDPGFLKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x68C74C0", Offset = "0x68C68C0", VA = "0x1868C74C0", Slot = "4")]
	public override void EAOAALBJJCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class KPPJDLMHEII : HHEDEJICEID<AmplitudeAnalyticsEvent, KPPJDLMHEII>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private bool FLEHDIAMHAI;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override KPPJDLMHEII AGOMLHPBOHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xBD2AA0", Offset = "0xBD1EA0", VA = "0x180BD2AA0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public long JHLGGCGCDCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x214ECF0", Offset = "0x214E0F0", VA = "0x18214ECF0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x68BDD30", Offset = "0x68BD130", VA = "0x1868BDD30")]
	public KPPJDLMHEII(AmplitudeAnalyticsEvent HGJHDPGFLKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x10687F0", Offset = "0x1067BF0", VA = "0x1810687F0", Slot = "5")]
	public override AmplitudeAnalyticsEvent EPPDAOBIIGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x68C7140", Offset = "0x68C6540", VA = "0x1868C7140", Slot = "4")]
	public override void EAOAALBJJCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2423070", Offset = "0x2422470", VA = "0x182423070")]
	public KPPJDLMHEII FBGHDJFLGJP<T>(string HNNIGEFAIIM, T[] KKIAKNLLHIO) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x68C7270", Offset = "0x68C6670", VA = "0x1868C7270")]
	public KPPJDLMHEII FBGHDJFLGJP(string HNNIGEFAIIM, string[] KKIAKNLLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2423000", Offset = "0x2422400", VA = "0x182423000")]
	public KPPJDLMHEII FBGHDJFLGJP<T>(string HNNIGEFAIIM, T KKIAKNLLHIO) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x68C71E0", Offset = "0x68C65E0", VA = "0x1868C71E0")]
	public KPPJDLMHEII FBGHDJFLGJP(string HNNIGEFAIIM, long KKIAKNLLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x68C7280", Offset = "0x68C6680", VA = "0x1868C7280")]
	public KPPJDLMHEII FBGHDJFLGJP(string HNNIGEFAIIM, string KKIAKNLLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x68C7390", Offset = "0x68C6790", VA = "0x1868C7390")]
	public KPPJDLMHEII FPFMFHAFIDP(string HNNIGEFAIIM, object? KKIAKNLLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x68C72F0", Offset = "0x68C66F0", VA = "0x1868C72F0")]
	public KPPJDLMHEII FGDIKEBOOMM(string HNNIGEFAIIM, string KKIAKNLLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x68C73C0", Offset = "0x68C67C0", VA = "0x1868C73C0")]
	private KPPJDLMHEII IFGBBCHFJDP(string HNNIGEFAIIM, object KKIAKNLLHIO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class AOKICGKOAKE : KPPJDLMHEII
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x68BDD30", Offset = "0x68BD130", VA = "0x1868BDD30")]
	public AOKICGKOAKE(AmplitudeAnalyticsEvent HGJHDPGFLKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x68BDBA0", Offset = "0x68BCFA0", VA = "0x1868BDBA0", Slot = "4")]
	public override void EAOAALBJJCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class HHEDEJICEID<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : HHEDEJICEID<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected M HGJHDPGFLKO;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public abstract BLDR AGOMLHPBOHM
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x16C90C0", Offset = "0x16C84C0", VA = "0x1816C90C0")]
	public HHEDEJICEID(M HGJHDPGFLKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2031940", Offset = "0x2030D40", VA = "0x182031940")]
	public BLDR HDMPPNDPFNM(AmplitudeAnalyticsIdentifyMessage.DeviceInfo FBFBGKFKNFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x20319F0", Offset = "0x2030DF0", VA = "0x1820319F0")]
	public BLDR IIAGFGNNMAF(AmplitudeAnalyticsIdentifyMessage.RevenueData OIKCOGEMGPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2031980", Offset = "0x2030D80", VA = "0x182031980")]
	public BLDR IEGHONOJLOO(string HNNIGEFAIIM, string KKIAKNLLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x21DCA60", Offset = "0x21DBE60", VA = "0x1821DCA60")]
	public BLDR IEGHONOJLOO<T>(string HNNIGEFAIIM, T KKIAKNLLHIO) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void EAOAALBJJCD();

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2031A30", Offset = "0x2030E30", VA = "0x182031A30")]
	internal static string PLGOBNEMMFM(string KKIAKNLLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2031840", Offset = "0x2030C40", VA = "0x182031840")]
	private BLDR BENCDBAIOMH(string HNNIGEFAIIM, object KKIAKNLLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M EPPDAOBIIGA();
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
			[Cpp2IlInjected.Address(RVA = "0x68C4F20", Offset = "0x68C4320", VA = "0x1868C4F20")]
			public void FOCPHJPEOBJ(Dictionary<string, object> AABJJCGJEFL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
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
			[Cpp2IlInjected.Address(RVA = "0x68CB180", Offset = "0x68CA580", VA = "0x1868CB180")]
			public void FOCPHJPEOBJ(Dictionary<string, object> MKNJIKGFLHD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x68CB2F0", Offset = "0x68CA6F0", VA = "0x1868CB2F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x7E8110", Offset = "0x7E7510", VA = "0x1807E8110")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x7F3140", Offset = "0x7F2540", VA = "0x1807F3140")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x68C40C0", Offset = "0x68C34C0", VA = "0x1868C40C0")]
		public static LIFJNHIGDCJ OBPHLOEIGIJ(string HEGEMCIFGEI, string OFOLDFODADE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x68C44B0", Offset = "0x68C38B0", VA = "0x1868C44B0")]
		protected AmplitudeAnalyticsIdentifyMessage(string HEGEMCIFGEI, string OFOLDFODADE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x68C3F30", Offset = "0x68C3330", VA = "0x1868C3F30")]
		public Dictionary<string, object> JBIEHAFFPNG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x68C4170", Offset = "0x68C3570", VA = "0x1868C4170", Slot = "4")]
		protected virtual Dictionary<string, object> PEPMIHHHFFP(Dictionary<string, object> KIBINFEMDHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x68C4010", Offset = "0x68C3410", VA = "0x1868C4010")]
		protected void MPAAANNGFEB(string KOFPKIJDAMC, Dictionary<string, object> IOGHHMEINJD, Dictionary<string, object> PBECOGLKPEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x68C3E70", Offset = "0x68C3270", VA = "0x1868C3E70")]
		protected void AFJDKDHIIAO(string KOFPKIJDAMC, string KKIAKNLLHIO, Dictionary<string, object> KGHHDBPCLOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x68C3FB0", Offset = "0x68C33B0", VA = "0x1868C3FB0", Slot = "5")]
		public virtual void LGOCMPEHCIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x68C3EE0", Offset = "0x68C32E0", VA = "0x1868C3EE0", Slot = "6")]
		public virtual void EAOAALBJJCD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		private enum DLMDFKDMOIN
		{
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		internal class FBEFFMHEMBI
		{
			[Cpp2IlInjected.Token(Token = "0x2000015")]
			private class ALPEBPPAAHL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000067")]
				public int IEJCBEBMIHI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000068")]
				public Dictionary<string, object> HLOFCMNMAGJ;

				[Cpp2IlInjected.Token(Token = "0x6000098")]
				[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
				public ALPEBPPAAHL()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000016")]
			[CompilerGenerated]
			private sealed class JEPMJIPPFDH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000069")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000099")]
				[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
				public JEPMJIPPFDH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600009A")]
				[Cpp2IlInjected.Address(RVA = "0x68C70E0", Offset = "0x68C64E0", VA = "0x1868C70E0")]
				internal bool EJFHLFLBDEA(ALPEBPPAAHL item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private const string NFAONJFDJOO = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			private readonly string EKHKAHMLNOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private List<ALPEBPPAAHL> KHNOIDMCFCN;

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public int? GONPGKDCPIL
			{
				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0x68C6270", Offset = "0x68C5670", VA = "0x1868C6270")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x68C6BD0", Offset = "0x68C5FD0", VA = "0x1868C6BD0")]
			internal FBEFFMHEMBI(string FBBAGJJELPF, string AJFFLGDMGFB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x68C5D10", Offset = "0x68C5110", VA = "0x1868C5D10")]
			public int EOOKHBJJIKP([Optional] int? EDOPPMDGMAM)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x68C5FD0", Offset = "0x68C53D0", VA = "0x1868C5FD0")]
			public List<Dictionary<string, object>> IMBPOGMJMGJ(int OEOMJPNPNCJ, int? EDOPPMDGMAM)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x68C69A0", Offset = "0x68C5DA0", VA = "0x1868C69A0")]
			public void OBOPBFJCLAC(AmplitudeAnalyticsIdentifyMessage ICNDEPGFBMI, bool BJBHDANNIGH = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x68C6890", Offset = "0x68C5C90", VA = "0x1868C6890")]
			public void OBOPBFJCLAC(Dictionary<string, object> ICNDEPGFBMI, bool BJBHDANNIGH = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x68C6A40", Offset = "0x68C5E40", VA = "0x1868C6A40")]
			public void OEKHCAOHNDE(params Dictionary<string, object>[] NIHLBEJIPBA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x68C5850", Offset = "0x68C4C50", VA = "0x1868C5850")]
			public void CLOJGGLHKJP(List<Dictionary<string, object>> AGCDDAJBOCF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x68C5E90", Offset = "0x68C5290", VA = "0x1868C5E90")]
			private void FEMBLKDMCKG(Dictionary<string, object> ICNDEPGFBMI, bool BJBHDANNIGH = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x68C5AA0", Offset = "0x68C4EA0", VA = "0x1868C5AA0")]
			public void ECLAPFECIGO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x68C6310", Offset = "0x68C5710", VA = "0x1868C6310")]
			private void KLNAMNJLOCG([Optional] string KODLAMJNDAP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x68C6760", Offset = "0x68C5B60", VA = "0x1868C6760")]
			private static string LGKAMHBJAFJ(string KKIAKNLLHIO, string KOFPKIJDAMC)
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
			[Cpp2IlInjected.Address(RVA = "0x68CB550", Offset = "0x68CA950", VA = "0x1868CB550")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public struct LGEFHKMMBGK<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public int GKCDAHPLAEJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public string MDPBDMJCHNI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public T GAIAIKCKEEP;
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class ENLBHPJFBKP : IEnumerator<LJHFBCJIPCN>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private LJHFBCJIPCN <>2__current;

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
			private LJHFBCJIPCN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000A4")]
				[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xA21140", Offset = "0xA20540", VA = "0x180A21140")]
			[DebuggerHidden]
			public ENLBHPJFBKP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x68C50A0", Offset = "0x68C44A0", VA = "0x1868C50A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x68C5810", Offset = "0x68C4C10", VA = "0x1868C5810", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class BFNNKEMKBIN : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public PFDOLDLEIBA quitCompletePromise;

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
				[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xA21140", Offset = "0xA20540", VA = "0x180A21140")]
			[DebuggerHidden]
			public BFNNKEMKBIN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x68C45B0", Offset = "0x68C39B0", VA = "0x1868C45B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x68C46D0", Offset = "0x68C3AD0", VA = "0x1868C46D0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class IAILFAAPIGD : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xA21140", Offset = "0xA20540", VA = "0x180A21140")]
			[DebuggerHidden]
			public IAILFAAPIGD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x68C6F10", Offset = "0x68C6310", VA = "0x1868C6F10", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x68C70A0", Offset = "0x68C64A0", VA = "0x1868C70A0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class PJBGAJNNLFB : IEnumerator<LJHFBCJIPCN>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			private LJHFBCJIPCN <>2__current;

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
			private FBEFFMHEMBI <cache>5__2;

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
			private LJHFBCJIPCN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000B6")]
				[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xA21140", Offset = "0xA20540", VA = "0x180A21140")]
			[DebuggerHidden]
			public PJBGAJNNLFB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x68CADD0", Offset = "0x68CA1D0", VA = "0x1868CADD0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x68CB140", Offset = "0x68CA540", VA = "0x1868CB140", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class MNGLONPJCFP : IEnumerator<LJHFBCJIPCN>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			private LJHFBCJIPCN <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public float timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			private FBEFFMHEMBI <cache>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			private string <url>5__2;

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			private LJHFBCJIPCN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000C0")]
				[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0xA21140", Offset = "0xA20540", VA = "0x180A21140")]
			[DebuggerHidden]
			public MNGLONPJCFP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x68C9850", Offset = "0x68C8C50", VA = "0x1868C9850", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x68C9B40", Offset = "0x68C8F40", VA = "0x1868C9B40", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class CGHELOOHBMI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public List<Dictionary<string, object>> batch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			public FBEFFMHEMBI cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
			public CGHELOOHBMI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x68C4710", Offset = "0x68C3B10", VA = "0x1868C4710")]
			internal void BGBGAMMMLPN(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x68C4A80", Offset = "0x68C3E80", VA = "0x1868C4A80")]
			internal void DJAMIKLOJMI(LGEFHKMMBGK<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[CompilerGenerated]
		private sealed class ALADJNIKGBH : IEnumerator<LJHFBCJIPCN>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			private LJHFBCJIPCN <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			public FBEFFMHEMBI cache;

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
			private CGHELOOHBMI <>8__1;

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
			private LJHFBCJIPCN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000C9")]
				[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xA21140", Offset = "0xA20540", VA = "0x180A21140")]
			[DebuggerHidden]
			public ALADJNIKGBH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x68BD270", Offset = "0x68BC670", VA = "0x1868BD270", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x68BDB60", Offset = "0x68BCF60", VA = "0x1868BDB60", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class PCEFNKCFMKK<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x928540", Offset = "0x927940", VA = "0x180928540")]
			public PCEFNKCFMKK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x240F6F0", Offset = "0x240EAF0", VA = "0x18240F6F0")]
			internal LGEFHKMMBGK<T> LKJFMNBNDHB(JDOBNEPGPBO postResponse)
			{
				return default(LGEFHKMMBGK<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private sealed class KOPHKEBFJOB<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x928540", Offset = "0x927940", VA = "0x180928540")]
			public KOPHKEBFJOB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x240F6F0", Offset = "0x240EAF0", VA = "0x18240F6F0")]
			internal LGEFHKMMBGK<T> ABALEDOEMCP(JDOBNEPGPBO postResponse)
			{
				return default(LGEFHKMMBGK<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private HNFFDGDJOBC GCGGFFKCFHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private Lazy<KABDAIIIKJE> MBGEFMFLDJA;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private const string ILOGGGJGALI = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const string MMGDNFDCIMI = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private const string DHCGPKKCMPA = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private const int JHLKEKFMKGD = 15;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private const int EHLGNJDNEMC = 10;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private const int DBCCGBAKMGM = 5;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private const float BLBMENJHNHE = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private const long ELOBNIAILDL = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private const string ACIIJGLEIJM = "f1779b982f1c09aed3adb3cca563cbc2";

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private const string OMODBKEBIHJ = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static bool BHOINKAEJOB;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static bool KMPIAAEJNJA;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static int HDKBLMFBMLG;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static int LPGMCKMHFOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private IPLAJFBCEKM LOHPKGGGBIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private bool NOEFFLKJHHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private float BJAAGBEELEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private float DDJMKNAJJBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private int MNBLOEEIMIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private int DJNGDBKAOKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private int? GOJJDHJFFMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private int? NNBFFENHKFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private long EICIKBPHFEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private string IHILEHCKAKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private bool CNBDCKAFOAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private long IAPDIHKDJFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private Dictionary<string, object> HGPFCLIABGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private DLMDFKDMOIN HMDGDBJHCLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private int MALGAHNLFKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private int OKBMPHJMOKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private float DMFADAIAPLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private bool JIKKJHBEADD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private bool BLJPJILNJKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private FBEFFMHEMBI HKKEPFOOACK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private FBEFFMHEMBI EDKMCHHKKHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private FBEFFMHEMBI DLCFJMPDNHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> NOKDKCLJNCO;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo DCHMJOFMPEI;

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private static string GJHEKDIPLHD;

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private const string CBAJNOAHNDO = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private readonly string GICLBFNDJAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private readonly string NOOPJOAGJCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly string HBLPNKPLKMK;

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private HNFFDGDJOBC NOOJCKCEFFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x68C0680", Offset = "0x68BFA80", VA = "0x1868C0680")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private KABDAIIIKJE OCCBFKLOIGH
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x68C1230", Offset = "0x68C0630", VA = "0x1868C1230")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private static int DOABLKOJAJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x68C1060", Offset = "0x68C0460", VA = "0x1868C1060")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static long KILJENFAIPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x68C2EE0", Offset = "0x68C22E0", VA = "0x1868C2EE0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x68C2FE0", Offset = "0x68C23E0", VA = "0x1868C2FE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static string DENFCEFDKPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x68C2E80", Offset = "0x68C2280", VA = "0x1868C2E80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static string KGLLBKGKONP
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x68C2EB0", Offset = "0x68C22B0", VA = "0x1868C2EB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public string GPNHPBOBALG
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x9BC180", Offset = "0x9BB580", VA = "0x1809BC180")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xDD8850", Offset = "0xDD7C50", VA = "0x180DD8850")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public int? KBJKAPCMHCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x905C80", Offset = "0x905080", VA = "0x180905C80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x905F80", Offset = "0x905380", VA = "0x180905F80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool OGIDDLMDMBC
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x9FB350", Offset = "0x9FA750", VA = "0x1809FB350")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x9F9370", Offset = "0x9F8770", VA = "0x1809F9370")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static bool NPJIOPIEOJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x68C2DF0", Offset = "0x68C21F0", VA = "0x1868C2DF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> ECNNDFOPLNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x68C2D50", Offset = "0x68C2150", VA = "0x1868C2D50")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x68C2F40", Offset = "0x68C2340", VA = "0x1868C2F40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x68BEC30", Offset = "0x68BE030", VA = "0x1868BEC30", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x68C0270", Offset = "0x68BF670", VA = "0x1868C0270")]
		private void LCKLOPLLEGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x68C2480", Offset = "0x68C1880", VA = "0x1868C2480")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x68C1710", Offset = "0x68C0B10", VA = "0x1868C1710", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x68C2760", Offset = "0x68C1B60", VA = "0x1868C2760")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x68C1920", Offset = "0x68C0D20", VA = "0x1868C1920")]
		public CCKGNGCPCCF PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x68C0020", Offset = "0x68BF420", VA = "0x1868C0020")]
		[IteratorStateMachine(typeof(ENLBHPJFBKP))]
		public IEnumerator<LJHFBCJIPCN> Initialize(AmplitudeAnalyticsEvent DHPGLJDCGIE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x68C2660", Offset = "0x68C1A60", VA = "0x1868C2660")]
		public void UpdateLastAliveTime(float DOCNBLMOCCC = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x68C06F0", Offset = "0x68BFAF0", VA = "0x1868C06F0")]
		private CCKGNGCPCCF LPKBLAMCHBE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x68C17B0", Offset = "0x68C0BB0", VA = "0x1868C17B0")]
		private CCKGNGCPCCF PADJJGKAOLH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x68C1F80", Offset = "0x68C1380", VA = "0x1868C1F80")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x68C1280", Offset = "0x68C0680", VA = "0x1868C1280")]
		[IteratorStateMachine(typeof(BFNNKEMKBIN))]
		private IEnumerator NJMGKCKIJDG(PFDOLDLEIBA HCNENNMONIG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x68C29E0", Offset = "0x68C1DE0", VA = "0x1868C29E0")]
		[IteratorStateMachine(typeof(IAILFAAPIGD))]
		public IEnumerator WaitForFlush(float ECADEOGJFGK = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x68C2540", Offset = "0x68C1940", VA = "0x1868C2540")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x68C2490", Offset = "0x68C1890", VA = "0x1868C2490")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime FEDAMNGKFGH)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x68BFC70", Offset = "0x68BF070", VA = "0x1868BFC70")]
		public static LIFJNHIGDCJ Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x68BEAD0", Offset = "0x68BDED0", VA = "0x1868BEAD0")]
		public static KPPJDLMHEII AccountSelectionPostLoginEvent([NotNull] string LCGFNKKPOKD, string OFOLDFODADE, bool DGKFGGLAEJK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x68BF500", Offset = "0x68BE900", VA = "0x1868BF500")]
		public static KPPJDLMHEII Event([NotNull] string LCGFNKKPOKD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x68C1AE0", Offset = "0x68C0EE0", VA = "0x1868C1AE0")]
		public static KPPJDLMHEII PreviousSessionEvent([NotNull] string LCGFNKKPOKD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x68BFDA0", Offset = "0x68BF1A0", VA = "0x1868BFDA0")]
		public static KPPJDLMHEII InitializeEvent(string OFOLDFODADE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x68C2160", Offset = "0x68C1560", VA = "0x1868C2160")]
		public static KPPJDLMHEII StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x68BEF20", Offset = "0x68BE320", VA = "0x1868BEF20")]
		public static KPPJDLMHEII CreateOutOfSessionEvent(string LCGFNKKPOKD, bool EJCLLFLPFGH = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x68C0A60", Offset = "0x68BFE60", VA = "0x1868C0A60")]
		public static CCKGNGCPCCF LogOutOfSessionEvent(KPPJDLMHEII PKFCJMGMIEL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x68C07C0", Offset = "0x68BFBC0", VA = "0x1868C07C0")]
		public void LogEventAsync(AmplitudeAnalyticsEvent BIEFLDJCMDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x68C0D50", Offset = "0x68C0150", VA = "0x1868C0D50")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent BIEFLDJCMDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x68C0EA0", Offset = "0x68C02A0", VA = "0x1868C0EA0")]
		public void LogSerializedEventAsync(Dictionary<string, object> CDLMBCAEBPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x68C0910", Offset = "0x68BFD10", VA = "0x1868C0910")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage HMHEDIKAEHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x68BF6F0", Offset = "0x68BEAF0", VA = "0x1868BF6F0")]
		private void FHGAFCOICIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x68BF1D0", Offset = "0x68BE5D0", VA = "0x1868BF1D0")]
		private void DAOMFJBBGOE(Dictionary<string, object> EKEKBDMMIBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x68C1310", Offset = "0x68C0710", VA = "0x1868C1310")]
		private void OBACGGIDCOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x68C1410", Offset = "0x68C0810", VA = "0x1868C1410")]
		private void OCOJBICCIID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x68BF7E0", Offset = "0x68BEBE0", VA = "0x1868BF7E0")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x68BF480", Offset = "0x68BE880", VA = "0x1868BF480")]
		[IteratorStateMachine(typeof(PJBGAJNNLFB))]
		private IEnumerator<LJHFBCJIPCN> EFNAHIAOAII(float ECADEOGJFGK = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x68BEA50", Offset = "0x68BDE50", VA = "0x1868BEA50")]
		[IteratorStateMachine(typeof(MNGLONPJCFP))]
		private IEnumerator<LJHFBCJIPCN> AGHPGIDMGDP(float ECADEOGJFGK = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x68C0F80", Offset = "0x68C0380", VA = "0x1868C0F80")]
		[IteratorStateMachine(typeof(ALADJNIKGBH))]
		private IEnumerator<LJHFBCJIPCN> MDACHFBLPHI(FBEFFMHEMBI ILGBPFIMIFJ, int? EDOPPMDGMAM, string MBKCCFIECLE, string PEBNPPCNHFM, float ECADEOGJFGK, Action<int> KPPEJKFFGLI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x68C15F0", Offset = "0x68C09F0", VA = "0x1868C15F0")]
		private static void OKHFHLEMKBB(bool HHBDPHOLHOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x68BF870", Offset = "0x68BEC70", VA = "0x1868BF870")]
		private MCFFIFIPNKE<LGEFHKMMBGK<Dictionary<string, object>>> ICMICOPKEBM(string MBKCCFIECLE, string PEBNPPCNHFM, string DBGAEGOOMHI, string IDEHILBKPPE, Dictionary<string, object> GAIAIKCKEEP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x68BF9A0", Offset = "0x68BEDA0", VA = "0x1868BF9A0")]
		private MCFFIFIPNKE<LGEFHKMMBGK<List<Dictionary<string, object>>>> ICMICOPKEBM(string MBKCCFIECLE, string PEBNPPCNHFM, string DBGAEGOOMHI, string IDEHILBKPPE, List<Dictionary<string, object>> GAIAIKCKEEP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x3036440", Offset = "0x3035840", VA = "0x183036440")]
		private MCFFIFIPNKE<LGEFHKMMBGK<T>> CCMAGFBNFPK<T>(string MBKCCFIECLE, string PEBNPPCNHFM, string IDEHILBKPPE, T GAIAIKCKEEP, Dictionary<string, object> INHOFKCFFHC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x30366D0", Offset = "0x3035AD0", VA = "0x1830366D0")]
		private MCFFIFIPNKE<LGEFHKMMBGK<T>> KJIBCAJBHIB<T>(string MBKCCFIECLE, string PEBNPPCNHFM, string DBGAEGOOMHI, T GAIAIKCKEEP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x68C0220", Offset = "0x68BF620", VA = "0x1868C0220")]
		private bool JOJMAIAGGCN(float HKHMFAHPKCM, float ECADEOGJFGK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x68BDD80", Offset = "0x68BD180", VA = "0x1868BDD80")]
		private Dictionary<string, object> ADBAIOJDGEP(string PEBNPPCNHFM, Dictionary<string, object> GAIAIKCKEEP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x68C2AC0", Offset = "0x68C1EC0", VA = "0x1868C2AC0")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x68C00B0", Offset = "0x68BF4B0", VA = "0x1868C00B0")]
		[CompilerGenerated]
		private long JEOPNFNEOJE()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x68C0210", Offset = "0x68BF610", VA = "0x1868C0210")]
		[CompilerGenerated]
		private void JIJPBAELDCH(int DJMOHDMFOMN)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class MJOFBGBOILP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private long NOOADCEHGDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private KPPJDLMHEII OFOKGNCAMLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private bool MKJGEENAIKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private float FFNNAKNMNMO;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x68C96B0", Offset = "0x68C8AB0", VA = "0x1868C96B0")]
	public MJOFBGBOILP(string NNHBPDAAPID, float FFNNAKNMNMO = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x24AC730", Offset = "0x24ABB30", VA = "0x1824AC730")]
	public void FBGHDJFLGJP<T>(string HNNIGEFAIIM, T KKIAKNLLHIO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x68C9450", Offset = "0x68C8850", VA = "0x1868C9450")]
	public void FBGHDJFLGJP(string HNNIGEFAIIM, string KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x68C9310", Offset = "0x68C8710", VA = "0x1868C9310")]
	public void AKLILFALJIB(string LLECCGOIJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x68C94D0", Offset = "0x68C88D0", VA = "0x1868C94D0")]
	public void GHJBFLBMECA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x68C9590", Offset = "0x68C8990", VA = "0x1868C9590")]
	private void NMNMMPJKEEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x68C9400", Offset = "0x68C8800", VA = "0x1868C9400")]
	private bool DENMFABANGO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public enum CPMDLJCIJAG
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
public class OENLOFNNKDE : FNILEFLGOHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private FNILEFLGOHF BLEKOJGKGCJ;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private FNILEFLGOHF JNJIAANLANL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x68CA550", Offset = "0x68C9950", VA = "0x1868CA550")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool MADHFPDLGFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x68C9FF0", Offset = "0x68C93F0", VA = "0x1868C9FF0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action BCFHFCJCPHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x68CA660", Offset = "0x68C9A60", VA = "0x1868CA660", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x68CA5C0", Offset = "0x68C99C0", VA = "0x1868CA5C0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action DCBLGLMNPKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x68CA7A0", Offset = "0x68C9BA0", VA = "0x1868CA7A0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x68CA4B0", Offset = "0x68C98B0", VA = "0x1868CA4B0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	[UnityEngine.Scripting.Preserve]
	public OENLOFNNKDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x68CA440", Offset = "0x68C9840", VA = "0x1868CA440")]
	[GHLDKGGJCDP(FGNCLGKDFDK.GameOnly)]
	private static void GMGNMHCNENI(EPBOEGFMAOO OHJGEOICJDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x68CA840", Offset = "0x68C9C40", VA = "0x1868CA840")]
	[GHLDKGGJCDP(FGNCLGKDFDK.EditorOnly)]
	private static void PLFPBAFCPJK(EPBOEGFMAOO OHJGEOICJDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x68C9D10", Offset = "0x68C9110", VA = "0x1868C9D10", Slot = "8")]
	public CCKGNGCPCCF BEFDPLAELIH(string GADAFGLCMAF, string AJFFLGDMGFB, [Optional] JFGALGDBDKE CLEOHOBGHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x68C9C10", Offset = "0x68C9010", VA = "0x1868C9C10", Slot = "10")]
	public CCKGNGCPCCF ACJOGLJLGAH(JFGALGDBDKE CLEOHOBGHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x68CA140", Offset = "0x68C9540", VA = "0x1868CA140", Slot = "11")]
	public CCKGNGCPCCF DHCLMOKMHCK(JFGALGDBDKE CLEOHOBGHDL, Dictionary<string, string> ANGDKJLJPKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x68CA700", Offset = "0x68C9B00", VA = "0x1868CA700", Slot = "12")]
	public bool NGOPNEALIND(string FLBMHOIKOLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x68CA340", Offset = "0x68C9740", VA = "0x1868CA340", Slot = "13")]
	public BHOLDNNHHOC FDHAFAKBNLG(string HAFNPEPNEFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x68CA040", Offset = "0x68C9440", VA = "0x1868CA040", Slot = "14")]
	public AEACHBPJCEL CFIMOKNMHGK(string NKKNJAICNOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x68CA250", Offset = "0x68C9650", VA = "0x1868CA250", Slot = "15")]
	public CCKGNGCPCCF EMDNIBPNEGH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0xB77160", Offset = "0xB76560", VA = "0x180B77160")]
	[CompilerGenerated]
	private void FGLGFPPMPOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0xC220E0", Offset = "0xC214E0", VA = "0x180C220E0")]
	[CompilerGenerated]
	private void BCOEOKFMJCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class MGLDPDAEODB : FNILEFLGOHF
{
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static readonly IReadOnlyDictionary<string, PAOKGMMDNDC> FLMONMHJGPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private bool GJCCMHBHJNF;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool MADHFPDLGFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xA2ED20", Offset = "0xA2E120", VA = "0x180A2ED20", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action BCFHFCJCPHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x68C8D90", Offset = "0x68C8190", VA = "0x1868C8D90", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x68C8CF0", Offset = "0x68C80F0", VA = "0x1868C8CF0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action DCBLGLMNPKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x68C9110", Offset = "0x68C8510", VA = "0x1868C9110", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x68C8C50", Offset = "0x68C8050", VA = "0x1868C8C50", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x68C7830", Offset = "0x68C6C30", VA = "0x1868C7830", Slot = "8")]
	public CCKGNGCPCCF BEFDPLAELIH(string GADAFGLCMAF, string AJFFLGDMGFB, [Optional] JFGALGDBDKE CLEOHOBGHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x68C8220", Offset = "0x68C7620", VA = "0x1868C8220", Slot = "15")]
	public CCKGNGCPCCF EMDNIBPNEGH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x68C7580", Offset = "0x68C6980", VA = "0x1868C7580", Slot = "10")]
	public CCKGNGCPCCF ACJOGLJLGAH(JFGALGDBDKE CLEOHOBGHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x68C7F30", Offset = "0x68C7330", VA = "0x1868C7F30", Slot = "11")]
	public CCKGNGCPCCF DHCLMOKMHCK(JFGALGDBDKE CLEOHOBGHDL, Dictionary<string, string> ANGDKJLJPKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x68C9060", Offset = "0x68C8460", VA = "0x1868C9060", Slot = "12")]
	public bool NGOPNEALIND(string FLBMHOIKOLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x68C83B0", Offset = "0x68C77B0", VA = "0x1868C83B0", Slot = "13")]
	public BHOLDNNHHOC FDHAFAKBNLG(string HAFNPEPNEFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x68C7CD0", Offset = "0x68C70D0", VA = "0x1868C7CD0", Slot = "14")]
	public AEACHBPJCEL CFIMOKNMHGK(string NKKNJAICNOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x68C84D0", Offset = "0x68C78D0", VA = "0x1868C84D0")]
	private NOCLKCIKBEC HEGGHONOBNI(JFGALGDBDKE CLEOHOBGHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x68C7D90", Offset = "0x68C7190", VA = "0x1868C7D90")]
	private HNGLOFGADAE CGBDELECMHN(string AJFFLGDMGFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x68C8E30", Offset = "0x68C8230", VA = "0x1868C8E30")]
	private void NDNGBBBAKBL(string HAFNPEPNEFG, BHOLDNNHHOC DPEGKOHKGDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x68C92E0", Offset = "0x68C86E0", VA = "0x1868C92E0")]
	public MGLDPDAEODB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0xB944B0", Offset = "0xB938B0", VA = "0x180B944B0")]
	[CompilerGenerated]
	private void IPMDGKFCJIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x68C77A0", Offset = "0x68C6BA0", VA = "0x1868C77A0")]
	[CompilerGenerated]
	private void AOJLNLPPOIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x68C8BC0", Offset = "0x68C7FC0", VA = "0x1868C8BC0")]
	[CompilerGenerated]
	private void JHBLGMJAOHB()
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
			[Cpp2IlInjected.Address(RVA = "0x7E8110", Offset = "0x7E7510", VA = "0x1807E8110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x7E8120", Offset = "0x7E7520", VA = "0x1807E8120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x68CB300", Offset = "0x68CA700", VA = "0x1868CB300", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface FNILEFLGOHF
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	bool MADHFPDLGFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action BCFHFCJCPHE;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action DCBLGLMNPKE;

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "4")]
	CCKGNGCPCCF BEFDPLAELIH(string GADAFGLCMAF, string AJFFLGDMGFB, [Optional] JFGALGDBDKE CLEOHOBGHDL);

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "6")]
	CCKGNGCPCCF ACJOGLJLGAH(JFGALGDBDKE CLEOHOBGHDL);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "7")]
	CCKGNGCPCCF DHCLMOKMHCK(JFGALGDBDKE CLEOHOBGHDL, Dictionary<string, string> ANGDKJLJPKB);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool NGOPNEALIND(string FLBMHOIKOLM);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	BHOLDNNHHOC FDHAFAKBNLG(string HAFNPEPNEFG);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	AEACHBPJCEL CFIMOKNMHGK(string NKKNJAICNOF);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	CCKGNGCPCCF EMDNIBPNEGH();
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class OIHLPODEGJG : FNILEFLGOHF
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool MADHFPDLGFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x7FFD60", Offset = "0x7FF160", VA = "0x1807FFD60", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action BCFHFCJCPHE
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x68CAC90", Offset = "0x68CA090", VA = "0x1868CAC90", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x68CABF0", Offset = "0x68C9FF0", VA = "0x1868CABF0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action DCBLGLMNPKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x68CAD30", Offset = "0x68CA130", VA = "0x1868CAD30", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x68CAB50", Offset = "0x68C9F50", VA = "0x1868CAB50", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	[RecRoom.NoEngine.Common.Preserve]
	public OIHLPODEGJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x68CA950", Offset = "0x68C9D50", VA = "0x1868CA950", Slot = "8")]
	public CCKGNGCPCCF BEFDPLAELIH(string GADAFGLCMAF, string AJFFLGDMGFB, [Optional] JFGALGDBDKE CLEOHOBGHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x68CA8B0", Offset = "0x68C9CB0", VA = "0x1868CA8B0", Slot = "10")]
	public CCKGNGCPCCF ACJOGLJLGAH(JFGALGDBDKE CLEOHOBGHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x68CAA00", Offset = "0x68C9E00", VA = "0x1868CAA00", Slot = "11")]
	public CCKGNGCPCCF DHCLMOKMHCK(JFGALGDBDKE CLEOHOBGHDL, Dictionary<string, string> ANGDKJLJPKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x7F2D20", Offset = "0x7F2120", VA = "0x1807F2D20", Slot = "12")]
	public bool NGOPNEALIND(string FLBMHOIKOLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x68CAB40", Offset = "0x68C9F40", VA = "0x1868CAB40", Slot = "13")]
	public BHOLDNNHHOC FDHAFAKBNLG(string HAFNPEPNEFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x68CA9F0", Offset = "0x68C9DF0", VA = "0x1868CA9F0", Slot = "14")]
	public AEACHBPJCEL CFIMOKNMHGK(string NKKNJAICNOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x68CAAA0", Offset = "0x68C9EA0", VA = "0x1868CAAA0", Slot = "15")]
	public CCKGNGCPCCF EMDNIBPNEGH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface JFGALGDBDKE
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	bool MELCNENFOPD
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	bool ABFHMDHIIIK
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	bool BOPPEANLKGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	bool? JACOPIGKMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	int? KBJKAPCMHCI
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	int EOGOECNODNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	string HCMCFFPNLMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	string KDHMHLOLAFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	string PNMJKGEFLNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	long FCIGPLGKCIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	string PNCCONKMJHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	string AAHPHHKDDHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	string APENFJBPEJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	string ELPJGDEOLPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	double KLNBPJGJKOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface IPEEOCJIJGL
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	long GGKIOGLEFMD
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	long OOHHBNLJDHA();

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BPEOPLHNDMA(long GLHEAIAHIPL, bool PBPFADAMMEF = true);

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EDOCIPOLFMC(string JNNDIHFHMHC, string PGOFBKKEOEI, string JFIJHMFLJBB);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OHHCANADFOK(string JNNDIHFHMHC);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CKPHJOEMJKC(string JNNDIHFHMHC, string FABIPLMALDO, string KDLHBMBFJMM);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DEKGEAAJPFI(string BJPOABKANKB, object OPPBECMJBBL, object JCKALIKKBAH);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface CFIPPMIMEBO
{
	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MJOFBGBOILP HCAGKECHOJE(string NNHBPDAAPID);
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

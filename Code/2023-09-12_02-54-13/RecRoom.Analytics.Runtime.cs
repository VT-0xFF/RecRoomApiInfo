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
		[Cpp2IlInjected.Address(RVA = "0x8CB040", Offset = "0x8CA440", VA = "0x1808CB040")]
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
		[Cpp2IlInjected.Address(RVA = "0x6ADF9C0", Offset = "0x6ADEDC0", VA = "0x186ADF9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA6EFA0", Offset = "0xA6E3A0", VA = "0x180A6EFA0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class EFGIJPEIJFI
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> GCLCNKFKFAI;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6ADB490", Offset = "0x6ADA890", VA = "0x186ADB490")]
	internal static bool IGLHAOOBGGB(string PMMAAICOJOP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface OIIDBHBDBEJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool BAHNPNJODGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string LHKAGPHNJEA
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	string CHLOPBPLACH
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	string NJFMPLIFCOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	string CNIEICAFIKO
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	KDCMFGDLEKL<APCBECOJLFJ> JFHIANHMIEA(string ELKGMMLGIKO, Dictionary<string, string> OFNMBGEHIKL, bool CNEBGNCILKL = false);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	KDCMFGDLEKL<APCBECOJLFJ> LNGLAMGCHOF(string ELKGMMLGIKO, string EIPGELPOKCO, string CPHKBPHDELC, string IJIMADNMGPE);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct APCBECOJLFJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly int JGOMALKDEIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly string GPHDHGKOLKK;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xBF1A50", Offset = "0xBF0E50", VA = "0x180BF1A50")]
	public APCBECOJLFJ(int MKAGDIMDGAP, string GKIEPBICIHI)
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
		public AmplitudeAnalyticsClient.Settings CPLEPEBLCAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x9C56F0", Offset = "0x9C4AF0", VA = "0x1809C56F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool GDNJFCGNFEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x11C5C30", Offset = "0x11C5030", VA = "0x1811C5C30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x976820", Offset = "0x975C20", VA = "0x180976820")]
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
			[Cpp2IlInjected.Address(RVA = "0x6ADAA60", Offset = "0x6AD9E60", VA = "0x186ADAA60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x6ADAB30", Offset = "0x6AD9F30", VA = "0x186ADAB30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static string StableId
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6ADAAA0", Offset = "0x6AD9EA0", VA = "0x186ADAAA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6ADAB80", Offset = "0x6AD9F80", VA = "0x186ADAB80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static string ClientLauncher
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6ADAA20", Offset = "0x6AD9E20", VA = "0x186ADAA20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6ADAAE0", Offset = "0x6AD9EE0", VA = "0x186ADAAE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x9B7D80", Offset = "0x9B7180", VA = "0x1809B7D80")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6AD9F00", Offset = "0x6AD9300", VA = "0x186AD9F00")]
		public static PBNOGICFNJJ DEDAFMGEJMH(string LJJHJABONIO, [NotNull] string EPHAAOEPCGL, long NNILKGIDMKL, long MLEMEKPLMEJ, string JEJLDCJDABJ, bool JJJCLEGADAM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6ADA530", Offset = "0x6AD9930", VA = "0x186ADA530")]
		public static PBNOGICFNJJ MHCDNFMMPDJ(string LJJHJABONIO, [NotNull] string EPHAAOEPCGL, long NNILKGIDMKL, long MLEMEKPLMEJ, string JEJLDCJDABJ, long CCKBHJOEAPA, bool JJJCLEGADAM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6ADA840", Offset = "0x6AD9C40", VA = "0x186ADA840")]
		private AmplitudeAnalyticsEvent(string LJJHJABONIO, [NotNull] string EPHAAOEPCGL, long NNILKGIDMKL, long MLEMEKPLMEJ, string JEJLDCJDABJ, bool JJJCLEGADAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xA7C9F0", Offset = "0xA7BDF0", VA = "0x180A7C9F0")]
		public void DEMBFFDKNHG(long JPCGPDOOJFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6ADA640", Offset = "0x6AD9A40", VA = "0x186ADA640", Slot = "5")]
		public override void NKNDPDOBPOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6AD9DA0", Offset = "0x6AD91A0", VA = "0x186AD9DA0", Slot = "6")]
		public override void CFKDPGALPNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6AD9FF0", Offset = "0x6AD93F0", VA = "0x186AD9FF0", Slot = "4")]
		protected override Dictionary<string, object> KPLLGKLMHCL(Dictionary<string, object> NOIPAJJKALN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6ADA730", Offset = "0x6AD9B30", VA = "0x186ADA730")]
		private void PGLLAKDECCB(string PMMAAICOJOP, string AGLCIEKHLEE, bool FJPDCDBMNPE = false)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class JAIIGBIKFAP : DNAEJILKDLL<AmplitudeAnalyticsIdentifyMessage, JAIIGBIKFAP>
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override JAIIGBIKFAP EEINDHKOMFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x1166610", Offset = "0x1165A10", VA = "0x181166610", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x9FC8D0", Offset = "0x9FBCD0", VA = "0x1809FC8D0", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage IBJDKDMOLHK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6ADC3D0", Offset = "0x6ADB7D0", VA = "0x186ADC3D0")]
	public JAIIGBIKFAP(AmplitudeAnalyticsIdentifyMessage FHDJIGKOLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6ADC360", Offset = "0x6ADB760", VA = "0x186ADC360", Slot = "4")]
	public override void CFKDPGALPNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class PBNOGICFNJJ : DNAEJILKDLL<AmplitudeAnalyticsEvent, PBNOGICFNJJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private bool ILENGLHDKMO;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override PBNOGICFNJJ EEINDHKOMFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1166610", Offset = "0x1165A10", VA = "0x181166610", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public long BJLOHGBIHME
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x1FE0300", Offset = "0x1FDF700", VA = "0x181FE0300")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6AE19A0", Offset = "0x6AE0DA0", VA = "0x186AE19A0")]
	public PBNOGICFNJJ(AmplitudeAnalyticsEvent FHDJIGKOLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x9FC8D0", Offset = "0x9FBCD0", VA = "0x1809FC8D0", Slot = "5")]
	public override AmplitudeAnalyticsEvent IBJDKDMOLHK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6AE2470", Offset = "0x6AE1870", VA = "0x186AE2470", Slot = "4")]
	public override void CFKDPGALPNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2043790", Offset = "0x2042B90", VA = "0x182043790")]
	public PBNOGICFNJJ PCGCGCEGEJN<T>(string LEMJCNJPDLJ, T[] AGLCIEKHLEE) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6AE2670", Offset = "0x6AE1A70", VA = "0x186AE2670")]
	public PBNOGICFNJJ PCGCGCEGEJN(string LEMJCNJPDLJ, string[] AGLCIEKHLEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2043720", Offset = "0x2042B20", VA = "0x182043720")]
	public PBNOGICFNJJ PCGCGCEGEJN<T>(string LEMJCNJPDLJ, T AGLCIEKHLEE) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6AE25E0", Offset = "0x6AE19E0", VA = "0x186AE25E0")]
	public PBNOGICFNJJ PCGCGCEGEJN(string LEMJCNJPDLJ, long AGLCIEKHLEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6AE2680", Offset = "0x6AE1A80", VA = "0x186AE2680")]
	public PBNOGICFNJJ PCGCGCEGEJN(string LEMJCNJPDLJ, string AGLCIEKHLEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6AE2510", Offset = "0x6AE1910", VA = "0x186AE2510")]
	public PBNOGICFNJJ FOCGBHMEAPN(string LEMJCNJPDLJ, object? AGLCIEKHLEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6AE2540", Offset = "0x6AE1940", VA = "0x186AE2540")]
	public PBNOGICFNJJ HAGLKDAOCAO(string LEMJCNJPDLJ, string AGLCIEKHLEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6AE2370", Offset = "0x6AE1770", VA = "0x186AE2370")]
	private PBNOGICFNJJ BPKOOBHHMJA(string LEMJCNJPDLJ, object AGLCIEKHLEE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class OKDFGJLNOOH : PBNOGICFNJJ
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6AE19A0", Offset = "0x6AE0DA0", VA = "0x186AE19A0")]
	public OKDFGJLNOOH(AmplitudeAnalyticsEvent FHDJIGKOLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6AE1810", Offset = "0x6AE0C10", VA = "0x186AE1810", Slot = "4")]
	public override void CFKDPGALPNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class DNAEJILKDLL<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : DNAEJILKDLL<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected M FHDJIGKOLJM;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public abstract BLDR EEINDHKOMFM
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1314980", Offset = "0x1313D80", VA = "0x181314980")]
	public DNAEJILKDLL(M FHDJIGKOLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2E6E790", Offset = "0x2E6DB90", VA = "0x182E6E790")]
	public BLDR EKAIFGLDHEA(AmplitudeAnalyticsIdentifyMessage.DeviceInfo FMLFKMKOHEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2E6E800", Offset = "0x2E6DC00", VA = "0x182E6E800")]
	public BLDR GFHGKEDGNFF(AmplitudeAnalyticsIdentifyMessage.RevenueData EGBAFBICKHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2E6E940", Offset = "0x2E6DD40", VA = "0x182E6E940")]
	public BLDR KGCBFGEJKLO(string LEMJCNJPDLJ, string AGLCIEKHLEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x214B410", Offset = "0x214A810", VA = "0x18214B410")]
	public BLDR KGCBFGEJKLO<T>(string LEMJCNJPDLJ, T AGLCIEKHLEE) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void CFKDPGALPNC();

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2E6E7D0", Offset = "0x2E6DBD0", VA = "0x182E6E7D0")]
	internal static string GDCCMPBMEOC(string AGLCIEKHLEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2E6E840", Offset = "0x2E6DC40", VA = "0x182E6E840")]
	private BLDR KBGEJFKCLBM(string LEMJCNJPDLJ, object AGLCIEKHLEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M IBJDKDMOLHK();
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
			[Cpp2IlInjected.Address(RVA = "0x6ADB310", Offset = "0x6ADA710", VA = "0x186ADB310")]
			public void PLBIEADMDGG(Dictionary<string, object> JMABDBFEBIM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
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
			[Cpp2IlInjected.Address(RVA = "0x6AE26F0", Offset = "0x6AE1AF0", VA = "0x186AE26F0")]
			public void PLBIEADMDGG(Dictionary<string, object> MBEHPDIJFCC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6AE2860", Offset = "0x6AE1C60", VA = "0x186AE2860")]
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
			[Cpp2IlInjected.Address(RVA = "0x81F0B0", Offset = "0x81E4B0", VA = "0x18081F0B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x8BBD20", Offset = "0x8BB120", VA = "0x1808BBD20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6ADAD40", Offset = "0x6ADA140", VA = "0x186ADAD40")]
		public static JAIIGBIKFAP DEDAFMGEJMH(string LJJHJABONIO, string JEJLDCJDABJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6ADB210", Offset = "0x6ADA610", VA = "0x186ADB210")]
		protected AmplitudeAnalyticsIdentifyMessage(string LJJHJABONIO, string JEJLDCJDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6ADB130", Offset = "0x6ADA530", VA = "0x186ADB130")]
		public Dictionary<string, object> LNNJIFAOFJI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6ADADF0", Offset = "0x6ADA1F0", VA = "0x186ADADF0", Slot = "4")]
		protected virtual Dictionary<string, object> KPLLGKLMHCL(Dictionary<string, object> NOIPAJJKALN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6ADABD0", Offset = "0x6AD9FD0", VA = "0x186ADABD0")]
		protected void BKHPAECACGP(string PMMAAICOJOP, Dictionary<string, object> PNFGPAJJNLK, Dictionary<string, object> BFEFKDPPAPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6ADACD0", Offset = "0x6ADA0D0", VA = "0x186ADACD0")]
		protected void CJFHADNODMP(string PMMAAICOJOP, string AGLCIEKHLEE, Dictionary<string, object> DIODANPKJHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6ADB1B0", Offset = "0x6ADA5B0", VA = "0x186ADB1B0", Slot = "5")]
		public virtual void NKNDPDOBPOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6ADAC80", Offset = "0x6ADA080", VA = "0x186ADAC80", Slot = "6")]
		public virtual void CFKDPGALPNC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		private enum ODKINFNCDFN
		{
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		internal class JOAKPNLDJCM
		{
			[Cpp2IlInjected.Token(Token = "0x2000015")]
			private class OBEIKPDCMJK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000067")]
				public int FLDGAHFGMPI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000068")]
				public Dictionary<string, object> BCLENALNFON;

				[Cpp2IlInjected.Token(Token = "0x6000098")]
				[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
				public OBEIKPDCMJK()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000016")]
			[CompilerGenerated]
			private sealed class JPDLBPHBHII
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000069")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000099")]
				[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
				public JPDLBPHBHII()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600009A")]
				[Cpp2IlInjected.Address(RVA = "0x6ADD930", Offset = "0x6ADCD30", VA = "0x186ADD930")]
				internal bool MPEKPHAMGBJ(OBEIKPDCMJK item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private const string MGJOHPDFMFO = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			private readonly string GBGNJPBFOBA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private List<OBEIKPDCMJK> BGKDEBKKBAN;

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public int? KCIHCAJCFLK
			{
				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0x6ADD490", Offset = "0x6ADC890", VA = "0x186ADD490")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x6ADD7A0", Offset = "0x6ADCBA0", VA = "0x186ADD7A0")]
			internal JOAKPNLDJCM(string GJGCNDPHKBP, string MIIILCFGIOO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x6ADC7B0", Offset = "0x6ADBBB0", VA = "0x186ADC7B0")]
			public int EPMBINNKLGF([Optional] int? IDDPCPHMGPD)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x6ADD1F0", Offset = "0x6ADC5F0", VA = "0x186ADD1F0")]
			public List<Dictionary<string, object>> NDBAKMBDPKJ(int CDOBEBBAGBN, int? IDDPCPHMGPD)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x6ADCBD0", Offset = "0x6ADBFD0", VA = "0x186ADCBD0")]
			public void IBKBIOFNHAE(AmplitudeAnalyticsIdentifyMessage HFAGBIOODHL, bool MPOGFJCICIB = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x6ADCAC0", Offset = "0x6ADBEC0", VA = "0x186ADCAC0")]
			public void IBKBIOFNHAE(Dictionary<string, object> HFAGBIOODHL, bool MPOGFJCICIB = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x6ADC930", Offset = "0x6ADBD30", VA = "0x186ADC930")]
			public void HIOCLFCDNLF(params Dictionary<string, object>[] FMNIEGMDIGB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x6ADC560", Offset = "0x6ADB960", VA = "0x186ADC560")]
			public void CIKAGAIAJLD(List<Dictionary<string, object>> EJDDMEACCHN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x6ADC420", Offset = "0x6ADB820", VA = "0x186ADC420")]
			private void BDLNFGMELMD(Dictionary<string, object> HFAGBIOODHL, bool MPOGFJCICIB = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x6ADD530", Offset = "0x6ADC930", VA = "0x186ADD530")]
			public void OMGFHLJJCJA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x6ADCC70", Offset = "0x6ADC070", VA = "0x186ADCC70")]
			private void IGFKIJFMFLE([Optional] string LPBCOGOFFBN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x6ADD0C0", Offset = "0x6ADC4C0", VA = "0x186ADD0C0")]
			private static string KEEOCANBION(string AGLCIEKHLEE, string PMMAAICOJOP)
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
			[Cpp2IlInjected.Address(RVA = "0x6AE2AC0", Offset = "0x6AE1EC0", VA = "0x186AE2AC0")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public struct DDDNPDFLNJL<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public int MKAGDIMDGAP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public string GKIEPBICIHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public T CLNNMLFLABE;
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class PAAOLEONFFN : IEnumerator<PHFLFKPMCCG>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private PHFLFKPMCCG <>2__current;

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
			private PHFLFKPMCCG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000A4")]
				[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x9BB930", Offset = "0x9BAD30", VA = "0x1809BB930")]
			[DebuggerHidden]
			public PAAOLEONFFN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x6AE19F0", Offset = "0x6AE0DF0", VA = "0x186AE19F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x6AE2160", Offset = "0x6AE1560", VA = "0x186AE2160", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class GPLIDGHHCDD : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public LGAKEDCJAKH quitCompletePromise;

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
				[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x9BB930", Offset = "0x9BAD30", VA = "0x1809BB930")]
			[DebuggerHidden]
			public GPLIDGHHCDD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x6ADB9F0", Offset = "0x6ADADF0", VA = "0x186ADB9F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x6ADBB10", Offset = "0x6ADAF10", VA = "0x186ADBB10", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class PBNHIBAMJIA : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x9BB930", Offset = "0x9BAD30", VA = "0x1809BB930")]
			[DebuggerHidden]
			public PBNHIBAMJIA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x6AE21A0", Offset = "0x6AE15A0", VA = "0x186AE21A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x6AE2330", Offset = "0x6AE1730", VA = "0x186AE2330", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class GFKKBNAIPME : IEnumerator<PHFLFKPMCCG>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			private PHFLFKPMCCG <>2__current;

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
			private JOAKPNLDJCM <cache>5__2;

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
			private PHFLFKPMCCG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000B6")]
				[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x9BB930", Offset = "0x9BAD30", VA = "0x1809BB930")]
			[DebuggerHidden]
			public GFKKBNAIPME(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x6ADB640", Offset = "0x6ADAA40", VA = "0x186ADB640", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x6ADB9B0", Offset = "0x6ADADB0", VA = "0x186ADB9B0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class AICFCHOPNJF : IEnumerator<PHFLFKPMCCG>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			private PHFLFKPMCCG <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public float timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			private JOAKPNLDJCM <cache>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			private string <url>5__2;

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			private PHFLFKPMCCG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000C0")]
				[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x9BB930", Offset = "0x9BAD30", VA = "0x1809BB930")]
			[DebuggerHidden]
			public AICFCHOPNJF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x6AD47B0", Offset = "0x6AD3BB0", VA = "0x186AD47B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x6AD4AA0", Offset = "0x6AD3EA0", VA = "0x186AD4AA0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class IAKGHDCADHE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public List<Dictionary<string, object>> batch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			public JOAKPNLDJCM cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
			public IAKGHDCADHE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x6ADBFF0", Offset = "0x6ADB3F0", VA = "0x186ADBFF0")]
			internal void JDPAALJDOKN(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x6ADBB50", Offset = "0x6ADAF50", VA = "0x186ADBB50")]
			internal void BNHGBGEGBBH(DDDNPDFLNJL<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[CompilerGenerated]
		private sealed class KNOMACDEPNI : IEnumerator<PHFLFKPMCCG>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			private PHFLFKPMCCG <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			public JOAKPNLDJCM cache;

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
			private IAKGHDCADHE <>8__1;

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
			private PHFLFKPMCCG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000C9")]
				[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x9BB930", Offset = "0x9BAD30", VA = "0x1809BB930")]
			[DebuggerHidden]
			public KNOMACDEPNI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x6ADDED0", Offset = "0x6ADD2D0", VA = "0x186ADDED0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x6ADE7C0", Offset = "0x6ADDBC0", VA = "0x186ADE7C0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class NGHAIKFNFEH<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x92E880", Offset = "0x92DC80", VA = "0x18092E880")]
			public NGHAIKFNFEH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x278DBC0", Offset = "0x278CFC0", VA = "0x18278DBC0")]
			internal DDDNPDFLNJL<T> AJODLMIEJPM(APCBECOJLFJ postResponse)
			{
				return default(DDDNPDFLNJL<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private sealed class APPHPKHIIOH<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x92E880", Offset = "0x92DC80", VA = "0x18092E880")]
			public APPHPKHIIOH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x278DBC0", Offset = "0x278CFC0", VA = "0x18278DBC0")]
			internal DDDNPDFLNJL<T> DIJLJOIKKHM(APCBECOJLFJ postResponse)
			{
				return default(DDDNPDFLNJL<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private IAJGLGCJAOD OIBLFMAPDEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private Lazy<LLOBKLJIJCM> MEJCPFNIEGD;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private const string KEDOIBHOCLO = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const string HCEBFCKEJHK = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private const string ENDMGEPPLNP = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private const int NOKKFBCEAFB = 15;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private const int FGMNPHHFKMN = 10;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private const int GDFHKKIBKEC = 5;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private const float EJGCIMGJLAM = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private const long AFCBGMHDBEM = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private const string CCKNKBKEGIP = "f1779b982f1c09aed3adb3cca563cbc2";

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private const string PCMDDNPLIOH = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static bool OHOFJBHOBGP;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static bool JILJLGMDHAH;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static int KGCHHOPPIOL;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static int MHDBGKLCIPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private OIIDBHBDBEJ MMJHDOKDAHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private bool DAADFFCDLEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private float MHDGINOOBED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private float MOMCFJNBKBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private int DIDANFPGKIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private int BPPDPJALGLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private int? KKKOAAPCNBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private int? OFBCGHJLCIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private long BHHCMAKLDOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private string FJHGOJMIPKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private bool HEHKECPDLLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private long CFOKJELCPBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private Dictionary<string, object> JFFJIDPFIIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private ODKINFNCDFN PNBEDNBBIGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private int MMKFBFEJGEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private int JKJAHIKPGCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private float ONCDKILNDON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private bool KNJKALHIIBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private bool FJEAFPFGBDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private JOAKPNLDJCM HOGLGOHFELB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private JOAKPNLDJCM ELGENNFKICB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private JOAKPNLDJCM IPBMJBBOKDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> LLBBHNABGBM;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo EDIOACLHBDO;

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private static string AFBFMINCGNK;

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private const string OJMENDMLOJD = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private readonly string KPOECLINDFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private readonly string FHOLNMNHDMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly string KFGMKKEPLCG;

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private IAJGLGCJAOD FMOLIMNJIFF
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x6AD4FB0", Offset = "0x6AD43B0", VA = "0x186AD4FB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private LLOBKLJIJCM LBAPIPKFDMM
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x6AD5710", Offset = "0x6AD4B10", VA = "0x186AD5710")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private static int JACKKNLJBMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6AD5540", Offset = "0x6AD4940", VA = "0x186AD5540")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static long ENFFBFJMCBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x6AD9C40", Offset = "0x6AD9040", VA = "0x186AD9C40")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x6AD9D40", Offset = "0x6AD9140", VA = "0x186AD9D40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static string HCAANCEEJNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6AD9BE0", Offset = "0x6AD8FE0", VA = "0x186AD9BE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static string ELDICABBOEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6AD9C10", Offset = "0x6AD9010", VA = "0x186AD9C10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public string CEADNEMIANL
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x973B50", Offset = "0x972F50", VA = "0x180973B50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xB61820", Offset = "0xB60C20", VA = "0x180B61820")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public int? JBJHEKOHAGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x997310", Offset = "0x996710", VA = "0x180997310")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xD381B0", Offset = "0xD375B0", VA = "0x180D381B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool APOLFCPLEEB
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x99D600", Offset = "0x99CA00", VA = "0x18099D600")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x99CE60", Offset = "0x99C260", VA = "0x18099CE60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static bool OIJJCLNJMJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x6AD9B50", Offset = "0x6AD8F50", VA = "0x186AD9B50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> OGJLCPCFEOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6AD9AB0", Offset = "0x6AD8EB0", VA = "0x186AD9AB0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6AD9CA0", Offset = "0x6AD90A0", VA = "0x186AD9CA0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6AD4CC0", Offset = "0x6AD40C0", VA = "0x186AD4CC0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6AD71E0", Offset = "0x6AD65E0", VA = "0x186AD71E0")]
		private void JJGNPDHLGGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6AD91E0", Offset = "0x6AD85E0", VA = "0x186AD91E0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6AD84E0", Offset = "0x6AD78E0", VA = "0x186AD84E0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6AD94C0", Offset = "0x6AD88C0", VA = "0x186AD94C0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6AD8680", Offset = "0x6AD7A80", VA = "0x186AD8680")]
		public LMHNGLGIJDH PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6AD6CC0", Offset = "0x6AD60C0", VA = "0x186AD6CC0")]
		[IteratorStateMachine(typeof(PAAOLEONFFN))]
		public IEnumerator<PHFLFKPMCCG> Initialize(AmplitudeAnalyticsEvent MHJMGELCDGO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6AD93C0", Offset = "0x6AD87C0", VA = "0x186AD93C0")]
		public void UpdateLastAliveTime(float GBGLMAACONP = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6AD7B30", Offset = "0x6AD6F30", VA = "0x186AD7B30")]
		private LMHNGLGIJDH LNFGNLHCJMH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6AD67A0", Offset = "0x6AD5BA0", VA = "0x186AD67A0")]
		private LMHNGLGIJDH ICIAOEMKJBO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6AD8CE0", Offset = "0x6AD80E0", VA = "0x186AD8CE0")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6AD6D50", Offset = "0x6AD6150", VA = "0x186AD6D50")]
		[IteratorStateMachine(typeof(GPLIDGHHCDD))]
		private IEnumerator JCLLDMDLPOG(LGAKEDCJAKH KMAFJHAJNLN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6AD9740", Offset = "0x6AD8B40", VA = "0x186AD9740")]
		[IteratorStateMachine(typeof(PBNHIBAMJIA))]
		public IEnumerator WaitForFlush(float GKNKCKJFGCG = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6AD92A0", Offset = "0x6AD86A0", VA = "0x186AD92A0")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6AD91F0", Offset = "0x6AD85F0", VA = "0x186AD91F0")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime OPPCDFFPFGD)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6AD6910", Offset = "0x6AD5D10", VA = "0x186AD6910")]
		public static JAIIGBIKFAP Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6AD4B60", Offset = "0x6AD3F60", VA = "0x186AD4B60")]
		public static PBNOGICFNJJ AccountSelectionPostLoginEvent([NotNull] string EKNPMGCDOFD, string JEJLDCJDABJ, bool JJJCLEGADAM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6AD5760", Offset = "0x6AD4B60", VA = "0x186AD5760")]
		public static PBNOGICFNJJ Event([NotNull] string EKNPMGCDOFD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6AD8840", Offset = "0x6AD7C40", VA = "0x186AD8840")]
		public static PBNOGICFNJJ PreviousSessionEvent([NotNull] string EKNPMGCDOFD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6AD6A40", Offset = "0x6AD5E40", VA = "0x186AD6A40")]
		public static PBNOGICFNJJ InitializeEvent(string JEJLDCJDABJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6AD8EC0", Offset = "0x6AD82C0", VA = "0x186AD8EC0")]
		public static PBNOGICFNJJ StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6AD5280", Offset = "0x6AD4680", VA = "0x186AD5280")]
		public static PBNOGICFNJJ CreateOutOfSessionEvent(string EKNPMGCDOFD, bool HKCHEIAIDFK = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6AD7EA0", Offset = "0x6AD72A0", VA = "0x186AD7EA0")]
		public static LMHNGLGIJDH LogOutOfSessionEvent(PBNOGICFNJJ IKNEEFKIGIF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6AD7C00", Offset = "0x6AD7000", VA = "0x186AD7C00")]
		public void LogEventAsync(AmplitudeAnalyticsEvent MBJAMNDOOIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6AD8190", Offset = "0x6AD7590", VA = "0x186AD8190")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent MBJAMNDOOIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6AD82E0", Offset = "0x6AD76E0", VA = "0x186AD82E0")]
		public void LogSerializedEventAsync(Dictionary<string, object> OLBPODAPGBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6AD7D50", Offset = "0x6AD7150", VA = "0x186AD7D50")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage HBOAOGFDDLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6AD66B0", Offset = "0x6AD5AB0", VA = "0x186AD66B0")]
		private void GLLEJFOBLGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6AD7880", Offset = "0x6AD6C80", VA = "0x186AD7880")]
		private void LLGDCACNEFO(Dictionary<string, object> AEDPMLPENPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6AD8580", Offset = "0x6AD7980", VA = "0x186AD8580")]
		private void PLGFOGEKLLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6AD50A0", Offset = "0x6AD44A0", VA = "0x186AD50A0")]
		private void CMLPENLEIFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6AD6620", Offset = "0x6AD5A20", VA = "0x186AD6620")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6AD4AE0", Offset = "0x6AD3EE0", VA = "0x186AD4AE0")]
		[IteratorStateMachine(typeof(GFKKBNAIPME))]
		private IEnumerator<PHFLFKPMCCG> AMCDBFCPNEP(float GKNKCKJFGCG = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6AD5020", Offset = "0x6AD4420", VA = "0x186AD5020")]
		[IteratorStateMachine(typeof(AICFCHOPNJF))]
		private IEnumerator<PHFLFKPMCCG> CIIMMIOMKDE(float GKNKCKJFGCG = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6AD7640", Offset = "0x6AD6A40", VA = "0x186AD7640")]
		[IteratorStateMachine(typeof(KNOMACDEPNI))]
		private IEnumerator<PHFLFKPMCCG> KJJNPKOGIAG(JOAKPNLDJCM PDBOIFOGFCE, int? IDDPCPHMGPD, string ELKGMMLGIKO, string JHNMABDIJIE, float GKNKCKJFGCG, Action<int> AHLNHDBOFJI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6AD83C0", Offset = "0x6AD77C0", VA = "0x186AD83C0")]
		private static void NABMMAKCCEI(bool CFACBPGLDGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6AD6DE0", Offset = "0x6AD61E0", VA = "0x186AD6DE0")]
		private KDCMFGDLEKL<DDDNPDFLNJL<Dictionary<string, object>>> JFHIANHMIEA(string ELKGMMLGIKO, string JHNMABDIJIE, string FMCDBNHEPEP, string PHHNOOIMAHN, Dictionary<string, object> CLNNMLFLABE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6AD6F10", Offset = "0x6AD6310", VA = "0x186AD6F10")]
		private KDCMFGDLEKL<DDDNPDFLNJL<List<Dictionary<string, object>>>> JFHIANHMIEA(string ELKGMMLGIKO, string JHNMABDIJIE, string FMCDBNHEPEP, string PHHNOOIMAHN, List<Dictionary<string, object>> CLNNMLFLABE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x21B6710", Offset = "0x21B5B10", VA = "0x1821B6710")]
		private KDCMFGDLEKL<DDDNPDFLNJL<T>> MKMKPNHCAID<T>(string ELKGMMLGIKO, string JHNMABDIJIE, string PHHNOOIMAHN, T CLNNMLFLABE, Dictionary<string, object> GLNOAODNJLF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x21B63D0", Offset = "0x21B57D0", VA = "0x1821B63D0")]
		private KDCMFGDLEKL<DDDNPDFLNJL<T>> GCNOMBNBKPJ<T>(string ELKGMMLGIKO, string JHNMABDIJIE, string FMCDBNHEPEP, T CLNNMLFLABE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6AD75F0", Offset = "0x6AD69F0", VA = "0x186AD75F0")]
		private bool KAJEFNNLDNE(float OFCMFJJGAGN, float GKNKCKJFGCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6AD5950", Offset = "0x6AD4D50", VA = "0x186AD5950")]
		private Dictionary<string, object> FIHDJCHGLAD(string JHNMABDIJIE, Dictionary<string, object> CLNNMLFLABE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6AD9820", Offset = "0x6AD8C20", VA = "0x186AD9820")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6AD7720", Offset = "0x6AD6B20", VA = "0x186AD7720")]
		[CompilerGenerated]
		private long LDJBFMGEPHD()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6AD5530", Offset = "0x6AD4930", VA = "0x186AD5530")]
		[CompilerGenerated]
		private void DAHPEAAKKEI(int FBBLCFFMAKD)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class KCCNLEBKKGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private long GPEANKLMGNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private PBNOGICFNJJ FMCOHAJBKCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private bool DKCFCCEDAMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private float ODIBJLIPICN;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6ADDD30", Offset = "0x6ADD130", VA = "0x186ADDD30")]
	public KCCNLEBKKGO(string DBJAJCPFDLK, float ODIBJLIPICN = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x1D919B0", Offset = "0x1D90DB0", VA = "0x181D919B0")]
	public void PCGCGCEGEJN<T>(string LEMJCNJPDLJ, T AGLCIEKHLEE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6ADDB90", Offset = "0x6ADCF90", VA = "0x186ADDB90")]
	public void PCGCGCEGEJN(string LEMJCNJPDLJ, string AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6ADD9E0", Offset = "0x6ADCDE0", VA = "0x186ADD9E0")]
	public void NFFEGDGJGKF(string PNOMGHABDKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6ADDAD0", Offset = "0x6ADCED0", VA = "0x186ADDAD0")]
	public void NMMPLNNABBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6ADDC10", Offset = "0x6ADD010", VA = "0x186ADDC10")]
	private void PMNHPMPENMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6ADD990", Offset = "0x6ADCD90", VA = "0x186ADD990")]
	private bool CFHNDHKDLLH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public enum BCPPINOLKHK
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
public class LFGPFAPBMBM : JMPIDBPNFPN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private JMPIDBPNFPN FKIOGOFLHHI;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private JMPIDBPNFPN HNCNJLHJDCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x6ADEEC0", Offset = "0x6ADE2C0", VA = "0x186ADEEC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool HPOMJOMGINK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6ADEB40", Offset = "0x6ADDF40", VA = "0x186ADEB40", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action DPLNEOGDIAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x6ADE900", Offset = "0x6ADDD00", VA = "0x186ADE900", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x6ADEAA0", Offset = "0x6ADDEA0", VA = "0x186ADEAA0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action GEDMDOJDGDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x6ADEC90", Offset = "0x6ADE090", VA = "0x186ADEC90", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6ADED30", Offset = "0x6ADE130", VA = "0x186ADED30", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	[UnityEngine.Scripting.Preserve]
	public LFGPFAPBMBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6ADEF30", Offset = "0x6ADE330", VA = "0x186ADEF30")]
	[PGKDFPMEDOJ(CDFBKAGHDGH.GameOnly)]
	private static void KBCIPFBKDFK(IFJJAPHPIAE DOJDGHDKCLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6ADF430", Offset = "0x6ADE830", VA = "0x186ADF430")]
	[PGKDFPMEDOJ(CDFBKAGHDGH.EditorOnly)]
	private static void OMFPPPGPPPE(IFJJAPHPIAE DOJDGHDKCLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6ADF040", Offset = "0x6ADE440", VA = "0x186ADF040", Slot = "8")]
	public LMHNGLGIJDH MHIDNOPDKCM(string KBKGLHEFPIL, string MIIILCFGIOO, [Optional] JABCHOGCKBH JPFPLKLHOGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6ADEB90", Offset = "0x6ADDF90", VA = "0x186ADEB90", Slot = "10")]
	public LMHNGLGIJDH FHENANCCMME(JABCHOGCKBH JPFPLKLHOGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6ADF320", Offset = "0x6ADE720", VA = "0x186ADF320", Slot = "11")]
	public LMHNGLGIJDH NKGDFEGKCNE(JABCHOGCKBH JPFPLKLHOGC, Dictionary<string, string> GCJFIJFMMIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6ADEFA0", Offset = "0x6ADE3A0", VA = "0x186ADEFA0", Slot = "12")]
	public bool KKCOCFDAJKC(string OELDKCFPKJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6ADE800", Offset = "0x6ADDC00", VA = "0x186ADE800", Slot = "13")]
	public IIBBMNDLGPA AKFMNDEHKPP(string FPGOOAIJKLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x6ADE9A0", Offset = "0x6ADDDA0", VA = "0x186ADE9A0", Slot = "14")]
	public LGKNBNOLJIF COIKJIDEHKL(string JJPKJCNAGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6ADEDD0", Offset = "0x6ADE1D0", VA = "0x186ADEDD0", Slot = "15")]
	public LMHNGLGIJDH ICHMLDCBOCF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0xF1A3C0", Offset = "0xF197C0", VA = "0x180F1A3C0")]
	[CompilerGenerated]
	private void GAPPPGJMLJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0xC61130", Offset = "0xC60530", VA = "0x180C61130")]
	[CompilerGenerated]
	private void JNBMJJCGAJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class OEJCNDIKIJG : JMPIDBPNFPN
{
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static readonly IReadOnlyDictionary<string, EJDEMJGNMAB> NNCAHNFCKNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private bool MFNFEKMJJMA;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool HPOMJOMGINK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x8BD740", Offset = "0x8BCB40", VA = "0x1808BD740", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action DPLNEOGDIAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6ADFB70", Offset = "0x6ADEF70", VA = "0x186ADFB70", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6ADFE70", Offset = "0x6ADF270", VA = "0x186ADFE70", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action GEDMDOJDGDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6AE0130", Offset = "0x6ADF530", VA = "0x186AE0130", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6AE01D0", Offset = "0x6ADF5D0", VA = "0x186AE01D0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x6AE06E0", Offset = "0x6ADFAE0", VA = "0x186AE06E0", Slot = "8")]
	public LMHNGLGIJDH MHIDNOPDKCM(string KBKGLHEFPIL, string MIIILCFGIOO, [Optional] JABCHOGCKBH JPFPLKLHOGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6AE0270", Offset = "0x6ADF670", VA = "0x186AE0270", Slot = "15")]
	public LMHNGLGIJDH ICHMLDCBOCF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x6ADFF10", Offset = "0x6ADF310", VA = "0x186ADFF10", Slot = "10")]
	public LMHNGLGIJDH FHENANCCMME(JABCHOGCKBH JPFPLKLHOGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x6AE0B80", Offset = "0x6ADFF80", VA = "0x186AE0B80", Slot = "11")]
	public LMHNGLGIJDH NKGDFEGKCNE(JABCHOGCKBH JPFPLKLHOGC, Dictionary<string, string> GCJFIJFMMIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x6AE0630", Offset = "0x6ADFA30", VA = "0x186AE0630", Slot = "12")]
	public bool KKCOCFDAJKC(string OELDKCFPKJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6ADFA50", Offset = "0x6ADEE50", VA = "0x186ADFA50", Slot = "13")]
	public IIBBMNDLGPA AKFMNDEHKPP(string FPGOOAIJKLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x6ADFDB0", Offset = "0x6ADF1B0", VA = "0x186ADFDB0", Slot = "14")]
	public LGKNBNOLJIF COIKJIDEHKL(string JJPKJCNAGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x6AE0F00", Offset = "0x6AE0300", VA = "0x186AE0F00")]
	private AHENFDINIMO OJMGHIGDLAL(JABCHOGCKBH JPFPLKLHOGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6ADFC10", Offset = "0x6ADF010", VA = "0x186ADFC10")]
	private NAGFHJKFPLD CKHIJKIGBGI(string MIIILCFGIOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x6AE0400", Offset = "0x6ADF800", VA = "0x186AE0400")]
	private void IPIPEFEOMCF(string FPGOOAIJKLK, IIBBMNDLGPA PPCPEOGMHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6AE17E0", Offset = "0x6AE0BE0", VA = "0x186AE17E0")]
	public OEJCNDIKIJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x9C5D30", Offset = "0x9C5130", VA = "0x1809C5D30")]
	[CompilerGenerated]
	private void OLODBHJOFBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6AE1620", Offset = "0x6AE0A20", VA = "0x186AE1620")]
	[CompilerGenerated]
	private void PINBBLIHEHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6AE0E70", Offset = "0x6AE0270", VA = "0x186AE0E70")]
	[CompilerGenerated]
	private void NMBCMIMCGFI()
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
			[Cpp2IlInjected.Address(RVA = "0x81F0B0", Offset = "0x81E4B0", VA = "0x18081F0B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x823C10", Offset = "0x823010", VA = "0x180823C10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6AE2870", Offset = "0x6AE1C70", VA = "0x186AE2870", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface JMPIDBPNFPN
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	bool HPOMJOMGINK
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action DPLNEOGDIAH;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action GEDMDOJDGDJ;

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "4")]
	LMHNGLGIJDH MHIDNOPDKCM(string KBKGLHEFPIL, string MIIILCFGIOO, [Optional] JABCHOGCKBH JPFPLKLHOGC);

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "6")]
	LMHNGLGIJDH FHENANCCMME(JABCHOGCKBH JPFPLKLHOGC);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "7")]
	LMHNGLGIJDH NKGDFEGKCNE(JABCHOGCKBH JPFPLKLHOGC, Dictionary<string, string> GCJFIJFMMIK);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool KKCOCFDAJKC(string OELDKCFPKJG);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IIBBMNDLGPA AKFMNDEHKPP(string FPGOOAIJKLK);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	LGKNBNOLJIF COIKJIDEHKL(string JJPKJCNAGCO);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	LMHNGLGIJDH ICHMLDCBOCF();
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class LIPDHFCDGIE : JMPIDBPNFPN
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool HPOMJOMGINK
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x823C20", Offset = "0x823020", VA = "0x180823C20", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action DPLNEOGDIAH
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6ADF4B0", Offset = "0x6ADE8B0", VA = "0x186ADF4B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x6ADF560", Offset = "0x6ADE960", VA = "0x186ADF560", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action GEDMDOJDGDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6ADF6A0", Offset = "0x6ADEAA0", VA = "0x186ADF6A0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x6ADF740", Offset = "0x6ADEB40", VA = "0x186ADF740", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	[RecRoom.NoEngine.Common.Preserve]
	public LIPDHFCDGIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6ADF880", Offset = "0x6ADEC80", VA = "0x186ADF880", Slot = "8")]
	public LMHNGLGIJDH MHIDNOPDKCM(string KBKGLHEFPIL, string MIIILCFGIOO, [Optional] JABCHOGCKBH JPFPLKLHOGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6ADF600", Offset = "0x6ADEA00", VA = "0x186ADF600", Slot = "10")]
	public LMHNGLGIJDH FHENANCCMME(JABCHOGCKBH JPFPLKLHOGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6ADF920", Offset = "0x6ADED20", VA = "0x186ADF920", Slot = "11")]
	public LMHNGLGIJDH NKGDFEGKCNE(JABCHOGCKBH JPFPLKLHOGC, Dictionary<string, string> GCJFIJFMMIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x822D60", Offset = "0x822160", VA = "0x180822D60", Slot = "12")]
	public bool KKCOCFDAJKC(string OELDKCFPKJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6ADF4A0", Offset = "0x6ADE8A0", VA = "0x186ADF4A0", Slot = "13")]
	public IIBBMNDLGPA AKFMNDEHKPP(string FPGOOAIJKLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6ADF550", Offset = "0x6ADE950", VA = "0x186ADF550", Slot = "14")]
	public LGKNBNOLJIF COIKJIDEHKL(string JJPKJCNAGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6ADF7E0", Offset = "0x6ADEBE0", VA = "0x186ADF7E0", Slot = "15")]
	public LMHNGLGIJDH ICHMLDCBOCF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface JABCHOGCKBH
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	bool GJDPAHDGGGP
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	bool JDKLEKHJMJE
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	bool NMOENAMPCBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	bool? GMMPGFJFOJN
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	int? JBJHEKOHAGB
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	int FIPHGJBFJPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	string OGAHADMNNEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	string JIBBFKJOBMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	string PGFLFLJNAOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	long DLGMPHBMKDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	string AFHGGPLDCCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	string HPONDINADAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	string GLHDKJMAKCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	string AONHMGFGFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	double MBNNDKOJOPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	int JAKDEADAPHL
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface GAILBGCHDAG
{
	[Cpp2IlInjected.Token(Token = "0x17000040")]
	long PAMMIDPFCCM
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	long KGLMEHFFMDB();

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HMLAFNMCCPB(long NNILKGIDMKL, bool FJPDCDBMNPE = true);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ADPMMNFIAAI(string AKPCLGIGABA, string LDAOLHMCKHC, string DHECNCBFHCK);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JHLBDENBKAD(string AKPCLGIGABA);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AHFFDFMDFFP(string AKPCLGIGABA, string DDLLKMOFAHJ, string EAAPFMPIIKL);

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BCJAHDKMFAN(string PBPMMNLOLHE, object CIDAGHMGPEO, object NLPFMEPMGLJ);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface PAAEJPAMAAL
{
	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KCCNLEBKKGO OCDABJKCFIC(string DBJAJCPFDLK);
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

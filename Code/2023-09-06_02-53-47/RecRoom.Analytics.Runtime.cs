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
		[Cpp2IlInjected.Address(RVA = "0x91C600", Offset = "0x91AC00", VA = "0x18091C600")]
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
		[Cpp2IlInjected.Address(RVA = "0x69038D0", Offset = "0x6901ED0", VA = "0x1869038D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x11F2200", Offset = "0x11F0800", VA = "0x1811F2200")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class MNDCHOOEMCJ
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> COLJLCDCNMC;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6903370", Offset = "0x6901970", VA = "0x186903370")]
	internal static bool DOBACAMACGL(string BOMEFJIOGGM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface EDBNAHGJJLN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool MJBFKDNGCIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string GHPAKLKBODI
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	string NGOMMEJCAPN
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	string DGEGENCNOMI
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	string PODDGIFKIJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	MFBKDKPGMNP<NPDMLDFCNCJ> NPNGOJLHAFM(string GGDHNGHHEEA, Dictionary<string, string> BHAFPAHKDEC, bool NFBAJEBIAPC = false);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	MFBKDKPGMNP<NPDMLDFCNCJ> AEGMIPDDAJM(string GGDHNGHHEEA, string MACBHGEFBPL, string CCKGGACHDAM, string MDNNMAPKAHA);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct NPDMLDFCNCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly int IOAFFKAFEBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly string KKDEPMCHLKF;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xC10030", Offset = "0xC0E630", VA = "0x180C10030")]
	public NPDMLDFCNCJ(int LOGMGBDGGDO, string DMMMNEBLGMB)
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
		public AmplitudeAnalyticsClient.Settings KLELFGOAMCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x7EEED0", Offset = "0x7ED4D0", VA = "0x1807EEED0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool JGMNIBJIPLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xE99C10", Offset = "0xE98210", VA = "0x180E99C10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7EAA60", Offset = "0x7E9060", VA = "0x1807EAA60")]
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
			[Cpp2IlInjected.Address(RVA = "0x68FD3B0", Offset = "0x68FB9B0", VA = "0x1868FD3B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x68FD480", Offset = "0x68FBA80", VA = "0x1868FD480")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static string StableId
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x68FD3F0", Offset = "0x68FB9F0", VA = "0x1868FD3F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x68FD4D0", Offset = "0x68FBAD0", VA = "0x1868FD4D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static string ClientLauncher
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x68FD370", Offset = "0x68FB970", VA = "0x1868FD370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x68FD430", Offset = "0x68FBA30", VA = "0x1868FD430")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x974F50", Offset = "0x973550", VA = "0x180974F50")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x68FCA50", Offset = "0x68FB050", VA = "0x1868FCA50")]
		public static FHLPMEBFNDD HKLENFAPHAP(string MPNDOHBKHJO, [NotNull] string EFKKKPJODFJ, long CMAECAJJLHA, long GOOHHIIOKPB, string JECLHHEOFCL, bool IFFPDHCNLPK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x68FD080", Offset = "0x68FB680", VA = "0x1868FD080")]
		public static FHLPMEBFNDD NHDDGKHFNDH(string MPNDOHBKHJO, [NotNull] string EFKKKPJODFJ, long CMAECAJJLHA, long GOOHHIIOKPB, string JECLHHEOFCL, long FOGHHLOJCOG, bool IFFPDHCNLPK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x68FD190", Offset = "0x68FB790", VA = "0x1868FD190")]
		private AmplitudeAnalyticsEvent(string MPNDOHBKHJO, [NotNull] string EFKKKPJODFJ, long CMAECAJJLHA, long GOOHHIIOKPB, string JECLHHEOFCL, bool IFFPDHCNLPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1909EE0", Offset = "0x19084E0", VA = "0x181909EE0")]
		public void NKICFDPIEGI(long JJJNAHIIALH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x68FC6F0", Offset = "0x68FACF0", VA = "0x1868FC6F0", Slot = "5")]
		public override void AHKNHONMPGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x68FC7E0", Offset = "0x68FADE0", VA = "0x1868FC7E0", Slot = "6")]
		public override void ANPDOLEFCJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x68FCB40", Offset = "0x68FB140", VA = "0x1868FCB40", Slot = "4")]
		protected override Dictionary<string, object> NCALNMAPEAP(Dictionary<string, object> HJIOFINHEGA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x68FC940", Offset = "0x68FAF40", VA = "0x1868FC940")]
		private void HCBFNBNFEAI(string BOMEFJIOGGM, string MOLEJFDINLH, bool AOGPLEBDKIG = false)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class BCPNICMAOBO : KBKFLCMAJLG<AmplitudeAnalyticsIdentifyMessage, BCPNICMAOBO>
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override BCPNICMAOBO KJDJLFCKGJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xCCB4F0", Offset = "0xCC9AF0", VA = "0x180CCB4F0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0xE93CC0", Offset = "0xE922C0", VA = "0x180E93CC0", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage HCBKOPOOIEK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x68FDCD0", Offset = "0x68FC2D0", VA = "0x1868FDCD0")]
	public BCPNICMAOBO(AmplitudeAnalyticsIdentifyMessage DPAJDIEBNKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x68FDC60", Offset = "0x68FC260", VA = "0x1868FDC60", Slot = "4")]
	public override void ANPDOLEFCJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class FHLPMEBFNDD : KBKFLCMAJLG<AmplitudeAnalyticsEvent, FHLPMEBFNDD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private bool KBEJBBALLPF;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override FHLPMEBFNDD KJDJLFCKGJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xCCB4F0", Offset = "0xCC9AF0", VA = "0x180CCB4F0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public long KMJBBHNAICF
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x21EF2A0", Offset = "0x21ED8A0", VA = "0x1821EF2A0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x68FF1E0", Offset = "0x68FD7E0", VA = "0x1868FF1E0")]
	public FHLPMEBFNDD(AmplitudeAnalyticsEvent DPAJDIEBNKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0xE93CC0", Offset = "0xE922C0", VA = "0x180E93CC0", Slot = "5")]
	public override AmplitudeAnalyticsEvent HCBKOPOOIEK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x68FEE60", Offset = "0x68FD460", VA = "0x1868FEE60", Slot = "4")]
	public override void ANPDOLEFCJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1C65220", Offset = "0x1C63820", VA = "0x181C65220")]
	public FHLPMEBFNDD GEPDKONMJHC<T>(string JCPKNOEICEG, T[] MOLEJFDINLH) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x68FF000", Offset = "0x68FD600", VA = "0x1868FF000")]
	public FHLPMEBFNDD GEPDKONMJHC(string JCPKNOEICEG, string[] MOLEJFDINLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1C651B0", Offset = "0x1C637B0", VA = "0x181C651B0")]
	public FHLPMEBFNDD GEPDKONMJHC<T>(string JCPKNOEICEG, T MOLEJFDINLH) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x68FEF70", Offset = "0x68FD570", VA = "0x1868FEF70")]
	public FHLPMEBFNDD GEPDKONMJHC(string JCPKNOEICEG, long MOLEJFDINLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x68FEF00", Offset = "0x68FD500", VA = "0x1868FEF00")]
	public FHLPMEBFNDD GEPDKONMJHC(string JCPKNOEICEG, string MOLEJFDINLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x68FF1B0", Offset = "0x68FD7B0", VA = "0x1868FF1B0")]
	public FHLPMEBFNDD MBAPFIDGODI(string JCPKNOEICEG, object? MOLEJFDINLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x68FF010", Offset = "0x68FD610", VA = "0x1868FF010")]
	public FHLPMEBFNDD GHCNGKHKKKA(string JCPKNOEICEG, string MOLEJFDINLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x68FF0B0", Offset = "0x68FD6B0", VA = "0x1868FF0B0")]
	private FHLPMEBFNDD GMPLONIBKNP(string JCPKNOEICEG, object MOLEJFDINLH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class KGMHNDLGIDB : FHLPMEBFNDD
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x68FF1E0", Offset = "0x68FD7E0", VA = "0x1868FF1E0")]
	public KGMHNDLGIDB(AmplitudeAnalyticsEvent DPAJDIEBNKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6902850", Offset = "0x6900E50", VA = "0x186902850", Slot = "4")]
	public override void ANPDOLEFCJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class KBKFLCMAJLG<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : KBKFLCMAJLG<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected M DPAJDIEBNKM;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public abstract BLDR KJDJLFCKGJK
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1F085A0", Offset = "0x1F06BA0", VA = "0x181F085A0")]
	public KBKFLCMAJLG(M DPAJDIEBNKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2544830", Offset = "0x2542E30", VA = "0x182544830")]
	public BLDR INNNKEJIBGM(AmplitudeAnalyticsIdentifyMessage.DeviceInfo EIKCKNMPPEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x25447C0", Offset = "0x2542DC0", VA = "0x1825447C0")]
	public BLDR CMHCMBPAICB(AmplitudeAnalyticsIdentifyMessage.RevenueData ICHCNHKAAKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2544970", Offset = "0x2542F70", VA = "0x182544970")]
	public BLDR NADANOCNGCI(string JCPKNOEICEG, string MOLEJFDINLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1CB6C10", Offset = "0x1CB5210", VA = "0x181CB6C10")]
	public BLDR NADANOCNGCI<T>(string JCPKNOEICEG, T MOLEJFDINLH) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void ANPDOLEFCJK();

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2544800", Offset = "0x2542E00", VA = "0x182544800")]
	internal static string GHJNICPNGJO(string MOLEJFDINLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2544870", Offset = "0x2542E70", VA = "0x182544870")]
	private BLDR JIMGKDCJIBA(string JCPKNOEICEG, object MOLEJFDINLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M HCBKOPOOIEK();
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
			[Cpp2IlInjected.Address(RVA = "0x68FE4D0", Offset = "0x68FCAD0", VA = "0x1868FE4D0")]
			public void JBNBMBLBNOK(Dictionary<string, object> OGOPDJDHFEF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
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
			[Cpp2IlInjected.Address(RVA = "0x6903E60", Offset = "0x6902460", VA = "0x186903E60")]
			public void JBNBMBLBNOK(Dictionary<string, object> CHHAJFDDDMP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6903FD0", Offset = "0x69025D0", VA = "0x186903FD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x7EA010", Offset = "0x7E8610", VA = "0x1807EA010")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x97E0F0", Offset = "0x97C6F0", VA = "0x18097E0F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x68FD680", Offset = "0x68FBC80", VA = "0x1868FD680")]
		public static BCPNICMAOBO HKLENFAPHAP(string MPNDOHBKHJO, string JECLHHEOFCL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x68FDB60", Offset = "0x68FC160", VA = "0x1868FDB60")]
		protected AmplitudeAnalyticsIdentifyMessage(string MPNDOHBKHJO, string JECLHHEOFCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x68FD7A0", Offset = "0x68FBDA0", VA = "0x1868FD7A0")]
		public Dictionary<string, object> LBADKDPPGNF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x68FD820", Offset = "0x68FBE20", VA = "0x1868FD820", Slot = "4")]
		protected virtual Dictionary<string, object> NCALNMAPEAP(Dictionary<string, object> HJIOFINHEGA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x68FD5D0", Offset = "0x68FBBD0", VA = "0x1868FD5D0")]
		protected void EEDBDDOENOK(string BOMEFJIOGGM, Dictionary<string, object> EMPEFLAEEDE, Dictionary<string, object> MGODHLKCDED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x68FD730", Offset = "0x68FBD30", VA = "0x1868FD730")]
		protected void HLFBMOHONGF(string BOMEFJIOGGM, string MOLEJFDINLH, Dictionary<string, object> EKMHMBEBEML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x68FD520", Offset = "0x68FBB20", VA = "0x1868FD520", Slot = "5")]
		public virtual void AHKNHONMPGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x68FD580", Offset = "0x68FBB80", VA = "0x1868FD580", Slot = "6")]
		public virtual void ANPDOLEFCJK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		private enum JNGAFMAAJPL
		{
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		internal class APCAKDJCHAK
		{
			[Cpp2IlInjected.Token(Token = "0x2000015")]
			private class OPAOKPBNOHM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000067")]
				public int KFFNBBFNHNK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000068")]
				public Dictionary<string, object> APAPBPNMNFH;

				[Cpp2IlInjected.Token(Token = "0x6000098")]
				[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
				public OPAOKPBNOHM()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000016")]
			[CompilerGenerated]
			private sealed class MNAECBOCCON
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000069")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000099")]
				[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
				public MNAECBOCCON()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600009A")]
				[Cpp2IlInjected.Address(RVA = "0x6903310", Offset = "0x6901910", VA = "0x186903310")]
				internal bool DPLBPHONKJB(OPAOKPBNOHM item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private const string IHDAKMJJBOK = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			private readonly string KMNDPDKPPEJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private List<OPAOKPBNOHM> DEDNOALBAKD;

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public int? NHIBEIBJBEB
			{
				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0x68F6540", Offset = "0x68F4B40", VA = "0x1868F6540")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x68F72A0", Offset = "0x68F58A0", VA = "0x1868F72A0")]
			internal APCAKDJCHAK(string HKLIJJOIFLJ, string GHOKMMJMKEB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x68F65E0", Offset = "0x68F4BE0", VA = "0x1868F65E0")]
			public int FAGCGJCBIPE([Optional] int? GOGIHIABFIP)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x68F5F20", Offset = "0x68F4520", VA = "0x1868F5F20")]
			public List<Dictionary<string, object>> CLOIHFEIFDG(int LFBGOILEMFF, int? GOGIHIABFIP)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x68F6E20", Offset = "0x68F5420", VA = "0x1868F6E20")]
			public void HGIDKPNELGJ(AmplitudeAnalyticsIdentifyMessage NKFOPKJGBEM, bool MAJDEKFAOBA = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x68F6EC0", Offset = "0x68F54C0", VA = "0x1868F6EC0")]
			public void HGIDKPNELGJ(Dictionary<string, object> NKFOPKJGBEM, bool MAJDEKFAOBA = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x68F6FD0", Offset = "0x68F55D0", VA = "0x1868F6FD0")]
			public void JANBIFLBIPP(params Dictionary<string, object>[] HEKHAIKKCJA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x68F61C0", Offset = "0x68F47C0", VA = "0x1868F61C0")]
			public void DCDOLALMJBM(List<Dictionary<string, object>> FPLCEGKOAMH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x68F7160", Offset = "0x68F5760", VA = "0x1868F7160")]
			private void NNKPCNELEMF(Dictionary<string, object> NKFOPKJGBEM, bool MAJDEKFAOBA = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x68F6760", Offset = "0x68F4D60", VA = "0x1868F6760")]
			public void GIFLCMNKDMG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x68F69D0", Offset = "0x68F4FD0", VA = "0x1868F69D0")]
			private void GNGEOCPAFKD([Optional] string MBGFBMFJKFM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x68F6410", Offset = "0x68F4A10", VA = "0x1868F6410")]
			private static string DEKGOPCHBJO(string MOLEJFDINLH, string BOMEFJIOGGM)
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
			[Cpp2IlInjected.Address(RVA = "0x6904230", Offset = "0x6902830", VA = "0x186904230")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public struct NFLHEIPEHLA<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public int LOGMGBDGGDO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public string DMMMNEBLGMB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public T OHCLPENAFEM;
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class CIGGLNPEHGB : IEnumerator<FOLOHDFBANO>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private FOLOHDFBANO <>2__current;

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
			private FOLOHDFBANO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000A4")]
				[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x975A90", Offset = "0x974090", VA = "0x180975A90")]
			[DebuggerHidden]
			public CIGGLNPEHGB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x68FDD20", Offset = "0x68FC320", VA = "0x1868FDD20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x68FE490", Offset = "0x68FCA90", VA = "0x1868FE490", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class GLNMKJHFEMM : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public NOKBHGDKGNF quitCompletePromise;

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
				[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x975A90", Offset = "0x974090", VA = "0x180975A90")]
			[DebuggerHidden]
			public GLNMKJHFEMM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x68FF750", Offset = "0x68FDD50", VA = "0x1868FF750", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x68FF870", Offset = "0x68FDE70", VA = "0x1868FF870", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class OCGLKKPIJHJ : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x975A90", Offset = "0x974090", VA = "0x180975A90")]
			[DebuggerHidden]
			public OCGLKKPIJHJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x6903960", Offset = "0x6901F60", VA = "0x186903960", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x6903AF0", Offset = "0x69020F0", VA = "0x186903AF0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class NNOODLFECEC : IEnumerator<FOLOHDFBANO>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			private FOLOHDFBANO <>2__current;

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
			private APCAKDJCHAK <cache>5__2;

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
			private FOLOHDFBANO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000B6")]
				[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x975A90", Offset = "0x974090", VA = "0x180975A90")]
			[DebuggerHidden]
			public NNOODLFECEC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x6903520", Offset = "0x6901B20", VA = "0x186903520", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x6903890", Offset = "0x6901E90", VA = "0x186903890", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class PCABGMHAKJG : IEnumerator<FOLOHDFBANO>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			private FOLOHDFBANO <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public float timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			private APCAKDJCHAK <cache>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			private string <url>5__2;

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			private FOLOHDFBANO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000C0")]
				[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x975A90", Offset = "0x974090", VA = "0x180975A90")]
			[DebuggerHidden]
			public PCABGMHAKJG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x6903B30", Offset = "0x6902130", VA = "0x186903B30", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x6903E20", Offset = "0x6902420", VA = "0x186903E20", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class EPHCPAJLJMA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public List<Dictionary<string, object>> batch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			public APCAKDJCHAK cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
			public EPHCPAJLJMA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x68FE650", Offset = "0x68FCC50", VA = "0x1868FE650")]
			internal void ACBIGJHFEMK(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x68FE9C0", Offset = "0x68FCFC0", VA = "0x1868FE9C0")]
			internal void MOJJDAIFCDI(NFLHEIPEHLA<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[CompilerGenerated]
		private sealed class LGKKGKILGPA : IEnumerator<FOLOHDFBANO>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			private FOLOHDFBANO <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			public APCAKDJCHAK cache;

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
			private EPHCPAJLJMA <>8__1;

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
			private FOLOHDFBANO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000C9")]
				[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x975A90", Offset = "0x974090", VA = "0x180975A90")]
			[DebuggerHidden]
			public LGKKGKILGPA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x69029E0", Offset = "0x6900FE0", VA = "0x1869029E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x69032D0", Offset = "0x69018D0", VA = "0x1869032D0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class MBIFBILHJNK<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
			public MBIFBILHJNK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x2717940", Offset = "0x2715F40", VA = "0x182717940")]
			internal NFLHEIPEHLA<T> JJFBHPGJFOC(NPDMLDFCNCJ postResponse)
			{
				return default(NFLHEIPEHLA<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private sealed class NGJCDIDKJMG<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
			public NGJCDIDKJMG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x2717940", Offset = "0x2715F40", VA = "0x182717940")]
			internal NFLHEIPEHLA<T> KEODBAIELKA(NPDMLDFCNCJ postResponse)
			{
				return default(NFLHEIPEHLA<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private OEDCEGNGFJP EOCNJKDCCBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private Lazy<NCGIMKKIFEJ> HKELAIPOEAI;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private const string DENAAFHDABJ = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const string BGFIHGCFJAD = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private const string KFNMPMBHICH = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private const int CBJHPDKNGIA = 15;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private const int DDKHDOOJIMJ = 10;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private const int BEODIOCJNAA = 5;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private const float FOJCMPHHMEK = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private const long DCNENJDNBPC = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private const string IHMDFCBIMHA = "f1779b982f1c09aed3adb3cca563cbc2";

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private const string FFJEICNEOCC = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static bool JNIJLPKHIHJ;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static bool NPHEOGCDIAF;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static int HJNGGLOICLJ;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static int OHNCABMEEEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private EDBNAHGJJLN KMMLHDMNGBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private bool HPJMDIOPMOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private float PDLCFHBNHJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private float MPAJPCFGCHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private int OGBFDKKIKMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private int CHNDCLEGKEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private int? CKGDOKIJGPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private int? AADGEBADBIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private long KPPDGBNJHKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private string HHAJOGEJAGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private bool CMALCMIMHNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private long AIIPLHJMOFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private Dictionary<string, object> HDAJLFMELAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private JNGAFMAAJPL GEEGDNEGAFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private int BGNCKCPBBNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private int HABEIMFOGGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private float HJJKBBJNCAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private bool OCBLHJIFPID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private bool MHJEBGCBLGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private APCAKDJCHAK AOKFIDANPHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private APCAKDJCHAK JFJEFILNGKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private APCAKDJCHAK LGKEBAEFDKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> GNKEBEJDGAH;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo EPOFAIDOKIG;

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private static string JIALEOFPMKO;

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private const string IKHKLJAENND = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private readonly string OFCNMLOBPAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private readonly string LAMGOCCHNHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly string NGPCJHDFIEK;

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private OEDCEGNGFJP MCAOMKACLOB
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x68F8660", Offset = "0x68F6C60", VA = "0x1868F8660")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private NCGIMKKIFEJ NMFPNOJLHBO
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x68F9870", Offset = "0x68F7E70", VA = "0x1868F9870")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private static int EJGOJGNBHIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x68FA490", Offset = "0x68F8A90", VA = "0x1868FA490")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static long HIJBIBLFBHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x68FC590", Offset = "0x68FAB90", VA = "0x1868FC590")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x68FC690", Offset = "0x68FAC90", VA = "0x1868FC690")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static string IOOEBJJMFJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x68FC530", Offset = "0x68FAB30", VA = "0x1868FC530")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static string CGDPGIOCIKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x68FC560", Offset = "0x68FAB60", VA = "0x1868FC560")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public string MLBDBNMNNFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x923F80", Offset = "0x922580", VA = "0x180923F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xCB7630", Offset = "0xCB5C30", VA = "0x180CB7630")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public int? AFOJENEBPJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xA97E40", Offset = "0xA96440", VA = "0x180A97E40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xDDA0B0", Offset = "0xDD86B0", VA = "0x180DDA0B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool PKOPIFCAMAN
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xA8E2C0", Offset = "0xA8C8C0", VA = "0x180A8E2C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xA8CFA0", Offset = "0xA8B5A0", VA = "0x180A8CFA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static bool FIKNLBDOMMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x68FC4A0", Offset = "0x68FAAA0", VA = "0x1868FC4A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> BGADFBAFLGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x68FC400", Offset = "0x68FAA00", VA = "0x1868FC400")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x68FC5F0", Offset = "0x68FABF0", VA = "0x1868FC5F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x68F7590", Offset = "0x68F5B90", VA = "0x1868F7590", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x68FA080", Offset = "0x68F8680", VA = "0x1868FA080")]
		private void MEOGKCHKNEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x68FBB30", Offset = "0x68FA130", VA = "0x1868FBB30")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x68FAEE0", Offset = "0x68F94E0", VA = "0x1868FAEE0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x68FBE10", Offset = "0x68FA410", VA = "0x1868FBE10")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x68FAFD0", Offset = "0x68F95D0", VA = "0x1868FAFD0")]
		public HHGLIBCDIDA PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x68F9750", Offset = "0x68F7D50", VA = "0x1868F9750")]
		[IteratorStateMachine(typeof(CIGGLNPEHGB))]
		public IEnumerator<FOLOHDFBANO> Initialize(AmplitudeAnalyticsEvent CNFDJKGDCAI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x68FBD10", Offset = "0x68FA310", VA = "0x1868FBD10")]
		public void UpdateLastAliveTime(float KKEKAHCHEND = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x68FA660", Offset = "0x68F8C60", VA = "0x1868FA660")]
		private HHGLIBCDIDA NFIDCGPEOIK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x68FAB30", Offset = "0x68F9130", VA = "0x1868FAB30")]
		private HHGLIBCDIDA OFJBODHALKC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x68FB630", Offset = "0x68F9C30", VA = "0x1868FB630")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x68F97E0", Offset = "0x68F7DE0", VA = "0x1868F97E0")]
		[IteratorStateMachine(typeof(GLNMKJHFEMM))]
		private IEnumerator JIEFLPBMEEL(NOKBHGDKGNF HIBLFGMEAPJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x68FC090", Offset = "0x68FA690", VA = "0x1868FC090")]
		[IteratorStateMachine(typeof(OCGLKKPIJHJ))]
		public IEnumerator WaitForFlush(float DNBGCDFFBOI = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x68FBBF0", Offset = "0x68FA1F0", VA = "0x1868FBBF0")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x68FBB40", Offset = "0x68FA140", VA = "0x1868FBB40")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime CKDPHHLMOGA)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x68F93A0", Offset = "0x68F79A0", VA = "0x1868F93A0")]
		public static BCPNICMAOBO Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x68F7430", Offset = "0x68F5A30", VA = "0x1868F7430")]
		public static FHLPMEBFNDD AccountSelectionPostLoginEvent([NotNull] string NOKLJBPMPID, string JECLHHEOFCL, bool IFFPDHCNLPK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x68F82E0", Offset = "0x68F68E0", VA = "0x1868F82E0")]
		public static FHLPMEBFNDD Event([NotNull] string NOKLJBPMPID)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x68FB190", Offset = "0x68F9790", VA = "0x1868FB190")]
		public static FHLPMEBFNDD PreviousSessionEvent([NotNull] string NOKLJBPMPID)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x68F94D0", Offset = "0x68F7AD0", VA = "0x1868F94D0")]
		public static FHLPMEBFNDD InitializeEvent(string JECLHHEOFCL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x68FB810", Offset = "0x68F9E10", VA = "0x1868FB810")]
		public static FHLPMEBFNDD StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x68F7D30", Offset = "0x68F6330", VA = "0x1868F7D30")]
		public static FHLPMEBFNDD CreateOutOfSessionEvent(string NOKLJBPMPID, bool LEENPPACBLB = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x68F9B60", Offset = "0x68F8160", VA = "0x1868F9B60")]
		public static HHGLIBCDIDA LogOutOfSessionEvent(FHLPMEBFNDD CPBJGJHEIEE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x68F98C0", Offset = "0x68F7EC0", VA = "0x1868F98C0")]
		public void LogEventAsync(AmplitudeAnalyticsEvent LLJDFJJKGEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x68F9E50", Offset = "0x68F8450", VA = "0x1868F9E50")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent LLJDFJJKGEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x68F9FA0", Offset = "0x68F85A0", VA = "0x1868F9FA0")]
		public void LogSerializedEventAsync(Dictionary<string, object> CFPODHOFDLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x68F9A10", Offset = "0x68F8010", VA = "0x1868F9A10")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage EFHGFBJGJJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x68F7880", Offset = "0x68F5E80", VA = "0x1868F7880")]
		private void BCNHBELJIHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x68F79F0", Offset = "0x68F5FF0", VA = "0x1868F79F0")]
		private void BOGCBFNNPDF(Dictionary<string, object> GBAHNMCMAEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x68F8560", Offset = "0x68F6B60", VA = "0x1868F8560")]
		private void GDKNMAHJIFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x68F7FE0", Offset = "0x68F65E0", VA = "0x1868F7FE0")]
		private void DGCKHOGJFIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x68F84D0", Offset = "0x68F6AD0", VA = "0x1868F84D0")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x68F7970", Offset = "0x68F5F70", VA = "0x1868F7970")]
		[IteratorStateMachine(typeof(NNOODLFECEC))]
		private IEnumerator<FOLOHDFBANO> BNJLCADCPOF(float DNBGCDFFBOI = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x68F7CA0", Offset = "0x68F62A0", VA = "0x1868F7CA0")]
		[IteratorStateMachine(typeof(PCABGMHAKJG))]
		private IEnumerator<FOLOHDFBANO> CCFBDJGDIIK(float DNBGCDFFBOI = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x68FACA0", Offset = "0x68F92A0", VA = "0x1868FACA0")]
		[IteratorStateMachine(typeof(LGKKGKILGPA))]
		private IEnumerator<FOLOHDFBANO> OGDGPHAKIDA(APCAKDJCHAK IFBIMPBNLEG, int? GOGIHIABFIP, string GGDHNGHHEEA, string HFMMOGFNCKA, float DNBGCDFFBOI, Action<int> PDMLKIECGIF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x68F81C0", Offset = "0x68F67C0", VA = "0x1868F81C0")]
		private static void EBHANDKIINH(bool IFMIFILEOLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x68FA730", Offset = "0x68F8D30", VA = "0x1868FA730")]
		private MFBKDKPGMNP<NFLHEIPEHLA<Dictionary<string, object>>> NPNGOJLHAFM(string GGDHNGHHEEA, string HFMMOGFNCKA, string MDBLIKEKBCK, string FIMLDGHCIFD, Dictionary<string, object> OHCLPENAFEM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x68FA860", Offset = "0x68F8E60", VA = "0x1868FA860")]
		private MFBKDKPGMNP<NFLHEIPEHLA<List<Dictionary<string, object>>>> NPNGOJLHAFM(string GGDHNGHHEEA, string HFMMOGFNCKA, string MDBLIKEKBCK, string FIMLDGHCIFD, List<Dictionary<string, object>> OHCLPENAFEM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x36C9A00", Offset = "0x36C8000", VA = "0x1836C9A00")]
		private MFBKDKPGMNP<NFLHEIPEHLA<T>> EPEAEPJHPCE<T>(string GGDHNGHHEEA, string HFMMOGFNCKA, string FIMLDGHCIFD, T OHCLPENAFEM, Dictionary<string, object> KIFLBMKOKDO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x36C9C90", Offset = "0x36C8290", VA = "0x1836C9C90")]
		private MFBKDKPGMNP<NFLHEIPEHLA<T>> PJFDJIBAJKM<T>(string GGDHNGHHEEA, string HFMMOGFNCKA, string MDBLIKEKBCK, T OHCLPENAFEM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x68FAF80", Offset = "0x68F9580", VA = "0x1868FAF80")]
		private bool PBFGOJAOGAM(float AOBHKJKOOND, float DNBGCDFFBOI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x68F86D0", Offset = "0x68F6CD0", VA = "0x1868F86D0")]
		private Dictionary<string, object> IJCLOLBFGGM(string HFMMOGFNCKA, Dictionary<string, object> OHCLPENAFEM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x68FC170", Offset = "0x68FA770", VA = "0x1868FC170")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x68FAD80", Offset = "0x68F9380", VA = "0x1868FAD80")]
		[CompilerGenerated]
		private long OLGHABPLAMA()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x68F7D20", Offset = "0x68F6320", VA = "0x1868F7D20")]
		[CompilerGenerated]
		private void CNKANBKGIFJ(int LJEKBGKHCOH)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class IJGJJOJKABO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private long NKCGONIDCEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private FHLPMEBFNDD EJOINPNDIKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private bool HIMFHHIKDDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private float PJAHJDNFKAN;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x68FFC50", Offset = "0x68FE250", VA = "0x1868FFC50")]
	public IJGJJOJKABO(string NKBOOPPFPHJ, float PJAHJDNFKAN = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x11D6840", Offset = "0x11D4E40", VA = "0x1811D6840")]
	public void GEPDKONMJHC<T>(string JCPKNOEICEG, T MOLEJFDINLH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x68FF8B0", Offset = "0x68FDEB0", VA = "0x1868FF8B0")]
	public void GEPDKONMJHC(string JCPKNOEICEG, string MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x68FFB10", Offset = "0x68FE110", VA = "0x1868FFB10")]
	public void NPNNPNPEOJB(string GLIBNGCJCDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x68FFA50", Offset = "0x68FE050", VA = "0x1868FFA50")]
	public void MGKPLHPJNMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x68FF930", Offset = "0x68FDF30", VA = "0x1868FF930")]
	private void HLIMFEFKMLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x68FFC00", Offset = "0x68FE200", VA = "0x1868FFC00")]
	private bool ODAKDBEMEDD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public enum GDAFKHJEGPL
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
public class JHKLELHFMDL : NEOAJDCIMKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private NEOAJDCIMKB GPICDKJGKGD;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private NEOAJDCIMKB KIAIEGBMNCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x68FFE90", Offset = "0x68FE490", VA = "0x1868FFE90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool DONKHGNKKGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6900710", Offset = "0x68FED10", VA = "0x186900710", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action OJCIFDHMNLK
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x6900570", Offset = "0x68FEB70", VA = "0x186900570", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x68FFDF0", Offset = "0x68FE3F0", VA = "0x1868FFDF0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action COMLGBGOGAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x6900900", Offset = "0x68FEF00", VA = "0x186900900", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6900860", Offset = "0x68FEE60", VA = "0x186900860", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	[UnityEngine.Scripting.Preserve]
	public JHKLELHFMDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6900110", Offset = "0x68FE710", VA = "0x186900110")]
	[HFALCAKMDCP(BFPOMPMIJIJ.GameOnly)]
	private static void GBPEJJMEKGC(HOKFDAHMIPF IBEPDAFMEAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x68FFFA0", Offset = "0x68FE5A0", VA = "0x1868FFFA0")]
	[HFALCAKMDCP(BFPOMPMIJIJ.EditorOnly)]
	private static void EDCDHEBPGAA(HOKFDAHMIPF IBEPDAFMEAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6900180", Offset = "0x68FE780", VA = "0x186900180", Slot = "8")]
	public HHGLIBCDIDA GMAKAKECEDK(string CODDLHKNKNP, string GHOKMMJMKEB, [Optional] GPONBJCOILP PHACEBJGLFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6900010", Offset = "0x68FE610", VA = "0x186900010", Slot = "10")]
	public HHGLIBCDIDA FJKIEGJFCNE(GPONBJCOILP PHACEBJGLFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6900460", Offset = "0x68FEA60", VA = "0x186900460", Slot = "11")]
	public HHGLIBCDIDA IKPGFHAADEH(GPONBJCOILP PHACEBJGLFN, Dictionary<string, string> OBFDHMHPMHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x68FFF00", Offset = "0x68FE500", VA = "0x1868FFF00", Slot = "12")]
	public bool COFCFAGECKC(string PEKFDFFNPEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6900760", Offset = "0x68FED60", VA = "0x186900760", Slot = "13")]
	public KMEIPPDNGNG NPGFKNEMKEC(string IFGHBBPLIJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x6900610", Offset = "0x68FEC10", VA = "0x186900610", Slot = "14")]
	public JFIHGEBKBJM KLEMBLKOOKJ(string GCDDJIMENFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x69009A0", Offset = "0x68FEFA0", VA = "0x1869009A0", Slot = "15")]
	public HHGLIBCDIDA PGGKADIBJGE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0xA839D0", Offset = "0xA81FD0", VA = "0x180A839D0")]
	[CompilerGenerated]
	private void OLBOAMIOEJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0xA48110", Offset = "0xA46710", VA = "0x180A48110")]
	[CompilerGenerated]
	private void INIKBNMCEFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class KGBENGMKBOI : NEOAJDCIMKB
{
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static readonly IReadOnlyDictionary<string, OMAFGINDHAA> CCKIMAKHBOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private bool BBLMNDGEOJD;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool DONKHGNKKGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x979990", Offset = "0x977F90", VA = "0x180979990", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action OJCIFDHMNLK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6901EE0", Offset = "0x69004E0", VA = "0x186901EE0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6900A90", Offset = "0x68FF090", VA = "0x186900A90", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action COMLGBGOGAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6902320", Offset = "0x6900920", VA = "0x186902320", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6902280", Offset = "0x6900880", VA = "0x186902280", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x6901520", Offset = "0x68FFB20", VA = "0x186901520", Slot = "8")]
	public HHGLIBCDIDA GMAKAKECEDK(string CODDLHKNKNP, string GHOKMMJMKEB, [Optional] GPONBJCOILP PHACEBJGLFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6902560", Offset = "0x6900B60", VA = "0x186902560", Slot = "15")]
	public HHGLIBCDIDA PGGKADIBJGE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x6901300", Offset = "0x68FF900", VA = "0x186901300", Slot = "10")]
	public HHGLIBCDIDA FJKIEGJFCNE(GPONBJCOILP PHACEBJGLFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x69019C0", Offset = "0x68FFFC0", VA = "0x1869019C0", Slot = "11")]
	public HHGLIBCDIDA IKPGFHAADEH(GPONBJCOILP PHACEBJGLFN, Dictionary<string, string> OBFDHMHPMHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x6901250", Offset = "0x68FF850", VA = "0x186901250", Slot = "12")]
	public bool COFCFAGECKC(string PEKFDFFNPEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x69020D0", Offset = "0x69006D0", VA = "0x1869020D0", Slot = "13")]
	public KMEIPPDNGNG NPGFKNEMKEC(string IFGHBBPLIJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x6901F80", Offset = "0x6900580", VA = "0x186901F80", Slot = "14")]
	public JFIHGEBKBJM KLEMBLKOOKJ(string GCDDJIMENFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x6900B30", Offset = "0x68FF130", VA = "0x186900B30")]
	private ECLLHBGAEEG BIGGFINENPA(GPONBJCOILP PHACEBJGLFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x69023C0", Offset = "0x69009C0", VA = "0x1869023C0")]
	private BFOLPIMCPCF PFLPGAIPJJN(string GHOKMMJMKEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x6901CB0", Offset = "0x69002B0", VA = "0x186901CB0")]
	private void JDALNEPFCGN(string IFGHBBPLIJN, KMEIPPDNGNG GCGOLIKBAAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6902820", Offset = "0x6900E20", VA = "0x186902820")]
	public KGBENGMKBOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0xC0F930", Offset = "0xC0DF30", VA = "0x180C0F930")]
	[CompilerGenerated]
	private void PMDECLDKFME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6902040", Offset = "0x6900640", VA = "0x186902040")]
	[CompilerGenerated]
	private void KNILHONDIIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x69021F0", Offset = "0x69007F0", VA = "0x1869021F0")]
	[CompilerGenerated]
	private void OAPDNAPDPDF()
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
			[Cpp2IlInjected.Address(RVA = "0x7EA010", Offset = "0x7E8610", VA = "0x1807EA010")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x8BD370", Offset = "0x8BB970", VA = "0x1808BD370")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6903FE0", Offset = "0x69025E0", VA = "0x186903FE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface NEOAJDCIMKB
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	bool DONKHGNKKGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action OJCIFDHMNLK;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action COMLGBGOGAI;

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "4")]
	HHGLIBCDIDA GMAKAKECEDK(string CODDLHKNKNP, string GHOKMMJMKEB, [Optional] GPONBJCOILP PHACEBJGLFN);

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "6")]
	HHGLIBCDIDA FJKIEGJFCNE(GPONBJCOILP PHACEBJGLFN);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "7")]
	HHGLIBCDIDA IKPGFHAADEH(GPONBJCOILP PHACEBJGLFN, Dictionary<string, string> OBFDHMHPMHP);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool COFCFAGECKC(string PEKFDFFNPEE);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	KMEIPPDNGNG NPGFKNEMKEC(string IFGHBBPLIJN);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	JFIHGEBKBJM KLEMBLKOOKJ(string GCDDJIMENFD);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	HHGLIBCDIDA PGGKADIBJGE();
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class FOBICGFIEIM : NEOAJDCIMKB
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool DONKHGNKKGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x7EB370", Offset = "0x7E9970", VA = "0x1807EB370", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action OJCIFDHMNLK
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x68FF4B0", Offset = "0x68FDAB0", VA = "0x1868FF4B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x68FF230", Offset = "0x68FD830", VA = "0x1868FF230", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action COMLGBGOGAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x68FF610", Offset = "0x68FDC10", VA = "0x1868FF610", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x68FF570", Offset = "0x68FDB70", VA = "0x1868FF570", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	[RecRoom.NoEngine.Common.Preserve]
	public FOBICGFIEIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x68FF370", Offset = "0x68FD970", VA = "0x1868FF370", Slot = "8")]
	public HHGLIBCDIDA GMAKAKECEDK(string CODDLHKNKNP, string GHOKMMJMKEB, [Optional] GPONBJCOILP PHACEBJGLFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x68FF2D0", Offset = "0x68FD8D0", VA = "0x1868FF2D0", Slot = "10")]
	public HHGLIBCDIDA FJKIEGJFCNE(GPONBJCOILP PHACEBJGLFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x68FF410", Offset = "0x68FDA10", VA = "0x1868FF410", Slot = "11")]
	public HHGLIBCDIDA IKPGFHAADEH(GPONBJCOILP PHACEBJGLFN, Dictionary<string, string> OBFDHMHPMHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x7F4850", Offset = "0x7F2E50", VA = "0x1807F4850", Slot = "12")]
	public bool COFCFAGECKC(string PEKFDFFNPEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x68FF560", Offset = "0x68FDB60", VA = "0x1868FF560", Slot = "13")]
	public KMEIPPDNGNG NPGFKNEMKEC(string IFGHBBPLIJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x68FF550", Offset = "0x68FDB50", VA = "0x1868FF550", Slot = "14")]
	public JFIHGEBKBJM KLEMBLKOOKJ(string GCDDJIMENFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x68FF6B0", Offset = "0x68FDCB0", VA = "0x1868FF6B0", Slot = "15")]
	public HHGLIBCDIDA PGGKADIBJGE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface GPONBJCOILP
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	bool ANECIGOKAHN
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	bool OGGCKAPNOAE
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	bool HBHHLKAEHKF
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	bool? IHKNDAOGAAI
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	int? AFOJENEBPJE
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	int HPBDLLAJPJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	string GONDJFMLKMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	string HHDLIAIEEJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	string LICELDLDCJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	long FDEKDKOLJEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	string KEFMHOPAHCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	string AHPDNJJFOCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	string PEDLIHNGHAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	string LGCNNGEGJNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	double FEOEGBKJPBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	int MJJKCMIPIPD
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface JECGMDBPJDA
{
	[Cpp2IlInjected.Token(Token = "0x17000040")]
	long MGGOLFJEKJH
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	long EKKFEGHLJHP();

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LFJHAFKLNLM(long CMAECAJJLHA, bool AOGPLEBDKIG = true);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FILINIFMHKH(string MFPELEJLJLD, string BBEGJLDDBEJ, string MEICMCHOOMB);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MCFNGMDFPKN(string MFPELEJLJLD);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MEBJDDPOOOI(string MFPELEJLJLD, string KFGFFGOHJAF, string FNMHJLEIKDA);

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HONINBBENMG(string MCLGIMEHNKA, object NGGOJMKIOMJ, object ICBEOJDMNDD);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface MACOIICMODD
{
	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IJGJJOJKABO LBOJBOAGEOK(string NKBOOPPFPHJ);
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

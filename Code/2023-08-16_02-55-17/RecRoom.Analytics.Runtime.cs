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
		[Cpp2IlInjected.Address(RVA = "0x7E5080", Offset = "0x7E4280", VA = "0x1807E5080")]
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
		[Cpp2IlInjected.Address(RVA = "0x6878C20", Offset = "0x6877E20", VA = "0x186878C20")]
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
		[Cpp2IlInjected.Address(RVA = "0x17C7540", Offset = "0x17C6740", VA = "0x1817C7540")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class KJDNKBAMHFD
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> BGIIFHKDBBL;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6876190", Offset = "0x6875390", VA = "0x186876190")]
	internal static bool HBFNGMPJBJC(string JCEGKCPOPDM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface OFEOKDLMOKM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool CNALBGOKIAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string ONHCNMELDLH
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	string GNACGHMLOLD
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	string LEIOMGPPNNC
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	string KDHPHHKNFNE
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	OOMFLHAHLDK<CGCBCJBNGHM> JABMLBPPCDF(string KCDDHIBJJDG, Dictionary<string, string> KBNKMDHKMEN, bool BBCEKBHAMFI = false);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	OOMFLHAHLDK<CGCBCJBNGHM> EAIBIPMPAFC(string KCDDHIBJJDG, string DPIAECLEEAG, string HGMBCBHOCGM, string HMBGGNLABHD);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct CGCBCJBNGHM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly int JCMPDNAGEIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly string JOPADFMEDLA;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xAA98E0", Offset = "0xAA8AE0", VA = "0x180AA98E0")]
	public CGCBCJBNGHM(int MPCJCMAJICM, string PGENPIBGHKH)
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
		public AmplitudeAnalyticsClient.Settings CGIACEKFCIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xA3F300", Offset = "0xA3E500", VA = "0x180A3F300")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool BJEHGIGBHNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8D3890", Offset = "0x8D2A90", VA = "0x1808D3890")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x89BCA0", Offset = "0x89AEA0", VA = "0x18089BCA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6874640", Offset = "0x6873840", VA = "0x186874640")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x6874710", Offset = "0x6873910", VA = "0x186874710")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static string StableId
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6874680", Offset = "0x6873880", VA = "0x186874680")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6874760", Offset = "0x6873960", VA = "0x186874760")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static string ClientLauncher
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6874600", Offset = "0x6873800", VA = "0x186874600")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x68746C0", Offset = "0x68738C0", VA = "0x1868746C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x9CCD40", Offset = "0x9CBF40", VA = "0x1809CCD40")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6874330", Offset = "0x6873530", VA = "0x186874330")]
		public static MGNPEGAFJGL JKAAGGANCJG(string KBIJDJHCEBH, [NotNull] string JHNLOGNHNGO, long BHDKFACMMAA, long MLJLKNDBMMO, string OFEEHFFCCPI, bool AKFGMMLNKFG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x68740C0", Offset = "0x68732C0", VA = "0x1868740C0")]
		public static MGNPEGAFJGL HLIKBJNLNKB(string KBIJDJHCEBH, [NotNull] string JHNLOGNHNGO, long BHDKFACMMAA, long MLJLKNDBMMO, string OFEEHFFCCPI, long BNAFICJGFCB, bool AKFGMMLNKFG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6874420", Offset = "0x6873620", VA = "0x186874420")]
		private AmplitudeAnalyticsEvent(string KBIJDJHCEBH, [NotNull] string JHNLOGNHNGO, long BHDKFACMMAA, long MLJLKNDBMMO, string OFEEHFFCCPI, bool AKFGMMLNKFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xFC2AC0", Offset = "0xFC1CC0", VA = "0x180FC2AC0")]
		public void ABLICLCGDNO(long MNEDDGFAFLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6873EC0", Offset = "0x68730C0", VA = "0x186873EC0", Slot = "5")]
		public override void BEBGOOFDKLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x68741D0", Offset = "0x68733D0", VA = "0x1868741D0", Slot = "6")]
		public override void ICHIHHAAJBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6873980", Offset = "0x6872B80", VA = "0x186873980", Slot = "4")]
		protected override Dictionary<string, object> ADHGBNLGGKO(Dictionary<string, object> KENONNEDPBB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6873FB0", Offset = "0x68731B0", VA = "0x186873FB0")]
		private void HGAGJFFAOAN(string JCEGKCPOPDM, string NABCGCEIEGG, bool PBNNHJPLDKE = false)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ENJCAGHFFNH : MHNOMAPHOOM<AmplitudeAnalyticsIdentifyMessage, ENJCAGHFFNH>
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override ENJCAGHFFNH DNFBBALJDLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xF91D70", Offset = "0xF90F70", VA = "0x180F91D70", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7E9420", Offset = "0x7E8620", VA = "0x1807E9420", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage IDLCMOGIALG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x68750E0", Offset = "0x68742E0", VA = "0x1868750E0")]
	public ENJCAGHFFNH(AmplitudeAnalyticsIdentifyMessage JPOEHOENKPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6875070", Offset = "0x6874270", VA = "0x186875070", Slot = "4")]
	public override void ICHIHHAAJBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class MGNPEGAFJGL : MHNOMAPHOOM<AmplitudeAnalyticsEvent, MGNPEGAFJGL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private bool MHPBEJMDEHI;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override MGNPEGAFJGL DNFBBALJDLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xF91D70", Offset = "0xF90F70", VA = "0x180F91D70", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public long FPMFJNECEJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2107BB0", Offset = "0x2106DB0", VA = "0x182107BB0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6877530", Offset = "0x6876730", VA = "0x186877530")]
	public MGNPEGAFJGL(AmplitudeAnalyticsEvent JPOEHOENKPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7E9420", Offset = "0x7E8620", VA = "0x1807E9420", Slot = "5")]
	public override AmplitudeAnalyticsEvent IDLCMOGIALG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x68772E0", Offset = "0x68764E0", VA = "0x1868772E0", Slot = "4")]
	public override void ICHIHHAAJBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1245020", Offset = "0x1244220", VA = "0x181245020")]
	public MGNPEGAFJGL PBLMBKCJCCL<T>(string BGOCDAGKFNE, T[] NABCGCEIEGG) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6877520", Offset = "0x6876720", VA = "0x186877520")]
	public MGNPEGAFJGL PBLMBKCJCCL(string BGOCDAGKFNE, string[] NABCGCEIEGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1244D00", Offset = "0x1243F00", VA = "0x181244D00")]
	public MGNPEGAFJGL PBLMBKCJCCL<T>(string BGOCDAGKFNE, T NABCGCEIEGG) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6877490", Offset = "0x6876690", VA = "0x186877490")]
	public MGNPEGAFJGL PBLMBKCJCCL(string BGOCDAGKFNE, long NABCGCEIEGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6877420", Offset = "0x6876620", VA = "0x186877420")]
	public MGNPEGAFJGL PBLMBKCJCCL(string BGOCDAGKFNE, string NABCGCEIEGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x68771B0", Offset = "0x68763B0", VA = "0x1868771B0")]
	public MGNPEGAFJGL EGOBLMOINNP(string BGOCDAGKFNE, object? NABCGCEIEGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6877380", Offset = "0x6876580", VA = "0x186877380")]
	public MGNPEGAFJGL NMPJMDAJBBC(string BGOCDAGKFNE, string NABCGCEIEGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x68771E0", Offset = "0x68763E0", VA = "0x1868771E0")]
	private MGNPEGAFJGL HIIKBJGLKNC(string BGOCDAGKFNE, object NABCGCEIEGG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class NCLDJNKCNAO : MGNPEGAFJGL
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6877530", Offset = "0x6876730", VA = "0x186877530")]
	public NCLDJNKCNAO(AmplitudeAnalyticsEvent JPOEHOENKPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6877D90", Offset = "0x6876F90", VA = "0x186877D90", Slot = "4")]
	public override void ICHIHHAAJBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class MHNOMAPHOOM<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : MHNOMAPHOOM<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected M JPOEHOENKPI;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public abstract BLDR DNFBBALJDLO
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1C453A0", Offset = "0x1C445A0", VA = "0x181C453A0")]
	public MHNOMAPHOOM(M JPOEHOENKPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3AA3CF0", Offset = "0x3AA2EF0", VA = "0x183AA3CF0")]
	public BLDR BMENDNJDLPI(AmplitudeAnalyticsIdentifyMessage.DeviceInfo NMPKAOGAHDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3AA3E30", Offset = "0x3AA3030", VA = "0x183AA3E30")]
	public BLDR KILJKBIOMCC(AmplitudeAnalyticsIdentifyMessage.RevenueData DLCJJLGMDFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3AA3EA0", Offset = "0x3AA30A0", VA = "0x183AA3EA0")]
	public BLDR OBFEMOENNPH(string BGOCDAGKFNE, string NABCGCEIEGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x236BC20", Offset = "0x236AE20", VA = "0x18236BC20")]
	public BLDR OBFEMOENNPH<T>(string BGOCDAGKFNE, T NABCGCEIEGG) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void ICHIHHAAJBB();

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3AA3E70", Offset = "0x3AA3070", VA = "0x183AA3E70")]
	internal static string MGPOAKCDLLM(string NABCGCEIEGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3AA3D30", Offset = "0x3AA2F30", VA = "0x183AA3D30")]
	private BLDR FAGDPOPIMIJ(string BGOCDAGKFNE, object NABCGCEIEGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M IDLCMOGIALG();
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
			[Cpp2IlInjected.Address(RVA = "0x6874EF0", Offset = "0x68740F0", VA = "0x186874EF0")]
			public void NJKMIBDBLPO(Dictionary<string, object> INAMDHPNPKA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
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
			[Cpp2IlInjected.Address(RVA = "0x687C4D0", Offset = "0x687B6D0", VA = "0x18687C4D0")]
			public void NJKMIBDBLPO(Dictionary<string, object> ILEPIPIIDAL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x687C640", Offset = "0x687B840", VA = "0x18687C640")]
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
			[Cpp2IlInjected.Address(RVA = "0x7E2110", Offset = "0x7E1310", VA = "0x1807E2110")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x902EE0", Offset = "0x9020E0", VA = "0x180902EE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6874C10", Offset = "0x6873E10", VA = "0x186874C10")]
		public static ENJCAGHFFNH JKAAGGANCJG(string KBIJDJHCEBH, string OFEEHFFCCPI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6874DF0", Offset = "0x6873FF0", VA = "0x186874DF0")]
		protected AmplitudeAnalyticsIdentifyMessage(string KBIJDJHCEBH, string OFEEHFFCCPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6874CC0", Offset = "0x6873EC0", VA = "0x186874CC0")]
		public Dictionary<string, object> JLJAEFBOCAB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x68747B0", Offset = "0x68739B0", VA = "0x1868747B0", Slot = "4")]
		protected virtual Dictionary<string, object> ADHGBNLGGKO(Dictionary<string, object> KENONNEDPBB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6874D40", Offset = "0x6873F40", VA = "0x186874D40")]
		protected void LNPMIKKLFHB(string JCEGKCPOPDM, Dictionary<string, object> MMPKMKGCEOK, Dictionary<string, object> CJIBHLCDILO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6874BA0", Offset = "0x6873DA0", VA = "0x186874BA0")]
		protected void JJDEANOHGMD(string JCEGKCPOPDM, string NABCGCEIEGG, Dictionary<string, object> NJNCLAPHFCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6874AF0", Offset = "0x6873CF0", VA = "0x186874AF0", Slot = "5")]
		public virtual void BEBGOOFDKLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6874B50", Offset = "0x6873D50", VA = "0x186874B50", Slot = "6")]
		public virtual void ICHIHHAAJBB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		private enum ABAIJHGMJDF
		{
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		internal class POKPHIJEOCL
		{
			[Cpp2IlInjected.Token(Token = "0x2000015")]
			private class LNMNKFDGGDK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000067")]
				public int BMPLFBPNFLB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000068")]
				public Dictionary<string, object> IIODJIPLNOD;

				[Cpp2IlInjected.Token(Token = "0x6000098")]
				[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
				public LNMNKFDGGDK()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000016")]
			[CompilerGenerated]
			private sealed class NDPJLJKGABO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000069")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000099")]
				[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
				public NDPJLJKGABO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600009A")]
				[Cpp2IlInjected.Address(RVA = "0x6877F20", Offset = "0x6877120", VA = "0x186877F20")]
				internal bool CLNIBEEOIHG(LNMNKFDGGDK item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private const string MOCMDMBDDHO = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			private readonly string NOFBJAIDPEL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private List<LNMNKFDGGDK> GFCFGPOLCJD;

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public int? DFNBCFONIJD
			{
				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0x687B5C0", Offset = "0x687A7C0", VA = "0x18687B5C0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x687C340", Offset = "0x687B540", VA = "0x18687C340")]
			internal POKPHIJEOCL(string EFOHMENLMLK, string HAFMDBGOGIH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x687B660", Offset = "0x687A860", VA = "0x18687B660")]
			public int GPBICLHNFEG([Optional] int? LNNDEHJLDGA)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x687BDC0", Offset = "0x687AFC0", VA = "0x18687BDC0")]
			public List<Dictionary<string, object>> MNMMLPHJNFD(int ADJBPNJMAIL, int? LNNDEHJLDGA)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x687C2A0", Offset = "0x687B4A0", VA = "0x18687C2A0")]
			public void PIPPGLDJFOM(AmplitudeAnalyticsIdentifyMessage PPNJOAJJOFF, bool PINEJHGIBEE = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x687C190", Offset = "0x687B390", VA = "0x18687C190")]
			public void PIPPGLDJFOM(Dictionary<string, object> PPNJOAJJOFF, bool PINEJHGIBEE = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x687B7E0", Offset = "0x687A9E0", VA = "0x18687B7E0")]
			public void HKBFKJPEBNH(params Dictionary<string, object>[] GBILMJHNBDD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x687B100", Offset = "0x687A300", VA = "0x18687B100")]
			public void BOCCAABCEAC(List<Dictionary<string, object>> AKFJNAKKGED)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x687AFC0", Offset = "0x687A1C0", VA = "0x18687AFC0")]
			private void APPIHOKJOFB(Dictionary<string, object> PPNJOAJJOFF, bool PINEJHGIBEE = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x687B350", Offset = "0x687A550", VA = "0x18687B350")]
			public void EDBAHNPIPMN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x687B970", Offset = "0x687AB70", VA = "0x18687B970")]
			private void KHNEHKPKFAP([Optional] string EFLAIFHHJII)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x687C060", Offset = "0x687B260", VA = "0x18687C060")]
			private static string PCKMGDPEDJB(string NABCGCEIEGG, string JCEGKCPOPDM)
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
			[Cpp2IlInjected.Address(RVA = "0x687C8A0", Offset = "0x687BAA0", VA = "0x18687C8A0")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public struct NNJFMNNAPII<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public int MPCJCMAJICM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public string PGENPIBGHKH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public T EDDJCJPBNAG;
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class JMEHNPAAFPK : IEnumerator<MPEFECEHMLJ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private MPEFECEHMLJ <>2__current;

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
			private MPEFECEHMLJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000A4")]
				[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xA0AFF0", Offset = "0xA0A1F0", VA = "0x180A0AFF0")]
			[DebuggerHidden]
			public JMEHNPAAFPK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x68759E0", Offset = "0x6874BE0", VA = "0x1868759E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x6876150", Offset = "0x6875350", VA = "0x186876150", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class OEOOBIDFDBA : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public MGJKNPFOJOG quitCompletePromise;

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
				[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xA0AFF0", Offset = "0xA0A1F0", VA = "0x180A0AFF0")]
			[DebuggerHidden]
			public OEOOBIDFDBA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x6878CB0", Offset = "0x6877EB0", VA = "0x186878CB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x6878DD0", Offset = "0x6877FD0", VA = "0x186878DD0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class HPNHBGCHDED : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xA0AFF0", Offset = "0xA0A1F0", VA = "0x180A0AFF0")]
			[DebuggerHidden]
			public HPNHBGCHDED(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x6875130", Offset = "0x6874330", VA = "0x186875130", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x68752C0", Offset = "0x68744C0", VA = "0x1868752C0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class IJEFFAFHILP : IEnumerator<MPEFECEHMLJ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			private MPEFECEHMLJ <>2__current;

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
			private POKPHIJEOCL <cache>5__2;

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
			private MPEFECEHMLJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000B6")]
				[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xA0AFF0", Offset = "0xA0A1F0", VA = "0x180A0AFF0")]
			[DebuggerHidden]
			public IJEFFAFHILP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x6875300", Offset = "0x6874500", VA = "0x186875300", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x6875670", Offset = "0x6874870", VA = "0x186875670", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class ILBEIINEBCP : IEnumerator<MPEFECEHMLJ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			private MPEFECEHMLJ <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public float timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			private POKPHIJEOCL <cache>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			private string <url>5__2;

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			private MPEFECEHMLJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000C0")]
				[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0xA0AFF0", Offset = "0xA0A1F0", VA = "0x180A0AFF0")]
			[DebuggerHidden]
			public ILBEIINEBCP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x68756B0", Offset = "0x68748B0", VA = "0x1868756B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x68759A0", Offset = "0x6874BA0", VA = "0x1868759A0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class MJJIAPBDLFN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public List<Dictionary<string, object>> batch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			public POKPHIJEOCL cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
			public MJJIAPBDLFN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x6877580", Offset = "0x6876780", VA = "0x186877580")]
			internal void IEEFCFBHGOP(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x68778F0", Offset = "0x6876AF0", VA = "0x1868778F0")]
			internal void KHDBIDHJJAM(NNJFMNNAPII<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[CompilerGenerated]
		private sealed class KMIILKJJPGN : IEnumerator<MPEFECEHMLJ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			private MPEFECEHMLJ <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			public POKPHIJEOCL cache;

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
			private MJJIAPBDLFN <>8__1;

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
			private MPEFECEHMLJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000C9")]
				[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xA0AFF0", Offset = "0xA0A1F0", VA = "0x180A0AFF0")]
			[DebuggerHidden]
			public KMIILKJJPGN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x6876880", Offset = "0x6875A80", VA = "0x186876880", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x6877170", Offset = "0x6876370", VA = "0x186877170", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class PHEIGIJHKFK<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x9CF3C0", Offset = "0x9CE5C0", VA = "0x1809CF3C0")]
			public PHEIGIJHKFK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x332D860", Offset = "0x332CA60", VA = "0x18332D860")]
			internal NNJFMNNAPII<T> CHJEPLMHIAK(CGCBCJBNGHM postResponse)
			{
				return default(NNJFMNNAPII<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private sealed class GCBJADCEPJC<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x9CF3C0", Offset = "0x9CE5C0", VA = "0x1809CF3C0")]
			public GCBJADCEPJC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x332D860", Offset = "0x332CA60", VA = "0x18332D860")]
			internal NNJFMNNAPII<T> LLNFPKBCEBJ(CGCBCJBNGHM postResponse)
			{
				return default(NNJFMNNAPII<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private GLPGJNOOMAG OLICNHGFKHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private Lazy<NFAFLJHOGNF> PHCEKHFCHGA;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private const string PGNDCPNAKED = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const string GMCKDHGHOPA = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private const string ENAMKNKOICA = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private const int PCFNJCFOAEM = 15;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private const int GKNDKDCGGAG = 10;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private const int DCFHOMOJJDE = 5;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private const float MJLDJOAIDMI = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private const long PGBDDBBLIEM = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private const string GMIICLMBLLB = "f1779b982f1c09aed3adb3cca563cbc2";

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private const string AJLBKCIIILJ = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static bool LJKKOJBBCGC;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static bool HBHDHIGGDMO;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static int NHCKBIPKGPA;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static int EJLIGJFNNII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private OFEOKDLMOKM HNEENBFJGAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private bool DIACDPLLBFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private float GFIJAFGEAIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private float FGADABPNELN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private int FJIFOPFIFED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private int ACNBLENKJOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private int? EMPEBDPFKNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private int? MAOEOFGKCHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private long HNMDEECAFHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private string AINPBMGJBND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private bool GIGKEFEFMOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private long DOAJOGFGDEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private Dictionary<string, object> ICONAENCMJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private ABAIJHGMJDF BIADNHJGALK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private int CCCDJPGAKAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private int PFPKELBEJGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private float EAGJAHFIANJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private bool GDMBJKEAABF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private bool BNJNKBGFMBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private POKPHIJEOCL CEGCELMCBHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private POKPHIJEOCL ILPGKLHLIMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private POKPHIJEOCL EEJLPLMLNLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> DCNDDOELMAC;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo BFADHJJOOGG;

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private static string AJOBCBBBKEL;

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private const string NHPLMACDOBC = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private readonly string HMFHAOEHEIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private readonly string GMBJLHNHLAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly string JAOAOHFPLKH;

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private GLPGJNOOMAG AHNDCIFAJLF
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x6870510", Offset = "0x686F710", VA = "0x186870510")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private NFAFLJHOGNF CFHMGMGKMJP
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x686EC90", Offset = "0x686DE90", VA = "0x18686EC90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private static int CCIBNDNONEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6871EF0", Offset = "0x68710F0", VA = "0x186871EF0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static long PAPABJIJBPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x6873820", Offset = "0x6872A20", VA = "0x186873820")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x6873920", Offset = "0x6872B20", VA = "0x186873920")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static string LNAONPFMKNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x68737C0", Offset = "0x68729C0", VA = "0x1868737C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static string JHFJGFBBBIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x68737F0", Offset = "0x68729F0", VA = "0x1868737F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public string FIFPIPDNDOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x8CC4B0", Offset = "0x8CB6B0", VA = "0x1808CC4B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x8CB690", Offset = "0x8CA890", VA = "0x1808CB690")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public int? IHDNAOLCOPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x8CC480", Offset = "0x8CB680", VA = "0x1808CC480")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xDB23A0", Offset = "0xDB15A0", VA = "0x180DB23A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool HKAKFMHKIKD
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x964270", Offset = "0x963470", VA = "0x180964270")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x962EF0", Offset = "0x9620F0", VA = "0x180962EF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static bool NKMEOEBFOMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x6873730", Offset = "0x6872930", VA = "0x186873730")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> LHAMCMPKAFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6873690", Offset = "0x6872890", VA = "0x186873690")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6873880", Offset = "0x6872A80", VA = "0x186873880")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x686E820", Offset = "0x686DA20", VA = "0x18686E820", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x686F8C0", Offset = "0x686EAC0", VA = "0x18686F8C0")]
		private void IKGDOMBNMFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6872DC0", Offset = "0x6871FC0", VA = "0x186872DC0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x68721C0", Offset = "0x68713C0", VA = "0x1868721C0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x68730A0", Offset = "0x68722A0", VA = "0x1868730A0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6872260", Offset = "0x6871460", VA = "0x186872260")]
		public GIOBGNHJLID PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6870080", Offset = "0x686F280", VA = "0x186870080")]
		[IteratorStateMachine(typeof(JMEHNPAAFPK))]
		public IEnumerator<MPEFECEHMLJ> Initialize(AmplitudeAnalyticsEvent FPEDDDJPLAF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6872FA0", Offset = "0x68721A0", VA = "0x186872FA0")]
		public void UpdateLastAliveTime(float JEBAFBJDHNC = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x686EF90", Offset = "0x686E190", VA = "0x18686EF90")]
		private GIOBGNHJLID EAIFLONDIPE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x686F140", Offset = "0x686E340", VA = "0x18686F140")]
		private GIOBGNHJLID EHOMICOOOPK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x68728C0", Offset = "0x6871AC0", VA = "0x1868728C0")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x686EB10", Offset = "0x686DD10", VA = "0x18686EB10")]
		[IteratorStateMachine(typeof(OEOOBIDFDBA))]
		private IEnumerator BFPGGGIDIAG(MGJKNPFOJOG NHEKHCJPLAM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6873320", Offset = "0x6872520", VA = "0x186873320")]
		[IteratorStateMachine(typeof(HPNHBGCHDED))]
		public IEnumerator WaitForFlush(float JOGKMNMDFDL = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6872E80", Offset = "0x6872080", VA = "0x186872E80")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6872DD0", Offset = "0x6871FD0", VA = "0x186872DD0")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime BNIHPJCDFCP)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x686FCD0", Offset = "0x686EED0", VA = "0x18686FCD0")]
		public static ENJCAGHFFNH Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x686E6C0", Offset = "0x686D8C0", VA = "0x18686E6C0")]
		public static MGNPEGAFJGL AccountSelectionPostLoginEvent([NotNull] string EIHCHJCBCGD, string OFEEHFFCCPI, bool AKFGMMLNKFG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x686F330", Offset = "0x686E530", VA = "0x18686F330")]
		public static MGNPEGAFJGL Event([NotNull] string EIHCHJCBCGD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6872420", Offset = "0x6871620", VA = "0x186872420")]
		public static MGNPEGAFJGL PreviousSessionEvent([NotNull] string EIHCHJCBCGD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x686FE00", Offset = "0x686F000", VA = "0x18686FE00")]
		public static MGNPEGAFJGL InitializeEvent(string OFEEHFFCCPI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6872AA0", Offset = "0x6871CA0", VA = "0x186872AA0")]
		public static MGNPEGAFJGL StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x686ECE0", Offset = "0x686DEE0", VA = "0x18686ECE0")]
		public static MGNPEGAFJGL CreateOutOfSessionEvent(string EIHCHJCBCGD, bool MKMJBAHKLPF = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x68719D0", Offset = "0x6870BD0", VA = "0x1868719D0")]
		public static GIOBGNHJLID LogOutOfSessionEvent(MGNPEGAFJGL PEFGBLCOKJK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6871730", Offset = "0x6870930", VA = "0x186871730")]
		public void LogEventAsync(AmplitudeAnalyticsEvent KBHPHMLMGJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6871CC0", Offset = "0x6870EC0", VA = "0x186871CC0")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent KBHPHMLMGJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6871E10", Offset = "0x6871010", VA = "0x186871E10")]
		public void LogSerializedEventAsync(Dictionary<string, object> MMOEBLBNGPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6871880", Offset = "0x6870A80", VA = "0x186871880")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage GEFJDFNFIGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x686EBA0", Offset = "0x686DDA0", VA = "0x18686EBA0")]
		private void BHOLNFOOKOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x686F610", Offset = "0x686E810", VA = "0x18686F610")]
		private void IGLPLJEBLDD(Dictionary<string, object> BCDNPHJJGCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x68720C0", Offset = "0x68712C0", VA = "0x1868720C0")]
		private void OIMPENELHNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6870600", Offset = "0x686F800", VA = "0x186870600")]
		private void KCILHPLDDFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x686F520", Offset = "0x686E720", VA = "0x18686F520")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6870580", Offset = "0x686F780", VA = "0x186870580")]
		[IteratorStateMachine(typeof(IJEFFAFHILP))]
		private IEnumerator<MPEFECEHMLJ> JONIMNDNKDA(float JOGKMNMDFDL = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x686F2B0", Offset = "0x686E4B0", VA = "0x18686F2B0")]
		[IteratorStateMachine(typeof(ILBEIINEBCP))]
		private IEnumerator<MPEFECEHMLJ> EMNGPHMEABM(float JOGKMNMDFDL = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x686F060", Offset = "0x686E260", VA = "0x18686F060")]
		[IteratorStateMachine(typeof(KMIILKJJPGN))]
		private IEnumerator<MPEFECEHMLJ> ECLCIIFLNMB(POKPHIJEOCL LAJNGMGNGED, int? LNNDEHJLDGA, string KCDDHIBJJDG, string ALPDHPGPGED, float JOGKMNMDFDL, Action<int> KGDICIFDCPG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x68714B0", Offset = "0x68706B0", VA = "0x1868714B0")]
		private static void LAOFLNKEGDF(bool GDJJNNHIPNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x68703E0", Offset = "0x686F5E0", VA = "0x1868703E0")]
		private OOMFLHAHLDK<NNJFMNNAPII<Dictionary<string, object>>> JABMLBPPCDF(string KCDDHIBJJDG, string ALPDHPGPGED, string DCIBOPKCCPN, string IMAFCJKNFJB, Dictionary<string, object> EDDJCJPBNAG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6870110", Offset = "0x686F310", VA = "0x186870110")]
		private OOMFLHAHLDK<NNJFMNNAPII<List<Dictionary<string, object>>>> JABMLBPPCDF(string KCDDHIBJJDG, string ALPDHPGPGED, string DCIBOPKCCPN, string IMAFCJKNFJB, List<Dictionary<string, object>> EDDJCJPBNAG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x21B27C0", Offset = "0x21B19C0", VA = "0x1821B27C0")]
		private OOMFLHAHLDK<NNJFMNNAPII<T>> MAKCGNKEPFJ<T>(string KCDDHIBJJDG, string ALPDHPGPGED, string IMAFCJKNFJB, T EDDJCJPBNAG, Dictionary<string, object> LMNLEOCNMEJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x21B2480", Offset = "0x21B1680", VA = "0x1821B2480")]
		private OOMFLHAHLDK<NNJFMNNAPII<T>> DAGKCPIHNDH<T>(string KCDDHIBJJDG, string ALPDHPGPGED, string DCIBOPKCCPN, T EDDJCJPBNAG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x686F5C0", Offset = "0x686E7C0", VA = "0x18686F5C0")]
		private bool IDIIGCNPCBC(float DNDEMKMKCAH, float JOGKMNMDFDL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x68707E0", Offset = "0x686F9E0", VA = "0x1868707E0")]
		private Dictionary<string, object> KCOMBAHAFIK(string ALPDHPGPGED, Dictionary<string, object> EDDJCJPBNAG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6873400", Offset = "0x6872600", VA = "0x186873400")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x68715D0", Offset = "0x68707D0", VA = "0x1868715D0")]
		[CompilerGenerated]
		private long LLDOJCFMCOD()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x686F5B0", Offset = "0x686E7B0", VA = "0x18686F5B0")]
		[CompilerGenerated]
		private void HJFBCPBKMBJ(int DIFGCNBDKDO)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class KLKOJMHJBHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private long LBJMFJGDDKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private MGNPEGAFJGL OAHCHPOKAGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private bool INDGJLBCDAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private float JAEGKDFGMFD;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x68766E0", Offset = "0x68758E0", VA = "0x1868766E0")]
	public KLKOJMHJBHO(string HHOFKEFKDJH, float JAEGKDFGMFD = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x1CD6270", Offset = "0x1CD5470", VA = "0x181CD6270")]
	public void PBLMBKCJCCL<T>(string BGOCDAGKFNE, T NABCGCEIEGG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6876660", Offset = "0x6875860", VA = "0x186876660")]
	public void PBLMBKCJCCL(string BGOCDAGKFNE, string NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6876570", Offset = "0x6875770", VA = "0x186876570")]
	public void LNJNANBIFFG(string IOGNIGKBCFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6876460", Offset = "0x6875660", VA = "0x186876460")]
	public void IGMLMPMCMJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6876340", Offset = "0x6875540", VA = "0x186876340")]
	private void FGILGDLMBNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6876520", Offset = "0x6875720", VA = "0x186876520")]
	private bool IMJDFFAPMFE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public enum BCMMLJGHECJ
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
public class NGMMKJHIOJI : HJMPLECDHEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private HJMPLECDHEG OAAHNENKIEO;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private HJMPLECDHEG MLPMIPJPDID
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x6877F80", Offset = "0x6877180", VA = "0x186877F80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool DILEBBOMEIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x68785C0", Offset = "0x68777C0", VA = "0x1868785C0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action NMBNCFGKFIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x6878280", Offset = "0x6877480", VA = "0x186878280", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x68789F0", Offset = "0x6877BF0", VA = "0x1868789F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action PNGNAEHGKMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x6878B80", Offset = "0x6877D80", VA = "0x186878B80", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6878100", Offset = "0x6877300", VA = "0x186878100", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	[UnityEngine.Scripting.Preserve]
	public NGMMKJHIOJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x68781A0", Offset = "0x68773A0", VA = "0x1868781A0")]
	[GKCPJLBLCDF(EHLDMJJGFKP.GameOnly)]
	private static void BPLMCGEOOMF(JFLMNMMPBBG AKLNKNCLGHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6878210", Offset = "0x6877410", VA = "0x186878210")]
	[GKCPJLBLCDF(EHLDMJJGFKP.EditorOnly)]
	private static void CCGCIIOBJHK(JFLMNMMPBBG AKLNKNCLGHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6878710", Offset = "0x6877910", VA = "0x186878710", Slot = "8")]
	public GIOBGNHJLID KCEHONPEIFO(string NABNLPDBLFN, string HAFMDBGOGIH, [Optional] FFLJBJFDKBO NMIOMKIIIOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x68784C0", Offset = "0x68776C0", VA = "0x1868784C0", Slot = "10")]
	public GIOBGNHJLID FHHBPMLPDDJ(FFLJBJFDKBO NMIOMKIIIOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6877FF0", Offset = "0x68771F0", VA = "0x186877FF0", Slot = "11")]
	public GIOBGNHJLID APMDMEFHDOP(FFLJBJFDKBO NMIOMKIIIOO, Dictionary<string, string> DABNJDJGJFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6878320", Offset = "0x6877520", VA = "0x186878320", Slot = "12")]
	public bool DNCHNCFFALH(string FMDLJCLCFLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6878610", Offset = "0x6877810", VA = "0x186878610", Slot = "13")]
	public NACMJPCGIIJ JLCDGAMNOGN(string AHNJKFFHNBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x68783C0", Offset = "0x68775C0", VA = "0x1868783C0", Slot = "14")]
	public MECFNPFCLHB FEDFOLKFLEA(string IIODNPCCIOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6878A90", Offset = "0x6877C90", VA = "0x186878A90", Slot = "15")]
	public GIOBGNHJLID MLLGEJPPILJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x8BF3F0", Offset = "0x8BE5F0", VA = "0x1808BF3F0")]
	[CompilerGenerated]
	private void DDJOOCLNMAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x8BF3D0", Offset = "0x8BE5D0", VA = "0x1808BF3D0")]
	[CompilerGenerated]
	private void IFNHHJHAIKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class PIGDOPMFABG : HJMPLECDHEG
{
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static readonly IReadOnlyDictionary<string, IIFHJAIGOMC> JEJMDJMIBHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private bool NGPFIFNMGLN;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool DILEBBOMEIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xAAB280", Offset = "0xAAA480", VA = "0x180AAB280", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action NMBNCFGKFIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x68791A0", Offset = "0x68783A0", VA = "0x1868791A0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x687A3B0", Offset = "0x68795B0", VA = "0x18687A3B0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action PNGNAEHGKMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x687A810", Offset = "0x6879A10", VA = "0x18687A810", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6879100", Offset = "0x6878300", VA = "0x186879100", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x6879F10", Offset = "0x6879110", VA = "0x186879F10", Slot = "8")]
	public GIOBGNHJLID KCEHONPEIFO(string NABNLPDBLFN, string HAFMDBGOGIH, [Optional] FFLJBJFDKBO NMIOMKIIIOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x687A680", Offset = "0x6879880", VA = "0x18687A680", Slot = "15")]
	public GIOBGNHJLID MLLGEJPPILJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x68793B0", Offset = "0x68785B0", VA = "0x1868793B0", Slot = "10")]
	public GIOBGNHJLID FHHBPMLPDDJ(FFLJBJFDKBO NMIOMKIIIOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x6878E10", Offset = "0x6878010", VA = "0x186878E10", Slot = "11")]
	public GIOBGNHJLID APMDMEFHDOP(FFLJBJFDKBO NMIOMKIIIOO, Dictionary<string, string> DABNJDJGJFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x6879240", Offset = "0x6878440", VA = "0x186879240", Slot = "12")]
	public bool DNCHNCFFALH(string FMDLJCLCFLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6879DF0", Offset = "0x6878FF0", VA = "0x186879DF0", Slot = "13")]
	public NACMJPCGIIJ JLCDGAMNOGN(string AHNJKFFHNBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x68792F0", Offset = "0x68784F0", VA = "0x1868792F0", Slot = "14")]
	public MECFNPFCLHB FEDFOLKFLEA(string IIODNPCCIOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x6879800", Offset = "0x6878A00", VA = "0x186879800")]
	private CAPODMLMJMN JILJEBDCMBG(FFLJBJFDKBO NMIOMKIIIOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x68795D0", Offset = "0x68787D0", VA = "0x1868795D0")]
	private DJOBHFMLMNA HDHIDBNPDID(string HAFMDBGOGIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x687A450", Offset = "0x6879650", VA = "0x18687A450")]
	private void MKMBADNOLMO(string AHNJKFFHNBC, NACMJPCGIIJ EDIJJHKDDAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x687AA70", Offset = "0x6879C70", VA = "0x18687AA70")]
	public PIGDOPMFABG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0xF4B4C0", Offset = "0xF4A6C0", VA = "0x180F4B4C0")]
	[CompilerGenerated]
	private void DKGPGODNBEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x687A8B0", Offset = "0x6879AB0", VA = "0x18687A8B0")]
	[CompilerGenerated]
	private void OBPDGOJELNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6879770", Offset = "0x6878970", VA = "0x186879770")]
	[CompilerGenerated]
	private void IHFLNNOCGGJ()
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
			[Cpp2IlInjected.Address(RVA = "0x7E2110", Offset = "0x7E1310", VA = "0x1807E2110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x7EBAE0", Offset = "0x7EACE0", VA = "0x1807EBAE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x687C650", Offset = "0x687B850", VA = "0x18687C650", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface HJMPLECDHEG
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	bool DILEBBOMEIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action NMBNCFGKFIC;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action PNGNAEHGKMD;

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GIOBGNHJLID KCEHONPEIFO(string NABNLPDBLFN, string HAFMDBGOGIH, [Optional] FFLJBJFDKBO NMIOMKIIIOO);

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GIOBGNHJLID FHHBPMLPDDJ(FFLJBJFDKBO NMIOMKIIIOO);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GIOBGNHJLID APMDMEFHDOP(FFLJBJFDKBO NMIOMKIIIOO, Dictionary<string, string> DABNJDJGJFA);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool DNCHNCFFALH(string FMDLJCLCFLJ);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	NACMJPCGIIJ JLCDGAMNOGN(string AHNJKFFHNBC);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	MECFNPFCLHB FEDFOLKFLEA(string IIODNPCCIOK);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	GIOBGNHJLID MLLGEJPPILJ();
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class PMPKJHKAOOK : HJMPLECDHEG
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool DILEBBOMEIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x7E30C0", Offset = "0x7E22C0", VA = "0x1807E30C0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action NMBNCFGKFIC
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x687ABE0", Offset = "0x6879DE0", VA = "0x18687ABE0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x687ADE0", Offset = "0x6879FE0", VA = "0x18687ADE0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action PNGNAEHGKMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x687AF20", Offset = "0x687A120", VA = "0x18687AF20", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x687AB40", Offset = "0x6879D40", VA = "0x18687AB40", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	[RecRoom.NoEngine.Common.Preserve]
	public PMPKJHKAOOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x687AD40", Offset = "0x6879F40", VA = "0x18687AD40", Slot = "8")]
	public GIOBGNHJLID KCEHONPEIFO(string NABNLPDBLFN, string HAFMDBGOGIH, [Optional] FFLJBJFDKBO NMIOMKIIIOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x687AC90", Offset = "0x6879E90", VA = "0x18687AC90", Slot = "10")]
	public GIOBGNHJLID FHHBPMLPDDJ(FFLJBJFDKBO NMIOMKIIIOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x687AAA0", Offset = "0x6879CA0", VA = "0x18687AAA0", Slot = "11")]
	public GIOBGNHJLID APMDMEFHDOP(FFLJBJFDKBO NMIOMKIIIOO, Dictionary<string, string> DABNJDJGJFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x7E30B0", Offset = "0x7E22B0", VA = "0x1807E30B0", Slot = "12")]
	public bool DNCHNCFFALH(string FMDLJCLCFLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x687AD30", Offset = "0x6879F30", VA = "0x18687AD30", Slot = "13")]
	public NACMJPCGIIJ JLCDGAMNOGN(string AHNJKFFHNBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x687AC80", Offset = "0x6879E80", VA = "0x18687AC80", Slot = "14")]
	public MECFNPFCLHB FEDFOLKFLEA(string IIODNPCCIOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x687AE80", Offset = "0x687A080", VA = "0x18687AE80", Slot = "15")]
	public GIOBGNHJLID MLLGEJPPILJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface FFLJBJFDKBO
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	bool PMLFKBIAMOK
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	bool AGFGJMDCLGG
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	bool DHEOPEHCLKM
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	bool? BCPICABAFAC
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	int? IHDNAOLCOPA
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	int KDHCMKHNJLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	string IJBGLNDCHDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	string OFGEAFHJGNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	string EANMOMMJENL
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	string PPCFHGADPNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	string IADEEIKIMON
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	string ECHNMPCOHFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	double BJFLENMOKFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface INCEMEGCJNO
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	long FDHNOHNJHPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "1")]
	long NCINJEKBMBA();

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EEILFADONLE(long BHDKFACMMAA, bool PBNNHJPLDKE = true);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PDOKJBEBOCJ(string JDFBABENAGD, string GGBMPGMKPFG, string GHNPDFEPNAI);

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NIACODKHFNF(string JDFBABENAGD);

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CCKHDDLEGNL(string JDFBABENAGD, string ALNDJHKLMEF, string BBHJFMAPGDP);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JLDFDABIACC(string EJOOMEOOAEJ, object NAAFPOPHEKP, object EIJLKBDMHAO);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface ECLODBLIPMB
{
	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KLKOJMHJBHO JMDCOLIOEGK(string HHOFKEFKDJH);
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

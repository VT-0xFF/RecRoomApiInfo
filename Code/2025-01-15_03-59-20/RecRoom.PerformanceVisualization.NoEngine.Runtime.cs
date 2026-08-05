using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.FastMesh.Core;
using RecRoom.FastMesh.Rendering;
using RecRoom.FastText;
using RecRoom.FastText.Layout;
using RecRoom.Logging.Attributes;
using RecRoom.Metrics.Pipeline;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_PerformanceVisualization_NoEngine_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Preserve]
	public class LogRegistrationIndex : IMPGLFODBJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x72C5E00", Offset = "0x72C5200", VA = "0x1872C5E00", Slot = "4")]
		public override void EMOBGIHOLPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8F0CF0", Offset = "0x8F00F0", VA = "0x1808F0CF0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.Utils.Debugging
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class MetricHudDisplay : MonoBehaviour, IRawMetricsSubscriber, IMetricsSubscriber<RawMetric>
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[Flags]
		private enum GNGHFBJAMOI
		{
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			RenderDependenciesInit = 1,
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			MetricDependenciesInit = 2,
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			AllDependenciesInit = 3,
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			LayoutStatesInit = 8,
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			MetricStatesInit = 4,
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			AllStatesInit = 0xC,
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			AllInit = 0xF
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly GKOKEEMOOFG OLCFMNDHOOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public MeshBufferRenderer MeshBufferRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public RectTransform RenderAreaRectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public Material Mat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public GlyphMapAsset GlyphMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[Min(4f)]
		public int FontSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private int OFNDIMBDOKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private GNGHFBJAMOI HDKLOMDOHCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private MetricIdLookup GAAMPOBOIIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private IRawMetricsPipeline EJODCPJOBHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private IMetricCollectionRegistry CFGEMLANOJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private MetricCollectionToken HGOOPHCMFDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private AJAMNDKPMCF IKHCPKIFHEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private OKFEGJJDBED AMIKKCBMKHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private FDGAIFMMNPP AFLNAFHPNPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private Material GDANEJONIOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private int DJBDBBHIBFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private LayoutRect HKLIKFCCKIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private int CFAICCGBIOK;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private const int NPEHEPDPPKB = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private List<MetricId> HCMPLOFJKGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private List<POFPKDJAAGE> KOPCLLGOGHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private List<CGOAILIHHGA> OBGKJLEDKGP;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static List<(string source, string metric)> AEAMMIDBGHD;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x72C7530", Offset = "0x72C6930", VA = "0x1872C7530")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x72C7630", Offset = "0x72C6A30", VA = "0x1872C7630")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x72C75A0", Offset = "0x72C69A0", VA = "0x1872C75A0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x72C5FE0", Offset = "0x72C53E0", VA = "0x1872C5FE0")]
		private void EPNHFAPFKJP(bool DOBDCENNGGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x72C6500", Offset = "0x72C5900", VA = "0x1872C6500")]
		private void IKOCEOIJHID(bool DOBDCENNGGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x72C7AF0", Offset = "0x72C6EF0", VA = "0x1872C7AF0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x72C6DF0", Offset = "0x72C61F0", VA = "0x1872C6DF0")]
		public void InitMetricsDependencies(MetricIdLookup GAAMPOBOIIG, IRawMetricsPipeline EJODCPJOBHM, IMetricCollectionRegistry CFGEMLANOJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x72C7660", Offset = "0x72C6A60", VA = "0x1872C7660")]
		private void PCNNFJDDNCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x72C69F0", Offset = "0x72C5DF0", VA = "0x1872C69F0")]
		private void IPJFJDNEGDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x72C6860", Offset = "0x72C5C60", VA = "0x1872C6860")]
		private void IOPCCMIMBOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x72C5EA0", Offset = "0x72C52A0", VA = "0x1872C5EA0")]
		private bool ELOKEKPAHGM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x72C7210", Offset = "0x72C6610", VA = "0x1872C7210")]
		private bool MJDEDMGLFGI(bool GDCOCNFLNHL = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x72C7090", Offset = "0x72C6490", VA = "0x1872C7090")]
		private bool LMIADCBPKJD(ILMNFFLLLCP MAPPNBHJLPD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x72C7420", Offset = "0x72C6820", VA = "0x1872C7420")]
		private bool MMLLFOBDEEL(ILMNFFLLLCP MAPPNBHJLPD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x72C62A0", Offset = "0x72C56A0", VA = "0x1872C62A0")]
		public void HandleMetric([In] RawMetric KCFAOOLDDME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x72C61B0", Offset = "0x72C55B0", VA = "0x1872C61B0")]
		private bool GIBNMLJGCIK(MetricId KIDNIINLINI, [Out] int PNJCGHMIGMH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x72C7080", Offset = "0x72C6480", VA = "0x1872C7080")]
		private bool LGJNKMACHJI(GNGHFBJAMOI CFDMPLAAOGL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x72C7060", Offset = "0x72C6460", VA = "0x1872C7060")]
		private bool KFJOANJECAO(GNGHFBJAMOI PHEJEBFOPBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x72C8690", Offset = "0x72C7A90", VA = "0x1872C8690")]
		public MetricHudDisplay()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x72C5E90", Offset = "0x72C5290", VA = "0x1872C5E90", Slot = "4")]
		private void BHPEDOBALEJ([In] RawMetric KCFAOOLDDME)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class CGOAILIHHGA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly OKFEGJJDBED CJKNIAACBBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly FDGAIFMMNPP EKLJAOFPFGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private int APHEEHHOFFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private LayoutRect OKGMGFLFOPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private TextSegmentLayout MIMPHIEMFEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private TextSegmentLayout JMICCHDPCCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private TextSegmentLayout DOMLNMLHPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private BLMKDMJAJON IKDDAOMPDJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private bool FPBFPIKINAJ;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8D5E30", Offset = "0x8D5230", VA = "0x1808D5E30")]
	public CGOAILIHHGA(OKFEGJJDBED JNBFGIKPPDE, FDGAIFMMNPP ABBKEADECKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x72C53A0", Offset = "0x72C47A0", VA = "0x1872C53A0")]
	public void LKOIGPCFEMK(LayoutRect MOGMCFCHLLL, int LIMDHOHKMPC, float CKKLDLEONBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x72C50B0", Offset = "0x72C44B0", VA = "0x1872C50B0")]
	public void ENCJBDEJFOH(float CKKLDLEONBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x72C51D0", Offset = "0x72C45D0", VA = "0x1872C51D0")]
	public void JCJFBNANFGF(char[] HOMFAMKBDEL, char[] ACLDLGIENKO, char[] EMEJDLDGKFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x72C4C80", Offset = "0x72C4080", VA = "0x1872C4C80")]
	public void BOOKGPDMPBN(float EFGKFEFADNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x72C5C20", Offset = "0x72C5020", VA = "0x1872C5C20")]
	public void MHMKHNAHMEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x72C5380", Offset = "0x72C4780", VA = "0x1872C5380")]
	public void JPBBDJCMIBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x72C4F60", Offset = "0x72C4360", VA = "0x1872C4F60")]
	public void CLBLNEJDEJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[Flags]
public enum DKKLGGLDPIN
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	Clean = 0,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	MetricDirty = 1,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	PrefixDirty = 2,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	ValueDirty = 4,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	SuffixDirty = 8,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	AllDirty = 0xF
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class POFPKDJAAGE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public BFPIHIEJBPE JMEFNANLJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public string FJEDFICIPCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public DKKLGGLDPIN NMLNBICBLGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public char[] DKJPBDAHHAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public char[] KFIOJPHPMCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public char[] AFKDCPFHLIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private RawMetricPayload PBJNGGAILNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private EWMA ABKCHOADJAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private double NFKDHPCCHBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int LANAHHFKPBG;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x72C8DD0", Offset = "0x72C81D0", VA = "0x1872C8DD0")]
	public POFPKDJAAGE(BFPIHIEJBPE EKNIDNIDCDP, string MMNDGHPNBHC, [Optional] string MGFMGPBIMNL, bool CDJGBJLNJGH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x72C8C80", Offset = "0x72C8080", VA = "0x1872C8C80")]
	public void GMCIOIIHJOB(RawMetricPayload KLPOAGFIBLM, bool OAAPPOCCNMP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x72C87D0", Offset = "0x72C7BD0", VA = "0x1872C87D0")]
	public bool CCJCIKOINKP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x72C8D80", Offset = "0x72C8180", VA = "0x1872C8D80")]
	private static int HBPNBKEILEP(BFPIHIEJBPE NKFDGDDBIKK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x72C8C00", Offset = "0x72C8000", VA = "0x1872C8C00")]
	private static bool FJINNJKPKIC(char[] FGFJFGGJOII, char[] CABLGFIBABJ)
	{
		return default(bool);
	}
}
namespace RecRoom.Utils.Debugging
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class TestMetricProvider : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public class DemoValueSource : ISerializationCallbackReceiver
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			[SerializeField]
			[HideInInspector]
			public bool isInit;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public string prefix;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public float value;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public string suffix;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			private string _lastPrefix;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			private float _lastValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			private string _lastSuffix;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x72C5C70", Offset = "0x72C5070", VA = "0x1872C5C70")]
			public bool COLALAFJAAK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x3702620", Offset = "0x3701A20", VA = "0x183702620")]
			private static bool DNIPNBKMOPE<T>(T MGPMAFDHMLC, T HCPAOILCJCB)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x72C5D90", Offset = "0x72C5190", VA = "0x1872C5D90", Slot = "4")]
			void ISerializationCallbackReceiver.OnBeforeSerialize()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x72C5D10", Offset = "0x72C5110", VA = "0x1872C5D10", Slot = "5")]
			public void OnAfterDeserialize()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public DemoValueSource()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public List<DemoValueSource> demoValueSources;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x72C8F60", Offset = "0x72C8360", VA = "0x1872C8F60")]
		public TestMetricProvider()
		{
		}
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

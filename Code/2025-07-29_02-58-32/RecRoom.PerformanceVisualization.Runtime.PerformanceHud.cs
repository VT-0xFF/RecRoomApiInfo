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
using RecRoom.Metrics.Pipeline.MetricInfo;
using RecRoom.NoEngine.DataStructures;
using RecRoom.Profiling;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_PerformanceVisualization_Runtime_PerformanceHud
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Preserve]
	public class LogRegistrationIndex : CCHAKOMCHCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x86C9E90", Offset = "0x86C8890", VA = "0x1886C9E90", Slot = "4")]
		public override void MAJNBNPDEEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.Profiling.Visualization
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class MetricHudDisplay : MonoBehaviour, IRawMetricsSubscriber, IMetricsSubscriber<RawMetric>
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[Flags]
		private enum MIOGBKGMIAF
		{
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			RenderDependenciesInit = 1,
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			MetricDependenciesInit = 2,
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			AllDependenciesInit = 3,
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			OverlayInit = 4,
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			MetricStatesInit = 8,
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			LayoutStatesInit = 0x10,
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			AllStatesInit = 0x1C,
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			AllInit = 0x1F
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly MEBJEIOEDLD HJHMNJLNNBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private MeshBufferRenderer meshBufferRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[SerializeField]
		private RectTransform renderAreaRectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[SerializeField]
		private Material glyphMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[SerializeField]
		private GlyphMapAsset glyphMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[SerializeField]
		private int fontSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		private int maxLines;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		private float lineHeightFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[SerializeField]
		private Material graphMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[SerializeField]
		private MetricGraphGraphic[] metricGraphs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private MIOGBKGMIAF FLHCKPNLGPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private MetricIdLookup HHIJJDOJJJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private IRawMetricsPipeline AJOJKDGCJOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private IMetricCollectionRegistry NBJBADJMNIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private MetricCollectionToken EJGBICKFIJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private CEMBEIHOKNJ MFEIAGCMOID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private NLJCIDJLCOL MEMODOBHLIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private Material BDJNJDLPCHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private int LLBEMMBOAFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private LayoutRect BACDHDEDGOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int KHOPAPEEGNH;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private const int IDOAAGPOGLH = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private BDLOKINEGIJ KMCDMNKDMAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private bool JKIFCIMNCKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private Dictionary<MetricId, int> EFMGPCODIJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private List<BNPKLIICPBO> MODGJLAMEFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private FJDGPLFHGCK EOGIIOGGAOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private List<FJDGPLFHGCK> EMDBOBPBFJP;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public MeshBufferRenderer ONIHIFJBKJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x86CBEF0", Offset = "0x86CA8F0", VA = "0x1886CBEF0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x86CC100", Offset = "0x86CAB00", VA = "0x1886CC100")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x86CC0A0", Offset = "0x86CAAA0", VA = "0x1886CC0A0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x86CC130", Offset = "0x86CAB30", VA = "0x1886CC130")]
		private void PBMLBBKMDIM(bool IKNDNACEPNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x86CAB60", Offset = "0x86C9560", VA = "0x1886CAB60")]
		private void GKKCCHIJKKM(bool IKNDNACEPNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x86CC2A0", Offset = "0x86CACA0", VA = "0x1886CC2A0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x86CBBE0", Offset = "0x86CA5E0", VA = "0x1886CBBE0")]
		public void InitMetricsDependencies(MetricIdLookup HHIJJDOJJJE, IRawMetricsPipeline AJOJKDGCJOK, IMetricCollectionRegistry NBJBADJMNIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x86CC220", Offset = "0x86CAC20", VA = "0x1886CC220")]
		public void SetActiveOverlay(BDLOKINEGIJ NEFIBIILGCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x86CB750", Offset = "0x86CA150", VA = "0x1886CB750")]
		private void IHBOOGGDEDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x86CBD90", Offset = "0x86CA790", VA = "0x1886CBD90")]
		private void ODMNHJJMFLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x86CA310", Offset = "0x86C8D10", VA = "0x1886CA310")]
		private void BJAMJAGEFNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x86CAED0", Offset = "0x86C98D0", VA = "0x1886CAED0")]
		private void HNIJBAOMKLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x86CA060", Offset = "0x86C8A60", VA = "0x1886CA060")]
		private bool AIEHAKLMEHD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x86CA720", Offset = "0x86C9120", VA = "0x1886CA720")]
		private bool EFEIGANJNOO(bool FGLPKBNAEFO = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x86CA960", Offset = "0x86C9360", VA = "0x1886CA960")]
		private bool EFFMCPCGHMD(NFFKDHKKOCO PEIDNFHKHFH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x86C9F20", Offset = "0x86C8920", VA = "0x1886C9F20")]
		private bool AGIECGLIJDF(NFFKDHKKOCO PEIDNFHKHFH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x86CB520", Offset = "0x86C9F20", VA = "0x1886CB520")]
		public void HandleMetric([In] RawMetric FENLICMJGNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x86CBD80", Offset = "0x86CA780", VA = "0x1886CBD80")]
		private bool MPPJOMCJHIK(MIOGBKGMIAF FAIHEAAPKPP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x86CAB40", Offset = "0x86C9540", VA = "0x1886CAB40")]
		private bool FMHNEENOKMK(MIOGBKGMIAF HCCLODKBABJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x86CC560", Offset = "0x86CAF60", VA = "0x1886CC560")]
		public MetricHudDisplay()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x86CBD70", Offset = "0x86CA770", VA = "0x1886CBD70", Slot = "4")]
		private void KLEHHEDCDLF([In] RawMetric FENLICMJGNG)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal class FJDGPLFHGCK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private bool EALBIPFMOOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private LayoutRect HLBNLMPJADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private TextSegmentLayout MNDAPKGNLGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private TextSegmentLayout PHFLILMINMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private TextSegmentLayout MGOHCOAEJIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private EBPDHCNOMJO LKOCIHEHLNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private MetricGraphGraphic NDMHMMPMNBF;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x86C8E20", Offset = "0x86C7820", VA = "0x1886C8E20")]
	public void CEKLAJMLNPO(CEMBEIHOKNJ NGICOEMHGEM, NLJCIDJLCOL FHMGNDDJGPK, LayoutRect JMALDKJIGEJ, int OIJBIJODHNC, [Optional] MetricGraphGraphic NDMHMMPMNBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x86C9450", Offset = "0x86C7E50", VA = "0x1886C9450")]
	public void FAJPEHJHKMD(float DHHNJBHCADF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x86C92E0", Offset = "0x86C7CE0", VA = "0x1886C92E0")]
	public void DPLBCPJHBJB(ReadOnlySpan<char> BHAGLLHGKJP, ReadOnlySpan<char> PEKODMCCJOK, ReadOnlySpan<char> OPIDLDNNAEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x86C99F0", Offset = "0x86C83F0", VA = "0x1886C99F0")]
	public void IDPJIMOAIDD(RRColor32 EDNHAEBPHJD, bool ABBNAIINOIG = true, bool DAOHIAANJHM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x86C95F0", Offset = "0x86C7FF0", VA = "0x1886C95F0")]
	public float IBPFGFAHNLF(float LOGIIPPEJGA, float HOFMOPBLMPH, float APPOMODJEKF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x86C9DB0", Offset = "0x86C87B0", VA = "0x1886C9DB0")]
	public void JLOBNJPIACA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x86C95C0", Offset = "0x86C7FC0", VA = "0x1886C95C0")]
	public void FLBEIIGMOLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x86C8E00", Offset = "0x86C7800", VA = "0x1886C8E00")]
	public void BGELCHKFMKP(OOCHJHNBEGP IMIKAEIBJNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x86C9D00", Offset = "0x86C8700", VA = "0x1886C9D00")]
	public void JDEPPEHHLME(OOCHJHNBEGP IMIKAEIBJNG, double DILGPPEHCGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x86C9E00", Offset = "0x86C8800", VA = "0x1886C9E00")]
	public void LALNGCFBPIO(double PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x86C9B40", Offset = "0x86C8540", VA = "0x1886C9B40")]
	public void IMMJLLEIOEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public FJDGPLFHGCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class PJKLDPFGGDK
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static BDLOKINEGIJ FEEAOANKFLC;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static BDLOKINEGIJ DEKPKBIMNBF;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static BDLOKINEGIJ LCNFKIJJMPL;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static BDLOKINEGIJ JNNMJLEDKOD;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static BDLOKINEGIJ AABGEGDFCJP;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static BDLOKINEGIJ FCGGOPBBADI;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static BDLOKINEGIJ MDAKIDAOHEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x86CC870", Offset = "0x86CB270", VA = "0x1886CC870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static BDLOKINEGIJ JEAADDAHOJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x86CC7D0", Offset = "0x86CB1D0", VA = "0x1886CC7D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static BDLOKINEGIJ ECGEDFPIBPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x86CC8C0", Offset = "0x86CB2C0", VA = "0x1886CC8C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static BDLOKINEGIJ BCCDFADKJAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x86CC780", Offset = "0x86CB180", VA = "0x1886CC780")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static BDLOKINEGIJ DANMBBCABJO
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x86CC820", Offset = "0x86CB220", VA = "0x1886CC820")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static BDLOKINEGIJ JFHPJKPOOKG
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x86CC730", Offset = "0x86CB130", VA = "0x1886CC730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public static BDLOKINEGIJ GBNPOIENDIE
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA85A50", Offset = "0xA84450", VA = "0x180A85A50")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct GJFENLLDDDK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public string EAOIOBGHMFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public string NIAHBFMCGEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public string ENKEGMKFINP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public OOCHJHNBEGP GKFAFNGGAOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public bool DCJFCGKHGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public bool PGEHFPOFPLG;
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class BDLOKINEGIJ
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public string KPLKBICGAHN
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public GJFENLLDDDK[] NGMDKFOPEMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public virtual void DCBFNOMOFJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "5")]
	public virtual void JJAAKDGJNBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0xA93780", Offset = "0xA92180", VA = "0x180A93780")]
	public BDLOKINEGIJ(string KAGDIKHFOCM, GJFENLLDDDK[] NBKFDACCIFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[Flags]
internal enum CFDCLKEFIEG
{
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	Clean = 0,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	MetricUpdated = 1,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	MetricDirty = 2,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	TextDirty = 4,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	AllDirty = 6
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal class BNPKLIICPBO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private CFDCLKEFIEG LLKBCLIIGJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private MetricDescription CJBAHKIFDND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private RawMetricPayload EEMEEFCIEHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private EwmaFilter OMNGIMCKFCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private double MJPCLBEFIMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private int GOOCEHECJKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private OOCHJHNBEGP IMIKAEIBJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private OHLBIHHFJIP FHNIDIJJANC;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int DFIKOBBMLFD = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private char[] BHAGLLHGKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private char[] PEKODMCCJOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private int DLEDJODHMPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private char[] OPIDLDNNAEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private int NEAOFEKIENC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private string BBOAEFFOANG;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public MetricDescription DJIJCPBNHJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xE7AD80", Offset = "0xE79780", VA = "0x180E7AD80")]
		get
		{
			return default(MetricDescription);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x86C8710", Offset = "0x86C7110", VA = "0x1886C8710")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public CFDCLKEFIEG ILFLGDJIAGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xA8E5C0", Offset = "0xA8CFC0", VA = "0x180A8E5C0")]
		get
		{
			return default(CFDCLKEFIEG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public ReadOnlySpan<char> AGPFGIKPLOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x86C8BE0", Offset = "0x86C75E0", VA = "0x1886C8BE0")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public ReadOnlySpan<char> AKJINAEAEGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x86C8870", Offset = "0x86C7270", VA = "0x1886C8870")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public ReadOnlySpan<char> GLIKMCNHACF
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x86C8790", Offset = "0x86C7190", VA = "0x1886C8790")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public OHLBIHHFJIP DKBMOJPBHEA
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xD091E0", Offset = "0xD07BE0", VA = "0x180D091E0")]
		get
		{
			return default(OHLBIHHFJIP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public double BIDOCGHHBPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x86C81F0", Offset = "0x86C6BF0", VA = "0x1886C81F0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public float MFHBLBMJLGK
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x86C8BD0", Offset = "0x86C75D0", VA = "0x1886C8BD0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float NELKKJCPEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xD5C580", Offset = "0xD5AF80", VA = "0x180D5C580")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xDCD170", Offset = "0xDCBB70", VA = "0x180DCD170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool EHEEGHKGIGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1294150", Offset = "0x1292B50", VA = "0x181294150")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x15C7310", Offset = "0x15C5D10", VA = "0x1815C7310")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public OOCHJHNBEGP GKFAFNGGAOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA84200", Offset = "0xA82C00", VA = "0x180A84200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x86C8C40", Offset = "0x86C7640", VA = "0x1886C8C40")]
	public BNPKLIICPBO(string HJIKHCCLFIK, [Optional] MetricDescription CJBAHKIFDND, [Optional] OOCHJHNBEGP IMIKAEIBJNG, bool JILNNFDHDKE = true, bool DCJIHIIADJN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x86C8100", Offset = "0x86C6B00", VA = "0x1886C8100")]
	public void AFCJLGIJCDH(RawMetricPayload PPFKHHPHONM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x86C8950", Offset = "0x86C7350", VA = "0x1886C8950")]
	public bool LENHHPNIOPO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x86C8270", Offset = "0x86C6C70", VA = "0x1886C8270")]
	public bool CBEBNNAELJH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x70BE1B0", Offset = "0x70BCBB0", VA = "0x1870BE1B0")]
	public void NKBINLIEIKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x70BE1A0", Offset = "0x70BCBA0", VA = "0x1870BE1A0")]
	public void GKIHHOLEEOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x86C8220", Offset = "0x86C6C20", VA = "0x1886C8220")]
	private static int CAOFGKBKKNL(MetricDataUnits BCPBNAPNMIB)
	{
		return default(int);
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

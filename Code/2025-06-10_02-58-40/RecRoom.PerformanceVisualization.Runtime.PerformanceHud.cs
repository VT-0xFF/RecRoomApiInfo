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
	public class LogRegistrationIndex : LALFEIIPPKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7FF8D80", Offset = "0x7FF7F80", VA = "0x187FF8D80", Slot = "4")]
		public override void ELDCOJNOKAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA2B980", Offset = "0xA2AB80", VA = "0x180A2B980")]
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
		private enum OJEHMJDODEA
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
		private static readonly KEPOMIIOHBM EBHKLAMEJCE;

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
		private OJEHMJDODEA MAMIMJLJFBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private MetricIdLookup CKIEOIPDBNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private IRawMetricsPipeline DCALIIALPEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private IMetricCollectionRegistry NHKJOCPFIEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private MetricCollectionToken HEHNPFELEPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private DHOFCFFMODF HALJKDHBAPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private BMEOOAEOHKE FDHPEBIBCCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private Material MENMNEIEIOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private int KJPJPCJBIGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private LayoutRect JMDHAKHEFJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int NIBEHMBHLHM;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private const int MCFACFIPNAI = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private DGHMFNEDDHE BKGMIGEPGGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private bool KGGNNOEAGFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private Dictionary<MetricId, int> JIDMIOMFLMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private List<PJGGJEAEMGK> NOJCNAKAKDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private GKALKLNDHEG KIGIPLMDCOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private List<GKALKLNDHEG> EFPFPNPODFM;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public MeshBufferRenderer PJCLEMDDFGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7FFAF20", Offset = "0x7FFA120", VA = "0x187FFAF20")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7FFB130", Offset = "0x7FFA330", VA = "0x187FFB130")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7FFB0D0", Offset = "0x7FFA2D0", VA = "0x187FFB0D0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7FFA810", Offset = "0x7FF9A10", VA = "0x187FFA810")]
		private void IMNNMDMBDPJ(bool JBPEFFIDDPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7FF8E10", Offset = "0x7FF8010", VA = "0x187FF8E10")]
		private void ABIDGFJCKPC(bool JBPEFFIDDPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7FFB1E0", Offset = "0x7FFA3E0", VA = "0x187FFB1E0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7FFA900", Offset = "0x7FF9B00", VA = "0x187FFA900")]
		public void InitMetricsDependencies(MetricIdLookup CKIEOIPDBNH, IRawMetricsPipeline DCALIIALPEA, IMetricCollectionRegistry NHKJOCPFIEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7FFB160", Offset = "0x7FFA360", VA = "0x187FFB160")]
		public void SetActiveOverlay(DGHMFNEDDHE MLMFCLPKEPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7FFAAA0", Offset = "0x7FF9CA0", VA = "0x187FFAAA0")]
		private void ONIFOLJHOGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7FF9F10", Offset = "0x7FF9110", VA = "0x187FF9F10")]
		private void ELCBGIBGLKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7FFA1B0", Offset = "0x7FF93B0", VA = "0x187FFA1B0")]
		private void EPFOCDBDAEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7FF9860", Offset = "0x7FF8A60", VA = "0x187FF9860")]
		private void DCFGCEMIBCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7FF9370", Offset = "0x7FF8570", VA = "0x187FF9370")]
		private bool BNADNDAPIJD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7FF9620", Offset = "0x7FF8820", VA = "0x187FF9620")]
		private bool DCDDBPKGKBA(bool IKLDNLEDLAC = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7FF9190", Offset = "0x7FF8390", VA = "0x187FF9190")]
		private bool BMLCLNANAOI(GKENILLPBOI MLMPPNLIAEF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7FFA070", Offset = "0x7FF9270", VA = "0x187FFA070")]
		private bool ENOJGPGAGIC(GKENILLPBOI MLMPPNLIAEF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7FFA5D0", Offset = "0x7FF97D0", VA = "0x187FFA5D0")]
		public void HandleMetric([In] RawMetric GKLLJMPNDJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7FFA5C0", Offset = "0x7FF97C0", VA = "0x187FFA5C0")]
		private bool FJJKHNMMAPE(OJEHMJDODEA CDKLGFKPHPE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7FFAA80", Offset = "0x7FF9C80", VA = "0x187FFAA80")]
		private bool KDMMPGFAEGI(OJEHMJDODEA JABOFCCDDFO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7FFB4A0", Offset = "0x7FFA6A0", VA = "0x187FFB4A0")]
		public MetricHudDisplay()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7FFA800", Offset = "0x7FF9A00", VA = "0x187FFA800", Slot = "4")]
		private void IAPGDHNBDNK([In] RawMetric GKLLJMPNDJB)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal class GKALKLNDHEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private bool OHHOBNIGDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private LayoutRect IMOMLGADHPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private TextSegmentLayout OFFEJLPBEKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private TextSegmentLayout GHHFFJHDECM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private TextSegmentLayout CNMHBNJPBMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private PLCBMEGBKGM CAMNJDFFDHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private MetricGraphGraphic PJMLCNJGBJH;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7FF8290", Offset = "0x7FF7490", VA = "0x187FF8290")]
	public void IJDFNMPLFGP(DHOFCFFMODF MJALHKKLPNJ, BMEOOAEOHKE OIIJGFEEHCO, LayoutRect CGMKKGFNOAP, int OANMIKIDOLA, [Optional] MetricGraphGraphic PJMLCNJGBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7FF7E50", Offset = "0x7FF7050", VA = "0x187FF7E50")]
	public void DODEDGEDFGM(float CMBFDGJHMJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7FF7C90", Offset = "0x7FF6E90", VA = "0x187FF7C90")]
	public void BMJKPBJPFLL(ReadOnlySpan<char> JKOJJODEPHI, ReadOnlySpan<char> DMBIJGFMEFL, ReadOnlySpan<char> IJCHHBBLKOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7FF8C30", Offset = "0x7FF7E30", VA = "0x187FF8C30")]
	public void PPFLFCGPGCI(RRColor32 NEMIFEKMDAI, bool CFKGLDFEACN = true, bool EMHIACKNCFG = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7FF8750", Offset = "0x7FF7950", VA = "0x187FF8750")]
	public float IOBAJIAPKIP(float EGKKPKHCOOJ, float JAHJEODLCCJ, float IDEKBOKKOIN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7FF7E00", Offset = "0x7FF7000", VA = "0x187FF7E00")]
	public void CNKAABCPCAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7FF8C00", Offset = "0x7FF7E00", VA = "0x187FF8C00")]
	public void KNDIELALGND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7FF7FC0", Offset = "0x7FF71C0", VA = "0x187FF7FC0")]
	public void EOGPINGPOPE(LOBCHMFMFLL LHGDGMBFHOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7FF8B50", Offset = "0x7FF7D50", VA = "0x187FF8B50")]
	public void JPKPNMJDGHF(LOBCHMFMFLL LHGDGMBFHOA, double GPOEDAABNAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7FF8200", Offset = "0x7FF7400", VA = "0x187FF8200")]
	public void GIIFGBGHHMF(double KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7FF7FE0", Offset = "0x7FF71E0", VA = "0x187FF7FE0")]
	public void FKEDJLMBNMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public GKALKLNDHEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class FDNEABGBEHO
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static DGHMFNEDDHE CKOAIDCFPFI;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static DGHMFNEDDHE MOLAGOMCBDL;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static DGHMFNEDDHE ADEPOIDEHAD;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static DGHMFNEDDHE HKHKOGEBMLD;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static DGHMFNEDDHE BEMBBNLJOKM;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static DGHMFNEDDHE JAAGANBPOIM;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static DGHMFNEDDHE LGHIFDBIJOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7FF5F20", Offset = "0x7FF5120", VA = "0x187FF5F20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static DGHMFNEDDHE OBJNMPNBDKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7FF5E80", Offset = "0x7FF5080", VA = "0x187FF5E80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static DGHMFNEDDHE ONKDOGOMEEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7FF5E30", Offset = "0x7FF5030", VA = "0x187FF5E30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static DGHMFNEDDHE CCEEPDEKDOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7FF5F70", Offset = "0x7FF5170", VA = "0x187FF5F70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static DGHMFNEDDHE HBOPJPALEJA
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7FF5ED0", Offset = "0x7FF50D0", VA = "0x187FF5ED0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static DGHMFNEDDHE NBEMBCBICHP
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7FF5DE0", Offset = "0x7FF4FE0", VA = "0x187FF5DE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public static DGHMFNEDDHE BNJNECKNOEP
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA02C70", Offset = "0xA01E70", VA = "0x180A02C70")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct IFJAHOKEOFB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public string FJPIHJNIGAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public string FMLGJKJEFLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public string LHMAPHKAPEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public LOBCHMFMFLL DDCPKMGGJNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public bool EPHPLPPDHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public bool NIOHECOMLBN;
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class DGHMFNEDDHE
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public string IHFNCCCFAAK
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA011A0", Offset = "0xA003A0", VA = "0x180A011A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA00FA0", Offset = "0xA001A0", VA = "0x180A00FA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IFJAHOKEOFB[] FEHEDDIDFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA00F60", Offset = "0xA00160", VA = "0x180A00F60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "4")]
	public virtual void DLMOBCJGMGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "5")]
	public virtual void IEGEMBGDFON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0xA058E0", Offset = "0xA04AE0", VA = "0x180A058E0")]
	public DGHMFNEDDHE(string PHCDDDIIGAJ, IFJAHOKEOFB[] AALECOLIKGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[Flags]
internal enum JLHGMKJJKNN
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
internal class PJGGJEAEMGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private JLHGMKJJKNN DLCOKNDLPNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private MetricDescription JDOCEIBICLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private RawMetricPayload EKFBEBELGHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private EwmaFilter HKALEBINDBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private double CAMIOGMBCGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private int LMDFMPNENKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private LOBCHMFMFLL LHGDGMBFHOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private NMKOMPFJOFO EEMEMAJDPCK;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int JFDBNFGLBPA = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private char[] JKOJJODEPHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private char[] DMBIJGFMEFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private int NDCDJPDLIMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private char[] IJCHHBBLKOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private int OCMJKHPEIEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private string IDHIFIPJGGG;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public MetricDescription DFDOPIHLKPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xD93950", Offset = "0xD92B50", VA = "0x180D93950")]
		get
		{
			return default(MetricDescription);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7FFC0F0", Offset = "0x7FFB2F0", VA = "0x187FFC0F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public JLHGMKJJKNN FBHJJHNEAGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xA09790", Offset = "0xA08990", VA = "0x180A09790")]
		get
		{
			return default(JLHGMKJJKNN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public ReadOnlySpan<char> MPNOOAIOBIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7FFB940", Offset = "0x7FFAB40", VA = "0x187FFB940")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public ReadOnlySpan<char> PEOACAPNKIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7FFB9A0", Offset = "0x7FFABA0", VA = "0x187FFB9A0")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public ReadOnlySpan<char> IMPFKLCABAC
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7FFC010", Offset = "0x7FFB210", VA = "0x187FFC010")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public NMKOMPFJOFO BKGPLDFDFIF
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xC33320", Offset = "0xC32520", VA = "0x180C33320")]
		get
		{
			return default(NMKOMPFJOFO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public double FGIGBOKOILA
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7FFB680", Offset = "0x7FFA880", VA = "0x187FFB680")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public float JILLBDMDBON
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7FFB670", Offset = "0x7FFA870", VA = "0x187FFB670")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float BEMMOGPADIG
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xC79E20", Offset = "0xC79020", VA = "0x180C79E20")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xCB9A30", Offset = "0xCB8C30", VA = "0x180CB9A30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool MLGFHICGIJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x11891F0", Offset = "0x11883F0", VA = "0x1811891F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x143B610", Offset = "0x143A810", VA = "0x18143B610")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public LOBCHMFMFLL DDCPKMGGJNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA00350", Offset = "0x9FF550", VA = "0x180A00350")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7FFC1C0", Offset = "0x7FFB3C0", VA = "0x187FFC1C0")]
	public PJGGJEAEMGK(string BDODAAJJOKK, [Optional] MetricDescription JDOCEIBICLD, [Optional] LOBCHMFMFLL LHGDGMBFHOA, bool FNOAGOGDEEE = true, bool ELNMDOGOCFK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7FFBA80", Offset = "0x7FFAC80", VA = "0x187FFBA80")]
	public void JBJBNGDKMCI(RawMetricPayload JJNCAKEKKLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7FFB6B0", Offset = "0x7FFA8B0", VA = "0x187FFB6B0")]
	public bool FHMMJJAAAJA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7FFBB70", Offset = "0x7FFAD70", VA = "0x187FFBB70")]
	public bool JNGLLDKPEEI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6A75260", Offset = "0x6A74460", VA = "0x186A75260")]
	public void ELLPFIHEPLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6A75250", Offset = "0x6A74450", VA = "0x186A75250")]
	public void FGCIJJBDCEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7FFC170", Offset = "0x7FFB370", VA = "0x187FFC170")]
	private static int PKFMOHAEPAH(MetricDataUnits CFNPJKKEACA)
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

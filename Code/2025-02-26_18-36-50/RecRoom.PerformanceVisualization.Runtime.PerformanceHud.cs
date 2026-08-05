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
	public class LogRegistrationIndex : EIAOKFHFGKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x77A9D00", Offset = "0x77A9100", VA = "0x1877A9D00", Slot = "4")]
		public override void OCICFIBHEPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9748B0", Offset = "0x973CB0", VA = "0x1809748B0")]
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
		private enum KGFAHJCPPNH
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
		private static readonly IBCMILIKEJG DDKJAEALMGF;

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
		private KGFAHJCPPNH JGMKPBHIMFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private MetricIdLookup EICICLPKNCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private IRawMetricsPipeline MCMMHDFDEMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private IMetricCollectionRegistry NDOEBAFKDJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private MetricCollectionToken HJHLOIHMHME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private JHFOGMCBEON FAJMKCGMCHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private APHPHOBEPGC OBDFJJLPIGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private Material LLBIKNIGOHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private int DAKJKFBCNMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private LayoutRect ILNKPOENJMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int ALNAMLAJJGM;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private const int JGNPOJPFDHO = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private DCKCDLJOBLI JGEBINNFEJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private bool BOOFGEENGFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private Dictionary<MetricId, int> CHMBONBAPIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private List<OMLJOPANOBN> BBKIIHJMMJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private GCFNFLCPPGF ONKIGIFPDHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private List<GCFNFLCPPGF> KHCAIDBHGPB;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public MeshBufferRenderer JOGGJAFIGHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x77ABE40", Offset = "0x77AB240", VA = "0x1877ABE40")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x77AC050", Offset = "0x77AB450", VA = "0x1877AC050")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x77ABFF0", Offset = "0x77AB3F0", VA = "0x1877ABFF0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x77AA100", Offset = "0x77A9500", VA = "0x1877AA100")]
		private void AKPONAKJGKK(bool NPPHCJJHKFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x77A9D90", Offset = "0x77A9190", VA = "0x1877A9D90")]
		private void ACFDBBDDPCH(bool NPPHCJJHKFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x77AC100", Offset = "0x77AB500", VA = "0x1877AC100")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x77AB7D0", Offset = "0x77AABD0", VA = "0x1877AB7D0")]
		public void InitMetricsDependencies(MetricIdLookup EICICLPKNCJ, IRawMetricsPipeline MCMMHDFDEMC, IMetricCollectionRegistry NDOEBAFKDJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x77AC080", Offset = "0x77AB480", VA = "0x1877AC080")]
		public void SetActiveOverlay(DCKCDLJOBLI DLFLCLOFHMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x77AA1F0", Offset = "0x77A95F0", VA = "0x1877AA1F0")]
		private void CCAOHKKEEHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x77AB960", Offset = "0x77AAD60", VA = "0x1877AB960")]
		private void JJENDCLNJEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x77AA680", Offset = "0x77A9A80", VA = "0x1877AA680")]
		private void DHALLDHPIIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x77AAF30", Offset = "0x77AA330", VA = "0x1877AAF30")]
		private void HAEIHMPFJGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x77AAC80", Offset = "0x77AA080", VA = "0x1877AAC80")]
		private bool FEDFADEIECL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x77ABC00", Offset = "0x77AB000", VA = "0x1877ABC00")]
		private bool NFFMEFJJHJF(bool MHOOEDPKADD = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x77AAAA0", Offset = "0x77A9EA0", VA = "0x1877AAAA0")]
		private bool ECGIPAIEKDB(GCCILAMBMEM MBDLAJMBAIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x77ABAC0", Offset = "0x77AAEC0", VA = "0x1877ABAC0")]
		private bool MJKLICMCJAE(GCCILAMBMEM MBDLAJMBAIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x77AB5A0", Offset = "0x77AA9A0", VA = "0x1877AB5A0")]
		public void HandleMetric([In] RawMetric EGBGOOLCFBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x22CE160", Offset = "0x22CD560", VA = "0x1822CE160")]
		private bool FMCALGIAMGP(KGFAHJCPPNH JICLKBHHOBO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x77AB580", Offset = "0x77AA980", VA = "0x1877AB580")]
		private bool HDODJDCAGNI(KGFAHJCPPNH FCLCGJPHKHL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x77AC3C0", Offset = "0x77AB7C0", VA = "0x1877AC3C0")]
		public MetricHudDisplay()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x77AAA90", Offset = "0x77A9E90", VA = "0x1877AAA90", Slot = "4")]
		private void DLAADKKGGPD([In] RawMetric EGBGOOLCFBO)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal class GCFNFLCPPGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private bool PDFMCABPMLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private LayoutRect HMGJBBBIFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private TextSegmentLayout KEJEFKONEDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private TextSegmentLayout JFMDINIIOCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private TextSegmentLayout FNHFCFOAGNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private ENOIDMDMFNO LHGCMDOKPPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private MetricGraphGraphic CBJNFNNFHBP;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x77A8E90", Offset = "0x77A8290", VA = "0x1877A8E90")]
	public void CIDIOEOELJF(JHFOGMCBEON GGCJCFPPNFO, APHPHOBEPGC DCNDOAAAGEO, LayoutRect JMOIMBBNPFB, int LFLHBJPHOAC, [Optional] MetricGraphGraphic CBJNFNNFHBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x77A9460", Offset = "0x77A8860", VA = "0x1877A9460")]
	public void HMKJKMPNPJI(float MOJOJKPNJPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x77A9790", Offset = "0x77A8B90", VA = "0x1877A9790")]
	public void MEDGAEDAALL(ReadOnlySpan<char> ALAALGAAPFE, ReadOnlySpan<char> PLAOLCPFMKN, ReadOnlySpan<char> AAACNIPBMNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x77A8C70", Offset = "0x77A8070", VA = "0x1877A8C70")]
	public void BENKJNIALGJ(RRColor32 NHCBHMJDLHA, bool LJJAOPEICGP = true, bool CMIAIHOBDKD = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x77A9900", Offset = "0x77A8D00", VA = "0x1877A9900")]
	public float PEEAFBOHFAB(float KBGNICDPLBJ, float BCOKCHGFEHE, float CDAPIHHJEKO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x77A9350", Offset = "0x77A8750", VA = "0x1877A9350")]
	public void CLKIPDKBLCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x77A93A0", Offset = "0x77A87A0", VA = "0x1877A93A0")]
	public void DKKFGJDGABH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x77A8DC0", Offset = "0x77A81C0", VA = "0x1877A8DC0")]
	public void BILPJGDBEFA(PKLDJMPIADF BEEDEPCIDNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x77A8DE0", Offset = "0x77A81E0", VA = "0x1877A8DE0")]
	public void BPGLGEOAMLK(PKLDJMPIADF BEEDEPCIDNA, double JJCKONKIIAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x77A93D0", Offset = "0x77A87D0", VA = "0x1877A93D0")]
	public void EGBFGFGFABB(double KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x77A95D0", Offset = "0x77A89D0", VA = "0x1877A95D0")]
	public void IHILNAOKAGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	public GCFNFLCPPGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class BAEBGLLFNOK
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static DCKCDLJOBLI DKJJGGIFLMK;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static DCKCDLJOBLI EAOKKLGBFCB;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static DCKCDLJOBLI LIEKJFJPDAN;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static DCKCDLJOBLI NGOAGMHFGNC;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static DCKCDLJOBLI HIPJNDNBACI;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static DCKCDLJOBLI ALHCCMNIIAO;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static DCKCDLJOBLI MPDPNCAPBBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x77A6DC0", Offset = "0x77A61C0", VA = "0x1877A6DC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static DCKCDLJOBLI DPIMFOFNHNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x77A6E10", Offset = "0x77A6210", VA = "0x1877A6E10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static DCKCDLJOBLI HLIHIFILCNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x77A6E60", Offset = "0x77A6260", VA = "0x1877A6E60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static DCKCDLJOBLI HOAEJHIFKGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x77A6D70", Offset = "0x77A6170", VA = "0x1877A6D70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static DCKCDLJOBLI MIJBEHNOEGK
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x77A6EB0", Offset = "0x77A62B0", VA = "0x1877A6EB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static DCKCDLJOBLI DIJBBMIFIOM
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x77A6F00", Offset = "0x77A6300", VA = "0x1877A6F00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public static DCKCDLJOBLI EJGBAHOKHAH
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x94AA70", Offset = "0x949E70", VA = "0x18094AA70")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct IENELGHKGMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public string HPBKHGFHJAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public string GGHGCJKJGJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public string DOEOPKOCCBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public PKLDJMPIADF FGKGPILFGCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public bool ECBFNLGFPNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public bool OBBLGJGAKNA;
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class DCKCDLJOBLI
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public string CNDFNOPKGFB
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x949410", Offset = "0x948810", VA = "0x180949410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x949400", Offset = "0x948800", VA = "0x180949400")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IENELGHKGMB[] OLNGBIEDHFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x94B9B0", Offset = "0x94ADB0", VA = "0x18094B9B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "4")]
	public virtual void JCEAMLFLPMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "5")]
	public virtual void FBLJKGIBFMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x957D80", Offset = "0x957180", VA = "0x180957D80")]
	public DCKCDLJOBLI(string HJLOFBIEILC, IENELGHKGMB[] FLNALAHAGDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[Flags]
internal enum PMADAPOGLGM
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
internal class OMLJOPANOBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private PMADAPOGLGM FINPAAGDFFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private MetricDescription AIHNBEMDDFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private RawMetricPayload GOAPBALNOKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private EwmaFilter OIHGODDBKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private double AOOFCCFCNAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private int NOALKPGEFAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private PKLDJMPIADF BEEDEPCIDNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private CFMOMIDPAEE CMBDFMILGMD;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int CLMNGGAFFDP = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private char[] ALAALGAAPFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private char[] PLAOLCPFMKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private int OALKJOGFDFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private char[] AAACNIPBMNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private int GDCKGIKNENA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private string KEBJDNHDPHI;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public MetricDescription IMANCMOGAIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xBC3070", Offset = "0xBC2470", VA = "0x180BC3070")]
		get
		{
			return default(MetricDescription);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x77ACD50", Offset = "0x77AC150", VA = "0x1877ACD50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public PMADAPOGLGM NMKCEDAGGDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x94D480", Offset = "0x94C880", VA = "0x18094D480")]
		get
		{
			return default(PMADAPOGLGM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public ReadOnlySpan<char> KLOIMGHDJGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x77ACFB0", Offset = "0x77AC3B0", VA = "0x1877ACFB0")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public ReadOnlySpan<char> JEPAJOMHAIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x77ACED0", Offset = "0x77AC2D0", VA = "0x1877ACED0")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public ReadOnlySpan<char> MJPJCNFMJLK
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x77AC9F0", Offset = "0x77ABDF0", VA = "0x1877AC9F0")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public CFMOMIDPAEE NKGAPEIEBDP
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xA60780", Offset = "0xA5FB80", VA = "0x180A60780")]
		get
		{
			return default(CFMOMIDPAEE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public double KLCAADLALKF
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x77AC9C0", Offset = "0x77ABDC0", VA = "0x1877AC9C0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public float KJLNEBLMPGH
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x77ACEC0", Offset = "0x77AC2C0", VA = "0x1877ACEC0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float GMOGCKGLLMN
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xAA9170", Offset = "0xAA8570", VA = "0x180AA9170")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xAF6040", Offset = "0xAF5440", VA = "0x180AF6040")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool BHELFFFDJCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xF518C0", Offset = "0xF50CC0", VA = "0x180F518C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x1169800", Offset = "0x1168C00", VA = "0x181169800")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public PKLDJMPIADF FGKGPILFGCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x94FCC0", Offset = "0x94F0C0", VA = "0x18094FCC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x77AD010", Offset = "0x77AC410", VA = "0x1877AD010")]
	public OMLJOPANOBN(string BPDGMLOBIKL, [Optional] MetricDescription AIHNBEMDDFL, [Optional] PKLDJMPIADF BEEDEPCIDNA, bool LKMFDDJAKLA = true, bool ECBFGMJPNBC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x77ACDD0", Offset = "0x77AC1D0", VA = "0x1877ACDD0")]
	public void LMAPGLNDIFH(RawMetricPayload JNLOPIHFLHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x77ACAD0", Offset = "0x77ABED0", VA = "0x1877ACAD0")]
	public bool IAOGLOKLKGP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x77AC5E0", Offset = "0x77AB9E0", VA = "0x1877AC5E0")]
	public bool FIHCPFBKKIK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x63E8850", Offset = "0x63E7C50", VA = "0x1863E8850")]
	public void OPCIMBAPBJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x63E8840", Offset = "0x63E7C40", VA = "0x1863E8840")]
	public void IEOIPPAELJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x77AC590", Offset = "0x77AB990", VA = "0x1877AC590")]
	private static int AHCDOJADLNI(MetricDataUnits MNMKKHBGNDM)
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

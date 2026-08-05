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
	public class LogRegistrationIndex : LGGBAGMLBKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x793E960", Offset = "0x793DB60", VA = "0x18793E960", Slot = "4")]
		public override void COGNOIDNGPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x98C9C0", Offset = "0x98BBC0", VA = "0x18098C9C0")]
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
		private enum MNCMDOBJNKD
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
		private static readonly PBBCGFNIILA NPAEAIAJLAP;

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
		private MNCMDOBJNKD CEKOKBEAHGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private MetricIdLookup LJDFKHJEFGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private IRawMetricsPipeline JPLJEPCGKEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private IMetricCollectionRegistry DAEEHPMFBOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private MetricCollectionToken MMKLNOBKPCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private MDLIACLACEL LGGDFFOJHCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private PBIGJMIHEJA HOBDEOGBAKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private Material GGIKHENPMBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private int IDFNOMJEHNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private LayoutRect BPADMCJPCLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int MLLKEOCMONM;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private const int CKOAEFGEAOC = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private FGMNBPCIEBB DPJNDCGLCBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private bool HFHPNCDIKII;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private Dictionary<MetricId, int> DEGCHOEKADE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private List<EIOHAMIHNAE> APJONDKNDMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private EGGBKCKJGDF MKCJCDPCEPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private List<EGGBKCKJGDF> KNHIIOEBFDJ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public MeshBufferRenderer HAKNFBJHCMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7940A80", Offset = "0x793FC80", VA = "0x187940A80")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7940C90", Offset = "0x793FE90", VA = "0x187940C90")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7940C30", Offset = "0x793FE30", VA = "0x187940C30")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x79400D0", Offset = "0x793F2D0", VA = "0x1879400D0")]
		private void KAOBJCOHPCE(bool NNHCCKJIMIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x793FD60", Offset = "0x793EF60", VA = "0x18793FD60")]
		private void JDKGGLFCOLP(bool NNHCCKJIMIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7940D40", Offset = "0x793FF40", VA = "0x187940D40")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x793FBE0", Offset = "0x793EDE0", VA = "0x18793FBE0")]
		public void InitMetricsDependencies(MetricIdLookup LJDFKHJEFGI, IRawMetricsPipeline JPLJEPCGKEK, IMetricCollectionRegistry DAEEHPMFBOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7940CC0", Offset = "0x793FEC0", VA = "0x187940CC0")]
		public void SetActiveOverlay(FGMNBPCIEBB BGFKGAPKMBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x793EEE0", Offset = "0x793E0E0", VA = "0x18793EEE0")]
		private void EILPMLNGDNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x79401C0", Offset = "0x793F3C0", VA = "0x1879401C0")]
		private void MDPMKMBJPHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7940350", Offset = "0x793F550", VA = "0x187940350")]
		private void NMDGLAKCCLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x793F360", Offset = "0x793E560", VA = "0x18793F360")]
		private void FAHMGOAEFCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x793EC30", Offset = "0x793DE30", VA = "0x18793EC30")]
		private bool CICLMGJJENF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x793E9F0", Offset = "0x793DBF0", VA = "0x18793E9F0")]
		private bool AECPAHGMDHA(bool CPGNGBBHKKK = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7940760", Offset = "0x793F960", VA = "0x187940760")]
		private bool NPEKBLLBOPI(EBDPFAGCKKD DPCGKOGCCDM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7940940", Offset = "0x793FB40", VA = "0x187940940")]
		private bool NPJLAJMPKMJ(EBDPFAGCKKD DPCGKOGCCDM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x793F9B0", Offset = "0x793EBB0", VA = "0x18793F9B0")]
		public void HandleMetric([In] RawMetric GEBPCGJCFDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x23435B0", Offset = "0x23427B0", VA = "0x1823435B0")]
		private bool HGMGKEGEKGC(MNCMDOBJNKD FJFHLIDCGCO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7940320", Offset = "0x793F520", VA = "0x187940320")]
		private bool MIPPILIPNOP(MNCMDOBJNKD IJALMJDGHPA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7941000", Offset = "0x7940200", VA = "0x187941000")]
		public MetricHudDisplay()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7940340", Offset = "0x793F540", VA = "0x187940340", Slot = "4")]
		private void NLLEIJLBKIE([In] RawMetric GEBPCGJCFDG)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal class EGGBKCKJGDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private bool MLMMOIOCHLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private LayoutRect AHGIFKGHENI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private TextSegmentLayout DHCNJOOBFJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private TextSegmentLayout GIFLDPMJBHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private TextSegmentLayout CFJLIGCOOPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private GPEIDPMHMKO NCNDFCKCBKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private MetricGraphGraphic KKPLKOAFDMC;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x793AFE0", Offset = "0x793A1E0", VA = "0x18793AFE0")]
	public void EMBIHAFPMPJ(MDLIACLACEL MOIFGIEDFOK, PBIGJMIHEJA ADMBFOJGIOL, LayoutRect FPAMIBEFDLM, int IEAJKCKDDFP, [Optional] MetricGraphGraphic KKPLKOAFDMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x793AE70", Offset = "0x793A070", VA = "0x18793AE70")]
	public void EBNOAIKBHNM(float DLOPFJNBDHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x793B6B0", Offset = "0x793A8B0", VA = "0x18793B6B0")]
	public void LGCJGGOIGMP(ReadOnlySpan<char> GLDDIOCOPGK, ReadOnlySpan<char> MOAHEEGNAFF, ReadOnlySpan<char> PPIKOOKJOKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x793B8D0", Offset = "0x793AAD0", VA = "0x18793B8D0")]
	public void MPNLCPIEDMD(RRColor32 JLNFDAODDKP, bool IEFOGJIODBC = true, bool FHIKFPOBIJK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x793BA70", Offset = "0x793AC70", VA = "0x18793BA70")]
	public float NPLNKAAJPII(float BKLMMIGJOGE, float BCINHCKLFKH, float FIGDHDOCCIL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x793BA20", Offset = "0x793AC20", VA = "0x18793BA20")]
	public void NABJOHFFIJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x793B4A0", Offset = "0x793A6A0", VA = "0x18793B4A0")]
	public void FOBGHAIIFPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x793B4D0", Offset = "0x793A6D0", VA = "0x18793B4D0")]
	public void GLDNDAGNAJP(EOLCDKAAMNC HPGHHNICBBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x793B820", Offset = "0x793AA20", VA = "0x18793B820")]
	public void MEDJDJNPLLA(EOLCDKAAMNC HPGHHNICBBG, double DIOKPOCPBHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x793ADE0", Offset = "0x7939FE0", VA = "0x18793ADE0")]
	public void EAMLDHAPJOI(double OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x793B4F0", Offset = "0x793A6F0", VA = "0x18793B4F0")]
	public void KHKCOPJHGHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public EGGBKCKJGDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class EIJAKJMAMDK
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static FGMNBPCIEBB NNKDEHKHAFA;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static FGMNBPCIEBB OMIMLMLBCPE;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static FGMNBPCIEBB FPDGAHKDANF;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static FGMNBPCIEBB EJFPPHPEEJM;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static FGMNBPCIEBB ELAEPELEAIB;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static FGMNBPCIEBB FCNHEJGHEBH;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static FGMNBPCIEBB IDMKIMBBHMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x793BFB0", Offset = "0x793B1B0", VA = "0x18793BFB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static FGMNBPCIEBB DAGCLMDAPPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x793C000", Offset = "0x793B200", VA = "0x18793C000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static FGMNBPCIEBB PLHLCKKJHBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x793BEC0", Offset = "0x793B0C0", VA = "0x18793BEC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static FGMNBPCIEBB GALCOJJNBCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x793BE70", Offset = "0x793B070", VA = "0x18793BE70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static FGMNBPCIEBB JJNNDHHFIFC
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x793BF60", Offset = "0x793B160", VA = "0x18793BF60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static FGMNBPCIEBB DIFLGJMPKHD
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x793BF10", Offset = "0x793B110", VA = "0x18793BF10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public static FGMNBPCIEBB GCLHNFJPPOD
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x962E10", Offset = "0x962010", VA = "0x180962E10")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct CELEEPCMGJA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public string DAGCAAFGHGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public string BNGLBHLIKOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public string LMGACAHGNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public EOLCDKAAMNC DIBIAKLHPFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public bool DPADLAHCMAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public bool OIJGJMODKKH;
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class FGMNBPCIEBB
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public string LOENICMPNCH
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x964520", Offset = "0x963720", VA = "0x180964520")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x964780", Offset = "0x963980", VA = "0x180964780")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public CELEEPCMGJA[] GPGCIHGBIPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9642A0", Offset = "0x9634A0", VA = "0x1809642A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "4")]
	public virtual void PKGDCCBDCGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "5")]
	public virtual void ODBFKBDGOLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x96FF10", Offset = "0x96F110", VA = "0x18096FF10")]
	public FGMNBPCIEBB(string AHMEOBJEAJP, CELEEPCMGJA[] ILAONPAJKAO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[Flags]
internal enum DHBDNKGABHC
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
internal class EIOHAMIHNAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private DHBDNKGABHC BIFPOPMCJAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private MetricDescription ODEKMJHGIFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private RawMetricPayload FKKLLADNDBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private EwmaFilter IPNAFBHLAIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private double KJAEKMHNDOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private int BMJJDOADFBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private EOLCDKAAMNC HPGHHNICBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private JNKMGCKAFCM JLEHOCGHLIP;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int CCLHJDDBHAD = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private char[] GLDDIOCOPGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private char[] MOAHEEGNAFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private int ACNEGDDOENI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private char[] PPIKOOKJOKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private int HEHOPAONCNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private string EJCMGMIBOCA;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public MetricDescription BDIKGNMBGBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xC1E1C0", Offset = "0xC1D3C0", VA = "0x180C1E1C0")]
		get
		{
			return default(MetricDescription);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x793E6C0", Offset = "0x793D8C0", VA = "0x18793E6C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public DHBDNKGABHC BCIKPPEMGAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x96C090", Offset = "0x96B290", VA = "0x18096C090")]
		get
		{
			return default(DHBDNKGABHC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public ReadOnlySpan<char> BIFDPOILGCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x793E740", Offset = "0x793D940", VA = "0x18793E740")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public ReadOnlySpan<char> HBFBNKNNBHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x793E590", Offset = "0x793D790", VA = "0x18793E590")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public ReadOnlySpan<char> IIPIHGBLHAA
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x793DFD0", Offset = "0x793D1D0", VA = "0x18793DFD0")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public JNKMGCKAFCM JGGNGJOINBM
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xAC11B0", Offset = "0xAC03B0", VA = "0x180AC11B0")]
		get
		{
			return default(JNKMGCKAFCM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public double OKELNLJIANI
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x793DD20", Offset = "0x793CF20", VA = "0x18793DD20")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public float FKDOBHNPFAP
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x793E490", Offset = "0x793D690", VA = "0x18793E490")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float LDHLOIMAFNA
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xB087C0", Offset = "0xB079C0", VA = "0x180B087C0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xB78510", Offset = "0xB77710", VA = "0x180B78510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool MBNIDFDNLAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xFD7FB0", Offset = "0xFD71B0", VA = "0x180FD7FB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x11CAC80", Offset = "0x11C9E80", VA = "0x1811CAC80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public EOLCDKAAMNC DIBIAKLHPFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x961620", Offset = "0x960820", VA = "0x180961620")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x793E7A0", Offset = "0x793D9A0", VA = "0x18793E7A0")]
	public EIOHAMIHNAE(string OOCHKCHNNFA, [Optional] MetricDescription ODEKMJHGIFB, [Optional] EOLCDKAAMNC HPGHHNICBBG, bool HNIANEIDOCD = true, bool GINKANPJAKH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x793E4A0", Offset = "0x793D6A0", VA = "0x18793E4A0")]
	public void IFDBLCPNEBG(RawMetricPayload NFKCOGJNCIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x793DD50", Offset = "0x793CF50", VA = "0x18793DD50")]
	public bool DHFHPCGBGGO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x793E0B0", Offset = "0x793D2B0", VA = "0x18793E0B0")]
	public bool HKHEBGEKFNA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x64D8C00", Offset = "0x64D7E00", VA = "0x1864D8C00")]
	public void AKDJCFNKJHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x64D8BF0", Offset = "0x64D7DF0", VA = "0x1864D8BF0")]
	public void LLOHGOLEJGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x793E670", Offset = "0x793D870", VA = "0x18793E670")]
	private static int JGEOPBGNPFL(MetricDataUnits JAPIMOGKCNP)
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

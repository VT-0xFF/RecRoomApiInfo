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
	public class LogRegistrationIndex : EJFLMJDOOOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x88287C0", Offset = "0x8826DC0", VA = "0x1888287C0", Slot = "4")]
		public override void CBPAAEAGBMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xABFAB0", Offset = "0xABE0B0", VA = "0x180ABFAB0")]
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
		private enum MFGPGBBKNMA
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
		private static readonly IDGHEFJHGEI FEFALLLFAGB;

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
		private MFGPGBBKNMA KEFCGAIKGHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private MetricIdLookup NPELBLHIAFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private IRawMetricsPipeline APJAAJFAFBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private IMetricCollectionRegistry HDLNHDJKBJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private MetricCollectionToken HILNNMJIIEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private BOKAHJFFMHP KNKHGBGNANI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private MCEACMNCNEN FKILEKLNPCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private Material HFNAGCOKMHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private int AIBJDMPKCGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private LayoutRect LEOFFIGGDAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int MPBBDPBDKIE;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private const int OKNKNCLMPPP = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private HEOKFPLCNFJ GBHFHDKEFAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private bool NFADCIKNBDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private Dictionary<MetricId, int> EBCECFCLFHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private List<KFFNNFDFKAF> PAPJGHLAFBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private JBGBGDABJPP DBLJIDLJMEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private List<JBGBGDABJPP> BAMKGHJAPMD;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public MeshBufferRenderer OGOCLLBAHAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x882A490", Offset = "0x8828A90", VA = "0x18882A490")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x882A6A0", Offset = "0x8828CA0", VA = "0x18882A6A0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x882A640", Offset = "0x8828C40", VA = "0x18882A640")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8829D00", Offset = "0x8828300", VA = "0x188829D00")]
		private void GIPFDLPOLCK(bool ECDIKDBOIEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8828990", Offset = "0x8826F90", VA = "0x188828990")]
		private void BCLDDFONNMA(bool ECDIKDBOIEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x882ABE0", Offset = "0x88291E0", VA = "0x18882ABE0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x882A040", Offset = "0x8828640", VA = "0x18882A040")]
		public void InitMetricsDependencies(MetricIdLookup NPELBLHIAFG, IRawMetricsPipeline APJAAJFAFBN, IMetricCollectionRegistry HDLNHDJKBJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x882AB60", Offset = "0x8829160", VA = "0x18882AB60")]
		public void SetActiveOverlay(HEOKFPLCNFJ CIGJNNJJDDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x882A6D0", Offset = "0x8828CD0", VA = "0x18882A6D0")]
		private void PAGFBMKGEGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8829120", Offset = "0x8827720", VA = "0x188829120")]
		private void BFFAGBEHHOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8828D10", Offset = "0x8827310", VA = "0x188828D10")]
		private void BDGNOAMBDHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8829290", Offset = "0x8827890", VA = "0x188829290")]
		private void CHMOJLDLJLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x882A1E0", Offset = "0x88287E0", VA = "0x18882A1E0")]
		private bool OKHNMDGKAGL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8829AC0", Offset = "0x88280C0", VA = "0x188829AC0")]
		private bool FAAJPHCAMNB(bool MKJGBAFLMBJ = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x88298E0", Offset = "0x8827EE0", VA = "0x1888298E0")]
		private bool CPLKMGMKBBP(IBOHKBJANCO LBHNPIBFMBH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8828850", Offset = "0x8826E50", VA = "0x188828850")]
		private bool ABPDHKJIGBB(IBOHKBJANCO LBHNPIBFMBH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8829DF0", Offset = "0x88283F0", VA = "0x188829DF0")]
		public void HandleMetric([In] RawMetric MFNMAAKGDOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x882A1D0", Offset = "0x88287D0", VA = "0x18882A1D0")]
		private bool JDLCBJACNEP(MFGPGBBKNMA IINBHIFBNDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x882A020", Offset = "0x8828620", VA = "0x18882A020")]
		private bool IKEGJBACCAK(MFGPGBBKNMA FJJDDAKGLND)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x882AEA0", Offset = "0x88294A0", VA = "0x18882AEA0")]
		public MetricHudDisplay()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8829280", Offset = "0x8827880", VA = "0x188829280", Slot = "4")]
		private void CBCGDFHFKDE([In] RawMetric MFNMAAKGDOL)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal class JBGBGDABJPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private bool NECFJFEEBOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private LayoutRect EFDJKNNOFAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private TextSegmentLayout AIOOLEFCKIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private TextSegmentLayout GONKENIAOAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private TextSegmentLayout LLCDKIKPLEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private GMIHPBLJNPF DKDGLMAKEMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private MetricGraphGraphic HDFBFLJNIGI;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x88275F0", Offset = "0x8825BF0", VA = "0x1888275F0")]
	public void PNHKIAJGEDI(BOKAHJFFMHP OKIDFONGGKO, MCEACMNCNEN GPBHMDADJOH, LayoutRect PMOPCBPKFFD, int IBEICLBCHMB, [Optional] MetricGraphGraphic HDFBFLJNIGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8827430", Offset = "0x8825A30", VA = "0x188827430")]
	public void OFICKCHFBCF(float PCCOKKHMFNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8827210", Offset = "0x8825810", VA = "0x188827210")]
	public void MNCADFEJPHF(ReadOnlySpan<char> ADFEPIMOLAN, ReadOnlySpan<char> NKCFIAKAPNO, ReadOnlySpan<char> AAHAKKLPJIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8826A20", Offset = "0x8825020", VA = "0x188826A20")]
	public void AFKDELMCPCJ(RRColor32 ONDGBPEOGJF, bool ADOKDMBDEHN = true, bool CLIKJNJCBOE = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8826BC0", Offset = "0x88251C0", VA = "0x188826BC0")]
	public float JECFGMFGKPI(float CIMGMIFJBBC, float NFDGKIHAPCP, float BEJEKGOBFCB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8826B70", Offset = "0x8825170", VA = "0x188826B70")]
	public void ELAHIKMDEDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x88275A0", Offset = "0x8825BA0", VA = "0x1888275A0")]
	public void OPBCMDDPJEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x88275D0", Offset = "0x8825BD0", VA = "0x1888275D0")]
	public void PFKACAHBPPF(GKABDIDAEBO EIDLBOAJGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8827380", Offset = "0x8825980", VA = "0x188827380")]
	public void NMPHDBAKFJN(GKABDIDAEBO EIDLBOAJGAG, double ILFCOODFNFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8827180", Offset = "0x8825780", VA = "0x188827180")]
	public void KMEHBDPOODH(double FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8826FC0", Offset = "0x88255C0", VA = "0x188826FC0")]
	public void JKHFIKONJMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public JBGBGDABJPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class DBBKEAOFDHF
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static HEOKFPLCNFJ KNMCEHOGLEF;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static HEOKFPLCNFJ JNIKMLCKIJB;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static HEOKFPLCNFJ EOPJGGMKDEK;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static HEOKFPLCNFJ NKEDGBIEPDJ;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static HEOKFPLCNFJ AKINBHIGACJ;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static HEOKFPLCNFJ JANPNMHEGMP;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static HEOKFPLCNFJ COLNIIHALMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8824C20", Offset = "0x8823220", VA = "0x188824C20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static HEOKFPLCNFJ OEIJAJGMABF
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8824B80", Offset = "0x8823180", VA = "0x188824B80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static HEOKFPLCNFJ KNLPNPLLGFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8824CC0", Offset = "0x88232C0", VA = "0x188824CC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static HEOKFPLCNFJ KHDBGIILKLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8824BD0", Offset = "0x88231D0", VA = "0x188824BD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static HEOKFPLCNFJ MHIIPDIMHDO
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8824C70", Offset = "0x8823270", VA = "0x188824C70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static HEOKFPLCNFJ DIHEKDIIGFE
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8824B30", Offset = "0x8823130", VA = "0x188824B30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public static HEOKFPLCNFJ LLBIGGBOCEG
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA97AD0", Offset = "0xA960D0", VA = "0x180A97AD0")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct EIAOIJFPLHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public string ELPEBIPAKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public string HKOOPJHMMPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public string BNAEJJDHKKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public GKABDIDAEBO HPODOKLNJKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public bool NFPEEEDDEJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public bool IKKOAONHLCK;
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class HEOKFPLCNFJ
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public string MHECIONFMCK
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public EIAOIJFPLHE[] JLDGIEJGBEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public virtual void FJIELLDMDJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "5")]
	public virtual void APNGFLAECHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0xA94D60", Offset = "0xA93360", VA = "0x180A94D60")]
	public HEOKFPLCNFJ(string AMFFBMMHAII, EIAOIJFPLHE[] JIGEPIBKMMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[Flags]
internal enum PPNMLHMNNJN
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
internal class KFFNNFDFKAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private PPNMLHMNNJN FKFPJHOBPGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private MetricDescription ILNDLHHCGKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private RawMetricPayload KMJEOGEJMHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private EwmaFilter OJFHCLMFMBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private double CEJNFGIDDIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private int NPLFBPPLICP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private GKABDIDAEBO EIDLBOAJGAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private LEEFFOEFAJK FPJMBLNNMPD;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int DBOHFKKNKCA = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private char[] ADFEPIMOLAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private char[] NKCFIAKAPNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private int ELBJECAADLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private char[] AAHAKKLPJIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private int ADDGPGJDEDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private string GGODMMHKEEG;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public MetricDescription HHAOAGIKBBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xEAD290", Offset = "0xEAB890", VA = "0x180EAD290")]
		get
		{
			return default(MetricDescription);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8827F90", Offset = "0x8826590", VA = "0x188827F90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public PPNMLHMNNJN DLECJMGBPEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xA9D650", Offset = "0xA9BC50", VA = "0x180A9D650")]
		get
		{
			return default(PPNMLHMNNJN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public ReadOnlySpan<char> FLIICNHGOEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x88285A0", Offset = "0x8826BA0", VA = "0x1888285A0")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public ReadOnlySpan<char> HNFKEBAABLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8827BA0", Offset = "0x88261A0", VA = "0x188827BA0")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public ReadOnlySpan<char> AFJHNDFCCDB
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8828010", Offset = "0x8826610", VA = "0x188828010")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public LEEFFOEFAJK AFFJNFENHBD
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xD4F030", Offset = "0xD4D630", VA = "0x180D4F030")]
		get
		{
			return default(LEEFFOEFAJK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public double NMMBJHIPIOO
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8827F10", Offset = "0x8826510", VA = "0x188827F10")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public float KHBKOGCOPBP
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8828590", Offset = "0x8826B90", VA = "0x188828590")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float BAGOGBHCOFG
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xD847A0", Offset = "0xD82DA0", VA = "0x180D847A0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xDFA620", Offset = "0xDF8C20", VA = "0x180DFA620")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool DPOLHEKOECP
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x130DD00", Offset = "0x130C300", VA = "0x18130DD00")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x1623410", Offset = "0x1621A10", VA = "0x181623410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public GKABDIDAEBO HPODOKLNJKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA962B0", Offset = "0xA948B0", VA = "0x180A962B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8828600", Offset = "0x8826C00", VA = "0x188828600")]
	public KFFNNFDFKAF(string GCNCIPOJBMI, [Optional] MetricDescription ILNDLHHCGKI, [Optional] GKABDIDAEBO EIDLBOAJGAG, bool EEBAMKDMAOD = true, bool IFMFKNGCCDB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x8827AB0", Offset = "0x88260B0", VA = "0x188827AB0")]
	public void AOBEHBINEDA(RawMetricPayload KKGCNCOPFOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8827C80", Offset = "0x8826280", VA = "0x188827C80")]
	public bool ENOPMCNBNHL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x88280F0", Offset = "0x88266F0", VA = "0x1888280F0")]
	public bool HKIGMGPEIJH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x71E56C0", Offset = "0x71E3CC0", VA = "0x1871E56C0")]
	public void NNOJJGIAPCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x71E56B0", Offset = "0x71E3CB0", VA = "0x1871E56B0")]
	public void LEOPCKKKLLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8827F40", Offset = "0x8826540", VA = "0x188827F40")]
	private static int FOIAGEBGFIE(MetricDataUnits GLMELHPJCNM)
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

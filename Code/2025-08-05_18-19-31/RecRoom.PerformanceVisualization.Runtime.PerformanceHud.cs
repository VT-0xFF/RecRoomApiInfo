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
	public class LogRegistrationIndex : FIPEGIMCDPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x86746B0", Offset = "0x8673AB0", VA = "0x1886746B0", Slot = "4")]
		public override void AAGBOPIEMBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
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
		private enum NCMDMOGLDGD
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
		private static readonly AKNCNLDICPO CCLJCJDJCOE;

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
		private NCMDMOGLDGD NLMAPNKKCIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private MetricIdLookup DMAKFHJGOEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private IRawMetricsPipeline IOPHEPCKOCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private IMetricCollectionRegistry CMMALPJACBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private MetricCollectionToken JKHEHFLLHPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private MMDFPBCPPIL ILHPLNDPCGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private HDDJAFJEBKE KNOIFAKMGFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private Material JDMLFDOFGEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private int ONMLDOMPAAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private LayoutRect KBCGNDMHCAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int MJFNBDGPNKE;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private const int LMBDDCDGFHP = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private LKGIPPKOALE CHCBLOIIABO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private bool NKNEPLADBAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private Dictionary<MetricId, int> NBJNNMNCJCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private List<FBLMJHHCJLB> GMGKMMAEBKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private BJBBJCKMMGE MGCEDOCDJNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private List<BJBBJCKMMGE> ODMIMEILOOL;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public MeshBufferRenderer BIDEJGNKKEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8676680", Offset = "0x8675A80", VA = "0x188676680")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8676890", Offset = "0x8675C90", VA = "0x188676890")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8676830", Offset = "0x8675C30", VA = "0x188676830")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8674740", Offset = "0x8673B40", VA = "0x188674740")]
		private void AFOIMHNCIKI(bool GJJCDLGLMED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8675050", Offset = "0x8674450", VA = "0x188675050")]
		private void DCBNNGBEJMC(bool GJJCDLGLMED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8676B20", Offset = "0x8675F20", VA = "0x188676B20")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8675CF0", Offset = "0x86750F0", VA = "0x188675CF0")]
		public void InitMetricsDependencies(MetricIdLookup DMAKFHJGOEI, IRawMetricsPipeline IOPHEPCKOCG, IMetricCollectionRegistry CMMALPJACBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8676AA0", Offset = "0x8675EA0", VA = "0x188676AA0")]
		public void SetActiveOverlay(LKGIPPKOALE MMFNANGOPFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8675620", Offset = "0x8674A20", VA = "0x188675620")]
		private void FPMHMHDJFLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8674EF0", Offset = "0x86742F0", VA = "0x188674EF0")]
		private void CCBODDKGPJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8675E80", Offset = "0x8675280", VA = "0x188675E80")]
		private void LEDFAJGKBAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8674830", Offset = "0x8673C30", VA = "0x188674830")]
		private void ALIPMONEEGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8676290", Offset = "0x8675690", VA = "0x188676290")]
		private bool MNBPKHPEFMF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x86753C0", Offset = "0x86747C0", VA = "0x1886753C0")]
		private bool DCPPMDCCLDH(bool KBIBIFOFAKG = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x86768C0", Offset = "0x8675CC0", VA = "0x1886768C0")]
		private bool PHPKHPCECCK(PEAEKLMBLEB NHDOFIDIKGL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8676540", Offset = "0x8675940", VA = "0x188676540")]
		private bool ONGIOPLAPEN(PEAEKLMBLEB NHDOFIDIKGL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8675AB0", Offset = "0x8674EB0", VA = "0x188675AB0")]
		public void HandleMetric([In] RawMetric FBOJKFPIEKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8674EE0", Offset = "0x86742E0", VA = "0x188674EE0")]
		private bool BHHAPCMILNE(NCMDMOGLDGD GCDEFBBNPOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8675600", Offset = "0x8674A00", VA = "0x188675600")]
		private bool ENANDKGKDAD(NCMDMOGLDGD CKJCGAHANIP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8676DE0", Offset = "0x86761E0", VA = "0x188676DE0")]
		public MetricHudDisplay()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8675CE0", Offset = "0x86750E0", VA = "0x188675CE0", Slot = "4")]
		private void ICKPPJGPIPE([In] RawMetric FBOJKFPIEKF)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal class BJBBJCKMMGE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private bool JDHPMEMMLAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private LayoutRect KDNDFAJDBOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private TextSegmentLayout CLNMAOAGHHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private TextSegmentLayout HPJHNPIKILL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private TextSegmentLayout COMLOJBDJCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private GLFHOAAJDDA JLGNBACBEFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private MetricGraphGraphic KEBICKAEIDH;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8671000", Offset = "0x8670400", VA = "0x188671000")]
	public void IPJPKJAMFMN(MMDFPBCPPIL GKCBGNCCGAD, HDDJAFJEBKE GJGJBLFNHAP, LayoutRect IPHLJBCJLGH, int GGHPNBCCDLG, [Optional] MetricGraphGraphic KEBICKAEIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8671940", Offset = "0x8670D40", VA = "0x188671940")]
	public void NAPOEIOLPAH(float AKKJCMPDNCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x86709C0", Offset = "0x866FDC0", VA = "0x1886709C0")]
	public void DGGMHMNFOEF(ReadOnlySpan<char> MHNMEDPEGLN, ReadOnlySpan<char> FMIPBCBDMNN, ReadOnlySpan<char> IDGMEODKHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8670EB0", Offset = "0x86702B0", VA = "0x188670EB0")]
	public void HBCOEDIINFG(RRColor32 IFBOGFLAOGG, bool PCHLPDBONKK = true, bool NLFAMFFEKLL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8671540", Offset = "0x8670940", VA = "0x188671540")]
	public float MEIHIIOBOMG(float CBHHBFEDIBB, float PDAKHHEHPOO, float NCNCDEMHHGL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x86714F0", Offset = "0x86708F0", VA = "0x1886714F0")]
	public void JELEJMOLCKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x86714C0", Offset = "0x86708C0", VA = "0x1886714C0")]
	public void JCNKFDEDDCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8670DE0", Offset = "0x86701E0", VA = "0x188670DE0")]
	public void FFANNPGBEDD(FCHKFFDPIJG FEEJNGIJPHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8670E00", Offset = "0x8670200", VA = "0x188670E00")]
	public void FPEFOEHNBNE(FCHKFFDPIJG FEEJNGIJPHG, double MJHAIBCGLLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8670D50", Offset = "0x8670150", VA = "0x188670D50")]
	public void EGDGKNALHIA(double CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8670B30", Offset = "0x866FF30", VA = "0x188670B30")]
	public void ECACKBMHMBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public BJBBJCKMMGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class ECJGILEKFBM
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static LKGIPPKOALE JAEGLKGOGMK;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static LKGIPPKOALE ODOOOPHEIFN;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static LKGIPPKOALE COGMPANDKFC;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static LKGIPPKOALE GKGENNBDEOC;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static LKGIPPKOALE MAHHAEGNMEN;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static LKGIPPKOALE NDDAAOELGKL;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static LKGIPPKOALE BCIBOEFGOGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8671BA0", Offset = "0x8670FA0", VA = "0x188671BA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static LKGIPPKOALE KDCKNDMFIHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8671C40", Offset = "0x8671040", VA = "0x188671C40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static LKGIPPKOALE IOBLMBNACJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8671AB0", Offset = "0x8670EB0", VA = "0x188671AB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static LKGIPPKOALE OCAFKCICEGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8671BF0", Offset = "0x8670FF0", VA = "0x188671BF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static LKGIPPKOALE NKBPCGHOEKK
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8671B00", Offset = "0x8670F00", VA = "0x188671B00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static LKGIPPKOALE OHCIGBJEDCN
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8671B50", Offset = "0x8670F50", VA = "0x188671B50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public static LKGIPPKOALE AMCCOMAEMHP
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED80", Offset = "0xA6E180", VA = "0x180A6ED80")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct PFBIDCGALPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public string EGPLOEOJGMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public string FGGPEIJKOKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public string HAIBIEGFKDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public FCHKFFDPIJG IHHKJPGPGIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public bool IJKDBFLOLAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public bool PPBEJNJFODB;
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class LKGIPPKOALE
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public string BOIMKKDBOOG
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public PFBIDCGALPO[] GIHLNEPBKGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public virtual void DOFAFDKMBCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "5")]
	public virtual void MPELJMKGFFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0xA7A690", Offset = "0xA79A90", VA = "0x180A7A690")]
	public LKGIPPKOALE(string LNOGNANOHAB, PFBIDCGALPO[] IHADNIBLGAO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[Flags]
internal enum BCBCCJOJNAL
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
internal class FBLMJHHCJLB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private BCBCCJOJNAL BGDMKPOADBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private MetricDescription OBFLJKIBHDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private RawMetricPayload JPPAFNCCIMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private EwmaFilter JHGMJLHKKEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private double AMAOAENANKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private int MCHPADAEIGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private FCHKFFDPIJG FEEJNGIJPHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private IJHCAKLIGNK OBPCMGNPKIK;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int ODJKJMBCDBD = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private char[] MHNMEDPEGLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private char[] FMIPBCBDMNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private int KDABCIHCAOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private char[] IDGMEODKHGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private int BMAHKDALJJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private string IELLFMMPBEF;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public MetricDescription FGEEHMDMJGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xE6C740", Offset = "0xE6BB40", VA = "0x180E6C740")]
		get
		{
			return default(MetricDescription);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8673AF0", Offset = "0x8672EF0", VA = "0x188673AF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public BCBCCJOJNAL GNHMILBFHMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xA72120", Offset = "0xA71520", VA = "0x180A72120")]
		get
		{
			return default(BCBCCJOJNAL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public ReadOnlySpan<char> IGJBAFMHJIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8673FC0", Offset = "0x86733C0", VA = "0x188673FC0")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public ReadOnlySpan<char> HDACAKDLBFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8673A10", Offset = "0x8672E10", VA = "0x188673A10")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public ReadOnlySpan<char> MJLEBNHGFIG
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8673B70", Offset = "0x8672F70", VA = "0x188673B70")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IJHCAKLIGNK CCDOLAHPLCL
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xCF0D60", Offset = "0xCF0160", VA = "0x180CF0D60")]
		get
		{
			return default(IJHCAKLIGNK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public double BCCDAKANMKH
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x86744C0", Offset = "0x86738C0", VA = "0x1886744C0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public float LPGGEEPEMNC
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8673A00", Offset = "0x8672E00", VA = "0x188673A00")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float ABEIFNNFJPC
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xD43CC0", Offset = "0xD430C0", VA = "0x180D43CC0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xDB9C10", Offset = "0xDB9010", VA = "0x180DB9C10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool CLBBPDHPAKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x12CA5C0", Offset = "0x12C99C0", VA = "0x1812CA5C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x15C3F00", Offset = "0x15C3300", VA = "0x1815C3F00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public FCHKFFDPIJG IHHKJPGPGIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA703D0", Offset = "0xA6F7D0", VA = "0x180A703D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x86744F0", Offset = "0x86738F0", VA = "0x1886744F0")]
	public FBLMJHHCJLB(string OGMPNBFOIII, [Optional] MetricDescription OBFLJKIBHDC, [Optional] FCHKFFDPIJG FEEJNGIJPHG, bool JPINDDHGLKF = true, bool MIOHOJHKKGH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x8673C50", Offset = "0x8673050", VA = "0x188673C50")]
	public void ICPIIOGEHKO(RawMetricPayload CIJGHJDHBIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8673D40", Offset = "0x8673140", VA = "0x188673D40")]
	public bool MBKPJEAMFPA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8674020", Offset = "0x8673420", VA = "0x188674020")]
	public bool MLFPKEPINPO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7038FA0", Offset = "0x70383A0", VA = "0x187038FA0")]
	public void GKEOAMAGDIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7038F90", Offset = "0x7038390", VA = "0x187038F90")]
	public void FABAOOFIFBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x86739B0", Offset = "0x8672DB0", VA = "0x1886739B0")]
	private static int AGBIBGINNFL(MetricDataUnits KCPOAENMGCO)
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

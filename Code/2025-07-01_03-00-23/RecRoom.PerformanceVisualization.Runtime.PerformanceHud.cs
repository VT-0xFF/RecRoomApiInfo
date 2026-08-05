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
	public class LogRegistrationIndex : CFJIINPOLDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8369080", Offset = "0x8367680", VA = "0x188369080", Slot = "4")]
		public override void CCHHFLKMKEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA6F950", Offset = "0xA6DF50", VA = "0x180A6F950")]
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
		private enum JILNFPGPGMK
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
		private static readonly LHMKAIAPMBI NDJJBNFFFGK;

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
		private JILNFPGPGMK EKNFCMOKPJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private MetricIdLookup IAFBILIBCLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private IRawMetricsPipeline DOFEDFGFILO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private IMetricCollectionRegistry CBEOJHPOGDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private MetricCollectionToken CLOPDGKEOHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private HLDLLFCIJLO ADIBNOLLKEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private NJBEGEMGOJJ PBHDFPGDHHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private Material ONAJHAPJFMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private int OEKHFDHINKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private LayoutRect EHBHKIKICBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int HFMKAOJIBNI;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private const int FEFFFJMPAGK = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private PBFMKBOEBGD JALCDCBAJDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private bool OGCKOIFLLEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private Dictionary<MetricId, int> EPINFJGIIBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private List<FNCONPKEJMF> DKOHCMKJFDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private JFIHIKGPLHA IPNJJFKGJBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private List<JFIHIKGPLHA> ABKOGEDKBEP;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public MeshBufferRenderer JKKAJMMOEAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x836B080", Offset = "0x8369680", VA = "0x18836B080")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x836B290", Offset = "0x8369890", VA = "0x18836B290")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x836B230", Offset = "0x8369830", VA = "0x18836B230")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8369490", Offset = "0x8367A90", VA = "0x188369490")]
		private void EAFEMDJALIO(bool NPIJFLCLFDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8369110", Offset = "0x8367710", VA = "0x188369110")]
		private void CCCGJIBGMIO(bool NPIJFLCLFDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x836B4A0", Offset = "0x8369AA0", VA = "0x18836B4A0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8369E80", Offset = "0x8368480", VA = "0x188369E80")]
		public void InitMetricsDependencies(MetricIdLookup IAFBILIBCLH, IRawMetricsPipeline DOFEDFGFILO, IMetricCollectionRegistry CBEOJHPOGDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x836B420", Offset = "0x8369A20", VA = "0x18836B420")]
		public void SetActiveOverlay(PBFMKBOEBGD LMNODJMLMOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x836ABD0", Offset = "0x83691D0", VA = "0x18836ABD0")]
		private void MJIPCIAMOGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x836B2C0", Offset = "0x83698C0", VA = "0x18836B2C0")]
		private void PHEBDKHMCKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8369590", Offset = "0x8367B90", VA = "0x188369590")]
		private void ELLNKCCMDLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x836A010", Offset = "0x8368610", VA = "0x18836A010")]
		private void JPHBCFBEPJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x83699A0", Offset = "0x8367FA0", VA = "0x1883699A0")]
		private bool HFEBLKPABDH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x836A660", Offset = "0x8368C60", VA = "0x18836A660")]
		private bool KLMMBPBPICA(bool KKBNDFNEENM = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x836A8B0", Offset = "0x8368EB0", VA = "0x18836A8B0")]
		private bool MHMFPPJIJLF(FFNJEDMMIBG INCFEGIJJJL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x836AA90", Offset = "0x8369090", VA = "0x18836AA90")]
		private bool MIHJAPIMEMK(FFNJEDMMIBG INCFEGIJJJL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8369C50", Offset = "0x8368250", VA = "0x188369C50")]
		public void HandleMetric([In] RawMetric NBIIIIIKAEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x836A8A0", Offset = "0x8368EA0", VA = "0x18836A8A0")]
		private bool LBACBDGBKAL(JILNFPGPGMK MOPOKGKOOJD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x836B060", Offset = "0x8369660", VA = "0x18836B060")]
		private bool NINBCLLKIJK(JILNFPGPGMK KFAPKDLDKGO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x836B760", Offset = "0x8369D60", VA = "0x18836B760")]
		public MetricHudDisplay()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8369580", Offset = "0x8367B80", VA = "0x188369580", Slot = "4")]
		private void ECPCEOEHBKE([In] RawMetric NBIIIIIKAEA)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal class JFIHIKGPLHA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private bool JNOGMCNDEMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private LayoutRect FAIHEHAHGIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private TextSegmentLayout CBPBGFALCBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private TextSegmentLayout MCGKNCNKEDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private TextSegmentLayout JDEMFNGDKCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private HNPBGLPGBIA OPPGPEAKJIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private MetricGraphGraphic HCJBKANAOAB;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8368BC0", Offset = "0x83671C0", VA = "0x188368BC0")]
	public void PNLBMDNIIGG(HLDLLFCIJLO JDHDMPCAEMB, NJBEGEMGOJJ KFKJJCBLAED, LayoutRect KGFAHLHIEHN, int GPLMOMAKOGC, [Optional] MetricGraphGraphic HCJBKANAOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8368260", Offset = "0x8366860", VA = "0x188368260")]
	public void DDHBKHHAGPG(float MMHLECICBFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8367FF0", Offset = "0x83665F0", VA = "0x188367FF0")]
	public void CALNKHKHBPO(ReadOnlySpan<char> AAJKOCHIHID, ReadOnlySpan<char> FAGHOCEKNFK, ReadOnlySpan<char> JIHGCPLDDBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8368670", Offset = "0x8366C70", VA = "0x188368670")]
	public void MCKNNCHLBJC(RRColor32 HFIMNHFKOFL, bool NKFDJCOAKNA = true, bool IBCPLOGMJFL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x83687C0", Offset = "0x8366DC0", VA = "0x1883687C0")]
	public float OLKCGMPDKPC(float EIJGCCMHHED, float LCEEJKECOFI, float HNMHAAJBLGA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8368160", Offset = "0x8366760", VA = "0x188368160")]
	public void CFPLOLNANOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8368640", Offset = "0x8366C40", VA = "0x188368640")]
	public void LBEGMKOLAEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8368620", Offset = "0x8366C20", VA = "0x188368620")]
	public void KJKCGCEBFJN(IINKDLHFHIJ FEOBCDEAOLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x83681B0", Offset = "0x83667B0", VA = "0x1883681B0")]
	public void DCJMPHGIHPM(IINKDLHFHIJ FEOBCDEAOLP, double HKINPNLCPPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8368590", Offset = "0x8366B90", VA = "0x188368590")]
	public void KIDAGJONNFB(double KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x83683D0", Offset = "0x83669D0", VA = "0x1883683D0")]
	public void GLGIKECFEFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public JFIHIKGPLHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class CPKIADFGEFJ
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static PBFMKBOEBGD LELJIGEALDF;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static PBFMKBOEBGD LMHBJIEGEEF;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static PBFMKBOEBGD GBPNBEIHGFI;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static PBFMKBOEBGD MMLPLMMEMNB;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static PBFMKBOEBGD INGLDGEJODP;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static PBFMKBOEBGD OMADBGLEHLO;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static PBFMKBOEBGD JLODNOEBAIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8365480", Offset = "0x8363A80", VA = "0x188365480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static PBFMKBOEBGD FMPENOHLCKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x83654D0", Offset = "0x8363AD0", VA = "0x1883654D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static PBFMKBOEBGD NFNIICEJGKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x83653E0", Offset = "0x83639E0", VA = "0x1883653E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static PBFMKBOEBGD IPGNBNLLKKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8365570", Offset = "0x8363B70", VA = "0x188365570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static PBFMKBOEBGD BEHENPCKLFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8365430", Offset = "0x8363A30", VA = "0x188365430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static PBFMKBOEBGD EECHDHPPJCK
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8365520", Offset = "0x8363B20", VA = "0x188365520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public static PBFMKBOEBGD DOGFLBPBLJM
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA46A00", Offset = "0xA45000", VA = "0x180A46A00")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct DFIPHEGOOAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public string KLCNIGKHAGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public string DNCPPNNPGKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public string BGHOOOAEBHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public IINKDLHFHIJ HDAGOEFLBGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public bool PNJMBIDLJGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public bool MMMHNFKAFAM;
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class PBFMKBOEBGD
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public string HMOKHIOKDKP
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public DFIPHEGOOAE[] JIFKDOOAMHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public virtual void EHMONJDOODA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "5")]
	public virtual void OCOAAOEAJFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0xA4BEA0", Offset = "0xA4A4A0", VA = "0x180A4BEA0")]
	public PBFMKBOEBGD(string CHFIPBCCMBD, DFIPHEGOOAE[] MGNEKNKIAGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[Flags]
internal enum LCCGKEJGELK
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
internal class FNCONPKEJMF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private LCCGKEJGELK LKDILNJPGNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private MetricDescription EOPOFMNFCKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private RawMetricPayload INCLIAEIKDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private EwmaFilter KOHKEIHJPHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private double CEMPPEFAKKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private int OBOBJECKNFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private IINKDLHFHIJ FEOBCDEAOLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private IHNCNMGCJDP EOOGHDABGBL;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int AMNNDABIAHJ = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private char[] AAJKOCHIHID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private char[] FAGHOCEKNFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private int OKKOKKOEHLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private char[] JIHGCPLDDBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private int NMMNGBADFNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private string IAEGBMAPKPO;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public MetricDescription OABKMGJGBAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xDED9A0", Offset = "0xDEBFA0", VA = "0x180DED9A0")]
		get
		{
			return default(MetricDescription);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x83679E0", Offset = "0x8365FE0", VA = "0x1883679E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public LCCGKEJGELK BCOPIPPAHML
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xA4C4A0", Offset = "0xA4AAA0", VA = "0x180A4C4A0")]
		get
		{
			return default(LCCGKEJGELK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public ReadOnlySpan<char> MKJPLCJEENM
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8367DD0", Offset = "0x83663D0", VA = "0x188367DD0")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public ReadOnlySpan<char> BLKPFHCKDJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8367CF0", Offset = "0x83662F0", VA = "0x188367CF0")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public ReadOnlySpan<char> BCDEDOKEPOB
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8367900", Offset = "0x8365F00", VA = "0x188367900")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IHNCNMGCJDP BIAGBLEOCIE
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xC86430", Offset = "0xC84A30", VA = "0x180C86430")]
		get
		{
			return default(IHNCNMGCJDP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public double MGBBEBAMFEO
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x83678D0", Offset = "0x8365ED0", VA = "0x1883678D0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public float NNOKODODIAH
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x83678C0", Offset = "0x8365EC0", VA = "0x1883678C0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float OAGHAJLGHOD
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xCCD5E0", Offset = "0xCCBBE0", VA = "0x180CCD5E0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xD1E870", Offset = "0xD1CE70", VA = "0x180D1E870")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool IIBACAPHLLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x12003E0", Offset = "0x11FE9E0", VA = "0x1812003E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x14F2FE0", Offset = "0x14F15E0", VA = "0x1814F2FE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public IINKDLHFHIJ HDAGOEFLBGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA44970", Offset = "0xA42F70", VA = "0x180A44970")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8367E30", Offset = "0x8366430", VA = "0x188367E30")]
	public FNCONPKEJMF(string JNBBFCFPNMI, [Optional] MetricDescription EOPOFMNFCKD, [Optional] IINKDLHFHIJ FEOBCDEAOLP, bool EDNAGPNPLHB = true, bool JCBPNABKLEK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x83672E0", Offset = "0x83658E0", VA = "0x1883672E0")]
	public void CCHBOCCHMPK(RawMetricPayload DOKMDLHEBHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8367A60", Offset = "0x8366060", VA = "0x188367A60")]
	public bool KFKCONMGDFB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8367420", Offset = "0x8365A20", VA = "0x188367420")]
	public bool ELGJCNAHPEB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6DA5F00", Offset = "0x6DA4500", VA = "0x186DA5F00")]
	public void OKGEONKBJFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6DA5EF0", Offset = "0x6DA44F0", VA = "0x186DA5EF0")]
	public void DGIFLNAFODF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x83673D0", Offset = "0x83659D0", VA = "0x1883673D0")]
	private static int DEJGEANLGEJ(MetricDataUnits AGCDGLEPLBI)
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

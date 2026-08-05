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
	public class LogRegistrationIndex : BPLGCOBKJGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7FC9870", Offset = "0x7FC8870", VA = "0x187FC9870", Slot = "4")]
		public override void AMBIAOGNIIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA1A700", Offset = "0xA19700", VA = "0x180A1A700")]
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
		private enum DCFICPBNKMF
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
		private static readonly JBBHIJHGEPM PAJIGEJCNAP;

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
		private DCFICPBNKMF KLDHMLLFEDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private MetricIdLookup INBNFFMHJEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private IRawMetricsPipeline JJFPHLJHIDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private IMetricCollectionRegistry KKOGMOAFABK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private MetricCollectionToken ANFLIMPPGPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private PEFFLCIMHDG MBBELFLHNCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private LBCCJIKLLIH LDPBMOMKJEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private Material MGHEDOGIMPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private int PENHOPFGHKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private LayoutRect KGFKPONMFJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int MKONHPEECIG;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private const int OKIGOEBMPJE = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private OECFJEGJOBD GCMJFGMCMFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private bool PFKLJDHKOEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private Dictionary<MetricId, int> JOBCJGAFPOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private List<CIMKEHICIMA> HGIEIKLELPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private PEBPHJCBIGN FEOALGEIBCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private List<PEBPHJCBIGN> NMCFECCEJBG;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public MeshBufferRenderer DIIDLMBLFDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7FCB990", Offset = "0x7FCA990", VA = "0x187FCB990")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7FCBBA0", Offset = "0x7FCABA0", VA = "0x187FCBBA0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7FCBB40", Offset = "0x7FCAB40", VA = "0x187FCBB40")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7FCA990", Offset = "0x7FC9990", VA = "0x187FCA990")]
		private void ICNHCGPIPGB(bool LMILHBBDLAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7FCA3F0", Offset = "0x7FC93F0", VA = "0x187FCA3F0")]
		private void HNLOEIPGKKI(bool LMILHBBDLAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7FCBC70", Offset = "0x7FCAC70", VA = "0x187FCBC70")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7FCACC0", Offset = "0x7FC9CC0", VA = "0x187FCACC0")]
		public void InitMetricsDependencies(MetricIdLookup INBNFFMHJEA, IRawMetricsPipeline JJFPHLJHIDL, IMetricCollectionRegistry KKOGMOAFABK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7FCBBF0", Offset = "0x7FCABF0", VA = "0x187FCBBF0")]
		public void SetActiveOverlay(OECFJEGJOBD EMMOIOHPMEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7FC9900", Offset = "0x7FC8900", VA = "0x187FC9900")]
		private void COFHKDGFKNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7FCAE50", Offset = "0x7FC9E50", VA = "0x187FCAE50")]
		private void JAIGPAGEBNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7FCB2D0", Offset = "0x7FCA2D0", VA = "0x187FCB2D0")]
		private void KOPNFACLCIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7FC9DA0", Offset = "0x7FC8DA0", VA = "0x187FC9DA0")]
		private void FHDJEBCDAJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7FCB6E0", Offset = "0x7FCA6E0", VA = "0x187FCB6E0")]
		private bool MDDPHGHMLCH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7FCAA80", Offset = "0x7FC9A80", VA = "0x187FCAA80")]
		private bool IEHAKJECEPD(bool ECOALLGHBMI = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7FCAFB0", Offset = "0x7FC9FB0", VA = "0x187FCAFB0")]
		private bool JCFDGACIGEB(BMGOKABNDBN NEKLMLONNIM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7FCB190", Offset = "0x7FCA190", VA = "0x187FCB190")]
		private bool JIPKBMBADPB(BMGOKABNDBN NEKLMLONNIM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7FCA760", Offset = "0x7FC9760", VA = "0x187FCA760")]
		public void HandleMetric([In] RawMetric MLELCPMIOKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x24DEA50", Offset = "0x24DDA50", VA = "0x1824DEA50")]
		private bool CDDIFNKCICP(DCFICPBNKMF HNJKBNOFGGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7FCBBD0", Offset = "0x7FCABD0", VA = "0x187FCBBD0")]
		private bool PIKHHADHFNG(DCFICPBNKMF AHOHIOJOJOG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7FCBF30", Offset = "0x7FCAF30", VA = "0x187FCBF30")]
		public MetricHudDisplay()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7FC9D90", Offset = "0x7FC8D90", VA = "0x187FC9D90", Slot = "4")]
		private void EAIEGMODDOP([In] RawMetric MLELCPMIOKG)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal class PEBPHJCBIGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private bool GPFLCKAMNFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private LayoutRect BPKPKMBJPDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private TextSegmentLayout IDAHEEBOMED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private TextSegmentLayout IOOGDNIGECL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private TextSegmentLayout NCDKHFENPDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private ILPBOLFDEHJ OOPCIGKEPME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private MetricGraphGraphic HLALLAJBCAP;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7FCC430", Offset = "0x7FCB430", VA = "0x187FCC430")]
	public void EEBICEODLFH(PEFFLCIMHDG KKHHLFGOJKA, LBCCJIKLLIH CJEJLMOKIJP, LayoutRect LPEBOHKPPLK, int FFEEENCEKHD, [Optional] MetricGraphGraphic HLALLAJBCAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7FCC2C0", Offset = "0x7FCB2C0", VA = "0x187FCC2C0")]
	public void CKCJODOBHGA(float KCGHGEMMBGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7FCC910", Offset = "0x7FCB910", VA = "0x187FCC910")]
	public void HKPHEMHFCJA(ReadOnlySpan<char> BDBFLBOFBGM, ReadOnlySpan<char> JOMJFHPECGD, ReadOnlySpan<char> IFOGOAJKPOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7FCCB30", Offset = "0x7FCBB30", VA = "0x187FCCB30")]
	public void NCHIIEBDCAC(RRColor32 NGGKCKILBNF, bool KGPKLOLMHJP = true, bool ODKBGFHHOEL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7FCCD10", Offset = "0x7FCBD10", VA = "0x187FCCD10")]
	public float OJOENHCGAOD(float EHDMIOIKIEO, float HMIIOIJEMAD, float JGOPNKDMDLP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7FCD110", Offset = "0x7FCC110", VA = "0x187FCD110")]
	public void PHAHACDDDPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7FCD160", Offset = "0x7FCC160", VA = "0x187FCD160")]
	public void PLPNMLHBNIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7FCC8F0", Offset = "0x7FCB8F0", VA = "0x187FCC8F0")]
	public void HEKHCLGNNOF(PENBDDEPHJF GNEJMIHLKNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7FCCA80", Offset = "0x7FCBA80", VA = "0x187FCCA80")]
	public void MDENNHDEEPA(PENBDDEPHJF GNEJMIHLKNH, double HDLKNIPAJGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7FCCC80", Offset = "0x7FCBC80", VA = "0x187FCCC80")]
	public void NGIILNODBNM(double OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7FCC100", Offset = "0x7FCB100", VA = "0x187FCC100")]
	public void AOJNBLCPAHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public PEBPHJCBIGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class IPBFBPKNBHE
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static OECFJEGJOBD NAKOIJFBHBG;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static OECFJEGJOBD KAFALOFFMKL;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static OECFJEGJOBD AOHFGKADPDG;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static OECFJEGJOBD PCPEONBODGO;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static OECFJEGJOBD NKLOFMKGMOJ;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static OECFJEGJOBD LKGMOKFCDLC;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static OECFJEGJOBD OPJKGEJPJBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7FC7A60", Offset = "0x7FC6A60", VA = "0x187FC7A60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static OECFJEGJOBD PGKCFGLPMJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7FC79C0", Offset = "0x7FC69C0", VA = "0x187FC79C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static OECFJEGJOBD IPIFELKLKOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7FC7B00", Offset = "0x7FC6B00", VA = "0x187FC7B00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static OECFJEGJOBD DLCKGCBEDPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7FC7A10", Offset = "0x7FC6A10", VA = "0x187FC7A10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static OECFJEGJOBD KPIPOGFJIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7FC7AB0", Offset = "0x7FC6AB0", VA = "0x187FC7AB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static OECFJEGJOBD NPPIJMMJMFN
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7FC7970", Offset = "0x7FC6970", VA = "0x187FC7970")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public static OECFJEGJOBD DDKBOEFIDNL
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9F0230", Offset = "0x9EF230", VA = "0x1809F0230")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct DHHDFFACBLL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public string IBENKHKLJFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public string AGDDMBFJAAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public string AFLPCNNBMIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public PENBDDEPHJF BBALHJGNFKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public bool HALGBIGEKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public bool AGACBLHNLJA;
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class OECFJEGJOBD
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public string GDDJONJKHPG
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public DHHDFFACBLL[] ONFBCHHKPHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public virtual void LJIJJAJPLLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "5")]
	public virtual void GODLCNFDGKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x9FE5E0", Offset = "0x9FD5E0", VA = "0x1809FE5E0")]
	public OECFJEGJOBD(string PAGMGOCFAHK, DHHDFFACBLL[] PKCEJFAFCCA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[Flags]
internal enum CGHLJEMHEGI
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
internal class CIMKEHICIMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private CGHLJEMHEGI EPMOPIGFAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private MetricDescription FOHPKJNICFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private RawMetricPayload DGHLABNPIEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private EwmaFilter GKICDPOEBFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private double MGFEIANCEOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private int KKIFCIBKGLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private PENBDDEPHJF GNEJMIHLKNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private GKEOMODKLJM HMJGPNLJPCO;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int HKPHJPOMOJB = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private char[] BDBFLBOFBGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private char[] JOMJFHPECGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private int CCDGKEMFPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private char[] IFOGOAJKPOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private int IOPEJFJGIOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private string FINOACPAHKN;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public MetricDescription OPGKLNIMCIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xD021C0", Offset = "0xD011C0", VA = "0x180D021C0")]
		get
		{
			return default(MetricDescription);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7FC6FB0", Offset = "0x7FC5FB0", VA = "0x187FC6FB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public CGHLJEMHEGI GBCILPNOMPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9F32A0", Offset = "0x9F22A0", VA = "0x1809F32A0")]
		get
		{
			return default(CGHLJEMHEGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public ReadOnlySpan<char> OOOCOBIOIBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7FC6E20", Offset = "0x7FC5E20", VA = "0x187FC6E20")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public ReadOnlySpan<char> MFFFOPKHFJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7FC76C0", Offset = "0x7FC66C0", VA = "0x187FC76C0")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public ReadOnlySpan<char> FBFBMAHEPIA
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7FC6E80", Offset = "0x7FC5E80", VA = "0x187FC6E80")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public GKEOMODKLJM KADMOFAEKBO
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xBB0C40", Offset = "0xBAFC40", VA = "0x180BB0C40")]
		get
		{
			return default(GKEOMODKLJM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public double HMEMKKBJLGE
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7FC7690", Offset = "0x7FC6690", VA = "0x187FC7690")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public float JMGJBKHMNPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7FC77A0", Offset = "0x7FC67A0", VA = "0x187FC77A0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float LAICHPNAIIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xBFE690", Offset = "0xBFD690", VA = "0x180BFE690")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xC4A0C0", Offset = "0xC490C0", VA = "0x180C4A0C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool JEIEDEILPLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x111FC50", Offset = "0x111EC50", VA = "0x18111FC50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x1357050", Offset = "0x1356050", VA = "0x181357050")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public PENBDDEPHJF BBALHJGNFKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9F4710", Offset = "0x9F3710", VA = "0x1809F4710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7FC77B0", Offset = "0x7FC67B0", VA = "0x187FC77B0")]
	public CIMKEHICIMA(string EKPIAKIDDJI, [Optional] MetricDescription FOHPKJNICFA, [Optional] PENBDDEPHJF GNEJMIHLKNH, bool OLKBBBLMKNC = true, bool EDHDIDGKPBN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7FC6D30", Offset = "0x7FC5D30", VA = "0x187FC6D30")]
	public void ANKEGOPKPDC(RawMetricPayload KCEIIGBJLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7FC7030", Offset = "0x7FC6030", VA = "0x187FC7030")]
	public bool DMNJADNLCPF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7FC72B0", Offset = "0x7FC62B0", VA = "0x187FC72B0")]
	public bool ICIKHJOHLJF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6AB9BD0", Offset = "0x6AB8BD0", VA = "0x186AB9BD0")]
	public void CLPFFDIBILB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6AA7B60", Offset = "0x6AA6B60", VA = "0x186AA7B60")]
	public void MENDAFDOJEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7FC6F60", Offset = "0x7FC5F60", VA = "0x187FC6F60")]
	private static int CNLCBMCKJFN(MetricDataUnits NILKHNKDICM)
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

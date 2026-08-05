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
	public class LogRegistrationIndex : LLMIPJJKGHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x847B290", Offset = "0x847A090", VA = "0x18847B290", Slot = "4")]
		public override void HIMDKAKGPHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA82AE0", Offset = "0xA818E0", VA = "0x180A82AE0")]
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
		private enum JAJFHKNFIFJ
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
		private static readonly PHLHEDGDBJO CFEMPAINFAM;

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
		private JAJFHKNFIFJ HPIMABDBCJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private MetricIdLookup CLNEOOFFAIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private IRawMetricsPipeline COIJBHEBAIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private IMetricCollectionRegistry MFJKOKODMEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private MetricCollectionToken DHHLJGCMNLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private GLKBFFAALKJ EKHODALHIMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private NIDMBDENMAO BECCDLEAEEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private Material JFLMMEIEEOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private int NFIJOACAGMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private LayoutRect OLCFDEDFGHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int GDDKEAEILIE;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private const int FLCELFMMLDF = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private HOOICGGNKEK PMJIPEHAAAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private bool DEHJHAFLCMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private Dictionary<MetricId, int> KKLOHGJOMEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private List<DOFAKJJGBFJ> FDPPKLACHOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private EJKDODIIABP AEHCEDHMHKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private List<EJKDODIIABP> ONJKABGEPKL;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public MeshBufferRenderer FNEKILHGNIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x847D3D0", Offset = "0x847C1D0", VA = "0x18847D3D0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x847D5E0", Offset = "0x847C3E0", VA = "0x18847D5E0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x847D580", Offset = "0x847C380", VA = "0x18847D580")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x847D2E0", Offset = "0x847C0E0", VA = "0x18847D2E0")]
		private void OEENEEJOAOI(bool BCDEGMPHKHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x847C9E0", Offset = "0x847B7E0", VA = "0x18847C9E0")]
		private void JDLMILMLLIL(bool BCDEGMPHKHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x847D6B0", Offset = "0x847C4B0", VA = "0x18847D6B0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x847C440", Offset = "0x847B240", VA = "0x18847C440")]
		public void InitMetricsDependencies(MetricIdLookup CLNEOOFFAIN, IRawMetricsPipeline COIJBHEBAIP, IMetricCollectionRegistry MFJKOKODMEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x847D630", Offset = "0x847C430", VA = "0x18847D630")]
		public void SetActiveOverlay(HOOICGGNKEK PHIGJDMMELK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x847B330", Offset = "0x847A130", VA = "0x18847B330")]
		private void APNEMCPJMDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x847CFA0", Offset = "0x847BDA0", VA = "0x18847CFA0")]
		private void KBMHBPMPIBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x847C5D0", Offset = "0x847B3D0", VA = "0x18847C5D0")]
		private void JDCLEAHDMNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x847BBC0", Offset = "0x847A9C0", VA = "0x18847BBC0")]
		private void HONMINIENOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x847B910", Offset = "0x847A710", VA = "0x18847B910")]
		private bool GBJPPFHIJBF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x847CD60", Offset = "0x847BB60", VA = "0x18847CD60")]
		private bool JKNFFHPGCPI(bool ADJOPEHJOFG = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x847D100", Offset = "0x847BF00", VA = "0x18847D100")]
		private bool KHDCNBIMHNC(DKFPGHEIIOM PBOOMELBCNJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x847B7C0", Offset = "0x847A5C0", VA = "0x18847B7C0")]
		private bool CHLELCPEJLO(DKFPGHEIIOM PBOOMELBCNJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x847C210", Offset = "0x847B010", VA = "0x18847C210")]
		public void HandleMetric([In] RawMetric ICMBKLKEBKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x847B320", Offset = "0x847A120", VA = "0x18847B320")]
		private bool AEIIADFAOBJ(JAJFHKNFIFJ JDIGAMNBHCI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x847D610", Offset = "0x847C410", VA = "0x18847D610")]
		private bool PJHIBMFNNPI(JAJFHKNFIFJ LGHAGGIKONE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x847D970", Offset = "0x847C770", VA = "0x18847D970")]
		public MetricHudDisplay()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x847B900", Offset = "0x847A700", VA = "0x18847B900", Slot = "4")]
		private void FDDIOCLGIJE([In] RawMetric ICMBKLKEBKB)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal class EJKDODIIABP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private bool NJGNPELBENF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private LayoutRect LELIAKDIOPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private TextSegmentLayout FFKKHFPNEKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private TextSegmentLayout HPOMLLCMCFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private TextSegmentLayout FOEGIJDLGBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private JECKJAHECKL NEMPGAKAMHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private MetricGraphGraphic FKIHOOPDNHC;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x847ADD0", Offset = "0x8479BD0", VA = "0x18847ADD0")]
	public void ONJHMMKMDOB(GLKBFFAALKJ DFCHHKFEBAN, NIDMBDENMAO HFPONIMNJJN, LayoutRect MOIKFDLJFDJ, int EEDGFPJOLJL, [Optional] MetricGraphGraphic FKIHOOPDNHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x847A5A0", Offset = "0x84793A0", VA = "0x18847A5A0")]
	public void EKLMOOOMCLN(float GLJKDHFIGGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x847AC60", Offset = "0x8479A60", VA = "0x18847AC60")]
	public void OCBFCOGMFAD(ReadOnlySpan<char> GMLMHENEHMB, ReadOnlySpan<char> CFKLMFBCKCM, ReadOnlySpan<char> OGLEGJDEPKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x847A200", Offset = "0x8479000", VA = "0x18847A200")]
	public void AHGJBCFDPKM(RRColor32 PFKMCINIKNC, bool KANDJCGJEFF = true, bool LNKKEGKLMAG = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x847A710", Offset = "0x8479510", VA = "0x18847A710")]
	public float GKIOGFJMEFB(float JKKDJPMNPNE, float EJJBDCJEHLP, float MDJOALMEMPO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x847AB10", Offset = "0x8479910", VA = "0x18847AB10")]
	public void HNCCPDKANMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x847AB60", Offset = "0x8479960", VA = "0x18847AB60")]
	public void KAAMGLBAGCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x847AC40", Offset = "0x8479A40", VA = "0x18847AC40")]
	public void NGGCIMFOGLG(ECLEBNEPKMK APACIMDJEGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x847AB90", Offset = "0x8479990", VA = "0x18847AB90")]
	public void KLDAGODNIJN(ECLEBNEPKMK APACIMDJEGN, double AMJKMJIBGNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x847A510", Offset = "0x8479310", VA = "0x18847A510")]
	public void CIBAHNAHIDI(double BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x847A350", Offset = "0x8479150", VA = "0x18847A350")]
	public void ANKJIMJKEFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public EJKDODIIABP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class BNIGGEAJGIJ
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static HOOICGGNKEK FHECFCANJFB;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static HOOICGGNKEK JLJOJFNMMEO;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static HOOICGGNKEK KAIPMBJAIDN;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static HOOICGGNKEK NNONACOKKPL;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static HOOICGGNKEK IJLBKEKANIN;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static HOOICGGNKEK IKGJKECHEAH;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static HOOICGGNKEK CLGJEJAIGBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8477730", Offset = "0x8476530", VA = "0x188477730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static HOOICGGNKEK KLOLOOIBOEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x84776E0", Offset = "0x84764E0", VA = "0x1884776E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static HOOICGGNKEK FMKEEOHBOLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x84775F0", Offset = "0x84763F0", VA = "0x1884775F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static HOOICGGNKEK HFKFKFMHGFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8477780", Offset = "0x8476580", VA = "0x188477780")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static HOOICGGNKEK LLADBJPABDB
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8477640", Offset = "0x8476440", VA = "0x188477640")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static HOOICGGNKEK IPBKGDGGIJE
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8477690", Offset = "0x8476490", VA = "0x188477690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public static HOOICGGNKEK ADLACOOLALG
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA58420", Offset = "0xA57220", VA = "0x180A58420")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct FLDCMHCCFGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public string FNJKLLCOFAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public string IIKAOBCFIBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public string BNANHOILMLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public ECLEBNEPKMK IEPKGLENJHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public bool NJKGEFDMOMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public bool MCAJBCCLADM;
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class HOOICGGNKEK
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public string OOKHCMCNDKA
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA598A0", Offset = "0xA586A0", VA = "0x180A598A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA59840", Offset = "0xA58640", VA = "0x180A59840")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public FLDCMHCCFGK[] ELJEHBAPMEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA595A0", Offset = "0xA583A0", VA = "0x180A595A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "4")]
	public virtual void LLEBHJMJNJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "5")]
	public virtual void ALAFGOHPCLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0xA639A0", Offset = "0xA627A0", VA = "0x180A639A0")]
	public HOOICGGNKEK(string NCPFIOFEKBK, FLDCMHCCFGK[] PJBIJEDCOJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[Flags]
internal enum OJLJDOBBIKK
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
internal class DOFAKJJGBFJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private OJLJDOBBIKK GCJMDBGOIMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private MetricDescription KPPMMGKIHMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private RawMetricPayload OFCPJKNFOPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private EwmaFilter OFGMEKAGEDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private double HJNKPJGEGEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private int GHFEFPHEHPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private ECLEBNEPKMK APACIMDJEGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private BHCGNHDONLI GEDLPMOCAIE;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int GGPBAAEAEPN = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private char[] GMLMHENEHMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private char[] CFKLMFBCKCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private int BEKCPCDFFOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private char[] OGLEGJDEPKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private int OHHKLBFMANP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private string CDCOCDJFBED;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public MetricDescription GCENKHNIHAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xE416F0", Offset = "0xE404F0", VA = "0x180E416F0")]
		get
		{
			return default(MetricDescription);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8479910", Offset = "0x8478710", VA = "0x188479910")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public OJLJDOBBIKK DNHKLEDFGCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xA5E620", Offset = "0xA5D420", VA = "0x180A5E620")]
		get
		{
			return default(OJLJDOBBIKK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public ReadOnlySpan<char> GGECGAHLIOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x84798B0", Offset = "0x84786B0", VA = "0x1884798B0")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public ReadOnlySpan<char> NLCDEOGJBCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x84794F0", Offset = "0x84782F0", VA = "0x1884794F0")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public ReadOnlySpan<char> ODNEGKLJGEB
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8479E40", Offset = "0x8478C40", VA = "0x188479E40")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public BHCGNHDONLI KOGFONCPANM
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xCDED80", Offset = "0xCDDB80", VA = "0x180CDED80")]
		get
		{
			return default(BHCGNHDONLI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public double BALDAAANPKO
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8479F20", Offset = "0x8478D20", VA = "0x188479F20")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public float JJBGBNAFLJL
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8479E30", Offset = "0x8478C30", VA = "0x188479E30")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float OJLHGOGAIHA
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xD261F0", Offset = "0xD24FF0", VA = "0x180D261F0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xD661E0", Offset = "0xD64FE0", VA = "0x180D661E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool MBOHANHCJHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1272A30", Offset = "0x1271830", VA = "0x181272A30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x15685B0", Offset = "0x15673B0", VA = "0x1815685B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public ECLEBNEPKMK IEPKGLENJHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA5F330", Offset = "0xA5E130", VA = "0x180A5F330")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x847A040", Offset = "0x8478E40", VA = "0x18847A040")]
	public DOFAKJJGBFJ(string DLNGPIGGLBL, [Optional] MetricDescription KPPMMGKIHMP, [Optional] ECLEBNEPKMK APACIMDJEGN, bool LLEDGLILOPA = true, bool IPBINNFBLHH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x8479F50", Offset = "0x8478D50", VA = "0x188479F50")]
	public void OLEAFBJCLFH(RawMetricPayload FCMENKCJJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x84795D0", Offset = "0x84783D0", VA = "0x1884795D0")]
	public bool FCHEFINPACD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8479990", Offset = "0x8478790", VA = "0x188479990")]
	public bool IMDAGANCLLI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6EA6650", Offset = "0x6EA5450", VA = "0x186EA6650")]
	public void NBGMKIMJFAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6EA6640", Offset = "0x6EA5440", VA = "0x186EA6640")]
	public void DKJMOPCHAEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8479860", Offset = "0x8478660", VA = "0x188479860")]
	private static int FIAGDOFFLHB(MetricDataUnits OCLBFMEGNJO)
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

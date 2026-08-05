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
	public class LogRegistrationIndex : BDONJGGEMII
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7BD1E50", Offset = "0x7BD1250", VA = "0x187BD1E50", Slot = "4")]
		public override void GEAMIGHEOPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9BE830", Offset = "0x9BDC30", VA = "0x1809BE830")]
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
		private enum HPMKEEPPBPE
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
		private static readonly GBHBOJAPDOA DPDKJPMBJOA;

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
		private HPMKEEPPBPE IMDJMOGIAFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private MetricIdLookup PHPCFHFHDDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private IRawMetricsPipeline BDFBAPAEJKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private IMetricCollectionRegistry CHINDHJIKHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private MetricCollectionToken IJLNCCINALA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private PEGDHDFJEOE PFBILKNNLAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private PIFHAKDIEGJ DDECCLLDOFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private Material CCCAOIGJCGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private int NINBCAFDFON;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private LayoutRect OLANNEFHDAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int MEOCIGCENAH;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private const int MLJEEMEFDPN = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private JGCJIJFBAOE EADPDCHKOGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private bool OKCAFDDGHAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private Dictionary<MetricId, int> JNGEOFIDLDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private List<LLNLBPEIACK> GKHEDAPJPIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private GKICJOAFPEE HJNFMHFPBHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private List<GKICJOAFPEE> PNOLIMMOFBF;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public MeshBufferRenderer FPEHHAAJFDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7BD3FA0", Offset = "0x7BD33A0", VA = "0x187BD3FA0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7BD41B0", Offset = "0x7BD35B0", VA = "0x187BD41B0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7BD4150", Offset = "0x7BD3550", VA = "0x187BD4150")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7BD3030", Offset = "0x7BD2430", VA = "0x187BD3030")]
		private void KABIJILKLEB(bool ILHCLNBPAJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7BD1EE0", Offset = "0x7BD12E0", VA = "0x187BD1EE0")]
		private void AALINOGPHIM(bool ILHCLNBPAJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7BD4260", Offset = "0x7BD3660", VA = "0x187BD4260")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7BD2EA0", Offset = "0x7BD22A0", VA = "0x187BD2EA0")]
		public void InitMetricsDependencies(MetricIdLookup PHPCFHFHDDH, IRawMetricsPipeline BDFBAPAEJKA, IMetricCollectionRegistry CHINDHJIKHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7BD41E0", Offset = "0x7BD35E0", VA = "0x187BD41E0")]
		public void SetActiveOverlay(JGCJIJFBAOE CJMEHPICKNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7BD23A0", Offset = "0x7BD17A0", VA = "0x187BD23A0")]
		private void CILJPIFEPCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7BD33D0", Offset = "0x7BD27D0", VA = "0x187BD33D0")]
		private void LODBHAADMGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7BD2850", Offset = "0x7BD1C50", VA = "0x187BD2850")]
		private void ENKINJNOJKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7BD3950", Offset = "0x7BD2D50", VA = "0x187BD3950")]
		private void NIOCFJLDLKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7BD3120", Offset = "0x7BD2520", VA = "0x187BD3120")]
		private bool KNOHHPIPBDH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7BD3530", Offset = "0x7BD2930", VA = "0x187BD3530")]
		private bool LPKFHOIAGGN(bool HLPBIKLHEBD = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7BD3770", Offset = "0x7BD2B70", VA = "0x187BD3770")]
		private bool NAKINDDNGPE(HBPFOPEAFLB PEAMMFAMJGD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7BD2260", Offset = "0x7BD1660", VA = "0x187BD2260")]
		private bool ALBMDENLNJA(HBPFOPEAFLB PEAMMFAMJGD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7BD2C60", Offset = "0x7BD2060", VA = "0x187BD2C60")]
		public void HandleMetric([In] RawMetric JHLIGMIBEJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x23FC7A0", Offset = "0x23FBBA0", VA = "0x1823FC7A0")]
		private bool MDDFJOAKELO(HPMKEEPPBPE LLCMINPIDCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7BD2830", Offset = "0x7BD1C30", VA = "0x187BD2830")]
		private bool DPJPKCMAJPG(HPMKEEPPBPE ILMBPPFBPFE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7BD4520", Offset = "0x7BD3920", VA = "0x187BD4520")]
		public MetricHudDisplay()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7BD2E90", Offset = "0x7BD2290", VA = "0x187BD2E90", Slot = "4")]
		private void IFPLONOKPHI([In] RawMetric JHLIGMIBEJH)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal class GKICJOAFPEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private bool IEPHEJLBCML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private LayoutRect JJPOBHADNFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private TextSegmentLayout AENJCHPNAII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private TextSegmentLayout KEBOEOBEONH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private TextSegmentLayout FHEEPPLGPHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private DNHKFOPALEG LEIOIKMPLIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private MetricGraphGraphic MODILCBOCME;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7BD01C0", Offset = "0x7BCF5C0", VA = "0x187BD01C0")]
	public void BECHPFCMIHE(PEGDHDFJEOE MDCFOFNJLOB, PIFHAKDIEGJ DFMAEGCMDGF, LayoutRect IKHFIALECEC, int OKDHGAPFLOA, [Optional] MetricGraphGraphic MODILCBOCME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7BD0680", Offset = "0x7BCFA80", VA = "0x187BD0680")]
	public void CFIAPDMABFA(float LDMDDNPOEMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7BD07F0", Offset = "0x7BCFBF0", VA = "0x187BD07F0")]
	public void CKCCEOHPMEG(ReadOnlySpan<char> AJCBFOKKPOK, ReadOnlySpan<char> KFMPNJKELEE, ReadOnlySpan<char> LNCADEFDBIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7BD0960", Offset = "0x7BCFD60", VA = "0x187BD0960")]
	public void DBLBIBGMPFE(RRColor32 ODFBFMBMBOG, bool FGJAPBNLOIA = true, bool PPBCGMMGDEM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7BD0B40", Offset = "0x7BCFF40", VA = "0x187BD0B40")]
	public float LMIGFEPHEHH(float DIDDBFEFFML, float NLNPIPCJEML, float GBJJEDEDAEL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7BD0170", Offset = "0x7BCF570", VA = "0x187BD0170")]
	public void ACANNMGMBGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7BD0F40", Offset = "0x7BD0340", VA = "0x187BD0F40")]
	public void MGAGNKOIHEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7BD11E0", Offset = "0x7BD05E0", VA = "0x187BD11E0")]
	public void PGLHAPDFFPM(BMHHKPDMAKD EMGNFONMJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7BD0F70", Offset = "0x7BD0370", VA = "0x187BD0F70")]
	public void MGBMPPNIKLM(BMHHKPDMAKD EMGNFONMJDJ, double KJPCKOGHHCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7BD0AB0", Offset = "0x7BCFEB0", VA = "0x187BD0AB0")]
	public void KPHMBMILALP(double FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7BD1020", Offset = "0x7BD0420", VA = "0x187BD1020")]
	public void MIPAEFEDIJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
	public GKICJOAFPEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class BFLMKGKFEJK
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static JGCJIJFBAOE GDMLDIBOMDM;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static JGCJIJFBAOE GCOELKKANML;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static JGCJIJFBAOE KBOKHMBGFOP;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static JGCJIJFBAOE CKEKFAHDCNM;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static JGCJIJFBAOE BHIKEEMIKPJ;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static JGCJIJFBAOE KBBIGPMIEOA;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static JGCJIJFBAOE AMGMCPILGIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7BCE400", Offset = "0x7BCD800", VA = "0x187BCE400")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static JGCJIJFBAOE PGBOEKMLHMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7BCE3B0", Offset = "0x7BCD7B0", VA = "0x187BCE3B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static JGCJIJFBAOE EKNKCFOOJBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7BCE310", Offset = "0x7BCD710", VA = "0x187BCE310")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static JGCJIJFBAOE AMIFFODMLAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7BCE360", Offset = "0x7BCD760", VA = "0x187BCE360")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static JGCJIJFBAOE HAPHOMBCHCL
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7BCE270", Offset = "0x7BCD670", VA = "0x187BCE270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static JGCJIJFBAOE ICLHHHLJIFA
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7BCE2C0", Offset = "0x7BCD6C0", VA = "0x187BCE2C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public static JGCJIJFBAOE EKEGIAOKMIF
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x996AF0", Offset = "0x995EF0", VA = "0x180996AF0")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct HNHNHKMFIJH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public string JLEIPGCOCFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public string FPBKDPIDBIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public string EFNJDCHBABO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public BMHHKPDMAKD CEOICEAHPNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public bool JAFKAEMKADN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public bool IFADHOLOAAP;
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class JGCJIJFBAOE
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public string IBIKFJBKBNK
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9943E0", Offset = "0x9937E0", VA = "0x1809943E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x994500", Offset = "0x993900", VA = "0x180994500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public HNHNHKMFIJH[] FCCDDAOGDID
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x993210", Offset = "0x992610", VA = "0x180993210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "4")]
	public virtual void EIAJIHGJDMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "5")]
	public virtual void EIKDLAIEGCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x9A3500", Offset = "0x9A2900", VA = "0x1809A3500")]
	public JGCJIJFBAOE(string MFHOBOOBKHB, HNHNHKMFIJH[] AICNBFDNLLI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[Flags]
internal enum EELIELHMNCM
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
internal class LLNLBPEIACK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private EELIELHMNCM IPJHAHHONPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private MetricDescription JDNPOBNDBDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private RawMetricPayload DMDJHNIAOJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private EwmaFilter LFMIHOIKJBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private double BOBBFKGJFCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private int AJPIDMDOBFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private BMHHKPDMAKD EMGNFONMJDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private BAONHMDAGCM MAJNIJPFEFL;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int FGLAPELKBEI = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private char[] AJCBFOKKPOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private char[] KFMPNJKELEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private int PAOEPCGMMMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private char[] LNCADEFDBIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private int GIJNPANCDBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private string LOEKKLLICJI;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public MetricDescription AIEHNONBDCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xC71960", Offset = "0xC70D60", VA = "0x180C71960")]
		get
		{
			return default(MetricDescription);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7BD1200", Offset = "0x7BD0600", VA = "0x187BD1200")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public EELIELHMNCM DGEDFANGBLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9984C0", Offset = "0x9978C0", VA = "0x1809984C0")]
		get
		{
			return default(EELIELHMNCM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public ReadOnlySpan<char> GKLIIGFAGDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7BD1280", Offset = "0x7BD0680", VA = "0x187BD1280")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public ReadOnlySpan<char> COJJJCIPMJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7BD1AC0", Offset = "0x7BD0EC0", VA = "0x187BD1AC0")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public ReadOnlySpan<char> PLPKNFLEGHP
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7BD15C0", Offset = "0x7BD09C0", VA = "0x187BD15C0")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public BAONHMDAGCM LCOCNICBIFB
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xB13DF0", Offset = "0xB131F0", VA = "0x180B13DF0")]
		get
		{
			return default(BAONHMDAGCM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public double MGEACCPGOGC
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7BD1A90", Offset = "0x7BD0E90", VA = "0x187BD1A90")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public float CNLAAALMAGD
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7BD1A80", Offset = "0x7BD0E80", VA = "0x187BD1A80")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float COBNMMOJLMA
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xB725C0", Offset = "0xB719C0", VA = "0x180B725C0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xBBE420", Offset = "0xBBD820", VA = "0x180BBE420")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool AOGOOEACOOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1043BA0", Offset = "0x1042FA0", VA = "0x181043BA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x123DF20", Offset = "0x123D320", VA = "0x18123DF20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public BMHHKPDMAKD CEOICEAHPNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x993A80", Offset = "0x992E80", VA = "0x180993A80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7BD1C90", Offset = "0x7BD1090", VA = "0x187BD1C90")]
	public LLNLBPEIACK(string BBLPHGNPPDD, [Optional] MetricDescription JDNPOBNDBDA, [Optional] BMHHKPDMAKD EMGNFONMJDJ, bool BAIFFCHMLBO = true, bool PCFBKOGNCDB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7BD1BA0", Offset = "0x7BD0FA0", VA = "0x187BD1BA0")]
	public void PDJNJHGADKP(RawMetricPayload CNPKPMAMCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7BD1330", Offset = "0x7BD0730", VA = "0x187BD1330")]
	public bool FBEKCKILPGH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7BD16A0", Offset = "0x7BD0AA0", VA = "0x187BD16A0")]
	public bool FHEDMOMGCNB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x67255E0", Offset = "0x67249E0", VA = "0x1867255E0")]
	public void ILOPAPMJLCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6713710", Offset = "0x6712B10", VA = "0x186713710")]
	public void AKPODPDAJMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7BD12E0", Offset = "0x7BD06E0", VA = "0x187BD12E0")]
	private static int EGELGEMFOJI(MetricDataUnits LFPMODGOMFK)
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

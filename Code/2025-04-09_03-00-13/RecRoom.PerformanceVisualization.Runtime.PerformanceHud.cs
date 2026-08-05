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
		[Cpp2IlInjected.Address(RVA = "0x7C26530", Offset = "0x7C25930", VA = "0x187C26530", Slot = "4")]
		public override void GEAMIGHEOPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9D4820", Offset = "0x9D3C20", VA = "0x1809D4820")]
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
			[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7C28660", Offset = "0x7C27A60", VA = "0x187C28660")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7C28870", Offset = "0x7C27C70", VA = "0x187C28870")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7C28810", Offset = "0x7C27C10", VA = "0x187C28810")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7C276F0", Offset = "0x7C26AF0", VA = "0x187C276F0")]
		private void KABIJILKLEB(bool ILHCLNBPAJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7C265C0", Offset = "0x7C259C0", VA = "0x187C265C0")]
		private void AALINOGPHIM(bool ILHCLNBPAJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7C28920", Offset = "0x7C27D20", VA = "0x187C28920")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7C27570", Offset = "0x7C26970", VA = "0x187C27570")]
		public void InitMetricsDependencies(MetricIdLookup PHPCFHFHDDH, IRawMetricsPipeline BDFBAPAEJKA, IMetricCollectionRegistry CHINDHJIKHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7C288A0", Offset = "0x7C27CA0", VA = "0x187C288A0")]
		public void SetActiveOverlay(JGCJIJFBAOE CJMEHPICKNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7C26A80", Offset = "0x7C25E80", VA = "0x187C26A80")]
		private void CILJPIFEPCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7C27A90", Offset = "0x7C26E90", VA = "0x187C27A90")]
		private void LODBHAADMGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7C26F20", Offset = "0x7C26320", VA = "0x187C26F20")]
		private void ENKINJNOJKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7C28010", Offset = "0x7C27410", VA = "0x187C28010")]
		private void NIOCFJLDLKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7C277E0", Offset = "0x7C26BE0", VA = "0x187C277E0")]
		private bool KNOHHPIPBDH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7C27BF0", Offset = "0x7C26FF0", VA = "0x187C27BF0")]
		private bool LPKFHOIAGGN(bool HLPBIKLHEBD = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7C27E30", Offset = "0x7C27230", VA = "0x187C27E30")]
		private bool NAKINDDNGPE(HBPFOPEAFLB PEAMMFAMJGD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7C26940", Offset = "0x7C25D40", VA = "0x187C26940")]
		private bool ALBMDENLNJA(HBPFOPEAFLB PEAMMFAMJGD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7C27330", Offset = "0x7C26730", VA = "0x187C27330")]
		public void HandleMetric([In] RawMetric JHLIGMIBEJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2409690", Offset = "0x2408A90", VA = "0x182409690")]
		private bool MDDFJOAKELO(HPMKEEPPBPE LLCMINPIDCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7C26F00", Offset = "0x7C26300", VA = "0x187C26F00")]
		private bool DPJPKCMAJPG(HPMKEEPPBPE ILMBPPFBPFE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7C28BE0", Offset = "0x7C27FE0", VA = "0x187C28BE0")]
		public MetricHudDisplay()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7C27560", Offset = "0x7C26960", VA = "0x187C27560", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x7C248A0", Offset = "0x7C23CA0", VA = "0x187C248A0")]
	public void BECHPFCMIHE(PEGDHDFJEOE MDCFOFNJLOB, PIFHAKDIEGJ DFMAEGCMDGF, LayoutRect IKHFIALECEC, int OKDHGAPFLOA, [Optional] MetricGraphGraphic MODILCBOCME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7C24D60", Offset = "0x7C24160", VA = "0x187C24D60")]
	public void CFIAPDMABFA(float LDMDDNPOEMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7C24ED0", Offset = "0x7C242D0", VA = "0x187C24ED0")]
	public void CKCCEOHPMEG(ReadOnlySpan<char> AJCBFOKKPOK, ReadOnlySpan<char> KFMPNJKELEE, ReadOnlySpan<char> LNCADEFDBIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7C25040", Offset = "0x7C24440", VA = "0x187C25040")]
	public void DBLBIBGMPFE(RRColor32 ODFBFMBMBOG, bool FGJAPBNLOIA = true, bool PPBCGMMGDEM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7C25220", Offset = "0x7C24620", VA = "0x187C25220")]
	public float LMIGFEPHEHH(float DIDDBFEFFML, float NLNPIPCJEML, float GBJJEDEDAEL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7C24850", Offset = "0x7C23C50", VA = "0x187C24850")]
	public void ACANNMGMBGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7C25620", Offset = "0x7C24A20", VA = "0x187C25620")]
	public void MGAGNKOIHEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7C258C0", Offset = "0x7C24CC0", VA = "0x187C258C0")]
	public void PGLHAPDFFPM(BMHHKPDMAKD EMGNFONMJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7C25650", Offset = "0x7C24A50", VA = "0x187C25650")]
	public void MGBMPPNIKLM(BMHHKPDMAKD EMGNFONMJDJ, double KJPCKOGHHCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7C25190", Offset = "0x7C24590", VA = "0x187C25190")]
	public void KPHMBMILALP(double FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7C25700", Offset = "0x7C24B00", VA = "0x187C25700")]
	public void MIPAEFEDIJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C22B30", Offset = "0x7C21F30", VA = "0x187C22B30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static JGCJIJFBAOE PGBOEKMLHMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7C22AE0", Offset = "0x7C21EE0", VA = "0x187C22AE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static JGCJIJFBAOE EKNKCFOOJBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7C22A40", Offset = "0x7C21E40", VA = "0x187C22A40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static JGCJIJFBAOE AMIFFODMLAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7C22A90", Offset = "0x7C21E90", VA = "0x187C22A90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static JGCJIJFBAOE HAPHOMBCHCL
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7C229A0", Offset = "0x7C21DA0", VA = "0x187C229A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static JGCJIJFBAOE ICLHHHLJIFA
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7C229F0", Offset = "0x7C21DF0", VA = "0x187C229F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public static JGCJIJFBAOE EKEGIAOKMIF
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9ACAA0", Offset = "0x9ABEA0", VA = "0x1809ACAA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9AA3B0", Offset = "0x9A97B0", VA = "0x1809AA3B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9AA4D0", Offset = "0x9A98D0", VA = "0x1809AA4D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public HNHNHKMFIJH[] FCCDDAOGDID
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9A9210", Offset = "0x9A8610", VA = "0x1809A9210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "4")]
	public virtual void EIAJIHGJDMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "5")]
	public virtual void EIKDLAIEGCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x9B9340", Offset = "0x9B8740", VA = "0x1809B9340")]
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
		[Cpp2IlInjected.Address(RVA = "0xC76DA0", Offset = "0xC761A0", VA = "0x180C76DA0")]
		get
		{
			return default(MetricDescription);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7C258E0", Offset = "0x7C24CE0", VA = "0x187C258E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public EELIELHMNCM DGEDFANGBLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9AE430", Offset = "0x9AD830", VA = "0x1809AE430")]
		get
		{
			return default(EELIELHMNCM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public ReadOnlySpan<char> GKLIIGFAGDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7C25960", Offset = "0x7C24D60", VA = "0x187C25960")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public ReadOnlySpan<char> COJJJCIPMJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7C261A0", Offset = "0x7C255A0", VA = "0x187C261A0")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public ReadOnlySpan<char> PLPKNFLEGHP
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7C25CA0", Offset = "0x7C250A0", VA = "0x187C25CA0")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public BAONHMDAGCM LCOCNICBIFB
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xB1BC00", Offset = "0xB1B000", VA = "0x180B1BC00")]
		get
		{
			return default(BAONHMDAGCM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public double MGEACCPGOGC
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7C26170", Offset = "0x7C25570", VA = "0x187C26170")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public float CNLAAALMAGD
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7C26160", Offset = "0x7C25560", VA = "0x187C26160")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float COBNMMOJLMA
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xB62380", Offset = "0xB61780", VA = "0x180B62380")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xBC5750", Offset = "0xBC4B50", VA = "0x180BC5750")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool AOGOOEACOOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x103D7A0", Offset = "0x103CBA0", VA = "0x18103D7A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x12451B0", Offset = "0x12445B0", VA = "0x1812451B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public BMHHKPDMAKD CEOICEAHPNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9A9A70", Offset = "0x9A8E70", VA = "0x1809A9A70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7C26370", Offset = "0x7C25770", VA = "0x187C26370")]
	public LLNLBPEIACK(string BBLPHGNPPDD, [Optional] MetricDescription JDNPOBNDBDA, [Optional] BMHHKPDMAKD EMGNFONMJDJ, bool BAIFFCHMLBO = true, bool PCFBKOGNCDB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7C26280", Offset = "0x7C25680", VA = "0x187C26280")]
	public void PDJNJHGADKP(RawMetricPayload CNPKPMAMCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7C25A10", Offset = "0x7C24E10", VA = "0x187C25A10")]
	public bool FBEKCKILPGH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7C25D80", Offset = "0x7C25180", VA = "0x187C25D80")]
	public bool FHEDMOMGCNB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6784A80", Offset = "0x6783E80", VA = "0x186784A80")]
	public void ILOPAPMJLCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6772ED0", Offset = "0x67722D0", VA = "0x186772ED0")]
	public void AKPODPDAJMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7C259C0", Offset = "0x7C24DC0", VA = "0x187C259C0")]
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

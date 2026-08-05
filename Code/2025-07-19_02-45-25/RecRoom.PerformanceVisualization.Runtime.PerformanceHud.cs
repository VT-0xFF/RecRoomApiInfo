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
	public class LogRegistrationIndex : AOMECLICLPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x853A540", Offset = "0x8539540", VA = "0x18853A540", Slot = "4")]
		public override void AMNFOKHCMAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA8A800", Offset = "0xA89800", VA = "0x180A8A800")]
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
		private enum OLIAIMIAAPC
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
		private static readonly ONIHMLNNEEF EFJNGOKNPIL;

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
		private OLIAIMIAAPC MCJMEPOLFKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private MetricIdLookup GJLNIMNCOPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private IRawMetricsPipeline GCFGHKNKFHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private IMetricCollectionRegistry PAJJLEBGFOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private MetricCollectionToken JDPNLBNKLDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private PNMLBNOOEII EDOPEJPOJKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private NANHGGBIIFI LIBOGAEJMGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private Material MEHHNGIPBJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private int HMIBNIEFBIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private LayoutRect EDHOAEAEOFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int GNDOLDBLGCK;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private const int MNNBIANEJFN = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private KEGLEFAGHPN DICNBHEFFDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private bool KCNMECIKDKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private Dictionary<MetricId, int> FCHFFFFAFME;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private List<HDMKMPEIEBL> MNCEBMLHKIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private DIFBLMOPDEG BEIABIAICMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private List<DIFBLMOPDEG> EDLEMMFIIFA;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public MeshBufferRenderer NNMEBMAJAAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x853C6F0", Offset = "0x853B6F0", VA = "0x18853C6F0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x853C900", Offset = "0x853B900", VA = "0x18853C900")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x853C8A0", Offset = "0x853B8A0", VA = "0x18853C8A0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x853C600", Offset = "0x853B600", VA = "0x18853C600")]
		private void OOMFBCKPNMJ(bool PHEOOAJAJMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x853C290", Offset = "0x853B290", VA = "0x18853C290")]
		private void LMJDOLOKIEM(bool PHEOOAJAJMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x853C9B0", Offset = "0x853B9B0", VA = "0x18853C9B0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x853BA40", Offset = "0x853AA40", VA = "0x18853BA40")]
		public void InitMetricsDependencies(MetricIdLookup GJLNIMNCOPA, IRawMetricsPipeline GCFGHKNKFHF, IMetricCollectionRegistry PAJJLEBGFOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x853C930", Offset = "0x853B930", VA = "0x18853C930")]
		public void SetActiveOverlay(KEGLEFAGHPN LCDGPENOENG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x853AE10", Offset = "0x8539E10", VA = "0x18853AE10")]
		private void FPBJPOECOMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x853AC80", Offset = "0x8539C80", VA = "0x18853AC80")]
		private void ANOHADLKBCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x853BE80", Offset = "0x853AE80", VA = "0x18853BE80")]
		private void LHEGBNFKFLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x853A5D0", Offset = "0x85395D0", VA = "0x18853A5D0")]
		private void AEPBOBIADJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x853BBD0", Offset = "0x853ABD0", VA = "0x18853BBD0")]
		private bool KFMPPGAAGII()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x853B2B0", Offset = "0x853A2B0", VA = "0x18853B2B0")]
		private bool GHAJGHMAGBJ(bool HOJOMGEINAH = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x853B630", Offset = "0x853A630", VA = "0x18853B630")]
		private bool GPMMJHFBEDE(OCMHEPHCGKM MKOOPFGGHLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x853B4F0", Offset = "0x853A4F0", VA = "0x18853B4F0")]
		private bool GKIEMDMAEIH(OCMHEPHCGKM MKOOPFGGHLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x853B810", Offset = "0x853A810", VA = "0x18853B810")]
		public void HandleMetric([In] RawMetric CJGEKDBPIFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x853B2A0", Offset = "0x853A2A0", VA = "0x18853B2A0")]
		private bool GEIGFMMGBEI(OLIAIMIAAPC MHDKCPNCABF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x853ADE0", Offset = "0x8539DE0", VA = "0x18853ADE0")]
		private bool CKPJHGCMADA(OLIAIMIAAPC BFGEGKADCFP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x853CC70", Offset = "0x853BC70", VA = "0x18853CC70")]
		public MetricHudDisplay()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x853AE00", Offset = "0x8539E00", VA = "0x18853AE00", Slot = "4")]
		private void DIIENNLIHDC([In] RawMetric CJGEKDBPIFJ)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal class DIFBLMOPDEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private bool CEKDKEKHGLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private LayoutRect INAGACFMCFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private TextSegmentLayout JKLGMCJNBLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private TextSegmentLayout CNCDEPADPJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private TextSegmentLayout GBPMJBFBELK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private FJALEJFPCKB DHCDLGHPPHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private MetricGraphGraphic AEJJGIHHLNP;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x85370F0", Offset = "0x85360F0", VA = "0x1885370F0")]
	public void LMCEEELLBNF(PNMLBNOOEII NHMHELHKIEP, NANHGGBIIFI MHKGIDIIMLM, LayoutRect FKIHNNCGLGB, int MJCPDPJCPNM, [Optional] MetricGraphGraphic AEJJGIHHLNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8536B50", Offset = "0x8535B50", VA = "0x188536B50")]
	public void GAFBCMOCNOO(float BHNODEEEOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8536850", Offset = "0x8535850", VA = "0x188536850")]
	public void BCFHGPNNPCF(ReadOnlySpan<char> GOPHLKANAPC, ReadOnlySpan<char> IKHHOKKGIBD, ReadOnlySpan<char> OPOAGCBKFMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x85377F0", Offset = "0x85367F0", VA = "0x1885377F0")]
	public void PDBOCJEEOEN(RRColor32 AHIICABHHJO, bool HGBHBDJKJLI = true, bool AGLFCMJHCHG = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8536CF0", Offset = "0x8535CF0", VA = "0x188536CF0")]
	public float GLPIIJFBAMJ(float OFODOEFCPJA, float ACGEOBGABKL, float HKLDEJPKDLN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x85369C0", Offset = "0x85359C0", VA = "0x1885369C0")]
	public void CGJNIDHMKLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8536CC0", Offset = "0x8535CC0", VA = "0x188536CC0")]
	public void GCICBFBLHLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x85375B0", Offset = "0x85365B0", VA = "0x1885375B0")]
	public void MHLEFDMKLCK(CAEFINNKKCC FANDIEKPHIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8536A10", Offset = "0x8535A10", VA = "0x188536A10")]
	public void CLAIAFOHIBG(CAEFINNKKCC FANDIEKPHIF, double AJNABLFIHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8536AC0", Offset = "0x8535AC0", VA = "0x188536AC0")]
	public void DJCDLGAHOHI(double IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x85375D0", Offset = "0x85365D0", VA = "0x1885375D0")]
	public void NBMGOOMFHHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public DIFBLMOPDEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class IKLMPGEOMOM
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static KEGLEFAGHPN BGGOFEPIGOA;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static KEGLEFAGHPN HMMEKKIBNLL;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static KEGLEFAGHPN MOKKAMBPDIP;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static KEGLEFAGHPN BBMIEBAAOCK;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static KEGLEFAGHPN HJGINPFHKID;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static KEGLEFAGHPN CPLCPFHMLNM;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static KEGLEFAGHPN HPFHFAKCNGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x85387D0", Offset = "0x85377D0", VA = "0x1885387D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static KEGLEFAGHPN KFFBCPEHJEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8538780", Offset = "0x8537780", VA = "0x188538780")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static KEGLEFAGHPN CDLMJKHLODA
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8538640", Offset = "0x8537640", VA = "0x188538640")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static KEGLEFAGHPN EKGFMHMAGJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x85386E0", Offset = "0x85376E0", VA = "0x1885386E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static KEGLEFAGHPN OBMLFNKEGHC
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8538690", Offset = "0x8537690", VA = "0x188538690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static KEGLEFAGHPN AOJOMCDKCGL
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8538730", Offset = "0x8537730", VA = "0x188538730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public static KEGLEFAGHPN EHAJBIAIFOO
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA60530", Offset = "0xA5F530", VA = "0x180A60530")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct MICNGAILIEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public string LCFDKFMJNNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public string IIAGHBKIDCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public string BNOBDGDAJFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public CAEFINNKKCC GDMDDBFEGIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public bool LOPHMJCLHKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public bool EOANPCOCJGC;
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class KEGLEFAGHPN
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public string GPMDGHINACB
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public MICNGAILIEN[] HPOLLOIHLCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public virtual void MEJKABMBPEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "5")]
	public virtual void GIPBIPLIAKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0xA653E0", Offset = "0xA643E0", VA = "0x180A653E0")]
	public KEGLEFAGHPN(string CJOMCGGBBON, MICNGAILIEN[] AGOJEHBDJOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[Flags]
internal enum JNBAFGFAIEG
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
internal class HDMKMPEIEBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private JNBAFGFAIEG GEOBKHFHFOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private MetricDescription OHKEKAEMFJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private RawMetricPayload MBAGIDFJGJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private EwmaFilter HFIOKADHDAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private double GEAPFIBKKHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private int CHGAHNDBDOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private CAEFINNKKCC FANDIEKPHIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private PHNNHDHELKN DONGDJGGCNB;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int MNELKMCNJEJ = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private char[] GOPHLKANAPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private char[] IKHHOKKGIBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private int APANIIOHFDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private char[] OPOAGCBKFMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private int FGDGCGKPDJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private string JIHDBKKPJNI;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public MetricDescription LGLHFAIHNAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xE60260", Offset = "0xE5F260", VA = "0x180E60260")]
		get
		{
			return default(MetricDescription);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8538400", Offset = "0x8537400", VA = "0x188538400")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public JNBAFGFAIEG APKDGNOFCAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xA6A700", Offset = "0xA69700", VA = "0x180A6A700")]
		get
		{
			return default(JNBAFGFAIEG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public ReadOnlySpan<char> ONLICCLGJMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x85380B0", Offset = "0x85370B0", VA = "0x1885380B0")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public ReadOnlySpan<char> LJGIJHFGHAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8538230", Offset = "0x8537230", VA = "0x188538230")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public ReadOnlySpan<char> ABMIOMJOGPP
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8538320", Offset = "0x8537320", VA = "0x188538320")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public PHNNHDHELKN NIFBFBEKPFO
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xCE3AB0", Offset = "0xCE2AB0", VA = "0x180CE3AB0")]
		get
		{
			return default(PHNNHDHELKN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public double DBDBCIFNFND
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8538200", Offset = "0x8537200", VA = "0x188538200")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public float MCMCLBLGFML
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8538310", Offset = "0x8537310", VA = "0x188538310")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float DLNOAILICAG
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xD356F0", Offset = "0xD346F0", VA = "0x180D356F0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xDA03A0", Offset = "0xD9F3A0", VA = "0x180DA03A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool LFHEHJIPDFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1290C40", Offset = "0x128FC40", VA = "0x181290C40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x1588380", Offset = "0x1587380", VA = "0x181588380")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public CAEFINNKKCC GDMDDBFEGIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA63170", Offset = "0xA62170", VA = "0x180A63170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8538480", Offset = "0x8537480", VA = "0x188538480")]
	public HDMKMPEIEBL(string NGBNCPKJGKC, [Optional] MetricDescription OHKEKAEMFJK, [Optional] CAEFINNKKCC FANDIEKPHIF, bool CKPOOOOLGHM = true, bool IBHIBKODIPC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x8538110", Offset = "0x8537110", VA = "0x188538110")]
	public void EEGNJLKCBMP(RawMetricPayload NCMNMHMLKBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8537E30", Offset = "0x8536E30", VA = "0x188537E30")]
	public bool BOCEFBNLAMP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8537990", Offset = "0x8536990", VA = "0x188537990")]
	public bool BAANBCKMFDP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6F370F0", Offset = "0x6F360F0", VA = "0x186F370F0")]
	public void MCOEHBFBNIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6F370E0", Offset = "0x6F360E0", VA = "0x186F370E0")]
	public void EKLOIJNNDJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8537940", Offset = "0x8536940", VA = "0x188537940")]
	private static int ANFAGIOLDAG(MetricDataUnits NHAOLJPBPMD)
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

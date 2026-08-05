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
	public class LogRegistrationIndex : OPBNGIPOJLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x88C0ED0", Offset = "0x88BF8D0", VA = "0x1888C0ED0", Slot = "4")]
		public override void NFFNLBFBLBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
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
		private enum CICFHDPMICM
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
		private static readonly OLFEOKKCIEG JHGFKLHHPJD;

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
		private CICFHDPMICM MPECFJMFHLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private MetricIdLookup KLOBEHOOCPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private IRawMetricsPipeline OPMMAMEBHMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private IMetricCollectionRegistry LGDCKNGDCFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private MetricCollectionToken IAGHCKGGBPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private FOKNLELMPFM NPAANOFKALJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private NKHJINBMJMN HPLBNGENLII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private Material PBNCINPPFII;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private int BAKAKELFOFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private LayoutRect PKPMEOAJHLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int AEIOPONJDLM;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private const int BDDNFFPPJOG = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private CBLGMBANKPL JJOLPHGLDHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private bool MMJBMDLGANA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private Dictionary<MetricId, int> MNEBEJJJNPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private List<MDPNFBEEMOI> BCOIHDLGJBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private KMCLFMPKCAJ AIIPKJACAEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private List<KMCLFMPKCAJ> MEDOHEKNBAP;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public MeshBufferRenderer HAKOHGCMAFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x88C3B80", Offset = "0x88C2580", VA = "0x1888C3B80")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x88C3D90", Offset = "0x88C2790", VA = "0x1888C3D90")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x88C3D30", Offset = "0x88C2730", VA = "0x1888C3D30")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x88C2080", Offset = "0x88C0A80", VA = "0x1888C2080")]
		private void ANKONJGMAGO(bool CJBINPFGANG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x88C2600", Offset = "0x88C1000", VA = "0x1888C2600")]
		private void ENMGKHGMCAC(bool CJBINPFGANG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x88C3FC0", Offset = "0x88C29C0", VA = "0x1888C3FC0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x88C2F50", Offset = "0x88C1950", VA = "0x1888C2F50")]
		public void InitMetricsDependencies(MetricIdLookup KLOBEHOOCPN, IRawMetricsPipeline OPMMAMEBHMM, IMetricCollectionRegistry LGDCKNGDCFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x88C3F40", Offset = "0x88C2940", VA = "0x1888C3F40")]
		public void SetActiveOverlay(CBLGMBANKPL OOCCJJPNPDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x88C2170", Offset = "0x88C0B70", VA = "0x1888C2170")]
		private void BPEMOHCAJBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x88C3DE0", Offset = "0x88C27E0", VA = "0x1888C3DE0")]
		private void PNKGEFEPKNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x88C1C70", Offset = "0x88C0670", VA = "0x1888C1C70")]
		private void AEJPEKNGKII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x88C3530", Offset = "0x88C1F30", VA = "0x1888C3530")]
		private void MPNACNOKIDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x88C30A0", Offset = "0x88C1AA0", VA = "0x1888C30A0")]
		private bool LMAHNHBOMPL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x88C2980", Offset = "0x88C1380", VA = "0x1888C2980")]
		private bool FHEPILLMGDI(bool KEJIJALNLAM = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x88C3350", Offset = "0x88C1D50", VA = "0x1888C3350")]
		private bool MMGEBADKIGI(CCHPBIFENPO PBOCDEMNFLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x88C2BD0", Offset = "0x88C15D0", VA = "0x1888C2BD0")]
		private bool HEHCCPCAHMK(CCHPBIFENPO PBOCDEMNFLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x88C2D10", Offset = "0x88C1710", VA = "0x1888C2D10")]
		public void HandleMetric([In] RawMetric BMPOMIGFMIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x88C2F40", Offset = "0x88C1940", VA = "0x1888C2F40")]
		private bool IPDNBMLBBPG(CICFHDPMICM NJHDCCJCFHL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x88C3DC0", Offset = "0x88C27C0", VA = "0x1888C3DC0")]
		private bool PMHJGIDFFPC(CICFHDPMICM ILOPINHIIEO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x88C4280", Offset = "0x88C2C80", VA = "0x1888C4280")]
		public MetricHudDisplay()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x88C2BC0", Offset = "0x88C15C0", VA = "0x1888C2BC0", Slot = "4")]
		private void HDOADKFBJJK([In] RawMetric BMPOMIGFMIL)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal class KMCLFMPKCAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private bool AEADHAHJCEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private LayoutRect PMHIDDCEKJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private TextSegmentLayout FNJNOKDMFPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private TextSegmentLayout OCMDBLNDDCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private TextSegmentLayout JGEHKBOPDFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private MEIFJGIGMLE KJLDAAKNOIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private MetricGraphGraphic LEKMNPEJOAO;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x88C0670", Offset = "0x88BF070", VA = "0x1888C0670")]
	public void LHEJPJMHOBO(FOKNLELMPFM IEGEHJKMLLK, NKHJINBMJMN NLJKHECMLMG, LayoutRect MIJOBFHNNIO, int DAICBMEEOBO, [Optional] MetricGraphGraphic LEKMNPEJOAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x88C0D60", Offset = "0x88BF760", VA = "0x1888C0D60")]
	public void PIHKMDCBHPH(float AABNGCCAIIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x88C0380", Offset = "0x88BED80", VA = "0x1888C0380")]
	public void GGFJPAKINJG(ReadOnlySpan<char> HBJGFABOJJL, ReadOnlySpan<char> OFBOACHKGJK, ReadOnlySpan<char> KJLILAMFPMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x88C0520", Offset = "0x88BEF20", VA = "0x1888C0520")]
	public void JGFMNHPGPBO(RRColor32 EOGEFFOIIOP, bool CMBIMJGDCFO = true, bool OMABLFOMIGF = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x88BFE40", Offset = "0x88BE840", VA = "0x1888BFE40")]
	public float ABPDAHINCMD(float GPBMEEIMOEI, float GNAKKGOPOHK, float HOEGPEFIGJL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x88C0B50", Offset = "0x88BF550", VA = "0x1888C0B50")]
	public void OGMIPJBNGPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x88C04F0", Offset = "0x88BEEF0", VA = "0x1888C04F0")]
	public void HCICOFHIPEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x88C0B30", Offset = "0x88BF530", VA = "0x1888C0B30")]
	public void MFNLLMDEHBJ(JNDDIDGPCKL DDBGKPLINLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x88C0240", Offset = "0x88BEC40", VA = "0x1888C0240")]
	public void COLHELDABMG(JNDDIDGPCKL DDBGKPLINLP, double NIAMAMNMMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x88C02F0", Offset = "0x88BECF0", VA = "0x1888C02F0")]
	public void EBNAHAHNKEJ(double KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x88C0BA0", Offset = "0x88BF5A0", VA = "0x1888C0BA0")]
	public void OLMPCAINCLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public KMCLFMPKCAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class KLLMPPMDHJL
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static CBLGMBANKPL HBEMCHNMFLO;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static CBLGMBANKPL KBPLCDOKDHE;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static CBLGMBANKPL OLEFLGLGOLH;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static CBLGMBANKPL GOEAHENLNPB;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static CBLGMBANKPL EAHDGPCKGAO;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static CBLGMBANKPL KEKABNGBENM;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static CBLGMBANKPL IIDHIFPMCOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x88BE040", Offset = "0x88BCA40", VA = "0x1888BE040")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static CBLGMBANKPL LLPPPIECHKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x88BDFF0", Offset = "0x88BC9F0", VA = "0x1888BDFF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static CBLGMBANKPL ENIPPMEENOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x88BDFA0", Offset = "0x88BC9A0", VA = "0x1888BDFA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static CBLGMBANKPL HKAADEALBEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x88BDF50", Offset = "0x88BC950", VA = "0x1888BDF50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static CBLGMBANKPL HDCLKAAIFBI
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x88BE0E0", Offset = "0x88BCAE0", VA = "0x1888BE0E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static CBLGMBANKPL EFAAANJDBGI
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x88BE090", Offset = "0x88BCA90", VA = "0x1888BE090")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public static CBLGMBANKPL EJGPPLLGMFO
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xAAD570", Offset = "0xAABF70", VA = "0x180AAD570")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct ODEJFAOLGNM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public string DFDGIKEDBPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public string BAGDPKFFCEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public string IHOAHBBPFHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public JNDDIDGPCKL FPGFCNKJGJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public bool KOONACLOGEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public bool AEGGEKCPMIE;
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class CBLGMBANKPL
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public string JGMPAAHOEAH
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public ODEJFAOLGNM[] PNINJGBIFNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public virtual void IOJJLBKHMEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
	public virtual void BBNOJKAAPIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0xAB5980", Offset = "0xAB4380", VA = "0x180AB5980")]
	public CBLGMBANKPL(string NICJKPGGLEM, ODEJFAOLGNM[] AFNKPGHGKGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[Flags]
internal enum CNMHGGJKKBG
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
internal class MDPNFBEEMOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private CNMHGGJKKBG HANKFBPFOJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private MetricDescription GLNJBBLDJBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private RawMetricPayload IHHGLEDNONA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private EwmaFilter LGJMEMIEEIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private double GGGGDJGDFLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private int PDKIEGNLGNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private JNDDIDGPCKL DDBGKPLINLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private HMNJDLDEFNI MMKEFNCBPEI;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int GDCDDHJLECP = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private char[] HBJGFABOJJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private char[] OFBOACHKGJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private int NOJAHMCNNAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private char[] KJLILAMFPMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private int JLIAICPPOPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private string BMGEJKENLKI;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public MetricDescription KLKHNJDKMBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xEC9A60", Offset = "0xEC8460", VA = "0x180EC9A60")]
		get
		{
			return default(MetricDescription);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x88C0FE0", Offset = "0x88BF9E0", VA = "0x1888C0FE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public CNMHGGJKKBG POEDOPKNPNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xAB3B20", Offset = "0xAB2520", VA = "0x180AB3B20")]
		get
		{
			return default(CNMHGGJKKBG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public ReadOnlySpan<char> ADGMLHANHDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x88C14C0", Offset = "0x88BFEC0", VA = "0x1888C14C0")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public ReadOnlySpan<char> MKLKMAGDDBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x88C19D0", Offset = "0x88C03D0", VA = "0x1888C19D0")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public ReadOnlySpan<char> BADFGJAKNPN
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x88C1150", Offset = "0x88BFB50", VA = "0x1888C1150")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public HMNJDLDEFNI LKKLJDJBPKK
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xD71C20", Offset = "0xD70620", VA = "0x180D71C20")]
		get
		{
			return default(HMNJDLDEFNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public double DHOAPKCCIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x88C0F60", Offset = "0x88BF960", VA = "0x1888C0F60")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public float OGIOPFONBJC
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x88C1520", Offset = "0x88BFF20", VA = "0x1888C1520")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float ECJACFIKAHD
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xDA71D0", Offset = "0xDA5BD0", VA = "0x180DA71D0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xE217B0", Offset = "0xE201B0", VA = "0x180E217B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool DKAJAPOGNFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1341D00", Offset = "0x1340700", VA = "0x181341D00")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x1679750", Offset = "0x1678150", VA = "0x181679750")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public JNDDIDGPCKL FPGFCNKJGJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xAB4840", Offset = "0xAB3240", VA = "0x180AB4840")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x88C1AB0", Offset = "0x88C04B0", VA = "0x1888C1AB0")]
	public MDPNFBEEMOI(string JLLMPMKJKMF, [Optional] MetricDescription GLNJBBLDJBB, [Optional] JNDDIDGPCKL DDBGKPLINLP, bool KKLFLMAPJBM = true, bool HDLGEELIMCH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x88C1060", Offset = "0x88BFA60", VA = "0x1888C1060")]
	public void FEMAMLAIFIL(RawMetricPayload NAPNCIDCFMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x88C1230", Offset = "0x88BFC30", VA = "0x1888C1230")]
	public bool LMGGEIHMHHJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x88C1530", Offset = "0x88BFF30", VA = "0x1888C1530")]
	public bool NHHALNHDAED()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x72613F0", Offset = "0x725FDF0", VA = "0x1872613F0")]
	public void OKFFJHOHIKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x72613E0", Offset = "0x725FDE0", VA = "0x1872613E0")]
	public void JEOKBNGJNEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x88C0F90", Offset = "0x88BF990", VA = "0x1888C0F90")]
	private static int EHJCFEJCANO(MetricDataUnits LCHANFMOPGD)
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

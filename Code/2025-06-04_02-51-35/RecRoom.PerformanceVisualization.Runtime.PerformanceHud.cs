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
	public class LogRegistrationIndex : HJMIPPBHOKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x83477A0", Offset = "0x8345FA0", VA = "0x1883477A0", Slot = "4")]
		public override void KELFLPPCOLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
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
		private enum LIDJLOMHONB
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
		private static readonly BMELPJIFPCL GLHOMCPEEHH;

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
		private LIDJLOMHONB PANINBEMOCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private MetricIdLookup APODJGHAELA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private IRawMetricsPipeline PAPBIJBGLIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private IMetricCollectionRegistry IMHECFPJNJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private MetricCollectionToken HHDEBKHLMCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private FKBFPHGCEMH JJOFMGOCHDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private GLDEKFAJAOK EOGJBJOGCML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private Material FLGOCNBCGON;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private int HLPMEKPCBIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private LayoutRect CIGAEAALKLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int DAAFBMJKONL;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private const int DHBKHGIOMJF = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private AOENGCMBILD PPNGFCMBGPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private bool PKOBPBMKMBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private Dictionary<MetricId, int> IIGGPDLIDLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private List<LGFLELLAJOL> KPKICKOKAJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private HMABOPCPBIM JNBHFCOPOJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private List<HMABOPCPBIM> DEKHOIOPGAO;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public MeshBufferRenderer JLEEJLFIKHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x83498D0", Offset = "0x83480D0", VA = "0x1883498D0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8349AE0", Offset = "0x83482E0", VA = "0x188349AE0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8349A80", Offset = "0x8348280", VA = "0x188349A80")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8347D30", Offset = "0x8346530", VA = "0x188347D30")]
		private void DLOFNBPCKEM(bool EOEAMFOCIJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8348D30", Offset = "0x8347530", VA = "0x188348D30")]
		private void NMABCPELOAA(bool EOEAMFOCIJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8349B90", Offset = "0x8348390", VA = "0x188349B90")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8348BB0", Offset = "0x83473B0", VA = "0x188348BB0")]
		public void InitMetricsDependencies(MetricIdLookup APODJGHAELA, IRawMetricsPipeline PAPBIJBGLIB, IMetricCollectionRegistry IMHECFPJNJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8349B10", Offset = "0x8348310", VA = "0x188349B10")]
		public void SetActiveOverlay(AOENGCMBILD AJAFPBMDFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x83480F0", Offset = "0x83468F0", VA = "0x1883480F0")]
		private void HALCAHEJAOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8347E20", Offset = "0x8346620", VA = "0x188347E20")]
		private void EJHMPJNKIIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x83487A0", Offset = "0x8346FA0", VA = "0x1883487A0")]
		private void IFADGMNMHNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x83490A0", Offset = "0x83478A0", VA = "0x1883490A0")]
		private void NNKDHACBMMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8347830", Offset = "0x8346030", VA = "0x188347830")]
		private bool AJFCACKFIJM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8347AE0", Offset = "0x83462E0", VA = "0x188347AE0")]
		private bool AKMEEGHDBOF(bool IBCIAMDAPFE = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x83496F0", Offset = "0x8347EF0", VA = "0x1883496F0")]
		private bool OCIHNDDNDHF(IEMNGFHJIPG BJNLPCOGDLM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8347FA0", Offset = "0x83467A0", VA = "0x188347FA0")]
		private bool GAONCFINEJL(IEMNGFHJIPG BJNLPCOGDLM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8348570", Offset = "0x8346D70", VA = "0x188348570")]
		public void HandleMetric([In] RawMetric LHHBGFGIHOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8347D20", Offset = "0x8346520", VA = "0x188347D20")]
		private bool CNOFLNEEGBF(LIDJLOMHONB ONDPPKIMDBJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8347F80", Offset = "0x8346780", VA = "0x188347F80")]
		private bool ENICJGHHOCF(LIDJLOMHONB CKMEGCNKIAM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8349E50", Offset = "0x8348650", VA = "0x188349E50")]
		public MetricHudDisplay()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x83480E0", Offset = "0x83468E0", VA = "0x1883480E0", Slot = "4")]
		private void GFICDNNMOIM([In] RawMetric LHHBGFGIHOL)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal class HMABOPCPBIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private bool BIFDBKGNJGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private LayoutRect GKOOPPLILMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private TextSegmentLayout OEMHBNIPODC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private TextSegmentLayout GPPBPBAOHPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private TextSegmentLayout JEHNNLBBBFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private NPEBJIIPBHM BAFFMFDJOLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private MetricGraphGraphic IMGFHBNGGIP;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8343CC0", Offset = "0x83424C0", VA = "0x188343CC0")]
	public void HNPKBJNJFKN(FKBFPHGCEMH NCEAOHLOFLM, GLDEKFAJAOK LLANHOBAGGC, LayoutRect JLJBJKLPGLH, int HDOPOKHBHBG, [Optional] MetricGraphGraphic IMGFHBNGGIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x83444D0", Offset = "0x8342CD0", VA = "0x1883444D0")]
	public void KBNMGCHMGLJ(float OHIAFEEACMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8344180", Offset = "0x8342980", VA = "0x188344180")]
	public void IBCOIKGOLCK(ReadOnlySpan<char> GKOHCHBBNEL, ReadOnlySpan<char> EJIKICFOPPG, ReadOnlySpan<char> HBDCIFJHIMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8344380", Offset = "0x8342B80", VA = "0x188344380")]
	public void JFHKFILDJNB(RRColor32 BIKIHAKPCIG, bool CNHGMCIKOAN = true, bool AADAABNMFEB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x83446F0", Offset = "0x8342EF0", VA = "0x1883446F0")]
	public float KFIJGICJAEJ(float PMICKHIAEIM, float FBBNMBIELCM, float KMAPLBJOOMO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8343C70", Offset = "0x8342470", VA = "0x188343C70")]
	public void CNEBPJBHFKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8343C20", Offset = "0x8342420", VA = "0x188343C20")]
	public void ACMEPJNDKMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8343C50", Offset = "0x8342450", VA = "0x188343C50")]
	public void AJENLNLCKPH(AGGICKCJJAM IILNEBJHNFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8344640", Offset = "0x8342E40", VA = "0x188344640")]
	public void KCIJHLCLPGP(AGGICKCJJAM IILNEBJHNFN, double DKMKOJPHLDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x83442F0", Offset = "0x8342AF0", VA = "0x1883442F0")]
	public void IOMLIIFDAPJ(double MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8344AF0", Offset = "0x83432F0", VA = "0x188344AF0")]
	public void PBPOAHLKNMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public HMABOPCPBIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class LAAEGDLAMDI
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static AOENGCMBILD GMAPIJPHHPB;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static AOENGCMBILD IONHBPCMPAM;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static AOENGCMBILD ENCJOMAPPOF;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static AOENGCMBILD AEKFMKJEKKH;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static AOENGCMBILD DIEBCNDMNMO;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static AOENGCMBILD IMJNHPMIKAJ;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static AOENGCMBILD JMOEBDABFID
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8344CB0", Offset = "0x83434B0", VA = "0x188344CB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static AOENGCMBILD FCIBJGFBLOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8344DA0", Offset = "0x83435A0", VA = "0x188344DA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static AOENGCMBILD EMJHLPABGND
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8344D00", Offset = "0x8343500", VA = "0x188344D00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static AOENGCMBILD NPNGOJPKJCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8344E40", Offset = "0x8343640", VA = "0x188344E40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static AOENGCMBILD HCICHBNKBIN
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8344D50", Offset = "0x8343550", VA = "0x188344D50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static AOENGCMBILD ELIPDENLDGO
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8344DF0", Offset = "0x83435F0", VA = "0x188344DF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public static AOENGCMBILD HJMPLHLAOLB
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA28D50", Offset = "0xA27550", VA = "0x180A28D50")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct DPADHOKPMOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public string OOPBIEEOBCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public string DCCDENJFOIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public string HELOAEAJIJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public AGGICKCJJAM JCBIIDIINHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public bool BDIOEFAFABO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public bool HOOFGAMHJML;
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class AOENGCMBILD
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public string HPLODLNCFIF
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public DPADHOKPMOC[] EEEOEIBCLEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public virtual void JGKLIAKFGAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "5")]
	public virtual void CIEEDBCOIMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0xA2A040", Offset = "0xA28840", VA = "0x180A2A040")]
	public AOENGCMBILD(string HGCMMCJBAPF, DPADHOKPMOC[] OCIGIMEACAH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[Flags]
internal enum NMGCPMBMNMJ
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
internal class LGFLELLAJOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private NMGCPMBMNMJ DNOLIPFDJNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private MetricDescription FLJIFIGCALA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private RawMetricPayload OILJBDLKBKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private EwmaFilter MBIONEHDNAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private double ONOMJONHPLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private int CAMIMLKGDLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private AGGICKCJJAM IILNEBJHNFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private PAMHNHJLMLE FCIDAMHDLGE;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int FOJMPGGLKAM = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private char[] GKOHCHBBNEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private char[] EJIKICFOPPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private int GCFJJEMHCDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private char[] HBDCIFJHIMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private int EGFDGJFEEIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private string BOINHFJGDEI;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public MetricDescription LOFGGFDABCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xDC2E90", Offset = "0xDC1690", VA = "0x180DC2E90")]
		get
		{
			return default(MetricDescription);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8347150", Offset = "0x8345950", VA = "0x188347150")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public NMGCPMBMNMJ IAMAGFHGOAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xA32B80", Offset = "0xA31380", VA = "0x180A32B80")]
		get
		{
			return default(NMGCPMBMNMJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public ReadOnlySpan<char> GEHOJDPNALH
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8347300", Offset = "0x8345B00", VA = "0x188347300")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public ReadOnlySpan<char> ICKKGHAPBPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x83471D0", Offset = "0x83459D0", VA = "0x1883471D0")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public ReadOnlySpan<char> PBNBPDCCDDF
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8346C50", Offset = "0x8345450", VA = "0x188346C50")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public PAMHNHJLMLE DOCCLMKOIFF
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xC575D0", Offset = "0xC55DD0", VA = "0x180C575D0")]
		get
		{
			return default(PAMHNHJLMLE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public double KIGJANBNFCD
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8347120", Offset = "0x8345920", VA = "0x188347120")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public float FMKNEMHAIOA
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8347110", Offset = "0x8345910", VA = "0x188347110")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float HGABGGJLIEN
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xC9E6B0", Offset = "0xC9CEB0", VA = "0x180C9E6B0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xCE1A20", Offset = "0xCE0220", VA = "0x180CE1A20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool MAPGHGCLANF
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x11A4EE0", Offset = "0x11A36E0", VA = "0x1811A4EE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x143EA80", Offset = "0x143D280", VA = "0x18143EA80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public AGGICKCJJAM JCBIIDIINHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA27530", Offset = "0xA25D30", VA = "0x180A27530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x83475E0", Offset = "0x8345DE0", VA = "0x1883475E0")]
	public LGFLELLAJOL(string IABPLCBPMIK, [Optional] MetricDescription FLJIFIGCALA, [Optional] AGGICKCJJAM IILNEBJHNFN, bool CBNPHPHGGGG = true, bool LLHLMAJJGOD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x8346B60", Offset = "0x8345360", VA = "0x188346B60")]
	public void AEMKMKLALOC(RawMetricPayload OLIEPBMBIEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8347360", Offset = "0x8345B60", VA = "0x188347360")]
	public bool PDNJEJKBAIL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8346D30", Offset = "0x8345530", VA = "0x188346D30")]
	public bool CCOHNONALDO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6DE62D0", Offset = "0x6DE4AD0", VA = "0x186DE62D0")]
	public void FEECKJKOOIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6DE62C0", Offset = "0x6DE4AC0", VA = "0x186DE62C0")]
	public void DLEFJCDFHMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x83472B0", Offset = "0x8345AB0", VA = "0x1883472B0")]
	private static int OHNBNFNGHCJ(MetricDataUnits JEAKKKEADAJ)
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

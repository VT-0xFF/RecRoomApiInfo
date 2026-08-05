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
	public class LogRegistrationIndex : GDJKPKDCEIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8746590", Offset = "0x8745390", VA = "0x188746590", Slot = "4")]
		public override void FAIIODDINIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
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
		private enum ADNFAMMKJOE
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
		private static readonly ALMLLDBPKBM IPEKLICENHF;

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
		private ADNFAMMKJOE NAODPFHJPDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private MetricIdLookup GPNEEAFDBAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private IRawMetricsPipeline CFAMDFBBAPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private IMetricCollectionRegistry MIABGBHLANH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private MetricCollectionToken CHJGDKMIPPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private KMGGGLJCGHP BCHILAKLIHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private AJAOCFGJOLD NFAPKMAHEBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private Material CPMCMACLEOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private int PPGOPMFLGAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private LayoutRect CIOOOBONNMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int KLACJDMCAHJ;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private const int KAHMJDBIBHI = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private HDILGAJBPGE LBOGAGHAAOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private bool CFMPHHAKAJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private Dictionary<MetricId, int> GJCMLBOFDBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private List<ICCDMIOGLND> KAMLHOKGNID;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private LMNCBCLLFHE MKHMIGOKNHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private List<LMNCBCLLFHE> OKCFKACGNJE;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public MeshBufferRenderer OCOIJMOFDAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x87486D0", Offset = "0x87474D0", VA = "0x1887486D0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x87488E0", Offset = "0x87476E0", VA = "0x1887488E0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8748880", Offset = "0x8747680", VA = "0x188748880")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x87476E0", Offset = "0x87464E0", VA = "0x1887476E0")]
		private void EPFPMFNENAG(bool HPHHJJMHCEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8748010", Offset = "0x8746E10", VA = "0x188748010")]
		private void KNEECFOOBIN(bool HPHHJJMHCEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8748990", Offset = "0x8747790", VA = "0x188748990")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8747A10", Offset = "0x8746810", VA = "0x188747A10")]
		public void InitMetricsDependencies(MetricIdLookup GPNEEAFDBAN, IRawMetricsPipeline CFAMDFBBAPM, IMetricCollectionRegistry MIABGBHLANH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8748910", Offset = "0x8747710", VA = "0x188748910")]
		public void SetActiveOverlay(HDILGAJBPGE BOMKJBACJMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8747B90", Offset = "0x8746990", VA = "0x188747B90")]
		private void JOGIKGKACLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8746620", Offset = "0x8745420", VA = "0x188746620")]
		private void AKMPCKBHIJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8746780", Offset = "0x8745580", VA = "0x188746780")]
		private void BDLKFKIKOAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8746BA0", Offset = "0x87459A0", VA = "0x188746BA0")]
		private void CPFKPODAEMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x87471F0", Offset = "0x8745FF0", VA = "0x1887471F0")]
		private bool DMKGHJELJIE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x87474A0", Offset = "0x87462A0", VA = "0x1887474A0")]
		private bool EDGMEPIMDOP(bool PPPGPLMAHNI = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x87483B0", Offset = "0x87471B0", VA = "0x1887483B0")]
		private bool OEIHEMIJJBP(BKKIHLNOJLJ MKPEOGPFEFH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8748590", Offset = "0x8747390", VA = "0x188748590")]
		private bool OIHBHPDFOJG(BKKIHLNOJLJ MKPEOGPFEFH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x87477D0", Offset = "0x87465D0", VA = "0x1887477D0")]
		public void HandleMetric([In] RawMetric COCONONBPDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8746B90", Offset = "0x8745990", VA = "0x188746B90")]
		private bool BGFEMOEICIB(ADNFAMMKJOE GODEBGJLCCH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8748390", Offset = "0x8747190", VA = "0x188748390")]
		private bool KNHCCPEFEJM(ADNFAMMKJOE DJEELEPNDMD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8748C50", Offset = "0x8747A50", VA = "0x188748C50")]
		public MetricHudDisplay()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8747A00", Offset = "0x8746800", VA = "0x188747A00", Slot = "4")]
		private void IJHFHECKLDF([In] RawMetric COCONONBPDD)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal class LMNCBCLLFHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private bool LMODLAEOJIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private LayoutRect LPLMHFLMNGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private TextSegmentLayout HPPFCKCIBGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private TextSegmentLayout FAHAEPHPKIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private TextSegmentLayout AFIIHGHLKEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private BIEFOGKONBN AGGHLIOEGDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private MetricGraphGraphic OGPLLAEHIHE;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8745FB0", Offset = "0x8744DB0", VA = "0x188745FB0")]
	public void MHDKBDCHLCM(KMGGGLJCGHP OJEMLMBNEEH, AJAOCFGJOLD NGJMLEHONHD, LayoutRect IPCOICLPACN, int FDOHFLCEALO, [Optional] MetricGraphGraphic OGPLLAEHIHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8745900", Offset = "0x8744700", VA = "0x188745900")]
	public void FNAFLDENJHA(float JFLGKNMNHEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8745E40", Offset = "0x8744C40", VA = "0x188745E40")]
	public void LKBHJDCHDKP(ReadOnlySpan<char> IMCEGOBMIDC, ReadOnlySpan<char> NJGHGDJBOIG, ReadOnlySpan<char> NCPBEDJGEOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8745B00", Offset = "0x8744900", VA = "0x188745B00")]
	public void IGGGOBFCEBM(RRColor32 BGBIPHDMBPB, bool ODMOLCKOHHK = true, bool AEEJCHDODIE = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8745500", Offset = "0x8744300", VA = "0x188745500")]
	public float EDMPBKIBKDE(float ANMACKGKCLJ, float AMCEFKEIKFN, float BAEJJDODKMD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8746520", Offset = "0x8745320", VA = "0x188746520")]
	public void NOFBCCDANLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8745E10", Offset = "0x8744C10", VA = "0x188745E10")]
	public void LGIGOCHHMNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8746570", Offset = "0x8745370", VA = "0x188746570")]
	public void OBPPKODBIGA(CNJJLBEFDNB NMOOEEHPACM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8746470", Offset = "0x8745270", VA = "0x188746470")]
	public void MKLPOLNCFPH(CNJJLBEFDNB NMOOEEHPACM, double KBAEKIALOKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8745A70", Offset = "0x8744870", VA = "0x188745A70")]
	public void HOJGFENLKKI(double HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8745C50", Offset = "0x8744A50", VA = "0x188745C50")]
	public void KFIKIPOKDFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public LMNCBCLLFHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class GHKHLBCOMCI
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static HDILGAJBPGE FPIEFCHAGAO;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static HDILGAJBPGE NPBHAMHKFKH;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static HDILGAJBPGE OAOKDAHIOJF;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static HDILGAJBPGE GLBAFJLFDCI;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static HDILGAJBPGE DNFLCOGHPBP;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static HDILGAJBPGE FFAFAAJACFO;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static HDILGAJBPGE HANIMDCJEMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x87429A0", Offset = "0x87417A0", VA = "0x1887429A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static HDILGAJBPGE NPHGJMNJKAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x87429F0", Offset = "0x87417F0", VA = "0x1887429F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static HDILGAJBPGE ADCELFKLJBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8742A40", Offset = "0x8741840", VA = "0x188742A40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static HDILGAJBPGE BBCECOAHEGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8742A90", Offset = "0x8741890", VA = "0x188742A90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static HDILGAJBPGE OICDFOLLFEL
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8742950", Offset = "0x8741750", VA = "0x188742950")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static HDILGAJBPGE IAOGFPDFJAE
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8742AE0", Offset = "0x87418E0", VA = "0x188742AE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public static HDILGAJBPGE AIOMEIOLIMM
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA96A00", Offset = "0xA95800", VA = "0x180A96A00")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct CIPLIIBODIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public string MFFMPILAEDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public string OEFICDIOHDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public string OFHKEKBJLKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public CNJJLBEFDNB DMPKLFPOIFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public bool KIHNJFNPNKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public bool HLCPBDCJFOC;
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class HDILGAJBPGE
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public string DGOKKDFBCOI
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public CIPLIIBODIM[] BELEMEGKDAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public virtual void MAJBPIPDBDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "5")]
	public virtual void EBMBCHNJMKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0xA9BCE0", Offset = "0xA9AAE0", VA = "0x180A9BCE0")]
	public HDILGAJBPGE(string GBBEGJGJHAK, CIPLIIBODIM[] JCLKNBDMPEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[Flags]
internal enum IHALFDMOPEE
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
internal class ICCDMIOGLND
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private IHALFDMOPEE HDNPGEOJDMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private MetricDescription GEMDNONCHEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private RawMetricPayload OBBABGHFJAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private EwmaFilter BAEPGHPHNKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private double IMHMGOBNENM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private int OLLHBMGAPGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private CNJJLBEFDNB NMOOEEHPACM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private PODDKNKAGKO FHGHKIPFJJH;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int PFEAPKBEMMI = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private char[] IMCEGOBMIDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private char[] NJGHGDJBOIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private int IJEPKHLKCMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private char[] NCPBEDJGEOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private int GOCJCJCGDOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private string EJMOLPDFJOB;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public MetricDescription JAPKJCOCHCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xEA0F90", Offset = "0xE9FD90", VA = "0x180EA0F90")]
		get
		{
			return default(MetricDescription);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8745170", Offset = "0x8743F70", VA = "0x188745170")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IHALFDMOPEE AGPFOEAPGLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xA94B20", Offset = "0xA93920", VA = "0x180A94B20")]
		get
		{
			return default(IHALFDMOPEE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public ReadOnlySpan<char> OKEEIJJCBCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x87452E0", Offset = "0x87440E0", VA = "0x1887452E0")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public ReadOnlySpan<char> LLHEEMLPKME
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8744D70", Offset = "0x8743B70", VA = "0x188744D70")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public ReadOnlySpan<char> MLIMKFDMAON
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x87447F0", Offset = "0x87435F0", VA = "0x1887447F0")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public PODDKNKAGKO KOFONFGPEDB
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xD4C240", Offset = "0xD4B040", VA = "0x180D4C240")]
		get
		{
			return default(PODDKNKAGKO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public double ACJHFJDNGFH
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8745140", Offset = "0x8743F40", VA = "0x188745140")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public float LOFLCNALPKP
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8745130", Offset = "0x8743F30", VA = "0x188745130")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float OIAHKJKCFGG
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xD80840", Offset = "0xD7F640", VA = "0x180D80840")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xDF0080", Offset = "0xDEEE80", VA = "0x180DF0080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool GGLOPJPFCBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x12FD860", Offset = "0x12FC660", VA = "0x1812FD860")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x1608700", Offset = "0x1607500", VA = "0x181608700")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public CNJJLBEFDNB DMPKLFPOIFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA931F0", Offset = "0xA91FF0", VA = "0x180A931F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8745340", Offset = "0x8744140", VA = "0x188745340")]
	public ICCDMIOGLND(string KCAHPOJKMFB, [Optional] MetricDescription GEMDNONCHEE, [Optional] CNJJLBEFDNB NMOOEEHPACM, bool EMGHEOPCNEH = true, bool KKMADNFDLCD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x87451F0", Offset = "0x8743FF0", VA = "0x1887451F0")]
	public void OLDBNIFFALB(RawMetricPayload MCIEBOKOJPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8744EA0", Offset = "0x8743CA0", VA = "0x188744EA0")]
	public bool KGPDGCMJNLL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x87448D0", Offset = "0x87436D0", VA = "0x1887448D0")]
	public bool DIFBJFJDNFB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x71320F0", Offset = "0x7130EF0", VA = "0x1871320F0")]
	public void MPLEMECOPON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x71320E0", Offset = "0x7130EE0", VA = "0x1871320E0")]
	public void KJDGEFNDIGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8744E50", Offset = "0x8743C50", VA = "0x188744E50")]
	private static int JBOIHECIENE(MetricDataUnits IMFPLECGDPA)
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

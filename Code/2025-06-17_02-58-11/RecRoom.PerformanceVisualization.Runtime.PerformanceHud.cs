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
	public class LogRegistrationIndex : GIIBELOIOJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x80F4EF0", Offset = "0x80F38F0", VA = "0x1880F4EF0", Slot = "4")]
		public override void EPIAMCEAEFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA34C70", Offset = "0xA33670", VA = "0x180A34C70")]
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
		private enum KCELPOOMIDJ
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
		private static readonly COJJKFBGGKB PMPMPCJHKKF;

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
		private KCELPOOMIDJ JIBNIIFBFHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private MetricIdLookup DAEFAGBLFNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private IRawMetricsPipeline EHKDNFJJMIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private IMetricCollectionRegistry CJENOEGCFJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private MetricCollectionToken GGGJCHHCDCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private AHAMHFKAOBC IPPNPKGKNJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private NPEBAPCENNP ANNJGODFJFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private Material LEAEOHGLIMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private int LBHKGKIBMEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private LayoutRect HMOEEJKMMND;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int IOEKIOMCOOB;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private const int GGOKDFFCHMK = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private MGNKHHHCMJN MBFKCBJNHPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private bool KDAIKOJMBLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private Dictionary<MetricId, int> ACEPMMEADEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private List<DKKEJFDPINJ> BACONJMNMDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private FMMKAJAJAMN AFHNIOHGKJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private List<FMMKAJAJAMN> ENHBFJOPIGH;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public MeshBufferRenderer NLFPIICGGFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x80F6D10", Offset = "0x80F5710", VA = "0x1880F6D10")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x80F6F20", Offset = "0x80F5920", VA = "0x1880F6F20")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x80F6EC0", Offset = "0x80F58C0", VA = "0x1880F6EC0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x80F6C20", Offset = "0x80F5620", VA = "0x1880F6C20")]
		private void NCIJIHDFKJL(bool MDKCANMNIAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x80F6F50", Offset = "0x80F5950", VA = "0x1880F6F50")]
		private void PKKFJOMDJIB(bool MDKCANMNIAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x80F7350", Offset = "0x80F5D50", VA = "0x1880F7350")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x80F6660", Offset = "0x80F5060", VA = "0x1880F6660")]
		public void InitMetricsDependencies(MetricIdLookup DAEFAGBLFNO, IRawMetricsPipeline EHKDNFJJMIK, IMetricCollectionRegistry CJENOEGCFJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x80F72D0", Offset = "0x80F5CD0", VA = "0x1880F72D0")]
		public void SetActiveOverlay(MGNKHHHCMJN IADHEJPDMDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x80F5BA0", Offset = "0x80F45A0", VA = "0x1880F5BA0")]
		private void FANCOJHDILF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x80F5770", Offset = "0x80F4170", VA = "0x1880F5770")]
		private void CKKNIHHKLBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x80F6250", Offset = "0x80F4C50", VA = "0x1880F6250")]
		private void INNLEGAIGNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x80F50C0", Offset = "0x80F3AC0", VA = "0x1880F50C0")]
		private void AHDKIOAGGDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x80F58D0", Offset = "0x80F42D0", VA = "0x1880F58D0")]
		private bool DEPDHNHFMJC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x80F69E0", Offset = "0x80F53E0", VA = "0x1880F69E0")]
		private bool LHLKHDJNKBO(bool BOOINJJDCOC = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x80F67F0", Offset = "0x80F51F0", VA = "0x1880F67F0")]
		private bool KKEJKPICFIJ(EALDJNGEMBA CHCCOOMJKLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x80F4F80", Offset = "0x80F3980", VA = "0x1880F4F80")]
		private bool AAAAPGFGDEH(EALDJNGEMBA CHCCOOMJKLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x80F6020", Offset = "0x80F4A20", VA = "0x1880F6020")]
		public void HandleMetric([In] RawMetric BAMCEPICIIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x80F67E0", Offset = "0x80F51E0", VA = "0x1880F67E0")]
		private bool KAMFBMNEMLP(KCELPOOMIDJ HJJCNDPPHPD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x80F5B80", Offset = "0x80F4580", VA = "0x1880F5B80")]
		private bool EHBBACOFEFN(KCELPOOMIDJ HHIFHECKPPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x80F7610", Offset = "0x80F6010", VA = "0x1880F7610")]
		public MetricHudDisplay()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x80F69D0", Offset = "0x80F53D0", VA = "0x1880F69D0", Slot = "4")]
		private void LBOEFHFEPEN([In] RawMetric BAMCEPICIIO)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal class FMMKAJAJAMN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private bool NNFHKPDGPMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private LayoutRect FJCCNFOIJDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private TextSegmentLayout MBCPFGCILJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private TextSegmentLayout JENLIACIKHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private TextSegmentLayout INCPIHPFHLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private PPDIDBEFKEI GPLBJANDBLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private MetricGraphGraphic PEEFAHBGHAA;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x80F28F0", Offset = "0x80F12F0", VA = "0x1880F28F0")]
	public void JBAOHJPBOCM(AHAMHFKAOBC ADKKDPCKBDK, NPEBAPCENNP NHMIJKKEICB, LayoutRect CJJMGPKDMNE, int LOLBPDPOPJN, [Optional] MetricGraphGraphic PEEFAHBGHAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x80F2E20", Offset = "0x80F1820", VA = "0x1880F2E20")]
	public void MDAOAEPNEKJ(float BLMIOBOBEDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x80F2350", Offset = "0x80F0D50", VA = "0x1880F2350")]
	public void EAPGMIIEAHL(ReadOnlySpan<char> MPDKLFDLAPN, ReadOnlySpan<char> GAFCHKHJJBD, ReadOnlySpan<char> AKPICDJFIEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x80F2200", Offset = "0x80F0C00", VA = "0x1880F2200")]
	public void DONCJJDEPDD(RRColor32 JJNDBAIEAAG, bool ANAJCBKPAAL = true, bool JPINOKAFKJM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x80F24C0", Offset = "0x80F0EC0", VA = "0x1880F24C0")]
	public float HKFNNBCPAJJ(float KFJIKJJNMGN, float LOHLBMGABFO, float AJLPBLPCBFL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x80F2DD0", Offset = "0x80F17D0", VA = "0x1880F2DD0")]
	public void MBPMJJINLBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x80F28C0", Offset = "0x80F12C0", VA = "0x1880F28C0")]
	public void HOABPELMBEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x80F2DB0", Offset = "0x80F17B0", VA = "0x1880F2DB0")]
	public void JNOJOMFAOIJ(FIIBEOFDEKE MENIENKNGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x80F2F90", Offset = "0x80F1990", VA = "0x1880F2F90")]
	public void OGGOMGHMACE(FIIBEOFDEKE MENIENKNGNA, double JAHHKOMJJAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x80F1F50", Offset = "0x80F0950", VA = "0x1880F1F50")]
	public void DGHKAJDFPLI(double PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x80F1FE0", Offset = "0x80F09E0", VA = "0x1880F1FE0")]
	public void DLJIAJAKIEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public FMMKAJAJAMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class LBHHPEBKLAN
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static MGNKHHHCMJN JAJIBEHOLBI;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static MGNKHHHCMJN PDJJFFOEJJC;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static MGNKHHHCMJN INFLOBFIIFB;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static MGNKHHHCMJN GMAAKPMMDKJ;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static MGNKHHHCMJN PMNBJMKACCD;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static MGNKHHHCMJN EAPEHCJDKHI;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static MGNKHHHCMJN MCHDAMDLAPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x80F3090", Offset = "0x80F1A90", VA = "0x1880F3090")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static MGNKHHHCMJN MIKOMMJCLGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x80F3130", Offset = "0x80F1B30", VA = "0x1880F3130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static MGNKHHHCMJN IDPPLDMPOIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x80F3180", Offset = "0x80F1B80", VA = "0x1880F3180")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static MGNKHHHCMJN NLAMMECICFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x80F31D0", Offset = "0x80F1BD0", VA = "0x1880F31D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static MGNKHHHCMJN GOOAEMMLLEH
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x80F3040", Offset = "0x80F1A40", VA = "0x1880F3040")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static MGNKHHHCMJN IKPAHPCNPNC
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x80F30E0", Offset = "0x80F1AE0", VA = "0x1880F30E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public static MGNKHHHCMJN IDOBFMENFBF
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4C0", Offset = "0xA0AEC0", VA = "0x180A0C4C0")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct PLHANIBCFCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public string KNIMLBJCBLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public string FNBHFMEEOFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public string DINJNGGEMOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public FIIBEOFDEKE PLFJEGEMFEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public bool GEHPAFJMOHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public bool JCDFBLBJBPO;
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class MGNKHHHCMJN
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public string KKEPOPAPFDG
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA0A560", Offset = "0xA08F60", VA = "0x180A0A560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA0A7A0", Offset = "0xA091A0", VA = "0x180A0A7A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public PLHANIBCFCJ[] ALJNLMCFKDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA0A7B0", Offset = "0xA091B0", VA = "0x180A0A7B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "4")]
	public virtual void HMMJIBIDKGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "5")]
	public virtual void ANJBHCONJBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0xA143A0", Offset = "0xA12DA0", VA = "0x180A143A0")]
	public MGNKHHHCMJN(string EEOCHCICMNA, PLHANIBCFCJ[] OGIMOJIAMMI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[Flags]
internal enum ICLJPHKMAMO
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
internal class DKKEJFDPINJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private ICLJPHKMAMO JGPDDHJEMJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private MetricDescription LPNHLNCHGCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private RawMetricPayload MGDBGDNLMCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private EwmaFilter IKEBDILJILA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private double JFMEMIINGHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private int HJIMOMNKEGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private FIIBEOFDEKE MENIENKNGNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private NGMKEKDGDLJ FHONHHMGCHF;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int JAFGFBDMHHM = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private char[] MPDKLFDLAPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private char[] GAFCHKHJJBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private int MJKOFCOIKFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private char[] AKPICDJFIEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private int FNKDBAMFENN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private string FHJHDFOBPAI;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public MetricDescription GEMGMKENGHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xDC95B0", Offset = "0xDC7FB0", VA = "0x180DC95B0")]
		get
		{
			return default(MetricDescription);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x80F1590", Offset = "0x80EFF90", VA = "0x1880F1590")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public ICLJPHKMAMO HDLEGJCDHFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xA09240", Offset = "0xA07C40", VA = "0x180A09240")]
		get
		{
			return default(ICLJPHKMAMO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public ReadOnlySpan<char> CDKCAIEAMLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x80F1420", Offset = "0x80EFE20", VA = "0x1880F1420")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public ReadOnlySpan<char> OJJNHPKMIGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x80F1480", Offset = "0x80EFE80", VA = "0x1880F1480")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public ReadOnlySpan<char> NLBFPNCNPCI
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x80F1240", Offset = "0x80EFC40", VA = "0x1880F1240")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public NGMKEKDGDLJ DCDMJFBBPJN
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xC62C40", Offset = "0xC61640", VA = "0x180C62C40")]
		get
		{
			return default(NGMKEKDGDLJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public double IDMBCGGOEOB
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x80F1560", Offset = "0x80EFF60", VA = "0x1880F1560")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public float LBCAJPOBPPF
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x80F1410", Offset = "0x80EFE10", VA = "0x1880F1410")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float EPDHLHNONOG
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xCA95B0", Offset = "0xCA7FB0", VA = "0x180CA95B0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xCF0BC0", Offset = "0xCEF5C0", VA = "0x180CF0BC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool ILIONGGDINI
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x11BEB10", Offset = "0x11BD510", VA = "0x1811BEB10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x14ACA70", Offset = "0x14AB470", VA = "0x1814ACA70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public FIIBEOFDEKE PLFJEGEMFEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA10550", Offset = "0xA0EF50", VA = "0x180A10550")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x80F1D90", Offset = "0x80F0790", VA = "0x1880F1D90")]
	public DKKEJFDPINJ(string DCBDCJILPIG, [Optional] MetricDescription LPNHLNCHGCJ, [Optional] FIIBEOFDEKE MENIENKNGNA, bool BNOOHNDABBL = true, bool HMMFCCJDHOB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x80F1320", Offset = "0x80EFD20", VA = "0x1880F1320")]
	public void GLNEPCLDPNJ(RawMetricPayload EJJOILLMHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x80F1660", Offset = "0x80F0060", VA = "0x1880F1660")]
	public bool PCIDMDEOAMG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x80F18F0", Offset = "0x80F02F0", VA = "0x1880F18F0")]
	public bool PJHBPHHMAMA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6B59FE0", Offset = "0x6B589E0", VA = "0x186B59FE0")]
	public void JGJBFIAKNBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6B59FD0", Offset = "0x6B589D0", VA = "0x186B59FD0")]
	public void HDGGHOBBHBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x80F1610", Offset = "0x80F0010", VA = "0x1880F1610")]
	private static int MFMEDJJNPBC(MetricDataUnits IHNBFLOAEDF)
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

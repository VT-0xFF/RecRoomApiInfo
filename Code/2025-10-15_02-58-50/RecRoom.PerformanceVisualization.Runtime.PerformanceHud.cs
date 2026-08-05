using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.FastMesh;
using RecRoom.FastMesh.Core;
using RecRoom.FastMesh.Rendering;
using RecRoom.FastText;
using RecRoom.FastText.Layout;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using RecRoom.Metrics;
using RecRoom.Metrics.Pipeline;
using RecRoom.Metrics.Pipeline.MetricInfo;
using RecRoom.NoEngine.DataStructures;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_PerformanceVisualization_Runtime_PerformanceHud
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x885EFB0", Offset = "0x885DDB0", VA = "0x18885EFB0", Slot = "4")]
		public override void IPFDCTVTWHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAC7BE0", Offset = "0xAC69E0", VA = "0x180AC7BE0")]
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
		private enum InitState
		{
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			RenderDependenciesInit = 1,
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			MetricDependenciesInit = 2,
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			AllDependenciesInit = 3,
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			OverlayInit = 4,
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			MetricStatesInit = 8,
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			LayoutStatesInit = 0x10,
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			AllStatesInit = 0x1C,
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			AllInit = 0x1F
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private static class PFZTYIFIBTZ
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8865040", Offset = "0x8863E40", VA = "0x188865040")]
			internal static ReadOnlySpan<char> Get(PerformanceBottleneck bottleneck)
			{
				return default(ReadOnlySpan<char>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly Log YLLVKVFSHML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private MeshBufferRenderer meshBufferRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[SerializeField]
		private RectTransform renderAreaRectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[SerializeField]
		private Material glyphMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[SerializeField]
		private GlyphMapAsset glyphMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[SerializeField]
		private int fontSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		private int maxLines;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		private float lineHeightFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[SerializeField]
		private Material graphMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[SerializeField]
		private MetricGraphGraphic[] metricGraphs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private InitState PYROPVYSJZM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private MetricIdLookup GVUCDMSXDCY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private IRawMetricsPipeline GEBOCWZQYBU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private IMetricCollectionRegistry DFOHZPGORKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private MetricCollectionToken RZGFBYKFGYF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private TextSegmentManager QLUPGEVAXAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private QuadMeshManager MRRAJLBJQSP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private Material HZCFOPUVLVQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private int VDDIQHGMGYK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private LayoutRect AKCMSBSDIQW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int IKXIGJBQSSV;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private const int UCDXBMTYHSW = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private AQSXJZCVYFH NAKIKVBAUBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private bool TOLHZFRFLQX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private Dictionary<MetricId, int> BQVFCNAIMCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private List<UNZTRNTFCKC> PNSWSELVCZF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private NMYGPBOVZBU UHMYNRRSLJS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private List<NMYGPBOVZBU> EQVBYTYJNHZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private PerformanceBottleneck VNYGORMCFBC;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public MeshBufferRenderer VDKYGEMHUQD
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xAA45D0", Offset = "0xAA33D0", VA = "0x180AA45D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8860120", Offset = "0x885EF20", VA = "0x188860120")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8860330", Offset = "0x885F130", VA = "0x188860330")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x88602D0", Offset = "0x885F0D0", VA = "0x1888602D0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8861160", Offset = "0x885FF60", VA = "0x188861160")]
		private void XIHGGKLWFFW(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8860780", Offset = "0x885F580", VA = "0x188860780")]
		private void UCGZSNJLGQE(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8860F10", Offset = "0x885FD10", VA = "0x188860F10")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x885F6E0", Offset = "0x885E4E0", VA = "0x18885F6E0")]
		public void InitMetricsDependencies(MetricIdLookup metricIdLookup, IRawMetricsPipeline metricsPipeline, IMetricCollectionRegistry metricsRegistry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x88605A0", Offset = "0x885F3A0", VA = "0x1888605A0")]
		public void SetActiveOverlay(AQSXJZCVYFH overlay)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x885F030", Offset = "0x885DE30", VA = "0x18885F030")]
		private void FISCAFODYDU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8860620", Offset = "0x885F420", VA = "0x188860620")]
		private void TXSVISLSKCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x885F840", Offset = "0x885E640", VA = "0x18885F840")]
		private void MGKQPPXDJJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8861250", Offset = "0x8860050", VA = "0x188861250")]
		private void XLAFDXOFPLT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x885FE50", Offset = "0x885EC50", VA = "0x18885FE50")]
		private bool OUQAAKCIBAH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8860B20", Offset = "0x885F920", VA = "0x188860B20")]
		private bool UCWLOSVVYXD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8860360", Offset = "0x885F160", VA = "0x188860360")]
		private bool PSCDKAIYBJZ(bool a = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x885FC70", Offset = "0x885EA70", VA = "0x18885FC70")]
		private bool ODPSPBUDKLU(JKGOXHCGXDS a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8860DD0", Offset = "0x885FBD0", VA = "0x188860DD0")]
		private bool UEMWFFMMKTR(JKGOXHCGXDS a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x885F4B0", Offset = "0x885E2B0", VA = "0x18885F4B0")]
		public void HandleMetric([In] RawMetric metricMessage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x885FC60", Offset = "0x885EA60", VA = "0x18885FC60")]
		private bool MGXVQRXYSJL(InitState a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x885F490", Offset = "0x885E290", VA = "0x18885F490")]
		private bool GAKQDAZOTUJ(InitState a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8861A10", Offset = "0x8860810", VA = "0x188861A10")]
		public MetricHudDisplay()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x885F830", Offset = "0x885E630", VA = "0x18885F830", Slot = "4")]
		private void LXGUGOFSNBP([In] RawMetric metricMessage)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal class NMYGPBOVZBU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private bool IJZKDZJMEZD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private LayoutRect BIULILPLWAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TextSegmentLayout BMLVWAWXQSB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TextSegmentLayout OKPSSCJQBLY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private TextSegmentLayout YGISHGTYXZO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private OODCKMWVTWG ICGKQGXSMER;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private MetricGraphGraphic MLZSEDQIMEJ;

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8864A40", Offset = "0x8863840", VA = "0x188864A40")]
		public void YXKPQQSUPQN(TextSegmentManager a, QuadMeshManager b, LayoutRect c, int d, [Optional] MetricGraphGraphic e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8864ED0", Offset = "0x8863CD0", VA = "0x188864ED0")]
		public void ZWBEAIPEYDT(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8864820", Offset = "0x8863620", VA = "0x188864820")]
		public void WGTZBVOGRCG(ReadOnlySpan<char> a, ReadOnlySpan<char> b, ReadOnlySpan<char> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8864640", Offset = "0x8863440", VA = "0x188864640")]
		public void OXWLUFWABFL(RRColor32 a, bool b = true, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8864260", Offset = "0x8863060", VA = "0x188864260")]
		public float MLGIRLAJXXX(float a, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8863FD0", Offset = "0x8862DD0", VA = "0x188863FD0")]
		public void AJEDZALNZST()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8864EA0", Offset = "0x8863CA0", VA = "0x188864EA0")]
		public void ZAMBEDPILXJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8864240", Offset = "0x8863040", VA = "0x188864240")]
		public void DMSBNIXYXJM(LCOYJETZVLU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8864990", Offset = "0x8863790", VA = "0x188864990")]
		public void WJCJGEOLPEF(LCOYJETZVLU a, double b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8864790", Offset = "0x8863590", VA = "0x188864790")]
		public void PZGUTXOCWNY(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8864020", Offset = "0x8862E20", VA = "0x188864020")]
		public void Cleanup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public NMYGPBOVZBU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class NFIYHDXFVGC
	{
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static AQSXJZCVYFH AWQMYIEWHTD;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static AQSXJZCVYFH KUHTDHAZFZT;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static AQSXJZCVYFH EVFWONXBJUV;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static AQSXJZCVYFH NWBUSUAKBAZ;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static AQSXJZCVYFH DHIOXIRYUMQ;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static AQSXJZCVYFH YAAPAFRKDAI;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static AQSXJZCVYFH SNTFEPMFQUI
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x8861C10", Offset = "0x8860A10", VA = "0x188861C10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static AQSXJZCVYFH WUHNSBSXWFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x8861D00", Offset = "0x8860B00", VA = "0x188861D00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static AQSXJZCVYFH NGMXPHDJBAY
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x8861CB0", Offset = "0x8860AB0", VA = "0x188861CB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static AQSXJZCVYFH IWFVXGMMAMQ
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8861C60", Offset = "0x8860A60", VA = "0x188861C60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static AQSXJZCVYFH LEJAUFUSAJN
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x8861BC0", Offset = "0x88609C0", VA = "0x188861BC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static AQSXJZCVYFH BSBHKKHPFXR
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x8861D50", Offset = "0x8860B50", VA = "0x188861D50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static AQSXJZCVYFH GVDBYCTTMHO
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xA9E190", Offset = "0xA9CF90", VA = "0x180A9E190")]
			get
			{
				return null;
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct MetricDisplay
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public string Label;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public string MetricSourceName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public string MetricName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public LCOYJETZVLU Threshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public bool Graph;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public bool DisableStats;
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class AQSXJZCVYFH
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string TWTXKLSHBWP
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BE0", Offset = "0xA9F9E0", VA = "0x180AA0BE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xAA0FA0", Offset = "0xA9FDA0", VA = "0x180AA0FA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public MetricDisplay[] MBEFOQHVZMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BC0", Offset = "0xA9F9C0", VA = "0x180AA0BC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "4")]
		public virtual void Activate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "5")]
		public virtual void JBBNSDEDKEV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xAA5770", Offset = "0xAA4570", VA = "0x180AA5770")]
		public AQSXJZCVYFH(string a, MetricDisplay[] b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[Flags]
	internal enum MetricTextDirtyState
	{
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		Clean = 0,
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		MetricUpdated = 1,
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		MetricDirty = 2,
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		TextDirty = 4,
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		AllDirty = 6
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	internal class UNZTRNTFCKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private MetricTextDirtyState EUCWVTLRNUS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private MetricDescription WJVVRZCMWEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private RawMetricPayload RDMMVZXUKST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private EwmaFilter LXGHUTUENGS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private double VOQEENZADUB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private int BTHCUHOVYSB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private LCOYJETZVLU HUMTCLCIFYG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private ThresholdResult ZGYMRIBNELN;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private const int ZGGAUMLEOFE = 16;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private char[] WOEEYOBLLJW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private char[] KKOVWIYCKQB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private int TZEKAACYLNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private char[] FVDSTMNYGOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private int WTDMHXERWIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private string CEAIYNGVAMM;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public MetricDescription WORIFPLYPPV
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xF29BE0", Offset = "0xF289E0", VA = "0x180F29BE0")]
			get
			{
				return default(MetricDescription);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8865B40", Offset = "0x8864940", VA = "0x188865B40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public MetricTextDirtyState ZEZZVWMRPWG
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xA9ED10", Offset = "0xA9DB10", VA = "0x180A9ED10")]
			get
			{
				return default(MetricTextDirtyState);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public ReadOnlySpan<char> OMHMXGPGIJK
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x8865BC0", Offset = "0x88649C0", VA = "0x188865BC0")]
			get
			{
				return default(ReadOnlySpan<char>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public ReadOnlySpan<char> EGEWTILQDDP
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x8865240", Offset = "0x8864040", VA = "0x188865240")]
			get
			{
				return default(ReadOnlySpan<char>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public ReadOnlySpan<char> XDHBQGOEKDB
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x8865150", Offset = "0x8863F50", VA = "0x188865150")]
			get
			{
				return default(ReadOnlySpan<char>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public ThresholdResult TDKGTRLEAHN
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xC44D30", Offset = "0xC43B30", VA = "0x180C44D30")]
			get
			{
				return default(ThresholdResult);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public double KSTEQXXQCIM
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x8865210", Offset = "0x8864010", VA = "0x188865210")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public float MAAVIKFYKQK
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x88659F0", Offset = "0x88647F0", VA = "0x1888659F0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float JREGGRCEQLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xE0A9E0", Offset = "0xE097E0", VA = "0x180E0A9E0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xE553C0", Offset = "0xE541C0", VA = "0x180E553C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool ALIGJYVTBGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x1389BA0", Offset = "0x13889A0", VA = "0x181389BA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x16B2340", Offset = "0x16B1140", VA = "0x1816B2340")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public LCOYJETZVLU LYLASWPSAPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xAA1950", Offset = "0xAA0750", VA = "0x180AA1950")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8865C20", Offset = "0x8864A20", VA = "0x188865C20")]
		public UNZTRNTFCKC(string a, [Optional] MetricDescription b, [Optional] LCOYJETZVLU c, bool d = true, bool e = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8865A50", Offset = "0x8864850", VA = "0x188865A50")]
		public void TCTVWCSUWSO(RawMetricPayload a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8865760", Offset = "0x8864560", VA = "0x188865760")]
		public bool MVGWOGQMILT()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8865300", Offset = "0x8864100", VA = "0x188865300")]
		public bool KJPCTDHFNNO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x72DDBE0", Offset = "0x72DC9E0", VA = "0x1872DDBE0")]
		public void ZHDKBBBZTXT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x72DDBD0", Offset = "0x72DC9D0", VA = "0x1872DDBD0")]
		public void NLOGKQZXQON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8865A00", Offset = "0x8864800", VA = "0x188865A00")]
		private static int SWJIEXGHECX(MetricDataUnits a)
		{
			return default(int);
		}
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

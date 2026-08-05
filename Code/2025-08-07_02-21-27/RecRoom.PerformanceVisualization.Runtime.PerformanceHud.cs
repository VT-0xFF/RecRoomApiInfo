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
		[Cpp2IlInjected.Address(RVA = "0x8E2E000", Offset = "0x8E2CC00", VA = "0x188E2E000", Slot = "4")]
		public override void Register()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
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
		private static class UYPWXFYVBGN
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8E31CE0", Offset = "0x8E308E0", VA = "0x188E31CE0")]
			internal static ReadOnlySpan<char> Get(PerformanceBottleneck bottleneck)
			{
				return default(ReadOnlySpan<char>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly Log DNBXSEXRPWR;

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
		private InitState VFVNOTETPGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private MetricIdLookup MJPVBXZAKOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private IRawMetricsPipeline TIINHSOUCWM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private IMetricCollectionRegistry NLIINJALWPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private MetricCollectionToken RBIXKDVTXLR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private TextSegmentManager AJIXKDVVFEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private QuadMeshManager HLGOZEWJBNX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private Material FIQXRVHLRUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private int RHTGIXNBSJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private LayoutRect CEOGIOLJAFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int KJUPHXITLXV;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private const int DMNAHACDSAY = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private IVOPXZQMXQL HVNUMYBJFTL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private bool EGNQQQQHUVX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private Dictionary<MetricId, int> PIGPJSXSADW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private List<PHCLWMVCKTC> MFLONANSQTD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private ZKOSBJESEKI UQSPSRNJCJQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private List<ZKOSBJESEKI> BSFTQPLBJVP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private PerformanceBottleneck ZGJTGIARBSG;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public MeshBufferRenderer UTJQTLTPHTL
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8E2FFE0", Offset = "0x8E2EBE0", VA = "0x188E2FFE0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8E301F0", Offset = "0x8E2EDF0", VA = "0x188E301F0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8E30190", Offset = "0x8E2ED90", VA = "0x188E30190")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8E2EFC0", Offset = "0x8E2DBC0", VA = "0x188E2EFC0")]
		private void GZNBYWNUQUC(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8E2F2E0", Offset = "0x8E2DEE0", VA = "0x188E2F2E0")]
		private void IVTDBVOWWCK(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8E30830", Offset = "0x8E2F430", VA = "0x188E30830")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8E2F660", Offset = "0x8E2E260", VA = "0x188E2F660")]
		public void InitMetricsDependencies(MetricIdLookup metricIdLookup, IRawMetricsPipeline metricsPipeline, IMetricCollectionRegistry metricsRegistry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8E30480", Offset = "0x8E2F080", VA = "0x188E30480")]
		public void SetActiveOverlay(IVOPXZQMXQL overlay)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8E2E450", Offset = "0x8E2D050", VA = "0x188E2E450")]
		private void DCXSZHTNXTK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8E2E2F0", Offset = "0x8E2CEF0", VA = "0x188E2E2F0")]
		private void ASECOZBYNJT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8E2F930", Offset = "0x8E2E530", VA = "0x188E2F930")]
		private void LEHLSWSCAXN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8E2E8B0", Offset = "0x8E2D4B0", VA = "0x188E2E8B0")]
		private void EBZIGQGOOYD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8E2E080", Offset = "0x8E2CC80", VA = "0x188E2E080")]
		private bool AGJRSQPSIHP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8E30A80", Offset = "0x8E2F680", VA = "0x188E30A80")]
		private bool WCWCLFAEXDB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8E30240", Offset = "0x8E2EE40", VA = "0x188E30240")]
		private bool QWSLVTKIENX(bool a = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8E30650", Offset = "0x8E2F250", VA = "0x188E30650")]
		private bool TLFAXERDFII(IGUCKTFSKHM a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8E2FEA0", Offset = "0x8E2EAA0", VA = "0x188E2FEA0")]
		private bool MYQUHBJFVFD(IGUCKTFSKHM a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8E2F0B0", Offset = "0x8E2DCB0", VA = "0x188E2F0B0")]
		public void HandleMetric([In] RawMetric metricMessage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8E2E2E0", Offset = "0x8E2CEE0", VA = "0x188E2E2E0")]
		private bool AQGEUGTOTFF(InitState a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8E30220", Offset = "0x8E2EE20", VA = "0x188E30220")]
		private bool QCZRDFAYBML(InitState a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8E30DA0", Offset = "0x8E2F9A0", VA = "0x188E30DA0")]
		public MetricHudDisplay()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8E2FE90", Offset = "0x8E2EA90", VA = "0x188E2FE90", Slot = "4")]
		private void MPZDFVTEQZN([In] RawMetric metricMessage)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal class ZKOSBJESEKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private bool SLLWNOHFWGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private LayoutRect UTPQZEBGWNW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private TextSegmentLayout DSWJISYGDPV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TextSegmentLayout DKAXADUDFSE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private TextSegmentLayout KMWWJTQSQMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private BMJGALVZZAM QJMOQJUOTTN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private MetricGraphGraphic IJNNOYHXDUX;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8E324B0", Offset = "0x8E310B0", VA = "0x188E324B0")]
		public void HRTIXRMSTIX(TextSegmentManager a, QuadMeshManager b, LayoutRect c, int d, [Optional] MetricGraphGraphic e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8E32930", Offset = "0x8E31530", VA = "0x188E32930")]
		public void JSETFKRHASH(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8E32CF0", Offset = "0x8E318F0", VA = "0x188E32CF0")]
		public void WBHHBGORYBS(ReadOnlySpan<char> a, ReadOnlySpan<char> b, ReadOnlySpan<char> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8E32AA0", Offset = "0x8E316A0", VA = "0x188E32AA0")]
		public void QHASJWHHTHR(RRColor32 a, bool b = true, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8E31DF0", Offset = "0x8E309F0", VA = "0x188E31DF0")]
		public float BLRDOQHXEFZ(float a, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8E32CA0", Offset = "0x8E318A0", VA = "0x188E32CA0")]
		public void URRRMQWSHLX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8E32480", Offset = "0x8E31080", VA = "0x188E32480")]
		public void HALJDYEXGUR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8E32910", Offset = "0x8E31510", VA = "0x188E32910")]
		public void JAJJOELIBDS(VNNAWQVASPG a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8E32BF0", Offset = "0x8E317F0", VA = "0x188E32BF0")]
		public void RAFPSFDOLXZ(VNNAWQVASPG a, double b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8E323F0", Offset = "0x8E30FF0", VA = "0x188E323F0")]
		public void GEMEGMSZGKA(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8E321D0", Offset = "0x8E30DD0", VA = "0x188E321D0")]
		public void Cleanup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public ZKOSBJESEKI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class KLXKSFMGTSM
	{
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static IVOPXZQMXQL LYOLSVGCPBV;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static IVOPXZQMXQL EERSRIHWJKT;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static IVOPXZQMXQL EPMRVFNDYVJ;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static IVOPXZQMXQL SDGXLGRYYOP;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static IVOPXZQMXQL IIUOVHBCFAS;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static IVOPXZQMXQL EEZCUOZGEEG;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static IVOPXZQMXQL ERMGBLVPTJQ
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x8E2BBF0", Offset = "0x8E2A7F0", VA = "0x188E2BBF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static IVOPXZQMXQL EJQKBKSINIK
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x8E2BCE0", Offset = "0x8E2A8E0", VA = "0x188E2BCE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static IVOPXZQMXQL XWJGHGMVRKG
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x8E2BC90", Offset = "0x8E2A890", VA = "0x188E2BC90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static IVOPXZQMXQL FZLWGKNHECS
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x8E2BD80", Offset = "0x8E2A980", VA = "0x188E2BD80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static IVOPXZQMXQL IRWJEQAEZQR
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8E2BC40", Offset = "0x8E2A840", VA = "0x188E2BC40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static IVOPXZQMXQL UPEOLCNRPFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x8E2BD30", Offset = "0x8E2A930", VA = "0x188E2BD30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static IVOPXZQMXQL NATIUESBWVY
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xB16800", Offset = "0xB15400", VA = "0x180B16800")]
			get
			{
				return null;
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct MetricDisplay
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public string Label;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public string MetricSourceName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public string MetricName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public VNNAWQVASPG Threshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public bool Graph;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public bool DisableStats;
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class IVOPXZQMXQL
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string GYODOTBOHOR
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xB13340", Offset = "0xB11F40", VA = "0x180B13340")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public MetricDisplay[] TZXRDUYBLQS
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xB13A60", Offset = "0xB12660", VA = "0x180B13A60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "4")]
		public virtual void Activate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "5")]
		public virtual void PVDJVIMFIZR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xB1A040", Offset = "0xB18C40", VA = "0x180B1A040")]
		public IVOPXZQMXQL(string a, MetricDisplay[] b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[Flags]
	internal enum MetricTextDirtyState
	{
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		Clean = 0,
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		MetricUpdated = 1,
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		MetricDirty = 2,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		TextDirty = 4,
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		AllDirty = 6
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal class PHCLWMVCKTC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private MetricTextDirtyState DRGTRGNDVYA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private MetricDescription QNHGYFPRXDT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private RawMetricPayload KSSBTTCLKAV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private EwmaFilter VFKKHYGELZG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private double CVNYUQKKYHZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private int PCKQJYBRHOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private VNNAWQVASPG KORIHEEPHIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private ThresholdResult KNQWMLGIMEZ;

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private const int FILZUFNFHXW = 16;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private char[] SNAYDBYAMQC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private char[] NRROPPGCIYX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private int ANHQAYCKWRY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private char[] HPGKFYHGAGV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private int MTSAFZYGNIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private string JCRMRLHZNHU;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public MetricDescription KHSTSQWOABL
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xF343E0", Offset = "0xF32FE0", VA = "0x180F343E0")]
			get
			{
				return default(MetricDescription);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x8E30F50", Offset = "0x8E2FB50", VA = "0x188E30F50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public MetricTextDirtyState JXLNHNEEJFG
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xB1D780", Offset = "0xB1C380", VA = "0x180B1D780")]
			get
			{
				return default(MetricTextDirtyState);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public ReadOnlySpan<char> CMCOSXDJTTA
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x8E31800", Offset = "0x8E30400", VA = "0x188E31800")]
			get
			{
				return default(ReadOnlySpan<char>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public ReadOnlySpan<char> QBWQVAHYZNR
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x8E31960", Offset = "0x8E30560", VA = "0x188E31960")]
			get
			{
				return default(ReadOnlySpan<char>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public ReadOnlySpan<char> XHMFWHYZFLX
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x8E316F0", Offset = "0x8E302F0", VA = "0x188E316F0")]
			get
			{
				return default(ReadOnlySpan<char>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public ThresholdResult SGTRUPAXHBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xB6E220", Offset = "0xB6CE20", VA = "0x180B6E220")]
			get
			{
				return default(ThresholdResult);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public double SDYBDYZNMCS
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x8E31430", Offset = "0x8E30030", VA = "0x188E31430")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public float LJODBENXXEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x8E31950", Offset = "0x8E30550", VA = "0x188E31950")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float CQSUNZXCKHZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xDF1180", Offset = "0xDEFD80", VA = "0x180DF1180")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xE807A0", Offset = "0xE7F3A0", VA = "0x180E807A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool DWITFFSRVBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x13E8500", Offset = "0x13E7100", VA = "0x1813E8500")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x1731A20", Offset = "0x1730620", VA = "0x181731A20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public VNNAWQVASPG OSPPXPRZBZC
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xB13180", Offset = "0xB11D80", VA = "0x180B13180")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8E31A20", Offset = "0x8E30620", VA = "0x188E31A20")]
		public PHCLWMVCKTC(string a, [Optional] MetricDescription b, [Optional] VNNAWQVASPG c, bool d = true, bool e = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8E31860", Offset = "0x8E30460", VA = "0x188E31860")]
		public void RUCMTKZMZXW(RawMetricPayload a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8E31460", Offset = "0x8E30060", VA = "0x188E31460")]
		public bool LMPFYIVBEUX()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8E30FD0", Offset = "0x8E2FBD0", VA = "0x188E30FD0")]
		public bool IJWMXEBATNQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x786FA70", Offset = "0x786E670", VA = "0x18786FA70")]
		public void WNCGYVCKMLZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x786FA60", Offset = "0x786E660", VA = "0x18786FA60")]
		public void AYFTVYNFGPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8E317B0", Offset = "0x8E303B0", VA = "0x188E317B0")]
		private static int PZLOREUIPMB(MetricDataUnits a)
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

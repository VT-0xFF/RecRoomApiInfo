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
		[Cpp2IlInjected.Address(RVA = "0x896ACA0", Offset = "0x8969AA0", VA = "0x18896ACA0", Slot = "4")]
		public override void PUOFOOQAOVA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAE81C0", Offset = "0xAE6FC0", VA = "0x180AE81C0")]
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
		private static class BGGVQIAHWHN
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8967770", Offset = "0x8966570", VA = "0x188967770")]
			internal static ReadOnlySpan<char> Get(PerformanceBottleneck bottleneck)
			{
				return default(ReadOnlySpan<char>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly Log IRJSVORGEBN;

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
		private InitState AHAXLMKSNLQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private MetricIdLookup UTEZGLGSKVO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private IRawMetricsPipeline ZEVIIFYJTOW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private IMetricCollectionRegistry HXYJYJMQTBZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private MetricCollectionToken RXQRWOFYFCV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private TextSegmentManager KRZINDWSYQO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private QuadMeshManager HEWKWPYVCJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private Material XXZBWSVVOUG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private int ZMQXDEOTATE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private LayoutRect PVIZJGXJMMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int HUDZACVLKYZ;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private const int WQWMDAFOIWS = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private CYNBQCUPGEB GQRBCDVHWBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private bool GTBEENXFFYH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private Dictionary<MetricId, int> LXOEYYLYXXA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private List<ZOJWWAYUKJM> GSVXBLBVUTB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private LOFHXXORNAG LRPIMIWXODS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private List<LOFHXXORNAG> UHUQYMLFMOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private PerformanceBottleneck DPAWFWZRCBO;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public MeshBufferRenderer GDQRDLXWYZZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x896BB40", Offset = "0x896A940", VA = "0x18896BB40")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x896BD50", Offset = "0x896AB50", VA = "0x18896BD50")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x896BCF0", Offset = "0x896AAF0", VA = "0x18896BCF0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x896D130", Offset = "0x896BF30", VA = "0x18896D130")]
		private void XCBCEHHXKHO(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x896C6B0", Offset = "0x896B4B0", VA = "0x18896C6B0")]
		private void VIUXVWCSORK(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x896C460", Offset = "0x896B260", VA = "0x18896C460")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x896B9C0", Offset = "0x896A7C0", VA = "0x18896B9C0")]
		public void InitMetricsDependencies(MetricIdLookup metricIdLookup, IRawMetricsPipeline metricsPipeline, IMetricCollectionRegistry metricsRegistry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x896BD80", Offset = "0x896AB80", VA = "0x18896BD80")]
		public void SetActiveOverlay(CYNBQCUPGEB overlay)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x896D220", Offset = "0x896C020", VA = "0x18896D220")]
		private void YKBUMQGTVHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x896C040", Offset = "0x896AE40", VA = "0x18896C040")]
		private void THWZQJQTXXN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x896CA50", Offset = "0x896B850", VA = "0x18896CA50")]
		private void VQHFBKQOCRL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x896AD20", Offset = "0x8969B20", VA = "0x18896AD20")]
		private void DKBUEBJNPGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x896CE70", Offset = "0x896BC70", VA = "0x18896CE70")]
		private bool WRRBDHVHIVZ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x896C1A0", Offset = "0x896AFA0", VA = "0x18896C1A0")]
		private bool TTXYXNZZNPH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x896BE00", Offset = "0x896AC00", VA = "0x18896BE00")]
		private bool TDLENDYNDRB(bool a = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x896B5B0", Offset = "0x896A3B0", VA = "0x18896B5B0")]
		private bool FLHODZVBPTY(BJMRRQMOXHC a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x896B470", Offset = "0x896A270", VA = "0x18896B470")]
		private bool FHWDXHZXQTJ(BJMRRQMOXHC a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x896B790", Offset = "0x896A590", VA = "0x18896B790")]
		public void HandleMetric([In] RawMetric metricMessage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x896C450", Offset = "0x896B250", VA = "0x18896C450")]
		private bool ULRPSIHVUKJ(InitState a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x896BB20", Offset = "0x896A920", VA = "0x18896BB20")]
		private bool KODTCYEQCCJ(InitState a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x896D6F0", Offset = "0x896C4F0", VA = "0x18896D6F0")]
		public MetricHudDisplay()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x896BB10", Offset = "0x896A910", VA = "0x18896BB10", Slot = "4")]
		private void JRSCKUOBSSB([In] RawMetric metricMessage)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal class LOFHXXORNAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private bool QNKBTXTMORT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private LayoutRect CLYQXHCURDU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TextSegmentLayout QUHDFVBFJHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TextSegmentLayout DHRRBVXTQNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private TextSegmentLayout FLYFPHQCYZC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private RUUYFYFQNBQ OAEYAYVXJKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private MetricGraphGraphic EQMBHZVLOBP;

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x896A760", Offset = "0x8969560", VA = "0x18896A760")]
		public void RWFLESYWDGJ(TextSegmentManager a, QuadMeshManager b, LayoutRect c, int d, [Optional] MetricGraphGraphic e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x896A1C0", Offset = "0x8968FC0", VA = "0x18896A1C0")]
		public void HSYLZJFXEEJ(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8969E50", Offset = "0x8968C50", VA = "0x188969E50")]
		public void FLXFJGWADAK(ReadOnlySpan<char> a, ReadOnlySpan<char> b, ReadOnlySpan<char> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x896A070", Offset = "0x8968E70", VA = "0x18896A070")]
		public void GYBHMHLGVCR(RRColor32 a, bool b = true, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x896A380", Offset = "0x8969180", VA = "0x18896A380")]
		public float OYCUVQXLOVX(float a, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x896AC50", Offset = "0x8969A50", VA = "0x18896AC50")]
		public void ZMJJEBMSYUT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x896A330", Offset = "0x8969130", VA = "0x18896A330")]
		public void LUTCZEJOTMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x896A360", Offset = "0x8969160", VA = "0x18896A360")]
		public void NDEFWLTZFCK(PCNTJJNAFRY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8969FC0", Offset = "0x8968DC0", VA = "0x188969FC0")]
		public void FPFNZMOUCRX(PCNTJJNAFRY a, double b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x896ABC0", Offset = "0x89699C0", VA = "0x18896ABC0")]
		public void XCFXMUNXNUW(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8969C30", Offset = "0x8968A30", VA = "0x188969C30")]
		public void Cleanup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public LOFHXXORNAG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class IVMQVCGLUOO
	{
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static CYNBQCUPGEB TGJFUVGPVFH;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static CYNBQCUPGEB WVZRCCTXNRL;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static CYNBQCUPGEB HEGFJTXEZXH;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static CYNBQCUPGEB YKIARBDQHKV;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static CYNBQCUPGEB IGWLEAKGMQA;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static CYNBQCUPGEB RLWCSCNCMVK;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static CYNBQCUPGEB GUTFKAZYITC
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x89679C0", Offset = "0x89667C0", VA = "0x1889679C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static CYNBQCUPGEB PFWWRUVHJNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x89678D0", Offset = "0x89666D0", VA = "0x1889678D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static CYNBQCUPGEB RVIBDYJOFPC
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x8967920", Offset = "0x8966720", VA = "0x188967920")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static CYNBQCUPGEB QADPGNXDWZG
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8967A10", Offset = "0x8966810", VA = "0x188967A10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static CYNBQCUPGEB ZQZKTQZJMVF
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x8967970", Offset = "0x8966770", VA = "0x188967970")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static CYNBQCUPGEB UYVOQBRSZUP
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x8967880", Offset = "0x8966680", VA = "0x188967880")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static CYNBQCUPGEB WFWPCAKKCRS
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xABE8E0", Offset = "0xABD6E0", VA = "0x180ABE8E0")]
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
		public PCNTJJNAFRY Threshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public bool Graph;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public bool DisableStats;
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class CYNBQCUPGEB
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string QUKHOKRQDML
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public MetricDisplay[] PIUTLRNWCOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public virtual void Activate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "5")]
		public virtual void CKADIUUZXVP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xABFA30", Offset = "0xABE830", VA = "0x180ABFA30")]
		public CYNBQCUPGEB(string a, MetricDisplay[] b)
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
	internal class ZOJWWAYUKJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private MetricTextDirtyState PMBDGXNJFCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private MetricDescription VKRUCFDWBTN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private RawMetricPayload EQZCXZLFUCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private EwmaFilter ECVNUGYGHOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private double DJSMPHMFCPX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private int XLRYXSLLCJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private PCNTJJNAFRY QNXBJFSZOOW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private ThresholdResult DLAZCKMYNST;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private const int TYWOIFLRGFE = 16;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private char[] HHHPJVDMQXG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private char[] FPOZBZWRRQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private int HRVRGOQSGLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private char[] MCRKJMNKVRR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private int KJFTJLUKIZI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private string PPWAUOSQTFW;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public MetricDescription SVFBGFOGKGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xED04F0", Offset = "0xECF2F0", VA = "0x180ED04F0")]
			get
			{
				return default(MetricDescription);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x896D8A0", Offset = "0x896C6A0", VA = "0x18896D8A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public MetricTextDirtyState UQXIFXYIUTQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xAC7B20", Offset = "0xAC6920", VA = "0x180AC7B20")]
			get
			{
				return default(MetricTextDirtyState);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public ReadOnlySpan<char> XIFYTZYDJUI
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x896DE20", Offset = "0x896CC20", VA = "0x18896DE20")]
			get
			{
				return default(ReadOnlySpan<char>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public ReadOnlySpan<char> JLCRBFLLTGR
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x896D920", Offset = "0x896C720", VA = "0x18896D920")]
			get
			{
				return default(ReadOnlySpan<char>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public ReadOnlySpan<char> RYSGJXYMPNR
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x896D9E0", Offset = "0x896C7E0", VA = "0x18896D9E0")]
			get
			{
				return default(ReadOnlySpan<char>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public ThresholdResult QIDNNBRYLXJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xC4F9C0", Offset = "0xC4E7C0", VA = "0x180C4F9C0")]
			get
			{
				return default(ThresholdResult);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public double DNCKJCDWRUA
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x896DEE0", Offset = "0x896CCE0", VA = "0x18896DEE0")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public float YDRKBKCXBZE
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x896DED0", Offset = "0x896CCD0", VA = "0x18896DED0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float GABKUCYTLCZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xD97BD0", Offset = "0xD969D0", VA = "0x180D97BD0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xE284C0", Offset = "0xE272C0", VA = "0x180E284C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool COCZSYHSZAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x1324960", Offset = "0x1323760", VA = "0x181324960")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x16701F0", Offset = "0x166EFF0", VA = "0x1816701F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public PCNTJJNAFRY XRHXAGCQONY
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xAC3430", Offset = "0xAC2230", VA = "0x180AC3430")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x896E370", Offset = "0x896D170", VA = "0x18896E370")]
		public ZOJWWAYUKJM(string a, [Optional] MetricDescription b, [Optional] PCNTJJNAFRY c, bool d = true, bool e = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x896DD30", Offset = "0x896CB30", VA = "0x18896DD30")]
		public void LRMHFKCGWYK(RawMetricPayload a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x896DAA0", Offset = "0x896C8A0", VA = "0x18896DAA0")]
		public bool IWWNNIWWCJX()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x896DF10", Offset = "0x896CD10", VA = "0x18896DF10")]
		public bool ZVPYWABTDFO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x74141F0", Offset = "0x7412FF0", VA = "0x1874141F0")]
		public void PBXDIQNFAPX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x74141E0", Offset = "0x7412FE0", VA = "0x1874141E0")]
		public void MWAAOFKPYYR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x896DE80", Offset = "0x896CC80", VA = "0x18896DE80")]
		private static int QSRFQESEDCL(MetricDataUnits a)
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

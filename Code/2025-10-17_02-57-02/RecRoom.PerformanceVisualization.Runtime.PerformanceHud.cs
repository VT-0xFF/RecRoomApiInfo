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
		[Cpp2IlInjected.Address(RVA = "0x88E58E0", Offset = "0x88E3EE0", VA = "0x1888E58E0", Slot = "4")]
		public override void KQPXXDZDTRT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAD08C0", Offset = "0xACEEC0", VA = "0x180AD08C0")]
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
		private static class XTLEWHVZJOE
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x88EB4D0", Offset = "0x88E9AD0", VA = "0x1888EB4D0")]
			internal static ReadOnlySpan<char> Get(PerformanceBottleneck bottleneck)
			{
				return default(ReadOnlySpan<char>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly Log WOAZIZZDVRE;

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
		private InitState VTNPKTBLKOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private MetricIdLookup RDUTHSJBJBR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private IRawMetricsPipeline MBUMOOAQXZF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private IMetricCollectionRegistry GIFERADIJLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private MetricCollectionToken JEKZCSVEJHQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private TextSegmentManager RVPGGPKKQHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private QuadMeshManager OVMOBNSYDVU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private Material ZNBBZRNREGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private int LREHXXTCYXV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private LayoutRect LXENEGAIQBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int QDDLWIOABPC;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private const int MCNGPHEGJXH = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private TZUUFDNVAZS ZYEEGSEEIWG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private bool ISZTPIGLLXE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private Dictionary<MetricId, int> KRYUOIITPIT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private List<UQWGPMYEWOR> JLDWJLPQHAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private LZWYFOVNSQH XCRZTDUBNFV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private List<LZWYFOVNSQH> YWIWBQFWCLW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private PerformanceBottleneck TPDSRINSPTJ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public MeshBufferRenderer EUZOALFCQWQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xAA7750", Offset = "0xAA5D50", VA = "0x180AA7750")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x88E6BF0", Offset = "0x88E51F0", VA = "0x1888E6BF0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x88E6E00", Offset = "0x88E5400", VA = "0x1888E6E00")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x88E6DA0", Offset = "0x88E53A0", VA = "0x1888E6DA0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x88E7A40", Offset = "0x88E6040", VA = "0x1888E7A40")]
		private void YJVYZGEWJVX(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x88E65D0", Offset = "0x88E4BD0", VA = "0x1888E65D0")]
		private void NGCQESFEZUP(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x88E77F0", Offset = "0x88E5DF0", VA = "0x1888E77F0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x88E6290", Offset = "0x88E4890", VA = "0x1888E6290")]
		public void InitMetricsDependencies(MetricIdLookup metricIdLookup, IRawMetricsPipeline metricsPipeline, IMetricCollectionRegistry metricsRegistry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x88E7630", Offset = "0x88E5C30", VA = "0x1888E7630")]
		public void SetActiveOverlay(TZUUFDNVAZS overlay)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x88E6F90", Offset = "0x88E5590", VA = "0x1888E6F90")]
		private void RXITQIBPMXB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x88E6E30", Offset = "0x88E5430", VA = "0x1888E6E30")]
		private void PMLCPWLRMAS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x88E5980", Offset = "0x88E3F80", VA = "0x1888E5980")]
		private void FATFMCGSXEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x88E7B30", Offset = "0x88E6130", VA = "0x1888E7B30")]
		private void YQSLGTWPXJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x88E5DA0", Offset = "0x88E43A0", VA = "0x1888E5DA0")]
		private bool HUVYZHFAQKI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x88E6940", Offset = "0x88E4F40", VA = "0x1888E6940")]
		private bool ORYMYOQMYOG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x88E73F0", Offset = "0x88E59F0", VA = "0x1888E73F0")]
		private bool SLUDGEVEDJO(bool a = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x88E63F0", Offset = "0x88E49F0", VA = "0x1888E63F0")]
		private bool LSYFDGNNGVH(BBUSSLDKBTT a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x88E76B0", Offset = "0x88E5CB0", VA = "0x1888E76B0")]
		private bool UMWCYRQRWQC(BBUSSLDKBTT a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x88E6060", Offset = "0x88E4660", VA = "0x1888E6060")]
		public void HandleMetric([In] RawMetric metricMessage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x88E8280", Offset = "0x88E6880", VA = "0x1888E8280")]
		private bool ZQMOVQFSFVM(InitState a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x88E5960", Offset = "0x88E3F60", VA = "0x1888E5960")]
		private bool BMHHAHBESMS(InitState a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x88E8300", Offset = "0x88E6900", VA = "0x1888E8300")]
		public MetricHudDisplay()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x88E63E0", Offset = "0x88E49E0", VA = "0x1888E63E0", Slot = "4")]
		private void KRVXZQNQESG([In] RawMetric metricMessage)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal class LZWYFOVNSQH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private bool NYIDXUOJZIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private LayoutRect RCBMQDKUMYD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TextSegmentLayout HTXEORQZKBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TextSegmentLayout XNYDZPLYQAT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private TextSegmentLayout UNEVCXDZHIX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private INVALJOSWEF SPRBITIAFGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private MetricGraphGraphic LKZEZUJVOBW;

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x88E4BE0", Offset = "0x88E31E0", VA = "0x1888E4BE0")]
		public void FTYJJGFKYMC(TextSegmentManager a, QuadMeshManager b, LayoutRect c, int d, [Optional] MetricGraphGraphic e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x88E5090", Offset = "0x88E3690", VA = "0x1888E5090")]
		public void KKZXPKVMWOY(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x88E5250", Offset = "0x88E3850", VA = "0x1888E5250")]
		public void NXMMYNECEQP(ReadOnlySpan<char> a, ReadOnlySpan<char> b, ReadOnlySpan<char> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x88E4A90", Offset = "0x88E3090", VA = "0x1888E4A90")]
		public void DRTIJRSKDLE(RRColor32 a, bool b = true, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x88E5500", Offset = "0x88E3B00", VA = "0x1888E5500")]
		public float XWQOKQGAREE(float a, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x88E5040", Offset = "0x88E3640", VA = "0x1888E5040")]
		public void GEASVWDLOUO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x88E5200", Offset = "0x88E3800", VA = "0x1888E5200")]
		public void NGHHPYQPBTE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x88E5230", Offset = "0x88E3830", VA = "0x1888E5230")]
		public void NNTCRSXZBLV(MWTVGMEZWPJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x88E53C0", Offset = "0x88E39C0", VA = "0x1888E53C0")]
		public void TRTWPPVXIBE(MWTVGMEZWPJ a, double b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x88E5470", Offset = "0x88E3A70", VA = "0x1888E5470")]
		public void VJLGZHZMVVZ(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x88E4870", Offset = "0x88E2E70", VA = "0x1888E4870")]
		public void Cleanup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public LZWYFOVNSQH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class XCDKQZOORRV
	{
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static TZUUFDNVAZS UVAIAYYRIXY;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static TZUUFDNVAZS RYHPAPBMRGY;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static TZUUFDNVAZS VOHKFHATSRU;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static TZUUFDNVAZS IWHDUMENXQQ;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static TZUUFDNVAZS EKIJDUZSLOL;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static TZUUFDNVAZS FLBBPWELNKV;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static TZUUFDNVAZS AMLVLGFTEOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x88E9120", Offset = "0x88E7720", VA = "0x1888E9120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static TZUUFDNVAZS PNCDXFUXNZR
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x88E92B0", Offset = "0x88E78B0", VA = "0x1888E92B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static TZUUFDNVAZS LLSYVNOUMJT
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x88E9210", Offset = "0x88E7810", VA = "0x1888E9210")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static TZUUFDNVAZS CFTKDANIXAX
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x88E9170", Offset = "0x88E7770", VA = "0x1888E9170")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static TZUUFDNVAZS UAJYXTEOKEG
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x88E91C0", Offset = "0x88E77C0", VA = "0x1888E91C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static TZUUFDNVAZS UFAKPCHFKUI
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x88E9260", Offset = "0x88E7860", VA = "0x1888E9260")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static TZUUFDNVAZS QHFSPWBMLIB
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860")]
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
		public MWTVGMEZWPJ Threshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public bool Graph;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public bool DisableStats;
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class TZUUFDNVAZS
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string PRIIIUOKRHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xAAA9C0", Offset = "0xAA8FC0", VA = "0x180AAA9C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public MetricDisplay[] PGEQWGZLXRP
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xAA7A70", Offset = "0xAA6070", VA = "0x180AA7A70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "4")]
		public virtual void Activate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "5")]
		public virtual void HQTIFATWAVM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xAAC450", Offset = "0xAAAA50", VA = "0x180AAC450")]
		public TZUUFDNVAZS(string a, MetricDisplay[] b)
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
	internal class UQWGPMYEWOR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private MetricTextDirtyState MTHIQCOYFKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private MetricDescription UCUTTEEAADY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private RawMetricPayload NILXQWWEBZI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private EwmaFilter PNSHFPYRUGX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private double WGZJSRXHVLU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private int KWDWYFULXNU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private MWTVGMEZWPJ ERICMIHHTAX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private ThresholdResult HEJHFQTBIAK;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private const int NKWOTTHYUEZ = 16;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private char[] CVTSKPVYPOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private char[] FGTBTNFFFUC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private int RSGMQWMNUTT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private char[] LILISRGIXSO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private int KKDVPKNRXAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private string GLXSNRMPQOD;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public MetricDescription QSPZXUHPWLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xF331E0", Offset = "0xF317E0", VA = "0x180F331E0")]
			get
			{
				return default(MetricDescription);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x88E8E60", Offset = "0x88E7460", VA = "0x1888E8E60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public MetricTextDirtyState SJNIAZRRRMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xAAA9D0", Offset = "0xAA8FD0", VA = "0x180AAA9D0")]
			get
			{
				return default(MetricTextDirtyState);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public ReadOnlySpan<char> TXAEFHNLARJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x88E8E00", Offset = "0x88E7400", VA = "0x1888E8E00")]
			get
			{
				return default(ReadOnlySpan<char>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public ReadOnlySpan<char> UAYRQMQQQXA
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x88E8820", Offset = "0x88E6E20", VA = "0x1888E8820")]
			get
			{
				return default(ReadOnlySpan<char>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public ReadOnlySpan<char> NNTDZUIAZOO
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x88E88E0", Offset = "0x88E6EE0", VA = "0x1888E88E0")]
			get
			{
				return default(ReadOnlySpan<char>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public ThresholdResult QJAKBQCMFGS
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xC4BB90", Offset = "0xC4A190", VA = "0x180C4BB90")]
			get
			{
				return default(ThresholdResult);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public double FHVBVONQNSH
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x88E8F40", Offset = "0x88E7540", VA = "0x1888E8F40")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public float XYMYKIGRRQZ
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x88E8F30", Offset = "0x88E7530", VA = "0x1888E8F30")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float CFSASHWXRXU
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xE11DF0", Offset = "0xE103F0", VA = "0x180E11DF0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xE55F90", Offset = "0xE54590", VA = "0x180E55F90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool THOGZBOSDAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x138D000", Offset = "0x138B600", VA = "0x18138D000")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x16B4200", Offset = "0x16B2800", VA = "0x1816B4200")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public MWTVGMEZWPJ TRFAJBAUSNR
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xAACA80", Offset = "0xAAB080", VA = "0x180AACA80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x88E8F70", Offset = "0x88E7570", VA = "0x1888E8F70")]
		public UQWGPMYEWOR(string a, [Optional] MetricDescription b, [Optional] MWTVGMEZWPJ c, bool d = true, bool e = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x88E8730", Offset = "0x88E6D30", VA = "0x1888E8730")]
		public void EJJGKTJLJPL(RawMetricPayload a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x88E84B0", Offset = "0x88E6AB0", VA = "0x1888E84B0")]
		public bool CHMYSGLZZYE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x88E89A0", Offset = "0x88E6FA0", VA = "0x1888E89A0")]
		public bool NJJKUFRFACL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x737C8C0", Offset = "0x737AEC0", VA = "0x18737C8C0")]
		public void INJMDWJBNWG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x737C8B0", Offset = "0x737AEB0", VA = "0x18737C8B0")]
		public void RYDPYBUCMVI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x88E8EE0", Offset = "0x88E74E0", VA = "0x1888E8EE0")]
		private static int QWWNOOAGHHM(MetricDataUnits a)
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

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom.Metrics.Pipeline;
using RecRoom.Metrics.Pipeline.MetricInfo;
using RecRoom.Profiling.Configs;
using RecRoom.Profiling.Core;
using TMPro;
using Unity.Profiling;
using Unity.Profiling.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.Serialization;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Profiling
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class FrameTimeMetricGraphDriver : SingleMetricGraphDriver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		[Header("Accumulation")]
		[Min(0f)]
		private int framesToAccumulate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private MetricAccumulateMode accumulateModeToUse;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		protected override int BAAOCNDGLMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0xD5F750", Offset = "0xD5DD50", VA = "0x180D5F750", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected override MetricAccumulateMode HFKPDALGLOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x1A37FA0", Offset = "0x1A365A0", VA = "0x181A37FA0", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9CD2F0", Offset = "0x9CB8F0", VA = "0x1809CD2F0", Slot = "4")]
		protected override HFPMCBFLMAG LIHJANPCHLJ()
		{
			return default(HFPMCBFLMAG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6D68050", Offset = "0x6D66650", VA = "0x186D68050", Slot = "14")]
		protected override bool FCDEGEOJOED(string JBKOOEINFLJ = "0.00", [Optional] string CAILINFGFJI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6D68130", Offset = "0x6D66730", VA = "0x186D68130")]
		public FrameTimeMetricGraphDriver()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public enum MetricAccumulateMode
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Average,
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		AveragePerSecond,
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		Max,
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		Min,
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		First,
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		Last,
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		Sum
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class ConfigurablePipelineGraphDriver : SingleMetricGraphDriver, IMetricsSubscriber<RawMetric>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private MetricIdLookup LMFCDOEMFLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private IRawMetricsPipeline BMBIJAPKCOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private IMetricCollectionRegistry CIBAAHGAFIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private MetricId LNIMFKFPOFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private int CCEBDEIOBBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private MetricAccumulateMode MOBIEEDHBJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private MetricCollectionToken DCEGGIJLHGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private MetricDescription HODJNAGBDMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private GraphConfig ONJANGBNNOG;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		protected override int BAAOCNDGLMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x12CB850", Offset = "0x12C9E50", VA = "0x1812CB850", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected override MetricAccumulateMode HFKPDALGLOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xA7E0C0", Offset = "0xA7C6C0", VA = "0x180A7E0C0", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6D67610", Offset = "0x6D65C10", VA = "0x186D67610")]
		private void INFPNJMEPBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6D673A0", Offset = "0x6D659A0", VA = "0x186D673A0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6D67CF0", Offset = "0x6D662F0", VA = "0x186D67CF0", Slot = "9")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6D67BF0", Offset = "0x6D661F0", VA = "0x186D67BF0")]
		protected void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6D67770", Offset = "0x6D65D70", VA = "0x186D67770")]
		public void Initialize(GraphConfig GLMAALEDHAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6D67400", Offset = "0x6D65A00", VA = "0x186D67400", Slot = "14")]
		protected override bool FCDEGEOJOED(string JBKOOEINFLJ = "0.00", [Optional] string CAILINFGFJI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6D67510", Offset = "0x6D65B10", VA = "0x186D67510")]
		public void HandleMetric(in RawMetric HGGDEEGJBGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xAB52B0", Offset = "0xAB38B0", VA = "0x180AB52B0", Slot = "4")]
		protected override HFPMCBFLMAG LIHJANPCHLJ()
		{
			return default(HFPMCBFLMAG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6D67E70", Offset = "0x6D66470", VA = "0x186D67E70")]
		public ConfigurablePipelineGraphDriver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6D67510", Offset = "0x6D65B10", VA = "0x186D67510", Slot = "15")]
		private void MMNANONDMOA(in RawMetric HGGDEEGJBGN)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class MetricDashboard : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		private List<ConfigurablePipelineGraphDriver> metricGraphDriverBases;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[SerializeField]
		private List<GraphConfigAsset> startingMetrics;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6D6AAD0", Offset = "0x6D690D0", VA = "0x186D6AAD0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6D6AEB0", Offset = "0x6D694B0", VA = "0x186D6AEB0")]
		public MetricDashboard()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class RandomMetricGraphDriver : SingleMetricGraphDriver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[SerializeField]
		[Min(0f)]
		[Header("Accumulation")]
		private int framesToAccumulate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private MetricAccumulateMode accumulateModeToUse;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[SerializeField]
		[Range(0f, 99f)]
		[Header("Random Range")]
		private float randomMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[SerializeField]
		[Range(1f, 100f)]
		private float randomMax;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		protected override int BAAOCNDGLMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xD5F750", Offset = "0xD5DD50", VA = "0x180D5F750", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected override MetricAccumulateMode HFKPDALGLOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x1A37FA0", Offset = "0x1A365A0", VA = "0x181A37FA0", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1D7C0C0", Offset = "0x1D7A6C0", VA = "0x181D7C0C0", Slot = "4")]
		protected override HFPMCBFLMAG LIHJANPCHLJ()
		{
			return default(HFPMCBFLMAG);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6D6D300", Offset = "0x6D6B900", VA = "0x186D6D300")]
		public RandomMetricGraphDriver()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class FPSMetricGraphDriver : SingleMetricGraphDriver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		[Min(0f)]
		[Header("Accumulation")]
		private int framesToAccumulate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[SerializeField]
		private MetricAccumulateMode accumulateModeToUse;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[SerializeField]
		private string DisplayFormat;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		protected override int BAAOCNDGLMJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xD5F750", Offset = "0xD5DD50", VA = "0x180D5F750", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		protected override MetricAccumulateMode HFKPDALGLOE
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x1A37FA0", Offset = "0x1A365A0", VA = "0x181A37FA0", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x95FD90", Offset = "0x95E390", VA = "0x18095FD90", Slot = "4")]
		protected override HFPMCBFLMAG LIHJANPCHLJ()
		{
			return default(HFPMCBFLMAG);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6D67EC0", Offset = "0x6D664C0", VA = "0x186D67EC0", Slot = "14")]
		protected override bool FCDEGEOJOED(string JBKOOEINFLJ = "0.00", [Optional] string CAILINFGFJI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6D67FC0", Offset = "0x6D665C0", VA = "0x186D67FC0")]
		public FPSMetricGraphDriver()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class MetricGraphTextDisplay : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[SerializeField]
		[Header("Metric Text")]
		private TMP_Text nameText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private bool AGHFMAEKLIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[SerializeField]
		private TMP_Text categoryText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private bool EMFCKGBNFBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[SerializeField]
		private TMP_Text descriptionText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private bool LLGAPMKPGBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[SerializeField]
		[Header("Data Text")]
		private TMP_Text samplesText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private bool GBHHFOFEAIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[SerializeField]
		private TMP_Text curText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private bool KLKBMAOMBFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[SerializeField]
		private TMP_Text minText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private bool DNNBGNHPEJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[SerializeField]
		private TMP_Text maxText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private bool LNBHHHMEBCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[SerializeField]
		private TMP_Text avgText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private bool KJAEHOABNNG;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string GDENOABFKNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6D6B950", Offset = "0x6D69F50", VA = "0x186D6B950")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6D6BBD0", Offset = "0x6D6A1D0", VA = "0x186D6BBD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string CKEAIHNJOEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6D6B6D0", Offset = "0x6D69CD0", VA = "0x186D6B6D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6D6BA90", Offset = "0x6D6A090", VA = "0x186D6BA90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public string KIGCLMCIDEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6D6B7D0", Offset = "0x6D69DD0", VA = "0x186D6B7D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6D6BB10", Offset = "0x6D6A110", VA = "0x186D6BB10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string OAOGBHGONAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6D6B9D0", Offset = "0x6D69FD0", VA = "0x186D6B9D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6D6BC10", Offset = "0x6D6A210", VA = "0x186D6BC10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public string JJOCFHADKKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6D6B750", Offset = "0x6D69D50", VA = "0x186D6B750")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6D6BAD0", Offset = "0x6D6A0D0", VA = "0x186D6BAD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public string DJEAKDGADFK
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6D6B8D0", Offset = "0x6D69ED0", VA = "0x186D6B8D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6D6BB90", Offset = "0x6D6A190", VA = "0x186D6BB90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public string PACFCKLOKAH
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6D6B850", Offset = "0x6D69E50", VA = "0x186D6B850")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6D6BB50", Offset = "0x6D6A150", VA = "0x186D6BB50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public string GIGLJLDILMH
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6D6B650", Offset = "0x6D69C50", VA = "0x186D6B650")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6D6BA50", Offset = "0x6D6A050", VA = "0x186D6BA50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B520", Offset = "0x6D69B20", VA = "0x186D6B520", Slot = "4")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B4A0", Offset = "0x6D69AA0", VA = "0x186D6B4A0")]
		protected string FOLJMLOLFGF(bool KBOHLFKGHDC, ref TMP_Text PAKFOBAPADB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B610", Offset = "0x6D69C10", VA = "0x186D6B610")]
		protected void PDHOJEHGGEO(bool FIFGMOFFIAP, ref TMP_Text LIGIEJOGFAH, string MOLEJFDINLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7EAA60", Offset = "0x7E9060", VA = "0x1807EAA60")]
		public MetricGraphTextDisplay()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[DefaultMember("Item")]
public class KCHNBFADMHH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	protected float[] AHOONMMFIFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	protected int NIIPFCHGNCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	protected int FJLPCOJGEJP;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int AEJJJIDCFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xA59820", Offset = "0xA57E20", VA = "0x180A59820")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int MJANMLEEEMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1D51010", Offset = "0x1D4F610", VA = "0x181D51010")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float HEDGFJAGBEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6D6A750", Offset = "0x6D68D50", VA = "0x186D6A750")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public float HFMEMJEKBGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6D6A670", Offset = "0x6D68C70", VA = "0x186D6A670")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float ENKOABNAAKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6D66830", Offset = "0x6D64E30", VA = "0x186D66830")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6D6A900", Offset = "0x6D68F00", VA = "0x186D6A900")]
	public KCHNBFADMHH(int LEFNHMBHKEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6D6A760", Offset = "0x6D68D60", VA = "0x186D6A760")]
	public void IEAKMEHLIBJ(int FLKKHJKGEJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6D6A680", Offset = "0x6D68C80", VA = "0x186D6A680")]
	public void CPBMNMBFGHG(float MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4858C90", Offset = "0x4857290", VA = "0x184858C90")]
	public void GNBNGAAJBNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6D668E0", Offset = "0x6D64EE0", VA = "0x186D668E0")]
	public void KANNICKDGPF(float[] LIGIEJOGFAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6D6A7F0", Offset = "0x6D68DF0", VA = "0x186D6A7F0")]
	public void KANNICKDGPF(float[] LIGIEJOGFAH, int OFFGIGKGOCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6D6A640", Offset = "0x6D68C40", VA = "0x186D6A640")]
	private int AOIHDCNHFDK(int OLGOBCPPPBB)
	{
		return default(int);
	}
}
namespace RecRoom.Profiling
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MetricGraph : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private ProfilerMarker AIPFGBMPHJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private ProfilerMarker BKKGOONAPNL;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private const int FHAIIFFKKKB = 8;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private const int MCIILOEIHOP = 512;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[SerializeField]
		[Range(8f, 512f)]
		[Header("Buffer")]
		private int bufferCapacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private KCHNBFADMHH MIIKDFMFJEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool JODBHBFOALB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private float DMIKJLLOGDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private float LDBEBHEOHIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private float PICCMGGLADM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private float MHHPLPPMMOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private float LGJGKBDIGAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		[Header("Graph")]
		private RawImage graphImageTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[Space]
		[SerializeField]
		[FormerlySerializedAs("graphImageShaderFull")]
		private Shader shaderFull;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[SerializeField]
		[FormerlySerializedAs("graphImageShaderLight")]
		private Shader shaderLight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[SerializeField]
		private bool useLightShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x69")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[SerializeField]
		[Header("Graph Visuals")]
		private bool isZeroBased;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[SerializeField]
		[Range(1f, 10f)]
		private float resolutionScalar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		private Color baseValueColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		[Space]
		private bool showAverageBar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[SerializeField]
		private Color averageBarColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[Space]
		[SerializeField]
		private bool showThresholdBars;

		[Cpp2IlInjected.FieldOffset(Offset = "0x95")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[SerializeField]
		private bool higherValueIsBetter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[SerializeField]
		private int cautionValueThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[SerializeField]
		private Color cautionValueColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[SerializeField]
		private int criticalValueThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[SerializeField]
		private Color criticalValueColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private BIOJOJCGKFM AGNINONONJI;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private int DLGFJHBIGKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x6D6C820", Offset = "0x6D6AE20", VA = "0x186D6C820")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private int AKKODEDCDKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6D6BEB0", Offset = "0x6D6A4B0", VA = "0x186D6BEB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private int AAKDLGAAJJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x6D6C9D0", Offset = "0x6D6AFD0", VA = "0x186D6C9D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public int BDHFODCIFBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6D6D110", Offset = "0x6D6B710", VA = "0x186D6D110")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public int NELPLIBCACG
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6D6D0E0", Offset = "0x6D6B6E0", VA = "0x186D6D0E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float JECJDMDMFDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6D6D040", Offset = "0x6D6B640", VA = "0x186D6D040")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float BNDGJKNAGCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6D6D080", Offset = "0x6D6B680", VA = "0x186D6D080")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float PPBHBHMFNML
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6D6D060", Offset = "0x6D6B660", VA = "0x186D6D060")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float GBLEABDHLGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x6D6D0A0", Offset = "0x6D6B6A0", VA = "0x186D6D0A0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float NEHJAPNJHFH
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6D6D0C0", Offset = "0x6D6B6C0", VA = "0x186D6D0C0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6D6BC50", Offset = "0x6D6A250", VA = "0x186D6BC50")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CE20", Offset = "0x6D6B420", VA = "0x186D6CE20")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CA40", Offset = "0x6D6B040", VA = "0x186D6CA40")]
		public void PushSample(double GMHPEIOKELK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6D6BED0", Offset = "0x6D6A4D0", VA = "0x186D6BED0")]
		public void ClearSamples()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6D6BC80", Offset = "0x6D6A280", VA = "0x186D6BC80")]
		private void BMDJOMDAHKA(bool ODPLBAPFKKP = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CB30", Offset = "0x6D6B130", VA = "0x186D6CB30")]
		public void UpdateShader()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6D6C840", Offset = "0x6D6AE40", VA = "0x186D6C840")]
		public void InitData(int HBNGDMGFJBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6D6BEF0", Offset = "0x6D6A4F0", VA = "0x186D6BEF0")]
		private void EEDPNCCMDBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CE50", Offset = "0x6D6B450", VA = "0x186D6CE50")]
		public MetricGraph()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class BIOJOJCGKFM
{
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public const int EENJCGELAOP = 512;

	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public const int HLKHILGBHLM = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public int ELKMMFBDABK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public float[] MFNAPCIBFDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public RawImage HLBLLFIKKOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public float FBEANCJBMEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public float FKLBDMMHBDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public float PEFDCPAKANE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public float BPDCNGFJHOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public float MIDIHCGINPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public Color LALGONMBNBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public Color BPDALHAPOBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public bool PNPHNPMCGIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public Color DMEJIBNMGCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public Color COJKMPMPKHB;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static readonly int BIKBBBNGILO;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly int OOFAOBPOPDJ;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static readonly int LJNJBMMHMKH;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static readonly int CACPEOCJHLO;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly int MJGKCJAEKNE;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly int LEMMFMIFAMI;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static readonly int CPHILIFDDFB;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static readonly int GINKCGFFCCL;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static readonly int CICDJNBKJBL;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly int GPECAIJJFEL;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static readonly int CMGBPBPDKMF;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly int EFBLFHLKNKK;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6D66DB0", Offset = "0x6D653B0", VA = "0x186D66DB0")]
	public void OAMOPKMPJAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6D66B60", Offset = "0x6D65160", VA = "0x186D66B60")]
	public void GOPHFKIBHMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6D66E70", Offset = "0x6D65470", VA = "0x186D66E70")]
	public void PGDHEMOKOBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6D669E0", Offset = "0x6D64FE0", VA = "0x186D669E0")]
	public void AMEBOAJFJOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6D66C10", Offset = "0x6D65210", VA = "0x186D66C10")]
	public void IKJMAGFMNBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6D66AC0", Offset = "0x6D650C0", VA = "0x186D66AC0")]
	public void CIEMIPNKKEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6D66F10", Offset = "0x6D65510", VA = "0x186D66F10")]
	public void PKIPBLBGONJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6D67220", Offset = "0x6D65820", VA = "0x186D67220")]
	public BIOJOJCGKFM()
	{
	}
}
namespace RecRoom.Profiling
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ProfilingMetricGraphDriver : SingleMetricGraphDriver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[SerializeField]
		[Header("Profiling Metric")]
		public string metricCategoryName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[SerializeField]
		public string metricName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private ProfilerRecorderHandle IBGDFPPMCFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[SerializeField]
		[Header("Accumulation")]
		[Min(0f)]
		private int framesToAccumulate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[SerializeField]
		private MetricAccumulateMode accumulateModeToUse;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static bool NPDLLCPHOPE;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool IIPKGAIMBEC
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x6D6D2F0", Offset = "0x6D6B8F0", VA = "0x186D6D2F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		protected override int BAAOCNDGLMJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x8C60E0", Offset = "0x8C46E0", VA = "0x1808C60E0", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		protected override MetricAccumulateMode HFKPDALGLOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x12CB850", Offset = "0x12C9E50", VA = "0x1812CB850", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9CD2F0", Offset = "0x9CB8F0", VA = "0x1809CD2F0", Slot = "4")]
		protected override HFPMCBFLMAG LIHJANPCHLJ()
		{
			return default(HFPMCBFLMAG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6D6D130", Offset = "0x6D6B730", VA = "0x186D6D130", Slot = "14")]
		protected override bool FCDEGEOJOED(string JBKOOEINFLJ = "0.00", [Optional] string CAILINFGFJI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6D6D250", Offset = "0x6D6B850", VA = "0x186D6D250")]
		public ProfilingMetricGraphDriver()
		{
		}
	}
}
namespace RecRoom.Profiling.Configs
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class GraphConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public string FriendlyDescription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public string MetricSourceName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public string MetricName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public int FramesToAccumulate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public int BufferSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public MetricAccumulateMode MetricAccumulateMode;

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6D69C70", Offset = "0x6D68270", VA = "0x186D69C70")]
		public GraphConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class GraphConfigAsset : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[SerializeField]
		private GraphConfig graphConfig;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public GraphConfig GraphConfig
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x9341D0", Offset = "0x9327D0", VA = "0x1809341D0")]
		public GraphConfigAsset()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface NHNIILJGMMA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool JLMOFFAFBKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "2")]
	RawMetricPayload MFLCFJLAEKC();
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class BMHOMBEBGGF : NHNIILJGMMA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly Func<double> PNGELAKBCFC;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool JLMOFFAFBKO
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x95ED20", Offset = "0x95D320", VA = "0x18095ED20", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xC00670", Offset = "0xBFEC70", VA = "0x180C00670", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6D67350", Offset = "0x6D65950", VA = "0x186D67350")]
	public BMHOMBEBGGF(Func<double> PNGELAKBCFC, MetricDescription HODJNAGBDMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6D672C0", Offset = "0x6D658C0", VA = "0x186D672C0", Slot = "6")]
	public RawMetricPayload MFLCFJLAEKC()
	{
		return default(RawMetricPayload);
	}
}
namespace RecRoom.Profiling.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public abstract class MetricGraphDriverBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		protected const string NCAOOLEAPJD = "0.00";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		protected double EMDJMIMBOIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		protected double LDKLCDJIFCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		protected double MMHLEHGFLIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		protected double EDIOKJMCILN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		protected double MKCJCIGMLIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		protected int PBMIIHCADPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		protected double IPABKLEEKND;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		protected abstract int BAAOCNDGLMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		protected abstract MetricAccumulateMode HFKPDALGLOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		protected bool GPGABDAABCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xBAC820", Offset = "0xBAAE20", VA = "0x180BAC820")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xBC4010", Offset = "0xBC2610", VA = "0x180BC4010")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract HFPMCBFLMAG LIHJANPCHLJ();

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected abstract void LAFGPJCNMND();

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x999AA0", Offset = "0x9980A0", VA = "0x180999AA0", Slot = "9")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x999AA0", Offset = "0x9980A0", VA = "0x180999AA0")]
		protected void NFIKBJGEDLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B170", Offset = "0x6D69770", VA = "0x186D6B170", Slot = "10")]
		protected virtual void DFBIFAPMGDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6D6AF70", Offset = "0x6D69570", VA = "0x186D6AF70", Slot = "11")]
		protected virtual void BJNEDJGGHIC(double LNJOPHMCPHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B310", Offset = "0x6D69910", VA = "0x186D6B310", Slot = "12")]
		protected virtual double GJNGNANAOMC(MetricAccumulateMode MOBIEEDHBJM)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B1B0", Offset = "0x6D697B0", VA = "0x186D6B1B0")]
		protected bool FDLLEPMGGLJ(MetricGraph PNOPANKHPJB, MetricAccumulateMode CFNBBPIIFMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B050", Offset = "0x6D69650", VA = "0x186D6B050", Slot = "13")]
		protected virtual string BMBNGDNKHOO(double MOLEJFDINLH, string EFLMIDCDMEN = "0.00", [Optional] string NLAKPAOBLBO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B460", Offset = "0x6D69A60", VA = "0x186D6B460")]
		protected MetricGraphDriverBase()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class GDGDEGDLMOO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private readonly struct MPKJHECIJOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public readonly string GBAAIFAPNOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public readonly string AJAINCMHMIH;

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xBEFA40", Offset = "0xBEE040", VA = "0x180BEFA40")]
		public MPKJHECIJOM(string BGDPHEPONKN, string FDHHCKGAECO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class MCCFEDJMIPO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public GDGDEGDLMOO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public MCCFEDJMIPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6D6A970", Offset = "0x6D68F70", VA = "0x186D6A970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly MetricIdLookup LMFCDOEMFLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly IRawMetricsPipeline BMBIJAPKCOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly IMetricCollectionRegistry CIBAAHGAFIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly CancellationTokenSource CGFLGAGNMCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly Dictionary<MetricId, NHNIILJGMMA> MMFLMDEHOLI;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static readonly MPKJHECIJOM[] NHAFEIILODI;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6D68470", Offset = "0x6D66A70", VA = "0x186D68470")]
	[HFALCAKMDCP(BFPOMPMIJIJ.GameOnly)]
	private static void DPJPPHFDAJD(HOKFDAHMIPF COFPHJJAOOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6D693B0", Offset = "0x6D679B0", VA = "0x186D693B0")]
	[Preserve]
	public GDGDEGDLMOO([BBBJPGKHPHG(null)] MetricIdLookup LMFCDOEMFLK, [BBBJPGKHPHG(null)] IRawMetricsPipeline BMBIJAPKCOF, [BBBJPGKHPHG(null)] IMetricCollectionRegistry CIBAAHGAFIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6D686F0", Offset = "0x6D66CF0", VA = "0x186D686F0")]
	private void LFJFPGIJHCP(string BMCAHNAIAJD, string FDHHCKGAECO, HFPMCBFLMAG NJGONGDGMEP, Func<double> PNGELAKBCFC, out MetricId LNIMFKFPOFB, out NHNIILJGMMA PAKFOBAPADB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6D683D0", Offset = "0x6D669D0", VA = "0x186D683D0")]
	private void CMLFMPDDOHC(MetricId LNIMFKFPOFB, bool PINAGGFBBKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6D685A0", Offset = "0x6D66BA0", VA = "0x186D685A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MCCFEDJMIPO))]
	private Task ICMPFLNPDKJ(CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6D68170", Offset = "0x6D66770", VA = "0x186D68170")]
	public void ABOGLKDBLHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6D68560", Offset = "0x6D66B60", VA = "0x186D68560", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.Profiling.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public abstract class SingleMetricGraphDriver : MetricGraphDriverBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		[SerializeField]
		protected string debugDescription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[SerializeField]
		[FormerlySerializedAs("targetGraph")]
		[Header("Graph and Text")]
		protected MetricGraph graphDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		protected bool NIFMIFLEJDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[SerializeField]
		protected MetricGraphTextDisplay textDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		protected bool EBKKLNNEIDI;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6D6D850", Offset = "0x6D6BE50", VA = "0x186D6D850", Slot = "9")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6D6D690", Offset = "0x6D6BC90", VA = "0x186D6D690", Slot = "5")]
		protected override void LAFGPJCNMND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6D6D350", Offset = "0x6D6B950", VA = "0x186D6D350", Slot = "14")]
		protected virtual bool FCDEGEOJOED(string JBKOOEINFLJ = "0.00", [Optional] string CAILINFGFJI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B460", Offset = "0x6D69A60", VA = "0x186D6B460")]
		protected SingleMetricGraphDriver()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class KBKNEHHBMNE : NHNIILJGMMA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private static bool NPDLLCPHOPE;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static Dictionary<(ushort category, string name), ProfilerRecorderHandle> OCILGDBJBBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly MetricId LNIMFKFPOFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly string BGDPHEPONKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly string FDHHCKGAECO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private ProfilerRecorder HFLNEBEEKLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private bool DJOKCPDPLFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private bool PICBIIKBCJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private ProfilerRecorderDescription HKLGBOFADLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private ProfilerRecorderHandle IBGDFPPMCFN;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool JLMOFFAFBKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x979990", Offset = "0x977F90", VA = "0x180979990", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x979740", Offset = "0x977D40", VA = "0x180979740", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private MetricDescription BKBCNFIIBEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x22DAE90", Offset = "0x22D9490", VA = "0x1822DAE90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6D6A5D0", Offset = "0x6D68BD0", VA = "0x186D6A5D0")]
	public KBKNEHHBMNE(MetricId LNIMFKFPOFB, string BGDPHEPONKN, string FDHHCKGAECO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6D6A480", Offset = "0x6D68A80", VA = "0x186D6A480", Slot = "6")]
	public RawMetricPayload MFLCFJLAEKC()
	{
		return default(RawMetricPayload);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6D6A330", Offset = "0x6D68930", VA = "0x186D6A330")]
	private static ProfilerRecorderHandle JJNIOHLGFPE(string BGDPHEPONKN, string FDHHCKGAECO)
	{
		return default(ProfilerRecorderHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6D69C90", Offset = "0x6D68290", VA = "0x186D69C90")]
	private void AAGKMLMEPMN(bool ODPLBAPFKKP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6D6A2B0", Offset = "0x6D688B0", VA = "0x186D6A2B0")]
	private static MetricDescription HFNCMHGEJKJ(MetricId LNIMFKFPOFB, ProfilerRecorderDescription IMHIJGHFONF)
	{
		return default(MetricDescription);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6D69FE0", Offset = "0x6D685E0", VA = "0x186D69FE0")]
	private static bool CMOHAFKEOFN(bool ODPLBAPFKKP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6D69FC0", Offset = "0x6D685C0", VA = "0x186D69FC0")]
	private void ABCLNMJJHPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6D69FC0", Offset = "0x6D685C0", VA = "0x186D69FC0", Slot = "7")]
	public void Dispose()
	{
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

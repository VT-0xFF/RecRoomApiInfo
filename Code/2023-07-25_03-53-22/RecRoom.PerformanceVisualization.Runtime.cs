using System;
using System.Collections;
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
		protected override int NMKPJMJAPIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0xFC4210", Offset = "0xFC3210", VA = "0x180FC4210", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected override MetricAccumulateMode HJADFHFHCMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x11DE030", Offset = "0x11DD030", VA = "0x1811DE030", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xC07AB0", Offset = "0xC06AB0", VA = "0x180C07AB0", Slot = "4")]
		protected override FHAEBCGCGLC PFHMPNFJNFB()
		{
			return default(FHAEBCGCGLC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6FEAD50", Offset = "0x6FE9D50", VA = "0x186FEAD50", Slot = "14")]
		protected override bool BOGDHPFPJEA(string JGFIAJIMOBH = "0.00", [Optional] string PKLBLJKDKEJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6FEAE30", Offset = "0x6FE9E30", VA = "0x186FEAE30")]
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
		private MetricIdLookup MFOOFEPJIDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private IRawMetricsPipeline IKHIDBMHABI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private IMetricCollectionRegistry LLDJNFDKDMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private MetricId EHJDDIBNKDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private int PCGKMJNAMHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private MetricAccumulateMode GPAHABKIEBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private MetricCollectionToken FFKJLIDBALM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private MetricDescription PPDDAJBGMDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private GraphConfig BFNMKFBGGMI;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		protected override int NMKPJMJAPIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x1422690", Offset = "0x1421690", VA = "0x181422690", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected override MetricAccumulateMode HJADFHFHCMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xA23910", Offset = "0xA22910", VA = "0x180A23910", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6FEA630", Offset = "0x6FE9630", VA = "0x186FEA630")]
		private void LNAJDGNPBGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6FE9F40", Offset = "0x6FE8F40", VA = "0x186FE9F40", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6FEA890", Offset = "0x6FE9890", VA = "0x186FEA890", Slot = "9")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6FEA790", Offset = "0x6FE9790", VA = "0x186FEA790")]
		protected void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6FEA1B0", Offset = "0x6FE91B0", VA = "0x186FEA1B0")]
		public void Initialize(GraphConfig MLIIGNBFOAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6FE9FA0", Offset = "0x6FE8FA0", VA = "0x186FE9FA0", Slot = "14")]
		protected override bool BOGDHPFPJEA(string JGFIAJIMOBH = "0.00", [Optional] string PKLBLJKDKEJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6FEA0B0", Offset = "0x6FE90B0", VA = "0x186FEA0B0")]
		public void HandleMetric(in RawMetric KBKHLEKAJLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x569C8A0", Offset = "0x569B8A0", VA = "0x18569C8A0", Slot = "4")]
		protected override FHAEBCGCGLC PFHMPNFJNFB()
		{
			return default(FHAEBCGCGLC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6FEAA10", Offset = "0x6FE9A10", VA = "0x186FEAA10")]
		public ConfigurablePipelineGraphDriver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6FEA0B0", Offset = "0x6FE90B0", VA = "0x186FEA0B0", Slot = "15")]
		private void DIIAIAOBCHP(in RawMetric KBKHLEKAJLM)
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
		[Cpp2IlInjected.Address(RVA = "0x6FED780", Offset = "0x6FEC780", VA = "0x186FED780")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6FEDB60", Offset = "0x6FECB60", VA = "0x186FEDB60")]
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
		[Header("Accumulation")]
		[Min(0f)]
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
		protected override int NMKPJMJAPIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xFC4210", Offset = "0xFC3210", VA = "0x180FC4210", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected override MetricAccumulateMode HJADFHFHCMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x11DE030", Offset = "0x11DD030", VA = "0x1811DE030", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1E3E250", Offset = "0x1E3D250", VA = "0x181E3E250", Slot = "4")]
		protected override FHAEBCGCGLC PFHMPNFJNFB()
		{
			return default(FHAEBCGCGLC);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6FF01E0", Offset = "0x6FEF1E0", VA = "0x186FF01E0")]
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
		protected override int NMKPJMJAPIH
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xFC4210", Offset = "0xFC3210", VA = "0x180FC4210", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		protected override MetricAccumulateMode HJADFHFHCMA
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x11DE030", Offset = "0x11DD030", VA = "0x1811DE030", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8682E0", Offset = "0x8672E0", VA = "0x1808682E0", Slot = "4")]
		protected override FHAEBCGCGLC PFHMPNFJNFB()
		{
			return default(FHAEBCGCGLC);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6FEABC0", Offset = "0x6FE9BC0", VA = "0x186FEABC0", Slot = "14")]
		protected override bool BOGDHPFPJEA(string JGFIAJIMOBH = "0.00", [Optional] string PKLBLJKDKEJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6FEACC0", Offset = "0x6FE9CC0", VA = "0x186FEACC0")]
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
		private bool KKNGJCHJBJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[SerializeField]
		private TMP_Text categoryText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private bool LHKLJMEOKPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[SerializeField]
		private TMP_Text descriptionText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private bool PNNCOBJNOJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[SerializeField]
		[Header("Data Text")]
		private TMP_Text samplesText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private bool OFJPKMIKONO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[SerializeField]
		private TMP_Text curText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private bool EADEGLFEAOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[SerializeField]
		private TMP_Text minText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private bool JPGHEHLBFCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[SerializeField]
		private TMP_Text maxText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private bool HOPJNAKPAKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[SerializeField]
		private TMP_Text avgText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private bool DPDEIPFPHPK;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string BEJNBHDKECN
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6FEE600", Offset = "0x6FED600", VA = "0x186FEE600")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6FEE880", Offset = "0x6FED880", VA = "0x186FEE880")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string AGNADKEKANA
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6FEE380", Offset = "0x6FED380", VA = "0x186FEE380")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6FEE740", Offset = "0x6FED740", VA = "0x186FEE740")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public string OKEMJPBKNII
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6FEE480", Offset = "0x6FED480", VA = "0x186FEE480")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6FEE7C0", Offset = "0x6FED7C0", VA = "0x186FEE7C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string FBFLFJDPFBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6FEE680", Offset = "0x6FED680", VA = "0x186FEE680")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6FEE8C0", Offset = "0x6FED8C0", VA = "0x186FEE8C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public string HBEJPLHOEDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6FEE400", Offset = "0x6FED400", VA = "0x186FEE400")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6FEE780", Offset = "0x6FED780", VA = "0x186FEE780")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public string EBLLCDEALOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6FEE580", Offset = "0x6FED580", VA = "0x186FEE580")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6FEE840", Offset = "0x6FED840", VA = "0x186FEE840")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public string IFGBDDMGFLL
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6FEE500", Offset = "0x6FED500", VA = "0x186FEE500")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6FEE800", Offset = "0x6FED800", VA = "0x186FEE800")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public string LJHGKHLLMIO
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6FEE300", Offset = "0x6FED300", VA = "0x186FEE300")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6FEE700", Offset = "0x6FED700", VA = "0x186FEE700")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6FEE210", Offset = "0x6FED210", VA = "0x186FEE210", Slot = "4")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6FEE150", Offset = "0x6FED150", VA = "0x186FEE150")]
		protected string JAAPGDGAJBF(bool MNPBDNKCMFO, ref TMP_Text LPNPMOOMCIB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6FEE1D0", Offset = "0x6FED1D0", VA = "0x186FEE1D0")]
		protected void MFIHGIOAPEG(bool CEFMDLAHDDM, ref TMP_Text FBOMMBLFPCD, string CKDFGEALFAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x85F0C0", Offset = "0x85E0C0", VA = "0x18085F0C0")]
		public MetricGraphTextDisplay()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[DefaultMember("Item")]
public class IGEGGMFFFLO
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class POLCPFNAAAF : IEnumerable<float>, IEnumerable, IEnumerator<float>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private float <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private int maxCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public int <>3__maxCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public IGEGGMFFFLO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private int <startIndex>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private int <index>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		float IEnumerator<float>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xDFAC90", Offset = "0xDF9C90", VA = "0x180DFAC90", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6FEFFC0", Offset = "0x6FEEFC0", VA = "0x186FEFFC0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x12F8CD0", Offset = "0x12F7CD0", VA = "0x1812F8CD0")]
		[DebuggerHidden]
		public POLCPFNAAAF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6FEFDE0", Offset = "0x6FEEDE0", VA = "0x186FEFDE0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6FEFF80", Offset = "0x6FEEF80", VA = "0x186FEFF80", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6FEFED0", Offset = "0x6FEEED0", VA = "0x186FEFED0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<float> IEnumerable<float>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6FEFED0", Offset = "0x6FEEED0", VA = "0x186FEFED0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	protected float[] GBLNCJMPJFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	protected int EFEFKLCNJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	protected int LEOAEOJMCHD;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int NMOEOEAONON
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xAA9110", Offset = "0xAA8110", VA = "0x180AA9110")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int BBEIOLGDHLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xC9D8A0", Offset = "0xC9C8A0", VA = "0x180C9D8A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float ODFHKFOMEMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6FEB320", Offset = "0x6FEA320", VA = "0x186FEB320")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public float LNOEECDFLEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6FEAF70", Offset = "0x6FE9F70", VA = "0x186FEAF70")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float CLDBOBAGHND
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6FE94D0", Offset = "0x6FE84D0", VA = "0x186FE94D0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6FEB330", Offset = "0x6FEA330", VA = "0x186FEB330")]
	public IGEGGMFFFLO(int OENKBEGLEDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6FEB1C0", Offset = "0x6FEA1C0", VA = "0x186FEB1C0")]
	public void HBFHMDFJCGO(int PHNOCPKDIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6FEB250", Offset = "0x6FEA250", VA = "0x186FEB250")]
	public void ODLEPPPKPKC(float CKDFGEALFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x56DC1F0", Offset = "0x56DB1F0", VA = "0x1856DC1F0")]
	public void AICHNDKKPDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6FEB000", Offset = "0x6FEA000", VA = "0x186FEB000")]
	public IEnumerable<float> EFMAOEFHKOG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6FEAF80", Offset = "0x6FE9F80", VA = "0x186FEAF80")]
	[IteratorStateMachine(typeof(POLCPFNAAAF))]
	public IEnumerable<float> EFMAOEFHKOG(int IGMIPOFKKKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6FE93D0", Offset = "0x6FE83D0", VA = "0x186FE93D0")]
	public void GGBIFBAOCAH(float[] FBOMMBLFPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6FEB0B0", Offset = "0x6FEA0B0", VA = "0x186FEB0B0")]
	public void GGBIFBAOCAH(float[] FBOMMBLFPCD, int KCPPDOCICGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6FEB080", Offset = "0x6FEA080", VA = "0x186FEB080")]
	private int FIBOOOBMONJ(int CCELBNKPBGB)
	{
		return default(int);
	}
}
namespace RecRoom.Profiling
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MetricGraph : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private ProfilerMarker GDHIMLFMHIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private ProfilerMarker FDFEHPFIGAN;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private const int JJFLFMLFHGH = 8;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private const int DOFBFMAIDCE = 512;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[SerializeField]
		[Header("Buffer")]
		[Range(8f, 512f)]
		private int bufferCapacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private IGEGGMFFFLO MEJIPNBFNAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private bool NFOFKIMILKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private float DAOCPBLHAEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private float GPJFDHLLGCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private float GLDDLNCOPGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private float COALAKKKDPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private float PFBGKGNEIGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[SerializeField]
		[Header("Graph")]
		private RawImage graphImageTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[Space]
		[SerializeField]
		[FormerlySerializedAs("graphImageShaderFull")]
		private Shader shaderFull;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[SerializeField]
		[FormerlySerializedAs("graphImageShaderLight")]
		private Shader shaderLight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[SerializeField]
		private bool useLightShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x69")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[SerializeField]
		[Header("Graph Visuals")]
		private bool isZeroBased;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[SerializeField]
		[Range(1f, 10f)]
		private float resolutionScalar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[SerializeField]
		private Color baseValueColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[SerializeField]
		[Space]
		private bool showAverageBar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[SerializeField]
		private Color averageBarColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[Space]
		[SerializeField]
		private bool showThresholdBars;

		[Cpp2IlInjected.FieldOffset(Offset = "0x95")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[SerializeField]
		private bool higherValueIsBetter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[SerializeField]
		private int cautionValueThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[SerializeField]
		private Color cautionValueColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[SerializeField]
		private int criticalValueThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[SerializeField]
		private Color criticalValueColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private JMJGBILLFNO MCADHBFIJBJ;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private int IOJANHAOACK
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6FEE950", Offset = "0x6FED950", VA = "0x186FEE950")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private int NMJEPAHJPBL
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6FEF430", Offset = "0x6FEE430", VA = "0x186FEF430")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private int OBKHFKHKGAO
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6FEF450", Offset = "0x6FEE450", VA = "0x186FEF450")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public int LGCOOIAGMDC
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x6FEFDC0", Offset = "0x6FEEDC0", VA = "0x186FEFDC0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int JIAJHPKEPJB
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x6FEFD90", Offset = "0x6FEED90", VA = "0x186FEFD90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float BDDCPPDOJCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6FEFCF0", Offset = "0x6FEECF0", VA = "0x186FEFCF0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float NEJHIMAKIJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x6FEFD30", Offset = "0x6FEED30", VA = "0x186FEFD30")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float JBACCMNKHDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x6FEFD10", Offset = "0x6FEED10", VA = "0x186FEFD10")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float GMJBOPNPIPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6FEFD50", Offset = "0x6FEED50", VA = "0x186FEFD50")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float HMFAKFNIICG
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6FEFD70", Offset = "0x6FEED70", VA = "0x186FEFD70")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6FEE900", Offset = "0x6FED900", VA = "0x186FEE900")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6FEFAD0", Offset = "0x6FEEAD0", VA = "0x186FEFAD0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6FEF6F0", Offset = "0x6FEE6F0", VA = "0x186FEF6F0")]
		public void PushSample(double KJMMBINIMFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6FEE930", Offset = "0x6FED930", VA = "0x186FEE930")]
		public void ClearSamples()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6FEF4C0", Offset = "0x6FEE4C0", VA = "0x186FEF4C0")]
		private void OJHFKJBLBKK(bool HNGHLFFJCGK = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6FEF7E0", Offset = "0x6FEE7E0", VA = "0x186FEF7E0")]
		public void UpdateShader()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6FEE970", Offset = "0x6FED970", VA = "0x186FEE970")]
		public void InitData(int CIDOOCPECLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6FEEB00", Offset = "0x6FEDB00", VA = "0x186FEEB00")]
		private void LDMCGIGANDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6FEFB00", Offset = "0x6FEEB00", VA = "0x186FEFB00")]
		public MetricGraph()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class JMJGBILLFNO
{
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public const int HBMJLBINGCK = 512;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public const int CGKEEMJAGPD = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public int IHEHIFOFBCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public float[] PDDDGPNPBLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public RawImage JGMIKIBCPFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float AKBLDMGFNFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float CGMBMGAFJBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public float FINBPCFLFDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public float DHMAFBJBLCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public float MPKGGLKCEFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public Color BAMLODJHAPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public Color FAHPBHIHJIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public bool IPGHGBKGJIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public Color MELEIMIMKCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public Color PGPPFIBDMMJ;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly int AIBCPENOPMK;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static readonly int KBFEIAOBDPM;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly int HONDGCPDBEF;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly int JMAKACHGAHA;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly int PBNDHAEMDCG;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static readonly int CCJCNMDGEPN;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly int BLEDJOCMHCD;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly int FDHABCKNIPC;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly int JCFEMDELMAE;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static readonly int LOPMGNHAAPP;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static readonly int KDPBCBAPNON;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static readonly int PKDGIALIGLA;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6FEB530", Offset = "0x6FEA530", VA = "0x186FEB530")]
	public void CILOKEPMFFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6FEB3A0", Offset = "0x6FEA3A0", VA = "0x186FEB3A0")]
	public void BLCFMCFGGIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6FEB910", Offset = "0x6FEA910", VA = "0x186FEB910")]
	public void KNGLDJFFAKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6FEB450", Offset = "0x6FEA450", VA = "0x186FEB450")]
	public void CAFLLBALKGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6FEB770", Offset = "0x6FEA770", VA = "0x186FEB770")]
	public void IGBECJPGIIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6FEB6D0", Offset = "0x6FEA6D0", VA = "0x186FEB6D0")]
	public void HAPJGMHCFDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6FEB5F0", Offset = "0x6FEA5F0", VA = "0x186FEB5F0")]
	public void FAFCONNLNDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6FEBBE0", Offset = "0x6FEABE0", VA = "0x186FEBBE0")]
	public JMJGBILLFNO()
	{
	}
}
namespace RecRoom.Profiling
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class ProfilingMetricGraphDriver : SingleMetricGraphDriver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[SerializeField]
		[Header("Profiling Metric")]
		public string metricCategoryName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[SerializeField]
		public string metricName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private ProfilerRecorderHandle KIKDJKEFOCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[SerializeField]
		[Min(0f)]
		[Header("Accumulation")]
		private int framesToAccumulate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[SerializeField]
		private MetricAccumulateMode accumulateModeToUse;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static bool LGLGMOLMJFI;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool ILLFJDKKNMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x6FF01D0", Offset = "0x6FEF1D0", VA = "0x186FF01D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		protected override int NMKPJMJAPIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x9BDA60", Offset = "0x9BCA60", VA = "0x1809BDA60", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		protected override MetricAccumulateMode HJADFHFHCMA
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x1422690", Offset = "0x1421690", VA = "0x181422690", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xC07AB0", Offset = "0xC06AB0", VA = "0x180C07AB0", Slot = "4")]
		protected override FHAEBCGCGLC PFHMPNFJNFB()
		{
			return default(FHAEBCGCGLC);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6FF0010", Offset = "0x6FEF010", VA = "0x186FF0010", Slot = "14")]
		protected override bool BOGDHPFPJEA(string JGFIAJIMOBH = "0.00", [Optional] string PKLBLJKDKEJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6FF0130", Offset = "0x6FEF130", VA = "0x186FF0130")]
		public ProfilingMetricGraphDriver()
		{
		}
	}
}
namespace RecRoom.Profiling.Configs
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class GraphConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public string FriendlyDescription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public string MetricSourceName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public string MetricName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public int FramesToAccumulate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public int BufferSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public MetricAccumulateMode MetricAccumulateMode;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6FEAE70", Offset = "0x6FE9E70", VA = "0x186FEAE70")]
		public GraphConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class GraphConfigAsset : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		[SerializeField]
		private GraphConfig graphConfig;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public GraphConfig GraphConfig
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA756E0", Offset = "0xA746E0", VA = "0x180A756E0")]
		public GraphConfigAsset()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface EAFOANBCFPG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool OAEPAJFJIBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	MetricDescription BJFKMLODOFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "3")]
	RawMetricPayload IKJAIDGBFHC();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class HGDKKNJINDG : EAFOANBCFPG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly Func<double> MOEIINIHEOJ;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool OAEPAJFJIBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x85F3D0", Offset = "0x85E3D0", VA = "0x18085F3D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x91B1A0", Offset = "0x91A1A0", VA = "0x18091B1A0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public MetricDescription BJFKMLODOFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2983F00", Offset = "0x2982F00", VA = "0x182983F00", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(MetricDescription);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6FEAF20", Offset = "0x6FE9F20", VA = "0x186FEAF20")]
	public HGDKKNJINDG(Func<double> MOEIINIHEOJ, MetricDescription PPDDAJBGMDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6FEAE90", Offset = "0x6FE9E90", VA = "0x186FEAE90", Slot = "7")]
	public RawMetricPayload IKJAIDGBFHC()
	{
		return default(RawMetricPayload);
	}
}
namespace RecRoom.Profiling.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class MetricGraphDriverBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		protected const string HAMOLAIAHHB = "0.00";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		protected double CGDAFMOADDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		protected double HACIBJJFDJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		protected double OFFNJKGEHIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		protected double PDEKCGDHAPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		protected double KLBEPPBNHLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		protected int HOIJEJLHHDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		protected double BMFPOJNFGHG;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		protected abstract int NMKPJMJAPIH
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		protected abstract MetricAccumulateMode HJADFHFHCMA
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		protected bool LNKPNPCJAJP
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x90AF40", Offset = "0x909F40", VA = "0x18090AF40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xC9A990", Offset = "0xC99990", VA = "0x180C9A990")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract FHAEBCGCGLC PFHMPNFJNFB();

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected abstract void JHOFBOAPCJD();

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xB932D0", Offset = "0xB922D0", VA = "0x180B932D0", Slot = "9")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xB932D0", Offset = "0xB922D0", VA = "0x180B932D0")]
		protected void CJGFMLHFLKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6FEDC20", Offset = "0x6FECC20", VA = "0x186FEDC20", Slot = "10")]
		protected virtual void DELLLFJHFCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6FEDC60", Offset = "0x6FECC60", VA = "0x186FEDC60", Slot = "11")]
		protected virtual void ECBFNAPCKOA(double AFMPBLNCGHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6FEDEA0", Offset = "0x6FECEA0", VA = "0x186FEDEA0", Slot = "12")]
		protected virtual double NFBHPGEJHEC(MetricAccumulateMode GPAHABKIEBD)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6FEDD40", Offset = "0x6FECD40", VA = "0x186FEDD40")]
		protected bool JJKHGDAOEHI(MetricGraph CIJNNIEBNOP, MetricAccumulateMode LPLFJNECDIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6FEDFF0", Offset = "0x6FECFF0", VA = "0x186FEDFF0", Slot = "13")]
		protected virtual string PIAPPMIJKJM(double CKDFGEALFAK, string PEGDKDFABOG = "0.00", [Optional] string GEICHAPFOAP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6FEE110", Offset = "0x6FED110", VA = "0x186FEE110")]
		protected MetricGraphDriverBase()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class LAHIGMFFPBI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private readonly struct BMPENHIIGFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public readonly string KJLMEHCPOCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public readonly string NKEBGCLPDIL;

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xA891D0", Offset = "0xA881D0", VA = "0x180A891D0")]
		public BMPENHIIGFJ(string JELMDLJIGIE, string IBLIJFHAEIO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class FOMAEAIGNBF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public LAHIGMFFPBI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public FOMAEAIGNBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6FEAA60", Offset = "0x6FE9A60", VA = "0x186FEAA60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly MetricIdLookup MFOOFEPJIDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly IRawMetricsPipeline IKHIDBMHABI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly IMetricCollectionRegistry LLDJNFDKDMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly CancellationTokenSource IGGNLLGJDCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly Dictionary<MetricId, EAFOANBCFPG> PFNLBHOIFPH;

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private static readonly BMPENHIIGFJ[] GLPGGINOIND;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6FEBC80", Offset = "0x6FEAC80", VA = "0x186FEBC80")]
	[FBCFLFBFGIL(LAFFCBAHJKM.GameOnly)]
	private static void BGLPJMCJCBB(CNALHHIKJDD HDIGDGEFOCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6FECEC0", Offset = "0x6FEBEC0", VA = "0x186FECEC0")]
	[Preserve]
	public LAHIGMFFPBI([JFLEHDEIONF(null)] MetricIdLookup MFOOFEPJIDA, [JFLEHDEIONF(null)] IRawMetricsPipeline IKHIDBMHABI, [JFLEHDEIONF(null)] IMetricCollectionRegistry LLDJNFDKDMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6FEC160", Offset = "0x6FEB160", VA = "0x186FEC160")]
	private void FGAOPKJOFKI(string JAPDGOBGLIM, string IBLIJFHAEIO, FHAEBCGCGLC DHPOCOKHLLA, Func<double> MOEIINIHEOJ, out MetricId EHJDDIBNKDD, out EAFOANBCFPG LPNPMOOMCIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6FEC220", Offset = "0x6FEB220", VA = "0x186FEC220")]
	private void HCNCJJBFILL(MetricId EHJDDIBNKDD, bool GJIJMEPKDIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6FEBD70", Offset = "0x6FEAD70", VA = "0x186FEBD70")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FOMAEAIGNBF))]
	private Task BJBDGDDGMHC(CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6FEBEC0", Offset = "0x6FEAEC0", VA = "0x186FEBEC0")]
	public void CAANPILOGID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6FEC120", Offset = "0x6FEB120", VA = "0x186FEC120", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.Profiling.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public abstract class SingleMetricGraphDriver : MetricGraphDriverBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		[SerializeField]
		protected string debugDescription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[SerializeField]
		[FormerlySerializedAs("targetGraph")]
		[Header("Graph and Text")]
		protected MetricGraph graphDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		protected bool OGILOHEBBME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[SerializeField]
		protected MetricGraphTextDisplay textDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		protected bool BMONHLHNAIH;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6FF0730", Offset = "0x6FEF730", VA = "0x186FF0730", Slot = "9")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6FF0570", Offset = "0x6FEF570", VA = "0x186FF0570", Slot = "5")]
		protected override void JHOFBOAPCJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6FF0230", Offset = "0x6FEF230", VA = "0x186FF0230", Slot = "14")]
		protected virtual bool BOGDHPFPJEA(string JGFIAJIMOBH = "0.00", [Optional] string PKLBLJKDKEJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6FEE110", Offset = "0x6FED110", VA = "0x186FEE110")]
		protected SingleMetricGraphDriver()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class AOFFPAJCDNC : EAFOANBCFPG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static bool LGLGMOLMJFI;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static Dictionary<(ushort category, string name), ProfilerRecorderHandle> EGGGBJELCLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly MetricId EHJDDIBNKDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly string JELMDLJIGIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private readonly string IBLIJFHAEIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private ProfilerRecorder HANPINMDECP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private bool ILAJCLJEFHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private bool DNLBHGPABGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private ProfilerRecorderDescription OPGPEEGNFMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private ProfilerRecorderHandle KIKDJKEFOCM;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool OAEPAJFJIBC
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x9127F0", Offset = "0x9117F0", VA = "0x1809127F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x912800", Offset = "0x911800", VA = "0x180912800", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public MetricDescription BJFKMLODOFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x15CA210", Offset = "0x15C9210", VA = "0x1815CA210", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(MetricDescription);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x15CA200", Offset = "0x15C9200", VA = "0x1815CA200")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool ILLFJDKKNMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6FE9580", Offset = "0x6FE8580", VA = "0x186FE9580")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6FE9ED0", Offset = "0x6FE8ED0", VA = "0x186FE9ED0")]
	public AOFFPAJCDNC(MetricId EHJDDIBNKDD, string JELMDLJIGIE, string IBLIJFHAEIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6FE9C30", Offset = "0x6FE8C30", VA = "0x186FE9C30", Slot = "7")]
	public RawMetricPayload IKJAIDGBFHC()
	{
		return default(RawMetricPayload);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6FE9CF0", Offset = "0x6FE8CF0", VA = "0x186FE9CF0")]
	private static ProfilerRecorderHandle NOOCMPAKKDP(string JELMDLJIGIE, string IBLIJFHAEIO)
	{
		return default(ProfilerRecorderHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6FE9900", Offset = "0x6FE8900", VA = "0x186FE9900")]
	private void FLMBBALLJKD(bool HNGHLFFJCGK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6FE9590", Offset = "0x6FE8590", VA = "0x186FE9590")]
	private static MetricDescription DLJLCHKGGBJ(MetricId EHJDDIBNKDD, ProfilerRecorderDescription CCIFOJKNEKO)
	{
		return default(MetricDescription);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6FE9630", Offset = "0x6FE8630", VA = "0x186FE9630")]
	private static bool EDHKJCFOCGK(bool HNGHLFFJCGK = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6FE9610", Offset = "0x6FE8610", VA = "0x186FE9610")]
	private void KPFDOOFINED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6FE9610", Offset = "0x6FE8610", VA = "0x186FE9610", Slot = "8")]
	public void Dispose()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class MHGFMJKAFPI
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	public MHGFMJKAFPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0xBB9C20", Offset = "0xBB8C20", VA = "0x180BB9C20")]
	public static string KILOLNAHAFI(byte[] BKIADALNNFJ, byte[] EEICCMPLMOJ)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
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

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
		protected override int INHGPJGPPPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0xA48710", Offset = "0xA47B10", VA = "0x180A48710", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected override MetricAccumulateMode LMJLBKKJJCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x1B0EAF0", Offset = "0x1B0DEF0", VA = "0x181B0EAF0", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9D83A0", Offset = "0x9D77A0", VA = "0x1809D83A0", Slot = "4")]
		protected override PIFOJDLDNHM PIOJAHMGBBC()
		{
			return default(PIFOJDLDNHM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6F773F0", Offset = "0x6F767F0", VA = "0x186F773F0", Slot = "14")]
		protected override bool GBDIGOKCMEN(string CKLDMLJKNMC = "0.00", [Optional] string FEONDPJALLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6F774D0", Offset = "0x6F768D0", VA = "0x186F774D0")]
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
		private MetricIdLookup CFEOGLGJAPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private IRawMetricsPipeline DDOLFOBKEGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private IMetricCollectionRegistry HGFNADONOHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private MetricId HMFBJHABLIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private int JABHGGBKING;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private MetricAccumulateMode EPCMEODCMCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private MetricCollectionToken AEMEEHLIDCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private MetricDescription JIFJEMNCEHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private GraphConfig LNLKKKGANCD;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		protected override int INHGPJGPPPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x12F77D0", Offset = "0x12F6BD0", VA = "0x1812F77D0", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected override MetricAccumulateMode LMJLBKKJJCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xC77E60", Offset = "0xC77260", VA = "0x180C77E60", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6F76850", Offset = "0x6F75C50", VA = "0x186F76850")]
		private void IEEGKBGJEBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6F765E0", Offset = "0x6F759E0", VA = "0x186F765E0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6F76F30", Offset = "0x6F76330", VA = "0x186F76F30", Slot = "9")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6F76E30", Offset = "0x6F76230", VA = "0x186F76E30")]
		protected void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6F769B0", Offset = "0x6F75DB0", VA = "0x186F769B0")]
		public void Initialize(GraphConfig CEFAEBFHKMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6F76640", Offset = "0x6F75A40", VA = "0x186F76640", Slot = "14")]
		protected override bool GBDIGOKCMEN(string CKLDMLJKNMC = "0.00", [Optional] string FEONDPJALLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6F76750", Offset = "0x6F75B50", VA = "0x186F76750")]
		public void HandleMetric(in RawMetric FHNMJFGGLGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xAD2260", Offset = "0xAD1660", VA = "0x180AD2260", Slot = "4")]
		protected override PIFOJDLDNHM PIOJAHMGBBC()
		{
			return default(PIFOJDLDNHM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6F770B0", Offset = "0x6F764B0", VA = "0x186F770B0")]
		public ConfigurablePipelineGraphDriver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6F76750", Offset = "0x6F75B50", VA = "0x186F76750", Slot = "15")]
		private void LHHAMCMAEON(in RawMetric FHNMJFGGLGM)
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
		[Cpp2IlInjected.Address(RVA = "0x6F79DF0", Offset = "0x6F791F0", VA = "0x186F79DF0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A1D0", Offset = "0x6F795D0", VA = "0x186F7A1D0")]
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
		protected override int INHGPJGPPPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xA48710", Offset = "0xA47B10", VA = "0x180A48710", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected override MetricAccumulateMode LMJLBKKJJCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x1B0EAF0", Offset = "0x1B0DEF0", VA = "0x181B0EAF0", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1E1BE20", Offset = "0x1E1B220", VA = "0x181E1BE20", Slot = "4")]
		protected override PIFOJDLDNHM PIOJAHMGBBC()
		{
			return default(PIFOJDLDNHM);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6F7CF00", Offset = "0x6F7C300", VA = "0x186F7CF00")]
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
		protected override int INHGPJGPPPN
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xA48710", Offset = "0xA47B10", VA = "0x180A48710", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		protected override MetricAccumulateMode LMJLBKKJJCL
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x1B0EAF0", Offset = "0x1B0DEF0", VA = "0x181B0EAF0", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8C9920", Offset = "0x8C8D20", VA = "0x1808C9920", Slot = "4")]
		protected override PIFOJDLDNHM PIOJAHMGBBC()
		{
			return default(PIFOJDLDNHM);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6F77260", Offset = "0x6F76660", VA = "0x186F77260", Slot = "14")]
		protected override bool GBDIGOKCMEN(string CKLDMLJKNMC = "0.00", [Optional] string FEONDPJALLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6F77360", Offset = "0x6F76760", VA = "0x186F77360")]
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
		private bool JMHOCPIJKMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[SerializeField]
		private TMP_Text categoryText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private bool MNHHOKODFNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[SerializeField]
		private TMP_Text descriptionText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private bool GOKALGNKBGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[SerializeField]
		[Header("Data Text")]
		private TMP_Text samplesText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private bool OGIHJHDKBOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[SerializeField]
		private TMP_Text curText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private bool BLOIIEAEPEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[SerializeField]
		private TMP_Text minText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private bool PICHINHIONB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[SerializeField]
		private TMP_Text maxText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private bool LBNHABDAAPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[SerializeField]
		private TMP_Text avgText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private bool DEJNECNHIKB;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string GPFHDKCJMNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6F7AC70", Offset = "0x6F7A070", VA = "0x186F7AC70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6F7AEF0", Offset = "0x6F7A2F0", VA = "0x186F7AEF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string NEFBKNGKBNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6F7A9F0", Offset = "0x6F79DF0", VA = "0x186F7A9F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6F7ADB0", Offset = "0x6F7A1B0", VA = "0x186F7ADB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public string NDLNOAACMFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6F7AAF0", Offset = "0x6F79EF0", VA = "0x186F7AAF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6F7AE30", Offset = "0x6F7A230", VA = "0x186F7AE30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string HBOIBOMPEOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6F7ACF0", Offset = "0x6F7A0F0", VA = "0x186F7ACF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6F7AF30", Offset = "0x6F7A330", VA = "0x186F7AF30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public string BPKNNNLCKEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6F7AA70", Offset = "0x6F79E70", VA = "0x186F7AA70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6F7ADF0", Offset = "0x6F7A1F0", VA = "0x186F7ADF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public string OJIKIKHPJII
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6F7ABF0", Offset = "0x6F79FF0", VA = "0x186F7ABF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6F7AEB0", Offset = "0x6F7A2B0", VA = "0x186F7AEB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public string JAPPJHFPLFI
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6F7AB70", Offset = "0x6F79F70", VA = "0x186F7AB70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6F7AE70", Offset = "0x6F7A270", VA = "0x186F7AE70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public string HPCMHBGDIAE
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6F7A970", Offset = "0x6F79D70", VA = "0x186F7A970")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6F7AD70", Offset = "0x6F7A170", VA = "0x186F7AD70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A880", Offset = "0x6F79C80", VA = "0x186F7A880", Slot = "4")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A7C0", Offset = "0x6F79BC0", VA = "0x186F7A7C0")]
		protected string ABIKDBDPAKO(bool HCAJAHIONDJ, ref TMP_Text OIEACLJHHPB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A840", Offset = "0x6F79C40", VA = "0x186F7A840")]
		protected void ICIJNPJELMI(bool POIDMNNHCAN, ref TMP_Text JNHEGOFDJBP, string AGLCIEKHLEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x976820", Offset = "0x975C20", VA = "0x180976820")]
		public MetricGraphTextDisplay()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[DefaultMember("Item")]
public class GLFJFBOHGBK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	protected float[] PGJHEOJPLFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	protected int EFKBDMDDHHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	protected int FJFMKNIHPDJ;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int HIBMACOFNKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xB2D6E0", Offset = "0xB2CAE0", VA = "0x180B2D6E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int EENLDMFFFJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1AF1A30", Offset = "0x1AF0E30", VA = "0x181AF1A30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float LDPKJEKCPKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6F776F0", Offset = "0x6F76AF0", VA = "0x186F776F0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public float DMGMOCHEOPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6F777C0", Offset = "0x6F76BC0", VA = "0x186F777C0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float ONEIGHFFEDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6F76530", Offset = "0x6F75930", VA = "0x186F76530")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6F777D0", Offset = "0x6F76BD0", VA = "0x186F777D0")]
	public GLFJFBOHGBK(int GLDHDJHPIPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6F77700", Offset = "0x6F76B00", VA = "0x186F77700")]
	public void HKAHNIEBCAA(int ILJAKNJOLFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6F77510", Offset = "0x6F76910", VA = "0x186F77510")]
	public void CNHKAHDIAAP(float AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x46FEBD0", Offset = "0x46FDFD0", VA = "0x1846FEBD0")]
	public void EDHPOEPIGJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6F76430", Offset = "0x6F75830", VA = "0x186F76430")]
	public void DBIODMNEHAB(float[] JNHEGOFDJBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6F775E0", Offset = "0x6F769E0", VA = "0x186F775E0")]
	public void DBIODMNEHAB(float[] JNHEGOFDJBP, int ONDDFDHPFLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6F77790", Offset = "0x6F76B90", VA = "0x186F77790")]
	private int JNNPCKHAPCM(int BNOAGGNAMKG)
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
		private ProfilerMarker EPFOIGKKCMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private ProfilerMarker EOMNHELBKHN;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private const int NHJINLFJLCP = 8;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private const int MNAEKJKFHBP = 512;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[SerializeField]
		[Range(8f, 512f)]
		[Header("Buffer")]
		private int bufferCapacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private GLFJFBOHGBK JBPBLNIELJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool AHDHODJNPDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private float GEBACEPKLNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private float JEOPNPPANDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private float INOELDIAAAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private float OCLHDLEIFLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private float CNNBLNAHIOK;

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
		private PEDJCKMGMKL DIIBCONHPIN;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private int FACPJLLLKCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x6F7BD40", Offset = "0x6F7B140", VA = "0x186F7BD40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private int NBODFPJMLCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6F7B1C0", Offset = "0x6F7A5C0", VA = "0x186F7B1C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private int JHLGJJDJEAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x6F7AFC0", Offset = "0x6F7A3C0", VA = "0x186F7AFC0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public int MHDEHOCMCLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6F7C430", Offset = "0x6F7B830", VA = "0x186F7C430")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public int ECCGMLPAENA
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6F7C400", Offset = "0x6F7B800", VA = "0x186F7C400")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float AAIAPKEKDLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6F7C360", Offset = "0x6F7B760", VA = "0x186F7C360")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float GDBDOFEBCMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6F7C3A0", Offset = "0x6F7B7A0", VA = "0x186F7C3A0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float AJFDCNPDPMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6F7C380", Offset = "0x6F7B780", VA = "0x186F7C380")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float HIKDPIOINDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x6F7C3C0", Offset = "0x6F7B7C0", VA = "0x186F7C3C0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float GJGBGINGPPM
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6F7C3E0", Offset = "0x6F7B7E0", VA = "0x186F7C3E0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6F7AF70", Offset = "0x6F7A370", VA = "0x186F7AF70")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6F7C140", Offset = "0x6F7B540", VA = "0x186F7C140")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6F7BD60", Offset = "0x6F7B160", VA = "0x186F7BD60")]
		public void PushSample(double MELDNEOHOKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6F7AFA0", Offset = "0x6F7A3A0", VA = "0x186F7AFA0")]
		public void ClearSamples()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6F7BB10", Offset = "0x6F7AF10", VA = "0x186F7BB10")]
		private void OEGEGBCKMJJ(bool DGLCECEILBL = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6F7BE50", Offset = "0x6F7B250", VA = "0x186F7BE50")]
		public void UpdateShader()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6F7B030", Offset = "0x6F7A430", VA = "0x186F7B030")]
		public void InitData(int DGCAOEOPHGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6F7B1E0", Offset = "0x6F7A5E0", VA = "0x186F7B1E0")]
		private void MFCNMPHKION()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6F7C170", Offset = "0x6F7B570", VA = "0x186F7C170")]
		public MetricGraph()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class PEDJCKMGMKL
{
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public const int BFLCHCEEAOO = 512;

	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public const int OHKAHAGMBLE = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public int GLAINAKJPME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public float[] NCAEFAEKHMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public RawImage CNFOLECLFAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public float PFOCFJBCPCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public float FFFGMAEAJFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public float IALGOKHOHDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public float DCBCKLHGBBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public float DNMDGLCFPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public Color MIJDEAFNMFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public Color BGMPGGMOCKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public bool OHJKCOOHHPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public Color NCELKLNENOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public Color FCJGBNFAHBP;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static readonly int MCGPKMMCEAL;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly int FMBHGNBNMLM;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static readonly int FAJPLCLBAFD;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static readonly int EMNLBOLCCNN;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly int GOBFJAPJAGC;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly int CPCCNIIJGAB;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static readonly int PHLDFKNNOLM;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static readonly int AMFDEJEIJJF;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static readonly int BNIFAPBACHI;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly int MNHIHACOBLE;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static readonly int FDCODFLGKPJ;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly int JPODKCGENHO;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6F7C500", Offset = "0x6F7B900", VA = "0x186F7C500")]
	public void BILKHHCNFFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6F7C450", Offset = "0x6F7B850", VA = "0x186F7C450")]
	public void BDILIHPDMOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6F7C8E0", Offset = "0x6F7BCE0", VA = "0x186F7C8E0")]
	public void KMPNNBJFHLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6F7C980", Offset = "0x6F7BD80", VA = "0x186F7C980")]
	public void OAAPOBFNJJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6F7C740", Offset = "0x6F7BB40", VA = "0x186F7C740")]
	public void HNIMKHBLHCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6F7C5C0", Offset = "0x6F7B9C0", VA = "0x186F7C5C0")]
	public void FBDEJCMKGMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6F7C660", Offset = "0x6F7BA60", VA = "0x186F7C660")]
	public void GOJBGBGCDLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6F7CC90", Offset = "0x6F7C090", VA = "0x186F7CC90")]
	public PEDJCKMGMKL()
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
		private ProfilerRecorderHandle PFABMINAILC;

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
		private static bool FOBNKNLBIAG;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool GJCDANEPDGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x6F7CEF0", Offset = "0x6F7C2F0", VA = "0x186F7CEF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		protected override int INHGPJGPPPN
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x8C0310", Offset = "0x8BF710", VA = "0x1808C0310", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		protected override MetricAccumulateMode LMJLBKKJJCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x12F77D0", Offset = "0x12F6BD0", VA = "0x1812F77D0", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9D83A0", Offset = "0x9D77A0", VA = "0x1809D83A0", Slot = "4")]
		protected override PIFOJDLDNHM PIOJAHMGBBC()
		{
			return default(PIFOJDLDNHM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6F7CD30", Offset = "0x6F7C130", VA = "0x186F7CD30", Slot = "14")]
		protected override bool GBDIGOKCMEN(string CKLDMLJKNMC = "0.00", [Optional] string FEONDPJALLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6F7CE50", Offset = "0x6F7C250", VA = "0x186F7CE50")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F77840", Offset = "0x6F76C40", VA = "0x186F77840")]
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
			[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x9840D0", Offset = "0x9834D0", VA = "0x1809840D0")]
		public GraphConfigAsset()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface EDIGDEIAABH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool GKODBKCLOCN
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
	RawMetricPayload OPIIBEHBDJE();
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class KAFIDDOHGAH : EDIGDEIAABH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly Func<double> EKNPHGGCBBI;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool GKODBKCLOCN
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x901ED0", Offset = "0x9012D0", VA = "0x180901ED0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x901900", Offset = "0x900D00", VA = "0x180901900", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6F793F0", Offset = "0x6F787F0", VA = "0x186F793F0")]
	public KAFIDDOHGAH(Func<double> EKNPHGGCBBI, MetricDescription JIFJEMNCEHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6F79360", Offset = "0x6F78760", VA = "0x186F79360", Slot = "6")]
	public RawMetricPayload OPIIBEHBDJE()
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
		protected const string JBDKCNOOGOK = "0.00";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		protected double OGPENIBDEDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		protected double MGIOKDLHAPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		protected double COPADADOECC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		protected double NHPCAGBFHHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		protected double EOPLDPFCBFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		protected int EGGNNAAFHEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		protected double BJFIAFKIEHP;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		protected abstract int INHGPJGPPPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		protected abstract MetricAccumulateMode LMJLBKKJJCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		protected bool BJHLFOFLEJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xA7EA10", Offset = "0xA7DE10", VA = "0x180A7EA10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xB9A350", Offset = "0xB99750", VA = "0x180B9A350")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract PIFOJDLDNHM PIOJAHMGBBC();

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected abstract void KBAABCIHHAL();

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xA1A330", Offset = "0xA19730", VA = "0x180A1A330", Slot = "9")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xA1A330", Offset = "0xA19730", VA = "0x180A1A330")]
		protected void HFBELECCMBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A660", Offset = "0x6F79A60", VA = "0x186F7A660", Slot = "10")]
		protected virtual void MBAGOGAJFND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A6A0", Offset = "0x6F79AA0", VA = "0x186F7A6A0", Slot = "11")]
		protected virtual void PJIABFKGGPI(double NEDDHGKJFAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A510", Offset = "0x6F79910", VA = "0x186F7A510", Slot = "12")]
		protected virtual double DJMHKGOCOFO(MetricAccumulateMode EPCMEODCMCN)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A3B0", Offset = "0x6F797B0", VA = "0x186F7A3B0")]
		protected bool BJPKNLFLOFA(MetricGraph AOHOJLPKPNH, MetricAccumulateMode ADMMGKCBODC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A290", Offset = "0x6F79690", VA = "0x186F7A290", Slot = "13")]
		protected virtual string ADAAJFHGFJJ(double AGLCIEKHLEE, string EFDFEGMKBJJ = "0.00", [Optional] string GDIBBFCJDCK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A780", Offset = "0x6F79B80", VA = "0x186F7A780")]
		protected MetricGraphDriverBase()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class HMBFDEGAMND : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private readonly struct FGOAFMGHKGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public readonly string CMNJOCPLGMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public readonly string JFINIGLNCGK;

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xD06A00", Offset = "0xD05E00", VA = "0x180D06A00")]
		public FGOAFMGHKGJ(string ICIPHLKGMMK, string DNHIDHPKFNG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class DJFJDFHBGAP : IAsyncStateMachine
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
		public HMBFDEGAMND <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public DJFJDFHBGAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6F77100", Offset = "0x6F76500", VA = "0x186F77100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly MetricIdLookup CFEOGLGJAPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly IRawMetricsPipeline DDOLFOBKEGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly IMetricCollectionRegistry HGFNADONOHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly CancellationTokenSource OCLAFKPHAEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly Dictionary<MetricId, EDIGDEIAABH> KNDPBIJKFHI;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static readonly FGOAFMGHKGJ[] FHAIFOKLGIB;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6F77A70", Offset = "0x6F76E70", VA = "0x186F77A70")]
	[PGKDFPMEDOJ(CDFBKAGHDGH.GameOnly)]
	private static void BAPPIPJDFJJ(IFJJAPHPIAE LDNJCMFLLMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6F78AA0", Offset = "0x6F77EA0", VA = "0x186F78AA0")]
	[Preserve]
	public HMBFDEGAMND([JLJFOFICIEA(null)] MetricIdLookup CFEOGLGJAPD, [JLJFOFICIEA(null)] IRawMetricsPipeline DDOLFOBKEGD, [JLJFOFICIEA(null)] IMetricCollectionRegistry HGFNADONOHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6F77860", Offset = "0x6F76C60", VA = "0x186F77860")]
	private void AEMEKOGBHFL(string EJBLEGOEDCM, string DNHIDHPKFNG, PIFOJDLDNHM CEAEBAHJJOC, Func<double> EKNPHGGCBBI, out MetricId HMFBJHABLIM, out EDIGDEIAABH OIEACLJHHPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6F77E00", Offset = "0x6F77200", VA = "0x186F77E00")]
	private void FLOGGDJIDAA(MetricId HMFBJHABLIM, bool CIFFHDLIOJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6F77920", Offset = "0x6F76D20", VA = "0x186F77920")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DJFJDFHBGAP))]
	private Task ALLIOLPHBBB(CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6F77B60", Offset = "0x6F76F60", VA = "0x186F77B60")]
	public void CKNNFHHCBGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6F77DC0", Offset = "0x6F771C0", VA = "0x186F77DC0", Slot = "4")]
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
		protected bool IKFMDEOBOHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[SerializeField]
		protected MetricGraphTextDisplay textDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		protected bool MHEEBFGHEFP;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6F7D450", Offset = "0x6F7C850", VA = "0x186F7D450", Slot = "9")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6F7D290", Offset = "0x6F7C690", VA = "0x186F7D290", Slot = "5")]
		protected override void KBAABCIHHAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6F7CF50", Offset = "0x6F7C350", VA = "0x186F7CF50", Slot = "14")]
		protected virtual bool GBDIGOKCMEN(string CKLDMLJKNMC = "0.00", [Optional] string FEONDPJALLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A780", Offset = "0x6F79B80", VA = "0x186F7A780")]
		protected SingleMetricGraphDriver()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class KODKIBIAENC : EDIGDEIAABH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private static bool FOBNKNLBIAG;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static Dictionary<(ushort category, string name), ProfilerRecorderHandle> GJHOPPOIEGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly MetricId HMFBJHABLIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly string ICIPHLKGMMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly string DNHIDHPKFNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private ProfilerRecorder NMJFPAHMCEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private bool HIBGALBMLLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private bool JKMNMNFJGEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private ProfilerRecorderDescription KAPEKEDDBKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private ProfilerRecorderHandle PFABMINAILC;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool GKODBKCLOCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8BD740", Offset = "0x8BCB40", VA = "0x1808BD740", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8C1870", Offset = "0x8C0C70", VA = "0x1808C1870", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private MetricDescription HEBIBPNMJEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x225AB60", Offset = "0x2259F60", VA = "0x18225AB60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6F79D80", Offset = "0x6F79180", VA = "0x186F79D80")]
	public KODKIBIAENC(MetricId HMFBJHABLIM, string ICIPHLKGMMK, string DNHIDHPKFNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6F79C30", Offset = "0x6F79030", VA = "0x186F79C30", Slot = "6")]
	public RawMetricPayload OPIIBEHBDJE()
	{
		return default(RawMetricPayload);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6F79440", Offset = "0x6F78840", VA = "0x186F79440")]
	private static ProfilerRecorderHandle BIALAMGMLDK(string ICIPHLKGMMK, string DNHIDHPKFNG)
	{
		return default(ProfilerRecorderHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6F79880", Offset = "0x6F78C80", VA = "0x186F79880")]
	private void HFNMCKNBGDM(bool DGLCECEILBL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6F79BB0", Offset = "0x6F78FB0", VA = "0x186F79BB0")]
	private static MetricDescription ILPLIODMCGC(MetricId HMFBJHABLIM, ProfilerRecorderDescription HEIDGDKHKOO)
	{
		return default(MetricDescription);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6F795B0", Offset = "0x6F789B0", VA = "0x186F795B0")]
	private static bool FHBGLGFEBEO(bool DGLCECEILBL = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6F79590", Offset = "0x6F78990", VA = "0x186F79590")]
	private void EOBOGDBNFDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6F79590", Offset = "0x6F78990", VA = "0x186F79590", Slot = "7")]
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

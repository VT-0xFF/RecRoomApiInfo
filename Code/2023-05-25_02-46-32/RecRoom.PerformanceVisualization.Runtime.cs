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
		protected override int KLBNEINNOBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x8E9220", Offset = "0x8E7A20", VA = "0x1808E9220", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected override MetricAccumulateMode CDBMHIMHENG
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0xD96790", Offset = "0xD94F90", VA = "0x180D96790", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD137C0", Offset = "0xD11FC0", VA = "0x180D137C0", Slot = "4")]
		protected override ICAGIFAGNBN AGMDDOKIEHL()
		{
			return default(ICAGIFAGNBN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x150F5A0", Offset = "0x150DDA0", VA = "0x18150F5A0", Slot = "14")]
		protected override bool FANNFNDOLDP(string BLADKFIJPAO = "0.00", [Optional] string AJKGHMPELCL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x150F680", Offset = "0x150DE80", VA = "0x18150F680")]
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
		private MetricIdLookup ELCANMAOCCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private IRawMetricsPipeline NIPOPDJCDIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private IMetricCollectionRegistry KFLBOOINEIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private MetricId AADGKAOPAIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private int APPHNAJMHPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private MetricAccumulateMode KICFOKMECPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private MetricCollectionToken FLDJLPKNKKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private MetricDescription PKJEPKLFIAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private GraphConfig LAGJGCNOCCL;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		protected override int KLBNEINNOBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xD27320", Offset = "0xD25B20", VA = "0x180D27320", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected override MetricAccumulateMode CDBMHIMHENG
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xD979E0", Offset = "0xD961E0", VA = "0x180D979E0", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x150ECC0", Offset = "0x150D4C0", VA = "0x18150ECC0")]
		private void IJCFMLOKOAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x150EA60", Offset = "0x150D260", VA = "0x18150EA60", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x150F240", Offset = "0x150DA40", VA = "0x18150F240", Slot = "9")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x150F1B0", Offset = "0x150D9B0", VA = "0x18150F1B0")]
		protected void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x150EE20", Offset = "0x150D620", VA = "0x18150EE20")]
		public void Initialize(GraphConfig GELAOBGGGJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x150EAC0", Offset = "0x150D2C0", VA = "0x18150EAC0", Slot = "14")]
		protected override bool FANNFNDOLDP(string BLADKFIJPAO = "0.00", [Optional] string AJKGHMPELCL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x150EBC0", Offset = "0x150D3C0", VA = "0x18150EBC0")]
		public void HandleMetric(in RawMetric EBNEJIFPPMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xC73350", Offset = "0xC71B50", VA = "0x180C73350", Slot = "4")]
		protected override ICAGIFAGNBN AGMDDOKIEHL()
		{
			return default(ICAGIFAGNBN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x150F3C0", Offset = "0x150DBC0", VA = "0x18150F3C0")]
		public ConfigurablePipelineGraphDriver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x150EBC0", Offset = "0x150D3C0", VA = "0x18150EBC0", Slot = "15")]
		private void MNNLECAIKFD(in RawMetric EBNEJIFPPMK)
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
		[Cpp2IlInjected.Address(RVA = "0x1511020", Offset = "0x150F820", VA = "0x181511020")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1511410", Offset = "0x150FC10", VA = "0x181511410")]
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
		protected override int KLBNEINNOBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8E9220", Offset = "0x8E7A20", VA = "0x1808E9220", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected override MetricAccumulateMode CDBMHIMHENG
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xD96790", Offset = "0xD94F90", VA = "0x180D96790", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xEBF0B0", Offset = "0xEBD8B0", VA = "0x180EBF0B0", Slot = "4")]
		protected override ICAGIFAGNBN AGMDDOKIEHL()
		{
			return default(ICAGIFAGNBN);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1513880", Offset = "0x1512080", VA = "0x181513880")]
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
		protected override int KLBNEINNOBK
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8E9220", Offset = "0x8E7A20", VA = "0x1808E9220", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		protected override MetricAccumulateMode CDBMHIMHENG
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xD96790", Offset = "0xD94F90", VA = "0x180D96790", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x83C8F0", Offset = "0x83B0F0", VA = "0x18083C8F0", Slot = "4")]
		protected override ICAGIFAGNBN AGMDDOKIEHL()
		{
			return default(ICAGIFAGNBN);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x150F410", Offset = "0x150DC10", VA = "0x18150F410", Slot = "14")]
		protected override bool FANNFNDOLDP(string BLADKFIJPAO = "0.00", [Optional] string AJKGHMPELCL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x150F510", Offset = "0x150DD10", VA = "0x18150F510")]
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
		private bool OBIKODKHJEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[SerializeField]
		private TMP_Text categoryText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private bool PNBCGEBDPOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[SerializeField]
		private TMP_Text descriptionText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private bool MPCJHBHCBOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[SerializeField]
		[Header("Data Text")]
		private TMP_Text samplesText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private bool FIHKPCCKFIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[SerializeField]
		private TMP_Text curText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private bool POEPOJBKABB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[SerializeField]
		private TMP_Text minText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private bool AAMJNAHIPHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[SerializeField]
		private TMP_Text maxText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private bool BAKPNFJEIGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[SerializeField]
		private TMP_Text avgText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private bool ELIDIAONNGL;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string IALFJDMMMLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x1511EC0", Offset = "0x15106C0", VA = "0x181511EC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x1512140", Offset = "0x1510940", VA = "0x181512140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string JFPEADFGGEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x1511C40", Offset = "0x1510440", VA = "0x181511C40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x1512000", Offset = "0x1510800", VA = "0x181512000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public string KKFBLEENEFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x1511D40", Offset = "0x1510540", VA = "0x181511D40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x1512080", Offset = "0x1510880", VA = "0x181512080")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string NFLHMMKBFMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x1511F40", Offset = "0x1510740", VA = "0x181511F40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x1512180", Offset = "0x1510980", VA = "0x181512180")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public string PIBEJEJPADI
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x1511CC0", Offset = "0x15104C0", VA = "0x181511CC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x1512040", Offset = "0x1510840", VA = "0x181512040")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public string OIDGPHCIJCD
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x1511E40", Offset = "0x1510640", VA = "0x181511E40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x1512100", Offset = "0x1510900", VA = "0x181512100")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public string OPGMFCDJIEJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x1511DC0", Offset = "0x15105C0", VA = "0x181511DC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x15120C0", Offset = "0x15108C0", VA = "0x1815120C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public string KJDMBHNPAOD
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x1511BC0", Offset = "0x15103C0", VA = "0x181511BC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x1511FC0", Offset = "0x15107C0", VA = "0x181511FC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1511AD0", Offset = "0x15102D0", VA = "0x181511AD0", Slot = "4")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1511A10", Offset = "0x1510210", VA = "0x181511A10")]
		protected string LHKLBLBCHBI(bool COKIGIBIJIK, ref TMP_Text PDHOFJLLEID)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1511A90", Offset = "0x1510290", VA = "0x181511A90")]
		protected void OEGLJFOJPDD(bool JPPDBPDKEMJ, ref TMP_Text CBHLPGJGAKG, string ECNGHFJBIJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9080F0", Offset = "0x9068F0", VA = "0x1809080F0")]
		public MetricGraphTextDisplay()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[DefaultMember("Item")]
public class KPDHOHOIDLJ
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class BAEAKKLGONC : IEnumerable<float>, IEnumerable, IEnumerator<float>, IEnumerator, IDisposable
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
		public KPDHOHOIDLJ <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x142ECE0", Offset = "0x142D4E0", VA = "0x18142ECE0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x150EA10", Offset = "0x150D210", VA = "0x18150EA10", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xC9ED40", Offset = "0xC9D540", VA = "0x180C9ED40")]
		[DebuggerHidden]
		public BAEAKKLGONC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x150E830", Offset = "0x150D030", VA = "0x18150E830", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x150E9D0", Offset = "0x150D1D0", VA = "0x18150E9D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x150E920", Offset = "0x150D120", VA = "0x18150E920", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<float> IEnumerable<float>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x150E920", Offset = "0x150D120", VA = "0x18150E920", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	protected float[] PELCAIHKCCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	protected int IAMNGCDNLFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	protected int FGHOJPFDCIA;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int PLEPIEDOEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8C8AE0", Offset = "0x8C72E0", VA = "0x1808C8AE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int HCGFJHGIHCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xB8E6B0", Offset = "0xB8CEB0", VA = "0x180B8E6B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float FFPMNEPBAJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x1510220", Offset = "0x150EA20", VA = "0x181510220")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public float OOOPMGLHCNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x1510210", Offset = "0x150EA10", VA = "0x181510210")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float OILDPKEFAJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x150CB60", Offset = "0x150B360", VA = "0x18150CB60")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x15105D0", Offset = "0x150EDD0", VA = "0x1815105D0")]
	public KPDHOHOIDLJ(int CABFJBCMJEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1510400", Offset = "0x150EC00", VA = "0x181510400")]
	public void KKOEIJDNMAD(int CDHMDBKOOHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1510230", Offset = "0x150EA30", VA = "0x181510230")]
	public void JCNCAANDIPG(float ECNGHFJBIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1510200", Offset = "0x150EA00", VA = "0x181510200")]
	public void AFCIOBBFKFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x1510300", Offset = "0x150EB00", VA = "0x181510300")]
	public IEnumerable<float> JJMGPPHLILD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x1510380", Offset = "0x150EB80", VA = "0x181510380")]
	[IteratorStateMachine(typeof(BAEAKKLGONC))]
	public IEnumerable<float> JJMGPPHLILD(int BCJOIBLMOKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x150CC10", Offset = "0x150B410", VA = "0x18150CC10")]
	public void MPMCFEJLJOP(float[] CBHLPGJGAKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x15104C0", Offset = "0x150ECC0", VA = "0x1815104C0")]
	public void MPMCFEJLJOP(float[] CBHLPGJGAKG, int MIFMEALEPDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1510490", Offset = "0x150EC90", VA = "0x181510490")]
	private int LKMNLAJICCM(int NHHNPPKPBIA)
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
		private ProfilerMarker FNMAOLPLPKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private ProfilerMarker FKDKGOEJMLJ;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private const int FAHBDOHNNBI = 8;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private const int FEAHFHIDEAJ = 512;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[SerializeField]
		[Header("Buffer")]
		[Range(8f, 512f)]
		private int bufferCapacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private KPDHOHOIDLJ KKPLLEPONNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private bool BBBJNMDOEBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private float LPCLHPPOPJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private float GFAJOLNDNFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private float KLDOAOJGPON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private float IGJLNAACOEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private float NKCBOHEGGJM;

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
		private KBFOKCMNIFI IGOFNIAHNAO;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private int EHFDLFPPCJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x15124B0", Offset = "0x1510CB0", VA = "0x1815124B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private int OENFHBALLMJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x1512660", Offset = "0x1510E60", VA = "0x181512660")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private int HNBDGPCJJHK
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x15121F0", Offset = "0x15109F0", VA = "0x1815121F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public int BLOHLLNFKNA
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x1513690", Offset = "0x1511E90", VA = "0x181513690")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int LCPLJEHNHBC
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x1513660", Offset = "0x1511E60", VA = "0x181513660")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float MKKDBMGDJEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x15135C0", Offset = "0x1511DC0", VA = "0x1815135C0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float FCEGMEMOKBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x1513600", Offset = "0x1511E00", VA = "0x181513600")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float LBLCAGLBCLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x15135E0", Offset = "0x1511DE0", VA = "0x1815135E0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float OMLLMAEPLLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x1513620", Offset = "0x1511E20", VA = "0x181513620")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float GKHMLFCDJGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x1513640", Offset = "0x1511E40", VA = "0x181513640")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x15121C0", Offset = "0x15109C0", VA = "0x1815121C0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x15133A0", Offset = "0x1511BA0", VA = "0x1815133A0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x1512FC0", Offset = "0x15117C0", VA = "0x181512FC0")]
		public void PushSample(double BJNBCLJDMLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x1512260", Offset = "0x1510A60", VA = "0x181512260")]
		public void ClearSamples()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x1512280", Offset = "0x1510A80", VA = "0x181512280")]
		private void GAEIJNFADLI(bool HCKNDFMIDDI = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x15130B0", Offset = "0x15118B0", VA = "0x1815130B0")]
		public void UpdateShader()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x15124D0", Offset = "0x1510CD0", VA = "0x1815124D0")]
		public void InitData(int MCNHKALPGHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x1512680", Offset = "0x1510E80", VA = "0x181512680")]
		private void ONMHMJHDLBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x15133D0", Offset = "0x1511BD0", VA = "0x1815133D0")]
		public MetricGraph()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class KBFOKCMNIFI
{
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public const int IPPNBOBBGCD = 512;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public const int FCLBGEOLPOL = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public int FBFJNDNJHPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public float[] MLFMIGMIHFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public RawImage PGABMPMABAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float COKDONPDMPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float HPDMAMNHJBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public float BHICLJKBEML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public float IFMPJOIHKMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public float MMDKBBGFJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public Color AGEENDLANBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public Color GENIHCKIOLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public bool ODMDNJKGLKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public Color EJELLIFICNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public Color EEFOMNGFLEA;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly int PGNHFFFIOAE;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static readonly int PNGIJBJLKIH;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly int LCNPAMFJGLD;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly int ALAMIHMKHDE;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly int MCDFFBPPDJP;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static readonly int PIKOOLEHDHP;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly int HMFHEICBKNC;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly int ICONFNLCLHM;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly int IHFMECKFLBP;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static readonly int IEOGDLLDFEA;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static readonly int DKKLBNMHNCL;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static readonly int NBPLIHPFILM;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x150FB80", Offset = "0x150E380", VA = "0x18150FB80")]
	public void KGBFBOBEOKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x150FDE0", Offset = "0x150E5E0", VA = "0x18150FDE0")]
	public void OCKDGFGMBGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x150FE90", Offset = "0x150E690", VA = "0x18150FE90")]
	public void PKJKICMPHJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x150F920", Offset = "0x150E120", VA = "0x18150F920")]
	public void GHNFCLBANIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x150FC40", Offset = "0x150E440", VA = "0x18150FC40")]
	public void LCJPADDPDML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x150FA00", Offset = "0x150E200", VA = "0x18150FA00")]
	public void HPAAFHHHEGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x150FAA0", Offset = "0x150E2A0", VA = "0x18150FAA0")]
	public void KDEIIIJJHKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1510160", Offset = "0x150E960", VA = "0x181510160")]
	public KBFOKCMNIFI()
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
		private ProfilerRecorderHandle JKCGINOOLPD;

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
		private static bool PDIBNMLLMBB;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool NCDNKHDPNMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x1513870", Offset = "0x1512070", VA = "0x181513870")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		protected override int KLBNEINNOBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xD27310", Offset = "0xD25B10", VA = "0x180D27310", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		protected override MetricAccumulateMode CDBMHIMHENG
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xD27320", Offset = "0xD25B20", VA = "0x180D27320", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xD137C0", Offset = "0xD11FC0", VA = "0x180D137C0", Slot = "4")]
		protected override ICAGIFAGNBN AGMDDOKIEHL()
		{
			return default(ICAGIFAGNBN);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x15136B0", Offset = "0x1511EB0", VA = "0x1815136B0", Slot = "14")]
		protected override bool FANNFNDOLDP(string BLADKFIJPAO = "0.00", [Optional] string AJKGHMPELCL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x15137D0", Offset = "0x1511FD0", VA = "0x1815137D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x150F6C0", Offset = "0x150DEC0", VA = "0x18150F6C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xBBBD50", Offset = "0xBBA550", VA = "0x180BBBD50")]
		public GraphConfigAsset()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface PLOBPAOFDBE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool GOEJILIBOLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	MetricDescription JGKPOEFELOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "3")]
	RawMetricPayload EJNKEAIFOKB();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class JKOGAOCLKGO : PLOBPAOFDBE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly Func<double> EJJJHECJLPF;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool GOEJILIBOLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8C7730", Offset = "0x8C5F30", VA = "0x1808C7730", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8E8B70", Offset = "0x8E7370", VA = "0x1808E8B70", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public MetricDescription JGKPOEFELOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x150F8C0", Offset = "0x150E0C0", VA = "0x18150F8C0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(MetricDescription);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x150F8D0", Offset = "0x150E0D0", VA = "0x18150F8D0")]
	public JKOGAOCLKGO(Func<double> EJJJHECJLPF, MetricDescription PKJEPKLFIAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x150F830", Offset = "0x150E030", VA = "0x18150F830", Slot = "7")]
	public RawMetricPayload EJNKEAIFOKB()
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
		protected const string LPLGLEFEEKB = "0.00";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		protected double PHELIAFGJPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		protected double HCFPABMGNHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		protected double NELFNMNBEHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		protected double IEDPEIOAIEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		protected double CMOOALDHIPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		protected int NOCFJHGLOLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		protected double OEGGBFELKCK;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		protected abstract int KLBNEINNOBK
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		protected abstract MetricAccumulateMode CDBMHIMHENG
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		protected bool KEJNNNDLHMC
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x12770B0", Offset = "0x12758B0", VA = "0x1812770B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x12766F0", Offset = "0x1274EF0", VA = "0x1812766F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract ICAGIFAGNBN AGMDDOKIEHL();

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected abstract void DBDFJGDPOKL();

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x15119C0", Offset = "0x15101C0", VA = "0x1815119C0", Slot = "9")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x15119C0", Offset = "0x15101C0", VA = "0x1815119C0")]
		protected void OEKGMGMCILI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x1511860", Offset = "0x1510060", VA = "0x181511860", Slot = "10")]
		protected virtual void JNNGOIECNNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x15114D0", Offset = "0x150FCD0", VA = "0x1815114D0", Slot = "11")]
		protected virtual void EIHBBACJAAK(double MHNABFLLLDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x1511710", Offset = "0x150FF10", VA = "0x181511710", Slot = "12")]
		protected virtual double JLJHCGJNJHC(MetricAccumulateMode KICFOKMECPD)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x15115B0", Offset = "0x150FDB0", VA = "0x1815115B0")]
		protected bool JJPLLBMIMLF(MetricGraph MEHDIGLPOEJ, MetricAccumulateMode JBENBACJFCK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x15118A0", Offset = "0x15100A0", VA = "0x1815118A0", Slot = "13")]
		protected virtual string LJOMBDALCBO(double ECNGHFJBIJL, string JIHLEMBEPHC = "0.00", [Optional] string PMPBLKLDCIL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x15119D0", Offset = "0x15101D0", VA = "0x1815119D0")]
		protected MetricGraphDriverBase()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class ALNBACEBMKH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private readonly struct KJHPHKADBON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public readonly string OHJMOJPLAHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public readonly string JMNJNECBGAJ;

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x9E1370", Offset = "0x9DFB70", VA = "0x1809E1370")]
		public KJHPHKADBON(string JFHFCFCFCJB, string JAECEENECDB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class IJKJMNNHIAE : IAsyncStateMachine
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
		public ALNBACEBMKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public IJKJMNNHIAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x150F6E0", Offset = "0x150DEE0", VA = "0x18150F6E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly MetricIdLookup ELCANMAOCCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly IRawMetricsPipeline NIPOPDJCDIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly IMetricCollectionRegistry KFLBOOINEIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly CancellationTokenSource MFGBDLCLLHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly Dictionary<MetricId, PLOBPAOFDBE> OMDPKAGKMHJ;

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private static readonly KJHPHKADBON[] DBOHHKKGEGK;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x150D280", Offset = "0x150BA80", VA = "0x18150D280")]
	[BBAPFPLPODF(EDNJEIFHIMJ.GameOnly)]
	private static void MCFKFGEHJOK(MHOBEFMLEFD EOOGCBGOIGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x150DF70", Offset = "0x150C770", VA = "0x18150DF70")]
	[Preserve]
	public ALNBACEBMKH([ACEKLAKDMBL(null)] MetricIdLookup ELCANMAOCCF, [ACEKLAKDMBL(null)] IRawMetricsPipeline NIPOPDJCDIP, [ACEKLAKDMBL(null)] IMetricCollectionRegistry KFLBOOINEIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x150CD10", Offset = "0x150B510", VA = "0x18150CD10")]
	private void AMMHCDPBKDE(string GLEKBDPMHDL, string JAECEENECDB, ICAGIFAGNBN JDNGDMOKNJE, Func<double> EJJJHECJLPF, out MetricId AADGKAOPAIJ, out PLOBPAOFDBE PDHOFJLLEID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x150D1E0", Offset = "0x150B9E0", VA = "0x18150D1E0")]
	private void IAHFLANFHFM(MetricId AADGKAOPAIJ, bool FHPFIHNMMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x150D090", Offset = "0x150B890", VA = "0x18150D090")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IJKJMNNHIAE))]
	private Task HPOLDOPEDNM(CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x150CDD0", Offset = "0x150B5D0", VA = "0x18150CDD0")]
	public void CHLJCCJNHOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x150D050", Offset = "0x150B850", VA = "0x18150D050", Slot = "4")]
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
		protected bool CCABINCPBNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[SerializeField]
		protected MetricGraphTextDisplay textDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		protected bool IGFMOGOOMPD;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x1513DD0", Offset = "0x15125D0", VA = "0x181513DD0", Slot = "9")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x15138D0", Offset = "0x15120D0", VA = "0x1815138D0", Slot = "5")]
		protected override void DBDFJGDPOKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x1513A90", Offset = "0x1512290", VA = "0x181513A90", Slot = "14")]
		protected virtual bool FANNFNDOLDP(string BLADKFIJPAO = "0.00", [Optional] string AJKGHMPELCL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x15119D0", Offset = "0x15101D0", VA = "0x1815119D0")]
		protected SingleMetricGraphDriver()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class MGAGOMDJEMB : PLOBPAOFDBE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static bool PDIBNMLLMBB;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static Dictionary<(ushort category, string name), ProfilerRecorderHandle> CJBNNKBPHFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly MetricId AADGKAOPAIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly string JFHFCFCFCJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private readonly string JAECEENECDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private ProfilerRecorder HAHHGLHLHCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private bool HKLJGBDLGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private bool PEAJGBIDIOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private ProfilerRecorderDescription OPLJHEIGPDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private ProfilerRecorderHandle JKCGINOOLPD;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool GOEJILIBOLA
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8116F0", Offset = "0x80FEF0", VA = "0x1808116F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8B1630", Offset = "0x8AFE30", VA = "0x1808B1630", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public MetricDescription JGKPOEFELOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x1510BB0", Offset = "0x150F3B0", VA = "0x181510BB0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(MetricDescription);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x1510970", Offset = "0x150F170", VA = "0x181510970")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool NCDNKHDPNMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x1510F10", Offset = "0x150F710", VA = "0x181510F10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x1510FB0", Offset = "0x150F7B0", VA = "0x181510FB0")]
	public MGAGOMDJEMB(MetricId AADGKAOPAIJ, string JFHFCFCFCJB, string JAECEENECDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x15109A0", Offset = "0x150F1A0", VA = "0x1815109A0", Slot = "7")]
	public RawMetricPayload EJNKEAIFOKB()
	{
		return default(RawMetricPayload);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x1510A60", Offset = "0x150F260", VA = "0x181510A60")]
	private static ProfilerRecorderHandle GDCKEOOOBDJ(string JFHFCFCFCJB, string JAECEENECDB)
	{
		return default(ProfilerRecorderHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x1510640", Offset = "0x150EE40", VA = "0x181510640")]
	private void AOJBKJLPOAP(bool HCKNDFMIDDI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x1510E90", Offset = "0x150F690", VA = "0x181510E90")]
	private static MetricDescription NMJHNFAIIOA(MetricId AADGKAOPAIJ, ProfilerRecorderDescription HFGKDNCAGNM)
	{
		return default(MetricDescription);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x1510BC0", Offset = "0x150F3C0", VA = "0x181510BC0")]
	private static bool MPAMGFJNADF(bool HCKNDFMIDDI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x1510980", Offset = "0x150F180", VA = "0x181510980")]
	private void EKJFJMAMAAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x1510980", Offset = "0x150F180", VA = "0x181510980", Slot = "8")]
	public void Dispose()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class PFBBJKPLBFC
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
	public PFBBJKPLBFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0xBC23C0", Offset = "0xBC0BC0", VA = "0x180BC23C0")]
	public static string NIMNBIGPMKB(byte[] DCFEDNINKHD, byte[] LFMKEJPAGIF)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class __BB_OBFUSCATOR_VERSION_3_9_9
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

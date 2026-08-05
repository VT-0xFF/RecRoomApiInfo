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
		protected override int IHAGEJPHINN
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0xE78910", Offset = "0xE77110", VA = "0x180E78910", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected override MetricAccumulateMode EAIEPGNFAKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x1A92810", Offset = "0x1A91010", VA = "0x181A92810", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA68400", Offset = "0xA66C00", VA = "0x180A68400", Slot = "4")]
		protected override KEIBIMFIAIP KOKFLOIBJJE()
		{
			return default(KEIBIMFIAIP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6C89CC0", Offset = "0x6C884C0", VA = "0x186C89CC0", Slot = "14")]
		protected override bool ALIKGPLFJKF(string HBOAOEKKLLG = "0.00", [Optional] string OIJDMHJIEMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6C89DA0", Offset = "0x6C885A0", VA = "0x186C89DA0")]
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
		private MetricIdLookup JPAMACBDDMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private IRawMetricsPipeline LLJGCDGGNGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private IMetricCollectionRegistry FGHMKIEPALE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private MetricId GHNCCHIBAKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private int FKIIEAGFFPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private MetricAccumulateMode GADBPFBKKDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private MetricCollectionToken AMCDGOPKAOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private MetricDescription EHLNDJKDKEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private GraphConfig HANJKLHPCIE;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		protected override int IHAGEJPHINN
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x136E320", Offset = "0x136CB20", VA = "0x18136E320", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected override MetricAccumulateMode EAIEPGNFAKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xD93FC0", Offset = "0xD927C0", VA = "0x180D93FC0", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6C88AF0", Offset = "0x6C872F0", VA = "0x186C88AF0")]
		private void OJEGIHFGKCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6C88510", Offset = "0x6C86D10", VA = "0x186C88510", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6C88D50", Offset = "0x6C87550", VA = "0x186C88D50", Slot = "9")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6C88C50", Offset = "0x6C87450", VA = "0x186C88C50")]
		protected void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6C88670", Offset = "0x6C86E70", VA = "0x186C88670")]
		public void Initialize(GraphConfig FNEMJGPALGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6C88400", Offset = "0x6C86C00", VA = "0x186C88400", Slot = "14")]
		protected override bool ALIKGPLFJKF(string HBOAOEKKLLG = "0.00", [Optional] string OIJDMHJIEMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6C88570", Offset = "0x6C86D70", VA = "0x186C88570")]
		public void HandleMetric(in RawMetric EEGEGDFLDNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x34CB2B0", Offset = "0x34C9AB0", VA = "0x1834CB2B0", Slot = "4")]
		protected override KEIBIMFIAIP KOKFLOIBJJE()
		{
			return default(KEIBIMFIAIP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6C88ED0", Offset = "0x6C876D0", VA = "0x186C88ED0")]
		public ConfigurablePipelineGraphDriver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6C88570", Offset = "0x6C86D70", VA = "0x186C88570", Slot = "15")]
		private void IDGJGDODKNH(in RawMetric EEGEGDFLDNM)
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
		[Cpp2IlInjected.Address(RVA = "0x6C8C410", Offset = "0x6C8AC10", VA = "0x186C8C410")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6C8C7F0", Offset = "0x6C8AFF0", VA = "0x186C8C7F0")]
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
		protected override int IHAGEJPHINN
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xE78910", Offset = "0xE77110", VA = "0x180E78910", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected override MetricAccumulateMode EAIEPGNFAKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x1A92810", Offset = "0x1A91010", VA = "0x181A92810", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1DCFE40", Offset = "0x1DCE640", VA = "0x181DCFE40", Slot = "4")]
		protected override KEIBIMFIAIP KOKFLOIBJJE()
		{
			return default(KEIBIMFIAIP);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6C8ED20", Offset = "0x6C8D520", VA = "0x186C8ED20")]
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
		protected override int IHAGEJPHINN
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xE78910", Offset = "0xE77110", VA = "0x180E78910", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		protected override MetricAccumulateMode EAIEPGNFAKD
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x1A92810", Offset = "0x1A91010", VA = "0x181A92810", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8E4370", Offset = "0x8E2B70", VA = "0x1808E4370", Slot = "4")]
		protected override KEIBIMFIAIP KOKFLOIBJJE()
		{
			return default(KEIBIMFIAIP);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6C89B30", Offset = "0x6C88330", VA = "0x186C89B30", Slot = "14")]
		protected override bool ALIKGPLFJKF(string HBOAOEKKLLG = "0.00", [Optional] string OIJDMHJIEMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6C89C30", Offset = "0x6C88430", VA = "0x186C89C30")]
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
		private bool GIIBKHNDPAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[SerializeField]
		private TMP_Text categoryText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private bool HAAHHCGHJOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[SerializeField]
		private TMP_Text descriptionText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private bool ABMAIPIKGEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[SerializeField]
		[Header("Data Text")]
		private TMP_Text samplesText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private bool NKDCKLIBBKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[SerializeField]
		private TMP_Text curText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private bool MOIKMPHKDPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[SerializeField]
		private TMP_Text minText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private bool PJFGGDIIAKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[SerializeField]
		private TMP_Text maxText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private bool DCLGDBAOJOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[SerializeField]
		private TMP_Text avgText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private bool CPPJAKACLOM;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string LIJJPGGJPDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6C8D290", Offset = "0x6C8BA90", VA = "0x186C8D290")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6C8D510", Offset = "0x6C8BD10", VA = "0x186C8D510")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string CLAMOHBPKBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6C8D010", Offset = "0x6C8B810", VA = "0x186C8D010")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6C8D3D0", Offset = "0x6C8BBD0", VA = "0x186C8D3D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public string DCGMJCANKNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6C8D110", Offset = "0x6C8B910", VA = "0x186C8D110")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6C8D450", Offset = "0x6C8BC50", VA = "0x186C8D450")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string PMIEFENAAHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6C8D310", Offset = "0x6C8BB10", VA = "0x186C8D310")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6C8D550", Offset = "0x6C8BD50", VA = "0x186C8D550")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public string PCJLGHBLKGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6C8D090", Offset = "0x6C8B890", VA = "0x186C8D090")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6C8D410", Offset = "0x6C8BC10", VA = "0x186C8D410")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public string HNMINOLLOKD
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6C8D210", Offset = "0x6C8BA10", VA = "0x186C8D210")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6C8D4D0", Offset = "0x6C8BCD0", VA = "0x186C8D4D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public string HFKMKEPBFFF
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6C8D190", Offset = "0x6C8B990", VA = "0x186C8D190")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6C8D490", Offset = "0x6C8BC90", VA = "0x186C8D490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public string BGEPIIAHCOO
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6C8CF90", Offset = "0x6C8B790", VA = "0x186C8CF90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6C8D390", Offset = "0x6C8BB90", VA = "0x186C8D390")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6C8CEA0", Offset = "0x6C8B6A0", VA = "0x186C8CEA0", Slot = "4")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6C8CE20", Offset = "0x6C8B620", VA = "0x186C8CE20")]
		protected string GHAGMJHLKIK(bool LFCBDGGMKHD, ref TMP_Text ODHKMJMLAIP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6C8CDE0", Offset = "0x6C8B5E0", VA = "0x186C8CDE0")]
		protected void CJLILHCNHAP(bool GHBOAGNGLMH, ref TMP_Text BEELAINJGPH, string MENBIMCLIOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x90A150", Offset = "0x908950", VA = "0x18090A150")]
		public MetricGraphTextDisplay()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[DefaultMember("Item")]
public class FHOPALPELPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	protected float[] CKLAAEABOLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	protected int GLGOAJGINFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	protected int JMKNAPEFDDB;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int GKGAEPJBJAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xAD9880", Offset = "0xAD8080", VA = "0x180AD9880")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int KANEBOFNBAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1DE4C60", Offset = "0x1DE3460", VA = "0x181DE4C60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float JJKGICOMDEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6C89890", Offset = "0x6C88090", VA = "0x186C89890")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public float CHAPENDOEJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6C89AB0", Offset = "0x6C882B0", VA = "0x186C89AB0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float ODGMKJGOOKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6C88250", Offset = "0x6C86A50", VA = "0x186C88250")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6C89AC0", Offset = "0x6C882C0", VA = "0x186C89AC0")]
	public FHOPALPELPI(int LNKEFEELODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6C89800", Offset = "0x6C88000", VA = "0x186C89800")]
	public void IFJPIAGBCMG(int MDFJKFEGKHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6C899B0", Offset = "0x6C881B0", VA = "0x186C899B0")]
	public void MOBNBILMLCM(float MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x451F630", Offset = "0x451DE30", VA = "0x18451F630")]
	public void AGOHJEKNEED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6C88300", Offset = "0x6C86B00", VA = "0x186C88300")]
	public void LLGDBLIMDHM(float[] BEELAINJGPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6C898A0", Offset = "0x6C880A0", VA = "0x186C898A0")]
	public void LLGDBLIMDHM(float[] BEELAINJGPH, int IEJJDBNIMJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6C89A80", Offset = "0x6C88280", VA = "0x186C89A80")]
	private int PDBHIFGCGDL(int AMOEKOMGDLG)
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
		private ProfilerMarker NKIKDLJHLBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private ProfilerMarker MJOIGKFPPKF;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private const int LOEAAJFFMDH = 8;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private const int FDIIOPCNIBD = 512;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[SerializeField]
		[Range(8f, 512f)]
		[Header("Buffer")]
		private int bufferCapacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private FHOPALPELPI PGAGAOOENBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool GNBCPKPGOAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private float INCNDBMDFID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private float DLMGDIFCDKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private float MMIDGHMEFIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private float LLOOPDDGIAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private float DJPPCKOFGGO;

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
		private DECMDEHANNF PEHNCBOICBN;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private int CAOEMDCGFBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x6C8D590", Offset = "0x6C8BD90", VA = "0x186C8D590")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private int IJIJOCBHJHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6C8DA30", Offset = "0x6C8C230", VA = "0x186C8DA30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private int KGNNCHKOIBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x6C8D830", Offset = "0x6C8C030", VA = "0x186C8D830")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public int NOFKLLELHIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6C8EA50", Offset = "0x6C8D250", VA = "0x186C8EA50")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public int IFEHLJEOCPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6C8EA20", Offset = "0x6C8D220", VA = "0x186C8EA20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float FOMKBOBBNHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6C8E980", Offset = "0x6C8D180", VA = "0x186C8E980")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float BGHOHOPFENM
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6C8E9C0", Offset = "0x6C8D1C0", VA = "0x186C8E9C0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float FCCIJLNIKAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6C8E9A0", Offset = "0x6C8D1A0", VA = "0x186C8E9A0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float LAENOEKDNGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x6C8E9E0", Offset = "0x6C8D1E0", VA = "0x186C8E9E0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float FEPFMIJHJPL
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6C8EA00", Offset = "0x6C8D200", VA = "0x186C8EA00")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6C8D5B0", Offset = "0x6C8BDB0", VA = "0x186C8D5B0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6C8E760", Offset = "0x6C8CF60", VA = "0x186C8E760")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6C8E380", Offset = "0x6C8CB80", VA = "0x186C8E380")]
		public void PushSample(double GPAHIBKJJLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6C8D810", Offset = "0x6C8C010", VA = "0x186C8D810")]
		public void ClearSamples()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6C8D5E0", Offset = "0x6C8BDE0", VA = "0x186C8D5E0")]
		private void BHHMOIIHDGC(bool BJDJJEPMPIM = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6C8E470", Offset = "0x6C8CC70", VA = "0x186C8E470")]
		public void UpdateShader()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6C8D8A0", Offset = "0x6C8C0A0", VA = "0x186C8D8A0")]
		public void InitData(int JOCDPNMOCCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6C8DA50", Offset = "0x6C8C250", VA = "0x186C8DA50")]
		private void NHMJBCFCDPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6C8E790", Offset = "0x6C8CF90", VA = "0x186C8E790")]
		public MetricGraph()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class DECMDEHANNF
{
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public const int PDGPMGHGIEK = 512;

	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public const int JBHPINACOMK = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public int BHHHFGPIGBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public float[] HEHHPCOJDPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public RawImage AIACLMIIADJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public float IJBCINBLEDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public float FNGBPLBNDIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public float DMKKLHKEMFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public float PJKJJEBOGPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public float FHABCGOFJEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public Color NIPOIKICMKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public Color EGGDIDJGGNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public bool POMICOAPMPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public Color PMAKAKLPJKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public Color JAPPDFGJCJM;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static readonly int NNLJDGMADHC;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly int BPEAIJDPPEO;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static readonly int JODCKAKJGAB;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static readonly int HHAHOHKENPE;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly int LKIHEHKNHAD;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly int MBNIFPIKOAE;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static readonly int AACOOHPHJDE;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static readonly int AGBFKHIJIND;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static readonly int GMKMFGAMCGE;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly int HNMJCKCEOLE;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static readonly int PONOHBEBKDP;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly int AFOEENKJOPO;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6C890C0", Offset = "0x6C878C0", VA = "0x186C890C0")]
	public void GDHDOEJBFDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6C89180", Offset = "0x6C87980", VA = "0x186C89180")]
	public void JDBJIKJCEPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6C893F0", Offset = "0x6C87BF0", VA = "0x186C893F0")]
	public void OALFECGDLBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6C89310", Offset = "0x6C87B10", VA = "0x186C89310")]
	public void KCHPABCLPPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6C88F20", Offset = "0x6C87720", VA = "0x186C88F20")]
	public void FKGDNEFANAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6C89490", Offset = "0x6C87C90", VA = "0x186C89490")]
	public void ODPHJOCGGLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6C89230", Offset = "0x6C87A30", VA = "0x186C89230")]
	public void JIPBOFDEILE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6C89760", Offset = "0x6C87F60", VA = "0x186C89760")]
	public DECMDEHANNF()
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
		private ProfilerRecorderHandle OAOPANBOMDD;

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
		private static bool DOEBFAEOPNO;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool CNGJINFFJHK
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x6C8ED10", Offset = "0x6C8D510", VA = "0x186C8ED10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		protected override int IHAGEJPHINN
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x90C2C0", Offset = "0x90AAC0", VA = "0x18090C2C0", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		protected override MetricAccumulateMode EAIEPGNFAKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x136E320", Offset = "0x136CB20", VA = "0x18136E320", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA68400", Offset = "0xA66C00", VA = "0x180A68400", Slot = "4")]
		protected override KEIBIMFIAIP KOKFLOIBJJE()
		{
			return default(KEIBIMFIAIP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6C8EB50", Offset = "0x6C8D350", VA = "0x186C8EB50", Slot = "14")]
		protected override bool ALIKGPLFJKF(string HBOAOEKKLLG = "0.00", [Optional] string OIJDMHJIEMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6C8EC70", Offset = "0x6C8D470", VA = "0x186C8EC70")]
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
		[Cpp2IlInjected.Address(RVA = "0x6C89DE0", Offset = "0x6C885E0", VA = "0x186C89DE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x9176C0", Offset = "0x915EC0", VA = "0x1809176C0")]
		public GraphConfigAsset()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface IDEAENEDLPC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool JLFBNHADDGL
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
	RawMetricPayload KGLFCAAFKNC();
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class NGGLDPPKAGM : IDEAENEDLPC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly Func<double> HBDNAKDPBCJ;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool JLFBNHADDGL
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8F14D0", Offset = "0x8EFCD0", VA = "0x1808F14D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xA3F030", Offset = "0xA3D830", VA = "0x180A3F030", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6C8EB00", Offset = "0x6C8D300", VA = "0x186C8EB00")]
	public NGGLDPPKAGM(Func<double> HBDNAKDPBCJ, MetricDescription EHLNDJKDKEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6C8EA70", Offset = "0x6C8D270", VA = "0x186C8EA70", Slot = "6")]
	public RawMetricPayload KGLFCAAFKNC()
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
		protected const string CFGAGBOMFHC = "0.00";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		protected double AFDEDDLLJHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		protected double BOALAHFFEEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		protected double HDBNCDIFCON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		protected double DIJGPOFDIJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		protected double EIFJIBBDOKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		protected int ENAOGDBJKBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		protected double JFCNGGFPNFJ;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		protected abstract int IHAGEJPHINN
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		protected abstract MetricAccumulateMode EAIEPGNFAKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		protected bool JCDJNADGMBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x94E330", Offset = "0x94CB30", VA = "0x18094E330")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x97D690", Offset = "0x97BE90", VA = "0x18097D690")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract KEIBIMFIAIP KOKFLOIBJJE();

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected abstract void BNNNJIPKHNF();

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xCB14B0", Offset = "0xCAFCB0", VA = "0x180CB14B0", Slot = "9")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xCB14B0", Offset = "0xCAFCB0", VA = "0x180CB14B0")]
		protected void DDNEBIIGLAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6C8CD60", Offset = "0x6C8B560", VA = "0x186C8CD60", Slot = "10")]
		protected virtual void MOFNCAKLAKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6C8CB30", Offset = "0x6C8B330", VA = "0x186C8CB30", Slot = "11")]
		protected virtual void KJBGMDOKANC(double FBEPLKONGCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6C8CC10", Offset = "0x6C8B410", VA = "0x186C8CC10", Slot = "12")]
		protected virtual double MNFCFEBEOLB(MetricAccumulateMode GADBPFBKKDL)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6C8C8B0", Offset = "0x6C8B0B0", VA = "0x186C8C8B0")]
		protected bool ABCOMJKIHFI(MetricGraph KKKAOJMKPJF, MetricAccumulateMode EDGJKPJHBBC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6C8CA10", Offset = "0x6C8B210", VA = "0x186C8CA10", Slot = "13")]
		protected virtual string INCCKKOHLGC(double MENBIMCLIOI, string GNIDPOHLINP = "0.00", [Optional] string DBBPHJBMBOK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6C8CDA0", Offset = "0x6C8B5A0", VA = "0x186C8CDA0")]
		protected MetricGraphDriverBase()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class KFMEMPLNOEJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private readonly struct HDPICOHMHIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public readonly string JBNADGGBAFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public readonly string HMCICGMEMCA;

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xB84550", Offset = "0xB82D50", VA = "0x180B84550")]
		public HDPICOHMHIM(string GELHMGGNFLF, string OFHOGIJDEPB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class IMONMBNPGCK : IAsyncStateMachine
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
		public KFMEMPLNOEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public IMONMBNPGCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6C89E00", Offset = "0x6C88600", VA = "0x186C89E00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly MetricIdLookup JPAMACBDDMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly IRawMetricsPipeline LLJGCDGGNGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly IMetricCollectionRegistry FGHMKIEPALE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly CancellationTokenSource EFIOOPGMKMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly Dictionary<MetricId, IDEAENEDLPC> OHKDHCOHKBK;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static readonly HDPICOHMHIM[] KAMMOLLFLCA;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6C8A4B0", Offset = "0x6C88CB0", VA = "0x186C8A4B0")]
	[NFOBBCLLFPP(BGPNPCEMJLD.GameOnly)]
	private static void MDGIANIPLFH(LIFDIPFHEEA IPBKDPBLBEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B1A0", Offset = "0x6C899A0", VA = "0x186C8B1A0")]
	[Preserve]
	public KFMEMPLNOEJ([JHPEMCNOMHI(null)] MetricIdLookup JPAMACBDDMG, [JHPEMCNOMHI(null)] IRawMetricsPipeline LLJGCDGGNGH, [JHPEMCNOMHI(null)] IMetricCollectionRegistry FGHMKIEPALE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6C8A040", Offset = "0x6C88840", VA = "0x186C8A040")]
	private void IIKNMFHBEIE(string CBOEHHFFADI, string OFHOGIJDEPB, KEIBIMFIAIP OLKNOJOBADB, Func<double> HBDNAKDPBCJ, out MetricId GHNCCHIBAKB, out IDEAENEDLPC ODHKMJMLAIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6C89F60", Offset = "0x6C88760", VA = "0x186C89F60")]
	private void AFMNFPAGCMH(MetricId GHNCCHIBAKB, bool GKFDEFIENPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6C8A100", Offset = "0x6C88900", VA = "0x186C8A100")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IMONMBNPGCK))]
	private Task IPLMHMKBLOK(CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6C8A250", Offset = "0x6C88A50", VA = "0x186C8A250")]
	public void MAKBAAJGOPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6C8A000", Offset = "0x6C88800", VA = "0x186C8A000", Slot = "4")]
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
		protected bool MGPCDKCLJIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[SerializeField]
		protected MetricGraphTextDisplay textDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		protected bool FFHAIMGOJNP;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6C8F270", Offset = "0x6C8DA70", VA = "0x186C8F270", Slot = "9")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6C8F0B0", Offset = "0x6C8D8B0", VA = "0x186C8F0B0", Slot = "5")]
		protected override void BNNNJIPKHNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6C8ED70", Offset = "0x6C8D570", VA = "0x186C8ED70", Slot = "14")]
		protected virtual bool ALIKGPLFJKF(string HBOAOEKKLLG = "0.00", [Optional] string OIJDMHJIEMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6C8CDA0", Offset = "0x6C8B5A0", VA = "0x186C8CDA0")]
		protected SingleMetricGraphDriver()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class MPJGBPOKLKH : IDEAENEDLPC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private static bool DOEBFAEOPNO;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static Dictionary<(ushort category, string name), ProfilerRecorderHandle> JLHPKIBMKKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly MetricId GHNCCHIBAKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly string GELHMGGNFLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly string OFHOGIJDEPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private ProfilerRecorder PDNLLMDNHDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private bool AMLHELPDOJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private bool ICBCKFAJPNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private ProfilerRecorderDescription ODHBLFMHJIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private ProfilerRecorderHandle OAOPANBOMDD;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool JLFBNHADDGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x97D920", Offset = "0x97C120", VA = "0x18097D920", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x97D930", Offset = "0x97C130", VA = "0x18097D930", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private MetricDescription HIFOMKENDNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x238E150", Offset = "0x238C950", VA = "0x18238E150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6C8C3A0", Offset = "0x6C8ABA0", VA = "0x186C8C3A0")]
	public MPJGBPOKLKH(MetricId GHNCCHIBAKB, string GELHMGGNFLF, string OFHOGIJDEPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6C8BF80", Offset = "0x6C8A780", VA = "0x186C8BF80", Slot = "6")]
	public RawMetricPayload KGLFCAAFKNC()
	{
		return default(RawMetricPayload);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6C8BE30", Offset = "0x6C8A630", VA = "0x186C8BE30")]
	private static ProfilerRecorderHandle KBAMHDMNOGI(string GELHMGGNFLF, string OFHOGIJDEPB)
	{
		return default(ProfilerRecorderHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6C8BAE0", Offset = "0x6C8A2E0", VA = "0x186C8BAE0")]
	private void DGDEEDEFIOL(bool BJDJJEPMPIM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6C8BA60", Offset = "0x6C8A260", VA = "0x186C8BA60")]
	private static MetricDescription BDCONMOCCPD(MetricId GHNCCHIBAKB, ProfilerRecorderDescription JNPGANLPCGJ)
	{
		return default(MetricDescription);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6C8C040", Offset = "0x6C8A840", VA = "0x186C8C040")]
	private static bool MBICNIGPAHL(bool BJDJJEPMPIM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6C8BE10", Offset = "0x6C8A610", VA = "0x186C8BE10")]
	private void NGNBDEEPNHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6C8BE10", Offset = "0x6C8A610", VA = "0x186C8BE10", Slot = "7")]
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

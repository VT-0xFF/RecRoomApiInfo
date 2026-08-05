using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.Metrics.Pipeline;
using RecRoom.Metrics.Pipeline.MetricInfo;
using RecRoom.Profiling.Configs;
using TMPro;
using Unity.Profiling.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Profiling
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class AudioMetricDashboard : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private List<ConfigurablePipelineGraphDriver> metricGraphDriverBases;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private List<GraphConfigAsset> startingMetrics;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x80EE6E0", Offset = "0x80ED0E0", VA = "0x1880EE6E0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x80EEAB0", Offset = "0x80ED4B0", VA = "0x1880EEAB0")]
		public AudioMetricDashboard()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class ConfigurablePipelineGraphDriver : SingleMetricGraphDriver, IMetricsSubscriber<RawMetric>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private MetricIdLookup DAEFAGBLFNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private IRawMetricsPipeline OOADKJEFALI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private IMetricCollectionRegistry BAIMBMGEKLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private MetricId NCINDIHFEAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private int KKEBBLICPMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private MetricAccumulateMode EIFAPPLPBAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private MetricCollectionToken BECBHDDLOHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private MetricDescription LPNHLNCHGCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private GraphConfig APLBFKHKCFA;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		protected override int GBJFGDJNMEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xE49110", Offset = "0xE47B10", VA = "0x180E49110", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected override MetricAccumulateMode GMPMMJCKDIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xA09290", Offset = "0xA07C90", VA = "0x180A09290", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x80EEBE0", Offset = "0x80ED5E0", VA = "0x1880EEBE0")]
		private void GIKGFGNNACA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x80EEB80", Offset = "0x80ED580", VA = "0x1880EEB80", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x80EF530", Offset = "0x80EDF30", VA = "0x1880EF530", Slot = "9")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x80EF420", Offset = "0x80EDE20", VA = "0x1880EF420")]
		protected void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x80EEF90", Offset = "0x80ED990", VA = "0x1880EEF90")]
		public void Initialize(GraphConfig DBPLGHGILMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x80EEE80", Offset = "0x80ED880", VA = "0x1880EEE80", Slot = "14")]
		protected override bool IDAPKIGLPJL(string BGLBOEOBIME = "0.00", [Optional] string ENFHKHJDFEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x80EED80", Offset = "0x80ED780", VA = "0x1880EED80")]
		public void HandleMetric([In] RawMetric BAMCEPICIIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2CD8400", Offset = "0x2CD6E00", VA = "0x182CD8400", Slot = "4")]
		protected override MetricDataUnits FLCGMKIENMC()
		{
			return default(MetricDataUnits);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x80EF6A0", Offset = "0x80EE0A0", VA = "0x1880EF6A0")]
		public ConfigurablePipelineGraphDriver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x80EED80", Offset = "0x80ED780", VA = "0x1880EED80", Slot = "15")]
		private void LBOEFHFEPEN([In] RawMetric BAMCEPICIIO)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class FPSMetricGraphDriver : SingleMetricGraphDriver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[Header("Accumulation")]
		[SerializeField]
		[Min(0f)]
		private int framesToAccumulate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[SerializeField]
		private MetricAccumulateMode accumulateModeToUse;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[SerializeField]
		private string DisplayFormat;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		protected override int GBJFGDJNMEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xC9F1D0", Offset = "0xC9DBD0", VA = "0x180C9F1D0", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected override MetricAccumulateMode GMPMMJCKDIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xCA7130", Offset = "0xCA5B30", VA = "0x180CA7130", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "4")]
		protected override MetricDataUnits FLCGMKIENMC()
		{
			return default(MetricDataUnits);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x80EF6E0", Offset = "0x80EE0E0", VA = "0x1880EF6E0", Slot = "14")]
		protected override bool IDAPKIGLPJL(string BGLBOEOBIME = "0.00", [Optional] string ENFHKHJDFEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x80EF7E0", Offset = "0x80EE1E0", VA = "0x1880EF7E0")]
		public FPSMetricGraphDriver()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class FrameTimeMetricGraphDriver : SingleMetricGraphDriver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[Header("Accumulation")]
		[SerializeField]
		[Min(0f)]
		private int framesToAccumulate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[SerializeField]
		private MetricAccumulateMode accumulateModeToUse;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		protected override int GBJFGDJNMEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xC9F1D0", Offset = "0xC9DBD0", VA = "0x180C9F1D0", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected override MetricAccumulateMode GMPMMJCKDIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xCA7130", Offset = "0xCA5B30", VA = "0x180CA7130", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x19183E0", Offset = "0x1916DE0", VA = "0x1819183E0", Slot = "4")]
		protected override MetricDataUnits FLCGMKIENMC()
		{
			return default(MetricDataUnits);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x80EF860", Offset = "0x80EE260", VA = "0x1880EF860", Slot = "14")]
		protected override bool IDAPKIGLPJL(string BGLBOEOBIME = "0.00", [Optional] string ENFHKHJDFEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x80EF940", Offset = "0x80EE340", VA = "0x1880EF940")]
		public FrameTimeMetricGraphDriver()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum MetricAccumulateMode
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		Average,
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		AveragePerSecond,
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		Max,
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		Min,
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		First,
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		Last,
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		Sum
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class MetricGraphDriverBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		protected const string MHHBOIELPIK = "0.00";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		protected double EAIIJHHDNOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		protected double EIFJIMBELPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		protected double CJFNGMMJMCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		protected double DOPGHHFLAFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		protected double CAPABJPBCFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		protected int LOLNMGBLDNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		protected double BJNMCCLDBMC;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		protected abstract int GBJFGDJNMEE
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		protected abstract MetricAccumulateMode GMPMMJCKDIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		protected bool POKNPEJJIHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xCF5530", Offset = "0xCF3F30", VA = "0x180CF5530")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xCF5520", Offset = "0xCF3F20", VA = "0x180CF5520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract MetricDataUnits FLCGMKIENMC();

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected abstract void MPJHNCFGDDJ();

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1922010", Offset = "0x1920A10", VA = "0x181922010", Slot = "9")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1922010", Offset = "0x1920A10", VA = "0x181922010")]
		protected void GLBCPLLPKLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x80EFEF0", Offset = "0x80EE8F0", VA = "0x1880EFEF0", Slot = "10")]
		protected virtual void BPMEDAOHOCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x80EFE30", Offset = "0x80EE830", VA = "0x1880EFE30", Slot = "11")]
		protected virtual void ABBEKIKKPGB(double NMOPDBHEHJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x80EFFE0", Offset = "0x80EE9E0", VA = "0x1880EFFE0", Slot = "12")]
		protected virtual double FHIAGOBMHKG(MetricAccumulateMode EIFAPPLPBAE)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x80EFF30", Offset = "0x80EE930", VA = "0x1880EFF30")]
		protected bool DGCAJMIONME(MetricGraph MAHFLPOCDJP, MetricAccumulateMode KMALIDMGEMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x80F0140", Offset = "0x80EEB40", VA = "0x1880F0140", Slot = "13")]
		protected virtual string NLMGJLMACHM(double PCDAHJCDHHF, string DFJIALHJPBA = "0.00", [Optional] string EBFLFLBDLDF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x80EF940", Offset = "0x80EE340", VA = "0x1880EF940")]
		protected MetricGraphDriverBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class ProfilingMetricGraphDriver : SingleMetricGraphDriver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[SerializeField]
		[Header("Profiling Metric")]
		public string metricCategoryName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[SerializeField]
		public string metricName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private ProfilerRecorderHandle FLJFPNJNMHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[Min(0f)]
		[SerializeField]
		[Header("Accumulation")]
		private int framesToAccumulate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[SerializeField]
		private MetricAccumulateMode accumulateModeToUse;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool ODGEPJANLBN
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x80F0B90", Offset = "0x80EF590", VA = "0x1880F0B90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		protected override int GBJFGDJNMEE
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xE49120", Offset = "0xE47B20", VA = "0x180E49120", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		protected override MetricAccumulateMode GMPMMJCKDIC
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0xE49110", Offset = "0xE47B10", VA = "0x180E49110", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x19183E0", Offset = "0x1916DE0", VA = "0x1819183E0", Slot = "4")]
		protected override MetricDataUnits FLCGMKIENMC()
		{
			return default(MetricDataUnits);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x80F0A10", Offset = "0x80EF410", VA = "0x1880F0A10", Slot = "14")]
		protected override bool IDAPKIGLPJL(string BGLBOEOBIME = "0.00", [Optional] string ENFHKHJDFEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x80F0AF0", Offset = "0x80EF4F0", VA = "0x1880F0AF0")]
		public ProfilingMetricGraphDriver()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class RandomMetricGraphDriver : SingleMetricGraphDriver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[SerializeField]
		[Min(0f)]
		[Header("Accumulation")]
		private int framesToAccumulate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[SerializeField]
		private MetricAccumulateMode accumulateModeToUse;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected override int GBJFGDJNMEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xC9F1D0", Offset = "0xC9DBD0", VA = "0x180C9F1D0", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected override MetricAccumulateMode GMPMMJCKDIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xCA7130", Offset = "0xCA5B30", VA = "0x180CA7130", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1386100", Offset = "0x1384B00", VA = "0x181386100", Slot = "4")]
		protected override MetricDataUnits FLCGMKIENMC()
		{
			return default(MetricDataUnits);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x80EF940", Offset = "0x80EE340", VA = "0x1880EF940")]
		public RandomMetricGraphDriver()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MetricDashboard : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[SerializeField]
		private List<ConfigurablePipelineGraphDriver> metricGraphDriverBases;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[SerializeField]
		private List<GraphConfigAsset> startingMetrics;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x80EF990", Offset = "0x80EE390", VA = "0x1880EF990")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x80EFD60", Offset = "0x80EE760", VA = "0x1880EFD60")]
		public MetricDashboard()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MetricGraphTextDisplay : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[Header("Metric Text")]
		[SerializeField]
		private TMP_Text nameText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private bool DNMHEIIJCNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[SerializeField]
		private TMP_Text categoryText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private bool PLIKGNCLHAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[SerializeField]
		private TMP_Text descriptionText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private bool PENHNIBBGCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[Header("Data Text")]
		[SerializeField]
		private TMP_Text samplesText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private bool PBANLGDFLMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		private TMP_Text curText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool PPPNKLEKDOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[SerializeField]
		private TMP_Text minText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private bool CLAIFBCEOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private TMP_Text maxText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private bool IDCHLBDIMBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		private TMP_Text avgText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private bool ILHNICOKOCL;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public string DILAPFJCFOM
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x80F0710", Offset = "0x80EF110", VA = "0x1880F0710")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x80F0990", Offset = "0x80EF390", VA = "0x1880F0990")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public string HMPLEJOMIBD
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x80F0490", Offset = "0x80EEE90", VA = "0x1880F0490")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x80F0850", Offset = "0x80EF250", VA = "0x1880F0850")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public string POIKOIBFAGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x80F0590", Offset = "0x80EEF90", VA = "0x1880F0590")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x80F08D0", Offset = "0x80EF2D0", VA = "0x1880F08D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public string PGBPLHFAAOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x80F0790", Offset = "0x80EF190", VA = "0x1880F0790")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x80F09D0", Offset = "0x80EF3D0", VA = "0x1880F09D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public string MCFJCKLNMMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x80F0510", Offset = "0x80EEF10", VA = "0x1880F0510")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x80F0890", Offset = "0x80EF290", VA = "0x1880F0890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public string PAPDOHNHCKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x80F0690", Offset = "0x80EF090", VA = "0x1880F0690")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x80F0950", Offset = "0x80EF350", VA = "0x1880F0950")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public string LBOHPPGOIOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x80F0610", Offset = "0x80EF010", VA = "0x1880F0610")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x80F0910", Offset = "0x80EF310", VA = "0x1880F0910")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public string CHCEHMLAIBI
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x80F0410", Offset = "0x80EEE10", VA = "0x1880F0410")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x80F0810", Offset = "0x80EF210", VA = "0x1880F0810")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x80F0330", Offset = "0x80EED30", VA = "0x1880F0330", Slot = "4")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x80F0270", Offset = "0x80EEC70", VA = "0x1880F0270")]
		protected string HBPAIABDDBH(bool IGBCJCGHNAE, TMP_Text CHCCOOMJKLJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x80F02F0", Offset = "0x80EECF0", VA = "0x1880F02F0")]
		protected void MDJLNKLAOMM(bool CJJPFCNJDAH, TMP_Text DKLAGICAOGN, string PCDAHJCDHHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4A0", Offset = "0xA0AEA0", VA = "0x180A0C4A0")]
		public MetricGraphTextDisplay()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public abstract class SingleMetricGraphDriver : MetricGraphDriverBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[SerializeField]
		protected string debugDescription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[SerializeField]
		[Header("Graph and Text")]
		[FormerlySerializedAs("targetGraph")]
		protected MetricGraph graphDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		protected bool MIPIKEADGJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[SerializeField]
		protected MetricGraphTextDisplay textDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		protected bool FGALLHJIABM;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x80F0FA0", Offset = "0x80EF9A0", VA = "0x1880F0FA0", Slot = "9")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x80F0EB0", Offset = "0x80EF8B0", VA = "0x1880F0EB0", Slot = "5")]
		protected override void MPJHNCFGDDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x80F0BA0", Offset = "0x80EF5A0", VA = "0x1880F0BA0", Slot = "14")]
		protected virtual bool IDAPKIGLPJL(string BGLBOEOBIME = "0.00", [Optional] string ENFHKHJDFEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x80EF940", Offset = "0x80EE340", VA = "0x1880EF940")]
		protected SingleMetricGraphDriver()
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
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public string FriendlyDescription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public string MetricSourceName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public string MetricName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public int FramesToAccumulate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int BufferSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public MetricAccumulateMode MetricAccumulateMode;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x80EF970", Offset = "0x80EE370", VA = "0x1880EF970")]
		public GraphConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class GraphConfigAsset : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[SerializeField]
		private GraphConfig graphConfig;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public GraphConfig GraphConfig
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xC49D80", Offset = "0xC48780", VA = "0x180C49D80")]
		public GraphConfigAsset()
		{
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

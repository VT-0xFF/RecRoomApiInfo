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
		[Cpp2IlInjected.Address(RVA = "0x8534000", Offset = "0x8533000", VA = "0x188534000")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x85343E0", Offset = "0x85333E0", VA = "0x1885343E0")]
		public AudioMetricDashboard()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class ConfigurablePipelineGraphDriver : SingleMetricGraphDriver, IMetricsSubscriber<RawMetric>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private MetricIdLookup GJLNIMNCOPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private IRawMetricsPipeline MNFFJFJINHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private IMetricCollectionRegistry AOIBDLAMCEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private MetricId AOMDDKMHFKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private int GNADFABAIKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private MetricAccumulateMode LEHIKOKAEJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private MetricCollectionToken GFDDDAIMFOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private MetricDescription OHKEKAEMFJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private GraphConfig NJGLBIJECPF;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		protected override int PNMFNHKJFJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xEF07A0", Offset = "0xEEF7A0", VA = "0x180EF07A0", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected override MetricAccumulateMode NBAHNGOIJLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xA6F000", Offset = "0xA6E000", VA = "0x180A6F000", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8534610", Offset = "0x8533610", VA = "0x188534610")]
		private void GPEJGANMNAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x85344B0", Offset = "0x85334B0", VA = "0x1885344B0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8534E70", Offset = "0x8533E70", VA = "0x188534E70", Slot = "9")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8534D60", Offset = "0x8533D60", VA = "0x188534D60")]
		protected void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x85347B0", Offset = "0x85337B0", VA = "0x1885347B0")]
		public void Initialize(GraphConfig AFEODADMEEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8534C50", Offset = "0x8533C50", VA = "0x188534C50", Slot = "14")]
		protected override bool MBCKEOFHAJK(string CIOEOJPIDOK = "0.00", [Optional] string EFNPGPIOFCO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8534510", Offset = "0x8533510", VA = "0x188534510")]
		public void HandleMetric([In] RawMetric CJGEKDBPIFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2E3E000", Offset = "0x2E3D000", VA = "0x182E3E000", Slot = "4")]
		protected override MetricDataUnits MHDHHMDOAKP()
		{
			return default(MetricDataUnits);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8534FE0", Offset = "0x8533FE0", VA = "0x188534FE0")]
		public ConfigurablePipelineGraphDriver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8534510", Offset = "0x8533510", VA = "0x188534510", Slot = "15")]
		private void DIIENNLIHDC([In] RawMetric CJGEKDBPIFJ)
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
		protected override int PNMFNHKJFJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xD1B380", Offset = "0xD1A380", VA = "0x180D1B380", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected override MetricAccumulateMode NBAHNGOIJLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xD243E0", Offset = "0xD233E0", VA = "0x180D243E0", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0", Slot = "4")]
		protected override MetricDataUnits MHDHHMDOAKP()
		{
			return default(MetricDataUnits);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8535020", Offset = "0x8534020", VA = "0x188535020", Slot = "14")]
		protected override bool MBCKEOFHAJK(string CIOEOJPIDOK = "0.00", [Optional] string EFNPGPIOFCO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8535120", Offset = "0x8534120", VA = "0x188535120")]
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
		protected override int PNMFNHKJFJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xD1B380", Offset = "0xD1A380", VA = "0x180D1B380", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected override MetricAccumulateMode NBAHNGOIJLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xD243E0", Offset = "0xD233E0", VA = "0x180D243E0", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1A07B00", Offset = "0x1A06B00", VA = "0x181A07B00", Slot = "4")]
		protected override MetricDataUnits MHDHHMDOAKP()
		{
			return default(MetricDataUnits);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x85351A0", Offset = "0x85341A0", VA = "0x1885351A0", Slot = "14")]
		protected override bool MBCKEOFHAJK(string CIOEOJPIDOK = "0.00", [Optional] string EFNPGPIOFCO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8535280", Offset = "0x8534280", VA = "0x188535280")]
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
		protected const string EJNHHANGHBB = "0.00";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		protected double CAFDMBBNMPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		protected double FEHDBDNDMMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		protected double ELOHJGOOOMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		protected double DCJCCMFMBBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		protected double PCBPDBOGLFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		protected int OIDOINPBBAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		protected double BLICNFAJBBN;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		protected abstract int PNMFNHKJFJP
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		protected abstract MetricAccumulateMode NBAHNGOIJLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		protected bool AONCHMLOHOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xAD32A0", Offset = "0xAD22A0", VA = "0x180AD32A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xAD3290", Offset = "0xAD2290", VA = "0x180AD3290")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract MetricDataUnits MHDHHMDOAKP();

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected abstract void DBJFNCEIMMC();

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1A14790", Offset = "0x1A13790", VA = "0x181A14790", Slot = "9")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1A14790", Offset = "0x1A13790", VA = "0x181A14790")]
		protected void KECGNBHDOBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8535A20", Offset = "0x8534A20", VA = "0x188535A20", Slot = "10")]
		protected virtual void NAFMCKIILCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x85358B0", Offset = "0x85348B0", VA = "0x1885358B0", Slot = "11")]
		protected virtual void IFFLANFGJGM(double IFANBELHCLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8535A60", Offset = "0x8534A60", VA = "0x188535A60", Slot = "12")]
		protected virtual double OBMKAAADFKA(MetricAccumulateMode LEHIKOKAEJH)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8535970", Offset = "0x8534970", VA = "0x188535970")]
		protected bool MFMEFAHPMIF(MetricGraph BKGCMOAONFI, MetricAccumulateMode PBBNDGKGPAB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8535780", Offset = "0x8534780", VA = "0x188535780", Slot = "13")]
		protected virtual string EGIEIKIDMGC(double IOALKPFEKEK, string IEAPGIAMHDB = "0.00", [Optional] string EEHKINFKFAO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8535280", Offset = "0x8534280", VA = "0x188535280")]
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
		private ProfilerRecorderHandle HMHHFPBFCAP;

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
		public bool IJHKEDKLBGO
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x8536180", Offset = "0x8535180", VA = "0x188536180")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		protected override int PNMFNHKJFJP
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xEF07B0", Offset = "0xEEF7B0", VA = "0x180EF07B0", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		protected override MetricAccumulateMode NBAHNGOIJLM
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0xEF07A0", Offset = "0xEEF7A0", VA = "0x180EF07A0", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x1A07B00", Offset = "0x1A06B00", VA = "0x181A07B00", Slot = "4")]
		protected override MetricDataUnits MHDHHMDOAKP()
		{
			return default(MetricDataUnits);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8536000", Offset = "0x8535000", VA = "0x188536000", Slot = "14")]
		protected override bool MBCKEOFHAJK(string CIOEOJPIDOK = "0.00", [Optional] string EFNPGPIOFCO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x85360E0", Offset = "0x85350E0", VA = "0x1885360E0")]
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
		protected override int PNMFNHKJFJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xD1B380", Offset = "0xD1A380", VA = "0x180D1B380", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected override MetricAccumulateMode NBAHNGOIJLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xD243E0", Offset = "0xD233E0", VA = "0x180D243E0", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x146AB10", Offset = "0x1469B10", VA = "0x18146AB10", Slot = "4")]
		protected override MetricDataUnits MHDHHMDOAKP()
		{
			return default(MetricDataUnits);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8535280", Offset = "0x8534280", VA = "0x188535280")]
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
		[Cpp2IlInjected.Address(RVA = "0x85352D0", Offset = "0x85342D0", VA = "0x1885352D0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x85356B0", Offset = "0x85346B0", VA = "0x1885356B0")]
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
		private bool NBEJACGFEIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[SerializeField]
		private TMP_Text categoryText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private bool PGBGPDGJPEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[SerializeField]
		private TMP_Text descriptionText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private bool AGGFJFFGPKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[Header("Data Text")]
		[SerializeField]
		private TMP_Text samplesText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private bool OEDPJPIFJNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		private TMP_Text curText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool POMFNLIMJHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[SerializeField]
		private TMP_Text minText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private bool CLCADJKDKGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private TMP_Text maxText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private bool IONMGFBPAIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		private TMP_Text avgText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private bool KFIDBPHNPBG;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public string PBDDFGNKNKJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x8535DE0", Offset = "0x8534DE0", VA = "0x188535DE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x8535F80", Offset = "0x8534F80", VA = "0x188535F80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public string IBFCAPOKBNP
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x8535D80", Offset = "0x8534D80", VA = "0x188535D80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x8535E40", Offset = "0x8534E40", VA = "0x188535E40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public string CMLPLJOMFBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x8535DA0", Offset = "0x8534DA0", VA = "0x188535DA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x8535EC0", Offset = "0x8534EC0", VA = "0x188535EC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public string DADALKGLEHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x8535DF0", Offset = "0x8534DF0", VA = "0x188535DF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x8535FC0", Offset = "0x8534FC0", VA = "0x188535FC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public string BHPNKNLNHNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8535D90", Offset = "0x8534D90", VA = "0x188535D90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8535E80", Offset = "0x8534E80", VA = "0x188535E80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public string HFBGGHAHDOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8535DD0", Offset = "0x8534DD0", VA = "0x188535DD0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8535F40", Offset = "0x8534F40", VA = "0x188535F40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public string GNKFFCEAMOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8535DB0", Offset = "0x8534DB0", VA = "0x188535DB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8535F00", Offset = "0x8534F00", VA = "0x188535F00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public string GNAMCNDMPLN
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x8535D60", Offset = "0x8534D60", VA = "0x188535D60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x8535E00", Offset = "0x8534E00", VA = "0x188535E00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8535C00", Offset = "0x8534C00", VA = "0x188535C00", Slot = "4")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8535CE0", Offset = "0x8534CE0", VA = "0x188535CE0")]
		protected string PCPOOHEHLCE(bool FKIHKBCGGOO, TMP_Text MKOOPFGGHLN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8535BC0", Offset = "0x8534BC0", VA = "0x188535BC0")]
		protected void LIMMLMBAAEC(bool HNDMPIIFMJI, TMP_Text AOJAHPGAGPO, string IOALKPFEKEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xA60510", Offset = "0xA5F510", VA = "0x180A60510")]
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
		protected bool BDPGMBMKGOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[SerializeField]
		protected MetricGraphTextDisplay textDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		protected bool LMFAJIDCBAM;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8536590", Offset = "0x8535590", VA = "0x188536590", Slot = "9")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8536190", Offset = "0x8535190", VA = "0x188536190", Slot = "5")]
		protected override void DBJFNCEIMMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8536280", Offset = "0x8535280", VA = "0x188536280", Slot = "14")]
		protected virtual bool MBCKEOFHAJK(string CIOEOJPIDOK = "0.00", [Optional] string EFNPGPIOFCO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8535280", Offset = "0x8534280", VA = "0x188535280")]
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
		[Cpp2IlInjected.Address(RVA = "0x85352B0", Offset = "0x85342B0", VA = "0x1885352B0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xCF9400", Offset = "0xCF8400", VA = "0x180CF9400")]
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

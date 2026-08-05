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
		[Cpp2IlInjected.Address(RVA = "0x84BBD60", Offset = "0x84BA960", VA = "0x1884BBD60")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x84BC140", Offset = "0x84BAD40", VA = "0x1884BC140")]
		public AudioMetricDashboard()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class ConfigurablePipelineGraphDriver : SingleMetricGraphDriver, IMetricsSubscriber<RawMetric>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private MetricIdLookup HCCIJAEOHJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private IRawMetricsPipeline PCDMINGDEHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private IMetricCollectionRegistry CJIJNAKDGLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private MetricId CBICLEKJLCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private int FJAKHEIOBMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private MetricAccumulateMode MPIHKPPEAIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private MetricCollectionToken DANCOEFIHDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private MetricDescription JKGONHGBCMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private GraphConfig EKIEJCGEJKI;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		protected override int ODNCOFMFHAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xEC6310", Offset = "0xEC4F10", VA = "0x180EC6310", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected override MetricAccumulateMode FBMPKOJIBDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xA5EB00", Offset = "0xA5D700", VA = "0x180A5EB00", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x84BC380", Offset = "0x84BAF80", VA = "0x1884BC380")]
		private void DOOIJDFHIDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x84BC210", Offset = "0x84BAE10", VA = "0x1884BC210", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x84BCBD0", Offset = "0x84BB7D0", VA = "0x1884BCBD0", Slot = "9")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x84BCAC0", Offset = "0x84BB6C0", VA = "0x1884BCAC0")]
		protected void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x84BC620", Offset = "0x84BB220", VA = "0x1884BC620")]
		public void Initialize(GraphConfig EOOFAEFNDMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x84BC270", Offset = "0x84BAE70", VA = "0x1884BC270", Slot = "14")]
		protected override bool BIHDNFAOFHC(string AEOHLKEJIBA = "0.00", [Optional] string MIPLPNOGJKN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x84BC520", Offset = "0x84BB120", VA = "0x1884BC520")]
		public void HandleMetric([In] RawMetric HJPHCMEPGEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2E1DC60", Offset = "0x2E1C860", VA = "0x182E1DC60", Slot = "4")]
		protected override MetricDataUnits CGIHOHAGIGB()
		{
			return default(MetricDataUnits);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x84BCD40", Offset = "0x84BB940", VA = "0x1884BCD40")]
		public ConfigurablePipelineGraphDriver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x84BC520", Offset = "0x84BB120", VA = "0x1884BC520", Slot = "15")]
		private void MCOFBLLADMH([In] RawMetric HJPHCMEPGEK)
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
		protected override int ODNCOFMFHAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xD203E0", Offset = "0xD1EFE0", VA = "0x180D203E0", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected override MetricAccumulateMode FBMPKOJIBDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xD297F0", Offset = "0xD283F0", VA = "0x180D297F0", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0", Slot = "4")]
		protected override MetricDataUnits CGIHOHAGIGB()
		{
			return default(MetricDataUnits);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x84BCD80", Offset = "0x84BB980", VA = "0x1884BCD80", Slot = "14")]
		protected override bool BIHDNFAOFHC(string AEOHLKEJIBA = "0.00", [Optional] string MIPLPNOGJKN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x84BCE80", Offset = "0x84BBA80", VA = "0x1884BCE80")]
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
		protected override int ODNCOFMFHAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xD203E0", Offset = "0xD1EFE0", VA = "0x180D203E0", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected override MetricAccumulateMode FBMPKOJIBDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xD297F0", Offset = "0xD283F0", VA = "0x180D297F0", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x19EE5A0", Offset = "0x19ED1A0", VA = "0x1819EE5A0", Slot = "4")]
		protected override MetricDataUnits CGIHOHAGIGB()
		{
			return default(MetricDataUnits);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x84BCF00", Offset = "0x84BBB00", VA = "0x1884BCF00", Slot = "14")]
		protected override bool BIHDNFAOFHC(string AEOHLKEJIBA = "0.00", [Optional] string MIPLPNOGJKN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x84BCFE0", Offset = "0x84BBBE0", VA = "0x1884BCFE0")]
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
		protected const string ONCPJPAPAPO = "0.00";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		protected double GGDJHPMPEJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		protected double IOGLJBIBNFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		protected double ECFNEDEJLKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		protected double GCPLCMCOBFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		protected double BHKCALNJOMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		protected int KGKEMBDGFAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		protected double HMEKFGDDKGH;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		protected abstract int ODNCOFMFHAF
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		protected abstract MetricAccumulateMode FBMPKOJIBDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		protected bool GAJLJBDELKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xACDD90", Offset = "0xACC990", VA = "0x180ACDD90")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xACDD70", Offset = "0xACC970", VA = "0x180ACDD70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract MetricDataUnits CGIHOHAGIGB();

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected abstract void NBHJBIJCKOL();

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x19FAA90", Offset = "0x19F9690", VA = "0x1819FAA90", Slot = "9")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x19FAA90", Offset = "0x19F9690", VA = "0x1819FAA90")]
		protected void OMOEBHALAAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x84BD770", Offset = "0x84BC370", VA = "0x1884BD770", Slot = "10")]
		protected virtual void HBFABDMGCAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x84BD860", Offset = "0x84BC460", VA = "0x1884BD860", Slot = "11")]
		protected virtual void PHPDDJDPHEH(double EPLABNPNBHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x84BD4E0", Offset = "0x84BC0E0", VA = "0x1884BD4E0", Slot = "12")]
		protected virtual double BCBJOHGIKDN(MetricAccumulateMode MPIHKPPEAIL)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x84BD7B0", Offset = "0x84BC3B0", VA = "0x1884BD7B0")]
		protected bool KBABNKMNDDP(MetricGraph EAMANPAHEGF, MetricAccumulateMode CEBNHJNKAJN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x84BD640", Offset = "0x84BC240", VA = "0x1884BD640", Slot = "13")]
		protected virtual string FHBPBLPEOIK(double BKMPCFIAHIG, string DNHJAJKHKHI = "0.00", [Optional] string KPODOKPMIEG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x84BCFE0", Offset = "0x84BBBE0", VA = "0x1884BCFE0")]
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
		private ProfilerRecorderHandle PADHFEFPPJG;

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
		public bool EPKOINLLDLA
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x84BDEE0", Offset = "0x84BCAE0", VA = "0x1884BDEE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		protected override int ODNCOFMFHAF
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xEC6320", Offset = "0xEC4F20", VA = "0x180EC6320", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		protected override MetricAccumulateMode FBMPKOJIBDJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0xEC6310", Offset = "0xEC4F10", VA = "0x180EC6310", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x19EE5A0", Offset = "0x19ED1A0", VA = "0x1819EE5A0", Slot = "4")]
		protected override MetricDataUnits CGIHOHAGIGB()
		{
			return default(MetricDataUnits);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x84BDD60", Offset = "0x84BC960", VA = "0x1884BDD60", Slot = "14")]
		protected override bool BIHDNFAOFHC(string AEOHLKEJIBA = "0.00", [Optional] string MIPLPNOGJKN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x84BDE40", Offset = "0x84BCA40", VA = "0x1884BDE40")]
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
		protected override int ODNCOFMFHAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xD203E0", Offset = "0xD1EFE0", VA = "0x180D203E0", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected override MetricAccumulateMode FBMPKOJIBDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xD297F0", Offset = "0xD283F0", VA = "0x180D297F0", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1441430", Offset = "0x1440030", VA = "0x181441430", Slot = "4")]
		protected override MetricDataUnits CGIHOHAGIGB()
		{
			return default(MetricDataUnits);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x84BCFE0", Offset = "0x84BBBE0", VA = "0x1884BCFE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x84BD030", Offset = "0x84BBC30", VA = "0x1884BD030")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x84BD410", Offset = "0x84BC010", VA = "0x1884BD410")]
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
		private bool EJNLLGHCCCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[SerializeField]
		private TMP_Text categoryText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private bool FCEODBMAKDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[SerializeField]
		private TMP_Text descriptionText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private bool JBKAHDCDIML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[Header("Data Text")]
		[SerializeField]
		private TMP_Text samplesText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private bool HBCOBANHHPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		private TMP_Text curText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool CKOOAFDHEIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[SerializeField]
		private TMP_Text minText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private bool LEPDNNEMIGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private TMP_Text maxText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private bool BIIALKPPMHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		private TMP_Text avgText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private bool NHDNLFFPFDM;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public string NKIBMNDOOGP
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x84BDB40", Offset = "0x84BC740", VA = "0x1884BDB40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x84BDCE0", Offset = "0x84BC8E0", VA = "0x1884BDCE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public string JPEHKDAJGJG
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x84BDAE0", Offset = "0x84BC6E0", VA = "0x1884BDAE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x84BDBA0", Offset = "0x84BC7A0", VA = "0x1884BDBA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public string LLIGKEMLCED
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x84BDB00", Offset = "0x84BC700", VA = "0x1884BDB00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x84BDC20", Offset = "0x84BC820", VA = "0x1884BDC20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public string ABGICJLJHJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x84BDB50", Offset = "0x84BC750", VA = "0x1884BDB50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x84BDD20", Offset = "0x84BC920", VA = "0x1884BDD20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public string JDCAEJKBCDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x84BDAF0", Offset = "0x84BC6F0", VA = "0x1884BDAF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x84BDBE0", Offset = "0x84BC7E0", VA = "0x1884BDBE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public string HIEHICJBHKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x84BDB30", Offset = "0x84BC730", VA = "0x1884BDB30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x84BDCA0", Offset = "0x84BC8A0", VA = "0x1884BDCA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public string JKAGLDFBKBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x84BDB10", Offset = "0x84BC710", VA = "0x1884BDB10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x84BDC60", Offset = "0x84BC860", VA = "0x1884BDC60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public string HPNMPPPAAMN
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x84BDAC0", Offset = "0x84BC6C0", VA = "0x1884BDAC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x84BDB60", Offset = "0x84BC760", VA = "0x1884BDB60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x84BD9E0", Offset = "0x84BC5E0", VA = "0x1884BD9E0", Slot = "4")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x84BD920", Offset = "0x84BC520", VA = "0x1884BD920")]
		protected string BFBNFCFPEAO(bool JOHAACPEMPF, TMP_Text NDMEBHICHPO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x84BD9A0", Offset = "0x84BC5A0", VA = "0x1884BD9A0")]
		protected void OBILNEAANJG(bool MCHDNCDKFDN, TMP_Text ADGCHNLKFKK, string BKMPCFIAHIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xA5E010", Offset = "0xA5CC10", VA = "0x180A5E010")]
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
		protected bool INAGMKFNMGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[SerializeField]
		protected MetricGraphTextDisplay textDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		protected bool LGAGNBNPBNA;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x84BE2F0", Offset = "0x84BCEF0", VA = "0x1884BE2F0", Slot = "9")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x84BE200", Offset = "0x84BCE00", VA = "0x1884BE200", Slot = "5")]
		protected override void NBHJBIJCKOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x84BDEF0", Offset = "0x84BCAF0", VA = "0x1884BDEF0", Slot = "14")]
		protected virtual bool BIHDNFAOFHC(string AEOHLKEJIBA = "0.00", [Optional] string MIPLPNOGJKN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x84BCFE0", Offset = "0x84BBBE0", VA = "0x1884BCFE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x84BD010", Offset = "0x84BBC10", VA = "0x1884BD010")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xCCB4F0", Offset = "0xCCA0F0", VA = "0x180CCB4F0")]
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

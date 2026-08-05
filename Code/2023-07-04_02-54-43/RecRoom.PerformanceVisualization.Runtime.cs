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
		protected override int IPIAFAOAHJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0xF80BC0", Offset = "0xF7F1C0", VA = "0x180F80BC0", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected override MetricAccumulateMode HHHBGJFJBDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x1373360", Offset = "0x1371960", VA = "0x181373360", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA668F0", Offset = "0xA64EF0", VA = "0x180A668F0", Slot = "4")]
		protected override JJNLDEIPKFC DMKIOHHCINN()
		{
			return default(JJNLDEIPKFC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6F78130", Offset = "0x6F76730", VA = "0x186F78130", Slot = "14")]
		protected override bool ALJDAFNEHHN(string JLCMELBNKCH = "0.00", [Optional] string CFMFGGFBGNO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6F78210", Offset = "0x6F76810", VA = "0x186F78210")]
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
		private MetricIdLookup NAGBIJHKFPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private IRawMetricsPipeline FGLOLGMNCKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private IMetricCollectionRegistry KOBAPCGBBOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private MetricId HDCNEGLMOND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private int CEIDCIOAIPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private MetricAccumulateMode GKJNLKLNHBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private MetricCollectionToken LODBJLOKBLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private MetricDescription HBLEJDHJCIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private GraphConfig MJHOHMIFFAI;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		protected override int IPIAFAOAHJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x1568BF0", Offset = "0x15671F0", VA = "0x181568BF0", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected override MetricAccumulateMode HHHBGJFJBDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xBEC3B0", Offset = "0xBEA9B0", VA = "0x180BEC3B0", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6F776F0", Offset = "0x6F75CF0", VA = "0x186F776F0")]
		private void GMPOMEAAFGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6F77590", Offset = "0x6F75B90", VA = "0x186F77590", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6F77DD0", Offset = "0x6F763D0", VA = "0x186F77DD0", Slot = "9")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6F77CD0", Offset = "0x6F762D0", VA = "0x186F77CD0")]
		protected void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6F77850", Offset = "0x6F75E50", VA = "0x186F77850")]
		public void Initialize(GraphConfig DEBNDFBOADK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6F77480", Offset = "0x6F75A80", VA = "0x186F77480", Slot = "14")]
		protected override bool ALJDAFNEHHN(string JLCMELBNKCH = "0.00", [Optional] string CFMFGGFBGNO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6F775F0", Offset = "0x6F75BF0", VA = "0x186F775F0")]
		public void HandleMetric(in RawMetric GBHEJKLLKFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3F55450", Offset = "0x3F53A50", VA = "0x183F55450", Slot = "4")]
		protected override JJNLDEIPKFC DMKIOHHCINN()
		{
			return default(JJNLDEIPKFC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6F77F50", Offset = "0x6F76550", VA = "0x186F77F50")]
		public ConfigurablePipelineGraphDriver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6F775F0", Offset = "0x6F75BF0", VA = "0x186F775F0", Slot = "15")]
		private void BDCODGJFANK(in RawMetric GBHEJKLLKFC)
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
		[Cpp2IlInjected.Address(RVA = "0x6F793F0", Offset = "0x6F779F0", VA = "0x186F793F0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6F797D0", Offset = "0x6F77DD0", VA = "0x186F797D0")]
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
		protected override int IPIAFAOAHJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xF80BC0", Offset = "0xF7F1C0", VA = "0x180F80BC0", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected override MetricAccumulateMode HHHBGJFJBDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x1373360", Offset = "0x1371960", VA = "0x181373360", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1E4D700", Offset = "0x1E4BD00", VA = "0x181E4D700", Slot = "4")]
		protected override JJNLDEIPKFC DMKIOHHCINN()
		{
			return default(JJNLDEIPKFC);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6F7E0E0", Offset = "0x6F7C6E0", VA = "0x186F7E0E0")]
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
		protected override int IPIAFAOAHJN
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xF80BC0", Offset = "0xF7F1C0", VA = "0x180F80BC0", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		protected override MetricAccumulateMode HHHBGJFJBDI
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x1373360", Offset = "0x1371960", VA = "0x181373360", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x921950", Offset = "0x91FF50", VA = "0x180921950", Slot = "4")]
		protected override JJNLDEIPKFC DMKIOHHCINN()
		{
			return default(JJNLDEIPKFC);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6F77FA0", Offset = "0x6F765A0", VA = "0x186F77FA0", Slot = "14")]
		protected override bool ALJDAFNEHHN(string JLCMELBNKCH = "0.00", [Optional] string CFMFGGFBGNO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6F780A0", Offset = "0x6F766A0", VA = "0x186F780A0")]
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
		private bool DHJGIPOCNPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[SerializeField]
		private TMP_Text categoryText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private bool MAPIFKLAGOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[SerializeField]
		private TMP_Text descriptionText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private bool DCEOIHOMGGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[SerializeField]
		[Header("Data Text")]
		private TMP_Text samplesText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private bool GMNLAJFNNFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[SerializeField]
		private TMP_Text curText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private bool IDPDEFECCNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[SerializeField]
		private TMP_Text minText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private bool IGOKHLPDALF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[SerializeField]
		private TMP_Text maxText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private bool MKNELNDNDMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[SerializeField]
		private TMP_Text avgText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private bool EGODFKKOKFA;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string HLEDKHNFECA
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6F7A270", Offset = "0x6F78870", VA = "0x186F7A270")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6F7A4F0", Offset = "0x6F78AF0", VA = "0x186F7A4F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string DHONAGAHKOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6F79FF0", Offset = "0x6F785F0", VA = "0x186F79FF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6F7A3B0", Offset = "0x6F789B0", VA = "0x186F7A3B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public string MNIFPKPCPKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6F7A0F0", Offset = "0x6F786F0", VA = "0x186F7A0F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6F7A430", Offset = "0x6F78A30", VA = "0x186F7A430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string AIFPIJPFHAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6F7A2F0", Offset = "0x6F788F0", VA = "0x186F7A2F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6F7A530", Offset = "0x6F78B30", VA = "0x186F7A530")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public string NGGPGEKNINP
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6F7A070", Offset = "0x6F78670", VA = "0x186F7A070")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6F7A3F0", Offset = "0x6F789F0", VA = "0x186F7A3F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public string EFJPKCOAEHI
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6F7A1F0", Offset = "0x6F787F0", VA = "0x186F7A1F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6F7A4B0", Offset = "0x6F78AB0", VA = "0x186F7A4B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public string ODPJCMGCPEN
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6F7A170", Offset = "0x6F78770", VA = "0x186F7A170")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6F7A470", Offset = "0x6F78A70", VA = "0x186F7A470")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public string DJNPNAMGNEG
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6F79F70", Offset = "0x6F78570", VA = "0x186F79F70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6F7A370", Offset = "0x6F78970", VA = "0x186F7A370")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6F79E80", Offset = "0x6F78480", VA = "0x186F79E80", Slot = "4")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6F79DC0", Offset = "0x6F783C0", VA = "0x186F79DC0")]
		protected string DGCBNOFNCIH(bool NJIFIHNFHON, ref TMP_Text BDIPIDIIILI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6F79E40", Offset = "0x6F78440", VA = "0x186F79E40")]
		protected void LEGCDPJGDFE(bool HBLJGGPNDPI, ref TMP_Text DPNGJGBLPFN, string FEBHELIDNED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x996120", Offset = "0x994720", VA = "0x180996120")]
		public MetricGraphTextDisplay()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[DefaultMember("Item")]
public class HAFDANEPPOL
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class JPDODFOHPPM : IEnumerable<float>, IEnumerable, IEnumerator<float>, IEnumerator, IDisposable
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
		public HAFDANEPPOL <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0xA34EB0", Offset = "0xA334B0", VA = "0x180A34EB0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6F789E0", Offset = "0x6F76FE0", VA = "0x186F789E0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xE44CB0", Offset = "0xE432B0", VA = "0x180E44CB0")]
		[DebuggerHidden]
		public JPDODFOHPPM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6F78800", Offset = "0x6F76E00", VA = "0x186F78800", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6F789A0", Offset = "0x6F76FA0", VA = "0x186F789A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6F788F0", Offset = "0x6F76EF0", VA = "0x186F788F0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<float> IEnumerable<float>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6F788F0", Offset = "0x6F76EF0", VA = "0x186F788F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	protected float[] KPIOFAHLKBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	protected int KFFMPGMIKHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	protected int EGIKAKGFKPB;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int KLPPADFIIJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xC6DAE0", Offset = "0xC6C0E0", VA = "0x180C6DAE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int ACDNNLEEIOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xB18580", Offset = "0xB16B80", VA = "0x180B18580")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float BKDPLOKEFKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6F78780", Offset = "0x6F76D80", VA = "0x186F78780")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public float LMCLDPFOEMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6F78530", Offset = "0x6F76B30", VA = "0x186F78530")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float KCHGKMPBAJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6F772D0", Offset = "0x6F758D0", VA = "0x186F772D0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6F78790", Offset = "0x6F76D90", VA = "0x186F78790")]
	public HAFDANEPPOL(int IOKNIDFIOPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6F783D0", Offset = "0x6F769D0", VA = "0x186F783D0")]
	public void AMCJKKDICAA(int BGODJEBBIME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6F78460", Offset = "0x6F76A60", VA = "0x186F78460")]
	public void DFIPDLPCFDI(float FEBHELIDNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4493EB0", Offset = "0x44924B0", VA = "0x184493EB0")]
	public void GCOEEFENJAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6F78540", Offset = "0x6F76B40", VA = "0x186F78540")]
	public IEnumerable<float> HKDJCJBGMCP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6F785C0", Offset = "0x6F76BC0", VA = "0x186F785C0")]
	[IteratorStateMachine(typeof(JPDODFOHPPM))]
	public IEnumerable<float> HKDJCJBGMCP(int FNIKNJKPJAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6F77380", Offset = "0x6F75980", VA = "0x186F77380")]
	public void JKDPFLNDEDE(float[] DPNGJGBLPFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6F78640", Offset = "0x6F76C40", VA = "0x186F78640")]
	public void JKDPFLNDEDE(float[] DPNGJGBLPFN, int DMFHJCPLEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6F78750", Offset = "0x6F76D50", VA = "0x186F78750")]
	private int MEKAJFAAJGL(int IIOMOLKAONM)
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
		private ProfilerMarker KGBNPJDDBDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private ProfilerMarker AJLIKPAFFDD;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private const int HDGOOHHCPNJ = 8;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private const int GKEALPJJKKO = 512;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[SerializeField]
		[Header("Buffer")]
		[Range(8f, 512f)]
		private int bufferCapacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private HAFDANEPPOL JDGADENGBKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private bool GJNPPOOBJDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private float HIPHBJIGKGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private float OJFDDKCNBKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private float PAMLFDKDKMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private float NJABMPPCKOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private float CBGIKMOMJJM;

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
		private OCGHADKIHHP EAOBGMCHKCJ;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private int AMFAPGGOEMN
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6F7A7F0", Offset = "0x6F78DF0", VA = "0x186F7A7F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private int KMDJCANBMJG
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6F7A810", Offset = "0x6F78E10", VA = "0x186F7A810")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private int MLACBFFFGIP
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6F7A9C0", Offset = "0x6F78FC0", VA = "0x186F7A9C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public int CEJIMCLMCEN
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x6F7BA30", Offset = "0x6F7A030", VA = "0x186F7BA30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int GPPLDDHMBBH
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x6F7BA00", Offset = "0x6F7A000", VA = "0x186F7BA00")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float NONEBCFNKOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6F7B960", Offset = "0x6F79F60", VA = "0x186F7B960")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float PKIACIDBGHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x6F7B9A0", Offset = "0x6F79FA0", VA = "0x186F7B9A0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float OFIFKGKOHKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x6F7B980", Offset = "0x6F79F80", VA = "0x186F7B980")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float AILHIIBCCIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6F7B9C0", Offset = "0x6F79FC0", VA = "0x186F7B9C0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float PBOGDONFFAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6F7B9E0", Offset = "0x6F79FE0", VA = "0x186F7B9E0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A570", Offset = "0x6F78B70", VA = "0x186F7A570")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6F7B740", Offset = "0x6F79D40", VA = "0x186F7B740")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6F7B360", Offset = "0x6F79960", VA = "0x186F7B360")]
		public void PushSample(double FINNLFNCLPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A5A0", Offset = "0x6F78BA0", VA = "0x186F7A5A0")]
		public void ClearSamples()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A5C0", Offset = "0x6F78BC0", VA = "0x186F7A5C0")]
		private void FNMGMEJPGGO(bool PNPIPMIPGBD = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6F7B450", Offset = "0x6F79A50", VA = "0x186F7B450")]
		public void UpdateShader()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A830", Offset = "0x6F78E30", VA = "0x186F7A830")]
		public void InitData(int GMFPLLIIOCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6F7AA30", Offset = "0x6F79030", VA = "0x186F7AA30")]
		private void PHKKFHBPNKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6F7B770", Offset = "0x6F79D70", VA = "0x186F7B770")]
		public MetricGraph()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class OCGHADKIHHP
{
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public const int KPMNBIBKDDJ = 512;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public const int GBNCAGKLMIM = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public int NBJCKGPOOBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public float[] LEJHDMMFKLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public RawImage DHIENEHEFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float ANCHNGLMLLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float LOCLBJEEKCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public float CBBMMGFJNLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public float OKCIBJDAGHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public float IABKAOBGIMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public Color AKGKFAGMALC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public Color KGDPJABCHOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public bool PNIFBCHKGFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public Color GEAKAOFGCNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public Color JJIPGEJFDHC;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly int HONOLIBGBGD;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static readonly int DDJMNEHLELP;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly int FGDGFNCNDCM;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly int KDGPFINKJLK;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly int OPNFIOEJDHF;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static readonly int LPCLCLOAPAI;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly int OKHGOJEEHFE;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly int BNLJBIMIGHJ;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly int CKLDADNBDEM;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static readonly int OFOBLKNHDPJ;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static readonly int JLFFCJDBHPD;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static readonly int ALIHBBDEAPO;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6F7BBE0", Offset = "0x6F7A1E0", VA = "0x186F7BBE0")]
	public void CFBMCECJCED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6F7BB30", Offset = "0x6F7A130", VA = "0x186F7BB30")]
	public void CBJIJIAEADK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6F7BD80", Offset = "0x6F7A380", VA = "0x186F7BD80")]
	public void HLDCDFIOMFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6F7BE20", Offset = "0x6F7A420", VA = "0x186F7BE20")]
	public void LFEPBMDDCHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6F7BF00", Offset = "0x6F7A500", VA = "0x186F7BF00")]
	public void LFFPLPCFDGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6F7C0A0", Offset = "0x6F7A6A0", VA = "0x186F7C0A0")]
	public void MLAMCNLFIKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6F7BCA0", Offset = "0x6F7A2A0", VA = "0x186F7BCA0")]
	public void FKKNEDFMIKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6F7C370", Offset = "0x6F7A970", VA = "0x186F7C370")]
	public OCGHADKIHHP()
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
		private ProfilerRecorderHandle ECABKBAGGJK;

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
		private static bool BDEMIKBKCNN;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool MKBGKBHDGPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x6F7E0D0", Offset = "0x6F7C6D0", VA = "0x186F7E0D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		protected override int IPIAFAOAHJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x998280", Offset = "0x996880", VA = "0x180998280", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		protected override MetricAccumulateMode HHHBGJFJBDI
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x1568BF0", Offset = "0x15671F0", VA = "0x181568BF0", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xA668F0", Offset = "0xA64EF0", VA = "0x180A668F0", Slot = "4")]
		protected override JJNLDEIPKFC DMKIOHHCINN()
		{
			return default(JJNLDEIPKFC);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6F7DF10", Offset = "0x6F7C510", VA = "0x186F7DF10", Slot = "14")]
		protected override bool ALJDAFNEHHN(string JLCMELBNKCH = "0.00", [Optional] string CFMFGGFBGNO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6F7E030", Offset = "0x6F7C630", VA = "0x186F7E030")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F783B0", Offset = "0x6F769B0", VA = "0x186F783B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x9A2FF0", Offset = "0x9A15F0", VA = "0x1809A2FF0")]
		public GraphConfigAsset()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface FMHNFJKDFOH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool EJJKPGEEHMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	MetricDescription PMIHFOHLOFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "3")]
	RawMetricPayload KKDDINLHPAE();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class NBHMIHGKADK : FMHNFJKDFOH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly Func<double> EGIHMBMKBIO;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool EJJKPGEEHMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x954B90", Offset = "0x953190", VA = "0x180954B90", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x954BA0", Offset = "0x9531A0", VA = "0x180954BA0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public MetricDescription PMIHFOHLOFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2485380", Offset = "0x2483980", VA = "0x182485380", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(MetricDescription);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6F7BAE0", Offset = "0x6F7A0E0", VA = "0x186F7BAE0")]
	public NBHMIHGKADK(Func<double> EGIHMBMKBIO, MetricDescription HBLEJDHJCIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6F7BA50", Offset = "0x6F7A050", VA = "0x186F7BA50", Slot = "7")]
	public RawMetricPayload KKDDINLHPAE()
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
		protected const string KPCAAHFBLKF = "0.00";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		protected double HKFBGEPEGII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		protected double COHIJDOPJBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		protected double IMHKHDKGKDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		protected double LPEBHJLGNJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		protected double CKBGKNEGKDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		protected int OKGAKBMFAEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		protected double EKIBIBIOKBB;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		protected abstract int IPIAFAOAHJN
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		protected abstract MetricAccumulateMode HHHBGJFJBDI
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		protected bool DPFNMPFHDAD
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x9440C0", Offset = "0x9426C0", VA = "0x1809440C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x944020", Offset = "0x942620", VA = "0x180944020")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract JJNLDEIPKFC DMKIOHHCINN();

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected abstract void LLPGOKLEALJ();

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x117CF10", Offset = "0x117B510", VA = "0x18117CF10", Slot = "9")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x117CF10", Offset = "0x117B510", VA = "0x18117CF10")]
		protected void IDPMAGHHGDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6F79890", Offset = "0x6F77E90", VA = "0x186F79890", Slot = "10")]
		protected virtual void DDIPHCGDIIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6F798D0", Offset = "0x6F77ED0", VA = "0x186F798D0", Slot = "11")]
		protected virtual void IJCHCFKBDCN(double DHBEJNPKEEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6F799B0", Offset = "0x6F77FB0", VA = "0x186F799B0", Slot = "12")]
		protected virtual double JEILDIINCMC(MetricAccumulateMode GKJNLKLNHBC)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6F79B00", Offset = "0x6F78100", VA = "0x186F79B00")]
		protected bool MCDGFENJLAC(MetricGraph CEJDMMFKJDI, MetricAccumulateMode MBKPCEEDDBF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6F79C60", Offset = "0x6F78260", VA = "0x186F79C60", Slot = "13")]
		protected virtual string PMIICIFPGKD(double FEBHELIDNED, string OKEJGKEKJIO = "0.00", [Optional] string KKPPFBPPCGB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6F79D80", Offset = "0x6F78380", VA = "0x186F79D80")]
		protected MetricGraphDriverBase()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class OMKAJLMCLMK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private readonly struct FBIPEGPPAKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public readonly string EDHNGAAPCMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public readonly string GMCLIKLEKBM;

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xBBF9D0", Offset = "0xBBDFD0", VA = "0x180BBF9D0")]
		public FBIPEGPPAKG(string DAIKMCDJHDM, string LPGAECKDJBE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class GBIDBMDENKO : IAsyncStateMachine
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
		public OMKAJLMCLMK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public GBIDBMDENKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6F78250", Offset = "0x6F76850", VA = "0x186F78250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly MetricIdLookup NAGBIJHKFPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly IRawMetricsPipeline FGLOLGMNCKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly IMetricCollectionRegistry KOBAPCGBBOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly CancellationTokenSource NAANFKJBCAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly Dictionary<MetricId, FMHNFJKDFOH> PIKBNFOKDBE;

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private static readonly FBIPEGPPAKG[] MLKNJAMFJGB;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6F7C960", Offset = "0x6F7AF60", VA = "0x186F7C960")]
	[PJEDGFFEDPC(PDIHHCLCNFI.GameOnly)]
	private static void PEMAGMCLMID(EIHIACACEHJ FBBMHADLAOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6F7D650", Offset = "0x6F7BC50", VA = "0x186F7D650")]
	[Preserve]
	public OMKAJLMCLMK([NALHKAIJJND(null)] MetricIdLookup NAGBIJHKFPN, [NALHKAIJJND(null)] IRawMetricsPipeline FGLOLGMNCKI, [NALHKAIJJND(null)] IMetricCollectionRegistry KOBAPCGBBOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6F7C8A0", Offset = "0x6F7AEA0", VA = "0x186F7C8A0")]
	private void LBLIOIIMFOA(string KKLGCGCPOEI, string LPGAECKDJBE, JJNLDEIPKFC CGHNKOELPKN, Func<double> EGIHMBMKBIO, out MetricId HDCNEGLMOND, out FMHNFJKDFOH BDIPIDIIILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6F7C670", Offset = "0x6F7AC70", VA = "0x186F7C670")]
	private void CFKJPJNENCH(MetricId HDCNEGLMOND, bool KJKMEKEFNMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6F7C750", Offset = "0x6F7AD50", VA = "0x186F7C750")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GBIDBMDENKO))]
	private Task KLOBDCIIODB(CancellationToken OOAGLCBNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6F7C410", Offset = "0x6F7AA10", VA = "0x186F7C410")]
	public void APMEGEHDHNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6F7C710", Offset = "0x6F7AD10", VA = "0x186F7C710", Slot = "4")]
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
		protected bool PFNJJEFNOMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[SerializeField]
		protected MetricGraphTextDisplay textDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		protected bool PGIDFDADPFD;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6F7E630", Offset = "0x6F7CC30", VA = "0x186F7E630", Slot = "9")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6F7E470", Offset = "0x6F7CA70", VA = "0x186F7E470", Slot = "5")]
		protected override void LLPGOKLEALJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6F7E130", Offset = "0x6F7C730", VA = "0x186F7E130", Slot = "14")]
		protected virtual bool ALJDAFNEHHN(string JLCMELBNKCH = "0.00", [Optional] string CFMFGGFBGNO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6F79D80", Offset = "0x6F78380", VA = "0x186F79D80")]
		protected SingleMetricGraphDriver()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class LKFKPCDGHHP : FMHNFJKDFOH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static bool BDEMIKBKCNN;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static Dictionary<(ushort category, string name), ProfilerRecorderHandle> EKFNDILHLGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly MetricId HDCNEGLMOND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly string DAIKMCDJHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private readonly string LPGAECKDJBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private ProfilerRecorder ODDFGEEJPAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private bool AJABNBPCECG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private bool DJFOHEMPBGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private ProfilerRecorderDescription KLELDLOJDGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private ProfilerRecorderHandle ECABKBAGGJK;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool EJJKPGEEHMI
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xA33AD0", Offset = "0xA320D0", VA = "0x180A33AD0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xA34370", Offset = "0xA32970", VA = "0x180A34370", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public MetricDescription PMIHFOHLOFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x24853A0", Offset = "0x24839A0", VA = "0x1824853A0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(MetricDescription);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x2485390", Offset = "0x2483990", VA = "0x182485390")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool MKBGKBHDGPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6F78F50", Offset = "0x6F77550", VA = "0x186F78F50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6F79380", Offset = "0x6F77980", VA = "0x186F79380")]
	public LKFKPCDGHHP(MetricId HDCNEGLMOND, string DAIKMCDJHDM, string LPGAECKDJBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6F78F60", Offset = "0x6F77560", VA = "0x186F78F60", Slot = "7")]
	public RawMetricPayload KKDDINLHPAE()
	{
		return default(RawMetricPayload);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6F78A30", Offset = "0x6F77030", VA = "0x186F78A30")]
	private static ProfilerRecorderHandle BGBPBOBHLOM(string DAIKMCDJHDM, string LPGAECKDJBE)
	{
		return default(ProfilerRecorderHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6F78B80", Offset = "0x6F77180", VA = "0x186F78B80")]
	private void BGMFNLKBLIF(bool PNPIPMIPGBD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6F78EB0", Offset = "0x6F774B0", VA = "0x186F78EB0")]
	private static MetricDescription CLIFOCEKJAH(MetricId HDCNEGLMOND, ProfilerRecorderDescription BFDPMOPJELE)
	{
		return default(MetricDescription);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6F79020", Offset = "0x6F77620", VA = "0x186F79020")]
	private static bool MDKNJJCFKMB(bool PNPIPMIPGBD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6F78F30", Offset = "0x6F77530", VA = "0x186F78F30")]
	private void NIBHJNLAIEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6F78F30", Offset = "0x6F77530", VA = "0x186F78F30", Slot = "8")]
	public void Dispose()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class IMLHFCPJGKL
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
	public IMLHFCPJGKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD111C0", VA = "0x180D12BC0")]
	public static string GOMDFOEHABF(byte[] CEBGDHINIFO, byte[] FGJCLMKLDKK)
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

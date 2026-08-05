using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using RecRoom.Metrics.Pipeline.MetricInfo;
using RecRoom.NoEngine.Common;
using RecRoom.NoEngine.DataStructures;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_MetricsPipeline_Interfaces
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x9A4D900", Offset = "0x9A4C300", VA = "0x189A4D900", Slot = "4")]
		public override void WSFSWRIEDET()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD3AE50", Offset = "0xD39850", VA = "0x180D3AE50")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.Profiling
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public enum ThresholdResult
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Normal = 0,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Caution = -1,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Critical = -2
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface PMVAFTJTZYJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public delegate ThresholdResult MetricEvaluationDelegate(double value);

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		double QNAGCWMHYOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		double FEKXYFRUBFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		MetricEvaluationDelegate SMBBYXZKBHT
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "3")]
		RRColor32 CEKYUBOBSIF(ThresholdResult a);
	}
}
namespace RecRoom.Metrics
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public enum PerformanceBottleneck
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		Indeterminate,
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		PresentLimited,
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		CPU,
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		GPU,
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		CPUandGPU
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface IFrameTime
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		double GetMainThreadCPUFrameTimeMS();

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		double GetRenderThreadCPUFrameTimeMS();

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		double GetGPUFrameTimeMS();

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		double GetWaitForVsyncFrameTime();

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		PerformanceBottleneck DetermineBottleneck();
	}
}
namespace RecRoom.Metrics.Pipeline
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public interface IMetricCollectionRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event MetricCollectionRequiredChanged OnMetricCollectionEnabledChanged;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void MarkRequiresMetricCollection(MetricCollectionToken token, MetricId metricId);

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void MarkDoesNotRequireMetricCollection(MetricCollectionToken token, MetricId metricId);

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool IsMetricCollectionRequired(MetricId metricId);
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public delegate void MetricCollectionRequiredChanged(MetricId metricId, bool isMetricCollectionRequired);
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct MetricCollectionToken : IEquatable<MetricCollectionToken>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly string TokenName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public readonly object Token;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x111A430", Offset = "0x1118E30", VA = "0x18111A430")]
		public MetricCollectionToken(string tokenName, object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9A4DA30", Offset = "0x9A4C430", VA = "0x189A4DA30", Slot = "4")]
		public bool Equals(MetricCollectionToken other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9A4DA40", Offset = "0x9A4C440", VA = "0x189A4DA40", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9A4DAD0", Offset = "0x9A4C4D0", VA = "0x189A4DAD0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9A4DB00", Offset = "0x9A4C500", VA = "0x189A4DB00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class PayloadExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9A4FCF0", Offset = "0x9A4E6F0", VA = "0x189A4FCF0")]
		public static double ReadAsDouble(this RawMetricPayload rawMetricPayload)
		{
			return default(double);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class RawMetricPipelineExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9A502B0", Offset = "0x9A4ECB0", VA = "0x189A502B0")]
		public static void PublishMetric(this IRawMetricsPipeline pipeline, RawMetric rawMetric)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface IMetricsPublisher<TMessage>
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool AddSubscriber(IMetricsSubscriber<TMessage> subscriber);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool RemoveSubscriber(IMetricsSubscriber<TMessage> subscriber);
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface IMetricsSubscriber<TMessage>
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void HandleMetric([In] TMessage metricMessage);
	}
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public readonly struct MetricId : IEquatable<MetricId>
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public class MetricComparer : IEqualityComparer<MetricId>
		{
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public static readonly MetricComparer Instance;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x9A4DB40", Offset = "0x9A4C540", VA = "0x189A4DB40", Slot = "4")]
			public bool Equals(MetricId x, MetricId y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x9A4DB90", Offset = "0x9A4C590", VA = "0x189A4DB90", Slot = "5")]
			public int GetHashCode(MetricId obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public MetricComparer()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public const ushort INVALID_IDX = 0;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly MetricId Invalid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public readonly ushort SourceIdx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public readonly ushort MetricNameIdx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly uint CombinedId;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x6913E90", Offset = "0x6912890", VA = "0x186913E90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x68B15C0", Offset = "0x68AFFC0", VA = "0x1868B15C0")]
		public MetricId(ushort sourceIdx, ushort metricNameIdx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x23BD780", Offset = "0x23BC180", VA = "0x1823BD780", Slot = "4")]
		public bool Equals(MetricId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9A4EEF0", Offset = "0x9A4D8F0", VA = "0x189A4EEF0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xF8BD10", Offset = "0xF8A710", VA = "0x180F8BD10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9A4F070", Offset = "0x9A4DA70", VA = "0x189A4F070")]
		public static bool operator ==(MetricId left, MetricId right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9A4F0C0", Offset = "0x9A4DAC0", VA = "0x189A4F0C0")]
		public static bool operator !=(MetricId left, MetricId right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9A4EF90", Offset = "0x9A4D990", VA = "0x189A4EF90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class MetricIdLookup
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static readonly Log Logger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly MetricIdxRegistry sourceIdxRegistry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly Dictionary<ushort, MetricIdxRegistry> sourceNameIdxRegistries;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly List<MetricId> metricIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly Dictionary<MetricId, MetricDescription> metricDescriptions;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9A4EDB0", Offset = "0x9A4D7B0", VA = "0x189A4EDB0")]
		[RecRoom.NoEngine.Common.Preserve]
		public MetricIdLookup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9A4E0B0", Offset = "0x9A4CAB0", VA = "0x189A4E0B0")]
		public MetricId AddOrGetMetricId(string metricSourceName, string metricName)
		{
			return default(MetricId);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9A4E1E0", Offset = "0x9A4CBE0", VA = "0x189A4E1E0")]
		public MetricId GetMetricId(string metricSourceName, string metricName)
		{
			return default(MetricId);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9A4EB90", Offset = "0x9A4D590", VA = "0x189A4EB90")]
		public MetricDescription RegisterOrGetMetricDescription(string metricSourceName, string metricName, MetricDataUnits metricUnit, [Optional] string customSuffix)
		{
			return default(MetricDescription);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9A4E120", Offset = "0x9A4CB20", VA = "0x189A4E120")]
		public MetricDescription GetMetricDescription(MetricId metricId)
		{
			return default(MetricDescription);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9A4EC80", Offset = "0x9A4D680", VA = "0x189A4EC80")]
		public bool TryGetMetricNames(MetricId metricId, [Out] string metricSourceName, [Out] string metricName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9A4E350", Offset = "0x9A4CD50", VA = "0x189A4E350")]
		private (MetricId, bool, bool) Internal_AddOrGetMetricIdForNames(string metricSourceName, string metricName)
		{
			return default((MetricId, bool, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9A4E980", Offset = "0x9A4D380", VA = "0x189A4E980")]
		private (MetricDescription, bool) Internal_RegisterOrGetMetricDescription(MetricId metricId, MetricDataUnits metricUnit, string customSuffix)
		{
			return default((MetricDescription, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9A4E550", Offset = "0x9A4CF50", VA = "0x189A4E550")]
		private void Internal_LogAddMetric(string metricSourceName, string metricName, MetricId metricId, bool addedSource, bool addedName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9A4E690", Offset = "0x9A4D090", VA = "0x189A4E690")]
		private void Internal_LogRegisterDescription(MetricDescription description, bool addedDescription)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal class MetricIdxRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private const ushort INVALID_IDX = 0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly List<string> names;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly Dictionary<string, ushort> nameIdxLookup;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9A4F3B0", Offset = "0x9A4DDB0", VA = "0x189A4F3B0")]
		public bool TryGetNameIdx(string name, [Out] ushort idx)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9A4F200", Offset = "0x9A4DC00", VA = "0x189A4F200")]
		internal ushort RegisterNameIdx(string name)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9A4F110", Offset = "0x9A4DB10", VA = "0x189A4F110")]
		public (ushort, bool) AddOrGetNameId(string name)
		{
			return default((ushort, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9A4F300", Offset = "0x9A4DD00", VA = "0x189A4F300")]
		public bool TryGetIdxName(ushort idx, [Out] string name)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2613110", Offset = "0x2611B10", VA = "0x182613110")]
		internal static ushort InternalToIndex(int index)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9A4F1F0", Offset = "0x9A4DBF0", VA = "0x189A4F1F0")]
		internal static int IndexToInternal(ushort id)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9A4F420", Offset = "0x9A4DE20", VA = "0x189A4F420")]
		public MetricIdxRegistry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum MetricDataUnits : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		Undefined,
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		Number,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		Count,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		TimeNanoseconds,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		SizeInBytes,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		Percent,
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		FrequencyHz
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public enum MetricStorageTypes : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		Undefined,
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		Bytes8,
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		Int,
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		Float,
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		Long,
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		Double
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class MetricUnitFormatter
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9A4F880", Offset = "0x9A4E280", VA = "0x189A4F880")]
		public static (string, double) PrettyFormatSample(double sampleValue, MetricDataUnits sampleUnit, bool abbreviate = true)
		{
			return default((string, double));
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9A4F7A0", Offset = "0x9A4E1A0", VA = "0x189A4F7A0")]
		private static (string, double) PrettyFormatNanoSecondValue(double valueInNanoSeconds, bool abbreviate = true)
		{
			return default((string, double));
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9A4F4E0", Offset = "0x9A4DEE0", VA = "0x189A4F4E0")]
		private static (string, double) PrettyFormatByteValue(double valueInBytes, bool abbreviate = true)
		{
			return default((string, double));
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9A4F640", Offset = "0x9A4E040", VA = "0x189A4F640")]
		private static (string, double) PrettyFormatHzValue(double valueInHz, bool abbreviate = true)
		{
			return default((string, double));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public readonly struct RawMetric
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public readonly MetricId MetricId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public readonly RawMetricPayload MetricPayload;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x68B2190", Offset = "0x68B0B90", VA = "0x1868B2190")]
		public RawMetric(MetricId metricId, RawMetricPayload payload)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9A50390", Offset = "0x9A4ED90", VA = "0x189A50390")]
		public static RawMetric Long(MetricId metricId, long value)
		{
			return default(RawMetric);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9A50360", Offset = "0x9A4ED60", VA = "0x189A50360")]
		public static RawMetric Double(MetricId metricId, double value)
		{
			return default(RawMetric);
		}
	}
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public readonly struct RawMetricPayload : IEquatable<RawMetricPayload>
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int Int
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xF8BD10", Offset = "0xF8A710", VA = "0x180F8BD10")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public float Float
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x2E0AA30", Offset = "0x2E09430", VA = "0x182E0AA30")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public long Long
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xEF9560", Offset = "0xEF7F60", VA = "0x180EF9560")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public double Double
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x40A7C00", Offset = "0x40A6600", VA = "0x1840A7C00")]
			[CompilerGenerated]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public MetricStorageTypes MetricStorageType
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xEF9570", Offset = "0xEF7F70", VA = "0x180EF9570")]
			[CompilerGenerated]
			get
			{
				return default(MetricStorageTypes);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9A502A0", Offset = "0x9A4ECA0", VA = "0x189A502A0")]
		public RawMetricPayload(long longValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9A50290", Offset = "0x9A4EC90", VA = "0x189A50290")]
		public RawMetricPayload(double doubleValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9A4FE70", Offset = "0x9A4E870", VA = "0x189A4FE70", Slot = "4")]
		public bool Equals(RawMetricPayload other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x9A4FDD0", Offset = "0x9A4E7D0", VA = "0x189A4FDD0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9A50100", Offset = "0x9A4EB00", VA = "0x189A50100", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x9A50170", Offset = "0x9A4EB70", VA = "0x189A50170", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9A4FE90", Offset = "0x9A4E890", VA = "0x189A4FE90")]
		public static string FormatInt64AsHex(long data)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface IRawMetricsPipeline : IMetricsSubscriber<RawMetric>, IMetricsPublisher<RawMetric>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public interface IRawMetricsSubscriber : IMetricsSubscriber<RawMetric>
	{
	}
}
namespace RecRoom.Metrics.Pipeline.MetricInfo
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public readonly struct MetricDescription : IEquatable<MetricDescription>
	{
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public static readonly MetricDescription Invalid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public readonly MetricId MetricId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public readonly MetricDataUnits DataUnit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public readonly string CustomSuffix;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x9A4E060", Offset = "0x9A4CA60", VA = "0x189A4E060")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x82CE5C0", Offset = "0x82CCFC0", VA = "0x1882CE5C0")]
		public MetricDescription(MetricId metricId, MetricDataUnits dataUnit, [Optional] string customSuffix)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9A4DC50", Offset = "0x9A4C650", VA = "0x189A4DC50")]
		public (bool, bool) CanUpdateWith(MetricDescription description)
		{
			return default((bool, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9A4DEA0", Offset = "0x9A4C8A0", VA = "0x189A4DEA0", Slot = "4")]
		public bool Equals(MetricDescription other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9A4DD90", Offset = "0x9A4C790", VA = "0x189A4DD90", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x9A4DF30", Offset = "0x9A4C930", VA = "0x189A4DF30", Slot = "2")]
		public override int GetHashCode()
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

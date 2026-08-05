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
		[Cpp2IlInjected.Address(RVA = "0x85A4EF0", Offset = "0x85A3CF0", VA = "0x1885A4EF0", Slot = "4")]
		public override void DELFABVRANX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
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
	public interface ZISOJWSFYGL
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public delegate ThresholdResult MetricEvaluationDelegate(double value);

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		double ICLUNIEOUDW
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		double RZSJMFTBNJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		MetricEvaluationDelegate WVTMUHZGROL
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "3")]
		RRColor32 PAZNJTTJYRV(ThresholdResult a);
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
		[Cpp2IlInjected.Address(RVA = "0xEB4670", Offset = "0xEB3470", VA = "0x180EB4670")]
		public MetricCollectionToken(string tokenName, object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x85A5020", Offset = "0x85A3E20", VA = "0x1885A5020", Slot = "4")]
		public bool Equals(MetricCollectionToken other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x85A5030", Offset = "0x85A3E30", VA = "0x1885A5030", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x85A50C0", Offset = "0x85A3EC0", VA = "0x1885A50C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x85A50F0", Offset = "0x85A3EF0", VA = "0x1885A50F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class PayloadExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x85A72C0", Offset = "0x85A60C0", VA = "0x1885A72C0")]
		public static double ReadAsDouble(this RawMetricPayload rawMetricPayload)
		{
			return default(double);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class RawMetricPipelineExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x85A7870", Offset = "0x85A6670", VA = "0x1885A7870")]
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
			[Cpp2IlInjected.Address(RVA = "0x85A5130", Offset = "0x85A3F30", VA = "0x1885A5130", Slot = "4")]
			public bool Equals(MetricId x, MetricId y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x85A5180", Offset = "0x85A3F80", VA = "0x1885A5180", Slot = "5")]
			public int GetHashCode(MetricId obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x54925A0", Offset = "0x54913A0", VA = "0x1854925A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5437A80", Offset = "0x5436880", VA = "0x185437A80")]
		public MetricId(ushort sourceIdx, ushort metricNameIdx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2150750", Offset = "0x214F550", VA = "0x182150750", Slot = "4")]
		public bool Equals(MetricId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x85A64C0", Offset = "0x85A52C0", VA = "0x1885A64C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xD2C740", Offset = "0xD2B540", VA = "0x180D2C740", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x85A6640", Offset = "0x85A5440", VA = "0x1885A6640")]
		public static bool operator ==(MetricId left, MetricId right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x85A6690", Offset = "0x85A5490", VA = "0x1885A6690")]
		public static bool operator !=(MetricId left, MetricId right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x85A6560", Offset = "0x85A5360", VA = "0x1885A6560", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x85A6380", Offset = "0x85A5180", VA = "0x1885A6380")]
		[RecRoom.NoEngine.Common.Preserve]
		public MetricIdLookup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x85A5690", Offset = "0x85A4490", VA = "0x1885A5690")]
		public MetricId AddOrGetMetricId(string metricSourceName, string metricName)
		{
			return default(MetricId);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x85A57C0", Offset = "0x85A45C0", VA = "0x1885A57C0")]
		public MetricId GetMetricId(string metricSourceName, string metricName)
		{
			return default(MetricId);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x85A6160", Offset = "0x85A4F60", VA = "0x1885A6160")]
		public MetricDescription RegisterOrGetMetricDescription(string metricSourceName, string metricName, MetricDataUnits metricUnit, [Optional] string customSuffix)
		{
			return default(MetricDescription);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x85A5700", Offset = "0x85A4500", VA = "0x1885A5700")]
		public MetricDescription GetMetricDescription(MetricId metricId)
		{
			return default(MetricDescription);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x85A6250", Offset = "0x85A5050", VA = "0x1885A6250")]
		public bool TryGetMetricNames(MetricId metricId, [Out] string metricSourceName, [Out] string metricName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x85A5930", Offset = "0x85A4730", VA = "0x1885A5930")]
		private (MetricId, bool, bool) Internal_AddOrGetMetricIdForNames(string metricSourceName, string metricName)
		{
			return default((MetricId, bool, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F50", Offset = "0x85A4D50", VA = "0x1885A5F50")]
		private (MetricDescription, bool) Internal_RegisterOrGetMetricDescription(MetricId metricId, MetricDataUnits metricUnit, string customSuffix)
		{
			return default((MetricDescription, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x85A5B30", Offset = "0x85A4930", VA = "0x1885A5B30")]
		private void Internal_LogAddMetric(string metricSourceName, string metricName, MetricId metricId, bool addedSource, bool addedName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x85A5C70", Offset = "0x85A4A70", VA = "0x1885A5C70")]
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
		[Cpp2IlInjected.Address(RVA = "0x85A6980", Offset = "0x85A5780", VA = "0x1885A6980")]
		public bool TryGetNameIdx(string name, [Out] ushort idx)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x85A67D0", Offset = "0x85A55D0", VA = "0x1885A67D0")]
		internal ushort RegisterNameIdx(string name)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x85A66E0", Offset = "0x85A54E0", VA = "0x1885A66E0")]
		public (ushort, bool) AddOrGetNameId(string name)
		{
			return default((ushort, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x85A68D0", Offset = "0x85A56D0", VA = "0x1885A68D0")]
		public bool TryGetIdxName(ushort idx, [Out] string name)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x239FE90", Offset = "0x239EC90", VA = "0x18239FE90")]
		internal static ushort InternalToIndex(int index)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x85A67C0", Offset = "0x85A55C0", VA = "0x1885A67C0")]
		internal static int IndexToInternal(ushort id)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x85A69F0", Offset = "0x85A57F0", VA = "0x1885A69F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x85A6E50", Offset = "0x85A5C50", VA = "0x1885A6E50")]
		public static (string, double) PrettyFormatSample(double sampleValue, MetricDataUnits sampleUnit, bool abbreviate = true)
		{
			return default((string, double));
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x85A6D70", Offset = "0x85A5B70", VA = "0x1885A6D70")]
		private static (string, double) PrettyFormatNanoSecondValue(double valueInNanoSeconds, bool abbreviate = true)
		{
			return default((string, double));
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x85A6AB0", Offset = "0x85A58B0", VA = "0x1885A6AB0")]
		private static (string, double) PrettyFormatByteValue(double valueInBytes, bool abbreviate = true)
		{
			return default((string, double));
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x85A6C10", Offset = "0x85A5A10", VA = "0x1885A6C10")]
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
		[Cpp2IlInjected.Address(RVA = "0x5438420", Offset = "0x5437220", VA = "0x185438420")]
		public RawMetric(MetricId metricId, RawMetricPayload payload)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x85A7950", Offset = "0x85A6750", VA = "0x1885A7950")]
		public static RawMetric Long(MetricId metricId, long value)
		{
			return default(RawMetric);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x85A7920", Offset = "0x85A6720", VA = "0x1885A7920")]
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
			[Cpp2IlInjected.Address(RVA = "0xD2C740", Offset = "0xD2B540", VA = "0x180D2C740")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B8EAA0", Offset = "0x2B8D8A0", VA = "0x182B8EAA0")]
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
			[Cpp2IlInjected.Address(RVA = "0xC9F850", Offset = "0xC9E650", VA = "0x180C9F850")]
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
			[Cpp2IlInjected.Address(RVA = "0x3C4CB00", Offset = "0x3C4B900", VA = "0x183C4CB00")]
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
			[Cpp2IlInjected.Address(RVA = "0xC9F860", Offset = "0xC9E660", VA = "0x180C9F860")]
			[CompilerGenerated]
			get
			{
				return default(MetricStorageTypes);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x85A7860", Offset = "0x85A6660", VA = "0x1885A7860")]
		public RawMetricPayload(long longValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x85A7850", Offset = "0x85A6650", VA = "0x1885A7850")]
		public RawMetricPayload(double doubleValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x85A7430", Offset = "0x85A6230", VA = "0x1885A7430", Slot = "4")]
		public bool Equals(RawMetricPayload other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x85A73A0", Offset = "0x85A61A0", VA = "0x1885A73A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x85A76C0", Offset = "0x85A64C0", VA = "0x1885A76C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x85A7730", Offset = "0x85A6530", VA = "0x1885A7730", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x85A7450", Offset = "0x85A6250", VA = "0x1885A7450")]
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
			[Cpp2IlInjected.Address(RVA = "0x85A5640", Offset = "0x85A4440", VA = "0x1885A5640")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x66E0C40", Offset = "0x66DFA40", VA = "0x1866E0C40")]
		public MetricDescription(MetricId metricId, MetricDataUnits dataUnit, [Optional] string customSuffix)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x85A5240", Offset = "0x85A4040", VA = "0x1885A5240")]
		public (bool, bool) CanUpdateWith(MetricDescription description)
		{
			return default((bool, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x85A5480", Offset = "0x85A4280", VA = "0x1885A5480", Slot = "4")]
		public bool Equals(MetricDescription other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x85A5380", Offset = "0x85A4180", VA = "0x1885A5380", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x85A5510", Offset = "0x85A4310", VA = "0x1885A5510", Slot = "2")]
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

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.Metrics.Pipeline.MetricInfo;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum ICAGIFAGNBN
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Undefined,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	TimeNanoseconds,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	SizeInBytes,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Count,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Percent,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	FrequencyHz
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum DHKNEMJCPAD : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Undefined,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Bytes8,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	Int,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	Float,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Long,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	Double
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class GCCOFOLJIJG
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6FA31C0", Offset = "0x6FA1DC0", VA = "0x186FA31C0")]
	public static (string, double) PNBHJDDCDII(double BJNBCLJDMLL, ICAGIFAGNBN PJAMEBFBGFJ, bool PFAGPHJGDAG = true)
	{
		return default((string, double));
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6FA2E90", Offset = "0x6FA1A90", VA = "0x186FA2E90")]
	private static (string, double) MANHDLEHKJH(double IOEJALBGJOD, bool PFAGPHJGDAG = true)
	{
		return default((string, double));
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6FA2FF0", Offset = "0x6FA1BF0", VA = "0x186FA2FF0")]
	private static (string, double) MEAMGEBFGHO(double ADGBKEJBJLE, bool PFAGPHJGDAG = true)
	{
		return default((string, double));
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6FA2D20", Offset = "0x6FA1920", VA = "0x186FA2D20")]
	private static (string, double) EGHEJJDKLBK(double EMPIDOFEHHE, bool PFAGPHJGDAG = true)
	{
		return default((string, double));
	}
}
namespace RecRoom.Metrics.Pipeline
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public readonly struct RawMetricPayload
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int Int
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x91F8E0", Offset = "0x91E4E0", VA = "0x18091F8E0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public float Float
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x2201490", Offset = "0x2200090", VA = "0x182201490")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public long Long
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x8638C0", Offset = "0x8624C0", VA = "0x1808638C0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public double Double
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x2905190", Offset = "0x2903D90", VA = "0x182905190")]
			[CompilerGenerated]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public DHKNEMJCPAD MetricStorageType
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xA7F8F0", Offset = "0xA7E4F0", VA = "0x180A7F8F0")]
			[CompilerGenerated]
			get
			{
				return default(DHKNEMJCPAD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6FA4830", Offset = "0x6FA3430", VA = "0x186FA4830")]
		public RawMetricPayload(int intValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6FA4820", Offset = "0x6FA3420", VA = "0x186FA4820")]
		public RawMetricPayload(double doubleValue)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class PayloadExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6FA4740", Offset = "0x6FA3340", VA = "0x186FA4740")]
		public static double ReadAsDouble(this RawMetricPayload rawMetricPayload)
		{
			return default(double);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public readonly struct RawMetric
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public readonly MetricId MetricId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly RawMetricPayload MetricPayload;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2904F20", Offset = "0x2903B20", VA = "0x182904F20")]
		public RawMetric(MetricId metricId, RawMetricPayload payload)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6FA48F0", Offset = "0x6FA34F0", VA = "0x186FA48F0")]
		public static RawMetric Integer(MetricId metricId, int value)
		{
			return default(RawMetric);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class RawMetricPipelineExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6FA4840", Offset = "0x6FA3440", VA = "0x186FA4840")]
		public static void PublishMetric(this IRawMetricsPipeline pipeline, RawMetric rawMetric)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface IMetricsPublisher<TMessage>
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool AddSubscriber(IMetricsSubscriber<TMessage> subscriber);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool RemoveSubscriber(IMetricsSubscriber<TMessage> subscriber);
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface IRawMetricsPipeline : IMetricsSubscriber<RawMetric>, IMetricsPublisher<RawMetric>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct MetricCollectionToken : IEquatable<MetricCollectionToken>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly string TokenName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public readonly object Token;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x91E4D0", Offset = "0x91D0D0", VA = "0x18091E4D0")]
		public MetricCollectionToken(string tokenName, object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6FA34E0", Offset = "0x6FA20E0", VA = "0x186FA34E0", Slot = "4")]
		public bool Equals(MetricCollectionToken other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6FA3500", Offset = "0x6FA2100", VA = "0x186FA3500", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6FA35A0", Offset = "0x6FA21A0", VA = "0x186FA35A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public readonly struct MetricId : IEquatable<MetricId>
	{
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public const ushort INVALID_IDX = 0;

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public static readonly MetricId Invalid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public readonly ushort SourceIdx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public readonly ushort MetricNameIdx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public readonly uint CombinedId;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x556A630", Offset = "0x5569230", VA = "0x18556A630")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2904DB0", Offset = "0x29039B0", VA = "0x182904DB0")]
		public MetricId(ushort sourceIdx, ushort metricNameIdx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1142F40", Offset = "0x1141B40", VA = "0x181142F40", Slot = "4")]
		public bool Equals(MetricId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6FA45B0", Offset = "0x6FA31B0", VA = "0x186FA45B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xB1B660", Offset = "0xB1A260", VA = "0x180B1B660", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x12E5B00", Offset = "0x12E4700", VA = "0x1812E5B00")]
		public static bool operator ==(MetricId left, MetricId right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1862D60", Offset = "0x1861960", VA = "0x181862D60")]
		public static bool operator !=(MetricId left, MetricId right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6FA4640", Offset = "0x6FA3240", VA = "0x186FA4640", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MetricIdLookup
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly List<string> metricSourceNames;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly Dictionary<string, ushort> stringMetricSourceToIdLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly Dictionary<ushort, (Dictionary<string, ushort> nameLookup, List<string> metricNames)> sourceToNameDictLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly Dictionary<MetricId, MetricDescription> metricDescriptions;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6FA4460", Offset = "0x6FA3060", VA = "0x186FA4460")]
		[Preserve]
		public MetricIdLookup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6FA3700", Offset = "0x6FA2300", VA = "0x186FA3700")]
		public MetricDescription CreateAndRegisterDescription(string metricSourceName, string metricName, ICAGIFAGNBN metricUnit = ICAGIFAGNBN.Undefined)
		{
			return default(MetricDescription);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6FA4200", Offset = "0x6FA2E00", VA = "0x186FA4200")]
		public void RegisterMetricDescription(MetricDescription metricDescription)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6FA3740", Offset = "0x6FA2340", VA = "0x186FA3740")]
		public MetricDescription GetMetricDescription(MetricId metricId)
		{
			return default(MetricDescription);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6FA3800", Offset = "0x6FA2400", VA = "0x186FA3800")]
		public MetricId GetMetricIdFromNames(string metricSourceName, string metricName)
		{
			return default(MetricId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6FA3E80", Offset = "0x6FA2A80", VA = "0x186FA3E80")]
		public MetricId GetOrRegisterMetricIdFromName(string metricSourceName, string metricName)
		{
			return default(MetricId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6FA3B10", Offset = "0x6FA2710", VA = "0x186FA3B10")]
		public void GetMetricNamesFromId(MetricId metricId, out string metricSourceName, out string metricName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6FA3D80", Offset = "0x6FA2980", VA = "0x186FA3D80")]
		public string GetMetricSourceName(ushort sourceIdx)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6FA3960", Offset = "0x6FA2560", VA = "0x186FA3960")]
		private void GetMetricNameInfos(ushort sourceId, out Dictionary<string, ushort> nameLookup, out List<string> namesList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6FA43F0", Offset = "0x6FA2FF0", VA = "0x186FA43F0")]
		private static bool TryGetMetricIdxFromString(string metricString, Dictionary<string, ushort> lookupTable, out ushort idx)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6FA4120", Offset = "0x6FA2D20", VA = "0x186FA4120")]
		private static ushort GetOrRegisterMetricIdxFromString(string metricString, Dictionary<string, ushort> lookupTable, List<string> stringsList)
		{
			return default(ushort);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface IMetricsSubscriber<TMessage>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void HandleMetric(in TMessage metricMessage);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface IMetricCollectionRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event MetricCollectionRequiredChanged OnMetricCollectionEnabledChanged;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void MarkRequiresMetricCollection(MetricCollectionToken token, MetricId metricId);

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void MarkDoesNotRequireMetricCollection(MetricCollectionToken token, MetricId metricId);

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool IsMetricCollectionRequired(MetricId metricId);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public delegate void MetricCollectionRequiredChanged(MetricId metricId, bool isMetricCollectionRequired);
}
namespace RecRoom.Metrics.Pipeline.MetricInfo
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public readonly struct MetricDescription : IEquatable<MetricDescription>
	{
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public static readonly MetricDescription Invalid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public readonly MetricId MetricId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public readonly ICAGIFAGNBN DataUnit;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x556A630", Offset = "0x5569230", VA = "0x18556A630")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6FA36F0", Offset = "0x6FA22F0", VA = "0x186FA36F0")]
		public MetricDescription(MetricId metricId, ICAGIFAGNBN dataUnit)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6B83F50", Offset = "0x6B82B50", VA = "0x186B83F50", Slot = "4")]
		public bool Equals(MetricDescription other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6FA35D0", Offset = "0x6FA21D0", VA = "0x186FA35D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x319EB40", Offset = "0x319D740", VA = "0x18319EB40", Slot = "2")]
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

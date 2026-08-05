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
public enum KEIBIMFIAIP
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
public enum PIOAKINKCCF : byte
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
public static class GCMJJPIAEFL
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6EBD000", Offset = "0x6EBB800", VA = "0x186EBD000")]
	public static (string, double) NDKNFBIONGF(double GPAHIBKJJLF, KEIBIMFIAIP ILKMNCNGDMD, bool OLMCOILALJK = true)
	{
		return default((string, double));
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6EBCEA0", Offset = "0x6EBB6A0", VA = "0x186EBCEA0")]
	private static (string, double) KGAAAAIILDD(double MEEGHIFANJG, bool OLMCOILALJK = true)
	{
		return default((string, double));
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6EBCCD0", Offset = "0x6EBB4D0", VA = "0x186EBCCD0")]
	private static (string, double) IHOIDAGBFOM(double AKKECEEHIPP, bool OLMCOILALJK = true)
	{
		return default((string, double));
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6EBCB60", Offset = "0x6EBB360", VA = "0x186EBCB60")]
	private static (string, double) GJFNAACALNA(double BCDFHNPDPEH, bool OLMCOILALJK = true)
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
			[Cpp2IlInjected.Address(RVA = "0xB1A680", Offset = "0xB18E80", VA = "0x180B1A680")]
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
			[Cpp2IlInjected.Address(RVA = "0x24CBAD0", Offset = "0x24CA2D0", VA = "0x1824CBAD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x7DF100", Offset = "0x7DD900", VA = "0x1807DF100")]
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
			[Cpp2IlInjected.Address(RVA = "0x1AB0830", Offset = "0x1AAF030", VA = "0x181AB0830")]
			[CompilerGenerated]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public PIOAKINKCCF MetricStorageType
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xE12560", Offset = "0xE10D60", VA = "0x180E12560")]
			[CompilerGenerated]
			get
			{
				return default(PIOAKINKCCF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6EBE660", Offset = "0x6EBCE60", VA = "0x186EBE660")]
		public RawMetricPayload(int intValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6EBE650", Offset = "0x6EBCE50", VA = "0x186EBE650")]
		public RawMetricPayload(double doubleValue)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class PayloadExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6EBE570", Offset = "0x6EBCD70", VA = "0x186EBE570")]
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
		[Cpp2IlInjected.Address(RVA = "0x1AB0470", Offset = "0x1AAEC70", VA = "0x181AB0470")]
		public RawMetric(MetricId metricId, RawMetricPayload payload)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6EBE720", Offset = "0x6EBCF20", VA = "0x186EBE720")]
		public static RawMetric Integer(MetricId metricId, int value)
		{
			return default(RawMetric);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class RawMetricPipelineExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6EBE670", Offset = "0x6EBCE70", VA = "0x186EBE670")]
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
		[Cpp2IlInjected.Address(RVA = "0xB84550", Offset = "0xB82D50", VA = "0x180B84550")]
		public MetricCollectionToken(string tokenName, object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6EBD320", Offset = "0x6EBBB20", VA = "0x186EBD320", Slot = "4")]
		public bool Equals(MetricCollectionToken other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6EBD340", Offset = "0x6EBBB40", VA = "0x186EBD340", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6EBD3D0", Offset = "0x6EBBBD0", VA = "0x186EBD3D0", Slot = "2")]
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
			[Cpp2IlInjected.Address(RVA = "0x524B250", Offset = "0x5249A50", VA = "0x18524B250")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1AAFFA0", Offset = "0x1AAE7A0", VA = "0x181AAFFA0")]
		public MetricId(ushort sourceIdx, ushort metricNameIdx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xDA2870", Offset = "0xDA1070", VA = "0x180DA2870", Slot = "4")]
		public bool Equals(MetricId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6EBE3E0", Offset = "0x6EBCBE0", VA = "0x186EBE3E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2E56D10", Offset = "0x2E55510", VA = "0x182E56D10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xE4EAB0", Offset = "0xE4D2B0", VA = "0x180E4EAB0")]
		public static bool operator ==(MetricId left, MetricId right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x31EED50", Offset = "0x31ED550", VA = "0x1831EED50")]
		public static bool operator !=(MetricId left, MetricId right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6EBE470", Offset = "0x6EBCC70", VA = "0x186EBE470", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x6EBE290", Offset = "0x6EBCA90", VA = "0x186EBE290")]
		[Preserve]
		public MetricIdLookup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6EBD530", Offset = "0x6EBBD30", VA = "0x186EBD530")]
		public MetricDescription CreateAndRegisterDescription(string metricSourceName, string metricName, KEIBIMFIAIP metricUnit = KEIBIMFIAIP.Undefined)
		{
			return default(MetricDescription);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6EBE020", Offset = "0x6EBC820", VA = "0x186EBE020")]
		public void RegisterMetricDescription(MetricDescription metricDescription)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6EBD570", Offset = "0x6EBBD70", VA = "0x186EBD570")]
		public MetricDescription GetMetricDescription(MetricId metricId)
		{
			return default(MetricDescription);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6EBD630", Offset = "0x6EBBE30", VA = "0x186EBD630")]
		public MetricId GetMetricIdFromNames(string metricSourceName, string metricName)
		{
			return default(MetricId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6EBDCA0", Offset = "0x6EBC4A0", VA = "0x186EBDCA0")]
		public MetricId GetOrRegisterMetricIdFromName(string metricSourceName, string metricName)
		{
			return default(MetricId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6EBD930", Offset = "0x6EBC130", VA = "0x186EBD930")]
		public void GetMetricNamesFromId(MetricId metricId, out string metricSourceName, out string metricName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6EBDBA0", Offset = "0x6EBC3A0", VA = "0x186EBDBA0")]
		public string GetMetricSourceName(ushort sourceIdx)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6EBD780", Offset = "0x6EBBF80", VA = "0x186EBD780")]
		private void GetMetricNameInfos(ushort sourceId, out Dictionary<string, ushort> nameLookup, out List<string> namesList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6EBE220", Offset = "0x6EBCA20", VA = "0x186EBE220")]
		private static bool TryGetMetricIdxFromString(string metricString, Dictionary<string, ushort> lookupTable, out ushort idx)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6EBDF40", Offset = "0x6EBC740", VA = "0x186EBDF40")]
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
		public readonly KEIBIMFIAIP DataUnit;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x524B250", Offset = "0x5249A50", VA = "0x18524B250")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6EBD520", Offset = "0x6EBBD20", VA = "0x186EBD520")]
		public MetricDescription(MetricId metricId, KEIBIMFIAIP dataUnit)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x45BBF50", Offset = "0x45BA750", VA = "0x1845BBF50", Slot = "4")]
		public bool Equals(MetricDescription other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6EBD400", Offset = "0x6EBBC00", VA = "0x186EBD400", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x2DF1FD0", Offset = "0x2DF07D0", VA = "0x182DF1FD0", Slot = "2")]
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

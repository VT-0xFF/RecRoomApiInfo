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
public enum GENEAJCPCML
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
public enum HCKJGJLIEKN : byte
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
public static class GIBAMAGEOGP
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x16BEF50", Offset = "0x16BE350", VA = "0x1816BEF50")]
	public static (string, double) OFFOIHJDCMM(double IGCABNKPMLE, GENEAJCPCML DCCNONIEGMO, bool DKPMBNHFKBO = true)
	{
		return default((string, double));
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x16BEAB0", Offset = "0x16BDEB0", VA = "0x1816BEAB0")]
	private static (string, double) AGCEBJDKFOE(double GIPCJKIFAJE, bool DKPMBNHFKBO = true)
	{
		return default((string, double));
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x16BED80", Offset = "0x16BE180", VA = "0x1816BED80")]
	private static (string, double) MFIHHPBOACL(double BGIFMOKKJBK, bool DKPMBNHFKBO = true)
	{
		return default((string, double));
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x16BEC10", Offset = "0x16BE010", VA = "0x1816BEC10")]
	private static (string, double) CNBDKBFCDBC(double PCFFLKHIHDN, bool DKPMBNHFKBO = true)
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
			[Cpp2IlInjected.Address(RVA = "0x9A0690", Offset = "0x99FA90", VA = "0x1809A0690")]
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
			[Cpp2IlInjected.Address(RVA = "0x16C0970", Offset = "0x16BFD70", VA = "0x1816C0970")]
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
			[Cpp2IlInjected.Address(RVA = "0x854A20", Offset = "0x853E20", VA = "0x180854A20")]
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
			[Cpp2IlInjected.Address(RVA = "0x16C0960", Offset = "0x16BFD60", VA = "0x1816C0960")]
			[CompilerGenerated]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public HCKJGJLIEKN MetricStorageType
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xB7FC30", Offset = "0xB7F030", VA = "0x180B7FC30")]
			[CompilerGenerated]
			get
			{
				return default(HCKJGJLIEKN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x16C0950", Offset = "0x16BFD50", VA = "0x1816C0950")]
		public RawMetricPayload(int intValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x16C0940", Offset = "0x16BFD40", VA = "0x1816C0940")]
		public RawMetricPayload(double doubleValue)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class PayloadExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x16C0860", Offset = "0x16BFC60", VA = "0x1816C0860")]
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
		[Cpp2IlInjected.Address(RVA = "0x16C0A60", Offset = "0x16BFE60", VA = "0x1816C0A60")]
		public RawMetric(MetricId metricId, RawMetricPayload payload)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x16C0A30", Offset = "0x16BFE30", VA = "0x1816C0A30")]
		public static RawMetric Integer(MetricId metricId, int value)
		{
			return default(RawMetric);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class RawMetricPipelineExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x16C0980", Offset = "0x16BFD80", VA = "0x1816C0980")]
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
		[Cpp2IlInjected.Address(RVA = "0xA1F0E0", Offset = "0xA1E4E0", VA = "0x180A1F0E0")]
		public MetricCollectionToken(string tokenName, object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x16BF580", Offset = "0x16BE980", VA = "0x1816BF580", Slot = "4")]
		public bool Equals(MetricCollectionToken other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x16BF5A0", Offset = "0x16BE9A0", VA = "0x1816BF5A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x16BF640", Offset = "0x16BEA40", VA = "0x1816BF640", Slot = "2")]
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
			[Cpp2IlInjected.Address(RVA = "0x16BF7D0", Offset = "0x16BEBD0", VA = "0x1816BF7D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x16C0830", Offset = "0x16BFC30", VA = "0x1816C0830")]
		public MetricId(ushort sourceIdx, ushort metricNameIdx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x16C0720", Offset = "0x16BFB20", VA = "0x1816C0720", Slot = "4")]
		public bool Equals(MetricId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x16C0690", Offset = "0x16BFA90", VA = "0x1816C0690", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xC8ACF0", Offset = "0xC8A0F0", VA = "0x180C8ACF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x16C0840", Offset = "0x16BFC40", VA = "0x1816C0840")]
		public static bool operator ==(MetricId left, MetricId right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x16C0850", Offset = "0x16BFC50", VA = "0x1816C0850")]
		public static bool operator !=(MetricId left, MetricId right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x16C0730", Offset = "0x16BFB30", VA = "0x1816C0730", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x16C0540", Offset = "0x16BF940", VA = "0x1816C0540")]
		[Preserve]
		public MetricIdLookup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x16BF7E0", Offset = "0x16BEBE0", VA = "0x1816BF7E0")]
		public MetricDescription CreateAndRegisterDescription(string metricSourceName, string metricName, GENEAJCPCML metricUnit = GENEAJCPCML.Undefined)
		{
			return default(MetricDescription);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x16C02E0", Offset = "0x16BF6E0", VA = "0x1816C02E0")]
		public void RegisterMetricDescription(MetricDescription metricDescription)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x16BF820", Offset = "0x16BEC20", VA = "0x1816BF820")]
		public MetricDescription GetMetricDescription(MetricId metricId)
		{
			return default(MetricDescription);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x16BF8E0", Offset = "0x16BECE0", VA = "0x1816BF8E0")]
		public MetricId GetMetricIdFromNames(string metricSourceName, string metricName)
		{
			return default(MetricId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x16BFF60", Offset = "0x16BF360", VA = "0x1816BFF60")]
		public MetricId GetOrRegisterMetricIdFromName(string metricSourceName, string metricName)
		{
			return default(MetricId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x16BFBF0", Offset = "0x16BEFF0", VA = "0x1816BFBF0")]
		public void GetMetricNamesFromId(MetricId metricId, out string metricSourceName, out string metricName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x16BFE60", Offset = "0x16BF260", VA = "0x1816BFE60")]
		public string GetMetricSourceName(ushort sourceIdx)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x16BFA40", Offset = "0x16BEE40", VA = "0x1816BFA40")]
		private void GetMetricNameInfos(ushort sourceId, out Dictionary<string, ushort> nameLookup, out List<string> namesList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x16C04D0", Offset = "0x16BF8D0", VA = "0x1816C04D0")]
		private static bool TryGetMetricIdxFromString(string metricString, Dictionary<string, ushort> lookupTable, out ushort idx)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x16C0200", Offset = "0x16BF600", VA = "0x1816C0200")]
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
		public readonly GENEAJCPCML DataUnit;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x16BF7D0", Offset = "0x16BEBD0", VA = "0x1816BF7D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x16BF7C0", Offset = "0x16BEBC0", VA = "0x1816BF7C0")]
		public MetricDescription(MetricId metricId, GENEAJCPCML dataUnit)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x16BF670", Offset = "0x16BEA70", VA = "0x1816BF670", Slot = "4")]
		public bool Equals(MetricDescription other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x16BF690", Offset = "0x16BEA90", VA = "0x1816BF690", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x16BF720", Offset = "0x16BEB20", VA = "0x1816BF720", Slot = "2")]
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

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
public enum JODMMMNPKLK
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
public enum OHIDMCELIKK : byte
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
public static class LCBOLMGCKNM
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6ABB360", Offset = "0x6AB9D60", VA = "0x186ABB360")]
	public static (string, double) FHEEDNECMIN(double EMHPFMJEEEK, JODMMMNPKLK JKFNMEKOPJJ, bool JDELBDCPPEL = true)
	{
		return default((string, double));
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6ABB220", Offset = "0x6AB9C20", VA = "0x186ABB220")]
	private static (string, double) EIKFKMPKEMA(double KCDFBPNPIHF, bool JDELBDCPPEL = true)
	{
		return default((string, double));
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6ABB6B0", Offset = "0x6ABA0B0", VA = "0x186ABB6B0")]
	private static (string, double) IJFCHAMGHCD(double LGOIODHIFLG, bool JDELBDCPPEL = true)
	{
		return default((string, double));
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6ABB850", Offset = "0x6ABA250", VA = "0x186ABB850")]
	private static (string, double) NBGPBGHCHFG(double IBPPKILFFEB, bool JDELBDCPPEL = true)
	{
		return default((string, double));
	}
}
namespace RecRoom.Metrics.Pipeline
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface IMetricCollectionRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event MetricCollectionRequiredChanged OnMetricCollectionEnabledChanged;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void MarkRequiresMetricCollection(MetricCollectionToken token, MetricId metricId);

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void MarkDoesNotRequireMetricCollection(MetricCollectionToken token, MetricId metricId);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool IsMetricCollectionRequired(MetricId metricId);
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public delegate void MetricCollectionRequiredChanged(MetricId metricId, bool isMetricCollectionRequired);
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public readonly struct MetricCollectionToken : IEquatable<MetricCollectionToken>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public readonly string TokenName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public readonly object Token;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xC33810", Offset = "0xC32210", VA = "0x180C33810")]
		public MetricCollectionToken(string tokenName, object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6ABBA40", Offset = "0x6ABA440", VA = "0x186ABBA40", Slot = "4")]
		public bool Equals(MetricCollectionToken other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6ABBA60", Offset = "0x6ABA460", VA = "0x186ABBA60", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xC78620", Offset = "0xC77020", VA = "0x180C78620", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class PayloadExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6ABCC60", Offset = "0x6ABB660", VA = "0x186ABCC60")]
		public static double ReadAsDouble(this RawMetricPayload rawMetricPayload)
		{
			return default(double);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class RawMetricPipelineExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6ABCD60", Offset = "0x6ABB760", VA = "0x186ABCD60")]
		public static void PublishMetric(this IRawMetricsPipeline pipeline, RawMetric rawMetric)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface IMetricsPublisher<TMessage>
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool AddSubscriber(IMetricsSubscriber<TMessage> subscriber);

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool RemoveSubscriber(IMetricsSubscriber<TMessage> subscriber);
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface IMetricsSubscriber<TMessage>
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void HandleMetric(in TMessage metricMessage);
	}
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public readonly struct MetricId : IEquatable<MetricId>
	{
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public const ushort INVALID_IDX = 0;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly MetricId Invalid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly ushort SourceIdx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly ushort MetricNameIdx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public readonly uint CombinedId;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x986370", Offset = "0x984D70", VA = "0x180986370")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x29FFF40", Offset = "0x29FE940", VA = "0x1829FFF40")]
		public MetricId(ushort sourceIdx, ushort metricNameIdx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x95B480", Offset = "0x959E80", VA = "0x18095B480", Slot = "4")]
		public bool Equals(MetricId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6ABCAE0", Offset = "0x6ABB4E0", VA = "0x186ABCAE0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x865120", Offset = "0x863B20", VA = "0x180865120", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x95B8C0", Offset = "0x95A2C0", VA = "0x18095B8C0")]
		public static bool operator ==(MetricId left, MetricId right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x95B8D0", Offset = "0x95A2D0", VA = "0x18095B8D0")]
		public static bool operator !=(MetricId left, MetricId right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6ABCB60", Offset = "0x6ABB560", VA = "0x186ABCB60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MetricIdLookup
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly List<string> metricSourceNames;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly Dictionary<string, ushort> stringMetricSourceToIdLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly Dictionary<ushort, (Dictionary<string, ushort> nameLookup, List<string> metricNames)> sourceToNameDictLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly Dictionary<MetricId, MetricDescription> metricDescriptions;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6ABC990", Offset = "0x6ABB390", VA = "0x186ABC990")]
		[Preserve]
		public MetricIdLookup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6ABBC30", Offset = "0x6ABA630", VA = "0x186ABBC30")]
		public MetricDescription CreateAndRegisterDescription(string metricSourceName, string metricName, JODMMMNPKLK metricUnit = JODMMMNPKLK.Undefined)
		{
			return default(MetricDescription);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6ABC730", Offset = "0x6ABB130", VA = "0x186ABC730")]
		public void RegisterMetricDescription(MetricDescription metricDescription)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6ABBC70", Offset = "0x6ABA670", VA = "0x186ABBC70")]
		public MetricDescription GetMetricDescription(MetricId metricId)
		{
			return default(MetricDescription);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6ABBD30", Offset = "0x6ABA730", VA = "0x186ABBD30")]
		public MetricId GetMetricIdFromNames(string metricSourceName, string metricName)
		{
			return default(MetricId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6ABC3B0", Offset = "0x6ABADB0", VA = "0x186ABC3B0")]
		public MetricId GetOrRegisterMetricIdFromName(string metricSourceName, string metricName)
		{
			return default(MetricId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6ABC040", Offset = "0x6ABAA40", VA = "0x186ABC040")]
		public void GetMetricNamesFromId(MetricId metricId, out string metricSourceName, out string metricName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6ABC2B0", Offset = "0x6ABACB0", VA = "0x186ABC2B0")]
		public string GetMetricSourceName(ushort sourceIdx)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6ABBE90", Offset = "0x6ABA890", VA = "0x186ABBE90")]
		private void GetMetricNameInfos(ushort sourceId, out Dictionary<string, ushort> nameLookup, out List<string> namesList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6ABC920", Offset = "0x6ABB320", VA = "0x186ABC920")]
		private static bool TryGetMetricIdxFromString(string metricString, Dictionary<string, ushort> lookupTable, out ushort idx)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6ABC650", Offset = "0x6ABB050", VA = "0x186ABC650")]
		private static ushort GetOrRegisterMetricIdxFromString(string metricString, Dictionary<string, ushort> lookupTable, List<string> stringsList)
		{
			return default(ushort);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct RawMetric
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public readonly MetricId MetricId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly RawMetricPayload MetricPayload;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x34EB8A0", Offset = "0x34EA2A0", VA = "0x1834EB8A0")]
		public RawMetric(MetricId metricId, RawMetricPayload payload)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6ABCE10", Offset = "0x6ABB810", VA = "0x186ABCE10")]
		public static RawMetric Integer(MetricId metricId, int value)
		{
			return default(RawMetric);
		}
	}
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public readonly struct RawMetricPayload
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int Int
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x865120", Offset = "0x863B20", VA = "0x180865120")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public float Float
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x855290", Offset = "0x853C90", VA = "0x180855290")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public long Long
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x875BB0", Offset = "0x8745B0", VA = "0x180875BB0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public double Double
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x1BE9950", Offset = "0x1BE8350", VA = "0x181BE9950")]
			[CompilerGenerated]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public OHIDMCELIKK MetricStorageType
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xB75130", Offset = "0xB73B30", VA = "0x180B75130")]
			[CompilerGenerated]
			get
			{
				return default(OHIDMCELIKK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6ABCD50", Offset = "0x6ABB750", VA = "0x186ABCD50")]
		public RawMetricPayload(int intValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6ABCD40", Offset = "0x6ABB740", VA = "0x186ABCD40")]
		public RawMetricPayload(double doubleValue)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface IRawMetricsPipeline : IMetricsSubscriber<RawMetric>, IMetricsPublisher<RawMetric>
	{
	}
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
		public readonly JODMMMNPKLK DataUnit;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x986370", Offset = "0x984D70", VA = "0x180986370")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6ABBC20", Offset = "0x6ABA620", VA = "0x186ABBC20")]
		public MetricDescription(MetricId metricId, JODMMMNPKLK dataUnit)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8622F0", Offset = "0x860CF0", VA = "0x1808622F0", Slot = "4")]
		public bool Equals(MetricDescription other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6ABBB00", Offset = "0x6ABA500", VA = "0x186ABBB00", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x862310", Offset = "0x860D10", VA = "0x180862310", Slot = "2")]
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

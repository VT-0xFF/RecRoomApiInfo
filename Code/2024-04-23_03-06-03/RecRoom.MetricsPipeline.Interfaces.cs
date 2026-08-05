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
public enum FAPJNAKFIKP
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
public enum NBAFBAFHJDK : byte
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
public static class FPIFKJHBPCA
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x63049B0", Offset = "0x63039B0", VA = "0x1863049B0")]
	public static (string, double) KPNAPLEKLND(double PLEIDJECPFB, FAPJNAKFIKP LCBKIHPGBNF, bool JHANHNCHBEO = true)
	{
		return default((string, double));
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6304870", Offset = "0x6303870", VA = "0x186304870")]
	private static (string, double) JOGPGGGPNMH(double GAGOFPIGAGM, bool JHANHNCHBEO = true)
	{
		return default((string, double));
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x63046D0", Offset = "0x63036D0", VA = "0x1863046D0")]
	private static (string, double) FHLKKADGJDN(double BCBCLMGBHDA, bool JHANHNCHBEO = true)
	{
		return default((string, double));
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6304D00", Offset = "0x6303D00", VA = "0x186304D00")]
	private static (string, double) OIJNMEMODHA(double FAMJAMPCNAD, bool JHANHNCHBEO = true)
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

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x948150", Offset = "0x947150", VA = "0x180948150")]
		public MetricCollectionToken(string tokenName, object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6304F40", Offset = "0x6303F40", VA = "0x186304F40", Slot = "4")]
		public bool Equals(MetricCollectionToken other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6304F50", Offset = "0x6303F50", VA = "0x186304F50", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6304FE0", Offset = "0x6303FE0", VA = "0x186304FE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class PayloadExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6306490", Offset = "0x6305490", VA = "0x186306490")]
		public static double ReadAsDouble(this RawMetricPayload rawMetricPayload)
		{
			return default(double);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class RawMetricPipelineExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x63065A0", Offset = "0x63055A0", VA = "0x1863065A0")]
		public static void PublishMetric(this IRawMetricsPipeline pipeline, RawMetric rawMetric)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface IMetricsPublisher<TMessage>
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool AddSubscriber(IMetricsSubscriber<TMessage> subscriber);

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool RemoveSubscriber(IMetricsSubscriber<TMessage> subscriber);
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface IMetricsSubscriber<TMessage>
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void HandleMetric([In] TMessage metricMessage);
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
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x63063E0", Offset = "0x63053E0", VA = "0x1863063E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3E12790", Offset = "0x3E11790", VA = "0x183E12790")]
		public MetricId(ushort sourceIdx, ushort metricNameIdx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x895C90", Offset = "0x894C90", VA = "0x180895C90", Slot = "4")]
		public bool Equals(MetricId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6306240", Offset = "0x6305240", VA = "0x186306240", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9151A0", Offset = "0x9141A0", VA = "0x1809151A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x63063F0", Offset = "0x63053F0", VA = "0x1863063F0")]
		public static bool operator ==(MetricId left, MetricId right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6306440", Offset = "0x6305440", VA = "0x186306440")]
		public static bool operator !=(MetricId left, MetricId right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x63062E0", Offset = "0x63052E0", VA = "0x1863062E0", Slot = "3")]
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

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x63060D0", Offset = "0x63050D0", VA = "0x1863060D0")]
		[Preserve]
		public MetricIdLookup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6305250", Offset = "0x6304250", VA = "0x186305250")]
		public MetricDescription CreateAndRegisterDescription(string metricSourceName, string metricName, FAPJNAKFIKP metricUnit = FAPJNAKFIKP.Undefined)
		{
			return default(MetricDescription);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6305DE0", Offset = "0x6304DE0", VA = "0x186305DE0")]
		public void RegisterMetricDescription(MetricDescription metricDescription)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x63052F0", Offset = "0x63042F0", VA = "0x1863052F0")]
		public MetricDescription GetMetricDescription(MetricId metricId)
		{
			return default(MetricDescription);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x63053C0", Offset = "0x63043C0", VA = "0x1863053C0")]
		public MetricId GetMetricIdFromNames(string metricSourceName, string metricName)
		{
			return default(MetricId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6305A50", Offset = "0x6304A50", VA = "0x186305A50")]
		public MetricId GetOrRegisterMetricIdFromName(string metricSourceName, string metricName)
		{
			return default(MetricId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x63056D0", Offset = "0x63046D0", VA = "0x1863056D0")]
		public void GetMetricNamesFromId(MetricId metricId, [Out] string metricSourceName, [Out] string metricName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6305950", Offset = "0x6304950", VA = "0x186305950")]
		public string GetMetricSourceName(ushort sourceIdx)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6305510", Offset = "0x6304510", VA = "0x186305510")]
		private void GetMetricNameInfos(ushort sourceId, [Out] Dictionary<string, ushort> nameLookup, [Out] List<string> namesList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6306060", Offset = "0x6305060", VA = "0x186306060")]
		private static bool TryGetMetricIdxFromString(string metricString, Dictionary<string, ushort> lookupTable, [Out] ushort idx)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6305D00", Offset = "0x6304D00", VA = "0x186305D00")]
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

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3E12530", Offset = "0x3E11530", VA = "0x183E12530")]
		public RawMetric(MetricId metricId, RawMetricPayload payload)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6306650", Offset = "0x6305650", VA = "0x186306650")]
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
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x9151A0", Offset = "0x9141A0", VA = "0x1809151A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public float Float
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x1FD4BF0", Offset = "0x1FD3BF0", VA = "0x181FD4BF0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public long Long
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x890FA0", Offset = "0x88FFA0", VA = "0x180890FA0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public double Double
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x2EACC90", Offset = "0x2EABC90", VA = "0x182EACC90")]
			[CompilerGenerated]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public NBAFBAFHJDK MetricStorageType
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x19E7F70", Offset = "0x19E6F70", VA = "0x1819E7F70")]
			[CompilerGenerated]
			get
			{
				return default(NBAFBAFHJDK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6306590", Offset = "0x6305590", VA = "0x186306590")]
		public RawMetricPayload(int intValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6306580", Offset = "0x6305580", VA = "0x186306580")]
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
		public readonly FAPJNAKFIKP DataUnit;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x6305200", Offset = "0x6304200", VA = "0x186305200")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x44D3C80", Offset = "0x44D2C80", VA = "0x1844D3C80")]
		public MetricDescription(MetricId metricId, FAPJNAKFIKP dataUnit)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x63050C0", Offset = "0x63040C0", VA = "0x1863050C0", Slot = "4")]
		public bool Equals(MetricDescription other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6305010", Offset = "0x6304010", VA = "0x186305010", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6305130", Offset = "0x6304130", VA = "0x186305130", Slot = "2")]
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

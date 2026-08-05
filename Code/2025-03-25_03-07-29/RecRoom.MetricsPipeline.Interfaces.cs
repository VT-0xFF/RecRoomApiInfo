using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.Logging.Attributes;
using RecRoom.Metrics.Pipeline.MetricInfo;
using RecRoom.NoEngine.Common;
using RecRoom.NoEngine.DataStructures;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_MetricsPipeline_Interfaces
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : PNJEOLJBAIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7885D30", Offset = "0x7885130", VA = "0x187885D30", Slot = "4")]
		public override void ELBDPICAHPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum JKIMKAHPIOO
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Normal = 0,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Caution = -1,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Critical = -2
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface PLKAKLALAMH
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public delegate JKIMKAHPIOO JMIHNOPEBHO(double FIIKLGCIAGG);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	double LMAHCJNGHJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	double NKCOMBBMFCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	JMIHNOPEBHO GBBIKPEMIFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	RRColor32 FKFCIHNMGCF(JKIMKAHPIOO KGODHHBLJOE);
}
namespace RecRoom.Metrics.Pipeline
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface IMetricCollectionRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event MetricCollectionRequiredChanged OnMetricCollectionEnabledChanged;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void MarkRequiresMetricCollection(MetricCollectionToken token, MetricId metricId);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void MarkDoesNotRequireMetricCollection(MetricCollectionToken token, MetricId metricId);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool IsMetricCollectionRequired(MetricId metricId);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public delegate void MetricCollectionRequiredChanged(MetricId metricId, bool isMetricCollectionRequired);
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct MetricCollectionToken : IEquatable<MetricCollectionToken>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string TokenName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly object Token;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9F9CA0", Offset = "0x9F90A0", VA = "0x1809F9CA0")]
		public MetricCollectionToken(string tokenName, object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7885EB0", Offset = "0x78852B0", VA = "0x187885EB0", Slot = "4")]
		public bool Equals(MetricCollectionToken other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7885EC0", Offset = "0x78852C0", VA = "0x187885EC0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7885F50", Offset = "0x7885350", VA = "0x187885F50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7885F80", Offset = "0x7885380", VA = "0x187885F80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class PayloadExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x78881B0", Offset = "0x78875B0", VA = "0x1878881B0")]
		public static double ReadAsDouble(this RawMetricPayload rawMetricPayload)
		{
			return default(double);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public static class RawMetricPipelineExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x78887B0", Offset = "0x7887BB0", VA = "0x1878887B0")]
		public static void PublishMetric(this IRawMetricsPipeline pipeline, RawMetric rawMetric)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface IMetricsPublisher<TMessage>
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool AddSubscriber(IMetricsSubscriber<TMessage> subscriber);

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool RemoveSubscriber(IMetricsSubscriber<TMessage> subscriber);
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface IMetricsSubscriber<TMessage>
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void HandleMetric([In] TMessage metricMessage);
	}
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public readonly struct MetricId : IEquatable<MetricId>
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public class MetricComparer : IEqualityComparer<MetricId>
		{
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public static readonly MetricComparer Instance;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x7885FC0", Offset = "0x78853C0", VA = "0x187885FC0", Slot = "4")]
			public bool Equals(MetricId x, MetricId y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x7886010", Offset = "0x7885410", VA = "0x187886010", Slot = "5")]
			public int GetHashCode(MetricId obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public MetricComparer()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public const ushort INVALID_IDX = 0;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public static readonly MetricId Invalid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public readonly ushort SourceIdx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly ushort MetricNameIdx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly uint CombinedId;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x78255F0", Offset = "0x78249F0", VA = "0x1878255F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x4D46C70", Offset = "0x4D46070", VA = "0x184D46C70")]
		public MetricId(ushort sourceIdx, ushort metricNameIdx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1FF4240", Offset = "0x1FF3640", VA = "0x181FF4240", Slot = "4")]
		public bool Equals(MetricId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7887340", Offset = "0x7886740", VA = "0x187887340", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9DD8E0", Offset = "0x9DCCE0", VA = "0x1809DD8E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x78874E0", Offset = "0x78868E0", VA = "0x1878874E0")]
		public static bool operator ==(MetricId left, MetricId right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7887530", Offset = "0x7886930", VA = "0x187887530")]
		public static bool operator !=(MetricId left, MetricId right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x78873E0", Offset = "0x78867E0", VA = "0x1878873E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MetricIdLookup
	{
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static readonly ABDDJEPKCOD Logger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly MetricIdxRegistry sourceIdxRegistry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly Dictionary<ushort, MetricIdxRegistry> sourceNameIdxRegistries;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly List<MetricId> metricIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly Dictionary<MetricId, MetricDescription> metricDescriptions;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x78871E0", Offset = "0x78865E0", VA = "0x1878871E0")]
		[RecRoom.NoEngine.Common.Preserve]
		public MetricIdLookup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7886540", Offset = "0x7885940", VA = "0x187886540")]
		public MetricId AddOrGetMetricId(string metricSourceName, string metricName)
		{
			return default(MetricId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7886670", Offset = "0x7885A70", VA = "0x187886670")]
		public MetricId GetMetricId(string metricSourceName, string metricName)
		{
			return default(MetricId);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7886FC0", Offset = "0x78863C0", VA = "0x187886FC0")]
		public MetricDescription RegisterOrGetMetricDescription(string metricSourceName, string metricName, MetricDataUnits metricUnit, [Optional] string customSuffix)
		{
			return default(MetricDescription);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x78865B0", Offset = "0x78859B0", VA = "0x1878865B0")]
		public MetricDescription GetMetricDescription(MetricId metricId)
		{
			return default(MetricDescription);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x78870B0", Offset = "0x78864B0", VA = "0x1878870B0")]
		public bool TryGetMetricNames(MetricId metricId, [Out] string metricSourceName, [Out] string metricName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x78867D0", Offset = "0x7885BD0", VA = "0x1878867D0")]
		private (MetricId, bool, bool) Internal_AddOrGetMetricIdForNames(string metricSourceName, string metricName)
		{
			return default((MetricId, bool, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7886DB0", Offset = "0x78861B0", VA = "0x187886DB0")]
		private (MetricDescription, bool) Internal_RegisterOrGetMetricDescription(MetricId metricId, MetricDataUnits metricUnit, string customSuffix)
		{
			return default((MetricDescription, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7886980", Offset = "0x7885D80", VA = "0x187886980")]
		private void Internal_LogAddMetric(string metricSourceName, string metricName, MetricId metricId, bool addedSource, bool addedName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7886AC0", Offset = "0x7885EC0", VA = "0x187886AC0")]
		private void Internal_LogRegisterDescription(MetricDescription description, bool addedDescription)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal class MetricIdxRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private const ushort INVALID_IDX = 0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly List<string> names;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly Dictionary<string, ushort> nameIdxLookup;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x78877C0", Offset = "0x7886BC0", VA = "0x1878877C0")]
		public bool TryGetNameIdx(string name, [Out] ushort idx)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7887670", Offset = "0x7886A70", VA = "0x187887670")]
		internal ushort RegisterNameIdx(string name)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7887580", Offset = "0x7886980", VA = "0x187887580")]
		public (ushort, bool) AddOrGetNameId(string name)
		{
			return default((ushort, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7887710", Offset = "0x7886B10", VA = "0x187887710")]
		public bool TryGetIdxName(ushort idx, [Out] string name)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1F97580", Offset = "0x1F96980", VA = "0x181F97580")]
		internal static ushort InternalToIndex(int index)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7887660", Offset = "0x7886A60", VA = "0x187887660")]
		internal static int IndexToInternal(ushort id)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7887830", Offset = "0x7886C30", VA = "0x187887830")]
		public MetricIdxRegistry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public enum MetricDataUnits : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		Undefined,
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		Number,
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		Count,
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		TimeNanoseconds,
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		SizeInBytes,
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		Percent,
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		FrequencyHz
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum MetricStorageTypes : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		Undefined,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		Bytes8,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		Int,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		Float,
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		Long,
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		Double
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class MetricUnitFormatter
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7887CA0", Offset = "0x78870A0", VA = "0x187887CA0")]
		public static (string, double) PrettyFormatSampleValue(double sampleValue, MetricDataUnits sampleUnit, bool abbreviate = true)
		{
			return default((string, double));
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7887D40", Offset = "0x7887140", VA = "0x187887D40")]
		public static (string, double) PrettyFormatSample(double sampleValue, MetricDataUnits sampleUnit, bool abbreviate = true)
		{
			return default((string, double));
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7887BC0", Offset = "0x7886FC0", VA = "0x187887BC0")]
		private static (string, double) PrettyFormatNanoSecondValue(double valueInNanoSeconds, bool abbreviate = true)
		{
			return default((string, double));
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7887900", Offset = "0x7886D00", VA = "0x187887900")]
		private static (string, double) PrettyFormatByteValue(double valueInBytes, bool abbreviate = true)
		{
			return default((string, double));
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7887A60", Offset = "0x7886E60", VA = "0x187887A60")]
		private static (string, double) PrettyFormatHzValue(double valueInHz, bool abbreviate = true)
		{
			return default((string, double));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public readonly struct RawMetric
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public readonly MetricId MetricId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public readonly RawMetricPayload MetricPayload;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x4D67230", Offset = "0x4D66630", VA = "0x184D67230")]
		public RawMetric(MetricId metricId, RawMetricPayload payload)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7888890", Offset = "0x7887C90", VA = "0x187888890")]
		public static RawMetric Integer(MetricId metricId, int value)
		{
			return default(RawMetric);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x78888C0", Offset = "0x7887CC0", VA = "0x1878888C0")]
		public static RawMetric Long(MetricId metricId, long value)
		{
			return default(RawMetric);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7888860", Offset = "0x7887C60", VA = "0x187888860")]
		public static RawMetric Double(MetricId metricId, double value)
		{
			return default(RawMetric);
		}
	}
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public readonly struct RawMetricPayload : IEquatable<RawMetricPayload>
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int Int
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x9DD8E0", Offset = "0x9DCCE0", VA = "0x1809DD8E0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public float Float
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x2854040", Offset = "0x2853440", VA = "0x182854040")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public long Long
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xC67BB0", Offset = "0xC66FB0", VA = "0x180C67BB0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public double Double
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x3CB0370", Offset = "0x3CAF770", VA = "0x183CB0370")]
			[CompilerGenerated]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public MetricStorageTypes MetricStorageType
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xC67CD0", Offset = "0xC670D0", VA = "0x180C67CD0")]
			[CompilerGenerated]
			get
			{
				return default(MetricStorageTypes);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x78887A0", Offset = "0x7887BA0", VA = "0x1878887A0")]
		public RawMetricPayload(int intValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7888790", Offset = "0x7887B90", VA = "0x187888790")]
		public RawMetricPayload(long longValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7888780", Offset = "0x7887B80", VA = "0x187888780")]
		public RawMetricPayload(double doubleValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7888340", Offset = "0x7887740", VA = "0x187888340", Slot = "4")]
		public bool Equals(RawMetricPayload other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x78882A0", Offset = "0x78876A0", VA = "0x1878882A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x78885F0", Offset = "0x78879F0", VA = "0x1878885F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7888660", Offset = "0x7887A60", VA = "0x187888660", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7888360", Offset = "0x7887760", VA = "0x187888360")]
		public static string FormatInt64AsHex(long data)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface IRawMetricsPipeline : IMetricsSubscriber<RawMetric>, IMetricsPublisher<RawMetric>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface IRawMetricsSubscriber : IMetricsSubscriber<RawMetric>
	{
	}
}
namespace RecRoom.Metrics.Pipeline.MetricInfo
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct MetricDescription : IEquatable<MetricDescription>
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public static readonly MetricDescription Invalid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public readonly MetricId MetricId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public readonly MetricDataUnits DataUnit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public readonly string CustomSuffix;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x78864F0", Offset = "0x78858F0", VA = "0x1878864F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x78864D0", Offset = "0x78858D0", VA = "0x1878864D0")]
		public MetricDescription(MetricId metricId, MetricDataUnits dataUnit, [Optional] string customSuffix)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x78860D0", Offset = "0x78854D0", VA = "0x1878860D0")]
		public (bool, bool) CanUpdateWith(MetricDescription description)
		{
			return default((bool, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7886320", Offset = "0x7885720", VA = "0x187886320", Slot = "4")]
		public bool Equals(MetricDescription other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7886210", Offset = "0x7885610", VA = "0x187886210", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x78863B0", Offset = "0x78857B0", VA = "0x1878863B0", Slot = "2")]
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

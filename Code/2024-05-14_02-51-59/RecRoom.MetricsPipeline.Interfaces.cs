using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.Logging.Attributes;
using RecRoom.Metrics.Pipeline.MetricInfo;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_MetricsPipeline_Interfaces
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : DEDNPPDJFOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6390630", Offset = "0x638F030", VA = "0x186390630", Slot = "4")]
		public override void JIGIEBIDGIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7EC840", Offset = "0x7EB240", VA = "0x1807EC840")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum DHPOKPFAEHE : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Undefined,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Number,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Count,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	TimeNanoseconds,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	SizeInBytes,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	Percent,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	FrequencyHz
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum LHPMKEEICFO : byte
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Undefined,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	Bytes8,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	Int,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Float,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	Long,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Double
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class DCHOFODDGKF
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6390140", Offset = "0x638EB40", VA = "0x186390140")]
	public static (string, double) LPEDKLIMBIE(double NCDAHBFCDFJ, DHPOKPFAEHE MOFALLBJGML, bool EIHAILMPNCI = true)
	{
		return default((string, double));
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x638FEB0", Offset = "0x638E8B0", VA = "0x18638FEB0")]
	private static (string, double) CEHNCEJHJJF(double FIPMGNPAIAM, bool EIHAILMPNCI = true)
	{
		return default((string, double));
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6390490", Offset = "0x638EE90", VA = "0x186390490")]
	private static (string, double) NPOECDLLEDE(double JEOFCHFCECI, bool EIHAILMPNCI = true)
	{
		return default((string, double));
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x638FFF0", Offset = "0x638E9F0", VA = "0x18638FFF0")]
	private static (string, double) HFCLLBKPEHO(double DCBLMIFIEDB, bool EIHAILMPNCI = true)
	{
		return default((string, double));
	}
}
namespace RecRoom.Metrics.Pipeline
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface IMetricCollectionRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event MetricCollectionRequiredChanged OnMetricCollectionEnabledChanged;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void MarkRequiresMetricCollection(MetricCollectionToken token, MetricId metricId);

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void MarkDoesNotRequireMetricCollection(MetricCollectionToken token, MetricId metricId);

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool IsMetricCollectionRequired(MetricId metricId);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public delegate void MetricCollectionRequiredChanged(MetricId metricId, bool isMetricCollectionRequired);
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct MetricCollectionToken : IEquatable<MetricCollectionToken>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public readonly string TokenName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly object Token;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x95C330", Offset = "0x95AD30", VA = "0x18095C330")]
		public MetricCollectionToken(string tokenName, object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x63907B0", Offset = "0x638F1B0", VA = "0x1863907B0", Slot = "4")]
		public bool Equals(MetricCollectionToken other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x63907C0", Offset = "0x638F1C0", VA = "0x1863907C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6390850", Offset = "0x638F250", VA = "0x186390850", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class PayloadExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6392160", Offset = "0x6390B60", VA = "0x186392160")]
		public static double ReadAsDouble(this RawMetricPayload rawMetricPayload)
		{
			return default(double);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public static class RawMetricPipelineExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6392730", Offset = "0x6391130", VA = "0x186392730")]
		public static void PublishMetric(this IRawMetricsPipeline pipeline, RawMetric rawMetric)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface IMetricsPublisher<TMessage>
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool AddSubscriber(IMetricsSubscriber<TMessage> subscriber);

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool RemoveSubscriber(IMetricsSubscriber<TMessage> subscriber);
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface IMetricsSubscriber<TMessage>
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void HandleMetric([In] TMessage metricMessage);
	}
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public readonly struct MetricId : IEquatable<MetricId>
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public const ushort INVALID_IDX = 0;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly MetricId Invalid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly ushort SourceIdx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public readonly ushort MetricNameIdx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly uint CombinedId;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6391CD0", Offset = "0x63906D0", VA = "0x186391CD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3E02590", Offset = "0x3E00F90", VA = "0x183E02590")]
		public MetricId(ushort sourceIdx, ushort metricNameIdx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8BB510", Offset = "0x8B9F10", VA = "0x1808BB510", Slot = "4")]
		public bool Equals(MetricId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6391B30", Offset = "0x6390530", VA = "0x186391B30", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x927700", Offset = "0x926100", VA = "0x180927700", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6391CE0", Offset = "0x63906E0", VA = "0x186391CE0")]
		public static bool operator ==(MetricId left, MetricId right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6391D30", Offset = "0x6390730", VA = "0x186391D30")]
		public static bool operator !=(MetricId left, MetricId right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6391BD0", Offset = "0x63905D0", VA = "0x186391BD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class MetricIdLookup
	{
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static readonly LBNENDFDEJK Logger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly MetricIdxRegistry sourceIdxRegistry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly Dictionary<ushort, MetricIdxRegistry> sourceNameIdxRegistries;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly List<MetricId> metricIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly Dictionary<MetricId, MetricDescription> metricDescriptions;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x63919D0", Offset = "0x63903D0", VA = "0x1863919D0")]
		[RecRoom.NoEngine.Common.Preserve]
		public MetricIdLookup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6390CF0", Offset = "0x638F6F0", VA = "0x186390CF0")]
		public MetricId AddOrGetMetricId(string metricSourceName, string metricName)
		{
			return default(MetricId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6390E20", Offset = "0x638F820", VA = "0x186390E20")]
		public MetricId GetMetricId(string metricSourceName, string metricName)
		{
			return default(MetricId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x63917B0", Offset = "0x63901B0", VA = "0x1863917B0")]
		public MetricDescription RegisterOrGetMetricDescription(string metricSourceName, string metricName, DHPOKPFAEHE metricUnit, [Optional] string customSuffix)
		{
			return default(MetricDescription);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6390D60", Offset = "0x638F760", VA = "0x186390D60")]
		public MetricDescription GetMetricDescription(MetricId metricId)
		{
			return default(MetricDescription);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x63918A0", Offset = "0x63902A0", VA = "0x1863918A0")]
		public bool TryGetMetricNames(MetricId metricId, [Out] string metricSourceName, [Out] string metricName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6390F90", Offset = "0x638F990", VA = "0x186390F90")]
		private (MetricId, bool, bool) Internal_AddOrGetMetricIdForNames(string metricSourceName, string metricName)
		{
			return default((MetricId, bool, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x63915A0", Offset = "0x638FFA0", VA = "0x1863915A0")]
		private (MetricDescription, bool) Internal_RegisterOrGetMetricDescription(MetricId metricId, DHPOKPFAEHE metricUnit, string customSuffix)
		{
			return default((MetricDescription, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6391180", Offset = "0x638FB80", VA = "0x186391180")]
		private void Internal_LogAddMetric(string metricSourceName, string metricName, MetricId metricId, bool addedSource, bool addedName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x63912C0", Offset = "0x638FCC0", VA = "0x1863912C0")]
		private void Internal_LogRegisterDescription(MetricDescription description, bool addedDescription)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal class MetricIdxRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private const ushort INVALID_IDX = 0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly List<string> names;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly Dictionary<string, ushort> nameIdxLookup;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6392020", Offset = "0x6390A20", VA = "0x186392020")]
		public bool TryGetNameIdx(string name, [Out] ushort idx)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6391E70", Offset = "0x6390870", VA = "0x186391E70")]
		internal ushort RegisterNameIdx(string name)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6391D80", Offset = "0x6390780", VA = "0x186391D80")]
		public (ushort, bool) AddOrGetNameId(string name)
		{
			return default((ushort, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6391F70", Offset = "0x6390970", VA = "0x186391F70")]
		public bool TryGetIdxName(ushort idx, [Out] string name)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x17833D0", Offset = "0x1781DD0", VA = "0x1817833D0")]
		internal static ushort InternalToIndex(int index)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6391E60", Offset = "0x6390860", VA = "0x186391E60")]
		internal static int IndexToInternal(ushort id)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6392090", Offset = "0x6390A90", VA = "0x186392090")]
		public MetricIdxRegistry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public readonly struct RawMetric
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public readonly MetricId MetricId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public readonly RawMetricPayload MetricPayload;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3E02380", Offset = "0x3E00D80", VA = "0x183E02380")]
		public RawMetric(MetricId metricId, RawMetricPayload payload)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x63927E0", Offset = "0x63911E0", VA = "0x1863927E0")]
		public static RawMetric Integer(MetricId metricId, int value)
		{
			return default(RawMetric);
		}
	}
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public readonly struct RawMetricPayload : IEquatable<RawMetricPayload>
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int Int
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x927700", Offset = "0x926100", VA = "0x180927700")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public float Float
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x2018290", Offset = "0x2016C90", VA = "0x182018290")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public long Long
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x88DB00", Offset = "0x88C500", VA = "0x18088DB00")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public double Double
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x2F20BD0", Offset = "0x2F1F5D0", VA = "0x182F20BD0")]
			[CompilerGenerated]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public LHPMKEEICFO MetricStorageType
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x1A110E0", Offset = "0x1A0FAE0", VA = "0x181A110E0")]
			[CompilerGenerated]
			get
			{
				return default(LHPMKEEICFO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6392720", Offset = "0x6391120", VA = "0x186392720")]
		public RawMetricPayload(int intValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6392710", Offset = "0x6391110", VA = "0x186392710")]
		public RawMetricPayload(double doubleValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x63922E0", Offset = "0x6390CE0", VA = "0x1863922E0", Slot = "4")]
		public bool Equals(RawMetricPayload other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6392250", Offset = "0x6390C50", VA = "0x186392250", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6392580", Offset = "0x6390F80", VA = "0x186392580", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x63925F0", Offset = "0x6390FF0", VA = "0x1863925F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6392300", Offset = "0x6390D00", VA = "0x186392300")]
		public static string FormatInt64AsHex(long data)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface IRawMetricsPipeline : IMetricsSubscriber<RawMetric>, IMetricsPublisher<RawMetric>
	{
	}
}
namespace RecRoom.Metrics.Pipeline.MetricInfo
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public readonly struct MetricDescription : IEquatable<MetricDescription>
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public static readonly MetricDescription Invalid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public readonly MetricId MetricId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public readonly DHPOKPFAEHE DataUnit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public readonly string CustomSuffix;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x6390CA0", Offset = "0x638F6A0", VA = "0x186390CA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6390C80", Offset = "0x638F680", VA = "0x186390C80")]
		public MetricDescription(MetricId metricId, DHPOKPFAEHE dataUnit, [Optional] string customSuffix)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6390880", Offset = "0x638F280", VA = "0x186390880")]
		public (bool, bool) CanUpdateWith(MetricDescription description)
		{
			return default((bool, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6390AC0", Offset = "0x638F4C0", VA = "0x186390AC0", Slot = "4")]
		public bool Equals(MetricDescription other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x63909C0", Offset = "0x638F3C0", VA = "0x1863909C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6390B50", Offset = "0x638F550", VA = "0x186390B50", Slot = "2")]
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

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
	public class LogRegistrationIndex : BOJNKDJNMOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6928180", Offset = "0x6926D80", VA = "0x186928180", Slot = "4")]
		public override void FHCDBNBHAOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x86D6A0", Offset = "0x86C2A0", VA = "0x18086D6A0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum ECBEINGBHPJ : byte
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
public enum GNEBNGOKIDN : byte
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
public static class NILMLKCDAID
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6929D60", Offset = "0x6928960", VA = "0x186929D60")]
	public static (string, double) JOGODINOLOE(double EGJDOFEHJDB, ECBEINGBHPJ IMAOBHBOIOM, bool AJHAIPNJEMM = true)
	{
		return default((string, double));
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6929C20", Offset = "0x6928820", VA = "0x186929C20")]
	private static (string, double) DAMILNDLKLD(double NGMGFAIHNHJ, bool AJHAIPNJEMM = true)
	{
		return default((string, double));
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x692A200", Offset = "0x6928E00", VA = "0x18692A200")]
	private static (string, double) PNCLMEJIDGF(double KLODJFOMPOP, bool AJHAIPNJEMM = true)
	{
		return default((string, double));
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x692A0B0", Offset = "0x6928CB0", VA = "0x18692A0B0")]
	private static (string, double) PJOAOMHOPCC(double KBMIINMHGAH, bool AJHAIPNJEMM = true)
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
		[Cpp2IlInjected.Address(RVA = "0xA93C90", Offset = "0xA92890", VA = "0x180A93C90")]
		public MetricCollectionToken(string tokenName, object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6928300", Offset = "0x6926F00", VA = "0x186928300", Slot = "4")]
		public bool Equals(MetricCollectionToken other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6928310", Offset = "0x6926F10", VA = "0x186928310", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x69283A0", Offset = "0x6926FA0", VA = "0x1869283A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class PayloadExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x692A3A0", Offset = "0x6928FA0", VA = "0x18692A3A0")]
		public static double ReadAsDouble(this RawMetricPayload rawMetricPayload)
		{
			return default(double);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public static class RawMetricPipelineExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x692A980", Offset = "0x6929580", VA = "0x18692A980")]
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
			[Cpp2IlInjected.Address(RVA = "0x68D67F0", Offset = "0x68D53F0", VA = "0x1868D67F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x41E2A60", Offset = "0x41E1660", VA = "0x1841E2A60")]
		public MetricId(ushort sourceIdx, ushort metricNameIdx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9D6EA0", Offset = "0x9D5AA0", VA = "0x1809D6EA0", Slot = "4")]
		public bool Equals(MetricId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6929660", Offset = "0x6928260", VA = "0x186929660", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x916930", Offset = "0x915530", VA = "0x180916930", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6929800", Offset = "0x6928400", VA = "0x186929800")]
		public static bool operator ==(MetricId left, MetricId right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6929850", Offset = "0x6928450", VA = "0x186929850")]
		public static bool operator !=(MetricId left, MetricId right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6929700", Offset = "0x6928300", VA = "0x186929700", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class MetricIdLookup
	{
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static readonly KEDKJKIEEGM Logger;

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
		[Cpp2IlInjected.Address(RVA = "0x6929500", Offset = "0x6928100", VA = "0x186929500")]
		[RecRoom.NoEngine.Common.Preserve]
		public MetricIdLookup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6928850", Offset = "0x6927450", VA = "0x186928850")]
		public MetricId AddOrGetMetricId(string metricSourceName, string metricName)
		{
			return default(MetricId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6928980", Offset = "0x6927580", VA = "0x186928980")]
		public MetricId GetMetricId(string metricSourceName, string metricName)
		{
			return default(MetricId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x69292E0", Offset = "0x6927EE0", VA = "0x1869292E0")]
		public MetricDescription RegisterOrGetMetricDescription(string metricSourceName, string metricName, ECBEINGBHPJ metricUnit, [Optional] string customSuffix)
		{
			return default(MetricDescription);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x69288C0", Offset = "0x69274C0", VA = "0x1869288C0")]
		public MetricDescription GetMetricDescription(MetricId metricId)
		{
			return default(MetricDescription);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x69293D0", Offset = "0x6927FD0", VA = "0x1869293D0")]
		public bool TryGetMetricNames(MetricId metricId, [Out] string metricSourceName, [Out] string metricName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6928AF0", Offset = "0x69276F0", VA = "0x186928AF0")]
		private (MetricId, bool, bool) Internal_AddOrGetMetricIdForNames(string metricSourceName, string metricName)
		{
			return default((MetricId, bool, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x69290D0", Offset = "0x6927CD0", VA = "0x1869290D0")]
		private (MetricDescription, bool) Internal_RegisterOrGetMetricDescription(MetricId metricId, ECBEINGBHPJ metricUnit, string customSuffix)
		{
			return default((MetricDescription, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6928CA0", Offset = "0x69278A0", VA = "0x186928CA0")]
		private void Internal_LogAddMetric(string metricSourceName, string metricName, MetricId metricId, bool addedSource, bool addedName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6928DE0", Offset = "0x69279E0", VA = "0x186928DE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6929AE0", Offset = "0x69286E0", VA = "0x186929AE0")]
		public bool TryGetNameIdx(string name, [Out] ushort idx)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6929990", Offset = "0x6928590", VA = "0x186929990")]
		internal ushort RegisterNameIdx(string name)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x69298A0", Offset = "0x69284A0", VA = "0x1869298A0")]
		public (ushort, bool) AddOrGetNameId(string name)
		{
			return default((ushort, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6929A30", Offset = "0x6928630", VA = "0x186929A30")]
		public bool TryGetIdxName(ushort idx, [Out] string name)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x188FD30", Offset = "0x188E930", VA = "0x18188FD30")]
		internal static ushort InternalToIndex(int index)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6929980", Offset = "0x6928580", VA = "0x186929980")]
		internal static int IndexToInternal(ushort id)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6929B50", Offset = "0x6928750", VA = "0x186929B50")]
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
		[Cpp2IlInjected.Address(RVA = "0x41E2940", Offset = "0x41E1540", VA = "0x1841E2940")]
		public RawMetric(MetricId metricId, RawMetricPayload payload)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x692AA30", Offset = "0x6929630", VA = "0x18692AA30")]
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
			[Cpp2IlInjected.Address(RVA = "0x916930", Offset = "0x915530", VA = "0x180916930")]
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
			[Cpp2IlInjected.Address(RVA = "0x2145A50", Offset = "0x2144650", VA = "0x182145A50")]
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
			[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x317F6E0", Offset = "0x317E2E0", VA = "0x18317F6E0")]
			[CompilerGenerated]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public GNEBNGOKIDN MetricStorageType
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x1B91D70", Offset = "0x1B90970", VA = "0x181B91D70")]
			[CompilerGenerated]
			get
			{
				return default(GNEBNGOKIDN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x692A970", Offset = "0x6929570", VA = "0x18692A970")]
		public RawMetricPayload(int intValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x692A960", Offset = "0x6929560", VA = "0x18692A960")]
		public RawMetricPayload(double doubleValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x692A530", Offset = "0x6929130", VA = "0x18692A530", Slot = "4")]
		public bool Equals(RawMetricPayload other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x692A490", Offset = "0x6929090", VA = "0x18692A490", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x692A7D0", Offset = "0x69293D0", VA = "0x18692A7D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x692A840", Offset = "0x6929440", VA = "0x18692A840", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x692A550", Offset = "0x6929150", VA = "0x18692A550")]
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
		public readonly ECBEINGBHPJ DataUnit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public readonly string CustomSuffix;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x6928800", Offset = "0x6927400", VA = "0x186928800")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x69287E0", Offset = "0x69273E0", VA = "0x1869287E0")]
		public MetricDescription(MetricId metricId, ECBEINGBHPJ dataUnit, [Optional] string customSuffix)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x69283D0", Offset = "0x6926FD0", VA = "0x1869283D0")]
		public (bool, bool) CanUpdateWith(MetricDescription description)
		{
			return default((bool, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6928620", Offset = "0x6927220", VA = "0x186928620", Slot = "4")]
		public bool Equals(MetricDescription other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6928510", Offset = "0x6927110", VA = "0x186928510", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x69286B0", Offset = "0x69272B0", VA = "0x1869286B0", Slot = "2")]
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

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Metrics
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class AccumulationMetric : Metric
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private struct AccumulationMetricAnalyzer : IMetricAnalyzer
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			private int _count;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			private double _value;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			private readonly MetricReportEntry[] _entryArray;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public readonly Metric Owner
			{
				[Cpp2IlInjected.Token(Token = "0x6000003")]
				[Cpp2IlInjected.Address(RVA = "0xBCBE40", Offset = "0xBCAA40", VA = "0x180BCBE40", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			private readonly MetricSampler _sampler
			{
				[Cpp2IlInjected.Token(Token = "0x6000004")]
				[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x8A7FB50", Offset = "0x8A7E750", VA = "0x188A7FB50")]
			public AccumulationMetricAnalyzer(Metric metric, bool showCount)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xB131D0", Offset = "0xB11DD0", VA = "0x180B131D0", Slot = "7")]
			public MetricReportEntry[] GetEntryList()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x8A7F880", Offset = "0x8A7E480", VA = "0x188A7F880", Slot = "4")]
			public void Start()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x8A7F8C0", Offset = "0x8A7E4C0", VA = "0x188A7F8C0", Slot = "5")]
			public void Stop()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8A7F9D0", Offset = "0x8A7E5D0", VA = "0x188A7F9D0", Slot = "6")]
			public void SyncFrame(int frameId)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private readonly bool _showCount;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8A7FE20", Offset = "0x8A7EA20", VA = "0x188A7FE20")]
		public AccumulationMetric(MetricPriority priority, MetricCategory category, string name, MetricSampler sampler, bool showCount = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8A7FD90", Offset = "0x8A7E990", VA = "0x188A7FD90", Slot = "4")]
		protected override IMetricAnalyzer InternalCreateAnalyzer()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class CountMetric : Metric
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private struct CountMetricAnalyzer : IMetricAnalyzer
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			private int _count;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			private readonly MetricReportEntry[] _entryArray;

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public readonly Metric Owner
			{
				[Cpp2IlInjected.Token(Token = "0x600000C")]
				[Cpp2IlInjected.Address(RVA = "0xBCBE40", Offset = "0xBCAA40", VA = "0x180BCBE40", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			private readonly MetricSampler _sampler
			{
				[Cpp2IlInjected.Token(Token = "0x600000D")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x8A80150", Offset = "0x8A7ED50", VA = "0x188A80150")]
			public CountMetricAnalyzer(Metric metric)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810", Slot = "7")]
			public MetricReportEntry[] GetEntryList()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8A7FF90", Offset = "0x8A7EB90", VA = "0x188A7FF90", Slot = "4")]
			public void Start()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8A7FFC0", Offset = "0x8A7EBC0", VA = "0x188A7FFC0", Slot = "5")]
			public void Stop()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8A80070", Offset = "0x8A7EC70", VA = "0x188A80070", Slot = "6")]
			public void SyncFrame(int frameId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8A80320", Offset = "0x8A7EF20", VA = "0x188A80320")]
		public CountMetric(MetricPriority priority, MetricCategory category, string name, MetricSampler sampler)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8A802A0", Offset = "0x8A7EEA0", VA = "0x188A802A0", Slot = "4")]
		protected override IMetricAnalyzer InternalCreateAnalyzer()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface IMetricAnalyzer
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Start();

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Stop();

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void SyncFrame(int frameId);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "3")]
		MetricReportEntry[] GetEntryList();
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum MetricCategory
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		Global,
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		Performance,
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		Memory,
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		LoadTime,
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		Render,
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		Network,
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		RecNet,
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		UGC,
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		AI,
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		Audio,
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		Physics,
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		UI,
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		None
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public enum MetricPriority
	{
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		Required,
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		High,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		Normal,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		Low
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public readonly struct MetricIdentifier : IEquatable<MetricIdentifier>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly int _hashInteger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly string _hashHexString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly string _shortHashHexString;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private static bool _initialized;

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static SHA256 _hashAlgorithm;

		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private static StringBuilder _builder;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8A80A70", Offset = "0x8A7F670", VA = "0x188A80A70")]
		public MetricIdentifier(string desc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8A80570", Offset = "0x8A7F170", VA = "0x188A80570")]
		private static void ComputeHash(string rawData, [Out] string readableHexString, [Out] string readableShortHexString, [Out] int shortenedHashInteger)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8A809D0", Offset = "0x8A7F5D0", VA = "0x188A809D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8A80A60", Offset = "0x8A7F660", VA = "0x188A80A60", Slot = "4")]
		public bool Equals(MetricIdentifier other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xCE0880", Offset = "0xCDF480", VA = "0x180CE0880", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public abstract class Metric
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public MetricPriority Priority
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xB13110", Offset = "0xB11D10", VA = "0x180B13110")]
			[CompilerGenerated]
			get
			{
				return default(MetricPriority);
			}
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xB1FB20", Offset = "0xB1E720", VA = "0x180B1FB20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public MetricCategory Category
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xB69740", Offset = "0xB68340", VA = "0x180B69740")]
			[CompilerGenerated]
			get
			{
				return default(MetricCategory);
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xC13B00", Offset = "0xC12700", VA = "0x180C13B00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public MetricIdentifier Identifier
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xF191F0", Offset = "0xF17DF0", VA = "0x180F191F0")]
			[CompilerGenerated]
			get
			{
				return default(MetricIdentifier);
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8A84950", Offset = "0x8A83550", VA = "0x188A84950")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xB13140", Offset = "0xB11D40", VA = "0x180B13140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xB1ACA0", Offset = "0xB198A0", VA = "0x180B1ACA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public MetricSampler Sampler
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xB13A50", Offset = "0xB12650", VA = "0x180B13A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xB13200", Offset = "0xB11E00", VA = "0x180B13200")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string Units
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x11A6F80", Offset = "0x11A5B80", VA = "0x1811A6F80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8A845C0", Offset = "0x8A831C0", VA = "0x188A845C0")]
		protected Metric(MetricPriority priority, MetricCategory category, string name, MetricSampler sampler)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xDB4F90", Offset = "0xDB3B90", VA = "0x180DB4F90")]
		public IMetricAnalyzer CreateAnalyzer()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract IMetricAnalyzer InternalCreateAnalyzer();

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8A84590", Offset = "0x8A83190", VA = "0x188A84590")]
		public void SyncFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8A84560", Offset = "0x8A83160", VA = "0x188A84560")]
		public void FinalizeFrame()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct MetricEventInstance
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public readonly MetricEvent Event
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xBCBE40", Offset = "0xBCAA40", VA = "0x180BCBE40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public readonly MetricIdentifier Identifier
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x596F800", Offset = "0x596E400", VA = "0x18596F800")]
			[CompilerGenerated]
			get
			{
				return default(MetricIdentifier);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public readonly MetricSession CurrentSession
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x8A80510", Offset = "0x8A7F110", VA = "0x188A80510")]
			[CompilerGenerated]
			get
			{
				return default(MetricSession);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public readonly MetricSession PreviousSession
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8A80540", Offset = "0x8A7F140", VA = "0x188A80540")]
			[CompilerGenerated]
			get
			{
				return default(MetricSession);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public readonly long Timestamp
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xB44440", Offset = "0xB43040", VA = "0x180B44440")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public readonly string Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xB1D6F0", Offset = "0xB1C2F0", VA = "0x180B1D6F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MetricEvent
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public MetricIdentifier Identifier
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x1A9E020", Offset = "0x1A9CC20", VA = "0x181A9E020")]
			[CompilerGenerated]
			get
			{
				return default(MetricIdentifier);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public MetricPriority Priority
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xB1FB30", Offset = "0xB1E730", VA = "0x180B1FB30")]
			[CompilerGenerated]
			get
			{
				return default(MetricPriority);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public MetricCategory Category
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xCB0B00", Offset = "0xCAF700", VA = "0x180CB0B00")]
			[CompilerGenerated]
			get
			{
				return default(MetricCategory);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xB13140", Offset = "0xB11D40", VA = "0x180B13140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public sealed class MetricLog
	{
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static readonly HashSet<Metric> metricRegistry;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static readonly Lazy<MetricLog> instance;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public static string BuildSummary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly Dictionary<string, string> _metadata;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly Stack<MetricSession> _currentSessionStack;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly List<MetricSession> _sessionList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private int _sessionIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly Queue<Action> _sessionActionQueue;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static MetricLog Instance
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x8A828B0", Offset = "0x8A814B0", VA = "0x188A828B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static bool Active
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8A82830", Offset = "0x8A81430", VA = "0x188A82830")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private MetricSession PreviousSession
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8A82930", Offset = "0x8A81530", VA = "0x188A82930")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8A81760", Offset = "0x8A80360", VA = "0x188A81760")]
		private static MetricLog Initializer()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8A824C0", Offset = "0x8A810C0", VA = "0x188A824C0")]
		private MetricLog()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8A80C30", Offset = "0x8A7F830", VA = "0x188A80C30")]
		public void AddMetadata(string key, string value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8A81830", Offset = "0x8A80430", VA = "0x188A81830")]
		public void StartSession(string name, string desc, [Optional] MetricCategory[] filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8A81A20", Offset = "0x8A80620", VA = "0x188A81A20")]
		public void StopSession()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8A81EC0", Offset = "0x8A80AC0", VA = "0x188A81EC0")]
		public void UpdateMetrics()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8A810A0", Offset = "0x8A7FCA0", VA = "0x188A810A0")]
		public void ClearSessions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8A80D50", Offset = "0x8A7F950", VA = "0x188A80D50")]
		public MetricReport BuildReport(string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8A817B0", Offset = "0x8A803B0", VA = "0x188A817B0")]
		public static void Register(Metric metric)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8A81270", Offset = "0x8A7FE70", VA = "0x188A81270")]
		public IMetricAnalyzer[] CreateMetricAnalyzerArray()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8A81220", Offset = "0x8A7FE20", VA = "0x188A81220")]
		private static bool Contains(MetricCategory cat, MetricCategory[] categoryFilter)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8A814A0", Offset = "0x8A800A0", VA = "0x188A814A0")]
		public IMetricAnalyzer[] CreateMetricAnalyzerArray(MetricCategory[] categoryFilter)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface IMetricReportArtifact : IComparable<IMetricReportArtifact>
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		float Timestamp
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		string Uri
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		bool Processed
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void WriteOutput();
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct MetricReportHeader : IComparable<MetricReportHeader>, IEquatable<MetricReportHeader>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public MetricIdentifier Identifier
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x4641850", Offset = "0x4640450", VA = "0x184641850")]
			[CompilerGenerated]
			readonly get
			{
				return default(MetricIdentifier);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x8A82E10", Offset = "0x8A81A10", VA = "0x188A82E10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Metric ParentMetric
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xB13A60", Offset = "0xB12660", VA = "0x180B13A60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xB256B0", Offset = "0xB242B0", VA = "0x180B256B0")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xB6A400", Offset = "0xB69000", VA = "0x180B6A400")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xB131D0", Offset = "0xB11DD0", VA = "0x180B131D0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xB180C0", Offset = "0xB16CC0", VA = "0x180B180C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool Enabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xC66AC0", Offset = "0xC656C0", VA = "0x180C66AC0")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xCB0820", Offset = "0xCAF420", VA = "0x180CB0820")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8A82CC0", Offset = "0x8A818C0", VA = "0x188A82CC0")]
		public MetricReportHeader(Metric parent, int index, string value, bool enabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8A82AA0", Offset = "0x8A816A0", VA = "0x188A82AA0", Slot = "4")]
		public int CompareTo(MetricReportHeader other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8A82CA0", Offset = "0x8A818A0", VA = "0x188A82CA0", Slot = "5")]
		public bool Equals(MetricReportHeader other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8A82C10", Offset = "0x8A81810", VA = "0x188A82C10", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8A82CB0", Offset = "0x8A818B0", VA = "0x188A82CB0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct MetricReportEntry
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public readonly MetricReportHeader Header
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x4641870", Offset = "0x4640470", VA = "0x184641870")]
			[CompilerGenerated]
			get
			{
				return default(MetricReportHeader);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xB13A50", Offset = "0xB12650", VA = "0x180B13A50")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xB13200", Offset = "0xB11E00", VA = "0x180B13200")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8A829C0", Offset = "0x8A815C0", VA = "0x188A829C0")]
		public MetricReportEntry(Metric owner, int index, string header, bool enabled = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public readonly struct MetricReportCapture
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xCE0880", Offset = "0xCDF480", VA = "0x180CE0880")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public MetricSession Session
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x5973290", Offset = "0x5971E90", VA = "0x185973290")]
			[CompilerGenerated]
			get
			{
				return default(MetricSession);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public MetricReportEntry[] EntryArray
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xB13240", Offset = "0xB11E40", VA = "0x180B13240")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8A82960", Offset = "0x8A81560", VA = "0x188A82960")]
		public MetricReportCapture(int index, MetricSession session, MetricReportEntry[] entryArray)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public readonly struct MetricAssert
	{
		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public string Message
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xBCBE40", Offset = "0xBCAA40", VA = "0x180BCBE40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public float Timestamp
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x2E05BB0", Offset = "0x2E047B0", VA = "0x182E05BB0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x55789D0", Offset = "0x55775D0", VA = "0x1855789D0")]
		public MetricAssert(string message, float timestamp)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class MetricReport
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private struct <ProcessDatabricksMeasurements>d__21 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public AsyncTaskMethodBuilder<string> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public MetricReport <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public DateTime fileTime;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x8A85B30", Offset = "0x8A84730", VA = "0x188A85B30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x8A86480", Offset = "0x8A85080", VA = "0x188A86480", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private struct <ProcessDatabricksMetadata>d__20 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public AsyncTaskMethodBuilder<string> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public MetricReport <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x8A864F0", Offset = "0x8A850F0", VA = "0x188A864F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x8A86A70", Offset = "0x8A85670", VA = "0x188A86A70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private struct <ProcessEventOutput>d__22 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public AsyncTaskMethodBuilder<string> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public MetricReport <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x8A86AE0", Offset = "0x8A856E0", VA = "0x188A86AE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x8A87230", Offset = "0x8A85E30", VA = "0x188A87230", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private struct <ProcessOutput>d__19 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public AsyncTaskMethodBuilder<string> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public MetricReport <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x8A872A0", Offset = "0x8A85EA0", VA = "0x188A872A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x8A88D50", Offset = "0x8A87950", VA = "0x188A88D50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private struct <WaitForReportComplete>d__18 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public MetricReport <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x8A890D0", Offset = "0x8A87CD0", VA = "0x188A890D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x8A89440", Offset = "0x8A88040", VA = "0x188A89440", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private Dictionary<MetricReportHeader, int> typeLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private Dictionary<string, string> metadataDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private List<MetricReportHeader> headerList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private List<MetricReportCapture> captureList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private List<MetricEventInstance> eventList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private List<IMetricReportArtifact> artifactList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private List<MetricAssert> assertionFailureList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private string name;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool IsComplete
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xBB3CE0", Offset = "0xBB28E0", VA = "0x180BB3CE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xBB3D50", Offset = "0xBB2950", VA = "0x180BB3D50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8A83830", Offset = "0x8A82430", VA = "0x188A83830")]
		public MetricReport(string reportName, Dictionary<string, string> metadata)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8A82F40", Offset = "0x8A81B40", VA = "0x188A82F40")]
		public void AddCapture(int index, MetricSession session, MetricReportEntry[] metricEntryArray)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8A82E30", Offset = "0x8A81A30", VA = "0x188A82E30")]
		public void AddArtifact(IMetricReportArtifact metricArtifact)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8A82EE0", Offset = "0x8A81AE0", VA = "0x188A82EE0")]
		public void AddAssertionFailures(IEnumerable<MetricAssert> metricAsserts)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8A83760", Offset = "0x8A82360", VA = "0x188A83760")]
		[AsyncStateMachine(typeof(<WaitForReportComplete>d__18))]
		private Task WaitForReportComplete()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8A83540", Offset = "0x8A82140", VA = "0x188A83540")]
		[AsyncStateMachine(typeof(<ProcessOutput>d__19))]
		public Task<string> ProcessOutput()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8A83360", Offset = "0x8A81F60", VA = "0x188A83360")]
		[AsyncStateMachine(typeof(<ProcessDatabricksMetadata>d__20))]
		public Task<string> ProcessDatabricksMetadata()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8A83250", Offset = "0x8A81E50", VA = "0x188A83250")]
		[AsyncStateMachine(typeof(<ProcessDatabricksMeasurements>d__21))]
		public Task<string> ProcessDatabricksMeasurements(DateTime fileTime)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8A83450", Offset = "0x8A82050", VA = "0x188A83450")]
		[AsyncStateMachine(typeof(<ProcessEventOutput>d__22))]
		public Task<string> ProcessEventOutput()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public interface IMetricSamplerIterator
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		int Frame
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		long Timestamp
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		double Sample
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool MoveNext();
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class MetricSampler
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		private struct Iterator : IMetricSamplerIterator
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			private readonly MetricSampler _sampler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			private int _remaining;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private int _index;

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			public int Frame
			{
				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(RVA = "0x8A7FED0", Offset = "0x8A7EAD0", VA = "0x188A7FED0", Slot = "4")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			public long Timestamp
			{
				[Cpp2IlInjected.Token(Token = "0x6000092")]
				[Cpp2IlInjected.Address(RVA = "0x8A7FF50", Offset = "0x8A7EB50", VA = "0x188A7FF50", Slot = "5")]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			public double Sample
			{
				[Cpp2IlInjected.Token(Token = "0x6000093")]
				[Cpp2IlInjected.Address(RVA = "0x8A7FF10", Offset = "0x8A7EB10", VA = "0x188A7FF10", Slot = "6")]
				get
				{
					return default(double);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x8A7FE90", Offset = "0x8A7EA90", VA = "0x188A7FE90")]
			public Iterator(MetricSampler owningSampler, int begin, int count)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x8A80440", Offset = "0x8A7F040", VA = "0x188A80440", Slot = "7")]
			public bool MoveNext()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		private struct BackIterator : IMetricSamplerIterator
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private readonly MetricSampler _sampler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private int _remaining;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private int _index;

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			public int Frame
			{
				[Cpp2IlInjected.Token(Token = "0x6000096")]
				[Cpp2IlInjected.Address(RVA = "0x8A7FED0", Offset = "0x8A7EAD0", VA = "0x188A7FED0", Slot = "4")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public long Timestamp
			{
				[Cpp2IlInjected.Token(Token = "0x6000097")]
				[Cpp2IlInjected.Address(RVA = "0x8A7FF50", Offset = "0x8A7EB50", VA = "0x188A7FF50", Slot = "5")]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public double Sample
			{
				[Cpp2IlInjected.Token(Token = "0x6000098")]
				[Cpp2IlInjected.Address(RVA = "0x8A7FF10", Offset = "0x8A7EB10", VA = "0x188A7FF10", Slot = "6")]
				get
				{
					return default(double);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x8A7FE90", Offset = "0x8A7EA90", VA = "0x188A7FE90")]
			public BackIterator(MetricSampler owningSampler, int begin, int count)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x8A7FE50", Offset = "0x8A7EA50", VA = "0x188A7FE50", Slot = "7")]
			public bool MoveNext()
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		private readonly struct EmptyIterator : IMetricSamplerIterator
		{
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public static readonly EmptyIterator Default;

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public int Frame
			{
				[Cpp2IlInjected.Token(Token = "0x600009B")]
				[Cpp2IlInjected.Address(RVA = "0xB16800", Offset = "0xB15400", VA = "0x180B16800", Slot = "4")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public long Timestamp
			{
				[Cpp2IlInjected.Token(Token = "0x600009C")]
				[Cpp2IlInjected.Address(RVA = "0xB16800", Offset = "0xB15400", VA = "0x180B16800", Slot = "5")]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public double Sample
			{
				[Cpp2IlInjected.Token(Token = "0x600009D")]
				[Cpp2IlInjected.Address(RVA = "0xB64500", Offset = "0xB63100", VA = "0x180B64500", Slot = "6")]
				get
				{
					return default(double);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "7")]
			public bool MoveNext()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		protected int frameId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		protected int frameSampleCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		protected int lastFrameEndIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		protected int validSampleIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		protected int sampleIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		protected int[] sampleFrameIdArray;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		protected long[] sampleTimeStampArray;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		protected double[] sampleArray;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xB3C3D0", Offset = "0xB3AFD0", VA = "0x180B3C3D0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xF7EB30", Offset = "0xF7D730", VA = "0x180F7EB30")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public int Capacity
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xB1FB30", Offset = "0xB1E730", VA = "0x180B1FB30")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xB1FE50", Offset = "0xB1EA50", VA = "0x180B1FE50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public string Units
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xB13140", Offset = "0xB11D40", VA = "0x180B13140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xB1ACA0", Offset = "0xB198A0", VA = "0x180B1ACA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8A83CB0", Offset = "0x8A828B0", VA = "0x188A83CB0")]
		public MetricSampler(string units, int capacity = 1800)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8A83C30", Offset = "0x8A82830", VA = "0x188A83C30")]
		protected void InternalProcessSample(double sample, long timeStamp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8A83B70", Offset = "0x8A82770", VA = "0x188A83B70")]
		public IMetricSamplerIterator GetFrameIterator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8A83A90", Offset = "0x8A82690", VA = "0x188A83A90")]
		public IMetricSamplerIterator GetBackIterator(int samples = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "4")]
		public virtual void SyncFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "5")]
		public virtual void OnCaptureStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "6")]
		public virtual void OnCaptureStop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8A83A70", Offset = "0x8A82670", VA = "0x188A83A70")]
		public void FinalizeFrame()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class MetricCallbackSampler : MetricSampler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		protected Func<double> callback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		protected double threshold;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8A803F0", Offset = "0x8A7EFF0", VA = "0x188A803F0")]
		public MetricCallbackSampler(string units, Func<double> sampleCallback, double sampleThreshold = -1.7976931348623157E+308)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8A80480", Offset = "0x8A7F080", VA = "0x188A80480", Slot = "4")]
		public override void SyncFrame()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class DeltaMetricCallbackSampler : MetricCallbackSampler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private double bias;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private double lastSample;

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8A803F0", Offset = "0x8A7EFF0", VA = "0x188A803F0")]
		public DeltaMetricCallbackSampler(string units, Func<double> sampleCallback, double sampleThreshold = -1.7976931348623157E+308)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8A80340", Offset = "0x8A7EF40", VA = "0x188A80340", Slot = "4")]
		public override void SyncFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8A80330", Offset = "0x8A7EF30", VA = "0x188A80330", Slot = "6")]
		public override void OnCaptureStop()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class MetricIntervalSampler : MetricSampler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private long startTime;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8A80BE0", Offset = "0x8A7F7E0", VA = "0x188A80BE0")]
		public MetricIntervalSampler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8A80AA0", Offset = "0x8A7F6A0", VA = "0x188A80AA0")]
		public void ProcessBegin()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8A80AF0", Offset = "0x8A7F6F0", VA = "0x188A80AF0")]
		public void ProcessEnd()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public readonly struct MetricSession : IComparer<MetricSession>
	{
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public static MetricSession Empty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private readonly IMetricAnalyzer[] _analyzerList;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public MetricIdentifier Identifier
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x4641850", Offset = "0x4640450", VA = "0x184641850")]
			[CompilerGenerated]
			get
			{
				return default(MetricIdentifier);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xB1D780", Offset = "0xB1C380", VA = "0x180B1D780")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public float Timestamp
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xB77A50", Offset = "0xB76650", VA = "0x180B77A50")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8A84410", Offset = "0x8A83010", VA = "0x188A84410")]
		public MetricSession(int index, string name, string desc, IMetricAnalyzer[] analyzers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8A83FF0", Offset = "0x8A82BF0", VA = "0x188A83FF0")]
		public void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x8A84220", Offset = "0x8A82E20", VA = "0x188A84220")]
		public void SyncFrame(int frameId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8A84100", Offset = "0x8A82D00", VA = "0x188A84100")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8A83E40", Offset = "0x8A82A40", VA = "0x188A83E40")]
		public MetricReportEntry[] GetEntryArray()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x8A83DA0", Offset = "0x8A829A0", VA = "0x188A83DA0", Slot = "4")]
		public int Compare(MetricSession x, MetricSession y)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[Flags]
	public enum MetricDisplayMask
	{
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		Mean = 1,
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		Min = 2,
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		Max = 4,
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		Sum = 8,
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		Var = 0x10,
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		StdDev = 0x20,
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		Count = 0x40
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class StatisticalMetric : Metric
	{
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		private struct StatisticalMetricAnalyzer : IMetricAnalyzer
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			private double _mean;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			private double _sum;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			private double _sumOfSqrDiff;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			private double _variance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			private double _stdDev;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			private double _val;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			private int _count;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			private double _max;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			private double _min;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			private readonly bool _highPrecision;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			private readonly MetricReportEntry[] _entryArray;

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public readonly Metric Owner
			{
				[Cpp2IlInjected.Token(Token = "0x60000B5")]
				[Cpp2IlInjected.Address(RVA = "0xBCBE40", Offset = "0xBCAA40", VA = "0x180BCBE40", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			private readonly MetricSampler _sampler
			{
				[Cpp2IlInjected.Token(Token = "0x60000B6")]
				[Cpp2IlInjected.Address(RVA = "0xB14930", Offset = "0xB13530", VA = "0x180B14930")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x8A852F0", Offset = "0x8A83EF0", VA = "0x188A852F0")]
			public StatisticalMetricAnalyzer(Metric metric, MetricDisplayMask displayMask, bool highPrecision)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xB13280", Offset = "0xB11E80", VA = "0x180B13280", Slot = "7")]
			public MetricReportEntry[] GetEntryList()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x8A84A50", Offset = "0x8A83650", VA = "0x188A84A50", Slot = "4")]
			public void Start()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x8A84AC0", Offset = "0x8A836C0", VA = "0x188A84AC0", Slot = "5")]
			public void Stop()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x8A84970", Offset = "0x8A83570", VA = "0x188A84970")]
			private void ProcessSample(double sample, long timestamp, int frame)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x8A85050", Offset = "0x8A83C50", VA = "0x188A85050", Slot = "6")]
			public void SyncFrame(int frameId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public static readonly MetricDisplayMask Range;

		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public static readonly MetricDisplayMask Simple;

		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public static readonly MetricDisplayMask Detailed;

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public static readonly MetricDisplayMask All;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly MetricDisplayMask _displayMask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly bool _highPrecision;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8A85AF0", Offset = "0x8A846F0", VA = "0x188A85AF0")]
		public StatisticalMetric(MetricPriority priority, MetricCategory category, string name, MetricSampler sampler, MetricDisplayMask displayMask, bool highPrecision = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8A85970", Offset = "0x8A84570", VA = "0x188A85970", Slot = "4")]
		protected override IMetricAnalyzer InternalCreateAnalyzer()
		{
			return null;
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

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Metrics.Pipeline
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class MetricsPipeline<T> : MetricsStream<T>, IMetricsSubscriber<T>, IMetricsPublisher<T>
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x4A2B150", Offset = "0x4A29950", VA = "0x184A2B150")]
		public MetricsPipeline(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x4A2B100", Offset = "0x4A29900", VA = "0x184A2B100", Slot = "6")]
		void IMetricsSubscriber<T>.HandleMetric([In] T metricMessage)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class MetricsStream<TMessage> : Subscribable<TMessage>, IMetricsSubscriber<TMessage>, IMetricsPublisher<TMessage>
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x4A2B1B0", Offset = "0x4A299B0", VA = "0x184A2B1B0")]
		public void HandleMetric([In] TMessage metricMessage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x3D3D3E0", Offset = "0x3D3BBE0", VA = "0x183D3D3E0")]
		public MetricsStream()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x4A2B260", Offset = "0x4A29A60", VA = "0x184A2B260", Slot = "6")]
		void IMetricsSubscriber<TMessage>.HandleMetric([In] TMessage metricMessage)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	internal static class Clock
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public static readonly Stopwatch Stopwatch;
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class EWMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly double weight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly long halflifeInStopwatchTicks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private long previousTimestamp;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public uint TotalSamples
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x8B5250", Offset = "0x8B3A50", VA = "0x1808B5250")]
			[CompilerGenerated]
			get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8B5240", Offset = "0x8B3A40", VA = "0x1808B5240")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public double Min
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6446AE0", Offset = "0x64452E0", VA = "0x186446AE0")]
			[CompilerGenerated]
			get
			{
				return default(double);
			}
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x6446660", Offset = "0x6444E60", VA = "0x186446660")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public double Max
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x6446640", Offset = "0x6444E40", VA = "0x186446640")]
			[CompilerGenerated]
			get
			{
				return default(double);
			}
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x6446B20", Offset = "0x6445320", VA = "0x186446B20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public double Variance
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x9A4980", Offset = "0x9A3180", VA = "0x1809A4980")]
			[CompilerGenerated]
			get
			{
				return default(double);
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6446B30", Offset = "0x6445330", VA = "0x186446B30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public double Mean
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x6446AD0", Offset = "0x64452D0", VA = "0x186446AD0")]
			[CompilerGenerated]
			get
			{
				return default(double);
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x6446B00", Offset = "0x6445300", VA = "0x186446B00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6FB5D50", Offset = "0x6FB4550", VA = "0x186FB5D50")]
		public EWMA(double weight = 0.9, [Optional] TimeSpan halflife)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6FB5CC0", Offset = "0x6FB44C0", VA = "0x186FB5CC0", Slot = "4")]
		public virtual void Track(double val)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6FB5B20", Offset = "0x6FB4320", VA = "0x186FB5B20", Slot = "5")]
		public virtual void Track(double val, long timestamp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6FB5AF0", Offset = "0x6FB42F0", VA = "0x186FB5AF0", Slot = "6")]
		public virtual void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6FB5AD0", Offset = "0x6FB42D0", VA = "0x186FB5AD0")]
		public void ResetMinMaxOnly()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal class RawMetricsPipeline : MetricsPipeline<RawMetric>, IRawMetricsPipeline, IMetricsSubscriber<RawMetric>, IMetricsPublisher<RawMetric>
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6FB6460", Offset = "0x6FB4C60", VA = "0x186FB6460")]
		[Preserve]
		public RawMetricsPipeline()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6FB6410", Offset = "0x6FB4C10", VA = "0x186FB6410", Slot = "6")]
		void IMetricsSubscriber<RawMetric>.HandleMetric([In] RawMetric metricMessage)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class Subscribable<TMessage> : IMetricsPublisher<TMessage>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly HashSet<IMetricsSubscriber<TMessage>> subscribers;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4EE5EA0", Offset = "0x4EE46A0", VA = "0x184EE5EA0")]
		protected void SendToSubscribers(TMessage metricsMessage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4A5EAB0", Offset = "0x4A5D2B0", VA = "0x184A5EAB0", Slot = "4")]
		public bool AddSubscriber(IMetricsSubscriber<TMessage> subscriber)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4EE5E50", Offset = "0x4EE4650", VA = "0x184EE5E50", Slot = "5")]
		public bool RemoveSubscriber(IMetricsSubscriber<TMessage> subscriber)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x4EE6270", Offset = "0x4EE4A70", VA = "0x184EE6270")]
		public Subscribable()
		{
		}
	}
}
namespace RecRoom.Metrics.Pipeline.CollectionRegistry
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class MetricCollectionRegistry : IMetricCollectionRegistry
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<MetricId, COKMJHAKPPF> metricCollectionTokenFlags;

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event MetricCollectionRequiredChanged OnMetricCollectionEnabledChanged
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6FB62D0", Offset = "0x6FB4AD0", VA = "0x186FB62D0", Slot = "7")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6FB6370", Offset = "0x6FB4B70", VA = "0x186FB6370", Slot = "8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6FB6240", Offset = "0x6FB4A40", VA = "0x186FB6240")]
		[Preserve]
		public MetricCollectionRegistry()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6FB6060", Offset = "0x6FB4860", VA = "0x186FB6060", Slot = "4")]
		public void MarkRequiresMetricCollection(MetricCollectionToken token, MetricId metricId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6FB5F40", Offset = "0x6FB4740", VA = "0x186FB5F40", Slot = "5")]
		public void MarkDoesNotRequireMetricCollection(MetricCollectionToken token, MetricId metricId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6FB5E90", Offset = "0x6FB4690", VA = "0x186FB5E90", Slot = "6")]
		public bool IsMetricCollectionRequired(MetricId metricId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6FB61D0", Offset = "0x6FB49D0", VA = "0x186FB61D0")]
		private void SafeInvokeMetricCollectionEnabledChanged(MetricId metricId, bool tokenFlagHasTokens)
		{
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

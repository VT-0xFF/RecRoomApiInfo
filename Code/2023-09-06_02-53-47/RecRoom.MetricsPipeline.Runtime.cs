using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Metrics.Pipeline
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class Subscribable<TMessage> : IMetricsPublisher<TMessage>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private readonly HashSet<IMetricsSubscriber<TMessage>> subscribers;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x34BD2F0", Offset = "0x34BB8F0", VA = "0x1834BD2F0")]
		protected void SendToSubscribers(TMessage metricsMessage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x179C120", Offset = "0x179A720", VA = "0x18179C120", Slot = "4")]
		public bool AddSubscriber(IMetricsSubscriber<TMessage> subscriber)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x34BD090", Offset = "0x34BB690", VA = "0x1834BD090", Slot = "5")]
		public bool RemoveSubscriber(IMetricsSubscriber<TMessage> subscriber)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x34BD520", Offset = "0x34BBB20", VA = "0x1834BD520")]
		public Subscribable()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	internal class RawMetricsPipeline : MetricsPipeline<RawMetric>, IRawMetricsPipeline, IMetricsSubscriber<RawMetric>, IMetricsPublisher<RawMetric>
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6FECFF0", Offset = "0x6FEB5F0", VA = "0x186FECFF0")]
		[Preserve]
		public RawMetricsPipeline()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6FECFA0", Offset = "0x6FEB5A0", VA = "0x186FECFA0", Slot = "6")]
		void IMetricsSubscriber<RawMetric>.HandleMetric(in RawMetric metricMessage)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class MetricsPipeline<T> : MetricsStream<T>, IMetricsSubscriber<T>, IMetricsPublisher<T>
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x24D8590", Offset = "0x24D6B90", VA = "0x1824D8590")]
		public MetricsPipeline(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x24D8560", Offset = "0x24D6B60", VA = "0x1824D8560", Slot = "6")]
		void IMetricsSubscriber<T>.HandleMetric(in T metricMessage)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class MetricsStream<TMessage> : Subscribable<TMessage>, IMetricsSubscriber<TMessage>, IMetricsPublisher<TMessage>
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x24D8620", Offset = "0x24D6C20", VA = "0x1824D8620")]
		public void HandleMetric(in TMessage metricMessage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x94AC60", Offset = "0x949260", VA = "0x18094AC60")]
		public MetricsStream()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x24D8560", Offset = "0x24D6B60", VA = "0x1824D8560", Slot = "6")]
		void IMetricsSubscriber<TMessage>.HandleMetric(in TMessage metricMessage)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class MetricsBootstrapper
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6FECEC0", Offset = "0x6FEB4C0", VA = "0x186FECEC0")]
		[HFALCAKMDCP(BFPOMPMIJIJ.None)]
		public static void BindPipelines(HOKFDAHMIPF diContainer)
		{
		}
	}
}
namespace RecRoom.Metrics.Pipeline.CollectionRegistry
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class MetricCollectionRegistry : IMetricCollectionRegistry
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly Dictionary<MetricId, DMMBJKBEDJE> metricCollectionTokenFlags;

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event MetricCollectionRequiredChanged OnMetricCollectionEnabledChanged
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x6FECD80", Offset = "0x6FEB380", VA = "0x186FECD80", Slot = "7")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6FECE20", Offset = "0x6FEB420", VA = "0x186FECE20", Slot = "8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6FECD00", Offset = "0x6FEB300", VA = "0x186FECD00")]
		[Preserve]
		public MetricCollectionRegistry()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6FECB40", Offset = "0x6FEB140", VA = "0x186FECB40", Slot = "4")]
		public void MarkRequiresMetricCollection(MetricCollectionToken token, MetricId metricId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6FECA40", Offset = "0x6FEB040", VA = "0x186FECA40", Slot = "5")]
		public void MarkDoesNotRequireMetricCollection(MetricCollectionToken token, MetricId metricId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6FEC9B0", Offset = "0x6FEAFB0", VA = "0x186FEC9B0", Slot = "6")]
		public bool IsMetricCollectionRequired(MetricId metricId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6FECC90", Offset = "0x6FEB290", VA = "0x186FECC90")]
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

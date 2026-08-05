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
		[Cpp2IlInjected.Address(RVA = "0x2E01EE0", Offset = "0x2E006E0", VA = "0x182E01EE0")]
		protected void SendToSubscribers(TMessage metricsMessage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x29C3C20", Offset = "0x29C2420", VA = "0x1829C3C20", Slot = "4")]
		public bool AddSubscriber(IMetricsSubscriber<TMessage> subscriber)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x2E01C80", Offset = "0x2E00480", VA = "0x182E01C80", Slot = "5")]
		public bool RemoveSubscriber(IMetricsSubscriber<TMessage> subscriber)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2E02120", Offset = "0x2E00920", VA = "0x182E02120")]
		public Subscribable()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	internal class RawMetricsPipeline : MetricsPipeline<RawMetric>, IRawMetricsPipeline, IMetricsSubscriber<RawMetric>, IMetricsPublisher<RawMetric>
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1687AA0", Offset = "0x16862A0", VA = "0x181687AA0")]
		[Preserve]
		public RawMetricsPipeline()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1687A50", Offset = "0x1686250", VA = "0x181687A50", Slot = "6")]
		void IMetricsSubscriber<RawMetric>.HandleMetric(in RawMetric metricMessage)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class MetricsPipeline<T> : MetricsStream<T>, IMetricsSubscriber<T>, IMetricsPublisher<T>
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x34109B0", Offset = "0x340F1B0", VA = "0x1834109B0")]
		public MetricsPipeline(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3410980", Offset = "0x340F180", VA = "0x183410980", Slot = "6")]
		void IMetricsSubscriber<T>.HandleMetric(in T metricMessage)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class MetricsStream<TMessage> : Subscribable<TMessage>, IMetricsSubscriber<TMessage>, IMetricsPublisher<TMessage>
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3410A40", Offset = "0x340F240", VA = "0x183410A40")]
		public void HandleMetric(in TMessage metricMessage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1CA08A0", Offset = "0x1C9F0A0", VA = "0x181CA08A0")]
		public MetricsStream()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3410980", Offset = "0x340F180", VA = "0x183410980", Slot = "6")]
		void IMetricsSubscriber<TMessage>.HandleMetric(in TMessage metricMessage)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class MetricsBootstrapper
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1687970", Offset = "0x1686170", VA = "0x181687970")]
		[BBAPFPLPODF(EDNJEIFHIMJ.None)]
		public static void BindPipelines(MHOBEFMLEFD diContainer)
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
		private readonly Dictionary<MetricId, FMDOKKBAPOM> metricCollectionTokenFlags;

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event MetricCollectionRequiredChanged OnMetricCollectionEnabledChanged
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x1687830", Offset = "0x1686030", VA = "0x181687830", Slot = "7")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x16878D0", Offset = "0x16860D0", VA = "0x1816878D0", Slot = "8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x16877B0", Offset = "0x1685FB0", VA = "0x1816877B0")]
		[Preserve]
		public MetricCollectionRegistry()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x16875F0", Offset = "0x1685DF0", VA = "0x1816875F0", Slot = "4")]
		public void MarkRequiresMetricCollection(MetricCollectionToken token, MetricId metricId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x16874F0", Offset = "0x1685CF0", VA = "0x1816874F0", Slot = "5")]
		public void MarkDoesNotRequireMetricCollection(MetricCollectionToken token, MetricId metricId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x1687460", Offset = "0x1685C60", VA = "0x181687460", Slot = "6")]
		public bool IsMetricCollectionRequired(MetricId metricId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1687740", Offset = "0x1685F40", VA = "0x181687740")]
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

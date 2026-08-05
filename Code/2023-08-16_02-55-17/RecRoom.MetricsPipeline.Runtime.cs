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
		[Cpp2IlInjected.Address(RVA = "0x4903D10", Offset = "0x4902F10", VA = "0x184903D10")]
		protected void SendToSubscribers(TMessage metricsMessage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2710C30", Offset = "0x270FE30", VA = "0x182710C30", Slot = "4")]
		public bool AddSubscriber(IMetricsSubscriber<TMessage> subscriber)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x4903AB0", Offset = "0x4902CB0", VA = "0x184903AB0", Slot = "5")]
		public bool RemoveSubscriber(IMetricsSubscriber<TMessage> subscriber)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x4903F40", Offset = "0x4903140", VA = "0x184903F40")]
		public Subscribable()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	internal class RawMetricsPipeline : MetricsPipeline<RawMetric>, IRawMetricsPipeline, IMetricsSubscriber<RawMetric>, IMetricsPublisher<RawMetric>
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6F72940", Offset = "0x6F71B40", VA = "0x186F72940")]
		[Preserve]
		public RawMetricsPipeline()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6F728F0", Offset = "0x6F71AF0", VA = "0x186F728F0", Slot = "6")]
		void IMetricsSubscriber<RawMetric>.HandleMetric(in RawMetric metricMessage)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class MetricsPipeline<T> : MetricsStream<T>, IMetricsSubscriber<T>, IMetricsPublisher<T>
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1C45F50", Offset = "0x1C45150", VA = "0x181C45F50")]
		public MetricsPipeline(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1C45F20", Offset = "0x1C45120", VA = "0x181C45F20", Slot = "6")]
		void IMetricsSubscriber<T>.HandleMetric(in T metricMessage)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class MetricsStream<TMessage> : Subscribable<TMessage>, IMetricsSubscriber<TMessage>, IMetricsPublisher<TMessage>
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1C45FE0", Offset = "0x1C451E0", VA = "0x181C45FE0")]
		public void HandleMetric(in TMessage metricMessage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9D9830", Offset = "0x9D8A30", VA = "0x1809D9830")]
		public MetricsStream()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1C45F20", Offset = "0x1C45120", VA = "0x181C45F20", Slot = "6")]
		void IMetricsSubscriber<TMessage>.HandleMetric(in TMessage metricMessage)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class MetricsBootstrapper
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6F72810", Offset = "0x6F71A10", VA = "0x186F72810")]
		[GKCPJLBLCDF(EHLDMJJGFKP.None)]
		public static void BindPipelines(JFLMNMMPBBG diContainer)
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
		private readonly Dictionary<MetricId, PDJBEHKNNCI> metricCollectionTokenFlags;

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event MetricCollectionRequiredChanged OnMetricCollectionEnabledChanged
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x6F726D0", Offset = "0x6F718D0", VA = "0x186F726D0", Slot = "7")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6F72770", Offset = "0x6F71970", VA = "0x186F72770", Slot = "8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6F72650", Offset = "0x6F71850", VA = "0x186F72650")]
		[Preserve]
		public MetricCollectionRegistry()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6F72490", Offset = "0x6F71690", VA = "0x186F72490", Slot = "4")]
		public void MarkRequiresMetricCollection(MetricCollectionToken token, MetricId metricId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6F72390", Offset = "0x6F71590", VA = "0x186F72390", Slot = "5")]
		public void MarkDoesNotRequireMetricCollection(MetricCollectionToken token, MetricId metricId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6F72300", Offset = "0x6F71500", VA = "0x186F72300", Slot = "6")]
		public bool IsMetricCollectionRequired(MetricId metricId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6F725E0", Offset = "0x6F717E0", VA = "0x186F725E0")]
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

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
		[Cpp2IlInjected.Address(RVA = "0x4C946B0", Offset = "0x4C934B0", VA = "0x184C946B0")]
		public MetricsPipeline(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x4D08D50", Offset = "0x4D07B50", VA = "0x184D08D50", Slot = "6")]
		void IMetricsSubscriber<T>.HandleMetric([In] T metricMessage)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class MetricsStream<TMessage> : Subscribable<TMessage>, IMetricsSubscriber<TMessage>, IMetricsPublisher<TMessage>
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x4D08DA0", Offset = "0x4D07BA0", VA = "0x184D08DA0")]
		public void HandleMetric([In] TMessage metricMessage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x4051ED0", Offset = "0x4050CD0", VA = "0x184051ED0")]
		public MetricsStream()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x4D08E50", Offset = "0x4D07C50", VA = "0x184D08E50", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x8F8F70", Offset = "0x8F7D70", VA = "0x1808F8F70")]
			[CompilerGenerated]
			get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8F8F00", Offset = "0x8F7D00", VA = "0x1808F8F00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public double Min
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x676ED50", Offset = "0x676DB50", VA = "0x18676ED50")]
			[CompilerGenerated]
			get
			{
				return default(double);
			}
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x676F220", Offset = "0x676E020", VA = "0x18676F220")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public double Max
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x676F200", Offset = "0x676E000", VA = "0x18676F200")]
			[CompilerGenerated]
			get
			{
				return default(double);
			}
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x676F1C0", Offset = "0x676DFC0", VA = "0x18676F1C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public double Variance
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x676ED30", Offset = "0x676DB30", VA = "0x18676ED30")]
			[CompilerGenerated]
			get
			{
				return default(double);
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x676F1D0", Offset = "0x676DFD0", VA = "0x18676F1D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public double Mean
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x676F210", Offset = "0x676E010", VA = "0x18676F210")]
			[CompilerGenerated]
			get
			{
				return default(double);
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x676ED60", Offset = "0x676DB60", VA = "0x18676ED60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x72E8C30", Offset = "0x72E7A30", VA = "0x1872E8C30")]
		public EWMA(double weight = 0.9, [Optional] TimeSpan halflife)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x72E8BA0", Offset = "0x72E79A0", VA = "0x1872E8BA0", Slot = "4")]
		public virtual void Track(double val)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x72E8A00", Offset = "0x72E7800", VA = "0x1872E8A00", Slot = "5")]
		public virtual void Track(double val, long timestamp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x72E89D0", Offset = "0x72E77D0", VA = "0x1872E89D0", Slot = "6")]
		public virtual void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x72E89B0", Offset = "0x72E77B0", VA = "0x1872E89B0")]
		public void ResetMinMaxOnly()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal class RawMetricsPipeline : MetricsPipeline<RawMetric>, IRawMetricsPipeline, IMetricsSubscriber<RawMetric>, IMetricsPublisher<RawMetric>
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x72E9340", Offset = "0x72E8140", VA = "0x1872E9340")]
		[Preserve]
		public RawMetricsPipeline()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x72E92F0", Offset = "0x72E80F0", VA = "0x1872E92F0", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x51A0290", Offset = "0x519F090", VA = "0x1851A0290")]
		protected void SendToSubscribers(TMessage metricsMessage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4D2CFE0", Offset = "0x4D2BDE0", VA = "0x184D2CFE0", Slot = "4")]
		public bool AddSubscriber(IMetricsSubscriber<TMessage> subscriber)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x51A0240", Offset = "0x519F040", VA = "0x1851A0240", Slot = "5")]
		public bool RemoveSubscriber(IMetricsSubscriber<TMessage> subscriber)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x51A0660", Offset = "0x519F460", VA = "0x1851A0660")]
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
		private readonly Dictionary<MetricId, LKPBNFNIBPJ> metricCollectionTokenFlags;

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event MetricCollectionRequiredChanged OnMetricCollectionEnabledChanged
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x72E91B0", Offset = "0x72E7FB0", VA = "0x1872E91B0", Slot = "7")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x72E9250", Offset = "0x72E8050", VA = "0x1872E9250", Slot = "8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x72E9120", Offset = "0x72E7F20", VA = "0x1872E9120")]
		[Preserve]
		public MetricCollectionRegistry()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x72E8F40", Offset = "0x72E7D40", VA = "0x1872E8F40", Slot = "4")]
		public void MarkRequiresMetricCollection(MetricCollectionToken token, MetricId metricId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x72E8E20", Offset = "0x72E7C20", VA = "0x1872E8E20", Slot = "5")]
		public void MarkDoesNotRequireMetricCollection(MetricCollectionToken token, MetricId metricId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x72E8D70", Offset = "0x72E7B70", VA = "0x1872E8D70", Slot = "6")]
		public bool IsMetricCollectionRequired(MetricId metricId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x72E90B0", Offset = "0x72E7EB0", VA = "0x1872E90B0")]
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

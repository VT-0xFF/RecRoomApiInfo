using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using CSCore;
using CSCore.CoreAudioAPI;
using CSCore.SoundIn;
using CSCore.Streams;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.StreamingAudio
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public interface FPZBYBFJEMQ
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool ZFMNPHTGRKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IReadOnlyList<QLCVRZPLTSB> RXPJELJJLLX();
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface QLCVRZPLTSB
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		string LPMQZOFBKKV
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		bool RGJDHILUCEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		bool LRPZESMMOSC
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "3")]
		StreamInfo PCYHDZVQBYY(Action<ArraySegment<float>> a);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void OEPJSHEQLQS();
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct StreamInfo
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int Channels
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xDCFD90", Offset = "0xDCED90", VA = "0x180DCFD90")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x16602A0", Offset = "0x165F2A0", VA = "0x1816602A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int SampleRate
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x30BACC0", Offset = "0x30B9CC0", VA = "0x1830BACC0")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x30BACD0", Offset = "0x30B9CD0", VA = "0x1830BACD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x878D1E0", Offset = "0x878C1E0", VA = "0x18878D1E0")]
		public StreamInfo(int sampleRate, int channels)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class StreamingAudio
	{
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static FPZBYBFJEMQ YGYRWQTKLTJ;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static bool ZFMNPHTGRKN
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x9243C50", Offset = "0x9242C50", VA = "0x189243C50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9243DC0", Offset = "0x9242DC0", VA = "0x189243DC0")]
		static StreamingAudio()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9243CD0", Offset = "0x9242CD0", VA = "0x189243CD0")]
		public static IReadOnlyList<QLCVRZPLTSB> RXPJELJJLLX()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class RQDOFMKVUSY : FPZBYBFJEMQ
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class UXYMVGHJNTU : QLCVRZPLTSB
		{
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			[CompilerGenerated]
			private sealed class WLNPPNEKMUG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000009")]
				public Action<ArraySegment<float>> TEPIKIUCSZA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400000A")]
				public float[] UNUGGCKWDFZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400000B")]
				public int UPMTRKCXOSV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public ISampleSource HJPVOQZOKHQ;

				[Cpp2IlInjected.Token(Token = "0x600001B")]
				[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
				public WLNPPNEKMUG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600001C")]
				[Cpp2IlInjected.Address(RVA = "0x9244350", Offset = "0x9243350", VA = "0x189244350")]
				internal void JIDUTKLHFSI(object a, DataAvailableEventArgs b)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			private MMDevice QMRZECKCPOX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			private WasapiLoopbackCapture SEQTLWUBYHN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			private SoundInSource AGTNHLQMRXV;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public string LPMQZOFBKKV
			{
				[Cpp2IlInjected.Token(Token = "0x6000013")]
				[Cpp2IlInjected.Address(RVA = "0x9243F20", Offset = "0x9242F20", VA = "0x189243F20", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public bool RGJDHILUCEE
			{
				[Cpp2IlInjected.Token(Token = "0x6000014")]
				[Cpp2IlInjected.Address(RVA = "0xCF83E0", Offset = "0xCF73E0", VA = "0x180CF83E0", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0xCF83F0", Offset = "0xCF73F0", VA = "0x180CF83F0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public bool LRPZESMMOSC
			{
				[Cpp2IlInjected.Token(Token = "0x6000016")]
				[Cpp2IlInjected.Address(RVA = "0xFF3790", Offset = "0xFF2790", VA = "0x180FF3790", Slot = "6")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x92442D0", Offset = "0x92432D0", VA = "0x1892442D0", Slot = "7")]
			public StreamInfo PCYHDZVQBYY(Action<ArraySegment<float>> a)
			{
				return default(StreamInfo);
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x9243F40", Offset = "0x9242F40", VA = "0x189243F40")]
			private StreamInfo PCYHDZVQBYY(int a, int b, int c, Action<ArraySegment<float>> d)
			{
				return default(StreamInfo);
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x9243EA0", Offset = "0x9242EA0", VA = "0x189243EA0", Slot = "8")]
			public void OEPJSHEQLQS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x9244300", Offset = "0x9243300", VA = "0x189244300")]
			public UXYMVGHJNTU(MMDevice a, bool b)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private List<UXYMVGHJNTU> WCUFZQQFIXT;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool ZFMNPHTGRKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xAE9210", Offset = "0xAE8210", VA = "0x180AE9210", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x92438D0", Offset = "0x92428D0", VA = "0x1892438D0", Slot = "5")]
		public IReadOnlyList<QLCVRZPLTSB> RXPJELJJLLX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9243BD0", Offset = "0x9242BD0", VA = "0x189243BD0")]
		public RQDOFMKVUSY()
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

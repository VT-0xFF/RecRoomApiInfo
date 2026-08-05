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
	public interface XDTBLJFDVAQ
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool RAPJGTYDAUJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IReadOnlyList<AQANVZMTNDT> PLPWETHDJGV();
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface AQANVZMTNDT
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		string AUAUPSXZBLT
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		bool IZMYCYRLXGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		bool FQLBGPVRUAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "3")]
		StreamInfo CDAXQUMWJWQ(Action<ArraySegment<float>> a);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void VPJFEWYPXBM();
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct StreamInfo
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int Channels
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xCE0880", Offset = "0xCDF480", VA = "0x180CE0880")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x167A4A0", Offset = "0x16790A0", VA = "0x18167A4A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int SampleRate
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x32F76D0", Offset = "0x32F62D0", VA = "0x1832F76D0")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x32F76E0", Offset = "0x32F62E0", VA = "0x1832F76E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8A6E870", Offset = "0x8A6D470", VA = "0x188A6E870")]
		public StreamInfo(int sampleRate, int channels)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class StreamingAudio
	{
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static XDTBLJFDVAQ KSZMUGQCHCX;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static bool RAPJGTYDAUJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x955AA40", Offset = "0x9559640", VA = "0x18955AA40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x955ABB0", Offset = "0x95597B0", VA = "0x18955ABB0")]
		static StreamingAudio()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x955AAC0", Offset = "0x95596C0", VA = "0x18955AAC0")]
		public static IReadOnlyList<AQANVZMTNDT> PLPWETHDJGV()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class FFJHTAIEQCU : XDTBLJFDVAQ
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class TVZANNURULU : AQANVZMTNDT
		{
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			[CompilerGenerated]
			private sealed class XLYSDAWRGEK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000009")]
				public Action<ArraySegment<float>> COHZLVOMFVA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400000A")]
				public float[] ECHOXEISYYL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400000B")]
				public int NKWLBBGSMOZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public ISampleSource CIRRXLWZODU;

				[Cpp2IlInjected.Token(Token = "0x600001B")]
				[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
				public XLYSDAWRGEK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600001C")]
				[Cpp2IlInjected.Address(RVA = "0x955B140", Offset = "0x9559D40", VA = "0x18955B140")]
				internal void MWIFCVABGYM(object a, DataAvailableEventArgs b)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			private MMDevice FRINERDOVRV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			private WasapiLoopbackCapture VVSMAMVKOAP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			private SoundInSource XLGXVDZAHZF;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public string AUAUPSXZBLT
			{
				[Cpp2IlInjected.Token(Token = "0x6000013")]
				[Cpp2IlInjected.Address(RVA = "0x955B050", Offset = "0x9559C50", VA = "0x18955B050", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public bool IZMYCYRLXGA
			{
				[Cpp2IlInjected.Token(Token = "0x6000014")]
				[Cpp2IlInjected.Address(RVA = "0xDD0FC0", Offset = "0xDCFBC0", VA = "0x180DD0FC0", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0xC901B0", Offset = "0xC8EDB0", VA = "0x180C901B0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public bool FQLBGPVRUAC
			{
				[Cpp2IlInjected.Token(Token = "0x6000016")]
				[Cpp2IlInjected.Address(RVA = "0xFA5700", Offset = "0xFA4300", VA = "0x180FA5700", Slot = "6")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x955B020", Offset = "0x9559C20", VA = "0x18955B020", Slot = "7")]
			public StreamInfo CDAXQUMWJWQ(Action<ArraySegment<float>> a)
			{
				return default(StreamInfo);
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x955AC90", Offset = "0x9559890", VA = "0x18955AC90")]
			private StreamInfo CDAXQUMWJWQ(int a, int b, int c, Action<ArraySegment<float>> d)
			{
				return default(StreamInfo);
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x955B070", Offset = "0x9559C70", VA = "0x18955B070", Slot = "8")]
			public void VPJFEWYPXBM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x955B0F0", Offset = "0x9559CF0", VA = "0x18955B0F0")]
			public TVZANNURULU(MMDevice a, bool b)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private List<TVZANNURULU> UBRNRXUFGFD;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool RAPJGTYDAUJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xB2EAD0", Offset = "0xB2D6D0", VA = "0x180B2EAD0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x955A6C0", Offset = "0x95592C0", VA = "0x18955A6C0", Slot = "5")]
		public IReadOnlyList<AQANVZMTNDT> PLPWETHDJGV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x955A9C0", Offset = "0x95595C0", VA = "0x18955A9C0")]
		public FFJHTAIEQCU()
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

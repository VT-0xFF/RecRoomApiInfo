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
	public interface WOIHGAVRBUW
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool QNYUHAAZOEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IReadOnlyList<AQCDUBAOVRZ> GHDDKHPOHXR();
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface AQCDUBAOVRZ
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		string EXGJUDSWVUT
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		bool FYQTOYXYXHU
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		bool ENAUCCVZBXC
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "3")]
		StreamInfo QFWLMBUNJLY(Action<ArraySegment<float>> a);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void TXIDDKWLSNO();
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct StreamInfo
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int Channels
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xDB2230", Offset = "0xDB1030", VA = "0x180DB2230")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x15B1800", Offset = "0x15B0600", VA = "0x1815B1800")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int SampleRate
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x30206B0", Offset = "0x301F4B0", VA = "0x1830206B0")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x30206C0", Offset = "0x301F4C0", VA = "0x1830206C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x85F8960", Offset = "0x85F7760", VA = "0x1885F8960")]
		public StreamInfo(int sampleRate, int channels)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class StreamingAudio
	{
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static WOIHGAVRBUW RYNHOJUPOMN;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static bool QNYUHAAZOEP
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x909E740", Offset = "0x909D540", VA = "0x18909E740")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x909E7B0", Offset = "0x909D5B0", VA = "0x18909E7B0")]
		static StreamingAudio()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x909E650", Offset = "0x909D450", VA = "0x18909E650")]
		public static IReadOnlyList<AQCDUBAOVRZ> GHDDKHPOHXR()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class QAJABVPGHIC : WOIHGAVRBUW
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class MARINKZLUFG : AQCDUBAOVRZ
		{
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			[CompilerGenerated]
			private sealed class RVDZJLMSLEQ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000009")]
				public Action<ArraySegment<float>> ISCZYLVFJQU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400000A")]
				public float[] KRYFJTCOODX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400000B")]
				public int QCYQTYQUXNJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public ISampleSource ZWNEKLJCNHO;

				[Cpp2IlInjected.Token(Token = "0x600001B")]
				[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
				public RVDZJLMSLEQ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600001C")]
				[Cpp2IlInjected.Address(RVA = "0x909E4D0", Offset = "0x909D2D0", VA = "0x18909E4D0")]
				internal void ROSPXEYPAKK(object a, DataAvailableEventArgs b)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			private MMDevice YCPLLGBCHJX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			private WasapiLoopbackCapture VKFLOHPYFQN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			private SoundInSource JROJAZKZPBL;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public string EXGJUDSWVUT
			{
				[Cpp2IlInjected.Token(Token = "0x6000013")]
				[Cpp2IlInjected.Address(RVA = "0x909E0E0", Offset = "0x909CEE0", VA = "0x18909E0E0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public bool FYQTOYXYXHU
			{
				[Cpp2IlInjected.Token(Token = "0x6000014")]
				[Cpp2IlInjected.Address(RVA = "0xD79680", Offset = "0xD78480", VA = "0x180D79680", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0xC330C0", Offset = "0xC31EC0", VA = "0x180C330C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public bool ENAUCCVZBXC
			{
				[Cpp2IlInjected.Token(Token = "0x6000016")]
				[Cpp2IlInjected.Address(RVA = "0xF4C210", Offset = "0xF4B010", VA = "0x180F4C210", Slot = "6")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x909E030", Offset = "0x909CE30", VA = "0x18909E030", Slot = "7")]
			public StreamInfo QFWLMBUNJLY(Action<ArraySegment<float>> a)
			{
				return default(StreamInfo);
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x909DCA0", Offset = "0x909CAA0", VA = "0x18909DCA0")]
			private StreamInfo QFWLMBUNJLY(int a, int b, int c, Action<ArraySegment<float>> d)
			{
				return default(StreamInfo);
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x909E060", Offset = "0x909CE60", VA = "0x18909E060", Slot = "8")]
			public void TXIDDKWLSNO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x909E100", Offset = "0x909CF00", VA = "0x18909E100")]
			public MARINKZLUFG(MMDevice a, bool b)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private List<MARINKZLUFG> OIHZEKGONMD;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool QNYUHAAZOEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xAD8CA0", Offset = "0xAD7AA0", VA = "0x180AD8CA0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x909E150", Offset = "0x909CF50", VA = "0x18909E150", Slot = "5")]
		public IReadOnlyList<AQCDUBAOVRZ> GHDDKHPOHXR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x909E450", Offset = "0x909D250", VA = "0x18909E450")]
		public QAJABVPGHIC()
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

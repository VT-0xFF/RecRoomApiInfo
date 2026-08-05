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
	public interface VZLIQOYUTER
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool ISQABFDSJLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IReadOnlyList<IEJUOQEYZSS> ECYQVYUXCKC();
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface IEJUOQEYZSS
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		string AMXDXJEJKJQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		bool FQEHSRVQQNT
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		bool AVWQBHJMSYL
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "3")]
		StreamInfo UOSBEVZJDLF(Action<ArraySegment<float>> a);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void TLIXNJBNPXF();
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct StreamInfo
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int Channels
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xC6C430", Offset = "0xC6B830", VA = "0x180C6C430")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x12A3E30", Offset = "0x12A3230", VA = "0x1812A3E30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int SampleRate
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x2DAC240", Offset = "0x2DAB640", VA = "0x182DAC240")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x2DAC250", Offset = "0x2DAB650", VA = "0x182DAC250")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x82F3C60", Offset = "0x82F3060", VA = "0x1882F3C60")]
		public StreamInfo(int sampleRate, int channels)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class StreamingAudio
	{
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static VZLIQOYUTER UQDUYDWTJXC;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static bool ISQABFDSJLG
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x8D9C4D0", Offset = "0x8D9B8D0", VA = "0x188D9C4D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8D9C540", Offset = "0x8D9B940", VA = "0x188D9C540")]
		static StreamingAudio()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8D9C3E0", Offset = "0x8D9B7E0", VA = "0x188D9C3E0")]
		public static IReadOnlyList<IEJUOQEYZSS> ECYQVYUXCKC()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class FUSJTUZUCNH : VZLIQOYUTER
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class XVHWBJVBZIH : IEJUOQEYZSS
		{
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			[CompilerGenerated]
			private sealed class DGZUGYUZOOX
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000009")]
				public Action<ArraySegment<float>> QCMVESDEXDH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400000A")]
				public float[] HHUGYHOGCLS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400000B")]
				public int QNFOYSVSBFU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public ISampleSource XWEAMPUHBKZ;

				[Cpp2IlInjected.Token(Token = "0x600001B")]
				[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
				public DGZUGYUZOOX()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600001C")]
				[Cpp2IlInjected.Address(RVA = "0x8D9BEE0", Offset = "0x8D9B2E0", VA = "0x188D9BEE0")]
				internal void XXMDYEEFDRF(object a, DataAvailableEventArgs b)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			private MMDevice SXJRCUZVMYI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			private WasapiLoopbackCapture ZXTPTUXYJSE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			private SoundInSource KTKMLYNTHOQ;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public string AMXDXJEJKJQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000013")]
				[Cpp2IlInjected.Address(RVA = "0x8D9C610", Offset = "0x8D9BA10", VA = "0x188D9C610", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public bool FQEHSRVQQNT
			{
				[Cpp2IlInjected.Token(Token = "0x6000014")]
				[Cpp2IlInjected.Address(RVA = "0xC75520", Offset = "0xC74920", VA = "0x180C75520", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0xC75550", Offset = "0xC74950", VA = "0x180C75550")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public bool AVWQBHJMSYL
			{
				[Cpp2IlInjected.Token(Token = "0x6000016")]
				[Cpp2IlInjected.Address(RVA = "0xC0F2F0", Offset = "0xC0E6F0", VA = "0x180C0F2F0", Slot = "6")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8D9CA40", Offset = "0x8D9BE40", VA = "0x188D9CA40", Slot = "7")]
			public StreamInfo UOSBEVZJDLF(Action<ArraySegment<float>> a)
			{
				return default(StreamInfo);
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8D9C6B0", Offset = "0x8D9BAB0", VA = "0x188D9C6B0")]
			private StreamInfo UOSBEVZJDLF(int a, int b, int c, Action<ArraySegment<float>> d)
			{
				return default(StreamInfo);
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8D9C630", Offset = "0x8D9BA30", VA = "0x188D9C630", Slot = "8")]
			public void TLIXNJBNPXF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x594A5A0", Offset = "0x59499A0", VA = "0x18594A5A0")]
			public XVHWBJVBZIH(MMDevice a, bool b)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private List<XVHWBJVBZIH> NNQNFRANVXY;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool ISQABFDSJLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8D9C060", Offset = "0x8D9B460", VA = "0x188D9C060", Slot = "5")]
		public IReadOnlyList<IEJUOQEYZSS> ECYQVYUXCKC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8D9C360", Offset = "0x8D9B760", VA = "0x188D9C360")]
		public FUSJTUZUCNH()
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

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSCore.CoreAudioAPI;
using CSCore.SoundIn;
using CSCore.Streams;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.StreamingAudio
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public interface IStreamingAudioImplementation
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool IsSupported
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IReadOnlyList<IAudioOutputDevice> GetOutputDevices();
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface IAudioOutputDevice
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		string FriendlyName
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		bool IsDefaultDevice
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		bool IsListening
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "3")]
		StreamInfo StartListening(Action<ArraySegment<float>> callback);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void StopListening();
	}
	[StructLayout((LayoutKind)0, Size = 8)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct StreamInfo
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int Channels
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x152D40", Offset = "0x152140", VA = "0x180152D40")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x152D10", Offset = "0x152110", VA = "0x180152D10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int SampleRate
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x155D20", Offset = "0x155120", VA = "0x180155D20")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x157E00", Offset = "0x157200", VA = "0x180157E00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2EAF40", Offset = "0x2EA340", VA = "0x1802EAF40")]
		public StreamInfo(int sampleRate, int channels)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class StreamingAudio
	{
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static IStreamingAudioImplementation implementation;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static bool IsSupported
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x3024650", Offset = "0x3023A50", VA = "0x183024650")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x30245B0", Offset = "0x30239B0", VA = "0x1830245B0")]
		static StreamingAudio()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x30244C0", Offset = "0x30238C0", VA = "0x1830244C0")]
		public static IReadOnlyList<IAudioOutputDevice> GetOutputDevices()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class WindowsStreamingAudio : IStreamingAudioImplementation
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class AudioOutputDevice : IAudioOutputDevice
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			private MMDevice device;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			private WasapiLoopbackCapture _loopbackCapture;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			private SoundInSource _soundInSource;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public string FriendlyName
			{
				[Cpp2IlInjected.Token(Token = "0x6000013")]
				[Cpp2IlInjected.Address(RVA = "0x30244A0", Offset = "0x30238A0", VA = "0x1830244A0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public bool IsDefaultDevice
			{
				[Cpp2IlInjected.Token(Token = "0x6000014")]
				[Cpp2IlInjected.Address(RVA = "0x4B11C0", Offset = "0x4B05C0", VA = "0x1804B11C0", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x622D30", Offset = "0x622130", VA = "0x180622D30")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public bool IsListening
			{
				[Cpp2IlInjected.Token(Token = "0x6000016")]
				[Cpp2IlInjected.Address(RVA = "0xC64F10", Offset = "0xC64310", VA = "0x180C64F10", Slot = "6")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x30243D0", Offset = "0x30237D0", VA = "0x1830243D0", Slot = "7")]
			public StreamInfo StartListening(Action<ArraySegment<float>> callback)
			{
				return default(StreamInfo);
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x30240F0", Offset = "0x30234F0", VA = "0x1830240F0")]
			private StreamInfo StartListening(int sampleRate, int bits, int channels, Action<ArraySegment<float>> callback)
			{
				return default(StreamInfo);
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x3024400", Offset = "0x3023800", VA = "0x183024400", Slot = "8")]
			public void StopListening()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x3024460", Offset = "0x3023860", VA = "0x183024460")]
			public AudioOutputDevice(MMDevice device, bool isDefault)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private List<AudioOutputDevice> audioSources;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool IsSupported
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x3E98E0", Offset = "0x3E8CE0", VA = "0x1803E98E0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3024840", Offset = "0x3023C40", VA = "0x183024840", Slot = "5")]
		public IReadOnlyList<IAudioOutputDevice> GetOutputDevices()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3024B20", Offset = "0x3023F20", VA = "0x183024B20")]
		public WindowsStreamingAudio()
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

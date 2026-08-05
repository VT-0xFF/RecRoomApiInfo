using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using CSCore.CoreAudioAPI;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.StreamingAudio
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public interface EWHQQDCHNWC
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool IWNDNSVWFPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IReadOnlyList<NOAMEJIEICT> HTSQKITEMFR();
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface NOAMEJIEICT
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool RNYSIHZSMXA
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class StreamingAudio
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static EWHQQDCHNWC MWMRHZQHURD;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static bool IWNDNSVWFPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x8CE1EB0", Offset = "0x8CE0AB0", VA = "0x188CE1EB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8CE1F30", Offset = "0x8CE0B30", VA = "0x188CE1F30")]
		static StreamingAudio()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8CE1DC0", Offset = "0x8CE09C0", VA = "0x188CE1DC0")]
		public static IReadOnlyList<NOAMEJIEICT> HTSQKITEMFR()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class DMFAXTKDEQW : EWHQQDCHNWC
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class SELBUSYTRTG : NOAMEJIEICT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			private MMDevice IYZGPJEFMZL;

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public bool RNYSIHZSMXA
			{
				[Cpp2IlInjected.Token(Token = "0x600000A")]
				[Cpp2IlInjected.Address(RVA = "0xBAE8E0", Offset = "0xBAD4E0", VA = "0x180BAE8E0", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600000B")]
				[Cpp2IlInjected.Address(RVA = "0xA97500", Offset = "0xA96100", VA = "0x180A97500")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x1348740", Offset = "0x1347340", VA = "0x181348740")]
			public SELBUSYTRTG(MMDevice a, bool b)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private List<SELBUSYTRTG> LBTQZZPTABN;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool IWNDNSVWFPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xAB0AB0", Offset = "0xAAF6B0", VA = "0x180AB0AB0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8CE1A50", Offset = "0x8CE0650", VA = "0x188CE1A50", Slot = "5")]
		public IReadOnlyList<NOAMEJIEICT> HTSQKITEMFR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8CE1D40", Offset = "0x8CE0940", VA = "0x188CE1D40")]
		public DMFAXTKDEQW()
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

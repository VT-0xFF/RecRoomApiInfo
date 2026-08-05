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
	public interface FMZFCMRPTAD
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool TCBHLKVAUOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IReadOnlyList<QDMUUBGWQMY> GTNCEAOEJSQ();
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface QDMUUBGWQMY
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool EYMLBQBAYGD
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
		private static FMZFCMRPTAD MUZYCYCCAKC;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static bool TCBHLKVAUOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xA369A50", Offset = "0xA368450", VA = "0x18A369A50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA369AD0", Offset = "0xA3684D0", VA = "0x18A369AD0")]
		static StreamingAudio()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA369960", Offset = "0xA368360", VA = "0x18A369960")]
		public static IReadOnlyList<QDMUUBGWQMY> GTNCEAOEJSQ()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class PWMIPIPBDWD : FMZFCMRPTAD
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class IDTGBKAJWCJ : QDMUUBGWQMY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			private MMDevice LXBVZBEROFM;

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public bool EYMLBQBAYGD
			{
				[Cpp2IlInjected.Token(Token = "0x600000A")]
				[Cpp2IlInjected.Address(RVA = "0xE70C80", Offset = "0xE6F680", VA = "0x180E70C80", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600000B")]
				[Cpp2IlInjected.Address(RVA = "0xCD5F00", Offset = "0xCD4900", VA = "0x180CD5F00")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x16548F0", Offset = "0x16532F0", VA = "0x1816548F0")]
			public IDTGBKAJWCJ(MMDevice a, bool b)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private List<IDTGBKAJWCJ> FLOWGJOKEWE;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool TCBHLKVAUOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xCEBB90", Offset = "0xCEA590", VA = "0x180CEBB90", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA3695F0", Offset = "0xA367FF0", VA = "0x18A3695F0", Slot = "5")]
		public IReadOnlyList<QDMUUBGWQMY> GTNCEAOEJSQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA3698E0", Offset = "0xA3682E0", VA = "0x18A3698E0")]
		public PWMIPIPBDWD()
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

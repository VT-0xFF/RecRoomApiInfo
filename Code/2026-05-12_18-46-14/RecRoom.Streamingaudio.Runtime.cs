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
			[Cpp2IlInjected.Address(RVA = "0xA4BFC90", Offset = "0xA4BE690", VA = "0x18A4BFC90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA4BFD00", Offset = "0xA4BE700", VA = "0x18A4BFD00")]
		static StreamingAudio()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA4BFBA0", Offset = "0xA4BE5A0", VA = "0x18A4BFBA0")]
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
				[Cpp2IlInjected.Address(RVA = "0xEA8300", Offset = "0xEA6D00", VA = "0x180EA8300", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600000B")]
				[Cpp2IlInjected.Address(RVA = "0xD0EF00", Offset = "0xD0D900", VA = "0x180D0EF00")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x1684DA0", Offset = "0x16837A0", VA = "0x181684DA0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD24D80", Offset = "0xD23780", VA = "0x180D24D80", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA4BF820", Offset = "0xA4BE220", VA = "0x18A4BF820", Slot = "5")]
		public IReadOnlyList<QDMUUBGWQMY> GTNCEAOEJSQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA4BFB20", Offset = "0xA4BE520", VA = "0x18A4BFB20")]
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

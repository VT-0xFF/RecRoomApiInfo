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
	public interface JPXCPFZNZLE
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool RRKRDKCWTDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IReadOnlyList<KJLMGTLIOUT> JGIWZOGXNFB();
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface KJLMGTLIOUT
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool BTZVLHISVLY
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
		private static JPXCPFZNZLE EJWMKRXNDKZ;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static bool RRKRDKCWTDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x8E4CCD0", Offset = "0x8E4B6D0", VA = "0x188E4CCD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8E4CD40", Offset = "0x8E4B740", VA = "0x188E4CD40")]
		static StreamingAudio()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8E4CBE0", Offset = "0x8E4B5E0", VA = "0x188E4CBE0")]
		public static IReadOnlyList<KJLMGTLIOUT> JGIWZOGXNFB()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class ALHEPHUPEFA : JPXCPFZNZLE
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class KLBMEAPQOWQ : KJLMGTLIOUT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			private MMDevice SEIIDUUHMAR;

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public bool BTZVLHISVLY
			{
				[Cpp2IlInjected.Token(Token = "0x600000A")]
				[Cpp2IlInjected.Address(RVA = "0xBF80A0", Offset = "0xBF6AA0", VA = "0x180BF80A0", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600000B")]
				[Cpp2IlInjected.Address(RVA = "0xAB99A0", Offset = "0xAB83A0", VA = "0x180AB99A0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x13879C0", Offset = "0x13863C0", VA = "0x1813879C0")]
			public KLBMEAPQOWQ(MMDevice a, bool b)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private List<KLBMEAPQOWQ> RHOXCECACML;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool RRKRDKCWTDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xAD13F0", Offset = "0xACFDF0", VA = "0x180AD13F0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8E4C860", Offset = "0x8E4B260", VA = "0x188E4C860", Slot = "5")]
		public IReadOnlyList<KJLMGTLIOUT> JGIWZOGXNFB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8E4CB60", Offset = "0x8E4B560", VA = "0x188E4CB60")]
		public ALHEPHUPEFA()
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

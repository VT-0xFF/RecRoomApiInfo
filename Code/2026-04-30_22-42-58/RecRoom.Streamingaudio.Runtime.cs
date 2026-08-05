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
	public interface UHVKBGXZLCV
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool CTJXZBRPUXC
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IReadOnlyList<KUHIVJWWMNA> NWXMBPHKZCG();
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface KUHIVJWWMNA
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool MGNYNQIMOUN
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
		private static UHVKBGXZLCV UZYCQQXLHCU;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static bool CTJXZBRPUXC
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xA2B4350", Offset = "0xA2B3750", VA = "0x18A2B4350")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA2B44B0", Offset = "0xA2B38B0", VA = "0x18A2B44B0")]
		static StreamingAudio()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA2B43C0", Offset = "0xA2B37C0", VA = "0x18A2B43C0")]
		public static IReadOnlyList<KUHIVJWWMNA> NWXMBPHKZCG()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class HBVWMYCYYQZ : UHVKBGXZLCV
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class FMLFNXSMPBF : KUHIVJWWMNA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			private MMDevice HCFDFGYDMUY;

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public bool MGNYNQIMOUN
			{
				[Cpp2IlInjected.Token(Token = "0x600000A")]
				[Cpp2IlInjected.Address(RVA = "0xEABB30", Offset = "0xEAAF30", VA = "0x180EABB30", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600000B")]
				[Cpp2IlInjected.Address(RVA = "0xCF6C00", Offset = "0xCF6000", VA = "0x180CF6C00")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x166A7B0", Offset = "0x1669BB0", VA = "0x18166A7B0")]
			public FMLFNXSMPBF(MMDevice a, bool b)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private List<FMLFNXSMPBF> RFDXXADLSCO;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool CTJXZBRPUXC
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xD0EDD0", Offset = "0xD0E1D0", VA = "0x180D0EDD0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA2B3FD0", Offset = "0xA2B33D0", VA = "0x18A2B3FD0", Slot = "5")]
		public IReadOnlyList<KUHIVJWWMNA> NWXMBPHKZCG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA2B42D0", Offset = "0xA2B36D0", VA = "0x18A2B42D0")]
		public HBVWMYCYYQZ()
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

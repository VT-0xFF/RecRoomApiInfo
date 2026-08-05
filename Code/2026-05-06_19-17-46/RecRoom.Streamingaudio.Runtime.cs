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
			[Cpp2IlInjected.Address(RVA = "0xA390BB0", Offset = "0xA38F5B0", VA = "0x18A390BB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA390D20", Offset = "0xA38F720", VA = "0x18A390D20")]
		static StreamingAudio()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA390C30", Offset = "0xA38F630", VA = "0x18A390C30")]
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
				[Cpp2IlInjected.Address(RVA = "0xE90550", Offset = "0xE8EF50", VA = "0x180E90550", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600000B")]
				[Cpp2IlInjected.Address(RVA = "0xCD8BE0", Offset = "0xCD75E0", VA = "0x180CD8BE0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x1659470", Offset = "0x1657E70", VA = "0x181659470")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF0C20", Offset = "0xCEF620", VA = "0x180CF0C20", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA390840", Offset = "0xA38F240", VA = "0x18A390840", Slot = "5")]
		public IReadOnlyList<KUHIVJWWMNA> NWXMBPHKZCG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA390B30", Offset = "0xA38F530", VA = "0x18A390B30")]
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

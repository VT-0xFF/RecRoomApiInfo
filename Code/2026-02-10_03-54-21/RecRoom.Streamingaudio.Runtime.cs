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
	public interface WJHKZEFBQHB
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool FGPEKGFOFTI
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IReadOnlyList<NIHRDSAHSAY> GQEJQAXYYTS();
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface NIHRDSAHSAY
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool IFKIYDODQPZ
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
		private static WJHKZEFBQHB DGTFABXVQQG;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static bool FGPEKGFOFTI
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x8F440D0", Offset = "0x8F432D0", VA = "0x188F440D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8F44140", Offset = "0x8F43340", VA = "0x188F44140")]
		static StreamingAudio()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8F43FE0", Offset = "0x8F431E0", VA = "0x188F43FE0")]
		public static IReadOnlyList<NIHRDSAHSAY> GQEJQAXYYTS()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class YDFVNLNJNQP : WJHKZEFBQHB
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class QKFDYFAMNSN : NIHRDSAHSAY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			private MMDevice GEUCQZKTXPM;

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public bool IFKIYDODQPZ
			{
				[Cpp2IlInjected.Token(Token = "0x600000A")]
				[Cpp2IlInjected.Address(RVA = "0xC56780", Offset = "0xC55980", VA = "0x180C56780", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600000B")]
				[Cpp2IlInjected.Address(RVA = "0xABAEE0", Offset = "0xABA0E0", VA = "0x180ABAEE0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x13F92E0", Offset = "0x13F84E0", VA = "0x1813F92E0")]
			public QKFDYFAMNSN(MMDevice a, bool b)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private List<QKFDYFAMNSN> VYFHTPPZKEQ;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool FGPEKGFOFTI
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xAD1330", Offset = "0xAD0530", VA = "0x180AD1330", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8F44210", Offset = "0x8F43410", VA = "0x188F44210", Slot = "5")]
		public IReadOnlyList<NIHRDSAHSAY> GQEJQAXYYTS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8F44500", Offset = "0x8F43700", VA = "0x188F44500")]
		public YDFVNLNJNQP()
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

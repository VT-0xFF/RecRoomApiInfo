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
	public interface BSCMKIAHMMB
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool CZNJXPHTYXO
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IReadOnlyList<XBFLBYPMGMO> MRCDVNWKZEO();
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface XBFLBYPMGMO
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool MVNQITPPLKZ
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
		private static BSCMKIAHMMB VLGTINZOLTO;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static bool CZNJXPHTYXO
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x8D1A760", Offset = "0x8D19B60", VA = "0x188D1A760")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8D1A7D0", Offset = "0x8D19BD0", VA = "0x188D1A7D0")]
		static StreamingAudio()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8D1A670", Offset = "0x8D19A70", VA = "0x188D1A670")]
		public static IReadOnlyList<XBFLBYPMGMO> MRCDVNWKZEO()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class XEJTGIZDLWF : BSCMKIAHMMB
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class AOJZHCHNLKX : XBFLBYPMGMO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			private MMDevice OLRTZNRTCXO;

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public bool MVNQITPPLKZ
			{
				[Cpp2IlInjected.Token(Token = "0x600000A")]
				[Cpp2IlInjected.Address(RVA = "0xBFA2C0", Offset = "0xBF96C0", VA = "0x180BFA2C0", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600000B")]
				[Cpp2IlInjected.Address(RVA = "0xAAC1E0", Offset = "0xAAB5E0", VA = "0x180AAC1E0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x1371790", Offset = "0x1370B90", VA = "0x181371790")]
			public AOJZHCHNLKX(MMDevice a, bool b)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private List<AOJZHCHNLKX> YQVXWDKVVQS;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool CZNJXPHTYXO
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xABDC90", Offset = "0xABD090", VA = "0x180ABDC90", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8D1A8A0", Offset = "0x8D19CA0", VA = "0x188D1A8A0", Slot = "5")]
		public IReadOnlyList<XBFLBYPMGMO> MRCDVNWKZEO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8D1ABA0", Offset = "0x8D19FA0", VA = "0x188D1ABA0")]
		public XEJTGIZDLWF()
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

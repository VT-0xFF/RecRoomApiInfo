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
	public interface SCSVZAZLDZN
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool BDXGMMCVPMS
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IReadOnlyList<EJXOZCZAVKU> XAQVNJJSNYA();
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface EJXOZCZAVKU
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool FNGCYDNTVKT
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
		private static SCSVZAZLDZN FJDSZVDTKHM;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static bool BDXGMMCVPMS
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xA382FF0", Offset = "0xA3819F0", VA = "0x18A382FF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA383160", Offset = "0xA381B60", VA = "0x18A383160")]
		static StreamingAudio()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA383070", Offset = "0xA381A70", VA = "0x18A383070")]
		public static IReadOnlyList<EJXOZCZAVKU> XAQVNJJSNYA()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class GFIGCZINTCX : SCSVZAZLDZN
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class UCWAUYBOSFX : EJXOZCZAVKU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			private MMDevice IZJDPDRLNQO;

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public bool FNGCYDNTVKT
			{
				[Cpp2IlInjected.Token(Token = "0x600000A")]
				[Cpp2IlInjected.Address(RVA = "0xEA3E30", Offset = "0xEA2830", VA = "0x180EA3E30", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600000B")]
				[Cpp2IlInjected.Address(RVA = "0xCFD470", Offset = "0xCFBE70", VA = "0x180CFD470")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x1642370", Offset = "0x1640D70", VA = "0x181642370")]
			public UCWAUYBOSFX(MMDevice a, bool b)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private List<UCWAUYBOSFX> NHFFAYNMZMQ;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool BDXGMMCVPMS
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD085A0", VA = "0x180D09BA0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA382C80", Offset = "0xA381680", VA = "0x18A382C80", Slot = "5")]
		public IReadOnlyList<EJXOZCZAVKU> XAQVNJJSNYA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA382F70", Offset = "0xA381970", VA = "0x18A382F70")]
		public GFIGCZINTCX()
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

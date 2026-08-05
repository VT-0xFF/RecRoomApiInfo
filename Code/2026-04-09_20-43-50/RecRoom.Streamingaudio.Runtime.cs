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
			[Cpp2IlInjected.Address(RVA = "0xA525D40", Offset = "0xA524D40", VA = "0x18A525D40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA525EB0", Offset = "0xA524EB0", VA = "0x18A525EB0")]
		static StreamingAudio()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA525DC0", Offset = "0xA524DC0", VA = "0x18A525DC0")]
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
				[Cpp2IlInjected.Address(RVA = "0xEBF620", Offset = "0xEBE620", VA = "0x180EBF620", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600000B")]
				[Cpp2IlInjected.Address(RVA = "0xD18620", Offset = "0xD17620", VA = "0x180D18620")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x165DEB0", Offset = "0x165CEB0", VA = "0x18165DEB0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD24DB0", Offset = "0xD23DB0", VA = "0x180D24DB0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA5259C0", Offset = "0xA5249C0", VA = "0x18A5259C0", Slot = "5")]
		public IReadOnlyList<EJXOZCZAVKU> XAQVNJJSNYA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA525CC0", Offset = "0xA524CC0", VA = "0x18A525CC0")]
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

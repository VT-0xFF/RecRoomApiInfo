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
	public interface RUMALBMIDEB
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool AJSWRFAVODK
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IReadOnlyList<QFNZOSIJUYS> YHJFSFUUJPM();
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface QFNZOSIJUYS
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool GMSRNTPGDJP
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
		private static RUMALBMIDEB NWESVTIDJKE;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static bool AJSWRFAVODK
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xA4F5DB0", Offset = "0xA4F47B0", VA = "0x18A4F5DB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA4F5F20", Offset = "0xA4F4920", VA = "0x18A4F5F20")]
		static StreamingAudio()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA4F5E30", Offset = "0xA4F4830", VA = "0x18A4F5E30")]
		public static IReadOnlyList<QFNZOSIJUYS> YHJFSFUUJPM()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class HEGBWUGZYSF : RUMALBMIDEB
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class BLGHIWBXHOT : QFNZOSIJUYS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			private MMDevice HLXHETCPSBW;

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public bool GMSRNTPGDJP
			{
				[Cpp2IlInjected.Token(Token = "0x600000A")]
				[Cpp2IlInjected.Address(RVA = "0xEC57F0", Offset = "0xEC41F0", VA = "0x180EC57F0", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600000B")]
				[Cpp2IlInjected.Address(RVA = "0xD14CD0", Offset = "0xD136D0", VA = "0x180D14CD0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x1690750", Offset = "0x168F150", VA = "0x181690750")]
			public BLGHIWBXHOT(MMDevice a, bool b)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private List<BLGHIWBXHOT> OPAVEMHJKIK;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool AJSWRFAVODK
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA4F5A30", Offset = "0xA4F4430", VA = "0x18A4F5A30", Slot = "5")]
		public IReadOnlyList<QFNZOSIJUYS> YHJFSFUUJPM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA4F5D30", Offset = "0xA4F4730", VA = "0x18A4F5D30")]
		public HEGBWUGZYSF()
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

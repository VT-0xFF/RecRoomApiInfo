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
	public interface KTIIWOACEVT
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool QQZJZQHAUZO
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IReadOnlyList<DRIAXBANHCC> MHXFUJNQAHQ();
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface DRIAXBANHCC
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool XWAGEVWEOQN
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
		private static KTIIWOACEVT SPUCJVYZSLW;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static bool QQZJZQHAUZO
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xA4E2620", Offset = "0xA4E1620", VA = "0x18A4E2620")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA4E26A0", Offset = "0xA4E16A0", VA = "0x18A4E26A0")]
		static StreamingAudio()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA4E2530", Offset = "0xA4E1530", VA = "0x18A4E2530")]
		public static IReadOnlyList<DRIAXBANHCC> MHXFUJNQAHQ()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class QSJDYQZYRGR : KTIIWOACEVT
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class SWWTUQNKTVV : DRIAXBANHCC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			private MMDevice MJEKSMVXCAA;

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public bool XWAGEVWEOQN
			{
				[Cpp2IlInjected.Token(Token = "0x600000A")]
				[Cpp2IlInjected.Address(RVA = "0xEBB680", Offset = "0xEBA680", VA = "0x180EBB680", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600000B")]
				[Cpp2IlInjected.Address(RVA = "0xCFDEE0", Offset = "0xCFCEE0", VA = "0x180CFDEE0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x1648130", Offset = "0x1647130", VA = "0x181648130")]
			public SWWTUQNKTVV(MMDevice a, bool b)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private List<SWWTUQNKTVV> XABBVOGLTLY;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool QQZJZQHAUZO
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xD0FC20", Offset = "0xD0EC20", VA = "0x180D0FC20", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA4E21B0", Offset = "0xA4E11B0", VA = "0x18A4E21B0", Slot = "5")]
		public IReadOnlyList<DRIAXBANHCC> MHXFUJNQAHQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA4E24B0", Offset = "0xA4E14B0", VA = "0x18A4E24B0")]
		public QSJDYQZYRGR()
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

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
	public interface IYVHCTXCXCW
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool AZACHEIVZZF
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IReadOnlyList<IYLBMWGWNVF> WILEHSCTOOL();
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface IYLBMWGWNVF
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool KHCBUQUGWBQ
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
		private static IYVHCTXCXCW HYKNJZXIWBX;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static bool AZACHEIVZZF
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x8E0C8F0", Offset = "0x8E0B0F0", VA = "0x188E0C8F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8E0CA50", Offset = "0x8E0B250", VA = "0x188E0CA50")]
		static StreamingAudio()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8E0C960", Offset = "0x8E0B160", VA = "0x188E0C960")]
		public static IReadOnlyList<IYLBMWGWNVF> WILEHSCTOOL()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class LNKSRQCYTTY : IYVHCTXCXCW
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class BKEDTKFCFAI : IYLBMWGWNVF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			private MMDevice BJBWBJPFDSJ;

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public bool KHCBUQUGWBQ
			{
				[Cpp2IlInjected.Token(Token = "0x600000A")]
				[Cpp2IlInjected.Address(RVA = "0xC19AA0", Offset = "0xC182A0", VA = "0x180C19AA0", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600000B")]
				[Cpp2IlInjected.Address(RVA = "0xAB0610", Offset = "0xAAEE10", VA = "0x180AB0610")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x13A8070", Offset = "0x13A6870", VA = "0x1813A8070")]
			public BKEDTKFCFAI(MMDevice a, bool b)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private List<BKEDTKFCFAI> ZIAPNIQYNXJ;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool AZACHEIVZZF
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xAC7BA0", Offset = "0xAC63A0", VA = "0x180AC7BA0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8E0C580", Offset = "0x8E0AD80", VA = "0x188E0C580", Slot = "5")]
		public IReadOnlyList<IYLBMWGWNVF> WILEHSCTOOL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8E0C870", Offset = "0x8E0B070", VA = "0x188E0C870")]
		public LNKSRQCYTTY()
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

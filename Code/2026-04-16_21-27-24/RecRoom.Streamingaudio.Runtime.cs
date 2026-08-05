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
	public interface QHQWPNYRRSY
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool DFPAQLCWDXL
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IReadOnlyList<GPFPQMFZBLX> MJGVJOZNXNL();
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface GPFPQMFZBLX
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool ETFGYQHHGHG
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
		private static QHQWPNYRRSY GFAUAXWHGGP;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static bool DFPAQLCWDXL
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xA36B650", Offset = "0xA36A450", VA = "0x18A36B650")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA36B7C0", Offset = "0xA36A5C0", VA = "0x18A36B7C0")]
		static StreamingAudio()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA36B6D0", Offset = "0xA36A4D0", VA = "0x18A36B6D0")]
		public static IReadOnlyList<GPFPQMFZBLX> MJGVJOZNXNL()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class TKRFVONGGQU : QHQWPNYRRSY
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class INTGQBUEBNA : GPFPQMFZBLX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			private MMDevice LHUGQTQLRBB;

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public bool ETFGYQHHGHG
			{
				[Cpp2IlInjected.Token(Token = "0x600000A")]
				[Cpp2IlInjected.Address(RVA = "0xE92720", Offset = "0xE91520", VA = "0x180E92720", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600000B")]
				[Cpp2IlInjected.Address(RVA = "0xCEFF90", Offset = "0xCEED90", VA = "0x180CEFF90")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x1637AD0", Offset = "0x16368D0", VA = "0x181637AD0")]
			public INTGQBUEBNA(MMDevice a, bool b)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private List<INTGQBUEBNA> SXMVPXVFRJT;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool DFPAQLCWDXL
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xD00B10", Offset = "0xCFF910", VA = "0x180D00B10", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA36B8A0", Offset = "0xA36A6A0", VA = "0x18A36B8A0", Slot = "5")]
		public IReadOnlyList<GPFPQMFZBLX> MJGVJOZNXNL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA36BB90", Offset = "0xA36A990", VA = "0x18A36BB90")]
		public TKRFVONGGQU()
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

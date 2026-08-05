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
	public interface QJURVMVJOJA
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool PRCABTUAGOT
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IReadOnlyList<ZWQOHUJGMWL> LPUZSBHBKLF();
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface ZWQOHUJGMWL
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool EYKBAJZMRLE
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
		private static QJURVMVJOJA EGXHIMNUEPP;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static bool PRCABTUAGOT
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x8FB0D10", Offset = "0x8FAFD10", VA = "0x188FB0D10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8FB0E70", Offset = "0x8FAFE70", VA = "0x188FB0E70")]
		static StreamingAudio()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8FB0D80", Offset = "0x8FAFD80", VA = "0x188FB0D80")]
		public static IReadOnlyList<ZWQOHUJGMWL> LPUZSBHBKLF()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class QJSESEHCQJE : QJURVMVJOJA
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class TGNGYBIURIM : ZWQOHUJGMWL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			private MMDevice MXTGQEQLHHT;

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public bool EYKBAJZMRLE
			{
				[Cpp2IlInjected.Token(Token = "0x600000A")]
				[Cpp2IlInjected.Address(RVA = "0xC35BD0", Offset = "0xC34BD0", VA = "0x180C35BD0", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600000B")]
				[Cpp2IlInjected.Address(RVA = "0xAD0090", Offset = "0xACF090", VA = "0x180AD0090")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x13F1050", Offset = "0x13F0050", VA = "0x1813F1050")]
			public TGNGYBIURIM(MMDevice a, bool b)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private List<TGNGYBIURIM> ERADZMGHRZZ;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool PRCABTUAGOT
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xAE6390", Offset = "0xAE5390", VA = "0x180AE6390", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8FB0990", Offset = "0x8FAF990", VA = "0x188FB0990", Slot = "5")]
		public IReadOnlyList<ZWQOHUJGMWL> LPUZSBHBKLF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8FB0C90", Offset = "0x8FAFC90", VA = "0x188FB0C90")]
		public QJSESEHCQJE()
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

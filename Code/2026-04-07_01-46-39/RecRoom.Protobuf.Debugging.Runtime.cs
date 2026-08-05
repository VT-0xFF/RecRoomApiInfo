using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Newtonsoft.Json;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Protobuf.Utilities
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public static class KYYLIXWCRKV
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static JsonConverter ONWWQVLBOJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x9DBF740", Offset = "0x9DBE740", VA = "0x189DBF740")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static JsonConverter OUIGJAGALMT
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x9DBF830", Offset = "0x9DBE830", VA = "0x189DBF830")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static JsonConverter AVBVQBEACSY
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x9DBF790", Offset = "0x9DBE790", VA = "0x189DBF790")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static JsonConverter BLHNDSRSNJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x9DBF7E0", Offset = "0x9DBE7E0", VA = "0x189DBF7E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
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

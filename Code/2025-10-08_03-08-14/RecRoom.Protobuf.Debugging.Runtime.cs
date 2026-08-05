using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Newtonsoft.Json;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Protobuf.Utilities
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public static class PLWFZRHERXK
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static JsonConverter FRAWTYHSFRW
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x898BF80", Offset = "0x898AD80", VA = "0x18898BF80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static JsonConverter WGLKSSWAPQM
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x898BFD0", Offset = "0x898ADD0", VA = "0x18898BFD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static JsonConverter BRXRTSONUYH
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x898C070", Offset = "0x898AE70", VA = "0x18898C070")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static JsonConverter IWJPEIACACV
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x898C020", Offset = "0x898AE20", VA = "0x18898C020")]
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

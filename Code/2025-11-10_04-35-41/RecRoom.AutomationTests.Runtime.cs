using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Core.Testing
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public static class RJNKGPYDHUI
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool AWSYIIMZJCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x80AD890", Offset = "0x80ACC90", VA = "0x1880AD890")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static bool ZXOJHTIEUWE
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x80AD8E0", Offset = "0x80ACCE0", VA = "0x1880AD8E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static bool CIBUSTUVYSN
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x80AD7B0", Offset = "0x80ACBB0", VA = "0x1880AD7B0")]
			get
			{
				return default(bool);
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

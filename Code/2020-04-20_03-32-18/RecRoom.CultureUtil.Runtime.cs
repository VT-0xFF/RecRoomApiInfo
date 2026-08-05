using System;
using System.Globalization;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public static class CultureUtil
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static char? _decimalSeparatorChar;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static string _decimalSeparatorString;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static CultureInfo CurrentCultureInfo
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x296F8D0", Offset = "0x296DED0", VA = "0x18296F8D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static char DecimalSeparatorChar
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x296FB00", Offset = "0x296E100", VA = "0x18296FB00")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static string DecimalSeparatorString
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x296FB50", Offset = "0x296E150", VA = "0x18296FB50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x296F920", Offset = "0x296DF20", VA = "0x18296F920")]
		public static bool TryParseFloat(string inputString, out float floatVal)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x296F8D0", Offset = "0x296DED0", VA = "0x18296F8D0")]
		private static CultureInfo GetCurrentSupportedCulture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x296F9A0", Offset = "0x296DFA0", VA = "0x18296F9A0")]
		private static void UpdateFloatParsingValues()
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

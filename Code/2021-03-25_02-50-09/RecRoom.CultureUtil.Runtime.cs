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
			[Cpp2IlInjected.Address(RVA = "0x333DC60", Offset = "0x333C460", VA = "0x18333DC60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static char DecimalSeparatorChar
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x333DE60", Offset = "0x333C660", VA = "0x18333DE60")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static string DecimalSeparatorString
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x333DEB0", Offset = "0x333C6B0", VA = "0x18333DEB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x333DCB0", Offset = "0x333C4B0", VA = "0x18333DCB0")]
		public static bool TryParseFloat(string inputString, out float floatVal)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x333DC60", Offset = "0x333C460", VA = "0x18333DC60")]
		private static CultureInfo GetCurrentSupportedCulture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x333DD30", Offset = "0x333C530", VA = "0x18333DD30")]
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

using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public static class FYHEBDIPCUO
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static CultureInfo JHDVOUKOJKR
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x97C9A40", Offset = "0x97C8640", VA = "0x1897C9A40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x97C9A80", Offset = "0x97C8680", VA = "0x1897C9A80")]
		public static bool FILWSMDFHWK(string a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x97C9A40", Offset = "0x97C8640", VA = "0x1897C9A40")]
		private static CultureInfo FIHDPWZRTKB()
		{
			return null;
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

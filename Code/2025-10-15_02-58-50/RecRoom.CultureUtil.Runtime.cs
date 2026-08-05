using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public static class MVVMZFMWFWD
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static CultureInfo FZRNTFYGIIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x83FFD40", Offset = "0x83FEB40", VA = "0x1883FFD40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x83FFD80", Offset = "0x83FEB80", VA = "0x1883FFD80")]
		public static bool ZHSUBUUDPEP(string a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x83FFD40", Offset = "0x83FEB40", VA = "0x1883FFD40")]
		private static CultureInfo TFWVGQQSJMS()
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

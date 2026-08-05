using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecNet;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Keepsakes
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public static class NNMSAOHTWCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x97FE270", Offset = "0x97FD670", VA = "0x1897FE270")]
		public static KeepsakeTheme IWWEDNXEWCQ(this SYUKJTIAKJJ a, Guid b)
		{
			return default(KeepsakeTheme);
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x97FE370", Offset = "0x97FD770", VA = "0x1897FE370")]
		public static KeepsakeTheme IWWEDNXEWCQ(this SYUKJTIAKJJ a, KeepsakeCategory b)
		{
			return default(KeepsakeTheme);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x97FE1A0", Offset = "0x97FD5A0", VA = "0x1897FE1A0")]
		public static List<KeepsakeTheme> DGDVHSRFCMK(this SYUKJTIAKJJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x97FE430", Offset = "0x97FD830", VA = "0x1897FE430")]
		public static KeepsakeCategory PPKIHPKEHUT(this SYUKJTIAKJJ a, Guid b)
		{
			return default(KeepsakeCategory);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x97FE4D0", Offset = "0x97FD8D0", VA = "0x1897FE4D0")]
		public static int QEKYVRPYTJH(this SYUKJTIAKJJ a, KeepsakeCategory b)
		{
			return default(int);
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

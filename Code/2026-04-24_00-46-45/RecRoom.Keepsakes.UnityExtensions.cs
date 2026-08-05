using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecNet;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Keepsakes
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public static class UQKEFSNDVXD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x9A2CFE0", Offset = "0x9A2B9E0", VA = "0x189A2CFE0")]
		public static KeepsakeTheme MTRNHGTQVGE(this YKTFSXJKYBJ a, Guid b)
		{
			return default(KeepsakeTheme);
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9A2CF30", Offset = "0x9A2B930", VA = "0x189A2CF30")]
		public static KeepsakeTheme MTRNHGTQVGE(this YKTFSXJKYBJ a, KeepsakeCategory b)
		{
			return default(KeepsakeTheme);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9A2CE70", Offset = "0x9A2B870", VA = "0x189A2CE70")]
		public static List<KeepsakeTheme> BRTXTLEVFXI(this YKTFSXJKYBJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9A2D0E0", Offset = "0x9A2BAE0", VA = "0x189A2D0E0")]
		public static KeepsakeCategory QDEFPFIYJMD(this YKTFSXJKYBJ a, Guid b)
		{
			return default(KeepsakeCategory);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9A2D180", Offset = "0x9A2BB80", VA = "0x189A2D180")]
		public static int XMMKWHEPODX(this YKTFSXJKYBJ a, KeepsakeCategory b)
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

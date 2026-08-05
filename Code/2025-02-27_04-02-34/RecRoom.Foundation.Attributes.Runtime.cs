using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
public class ILHBJDHFKPO : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x975680", Offset = "0x974A80", VA = "0x180975680")]
	public ILHBJDHFKPO(string JIAJKCJJONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x74605B0", Offset = "0x745F9B0", VA = "0x1874605B0")]
	public ILHBJDHFKPO(Type BMIPLDLMPCD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
public class LDBBKAIEOAF : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x9748B0", Offset = "0x973CB0", VA = "0x1809748B0")]
	public LDBBKAIEOAF(Type BMIPLDLMPCD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Method)]
public sealed class LAHMMLMGGEA : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x9748B0", Offset = "0x973CB0", VA = "0x1809748B0")]
	public LAHMMLMGGEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Method)]
public sealed class FGKACNBLIFF : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x9748B0", Offset = "0x973CB0", VA = "0x1809748B0")]
	public FGKACNBLIFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class EDNMIOGDLLP : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x9748B0", Offset = "0x973CB0", VA = "0x1809748B0")]
	public EDNMIOGDLLP()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class OKEBKGOCPLK
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	public OKEBKGOCPLK()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
	{
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

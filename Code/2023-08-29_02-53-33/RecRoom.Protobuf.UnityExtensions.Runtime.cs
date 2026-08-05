using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class MFPBCNGOAPF
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6FA9540", Offset = "0x6FA8940", VA = "0x186FA9540")]
	public static MIEDKGKKNIP IBKPGJDIIJI(this in Color JCOLBAAGCGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6FA95E0", Offset = "0x6FA89E0", VA = "0x186FA95E0")]
	public static Color LFPLIBEJFBF(this MIEDKGKKNIP JCOLBAAGCGE)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6FA9420", Offset = "0x6FA8820", VA = "0x186FA9420")]
	public static Color? HBFOCBFNBPO(this MIEDKGKKNIP JCOLBAAGCGE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class BCPDKBBCOEM
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6FA90C0", Offset = "0x6FA84C0", VA = "0x186FA90C0")]
	public static PIBHALNGDMM IBKPGJDIIJI(this in Quaternion JCOLBAAGCGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6FA9160", Offset = "0x6FA8560", VA = "0x186FA9160")]
	public static Quaternion LFPLIBEJFBF(this PIBHALNGDMM JCOLBAAGCGE)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6FA8FA0", Offset = "0x6FA83A0", VA = "0x186FA8FA0")]
	public static Quaternion? HBFOCBFNBPO(this PIBHALNGDMM JCOLBAAGCGE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class AHECHHGGDHP
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6FA8C40", Offset = "0x6FA8040", VA = "0x186FA8C40")]
	public static Quaternion BKNBHDJPCFD(AMGJFOOIJEB KJFNAECAHBA)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6FA8E50", Offset = "0x6FA8250", VA = "0x186FA8E50")]
	public static IKBMHMGOOFG NLHGJGPMFPO(Quaternion MBPLHNIBPIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6FA8F00", Offset = "0x6FA8300", VA = "0x186FA8F00")]
	public static Quaternion PHPMAOCGOGH(IKBMHMGOOFG KJFNAECAHBA)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class FBDDILIACPF
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6FA92F0", Offset = "0x6FA86F0", VA = "0x186FA92F0")]
	public static IKBMHMGOOFG IBKPGJDIIJI(this in Vector3 JCOLBAAGCGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6FA9380", Offset = "0x6FA8780", VA = "0x186FA9380")]
	public static Vector3 LFPLIBEJFBF(this IKBMHMGOOFG JCOLBAAGCGE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6FA9230", Offset = "0x6FA8630", VA = "0x186FA9230")]
	public static Vector3? HBFOCBFNBPO(this IKBMHMGOOFG JCOLBAAGCGE)
	{
		return null;
	}
}
namespace Cpp2IlInjected;

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

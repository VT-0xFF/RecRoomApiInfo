using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate | AttributeTargets.GenericParameter)]
public sealed class BNJBOLPELGJ : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780")]
	public BNJBOLPELGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Parameter | AttributeTargets.GenericParameter)]
public sealed class BJEBNHKJEDJ : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1072350", Offset = "0x1071750", VA = "0x181072350")]
	public BJEBNHKJEDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1072380", Offset = "0x1071780", VA = "0x181072380")]
	public BJEBNHKJEDJ(HIMHNPKJIDK GLIGILGBKCA, BLKPGBLKGGP FEPBMEFEAIA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[Flags]
public enum HIMHNPKJIDK
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Default = 7,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Access = 1,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Assign = 2,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	InstantiatedWithFixedConstructorSignature = 4,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	InstantiatedNoFixedConstructorSignature = 8
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[Flags]
public enum BLKPGBLKGGP
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Default = 1,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	Itself = 1,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	Members = 2,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	WithInheritors = 4,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	WithMembers = 3
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

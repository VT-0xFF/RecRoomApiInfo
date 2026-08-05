using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[Flags]
public enum NKKFOJIBKNG
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Release = 1,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Debug = 2,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Promo = 4,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	All = 7
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum)]
public class JBPFIGNFLBL : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly Type GFGNJCOEBMN;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x64F4570", Offset = "0x64F3170", VA = "0x1864F4570")]
	public JBPFIGNFLBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x86E660", Offset = "0x86D260", VA = "0x18086E660")]
	public JBPFIGNFLBL(Type EBDAHODFHFD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Field)]
public class HAPDLPFKENC : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x86D6A0", Offset = "0x86C2A0", VA = "0x18086D6A0")]
	public HAPDLPFKENC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
[HBMEAIGGPID]
public class GDAEHKCCINB : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly string EGAJMAOKAOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly NKKFOJIBKNG GLKBGPLEMNC;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5B38810", Offset = "0x5B37410", VA = "0x185B38810")]
	public GDAEHKCCINB(string PFBIGDBHOHF, NKKFOJIBKNG ONHCCDONKAK = NKKFOJIBKNG.All)
	{
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

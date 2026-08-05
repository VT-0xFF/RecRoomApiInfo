using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[Flags]
public enum DAALIKBJMPJ
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
public class DCGGHMFAHHI : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly Type AJANMFMONLG;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5ABDC00", Offset = "0x5ABCA00", VA = "0x185ABDC00")]
	public DCGGHMFAHHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x799B60", Offset = "0x798960", VA = "0x180799B60")]
	public DCGGHMFAHHI(Type IGFCFGPLHFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Field)]
public class KMMMEEOHGOM : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7997A0", Offset = "0x7985A0", VA = "0x1807997A0")]
	public KMMMEEOHGOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
[AMCMKIOIJNL]
public class BFMPKFMAIJF : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly string BPLNDEBILEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly DAALIKBJMPJ MBHAHALBIKN;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x514F6F0", Offset = "0x514E4F0", VA = "0x18514F6F0")]
	public BFMPKFMAIJF(string FHBNFIMPDGK, DAALIKBJMPJ IDFDPMJDEOA = DAALIKBJMPJ.All)
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

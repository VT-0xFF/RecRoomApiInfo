using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class DKPDMABDAHO
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface JPJJFDLJDCD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x31460F0", Offset = "0x3144EF0", VA = "0x1831460F0")]
	public static T KDPDNGJLHPJ<T>(this T DJAJDIFOIHP) where T : UnityEngine.Object
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3146150", Offset = "0x3144F50", VA = "0x183146150")]
	public static T KHGMDELBJLP<T>(this T DJAJDIFOIHP) where T : class, JPJJFDLJDCD
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3146030", Offset = "0x3144E30", VA = "0x183146030")]
	public static void IDHHBGHGMHA<T>(T DJAJDIFOIHP, T LHMPMCLNOPG) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x31461E0", Offset = "0x3144FE0", VA = "0x1831461E0")]
	public static bool MGHGBCONHGP<T>(this T JOOHPPHJKMI) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x72A43A0", Offset = "0x72A31A0", VA = "0x1872A43A0")]
	public static string OPKHAJFFJFG(this UnityEngine.Object JOOHPPHJKMI)
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

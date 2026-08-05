using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class DCKMFHENDEB
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface EMJMHBNILDJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x29E62E0", Offset = "0x29E48E0", VA = "0x1829E62E0")]
	public static T BLNNBDPDMDB<T>(this T HLIDMKMINHN) where T : UnityEngine.Object
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x29E6250", Offset = "0x29E4850", VA = "0x1829E6250")]
	public static T ACHENNOKPKF<T>(this T HLIDMKMINHN) where T : class, EMJMHBNILDJ
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x29E6340", Offset = "0x29E4940", VA = "0x1829E6340")]
	public static bool CKINKHIAJFD<T>(this T NJKKPOFFNNJ) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6A1E660", Offset = "0x6A1CC60", VA = "0x186A1E660")]
	public static string ENFCIJGNMKC(this UnityEngine.Object NJKKPOFFNNJ)
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

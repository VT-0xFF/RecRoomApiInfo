using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class LHLMENCGNGJ
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface OPMJJAJMOGP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2C16E60", Offset = "0x2C16060", VA = "0x182C16E60")]
	public static T FLMBMOKHPOL<T>(this T HIKEOGPAJAF) where T : UnityEngine.Object
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2C16F50", Offset = "0x2C16150", VA = "0x182C16F50")]
	public static T ICINGKDGEKI<T>(this T HIKEOGPAJAF) where T : class, OPMJJAJMOGP
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2C16EC0", Offset = "0x2C160C0", VA = "0x182C16EC0")]
	public static bool HOEIECHNKHJ<T>(this T MEAFIMADMKA) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x690AB30", Offset = "0x6909D30", VA = "0x18690AB30")]
	public static string IFNALNCNPID(this UnityEngine.Object MEAFIMADMKA)
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

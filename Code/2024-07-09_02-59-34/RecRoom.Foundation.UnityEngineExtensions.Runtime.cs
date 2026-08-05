using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class PDCGADEABPB
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface ONPKDHIBKJH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2CE25F0", Offset = "0x2CE11F0", VA = "0x182CE25F0")]
	public static T HNDKFLNDHDK<T>(this T ENEDBNLKLJL) where T : UnityEngine.Object
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2CE26E0", Offset = "0x2CE12E0", VA = "0x182CE26E0")]
	public static T MJFMOOALPIE<T>(this T ENEDBNLKLJL) where T : class, ONPKDHIBKJH
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2CE2650", Offset = "0x2CE1250", VA = "0x182CE2650")]
	public static bool LFPGLKGPAFH<T>(this T APKAFMDACKK) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x69E8B20", Offset = "0x69E7720", VA = "0x1869E8B20")]
	public static string KCDMFMFJFDP(this UnityEngine.Object APKAFMDACKK)
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

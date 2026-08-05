using System;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface GHIALFEOOFP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool OMNLACCGDCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::KFCKCBLDJHI<Texture2D> KCGGLIFHGKB(NativeArray<byte> LKNKGIHBJGM, bool HPPEGOJFLAK = false);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class NPKDCDGLMEH : GHIALFEOOFP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool OMNLACCGDCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5E5EC0", Offset = "0x5E4EC0", VA = "0x1805E5EC0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xE551A0", Offset = "0xE541A0", VA = "0x180E551A0")]
	[HJKJOFMFDMI]
	private static void CKGHFAKJFGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	[Preserve]
	public NPKDCDGLMEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0xE55300", Offset = "0xE54300", VA = "0x180E55300", Slot = "5")]
	public global::KFCKCBLDJHI<Texture2D> KCGGLIFHGKB(NativeArray<byte> LKNKGIHBJGM, bool HPPEGOJFLAK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80", Slot = "6")]
	public void Dispose()
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

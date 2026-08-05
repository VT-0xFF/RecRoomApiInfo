using System;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface NPPHPCBDOPE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool CDHDAHMPNAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::BFJKHNFPOCI<Texture2D> NEMAKDHFPPK(NativeArray<byte> LDELBHEDHOJ, bool LKKCLIMIJBP = false);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class BFBHENEJAKJ : NPPHPCBDOPE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool CDHDAHMPNAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x67BD00", Offset = "0x67B100", VA = "0x18067BD00", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x60AF710", Offset = "0x60AEB10", VA = "0x1860AF710")]
	[PCIIMDKJBPO(GGLAACLIDJL.None)]
	private static void GHCFAKCMOAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	[Preserve]
	public BFBHENEJAKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x60AF810", Offset = "0x60AEC10", VA = "0x1860AF810", Slot = "5")]
	public global::BFJKHNFPOCI<Texture2D> NEMAKDHFPPK(NativeArray<byte> LDELBHEDHOJ, bool LKKCLIMIJBP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "6")]
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

using System;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface MIKGHCKPHPD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool PMOFCPKMCKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::BKFIALBOCOF<Texture2D> MMLHJNHJKIO(NativeArray<byte> FDJJJKEGJEB, bool KEDMKCPOGKO = false);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class DGCEIPMJMPC : MIKGHCKPHPD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool PMOFCPKMCKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5ECEC0", Offset = "0x5EBAC0", VA = "0x1805ECEC0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x58B4180", Offset = "0x58B2D80", VA = "0x1858B4180")]
	[GFJPFDCIFKC(GLALKNGODNM.None)]
	private static void AIOENCGFIEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
	[Preserve]
	public DGCEIPMJMPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x58B4270", Offset = "0x58B2E70", VA = "0x1858B4270", Slot = "5")]
	public global::BKFIALBOCOF<Texture2D> MMLHJNHJKIO(NativeArray<byte> FDJJJKEGJEB, bool KEDMKCPOGKO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80", Slot = "6")]
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

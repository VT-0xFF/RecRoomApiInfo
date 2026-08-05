using System;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface MNNKFOOKPIP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool BMKIPAKDNHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::DCAEDBKANDL<Texture2D> DILABKICGGP(NativeArray<byte> EFKDHOLGNIP, bool EDLBIJOKEFC = false);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class GCPGGOIMFGO : MNNKFOOKPIP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool BMKIPAKDNHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x58CEC0", Offset = "0x58BEC0", VA = "0x18058CEC0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5216C40", Offset = "0x5215C40", VA = "0x185216C40")]
	[NKCNCMJLPMH]
	private static void NCCJLLHLICO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	[Preserve]
	public GCPGGOIMFGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5216BE0", Offset = "0x5215BE0", VA = "0x185216BE0", Slot = "5")]
	public global::DCAEDBKANDL<Texture2D> DILABKICGGP(NativeArray<byte> EFKDHOLGNIP, bool EDLBIJOKEFC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x58CE80", Offset = "0x58BE80", VA = "0x18058CE80", Slot = "6")]
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

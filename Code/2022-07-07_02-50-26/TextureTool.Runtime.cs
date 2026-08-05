using System;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface BIGDIMEMMOI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool LGAALHFNKHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::MLAIHLNJONP<Texture2D> EGJBFPKCHLD(NativeArray<byte> DGDDAOBDJDF, bool IMJOENLIJIA = false);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class OOPILPEFHIA : BIGDIMEMMOI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool LGAALHFNKHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x58AEC0", Offset = "0x58A0C0", VA = "0x18058AEC0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xDDAF30", Offset = "0xDDA130", VA = "0x180DDAF30")]
	[CFCNMFNLFMK]
	private static void APOKIHMDCPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	[Preserve]
	public OOPILPEFHIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0xDDB090", Offset = "0xDDA290", VA = "0x180DDB090", Slot = "5")]
	public global::MLAIHLNJONP<Texture2D> EGJBFPKCHLD(NativeArray<byte> DGDDAOBDJDF, bool IMJOENLIJIA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x58AE80", Offset = "0x58A080", VA = "0x18058AE80", Slot = "6")]
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

using System;
using System.IO;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
internal class DCLCOJGFLAD : BinaryWriter
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly byte[] LHJEDJIFOCK;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x9D746F0", Offset = "0x9D73AF0", VA = "0x189D746F0")]
	public DCLCOJGFLAD(Stream FICAOFNBOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x9D73240", Offset = "0x9D72640", VA = "0x189D73240")]
	public void FIAMOLGPIJD(float[] CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x9D74450", Offset = "0x9D73850", VA = "0x189D74450", Slot = "27")]
	public override void Write(float CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x9D73530", Offset = "0x9D72930", VA = "0x189D73530")]
	public void FIAMOLGPIJD(Vector4[] OLEJLIDKEEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x9D72C40", Offset = "0x9D72040", VA = "0x189D72C40")]
	public void FIAMOLGPIJD(Vector3[] OLEJLIDKEEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x9D73CC0", Offset = "0x9D730C0", VA = "0x189D73CC0")]
	public void FIAMOLGPIJD(Quaternion[] OLEJLIDKEEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class OKBGGDLEOMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private bool CPEJPBDHPFM;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x9D747B0", Offset = "0x9D73BB0", VA = "0x189D747B0")]
	public OKBGGDLEOMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x9D74750", Offset = "0x9D73B50", VA = "0x189D74750")]
	public void JKIEDOPPCEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xDD8090", Offset = "0xDD7490", VA = "0x180DD8090")]
	private void GEKMCMBNAJO()
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

using System;
using System.IO;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
internal class NAKGAABKNAC : BinaryWriter
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly byte[] EMGOPPNCHPK;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x9DAE7D0", Offset = "0x9DAD1D0", VA = "0x189DAE7D0")]
	public NAKGAABKNAC(Stream DDEEDKINMMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x9DACD20", Offset = "0x9DAB720", VA = "0x189DACD20")]
	public void PHAKNALBEIB(float[] PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x9DAE530", Offset = "0x9DACF30", VA = "0x189DAE530", Slot = "27")]
	public override void Write(float PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x9DAD610", Offset = "0x9DAC010", VA = "0x189DAD610")]
	public void PHAKNALBEIB(Vector4[] LDAMGPGPNCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x9DAD010", Offset = "0x9DABA10", VA = "0x189DAD010")]
	public void PHAKNALBEIB(Vector3[] LDAMGPGPNCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x9DADDA0", Offset = "0x9DAC7A0", VA = "0x189DADDA0")]
	public void PHAKNALBEIB(Quaternion[] LDAMGPGPNCL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class NDGAEMHCBHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private bool NLNMAIKHFJK;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x9DAE890", Offset = "0x9DAD290", VA = "0x189DAE890")]
	public NDGAEMHCBHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x9DAE830", Offset = "0x9DAD230", VA = "0x189DAE830")]
	public void DALMCBIJENG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xDD1170", Offset = "0xDCFB70", VA = "0x180DD1170")]
	private void OLOGKEIIIOD()
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

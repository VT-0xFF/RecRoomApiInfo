using System;
using System.IO;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
internal class NPBFHCKEDCF : BinaryWriter
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly byte[] PEIJCAMFPBB;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x9F5EA00", Offset = "0x9F5D000", VA = "0x189F5EA00")]
	public NPBFHCKEDCF(Stream KNOCFLEDLNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x9F5CF50", Offset = "0x9F5B550", VA = "0x189F5CF50")]
	public void OFCKLKGLICM(float[] FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x9F5E760", Offset = "0x9F5CD60", VA = "0x189F5E760", Slot = "27")]
	public override void Write(float FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x9F5D9D0", Offset = "0x9F5BFD0", VA = "0x189F5D9D0")]
	public void OFCKLKGLICM(Vector4[] OBACHLEFMJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x9F5E160", Offset = "0x9F5C760", VA = "0x189F5E160")]
	public void OFCKLKGLICM(Vector3[] OBACHLEFMJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x9F5D240", Offset = "0x9F5B840", VA = "0x189F5D240")]
	public void OFCKLKGLICM(Quaternion[] OBACHLEFMJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class BKCBOBCPNBH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private bool BFIJHDCJBHC;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x9F5CEC0", Offset = "0x9F5B4C0", VA = "0x189F5CEC0")]
	public BKCBOBCPNBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x9F5CE60", Offset = "0x9F5B460", VA = "0x189F5CE60")]
	public void OHEFCKGFNAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xE15B20", Offset = "0xE14120", VA = "0x180E15B20")]
	private void ADFEGECJCDE()
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

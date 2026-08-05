using System;
using System.IO;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
internal class NIKDAOMMPMO : BinaryWriter
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly byte[] DCMIENOBOCJ;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x9C29610", Offset = "0x9C28610", VA = "0x189C29610")]
	public NIKDAOMMPMO(Stream KNAKPEGCGEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x9C27B60", Offset = "0x9C26B60", VA = "0x189C27B60")]
	public void KENBDFDJMJH(float[] IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x9C29370", Offset = "0x9C28370", VA = "0x189C29370", Slot = "26")]
	public override void Write(float IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x9C285E0", Offset = "0x9C275E0", VA = "0x189C285E0")]
	public void KENBDFDJMJH(Vector4[] CAJHHKCJGAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x9C28D70", Offset = "0x9C27D70", VA = "0x189C28D70")]
	public void KENBDFDJMJH(Vector3[] CAJHHKCJGAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x9C27E50", Offset = "0x9C26E50", VA = "0x189C27E50")]
	public void KENBDFDJMJH(Quaternion[] CAJHHKCJGAH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class PONAAEMPPDG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private bool BMPFKNAIOFH;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x9C296D0", Offset = "0x9C286D0", VA = "0x189C296D0")]
	public PONAAEMPPDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x9C29670", Offset = "0x9C28670", VA = "0x189C29670")]
	public void DJCADOADGHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xDB1510", Offset = "0xDB0510", VA = "0x180DB1510")]
	private void BHFDFJAIFCM()
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

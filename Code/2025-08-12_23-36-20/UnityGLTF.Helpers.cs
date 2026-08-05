using System;
using System.IO;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
internal class IBBDIOOJAFE : BinaryWriter
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly byte[] NNABGJIGEFP;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x9E4E360", Offset = "0x9E4D160", VA = "0x189E4E360")]
	public IBBDIOOJAFE(Stream KHCFEIMCNJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x9E4D860", Offset = "0x9E4C660", VA = "0x189E4D860")]
	public void JKBMBEKOIPJ(float[] HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x9E4E0E0", Offset = "0x9E4CEE0", VA = "0x189E4E0E0", Slot = "27")]
	public override void Write(float HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x9E4CA20", Offset = "0x9E4B820", VA = "0x189E4CA20")]
	public void JKBMBEKOIPJ(Vector4[] FECLLLBAKJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x9E4DB30", Offset = "0x9E4C930", VA = "0x189E4DB30")]
	public void JKBMBEKOIPJ(Vector3[] FECLLLBAKJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x9E4D140", Offset = "0x9E4BF40", VA = "0x189E4D140")]
	public void JKBMBEKOIPJ(Quaternion[] FECLLLBAKJD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class APECCPFMJHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private bool IJCJGBAFLML;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x9E4C990", Offset = "0x9E4B790", VA = "0x189E4C990")]
	public APECCPFMJHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x9E4C930", Offset = "0x9E4B730", VA = "0x189E4C930")]
	public void IAHEHGELIAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xE12CA0", Offset = "0xE11AA0", VA = "0x180E12CA0")]
	private void IOAEPLJHHPC()
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

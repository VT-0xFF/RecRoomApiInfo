using System;
using System.IO;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
internal class GFHKHDEKIIE : BinaryWriter
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly byte[] LFPNKDGDDNI;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x9B4DEE0", Offset = "0x9B4CCE0", VA = "0x189B4DEE0")]
	public GFHKHDEKIIE(Stream EIHKLMPABNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x9B4C430", Offset = "0x9B4B230", VA = "0x189B4C430")]
	public void HFOAKAKOEPN(float[] BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x9B4DC40", Offset = "0x9B4CA40", VA = "0x189B4DC40", Slot = "26")]
	public override void Write(float BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x9B4CD20", Offset = "0x9B4BB20", VA = "0x189B4CD20")]
	public void HFOAKAKOEPN(Vector4[] LPNHFNADNJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x9B4C720", Offset = "0x9B4B520", VA = "0x189B4C720")]
	public void HFOAKAKOEPN(Vector3[] LPNHFNADNJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x9B4D4B0", Offset = "0x9B4C2B0", VA = "0x189B4D4B0")]
	public void HFOAKAKOEPN(Quaternion[] LPNHFNADNJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class OLLLMIBGIEH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private bool HDFFMMHDLNF;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x9B4DFA0", Offset = "0x9B4CDA0", VA = "0x189B4DFA0")]
	public OLLLMIBGIEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x9B4DF40", Offset = "0x9B4CD40", VA = "0x189B4DF40")]
	public void CEJFMPAJFBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xDA1B40", Offset = "0xDA0940", VA = "0x180DA1B40")]
	private void NCLELHCJIFH()
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

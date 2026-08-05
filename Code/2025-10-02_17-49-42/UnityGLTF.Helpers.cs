using System;
using System.IO;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
internal class GAGIKKBDMLN : BinaryWriter
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly byte[] EALKMFOFJFH;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x9FEBDB0", Offset = "0x9FEA7B0", VA = "0x189FEBDB0")]
	public GAGIKKBDMLN(Stream APJGPGMFHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x9FEB820", Offset = "0x9FEA220", VA = "0x189FEB820")]
	public void MGCEPLPNMLJ(float[] KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x9FEBB10", Offset = "0x9FEA510", VA = "0x189FEBB10", Slot = "27")]
	public override void Write(float KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x9FEAA90", Offset = "0x9FE9490", VA = "0x189FEAA90")]
	public void MGCEPLPNMLJ(Vector4[] IIHNJOKLOOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x9FEB220", Offset = "0x9FE9C20", VA = "0x189FEB220")]
	public void MGCEPLPNMLJ(Vector3[] IIHNJOKLOOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x9FEA300", Offset = "0x9FE8D00", VA = "0x189FEA300")]
	public void MGCEPLPNMLJ(Quaternion[] IIHNJOKLOOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class BHPJFMNHPBM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private bool GFNJJNFCCIK;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x9FEA270", Offset = "0x9FE8C70", VA = "0x189FEA270")]
	public BHPJFMNHPBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x9FEA210", Offset = "0x9FE8C10", VA = "0x189FEA210")]
	public void ECKNFDHLCOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xE33FE0", Offset = "0xE329E0", VA = "0x180E33FE0")]
	private void FCHLIJNMMKE()
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

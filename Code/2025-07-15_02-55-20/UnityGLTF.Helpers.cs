using System;
using System.IO;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
internal class KJNOBCGKKOO : BinaryWriter
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly byte[] HGAPPCKDFFJ;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x9BB0460", Offset = "0x9BAF060", VA = "0x189BB0460")]
	public KJNOBCGKKOO(Stream NOLPHAGAPOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x9BAF740", Offset = "0x9BAE340", VA = "0x189BAF740")]
	public void KJONDBHMIMN(float[] BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x9BB01C0", Offset = "0x9BAEDC0", VA = "0x189BB01C0", Slot = "26")]
	public override void Write(float BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x9BAEFB0", Offset = "0x9BADBB0", VA = "0x189BAEFB0")]
	public void KJONDBHMIMN(Vector4[] JPLCDDPKPCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x9BAE9B0", Offset = "0x9BAD5B0", VA = "0x189BAE9B0")]
	public void KJONDBHMIMN(Vector3[] JPLCDDPKPCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x9BAFA30", Offset = "0x9BAE630", VA = "0x189BAFA30")]
	public void KJONDBHMIMN(Quaternion[] JPLCDDPKPCC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class CICOKJMDMOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private bool NFJMAPOJDLJ;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x9BAE920", Offset = "0x9BAD520", VA = "0x189BAE920")]
	public CICOKJMDMOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x9BAE8C0", Offset = "0x9BAD4C0", VA = "0x189BAE8C0")]
	public void DOFNFKKECNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xDAA000", Offset = "0xDA8C00", VA = "0x180DAA000")]
	private void JMEICEMEAEC()
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

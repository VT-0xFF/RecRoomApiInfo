using System;
using System.IO;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
internal class FOEPIAPEAMN : BinaryWriter
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly byte[] KKMIHIHHCGB;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x9FF3E20", Offset = "0x9FF2420", VA = "0x189FF3E20")]
	public FOEPIAPEAMN(Stream CCHEFPNDJLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x9FF3100", Offset = "0x9FF1700", VA = "0x189FF3100")]
	public void OMIKOFLNMMP(float[] KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x9FF3B80", Offset = "0x9FF2180", VA = "0x189FF3B80", Slot = "27")]
	public override void Write(float KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x9FF33F0", Offset = "0x9FF19F0", VA = "0x189FF33F0")]
	public void OMIKOFLNMMP(Vector4[] MDIMFHGEOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x9FF2370", Offset = "0x9FF0970", VA = "0x189FF2370")]
	public void OMIKOFLNMMP(Vector3[] MDIMFHGEOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x9FF2970", Offset = "0x9FF0F70", VA = "0x189FF2970")]
	public void OMIKOFLNMMP(Quaternion[] MDIMFHGEOCP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class MMFFMLJGBMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private bool MJFLLIADELG;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x9FF3EE0", Offset = "0x9FF24E0", VA = "0x189FF3EE0")]
	public MMFFMLJGBMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x9FF3E80", Offset = "0x9FF2480", VA = "0x189FF3E80")]
	public void OOJJEDDKMAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xE36610", Offset = "0xE34C10", VA = "0x180E36610")]
	private void FEJNCKOOFCC()
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

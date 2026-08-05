using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Photon.Pun;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class DCGNKLFPIBC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid JLMDGKFHAOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string PEDHJPCADCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int CBIKPNJEJCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid GPINDNEAKFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly ABNGHDDNIOD FNLJAPCNPEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 HKOFFOMAMII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion PCMKPKPLJCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Vector3 CGNFMJMGNEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool NMMICIAIKIJ;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x58ADDC0", Offset = "0x58AC9C0", VA = "0x1858ADDC0")]
	public DCGNKLFPIBC(string DAAPEPEGMGB, Guid AOGLEJFHHJL, int OHONFCAOFGG, Guid BJELMPLPKAD, ABNGHDDNIOD IHJIIJJJJLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x58ADB50", Offset = "0x58AC750", VA = "0x1858ADB50")]
	public IGOBMDEHBOG.IDPFDONCIKP AMOIDDENBNP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x58ADD00", Offset = "0x58AC900", VA = "0x1858ADD00")]
	public KOFMCJLLJHF KLPJJADAHLI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class ABNGHDDNIOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, object> AAMEBGPJLAB;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x58ADAD0", Offset = "0x58AC6D0", VA = "0x1858ADAD0")]
	public ABNGHDDNIOD([Optional] Dictionary<string, object> AAMEBGPJLAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x58AD950", Offset = "0x58AC550", VA = "0x1858AD950")]
	[NotNull]
	public static ABNGHDDNIOD KLPDOMANHOK(PhotonView FJAGFNGNGHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3120C40", Offset = "0x311F840", VA = "0x183120C40")]
	public bool HMDEELNDPOI<T>(string KKDEFIFHPNN, out T KGJOJGIPNPH) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1FA5DB0", Offset = "0x1FA49B0", VA = "0x181FA5DB0")]
	public void GELHLBKPBFF<T>(string KKDEFIFHPNN, T KGJOJGIPNPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x58AD8F0", Offset = "0x58AC4F0", VA = "0x1858AD8F0")]
	public void JNIHJKFEBJI(string KKDEFIFHPNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5EC1D0", Offset = "0x5EADD0", VA = "0x1805EC1D0")]
	public Dictionary<string, object> EMODCPIFJOP()
	{
		return null;
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

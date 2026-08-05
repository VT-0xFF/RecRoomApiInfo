using System;
using System.Reflection;
using Cpp2IlInjected;
using Photon.Pun;
using RecRoom.Foundation;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class OLPKOLEDJIC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid CCPKEILOFHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string PIPBPMNKLKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int MGKJPCMBANP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid MLFGGJGDMLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly FIGGFBFOHNG CDNAAMGIJMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 COFBFGOOFOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion PHMBAJJGPAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Vector3 BDDFJFCLMBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool NDGNGLOPOEJ;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7B672F0", Offset = "0x7B65AF0", VA = "0x187B672F0")]
	public OLPKOLEDJIC(string OLMKGDACLDI, Guid JIENEFJJAGC, int AMMODJCDOJN, Guid OLBCGDKCLDF, FIGGFBFOHNG MAGNIDHODLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7B67140", Offset = "0x7B65940", VA = "0x187B67140")]
	public KCGCNCJIDFP PFODKLOCBCJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7B671F0", Offset = "0x7B659F0", VA = "0x187B671F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class JBEFAFFBKKG
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7B67110", Offset = "0x7B65910", VA = "0x187B67110")]
	public static bool PHNBDDGICKN(this PhotonView JNLFCOMKBMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7B66F60", Offset = "0x7B65760", VA = "0x187B66F60")]
	public static object[] BADGHCOFPCL(this PhotonView JNLFCOMKBMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7B66F80", Offset = "0x7B65780", VA = "0x187B66F80")]
	public static ViewId FHLCLMHJFHB(this PhotonView JNLFCOMKBMA)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7B67020", Offset = "0x7B65820", VA = "0x187B67020")]
	public static FIGGFBFOHNG JPICLCGAFHE(this PhotonView JNLFCOMKBMA)
	{
		return default(FIGGFBFOHNG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7B670E0", Offset = "0x7B658E0", VA = "0x187B670E0")]
	public static FIGGFBFOHNG MAGBJHEGJFO(this NCOJGBNNBKA KIAKHLGFPAF)
	{
		return default(FIGGFBFOHNG);
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

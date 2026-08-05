using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface BLJHFCKHOAL
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JBNDLFMNHKI(HNGHCMBBKEB HOAIKLJFCGK, IGEOACAAHGI EAJINMJLKJK);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(HNGHCMBBKEB, ComponentTypeList, JJHJAIMLOHJ)> HNDMIAEAKBP(NLFDLEBCDME FNIMMOLDOMI);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void JJHJAIMLOHJ(HNGHCMBBKEB HOAIKLJFCGK, IGEOACAAHGI EAJINMJLKJK);
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct IGEOACAAHGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity AHNNJNFIHFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager OKNGAOGEIDO;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1FB8A30", Offset = "0x1FB7E30", VA = "0x181FB8A30")]
	public IGEOACAAHGI(Entity AHNNJNFIHFM, EntityManager OKNGAOGEIDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x23F6140", Offset = "0x23F5540", VA = "0x1823F6140")]
	public void FAJCEJLMNJF<T>(T LPCGJALKADL) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x23F6460", Offset = "0x23F5860", VA = "0x1823F6460")]
	public void FNDBLJNFEJE<T>(T LPCGJALKADL) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5D9F400", Offset = "0x5D9E800", VA = "0x185D9F400")]
	public void ACPOLHPAGAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface NLFDLEBCDME
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(JHDIEJNPMMJ, HNGHCMBBKEB)> MADBHAKNFNK();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class MLEPLFACGKF : IHEAACHMMDM
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x773100", Offset = "0x772500", VA = "0x180773100")]
	public MLEPLFACGKF()
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

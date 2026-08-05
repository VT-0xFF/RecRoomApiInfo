using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface PDDBGKKNOJO
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PDNPKCOAFBJ(NMFEMHGADPL KEEKBCHCMJM, HANEKIAEPKM LEGNJEAFIPO);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(NMFEMHGADPL, ComponentTypeList, DFAABFNJGII)> KIELADHBOAJ(BCJKBNHNEAJ KPDHKNGNFOD);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void DFAABFNJGII(NMFEMHGADPL KEEKBCHCMJM, HANEKIAEPKM LEGNJEAFIPO);
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct HANEKIAEPKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity IBMHOJHGCIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager KFOGOLNDMKF;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x21F5E90", Offset = "0x21F4890", VA = "0x1821F5E90")]
	public HANEKIAEPKM(Entity IBMHOJHGCIG, EntityManager KFOGOLNDMKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x269B730", Offset = "0x269A130", VA = "0x18269B730")]
	public void BDBEANEDBLI<T>(T FDFHGIHHGHO) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x269B950", Offset = "0x269A350", VA = "0x18269B950")]
	public void ICCNAGPBMAD<T>(T FDFHGIHHGHO) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6086FC0", Offset = "0x60859C0", VA = "0x186086FC0")]
	public void DEPILPHLJFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface BCJKBNHNEAJ
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(GLKBACJABIP, NMFEMHGADPL)> CBIODFGIDPA();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class GONMFIDEIFD : JMFFMANBMIK
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7B7100", Offset = "0x7B5B00", VA = "0x1807B7100")]
	public GONMFIDEIFD()
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

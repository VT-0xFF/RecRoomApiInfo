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
	[Cpp2IlInjected.Address(RVA = "0x21D57E0", Offset = "0x21D4BE0", VA = "0x1821D57E0")]
	public HANEKIAEPKM(Entity IBMHOJHGCIG, EntityManager KFOGOLNDMKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2646340", Offset = "0x2645740", VA = "0x182646340")]
	public void BDBEANEDBLI<T>(T FDFHGIHHGHO) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2646560", Offset = "0x2645960", VA = "0x182646560")]
	public void ICCNAGPBMAD<T>(T FDFHGIHHGHO) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x600D3E0", Offset = "0x600C7E0", VA = "0x18600D3E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x7AD100", Offset = "0x7AC500", VA = "0x1807AD100")]
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

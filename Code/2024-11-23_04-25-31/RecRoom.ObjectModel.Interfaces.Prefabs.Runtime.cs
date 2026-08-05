using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface BPADJPPABEM
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OKCGLECEBIO(EBLEEPKFPFE ADCKHDIMKFL, FCFJCLCMCAD OKGGEMJKOEI);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(EBLEEPKFPFE, ComponentTypeList, EBMLBMPGPAD)> LDALCPMKEEB(ACIDJPIBBLI JECDOHMAOGJ);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void EBMLBMPGPAD(EBLEEPKFPFE ADCKHDIMKFL, FCFJCLCMCAD OKGGEMJKOEI);
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct FCFJCLCMCAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity IHGPCLDNNFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager LOJAAGLKEBK;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2895E40", Offset = "0x2894840", VA = "0x182895E40")]
	public FCFJCLCMCAD(Entity IHGPCLDNNFC, EntityManager LOJAAGLKEBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2EDCF70", Offset = "0x2EDB970", VA = "0x182EDCF70")]
	public void CADIEIMFLMA<T>(T PKCLPFEIPFH) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2EDCEF0", Offset = "0x2EDB8F0", VA = "0x182EDCEF0")]
	public void ABLEIIKNHCG<T>(T PKCLPFEIPFH) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6F1F6D0", Offset = "0x6F1E0D0", VA = "0x186F1F6D0")]
	public void IIFEPCIEAJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface ACIDJPIBBLI
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(JKLBMPOHFIB, EBLEEPKFPFE)> MHNENGBCBEP();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class IFADODNOPIB : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x1983700", Offset = "0x1982100", VA = "0x181983700")]
	public IFADODNOPIB()
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

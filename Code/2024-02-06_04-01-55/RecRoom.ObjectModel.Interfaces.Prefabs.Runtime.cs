using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface NEFJGHDCMBI
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CEHHAGPHNPD(GLDOCFALIAD APPOBJLFBKD, KLBABOIJALF JGHPEDHBKAD);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(GLDOCFALIAD, ComponentTypeList, GBPAFDNJIIG)> NGJMDKOOBMK(DDHMGOKPBLK MDJNPBEMLOH);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void GBPAFDNJIIG(GLDOCFALIAD APPOBJLFBKD, KLBABOIJALF JGHPEDHBKAD);
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct KLBABOIJALF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity JPDMAMIIECO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager NIHDJFAPFPF;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x21CEF80", Offset = "0x21CE380", VA = "0x1821CEF80")]
	public KLBABOIJALF(Entity JPDMAMIIECO, EntityManager NIHDJFAPFPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2720900", Offset = "0x271FD00", VA = "0x182720900")]
	public void ENHGLNPEFHG<T>(T ANJCCKHBJJO) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2720BA0", Offset = "0x271FFA0", VA = "0x182720BA0")]
	public void PFEGDHLANAN<T>(T ANJCCKHBJJO) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6165230", Offset = "0x6164630", VA = "0x186165230")]
	public void HPOBLHEMBAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface DDHMGOKPBLK
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(JGGHLKICFJK, GLDOCFALIAD)> NIKLFHGHHBK();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class LKBAALHJPIB : HPEAGNKMHFJ
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7AF100", Offset = "0x7AE500", VA = "0x1807AF100")]
	public LKBAALHJPIB()
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

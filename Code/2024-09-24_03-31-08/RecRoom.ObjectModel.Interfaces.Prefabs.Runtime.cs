using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface CJHNLBIKAEP
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NMLABLPBPLB(ADNGPIOLLLA NLMEGDEGAEA, HEBMNHPHIDI HHPDJKDHLGL);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(ADNGPIOLLLA, ComponentTypeList, JKOPIJMGLEA)> PPLMJBFKOPO(JLIBGFPNDNF EHPHLCNGGKB);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void JKOPIJMGLEA(ADNGPIOLLLA NLMEGDEGAEA, HEBMNHPHIDI HHPDJKDHLGL);
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct HEBMNHPHIDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity AFNIOPPCKNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager JONCEOFPEBL;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x271AE70", Offset = "0x2719870", VA = "0x18271AE70")]
	public HEBMNHPHIDI(Entity AFNIOPPCKNG, EntityManager JONCEOFPEBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2D7A660", Offset = "0x2D79060", VA = "0x182D7A660")]
	public void ODIPBPJKHHK<T>(T IPHMAHBENGI) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2D7A5E0", Offset = "0x2D78FE0", VA = "0x182D7A5E0")]
	public void DMMECAIMDAA<T>(T IPHMAHBENGI) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6C9BA20", Offset = "0x6C9A420", VA = "0x186C9BA20")]
	public void PJDFEDNAPPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface JLIBGFPNDNF
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(NIGNKOFGHHP, ADNGPIOLLLA)> OJIOIKCLACH();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class JBAICLLKNBB : LCCBCKAMMLH
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x183C420", Offset = "0x183AE20", VA = "0x18183C420")]
	public JBAICLLKNBB()
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

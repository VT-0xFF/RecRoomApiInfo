using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface EMFDNLDFJMD
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IGFKICEIIOD(IPNKFCKAPGB IMKFFCANKLC, FGFAOJLDHJJ CMCBEOMNFLN);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(IPNKFCKAPGB, ComponentTypeList, IHJJPGADLDM)> NOCMLMBNILD(LIJHKDAHONG HGEOMACAEJD);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void IHJJPGADLDM(IPNKFCKAPGB IMKFFCANKLC, FGFAOJLDHJJ CMCBEOMNFLN);
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct FGFAOJLDHJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity AINKOAHKAPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager MAJIKHEKDED;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2732ED0", Offset = "0x27318D0", VA = "0x182732ED0")]
	public FGFAOJLDHJJ(Entity AINKOAHKAPB, EntityManager MAJIKHEKDED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2D808A0", Offset = "0x2D7F2A0", VA = "0x182D808A0")]
	public void ENCKAHEIPGI<T>(T KLABJGGMBGH) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2D80AC0", Offset = "0x2D7F4C0", VA = "0x182D80AC0")]
	public void HHHFKNGNOJL<T>(T KLABJGGMBGH) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6D570D0", Offset = "0x6D55AD0", VA = "0x186D570D0")]
	public void MJPBNKLKKDO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface LIJHKDAHONG
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(KDHBKKGFEEG, IPNKFCKAPGB)> OMNPEODELIO();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class LMJILOENGKH : GCKGMAMCGEA
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x1852420", Offset = "0x1850E20", VA = "0x181852420")]
	public LMJILOENGKH()
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

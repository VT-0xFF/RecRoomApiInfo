using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface LGDLLDKFNKB
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KMGNIJMCHKB(NJNFOMGPIJM GFOODEKJMLI, LIJCPKKHMJO DPHFLKIKHED);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(NJNFOMGPIJM, ComponentTypeList, EGPMDMBIFLC)> CENDKFBDAIP(MPJAOADAGMO NIHHKEFEPPJ);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void EGPMDMBIFLC(NJNFOMGPIJM GFOODEKJMLI, LIJCPKKHMJO DPHFLKIKHED);
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct LIJCPKKHMJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity DGNDJCBPFEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager LEDLAOLOFCD;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2B6F2F0", Offset = "0x2B6E0F0", VA = "0x182B6F2F0")]
	public LIJCPKKHMJO(Entity DGNDJCBPFEH, EntityManager LEDLAOLOFCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x33A9750", Offset = "0x33A8550", VA = "0x1833A9750")]
	public void DJKOKNNCNMK<T>(T IPHILEOFJLB) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x33A96D0", Offset = "0x33A84D0", VA = "0x1833A96D0")]
	public void BGJGBLJMNEK<T>(T IPHILEOFJLB) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x73D4D40", Offset = "0x73D3B40", VA = "0x1873D4D40")]
	public void HHANGCHLGID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface MPJAOADAGMO
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(LOEIMIFIJEN, NJNFOMGPIJM)> DBMKEKKBCEG();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class IBLHMOHMAGL : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x1DF5AB0", Offset = "0x1DF48B0", VA = "0x181DF5AB0")]
	public IBLHMOHMAGL()
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

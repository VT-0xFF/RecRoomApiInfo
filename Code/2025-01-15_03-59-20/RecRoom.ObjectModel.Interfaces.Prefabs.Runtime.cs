using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface JOGCPNOOGEK
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OBNPALBMDBE(NABGOBFPKKK FPLGHFJHKOE, PIPICDHGADF DLPEFGJCADN);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(NABGOBFPKKK, ComponentTypeList, MENDBBPNABI)> GOJOPGMMEMA(LOGAJDHIIHG AJMOMCAACBA);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void MENDBBPNABI(NABGOBFPKKK FPLGHFJHKOE, PIPICDHGADF DLPEFGJCADN);
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct PIPICDHGADF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity DGPOIOLCNNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager PKOBGBCOJNG;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x295B110", Offset = "0x295A510", VA = "0x18295B110")]
	public PIPICDHGADF(Entity DGPOIOLCNNN, EntityManager PKOBGBCOJNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3224490", Offset = "0x3223890", VA = "0x183224490")]
	public void KJLAKIGFJAC<T>(T HCPAOILCJCB) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3224410", Offset = "0x3223810", VA = "0x183224410")]
	public void EJHLLLCNDPL<T>(T HCPAOILCJCB) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7138ED0", Offset = "0x71382D0", VA = "0x187138ED0")]
	public void EPKLBLCIMKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface LOGAJDHIIHG
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(LHOIJIFDHFN, NABGOBFPKKK)> GLGPEPIKPAB();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class BAGBBNCHCOG : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x1A29C90", Offset = "0x1A29090", VA = "0x181A29C90")]
	public BAGBBNCHCOG()
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

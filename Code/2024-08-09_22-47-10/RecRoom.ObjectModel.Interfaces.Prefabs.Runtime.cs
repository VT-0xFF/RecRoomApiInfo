using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface ABMPDDMACBL
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PDIIGCMKEBK(POJFLIOAKPM AKDHFMEOHOE, KBADDPICDBB BLFJDFBJMEI);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(POJFLIOAKPM, ComponentTypeList, COOAGIEEOGO)> FMMHCPEELFC(GNMALEDLKKF NHGHGLCNDGA);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void COOAGIEEOGO(POJFLIOAKPM AKDHFMEOHOE, KBADDPICDBB BLFJDFBJMEI);
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct KBADDPICDBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity KHAAFKNHHNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager NIHNJICAABF;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x25AB940", Offset = "0x25AAD40", VA = "0x1825AB940")]
	public KBADDPICDBB(Entity KHAAFKNHHNL, EntityManager NIHNJICAABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2C19D10", Offset = "0x2C19110", VA = "0x182C19D10")]
	public void KGJINEABJGO<T>(T OBEEJPGJPFD) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2C19C90", Offset = "0x2C19090", VA = "0x182C19C90")]
	public void ILDFIFDMOKK<T>(T OBEEJPGJPFD) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x69EA6D0", Offset = "0x69E9AD0", VA = "0x1869EA6D0")]
	public void GAONIKBNAEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface GNMALEDLKKF
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(ODHNMDGHJAA, POJFLIOAKPM)> DMPBDICAMLB();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class LMPNABNBBOD : AFENHBMIOLA
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x15B3AC0", Offset = "0x15B2EC0", VA = "0x1815B3AC0")]
	public LMPNABNBBOD()
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

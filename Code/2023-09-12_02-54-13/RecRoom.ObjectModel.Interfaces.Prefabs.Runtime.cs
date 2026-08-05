using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface DIFPONKGMOA
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(DJOJBOPMMAC, IMPAOGMALJN)> ICENLMBENOG();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class)]
public class MIFABIJFGFN : HFNAELOJHJC
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x823850", Offset = "0x822C50", VA = "0x180823850")]
	public MIFABIJFGFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface AAOKHJFFILP
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GHJHBPDJCEN(IMPAOGMALJN JBGKOICMKNG, JJGOPHKAJCM BBDEDKHLJFB);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(IMPAOGMALJN, ComponentTypeList, COKILELHEJE)> FKMODGGMJNJ(DIFPONKGMOA PJGJLPEKIPH);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void COKILELHEJE(IMPAOGMALJN JBGKOICMKNG, JJGOPHKAJCM BBDEDKHLJFB);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct JJGOPHKAJCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity GKMECPLEALF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager BEBIJONEMLA;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x176AAD0", Offset = "0x1769ED0", VA = "0x18176AAD0")]
	public JJGOPHKAJCM(Entity GKMECPLEALF, EntityManager BEBIJONEMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x16409A0", Offset = "0x163FDA0", VA = "0x1816409A0")]
	public void AFLFAPDAOKF<T>(T AGLCIEKHLEE) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1640A80", Offset = "0x163FE80", VA = "0x181640A80")]
	public void DEMBGMDGAKK<T>(T AGLCIEKHLEE) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7232D20", Offset = "0x7232120", VA = "0x187232D20")]
	public void JFCEBBNNJGO()
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

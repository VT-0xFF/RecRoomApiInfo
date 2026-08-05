using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface DAMJNMDABPA
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(IFEBDPAFELD, BLIAAMDKPNO)> HKHFIHNCILB();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class)]
public class DEOIDCOHIJG : EAGNFDFLHGH
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x8D40F0", Offset = "0x8D26F0", VA = "0x1808D40F0")]
	public DEOIDCOHIJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface FCJOBAGOILJ
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ECHHAMAPDMD(BLIAAMDKPNO POJMFCODLHG, KEJPMIHIFPE OCAJKLILJPK);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(BLIAAMDKPNO, ComponentTypeList, JDLDLAOBEIE)> KBDMHFINMBH(DAMJNMDABPA LKGDMEFDKFH);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void JDLDLAOBEIE(BLIAAMDKPNO POJMFCODLHG, KEJPMIHIFPE OCAJKLILJPK);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct KEJPMIHIFPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity MPAGCMNFGMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager PHHGGAMLDGB;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x1D428D0", Offset = "0x1D40ED0", VA = "0x181D428D0")]
	public KEJPMIHIFPE(Entity MPAGCMNFGMI, EntityManager PHHGGAMLDGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xF38230", Offset = "0xF36830", VA = "0x180F38230")]
	public void FGMAFKALEHD<T>(T MOLEJFDINLH) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0xF38310", Offset = "0xF36910", VA = "0x180F38310")]
	public void MINPHJLANDL<T>(T MOLEJFDINLH) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6FF9D80", Offset = "0x6FF8380", VA = "0x186FF9D80")]
	public void CIPJKGODPEL()
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

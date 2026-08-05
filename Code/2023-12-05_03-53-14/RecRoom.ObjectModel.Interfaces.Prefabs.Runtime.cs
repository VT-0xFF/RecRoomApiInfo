using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface AOJHGJKHCLD
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BKHKJJPNAGG(EGBCNJNDDPI PINNOPCPBKC, CPBNHLIGFHD JJFGEIJKLCL);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(EGBCNJNDDPI, ComponentTypeList, HJOFGAGNBKN)> FKMPIBCLPBL(AGPCIHHPGGJ PPOLBJGKPLE);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void HJOFGAGNBKN(EGBCNJNDDPI PINNOPCPBKC, CPBNHLIGFHD JJFGEIJKLCL);
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct CPBNHLIGFHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity HPMKKHPHJEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager LPAJKOAHLHJ;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x20B0640", Offset = "0x20AFA40", VA = "0x1820B0640")]
	public CPBNHLIGFHD(Entity HPMKKHPHJEE, EntityManager LPAJKOAHLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2348930", Offset = "0x2347D30", VA = "0x182348930")]
	public void HPDCNGOHBJP<T>(T NMENOOMOOJP) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2348BD0", Offset = "0x2347FD0", VA = "0x182348BD0")]
	public void NCHPCLLMENP<T>(T NMENOOMOOJP) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5EE6780", Offset = "0x5EE5B80", VA = "0x185EE6780")]
	public void NKDOMFEAMGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface AGPCIHHPGGJ
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(LHAFCPFJILF, EGBCNJNDDPI)> NOCKOKDMOCN();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class JEEDGJPANKG : BDAJIPEGBOD
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x781100", Offset = "0x780500", VA = "0x180781100")]
	public JEEDGJPANKG()
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

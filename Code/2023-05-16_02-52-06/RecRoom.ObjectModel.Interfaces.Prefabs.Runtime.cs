using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public delegate void OCDOGPHMNFN(IAFDFFOCDLF KCFAHJGLHLA, Entity NEAKDKENHHP, EntityManager PAHBLOLNPLD);
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface NMHEIOCPIJH
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(IAFDFFOCDLF, ComponentTypeList, OCDOGPHMNFN)> HGAFEBDKGFP(BACCEOHKDED FHLJIJCKGLN);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface BACCEOHKDED
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(ENALNDEOHNF, IAFDFFOCDLF)> PKCHKKPIIFJ();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class)]
public class BBNLHPBAJKI : GJHEIIBGENE
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0xF01AA0", Offset = "0xF008A0", VA = "0x180F01AA0")]
	public BBNLHPBAJKI()
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

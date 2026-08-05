using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public delegate void CFHDEDJFOHN(FFIHEMJDJJI CNEFMCCDIIL, Entity KCGBIDJFHLF, EntityManager KLFKJJDHNIL);
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface LILHBOLDDBP
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(FFIHEMJDJJI, APDBBCPJHNI, CFHDEDJFOHN)> NILNNGEEKDM(PDOMJEMLCGH EELIHJHFEMH);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface PDOMJEMLCGH
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(CDPNPEPOMEC, FFIHEMJDJJI)> DOFOPDAFJLI();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class)]
public class GMECFACEKMB : BFFBEGLONBC
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0xF64AD0", Offset = "0xF63ED0", VA = "0x180F64AD0")]
	public GMECFACEKMB()
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

using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface CAEMJJLHFME
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2ED4998854463C", Offset = "0x0", VA = "0x2ED49B0854463C", Slot = "0")]
	void DBKHFPMEGAJ(object EKOKIILLNMO);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x854465A802ED4E4", Offset = "0x0", VA = "0x854465C002ED4E4", Slot = "1")]
	void HNNDPDPEPLK(object EKOKIILLNMO);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2ED4E8802ED4E4", Offset = "0x0", VA = "0x2ED4EA002ED4E4", Slot = "2")]
	void MBCIOBBCNFF(object EKOKIILLNMO);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2ED4E88854466C", Offset = "0x0", VA = "0x2ED4EA0854466C", Slot = "3")]
	void MIGIHAMMEAJ(object IJBJKIBEJLN, string BHFJONCFCNH, params object[] CFGJGLPAHFD);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x854465A802ED533", Offset = "0x0", VA = "0x854465C002ED533", Slot = "4")]
	void AHFHDEBPJBO(Exception NBMLFONNLJF);
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

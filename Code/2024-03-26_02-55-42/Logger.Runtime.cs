using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface BOKLJLGEHAO
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x248443899223D4", Offset = "0x0", VA = "0x248445099223D4", Slot = "0")]
	void OMAIFAPDBID(object DFBIKANGICJ);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x9A3886E802484EC", Offset = "0x0", VA = "0x9A38870002484EC", Slot = "1")]
	void LGFICOCMNCN(object DFBIKANGICJ);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x24853B802484EC", Offset = "0x0", VA = "0x24853D002484EC", Slot = "2")]
	void HOLPICFPDNJ(object DFBIKANGICJ);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x24853B89A3888C", Offset = "0x0", VA = "0x24853D09A3888C", Slot = "3")]
	void PBKKHJGKKLE(object APOKKKDAFKO, string OFLCCFMHOME, params object[] EGGAPMGLGIF);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x9A3889A80248543", Offset = "0x0", VA = "0x9A3889C00248543", Slot = "4")]
	void CFDJGOBIIKC(Exception IJGEEAMFAPO);
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

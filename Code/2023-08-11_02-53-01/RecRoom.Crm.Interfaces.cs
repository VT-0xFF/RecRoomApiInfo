using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface OHJCBNBDDNG
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2548AE888B2E8C", Offset = "0x0", VA = "0x2548B0088B2E8C", Slot = "0")]
	void ALEGGFCCAPA(string LFMEGLGIDMA, string INLOFCEECLJ, bool COBLMNCCGNL);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x88B1456802548D6", Offset = "0x0", VA = "0x88B1458002548D6", Slot = "1")]
	void NBIAGJNEHME();

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x254977802548F0", Offset = "0x0", VA = "0x254979002548F0", Slot = "2")]
	void DNBEBIHKIEF();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x25497E888B19F4", Offset = "0x0", VA = "0x254980088B19F4", Slot = "3")]
	void MKKJJGHJMPC();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x88B171280254A0E", Offset = "0x0", VA = "0x88B171400254A0E", Slot = "4")]
	void FCMKBBEFKFN(string EHKIONDBEDO, [Optional] string FBAIAMLLNDN);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface LEOJCOHKGOF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool GNAIMMEBIHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x254A6480254A10", Offset = "0x0", VA = "0x254A6600254A10", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x254A6E888B1554", Offset = "0x0", VA = "0x254A70088B1554", Slot = "1")]
	Task NNOHNEKNCIF();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x88B155280254AB2", Offset = "0x0", VA = "0x88B155400254AB2", Slot = "2")]
	void OGPDBFFONOJ();
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

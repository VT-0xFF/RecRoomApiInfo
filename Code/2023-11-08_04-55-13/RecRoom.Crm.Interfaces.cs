using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface BKAOEGGMODB
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x232F328910C700", Offset = "0x0", VA = "0x232F340910C700", Slot = "0")]
	void MNECLJIEPPB(string PHOKGNCFGOI, string GNFIOPBEACA, bool PNPAOFMPJLG);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x92F86CA80232FC9", Offset = "0x0", VA = "0x92F86CC00232FC9", Slot = "1")]
	void OEGHADOIECD();

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x23301880232FC9", Offset = "0x0", VA = "0x23301A00232FC9", Slot = "2")]
	void GIECOGHJLJP();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x233018892F86E8", Offset = "0x0", VA = "0x23301A092F86E8", Slot = "3")]
	void IHMJANDBIDO();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x92F86F680233020", Offset = "0x0", VA = "0x92F86F800233020", Slot = "4")]
	void BOCNDMAMPAO(string BIJFOMHCKCK, [Optional] string NIGOKJHFJDN);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface OAEEABMCEKC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool OKCFFCJOFOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x23306F80233020", Offset = "0x0", VA = "0x23307100233020", Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface PJIAJKMGMDA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool NPOECDCICEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x23307E892F86E8", Offset = "0x0", VA = "0x233080092F86E8", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<KFILJGNGOKG> KFGGJAEKJAL;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x23315A892F8B8C", Offset = "0x0", VA = "0x23315C092F8B8C", Slot = "3")]
	Task CAKCEPELMIL();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x92F8BA6802331AD", Offset = "0x0", VA = "0x92F8BA8002331AD", Slot = "4")]
	void KICOEKABIEM();
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

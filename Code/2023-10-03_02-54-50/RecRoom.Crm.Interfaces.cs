using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface EIDJFMMBNHE
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x224F8388FA0BC4", Offset = "0x0", VA = "0x224F8508FA0BC4", Slot = "0")]
	void GMBPPOMHLOI(string GEGEFLNMLKP, string IGOJGIAAHOK, bool MKOOKNIFJMP);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x90911468022502C", Offset = "0x0", VA = "0x90911480022502C", Slot = "1")]
	void FLCDNEHAKOF();

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x22507B8022502C", Offset = "0x0", VA = "0x22507D0022502C", Slot = "2")]
	void NKBLDBABKMB();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x22507B89091164", Offset = "0x0", VA = "0x22507D09091164", Slot = "3")]
	void KHJAJJCLFCK();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x909117280225083", Offset = "0x0", VA = "0x909117400225083", Slot = "4")]
	void KFEHIPCLBEN(string ELEMKMJCNDO, [Optional] string HJMOOOBNFBD);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface NILKMOJJKII
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool BPFBNNMBIAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2250D280225083", Offset = "0x0", VA = "0x2250D400225083", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2250DE89091164", Offset = "0x0", VA = "0x2250E009091164", Slot = "1")]
	Task OJHFNNJKLNN();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8FA0BC280225105", Offset = "0x0", VA = "0x8FA0BC400225105", Slot = "2")]
	void HCOIPAFLDEA();
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

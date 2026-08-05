using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface ELEAHIDDDDD
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2657638026574E", Offset = "0x0", VA = "0x2657650026574E", Slot = "0")]
	void LBLKFLBKGFH(string NNBEHBLIGEL, string GNFOHMMDMJO, bool GDPDLPGHIBJ);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x26576388DBB55C", Offset = "0x0", VA = "0x26576508DBB55C", Slot = "1")]
	void MFJJHNIFDON();

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8DBB56E8026580E", Offset = "0x0", VA = "0x8DBB5700026580E", Slot = "2")]
	void JECAKNPGMMI();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2658118026580E", Offset = "0x0", VA = "0x2658130026580E", Slot = "3")]
	void AJGGKLJAFLA();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x26581188DBB584", Offset = "0x0", VA = "0x26581308DBB584", Slot = "4")]
	void OMPCJLACDHK(string JEJLDCJDABJ, [Optional] string ANJKHKECFIK);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface LLOBKLJIJCM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool EGDANDHGJIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8DBB59280265826", Offset = "0x0", VA = "0x8DBB59400265826", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x26587C80265830", Offset = "0x0", VA = "0x26587E00265830", Slot = "1")]
	Task ABPANGJPOHB();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x26587C88CBFE18", Offset = "0x0", VA = "0x26587E08CBFE18", Slot = "2")]
	void IKCBOKMOGJK();
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

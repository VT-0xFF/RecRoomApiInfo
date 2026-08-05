using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface NKAMOHNDEMJ
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x28F3F68A71C448", Offset = "0x0", VA = "0x28F3F80A71C448", Slot = "0")]
	void FMECEHIJCGP(string NAPEGIIPDOG, string LMMFCHHELHK, bool BGIBPLNCEDP);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xA71C4628028F449", Offset = "0x0", VA = "0xA71C4640028F449", Slot = "1")]
	void MEGJMFNKLNJ();

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x28F44D8028F449", Offset = "0x0", VA = "0x28F44F0028F449", Slot = "2")]
	void NGPAKPBNKHO();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x28F44D8A71C474", Offset = "0x0", VA = "0x28F44F0A71C474", Slot = "3")]
	void KLLBDGJIJFN();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xA71C4628028F4A0", Offset = "0x0", VA = "0xA71C4640028F4A0", Slot = "4")]
	void JLENIKEFKEG(string GGLGKJIKCHI, [Optional] string AFGFCIFDHKB);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface APBHODKIPIN
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface MEPDAJPKLID : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	HPAJLGJPDIL NHCBGHAODLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x28F4C38028F4A0", Offset = "0x0", VA = "0x28F4C50028F4A0", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool FMHKDAOJBCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x28F4C38A50F614", Offset = "0x0", VA = "0x28F4C50A50F614", Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<BPMMEPAJAOO> NHNPLOAJPOH;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x28F5C78A71C964", Offset = "0x0", VA = "0x28F5C90A71C964", Slot = "4")]
	Task HINDDHMAHAN();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0xA71C9728028F5CF", Offset = "0x0", VA = "0xA71C9740028F5CF", Slot = "5")]
	void NJEMNKBBDAD();
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

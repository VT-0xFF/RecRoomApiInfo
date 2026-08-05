using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface AOECCADAPGP
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x281D308A48134C", Offset = "0x0", VA = "0x281D320A48134C", Slot = "0")]
	void OCEACCPBFJG(string MNDDLCFKAGB, string KHEJFPBNFJI, bool BBJBMDAHLJC);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xA48133A80281D83", Offset = "0x0", VA = "0xA48133C00281D83", Slot = "1")]
	void PEFPEOHAFFC();

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x281DB380281D90", Offset = "0x0", VA = "0x281DB500281D90", Slot = "2")]
	void DONOHAEGHMP();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x281DB38A26756C", Offset = "0x0", VA = "0x281DB50A26756C", Slot = "3")]
	void CNMFONOKOOA();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xA48145E80281E66", Offset = "0x0", VA = "0xA48146000281E66", Slot = "4")]
	void HOGJBBHNHBG(string HJNBJJBDHME, [Optional] string DOHGHOELHDA);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface NLJKNBIBKJA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool EKONAEDGCLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x281EB580281E66", Offset = "0x0", VA = "0x281EB700281E66", Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface FEMBOANNIHC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool DJBGBNMKLFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x281EB58A48147C", Offset = "0x0", VA = "0x281EB70A48147C", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<EKMAJMLIIJL> JOAHOFELMAI;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x281F0E8A48147C", Offset = "0x0", VA = "0x281F100A48147C", Slot = "3")]
	Task PNLKNBIHCGI();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0xA41956A80281F35", Offset = "0x0", VA = "0xA41956C00281F35", Slot = "4")]
	void LJOBMJGJKLI();
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

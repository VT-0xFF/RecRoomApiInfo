using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface EENGHMGFLOA
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xA5F6C7680296375", Offset = "0x0", VA = "0xA5F6C7800296375", Slot = "0")]
	void NCKPAOIEEMC(string NIKFJOMNMCL, string DKPNEJDCMNF, bool MMEPPMODIKL);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x29641E80296375", Offset = "0x0", VA = "0x29642000296375", Slot = "1")]
	void MIFAENLKPCK();

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x29641E8A8040A8", Offset = "0x0", VA = "0x2964200A8040A8", Slot = "2")]
	void NOEEIEKBCDH();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0xA8040C280296471", Offset = "0x0", VA = "0xA8040C400296471", Slot = "3")]
	void DLCNKODFADG();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x29647580296471", Offset = "0x0", VA = "0x29647700296471", Slot = "4")]
	void KPPFJDNMMAF(string FONNPINLHLC, [Optional] string JIKOKHBBMFB);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface DFDIEOCMNKA
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface PBOBJPLMOIJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	GEAEDAGDAEC IPOLDMJOJKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2964758A8040D4", Offset = "0x0", VA = "0x2964770A8040D4", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool KCKFIDJFIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA8040C2802964C8", Offset = "0x0", VA = "0xA8040C4002964C8", Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<MKAEOEPBNAN> EDOMDCNDDJD;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xA804966802965A8", Offset = "0x0", VA = "0xA804968002965A8", Slot = "4")]
	Task DDNLIMMJHCH();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2965F7802965A8", Offset = "0x0", VA = "0x2965F9002965A8", Slot = "5")]
	void AKMCCPCKADJ();
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

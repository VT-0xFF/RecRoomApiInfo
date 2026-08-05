using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface JPPFHEECCAL
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x250A9E898A586C", Offset = "0x0", VA = "0x250AA0098A586C", Slot = "0")]
	void EOKAFBAEFBH(string DEOCADMKOKD, string GHOHMHIJIEH, bool JKDJHEKPJAC);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x98A672280250AF4", Offset = "0x0", VA = "0x98A672400250AF4", Slot = "1")]
	void MHDPJBMJNJK();

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x250B2C80250B00", Offset = "0x0", VA = "0x250B2E00250B00", Slot = "2")]
	void LCBLIKCNFDD();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x250B2E898A5C10", Offset = "0x0", VA = "0x250B30098A5C10", Slot = "3")]
	void MOIPPKDGMEA();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x98A5C0E80250B60", Offset = "0x0", VA = "0x98A5C1000250B60", Slot = "4")]
	void CEIFICGBEBL(string BKKGCFBPGLD, [Optional] string MKHGFLAKGLA);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface KHENNCPOOPP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool FECBOBMKPHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x250B8A80250B60", Offset = "0x0", VA = "0x250B8C00250B60", Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface ALNBLHJAHHO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool KOKFGJOEDAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x250B8E898A5C10", Offset = "0x0", VA = "0x250B90098A5C10", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<HMJJAEMPFOC> IIFOKILMFDN;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x250BEE898A45B0", Offset = "0x0", VA = "0x250BF0098A45B0", Slot = "3")]
	Task GEJAFFIMNGM();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x98A45AE80250C16", Offset = "0x0", VA = "0x98A45B000250C16", Slot = "4")]
	void MNHGCJGIAKL();
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

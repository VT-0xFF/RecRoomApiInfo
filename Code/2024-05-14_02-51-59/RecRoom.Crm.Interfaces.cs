using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface LJDFNKAGFOM
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x9A88F9280255B04", Offset = "0x0", VA = "0x9A88F9400255B04", Slot = "0")]
	void PNMILLMIGAN(string NNIANKHDAIC, string IOCAEGELOCM, bool LNHICENAGPE);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x255B8E80255B10", Offset = "0x0", VA = "0x255B9000255B10", Slot = "1")]
	void PGCMOEBPGPB();

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x255B8E89A85F64", Offset = "0x0", VA = "0x255B9009A85F64", Slot = "2")]
	void JBAOLNMEKNM();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x9A8A50280255C22", Offset = "0x0", VA = "0x9A8A50400255C22", Slot = "3")]
	void HNJMLEJHOIC();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x255CC280255C30", Offset = "0x0", VA = "0x255CC400255C30", Slot = "4")]
	void MCMIDOKFIMK(string CICMLCANLNN, [Optional] string EJPJDCENJLD);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface JMIHKBFJCGH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool PIBJFDBPDPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x255CCE89A88F94", Offset = "0x0", VA = "0x255CD009A88F94", Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface LJFNNDDAEKF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool JOMHMICEPCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9A85F6280255D50", Offset = "0x0", VA = "0x9A85F6400255D50", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<GNGKKPHDGEG> NCIMFLMJIDL;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x9A8A50280255E82", Offset = "0x0", VA = "0x9A8A50400255E82", Slot = "3")]
	Task MPOMBMILLLK();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x255ECE80255EA0", Offset = "0x0", VA = "0x255ED000255EA0", Slot = "4")]
	void EMPGGONCJIE();
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

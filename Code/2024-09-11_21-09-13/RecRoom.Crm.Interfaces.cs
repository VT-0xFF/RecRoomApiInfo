using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface KEMPDDCCHAB
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xA6A87A680288344", Offset = "0x0", VA = "0xA6A87A800288344", Slot = "0")]
	void IPILPJKLDIC(string GMFFCCGBINJ, string IAJCNPAMADF, bool GHBOHLOKCCL);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x28839380288344", Offset = "0x0", VA = "0x28839500288344", Slot = "1")]
	void NGFECNIHLJL();

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x28839E8A6A8798", Offset = "0x0", VA = "0x2883A00A6A8798", Slot = "2")]
	void LHBAIIEGAKL();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0xA497F1A802883C5", Offset = "0x0", VA = "0xA497F1C002883C5", Slot = "3")]
	void BPKCKPCNOFM();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x288474802883C5", Offset = "0x0", VA = "0x288476002883C5", Slot = "4")]
	void DHJCAAAEEPL(string FBCNKAADCGD, [Optional] string OGCJFOGNEND);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface MGLGPKEGECD
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface NEIIMNIBCIO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	BJINABDIOMD MDFCOEBOEFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2884748A6A78DC", Offset = "0x0", VA = "0x2884760A6A78DC", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool FGDHCLCAKGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA6A78F6802884C7", Offset = "0x0", VA = "0xA6A78F8002884C7", Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<PAIBKKHNFOG> FIGNFBEKPCM;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xA6A78F68028851E", Offset = "0x0", VA = "0xA6A78F80028851E", Slot = "4")]
	Task AIFHKOLJDOL();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x28854380288520", Offset = "0x0", VA = "0x28854500288520", Slot = "5")]
	void LFBMALNLGLI();
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

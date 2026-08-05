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
	[Cpp2IlInjected.Address(RVA = "0x2903C38A5B627C", Offset = "0x0", VA = "0x2903C50A5B627C", Slot = "0")]
	void IPILPJKLDIC(string GMFFCCGBINJ, string IAJCNPAMADF, bool GHBOHLOKCCL);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xA7C4E1A80290476", Offset = "0x0", VA = "0xA7C4E1C00290476", Slot = "1")]
	void NGFECNIHLJL();

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2904C580290476", Offset = "0x0", VA = "0x2904C700290476", Slot = "2")]
	void LHBAIIEGAKL();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2904C58A7C4E38", Offset = "0x0", VA = "0x2904C70A7C4E38", Slot = "3")]
	void BPKCKPCNOFM();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xA7C4E46802904CD", Offset = "0x0", VA = "0xA7C4E48002904CD", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x29051C802904CD", Offset = "0x0", VA = "0x29051E002904CD", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool FGDHCLCAKGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x29051E8A7C4E38", Offset = "0x0", VA = "0x2905200A7C4E38", Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<PAIBKKHNFOG> FIGNFBEKPCM;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2905F48A7C479C", Offset = "0x0", VA = "0x2905F60A7C479C", Slot = "4")]
	Task AIFHKOLJDOL();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0xA7C47B680290647", Offset = "0x0", VA = "0xA7C47B800290647", Slot = "5")]
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

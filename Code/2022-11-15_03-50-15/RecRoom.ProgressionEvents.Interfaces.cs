using System;
using System.Reflection;
using Cpp2IlInjected;
using RecNet;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface FGCGGIMBFOD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	ProgressionEventDTO NJIANAJJFIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x232BE0876B3C8C", Offset = "0x0", VA = "0x232BE2076B3C8C", Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	ProgressionEventRecordDTO CDMBKHNNKAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x76B3CAA80232C2B", Offset = "0x0", VA = "0x76B3CAC00232C2B", Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	IEMLFHKGAKI EBDIMHKBFLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x232C2F80232C2B", Offset = "0x0", VA = "0x232C3100232C2B", Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	int HCEEFOKCCGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x232C2F876B3CBC", Offset = "0x0", VA = "0x232C31076B3CBC", Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool LMCKMGCDDEI
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x76B3FFE80232D68", Offset = "0x0", VA = "0x76B400000232D68", Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action KNHEECBACDH;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action AAJMLKIAJLE;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x76B3CAA80232C7A", Offset = "0x0", VA = "0x76B3CAC00232C7A", Slot = "8")]
	global::LFIHKJLGIGB<bool> KEDCDIMAMGC();

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x232CA780232C80", Offset = "0x0", VA = "0x232CA900232C80", Slot = "9")]
	JFOAFMPHLMG EKJMAOOKDBH();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x232CA787675244", Offset = "0x0", VA = "0x232CA907675244", Slot = "10")]
	JFOAFMPHLMG JKNLBGNBJOP(int PAJJPPKFEFM);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x232DAF80232D68", Offset = "0x0", VA = "0x232DB100232D68", Slot = "12")]
	void IAKNGCPGJMO();
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

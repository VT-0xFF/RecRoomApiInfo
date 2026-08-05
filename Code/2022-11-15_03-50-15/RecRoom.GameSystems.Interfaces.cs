using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecNet;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface GJFDOABAEHL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool EKIDPDEGDOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x76B402E80232DB7", Offset = "0x0", VA = "0x76B403000232DB7", Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface DOEGGINEFGD
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action IIMMFKLALFP;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x760488E80232E27", Offset = "0x0", VA = "0x760489000232E27", Slot = "2")]
	bool CGPPDLGPLAD(NNOLNDPAGMJ ANIGGFOCLPL);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x232EDB80232E27", Offset = "0x0", VA = "0x232EDD00232E27", Slot = "3")]
	void FBHCFCLMHBB();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface LJGFIMGHDKL
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool ALFAPMHJHCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x232EDB876B515C", Offset = "0x0", VA = "0x232EDD076B515C", Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface DAEKJBALILI
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x76B517A80232F26", Offset = "0x0", VA = "0x76B517C00232F26", Slot = "0")]
	IDisposable Play(IFCBIBDFLGA IHGLPEJGPCK, string IEBEKEDOFNO, float AGKDNDKKLHG, [Optional] Action MLFGBBGKHEO, [Optional] object GIAGCHKFJKD);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x232F2A80232F26", Offset = "0x0", VA = "0x232F2C00232F26", Slot = "1")]
	IDisposable Play(IFCBIBDFLGA IHGLPEJGPCK, float BKBGFCGOJNN, PPBLKGBCBFA BHKGNKAJKCK, string IEBEKEDOFNO, Color? GINAALHBOGD, string GMEJIKBDABM, Color? BEIMLKFMAEI, float AGKDNDKKLHG, [Optional] Action MLFGBBGKHEO, [Optional] object GIAGCHKFJKD);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface OMEAFNBMLLG
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x232F2A876B518C", Offset = "0x0", VA = "0x232F2C076B518C", Slot = "0")]
	void CCIBOHKBILI(CDANCKEKNJL DJFJBIDFPMN, List<KeepsakeInstanceDTO> HABIGOGKDCA);
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

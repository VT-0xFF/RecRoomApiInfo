using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface ONIFAAIEHOP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool NPGPKDCLMMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x2B5906802B58B7", Offset = "0x0", VA = "0x2B5908002B58B7", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	MIPKPFFHABJ HAMHGLAGBGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2B590E8ACF4B9C", Offset = "0x0", VA = "0x2B59100ACF4B9C", Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	MIPKPFFHABJ IBGHNHIKCAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAAE416A802B5935", Offset = "0x0", VA = "0xAAE416C002B5935", Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	List<string> DLFFLJHEEDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2B59E4802B5935", Offset = "0x0", VA = "0x2B59E6002B5935", Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2B59E48ACF5CE0", Offset = "0x0", VA = "0x2B59E60ACF5CE0", Slot = "4")]
	void AFCLDBMJAPB(List<(string, PLNKHDFAHFD.GFOEIHGPCGD)> AFJFPOAHKHM);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0xACF5CFA802B5A37", Offset = "0x0", VA = "0xACF5CFC002B5A37", Slot = "5")]
	string[] PIDNDCAABLC(string DKOFDDEGFIN);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2B5A3B802B5A37", Offset = "0x0", VA = "0x2B5A3D002B5A37", Slot = "6")]
	bool KDINJCNKBBA(string DKOFDDEGFIN);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2B5A3B8ACF5D0C", Offset = "0x0", VA = "0x2B5A3D0ACF5D0C", Slot = "7")]
	string KEMOAOBFHHG(string DKOFDDEGFIN);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0xACF5CFA802B5A8E", Offset = "0x0", VA = "0xACF5CFC002B5A8E", Slot = "8")]
	PLNKHDFAHFD.GFOEIHGPCGD KIBNADODHGD(string DKOFDDEGFIN);
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

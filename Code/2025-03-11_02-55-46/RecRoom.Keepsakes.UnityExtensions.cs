using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class BEDLNDJDEIP
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7636770", Offset = "0x7635B70", VA = "0x187636770")]
	public static KeepsakeTheme NMNOOKNOHCN(this CMBFELMIEKF FDIJEKJEAKE, Guid JFGNPLFCOBO)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7636870", Offset = "0x7635C70", VA = "0x187636870")]
	public static KeepsakeTheme NMNOOKNOHCN(this CMBFELMIEKF FDIJEKJEAKE, DINILGKMLAO EEFFHNHPOGC)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x76366A0", Offset = "0x7635AA0", VA = "0x1876366A0")]
	public static List<KeepsakeTheme> NKIDCHBHPFJ(this CMBFELMIEKF FDIJEKJEAKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7636600", Offset = "0x7635A00", VA = "0x187636600")]
	public static DINILGKMLAO IPDPBGBBBBO(this CMBFELMIEKF FDIJEKJEAKE, Guid JFGNPLFCOBO)
	{
		return default(DINILGKMLAO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7636570", Offset = "0x7635970", VA = "0x187636570")]
	public static int AOEJMGLDKBO(this CMBFELMIEKF FDIJEKJEAKE, DINILGKMLAO HPIOPHHLCME)
	{
		return default(int);
	}
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

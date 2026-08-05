using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class LDMALEKFOKG
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7CE9670", Offset = "0x7CE8870", VA = "0x187CE9670")]
	public static KeepsakeTheme KBKFPKAIOLN(this EGLMAECMKPK MHGFNMBGACA, Guid NKDDAALENNJ)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7CE9770", Offset = "0x7CE8970", VA = "0x187CE9770")]
	public static KeepsakeTheme KBKFPKAIOLN(this EGLMAECMKPK MHGFNMBGACA, DCGPHHIICLO LNOADGDMCIN)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7CE98D0", Offset = "0x7CE8AD0", VA = "0x187CE98D0")]
	public static List<KeepsakeTheme> LPMHHCBGPPA(this EGLMAECMKPK MHGFNMBGACA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7CE9830", Offset = "0x7CE8A30", VA = "0x187CE9830")]
	public static DCGPHHIICLO LHEGLNOJCPE(this EGLMAECMKPK MHGFNMBGACA, Guid NKDDAALENNJ)
	{
		return default(DCGPHHIICLO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7CE99A0", Offset = "0x7CE8BA0", VA = "0x187CE99A0")]
	public static int ODAPLNPHAPA(this EGLMAECMKPK MHGFNMBGACA, DCGPHHIICLO IJHPGCNFKNG)
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

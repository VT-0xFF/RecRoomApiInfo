using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class GJPLMEGDONK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum BEKJAOJANFJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void ECJDDPEKIIB(IntPtr DKKNMPCNGDF, int FOADGJOOFID, int IFGKCEMALDJ);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int KJPLGBMFOPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6012610", Offset = "0x6011A10", VA = "0x186012610")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6012770", Offset = "0x6011B70", VA = "0x186012770")]
	private static extern void IMGAOFECAJM(ECJDDPEKIIB EGLKIOCIBPB);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6012880", Offset = "0x6011C80", VA = "0x186012880")]
	[MonoPInvokeCallback(typeof(ECJDDPEKIIB))]
	private static void LEGIAPLEFMN(IntPtr DKKNMPCNGDF, int FOADGJOOFID, int IFGKCEMALDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6012A30", Offset = "0x6011E30", VA = "0x186012A30")]
	private static extern void PAICICMJOCE();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6012680", Offset = "0x6011A80", VA = "0x186012680")]
	private static extern void HLKDCKOBAEJ();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6012610", Offset = "0x6011A10", VA = "0x186012610")]
	private static extern int AJEGLAPIDBL();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x60129B0", Offset = "0x6011DB0", VA = "0x1860129B0")]
	private static extern int MBAGBICJAMJ(int FBDAFGPAOAL);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x60126F0", Offset = "0x6011AF0", VA = "0x1860126F0")]
	private static extern int HCOGDDHGCPI(int FBDAFGPAOAL);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6012800", Offset = "0x6011C00", VA = "0x186012800")]
	private static extern int JCLMCLELFID(int FBDAFGPAOAL);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6012AA0", Offset = "0x6011EA0", VA = "0x186012AA0")]
	private static extern int PJLDDFBADOP(int FBDAFGPAOAL);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6012D10", Offset = "0x6012110", VA = "0x186012D10")]
	public GJPLMEGDONK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6012680", Offset = "0x6011A80", VA = "0x186012680", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6012B20", Offset = "0x6011F20", VA = "0x186012B20")]
	public Rect PPEKIFFADGN(int PADNJNCKMNI)
	{
		return default(Rect);
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

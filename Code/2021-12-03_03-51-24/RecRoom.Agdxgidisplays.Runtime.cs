using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class IBMIPKCMHNP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum MEDCEEAKJOJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void GPPFBINPDOB(IntPtr CHGGHPLKPDC, int AEFLDANFMFH, int FKEBHCOFGKO);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int AKBGBAMEKCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3F9FEB0", Offset = "0x3F9F0B0", VA = "0x183F9FEB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3FA01B0", Offset = "0x3F9F3B0", VA = "0x183FA01B0")]
	private static extern void HLJOAAGHLEA(GPPFBINPDOB BILBMIBDIIJ);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3FA0090", Offset = "0x3F9F290", VA = "0x183FA0090")]
	[MonoPInvokeCallback(typeof(GPPFBINPDOB))]
	private static void HJONAFEHJBI(IntPtr CHGGHPLKPDC, int AEFLDANFMFH, int FKEBHCOFGKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3F9FFA0", Offset = "0x3F9F1A0", VA = "0x183F9FFA0")]
	private static extern void GKJAAEEMOPM();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3F9FDC0", Offset = "0x3F9EFC0", VA = "0x183F9FDC0")]
	private static extern void CHMIOACNMOG();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3F9FEB0", Offset = "0x3F9F0B0", VA = "0x183F9FEB0")]
	private static extern int DGCHJCNMPAO();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3F9FE30", Offset = "0x3F9F030", VA = "0x183F9FE30")]
	private static extern int CPGFABKJJGP(int EAOOANIBOHM);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3FA0240", Offset = "0x3F9F440", VA = "0x183FA0240")]
	private static extern int JBKEBNAOAJC(int EAOOANIBOHM);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3FA0010", Offset = "0x3F9F210", VA = "0x183FA0010")]
	private static extern int HHLFPAPIJML(int EAOOANIBOHM);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3F9FF20", Offset = "0x3F9F120", VA = "0x183F9FF20")]
	private static extern int EGFGKIMFLGM(int EAOOANIBOHM);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3FA04B0", Offset = "0x3F9F6B0", VA = "0x183FA04B0")]
	public IBMIPKCMHNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3F9FDC0", Offset = "0x3F9EFC0", VA = "0x183F9FDC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3FA02C0", Offset = "0x3F9F4C0", VA = "0x183FA02C0")]
	public Rect LPBKIKLOJAA(int JEHLAGFBABJ)
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

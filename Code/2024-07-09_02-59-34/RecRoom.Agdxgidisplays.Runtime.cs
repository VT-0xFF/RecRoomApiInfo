using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class ONFJHGCHFPI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum HHIBLHPFECN
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void NOGMHHEAHFE(IntPtr KAIGMLIOMBJ, int INGCLKPLIOP, int LCFLPNOCGHO);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int JEOCEOGEHJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x683BB60", Offset = "0x683A760", VA = "0x18683BB60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x683BAD0", Offset = "0x683A6D0", VA = "0x18683BAD0")]
	private static extern void EMFHBGPLGOB(NOGMHHEAHFE LABOKGHKKOB);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x683BBD0", Offset = "0x683A7D0", VA = "0x18683BBD0")]
	[MonoPInvokeCallback(typeof(NOGMHHEAHFE))]
	private static void GPMJDINOKFK(IntPtr KAIGMLIOMBJ, int INGCLKPLIOP, int LCFLPNOCGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x683BDD0", Offset = "0x683A9D0", VA = "0x18683BDD0")]
	private static extern void NJFEGHENHFC();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x683BA60", Offset = "0x683A660", VA = "0x18683BA60")]
	private static extern void DJBCCFACCEI();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x683BB60", Offset = "0x683A760", VA = "0x18683BB60")]
	private static extern int NBLJGIFNCOO();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x683B960", Offset = "0x683A560", VA = "0x18683B960")]
	private static extern int BDEDDKENCFE(int CABAGOHBNFK);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x683B9E0", Offset = "0x683A5E0", VA = "0x18683B9E0")]
	private static extern int DEOLFGABEEC(int CABAGOHBNFK);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x683BD50", Offset = "0x683A950", VA = "0x18683BD50")]
	private static extern int NBNCAJLDAJD(int CABAGOHBNFK);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x683BCD0", Offset = "0x683A8D0", VA = "0x18683BCD0")]
	private static extern int HMDABPIGMDI(int CABAGOHBNFK);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x683BE40", Offset = "0x683AA40", VA = "0x18683BE40")]
	public ONFJHGCHFPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x683BA60", Offset = "0x683A660", VA = "0x18683BA60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x683B770", Offset = "0x683A370", VA = "0x18683B770")]
	public Rect BCOCIPNCIKN(int IKDBCDDCCJG)
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

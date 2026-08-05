using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class KHBHMLBKHMJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum HCLLBLONBBF
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void MGHECDELFKP(IntPtr IPMGANOCOKF, int GPNBMIDFKMK, int IDLJKEDDJLO);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int NKOPCDIOOHM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7CE4D60", Offset = "0x7CE3360", VA = "0x187CE4D60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7CE4CD0", Offset = "0x7CE32D0", VA = "0x187CE4CD0")]
	private static extern void HECEBOHAPBC(MGHECDELFKP BNOBGIHHJGL);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7CE4BD0", Offset = "0x7CE31D0", VA = "0x187CE4BD0")]
	[MonoPInvokeCallback(typeof(MGHECDELFKP))]
	private static void GPBPNHILGOJ(IntPtr IPMGANOCOKF, int GPNBMIDFKMK, int IDLJKEDDJLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7CE4B60", Offset = "0x7CE3160", VA = "0x187CE4B60")]
	private static extern void FLMOPKJJIJF();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7CE4AF0", Offset = "0x7CE30F0", VA = "0x187CE4AF0")]
	private static extern void JEEIEGNOEPI();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7CE4D60", Offset = "0x7CE3360", VA = "0x187CE4D60")]
	private static extern int IFAPANLLCCI();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7CE4DD0", Offset = "0x7CE33D0", VA = "0x187CE4DD0")]
	private static extern int JFNLELPKILK(int HLIPPIOIAJK);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7CE4970", Offset = "0x7CE2F70", VA = "0x187CE4970")]
	private static extern int BBKPNIAJNJA(int HLIPPIOIAJK);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7CE4A70", Offset = "0x7CE3070", VA = "0x187CE4A70")]
	private static extern int BGCOJLPAAPG(int HLIPPIOIAJK);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7CE49F0", Offset = "0x7CE2FF0", VA = "0x187CE49F0")]
	private static extern int BDJIPFIEDIE(int HLIPPIOIAJK);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7CE5040", Offset = "0x7CE3640", VA = "0x187CE5040")]
	public KHBHMLBKHMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7CE4AF0", Offset = "0x7CE30F0", VA = "0x187CE4AF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7CE4E50", Offset = "0x7CE3450", VA = "0x187CE4E50")]
	public Rect NMKABMKGJLE(int FFPDMODNJPG)
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

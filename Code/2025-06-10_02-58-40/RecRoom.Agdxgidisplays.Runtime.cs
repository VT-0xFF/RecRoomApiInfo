using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class PGDIIIODHIL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum COONMKKBOPA
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void LLAHHFPCFKC(IntPtr IKFDGIFGHKP, int GCFCAGDGDIN, int CMACOHIAFHM);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int MMOFHLILJAD
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x79A0170", Offset = "0x799F370", VA = "0x1879A0170")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x79A00E0", Offset = "0x799F2E0", VA = "0x1879A00E0")]
	private static extern void ANABMDIKHMO(LLAHHFPCFKC MHPGHAHOBNK);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x79A0350", Offset = "0x799F550", VA = "0x1879A0350")]
	[MonoPInvokeCallback(typeof(LLAHHFPCFKC))]
	private static void GHAIGDMPLAI(IntPtr IKFDGIFGHKP, int GCFCAGDGDIN, int CMACOHIAFHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x79A0070", Offset = "0x799F270", VA = "0x1879A0070")]
	private static extern void AFLILFPIJAH();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x79A01E0", Offset = "0x799F3E0", VA = "0x1879A01E0")]
	private static extern void NNMDKLHBCOM();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x79A0170", Offset = "0x799F370", VA = "0x1879A0170")]
	private static extern int HHNPLPIFKIL();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x79A04D0", Offset = "0x799F6D0", VA = "0x1879A04D0")]
	private static extern int KJNOHEMKKKN(int APBCLGNDGBE);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x79A0250", Offset = "0x799F450", VA = "0x1879A0250")]
	private static extern int EECBNFPMKBD(int APBCLGNDGBE);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x79A02D0", Offset = "0x799F4D0", VA = "0x1879A02D0")]
	private static extern int GDHFGLEBDJH(int APBCLGNDGBE);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x79A0450", Offset = "0x799F650", VA = "0x1879A0450")]
	private static extern int IOPMKENDNJN(int APBCLGNDGBE);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x79A0740", Offset = "0x799F940", VA = "0x1879A0740")]
	public PGDIIIODHIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x79A01E0", Offset = "0x799F3E0", VA = "0x1879A01E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x79A0550", Offset = "0x799F750", VA = "0x1879A0550")]
	public Rect OIABEMNFIPC(int FKKLMAOCCNH)
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

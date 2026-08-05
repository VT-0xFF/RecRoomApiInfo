using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class IGKLGDOOHEM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum LIHKNDIMDBP
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void MHIFDMGANBI(IntPtr MGALKMHOLCM, int JAFKPMJIGFL, int FFNBDDMHMOK);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int GJMOFNHKIIF
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x79F2D40", Offset = "0x79F1F40", VA = "0x1879F2D40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x79F2FA0", Offset = "0x79F21A0", VA = "0x1879F2FA0")]
	private static extern void OKOKFJAHPIP(MHIFDMGANBI LKEPFHDAAED);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x79F2BD0", Offset = "0x79F1DD0", VA = "0x1879F2BD0")]
	[MonoPInvokeCallback(typeof(MHIFDMGANBI))]
	private static void CFFANHCJLHF(IntPtr MGALKMHOLCM, int JAFKPMJIGFL, int FFNBDDMHMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x79F2DB0", Offset = "0x79F1FB0", VA = "0x1879F2DB0")]
	private static extern void ILLMBOBOELN();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x79F2CD0", Offset = "0x79F1ED0", VA = "0x1879F2CD0")]
	private static extern void DCBAHHEFNOO();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x79F2D40", Offset = "0x79F1F40", VA = "0x1879F2D40")]
	private static extern int IMGPNFGGMLF();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x79F2E20", Offset = "0x79F2020", VA = "0x1879F2E20")]
	private static extern int JCLOJMOJMMP(int MKHHKDJKLDN);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x79F2B50", Offset = "0x79F1D50", VA = "0x1879F2B50")]
	private static extern int CDHIMJPCEIN(int MKHHKDJKLDN);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x79F2EA0", Offset = "0x79F20A0", VA = "0x1879F2EA0")]
	private static extern int JFAEBDKMDGH(int MKHHKDJKLDN);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x79F2F20", Offset = "0x79F2120", VA = "0x1879F2F20")]
	private static extern int MIMNNJEEEFD(int MKHHKDJKLDN);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x79F3030", Offset = "0x79F2230", VA = "0x1879F3030")]
	public IGKLGDOOHEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x79F2CD0", Offset = "0x79F1ED0", VA = "0x1879F2CD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x79F2960", Offset = "0x79F1B60", VA = "0x1879F2960")]
	public Rect BLLIEGGHFKB(int APFEHAODJME)
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

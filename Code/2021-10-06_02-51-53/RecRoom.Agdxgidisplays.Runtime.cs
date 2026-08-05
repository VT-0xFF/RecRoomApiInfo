using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class AMAONNBNCCF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum LPIBNHNFKIO
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void LEPMIEDAGJO(IntPtr HBENBLLOAFP, int DFDGHCFEOOK, int PKOIKMGPCJG);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int OKEKGOPLAIK
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3D0D110", Offset = "0x3D0C110", VA = "0x183D0D110")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3D0D310", Offset = "0x3D0C310", VA = "0x183D0D310")]
	private static extern void HHLJKPNDEEB(LEPMIEDAGJO GAMOMGCMAHI);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3D0D180", Offset = "0x3D0C180", VA = "0x183D0D180")]
	[MonoPInvokeCallback(typeof(LEPMIEDAGJO))]
	private static void GIABFAJOAAD(IntPtr HBENBLLOAFP, int DFDGHCFEOOK, int PKOIKMGPCJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3D0D2A0", Offset = "0x3D0C2A0", VA = "0x183D0D2A0")]
	private static extern void HAEHJBELNGJ();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3D0D0A0", Offset = "0x3D0C0A0", VA = "0x183D0D0A0")]
	private static extern void LIODNHIMAPO();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3D0D110", Offset = "0x3D0C110", VA = "0x183D0D110")]
	private static extern int EDLFNBECCOJ();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3D0CF20", Offset = "0x3D0BF20", VA = "0x183D0CF20")]
	private static extern int AAMEBBJIINK(int KOCMKCCBGOB);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3D0D020", Offset = "0x3D0C020", VA = "0x183D0D020")]
	private static extern int DPGJHFOKMBB(int KOCMKCCBGOB);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3D0D590", Offset = "0x3D0C590", VA = "0x183D0D590")]
	private static extern int OFLDCJHMFHN(int KOCMKCCBGOB);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3D0CFA0", Offset = "0x3D0BFA0", VA = "0x183D0CFA0")]
	private static extern int BNDEJNMGOBJ(int KOCMKCCBGOB);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3D0D610", Offset = "0x3D0C610", VA = "0x183D0D610")]
	public AMAONNBNCCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3D0D0A0", Offset = "0x3D0C0A0", VA = "0x183D0D0A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3D0D3A0", Offset = "0x3D0C3A0", VA = "0x183D0D3A0")]
	public Rect LOLEMADMCPC(int CIDLCBFAGOE)
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

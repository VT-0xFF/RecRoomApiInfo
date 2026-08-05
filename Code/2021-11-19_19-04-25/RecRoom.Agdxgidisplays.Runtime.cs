using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class DKJPDKKBAGL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum EHENINBGJDI
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void HJPLGBAMINH(IntPtr JGIGJNGMAMM, int JMGGFMEEKPN, int FAAFPKNKNBG);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int GMIHPFKKKIO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3D9FC80", Offset = "0x3D9EC80", VA = "0x183D9FC80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3D9F8E0", Offset = "0x3D9E8E0", VA = "0x183D9F8E0")]
	private static extern void IHHFNKLMDIE(HJPLGBAMINH PBCLPMFCHNG);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3D9FB60", Offset = "0x3D9EB60", VA = "0x183D9FB60")]
	[MonoPInvokeCallback(typeof(HJPLGBAMINH))]
	private static void LBDHLBKNCJE(IntPtr JGIGJNGMAMM, int JMGGFMEEKPN, int FAAFPKNKNBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3D9F680", Offset = "0x3D9E680", VA = "0x183D9F680")]
	private static extern void AAIBGKJCEGA();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3D9F770", Offset = "0x3D9E770", VA = "0x183D9F770")]
	private static extern void PNNAIPGOLOB();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3D9FC80", Offset = "0x3D9EC80", VA = "0x183D9FC80")]
	private static extern int LPOIJDMMAEB();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3D9FCF0", Offset = "0x3D9ECF0", VA = "0x183D9FCF0")]
	private static extern int MKEEJBJFPEL(int JLIONFOJGGD);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3D9F860", Offset = "0x3D9E860", VA = "0x183D9F860")]
	private static extern int HBMHNDLKGBB(int JLIONFOJGGD);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3D9F7E0", Offset = "0x3D9E7E0", VA = "0x183D9F7E0")]
	private static extern int EECDGECFJNB(int JLIONFOJGGD);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3D9F6F0", Offset = "0x3D9E6F0", VA = "0x183D9F6F0")]
	private static extern int DGPPCNPMKFL(int JLIONFOJGGD);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3D9FD70", Offset = "0x3D9ED70", VA = "0x183D9FD70")]
	public DKJPDKKBAGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3D9F770", Offset = "0x3D9E770", VA = "0x183D9F770", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3D9F970", Offset = "0x3D9E970", VA = "0x183D9F970")]
	public Rect KOACEGOHOLN(int KNAJAMNALNO)
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

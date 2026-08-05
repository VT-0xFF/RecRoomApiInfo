using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class KKALPHKIKHO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum KEIHKHELPMD
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void AJIAKEDJNOG(IntPtr AIJPHINHCJO, int MKJBDDDPMKM, int FGOOIEIHBJP);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int ENFPIENDNGF
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6070B70", Offset = "0x606FD70", VA = "0x186070B70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x60709F0", Offset = "0x606FBF0", VA = "0x1860709F0")]
	private static extern void EGGMINPOGNI(AJIAKEDJNOG IAPBAMILEGB);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x60707F0", Offset = "0x606F9F0", VA = "0x1860707F0")]
	[MonoPInvokeCallback(typeof(AJIAKEDJNOG))]
	private static void BJMPKANMOCP(IntPtr AIJPHINHCJO, int MKJBDDDPMKM, int FGOOIEIHBJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6070A80", Offset = "0x606FC80", VA = "0x186070A80")]
	private static extern void GEJAFFIMNGM();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6070780", Offset = "0x606F980", VA = "0x186070780")]
	private static extern void BDONEMGJLIA();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6070B70", Offset = "0x606FD70", VA = "0x186070B70")]
	private static extern int KFBKOALNFCH();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6070970", Offset = "0x606FB70", VA = "0x186070970")]
	private static extern int EBLDLODKPFA(int JNIKIHKLGAD);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6070AF0", Offset = "0x606FCF0", VA = "0x186070AF0")]
	private static extern int IBHALFGPOPC(int JNIKIHKLGAD);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x60708F0", Offset = "0x606FAF0", VA = "0x1860708F0")]
	private static extern int CMBNHNHAAPM(int JNIKIHKLGAD);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6070510", Offset = "0x606F710", VA = "0x186070510")]
	private static extern int BBEBKJCNFDN(int JNIKIHKLGAD);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6070BE0", Offset = "0x606FDE0", VA = "0x186070BE0")]
	public KKALPHKIKHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6070780", Offset = "0x606F980", VA = "0x186070780", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6070590", Offset = "0x606F790", VA = "0x186070590")]
	public Rect BBNBDKHMIMJ(int PEJLLJAKMBH)
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

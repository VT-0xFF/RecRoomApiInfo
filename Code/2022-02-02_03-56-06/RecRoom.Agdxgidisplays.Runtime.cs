using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class CAOEKLCFKIL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum AKIIFPHLEOB
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void KCCLODGCELF(IntPtr AHGPNMJKOID, int MMNEHHBHOKO, int BLIICIMOFCH);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int AMGLJDBLKKG
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x46C74B0", Offset = "0x46C64B0", VA = "0x1846C74B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x46C77C0", Offset = "0x46C67C0", VA = "0x1846C77C0")]
	private static extern void JFDFBNKBDEN(KCCLODGCELF MBNIDEHOLID);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x46C7520", Offset = "0x46C6520", VA = "0x1846C7520")]
	[MonoPInvokeCallback(typeof(KCCLODGCELF))]
	private static void GCNAAGBFMMD(IntPtr AHGPNMJKOID, int MMNEHHBHOKO, int BLIICIMOFCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x46C7850", Offset = "0x46C6850", VA = "0x1846C7850")]
	private static extern void JJACNFBHGAP();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x46C7440", Offset = "0x46C6440", VA = "0x1846C7440")]
	private static extern void BHBKHMBDEPJ();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x46C74B0", Offset = "0x46C64B0", VA = "0x1846C74B0")]
	private static extern int CKOAAAEBCEJ();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x46C76C0", Offset = "0x46C66C0", VA = "0x1846C76C0")]
	private static extern int HPOGENNGJJI(int DDPAIIBBEOH);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x46C7640", Offset = "0x46C6640", VA = "0x1846C7640")]
	private static extern int GOEJDKGNBPB(int DDPAIIBBEOH);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x46C7740", Offset = "0x46C6740", VA = "0x1846C7740")]
	private static extern int IDNAADOIEKD(int DDPAIIBBEOH);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x46C7AB0", Offset = "0x46C6AB0", VA = "0x1846C7AB0")]
	private static extern int OOAFHCMJMLI(int DDPAIIBBEOH);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x46C7B30", Offset = "0x46C6B30", VA = "0x1846C7B30")]
	public CAOEKLCFKIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x46C7440", Offset = "0x46C6440", VA = "0x1846C7440", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x46C78C0", Offset = "0x46C68C0", VA = "0x1846C78C0")]
	public Rect NNOEAFDAEHC(int BJHCFHBAPCE)
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

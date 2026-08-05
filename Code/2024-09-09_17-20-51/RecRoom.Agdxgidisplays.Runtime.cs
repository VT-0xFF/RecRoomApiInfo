using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class GMJKOHCMKHI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum EDCJEFHKADI
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void DLCHGGBGPFD(IntPtr MGBHCKLJEHL, int ECFPAOHDFEB, int LCNMLPNPBEL);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int KDKOIAAFAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x69FC6E0", Offset = "0x69FB0E0", VA = "0x1869FC6E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x69FCCB0", Offset = "0x69FB6B0", VA = "0x1869FCCB0")]
	private static extern void PGPDGGJIBJG(DLCHGGBGPFD AGMLFHLAIFJ);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x69FCB30", Offset = "0x69FB530", VA = "0x1869FCB30")]
	[MonoPInvokeCallback(typeof(DLCHGGBGPFD))]
	private static void PCOJLHLGPBM(IntPtr MGBHCKLJEHL, int ECFPAOHDFEB, int LCNMLPNPBEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x69FC7D0", Offset = "0x69FB1D0", VA = "0x1869FC7D0")]
	private static extern void HINDDHMAHAN();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x69FC670", Offset = "0x69FB070", VA = "0x1869FC670")]
	private static extern void NOOGFMDGAEJ();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x69FC6E0", Offset = "0x69FB0E0", VA = "0x1869FC6E0")]
	private static extern int EGHLCDIAHLG();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x69FCC30", Offset = "0x69FB630", VA = "0x1869FCC30")]
	private static extern int PFJPPOFNAJK(int DNICIAANFHD);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x69FC750", Offset = "0x69FB150", VA = "0x1869FC750")]
	private static extern int FMMKKBNLHOG(int DNICIAANFHD);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x69FCA30", Offset = "0x69FB430", VA = "0x1869FCA30")]
	private static extern int ICIEGFOLDBO(int DNICIAANFHD);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x69FCAB0", Offset = "0x69FB4B0", VA = "0x1869FCAB0")]
	private static extern int MEEFCMKAJEJ(int DNICIAANFHD);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x69FCD40", Offset = "0x69FB740", VA = "0x1869FCD40")]
	public GMJKOHCMKHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x69FC670", Offset = "0x69FB070", VA = "0x1869FC670", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x69FC840", Offset = "0x69FB240", VA = "0x1869FC840")]
	public Rect HMMNJDMDAED(int DBOGOIECCMF)
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

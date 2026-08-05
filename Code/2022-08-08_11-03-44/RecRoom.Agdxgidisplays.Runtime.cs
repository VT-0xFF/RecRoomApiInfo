using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class LEDINKOBNNM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum DIHDFBOOCCF
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void GABDAECLINP(IntPtr PDHKNAGOONJ, int CCDDIFMMPAN, int GNPMMMKABDB);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int OLNFPJPMPBI
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x585B9D0", Offset = "0x585A9D0", VA = "0x18585B9D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x585BE10", Offset = "0x585AE10", VA = "0x18585BE10")]
	private static extern void KJEJPKPDBGM(GABDAECLINP PCMFICPIFCD);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x585BF20", Offset = "0x585AF20", VA = "0x18585BF20")]
	[MonoPInvokeCallback(typeof(GABDAECLINP))]
	private static void OLNOOJOMOFN(IntPtr PDHKNAGOONJ, int CCDDIFMMPAN, int GNPMMMKABDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x585BA40", Offset = "0x585AA40", VA = "0x18585BA40")]
	private static extern void AICHPOAHICB();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x585BAB0", Offset = "0x585AAB0", VA = "0x18585BAB0")]
	private static extern void OKEFLAFHEGF();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x585B9D0", Offset = "0x585A9D0", VA = "0x18585B9D0")]
	private static extern int AEHNHGEOEIL();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x585BBA0", Offset = "0x585ABA0", VA = "0x18585BBA0")]
	private static extern int GHHDDAKABFF(int LGBAJKGIPMA);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x585BB20", Offset = "0x585AB20", VA = "0x18585BB20")]
	private static extern int GBDFCMFGBBM(int LGBAJKGIPMA);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x585C040", Offset = "0x585B040", VA = "0x18585C040")]
	private static extern int PIFNHPFKDIN(int LGBAJKGIPMA);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x585BEA0", Offset = "0x585AEA0", VA = "0x18585BEA0")]
	private static extern int MMBKPBNPGPK(int LGBAJKGIPMA);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x585C0C0", Offset = "0x585B0C0", VA = "0x18585C0C0")]
	public LEDINKOBNNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x585BAB0", Offset = "0x585AAB0", VA = "0x18585BAB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x585BC20", Offset = "0x585AC20", VA = "0x18585BC20")]
	public Rect GIMFKDBINEG(int MGIGONLHDON)
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

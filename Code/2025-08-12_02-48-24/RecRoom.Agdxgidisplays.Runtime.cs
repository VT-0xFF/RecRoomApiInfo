using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class GOJPPBNEMMH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum MJBADFFBKOE
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void HBMHGDBJCBN(IntPtr MLCIBEJGDFC, int MLMBLBFOLPC, int GGOKLJEDBLO);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int GDKEFIILEGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8171080", Offset = "0x816F680", VA = "0x188171080")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x81712E0", Offset = "0x816F8E0", VA = "0x1881712E0")]
	private static extern void GOIGJOLDLCO(HBMHGDBJCBN GDMDDGECOJI);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x81710F0", Offset = "0x816F6F0", VA = "0x1881710F0")]
	[MonoPInvokeCallback(typeof(HBMHGDBJCBN))]
	private static void DMNHBNACLCF(IntPtr MLCIBEJGDFC, int MLMBLBFOLPC, int GGOKLJEDBLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8171470", Offset = "0x816FA70", VA = "0x188171470")]
	private static extern void LJDCNOCKLGC();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x81711F0", Offset = "0x816F7F0", VA = "0x1881711F0")]
	private static extern void JHIMAFMJBAA();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8171080", Offset = "0x816F680", VA = "0x188171080")]
	private static extern int NOHPCMOJKIP();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8171370", Offset = "0x816F970", VA = "0x188171370")]
	private static extern int IPEEEHMKDJE(int JIEJOKBHEMF);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8171260", Offset = "0x816F860", VA = "0x188171260")]
	private static extern int EPPHKLMOLCG(int JIEJOKBHEMF);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x81713F0", Offset = "0x816F9F0", VA = "0x1881713F0")]
	private static extern int LBIAPJDJHMF(int JIEJOKBHEMF);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x81714E0", Offset = "0x816FAE0", VA = "0x1881714E0")]
	private static extern int OHCNIAFDJCB(int JIEJOKBHEMF);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8171750", Offset = "0x816FD50", VA = "0x188171750")]
	public GOJPPBNEMMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x81711F0", Offset = "0x816F7F0", VA = "0x1881711F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8171560", Offset = "0x816FB60", VA = "0x188171560")]
	public Rect POELNIIPCIL(int KLGOAMFEIFP)
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

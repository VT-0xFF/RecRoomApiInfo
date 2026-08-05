using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class HJEIKLDGFBJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum CPBLPENCEIF
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void AOCMCGFBIFD(IntPtr EMCPHLBMEHO, int DEBAMGFBJEH, int AJJOGHKEFIO);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int FMNNLGDCFBB
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x60AEBD0", Offset = "0x60ADFD0", VA = "0x1860AEBD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x60AEDB0", Offset = "0x60AE1B0", VA = "0x1860AEDB0")]
	private static extern void JGNDLOAACII(AOCMCGFBIFD MCFINHLOBAO);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x60AEAA0", Offset = "0x60ADEA0", VA = "0x1860AEAA0")]
	[MonoPInvokeCallback(typeof(AOCMCGFBIFD))]
	private static void CIJHEGLONGJ(IntPtr EMCPHLBMEHO, int DEBAMGFBJEH, int AJJOGHKEFIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x60AEE40", Offset = "0x60AE240", VA = "0x1860AEE40")]
	private static extern void LJAJKOINHPD();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x60AECC0", Offset = "0x60AE0C0", VA = "0x1860AECC0")]
	private static extern void HLIFOLDHPDJ();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x60AEBD0", Offset = "0x60ADFD0", VA = "0x1860AEBD0")]
	private static extern int PMBDIDPLNOD();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x60AEC40", Offset = "0x60AE040", VA = "0x1860AEC40")]
	private static extern int CNJMGFLGPIP(int KDFBMFGPICB);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x60AED30", Offset = "0x60AE130", VA = "0x1860AED30")]
	private static extern int FBNKMHADGLK(int KDFBMFGPICB);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x60AE9A0", Offset = "0x60ADDA0", VA = "0x1860AE9A0")]
	private static extern int BDCIDCCDEIH(int KDFBMFGPICB);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x60AEA20", Offset = "0x60ADE20", VA = "0x1860AEA20")]
	private static extern int BEGFMPBCDKE(int KDFBMFGPICB);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x60AEEB0", Offset = "0x60AE2B0", VA = "0x1860AEEB0")]
	public HJEIKLDGFBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x60AECC0", Offset = "0x60AE0C0", VA = "0x1860AECC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x60AE7B0", Offset = "0x60ADBB0", VA = "0x1860AE7B0")]
	public Rect AEPJMBGFKIK(int OEBPCFAMKOA)
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

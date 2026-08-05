using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class LIJKGGAGGPK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum EGPOMOLJJFG
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void NBMLNCLDHIN(IntPtr CEKCHJKLGMA, int IMMPKDAEONJ, int LLELMHEMFIK);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int MNAGBJFACFN
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1E7A650", Offset = "0x1E79050", VA = "0x181E7A650")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1E7AC50", Offset = "0x1E79650", VA = "0x181E7AC50")]
	private static extern void LJMJJNFFNMB(NBMLNCLDHIN KFICNKMCGGK);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1E7A930", Offset = "0x1E79330", VA = "0x181E7A930")]
	[MonoPInvokeCallback(typeof(NBMLNCLDHIN))]
	private static void BOAIPILDBAP(IntPtr CEKCHJKLGMA, int IMMPKDAEONJ, int LLELMHEMFIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1E7ACE0", Offset = "0x1E796E0", VA = "0x181E7ACE0")]
	private static extern void NCBKDFJCMBF();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x1E7AAE0", Offset = "0x1E794E0", VA = "0x181E7AAE0")]
	private static extern void DKACBOJDJCH();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1E7A650", Offset = "0x1E79050", VA = "0x181E7A650")]
	private static extern int AFMGDPECIBJ();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1E7ABD0", Offset = "0x1E795D0", VA = "0x181E7ABD0")]
	private static extern int KAKNNFJCADJ(int BEEBALICHLA);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1E7AA60", Offset = "0x1E79460", VA = "0x181E7AA60")]
	private static extern int CBMIIHKEMEN(int BEEBALICHLA);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1E7A8B0", Offset = "0x1E792B0", VA = "0x181E7A8B0")]
	private static extern int BIMDALKGFAC(int BEEBALICHLA);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x1E7AB50", Offset = "0x1E79550", VA = "0x181E7AB50")]
	private static extern int JDJCDMGLBDF(int BEEBALICHLA);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x1E7AD50", Offset = "0x1E79750", VA = "0x181E7AD50")]
	public LIJKGGAGGPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1E7AAE0", Offset = "0x1E794E0", VA = "0x181E7AAE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1E7A6C0", Offset = "0x1E790C0", VA = "0x181E7A6C0")]
	public Rect AGGKNLECJHH(int MKLMMJFFDPJ)
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

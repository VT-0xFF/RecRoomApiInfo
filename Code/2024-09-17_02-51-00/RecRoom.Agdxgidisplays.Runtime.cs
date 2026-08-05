using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class CHMHNHGGGNN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum PLHEFDJACBM
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void NEKEPMEOKCJ(IntPtr NEKCFCOLDAN, int BHEAFIOEIAD, int LOGDHIGFBFA);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int IJIHBAJMCDA
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6AB80D0", Offset = "0x6AB6AD0", VA = "0x186AB80D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6AB85A0", Offset = "0x6AB6FA0", VA = "0x186AB85A0")]
	private static extern void NEHDIKGOAGG(NEKEPMEOKCJ JMKAJHCEDCI);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6AB8230", Offset = "0x6AB6C30", VA = "0x186AB8230")]
	[MonoPInvokeCallback(typeof(NEKEPMEOKCJ))]
	private static void GAPLFADHNEL(IntPtr NEKCFCOLDAN, int BHEAFIOEIAD, int LOGDHIGFBFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6AB8060", Offset = "0x6AB6A60", VA = "0x186AB8060")]
	private static extern void AIFHKOLJDOL();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6AB81C0", Offset = "0x6AB6BC0", VA = "0x186AB81C0")]
	private static extern void ODEEMEMNBLE();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6AB80D0", Offset = "0x6AB6AD0", VA = "0x186AB80D0")]
	private static extern int KAJCAKKFLLA();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6AB86B0", Offset = "0x6AB70B0", VA = "0x186AB86B0")]
	private static extern int OOMNJMKIEKN(int MCAKFNPAKIL);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6AB8520", Offset = "0x6AB6F20", VA = "0x186AB8520")]
	private static extern int HDIJIOLJFCH(int MCAKFNPAKIL);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6AB8630", Offset = "0x6AB7030", VA = "0x186AB8630")]
	private static extern int ODHDHDLMBFH(int MCAKFNPAKIL);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6AB8140", Offset = "0x6AB6B40", VA = "0x186AB8140")]
	private static extern int BOJLMELICOK(int MCAKFNPAKIL);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6AB8730", Offset = "0x6AB7130", VA = "0x186AB8730")]
	public CHMHNHGGGNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6AB81C0", Offset = "0x6AB6BC0", VA = "0x186AB81C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6AB8330", Offset = "0x6AB6D30", VA = "0x186AB8330")]
	public Rect GOONGJHMCEF(int LCLNALICPNB)
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

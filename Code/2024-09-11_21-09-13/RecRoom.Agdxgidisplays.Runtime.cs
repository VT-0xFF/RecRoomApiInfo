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
		[Cpp2IlInjected.Address(RVA = "0x69D3D20", Offset = "0x69D2320", VA = "0x1869D3D20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x69D41F0", Offset = "0x69D27F0", VA = "0x1869D41F0")]
	private static extern void NEHDIKGOAGG(NEKEPMEOKCJ JMKAJHCEDCI);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x69D3E80", Offset = "0x69D2480", VA = "0x1869D3E80")]
	[MonoPInvokeCallback(typeof(NEKEPMEOKCJ))]
	private static void GAPLFADHNEL(IntPtr NEKCFCOLDAN, int BHEAFIOEIAD, int LOGDHIGFBFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x69D3CB0", Offset = "0x69D22B0", VA = "0x1869D3CB0")]
	private static extern void AIFHKOLJDOL();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x69D3E10", Offset = "0x69D2410", VA = "0x1869D3E10")]
	private static extern void ODEEMEMNBLE();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x69D3D20", Offset = "0x69D2320", VA = "0x1869D3D20")]
	private static extern int KAJCAKKFLLA();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x69D4300", Offset = "0x69D2900", VA = "0x1869D4300")]
	private static extern int OOMNJMKIEKN(int MCAKFNPAKIL);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x69D4170", Offset = "0x69D2770", VA = "0x1869D4170")]
	private static extern int HDIJIOLJFCH(int MCAKFNPAKIL);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x69D4280", Offset = "0x69D2880", VA = "0x1869D4280")]
	private static extern int ODHDHDLMBFH(int MCAKFNPAKIL);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x69D3D90", Offset = "0x69D2390", VA = "0x1869D3D90")]
	private static extern int BOJLMELICOK(int MCAKFNPAKIL);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x69D4380", Offset = "0x69D2980", VA = "0x1869D4380")]
	public CHMHNHGGGNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x69D3E10", Offset = "0x69D2410", VA = "0x1869D3E10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x69D3F80", Offset = "0x69D2580", VA = "0x1869D3F80")]
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

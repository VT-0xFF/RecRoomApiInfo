using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class CFKGNNOELEJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum EJABPCLAHIC
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void AFBDHDKEKJF(IntPtr ODNHKCNDAKN, int GIGKIGNPJAP, int PLKIGMFDEGO);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int AHLKJEBJDDE
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x65F1D90", Offset = "0x65F0590", VA = "0x1865F1D90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x65F1E00", Offset = "0x65F0600", VA = "0x1865F1E00")]
	private static extern void GOPCGBGIIHJ(AFBDHDKEKJF MKOFIMIHGLL);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x65F1F10", Offset = "0x65F0710", VA = "0x1865F1F10")]
	[MonoPInvokeCallback(typeof(AFBDHDKEKJF))]
	private static void JACMCADPMKM(IntPtr ODNHKCNDAKN, int GIGKIGNPJAP, int PLKIGMFDEGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x65F2140", Offset = "0x65F0940", VA = "0x1865F2140")]
	private static extern void ODGJJHFNDHJ();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x65F1D20", Offset = "0x65F0520", VA = "0x1865F1D20")]
	private static extern void NONLCEEEBPK();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x65F1D90", Offset = "0x65F0590", VA = "0x1865F1D90")]
	private static extern int EHMMJPELNGH();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x65F21B0", Offset = "0x65F09B0", VA = "0x1865F21B0")]
	private static extern int OHKMGOPMOEP(int MKEJJPNNCOG);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x65F2040", Offset = "0x65F0840", VA = "0x1865F2040")]
	private static extern int KADLADGHIGB(int MKEJJPNNCOG);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x65F20C0", Offset = "0x65F08C0", VA = "0x1865F20C0")]
	private static extern int MLKJBNLKOOF(int MKEJJPNNCOG);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x65F1E90", Offset = "0x65F0690", VA = "0x1865F1E90")]
	private static extern int IDJHAFOGNFG(int MKEJJPNNCOG);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x65F2230", Offset = "0x65F0A30", VA = "0x1865F2230")]
	public CFKGNNOELEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x65F1D20", Offset = "0x65F0520", VA = "0x1865F1D20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x65F1B30", Offset = "0x65F0330", VA = "0x1865F1B30")]
	public Rect BNCHONOOINO(int DLAHEHIOJPK)
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

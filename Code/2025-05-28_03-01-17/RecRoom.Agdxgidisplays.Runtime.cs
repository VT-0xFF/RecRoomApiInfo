using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class PKDGIFKJPGD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum CDJHAEKNKNH
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void EDGFCMJEIPK(IntPtr OHDJLNAKLPC, int ACINDEOBNPO, int HCBLKEJNOJP);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int PEHCFFCILBC
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7AF1870", Offset = "0x7AF0670", VA = "0x187AF1870")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7AF18E0", Offset = "0x7AF06E0", VA = "0x187AF18E0")]
	private static extern void CEFJAAOBCAH(EDGFCMJEIPK LDLIMOGOGBF);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7AF1B60", Offset = "0x7AF0960", VA = "0x187AF1B60")]
	[MonoPInvokeCallback(typeof(EDGFCMJEIPK))]
	private static void DNFGOJHPODF(IntPtr OHDJLNAKLPC, int ACINDEOBNPO, int HCBLKEJNOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7AF1D50", Offset = "0x7AF0B50", VA = "0x187AF1D50")]
	private static extern void IANLJFINMMK();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7AF1C60", Offset = "0x7AF0A60", VA = "0x187AF1C60")]
	private static extern void JHFPIMHAHKH();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7AF1870", Offset = "0x7AF0670", VA = "0x187AF1870")]
	private static extern int APFNEBHMFAG();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7AF1CD0", Offset = "0x7AF0AD0", VA = "0x187AF1CD0")]
	private static extern int EBNLCKGIDNC(int FONJFDCCINO);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7AF1E40", Offset = "0x7AF0C40", VA = "0x187AF1E40")]
	private static extern int LLILILDIIEI(int FONJFDCCINO);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7AF1EC0", Offset = "0x7AF0CC0", VA = "0x187AF1EC0")]
	private static extern int OFOPIFHODCO(int FONJFDCCINO);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7AF1DC0", Offset = "0x7AF0BC0", VA = "0x187AF1DC0")]
	private static extern int JBEKPGGPGID(int FONJFDCCINO);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7AF1F40", Offset = "0x7AF0D40", VA = "0x187AF1F40")]
	public PKDGIFKJPGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7AF1C60", Offset = "0x7AF0A60", VA = "0x187AF1C60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7AF1970", Offset = "0x7AF0770", VA = "0x187AF1970")]
	public Rect DCDLNKCGKBK(int MCNGFOMCBCC)
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

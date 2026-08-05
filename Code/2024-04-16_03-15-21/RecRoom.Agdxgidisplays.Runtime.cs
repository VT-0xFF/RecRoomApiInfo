using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class KENMLALKHCE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum OLJHLJGPIAB
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void APMPEJCMHKH(IntPtr NOGNLJBIFAF, int ANCJPCFOHBG, int CBFEIBNOFPO);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int HLJKBDPJDKE
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5FCEF00", Offset = "0x5FCE100", VA = "0x185FCEF00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5FCF250", Offset = "0x5FCE450", VA = "0x185FCF250")]
	private static extern void OFCEAJBBNAF(APMPEJCMHKH CMMPHMKBCDC);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5FCEFE0", Offset = "0x5FCE1E0", VA = "0x185FCEFE0")]
	[MonoPInvokeCallback(typeof(APMPEJCMHKH))]
	private static void ELJOMPAFOHP(IntPtr NOGNLJBIFAF, int ANCJPCFOHBG, int CBFEIBNOFPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5FCF160", Offset = "0x5FCE360", VA = "0x185FCF160")]
	private static extern void MEJEOBIHPJE();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5FCEF70", Offset = "0x5FCE170", VA = "0x185FCEF70")]
	private static extern void MPHKEAJJIAO();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5FCEF00", Offset = "0x5FCE100", VA = "0x185FCEF00")]
	private static extern int CLOBLGCGBGM();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5FCF1D0", Offset = "0x5FCE3D0", VA = "0x185FCF1D0")]
	private static extern int NLPJHOODBKL(int POAELFIOKHK);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5FCEE80", Offset = "0x5FCE080", VA = "0x185FCEE80")]
	private static extern int AJJGMMMGGPM(int POAELFIOKHK);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5FCF0E0", Offset = "0x5FCE2E0", VA = "0x185FCF0E0")]
	private static extern int LDFLNMHMDJF(int POAELFIOKHK);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5FCF2E0", Offset = "0x5FCE4E0", VA = "0x185FCF2E0")]
	private static extern int OHOHDIIECJP(int POAELFIOKHK);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5FCF360", Offset = "0x5FCE560", VA = "0x185FCF360")]
	public KENMLALKHCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5FCEF70", Offset = "0x5FCE170", VA = "0x185FCEF70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5FCEC90", Offset = "0x5FCDE90", VA = "0x185FCEC90")]
	public Rect ABJDJOGDGEF(int GGOOCHDNMPO)
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

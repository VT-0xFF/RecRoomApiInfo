using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class AMEFMINJKEG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum DCMAGBJJDAA
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void KGLGALCNBHK(IntPtr KPOBLGGEAFB, int DFCIFDODMGE, int JNCNAIDPGHC);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int PGKEHFKLDKF
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x28A1230", Offset = "0x28A0430", VA = "0x1828A1230")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x28A1030", Offset = "0x28A0230", VA = "0x1828A1030")]
	private static extern void BHIKGDNCHGE(KGLGALCNBHK ELMGCHGCEJD);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x28A1600", Offset = "0x28A0800", VA = "0x1828A1600")]
	[MonoPInvokeCallback(typeof(KGLGALCNBHK))]
	private static void OELMNPOHAEJ(IntPtr KPOBLGGEAFB, int DFCIFDODMGE, int JNCNAIDPGHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x28A1320", Offset = "0x28A0520", VA = "0x1828A1320")]
	private static extern void MGEPLKAAEGI();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x28A11C0", Offset = "0x28A03C0", VA = "0x1828A11C0")]
	private static extern void PJMCFEILABM();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x28A1230", Offset = "0x28A0430", VA = "0x1828A1230")]
	private static extern int FEIDKOJIDCJ();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x28A1390", Offset = "0x28A0590", VA = "0x1828A1390")]
	private static extern int MLOJGIBNAHB(int IHPCCBHNEMN);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x28A1140", Offset = "0x28A0340", VA = "0x1828A1140")]
	private static extern int DIINNGOFEPD(int IHPCCBHNEMN);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x28A10C0", Offset = "0x28A02C0", VA = "0x1828A10C0")]
	private static extern int BPLIJGDBAEK(int IHPCCBHNEMN);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x28A12A0", Offset = "0x28A04A0", VA = "0x1828A12A0")]
	private static extern int IPOOCMOAKKH(int IHPCCBHNEMN);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x28A1720", Offset = "0x28A0920", VA = "0x1828A1720")]
	public AMEFMINJKEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x28A11C0", Offset = "0x28A03C0", VA = "0x1828A11C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x28A1410", Offset = "0x28A0610", VA = "0x1828A1410")]
	public Rect NBKJBDCHGEN(int OFJCGDKALMN)
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

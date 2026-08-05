using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class IDKEKAMLJNG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum FNIIMCFKLEH
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void OGDJJICGCEC(IntPtr KDMHFDGDHMP, int GCDOPBGGNDP, int EMAFIPBIGEI);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int HODBCKJGPJK
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6070020", Offset = "0x606EA20", VA = "0x186070020")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x606FEA0", Offset = "0x606E8A0", VA = "0x18606FEA0")]
	private static extern void CIFLNBDNHKL(OGDJJICGCEC MLFGBBGKHEO);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x60703F0", Offset = "0x606EDF0", VA = "0x1860703F0")]
	[MonoPInvokeCallback(typeof(OGDJJICGCEC))]
	private static void PNEEFAEIMKD(IntPtr KDMHFDGDHMP, int GCDOPBGGNDP, int EMAFIPBIGEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6070110", Offset = "0x606EB10", VA = "0x186070110")]
	private static extern void GICNDCMAEJH();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x606FFB0", Offset = "0x606E9B0", VA = "0x18606FFB0")]
	private static extern void HNHNOGHBBNE();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6070020", Offset = "0x606EA20", VA = "0x186070020")]
	private static extern int OLILCNIIOIL();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x606FF30", Offset = "0x606E930", VA = "0x18606FF30")]
	private static extern int DKBDICNLHNN(int ENFGKNDHLNI);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6070090", Offset = "0x606EA90", VA = "0x186070090")]
	private static extern int FJLKEPEJJPJ(int ENFGKNDHLNI);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x606FE20", Offset = "0x606E820", VA = "0x18606FE20")]
	private static extern int ALMDMDCDEFK(int ENFGKNDHLNI);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6070370", Offset = "0x606ED70", VA = "0x186070370")]
	private static extern int LNGAGPOEPFI(int ENFGKNDHLNI);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6070520", Offset = "0x606EF20", VA = "0x186070520")]
	public IDKEKAMLJNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x606FFB0", Offset = "0x606E9B0", VA = "0x18606FFB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6070180", Offset = "0x606EB80", VA = "0x186070180")]
	public Rect LLJIAJJNFKI(int OHAAEHODEDB)
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

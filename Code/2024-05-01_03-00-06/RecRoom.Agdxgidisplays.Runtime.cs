using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class MKOCCMGAKKG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum MPJKIPBKHFO
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void EOGNJGCPHFG(IntPtr AIAKOJMKOGA, int CGDBKIJPKOF, int OFODBBNJBGF);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int EOFOCFEEIDE
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x609A020", Offset = "0x6098E20", VA = "0x18609A020")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x609A480", Offset = "0x6099280", VA = "0x18609A480")]
	private static extern void ONOGPMPKFKF(EOGNJGCPHFG KPIAINDMMOB);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x609A190", Offset = "0x6098F90", VA = "0x18609A190")]
	[MonoPInvokeCallback(typeof(EOGNJGCPHFG))]
	private static void MEMKIIAGOIM(IntPtr AIAKOJMKOGA, int CGDBKIJPKOF, int OFODBBNJBGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6099FB0", Offset = "0x6098DB0", VA = "0x186099FB0")]
	private static extern void HBPIHILNAPB();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6099F40", Offset = "0x6098D40", VA = "0x186099F40")]
	private static extern void FDCICILBADA();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x609A020", Offset = "0x6098E20", VA = "0x18609A020")]
	private static extern int IIONDFNGEDP();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x609A090", Offset = "0x6098E90", VA = "0x18609A090")]
	private static extern int KKGNEJNNNBM(int NLFEJIHGBIC);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x609A510", Offset = "0x6099310", VA = "0x18609A510")]
	private static extern int PFFDMADFPFN(int NLFEJIHGBIC);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6099EC0", Offset = "0x6098CC0", VA = "0x186099EC0")]
	private static extern int BPMKFCOLNLP(int NLFEJIHGBIC);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x609A110", Offset = "0x6098F10", VA = "0x18609A110")]
	private static extern int LHHIAAMDDLB(int NLFEJIHGBIC);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x609A590", Offset = "0x6099390", VA = "0x18609A590")]
	public MKOCCMGAKKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6099F40", Offset = "0x6098D40", VA = "0x186099F40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x609A290", Offset = "0x6099090", VA = "0x18609A290")]
	public Rect NHHLGCAGKLI(int INCOPDMPIBA)
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

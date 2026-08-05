using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class OLFNGGDNHIO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum AJBKHNHPLLO
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void EBKLFFFKLMC(IntPtr LBOBHKOOIAP, int ILOELBIABFJ, int DGPCKNFLKPL);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int CDCFNFOBJCD
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x16ECF90", Offset = "0x16EBD90", VA = "0x1816ECF90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x16ED290", Offset = "0x16EC090", VA = "0x1816ED290")]
	private static extern void LHIBHFJHILB(EBKLFFFKLMC IFOGDLBNNEF);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x16ED170", Offset = "0x16EBF70", VA = "0x1816ED170")]
	[MonoPInvokeCallback(typeof(EBKLFFFKLMC))]
	private static void JJKOFNJPMOA(IntPtr LBOBHKOOIAP, int ILOELBIABFJ, int DGPCKNFLKPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x16ED320", Offset = "0x16EC120", VA = "0x1816ED320")]
	private static extern void LNBLCEPPLFK();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x16ED000", Offset = "0x16EBE00", VA = "0x1816ED000")]
	private static extern void CPDHFJKNEKG();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x16ECF90", Offset = "0x16EBD90", VA = "0x1816ECF90")]
	private static extern int MKJMFGEEENK();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x16ED580", Offset = "0x16EC380", VA = "0x1816ED580")]
	private static extern int OFMGEDAJCBI(int NKFKNPEOIHO);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x16ED600", Offset = "0x16EC400", VA = "0x1816ED600")]
	private static extern int PKDKBFCADML(int NKFKNPEOIHO);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x16ED070", Offset = "0x16EBE70", VA = "0x1816ED070")]
	private static extern int DDFOFAAOHLA(int NKFKNPEOIHO);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x16ED0F0", Offset = "0x16EBEF0", VA = "0x1816ED0F0")]
	private static extern int GOGFIIACKDO(int NKFKNPEOIHO);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x16ED680", Offset = "0x16EC480", VA = "0x1816ED680")]
	public OLFNGGDNHIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x16ED000", Offset = "0x16EBE00", VA = "0x1816ED000", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x16ED390", Offset = "0x16EC190", VA = "0x1816ED390")]
	public Rect MOEHJJLNCFJ(int LJAPNPHJKKB)
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

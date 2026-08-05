using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class CMEFAFOMKHM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum JLHNNBKDGPP
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void BBLKDMMHJDB(IntPtr GMJOOGMAMPH, int OCAKIKBDFGC, int CPKIJLDCHJP);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int EBJACHIKGIO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x421AAB0", Offset = "0x42192B0", VA = "0x18421AAB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x421A930", Offset = "0x4219130", VA = "0x18421A930")]
	private static extern void ENKLHGIGBOM(BBLKDMMHJDB LABDBOEIJFO);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x421AD90", Offset = "0x4219590", VA = "0x18421AD90")]
	[MonoPInvokeCallback(typeof(BBLKDMMHJDB))]
	private static void OKDIKCMJKJG(IntPtr GMJOOGMAMPH, int OCAKIKBDFGC, int CPKIJLDCHJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x421AA40", Offset = "0x4219240", VA = "0x18421AA40")]
	private static extern void LGHMODLDJCJ();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x421A8C0", Offset = "0x42190C0", VA = "0x18421A8C0")]
	private static extern void EKOOLDPJFNK();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x421AAB0", Offset = "0x42192B0", VA = "0x18421AAB0")]
	private static extern int MAEGNMEKDPJ();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x421AB20", Offset = "0x4219320", VA = "0x18421AB20")]
	private static extern int NINJAIAMMKA(int OCNCOBFEOBE);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x421A9C0", Offset = "0x42191C0", VA = "0x18421A9C0")]
	private static extern int GCIOHKONOFJ(int OCNCOBFEOBE);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x421AF30", Offset = "0x4219730", VA = "0x18421AF30")]
	private static extern int PFJOFBOGEIH(int OCNCOBFEOBE);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x421AEB0", Offset = "0x42196B0", VA = "0x18421AEB0")]
	private static extern int PEBGGECHGAD(int OCNCOBFEOBE);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x421AFB0", Offset = "0x42197B0", VA = "0x18421AFB0")]
	public CMEFAFOMKHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x421A8C0", Offset = "0x42190C0", VA = "0x18421A8C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x421ABA0", Offset = "0x42193A0", VA = "0x18421ABA0")]
	public Rect OEAKACJBBDB(int CLOOMGJEKBN)
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

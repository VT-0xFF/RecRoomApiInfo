using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using ExitGames.Client.Photon;
using RecRoom.CodeGen.Attributes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[GIDPDJJGMLG(typeof(ABECIHIGANA), new string[] { "Photon" })]
public class LHIOFGDHBMH : ACLOEOFNKAE, ABECIHIGANA, IDisposable, OMCHPNDEIPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	[GFFJKOFNHJO]
	private KHCACGLEOEM FFGIGBONMNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[GFFJKOFNHJO]
	private DDKKPCJCKMB BJEAHAJJIIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly Hashtable OGGBBPNBCPJ;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x60E2A10", Offset = "0x60E1E10", VA = "0x1860E2A10", Slot = "4")]
	public void InitReferences(NLGOFGOGHKI DPELPGGDADK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x60E29C0", Offset = "0x60E1DC0", VA = "0x1860E29C0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x60E2E10", Offset = "0x60E2210", VA = "0x1860E2E10", Slot = "5")]
	public void KMCBLPKGLPP(ICAGMHNMFKH CONEAMPCFEL, ReadOnlySpan<byte> JFKHFDHADBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x60E2AB0", Offset = "0x60E1EB0", VA = "0x1860E2AB0", Slot = "9")]
	public void KCMDILFALBE(ICAGMHNMFKH HOBBAGPIDGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x60E2F60", Offset = "0x60E2360", VA = "0x1860E2F60", Slot = "6")]
	public void PDOANALKEMB(ReadOnlySpan<ICAGMHNMFKH> DIMCKNJFHPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x60E2BB0", Offset = "0x60E1FB0", VA = "0x1860E2BB0")]
	private Hashtable KKOBHDFIHGO(Hashtable LENMHJJDBPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x60E24F0", Offset = "0x60E18F0", VA = "0x1860E24F0", Slot = "8")]
	private void CBPEBNOBANM(EventData OGBNHOLMCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x60E30D0", Offset = "0x60E24D0", VA = "0x1860E30D0")]
	public LHIOFGDHBMH()
	{
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.Dependencies.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Preserve]
	internal class _RRAssemblyIndex : NNKBGHGFICJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7BAB50", Offset = "0x7B9F50", VA = "0x1807BAB50")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x60E3150", Offset = "0x60E2550", VA = "0x1860E3150", Slot = "6")]
		public sealed override void EGAEKEEPMBK(EANAHNJCCDI COPFOFGFOAL)
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class MCHCGHGHNGD
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
	public MCHCGHGHNGD()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
	{
	}
}
namespace Cpp2IlInjected
{
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
}

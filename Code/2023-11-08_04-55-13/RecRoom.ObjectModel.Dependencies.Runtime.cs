using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using ExitGames.Client.Photon;
using RecRoom.CodeGen.Attributes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[PLLADOOKFGO(typeof(BFBMCHMKONH), new string[] { "Photon" })]
public class NJHHDGIGDNJ : ECOFDNFPFFG, BFBMCHMKONH, IDisposable, NFIJLOJCGNE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	[GDCPPADOKIA]
	private DBMNBDECAIP IKEGHFLBMKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[GDCPPADOKIA]
	private AGJJJOLKBLC IMKJOCGAOBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly Hashtable GLPHNLMJMNF;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5EB4980", Offset = "0x5EB3780", VA = "0x185EB4980", Slot = "4")]
	public void InitReferences(DFLOIMJPFAA KDACNGHEDPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5EB47E0", Offset = "0x5EB35E0", VA = "0x185EB47E0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5EB4830", Offset = "0x5EB3630", VA = "0x185EB4830", Slot = "5")]
	public void FNLMAFFJDGF(LIEEBGEKNHM GAMCILOFBAF, ReadOnlySpan<byte> IPHMLIFNKFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5EB46E0", Offset = "0x5EB34E0", VA = "0x185EB46E0", Slot = "9")]
	public void ACJLDEGNCPI(LIEEBGEKNHM OBNPINEEHDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5EB4A20", Offset = "0x5EB3820", VA = "0x185EB4A20", Slot = "6")]
	public void MHGFONLMFAI(ReadOnlySpan<LIEEBGEKNHM> BPNEOHIDACE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5EB4B90", Offset = "0x5EB3990", VA = "0x185EB4B90")]
	private Hashtable MPCDGCGPOGA(Hashtable JAGGKLKIMLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5EB4270", Offset = "0x5EB3070", VA = "0x185EB4270", Slot = "8")]
	private void ABDEMLJOFJK(EventData FOGGGCKLLHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5EB4DF0", Offset = "0x5EB3BF0", VA = "0x185EB4DF0")]
	public NJHHDGIGDNJ()
	{
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.Dependencies.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Preserve]
	internal class _RRAssemblyIndex : IMHCJPKCGLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7997A0", Offset = "0x7985A0", VA = "0x1807997A0")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5EB4E70", Offset = "0x5EB3C70", VA = "0x185EB4E70", Slot = "6")]
		public sealed override void PGPOIJFPEMI(MACKNKFCFBE PJJEKPONKPF)
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class DBFEEPAPMKO
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public DBFEEPAPMKO()
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

using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using ExitGames.Client.Photon;
using RecRoom.CodeGen.Attributes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[IOECDJGDPJM(typeof(NJPNMCNNKAF), new string[] { "Photon" })]
public class FIACBPLMBOB : LFEOMOKILLA, NJPNMCNNKAF, IDisposable, GOODFPJBOCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	[EADALOFEHFB]
	private OMMOFEDCNEC JFBAAAAIBGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[EADALOFEHFB]
	private KNIACBABJKI KJKBLCMAECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly Hashtable CDJFMFMBDBN;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5EBAEF0", Offset = "0x5EB9EF0", VA = "0x185EBAEF0", Slot = "4")]
	public void InitReferences(MKDBPFPJIJD HCKKNCPHDMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5EBAEA0", Offset = "0x5EB9EA0", VA = "0x185EBAEA0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5EBB570", Offset = "0x5EBA570", VA = "0x185EBB570", Slot = "5")]
	public void NLNADDMJAPP(GCEJLAILKLA BGNGIHJEFLM, ReadOnlySpan<byte> HPEDGLBMGED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5EBADA0", Offset = "0x5EB9DA0", VA = "0x185EBADA0", Slot = "9")]
	public void BICMCBEHAJO(GCEJLAILKLA PIHJKNKDBEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5EBB400", Offset = "0x5EBA400", VA = "0x185EBB400", Slot = "6")]
	public void NGCOIMANLPL(ReadOnlySpan<GCEJLAILKLA> LDMEGNNFBBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5EBB6C0", Offset = "0x5EBA6C0", VA = "0x185EBB6C0")]
	private Hashtable OLFGDLABEKN(Hashtable BFEICIMHMGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5EBAF90", Offset = "0x5EB9F90", VA = "0x185EBAF90", Slot = "8")]
	private void LEJFPHIJPJC(EventData GJNDPOBCNHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5EBB920", Offset = "0x5EBA920", VA = "0x185EBB920")]
	public FIACBPLMBOB()
	{
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.Dependencies.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Preserve]
	internal class _RRAssemblyIndex : MEDPHPOAELF
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x79A600", Offset = "0x799600", VA = "0x18079A600")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5EBB9A0", Offset = "0x5EBA9A0", VA = "0x185EBB9A0", Slot = "6")]
		public sealed override void HHEFIFLAAMN(MHHKPCCLDJH CAEGDBPOJIB)
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class OHHMJHHAJKD
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public OHHMJHHAJKD()
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

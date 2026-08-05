using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using ExitGames.Client.Photon;
using RecRoom.CodeGen.Attributes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[LHLDKFCBMDL(typeof(OBPLLFDIIMM), new string[] { "Photon" })]
public class BPIDJPJFLJB : MPDHAHPLHCI, OBPLLFDIIMM, IDisposable, KEPIALKMABK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	[KLEIFKIOFEF]
	private CKDLAGLLCOC KIGAJECMNEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[KLEIFKIOFEF]
	private CHBHNGBMHCK HDINBJLMGDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly Hashtable LOFNNPAJGEF;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x61587D0", Offset = "0x6157BD0", VA = "0x1861587D0", Slot = "4")]
	public void InitReferences(DOHCFJAHLBK DKKCBCANDII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6158680", Offset = "0x6157A80", VA = "0x186158680", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6158530", Offset = "0x6157930", VA = "0x186158530", Slot = "5")]
	public void DDPCPBKAGMH(GEKANCKOEPJ GPGELODKPOB, ReadOnlySpan<byte> KFANGHDLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x61586D0", Offset = "0x6157AD0", VA = "0x1861586D0", Slot = "9")]
	public void GCCBJLILJEJ(GEKANCKOEPJ AEMNNOJEMGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x61583C0", Offset = "0x61577C0", VA = "0x1861583C0", Slot = "6")]
	public void CLJFPFEBCAL(ReadOnlySpan<GEKANCKOEPJ> LMNCENGPHHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6158160", Offset = "0x6157560", VA = "0x186158160")]
	private Hashtable BBMKEJCAEHP(Hashtable DGFGHIAPHBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6158870", Offset = "0x6157C70", VA = "0x186158870", Slot = "8")]
	private void LLGCMFOHHHK(EventData BOPHALANMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6158D40", Offset = "0x6158140", VA = "0x186158D40")]
	public BPIDJPJFLJB()
	{
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.Dependencies.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Preserve]
	internal class _RRAssemblyIndex : DMCHAMHPJDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7C9520", Offset = "0x7C8920", VA = "0x1807C9520")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6158DC0", Offset = "0x61581C0", VA = "0x186158DC0", Slot = "6")]
		public sealed override void MKONPADAFEN(JHICGHNGFCN KNDPECEGMIA)
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class CEDJFJLKOPL
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
	public CEDJFJLKOPL()
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

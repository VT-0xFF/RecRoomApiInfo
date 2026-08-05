using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using ExitGames.Client.Photon;
using RecRoom.CodeGen.Attributes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[GJLJLBIABKM(typeof(MEABKCDHNCD), new string[] { "Photon" })]
public class FLDJJEDFPCJ : OILIFCGGAMK, MEABKCDHNCD, IDisposable, JLNNNPJPFHL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	[MCMLPKDBFJE]
	private FECOAHBOMEJ KBCHPJJCKNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[MCMLPKDBFJE]
	private HHCNHIPPGNG PAONDGJIOIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly Hashtable PBFNCDEJLIJ;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5D60F30", Offset = "0x5D5F730", VA = "0x185D60F30", Slot = "4")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5D609C0", Offset = "0x5D5F1C0", VA = "0x185D609C0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5D60870", Offset = "0x5D5F070", VA = "0x185D60870", Slot = "5")]
	public void CLFJCMJBKBK(MMNLNLKKOGE EBICOEDOGKC, ReadOnlySpan<byte> AJPCNFDACDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5D60A10", Offset = "0x5D5F210", VA = "0x185D60A10")]
	private Hashtable HOJDNFDAJKO(Hashtable BMHCMFJPPJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5D60C70", Offset = "0x5D5F470", VA = "0x185D60C70", Slot = "7")]
	private void IOHICJIMAOK(EventData NKGEMBOHNCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5D60FD0", Offset = "0x5D5F7D0", VA = "0x185D60FD0")]
	public FLDJJEDFPCJ()
	{
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.Dependencies.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Preserve]
	internal class _RRAssemblyIndex : FNNEAFKGECA
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x78B4D0", Offset = "0x789CD0", VA = "0x18078B4D0")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5D61050", Offset = "0x5D5F850", VA = "0x185D61050", Slot = "6")]
		public sealed override void ONAHLMMGDBM(FHBMMBMHFBC ELLFKJCIDIE)
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class OBJMCPPPHHO
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public OBJMCPPPHHO()
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

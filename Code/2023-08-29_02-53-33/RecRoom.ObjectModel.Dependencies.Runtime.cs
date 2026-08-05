using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using ExitGames.Client.Photon;
using RecRoom.CodeGen.Attributes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[EFDJEPLIMOC(typeof(IKINGBNPGOH), new string[] { "Photon" })]
public class CMNNAPMDCHL : AKFIPDJCCOH, IKINGBNPGOH, IDisposable, OGJFDBICEJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	[ONGFANECMJO]
	private NIOKIOAHGMB FBCPJLHEMAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[ONGFANECMJO]
	private FHGIEPBNGKE GOIJBJJFCPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly Hashtable NFDNHCCMBMJ;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6FA75B0", Offset = "0x6FA69B0", VA = "0x186FA75B0", Slot = "4")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6FA7560", Offset = "0x6FA6960", VA = "0x186FA7560", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6FA7660", Offset = "0x6FA6A60", VA = "0x186FA7660", Slot = "5")]
	public void MDGIOAECIDB(EBBOOPFABOA KOFPKIJDAMC, ReadOnlySpan<byte> KBLLMJIHKAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6FA7310", Offset = "0x6FA6710", VA = "0x186FA7310")]
	private Hashtable BEEJCKIPKMB(Hashtable LIPNHBAPCLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6FA77A0", Offset = "0x6FA6BA0", VA = "0x186FA77A0", Slot = "7")]
	private void NBEGGMLELBG(EventData OKCGKFJOEOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6FA7A90", Offset = "0x6FA6E90", VA = "0x186FA7A90")]
	public CMNNAPMDCHL()
	{
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.Dependencies.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Preserve]
	internal class _RRAssemblyIndex : DMCBJAFGDBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7F1AF0", Offset = "0x7F0EF0", VA = "0x1807F1AF0")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6FA7B00", Offset = "0x6FA6F00", VA = "0x186FA7B00", Slot = "6")]
		public sealed override void LPGLFILFNHK(AOEKEIHNKAE GBCKPIBLKJM)
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class CBCPDCNEBEL
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public CBCPDCNEBEL()
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

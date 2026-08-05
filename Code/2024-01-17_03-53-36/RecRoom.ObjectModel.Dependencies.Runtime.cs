using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using ExitGames.Client.Photon;
using RecRoom.CodeGen.Attributes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[PEPANDEJFKC(typeof(EELEJMCKELO), new string[] { "Photon" })]
public class PCJFFIGEFPM : CAAHJAMNMLN, EELEJMCKELO, IDisposable, BFDOFOGGIOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	[GCMNLGLAIFA]
	private CHPBJKILKEP OEAGGPHBPPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[GCMNLGLAIFA]
	private AOAABEOBEOD MNDJCMAHMIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly Hashtable PBCLPGDIOCN;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x60A50B0", Offset = "0x60A3EB0", VA = "0x1860A50B0", Slot = "4")]
	public void InitReferences(ELAIGJGMPAC LFFHKCFMLHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x60A4E10", Offset = "0x60A3C10", VA = "0x1860A4E10", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x60A4E60", Offset = "0x60A3C60", VA = "0x1860A4E60", Slot = "5")]
	public void FHBKNBDCJKI(ILFENCCNBML IDGIKKEFDCG, ReadOnlySpan<byte> PLFMLOLFNID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x60A4FB0", Offset = "0x60A3DB0", VA = "0x1860A4FB0", Slot = "9")]
	public void HDLKHGEBPBI(ILFENCCNBML MFFFFIHLHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x60A5150", Offset = "0x60A3F50", VA = "0x1860A5150", Slot = "6")]
	public void KOOFINOCMOJ(ReadOnlySpan<ILFENCCNBML> PAHOKPBLMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x60A52C0", Offset = "0x60A40C0", VA = "0x1860A52C0")]
	private Hashtable LCGFDIKEGNO(Hashtable MPAFAGIJEDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x60A5520", Offset = "0x60A4320", VA = "0x1860A5520", Slot = "8")]
	private void LFNNFPICDGG(EventData BFJEINFGFHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x60A59F0", Offset = "0x60A47F0", VA = "0x1860A59F0")]
	public PCJFFIGEFPM()
	{
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.Dependencies.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Preserve]
	internal class _RRAssemblyIndex : GCOJLFMNBGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7B83D0", Offset = "0x7B71D0", VA = "0x1807B83D0")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x60A5A70", Offset = "0x60A4870", VA = "0x1860A5A70", Slot = "6")]
		public sealed override void FJKDFPHMFOG(FIHGIMENDOE EAGOMMNFHFH)
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class LBMBDANPICH
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
	public LBMBDANPICH()
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

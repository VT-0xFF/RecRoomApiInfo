using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using ExitGames.Client.Photon;
using RecRoom.CodeGen.Attributes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[FHOIBFDAOOA(typeof(HNCJOLMBHOI), new string[] { "Photon" })]
public class JHFMEDNEBCN : ENDDIKHKCDF, HNCJOLMBHOI, IDisposable, HANJPGNFHIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	[DMNKPOGEHOO]
	private BKIMEPBHNGA KDDNMNODBLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[DMNKPOGEHOO]
	private OAFEOPGEEED AAGNKFNPBLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly Hashtable MJHCCCCPHBO;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5D93470", Offset = "0x5D92870", VA = "0x185D93470", Slot = "4")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5D93420", Offset = "0x5D92820", VA = "0x185D93420", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5D93010", Offset = "0x5D92410", VA = "0x185D93010", Slot = "5")]
	public void BPLOMEHFCFF(KFHEKKOEHDF IHHOPACLNAK, ReadOnlySpan<byte> CJFCIOOMJGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5D93510", Offset = "0x5D92910", VA = "0x185D93510")]
	private Hashtable JFFAHGOIMEO(Hashtable OCEOALPNPOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5D93160", Offset = "0x5D92560", VA = "0x185D93160", Slot = "7")]
	private void CJLAIKPPFCK(EventData PIBJHHOGKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5D93770", Offset = "0x5D92B70", VA = "0x185D93770")]
	public JHFMEDNEBCN()
	{
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.Dependencies.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Preserve]
	internal class _RRAssemblyIndex : GHHKFIIHMPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x78D520", Offset = "0x78C920", VA = "0x18078D520")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5D937F0", Offset = "0x5D92BF0", VA = "0x185D937F0", Slot = "6")]
		public sealed override void LHBGMEBPDNO(IOIHKDFKKJB AIBILCAOCLG)
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class FCJMKIHNMJN
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public FCJMKIHNMJN()
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

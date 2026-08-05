using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using ExitGames.Client.Photon;
using RecRoom.CodeGen.Attributes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[GKFKBGDODHH(typeof(HLLFIKDLBFF), new string[] { "Photon" })]
public class IPOLAIMBEEE : HKECKBDIOOH, HLLFIKDLBFF, IDisposable, BADNCKBLDOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	[LEKELIKDPPG]
	private AHLJNGAFEPJ DOGAKELJKHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[LEKELIKDPPG]
	private JCKMDPMAJBD LEMOHPCKKCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly Hashtable ACGMLGMLLPB;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5EDA800", Offset = "0x5ED9400", VA = "0x185EDA800", Slot = "4")]
	public void InitReferences(AKLOJBGPAJC LCFMOEJDELG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5ED9F10", Offset = "0x5ED8B10", VA = "0x185ED9F10", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5EDA8A0", Offset = "0x5ED94A0", VA = "0x185EDA8A0", Slot = "5")]
	public void LAODCBCCJHF(FMNBCHJKCNF PPNDANAOAMK, ReadOnlySpan<byte> AGEBEEELPDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5ED9E10", Offset = "0x5ED8A10", VA = "0x185ED9E10", Slot = "9")]
	public void APOMCMDHLIO(FMNBCHJKCNF HPDEFLMKLBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5EDA430", Offset = "0x5ED9030", VA = "0x185EDA430", Slot = "6")]
	public void HDPOKGEEGJO(ReadOnlySpan<FMNBCHJKCNF> BKPFHOLIGGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5EDA5A0", Offset = "0x5ED91A0", VA = "0x185EDA5A0")]
	private Hashtable HMEHLKENDBB(Hashtable EDNPJFJGDDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5ED9F60", Offset = "0x5ED8B60", VA = "0x185ED9F60", Slot = "8")]
	private void GPKAPGGLOBH(EventData BLDNMHMAPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5EDA9F0", Offset = "0x5ED95F0", VA = "0x185EDA9F0")]
	public IPOLAIMBEEE()
	{
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.Dependencies.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Preserve]
	internal class _RRAssemblyIndex : ELKGCLAEHBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x79B4F0", Offset = "0x79A0F0", VA = "0x18079B4F0")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5EDAA70", Offset = "0x5ED9670", VA = "0x185EDAA70", Slot = "6")]
		public sealed override void LPLJBBEMGKL(JLPOCOOPMJD FCFEFDOJHCD)
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class CNCAHEHIFIE
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public CNCAHEHIFIE()
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

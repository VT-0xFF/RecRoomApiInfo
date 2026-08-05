using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using ExitGames.Client.Photon;
using RecRoom.CodeGen.Attributes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[PNAJALIKCOM(typeof(CBGNJCOKJKE), new string[] { "Photon" })]
public class MDFFJEOFAPN : JAKEGKENGGK, CBGNJCOKJKE, IDisposable, COHHIJKCCGB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	[MFFAOKEGCNH]
	private OBDFANNJJFO MKNFLEECOBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[MFFAOKEGCNH]
	private AHAAPFOIKPK AHFDHEEACGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly Hashtable MFEJFLABCIK;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5D40C30", Offset = "0x5D40030", VA = "0x185D40C30", Slot = "4")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5D40A90", Offset = "0x5D3FE90", VA = "0x185D40A90", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5D40AE0", Offset = "0x5D3FEE0", VA = "0x185D40AE0", Slot = "5")]
	public void FDPDLHCJFBF(OCNDOGNDAKK DGCJCBHPPBD, ReadOnlySpan<byte> HEFGEKEDAKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5D40CD0", Offset = "0x5D400D0", VA = "0x185D40CD0")]
	private Hashtable JNDAFHHMKBE(Hashtable KGPNEPMALMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5D40F30", Offset = "0x5D40330", VA = "0x185D40F30", Slot = "7")]
	private void MJKNNPFADEI(EventData DPBGJEIOGOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5D411F0", Offset = "0x5D405F0", VA = "0x185D411F0")]
	public MDFFJEOFAPN()
	{
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.Dependencies.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Preserve]
	internal class _RRAssemblyIndex : BAFBLMKEIGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x787870", Offset = "0x786C70", VA = "0x180787870")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5D41270", Offset = "0x5D40670", VA = "0x185D41270", Slot = "6")]
		public sealed override void CAGGLFMEPDA(PGKEOEMFGED IOKENELNCLP)
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class GJFEHICIKAF
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public GJFEHICIKAF()
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

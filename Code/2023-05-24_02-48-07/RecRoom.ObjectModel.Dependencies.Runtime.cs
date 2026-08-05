using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using ExitGames.Client.Photon;
using RecRoom.CodeGen.Attributes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[KKBPAALNMJN(typeof(PKNLBCKILDK), new string[] { "Photon" })]
public class PAAIEDPKJJE : BOGFHHLHMCB, PKNLBCKILDK, IDisposable, OODGHPHMEDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	[BDIAFGIKHDL]
	private OCBAADNICLO FGOMHOJPKFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[BDIAFGIKHDL]
	private DFIMFFMODCD POJDKGAMKOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly Hashtable JEADDOCNIGI;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6FD90A0", Offset = "0x6FD7CA0", VA = "0x186FD90A0", Slot = "4")]
	public void InitReferences(JHMGDIDCDLA EHNANGKLKAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6FD8F10", Offset = "0x6FD7B10", VA = "0x186FD8F10", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6FD8F60", Offset = "0x6FD7B60", VA = "0x186FD8F60", Slot = "5")]
	public void EDMPMHACGNJ(OAKBKBLFPOC BDFCACLHAFA, ReadOnlySpan<byte> MEKBNGFFPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6FD8C50", Offset = "0x6FD7850", VA = "0x186FD8C50")]
	private Hashtable CHLGGFAMJDO(Hashtable KLOEAHLEKKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6FD8960", Offset = "0x6FD7560", VA = "0x186FD8960", Slot = "7")]
	private void BGMENHHBMJC(EventData BIMOMPIOOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6FD9150", Offset = "0x6FD7D50", VA = "0x186FD9150")]
	public PAAIEDPKJJE()
	{
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.Dependencies.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Preserve]
	internal class _RRAssemblyIndex : HPBGIGMFLIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7F0020", Offset = "0x7EEC20", VA = "0x1807F0020")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6FD91C0", Offset = "0x6FD7DC0", VA = "0x186FD91C0", Slot = "6")]
		public sealed override void MIJPKAHHAOP(FFIAJAAMFMA IACLOIAOHJF)
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class PFBBJKPLBFC
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
	public PFBBJKPLBFC()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class __BB_OBFUSCATOR_VERSION_3_9_9
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

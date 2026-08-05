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
	[Cpp2IlInjected.Address(RVA = "0x6FE3DA0", Offset = "0x6FE25A0", VA = "0x186FE3DA0", Slot = "4")]
	public void InitReferences(JHMGDIDCDLA EHNANGKLKAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6FE3C10", Offset = "0x6FE2410", VA = "0x186FE3C10", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6FE3C60", Offset = "0x6FE2460", VA = "0x186FE3C60", Slot = "5")]
	public void EDMPMHACGNJ(OAKBKBLFPOC BDFCACLHAFA, ReadOnlySpan<byte> MEKBNGFFPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6FE3950", Offset = "0x6FE2150", VA = "0x186FE3950")]
	private Hashtable CHLGGFAMJDO(Hashtable KLOEAHLEKKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6FE3660", Offset = "0x6FE1E60", VA = "0x186FE3660", Slot = "7")]
	private void BGMENHHBMJC(EventData BIMOMPIOOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6FE3E50", Offset = "0x6FE2650", VA = "0x186FE3E50")]
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
		[Cpp2IlInjected.Address(RVA = "0x80EA90", Offset = "0x80D290", VA = "0x18080EA90")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6FE3EC0", Offset = "0x6FE26C0", VA = "0x186FE3EC0", Slot = "6")]
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
	[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
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

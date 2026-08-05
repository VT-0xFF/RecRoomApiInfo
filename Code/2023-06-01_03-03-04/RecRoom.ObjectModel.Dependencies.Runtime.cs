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
	[Cpp2IlInjected.Address(RVA = "0x6FF4DE0", Offset = "0x6FF39E0", VA = "0x186FF4DE0", Slot = "4")]
	public void InitReferences(JHMGDIDCDLA EHNANGKLKAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6FF4C50", Offset = "0x6FF3850", VA = "0x186FF4C50", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6FF4CA0", Offset = "0x6FF38A0", VA = "0x186FF4CA0", Slot = "5")]
	public void EDMPMHACGNJ(OAKBKBLFPOC BDFCACLHAFA, ReadOnlySpan<byte> MEKBNGFFPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6FF4990", Offset = "0x6FF3590", VA = "0x186FF4990")]
	private Hashtable CHLGGFAMJDO(Hashtable KLOEAHLEKKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6FF46A0", Offset = "0x6FF32A0", VA = "0x186FF46A0", Slot = "7")]
	private void BGMENHHBMJC(EventData BIMOMPIOOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6FF4E90", Offset = "0x6FF3A90", VA = "0x186FF4E90")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F3020", Offset = "0x7F1C20", VA = "0x1807F3020")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6FF4F00", Offset = "0x6FF3B00", VA = "0x186FF4F00", Slot = "6")]
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
	[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
	public PFBBJKPLBFC()
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

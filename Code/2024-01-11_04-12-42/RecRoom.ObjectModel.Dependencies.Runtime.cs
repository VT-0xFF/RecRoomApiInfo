using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using ExitGames.Client.Photon;
using RecRoom.CodeGen.Attributes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[KHBNPKNGIHN(typeof(NNFMGDDLKBF), new string[] { "Photon" })]
public class COKNEKBLBNM : DKOLEACPDKF, NNFMGDDLKBF, IDisposable, LLDAPJEOEAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	[HOGGOCOBCAF]
	private OBDAJBOJDHN GHLEBMADCKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[HOGGOCOBCAF]
	private HDPOOKJAKPM KKAMCDLNCIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly Hashtable DEOBABCCOJC;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x60A3C50", Offset = "0x60A2650", VA = "0x1860A3C50", Slot = "4")]
	public void InitReferences(HANNLEINLJM OPLKFNLAKGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x60A3750", Offset = "0x60A2150", VA = "0x1860A3750", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x60A3A00", Offset = "0x60A2400", VA = "0x1860A3A00", Slot = "5")]
	public void GLBOMBDHAEO(MLMHGBHDOEI FHLJKJHFEEK, ReadOnlySpan<byte> DNNAMOOCONL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x60A3B50", Offset = "0x60A2550", VA = "0x1860A3B50", Slot = "9")]
	public void HLFBJGCPKAB(MLMHGBHDOEI BBOLLOBCCPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x60A35E0", Offset = "0x60A1FE0", VA = "0x1860A35E0", Slot = "6")]
	public void ABBAAHEFNKJ(ReadOnlySpan<MLMHGBHDOEI> BJPJKPPPHOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x60A37A0", Offset = "0x60A21A0", VA = "0x1860A37A0")]
	private Hashtable EDNMNOILIIO(Hashtable FGJPHEJDMHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x60A3CF0", Offset = "0x60A26F0", VA = "0x1860A3CF0", Slot = "8")]
	private void JNNKGDEPPPK(EventData EEKMGALHFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x60A41C0", Offset = "0x60A2BC0", VA = "0x1860A41C0")]
	public COKNEKBLBNM()
	{
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.Dependencies.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Preserve]
	internal class _RRAssemblyIndex : ELEICGBPLOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7BA380", Offset = "0x7B8D80", VA = "0x1807BA380")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x60A4240", Offset = "0x60A2C40", VA = "0x1860A4240", Slot = "6")]
		public sealed override void PKKGNKNPCEJ(OCKNAJKJMFD MKEOIOPNPIL)
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class PMMLLLCENIK
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public PMMLLLCENIK()
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

using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using ExitGames.Client.Photon;
using RecRoom.CodeGen.Attributes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[JAHFMFEHFPG(typeof(CGHENELOLJG), new string[] { "Photon" })]
public class ILDCFCODOJH : BFJKHKFONLF, CGHENELOLJG, IDisposable, BOEDEAICBBP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	[PKJNMMINAIF]
	private IGBGBDOHHJA MFAPABNLFEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[PKJNMMINAIF]
	private BEBFCNOCFIG FFKDFCPOFBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly Hashtable ELDLHEJCIMN;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5ED9C90", Offset = "0x5ED9090", VA = "0x185ED9C90", Slot = "4")]
	public void InitReferences(DCDICCBPDIP KAPGNOEILJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5ED9790", Offset = "0x5ED8B90", VA = "0x185ED9790", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5ED9B40", Offset = "0x5ED8F40", VA = "0x185ED9B40", Slot = "5")]
	public void IIINLNBBFIK(ABMDNLLGAPC MIMFBLPNKOG, ReadOnlySpan<byte> LJIMLOGOIHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5ED9A40", Offset = "0x5ED8E40", VA = "0x185ED9A40", Slot = "9")]
	public void IDAOOAKAAFK(ABMDNLLGAPC COPOMFAFNNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5EDA200", Offset = "0x5ED9600", VA = "0x185EDA200", Slot = "6")]
	public void NOPABOEEMAE(ReadOnlySpan<ABMDNLLGAPC> AHLNBLMLNGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5ED97E0", Offset = "0x5ED8BE0", VA = "0x185ED97E0")]
	private Hashtable EEDOKBNNMBG(Hashtable FAMKBFOGKCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5ED9D30", Offset = "0x5ED9130", VA = "0x185ED9D30", Slot = "8")]
	private void KGEELIDENAB(EventData OCFFDKFEACK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5EDA370", Offset = "0x5ED9770", VA = "0x185EDA370")]
	public ILDCFCODOJH()
	{
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.Dependencies.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Preserve]
	internal class _RRAssemblyIndex : FMCDNLLKPEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x79B610", Offset = "0x79AA10", VA = "0x18079B610")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5EDA3F0", Offset = "0x5ED97F0", VA = "0x185EDA3F0", Slot = "6")]
		public sealed override void IHFNENEGKLH(KACPMKJBEIB PDECDCHNHMC)
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class DADPLEAPLGN
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public DADPLEAPLGN()
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

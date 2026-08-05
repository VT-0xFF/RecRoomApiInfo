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
	[Cpp2IlInjected.Address(RVA = "0x5ED9BB0", Offset = "0x5ED8FB0", VA = "0x185ED9BB0", Slot = "4")]
	public void InitReferences(DCDICCBPDIP KAPGNOEILJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5ED96B0", Offset = "0x5ED8AB0", VA = "0x185ED96B0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5ED9A60", Offset = "0x5ED8E60", VA = "0x185ED9A60", Slot = "5")]
	public void IIINLNBBFIK(ABMDNLLGAPC MIMFBLPNKOG, ReadOnlySpan<byte> LJIMLOGOIHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5ED9960", Offset = "0x5ED8D60", VA = "0x185ED9960", Slot = "9")]
	public void IDAOOAKAAFK(ABMDNLLGAPC COPOMFAFNNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5EDA120", Offset = "0x5ED9520", VA = "0x185EDA120", Slot = "6")]
	public void NOPABOEEMAE(ReadOnlySpan<ABMDNLLGAPC> AHLNBLMLNGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5ED9700", Offset = "0x5ED8B00", VA = "0x185ED9700")]
	private Hashtable EEDOKBNNMBG(Hashtable FAMKBFOGKCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5ED9C50", Offset = "0x5ED9050", VA = "0x185ED9C50", Slot = "8")]
	private void KGEELIDENAB(EventData OCFFDKFEACK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5EDA290", Offset = "0x5ED9690", VA = "0x185EDA290")]
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
		[Cpp2IlInjected.Address(RVA = "0x5EDA310", Offset = "0x5ED9710", VA = "0x185EDA310", Slot = "6")]
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

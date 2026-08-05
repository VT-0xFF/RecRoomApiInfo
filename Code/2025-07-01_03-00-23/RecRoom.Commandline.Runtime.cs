using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _AssemblyRegistry.RecRoom_Commandline_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7EC2960", Offset = "0x7EC0F60", VA = "0x187EC2960", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x282D140", Offset = "0x282B740", VA = "0x18282D140")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface LDFDNGGCOMM
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string AGFFMGKOEGA(string GDFBBGHAAKG);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FELPLAHGIJN(string GDFBBGHAAKG);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum AIIHKGCGJDA
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RecRoom.NoEngine.Common.Preserve]
public class JFLIBHNAGOA : LDFDNGGCOMM
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static List<string> HIMJNKFIAPI;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] NKGIIDODGJH;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static string[] HFFPBNHJNAO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string[] PNNCOHDIOFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7EC24F0", Offset = "0x7EC0AF0", VA = "0x187EC24F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] GHPIPIBPPCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7EC26C0", Offset = "0x7EC0CC0", VA = "0x187EC26C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7EC2870", Offset = "0x7EC0E70", VA = "0x187EC2870")]
	[BNHIEDNKDNA.MLFEBCDGLFC]
	internal static void PCDILHPDLBD(DCNOMJHNEOK FAIEEFHMPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7EC2500", Offset = "0x7EC0B00", VA = "0x187EC2500")]
	internal static string[] JCHICAELPJK(string[] MDBMMBLMNGD, string[] MFJEJJAHPNA, List<string> HGKCINEFGBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7EC23A0", Offset = "0x7EC09A0", VA = "0x187EC23A0", Slot = "4")]
	private string AMFKEEGIKGI(string GDFBBGHAAKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7EC22F0", Offset = "0x7EC08F0", VA = "0x187EC22F0")]
	public static string AGFFMGKOEGA(string GDFBBGHAAKG, [Optional] string COMAGLLDBOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7EC2620", Offset = "0x7EC0C20", VA = "0x187EC2620", Slot = "5")]
	private bool JECHKAMODOP(string GDFBBGHAAKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7EC2450", Offset = "0x7EC0A50", VA = "0x187EC2450")]
	public static bool FELPLAHGIJN(string GDFBBGHAAKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public JFLIBHNAGOA()
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

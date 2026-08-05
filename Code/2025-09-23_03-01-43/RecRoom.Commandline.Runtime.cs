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
		[Cpp2IlInjected.Address(RVA = "0x84083B0", Offset = "0x84069B0", VA = "0x1884083B0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x29CB0D0", Offset = "0x29C96D0", VA = "0x1829CB0D0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface AOCLLHGAFPF
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string HGDHJCJJGBH(string EIDEEAHADAH);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BLINAFNDNKK(string EIDEEAHADAH);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum MDFNLOKDNAI
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RecRoom.NoEngine.Common.Preserve]
public class LKGKPOKOHLM : AOCLLHGAFPF
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static List<string> NKLNEFBNABH;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] OIKBCOICEDA;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static string[] EGBPIHOBCNF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string[] PEMPFCIIKFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8407DD0", Offset = "0x84063D0", VA = "0x188407DD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] MDGCPKFDKHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8407DE0", Offset = "0x84063E0", VA = "0x188407DE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8407F90", Offset = "0x8406590", VA = "0x188407F90")]
	[EGNICHGEFDG.KHJDAJHJKCM]
	internal static void GOLDGDOKEIF(NMNJFHODGJA JBBCAANONNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8408290", Offset = "0x8406890", VA = "0x188408290")]
	internal static string[] OHPEGPLBDLI(string[] FNJCOCIGEMM, string[] IGNJCDPNHII, List<string> LBGBOFPMPOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8408140", Offset = "0x8406740", VA = "0x188408140", Slot = "4")]
	private string ICOMFHMAOHD(string EIDEEAHADAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8408090", Offset = "0x8406690", VA = "0x188408090")]
	public static string HGDHJCJJGBH(string EIDEEAHADAH, [Optional] string APJDJFMLEAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x84081F0", Offset = "0x84067F0", VA = "0x1884081F0", Slot = "5")]
	private bool MDCCHKFDIED(string EIDEEAHADAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8407D30", Offset = "0x8406330", VA = "0x188407D30")]
	public static bool BLINAFNDNKK(string EIDEEAHADAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public LKGKPOKOHLM()
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

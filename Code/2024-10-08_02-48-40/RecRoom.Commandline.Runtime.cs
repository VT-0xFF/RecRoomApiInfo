using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer.Attributes;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _AssemblyRegistry.RecRoom_Commandline_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : JFBHLNBAFAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6B91B70", Offset = "0x6B90D70", VA = "0x186B91B70", Slot = "8")]
		public override void KGHJDOOILCG(KCABLKMBKAN registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x63262B0", Offset = "0x63254B0", VA = "0x1863262B0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface HOMCMAMCPLI
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string LPOGBJMCDBN(string AHJMNOJALCD);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ABBOEOKBLNF(string AHJMNOJALCD);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum KJDMKHMCIEJ
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RecRoom.NoEngine.Common.Preserve]
public class AJIOMHIMAOB : HOMCMAMCPLI
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static List<string> HCOOBOKJLOM;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] CDGCJDIOHGB;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static string[] AGOGLOMJMAA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string[] ILBIIIINNEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6B918D0", Offset = "0x6B90AD0", VA = "0x186B918D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] GGNLECNGMEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6B918E0", Offset = "0x6B90AE0", VA = "0x186B918E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6B91A80", Offset = "0x6B90C80", VA = "0x186B91A80")]
	[NPIOOMADHDK.JLDADBHPDAA]
	internal static void NLJAFONFJGA(KHAIBIPGEJP DDIEINIMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6B91660", Offset = "0x6B90860", VA = "0x186B91660")]
	internal static string[] GFBCFGPDFCA(string[] MELHOEOGMCK, string[] MNEPMJLGJCF, List<string> PEJFHIOGGIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6B915B0", Offset = "0x6B907B0", VA = "0x186B915B0", Slot = "4")]
	private string GCHFANAGKND(string AHJMNOJALCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6B91820", Offset = "0x6B90A20", VA = "0x186B91820")]
	public static string LPOGBJMCDBN(string AHJMNOJALCD, [Optional] string IIGPKDCCLGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6B91780", Offset = "0x6B90980", VA = "0x186B91780", Slot = "5")]
	private bool LNKKJMFIFNL(string AHJMNOJALCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6B91510", Offset = "0x6B90710", VA = "0x186B91510")]
	public static bool ABBOEOKBLNF(string AHJMNOJALCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	public AJIOMHIMAOB()
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

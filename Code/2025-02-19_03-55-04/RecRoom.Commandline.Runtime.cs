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
		[Cpp2IlInjected.Address(RVA = "0x73D6B50", Offset = "0x73D5750", VA = "0x1873D6B50", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x240ECE0", Offset = "0x240D8E0", VA = "0x18240ECE0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface EIPFPKLGLHG
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string GBKFALGBOEE(string NIIENGDOBFN);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IIECNNOIOFH(string NIIENGDOBFN);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum CNKECBAFCCN
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RecRoom.NoEngine.Common.Preserve]
public class PEDEGLJNLOG : EIPFPKLGLHG
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static List<string> KAGEHHCDGFF;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] HPGCOGIHLJP;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static string[] MFKLGNACMHG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string[] EJEIABJBAEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x73D6700", Offset = "0x73D5300", VA = "0x1873D6700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] CPLPCAJDHFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x73D69B0", Offset = "0x73D55B0", VA = "0x1873D69B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x73D6600", Offset = "0x73D5200", VA = "0x1873D6600")]
	[DMDJPIBKEJJ.OHIIEKNFAKB]
	internal static void EKJPAICHAMI(KPLLBHIBBNH AGGFAPJEEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x73D64E0", Offset = "0x73D50E0", VA = "0x1873D64E0")]
	internal static string[] ECIOKFIFGIL(string[] JCHFMJAHCMC, string[] MCMCGMGGFLK, List<string> FOFMCLBCLOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x73D6900", Offset = "0x73D5500", VA = "0x1873D6900", Slot = "4")]
	private string KCKAIEFHOAM(string NIIENGDOBFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x73D67B0", Offset = "0x73D53B0", VA = "0x1873D67B0")]
	public static string GBKFALGBOEE(string NIIENGDOBFN, [Optional] string NBKBMLNEBHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x73D6710", Offset = "0x73D5310", VA = "0x1873D6710", Slot = "5")]
	private bool FKIMNHHFJLP(string NIIENGDOBFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x73D6860", Offset = "0x73D5460", VA = "0x1873D6860")]
	public static bool IIECNNOIOFH(string NIIENGDOBFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public PEDEGLJNLOG()
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

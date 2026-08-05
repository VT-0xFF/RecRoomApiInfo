using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Logging.Attributes;
using Unity.Mathematics;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8D6960", Offset = "0x8D5360", VA = "0x1808D6960")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6483DD0", Offset = "0x64827D0", VA = "0x186483DD0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8D7890", Offset = "0x8D6290", VA = "0x1808D7890")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8D78D0", Offset = "0x8D62D0", VA = "0x1808D78D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _LogRegistration.RecNet_DataCollection
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : IGBHOMLLHLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x647FD20", Offset = "0x647E720", VA = "0x18647FD20", Slot = "4")]
		public override void KFMGLABNFNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8D6960", Offset = "0x8D5360", VA = "0x1808D6960")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecNet_DataCollection
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6485390", Offset = "0x6483D90", VA = "0x186485390", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2164780", Offset = "0x2163180", VA = "0x182164780")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface LDDFJFEOCEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyDictionary<string, object> BHGLAGNMCIN();
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class OLPKOBNMNJH
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface OCELBPLFPCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "0")]
		DLDFCBMLNLG FMGHPLIDHDO(Guid DKDBDIKANCM, string OINMCIKACIG, [Optional] string MCPJGMFLHLP, [Optional] long? FEJKBOIKNON, [Optional] string FLKBKEDNIML, [Optional] string LCCKNOODDHO);
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class DNFHFOFNFDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x647FA40", Offset = "0x647E440", VA = "0x18647FA40")]
		public static DLDFCBMLNLG HAOCCHHNFIJ(Guid DKDBDIKANCM, string OINMCIKACIG, string MCPJGMFLHLP, [Optional] long? FEJKBOIKNON, [Optional] string FLKBKEDNIML, [Optional] string LCCKNOODDHO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class DLDFCBMLNLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		protected PPKAOONLHOG JEAABFEJJGG;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8B23B0", Offset = "0x8B0DB0", VA = "0x1808B23B0")]
		public DLDFCBMLNLG(PPKAOONLHOG JEAABFEJJGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x647F9C0", Offset = "0x647E3C0", VA = "0x18647F9C0")]
		public DLDFCBMLNLG HOCGKCHKMOL(string JKKOEFMEAMD, string PKCLPFEIPFH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3582570", Offset = "0x3580F70", VA = "0x183582570")]
		public DLDFCBMLNLG HOCGKCHKMOL<T>(string JKKOEFMEAMD, T PKCLPFEIPFH) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x35824E0", Offset = "0x3580EE0", VA = "0x1835824E0")]
		public DLDFCBMLNLG BDNHMDFBOLN<T>(string JKKOEFMEAMD, T? PKCLPFEIPFH) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x647F910", Offset = "0x647E310", VA = "0x18647F910")]
		public DLDFCBMLNLG BDNHMDFBOLN(string JKKOEFMEAMD, string PKCLPFEIPFH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x647F9A0", Offset = "0x647E3A0", VA = "0x18647F9A0")]
		public HGKKEBPLLAP FLKNKBLIAHH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2277150", Offset = "0x2275B50", VA = "0x182277150", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class PPKAOONLHOG
	{
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public static Action<PPKAOONLHOG> HMONMIOOOJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly string IHHMGJOBHNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly Dictionary<string, object> ADLIGBDHBEO;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6484D50", Offset = "0x6483750", VA = "0x186484D50")]
		private PPKAOONLHOG(string IHHMGJOBHNC, int KGOMJEMDBBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6484360", Offset = "0x6482D60", VA = "0x186484360")]
		public static DLDFCBMLNLG LNCAGMGJJFK(string IHHMGJOBHNC, int KGOMJEMDBBE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6484A40", Offset = "0x6483440", VA = "0x186484A40")]
		public HGKKEBPLLAP FLKNKBLIAHH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6484CE0", Offset = "0x64836E0", VA = "0x186484CE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2D294B0", Offset = "0x2D27EB0", VA = "0x182D294B0")]
		internal void NAGLFMEDNJH<T>(string JKKOEFMEAMD, T PKCLPFEIPFH) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6484C80", Offset = "0x6483680", VA = "0x186484C80")]
		internal void NAGLFMEDNJH(string JKKOEFMEAMD, string PKCLPFEIPFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3589EB0", Offset = "0x35888B0", VA = "0x183589EB0")]
		private void CPPIKCGJEPM<T>(string JKKOEFMEAMD, T PKCLPFEIPFH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct MHLPKBCJBBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly string PALHLIIILII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public readonly long? FFMKJNBFCOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public readonly short? BCGCJFNHOCG;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x647FDB0", Offset = "0x647E7B0", VA = "0x18647FDB0")]
		public MHLPKBCJBBN(string FCMLNDIIECO, [Optional] long? NPGHGEFGHLA, [Optional] short? FPHPAOGKIAC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct OMPDPMDCOHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public readonly int ABLEDHIJFPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public readonly string LFEPACIOGPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public readonly short JNKIMDMBFKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly string OIEKEMBDMDM;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6484750", Offset = "0x6483150", VA = "0x186484750")]
		public OMPDPMDCOHA(int GLLNHNBEBCH, string BANGECFOGOK, short EJINCMGGJHI, string LKFANNIPMPO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class BMHDFHOBOMD : JJCLGLJLBAB<JKMLHGJLGFI, OMPDPMDCOHA, MHLPKBCJBBN>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private string BANGECFOGOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private short EJINCMGGJHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private string LKFANNIPMPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private Dictionary<short, int> GCKNNJGCJBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int ICAANLAINIA;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x647DC40", Offset = "0x647C640", VA = "0x18647DC40")]
		public BMHDFHOBOMD(string FIGCNDNKPBL, Guid INNGMONECPC, long DMHEEMFLNHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x647D950", Offset = "0x647C350", VA = "0x18647D950", Slot = "4")]
		public override void PIBGICDPJFJ(OMPDPMDCOHA NMLADFJPIPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x647C7E0", Offset = "0x647B1E0", VA = "0x18647C7E0")]
		public void ADHJANLJDND(short EJINCMGGJHI, bool FANHMEPECJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3F03EC0", Offset = "0x3F028C0", VA = "0x183F03EC0")]
		public void HDEJKFGNOEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8AB210", Offset = "0x8A9C10", VA = "0x1808AB210")]
		public void IFNCBHCLNJD(string FNECOHGMOEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x647CB70", Offset = "0x647B570", VA = "0x18647CB70", Slot = "5")]
		public override void NFLLCMPFHCC(bool LMEIHFILHBE, MHLPKBCJBBN NCOEKMKFHFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x647C8C0", Offset = "0x647B2C0", VA = "0x18647C8C0", Slot = "6")]
		public override NBDLLDCFFMH AMBFKKHCDEE(JKMLHGJLGFI NEILODECFFG, int GCBONJOGHCD, string LIDIDHEJPDN)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class POFHFEBFLAN : NBDLLDCFFMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private string BANGECFOGOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public readonly short EJINCMGGJHI;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6484950", Offset = "0x6483350", VA = "0x186484950")]
		public POFHFEBFLAN(long NFIKDKPAGBO, int GLLNHNBEBCH, string MCPJGMFLHLP, long DMHEEMFLNHE, int AJLGMGADMFI, string FLKBKEDNIML, short EJINCMGGJHI, string BANGECFOGOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x64848D0", Offset = "0x64832D0", VA = "0x1864848D0")]
		public void HPLHFHENGDJ(int GLLNHNBEBCH, string BANGECFOGOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x64847A0", Offset = "0x64831A0", VA = "0x1864847A0", Slot = "5")]
		public override DLDFCBMLNLG FMGHPLIDHDO(Guid DKDBDIKANCM, string OINMCIKACIG, [Optional] string MCPJGMFLHLP, [Optional] long? FEJKBOIKNON, [Optional] string FLKBKEDNIML, [Optional] string LCCKNOODDHO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class BCLGGNOPMIO
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x647C6D0", Offset = "0x647B0D0", VA = "0x18647C6D0")]
		public static void EBHKMOKCJAK(string PNABAFEIDND, object CIDIGKGIMEL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public static class NJKMKEBMOAB
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public readonly struct ENMNAMKEKJI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public readonly int JHIOCILBHEH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public readonly int GFMKGCBMAPM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public readonly int OJJKPOGAHOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly int HNOOMAPMPKL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public readonly int DFGLAHIGIEG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public readonly int LKKNEGJNOBG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public readonly int DKNNLAPOEML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public readonly int DFLJMFMODJI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public readonly int KLLIOBDLIDF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public readonly int CLIGJGKBEJD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public readonly int GNGCKAHJCBK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public readonly int BBGMHMCNPBL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public readonly int CPBFLCAHJDH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public readonly int LIKLKCGOGKE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public readonly int AIFLAIIOACG;

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x647FC50", Offset = "0x647E650", VA = "0x18647FC50")]
			public ENMNAMKEKJI(int COMAOCCCDJP, int CJMNCLBCIOG, int NMDGLNIFOLP, int LHLEPHMBNOD, int AKMJGEIGIFA, int EBILBPDELJA, int JAFMFLHJELJ, int AOAJCLNKOFA, int JDLOGAKFHBL, int MOECKNNNOOB, int OIGGNBNDKKC, int PCENDIBHIHN, int HOGKOAINCLG, int FNNPCBILEMG, int EHOGDBKOPBC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static Dictionary<string, object>? IDODMOOLKEO;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private static Dictionary<string, object> OHAECFEMEJM
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6483D20", Offset = "0x6482720", VA = "0x186483D20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6483530", Offset = "0x6481F30", VA = "0x186483530")]
		public static void MPPJICEOIJH(ENMNAMKEKJI PLCDPIFLJOO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class NAFBKPEFMPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x647FDF0", Offset = "0x647E7F0", VA = "0x18647FDF0")]
		public static void EBHKMOKCJAK(string PNABAFEIDND, object CIDIGKGIMEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6480090", Offset = "0x647EA90", VA = "0x186480090")]
		public static void EBHKMOKCJAK(string PNABAFEIDND, float PKCLPFEIPFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x647FE60", Offset = "0x647E860", VA = "0x18647FE60")]
		public static void EBHKMOKCJAK(string PNABAFEIDND, MBPCHOOCNHF CIDIGKGIMEL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class CJBGLKDAHLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x647F2C0", Offset = "0x647DCC0", VA = "0x18647F2C0")]
		public static void PHOCPGNIJHD(float3 PCPIJKGKPCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x647F1A0", Offset = "0x647DBA0", VA = "0x18647F1A0")]
		public static void NEFABGNEAHH(bool KCLCBGKHDGD, bool IOGOGGNOAHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x647F100", Offset = "0x647DB00", VA = "0x18647F100")]
		public static void AKPHHDPKKMK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class KBCEELFHNKB<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class CEKIBHMKEJP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public KBCEELFHNKB<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
			public CEKIBHMKEJP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x540BE60", Offset = "0x540A860", VA = "0x18540BE60")]
			internal object LLKOFLFNELL()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class ACDOGBLFPGB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public KBCEELFHNKB<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
			public ACDOGBLFPGB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x409A2F0", Offset = "0x4098CF0", VA = "0x18409A2F0")]
			internal object HIIPAAJOIOF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class AMIHFCKEAPM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public KBCEELFHNKB<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
			public AMIHFCKEAPM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x415BC60", Offset = "0x415A660", VA = "0x18415BC60")]
			internal object HFNJJHLPJIB()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class CFONADMPHCK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public KBCEELFHNKB<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
			public CFONADMPHCK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x540FD10", Offset = "0x540E710", VA = "0x18540FD10")]
			internal object NMJNECMIGKB()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private const float FKMMBKEIFMB = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly Guid DKDBDIKANCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly string FLKBKEDNIML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly string HAMJKMHOKIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private string AFCMJFJAGAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private string LCCKNOODDHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private string BDPPEKJCJJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private string BHHPDJNNPBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private string LBAEJNHPAJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private string PDKAOKGOLDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private string NMJNHKILNHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private Guid? DJLPGAOCDHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private (int, int)? DOCDCMNDGEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly HashSet<T> FGJNJMHNPDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private readonly Dictionary<(T, int), string> JCKPNJHDCJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly Dictionary<(T, int), float> ANINCBLNJLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly Dictionary<T, string> ICFMMHAMKKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private string NGHIKKLNHOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool HJBPDCJAIMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private HGKKEBPLLAP HNJHGKIAPOJ;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x44F4D20", Offset = "0x44F3720", VA = "0x1844F4D20")]
		public KBCEELFHNKB(Guid DKDBDIKANCM, string HAMJKMHOKIB, string FLKBKEDNIML, string AFCMJFJAGAA, [Optional] string LCCKNOODDHO, [Optional] string BDPPEKJCJJP, [Optional] string BHHPDJNNPBK, [Optional] string NMJNHKILNHG, [Optional] string NGHIKKLNHOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8B00F0", Offset = "0x8AEAF0", VA = "0x1808B00F0")]
		public void MFAJBFDCPDJ(string LCCKNOODDHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8B4D30", Offset = "0x8B3730", VA = "0x1808B4D30")]
		public void AADOHFAFKOO(string AFCMJFJAGAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8B6910", Offset = "0x8B5310", VA = "0x1808B6910")]
		public void CMOMENPNGAK(string NGHIKKLNHOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8AB1E0", Offset = "0x8A9BE0", VA = "0x1808AB1E0")]
		public void GGLFKLHANME(string LBAEJNHPAJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x44F3100", Offset = "0x44F1B00", VA = "0x1844F3100")]
		public void HMOIIEMOGAA(Guid? DKDBDIKANCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x44E5CE0", Offset = "0x44E46E0", VA = "0x1844E5CE0")]
		public void DGKFHCNEAOJ((int, int)? DOCDCMNDGEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8AB240", Offset = "0x8A9C40", VA = "0x1808AB240")]
		public void OBLGMEJHDDM(string PDKAOKGOLDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x44F3640", Offset = "0x44F2040", VA = "0x1844F3640")]
		public void JPLLFJCAMAE(T FEJKBOIKNON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x44F3B20", Offset = "0x44F2520", VA = "0x1844F3B20")]
		public void LHAAMJHOLII(T FEJKBOIKNON, int MBDLAOIJGLL, float NOMMEIKOKMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x44F47F0", Offset = "0x44F31F0", VA = "0x1844F47F0")]
		public void PLBAHBIDOJA(T FEJKBOIKNON, int MBDLAOIJGLL, string NBFPACDFLKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x44F3480", Offset = "0x44F1E80", VA = "0x1844F3480")]
		public void JCCBFCCPOPC(T FEJKBOIKNON, string IAPIFCEGBNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x44F0840", Offset = "0x44EF240", VA = "0x1844F0840")]
		public HGKKEBPLLAP FLKNKBLIAHH(bool DEDPJAGPBOL = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x44F2460", Offset = "0x44F0E60", VA = "0x1844F2460")]
		private (IEnumerable<T>, string) GJNKJAOOCMA()
		{
			return default((IEnumerable<T>, string));
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x44EF1C0", Offset = "0x44EDBC0", VA = "0x1844EF1C0")]
		public static DLDFCBMLNLG EPOIHJONHOL(Guid DKDBDIKANCM, string HAMJKMHOKIB, T FEJKBOIKNON, string FLKBKEDNIML, string LEBOFGNGHEE, string LCCKNOODDHO, int? GCBONJOGHCD, [Optional] string MEPDKEIAPBH, [Optional] string IAPIFCEGBNG, [Optional] int? MLGIHAABFLL, [Optional] Guid? DJLPGAOCDHI, [Optional] string NGHIKKLNHOH, [Optional] string MCPJGMFLHLP, [Optional] (int, int)? DOCDCMNDGEN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x44EF130", Offset = "0x44EDB30", VA = "0x1844EF130")]
		[CompilerGenerated]
		private string ANIGNCDFFKB(T CMEADPACGME)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public abstract class JJCLGLJLBAB<TItem, TListSessionStartParams, TListSessionLogParams>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		protected readonly string FIGCNDNKPBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		protected readonly Guid INNGMONECPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		protected readonly long DMHEEMFLNHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		protected int GLLNHNBEBCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		protected int GJPOELLCFLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		protected DateTime PCGNKHJJHEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		protected bool GLGDNHHAFFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		protected Dictionary<long, NBDLLDCFFMH> PHJLEIKFIEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		protected bool HNGMOLGJCGM;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool HBBOBABEAJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x935D30", Offset = "0x934730", VA = "0x180935D30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool MPBANEGHLOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xA895D0", Offset = "0xA87FD0", VA = "0x180A895D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x4436C70", Offset = "0x4435670", VA = "0x184436C70")]
		public JJCLGLJLBAB(string FIGCNDNKPBL, Guid INNGMONECPC, long DMHEEMFLNHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void PIBGICDPJFJ(TListSessionStartParams NMLADFJPIPJ);

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xCAD480", Offset = "0xCABE80", VA = "0x180CAD480")]
		public void IHOFEEENHIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void NFLLCMPFHCC(bool LMEIHFILHBE, TListSessionLogParams NCOEKMKFHFI);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x4436B00", Offset = "0x4435500", VA = "0x184436B00")]
		public void KDIOOGOECDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x4436840", Offset = "0x4435240", VA = "0x184436840")]
		public void FHMNLGDGKDL(long NFIKDKPAGBO, int GCBONJOGHCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x4436A70", Offset = "0x4435470", VA = "0x184436A70")]
		public void JFLOGJHDJFC(long NFIKDKPAGBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract NBDLLDCFFMH AMBFKKHCDEE(TItem GNDKBENMBLO, int GCBONJOGHCD, string LIDIDHEJPDN);
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class NBDLLDCFFMH : OCELBPLFPCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private int GLLNHNBEBCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private long NFIKDKPAGBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private long DMHEEMFLNHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private readonly string EBFPNOCHHDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private readonly string KGBGODBDBOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private readonly int AJLGMGADMFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private DateTime FMCLLNHJDOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private double GLCPANPDCIJ;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool BKBEEGKGJKG
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x9DC360", Offset = "0x9DAD60", VA = "0x1809DC360")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x9DC7F0", Offset = "0x9DB1F0", VA = "0x1809DC7F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6480880", Offset = "0x647F280", VA = "0x186480880")]
		public NBDLLDCFFMH(long NFIKDKPAGBO, int GLLNHNBEBCH, string MCPJGMFLHLP, long DMHEEMFLNHE, int AJLGMGADMFI, [Optional] string FLKBKEDNIML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6480810", Offset = "0x647F210", VA = "0x186480810")]
		public void OCGEACNMEKJ(int GLLNHNBEBCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x64801A0", Offset = "0x647EBA0", VA = "0x1864801A0")]
		public void AIAHFEILDME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x64801F0", Offset = "0x647EBF0", VA = "0x1864801F0")]
		public void DMFBLKNIEPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x64807B0", Offset = "0x647F1B0", VA = "0x1864807B0")]
		private void GBONLNNCHNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6480300", Offset = "0x647ED00", VA = "0x186480300", Slot = "5")]
		public virtual DLDFCBMLNLG FMGHPLIDHDO(Guid DKDBDIKANCM, string OINMCIKACIG, [Optional] string MCPJGMFLHLP, [Optional] long? FEJKBOIKNON, [Optional] string FLKBKEDNIML, [Optional] string LCCKNOODDHO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public static class NGFOEBIGJAB
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class BLGFODPNEGD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public float nextHeartbeatSendTime;

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
			public BLGFODPNEGD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x647C740", Offset = "0x647B140", VA = "0x18647C740")]
			internal bool NKDJHOEHNOG()
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[CompilerGenerated]
		private struct CGJIJCLFMFK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			private BLGFODPNEGD <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			private TimeSpan <delayPollingInterval>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private bool <isForcedHeartbeatEvent>5__3;

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x647DEA0", Offset = "0x647C8A0", VA = "0x18647DEA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x647F0A0", Offset = "0x647DAA0", VA = "0x18647F0A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public static readonly float PIMNCJJFMLM;

		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private static Dictionary<string, Dictionary<string, object>> EIADABGHBDJ;

		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private static Dictionary<string, Dictionary<string, object>> HKAOHNLANFI;

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static string PJNLCPOKGJM;

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static CancellationTokenSource? EBDPCDNJMJG;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static int AENPFFPEABJ;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static int EEGAMKNGBMD;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static bool DMAEHFBPBJO;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static readonly Dictionary<string, LDDFJFEOCEJ> BMGHLFBMGEE;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly ABIBNEMCANM<bool> JPLANGFDOJE;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static CLNMMCDHJBN? CBHJJHLODEF;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private static string LLBKHDJIJJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x6481AD0", Offset = "0x64804D0", VA = "0x186481AD0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x6480A00", Offset = "0x647F400", VA = "0x186480A00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static Guid? EAJHFEKLIHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x6482780", Offset = "0x6481180", VA = "0x186482780")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x6480F60", Offset = "0x647F960", VA = "0x186480F60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static Guid? CFCCKJEGBNJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x6480AB0", Offset = "0x647F4B0", VA = "0x186480AB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x6481D80", Offset = "0x6480780", VA = "0x186481D80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static DHPLOJPHLPI<bool> DDDLPFPAINM
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x6480B10", Offset = "0x647F510", VA = "0x186480B10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private static bool JDDMCFJHKFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x6483290", Offset = "0x6481C90", VA = "0x186483290")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x6480F00", Offset = "0x647F900", VA = "0x186480F00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private static bool KDBNLIJFOCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x6480B60", Offset = "0x647F560", VA = "0x186480B60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x6480BB0", Offset = "0x647F5B0", VA = "0x186480BB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private static float OCIDADNHBMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x6481670", Offset = "0x6480070", VA = "0x186481670")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x6480950", Offset = "0x647F350", VA = "0x186480950")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6481EB0", Offset = "0x64808B0", VA = "0x186481EB0")]
		public static void LDJIBFBKOMD(string KIDIAFKOHCO, LDDFJFEOCEJ NNOMEOMIIMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6481240", Offset = "0x647FC40", VA = "0x186481240")]
		private static void HBOKDJGEDEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6480FC0", Offset = "0x647F9C0", VA = "0x186480FC0")]
		internal static void GCHKJEOLKFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6480C10", Offset = "0x647F610", VA = "0x186480C10")]
		internal static void DBGMAPHEIBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x64811A0", Offset = "0x647FBA0", VA = "0x1864811A0")]
		internal static void GHGIHNFHMEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6482CC0", Offset = "0x64816C0", VA = "0x186482CC0")]
		public static Guid PIBGICDPJFJ(string KIDIAFKOHCO, [Optional] string? NDEKAAFNFIC, [Optional] Dictionary<string, object>? JJKMCGFPKGP)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6482C20", Offset = "0x6481620", VA = "0x186482C20")]
		public static Guid PIBGICDPJFJ(string KIDIAFKOHCO, long NDEKAAFNFIC, [Optional] Dictionary<string, object>? JJKMCGFPKGP)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6481B20", Offset = "0x6480520", VA = "0x186481B20")]
		public static void IHOFEEENHIG(string KIDIAFKOHCO, [Optional] Guid? MMGMNLELLKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6482A20", Offset = "0x6481420", VA = "0x186482A20")]
		public static void PCIJKIJJJIP(string KIDIAFKOHCO, string BDGNBAKPNIE, object LBCDKEDAONI, bool DMAEHFBPBJO = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6482830", Offset = "0x6481230", VA = "0x186482830")]
		public static bool NIBEJHKKNDN(string KIDIAFKOHCO, [Optional] string? NDEKAAFNFIC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6480DC0", Offset = "0x647F7C0", VA = "0x186480DC0")]
		private static void ECHOBPJFGMO(bool KNHNGHBDBIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6482020", Offset = "0x6480A20", VA = "0x186482020")]
		internal static void LMEJHDANFAE(string KMDNOIPDFGB, string PNABAFEIDND, object GGEMPJLCHFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x64821A0", Offset = "0x6480BA0", VA = "0x1864821A0")]
		internal static void LMEJHDANFAE(string KMDNOIPDFGB, Dictionary<string, object> IMBCPMLJKOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6481A60", Offset = "0x6480460", VA = "0x186481A60")]
		private static void HGHIPJNMAIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x64809B0", Offset = "0x647F3B0", VA = "0x1864809B0")]
		public static void AMIFEEIECMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x64827E0", Offset = "0x64811E0", VA = "0x1864827E0")]
		public static void NBJLHNKCJGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x64816C0", Offset = "0x64800C0", VA = "0x1864816C0")]
		private static void HFFGOBGFICA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6481DE0", Offset = "0x64807E0", VA = "0x186481DE0")]
		private static void JOHCLAKDNCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6481F40", Offset = "0x6480940", VA = "0x186481F40")]
		[AsyncStateMachine(typeof(CGJIJCLFMFK))]
		private static Task LHOGHHFAJIH(CancellationToken PPLDCJFFMEP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6482320", Offset = "0x6480D20", VA = "0x186482320")]
		private static void MDBKNMKBFBL(string KIDIAFKOHCO, Guid DKDBDIKANCM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class AKHCOHOBLGF
	{
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public struct DEKPDBHGJPO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public bool HDKDMAHLAFI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public string HEJCCGDENJJ;

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x205F870", Offset = "0x205E270", VA = "0x18205F870")]
			public DEKPDBHGJPO(bool HDKDMAHLAFI, string HEJCCGDENJJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x647BCC0", Offset = "0x647A6C0", VA = "0x18647BCC0")]
		public static DEKPDBHGJPO PMAPEFGPDFK(DLDFCBMLNLG ENLCOHBLHJM)
		{
			return default(DEKPDBHGJPO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x647BBC0", Offset = "0x647A5C0", VA = "0x18647BBC0")]
		private static void OPKLOOOFEJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x647BB00", Offset = "0x647A500", VA = "0x18647BB00")]
		private static void JEODHDNOINP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class KLCPMKHOECO
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x647FCC0", Offset = "0x647E6C0", VA = "0x18647FCC0")]
		public static DLDFCBMLNLG ONGFKPGJDDD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class DJJKLIDDOPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x647F610", Offset = "0x647E010", VA = "0x18647F610")]
		public static DLDFCBMLNLG JKILOGEPLFA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x647F430", Offset = "0x647DE30", VA = "0x18647F430")]
		public static DLDFCBMLNLG GAOGANBKJCN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x647F550", Offset = "0x647DF50", VA = "0x18647F550")]
		public static DLDFCBMLNLG HDEDOIAFNHM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x647F6D0", Offset = "0x647E0D0", VA = "0x18647F6D0")]
		public static DLDFCBMLNLG MKCCMKPJOPD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x647F5B0", Offset = "0x647DFB0", VA = "0x18647F5B0")]
		public static DLDFCBMLNLG HFLMHKEJJOF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x647F790", Offset = "0x647E190", VA = "0x18647F790")]
		public static DLDFCBMLNLG NNNCDABEMOM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x647F730", Offset = "0x647E130", VA = "0x18647F730")]
		public static DLDFCBMLNLG NLANEJOHIMD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x647F7F0", Offset = "0x647E1F0", VA = "0x18647F7F0")]
		public static DLDFCBMLNLG OEBLDGKBJON()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x647F8B0", Offset = "0x647E2B0", VA = "0x18647F8B0")]
		public static DLDFCBMLNLG PNIAIAIACCM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x647F490", Offset = "0x647DE90", VA = "0x18647F490")]
		public static DLDFCBMLNLG GHOMJAPENIP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x647F3D0", Offset = "0x647DDD0", VA = "0x18647F3D0")]
		public static DLDFCBMLNLG AFJDCAONGKM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x647F4F0", Offset = "0x647DEF0", VA = "0x18647F4F0")]
		public static DLDFCBMLNLG HAEDOAHEPAC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x647F670", Offset = "0x647E070", VA = "0x18647F670")]
		public static DLDFCBMLNLG MIBJPDBLDHG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x647F850", Offset = "0x647E250", VA = "0x18647F850")]
		public static DLDFCBMLNLG PICPCFEIOII()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class CBFLDAFCOII
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x647DCC0", Offset = "0x647C6C0", VA = "0x18647DCC0")]
		public static DLDFCBMLNLG KOFPOEPKFII(long NPGHGEFGHLA, long OKPAMGANILI, bool ILCMJEFDGNM, string ECGJAAMBNMC, string IFMJFLLHBAL)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class OJNKFJNMNNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6483E50", Offset = "0x6482850", VA = "0x186483E50")]
		public static DLDFCBMLNLG DPPDJHFMDPL(string KHGOGACJPCF, string FJDHBMCMEFP, bool HEACMFJKLMG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6483FC0", Offset = "0x64829C0", VA = "0x186483FC0")]
		public static DLDFCBMLNLG MMIDPHGCALE(string KMDNOIPDFGB, string PILGIPMNJDO, string PLHFCDNOIEA, [Optional] int? DNBBFIONKBB, [Optional] double[] HOFCLDFJAKG)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class APDGHFOCNPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x647C450", Offset = "0x647AE50", VA = "0x18647C450")]
		public static DLDFCBMLNLG FGEDGNDIKNL(string KOJNDJBEBAL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x647C590", Offset = "0x647AF90", VA = "0x18647C590")]
		public static DLDFCBMLNLG HDDDJKIMMJD(string EMFHHGHMEPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x647C030", Offset = "0x647AA30", VA = "0x18647C030")]
		public static DLDFCBMLNLG DPEGLMEBANM(int KGOMJEMDBBE, string JHJFHDOAMLG, string CMEADPACGME)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x647C670", Offset = "0x647B070", VA = "0x18647C670")]
		public static DLDFCBMLNLG NGCMJDBLBHC(int KGOMJEMDBBE, string JHJFHDOAMLG, string CMEADPACGME)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x647BFD0", Offset = "0x647A9D0", VA = "0x18647BFD0")]
		public static DLDFCBMLNLG ALCPMKCJMPI(int KGOMJEMDBBE, string JHJFHDOAMLG, string CMEADPACGME)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x647C530", Offset = "0x647AF30", VA = "0x18647C530")]
		public static DLDFCBMLNLG FMEAHILKIKK(int KGOMJEMDBBE, string JHJFHDOAMLG, string CMEADPACGME)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x647C300", Offset = "0x647AD00", VA = "0x18647C300")]
		public static DLDFCBMLNLG FDALNKHJHKK(string JHJFHDOAMLG, string CMEADPACGME)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x647C090", Offset = "0x647AA90", VA = "0x18647C090")]
		private static DLDFCBMLNLG EMAMBEKMMMB(string FIGCNDNKPBL, int KGOMJEMDBBE, string NEEHJADHOFP, string IECICGPFGHO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x647C1D0", Offset = "0x647ABD0", VA = "0x18647C1D0")]
		private static DLDFCBMLNLG EMAMBEKMMMB(string FIGCNDNKPBL, string NEEHJADHOFP, string IECICGPFGHO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly KLEHBGEJMBN PMAPEFGPDFK;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static PKCJNCMMMAN ANHDMKEMIFI;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static GDJPPADHBHH NBNGLCKMMHF;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static Queue<DLDFCBMLNLG> FJFLNCJONIE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private static long ALNJPDABEHL
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x64841F0", Offset = "0x6482BF0", VA = "0x1864841F0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x64844D0", Offset = "0x6482ED0", VA = "0x1864844D0")]
	[DJHNLGFKBFK.PIFNMABAPCA]
	internal static void HDEMNDJCOBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6484410", Offset = "0x6482E10", VA = "0x186484410")]
	private static void GCHKJEOLKFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x64842E0", Offset = "0x6482CE0", VA = "0x1864842E0")]
	public static DLDFCBMLNLG EANBDONFAHA(string IHHMGJOBHNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6484360", Offset = "0x6482D60", VA = "0x186484360")]
	public static DLDFCBMLNLG EANBDONFAHA(string IHHMGJOBHNC, int KGOMJEMDBBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x64845C0", Offset = "0x6482FC0", VA = "0x1864845C0")]
	[DJHNLGFKBFK.PIFNMABAPCA]
	internal static void JDNBHKIAMAC()
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

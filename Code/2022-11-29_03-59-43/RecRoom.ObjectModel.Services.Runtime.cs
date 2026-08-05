using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mono.Math;
using RecRoom.ObjectModel.Service.Internal;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface GBHMBPPBAGM<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface KGABHKADGEM
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LBEJDBOEOKN();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface OHFJHEDBJHF
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface HMFGCABFMPC
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OJPFNPOJAIL(PGEEJALGCGE HFDOFHJBJGD);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface HJAMGBPCPIB
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HMCIHMGHIKF(PGEEJALGCGE HFDOFHJBJGD);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface PFBMKGBLLGM : KGABHKADGEM, OHFJHEDBJHF, HMFGCABFMPC
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface OIAIMMLKKAN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	AHPBGKKBONO FBGBCINBOBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LHCOLCBEPCK(PGEEJALGCGE HFDOFHJBJGD);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface BFHAHCPNLAO
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PGNCABCBGBJ(PGEEJALGCGE HFDOFHJBJGD);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[DefaultMember("Item")]
[GGOLPMFKOCH(JIJBLGHADKE.Application)]
public interface FEGPLAEFMOI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	PGEEJALGCGE OPKHBNOGHCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	JIJBLGHADKE EDEPCNJJKBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	PGEEJALGCGE ILMFBMIBCLI
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ELGBPIMHCCH(Type PDMKGMPDDLH, object EBNNPKINFJN);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool NKDBGPNCFBD(Type PDMKGMPDDLH, global::JOCAMGODHEJ<object> DENGEJMDIND);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool NKDBGPNCFBD(Type PDMKGMPDDLH, global::JOCAMGODHEJ<object> DENGEJMDIND, JIJBLGHADKE CJLOHKHKFCM);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KEAEHBAHBFH();

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BBAOCFDPFCC();
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class CCMLAHDINKC
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x229C240", Offset = "0x229AE40", VA = "0x18229C240")]
	public static void HMFHOBMDMGG<T>(this FEGPLAEFMOI HFDOFHJBJGD, out T EBNNPKINFJN) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x229C1D0", Offset = "0x229ADD0", VA = "0x18229C1D0")]
	public static T HMFHOBMDMGG<T>(this FEGPLAEFMOI HFDOFHJBJGD) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6032190", Offset = "0x6030D90", VA = "0x186032190")]
	public static void KEAEHBAHBFH(this FEGPLAEFMOI HFDOFHJBJGD, JIJBLGHADKE CJLOHKHKFCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6031DE0", Offset = "0x60309E0", VA = "0x186031DE0")]
	public static void BBAOCFDPFCC(this FEGPLAEFMOI HFDOFHJBJGD, JIJBLGHADKE CJLOHKHKFCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6031F30", Offset = "0x6030B30", VA = "0x186031F30")]
	public static void KBCNNKGLEJB(this FEGPLAEFMOI HFDOFHJBJGD, JIJBLGHADKE PDOKCFJGNBM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface HCPNALJKDNH
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GIGGJMBFKKD(Type BIEGICDMJCM, out object EBNNPKINFJN);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class HHHKPPEKNJN
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface PGEEJALGCGE : HCPNALJKDNH
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	HGCFMABKDDJ FEFJCNCBGDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	AHPBGKKBONO PFCLGBDPMMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	JIJBLGHADKE EDEPCNJJKBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "3")]
	object HMFHOBMDMGG(Type BIEGICDMJCM);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class CFNFDIJGCOO
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x229F820", Offset = "0x229E420", VA = "0x18229F820")]
	public static bool GIGGJMBFKKD<T>(this PGEEJALGCGE HFDOFHJBJGD, out T EBNNPKINFJN) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x229F9E0", Offset = "0x229E5E0", VA = "0x18229F9E0")]
	public static T HMFHOBMDMGG<T>(this PGEEJALGCGE HFDOFHJBJGD) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x229FB30", Offset = "0x229E730", VA = "0x18229FB30")]
	public static void HMFHOBMDMGG<T>(this PGEEJALGCGE HFDOFHJBJGD, out T EBNNPKINFJN) where T : class
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[HFIGNCEGOKM(DDEOJCINOPG.Services)]
	internal class LifetimeScopedServices
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private readonly HGCFMABKDDJ FLBJMLJLEGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly ServiceInitOrder NFGHEDLNMKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly EDPNNJHHNMC OCKFADIHGEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly JIJBLGHADKE CJLOHKHKFCM;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public AHPBGKKBONO PFCLGBDPMMB
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6034340", Offset = "0x6032F40", VA = "0x186034340")]
			get
			{
				return default(AHPBGKKBONO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public HGCFMABKDDJ FEFJCNCBGDN
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x678AC0", Offset = "0x6776C0", VA = "0x180678AC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6034510", Offset = "0x6033110", VA = "0x186034510")]
		public LifetimeScopedServices(HGCFMABKDDJ FLBJMLJLEGK, JIJBLGHADKE CJLOHKHKFCM, PGEEJALGCGE NIAJDJNKIFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6033F10", Offset = "0x6032B10", VA = "0x186033F10")]
		public void ELGBPIMHCCH(Type BIEGICDMJCM, object EBNNPKINFJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x60342A0", Offset = "0x6032EA0", VA = "0x1860342A0")]
		public bool ILLNMMMGLHA(Type BIEGICDMJCM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x60340F0", Offset = "0x6032CF0", VA = "0x1860340F0")]
		public void FNJOFAEFPIL(HCPNALJKDNH MOPBAELKKDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6034360", Offset = "0x6032F60", VA = "0x186034360")]
		public void PGNCABCBGBJ(PGEEJALGCGE KFIFCJABAFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6033DD0", Offset = "0x60329D0", VA = "0x186033DD0")]
		public void CGILPHFOCHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6034450", Offset = "0x6033050", VA = "0x186034450", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6034250", Offset = "0x6032E50", VA = "0x186034250")]
		private static void FNLOOGNMMLM(Type PDMKGMPDDLH, object EBNNPKINFJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x60342D0", Offset = "0x6032ED0", VA = "0x1860342D0")]
		private void JJJIFHPBOGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6033E30", Offset = "0x6032A30", VA = "0x186033E30")]
		private void ELEKNNHJKPM(Type BIEGICDMJCM)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public delegate T JOCAMGODHEJ<out T>();
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[HFIGNCEGOKM(DDEOJCINOPG.Services)]
	[DefaultMember("Item")]
	public class Services : FEGPLAEFMOI, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		private class KALBFBBNJGN : PGEEJALGCGE, HCPNALJKDNH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			private readonly Services HFDOFHJBJGD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			private readonly JIJBLGHADKE CJLOHKHKFCM;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			private LifetimeScopedServices NJJHLCFOCPD
			{
				[Cpp2IlInjected.Token(Token = "0x6000045")]
				[Cpp2IlInjected.Address(RVA = "0x6033880", Offset = "0x6032480", VA = "0x186033880")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public HGCFMABKDDJ FEFJCNCBGDN
			{
				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x6033B00", Offset = "0x6032700", VA = "0x186033B00", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public AHPBGKKBONO PFCLGBDPMMB
			{
				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x6033B50", Offset = "0x6032750", VA = "0x186033B50", Slot = "5")]
				get
				{
					return default(AHPBGKKBONO);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public JIJBLGHADKE EDEPCNJJKBB
			{
				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x678BD0", Offset = "0x6777D0", VA = "0x180678BD0", Slot = "6")]
				get
				{
					return default(JIJBLGHADKE);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x727920", Offset = "0x726520", VA = "0x180727920")]
			public KALBFBBNJGN(Services HFDOFHJBJGD, JIJBLGHADKE CJLOHKHKFCM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x60338C0", Offset = "0x60324C0", VA = "0x1860338C0", Slot = "8")]
			public bool GIGGJMBFKKD(Type BIEGICDMJCM, out object EBNNPKINFJN)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6033920", Offset = "0x6032520", VA = "0x186033920", Slot = "7")]
			public object HMFHOBMDMGG(Type BIEGICDMJCM)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly LifetimeScopedServices[] HNMFCPCHFMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly KALBFBBNJGN[] NIAJDJNKIFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private JIJBLGHADKE CJLOHKHKFCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private bool IBOHJGMEBIO;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private PGEEJALGCGE JOJOHMIEMMM
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6036D30", Offset = "0x6035930", VA = "0x186036D30", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public JIJBLGHADKE EDEPCNJJKBB
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x677010", Offset = "0x675C10", VA = "0x180677010", Slot = "5")]
			get
			{
				return default(JIJBLGHADKE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public PGEEJALGCGE OPKHBNOGHCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8D7880", Offset = "0x8D6480", VA = "0x1808D7880", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private LifetimeScopedServices ILMFBMIBCLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xB549A0", Offset = "0xB535A0", VA = "0x180B549A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private LifetimeScopedServices DFJPBHDEHBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x6036A80", Offset = "0x6035680", VA = "0x186036A80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6036960", Offset = "0x6035560", VA = "0x186036960")]
		public static FEGPLAEFMOI GLBIKEOEKPG([Optional] HGCFMABKDDJ FLBJMLJLEGK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6036870", Offset = "0x6035470", VA = "0x186036870")]
		public static FEGPLAEFMOI GGCMILIMJPP(HGCFMABKDDJ FLBJMLJLEGK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x60371D0", Offset = "0x6035DD0", VA = "0x1860371D0")]
		private Services(HGCFMABKDDJ KMBIMBAGHIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6036780", Offset = "0x6035380", VA = "0x186036780", Slot = "7")]
		public void ELGBPIMHCCH(Type PDMKGMPDDLH, object EBNNPKINFJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6036820", Offset = "0x6035420", VA = "0x186036820", Slot = "13")]
		public void ELGBPIMHCCH(Type PDMKGMPDDLH, object EBNNPKINFJN, JIJBLGHADKE CJLOHKHKFCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6036D70", Offset = "0x6035970", VA = "0x186036D70", Slot = "8")]
		public bool NKDBGPNCFBD(Type PDMKGMPDDLH, global::JOCAMGODHEJ<object> DENGEJMDIND)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6036EC0", Offset = "0x6035AC0", VA = "0x186036EC0", Slot = "9")]
		public bool NKDBGPNCFBD(Type PDMKGMPDDLH, global::JOCAMGODHEJ<object> DENGEJMDIND, JIJBLGHADKE CJLOHKHKFCM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6036B40", Offset = "0x6035740", VA = "0x186036B40", Slot = "10")]
		public void KEAEHBAHBFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6036220", Offset = "0x6034E20", VA = "0x186036220", Slot = "11")]
		public void BBAOCFDPFCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6036470", Offset = "0x6035070", VA = "0x186036470", Slot = "12")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x60365B0", Offset = "0x60351B0", VA = "0x1860365B0")]
		private void EDNIGDIJGAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6036AC0", Offset = "0x60356C0", VA = "0x186036AC0")]
		private void KDFMIKPGOPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x60369E0", Offset = "0x60355E0", VA = "0x1860369E0")]
		private bool ILLNMMMGLHA(Type BIEGICDMJCM, JIJBLGHADKE CJLOHKHKFCM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x60362C0", Offset = "0x6034EC0", VA = "0x1860362C0")]
		private bool CADCAMIGNJH(Type BIEGICDMJCM, out JIJBLGHADKE CJLOHKHKFCM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6036FE0", Offset = "0x6035BE0", VA = "0x186036FE0")]
		private void PBKHHCKPEFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6036B70", Offset = "0x6035770", VA = "0x186036B70")]
		private static LifetimeScopedServices[] KEBPNLMCEKD(HGCFMABKDDJ KMBIMBAGHIN, KALBFBBNJGN[] JFCIKDNMODK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6036360", Offset = "0x6034F60", VA = "0x186036360")]
		private KALBFBBNJGN[] DAIEPFJHJDC()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[Flags]
public enum AHPBGKKBONO
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	InitInternal = 1,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	InitReferences = 2,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	InitExternal = 4,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	PostInit = 8,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Uninitialized = 0,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	Initialized = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	ScopeChange = 0x20,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	All = 0xF
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class CJNGHCFLKLO
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x60323B0", Offset = "0x6030FB0", VA = "0x1860323B0")]
	public static Exception MGCKBEHHIIP(Type PDMKGMPDDLH, JIJBLGHADKE CJLOHKHKFCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x60322E0", Offset = "0x6030EE0", VA = "0x1860322E0")]
	public static Exception BDMOBMNJOII(Type PDMKGMPDDLH, JIJBLGHADKE CJLOHKHKFCM, Type PLBHPMFFEBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6032440", Offset = "0x6031040", VA = "0x186032440")]
	public static Type NNHLNBJKJKG(int MIKMBHLHCCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6032370", Offset = "0x6030F70", VA = "0x186032370")]
	private static string KJACGDMIFGI(Type PDMKGMPDDLH, JIJBLGHADKE CJLOHKHKFCM, Type PLBHPMFFEBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6032370", Offset = "0x6030F70", VA = "0x186032370")]
	private static string DNGLFJNOFBH(Type BIEGICDMJCM)
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Service
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[HFIGNCEGOKM(DDEOJCINOPG.Services)]
	public abstract class ServiceRegisterer : OFPBJBCBPFJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public class AKMPOBKLHJD : ServiceRegisterer
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x344B820", Offset = "0x344A420", VA = "0x18344B820", Slot = "8")]
			public override bool EHMHLLLMBAF<TBind, TInstance, TBind>(string[] PLHBKKLFOOJ)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x6031CF0", Offset = "0x60308F0", VA = "0x186031CF0", Slot = "9")]
			public override bool EHMHLLLMBAF(Type PDMKGMPDDLH, Type JGOECPKCFLB, string[] PLHBKKLFOOJ)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public class DEBEGJGFMPK : ServiceRegisterer
		{
			[Cpp2IlInjected.Token(Token = "0x200001B")]
			[CompilerGenerated]
			private sealed class BFMGHBCKOMB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public Type instanceType;

				[Cpp2IlInjected.Token(Token = "0x6000061")]
				[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
				public BFMGHBCKOMB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000062")]
				[Cpp2IlInjected.Address(RVA = "0x6031DD0", Offset = "0x60309D0", VA = "0x186031DD0")]
				internal object <Register>b__0()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x6032700", Offset = "0x6031300", VA = "0x186032700")]
			public DEBEGJGFMPK(FEGPLAEFMOI HFDOFHJBJGD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x344C820", Offset = "0x344B420", VA = "0x18344C820", Slot = "8")]
			public override bool EHMHLLLMBAF<TBind, TInstance, TBind>(string[] PLHBKKLFOOJ)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x60325A0", Offset = "0x60311A0", VA = "0x1860325A0", Slot = "9")]
			public override bool EHMHLLLMBAF(Type PDMKGMPDDLH, Type JGOECPKCFLB, string[] PLHBKKLFOOJ)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class IEGBAKBNALK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public ServiceRegisterer <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public Type bindType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public JIJBLGHADKE lifetime;

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
			public IEGBAKBNALK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x6033710", Offset = "0x6032310", VA = "0x186033710")]
			internal object <AlsoBindAs>b__0()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly FEGPLAEFMOI HFDOFHJBJGD;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x677F40", Offset = "0x676B40", VA = "0x180677F40")]
		public ServiceRegisterer(FEGPLAEFMOI HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract bool EHMHLLLMBAF<TBind, TInstance, TBind>(string[] PLHBKKLFOOJ) where TBind : class where TInstance : TBind, new() where TBind : class;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract bool EHMHLLLMBAF(Type PDMKGMPDDLH, Type JGOECPKCFLB, string[] PLHBKKLFOOJ);

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x3A0F1F0", Offset = "0x3A0DDF0", VA = "0x183A0F1F0", Slot = "7")]
		public void MFDONBAABPC<TBind, TAlsoBindAs, TBind>() where TBind : class where TAlsoBindAs : class, TBind where TBind : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6035F40", Offset = "0x6034B40", VA = "0x186035F40", Slot = "5")]
		public void MFDONBAABPC(Type PDMKGMPDDLH, Type GJKBEBCKHME)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal static class FDKLLGNMAFH
{
}
namespace RecRoom.ObjectModel.Service.Internal
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[HFIGNCEGOKM(DDEOJCINOPG.Services)]
	internal class Disposables : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly List<IDisposable> EJJNKDENMMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private bool IBOHJGMEBIO;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6032900", Offset = "0x6031500", VA = "0x186032900")]
		public void NKDBGPNCFBD(object EHPFANFOFFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x60328E0", Offset = "0x60314E0", VA = "0x1860328E0")]
		public void GJPIAAEOJAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6032770", Offset = "0x6031370", VA = "0x186032770", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6032A20", Offset = "0x6031620", VA = "0x186032A20")]
		public Disposables()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal class EDPNNJHHNMC
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class LAKDHGHEAMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public PGEEJALGCGE newScope;

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public LAKDHGHEAMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6033D70", Offset = "0x6032970", VA = "0x186033D70")]
		internal void <ExecuteScopeChange>b__0(BFHAHCPNLAO svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class AINMNJKBJOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public AINMNJKBJOB()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly Dictionary<AHPBGKKBONO, List<object>> OCKFADIHGEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly AHPBGKKBONO[] OBIPACNIFGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly PGEEJALGCGE HFDOFHJBJGD;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public AHPBGKKBONO PFCLGBDPMMB
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6991B0", Offset = "0x697DB0", VA = "0x1806991B0")]
		[CompilerGenerated]
		get
		{
			return default(AHPBGKKBONO);
		}
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x82CDE0", Offset = "0x82B9E0", VA = "0x18082CDE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6033630", Offset = "0x6032230", VA = "0x186033630")]
	public EDPNNJHHNMC(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x60330A0", Offset = "0x6031CA0", VA = "0x1860330A0")]
	public void OEFLKCBFDDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6032DC0", Offset = "0x60319C0", VA = "0x186032DC0")]
	public void IJFJMGAKBAB(PGEEJALGCGE KFIFCJABAFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6032BC0", Offset = "0x60317C0", VA = "0x186032BC0")]
	internal void GJPIAAEOJAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6033470", Offset = "0x6032070", VA = "0x186033470")]
	public bool PALIPDCOHIN(object EHPFANFOFFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x1AC1AE0", Offset = "0x1AC06E0", VA = "0x181AC1AE0")]
	private void KPNLPBPIFNE<T>(Action<T> OFCBPHMKBKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x1AC1B10", Offset = "0x1AC0710", VA = "0x181AC1B10")]
	private void KPNLPBPIFNE<T>(Action<T> OFCBPHMKBKO, AHPBGKKBONO FGMCPHKBIAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x1AC1CE0", Offset = "0x1AC08E0", VA = "0x181AC1CE0")]
	private static bool PCLGMJGFHKN<T>(object MMBOEGCIFOD, Action<T> OFCBPHMKBKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1AC1A10", Offset = "0x1AC0610", VA = "0x181AC1A10")]
	private bool HNKMKJLMOJL<T>(AHPBGKKBONO FGMCPHKBIAK, object CHBJLDALBNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6032EB0", Offset = "0x6031AB0", VA = "0x186032EB0")]
	private void KEOMBBAFMDH(AHPBGKKBONO FGMCPHKBIAK, object EHPFANFOFFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6032D60", Offset = "0x6031960", VA = "0x186032D60")]
	[CompilerGenerated]
	private void HJDMNBBHAEN(OIAIMMLKKAN MMBOEGCIFOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6033040", Offset = "0x6031C40", VA = "0x186033040")]
	[CompilerGenerated]
	private void LDFDHKBMGFC(OIAIMMLKKAN MMBOEGCIFOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6032B00", Offset = "0x6031700", VA = "0x186032B00")]
	[CompilerGenerated]
	private void DIIOICKKFLM(OHFJHEDBJHF MMBOEGCIFOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6032D00", Offset = "0x6031900", VA = "0x186032D00")]
	[CompilerGenerated]
	private void HIPIFJDEKAG(OIAIMMLKKAN MMBOEGCIFOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6032AA0", Offset = "0x60316A0", VA = "0x186032AA0")]
	[CompilerGenerated]
	private void COAJBMAAKLG(HMFGCABFMPC MMBOEGCIFOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6032B60", Offset = "0x6031760", VA = "0x186032B60")]
	[CompilerGenerated]
	private void GDNOMHMGEJA(OIAIMMLKKAN MMBOEGCIFOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6032FE0", Offset = "0x6031BE0", VA = "0x186032FE0")]
	[CompilerGenerated]
	private void KNDIPMJGCDF(HJAMGBPCPIB MMBOEGCIFOD)
	{
	}
}
namespace RecRoom.ObjectModel.Service.Internal
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[HFIGNCEGOKM(DDEOJCINOPG.Services)]
	internal class ServiceInitOrder : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly OLJCAOOFNGB AFMGDGHLMGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly Dictionary<Type, object> FNHIAANOAMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly HashSet<object> HDILJPDKKBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly Disposables EJJNKDENMMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly JIJBLGHADKE CJLOHKHKFCM;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6035DA0", Offset = "0x60349A0", VA = "0x186035DA0")]
		public ServiceInitOrder(JIJBLGHADKE CJLOHKHKFCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6034D00", Offset = "0x6033900", VA = "0x186034D00", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6034D20", Offset = "0x6033920", VA = "0x186034D20")]
		public void ELGBPIMHCCH(Type PDMKGMPDDLH, object EBNNPKINFJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6035320", Offset = "0x6033F20", VA = "0x186035320")]
		private void IGOMKAIDFPG(Type PDMKGMPDDLH, Type JGOECPKCFLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6034940", Offset = "0x6033540", VA = "0x186034940")]
		private void BJFAJGEDMDB(Type PDMKGMPDDLH, Type JGOECPKCFLB, Type ILKOPJOIBCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6034C30", Offset = "0x6033830", VA = "0x186034C30")]
		public void CGGFGDCMCBJ(EDPNNJHHNMC OCKFADIHGEI, HCPNALJKDNH FCBECALILNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6034AB0", Offset = "0x60336B0", VA = "0x186034AB0")]
		private void CCNBPACODID(EDPNNJHHNMC OCKFADIHGEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6034DB0", Offset = "0x60339B0", VA = "0x186034DB0")]
		private void HGMBDMILJOM(EDPNNJHHNMC OCKFADIHGEI, HCPNALJKDNH FCBECALILNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x60347F0", Offset = "0x60333F0", VA = "0x1860347F0")]
		private IEnumerable<Type> AIIPANDFJDI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6035640", Offset = "0x6034240", VA = "0x186035640")]
		private static bool MIDNMGFPBDO(Type DAGFPDADJPL, Type ILKOPJOIBCC, out JIJBLGHADKE CJLOHKHKFCM, out string OMKDGOMBDIM)
		{
			return default(bool);
		}
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.Services.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[Preserve]
	internal class _RRAssemblyIndex : OJPIMOLMMLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677740", VA = "0x180678B40")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6037720", Offset = "0x6036320", VA = "0x186037720", Slot = "4")]
		public sealed override void LHIOLPAIHGM()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class KEJBIFLOMJJ
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static byte[] POAMPPAGKIJ;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static int DNBFJGDJLJG;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static int JPELDCGMMIM;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static BigInteger LIKOKONEDPL;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public KEJBIFLOMJJ()
	{
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
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

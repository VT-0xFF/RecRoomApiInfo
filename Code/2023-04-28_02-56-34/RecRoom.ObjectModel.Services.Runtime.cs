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
public interface PEBAANKICOC<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface BJDLFHICAGD
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DHCINKEHHEL();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface GBCNOEIKEOL
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface IJGJDJPFIAJ
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LOIIDKBBIDB(FJEOEPCCLME JGMMDACFJLC);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface AGPEIHBOPOK
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KOKHAJKKANK(FJEOEPCCLME JGMMDACFJLC);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface HBEOAMPLBKH : BJDLFHICAGD, GBCNOEIKEOL, IJGJDJPFIAJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface EADCECODNBJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	HNJBILHOIMC DMGKCMGPDOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AHPFPMIFNAG(FJEOEPCCLME JGMMDACFJLC);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface OFGHLKBBKBB
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CCCAANGKKJB(FJEOEPCCLME JGMMDACFJLC);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[DefaultMember("Item")]
[DCBDIJCKLAD(IKIGKMLBEFF.Application)]
public interface HJOJGGNKDFB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	FJEOEPCCLME JNKMHBEEDBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	IKIGKMLBEFF GJHFEOADJCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	FJEOEPCCLME CJPGBGNJAAG
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AGMLDLCGDGN(Type EKGNJFKLBCB, object LHDJJEMNOIF);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool MGFMFMIIKAH(Type EKGNJFKLBCB, global::JNKLLGHJKLM<object> OHBNFBFIMDH);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool MGFMFMIIKAH(Type EKGNJFKLBCB, global::JNKLLGHJKLM<object> OHBNFBFIMDH, IKIGKMLBEFF MJMOJANEIJI);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BFOBHHOJHHG();

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LJMPMFMCLKG();
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class JDOFFDEGFMF
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1994370", Offset = "0x1992D70", VA = "0x181994370")]
	public static void MKLBNKEKMJE<T>(this HJOJGGNKDFB JGMMDACFJLC, out T LHDJJEMNOIF) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1994300", Offset = "0x1992D00", VA = "0x181994300")]
	public static T MKLBNKEKMJE<T>(this HJOJGGNKDFB JGMMDACFJLC) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x69A2640", Offset = "0x69A1040", VA = "0x1869A2640")]
	public static void BFOBHHOJHHG(this HJOJGGNKDFB JGMMDACFJLC, IKIGKMLBEFF MJMOJANEIJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x69A29F0", Offset = "0x69A13F0", VA = "0x1869A29F0")]
	public static void LJMPMFMCLKG(this HJOJGGNKDFB JGMMDACFJLC, IKIGKMLBEFF MJMOJANEIJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x69A2790", Offset = "0x69A1190", VA = "0x1869A2790")]
	public static void KJEFOLGJBEC(this HJOJGGNKDFB JGMMDACFJLC, IKIGKMLBEFF PBFAMNOLEAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface LENFBMHDJIO
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OBCGBBDEENH(Type OGILDIMGIOH, out object LHDJJEMNOIF);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class IMPJHIPDCFE
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface FJEOEPCCLME : LENFBMHDJIO
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	AOONKACGDKK LCNJLEALFLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	HNJBILHOIMC ADJHONNAHAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	IKIGKMLBEFF GJHFEOADJCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "3")]
	object MKLBNKEKMJE(Type OGILDIMGIOH);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class OCLEKEMFMKD
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x328BA50", Offset = "0x328A450", VA = "0x18328BA50")]
	public static bool OBCGBBDEENH<T>(this FJEOEPCCLME JGMMDACFJLC, out T LHDJJEMNOIF) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x328B8D0", Offset = "0x328A2D0", VA = "0x18328B8D0")]
	public static T MKLBNKEKMJE<T>(this FJEOEPCCLME JGMMDACFJLC) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x328BA20", Offset = "0x328A420", VA = "0x18328BA20")]
	public static void MKLBNKEKMJE<T>(this FJEOEPCCLME JGMMDACFJLC, out T LHDJJEMNOIF) where T : class
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[JEGJCCBDMOE(OLCAJGBKOGB.Services)]
	internal class LifetimeScopedServices
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private readonly AOONKACGDKK ONILLNPEPMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly ServiceInitOrder DHINIDOKHGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly IKCBIOLBAAI PALLPPNHLGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly IKIGKMLBEFF MJMOJANEIJI;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public HNJBILHOIMC ADJHONNAHAK
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x69A3330", Offset = "0x69A1D30", VA = "0x1869A3330")]
			get
			{
				return default(HNJBILHOIMC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public AOONKACGDKK LCNJLEALFLE
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x727010", Offset = "0x725A10", VA = "0x180727010")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x69A35C0", Offset = "0x69A1FC0", VA = "0x1869A35C0")]
		public LifetimeScopedServices(AOONKACGDKK ONILLNPEPMK, IKIGKMLBEFF MJMOJANEIJI, FJEOEPCCLME CGBBBNOGJNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x69A2E80", Offset = "0x69A1880", VA = "0x1869A2E80")]
		public void AGMLDLCGDGN(Type OGILDIMGIOH, object LHDJJEMNOIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x69A3300", Offset = "0x69A1D00", VA = "0x1869A3300")]
		public bool HPHMOMKKMCJ(Type OGILDIMGIOH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x69A3350", Offset = "0x69A1D50", VA = "0x1869A3350")]
		public void KADCCJJCHBP(LENFBMHDJIO AIEPMNGCMKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x69A3060", Offset = "0x69A1A60", VA = "0x1869A3060")]
		public void CCCAANGKKJB(FJEOEPCCLME EFNJKPDMBHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x69A3150", Offset = "0x69A1B50", VA = "0x1869A3150")]
		public void CKAJENPILHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x69A3500", Offset = "0x69A1F00", VA = "0x1869A3500", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x69A34B0", Offset = "0x69A1EB0", VA = "0x1869A34B0")]
		private static void NAKGBHBGCPG(Type EKGNJFKLBCB, object LHDJJEMNOIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x69A31B0", Offset = "0x69A1BB0", VA = "0x1869A31B0")]
		private void DEDABKMJFAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x69A3220", Offset = "0x69A1C20", VA = "0x1869A3220")]
		private void HCLKMIDGCJH(Type OGILDIMGIOH)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public delegate T JNKLLGHJKLM<out T>();
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[JEGJCCBDMOE(OLCAJGBKOGB.Services)]
	[DefaultMember("Item")]
	public class Services : HJOJGGNKDFB, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		private class CPPEABBCEJH : FJEOEPCCLME, LENFBMHDJIO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			private readonly Services JGMMDACFJLC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			private readonly IKIGKMLBEFF MJMOJANEIJI;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			private LifetimeScopedServices CIJDLCNILKP
			{
				[Cpp2IlInjected.Token(Token = "0x6000045")]
				[Cpp2IlInjected.Address(RVA = "0x69A0E00", Offset = "0x699F800", VA = "0x1869A0E00")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public AOONKACGDKK LCNJLEALFLE
			{
				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x69A0E90", Offset = "0x699F890", VA = "0x1869A0E90", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public HNJBILHOIMC ADJHONNAHAK
			{
				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x69A0E40", Offset = "0x699F840", VA = "0x1869A0E40", Slot = "5")]
				get
				{
					return default(HNJBILHOIMC);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public IKIGKMLBEFF GJHFEOADJCJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x77AFB0", Offset = "0x7799B0", VA = "0x18077AFB0", Slot = "6")]
				get
				{
					return default(IKIGKMLBEFF);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x7C15C0", Offset = "0x7BFFC0", VA = "0x1807C15C0")]
			public CPPEABBCEJH(Services JGMMDACFJLC, IKIGKMLBEFF MJMOJANEIJI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x69A10C0", Offset = "0x699FAC0", VA = "0x1869A10C0", Slot = "8")]
			public bool OBCGBBDEENH(Type OGILDIMGIOH, out object LHDJJEMNOIF)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x69A0EE0", Offset = "0x699F8E0", VA = "0x1869A0EE0", Slot = "7")]
			public object MKLBNKEKMJE(Type OGILDIMGIOH)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly LifetimeScopedServices[] MJNNPMHAPBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly CPPEABBCEJH[] CGBBBNOGJNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private IKIGKMLBEFF MJMOJANEIJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private bool FCPODLMHINC;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private FJEOEPCCLME NMMMGHIFAMK
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x69A6260", Offset = "0x69A4C60", VA = "0x1869A6260", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public IKIGKMLBEFF GJHFEOADJCJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x731750", Offset = "0x730150", VA = "0x180731750", Slot = "5")]
			get
			{
				return default(IKIGKMLBEFF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public FJEOEPCCLME JNKMHBEEDBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8C89D0", Offset = "0x8C73D0", VA = "0x1808C89D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private LifetimeScopedServices CJPGBGNJAAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xAEACE0", Offset = "0xAE96E0", VA = "0x180AEACE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private LifetimeScopedServices FADDPBPEOIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x69A5520", Offset = "0x69A3F20", VA = "0x1869A5520")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x69A5AE0", Offset = "0x69A44E0", VA = "0x1869A5AE0")]
		public static HJOJGGNKDFB IDIKGABNBEI([Optional] AOONKACGDKK ONILLNPEPMK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x69A5340", Offset = "0x69A3D40", VA = "0x1869A5340")]
		public static HJOJGGNKDFB AAOGPKMHOFB(AOONKACGDKK ONILLNPEPMK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x69A62F0", Offset = "0x69A4CF0", VA = "0x1869A62F0")]
		private Services(AOONKACGDKK AIOLFLHDLAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x69A5430", Offset = "0x69A3E30", VA = "0x1869A5430", Slot = "7")]
		public void AGMLDLCGDGN(Type EKGNJFKLBCB, object LHDJJEMNOIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x69A54D0", Offset = "0x69A3ED0", VA = "0x1869A54D0", Slot = "13")]
		public void AGMLDLCGDGN(Type EKGNJFKLBCB, object LHDJJEMNOIF, IKIGKMLBEFF MJMOJANEIJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x69A5F40", Offset = "0x69A4940", VA = "0x1869A5F40", Slot = "8")]
		public bool MGFMFMIIKAH(Type EKGNJFKLBCB, global::JNKLLGHJKLM<object> OHBNFBFIMDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x69A5E20", Offset = "0x69A4820", VA = "0x1869A5E20", Slot = "9")]
		public bool MGFMFMIIKAH(Type EKGNJFKLBCB, global::JNKLLGHJKLM<object> OHBNFBFIMDH, IKIGKMLBEFF MJMOJANEIJI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x69A5560", Offset = "0x69A3F60", VA = "0x1869A5560", Slot = "10")]
		public void BFOBHHOJHHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x69A5D80", Offset = "0x69A4780", VA = "0x1869A5D80", Slot = "11")]
		public void LJMPMFMCLKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x69A5750", Offset = "0x69A4150", VA = "0x1869A5750", Slot = "12")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x69A6090", Offset = "0x69A4A90", VA = "0x1869A6090")]
		private void OLDFODGLHEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x69A5B60", Offset = "0x69A4560", VA = "0x1869A5B60")]
		private void KCHGEMKGLOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x69A5A40", Offset = "0x69A4440", VA = "0x1869A5A40")]
		private bool HPHMOMKKMCJ(Type OGILDIMGIOH, IKIGKMLBEFF MJMOJANEIJI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x69A59A0", Offset = "0x69A43A0", VA = "0x1869A59A0")]
		private bool FNKGFCEEPHF(Type OGILDIMGIOH, out IKIGKMLBEFF MJMOJANEIJI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x69A5BE0", Offset = "0x69A45E0", VA = "0x1869A5BE0")]
		private void KGEMNHPDOIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x69A5590", Offset = "0x69A3F90", VA = "0x1869A5590")]
		private static LifetimeScopedServices[] DMFIAFBNPBN(AOONKACGDKK AIOLFLHDLAL, CPPEABBCEJH[] FBNJNNBBLIM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x69A5890", Offset = "0x69A4290", VA = "0x1869A5890")]
		private CPPEABBCEJH[] FEEDMHBEJJP()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[Flags]
public enum HNJBILHOIMC
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
public static class HHNABCPPGAP
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x69A1730", Offset = "0x69A0130", VA = "0x1869A1730")]
	public static Exception HBGMHHOJJCD(Type EKGNJFKLBCB, IKIGKMLBEFF MJMOJANEIJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x69A16A0", Offset = "0x69A00A0", VA = "0x1869A16A0")]
	public static Exception HAGOGKACDKD(Type EKGNJFKLBCB, IKIGKMLBEFF MJMOJANEIJI, Type FNKEAGOGFBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x69A1540", Offset = "0x699FF40", VA = "0x1869A1540")]
	public static Type GNFKIBHKJLP(int JCEAJPNOAJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x69A17C0", Offset = "0x69A01C0", VA = "0x1869A17C0")]
	private static string NCDMGFCLNOF(Type EKGNJFKLBCB, IKIGKMLBEFF MJMOJANEIJI, Type FNKEAGOGFBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x69A17C0", Offset = "0x69A01C0", VA = "0x1869A17C0")]
	private static string IAGHABFCPLM(Type OGILDIMGIOH)
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Service
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[JEGJCCBDMOE(OLCAJGBKOGB.Services)]
	public abstract class ServiceRegisterer : CKMMIMLGKKB
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public class HDEOMFOBJOB : ServiceRegisterer
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x2E77560", Offset = "0x2E75F60", VA = "0x182E77560", Slot = "8")]
			public override bool EHOMCGHPBHE<TBind, TInstance, TBind>(string[] AFFPJFFGLAI)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x69A1460", Offset = "0x699FE60", VA = "0x1869A1460", Slot = "9")]
			public override bool EHOMCGHPBHE(Type EKGNJFKLBCB, Type HELDLMEDGHK, string[] AFFPJFFGLAI)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public class IHGODLHIFEO : ServiceRegisterer
		{
			[Cpp2IlInjected.Token(Token = "0x200001B")]
			[CompilerGenerated]
			private sealed class PAIGJNENBDM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public Type instanceType;

				[Cpp2IlInjected.Token(Token = "0x6000061")]
				[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
				public PAIGJNENBDM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000062")]
				[Cpp2IlInjected.Address(RVA = "0x69A38A0", Offset = "0x69A22A0", VA = "0x1869A38A0")]
				internal object <Register>b__0()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x69A1960", Offset = "0x69A0360", VA = "0x1869A1960")]
			public IHGODLHIFEO(HJOJGGNKDFB JGMMDACFJLC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x2E77680", Offset = "0x2E76080", VA = "0x182E77680", Slot = "8")]
			public override bool EHOMCGHPBHE<TBind, TInstance, TBind>(string[] AFFPJFFGLAI)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x69A1800", Offset = "0x69A0200", VA = "0x1869A1800", Slot = "9")]
			public override bool EHOMCGHPBHE(Type EKGNJFKLBCB, Type HELDLMEDGHK, string[] AFFPJFFGLAI)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class LCCJDKKJBFE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public ServiceRegisterer <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public Type bindType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public IKIGKMLBEFF lifetime;

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
			public LCCJDKKJBFE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x69A2D10", Offset = "0x69A1710", VA = "0x1869A2D10")]
			internal object <AlsoBindAs>b__0()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly HJOJGGNKDFB JGMMDACFJLC;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x74A940", Offset = "0x749340", VA = "0x18074A940")]
		public ServiceRegisterer(HJOJGGNKDFB JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract bool EHOMCGHPBHE<TBind, TInstance, TBind>(string[] AFFPJFFGLAI) where TBind : class where TInstance : TBind, new() where TBind : class;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract bool EHOMCGHPBHE(Type EKGNJFKLBCB, Type HELDLMEDGHK, string[] AFFPJFFGLAI);

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x4ADD1A0", Offset = "0x4ADBBA0", VA = "0x184ADD1A0", Slot = "7")]
		public void IFCCFBALMNM<TBind, TAlsoBindAs, TBind>() where TBind : class where TAlsoBindAs : class, TBind where TBind : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x69A5060", Offset = "0x69A3A60", VA = "0x1869A5060", Slot = "5")]
		public void IFCCFBALMNM(Type EKGNJFKLBCB, Type PMJEDMJBFNM)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal static class FMFCNHHCJFM
{
}
namespace RecRoom.ObjectModel.Service.Internal
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[JEGJCCBDMOE(OLCAJGBKOGB.Services)]
	internal class Disposables : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly List<IDisposable> HJMKNPMFOOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private bool FCPODLMHINC;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x69A12C0", Offset = "0x699FCC0", VA = "0x1869A12C0")]
		public void MGFMFMIIKAH(object ELODBNLDLIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x69A1120", Offset = "0x699FB20", VA = "0x1869A1120")]
		public void BONIBAPHNIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x69A1140", Offset = "0x699FB40", VA = "0x1869A1140", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x69A13E0", Offset = "0x699FDE0", VA = "0x1869A13E0")]
		public Disposables()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal class IKCBIOLBAAI
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class PKAGBJPNGJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public FJEOEPCCLME newScope;

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public PKAGBJPNGJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x69A38B0", Offset = "0x69A22B0", VA = "0x1869A38B0")]
		internal void <ExecuteScopeChange>b__0(OFGHLKBBKBB svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class MOLBLJHIKJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public MOLBLJHIKJP()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly Dictionary<HNJBILHOIMC, List<object>> PALLPPNHLGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly HNJBILHOIMC[] FIPOFINIHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly FJEOEPCCLME JGMMDACFJLC;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public HNJBILHOIMC ADJHONNAHAK
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x732B90", Offset = "0x731590", VA = "0x180732B90")]
		[CompilerGenerated]
		get
		{
			return default(HNJBILHOIMC);
		}
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x998CF0", Offset = "0x9976F0", VA = "0x180998CF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x69A2560", Offset = "0x69A0F60", VA = "0x1869A2560")]
	public IKCBIOLBAAI(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x69A1EE0", Offset = "0x69A08E0", VA = "0x1869A1EE0")]
	public void MHGNBBHJEKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x69A2470", Offset = "0x69A0E70", VA = "0x1869A2470")]
	public void OMPDIJDCJBL(FJEOEPCCLME EFNJKPDMBHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x69A1A30", Offset = "0x69A0430", VA = "0x1869A1A30")]
	internal void BONIBAPHNIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x69A22B0", Offset = "0x69A0CB0", VA = "0x1869A22B0")]
	public bool MOOPFBMKCFG(object ELODBNLDLIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x2835E70", Offset = "0x2834870", VA = "0x182835E70")]
	private void DMKDDACKFDC<T>(Action<T> MOJNBGAOCCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2835EA0", Offset = "0x28348A0", VA = "0x182835EA0")]
	private void DMKDDACKFDC<T>(Action<T> MOJNBGAOCCB, HNJBILHOIMC HJGAFKLFBEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2836070", Offset = "0x2834A70", VA = "0x182836070")]
	private static bool HGGNCJJLKBD<T>(object BKMJIJNEKAE, Action<T> MOJNBGAOCCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2836190", Offset = "0x2834B90", VA = "0x182836190")]
	private bool PPODGOJJGAM<T>(HNJBILHOIMC HJGAFKLFBEI, object IOMDCEAIKDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x69A1DB0", Offset = "0x69A07B0", VA = "0x1869A1DB0")]
	private void KDAFDNJEJHE(HNJBILHOIMC HJGAFKLFBEI, object ELODBNLDLIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x69A1CF0", Offset = "0x69A06F0", VA = "0x1869A1CF0")]
	[CompilerGenerated]
	private void HGGNAFAFHPH(EADCECODNBJ BKMJIJNEKAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x69A19D0", Offset = "0x69A03D0", VA = "0x1869A19D0")]
	[CompilerGenerated]
	private void BHMDBKOMEPL(EADCECODNBJ BKMJIJNEKAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x69A1C90", Offset = "0x69A0690", VA = "0x1869A1C90")]
	[CompilerGenerated]
	private void HBOIHKFOOCE(GBCNOEIKEOL BKMJIJNEKAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x69A1C30", Offset = "0x69A0630", VA = "0x1869A1C30")]
	[CompilerGenerated]
	private void GPPMIHCGFDI(EADCECODNBJ BKMJIJNEKAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x69A1D50", Offset = "0x69A0750", VA = "0x1869A1D50")]
	[CompilerGenerated]
	private void JCMPBENDHMO(IJGJDJPFIAJ BKMJIJNEKAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x69A1B70", Offset = "0x69A0570", VA = "0x1869A1B70")]
	[CompilerGenerated]
	private void ENJJCFPFBPE(EADCECODNBJ BKMJIJNEKAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x69A1BD0", Offset = "0x69A05D0", VA = "0x1869A1BD0")]
	[CompilerGenerated]
	private void FJCOGAOKKPL(AGPEIHBOPOK BKMJIJNEKAE)
	{
	}
}
namespace RecRoom.ObjectModel.Service.Internal
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[JEGJCCBDMOE(OLCAJGBKOGB.Services)]
	internal class ServiceInitOrder : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly FNLHMDLBAHC KBEHPOJPNNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly Dictionary<Type, object> OJDLFCACFLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly HashSet<object> ADAKHGHKIJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly Disposables HJMKNPMFOOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly IKIGKMLBEFF MJMOJANEIJI;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x69A4EC0", Offset = "0x69A38C0", VA = "0x1869A4EC0")]
		public ServiceInitOrder(IKIGKMLBEFF MJMOJANEIJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x69A43A0", Offset = "0x69A2DA0", VA = "0x1869A43A0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x69A3910", Offset = "0x69A2310", VA = "0x1869A3910")]
		public void AGMLDLCGDGN(Type EKGNJFKLBCB, object LHDJJEMNOIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x69A4080", Offset = "0x69A2A80", VA = "0x1869A4080")]
		private void DGOHFIPLFPI(Type EKGNJFKLBCB, Type HELDLMEDGHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x69A39A0", Offset = "0x69A23A0", VA = "0x1869A39A0")]
		private void BDKKDFGCPHN(Type EKGNJFKLBCB, Type HELDLMEDGHK, Type NNDGCIEGNDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x69A4AD0", Offset = "0x69A34D0", VA = "0x1869A4AD0")]
		public void GABIDGOKNII(IKCBIOLBAAI PALLPPNHLGA, LENFBMHDJIO PEFBHOMLEPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x69A4BA0", Offset = "0x69A35A0", VA = "0x1869A4BA0")]
		private void JCIINIGIPDM(IKCBIOLBAAI PALLPPNHLGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x69A3B10", Offset = "0x69A2510", VA = "0x1869A3B10")]
		private void BLLBAEFGOEL(IKCBIOLBAAI PALLPPNHLGA, LENFBMHDJIO PEFBHOMLEPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x69A4D20", Offset = "0x69A3720", VA = "0x1869A4D20")]
		private IEnumerable<Type> NFEGACOFNMG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x69A43C0", Offset = "0x69A2DC0", VA = "0x1869A43C0")]
		private static bool EDLHNPDJICM(Type OPBECMDGDDD, Type NNDGCIEGNDD, out IKIGKMLBEFF MJMOJANEIJI, out string NOGDNAGMMCO)
		{
			return default(bool);
		}
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.Services.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[Preserve]
	internal class _RRAssemblyIndex : AAHOHGIJHFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x69A6840", Offset = "0x69A5240", VA = "0x1869A6840", Slot = "4")]
		public sealed override void KLMOEJEAKPE()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class KKMDFNBFHNC
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static byte[] BKNPCMHFKCN;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static int KPMJKGHHDMP;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static int JFAKBFOPBGJ;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static BigInteger JMHPFPLGCJL;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	public KKMDFNBFHNC()
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
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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

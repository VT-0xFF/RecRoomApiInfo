using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom.RoomEconomy.RoomInventory;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class EPELCBFOCLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly MBNHLOIPEAM NJIHDNKAJDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly long IGPGGFCOPJC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int GDLJGJDJPED
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x65E0EF0", Offset = "0x65E02F0", VA = "0x1865E0EF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x65E0F00", Offset = "0x65E0300", VA = "0x1865E0F00")]
	public EPELCBFOCLC(MBNHLOIPEAM APCONDCGDJA, long GNHCGOJHAJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum JIDOMPLHIMJ
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	HiddenWhenNone,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Hidden,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	AlwaysVisibleOnceOwned,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	AlwaysVisible
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface PKHLABGFHIJ
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	DECPPMKECOG AGLNJELEKGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	NFAKNFEBDCB<BOKGJMPLMIL> ADAKOOLGPDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	NFAKNFEBDCB<Guid> KBOCBKJKGMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	PLDMPICEDLM<PKAJDOKDMJC, int> DOAGKPMLHFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	DECPPMKECOG EADAGNLNJLP
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<EGECKPFNJNE<BOKGJMPLMIL, string>> EJHBMIEDDFI(long JFLKHKDOLFI, string ADLKEGECLOG, string MFDFNAPOEEK, string PGFBEFNIOHM, RoomInventoryItemProperties OGGBBPNBCPJ);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<EGECKPFNJNE<BOKGJMPLMIL, string>> PLBFHNJBJME(Guid ELINCENJLAJ, [Optional] string ADLKEGECLOG, [Optional] string MFDFNAPOEEK, [Optional] string PGFBEFNIOHM, [Optional] RoomInventoryItemProperties OGGBBPNBCPJ);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<EGECKPFNJNE<bool, string>> MOLHCKOJOCA(Guid ELINCENJLAJ);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "13")]
	IReadOnlyList<BOKGJMPLMIL> NCOKAIMMJAK();

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "14")]
	IReadOnlyList<BOKGJMPLMIL> ALCGBIMCHEN();

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool COLEMCEBOPO(Guid ELINCENJLAJ, [Out] BOKGJMPLMIL HILMPBOOHHL);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool HAGMGIOMMOP(string CIPJHANAOPG, [Out] BOKGJMPLMIL HILMPBOOHHL);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool OLAGCBBAMCA(Guid ELINCENJLAJ, [Out] PKAJDOKDMJC IOPGOJKHFMH);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task<int> NMIJHJBMLND(LGNHMFCMNEG HGINANEPKFN, Guid ELINCENJLAJ);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task<EPELCBFOCLC> MHPGMIEGHLB(LGNHMFCMNEG HGINANEPKFN, Guid ELINCENJLAJ, int PAJBMBKMIHA);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "20")]
	string POCMOFENBCH(MBNHLOIPEAM APCONDCGDJA);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool AHODLADNGKB();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void Dispose();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface LOCKFBGCNIO : PKHLABGFHIJ
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FCBBHMMBGDC(IEnumerable<JADHDFOKEOG> GFIPKJLFAON);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class PKAJDOKDMJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly Guid NGOAPOPNNNI;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long IGPGGFCOPJC
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x65E1570", Offset = "0x65E0970", VA = "0x1865E1570")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int GDLJGJDJPED
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x65E1580", Offset = "0x65E0980", VA = "0x1865E1580")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long MHNBMFBHLFO
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x793FD0", Offset = "0x7933D0", VA = "0x180793FD0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x793FC0", Offset = "0x7933C0", VA = "0x180793FC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public long MEAFPGBMFLO
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x793ED0", Offset = "0x7932D0", VA = "0x180793ED0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x79A740", Offset = "0x799B40", VA = "0x18079A740")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Guid? EDIONBOEPHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x79D9A0", Offset = "0x79CDA0", VA = "0x18079D9A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x79DA00", Offset = "0x79CE00", VA = "0x18079DA00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool JCPJBEBLOCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x821240", Offset = "0x820640", VA = "0x180821240")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x19C2D30", Offset = "0x19C2130", VA = "0x1819C2D30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x65E15A0", Offset = "0x65E09A0", VA = "0x1865E15A0")]
	public PKAJDOKDMJC(JADHDFOKEOG DCAOPJIMHHB, bool EEDEGBFDICB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x1CF3140", Offset = "0x1CF2540", VA = "0x181CF3140")]
	public PKAJDOKDMJC(Guid ELINCENJLAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x65E1320", Offset = "0x65E0720", VA = "0x1865E1320")]
	internal bool AKOCPLJFKLG(JADHDFOKEOG DCAOPJIMHHB, long IHLEGBLCDOI, Action<PKAJDOKDMJC, int> ALKLEIDEHCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x65E1510", Offset = "0x65E0910", VA = "0x1865E1510")]
	internal void IINGBJIOFAB(long FDIMJGMAGDO, Action<PKAJDOKDMJC, int> ALKLEIDEHCP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class BOKGJMPLMIL : IEquatable<BOKGJMPLMIL>
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public const int JAPJNCKHELP = 3;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public const int OFKPOPFEHGK = 25;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public const int IHDLPDOLNMM = 180;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public const int PJHEGNFCAIH = 1000;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Guid NGOAPOPNNNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xB5FAF0", Offset = "0xB5EEF0", VA = "0x180B5FAF0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x1BC3F10", Offset = "0x1BC3310", VA = "0x181BC3F10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public long GJKPNGNLLFK
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x796850", Offset = "0x795C50", VA = "0x180796850")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xE39570", Offset = "0xE38970", VA = "0x180E39570")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string DACJMNMHBIF
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7940D0", Offset = "0x7934D0", VA = "0x1807940D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x796870", Offset = "0x795C70", VA = "0x180796870")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string FBBHJAECEKN
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x793FD0", Offset = "0x7933D0", VA = "0x180793FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x796860", Offset = "0x795C60", VA = "0x180796860")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public string DHLGKNNPFBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x793ED0", Offset = "0x7932D0", VA = "0x180793ED0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7940F0", Offset = "0x7934F0", VA = "0x1807940F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public DateTime LJFEFONPHLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x793E80", Offset = "0x793280", VA = "0x180793E80")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x198FB80", Offset = "0x198EF80", VA = "0x18198FB80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public DateTime IDLLOICJLLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x78F350", Offset = "0x78E750", VA = "0x18078F350")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x19A5440", Offset = "0x19A4840", VA = "0x1819A5440")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public RoomInventoryItemProperties NACNNKBJPLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x792F30", Offset = "0x792330", VA = "0x180792F30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x792F60", Offset = "0x792360", VA = "0x180792F60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x65E0D70", Offset = "0x65E0170", VA = "0x1865E0D70")]
	public BOKGJMPLMIL(LAAAOAOOAMD DCAOPJIMHHB, [Optional] RoomInventoryItemProperties OGGBBPNBCPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x65E0930", Offset = "0x65DFD30", VA = "0x1865E0930", Slot = "4")]
	public bool Equals(BOKGJMPLMIL JLCJEDAFKJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x65E0AB0", Offset = "0x65DFEB0", VA = "0x1865E0AB0", Slot = "0")]
	public override bool Equals(object DFFBALIDCLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x65E0C90", Offset = "0x65E0090", VA = "0x1865E0C90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class KJOMBCDINOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private PKAJDOKDMJC IOPGOJKHFMH;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public BOKGJMPLMIL OONINILAJGF
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x793920", Offset = "0x792D20", VA = "0x180793920")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x793930", Offset = "0x792D30", VA = "0x180793930")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public PKAJDOKDMJC CPOPAAPFGAL
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x65E0F40", Offset = "0x65E0340", VA = "0x1865E0F40")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x792A30", Offset = "0x791E30", VA = "0x180792A30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x65E0FD0", Offset = "0x65E03D0", VA = "0x1865E0FD0")]
	public KJOMBCDINOM(BOKGJMPLMIL HILMPBOOHHL, [Optional] PKAJDOKDMJC IOPGOJKHFMH)
	{
	}
}
namespace RecRoom.RoomEconomy.RoomInventory
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class RoomInventoryItemProperties : IEquatable<RoomInventoryItemProperties>
	{
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private const int CURRENT_VERSION = 1;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static RoomInventoryItemProperties Default
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x65E1790", Offset = "0x65E0B90", VA = "0x1865E1790")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		internal int Version
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x78F180", Offset = "0x78E580", VA = "0x18078F180")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x79D9F0", Offset = "0x79CDF0", VA = "0x18079D9F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool SupportsUseAction
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x909000", Offset = "0x908400", VA = "0x180909000")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x908FF0", Offset = "0x9083F0", VA = "0x180908FF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public JIDOMPLHIMJ Visibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x78F1D0", Offset = "0x78E5D0", VA = "0x18078F1D0")]
			[CompilerGenerated]
			get
			{
				return default(JIDOMPLHIMJ);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x7979D0", Offset = "0x796DD0", VA = "0x1807979D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x65E16D0", Offset = "0x65E0AD0", VA = "0x1865E16D0", Slot = "4")]
		public bool Equals(RoomInventoryItemProperties JLCJEDAFKJL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x65E1650", Offset = "0x65E0A50", VA = "0x1865E1650")]
		public static RoomInventoryItemProperties BKBFLDHHCMN(RoomInventoryItemProperties OGGBBPNBCPJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x1A2AD80", Offset = "0x1A2A180", VA = "0x181A2AD80")]
		public RoomInventoryItemProperties()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal static class CPKJINAFGCN
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x65E0E90", Offset = "0x65E0290", VA = "0x1865E0E90")]
	public static int OECOADCIDHI(long OGEDDLPEGMG)
	{
		return default(int);
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

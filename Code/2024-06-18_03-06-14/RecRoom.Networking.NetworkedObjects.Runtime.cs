using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2IlInjected;
using ExitGames.Client.Photon;
using JetBrains.Annotations;
using Photon.Realtime;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface JBNANBBIFBM
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<bool> CCEODECEENJ;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EKBFOLFCBKK(object JCIFCENKMKP);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AEPNIELODGD(object JCIFCENKMKP);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KDFAFLKKHDL(object JCIFCENKMKP, bool EJIHAKFCFBI);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IDisposable LHONJENHODK();

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool FEKGMBBJMHM();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IPPHOGOJJDL(StringBuilder ODJPIMKJDBP);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool IAGPCKBOIGA(bool LJHMDADACPJ, [Out] string BKMJJACFCBK);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface NJMPHBJNLAC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool CGCBDCEIEKI
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	GEELLJMKKPM MEMECOBLFLO
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool PMDPALLONBG
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool GEIEGKKGMLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool FMGHGOJKFFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool KABKHOJOOOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	BADJBHGFANM JKFJCKHPDIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool FKJCMPLDPHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<GEELLJMKKPM, GEELLJMKKPM> HHNGNLHHJNK;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EMJEPADHLGC(IHCGIJLNMPA AELKGENHKKJ);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool KLDIKNMJIKI();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool DKBBPJLDMCJ(string NGLKAOLIEOA, FCFAMDIDFED IIDHHAEJDIN);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void FEAOLAEOEPB();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool FEJDNALKAAK(AppSettings NCIEPDOJKEP);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface GEELLJMKKPM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	FCOAFDDNJKE OPJPFPNJJPC
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	[CanBeNull]
	EAAODAGEJLG JFENGHLMGMD
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool KABKHOJOOOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool PMDPALLONBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool FJNIIPLNCND
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	[CanBeNull]
	Exception PLLBLCLPKIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	StatusCode KPFGKICDGKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event IHCGIJLNMPA.KBLJBOGHOIA GFEGKECCCFN;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<FCOAFDDNJKE, FCOAFDDNJKE> PEBGMNOJGAN;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LNDMMFJEBHP(object PIBCCEDJCCL);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void ELNPBNAFCEF(object PLJNIDJFDFD);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void DGOGFKMJGLB(byte BEDMMPCCKDC, int FHOIOAHBGEP, object ECOHBDCBECH);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface KGMIOAOMIPE
{
	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event IHCGIJLNMPA.KBLJBOGHOIA GFEGKECCCFN;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event DGOGFKMJGLB DAEGHDJCGOF;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool BMJIPCINGIA(byte BEDMMPCCKDC, Hashtable LLHLGHCEKMK, KKFFNPANNKN IMFDJHHCDMD, SendOptions FFJHELMNLKM);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface OOAABLJLPBA
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	JDKCNIBKGKE IEINKFJJGFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int GLNAKAMKPOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	int MKDFPMEPAGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool IGOCMKBBFCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	int HFHFNLPBFGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action<JDKCNIBKGKE> GOFGEPMBEBC;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "7")]
	[CanBeNull]
	JDKCNIBKGKE KKCEJIBAPJP(int JBNPKIOAEDN);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface FNGDKKGMMKN
{
	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action OOHDDHJBLGJ;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AJJAOAEJDHI();
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface FGAKHKLMNEL : NJMPHBJNLAC, JBNANBBIFBM, KGMIOAOMIPE, OOAABLJLPBA, FNGDKKGMMKN
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	int PPLFIELCHLD
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	int PNPIFBGAMGL
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	float NLGOIKAAKIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	float EPJCFDHKJGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool ICEKDPPMDEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	GKDGFNGFCHN GEFDFIGPFHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action HNMABGPJFFF;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ILHANPPAEIA();

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BJDLBMHDMEM();

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void DBCCNDNPMCH(string HHLELHABPON);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface GKDGFNGFCHN
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool GFNDEHAKLPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool HGGKDFPKDEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	IReadOnlyList<CHKCFNJNIDD> IAEKIDPOKJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FPFKGJCIOJE(Action OKNMPFFHNGD, string CEACGPEFPBB);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class KOFFCJBDDGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public string HMOHJILNKOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Vector3 IOJOFKPMLAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Quaternion JIIABDGOIIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Vector3 CEICIFJLDCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public int NGIMIFEPHAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Dictionary<string, object> AALFGPKDMJP;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x696BC40", Offset = "0x696A640", VA = "0x18696BC40")]
	public object[] EAHFHHOLNJE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
	public KOFFCJBDDGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class DGDMHHNNPCI
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6969380", Offset = "0x6967D80", VA = "0x186969380")]
	public static bool FOPNPIPAPFO(this NJMPHBJNLAC DCLGAKMBDMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x69692B0", Offset = "0x6967CB0", VA = "0x1869692B0")]
	public static bool AGJEKFLHLII(this NJMPHBJNLAC DCLGAKMBDMG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class INOAEMJPBLH : FGAKHKLMNEL, NJMPHBJNLAC, JBNANBBIFBM, KGMIOAOMIPE, OOAABLJLPBA, FNGDKKGMMKN
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private class MGCKNBFOCIL : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly INOAEMJPBLH DFNAJMALOHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool MENBJDNCHDA;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x696C460", Offset = "0x696AE60", VA = "0x18696C460")]
		public MGCKNBFOCIL(INOAEMJPBLH DFNAJMALOHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x696C360", Offset = "0x696AD60", VA = "0x18696C360", Slot = "1")]
		~MGCKNBFOCIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x696C2D0", Offset = "0x696ACD0", VA = "0x18696C2D0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x696C400", Offset = "0x696AE00", VA = "0x18696C400")]
		private void LAGMPCIECFF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly object OBFOJAAHJDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly object IDFPFKHENOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private float NAGNAHFNCPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private float GOCCPLKJCIM;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public abstract bool FKJCMPLDPHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public abstract float JPKIDKLMCEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "62")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public abstract int PPLFIELCHLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "63")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public abstract int PNPIFBGAMGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public abstract JDKCNIBKGKE IEINKFJJGFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "65")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int GLNAKAMKPOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x696AAD0", Offset = "0x69694D0", VA = "0x18696AAD0", Slot = "48")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public abstract int MKDFPMEPAGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public abstract int HFHFNLPBFGG
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool IGOCMKBBFCG
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x696B8A0", Offset = "0x696A2A0", VA = "0x18696B8A0", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public float NLGOIKAAKIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8BBA90", Offset = "0x8BA490", VA = "0x1808BBA90", Slot = "74")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x696AB40", Offset = "0x6969540", VA = "0x18696AB40", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public float EPJCFDHKJGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8BBBA0", Offset = "0x8BA5A0", VA = "0x1808BBBA0", Slot = "75")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x696AE10", Offset = "0x6969810", VA = "0x18696AE10", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public abstract bool ICEKDPPMDEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "76")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public abstract GKDGFNGFCHN GEFDFIGPFHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "77")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public abstract bool CGCBDCEIEKI
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "80")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public abstract GEELLJMKKPM MEMECOBLFLO
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "81")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public abstract bool PMDPALLONBG
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "82")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public abstract bool GEIEGKKGMLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "83")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "84")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public abstract bool FMGHGOJKFFK
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "85")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public abstract bool KABKHOJOOOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "86")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public abstract BADJBHGFANM JKFJCKHPDIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "87")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private NFLEMDIBMBJ BPIEDEDJNKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x84EC50", Offset = "0x84D650", VA = "0x18084EC50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private NFLEMDIBMBJ AALEDKOGOCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x84EEA0", Offset = "0x84D8A0", VA = "0x18084EEA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private LOGIDLDKBHN<Func<float>> DMFCEADBHMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x84EC40", Offset = "0x84D640", VA = "0x18084EC40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private bool MOAOFALMEIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xE68220", Offset = "0xE66C20", VA = "0x180E68220")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	protected bool ECBNFIHIKDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x696A5D0", Offset = "0x6968FD0", VA = "0x18696A5D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	protected bool LGKJDKFLDFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x696A6A0", Offset = "0x69690A0", VA = "0x18696A6A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event IHCGIJLNMPA.KBLJBOGHOIA GFEGKECCCFN
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x696AE50", Offset = "0x6969850", VA = "0x18696AE50", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x696ADA0", Offset = "0x69697A0", VA = "0x18696ADA0", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	[method: Cpp2IlInjected.Token(Token = "0x600004E")]
	[method: Cpp2IlInjected.Address(Slot = "56")]
	public abstract event DGOGFKMJGLB DAEGHDJCGOF;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	[method: Cpp2IlInjected.Token(Token = "0x6000050")]
	[method: Cpp2IlInjected.Address(Slot = "58")]
	public abstract event Action<JDKCNIBKGKE> GOFGEPMBEBC;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	[method: Cpp2IlInjected.Token(Token = "0x6000068")]
	[method: Cpp2IlInjected.Address(Slot = "78")]
	public abstract event Action<GEELLJMKKPM, GEELLJMKKPM> HHNGNLHHJNK;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<bool> CCEODECEENJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x696A6E0", Offset = "0x69690E0", VA = "0x18696A6E0", Slot = "31")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x696A490", Offset = "0x6968E90", VA = "0x18696A490", Slot = "32")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action HNMABGPJFFF
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x696BA20", Offset = "0x696A420", VA = "0x18696BA20", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x696A930", Offset = "0x6969330", VA = "0x18696A930", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action OOHDDHJBLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x696AD00", Offset = "0x6969700", VA = "0x18696AD00", Slot = "53")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x696AB80", Offset = "0x6969580", VA = "0x18696AB80", Slot = "54")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "68")]
	public abstract JDKCNIBKGKE KKCEJIBAPJP(int JBNPKIOAEDN);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "69")]
	public abstract bool FEJDNALKAAK(AppSettings NCIEPDOJKEP);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "70")]
	public abstract void FEAOLAEOEPB();

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "71")]
	public abstract bool KLDIKNMJIKI();

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "72")]
	public abstract void CCPLOBBMMKG();

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "73")]
	public abstract bool BMJIPCINGIA(byte BEDMMPCCKDC, Hashtable LLHLGHCEKMK, KKFFNPANNKN IMFDJHHCDMD, SendOptions FFJHELMNLKM);

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "88")]
	public abstract bool DKBBPJLDMCJ(string NGLKAOLIEOA, FCFAMDIDFED IIDHHAEJDIN);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "89")]
	public abstract void DBCCNDNPMCH(string HHLELHABPON);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "90")]
	public abstract void EMJEPADHLGC(IHCGIJLNMPA AELKGENHKKJ);

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x696BAC0", Offset = "0x696A4C0", VA = "0x18696BAC0")]
	protected INOAEMJPBLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x696A680", Offset = "0x6969080", VA = "0x18696A680")]
	public void CCPNKNOIBEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x696B590", Offset = "0x6969F90", VA = "0x18696B590", Slot = "35")]
	public void KDFAFLKKHDL(object JCIFCENKMKP, bool EJIHAKFCFBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x696A9D0", Offset = "0x69693D0", VA = "0x18696A9D0", Slot = "33")]
	public void EKBFOLFCBKK(object JCIFCENKMKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x696A540", Offset = "0x6968F40", VA = "0x18696A540", Slot = "34")]
	public void AEPNIELODGD(object JCIFCENKMKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x696B760", Offset = "0x696A160", VA = "0x18696B760", Slot = "36")]
	public IDisposable LHONJENHODK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x696AEC0", Offset = "0x69698C0", VA = "0x18696AEC0", Slot = "91")]
	public virtual bool IAGPCKBOIGA(bool LJHMDADACPJ, [Out] string BKMJJACFCBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x696A790", Offset = "0x6969190", VA = "0x18696A790")]
	private bool EAIPFODEECM([Out] string BKMJJACFCBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x696B930", Offset = "0x696A330", VA = "0x18696B930")]
	private bool OBMPCJFFJCI([Out] string BKMJJACFCBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x696AC20", Offset = "0x6969620", VA = "0x18696AC20", Slot = "37")]
	public bool FEKGMBBJMHM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x696B320", Offset = "0x6969D20", VA = "0x18696B320", Slot = "38")]
	public void IPPHOGOJJDL(StringBuilder ODJPIMKJDBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x696B0E0", Offset = "0x6969AE0", VA = "0x18696B0E0")]
	private void IBFACLGPGFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x696AC70", Offset = "0x6969670", VA = "0x18696AC70")]
	private void GKLCBLBCJDL(Func<float> CKGAEHMPIFF, object JCIFCENKMKP, int AJDJDACIIPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x696B9C0", Offset = "0x696A3C0", VA = "0x18696B9C0", Slot = "92")]
	public void OCNJCFABGNL(object JCIFCENKMKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x696B290", Offset = "0x6969C90", VA = "0x18696B290", Slot = "8")]
	public void ILHANPPAEIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x696A620", Offset = "0x6969020", VA = "0x18696A620", Slot = "9")]
	public void BJDLBMHDMEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x696B6B0", Offset = "0x696A0B0", VA = "0x18696B6B0")]
	private void LEMDDHLJICE(float CGNNGIOOAGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x8BBBA0", Offset = "0x8BA5A0", VA = "0x1808BBBA0")]
	private float EMLMEPHNIMG()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x8BBA90", Offset = "0x8BA490", VA = "0x1808BBA90")]
	private float BHPPHNNJPII()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x696B7F0", Offset = "0x696A1F0", VA = "0x18696B7F0")]
	private void MOOFFFNNBAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x696A580", Offset = "0x6968F80", VA = "0x18696A580", Slot = "55")]
	public void AJJAOAEJDHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class FKIGMAECJOF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public string MDBGILIHOGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public bool CDENMONONNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected internal bool FAFENBBPPAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	protected internal int DAJNCHFEHLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	protected internal byte[] JMHHHFFNBLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	protected internal byte ELIBBNFPJDB;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static readonly System.Random NIFGFMJNLDO;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6969EE0", Offset = "0x69688E0", VA = "0x186969EE0", Slot = "5")]
	public virtual bool KPLFBOMGBNN(string KPFBGAFPAIK, int EFFIPLGIFEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6969F30", Offset = "0x6968930", VA = "0x186969F30", Slot = "6")]
	public virtual bool MANEODJNDND()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6969E10", Offset = "0x6968810", VA = "0x186969E10", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6969E60", Offset = "0x6968860", VA = "0x186969E60")]
	protected internal void GKMPMEFLHAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x696A000", Offset = "0x6968A00", VA = "0x18696A000")]
	protected FKIGMAECJOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class LKKFFIOEFKC : FKIGMAECJOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private Socket HCFLNLKAAHF;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x696BD60", Offset = "0x696A760", VA = "0x18696BD60", Slot = "5")]
	public override bool KPLFBOMGBNN(string KPFBGAFPAIK, int EFFIPLGIFEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x696C000", Offset = "0x696AA00", VA = "0x18696C000", Slot = "6")]
	public override bool MANEODJNDND()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x5F10C00", Offset = "0x5F0F600", VA = "0x185F10C00", Slot = "7")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x696C1F0", Offset = "0x696ABF0", VA = "0x18696C1F0")]
	public LKKFFIOEFKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class GJJDGFDPCLK
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public string BKIGGLLPDBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x84EC70", Offset = "0x84D670", VA = "0x18084EC70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x84EC30", Offset = "0x84D630", VA = "0x18084EC30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string OMEFIMJAJNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x84EC60", Offset = "0x84D660", VA = "0x18084EC60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x84EC00", Offset = "0x84D600", VA = "0x18084EC00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public string DNKECLNLOGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x850E50", Offset = "0x84F850", VA = "0x180850E50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x850E40", Offset = "0x84F840", VA = "0x180850E40")]
		[CompilerGenerated]
		protected internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int NKCEKDCJIAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8566A0", Offset = "0x8550A0", VA = "0x1808566A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8566E0", Offset = "0x8550E0", VA = "0x1808566E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x696A370", Offset = "0x6968D70", VA = "0x18696A370")]
	public GJJDGFDPCLK(string KIPEDCEMNBN, string JPMGDOMJOOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x696A1A0", Offset = "0x6968BA0", VA = "0x18696A1A0")]
	private void MAEGPGAPCPB(string LMHIPDMGHOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x696A2B0", Offset = "0x6968CB0", VA = "0x18696A2B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x696A0B0", Offset = "0x6968AB0", VA = "0x18696A0B0")]
	public string DBFCKNEJGCG(bool PLBMHJIFFKA = false)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class FEHAOLJFGGC
{
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static int KMCAAIJJJOI;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public static bool JAGAHABCIPJ;

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public static int APDFIPMHFAM;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public static int MAKBAAGJAMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private GJJDGFDPCLK GAALCEMOFIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private string MJMOFKIINAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private int ADGNDKGMJCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public int MBLKHHANACM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private Action<GJJDGFDPCLK> DJJEAGGFMPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private FKIGMAECJOF FKIBFBNCLDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private List<int> HCOFKCPIJEH;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool MANEODJNDND
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xA659B0", Offset = "0xA643B0", VA = "0x180A659B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xB36070", Offset = "0xB34A70", VA = "0x180B36070")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6969D60", Offset = "0x6968760", VA = "0x186969D60")]
	public FEHAOLJFGGC(GJJDGFDPCLK GAALCEMOFIO, Action<GJJDGFDPCLK> MKIJIHNDLGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x69697E0", Offset = "0x69681E0", VA = "0x1869697E0")]
	public bool FNEPMCHENFK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6969B50", Offset = "0x6968550", VA = "0x186969B50")]
	public static string NGIONHENDGN(string CONJONOEFFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6969CD0", Offset = "0x69686D0", VA = "0x186969CD0")]
	protected internal void NOCNKLIGDBI(object NIDJKNBFFJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6969510", Offset = "0x6967F10", VA = "0x186969510")]
	protected internal bool EPHGGMMLDDJ()
	{
		return default(bool);
	}
}
namespace Cpp2IlInjected;

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

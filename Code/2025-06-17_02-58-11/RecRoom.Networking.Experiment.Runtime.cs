using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2IlInjected;
using RecRoom;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Foundation;
using RecRoom.ObjectModel;
using Unity.Collections;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _AssemblyRegistry.RecRoom_Networking_Experiment_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7E3A8A0", Offset = "0x7E392A0", VA = "0x187E3A8A0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2796C60", Offset = "0x2795660", VA = "0x182796C60")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface APIHBEIAIJE
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CLHFIKJJEPE(BCHAGGJCBIN JKGCHKOAIPN, bool OLAALDJFJON = false);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int ICACDDLNLIK(BCHAGGJCBIN[] CAIHDKKACCK);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DIJHOGHEJAO();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DDJKOLJIGNB(int POHODHGBPHP, int KCAHOJHAGKP, bool OBLENHAAONG, GameObject HNGFDIJGINB);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NLPPHFDPCMJ(int KCAHOJHAGKP, [Optional] int? FEKGEHBGLLM);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool BCDNAMFLMNG(HCCHCCGILAH JEMDJIEKJFA, [Out] BCHAGGJCBIN CMDCHHFPJJG, bool JLABGODBDMG = true);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool ABKAIKKINKB(HCCHCCGILAH JEMDJIEKJFA, [Out] int BCHHOFOFBKL, [Out] BCHAGGJCBIN[] CAIHDKKACCK);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool OKJNCOMJGPG(HCCHCCGILAH JEMDJIEKJFA, [Out] int KCAHOJHAGKP);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LBKNNOHDMKI(HCCHCCGILAH JEMDJIEKJFA, [Out] int JCLAEJFHIOG, [Out] int[] MHOOIKNKEKC);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void INJLABHIGAK(int BCHHOFOFBKL);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void OHJEPAMMAPL(int BCHHOFOFBKL, int[] MHOOIKNKEKC);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void EOJBJMMNJMD(int[] MHOOIKNKEKC);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void LDLJJPHMFOB(int[] MHOOIKNKEKC);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void EAADEPKOFPB(int BCHHOFOFBKL, int KCAHOJHAGKP);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface KAFDOFNEINA
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HDPGMIKIEGL(ViewId POHODHGBPHP);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KDPLBIKLLBD(HCCHCCGILAH JEMDJIEKJFA, [Out] ViewId POHODHGBPHP, [Out] string KJHKPFJLEEB, [Out] int ENCFEMPDCCA, [Out] object[] FOABHHONDMI);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PDOKONKOCKK(ViewId MMGGIIKGBNM, string KJHKPFJLEEB, KGENHPLGJBJ PDKPPAEHICP, GBDECDHLMJN KPIDJKLDGJJ, PJHBHKGEEAK BKKIDHENLIH, object[] JKGCHKOAIPN);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class PAEHLGAEPBJ : ICKNPKBJODA, KPOIGOFACJG, PEKPECOOHHK, AHIDOPECKNN, OHJGNBHMELG, OJFODEFOOCG, AHDBNGNAHKJ, AIMJAGPELFN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private ICKNPKBJODA LAMIGBBFPGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7E36640", Offset = "0x7E35040", VA = "0x187E36640")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public float ACAIPJBKHOK
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7E39A20", Offset = "0x7E38420", VA = "0x187E39A20", Slot = "6")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int IKIMEPANDAD
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7E38430", Offset = "0x7E36E30", VA = "0x187E38430", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int FACIFGDMKMN
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7E381A0", Offset = "0x7E36BA0", VA = "0x187E381A0", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int NOHLPIGHFKC
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7E387C0", Offset = "0x7E371C0", VA = "0x187E387C0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int BAPDJMFHFNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7E39DA0", Offset = "0x7E387A0", VA = "0x187E39DA0", Slot = "17")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public float KCIIKGOKMJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7E376B0", Offset = "0x7E360B0", VA = "0x187E376B0", Slot = "24")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public float CNHJLFGBCFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7E386B0", Offset = "0x7E370B0", VA = "0x187E386B0", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool IEEGFDDGABA
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7E36680", Offset = "0x7E35080", VA = "0x187E36680", Slot = "26")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public DKNMPAOCGIA NCICNNDBHLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7E37060", Offset = "0x7E35A60", VA = "0x187E37060", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public double MPFAODOCFHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7E3A180", Offset = "0x7E38B80", VA = "0x187E3A180", Slot = "29")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int DAMMFFLKPCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7E375A0", Offset = "0x7E35FA0", VA = "0x187E375A0", Slot = "30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool OADECHMJMLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7E3A080", Offset = "0x7E38A80", VA = "0x187E3A080", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public ABEGIIDNPGF ILFAKFCKEOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7E39310", Offset = "0x7E37D10", VA = "0x187E39310", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool JCKDJLBFMBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7E38120", Offset = "0x7E36B20", VA = "0x187E38120", Slot = "36")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool OBHIDFLPHPO
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7E384B0", Offset = "0x7E36EB0", VA = "0x187E384B0", Slot = "37")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool PFAKPFFMJJB
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7E39C20", Offset = "0x7E38620", VA = "0x187E39C20", Slot = "39")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7E36BB0", Offset = "0x7E355B0", VA = "0x187E36BB0", Slot = "40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool OFFLGANPGAD
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7E37110", Offset = "0x7E35B10", VA = "0x187E37110", Slot = "41")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool BJLEFKIJJFG
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7E38630", Offset = "0x7E37030", VA = "0x187E38630", Slot = "42")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public object JLFMOAFFDKH
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7E37900", Offset = "0x7E36300", VA = "0x187E37900", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool BACHOHNPMLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7E36D40", Offset = "0x7E35740", VA = "0x187E36D40", Slot = "44")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7E37870", Offset = "0x7E36270", VA = "0x187E37870", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public GBDECDHLMJN IGOAGANFOKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7E380A0", Offset = "0x7E36AA0", VA = "0x187E380A0", Slot = "66")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int LDFEKHOEPMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7E39B10", Offset = "0x7E38510", VA = "0x187E39B10", Slot = "67")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int PMIODMHHDMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7E395C0", Offset = "0x7E37FC0", VA = "0x187E395C0", Slot = "68")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public GBDECDHLMJN JGEBLPFAMHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7E37190", Offset = "0x7E35B90", VA = "0x187E37190", Slot = "69")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool AEEFIAPJAME
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7E37290", Offset = "0x7E35C90", VA = "0x187E37290", Slot = "70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int AADKJDGOLOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7E385B0", Offset = "0x7E36FB0", VA = "0x187E385B0", Slot = "71")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public string EGEMLGEHLGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7E36AA0", Offset = "0x7E354A0", VA = "0x187E36AA0", Slot = "72")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public Func<string, string> JGLNHDAOBLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7E39640", Offset = "0x7E38040", VA = "0x187E39640", Slot = "73")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public KBKKLBBPBEC MOFIOOKNECE
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7E36390", Offset = "0x7E34D90", VA = "0x187E36390", Slot = "84")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool EEAHGIBDGBE
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7E36FE0", Offset = "0x7E359E0", VA = "0x187E36FE0", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public string HKPECCALMPN
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7E37E10", Offset = "0x7E36810", VA = "0x187E37E10", Slot = "85")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public long DOJFFEMMFEK
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7E38FD0", Offset = "0x7E379D0", VA = "0x187E38FD0", Slot = "86")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public long PNNOOIAJLNI
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7E38220", Offset = "0x7E36C20", VA = "0x187E38220", Slot = "87")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action LNDIIAJCJJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7E39520", Offset = "0x7E37F20", VA = "0x187E39520", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7E36710", Offset = "0x7E35110", VA = "0x187E36710", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<ABEGIIDNPGF, ABEGIIDNPGF> MOBOBBOFMDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7E39E20", Offset = "0x7E38820", VA = "0x187E39E20", Slot = "32")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7E3A480", Offset = "0x7E38E80", VA = "0x187E3A480", Slot = "33")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<bool> FJEDEPJAAEC
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7E36950", Offset = "0x7E35350", VA = "0x187E36950", Slot = "50")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7E39260", Offset = "0x7E37C60", VA = "0x187E39260", Slot = "51")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action<string, long> EKDELKNBGEO
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7E39970", Offset = "0x7E38370", VA = "0x187E39970", Slot = "59")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7E377C0", Offset = "0x7E361C0", VA = "0x187E377C0", Slot = "60")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action<HCCHCCGILAH> PKPBOODOBMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7E39FE0", Offset = "0x7E389E0", VA = "0x187E39FE0", Slot = "61")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7E36510", Offset = "0x7E34F10", VA = "0x187E36510", Slot = "62")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action<GBDECDHLMJN> JIDLHFGGFEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7E36A00", Offset = "0x7E35400", VA = "0x187E36A00", Slot = "64")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7E398D0", Offset = "0x7E382D0", VA = "0x187E398D0", Slot = "65")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action PMBABKOOJON
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7E36470", Offset = "0x7E34E70", VA = "0x187E36470", Slot = "81")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7E367B0", Offset = "0x7E351B0", VA = "0x187E367B0", Slot = "82")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7E38DE0", Offset = "0x7E377E0", VA = "0x187E38DE0")]
	[CGLGNCLDKHN.CKJOAALDIOP.OPIHCDHBMNP]
	internal static void JGOIPALGEOO(MHGNCMHMEKD DJGDNAKMFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7E3A530", Offset = "0x7E38F30", VA = "0x187E3A530")]
	[Preserve]
	public PAEHLGAEPBJ([CNHMBDDCGKB(null)] JFPEAJOCHDI GCDHIONAHBL, [CNHMBDDCGKB(null)] FCOIKHLMBEF NEPNNGNNIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7E373A0", Offset = "0x7E35DA0", VA = "0x187E373A0", Slot = "89")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7E37990", Offset = "0x7E36390", VA = "0x187E37990")]
	private void FJJAMOHJPLL(ICKNPKBJODA NFPKGBKPKNC, ICKNPKBJODA MFJFBNFOFDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x11DF5F0", Offset = "0x11DDFF0", VA = "0x1811DF5F0")]
	private void HHLABOCDCJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7E36EC0", Offset = "0x7E358C0", VA = "0x187E36EC0")]
	private void CLDGNJJCBKG(ABEGIIDNPGF EACEFKEJDGB, ABEGIIDNPGF KOHECGPMBHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0xD68A30", Offset = "0xD67430", VA = "0x180D68A30")]
	private void FBDIGBOPIJB(bool EIOLKALMPEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2331850", Offset = "0x2330250", VA = "0x182331850")]
	private void IEOMMPCLADE(string HHCAOFMCNLG, long AKFBLGMMJBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0xF700F0", Offset = "0xF6EAF0", VA = "0x180F700F0")]
	private void JNKOCLDKDOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7E39750", Offset = "0x7E38150", VA = "0x187E39750", Slot = "57")]
	public void MEFAADNHDKK(StringBuilder MLDFCHHLDNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7E38ED0", Offset = "0x7E378D0", VA = "0x187E38ED0", Slot = "14")]
	public void JLLDDLJJMNC(List<object> IBKFNAMHILN, int OBKGKEGIECO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7E389F0", Offset = "0x7E373F0", VA = "0x187E389F0", Slot = "16")]
	public void JBPNKDNJAGI(IDictionary<object, object> COGBEMJPNIC, int BJBHFAMODGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7E36310", Offset = "0x7E34D10", VA = "0x187E36310", Slot = "20")]
	public void ADPFJOBFELM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7E39B90", Offset = "0x7E38590", VA = "0x187E39B90", Slot = "49")]
	public bool NAHJLKIGCKH(object LKNPPGBPPJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7E3A270", Offset = "0x7E38C70", VA = "0x187E3A270", Slot = "22")]
	public object PGEPBAPICDN(NativeArray<byte> HPGIDELCODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7E39CA0", Offset = "0x7E386A0", VA = "0x187E39CA0", Slot = "23")]
	public int NGAMGKHDEEG(HCCHCCGILAH JEMDJIEKJFA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7E39150", Offset = "0x7E37B50", VA = "0x187E39150", Slot = "48")]
	public void KJDHDFALAOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7E38C60", Offset = "0x7E37660", VA = "0x187E38C60", Slot = "15")]
	public void JFJJPDFFGCJ(int BLEDCECONDJ, object JEMDJIEKJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7E37310", Offset = "0x7E35D10", VA = "0x187E37310", Slot = "76")]
	public GBDECDHLMJN DPMEAONPLEO(int LIEFHLCIOCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7E363E0", Offset = "0x7E34DE0", VA = "0x187E363E0", Slot = "75")]
	public GBDECDHLMJN AJIEBPGPDHN(int KJCCMAJJDNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7E38010", Offset = "0x7E36A10", VA = "0x187E38010", Slot = "77")]
	public GBDECDHLMJN FNCKIJJKJPD(int KJCCMAJJDNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7E38AF0", Offset = "0x7E374F0", VA = "0x187E38AF0", Slot = "56")]
	public bool JEFAIDJGNJO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7E39ED0", Offset = "0x7E388D0", VA = "0x187E39ED0", Slot = "11")]
	public bool OBKGLJFLNFB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7E383A0", Offset = "0x7E36DA0", VA = "0x187E383A0", Slot = "78")]
	public IReadOnlyList<GBDECDHLMJN> HACFFNGHAME(bool JPLKHIANGNK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7E391D0", Offset = "0x7E37BD0", VA = "0x187E391D0", Slot = "79")]
	public IReadOnlyList<GBDECDHLMJN> KKHOBEAFHMC(bool JPLKHIANGNK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7E36C40", Offset = "0x7E35640", VA = "0x187E36C40", Slot = "47")]
	public bool CFICCIJBGBJ(string CJNHPDLFGCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7E3A100", Offset = "0x7E38B00", VA = "0x187E3A100", Slot = "46")]
	public bool ONKNBKABNMI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7E36DC0", Offset = "0x7E357C0", VA = "0x187E36DC0", Slot = "58")]
	public bool CLAJHGBOFOI(bool HIPALJBMCHM, [Out] string OLIGKIPGKGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7E39050", Offset = "0x7E37A50", VA = "0x187E39050", Slot = "13")]
	public void JONJLLKONMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7E38840", Offset = "0x7E37240", VA = "0x187E38840", Slot = "55")]
	public IDisposable IJNKAKHIJCC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7E388C0", Offset = "0x7E372C0", VA = "0x187E388C0", Slot = "63")]
	public bool IPNAMOAAKJD(byte FDDOIFDLLNO, object AHJCOCMFHID, AIJLKOBFKFM CMJDPJIOEOH, JOJLAKAOABL PPFPKPFAHFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7E39850", Offset = "0x7E38250", VA = "0x187E39850", Slot = "83")]
	public void MFAHBABEGLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7E38530", Offset = "0x7E36F30", VA = "0x187E38530", Slot = "12")]
	public void HFEHJDDGKBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7E3A370", Offset = "0x7E38D70", VA = "0x187E3A370", Slot = "21")]
	public void PGPOMLMDCHO(object OJDHMKOBKLD, NativeList<byte> HPGIDELCODH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7E39420", Offset = "0x7E37E20", VA = "0x187E39420", Slot = "38")]
	public void LFAJILDNFDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7E37210", Offset = "0x7E35C10", VA = "0x187E37210", Slot = "18")]
	public void DKDIMJOAGMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7E390D0", Offset = "0x7E37AD0", VA = "0x187E390D0", Slot = "19")]
	public void KCJPHDFMHDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7E365B0", Offset = "0x7E34FB0", VA = "0x187E365B0", Slot = "80")]
	public bool BEBNMLALAHL(GBDECDHLMJN MAMJPGLPJEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7E37620", Offset = "0x7E36020", VA = "0x187E37620", Slot = "52")]
	public void ELJLDMBGDGJ(object BECBHDDLOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7E36850", Offset = "0x7E35250", VA = "0x187E36850", Slot = "54")]
	public void CAGLEGDDCHL(object BECBHDDLOHA, bool EIOLKALMPEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7E39F50", Offset = "0x7E38950", VA = "0x187E39F50", Slot = "53")]
	public void OCHHEDAJKCC(object BECBHDDLOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7E39390", Offset = "0x7E37D90", VA = "0x187E39390", Slot = "28")]
	public void LBFJIKCEOHK(string KMCEBDFLJHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7E382A0", Offset = "0x7E36CA0", VA = "0x187E382A0", Slot = "10")]
	public float GOPLPKEJKBF(bool KEEOABDKAML, int EILJCFEDMAA = 1)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7E37F00", Offset = "0x7E36900", VA = "0x187E37F00", Slot = "74")]
	public void FLGHPFFDPPM(string GBCFHNGPBLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7E38D60", Offset = "0x7E37760", VA = "0x187E38D60", Slot = "88")]
	public int JFPILEKEGBD()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum EDMJCHOJNGI
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	Photon,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	GameServer
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[ServiceLifetime(Lifetime.Application)]
public interface JFPEAJOCHDI
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[ServiceLifetime(Lifetime.Application)]
public interface FCOIKHLMBEF
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class FHDKNMGGDKK
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static EDMJCHOJNGI CJPIABNHEDI;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static EDMJCHOJNGI CEPAEHPBDCJ;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static bool HJPJBDJDDNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7E36160", Offset = "0x7E34B60", VA = "0x187E36160")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public static EDMJCHOJNGI OGLFAMKDCPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7E36110", Offset = "0x7E34B10", VA = "0x187E36110")]
		get
		{
			return default(EDMJCHOJNGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public static ICKNPKBJODA OEGMNCHDMGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7E35560", Offset = "0x7E33F60", VA = "0x187E35560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7E35AE0", Offset = "0x7E344E0", VA = "0x187E35AE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public static ICKNPKBJODA PGMOPEEFFNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7E35510", Offset = "0x7E33F10", VA = "0x187E35510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7E360A0", Offset = "0x7E34AA0", VA = "0x187E360A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public static ICKNPKBJODA LAMIGBBFPGD
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7E35410", Offset = "0x7E33E10", VA = "0x187E35410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static APIHBEIAIJE OOGMDGKMCOC
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7E35830", Offset = "0x7E34230", VA = "0x187E35830")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7E35A70", Offset = "0x7E34470", VA = "0x187E35A70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static APIHBEIAIJE DJPAMDBPMFO
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7E35880", Offset = "0x7E34280", VA = "0x187E35880")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7E35E00", Offset = "0x7E34800", VA = "0x187E35E00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static APIHBEIAIJE GGDBKMIFJMK
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7E358D0", Offset = "0x7E342D0", VA = "0x187E358D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static KAFDOFNEINA DDNNPGKHOHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7E353C0", Offset = "0x7E33DC0", VA = "0x187E353C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7E361B0", Offset = "0x7E34BB0", VA = "0x187E361B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public static KAFDOFNEINA JJIJPJGCPFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7E35B50", Offset = "0x7E34550", VA = "0x187E35B50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7E35F80", Offset = "0x7E34980", VA = "0x187E35F80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public static KAFDOFNEINA LDIMBEPMGBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7E35D00", Offset = "0x7E34700", VA = "0x187E35D00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public static event Action<ICKNPKBJODA, ICKNPKBJODA> FJJAMOHJPLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7E35E70", Offset = "0x7E34870", VA = "0x187E35E70")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7E355B0", Offset = "0x7E33FB0", VA = "0x187E355B0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7E36220", Offset = "0x7E34C20", VA = "0x187E36220")]
	static FHDKNMGGDKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7E356C0", Offset = "0x7E340C0", VA = "0x187E356C0")]
	public static void DBILOAODCDE(JFPEAJOCHDI GCDHIONAHBL, FCOIKHLMBEF NEPNNGNNIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7E35BA0", Offset = "0x7E345A0", VA = "0x187E35BA0")]
	public static void JGHLPKFCFJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7E35FF0", Offset = "0x7E349F0", VA = "0x187E35FF0")]
	private static void MKPDFFOMACD(EDMJCHOJNGI JGBHGLEIEBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7E359D0", Offset = "0x7E343D0", VA = "0x187E359D0")]
	private static void EKMNJBHAHEP(NMNFDNGOPCL CABCNLPMGMP)
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

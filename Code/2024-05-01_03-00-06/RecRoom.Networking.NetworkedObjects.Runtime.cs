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
public interface GDOJBJEEDJP
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<bool> GPAKEJOOGDA;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NAAMBLGEHON(object ADNDMAGEPOK);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NOPDELAODGM(object ADNDMAGEPOK);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CDCKEMGJPFP(object ADNDMAGEPOK, bool ACBKMGMNLJG);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IDisposable KMHAFNCLOHO();

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool LLPNBKLJDFC();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EKCLILAMCIA(StringBuilder PEFJEFMJEDM);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool HMKNDECBCJD(bool FPKEMABOPHM, [Out] string EPIMHJFIPDE);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface KDJAJLAMBFK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool FNGBCMCBMOK
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	BLAHDNCBNIM GMLDFFJPNCI
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool FNNNDPAOBBK
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool KHGLODEHEOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool ANHAADKCOJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool MCAFJHLAELO
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	IBDPKEJPCGB BDELPBMBOAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool GCKMDFPDKEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<BLAHDNCBNIM, BLAHDNCBNIM> LJDKEOKMFKA;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IBHFNKFPFOF(CIMLAIKEOFN KGLNIBCAFHH);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool CMLOHHAJICB();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool LJOMPAPJJKE(string PBIOMAEKCKJ, KPOFJGCMPEC IACGFKEIGHF);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void GKIBOMIFMPC();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool KNNMPKJDDLJ(AppSettings GANOGKFBOIB);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface BLAHDNCBNIM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	HJIIHDANIAM BKOCKKPEBHG
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	[CanBeNull]
	BMPPKEKODHF APLBEEDNPOK
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool MCAFJHLAELO
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool FNNNDPAOBBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool CNOOCFHMKCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	[CanBeNull]
	Exception DJENJFEIMNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	StatusCode MNCNPNLFABL
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event CIMLAIKEOFN.IGMJDBKOPLK BABIGPPKIPB;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<HJIIHDANIAM, HJIIHDANIAM> OKLLJDBFFFB;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PALPFJBHOPA(object KCDBINENHAL);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void LDBJLHFHPAF(object BFHGIPLFIDB);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void OBGMAIBNCKH(byte JFHJBNFICLM, int HLJBHMIHLEB, object LGLMJBOBFOG);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface NFOLOGPLIPC
{
	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event CIMLAIKEOFN.IGMJDBKOPLK BABIGPPKIPB;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event OBGMAIBNCKH GLNIHGHFAAM;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool FEAFAFALEIC(byte JFHJBNFICLM, Hashtable INJALPFHONC, OOIBPFOFLNA LHLBLFDHCJC, SendOptions BHPPHHKOFNK);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface NFPANEKDLDE
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	CMFDBPHCNJN KMOGGEGKNFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int NJNJDHLPMFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	int OMNILGAGHMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool KIIMIIMONHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	int IOPBJIGJLFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action<CMFDBPHCNJN> POIFACACDPB;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "7")]
	[CanBeNull]
	CMFDBPHCNJN MHLLPNAMAKJ(int FBPJACPIKDK);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface NKKIGLOOPOB
{
	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action MELIANLGGOF;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ABOJNLKPBNC();
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface BBFGEEDHNOO : KDJAJLAMBFK, GDOJBJEEDJP, NFOLOGPLIPC, NFPANEKDLDE, NKKIGLOOPOB
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	int KBKFKDAAGLK
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	int PCICMOBDKDG
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	float LMBODPFBJLE
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	float LAGJLFBCNJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool GLPPPGHHBLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	MEFACAIGEAG OBEBJFCDHCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action NAIKFCEDCLB;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void INFKDAPJKOJ();

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EGFHFPMECDJ();

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PKAMLHJLCLP(string OANDAAEKAHO);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface MEFACAIGEAG
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool KEILJLBALKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool JADPKLAFGAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	IReadOnlyList<KBLHIAJGLFP> LBHBADHNMHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NIJMAIAPPNG(Action MNFBKEIPINP, string ONBNNOMHAJB);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class BALCIIMEJMJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public string KMJKFPIAHBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Vector3 LDNPGPEOBDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Quaternion FCDMNAEMCJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Vector3 MNBLMDJFLDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public int JBCEEMJOHNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Dictionary<string, object> PFONHNPCIPF;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x629B0A0", Offset = "0x6299EA0", VA = "0x18629B0A0")]
	public object[] PJKLGMCDIMH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public BALCIIMEJMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class CBIFGIJNMID
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x629B1C0", Offset = "0x6299FC0", VA = "0x18629B1C0")]
	public static bool AHBHPJAHOAI(this KDJAJLAMBFK MLCEOKLAEHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x629B260", Offset = "0x629A060", VA = "0x18629B260")]
	public static bool BHDMJMMAJBC(this KDJAJLAMBFK MLCEOKLAEHJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class GLOFDFEBEIO : BBFGEEDHNOO, KDJAJLAMBFK, GDOJBJEEDJP, NFOLOGPLIPC, NFPANEKDLDE, NKKIGLOOPOB
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private class FCBEHIBJGPL : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly GLOFDFEBEIO BOAGFOBOOMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool COIBHEFKPKD;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x629B4C0", Offset = "0x629A2C0", VA = "0x18629B4C0")]
		public FCBEHIBJGPL(GLOFDFEBEIO BOAGFOBOOMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x629B3C0", Offset = "0x629A1C0", VA = "0x18629B3C0", Slot = "1")]
		~FCBEHIBJGPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x629B330", Offset = "0x629A130", VA = "0x18629B330", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x629B460", Offset = "0x629A260", VA = "0x18629B460")]
		private void PNAHBOFIFIL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly object MNEIBDBLPBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly object DIELCAKECNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private float DEKPDLFAKHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private float OJGGOKFMAAL;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public abstract bool GCKMDFPDKEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public abstract float ICHHLIICJJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "62")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public abstract int KBKFKDAAGLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "63")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public abstract int PCICMOBDKDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public abstract CMFDBPHCNJN KMOGGEGKNFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "65")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int NJNJDHLPMFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x629B5E0", Offset = "0x629A3E0", VA = "0x18629B5E0", Slot = "48")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public abstract int OMNILGAGHMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public abstract int IOPBJIGJLFK
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool KIIMIIMONHH
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x629C950", Offset = "0x629B750", VA = "0x18629C950", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public float LMBODPFBJLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x975D90", Offset = "0x974B90", VA = "0x180975D90", Slot = "74")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x629BA60", Offset = "0x629A860", VA = "0x18629BA60", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public float LAGJLFBCNJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8F3690", Offset = "0x8F2490", VA = "0x1808F3690", Slot = "75")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x629C6D0", Offset = "0x629B4D0", VA = "0x18629C6D0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public abstract bool GLPPPGHHBLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "76")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public abstract MEFACAIGEAG OBEBJFCDHCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "77")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public abstract bool FNGBCMCBMOK
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "80")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public abstract BLAHDNCBNIM GMLDFFJPNCI
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "81")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public abstract bool FNNNDPAOBBK
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "82")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public abstract bool KHGLODEHEOP
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "83")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "84")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public abstract bool ANHAADKCOJE
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "85")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public abstract bool MCAFJHLAELO
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "86")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public abstract IBDPKEJPCGB BDELPBMBOAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "87")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private MJAHGDHMCCG HAMEDCBAIBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7B22C0", Offset = "0x7B10C0", VA = "0x1807B22C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private MJAHGDHMCCG DINDFEEDLIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7B8500", Offset = "0x7B7300", VA = "0x1807B8500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private AAEICIGBGLG<Func<float>> EAGEHHLCJFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7B1EF0", Offset = "0x7B0CF0", VA = "0x1807B1EF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private bool BBNAPHFDGON
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xCE0620", Offset = "0xCDF420", VA = "0x180CE0620")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	protected bool FDHCCIJPAMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x629B9B0", Offset = "0x629A7B0", VA = "0x18629B9B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	protected bool EJMACNBADNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x629BD10", Offset = "0x629AB10", VA = "0x18629BD10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event CIMLAIKEOFN.IGMJDBKOPLK BABIGPPKIPB
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x629B570", Offset = "0x629A370", VA = "0x18629B570", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x629C0E0", Offset = "0x629AEE0", VA = "0x18629C0E0", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	[method: Cpp2IlInjected.Token(Token = "0x600004E")]
	[method: Cpp2IlInjected.Address(Slot = "56")]
	public abstract event OBGMAIBNCKH GLNIHGHFAAM;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	[method: Cpp2IlInjected.Token(Token = "0x6000050")]
	[method: Cpp2IlInjected.Address(Slot = "58")]
	public abstract event Action<CMFDBPHCNJN> POIFACACDPB;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	[method: Cpp2IlInjected.Token(Token = "0x6000068")]
	[method: Cpp2IlInjected.Address(Slot = "78")]
	public abstract event Action<BLAHDNCBNIM, BLAHDNCBNIM> LJDKEOKMFKA;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<bool> GPAKEJOOGDA
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x629C200", Offset = "0x629B000", VA = "0x18629C200", Slot = "31")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x629BF90", Offset = "0x629AD90", VA = "0x18629BF90", Slot = "32")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action NAIKFCEDCLB
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x629C040", Offset = "0x629AE40", VA = "0x18629C040", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x629C9E0", Offset = "0x629B7E0", VA = "0x18629C9E0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action MELIANLGGOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x629C4F0", Offset = "0x629B2F0", VA = "0x18629C4F0", Slot = "53")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x629BEF0", Offset = "0x629ACF0", VA = "0x18629BEF0", Slot = "54")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "68")]
	public abstract CMFDBPHCNJN MHLLPNAMAKJ(int FBPJACPIKDK);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "69")]
	public abstract bool KNNMPKJDDLJ(AppSettings GANOGKFBOIB);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "70")]
	public abstract void GKIBOMIFMPC();

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "71")]
	public abstract bool CMLOHHAJICB();

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "72")]
	public abstract void GGAMNDKOIAN();

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "73")]
	public abstract bool FEAFAFALEIC(byte JFHJBNFICLM, Hashtable INJALPFHONC, OOIBPFOFLNA LHLBLFDHCJC, SendOptions BHPPHHKOFNK);

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "88")]
	public abstract bool LJOMPAPJJKE(string PBIOMAEKCKJ, KPOFJGCMPEC IACGFKEIGHF);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "89")]
	public abstract void PKAMLHJLCLP(string OANDAAEKAHO);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "90")]
	public abstract void IBHFNKFPFOF(CIMLAIKEOFN KGLNIBCAFHH);

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x629CB50", Offset = "0x629B950", VA = "0x18629CB50")]
	protected GLOFDFEBEIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x629C2B0", Offset = "0x629B0B0", VA = "0x18629C2B0")]
	public void HBPIHILNAPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x629B650", Offset = "0x629A450", VA = "0x18629B650", Slot = "35")]
	public void CDCKEMGJPFP(object ADNDMAGEPOK, bool ACBKMGMNLJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x629C850", Offset = "0x629B650", VA = "0x18629C850", Slot = "33")]
	public void NAAMBLGEHON(object ADNDMAGEPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x629CA80", Offset = "0x629B880", VA = "0x18629CA80", Slot = "34")]
	public void NOPDELAODGM(object ADNDMAGEPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x629C770", Offset = "0x629B570", VA = "0x18629C770", Slot = "36")]
	public IDisposable KMHAFNCLOHO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x629C2D0", Offset = "0x629B0D0", VA = "0x18629C2D0", Slot = "91")]
	public virtual bool HMKNDECBCJD(bool FPKEMABOPHM, [Out] string EPIMHJFIPDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x629BD50", Offset = "0x629AB50", VA = "0x18629BD50")]
	private bool FHHLENILBOC([Out] string EPIMHJFIPDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x629CAC0", Offset = "0x629B8C0", VA = "0x18629CAC0")]
	private bool OAHACAPDGOG([Out] string EPIMHJFIPDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x629C800", Offset = "0x629B600", VA = "0x18629C800", Slot = "37")]
	public bool LLPNBKLJDFC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x629BAA0", Offset = "0x629A8A0", VA = "0x18629BAA0", Slot = "38")]
	public void EKCLILAMCIA(StringBuilder PEFJEFMJEDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x629B770", Offset = "0x629A570", VA = "0x18629B770")]
	private void DBCPBODICAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x629B920", Offset = "0x629A720", VA = "0x18629B920")]
	private void DBPLJHLDDHJ(Func<float> OKLJKOMFGLD, object ADNDMAGEPOK, int BLHNHPBIGKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x629C710", Offset = "0x629B510", VA = "0x18629C710", Slot = "92")]
	public void KCGFDPEGOFE(object ADNDMAGEPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x629C640", Offset = "0x629B440", VA = "0x18629C640", Slot = "8")]
	public void INFKDAPJKOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x629BA00", Offset = "0x629A800", VA = "0x18629BA00", Slot = "9")]
	public void EGFHFPMECDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x629C590", Offset = "0x629B390", VA = "0x18629C590")]
	private void IDMJPGMKPFM(float JODGDKECNNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x8F3690", Offset = "0x8F2490", VA = "0x1808F3690")]
	private float PGKBNHPHJLK()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x975D90", Offset = "0x974B90", VA = "0x180975D90")]
	private float MJKHOPKMMAL()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x629C150", Offset = "0x629AF50", VA = "0x18629C150")]
	private void GNFDBJDFCID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x629B520", Offset = "0x629A320", VA = "0x18629B520", Slot = "55")]
	public void ABOJNLKPBNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class KPBGDNNEFPA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public string CCOKAPJOCGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public bool FAPHKJPDFDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected internal bool BCHMLIOGBCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	protected internal int GIFDAFLIPPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	protected internal byte[] HMPDCMGGDOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	protected internal byte BOIALBPLNLJ;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static readonly System.Random FAELCFKDCFG;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x629D620", Offset = "0x629C420", VA = "0x18629D620", Slot = "5")]
	public virtual bool CKGFLPAMPIP(string LOLGIFJAMFA, int AHLCDFAKDLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x629D6C0", Offset = "0x629C4C0", VA = "0x18629D6C0", Slot = "6")]
	public virtual bool LBAIEKAGDBK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x629D670", Offset = "0x629C470", VA = "0x18629D670", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x629D710", Offset = "0x629C510", VA = "0x18629D710")]
	protected internal void LMFMKFLHHJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x629D810", Offset = "0x629C610", VA = "0x18629D810")]
	protected KPBGDNNEFPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class KJAHKKAJBDC : KPBGDNNEFPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private Socket IBPPGNFAEOF;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x629D0B0", Offset = "0x629BEB0", VA = "0x18629D0B0", Slot = "5")]
	public override bool CKGFLPAMPIP(string LOLGIFJAMFA, int AHLCDFAKDLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x629D350", Offset = "0x629C150", VA = "0x18629D350", Slot = "6")]
	public override bool LBAIEKAGDBK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x58B23E0", Offset = "0x58B11E0", VA = "0x1858B23E0", Slot = "7")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x629D540", Offset = "0x629C340", VA = "0x18629D540")]
	public KJAHKKAJBDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class KCAABEDODPK
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public string HFAAHELHFBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7B1BD0", Offset = "0x7B09D0", VA = "0x1807B1BD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7B1BC0", Offset = "0x7B09C0", VA = "0x1807B1BC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string GIJBEKICNAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7B1930", Offset = "0x7B0730", VA = "0x1807B1930")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public string NBFEKPBFBGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7B22D0", Offset = "0x7B10D0", VA = "0x1807B22D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7B1940", Offset = "0x7B0740", VA = "0x1807B1940")]
		[CompilerGenerated]
		protected internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int FIPNELMOHDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7B5040", Offset = "0x7B3E40", VA = "0x1807B5040")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7B4FF0", Offset = "0x7B3DF0", VA = "0x1807B4FF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x629CF90", Offset = "0x629BD90", VA = "0x18629CF90")]
	public KCAABEDODPK(string DEBOKPNAGFI, string IMHFEJALMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x629CCD0", Offset = "0x629BAD0", VA = "0x18629CCD0")]
	private void DOPEIIFGFNK(string JKCAOEDCBJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x629CED0", Offset = "0x629BCD0", VA = "0x18629CED0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x629CDE0", Offset = "0x629BBE0", VA = "0x18629CDE0")]
	public string MNMOLENCOGN(bool AFHNNIEMMDM = false)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class OPFCPJFGNOE
{
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static int PBPONDJOFGJ;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public static bool DDDEKHICDEJ;

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public static int IHLFIDNMKNA;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public static int DPGMOJHHNKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private KCAABEDODPK JPCBPGAEFIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private string HBFMNEFKGHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private int NEDLKFABNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public int JFJLIIJLCGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private Action<KCAABEDODPK> ADEINNFLNIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private KPBGDNNEFPA PLDDININCGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private List<int> PNPHINEDEGA;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool LBAIEKAGDBK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x8F8610", Offset = "0x8F7410", VA = "0x1808F8610")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x9E9A40", Offset = "0x9E8840", VA = "0x1809E9A40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x629E1E0", Offset = "0x629CFE0", VA = "0x18629E1E0")]
	public OPFCPJFGNOE(KCAABEDODPK JPCBPGAEFIA, Action<KCAABEDODPK> AONBFFLECJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x629DC70", Offset = "0x629CA70", VA = "0x18629DC70")]
	public bool FIAKOELMJPA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x629DFE0", Offset = "0x629CDE0", VA = "0x18629DFE0")]
	public static string LPJDANFGFJF(string KMPIGCGNIOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x629E160", Offset = "0x629CF60", VA = "0x18629E160")]
	protected internal void NFPBCHICNDH(object EJDIFPAIGMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x629D9B0", Offset = "0x629C7B0", VA = "0x18629D9B0")]
	protected internal bool DJJKFDLJJBF()
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

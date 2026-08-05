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
public interface FAJONMKLMEP
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<bool> JOILMAIIFFN;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HFPBBOPAGJI(object KJAGMGIFCEM);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FPBOAGPCPGG(object KJAGMGIFCEM);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ABOANEJLHIN(object KJAGMGIFCEM, bool JLDINMBJPKG);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IDisposable EGMBLOKDPDI();

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool GDKJAHPNJGE();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JBMLFCHAPBC(StringBuilder GJAPOCEAGBM);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool EFLACDDKPJG(bool FKCEKAIEIPO, [Out] string GHNPOMJGELJ);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface LHLMJCKPLDG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool OHMAFKDGICH
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	NHFKPAOGFHM HIOIJDDIHGC
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool DCMKPMAFHGN
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool ILIACOFMHNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool FGOMAPLMOGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool KBINIFAGNPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	LDMJAJANBKI DLDAIKDONEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool BJFEPCNKBNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<NHFKPAOGFHM, NHFKPAOGFHM> KFKMNGKMHPE;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CAHMPNOMOFB(EIAKNHLGOIC GLHKMBBOAML);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool JECCICLMKAL();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool BKIAOMFJHCO(string LBGLMHHJHJJ, JOLFKJJOPME GENAHMOEODI);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void AEFMOCBEJCG();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool LLKMIKJGLAH(AppSettings PEKJMJJOJDA);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface NHFKPAOGFHM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	ENDNIBADGNL DJAIKPJFBFF
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	[CanBeNull]
	ELFHKIFMINK OHAPFDLNNFM
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool KBINIFAGNPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool DCMKPMAFHGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool NOFDHONNOAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	[CanBeNull]
	Exception HJCHOOKGMHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	StatusCode INMJHLJPNLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event EIAKNHLGOIC.EOECGNHFPNP HNIFHMMOBAG;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<ENDNIBADGNL, ENDNIBADGNL> CMMICIJEKPE;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PEBKCDHKOFF(object BGICHGONLEL);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void OHJJMCEPLLC(object NHKJAFNPILF);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void KDBNBIIJMHG(byte JILHBFHCFPK, int LGLKDKGOADO, object ACDNJPHPGEB);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface KFODJGABGLO
{
	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event EIAKNHLGOIC.EOECGNHFPNP HNIFHMMOBAG;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event KDBNBIIJMHG AJPHKGPLPOO;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool AKCMIODEIMJ(byte JILHBFHCFPK, Hashtable GJFIAOCHHKA, ICDPKBNMAKD IIAAPHJCFOK, SendOptions HLFCHLOIJKN);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface HLFJMKJJLNH
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	CBOIFHFJJAA PHBDNODNADP
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int FHKDIHIGIOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	int JCNEEGKMDJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool EFNBKJOEKCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	int AJIPEDOHNFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action<CBOIFHFJJAA> JJBHNFPAFGP;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "7")]
	[CanBeNull]
	CBOIFHFJJAA COGLNFOPIFM(int CBNGMOLIGJF);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface PAJIMOEEMKH
{
	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action BOLMMEDDBBA;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CGPOLDLGAGF();
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface MLIGLPPOEFP : LHLMJCKPLDG, FAJONMKLMEP, KFODJGABGLO, HLFJMKJJLNH, PAJIMOEEMKH
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	int IIPCCEGBMJH
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	int NMEBBOLCKHO
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	float JFKOIIGEEPD
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	float PIMPJJIFIFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool JJMJMBNFGDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	IHCDHLEFDCE HIEHNLCBEAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action AICFGNKGJPL;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GMHEHADMLKO();

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BANGJGHPEHO();

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void LBHJDLHDBGN(string BLIDPKJFLOP);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface IHCDHLEFDCE
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool FDLBCNIFDLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool BFFDKOLDFPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	IReadOnlyList<DCFHDFEJPPF> MHICINADKKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MJFHOAKFPKL(Action DPGGHMDCKBF, string CIAMMKNHANA);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class NCBNEKFGEHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public string KHOHKJDBBCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Vector3 AFLOHMGJCHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Quaternion LLPNDHMIBDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Vector3 DGNEJMALDNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public int CLELCGBKEMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Dictionary<string, object> OEMHKDBIJPP;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5CD5350", Offset = "0x5CD4750", VA = "0x185CD5350")]
	public object[] FAICPHOBCGE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public NCBNEKFGEHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class KNGGLNIHIKF
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5CD3A20", Offset = "0x5CD2E20", VA = "0x185CD3A20")]
	public static bool CDBEGAOJHIN(this LHLMJCKPLDG IDABEALKBCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5CD3AC0", Offset = "0x5CD2EC0", VA = "0x185CD3AC0")]
	public static bool IJHHMDAEFAA(this LHLMJCKPLDG IDABEALKBCC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class LPKJGNNMHAL : MLIGLPPOEFP, LHLMJCKPLDG, FAJONMKLMEP, KFODJGABGLO, HLFJMKJJLNH, PAJIMOEEMKH
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private class EFMPOJHGDLI : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly LPKJGNNMHAL LLIMCLKOEIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool EJHKEMCAIJC;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5CD2A60", Offset = "0x5CD1E60", VA = "0x185CD2A60")]
		public EFMPOJHGDLI(LPKJGNNMHAL LLIMCLKOEIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5CD29C0", Offset = "0x5CD1DC0", VA = "0x185CD29C0", Slot = "1")]
		~EFMPOJHGDLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5CD28D0", Offset = "0x5CD1CD0", VA = "0x185CD28D0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5CD2960", Offset = "0x5CD1D60", VA = "0x185CD2960")]
		private void FINNPNBJEED()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly object KBLPABAJBPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly object BNPKDKGJMJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private float PPOPAHPGONM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private float CMLDLMDMFBL;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public abstract bool BJFEPCNKBNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public abstract float OJPOIJOBGFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "62")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public abstract int IIPCCEGBMJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "63")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public abstract int NMEBBOLCKHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public abstract CBOIFHFJJAA PHBDNODNADP
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "65")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int FHKDIHIGIOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5CD3F50", Offset = "0x5CD3350", VA = "0x185CD3F50", Slot = "48")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public abstract int JCNEEGKMDJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public abstract int AJIPEDOHNFA
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool EFNBKJOEKCE
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5CD4E40", Offset = "0x5CD4240", VA = "0x185CD4E40", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public float JFKOIIGEEPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7B1850", Offset = "0x7B0C50", VA = "0x1807B1850", Slot = "74")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5CD45C0", Offset = "0x5CD39C0", VA = "0x185CD45C0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public float PIMPJJIFIFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7B1830", Offset = "0x7B0C30", VA = "0x1807B1830", Slot = "75")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x5CD50C0", Offset = "0x5CD44C0", VA = "0x185CD50C0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public abstract bool JJMJMBNFGDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "76")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public abstract IHCDHLEFDCE HIEHNLCBEAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "77")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public abstract bool OHMAFKDGICH
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "80")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public abstract NHFKPAOGFHM HIOIJDDIHGC
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "81")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public abstract bool DCMKPMAFHGN
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "82")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public abstract bool ILIACOFMHNB
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "83")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "84")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public abstract bool FGOMAPLMOGO
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "85")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public abstract bool KBINIFAGNPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "86")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public abstract LDMJAJANBKI DLDAIKDONEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "87")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private HAMCJNIMIPK FBCLABNHEFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x75C780", Offset = "0x75BB80", VA = "0x18075C780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private HAMCJNIMIPK LGLLGIOHNJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x75C7D0", Offset = "0x75BBD0", VA = "0x18075C7D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private AMFIFBBMHNN<Func<float>> COFFKOAFCEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x75C7E0", Offset = "0x75BBE0", VA = "0x18075C7E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private bool JGIMJJKFEKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xB703B0", Offset = "0xB6F7B0", VA = "0x180B703B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	protected bool MIDGIJOJAON
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x5CD4430", Offset = "0x5CD3830", VA = "0x185CD4430")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	protected bool LGNLCGBFNKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5CD3EC0", Offset = "0x5CD32C0", VA = "0x185CD3EC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event EIAKNHLGOIC.EOECGNHFPNP HNIFHMMOBAG
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5CD5100", Offset = "0x5CD4500", VA = "0x185CD5100", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x5CD3FC0", Offset = "0x5CD33C0", VA = "0x185CD3FC0", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	[method: Cpp2IlInjected.Token(Token = "0x600004E")]
	[method: Cpp2IlInjected.Address(Slot = "56")]
	public abstract event KDBNBIIJMHG AJPHKGPLPOO;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	[method: Cpp2IlInjected.Token(Token = "0x6000050")]
	[method: Cpp2IlInjected.Address(Slot = "58")]
	public abstract event Action<CBOIFHFJJAA> JJBHNFPAFGP;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	[method: Cpp2IlInjected.Token(Token = "0x6000068")]
	[method: Cpp2IlInjected.Address(Slot = "78")]
	public abstract event Action<NHFKPAOGFHM, NHFKPAOGFHM> KFKMNGKMHPE;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<bool> JOILMAIIFFN
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5CD4480", Offset = "0x5CD3880", VA = "0x185CD4480", Slot = "31")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5CD4CF0", Offset = "0x5CD40F0", VA = "0x185CD4CF0", Slot = "32")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action AICFGNKGJPL
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5CD42E0", Offset = "0x5CD36E0", VA = "0x185CD42E0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5CD4F80", Offset = "0x5CD4380", VA = "0x185CD4F80", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action BOLMMEDDBBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x5CD5020", Offset = "0x5CD4420", VA = "0x185CD5020", Slot = "53")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x5CD4DA0", Offset = "0x5CD41A0", VA = "0x185CD4DA0", Slot = "54")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "68")]
	public abstract CBOIFHFJJAA COGLNFOPIFM(int CBNGMOLIGJF);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "69")]
	public abstract bool LLKMIKJGLAH(AppSettings PEKJMJJOJDA);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "70")]
	public abstract void AEFMOCBEJCG();

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "71")]
	public abstract bool JECCICLMKAL();

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "72")]
	public abstract void FNDHDAOBBFF();

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "73")]
	public abstract bool AKCMIODEIMJ(byte JILHBFHCFPK, Hashtable GJFIAOCHHKA, ICDPKBNMAKD IIAAPHJCFOK, SendOptions HLFCHLOIJKN);

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "88")]
	public abstract bool BKIAOMFJHCO(string LBGLMHHJHJJ, JOLFKJJOPME GENAHMOEODI);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "89")]
	public abstract void LBHJDLHDBGN(string BLIDPKJFLOP);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "90")]
	public abstract void CAHMPNOMOFB(EIAKNHLGOIC GLHKMBBOAML);

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5CD51D0", Offset = "0x5CD45D0", VA = "0x185CD51D0")]
	protected LPKJGNNMHAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5CD4380", Offset = "0x5CD3780", VA = "0x185CD4380")]
	public void FGBNJEBGKMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5CD3D40", Offset = "0x5CD3140", VA = "0x185CD3D40", Slot = "35")]
	public void ABOANEJLHIN(object KJAGMGIFCEM, bool JLDINMBJPKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5CD4600", Offset = "0x5CD3A00", VA = "0x185CD4600", Slot = "33")]
	public void HFPBBOPAGJI(object KJAGMGIFCEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5CD43A0", Offset = "0x5CD37A0", VA = "0x185CD43A0", Slot = "34")]
	public void FPBOAGPCPGG(object KJAGMGIFCEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5CD4250", Offset = "0x5CD3650", VA = "0x185CD4250", Slot = "36")]
	public IDisposable EGMBLOKDPDI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5CD4030", Offset = "0x5CD3430", VA = "0x185CD4030", Slot = "91")]
	public virtual bool EFLACDDKPJG(bool FKCEKAIEIPO, [Out] string GHNPOMJGELJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5CD4700", Offset = "0x5CD3B00", VA = "0x185CD4700")]
	private bool IFGCLJKHILP([Out] string GHNPOMJGELJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5CD48A0", Offset = "0x5CD3CA0", VA = "0x185CD48A0")]
	private bool IGHJHPCFCMN([Out] string GHNPOMJGELJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5CD43E0", Offset = "0x5CD37E0", VA = "0x185CD43E0", Slot = "37")]
	public bool GDKJAHPNJGE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5CD4930", Offset = "0x5CD3D30", VA = "0x185CD4930", Slot = "38")]
	public void JBMLFCHAPBC(StringBuilder GJAPOCEAGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5CD3B90", Offset = "0x5CD2F90", VA = "0x185CD3B90")]
	private void AANKMIPINLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5CD4BB0", Offset = "0x5CD3FB0", VA = "0x185CD4BB0")]
	private void KEAMBPPNANO(Func<float> MOAGDDIINBE, object KJAGMGIFCEM, int AAEOMDCOKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5CD5170", Offset = "0x5CD4570", VA = "0x185CD5170", Slot = "92")]
	public void POKHMPKKMIL(object KJAGMGIFCEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5CD4530", Offset = "0x5CD3930", VA = "0x185CD4530", Slot = "8")]
	public void GMHEHADMLKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5CD3E60", Offset = "0x5CD3260", VA = "0x185CD3E60", Slot = "9")]
	public void BANGJGHPEHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5CD4C40", Offset = "0x5CD4040", VA = "0x185CD4C40")]
	private void KEBMHPMLDMC(float LBOMALIMPNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7B1830", Offset = "0x7B0C30", VA = "0x1807B1830")]
	private float LBKHPNFBFED()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7B1850", Offset = "0x7B0C50", VA = "0x1807B1850")]
	private float EGCJABPBLGK()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5CD4ED0", Offset = "0x5CD42D0", VA = "0x185CD4ED0")]
	private void MOEMEKABAGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5CD3F00", Offset = "0x5CD3300", VA = "0x185CD3F00", Slot = "55")]
	public void CGPOLDLGAGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class CFIBFDLEGFD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public string KMEFFABLPDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public bool EKPCAOIJBIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected internal bool MPDEHEGJEBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	protected internal int BPMJEEJCOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	protected internal byte[] LPCLJJMBHCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	protected internal byte JBDMPBAECEC;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static readonly System.Random GICPLAGBFJJ;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5CD2630", Offset = "0x5CD1A30", VA = "0x185CD2630", Slot = "5")]
	public virtual bool BFBJPDNAGKE(string DHNOBALCCKM, int OGAEHODNLPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5CD26D0", Offset = "0x5CD1AD0", VA = "0x185CD26D0", Slot = "6")]
	public virtual bool PCOMMOMKHMM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x5CD2680", Offset = "0x5CD1A80", VA = "0x185CD2680", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5CD2720", Offset = "0x5CD1B20", VA = "0x185CD2720")]
	protected internal void PICNJLOMOKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x5CD2820", Offset = "0x5CD1C20", VA = "0x185CD2820")]
	protected CFIBFDLEGFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class FMEKLAOOAHM : CFIBFDLEGFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private Socket CDFKNMPLAGL;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x5CD2AC0", Offset = "0x5CD1EC0", VA = "0x185CD2AC0", Slot = "5")]
	public override bool BFBJPDNAGKE(string DHNOBALCCKM, int OGAEHODNLPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x5CD2D60", Offset = "0x5CD2160", VA = "0x185CD2D60", Slot = "6")]
	public override bool PCOMMOMKHMM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x53E2920", Offset = "0x53E1D20", VA = "0x1853E2920", Slot = "7")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x5CD2F50", Offset = "0x5CD2350", VA = "0x185CD2F50")]
	public FMEKLAOOAHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class ODEPDLLAECJ
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public string COAGFCLADHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x75C530", Offset = "0x75B930", VA = "0x18075C530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x75C7A0", Offset = "0x75BBA0", VA = "0x18075C7A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string BCOLOPAHNLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x75C540", Offset = "0x75B940", VA = "0x18075C540")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x75C560", Offset = "0x75B960", VA = "0x18075C560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public string IMHCCPKIOLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x764960", Offset = "0x763D60", VA = "0x180764960")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x760A90", Offset = "0x75FE90", VA = "0x180760A90")]
		[CompilerGenerated]
		protected internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int JEPFCEFBLPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x766ED0", Offset = "0x7662D0", VA = "0x180766ED0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x766EB0", Offset = "0x7662B0", VA = "0x180766EB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x5CD5720", Offset = "0x5CD4B20", VA = "0x185CD5720")]
	public ODEPDLLAECJ(string KMFFMLLPDHI, string JDLBGJDPMCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x5CD5460", Offset = "0x5CD4860", VA = "0x185CD5460")]
	private void FHDGJLABPLB(string EIHAKJCIEGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x5CD5660", Offset = "0x5CD4A60", VA = "0x185CD5660", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x5CD5570", Offset = "0x5CD4970", VA = "0x185CD5570")]
	public string NJMLMIPCBEL(bool MMIPOMJBLCB = false)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class JKIHJLPFBPF
{
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static int JHJBMLLGGIO;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public static bool LNCAIFDMGGA;

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public static int MKDNOLPFKNA;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public static int ODPOBDBBMIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private ODEPDLLAECJ MNGEAEBDCEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private string GGJKOCMHIMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private int ENNBPJBIENC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public int CACAFJMNJIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private Action<ODEPDLLAECJ> LFDACFKMHND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private CFIBFDLEGFD JFCOMDDADPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private List<int> HIIEMLADDNB;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool PCOMMOMKHMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7CAC20", Offset = "0x7CA020", VA = "0x1807CAC20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x882360", Offset = "0x881760", VA = "0x180882360")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x5CD3880", Offset = "0x5CD2C80", VA = "0x185CD3880")]
	public JKIHJLPFBPF(ODEPDLLAECJ MNGEAEBDCEH, Action<ODEPDLLAECJ> ANPFBFEEECI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5CD3030", Offset = "0x5CD2430", VA = "0x185CD3030")]
	public bool DOIBKMNMIJN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5CD33A0", Offset = "0x5CD27A0", VA = "0x185CD33A0")]
	public static string FKDOCHAHOAB(string KJKEDBKHKNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5CD37F0", Offset = "0x5CD2BF0", VA = "0x185CD37F0")]
	protected internal void ONCAPGMCCNL(object FJHKACIMEOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5CD3520", Offset = "0x5CD2920", VA = "0x185CD3520")]
	protected internal bool HCLIICELCHG()
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

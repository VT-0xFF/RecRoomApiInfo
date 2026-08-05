using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _AssemblyRegistry.RecRoom_Preferences_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7528DA0", Offset = "0x7527FA0", VA = "0x187528DA0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x23EA930", Offset = "0x23E9B30", VA = "0x1823EA930")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum IIDAMLOCBEC : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	CLOUD,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	DISK
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
internal static class IMNOPKEOJIE
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	internal delegate void KNDFGKONEEJ(OCMNFPBAKFB DBPOHNCHCLG);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7522FF0", Offset = "0x75221F0", VA = "0x187522FF0")]
	private static void JFHBKMEMKJB(OCMNFPBAKFB DBPOHNCHCLG, KNDFGKONEEJ AMPLPBPLKKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7522D40", Offset = "0x7521F40", VA = "0x187522D40")]
	public static bool EDMGHNJMHBH(this OCMNFPBAKFB DBPOHNCHCLG, string LFNMBEJGJCH, [Optional] KNDFGKONEEJ AMPLPBPLKKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7522EA0", Offset = "0x75220A0", VA = "0x187522EA0")]
	public static OACEEIJNHCH EPJKPKHDFBC(this OCMNFPBAKFB DBPOHNCHCLG, string LFNMBEJGJCH, string OMEFCJCOLII, [Optional] KNDFGKONEEJ AMPLPBPLKKE)
	{
		return default(OACEEIJNHCH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7523070", Offset = "0x7522270", VA = "0x187523070")]
	public static OACEEIJNHCH LBJABFDIMPM(this OCMNFPBAKFB DBPOHNCHCLG, string LFNMBEJGJCH, int OMEFCJCOLII, [Optional] KNDFGKONEEJ AMPLPBPLKKE)
	{
		return default(OACEEIJNHCH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7523460", Offset = "0x7522660", VA = "0x187523460")]
	public static OACEEIJNHCH PLPNHKOMHJG(this OCMNFPBAKFB DBPOHNCHCLG, string LFNMBEJGJCH, bool OMEFCJCOLII, [Optional] KNDFGKONEEJ AMPLPBPLKKE)
	{
		return default(OACEEIJNHCH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7522BF0", Offset = "0x7521DF0", VA = "0x187522BF0")]
	public static OACEEIJNHCH BIKKFNMHDID(this OCMNFPBAKFB DBPOHNCHCLG, string LFNMBEJGJCH, float OMEFCJCOLII, [Optional] KNDFGKONEEJ AMPLPBPLKKE)
	{
		return default(OACEEIJNHCH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x75232F0", Offset = "0x75224F0", VA = "0x1875232F0")]
	public static OACEEIJNHCH LMOJDGLDCDB(this OCMNFPBAKFB DBPOHNCHCLG, string LFNMBEJGJCH, DateTime OMEFCJCOLII, [Optional] KNDFGKONEEJ AMPLPBPLKKE)
	{
		return default(OACEEIJNHCH);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x75231B0", Offset = "0x75223B0", VA = "0x1875231B0")]
	public static OACEEIJNHCH LIFJMPCGPCD(this OCMNFPBAKFB DBPOHNCHCLG, string LFNMBEJGJCH, long OMEFCJCOLII, [Optional] KNDFGKONEEJ AMPLPBPLKKE)
	{
		return default(OACEEIJNHCH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class IMBPDEIBLFE : CNFKAHOOGOE, OCMNFPBAKFB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly BFKNDMKFDCL LEECLKNIPAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<string, byte> PKGPGALNOPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private Dictionary<string, string> ECBLPBGCGDO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool EHPNJBGMJGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x90E330", Offset = "0x90D530", VA = "0x18090E330", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Dictionary<string, string> HADBAPDAOGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7522330", Offset = "0x7521530", VA = "0x187522330")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action GKHBAEPKBHI
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7522B50", Offset = "0x7521D50", VA = "0x187522B50")]
	[UnityEngine.Scripting.Preserve]
	public IMBPDEIBLFE([FMJHJHHALCB(null)] BFKNDMKFDCL LEECLKNIPAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "8")]
	public void CKBLCKOFMNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7522800", Offset = "0x7521A00", VA = "0x187522800")]
	private DirectoryInfo LGDLBPPJPBJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7521540", Offset = "0x7520740", VA = "0x187521540", Slot = "6")]
	public Task DFOKPIJINHF(long DGLNJMHHIEM, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7522370", Offset = "0x7521570", VA = "0x187522370", Slot = "14")]
	public float IHAKKLMOBOI(string OFPBICPHALF, float JEBHMGJFPIP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x75214D0", Offset = "0x75206D0", VA = "0x1875214D0", Slot = "13")]
	public void DFMACDJOJLE(string OFPBICPHALF, bool OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7522260", Offset = "0x7521460", VA = "0x187522260", Slot = "12")]
	public bool IBHNDHFLBNB(string OFPBICPHALF, bool JEBHMGJFPIP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x75223E0", Offset = "0x75215E0", VA = "0x1875223E0", Slot = "10")]
	public int IILCNBLILDC(string OFPBICPHALF, int JEBHMGJFPIP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7521460", Offset = "0x7520660", VA = "0x187521460", Slot = "18")]
	public DateTime CNCJDPMEKKD(string LFNMBEJGJCH, [Optional] DateTime JEBHMGJFPIP)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7520FC0", Offset = "0x75201C0", VA = "0x187520FC0", Slot = "19")]
	public void AKNIGAFPGBG(string OFPBICPHALF, DateTime OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7521030", Offset = "0x7520230", VA = "0x187521030", Slot = "15")]
	public void BEOKDFJFPKB(string OFPBICPHALF, float OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7522790", Offset = "0x7521990", VA = "0x187522790", Slot = "11")]
	public void LCFFMDEBDEC(string OFPBICPHALF, int OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x75221F0", Offset = "0x75213F0", VA = "0x1875221F0", Slot = "20")]
	public long IBBKJEEGKGK(string LFNMBEJGJCH, long JEBHMGJFPIP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7522900", Offset = "0x7521B00", VA = "0x187522900", Slot = "21")]
	public void MLPANDBBEJP(string LFNMBEJGJCH, long OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x32B84E0", Offset = "0x32B76E0", VA = "0x1832B84E0", Slot = "22")]
	public T JNCIELIFPIC<T>(string LFNMBEJGJCH, T JEBHMGJFPIP, MHIHOKMIFMB<T> FGBGHFDCFFO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x32B84E0", Offset = "0x32B76E0", VA = "0x1832B84E0", Slot = "23")]
	public void IJLGAOIJGOG<T>(string LFNMBEJGJCH, T OMEFCJCOLII, MHIHOKMIFMB<T> FGBGHFDCFFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x75215D0", Offset = "0x75207D0", VA = "0x1875215D0", Slot = "16")]
	public string EJGAHHNBKMF(string OFPBICPHALF, string JEBHMGJFPIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7521780", Offset = "0x7520980", VA = "0x187521780", Slot = "17")]
	public void HABMLIGDDDD(string OFPBICPHALF, string OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7522970", Offset = "0x7521B70", VA = "0x187522970", Slot = "24")]
	public void MPIEIKIIOOO(string OFPBICPHALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7522AC0", Offset = "0x7521CC0", VA = "0x187522AC0", Slot = "9")]
	public bool PHMALBDLNOI(string OFPBICPHALF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7522450", Offset = "0x7521650", VA = "0x187522450", Slot = "25")]
	public Task KMPOEKLCMGN(CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x75210A0", Offset = "0x75202A0", VA = "0x1875210A0")]
	private void BOBHFJGHFGO(DirectoryInfo CPNOPJAGLMK, string LMGKNHOJGLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x75217F0", Offset = "0x75209F0", VA = "0x1875217F0")]
	private static string HCOGLNKPACM(string OFPBICPHALF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7521680", Offset = "0x7520880", VA = "0x187521680")]
	private static string FBGCLMAGDLI(byte[] JIGDFCPIKCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x32B5E30", Offset = "0x32B5030", VA = "0x1832B5E30")]
	private T BGMHNJIJIDG<T>(string LFNMBEJGJCH, T JEBHMGJFPIP, [Optional] MHIHOKMIFMB<T> BJNIEHGGDLE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x32B7150", Offset = "0x32B6350", VA = "0x1832B7150")]
	private void CEJFMFJKFIE<T>(string LFNMBEJGJCH, T OMEFCJCOLII, [Optional] MHIHOKMIFMB<T> BJNIEHGGDLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x75219F0", Offset = "0x7520BF0", VA = "0x1875219F0")]
	private Dictionary<string, string> HOBALKMOLFL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal static class ELEBICAEIGE
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7520BC0", Offset = "0x751FDC0", VA = "0x187520BC0")]
	[NAOGKPPNIGE.PBOHCEMILCE]
	internal static void BHMHEMCKFJH(JBPONICDCIO CKNPDKKKGFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class NANAMMMFIII : ALGCIOFAJCA
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x75204F0", Offset = "0x751F6F0", VA = "0x1875204F0")]
	[UnityEngine.Scripting.Preserve]
	public NANAMMMFIII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class ALGCIOFAJCA : CNFKAHOOGOE, OCMNFPBAKFB, FGBDNECADLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<string, object> BOIHKBJEDDB;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool EHPNJBGMJGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x90E330", Offset = "0x90D530", VA = "0x18090E330", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action GKHBAEPKBHI
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "8")]
	public void CKBLCKOFMNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7520010", Offset = "0x751F210", VA = "0x187520010", Slot = "6")]
	public Task DFOKPIJINHF(long DGLNJMHHIEM, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7520490", Offset = "0x751F690", VA = "0x187520490", Slot = "9")]
	public bool PHMALBDLNOI(string LFNMBEJGJCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7520280", Offset = "0x751F480", VA = "0x187520280", Slot = "10")]
	public int IILCNBLILDC(string LFNMBEJGJCH, int JEBHMGJFPIP = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7520370", Offset = "0x751F570", VA = "0x187520370", Slot = "11")]
	public void LCFFMDEBDEC(string LFNMBEJGJCH, int OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x75201C0", Offset = "0x751F3C0", VA = "0x1875201C0", Slot = "12")]
	public bool IBHNDHFLBNB(string LFNMBEJGJCH, bool JEBHMGJFPIP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x751FFB0", Offset = "0x751F1B0", VA = "0x18751FFB0", Slot = "13")]
	public void DFMACDJOJLE(string LFNMBEJGJCH, bool OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7520220", Offset = "0x751F420", VA = "0x187520220", Slot = "14")]
	public float IHAKKLMOBOI(string LFNMBEJGJCH, float JEBHMGJFPIP = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x751FEF0", Offset = "0x751F0F0", VA = "0x18751FEF0", Slot = "15")]
	public void BEOKDFJFPKB(string LFNMBEJGJCH, float OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x75200A0", Offset = "0x751F2A0", VA = "0x1875200A0", Slot = "16")]
	public string EJGAHHNBKMF(string LFNMBEJGJCH, [Optional] string JEBHMGJFPIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7520100", Offset = "0x751F300", VA = "0x187520100", Slot = "17")]
	public void HABMLIGDDDD(string LFNMBEJGJCH, string OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x751FF50", Offset = "0x751F150", VA = "0x18751FF50", Slot = "18")]
	public DateTime CNCJDPMEKKD(string LFNMBEJGJCH, [Optional] DateTime JEBHMGJFPIP)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x751FE90", Offset = "0x751F090", VA = "0x18751FE90", Slot = "19")]
	public void AKNIGAFPGBG(string LFNMBEJGJCH, DateTime OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7520160", Offset = "0x751F360", VA = "0x187520160", Slot = "20")]
	public long IBBKJEEGKGK(string LFNMBEJGJCH, long JEBHMGJFPIP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x75203D0", Offset = "0x751F5D0", VA = "0x1875203D0", Slot = "21")]
	public void MLPANDBBEJP(string LFNMBEJGJCH, long OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x39F12B0", Offset = "0x39F04B0", VA = "0x1839F12B0", Slot = "22")]
	public T JNCIELIFPIC<T>(string LFNMBEJGJCH, T JEBHMGJFPIP, MHIHOKMIFMB<T> FGBGHFDCFFO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x39F11D0", Offset = "0x39F03D0", VA = "0x1839F11D0", Slot = "23")]
	public void IJLGAOIJGOG<T>(string LFNMBEJGJCH, T OMEFCJCOLII, MHIHOKMIFMB<T> FGBGHFDCFFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x39F04A0", Offset = "0x39EF6A0", VA = "0x1839F04A0")]
	public T BGMHNJIJIDG<T>(string LFNMBEJGJCH, T JEBHMGJFPIP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x39F0CE0", Offset = "0x39EFEE0", VA = "0x1839F0CE0")]
	public void CEJFMFJKFIE<T>(string LFNMBEJGJCH, T OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7520430", Offset = "0x751F630", VA = "0x187520430", Slot = "24")]
	public void MPIEIKIIOOO(string LFNMBEJGJCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x75202E0", Offset = "0x751F4E0", VA = "0x1875202E0", Slot = "25")]
	public Task KMPOEKLCMGN(CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x75204F0", Offset = "0x751F6F0", VA = "0x1875204F0")]
	public ALGCIOFAJCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public abstract class IBNEHOAKCNH<TParent> where TParent : OCMNFPBAKFB
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly HashSet<IBNEHOAKCNH<TParent>> MNPEIGIJEHK;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x45A9960", Offset = "0x45A8B60", VA = "0x1845A9960")]
	protected IBNEHOAKCNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract void DBGBEIOBMKO();

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void MEHBBABBNIE(string OFPBICPHALF);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x45A93B0", Offset = "0x45A85B0", VA = "0x1845A93B0")]
	public static void GPOMHNGCIJC(string OFPBICPHALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x45A95F0", Offset = "0x45A87F0", VA = "0x1845A95F0")]
	public static void LNHGKNLCNEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class EJGONMKINHB<TParent, TValue> : IBNEHOAKCNH<TParent> where TParent : OCMNFPBAKFB
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly EJGONMKINHB<TParent, TValue> MIAJNEPFAEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, TValue> CFAAABCOBLB;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3F1BFD0", Offset = "0x3F1B1D0", VA = "0x183F1BFD0")]
	public bool EKHOHBPCPIG(string MJJCFLDMEMJ, [Out] TValue OMEGHEHDIOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3F1C030", Offset = "0x3F1B230", VA = "0x183F1C030")]
	public void ELLGODOPKNL(string MJJCFLDMEMJ, TValue OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3F1BF80", Offset = "0x3F1B180", VA = "0x183F1BF80", Slot = "4")]
	protected override void DBGBEIOBMKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x3F1C190", Offset = "0x3F1B390", VA = "0x183F1C190", Slot = "5")]
	protected override void MEHBBABBNIE(string MJJCFLDMEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3F1C320", Offset = "0x3F1B520", VA = "0x183F1C320")]
	public EJGONMKINHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface OCMNFPBAKFB
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool EHPNJBGMJGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CKBLCKOFMNG();

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PHMALBDLNOI(string LFNMBEJGJCH);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int IILCNBLILDC(string LFNMBEJGJCH, int JEBHMGJFPIP = 0);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LCFFMDEBDEC(string LFNMBEJGJCH, int OMEFCJCOLII);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool IBHNDHFLBNB(string LFNMBEJGJCH, bool JEBHMGJFPIP = false);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DFMACDJOJLE(string LFNMBEJGJCH, bool OMEFCJCOLII);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	float IHAKKLMOBOI(string LFNMBEJGJCH, float JEBHMGJFPIP = 0f);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BEOKDFJFPKB(string LFNMBEJGJCH, float OMEFCJCOLII);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	string EJGAHHNBKMF(string LFNMBEJGJCH, [Optional] string JEBHMGJFPIP);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HABMLIGDDDD(string LFNMBEJGJCH, string OMEFCJCOLII);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	DateTime CNCJDPMEKKD(string LFNMBEJGJCH, [Optional] DateTime OKFBKPIJMMN);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void AKNIGAFPGBG(string LFNMBEJGJCH, DateTime OKFBKPIJMMN);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "13")]
	long IBBKJEEGKGK(string LFNMBEJGJCH, long JEBHMGJFPIP);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void MLPANDBBEJP(string LFNMBEJGJCH, long OMEFCJCOLII);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "15")]
	T JNCIELIFPIC<T>(string LFNMBEJGJCH, T JEBHMGJFPIP, MHIHOKMIFMB<T> FGBGHFDCFFO);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void IJLGAOIJGOG<T>(string LFNMBEJGJCH, T OMEFCJCOLII, MHIHOKMIFMB<T> FGBGHFDCFFO);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void MPIEIKIIOOO(string LFNMBEJGJCH);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task KMPOEKLCMGN([Optional] CancellationToken BGEKICMONBE);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface CNFKAHOOGOE : OCMNFPBAKFB
{
	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action GKHBAEPKBHI;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task DFOKPIJINHF(long DGLNJMHHIEM, CancellationToken BGEKICMONBE);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface FGBDNECADLC : OCMNFPBAKFB
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class OFKJJAIMHNB : CNFKAHOOGOE, OCMNFPBAKFB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct JMDHHBIBPKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public OFKJJAIMHNB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x75235A0", Offset = "0x75227A0", VA = "0x1875235A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7523970", Offset = "0x7522B70", VA = "0x187523970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class APELFENFGOI : IEnumerator<IOBGCLDPPJE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private IOBGCLDPPJE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public OFKJJAIMHNB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private IOBGCLDPPJE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8F2CE0", Offset = "0x8F1EE0", VA = "0x1808F2CE0")]
		[DebuggerHidden]
		public APELFENFGOI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7520580", Offset = "0x751F780", VA = "0x187520580", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x75205F0", Offset = "0x751F7F0", VA = "0x1875205F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly BFKNDMKFDCL LEECLKNIPAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool FGIFFCCAHPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private bool AGIOHAAMGLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private FJHAIGEICMN CHHAFMMADAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private GFDHFLBBFKF MLHPLDJBOIH;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool EHPNJBGMJGK
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x90E330", Offset = "0x90D530", VA = "0x18090E330", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action GKHBAEPKBHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x75259F0", Offset = "0x7524BF0", VA = "0x1875259F0")]
	[UnityEngine.Scripting.Preserve]
	public OFKJJAIMHNB([FMJHJHHALCB(null)] BFKNDMKFDCL LEECLKNIPAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "8")]
	public void CKBLCKOFMNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7525430", Offset = "0x7524630", VA = "0x187525430", Slot = "6")]
	public Task DFOKPIJINHF(long DGLNJMHHIEM, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1887830", Offset = "0x1886A30", VA = "0x181887830")]
	private static int JDOGJKFGJBN(bool OMEFCJCOLII)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x75259D0", Offset = "0x7524BD0", VA = "0x1875259D0", Slot = "9")]
	public bool PHMALBDLNOI(string LFNMBEJGJCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7525670", Offset = "0x7524870", VA = "0x187525670", Slot = "10")]
	public int IILCNBLILDC(string LFNMBEJGJCH, int JEBHMGJFPIP = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x75258A0", Offset = "0x7524AA0", VA = "0x1875258A0", Slot = "11")]
	public void LCFFMDEBDEC(string LFNMBEJGJCH, int OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x75255F0", Offset = "0x75247F0", VA = "0x1875255F0", Slot = "12")]
	public bool IBHNDHFLBNB(string LFNMBEJGJCH, bool JEBHMGJFPIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7525400", Offset = "0x7524600", VA = "0x187525400", Slot = "13")]
	public void DFMACDJOJLE(string LFNMBEJGJCH, bool OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7525640", Offset = "0x7524840", VA = "0x187525640", Slot = "14")]
	public float IHAKKLMOBOI(string LFNMBEJGJCH, float JEBHMGJFPIP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x75252F0", Offset = "0x75244F0", VA = "0x1875252F0", Slot = "15")]
	public void BEOKDFJFPKB(string LFNMBEJGJCH, float OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7525390", Offset = "0x7524590", VA = "0x187525390", Slot = "18")]
	public DateTime CNCJDPMEKKD(string LFNMBEJGJCH, [Optional] DateTime JEBHMGJFPIP)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x75251E0", Offset = "0x75243E0", VA = "0x1875251E0", Slot = "19")]
	public void AKNIGAFPGBG(string LFNMBEJGJCH, DateTime OKFBKPIJMMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7525580", Offset = "0x7524780", VA = "0x187525580", Slot = "20")]
	public long IBBKJEEGKGK(string LFNMBEJGJCH, long JEBHMGJFPIP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x75258D0", Offset = "0x7524AD0", VA = "0x1875258D0", Slot = "21")]
	public void MLPANDBBEJP(string LFNMBEJGJCH, long OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3435430", Offset = "0x3434630", VA = "0x183435430", Slot = "22")]
	public T JNCIELIFPIC<T>(string LFNMBEJGJCH, T JEBHMGJFPIP, MHIHOKMIFMB<T> FGBGHFDCFFO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3435430", Offset = "0x3434630", VA = "0x183435430", Slot = "23")]
	public void IJLGAOIJGOG<T>(string LFNMBEJGJCH, T OMEFCJCOLII, MHIHOKMIFMB<T> FGBGHFDCFFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3435730", Offset = "0x3434930", VA = "0x183435730")]
	private T OAGDGMACPHG<T>(string LFNMBEJGJCH, T JEBHMGJFPIP, [Optional] MHIHOKMIFMB<T> BJNIEHGGDLE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3434DA0", Offset = "0x3433FA0", VA = "0x183434DA0")]
	private void HGOGMFAICIF<T>(string LFNMBEJGJCH, T OMEFCJCOLII, [Optional] MHIHOKMIFMB<T> BJNIEHGGDLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7525520", Offset = "0x7524720", VA = "0x187525520", Slot = "16")]
	public string EJGAHHNBKMF(string LFNMBEJGJCH, string JEBHMGJFPIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7525550", Offset = "0x7524750", VA = "0x187525550", Slot = "17")]
	public void HABMLIGDDDD(string LFNMBEJGJCH, string OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x75256A0", Offset = "0x75248A0", VA = "0x1875256A0")]
	private void JHMCLMEIIJJ(string LFNMBEJGJCH, string OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7525620", Offset = "0x7524820", VA = "0x187525620")]
	private string IDFPALDPABI(string LFNMBEJGJCH, string JEBHMGJFPIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7525940", Offset = "0x7524B40", VA = "0x187525940", Slot = "24")]
	public void MPIEIKIIOOO(string LFNMBEJGJCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7525250", Offset = "0x7524450", VA = "0x187525250")]
	private string BACPCGCKFOK(string OFPBICPHALF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7525740", Offset = "0x7524940", VA = "0x187525740", Slot = "25")]
	[AsyncStateMachine(typeof(JMDHHBIBPKH))]
	public Task KMPOEKLCMGN(CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x75256C0", Offset = "0x75248C0", VA = "0x1875256C0")]
	[IteratorStateMachine(typeof(APELFENFGOI))]
	private IEnumerator<IOBGCLDPPJE> KEHALNJGKGL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x75254C0", Offset = "0x75246C0", VA = "0x1875254C0")]
	private void EJAMNPNLAKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7525320", Offset = "0x7524520", VA = "0x187525320")]
	private void BIBPNJCPPDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7525830", Offset = "0x7524A30", VA = "0x187525830")]
	private void KOHODBLJBCJ(bool GDMCFOPLDEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class OBOGLJHHOJO : CNFKAHOOGOE, OCMNFPBAKFB
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private struct KVP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public string k;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public string v;
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private struct KVPs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public KVP[] kvps;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private Dictionary<string, string> ECBLPBGCGDO;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool EHPNJBGMJGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x90E330", Offset = "0x90D530", VA = "0x18090E330", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private string BBANOCKOKLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x75246D0", Offset = "0x75238D0", VA = "0x1875246D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private Dictionary<string, string> HADBAPDAOGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7524C20", Offset = "0x7523E20", VA = "0x187524C20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action GKHBAEPKBHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	[UnityEngine.Scripting.Preserve]
	public OBOGLJHHOJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "8")]
	public void CKBLCKOFMNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7524590", Offset = "0x7523790", VA = "0x187524590", Slot = "6")]
	public Task DFOKPIJINHF(long DGLNJMHHIEM, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7524C60", Offset = "0x7523E60", VA = "0x187524C60", Slot = "14")]
	public float IHAKKLMOBOI(string OFPBICPHALF, float JEBHMGJFPIP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7524520", Offset = "0x7523720", VA = "0x187524520", Slot = "13")]
	public void DFMACDJOJLE(string OFPBICPHALF, bool OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7524B50", Offset = "0x7523D50", VA = "0x187524B50", Slot = "12")]
	public bool IBHNDHFLBNB(string OFPBICPHALF, bool JEBHMGJFPIP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7524CD0", Offset = "0x7523ED0", VA = "0x187524CD0", Slot = "10")]
	public int IILCNBLILDC(string OFPBICPHALF, int JEBHMGJFPIP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x75244B0", Offset = "0x75236B0", VA = "0x1875244B0", Slot = "18")]
	public DateTime CNCJDPMEKKD(string LFNMBEJGJCH, [Optional] DateTime JEBHMGJFPIP)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x75243D0", Offset = "0x75235D0", VA = "0x1875243D0", Slot = "19")]
	public void AKNIGAFPGBG(string OFPBICPHALF, DateTime OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7524440", Offset = "0x7523640", VA = "0x187524440", Slot = "15")]
	public void BEOKDFJFPKB(string OFPBICPHALF, float OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7524FB0", Offset = "0x75241B0", VA = "0x187524FB0", Slot = "11")]
	public void LCFFMDEBDEC(string OFPBICPHALF, int OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7524AE0", Offset = "0x7523CE0", VA = "0x187524AE0", Slot = "20")]
	public long IBBKJEEGKGK(string LFNMBEJGJCH, long JEBHMGJFPIP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7525020", Offset = "0x7524220", VA = "0x187525020", Slot = "21")]
	public void MLPANDBBEJP(string LFNMBEJGJCH, long OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x32B84E0", Offset = "0x32B76E0", VA = "0x1832B84E0", Slot = "22")]
	public T JNCIELIFPIC<T>(string LFNMBEJGJCH, T JEBHMGJFPIP, MHIHOKMIFMB<T> FGBGHFDCFFO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x32B84E0", Offset = "0x32B76E0", VA = "0x1832B84E0", Slot = "23")]
	public void IJLGAOIJGOG<T>(string LFNMBEJGJCH, T OMEFCJCOLII, MHIHOKMIFMB<T> FGBGHFDCFFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7524620", Offset = "0x7523820", VA = "0x187524620", Slot = "16")]
	public string EJGAHHNBKMF(string OFPBICPHALF, string JEBHMGJFPIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7524740", Offset = "0x7523940", VA = "0x187524740", Slot = "17")]
	public void HABMLIGDDDD(string OFPBICPHALF, string OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7525090", Offset = "0x7524290", VA = "0x187525090", Slot = "24")]
	public void MPIEIKIIOOO(string OFPBICPHALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7525150", Offset = "0x7524350", VA = "0x187525150", Slot = "9")]
	public bool PHMALBDLNOI(string OFPBICPHALF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7524D40", Offset = "0x7523F40", VA = "0x187524D40", Slot = "25")]
	public Task KMPOEKLCMGN(CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x34311D0", Offset = "0x34303D0", VA = "0x1834311D0")]
	private T BGMHNJIJIDG<T>(string LFNMBEJGJCH, T JEBHMGJFPIP, [Optional] MHIHOKMIFMB<T> BJNIEHGGDLE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x34324F0", Offset = "0x34316F0", VA = "0x1834324F0")]
	private void CEJFMFJKFIE<T>(string LFNMBEJGJCH, T OMEFCJCOLII, [Optional] MHIHOKMIFMB<T> BJNIEHGGDLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x75247E0", Offset = "0x75239E0", VA = "0x1875247E0")]
	private Dictionary<string, string> HOBALKMOLFL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface OFILAFCHFIJ
{
	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action GKHBAEPKBHI;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CKBLCKOFMNG();

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task EMBKKKLJCPD(long DGLNJMHHIEM);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool GDIDDBJNCAA(IIDAMLOCBEC AKGPEGEMBAI = IIDAMLOCBEC.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool LMNCNDFGIIO(string LFNMBEJGJCH, IIDAMLOCBEC PPDJIGOKLEL = IIDAMLOCBEC.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool KHMGFKPOGBK(string LFNMBEJGJCH, IIDAMLOCBEC PPDJIGOKLEL = IIDAMLOCBEC.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "7")]
	string FBPONOGEJCC(string LFNMBEJGJCH, [Optional] string JEBHMGJFPIP, IIDAMLOCBEC PPDJIGOKLEL = IIDAMLOCBEC.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	OACEEIJNHCH NJKNJGPKDKA(string LFNMBEJGJCH, string OMEFCJCOLII, IIDAMLOCBEC PPDJIGOKLEL = IIDAMLOCBEC.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	int APJMAFDNIOJ(string LFNMBEJGJCH, int JEBHMGJFPIP = 0, IIDAMLOCBEC PPDJIGOKLEL = IIDAMLOCBEC.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	OACEEIJNHCH MOMIKLODAJJ(string LFNMBEJGJCH, int OMEFCJCOLII, IIDAMLOCBEC PPDJIGOKLEL = IIDAMLOCBEC.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool AEANBNEIBMO(string LFNMBEJGJCH, bool JEBHMGJFPIP, IIDAMLOCBEC PPDJIGOKLEL = IIDAMLOCBEC.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "12")]
	OACEEIJNHCH LOFNBANJLIE(string LFNMBEJGJCH, bool OMEFCJCOLII, IIDAMLOCBEC PPDJIGOKLEL = IIDAMLOCBEC.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float FMDCFAHKLGC(string LFNMBEJGJCH, float JEBHMGJFPIP = 0f, IIDAMLOCBEC PPDJIGOKLEL = IIDAMLOCBEC.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "14")]
	OACEEIJNHCH DGENJBNOFEA(string LFNMBEJGJCH, float OMEFCJCOLII, IIDAMLOCBEC PPDJIGOKLEL = IIDAMLOCBEC.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "15")]
	DateTime GAELAPHHMOE(string LFNMBEJGJCH, [Optional] DateTime JEBHMGJFPIP, IIDAMLOCBEC PPDJIGOKLEL = IIDAMLOCBEC.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	OACEEIJNHCH CHODJAAPIKE(string LFNMBEJGJCH, DateTime OMEFCJCOLII, IIDAMLOCBEC PPDJIGOKLEL = IIDAMLOCBEC.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "17")]
	long MACELFOFIDE(string LFNMBEJGJCH, long JEBHMGJFPIP = 0L, IIDAMLOCBEC PPDJIGOKLEL = IIDAMLOCBEC.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "18")]
	OACEEIJNHCH JPEMBJKNOHP(string LFNMBEJGJCH, long OMEFCJCOLII, IIDAMLOCBEC PPDJIGOKLEL = IIDAMLOCBEC.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "19")]
	T COCLKCGALPA<T>(string LFNMBEJGJCH, [Optional] T JEBHMGJFPIP, IIDAMLOCBEC PPDJIGOKLEL = IIDAMLOCBEC.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "20")]
	OACEEIJNHCH FAKDOJGFEHB<T>(string LFNMBEJGJCH, T OMEFCJCOLII, IIDAMLOCBEC PPDJIGOKLEL = IIDAMLOCBEC.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool EFCFGPNBDLA(string LFNMBEJGJCH);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool MEENGJMDDIC(string LFNMBEJGJCH);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "23")]
	string GLIOICBBACM(string LFNMBEJGJCH, [Optional] string JEBHMGJFPIP);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "24")]
	OACEEIJNHCH BDPBMKNFFCC(string LFNMBEJGJCH, string OMEFCJCOLII);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "25")]
	int CEMIOKICAKN(string LFNMBEJGJCH, int JEBHMGJFPIP = 0);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "26")]
	OACEEIJNHCH EBKJMNILJGH(string LFNMBEJGJCH, int OMEFCJCOLII);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool CIODMKMIHEG(string LFNMBEJGJCH, bool JEBHMGJFPIP);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "28")]
	OACEEIJNHCH LNGBGPJCAKK(string LFNMBEJGJCH, bool OMEFCJCOLII);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "29")]
	float NLMCAEGNEBJ(string LFNMBEJGJCH, float JEBHMGJFPIP = 0f);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "30")]
	OACEEIJNHCH BILPJKPMCKF(string LFNMBEJGJCH, float OMEFCJCOLII);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "31")]
	DateTime CPPNDEHIAHD(string LFNMBEJGJCH, [Optional] DateTime JEBHMGJFPIP);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "32")]
	OACEEIJNHCH IOKHFGOHMEI(string LFNMBEJGJCH, DateTime OMEFCJCOLII);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "33")]
	long HELAHFMOJEE(string LFNMBEJGJCH, long JEBHMGJFPIP = 0L);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "34")]
	OACEEIJNHCH KFENLBKGMLA(string LFNMBEJGJCH, long OMEFCJCOLII);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void NGHBKAAHAAD<T>(MHIHOKMIFMB<T> FGBGHFDCFFO, [Optional] IEqualityComparer<T> FHMDPOEGNHH);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void OOOJFNPHJIJ<T>();

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "37")]
	IDisposable FCHINDLOIIB();

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void IIFODAELOMA(float KIPBHBAMJHE);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task EJAMNPNLAKN([Optional] CancellationToken BGEKICMONBE);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum OACEEIJNHCH : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	Unchanged,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	New,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Changed
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class PBPFBOIKIKN : OFILAFCHFIJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private abstract class HEHNOAGGNAD
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		protected static readonly HashSet<HEHNOAGGNAD> PMALBODAEMG;

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x7520D10", Offset = "0x751FF10", VA = "0x187520D10")]
		public static void LNHGKNLCNEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void DBGBEIOBMKO();

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		protected HEHNOAGGNAD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private class DLJPLCONFHM<T> : HEHNOAGGNAD
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly DLJPLCONFHM<T> CLACNPDFIIL;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public MHIHOKMIFMB<T> OCDCLLKELPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x8F4D10", Offset = "0x8F3F10", VA = "0x1808F4D10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x8F54A0", Offset = "0x8F46A0", VA = "0x1808F54A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public IEqualityComparer<T> GJJMBJAABIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x8F7590", Offset = "0x8F6790", VA = "0x1808F7590")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool AAKLAKAMIDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x3ECA8E0", Offset = "0x3EC9AE0", VA = "0x183ECA8E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x6081750", Offset = "0x6080950", VA = "0x186081750")]
		private DLJPLCONFHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x6081360", Offset = "0x6080560", VA = "0x186081360")]
		public void JMFBCAGPLCG(MHIHOKMIFMB<T> BJNIEHGGDLE, [Optional] IEqualityComparer<T> FHMDPOEGNHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x6080F70", Offset = "0x6080170", VA = "0x186080F70", Slot = "4")]
		public override void DBGBEIOBMKO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private class BOLOJOPIJCC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private readonly PBPFBOIKIKN PLBEGLBDMDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly object GBNONJMMLAF;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x7520670", Offset = "0x751F870", VA = "0x187520670")]
		public BOLOJOPIJCC(PBPFBOIKIKN PLBEGLBDMDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x7520640", Offset = "0x751F840", VA = "0x187520640", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct LGDOHFLAMAI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public PBPFBOIKIKN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public long playerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x7523B60", Offset = "0x7522D60", VA = "0x187523B60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7523E40", Offset = "0x7523040", VA = "0x187523E40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct KKHADHFAHFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public PBPFBOIKIKN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public OCMNFPBAKFB backingStoreToSave;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x75239D0", Offset = "0x7522BD0", VA = "0x1875239D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x949E40", Offset = "0x949040", VA = "0x180949E40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private struct MIKFNGCGNHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public PBPFBOIKIKN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x7523EA0", Offset = "0x75230A0", VA = "0x187523EA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7524370", Offset = "0x7523570", VA = "0x187524370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class HMCMBOKKADM : IEnumerator<IOBGCLDPPJE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private IOBGCLDPPJE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public PBPFBOIKIKN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public float seconds;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private IOBGCLDPPJE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x8F2CE0", Offset = "0x8F1EE0", VA = "0x1808F2CE0")]
		[DebuggerHidden]
		public HMCMBOKKADM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7520EE0", Offset = "0x75200E0", VA = "0x187520EE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7520F70", Offset = "0x7520170", VA = "0x187520F70", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly CNFKAHOOGOE HDFKPNEJKGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly CNFKAHOOGOE OKGOAAKJAGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly FGBDNECADLC KAIIJFCOODF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly FJHAIGEICMN CHHAFMMADAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly IMNOPKEOJIE.KNDFGKONEEJ AMPLPBPLKKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly PNEMCEGHFHA NDKFIKAKBGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly HashSet<OCMNFPBAKFB> ICMEKOLHICK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private Task PDOGJLHDLPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private Dictionary<string, string> JBHBBLCMFKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private GFDHFLBBFKF NPLPIOJAOFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly object HMMDDEGPJKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly object PKPEHAINKAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private long MEJAACJFNDB;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private bool LCJJGFDPJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7526CF0", Offset = "0x7525EF0", VA = "0x187526CF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private CancellationTokenSource MOECPPONHNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x8F21D0", Offset = "0x8F13D0", VA = "0x1808F21D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8F21B0", Offset = "0x8F13B0", VA = "0x1808F21B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action GKHBAEPKBHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7528750", Offset = "0x7527950", VA = "0x187528750", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x75287F0", Offset = "0x75279F0", VA = "0x1875287F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x75267B0", Offset = "0x75259B0", VA = "0x1875267B0")]
	[NAOGKPPNIGE.PBOHCEMILCE]
	internal static void EEMNDALIEKO(JBPONICDCIO CKNPDKKKGFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x75288E0", Offset = "0x7527AE0", VA = "0x1875288E0")]
	[UnityEngine.Scripting.Preserve]
	public PBPFBOIKIKN([FMJHJHHALCB("Disk")] CNFKAHOOGOE HDFKPNEJKGD, [FMJHJHHALCB("Cloud")] CNFKAHOOGOE OKGOAAKJAGM, [FMJHJHHALCB(null)] FGBDNECADLC KAIIJFCOODF, [FMJHJHHALCB(null)] FJHAIGEICMN CHHAFMMADAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7526740", Offset = "0x7525940", VA = "0x187526740", Slot = "44")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x7528890", Offset = "0x7527A90", VA = "0x187528890")]
	private void PNPIJBEDGFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7526140", Offset = "0x7525340", VA = "0x187526140", Slot = "6")]
	public void CKBLCKOFMNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7526970", Offset = "0x7525B70", VA = "0x187526970", Slot = "7")]
	public Task EMBKKKLJCPD(long DGLNJMHHIEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x75261B0", Offset = "0x75253B0", VA = "0x1875261B0")]
	[AsyncStateMachine(typeof(LGDOHFLAMAI))]
	private Task CNLIMLPCHGG(long DGLNJMHHIEM, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x7527A60", Offset = "0x7526C60", VA = "0x187527A60")]
	private void KJNIAPNJHIE(object BCOHKLCJCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x7525B90", Offset = "0x7524D90", VA = "0x187525B90")]
	private void AFCJBEGJFFM(object BCOHKLCJCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x7527470", Offset = "0x7526670", VA = "0x187527470")]
	private string JAEHOLBGDPL(string MNHKKEDFIKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x7525C10", Offset = "0x7524E10", VA = "0x187525C10")]
	private void AKGGJAJIMFB(IIDAMLOCBEC AKGPEGEMBAI, string OFPBICPHALF, [Out] CNFKAHOOGOE DBPOHNCHCLG, [Out] string GHPIGHJMPKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x7528590", Offset = "0x7527790", VA = "0x187528590")]
	private CNFKAHOOGOE OBNINAGPNAL(IIDAMLOCBEC AKGPEGEMBAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x7526FC0", Offset = "0x75261C0", VA = "0x187526FC0", Slot = "8")]
	public bool GDIDDBJNCAA(IIDAMLOCBEC AKGPEGEMBAI = IIDAMLOCBEC.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x7527C90", Offset = "0x7526E90", VA = "0x187527C90", Slot = "9")]
	public bool LMNCNDFGIIO(string LFNMBEJGJCH, IIDAMLOCBEC PPDJIGOKLEL = IIDAMLOCBEC.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x7527670", Offset = "0x7526870", VA = "0x187527670", Slot = "10")]
	public bool KHMGFKPOGBK(string LFNMBEJGJCH, IIDAMLOCBEC PPDJIGOKLEL = IIDAMLOCBEC.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x7526B70", Offset = "0x7525D70", VA = "0x187526B70", Slot = "11")]
	public string FBPONOGEJCC(string LFNMBEJGJCH, [Optional] string JEBHMGJFPIP, IIDAMLOCBEC PPDJIGOKLEL = IIDAMLOCBEC.CLOUD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x7528260", Offset = "0x7527460", VA = "0x187528260", Slot = "12")]
	public OACEEIJNHCH NJKNJGPKDKA(string LFNMBEJGJCH, string OMEFCJCOLII, IIDAMLOCBEC PPDJIGOKLEL = IIDAMLOCBEC.CLOUD)
	{
		return default(OACEEIJNHCH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x7525DB0", Offset = "0x7524FB0", VA = "0x187525DB0", Slot = "13")]
	public int APJMAFDNIOJ(string LFNMBEJGJCH, int JEBHMGJFPIP = 0, IIDAMLOCBEC PPDJIGOKLEL = IIDAMLOCBEC.CLOUD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x75280F0", Offset = "0x75272F0", VA = "0x1875280F0", Slot = "14")]
	public OACEEIJNHCH MOMIKLODAJJ(string LFNMBEJGJCH, int OMEFCJCOLII, IIDAMLOCBEC PPDJIGOKLEL = IIDAMLOCBEC.CLOUD)
	{
		return default(OACEEIJNHCH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x7525AE0", Offset = "0x7524CE0", VA = "0x187525AE0", Slot = "15")]
	public bool AEANBNEIBMO(string LFNMBEJGJCH, bool JEBHMGJFPIP, IIDAMLOCBEC PPDJIGOKLEL = IIDAMLOCBEC.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x7527D60", Offset = "0x7526F60", VA = "0x187527D60", Slot = "16")]
	public OACEEIJNHCH LOFNBANJLIE(string LFNMBEJGJCH, bool OMEFCJCOLII, IIDAMLOCBEC PPDJIGOKLEL = IIDAMLOCBEC.CLOUD)
	{
		return default(OACEEIJNHCH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x7526E70", Offset = "0x7526070", VA = "0x187526E70", Slot = "17")]
	public float FMDCFAHKLGC(string LFNMBEJGJCH, float JEBHMGJFPIP = 0f, IIDAMLOCBEC PPDJIGOKLEL = IIDAMLOCBEC.CLOUD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x7526330", Offset = "0x7525530", VA = "0x187526330", Slot = "18")]
	public OACEEIJNHCH DGENJBNOFEA(string LFNMBEJGJCH, float OMEFCJCOLII, IIDAMLOCBEC PPDJIGOKLEL = IIDAMLOCBEC.CLOUD)
	{
		return default(OACEEIJNHCH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x7526F20", Offset = "0x7526120", VA = "0x187526F20", Slot = "19")]
	public DateTime GAELAPHHMOE(string LFNMBEJGJCH, [Optional] DateTime JEBHMGJFPIP, IIDAMLOCBEC PPDJIGOKLEL = IIDAMLOCBEC.CLOUD)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x7525F30", Offset = "0x7525130", VA = "0x187525F30", Slot = "20")]
	public OACEEIJNHCH CHODJAAPIKE(string LFNMBEJGJCH, DateTime OMEFCJCOLII, IIDAMLOCBEC PPDJIGOKLEL = IIDAMLOCBEC.CLOUD)
	{
		return default(OACEEIJNHCH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x7527ED0", Offset = "0x75270D0", VA = "0x187527ED0", Slot = "21")]
	public long MACELFOFIDE(string LFNMBEJGJCH, long JEBHMGJFPIP = 0L, IIDAMLOCBEC PPDJIGOKLEL = IIDAMLOCBEC.CLOUD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x75274D0", Offset = "0x75266D0", VA = "0x1875274D0", Slot = "22")]
	public OACEEIJNHCH JPEMBJKNOHP(string LFNMBEJGJCH, long OMEFCJCOLII, IIDAMLOCBEC PPDJIGOKLEL = IIDAMLOCBEC.CLOUD)
	{
		return default(OACEEIJNHCH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x3456D30", Offset = "0x3455F30", VA = "0x183456D30", Slot = "23")]
	public T COCLKCGALPA<T>(string LFNMBEJGJCH, [Optional] T JEBHMGJFPIP, IIDAMLOCBEC PPDJIGOKLEL = IIDAMLOCBEC.CLOUD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x3456D30", Offset = "0x3455F30", VA = "0x183456D30", Slot = "24")]
	public OACEEIJNHCH FAKDOJGFEHB<T>(string LFNMBEJGJCH, T OMEFCJCOLII, IIDAMLOCBEC PPDJIGOKLEL = IIDAMLOCBEC.CLOUD)
	{
		return default(OACEEIJNHCH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x7526820", Offset = "0x7525A20", VA = "0x187526820", Slot = "25")]
	public bool EFCFGPNBDLA(string LFNMBEJGJCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x7527F70", Offset = "0x7527170", VA = "0x187527F70", Slot = "26")]
	public bool MEENGJMDDIC(string LFNMBEJGJCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x7527080", Offset = "0x7526280", VA = "0x187527080", Slot = "27")]
	public string GLIOICBBACM(string LFNMBEJGJCH, [Optional] string JEBHMGJFPIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x7525E60", Offset = "0x7525060", VA = "0x187525E60", Slot = "28")]
	public OACEEIJNHCH BDPBMKNFFCC(string LFNMBEJGJCH, string OMEFCJCOLII)
	{
		return default(OACEEIJNHCH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x7525EC0", Offset = "0x75250C0", VA = "0x187525EC0", Slot = "29")]
	public int CEMIOKICAKN(string LFNMBEJGJCH, int JEBHMGJFPIP = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x7526780", Offset = "0x7525980", VA = "0x187526780", Slot = "30")]
	public OACEEIJNHCH EBKJMNILJGH(string LFNMBEJGJCH, int OMEFCJCOLII)
	{
		return default(OACEEIJNHCH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x75260D0", Offset = "0x75252D0", VA = "0x1875260D0", Slot = "31")]
	public bool CIODMKMIHEG(string LFNMBEJGJCH, bool JEBHMGJFPIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x7527D30", Offset = "0x7526F30", VA = "0x187527D30", Slot = "32")]
	public OACEEIJNHCH LNGBGPJCAKK(string LFNMBEJGJCH, bool OMEFCJCOLII)
	{
		return default(OACEEIJNHCH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x75283E0", Offset = "0x75275E0", VA = "0x1875283E0", Slot = "33")]
	public float NLMCAEGNEBJ(string LFNMBEJGJCH, float JEBHMGJFPIP = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x7525E90", Offset = "0x7525090", VA = "0x187525E90", Slot = "34")]
	public OACEEIJNHCH BILPJKPMCKF(string LFNMBEJGJCH, float OMEFCJCOLII)
	{
		return default(OACEEIJNHCH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x75262C0", Offset = "0x75254C0", VA = "0x1875262C0", Slot = "35")]
	public DateTime CPPNDEHIAHD(string LFNMBEJGJCH, [Optional] DateTime JEBHMGJFPIP)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x7527440", Offset = "0x7526640", VA = "0x187527440", Slot = "36")]
	public OACEEIJNHCH IOKHFGOHMEI(string LFNMBEJGJCH, DateTime OMEFCJCOLII)
	{
		return default(OACEEIJNHCH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x75270F0", Offset = "0x75262F0", VA = "0x1875270F0", Slot = "37")]
	public long HELAHFMOJEE(string LFNMBEJGJCH, long JEBHMGJFPIP = 0L)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x7527640", Offset = "0x7526840", VA = "0x187527640", Slot = "38")]
	public OACEEIJNHCH KFENLBKGMLA(string LFNMBEJGJCH, long OMEFCJCOLII)
	{
		return default(OACEEIJNHCH);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x75271F0", Offset = "0x75263F0", VA = "0x1875271F0")]
	private bool IGOHBNDNAEP(OCMNFPBAKFB DBPOHNCHCLG, string LFNMBEJGJCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7526D10", Offset = "0x7525F10", VA = "0x187526D10")]
	private bool FKFNFMKPIAK(OCMNFPBAKFB DBPOHNCHCLG, string LFNMBEJGJCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x75265F0", Offset = "0x75257F0", VA = "0x1875265F0")]
	private OACEEIJNHCH DPGBHHCMMPO(OCMNFPBAKFB DBPOHNCHCLG, string LFNMBEJGJCH, string OMEFCJCOLII)
	{
		return default(OACEEIJNHCH);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7527B50", Offset = "0x7526D50", VA = "0x187527B50")]
	private OACEEIJNHCH KPIHABOFEOM(OCMNFPBAKFB DBPOHNCHCLG, string LFNMBEJGJCH, int OMEFCJCOLII)
	{
		return default(OACEEIJNHCH);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x7528610", Offset = "0x7527810", VA = "0x187528610")]
	private OACEEIJNHCH OMFNEBHBACE(OCMNFPBAKFB DBPOHNCHCLG, string LFNMBEJGJCH, bool OMEFCJCOLII)
	{
		return default(OACEEIJNHCH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x7528450", Offset = "0x7527650", VA = "0x187528450")]
	private OACEEIJNHCH OBLHALMEJOO(OCMNFPBAKFB DBPOHNCHCLG, string LFNMBEJGJCH, float OMEFCJCOLII)
	{
		return default(OACEEIJNHCH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x7527F80", Offset = "0x7527180", VA = "0x187527F80")]
	private OACEEIJNHCH MKHKBAGENDJ(OCMNFPBAKFB DBPOHNCHCLG, string LFNMBEJGJCH, DateTime OMEFCJCOLII)
	{
		return default(OACEEIJNHCH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x75264B0", Offset = "0x75256B0", VA = "0x1875264B0")]
	private OACEEIJNHCH DKMJPBDPLMA(OCMNFPBAKFB DBPOHNCHCLG, string LFNMBEJGJCH, long OMEFCJCOLII)
	{
		return default(OACEEIJNHCH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x34567C0", Offset = "0x34559C0", VA = "0x1834567C0")]
	private T BAFMJPFADHJ<T>(OCMNFPBAKFB DBPOHNCHCLG, string LFNMBEJGJCH, T JEBHMGJFPIP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x34571C0", Offset = "0x34563C0", VA = "0x1834571C0")]
	private OACEEIJNHCH PLLNHGGEPOK<T>(OCMNFPBAKFB DBPOHNCHCLG, string LFNMBEJGJCH, T OMEFCJCOLII)
	{
		return default(OACEEIJNHCH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3457090", Offset = "0x3456290", VA = "0x183457090", Slot = "39")]
	public void NGHBKAAHAAD<T>(MHIHOKMIFMB<T> FGBGHFDCFFO, [Optional] IEqualityComparer<T> FHMDPOEGNHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3457140", Offset = "0x3456340", VA = "0x183457140", Slot = "40")]
	public void OOOJFNPHJIJ<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x7527A80", Offset = "0x7526C80", VA = "0x187527A80")]
	[AsyncStateMachine(typeof(KKHADHFAHFB))]
	private void KMPOEKLCMGN(OCMNFPBAKFB PPJHNELMNGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x7526880", Offset = "0x7525A80", VA = "0x187526880", Slot = "43")]
	[AsyncStateMachine(typeof(MIKFNGCGNHG))]
	public Task EJAMNPNLAKN([Optional] CancellationToken BCOHKLCJCPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x7527260", Offset = "0x7526460", VA = "0x187527260")]
	private void IMEJEGAKABG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x7526C10", Offset = "0x7525E10", VA = "0x187526C10", Slot = "41")]
	public IDisposable FCHINDLOIIB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x7527250", Offset = "0x7526450", VA = "0x187527250", Slot = "42")]
	public void IIFODAELOMA(float KIPBHBAMJHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x75277F0", Offset = "0x75269F0", VA = "0x1875277F0")]
	private void KJJKBICKCHI(float JNNEFFFCPGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x7527160", Offset = "0x7526360", VA = "0x187527160")]
	[IteratorStateMachine(typeof(HMCMBOKKADM))]
	private IEnumerator<IOBGCLDPPJE> HFNGEPGIDOK(float KIPBHBAMJHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x7526B40", Offset = "0x7525D40", VA = "0x187526B40")]
	[CompilerGenerated]
	private void EMIOJHNGNCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class CKBFGHJMDFJ : LELIAKDGOEM<bool>
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static CKBFGHJMDFJ CLACNPDFIIL
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x7520720", Offset = "0x751F920", VA = "0x187520720")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x7520770", Offset = "0x751F970", VA = "0x187520770", Slot = "9")]
	public override string LKDLAIOBOFF(bool DFKGLBJBJGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7520860", Offset = "0x751FA60", VA = "0x187520860", Slot = "10")]
	protected override bool OIOJOJAMPKC(string DFKGLBJBJGD, [Out] bool OMEFCJCOLII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x7520B80", Offset = "0x751FD80", VA = "0x187520B80")]
	public CKBFGHJMDFJ()
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

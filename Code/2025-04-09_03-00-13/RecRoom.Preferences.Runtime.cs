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
		[Cpp2IlInjected.Address(RVA = "0x7C3F140", Offset = "0x7C3E540", VA = "0x187C3F140", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2553680", Offset = "0x2552A80", VA = "0x182553680")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum LEPKAGCLFJO : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	CLOUD,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	DISK
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
internal static class GDFFPAJAJGP
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	internal delegate void JPEMLKEPGBP(CEGEOIFFONJ AFKMCGKFGFH);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7C392D0", Offset = "0x7C386D0", VA = "0x187C392D0")]
	private static void LPEBBNCLBPF(CEGEOIFFONJ AFKMCGKFGFH, JPEMLKEPGBP FNOABCJJLOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7C38DA0", Offset = "0x7C381A0", VA = "0x187C38DA0")]
	public static bool CCHCEOIBBAG(this CEGEOIFFONJ AFKMCGKFGFH, string MOIADMOIDPH, [Optional] JPEMLKEPGBP FNOABCJJLOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7C39040", Offset = "0x7C38440", VA = "0x187C39040")]
	public static IIBMKOKAGAB FHDOEHMJPAK(this CEGEOIFFONJ AFKMCGKFGFH, string MOIADMOIDPH, string FFOEEMKIKJO, [Optional] JPEMLKEPGBP FNOABCJJLOG)
	{
		return default(IIBMKOKAGAB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7C394C0", Offset = "0x7C388C0", VA = "0x187C394C0")]
	public static IIBMKOKAGAB NEHDDCPAKHK(this CEGEOIFFONJ AFKMCGKFGFH, string MOIADMOIDPH, int FFOEEMKIKJO, [Optional] JPEMLKEPGBP FNOABCJJLOG)
	{
		return default(IIBMKOKAGAB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7C39190", Offset = "0x7C38590", VA = "0x187C39190")]
	public static IIBMKOKAGAB HKHCCLJCABJ(this CEGEOIFFONJ AFKMCGKFGFH, string MOIADMOIDPH, bool FFOEEMKIKJO, [Optional] JPEMLKEPGBP FNOABCJJLOG)
	{
		return default(IIBMKOKAGAB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7C38C50", Offset = "0x7C38050", VA = "0x187C38C50")]
	public static IIBMKOKAGAB BEGFIALGGLJ(this CEGEOIFFONJ AFKMCGKFGFH, string MOIADMOIDPH, float FFOEEMKIKJO, [Optional] JPEMLKEPGBP FNOABCJJLOG)
	{
		return default(IIBMKOKAGAB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7C39350", Offset = "0x7C38750", VA = "0x187C39350")]
	public static IIBMKOKAGAB MMGIACGOOML(this CEGEOIFFONJ AFKMCGKFGFH, string MOIADMOIDPH, DateTime FFOEEMKIKJO, [Optional] JPEMLKEPGBP FNOABCJJLOG)
	{
		return default(IIBMKOKAGAB);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7C38F00", Offset = "0x7C38300", VA = "0x187C38F00")]
	public static IIBMKOKAGAB CLMLLEELFDN(this CEGEOIFFONJ AFKMCGKFGFH, string MOIADMOIDPH, long FFOEEMKIKJO, [Optional] JPEMLKEPGBP FNOABCJJLOG)
	{
		return default(IIBMKOKAGAB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class ADJLBMFENDK : PMFDHIMKODI, CEGEOIFFONJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly HFGFHCFDKKH PKFKPOLIFAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<string, byte> KJBOBKHAHMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private Dictionary<string, string> KHMDEBPOBOM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool LCONPCPHNJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9C55F0", Offset = "0x9C49F0", VA = "0x1809C55F0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Dictionary<string, string> MKAHBDKBFJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7C36CB0", Offset = "0x7C360B0", VA = "0x187C36CB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action NGKGBBCBGCK
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7C37DB0", Offset = "0x7C371B0", VA = "0x187C37DB0")]
	[UnityEngine.Scripting.Preserve]
	public ADJLBMFENDK([CMKKAFOAFJE(null)] HFGFHCFDKKH PKFKPOLIFAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "8")]
	public void OLFBOBOMKCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7C37A60", Offset = "0x7C36E60", VA = "0x187C37A60")]
	private DirectoryInfo NMPGPDJMPLG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7C36CF0", Offset = "0x7C360F0", VA = "0x187C36CF0", Slot = "6")]
	public Task KHFNEFMDEEM(long LOLGHOBDHCK, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7C36550", Offset = "0x7C35950", VA = "0x187C36550", Slot = "14")]
	public float DFBHFAHGHPN(string DJBLFBEBKGO, float PFCPDJEHNAP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7C36BD0", Offset = "0x7C35FD0", VA = "0x187C36BD0", Slot = "13")]
	public void IMKFLPBFDEE(string DJBLFBEBKGO, bool FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7C36A10", Offset = "0x7C35E10", VA = "0x187C36A10", Slot = "12")]
	public bool GIAMNCBLEDP(string DJBLFBEBKGO, bool PFCPDJEHNAP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7C369A0", Offset = "0x7C35DA0", VA = "0x187C369A0", Slot = "10")]
	public int DNJNEOGELJI(string DJBLFBEBKGO, int PFCPDJEHNAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7C37980", Offset = "0x7C36D80", VA = "0x187C37980", Slot = "18")]
	public DateTime MOCMCLIDAPJ(string MOIADMOIDPH, [Optional] DateTime PFCPDJEHNAP)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7C36D80", Offset = "0x7C36180", VA = "0x187C36D80", Slot = "19")]
	public void KKFKBEPKKDL(string DJBLFBEBKGO, DateTime FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7C362E0", Offset = "0x7C356E0", VA = "0x187C362E0", Slot = "15")]
	public void BGOGJILAOCC(string DJBLFBEBKGO, float FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7C36B60", Offset = "0x7C35F60", VA = "0x187C36B60", Slot = "11")]
	public void IKHCPDILACG(string DJBLFBEBKGO, int FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7C36270", Offset = "0x7C35670", VA = "0x187C36270", Slot = "20")]
	public long ADCKBBHNCLF(string MOIADMOIDPH, long PFCPDJEHNAP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7C36C40", Offset = "0x7C36040", VA = "0x187C36C40", Slot = "21")]
	public void JIEMLAPANOF(string MOIADMOIDPH, long FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3657EE0", Offset = "0x36572E0", VA = "0x183657EE0", Slot = "22")]
	public T BDGODDKBPAL<T>(string MOIADMOIDPH, T PFCPDJEHNAP, HIHPOAELMHI<T> GCFHFJLLJMB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3657EE0", Offset = "0x36572E0", VA = "0x183657EE0", Slot = "23")]
	public void ILLCNANECFM<T>(string MOIADMOIDPH, T FFOEEMKIKJO, HIHPOAELMHI<T> GCFHFJLLJMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7C368F0", Offset = "0x7C35CF0", VA = "0x187C368F0", Slot = "16")]
	public string DKIEJMKIMKH(string DJBLFBEBKGO, string PFCPDJEHNAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7C379F0", Offset = "0x7C36DF0", VA = "0x187C379F0", Slot = "17")]
	public void NILBOHABJJC(string DJBLFBEBKGO, string FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7C37B60", Offset = "0x7C36F60", VA = "0x187C37B60", Slot = "24")]
	public void PCHINIFAOEB(string DJBLFBEBKGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7C36AD0", Offset = "0x7C35ED0", VA = "0x187C36AD0", Slot = "9")]
	public bool HDDDFKIEMIJ(string DJBLFBEBKGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7C365C0", Offset = "0x7C359C0", VA = "0x187C365C0", Slot = "25")]
	public Task DIKEMKPABJI(CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7C36DF0", Offset = "0x7C361F0", VA = "0x187C36DF0")]
	private void LJPHFIOEOPP(DirectoryInfo PHJHDLDHNKH, string LGBGIKHCLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7C36350", Offset = "0x7C35750", VA = "0x187C36350")]
	private static string BHOJKLHGAPG(string DJBLFBEBKGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7C37CB0", Offset = "0x7C370B0", VA = "0x187C37CB0")]
	private static string PNBHILPADIJ(byte[] DHHEGLJJIIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3D83CD0", Offset = "0x3D830D0", VA = "0x183D83CD0")]
	private T IOLMGDEDCOJ<T>(string MOIADMOIDPH, T PFCPDJEHNAP, [Optional] HIHPOAELMHI<T> BPKFDKFLGKL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3D84FC0", Offset = "0x3D843C0", VA = "0x183D84FC0")]
	private void JFGGMENNDNP<T>(string MOIADMOIDPH, T FFOEEMKIKJO, [Optional] HIHPOAELMHI<T> BPKFDKFLGKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7C371B0", Offset = "0x7C365B0", VA = "0x187C371B0")]
	private Dictionary<string, string> LMOJJLNKHFI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal static class FOCKBGPJHOD
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7C38B00", Offset = "0x7C37F00", VA = "0x187C38B00")]
	[NOCPMGCIOME.CBODKAAMPCM]
	internal static void FJKHLPMEJLC(DHLGDCALOEP NKMJDOBLHGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class MGKCHCLHJGP : FAEPMNGELEP
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7C38A70", Offset = "0x7C37E70", VA = "0x187C38A70")]
	[UnityEngine.Scripting.Preserve]
	public MGKCHCLHJGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class FAEPMNGELEP : PMFDHIMKODI, CEGEOIFFONJ, EEHPELLNMMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<string, object> LHGGNAMPONG;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool LCONPCPHNJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9C55F0", Offset = "0x9C49F0", VA = "0x1809C55F0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action NGKGBBCBGCK
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "8")]
	public void OLFBOBOMKCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7C38860", Offset = "0x7C37C60", VA = "0x187C38860", Slot = "6")]
	public Task KHFNEFMDEEM(long LOLGHOBDHCK, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7C386E0", Offset = "0x7C37AE0", VA = "0x187C386E0", Slot = "9")]
	public bool HDDDFKIEMIJ(string MOIADMOIDPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7C38620", Offset = "0x7C37A20", VA = "0x187C38620", Slot = "10")]
	public int DNJNEOGELJI(string MOIADMOIDPH, int PFCPDJEHNAP = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7C38740", Offset = "0x7C37B40", VA = "0x187C38740", Slot = "11")]
	public void IKHCPDILACG(string MOIADMOIDPH, int FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7C38680", Offset = "0x7C37A80", VA = "0x187C38680", Slot = "12")]
	public bool GIAMNCBLEDP(string MOIADMOIDPH, bool PFCPDJEHNAP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7C387A0", Offset = "0x7C37BA0", VA = "0x187C387A0", Slot = "13")]
	public void IMKFLPBFDEE(string MOIADMOIDPH, bool FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7C384D0", Offset = "0x7C378D0", VA = "0x187C384D0", Slot = "14")]
	public float DFBHFAHGHPN(string MOIADMOIDPH, float PFCPDJEHNAP = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7C38470", Offset = "0x7C37870", VA = "0x187C38470", Slot = "15")]
	public void BGOGJILAOCC(string MOIADMOIDPH, float FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7C385C0", Offset = "0x7C379C0", VA = "0x187C385C0", Slot = "16")]
	public string DKIEJMKIMKH(string MOIADMOIDPH, [Optional] string PFCPDJEHNAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7C389B0", Offset = "0x7C37DB0", VA = "0x187C389B0", Slot = "17")]
	public void NILBOHABJJC(string MOIADMOIDPH, string FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7C38950", Offset = "0x7C37D50", VA = "0x187C38950", Slot = "18")]
	public DateTime MOCMCLIDAPJ(string MOIADMOIDPH, [Optional] DateTime PFCPDJEHNAP)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7C388F0", Offset = "0x7C37CF0", VA = "0x187C388F0", Slot = "19")]
	public void KKFKBEPKKDL(string MOIADMOIDPH, DateTime FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7C38410", Offset = "0x7C37810", VA = "0x187C38410", Slot = "20")]
	public long ADCKBBHNCLF(string MOIADMOIDPH, long PFCPDJEHNAP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7C38800", Offset = "0x7C37C00", VA = "0x187C38800", Slot = "21")]
	public void JIEMLAPANOF(string MOIADMOIDPH, long FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x35D1510", Offset = "0x35D0910", VA = "0x1835D1510", Slot = "22")]
	public T BDGODDKBPAL<T>(string MOIADMOIDPH, T PFCPDJEHNAP, HIHPOAELMHI<T> GCFHFJLLJMB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x35D1630", Offset = "0x35D0A30", VA = "0x1835D1630", Slot = "23")]
	public void ILLCNANECFM<T>(string MOIADMOIDPH, T FFOEEMKIKJO, HIHPOAELMHI<T> GCFHFJLLJMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x35D1710", Offset = "0x35D0B10", VA = "0x1835D1710")]
	public T IOLMGDEDCOJ<T>(string MOIADMOIDPH, T PFCPDJEHNAP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x35D1F50", Offset = "0x35D1350", VA = "0x1835D1F50")]
	public void JFGGMENNDNP<T>(string MOIADMOIDPH, T FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7C38A10", Offset = "0x7C37E10", VA = "0x187C38A10", Slot = "24")]
	public void PCHINIFAOEB(string MOIADMOIDPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7C38530", Offset = "0x7C37930", VA = "0x187C38530", Slot = "25")]
	public Task DIKEMKPABJI(CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7C38A70", Offset = "0x7C37E70", VA = "0x187C38A70")]
	public FAEPMNGELEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public abstract class PFODIKLHPBI<TParent> where TParent : CEGEOIFFONJ
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly HashSet<PFODIKLHPBI<TParent>> BAPCNPNCELK;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x530C6E0", Offset = "0x530BAE0", VA = "0x18530C6E0")]
	protected PFODIKLHPBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract void CJEMNCEDADJ();

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void OFOHCJCNIAM(string DJBLFBEBKGO);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x530C370", Offset = "0x530B770", VA = "0x18530C370")]
	public static void OGLHCNJGFCK(string DJBLFBEBKGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x530C140", Offset = "0x530B540", VA = "0x18530C140")]
	public static void LBDCHDFHHFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class LJJLAPNIGAH<TParent, TValue> : PFODIKLHPBI<TParent> where TParent : CEGEOIFFONJ
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly LJJLAPNIGAH<TParent, TValue> AMGMCPILGIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, TValue> DFCPINLLCPL;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4E6A8A0", Offset = "0x4E69CA0", VA = "0x184E6A8A0")]
	public bool BGPIDOLLEKE(string IMDENDBDIKN, [Out] TValue HAANLGCBGAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4E6A900", Offset = "0x4E69D00", VA = "0x184E6A900")]
	public void HDEAGEPCNCJ(string IMDENDBDIKN, TValue FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4A1A920", Offset = "0x4A19D20", VA = "0x184A1A920", Slot = "4")]
	protected override void CJEMNCEDADJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x49E1AC0", Offset = "0x49E0EC0", VA = "0x1849E1AC0", Slot = "5")]
	protected override void OFOHCJCNIAM(string IMDENDBDIKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x4E6AB90", Offset = "0x4E69F90", VA = "0x184E6AB90")]
	public LJJLAPNIGAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface CEGEOIFFONJ
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool LCONPCPHNJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OLFBOBOMKCA();

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HDDDFKIEMIJ(string MOIADMOIDPH);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int DNJNEOGELJI(string MOIADMOIDPH, int PFCPDJEHNAP = 0);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IKHCPDILACG(string MOIADMOIDPH, int FFOEEMKIKJO);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool GIAMNCBLEDP(string MOIADMOIDPH, bool PFCPDJEHNAP = false);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IMKFLPBFDEE(string MOIADMOIDPH, bool FFOEEMKIKJO);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	float DFBHFAHGHPN(string MOIADMOIDPH, float PFCPDJEHNAP = 0f);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BGOGJILAOCC(string MOIADMOIDPH, float FFOEEMKIKJO);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	string DKIEJMKIMKH(string MOIADMOIDPH, [Optional] string PFCPDJEHNAP);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NILBOHABJJC(string MOIADMOIDPH, string FFOEEMKIKJO);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	DateTime MOCMCLIDAPJ(string MOIADMOIDPH, [Optional] DateTime HAJIKKBJGLF);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void KKFKBEPKKDL(string MOIADMOIDPH, DateTime HAJIKKBJGLF);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "13")]
	long ADCKBBHNCLF(string MOIADMOIDPH, long PFCPDJEHNAP);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void JIEMLAPANOF(string MOIADMOIDPH, long FFOEEMKIKJO);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "15")]
	T BDGODDKBPAL<T>(string MOIADMOIDPH, T PFCPDJEHNAP, HIHPOAELMHI<T> GCFHFJLLJMB);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void ILLCNANECFM<T>(string MOIADMOIDPH, T FFOEEMKIKJO, HIHPOAELMHI<T> GCFHFJLLJMB);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void PCHINIFAOEB(string MOIADMOIDPH);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task DIKEMKPABJI([Optional] CancellationToken LMNHDKIFBOH);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface PMFDHIMKODI : CEGEOIFFONJ
{
	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action NGKGBBCBGCK;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task KHFNEFMDEEM(long LOLGHOBDHCK, CancellationToken LMNHDKIFBOH);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface EEHPELLNMMG : CEGEOIFFONJ
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class IIGDANFDKCC : PMFDHIMKODI, CEGEOIFFONJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct LKOAFENPAJD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public IIGDANFDKCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7C39F00", Offset = "0x7C39300", VA = "0x187C39F00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7C3A2E0", Offset = "0x7C396E0", VA = "0x187C3A2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class CDHFJKEBCBN : IEnumerator<CIKDDGFOAFI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private CIKDDGFOAFI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public IIGDANFDKCC <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private CIKDDGFOAFI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x9AFBB0", Offset = "0x9AEFB0", VA = "0x1809AFBB0")]
		[DebuggerHidden]
		public CDHFJKEBCBN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7C37F30", Offset = "0x7C37330", VA = "0x187C37F30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7C37FA0", Offset = "0x7C373A0", VA = "0x187C37FA0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly HFGFHCFDKKH PKFKPOLIFAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool DIIMKLCPJKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private bool MIPLKOFKGKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private OKJPOJGEILK AAECGIEPKCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private LBKCJDEOHAA CCNEDPONBDE;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool LCONPCPHNJM
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x9C55F0", Offset = "0x9C49F0", VA = "0x1809C55F0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action NGKGBBCBGCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7C39E10", Offset = "0x7C39210", VA = "0x187C39E10")]
	[UnityEngine.Scripting.Preserve]
	public IIGDANFDKCC([CMKKAFOAFJE(null)] HFGFHCFDKKH PKFKPOLIFAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "8")]
	public void OLFBOBOMKCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7C39B60", Offset = "0x7C38F60", VA = "0x187C39B60", Slot = "6")]
	public Task KHFNEFMDEEM(long LOLGHOBDHCK, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x19D98B0", Offset = "0x19D8CB0", VA = "0x1819D98B0")]
	private static int FLIGDGLOMKA(bool FFOEEMKIKJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7C39950", Offset = "0x7C38D50", VA = "0x187C39950", Slot = "9")]
	public bool HDDDFKIEMIJ(string MOIADMOIDPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7C39880", Offset = "0x7C38C80", VA = "0x187C39880", Slot = "10")]
	public int DNJNEOGELJI(string MOIADMOIDPH, int PFCPDJEHNAP = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7C39A10", Offset = "0x7C38E10", VA = "0x187C39A10", Slot = "11")]
	public void IKHCPDILACG(string MOIADMOIDPH, int FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7C39920", Offset = "0x7C38D20", VA = "0x187C39920", Slot = "12")]
	public bool GIAMNCBLEDP(string MOIADMOIDPH, bool PFCPDJEHNAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7C39A40", Offset = "0x7C38E40", VA = "0x187C39A40", Slot = "13")]
	public void IMKFLPBFDEE(string MOIADMOIDPH, bool FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7C39730", Offset = "0x7C38B30", VA = "0x187C39730", Slot = "14")]
	public float DFBHFAHGHPN(string MOIADMOIDPH, float PFCPDJEHNAP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7C396E0", Offset = "0x7C38AE0", VA = "0x187C396E0", Slot = "15")]
	public void BGOGJILAOCC(string MOIADMOIDPH, float FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7C39C80", Offset = "0x7C39080", VA = "0x187C39C80", Slot = "18")]
	public DateTime MOCMCLIDAPJ(string MOIADMOIDPH, [Optional] DateTime PFCPDJEHNAP)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7C39BF0", Offset = "0x7C38FF0", VA = "0x187C39BF0", Slot = "19")]
	public void KKFKBEPKKDL(string MOIADMOIDPH, DateTime HAJIKKBJGLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7C39600", Offset = "0x7C38A00", VA = "0x187C39600", Slot = "20")]
	public long ADCKBBHNCLF(string MOIADMOIDPH, long PFCPDJEHNAP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7C39A70", Offset = "0x7C38E70", VA = "0x187C39A70", Slot = "21")]
	public void JIEMLAPANOF(string MOIADMOIDPH, long FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3667DD0", Offset = "0x36671D0", VA = "0x183667DD0", Slot = "22")]
	public T BDGODDKBPAL<T>(string MOIADMOIDPH, T PFCPDJEHNAP, HIHPOAELMHI<T> GCFHFJLLJMB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3667DD0", Offset = "0x36671D0", VA = "0x183667DD0", Slot = "23")]
	public void ILLCNANECFM<T>(string MOIADMOIDPH, T FFOEEMKIKJO, HIHPOAELMHI<T> GCFHFJLLJMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3668820", Offset = "0x3667C20", VA = "0x183668820")]
	private T PGLLLKHHMNO<T>(string MOIADMOIDPH, T PFCPDJEHNAP, [Optional] HIHPOAELMHI<T> BPKFDKFLGKL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3667FB0", Offset = "0x36673B0", VA = "0x183667FB0")]
	private void CHOCEHFLOFL<T>(string MOIADMOIDPH, T FFOEEMKIKJO, [Optional] HIHPOAELMHI<T> BPKFDKFLGKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7C39850", Offset = "0x7C38C50", VA = "0x187C39850", Slot = "16")]
	public string DKIEJMKIMKH(string MOIADMOIDPH, string PFCPDJEHNAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7C39CF0", Offset = "0x7C390F0", VA = "0x187C39CF0", Slot = "17")]
	public void NILBOHABJJC(string MOIADMOIDPH, string FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7C39C60", Offset = "0x7C39060", VA = "0x187C39C60")]
	private void KMBLPMGNCJP(string MOIADMOIDPH, string FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7C39710", Offset = "0x7C38B10", VA = "0x187C39710")]
	private string CNHBMAIJIIG(string MOIADMOIDPH, string PFCPDJEHNAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7C39D80", Offset = "0x7C39180", VA = "0x187C39D80", Slot = "24")]
	public void PCHINIFAOEB(string MOIADMOIDPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7C39970", Offset = "0x7C38D70", VA = "0x187C39970")]
	private string HNLHGBHDFNN(string DJBLFBEBKGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7C39760", Offset = "0x7C38B60", VA = "0x187C39760", Slot = "25")]
	[AsyncStateMachine(typeof(LKOAFENPAJD))]
	public Task DIKEMKPABJI(CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7C39AE0", Offset = "0x7C38EE0", VA = "0x187C39AE0")]
	[IteratorStateMachine(typeof(CDHFJKEBCBN))]
	private IEnumerator<CIKDDGFOAFI> JKPGBAMLBDN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7C39D20", Offset = "0x7C39120", VA = "0x187C39D20")]
	private void NPICDMIBHCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7C39670", Offset = "0x7C38A70", VA = "0x187C39670")]
	private void AGOIMEPJEEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7C398B0", Offset = "0x7C38CB0", VA = "0x187C398B0")]
	private void EIIAPBCMPCN(bool CMNFJMELEON)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class PDOABNAIPMI : PMFDHIMKODI, CEGEOIFFONJ
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
	private Dictionary<string, string> KHMDEBPOBOM;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool LCONPCPHNJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x9C55F0", Offset = "0x9C49F0", VA = "0x1809C55F0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private string GOFHPFNMLEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7C3E760", Offset = "0x7C3DB60", VA = "0x187C3E760")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private Dictionary<string, string> MKAHBDKBFJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7C3EA70", Offset = "0x7C3DE70", VA = "0x187C3EA70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action NGKGBBCBGCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	[UnityEngine.Scripting.Preserve]
	public PDOABNAIPMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "8")]
	public void OLFBOBOMKCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7C3EAB0", Offset = "0x7C3DEB0", VA = "0x187C3EAB0", Slot = "6")]
	public Task KHFNEFMDEEM(long LOLGHOBDHCK, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7C3E370", Offset = "0x7C3D770", VA = "0x187C3E370", Slot = "14")]
	public float DFBHFAHGHPN(string DJBLFBEBKGO, float PFCPDJEHNAP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7C3E990", Offset = "0x7C3DD90", VA = "0x187C3E990", Slot = "13")]
	public void IMKFLPBFDEE(string DJBLFBEBKGO, bool FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7C3E7D0", Offset = "0x7C3DBD0", VA = "0x187C3E7D0", Slot = "12")]
	public bool GIAMNCBLEDP(string DJBLFBEBKGO, bool PFCPDJEHNAP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7C3E6F0", Offset = "0x7C3DAF0", VA = "0x187C3E6F0", Slot = "10")]
	public int DNJNEOGELJI(string DJBLFBEBKGO, int PFCPDJEHNAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7C3EE90", Offset = "0x7C3E290", VA = "0x187C3EE90", Slot = "18")]
	public DateTime MOCMCLIDAPJ(string MOIADMOIDPH, [Optional] DateTime PFCPDJEHNAP)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7C3EB40", Offset = "0x7C3DF40", VA = "0x187C3EB40", Slot = "19")]
	public void KKFKBEPKKDL(string DJBLFBEBKGO, DateTime FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7C3E300", Offset = "0x7C3D700", VA = "0x187C3E300", Slot = "15")]
	public void BGOGJILAOCC(string DJBLFBEBKGO, float FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7C3E920", Offset = "0x7C3DD20", VA = "0x187C3E920", Slot = "11")]
	public void IKHCPDILACG(string DJBLFBEBKGO, int FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7C3E290", Offset = "0x7C3D690", VA = "0x187C3E290", Slot = "20")]
	public long ADCKBBHNCLF(string MOIADMOIDPH, long PFCPDJEHNAP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7C3EA00", Offset = "0x7C3DE00", VA = "0x187C3EA00", Slot = "21")]
	public void JIEMLAPANOF(string MOIADMOIDPH, long FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3657EE0", Offset = "0x36572E0", VA = "0x183657EE0", Slot = "22")]
	public T BDGODDKBPAL<T>(string MOIADMOIDPH, T PFCPDJEHNAP, HIHPOAELMHI<T> GCFHFJLLJMB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3657EE0", Offset = "0x36572E0", VA = "0x183657EE0", Slot = "23")]
	public void ILLCNANECFM<T>(string MOIADMOIDPH, T FFOEEMKIKJO, HIHPOAELMHI<T> GCFHFJLLJMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7C3E640", Offset = "0x7C3DA40", VA = "0x187C3E640", Slot = "16")]
	public string DKIEJMKIMKH(string DJBLFBEBKGO, string PFCPDJEHNAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7C3EF00", Offset = "0x7C3E300", VA = "0x187C3EF00", Slot = "17")]
	public void NILBOHABJJC(string DJBLFBEBKGO, string FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7C3EFA0", Offset = "0x7C3E3A0", VA = "0x187C3EFA0", Slot = "24")]
	public void PCHINIFAOEB(string DJBLFBEBKGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7C3E890", Offset = "0x7C3DC90", VA = "0x187C3E890", Slot = "9")]
	public bool HDDDFKIEMIJ(string DJBLFBEBKGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7C3E3E0", Offset = "0x7C3D7E0", VA = "0x187C3E3E0", Slot = "25")]
	public Task DIKEMKPABJI(CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3820FF0", Offset = "0x38203F0", VA = "0x183820FF0")]
	private T IOLMGDEDCOJ<T>(string MOIADMOIDPH, T PFCPDJEHNAP, [Optional] HIHPOAELMHI<T> BPKFDKFLGKL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x38222E0", Offset = "0x38216E0", VA = "0x1838222E0")]
	private void JFGGMENNDNP<T>(string MOIADMOIDPH, T FFOEEMKIKJO, [Optional] HIHPOAELMHI<T> BPKFDKFLGKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7C3EBB0", Offset = "0x7C3DFB0", VA = "0x187C3EBB0")]
	private Dictionary<string, string> LMOJJLNKHFI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface IFCCBFAGEOA
{
	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action NGKGBBCBGCK;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OLFBOBOMKCA();

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task INLKOAGPILC(long LOLGHOBDHCK);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool DEALCPDHJBG(LEPKAGCLFJO LFHNNNPIOJD = LEPKAGCLFJO.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool IABIEIENNLK(string MOIADMOIDPH, LEPKAGCLFJO ECIFGMDBCGD = LEPKAGCLFJO.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool CKLCCEFELFM(string MOIADMOIDPH, LEPKAGCLFJO ECIFGMDBCGD = LEPKAGCLFJO.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "7")]
	string AJADNODIOJH(string MOIADMOIDPH, [Optional] string PFCPDJEHNAP, LEPKAGCLFJO ECIFGMDBCGD = LEPKAGCLFJO.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IIBMKOKAGAB NDAFMHMHHEJ(string MOIADMOIDPH, string FFOEEMKIKJO, LEPKAGCLFJO ECIFGMDBCGD = LEPKAGCLFJO.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	int OBLBAOMFPDB(string MOIADMOIDPH, int PFCPDJEHNAP = 0, LEPKAGCLFJO ECIFGMDBCGD = LEPKAGCLFJO.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IIBMKOKAGAB NAEIJFAKDPC(string MOIADMOIDPH, int FFOEEMKIKJO, LEPKAGCLFJO ECIFGMDBCGD = LEPKAGCLFJO.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool GKFKGCAPJOI(string MOIADMOIDPH, bool PFCPDJEHNAP, LEPKAGCLFJO ECIFGMDBCGD = LEPKAGCLFJO.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "12")]
	IIBMKOKAGAB CKIAIGKOLGN(string MOIADMOIDPH, bool FFOEEMKIKJO, LEPKAGCLFJO ECIFGMDBCGD = LEPKAGCLFJO.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float PGKMLPKLPDP(string MOIADMOIDPH, float PFCPDJEHNAP = 0f, LEPKAGCLFJO ECIFGMDBCGD = LEPKAGCLFJO.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "14")]
	IIBMKOKAGAB GEBCAMMELMC(string MOIADMOIDPH, float FFOEEMKIKJO, LEPKAGCLFJO ECIFGMDBCGD = LEPKAGCLFJO.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "15")]
	DateTime CDNECFOIGGB(string MOIADMOIDPH, [Optional] DateTime PFCPDJEHNAP, LEPKAGCLFJO ECIFGMDBCGD = LEPKAGCLFJO.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	IIBMKOKAGAB HIGECBLJOOL(string MOIADMOIDPH, DateTime FFOEEMKIKJO, LEPKAGCLFJO ECIFGMDBCGD = LEPKAGCLFJO.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "17")]
	long INDANBLEGIC(string MOIADMOIDPH, long PFCPDJEHNAP = 0L, LEPKAGCLFJO ECIFGMDBCGD = LEPKAGCLFJO.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "18")]
	IIBMKOKAGAB PBNOFIBJMHM(string MOIADMOIDPH, long FFOEEMKIKJO, LEPKAGCLFJO ECIFGMDBCGD = LEPKAGCLFJO.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "19")]
	T CKMICJOBICI<T>(string MOIADMOIDPH, [Optional] T PFCPDJEHNAP, LEPKAGCLFJO ECIFGMDBCGD = LEPKAGCLFJO.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "20")]
	IIBMKOKAGAB IPHHHKKEBKI<T>(string MOIADMOIDPH, T FFOEEMKIKJO, LEPKAGCLFJO ECIFGMDBCGD = LEPKAGCLFJO.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool BFDAPMFGDPA(string MOIADMOIDPH);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool EEGJPJONJAG(string MOIADMOIDPH);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "23")]
	string FGLAJONGIFG(string MOIADMOIDPH, [Optional] string PFCPDJEHNAP);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "24")]
	IIBMKOKAGAB FPBJINDFDCD(string MOIADMOIDPH, string FFOEEMKIKJO);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "25")]
	int EEMCNHOEPMK(string MOIADMOIDPH, int PFCPDJEHNAP = 0);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "26")]
	IIBMKOKAGAB PMAJOGJMPOO(string MOIADMOIDPH, int FFOEEMKIKJO);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool DIMIGEONNDF(string MOIADMOIDPH, bool PFCPDJEHNAP);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "28")]
	IIBMKOKAGAB JCDGJAMOLKE(string MOIADMOIDPH, bool FFOEEMKIKJO);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "29")]
	float LFNONFIEMMA(string MOIADMOIDPH, float PFCPDJEHNAP = 0f);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "30")]
	IIBMKOKAGAB IHOBJMOACID(string MOIADMOIDPH, float FFOEEMKIKJO);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "31")]
	DateTime JNIMEEDGKJP(string MOIADMOIDPH, [Optional] DateTime PFCPDJEHNAP);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "32")]
	IIBMKOKAGAB HMNABFEJJCP(string MOIADMOIDPH, DateTime FFOEEMKIKJO);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "33")]
	long IKKFACLAMPM(string MOIADMOIDPH, long PFCPDJEHNAP = 0L);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "34")]
	IIBMKOKAGAB ICKGFECBIHK(string MOIADMOIDPH, long FFOEEMKIKJO);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void FMAMEEJIOAI<T>(HIHPOAELMHI<T> GCFHFJLLJMB, [Optional] IEqualityComparer<T> BJPBKLBLNPO);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void FGDFLPHMCDA<T>();

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "37")]
	IDisposable OOGMIHGFMIC();

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void BGNFNBLFFKO(float PCFGHPNONAI);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task NPICDMIBHCO([Optional] CancellationToken LMNHDKIFBOH);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum IIBMKOKAGAB : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	Unchanged,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	New,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Changed
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class PCOGOKFNAEL : IFCCBFAGEOA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private abstract class MOCBCFKONPF
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		protected static readonly HashSet<MOCBCFKONPF> OJKCOPIGGNJ;

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x7C3A340", Offset = "0x7C39740", VA = "0x187C3A340")]
		public static void LBDCHDFHHFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void CJEMNCEDADJ();

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		protected MOCBCFKONPF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private class LPKIPPOBNLO<T> : MOCBCFKONPF
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly LPKIPPOBNLO<T> DNEPPKLGBFA;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public HIHPOAELMHI<T> HCPEPAOODNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x9AA3B0", Offset = "0x9A97B0", VA = "0x1809AA3B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x9AA4D0", Offset = "0x9A98D0", VA = "0x1809AA4D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public IEqualityComparer<T> HFLLKMBGLNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x9A9210", Offset = "0x9A8610", VA = "0x1809A9210")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool NMJMIBNPAKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x4285EF0", Offset = "0x42852F0", VA = "0x184285EF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x4E817E0", Offset = "0x4E80BE0", VA = "0x184E817E0")]
		private LPKIPPOBNLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x4E810A0", Offset = "0x4E804A0", VA = "0x184E810A0")]
		public void GEAMIGHEOPG(HIHPOAELMHI<T> BPKFDKFLGKL, [Optional] IEqualityComparer<T> BJPBKLBLNPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x4E81010", Offset = "0x4E80410", VA = "0x184E81010", Slot = "4")]
		public override void CJEMNCEDADJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private class ALFBJNIMCLF : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private readonly PCOGOKFNAEL BELIOMNDLEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly object PGEMOEPMABP;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x7C37E80", Offset = "0x7C37280", VA = "0x187C37E80")]
		public ALFBJNIMCLF(PCOGOKFNAEL BELIOMNDLEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x7C37E50", Offset = "0x7C37250", VA = "0x187C37E50", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct DKDDFAMDLDN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public PCOGOKFNAEL <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x7C380D0", Offset = "0x7C374D0", VA = "0x187C380D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7C383B0", Offset = "0x7C377B0", VA = "0x187C383B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct MOELKAKECPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public PCOGOKFNAEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public CEGEOIFFONJ backingStoreToSave;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7C3A510", Offset = "0x7C39910", VA = "0x187C3A510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0xA0AFE0", Offset = "0xA0A3E0", VA = "0x180A0AFE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private struct OMKGDJKDMLM : IAsyncStateMachine
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
		public PCOGOKFNAEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x7C3AB30", Offset = "0x7C39F30", VA = "0x187C3AB30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7C3B000", Offset = "0x7C3A400", VA = "0x187C3B000", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class DHPGNBMGKBK : IEnumerator<CIKDDGFOAFI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private CIKDDGFOAFI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public PCOGOKFNAEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public float seconds;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private CIKDDGFOAFI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x9AFBB0", Offset = "0x9AEFB0", VA = "0x1809AFBB0")]
		[DebuggerHidden]
		public DHPGNBMGKBK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7C37FF0", Offset = "0x7C373F0", VA = "0x187C37FF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7C38080", Offset = "0x7C37480", VA = "0x187C38080", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly PMFDHIMKODI ODJLMCLFKAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly PMFDHIMKODI LJBNECBOGHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly EEHPELLNMMG JPBGMEKMIKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly OKJPOJGEILK AAECGIEPKCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly GDFFPAJAJGP.JPEMLKEPGBP FNOABCJJLOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly BBOIFKBNJEM MOBIEJDKKNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly HashSet<CEGEOIFFONJ> OAEHGFNEDPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private Task FAKGHCKDFFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private Dictionary<string, string> FAJCIIJAJHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private LBKCJDEOHAA OCFLLJHLNAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly object BEFJEJCFAFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly object HMDJHOLJLKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private long KDBIDPJLDJN;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private bool AAGKLNJHAPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7C3C5D0", Offset = "0x7C3B9D0", VA = "0x187C3C5D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private CancellationTokenSource JEHECCHNAOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x9A9A60", Offset = "0x9A8E60", VA = "0x1809A9A60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x9A9AC0", Offset = "0x9A8EC0", VA = "0x1809A9AC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action NGKGBBCBGCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7C3C190", Offset = "0x7C3B590", VA = "0x187C3C190", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7C3CD20", Offset = "0x7C3C120", VA = "0x187C3CD20", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7C3DAA0", Offset = "0x7C3CEA0", VA = "0x187C3DAA0")]
	[NOCPMGCIOME.CBODKAAMPCM]
	internal static void OGCPPBNKBAK(DHLGDCALOEP NKMJDOBLHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7C3DEC0", Offset = "0x7C3D2C0", VA = "0x187C3DEC0")]
	[UnityEngine.Scripting.Preserve]
	public PCOGOKFNAEL([CMKKAFOAFJE("Disk")] PMFDHIMKODI ODJLMCLFKAD, [CMKKAFOAFJE("Cloud")] PMFDHIMKODI LJBNECBOGHD, [CMKKAFOAFJE(null)] EEHPELLNMMG JPBGMEKMIKE, [CMKKAFOAFJE(null)] OKJPOJGEILK AAECGIEPKCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7C3B960", Offset = "0x7C3AD60", VA = "0x187C3B960", Slot = "44")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x7C3C580", Offset = "0x7C3B980", VA = "0x187C3C580")]
	private void HLLHMHEDOND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7C3DB10", Offset = "0x7C3CF10", VA = "0x187C3DB10", Slot = "6")]
	public void OLFBOBOMKCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7C3CDC0", Offset = "0x7C3C1C0", VA = "0x187C3CDC0", Slot = "7")]
	public Task INLKOAGPILC(long LOLGHOBDHCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x7C3B710", Offset = "0x7C3AB10", VA = "0x187C3B710")]
	[AsyncStateMachine(typeof(DKDDFAMDLDN))]
	private Task DGICJINEELC(long LOLGHOBDHCK, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x7C3D300", Offset = "0x7C3C700", VA = "0x187C3D300")]
	private void LAFAFFMLLME(object HHGPJKKLNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x7C3CB90", Offset = "0x7C3BF90", VA = "0x187C3CB90")]
	private void IKIFOMFDGHL(object HHGPJKKLNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x7C3C130", Offset = "0x7C3B530", VA = "0x187C3C130")]
	private string GMNOFIPKLOD(string FMGFOODKHCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x7C3D760", Offset = "0x7C3CB60", VA = "0x187C3D760")]
	private void NOFHEMAGILG(LEPKAGCLFJO LFHNNNPIOJD, string DJBLFBEBKGO, [Out] PMFDHIMKODI AFKMCGKFGFH, [Out] string LLOKKDKFGIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x7C3BA20", Offset = "0x7C3AE20", VA = "0x187C3BA20")]
	private PMFDHIMKODI EONCBFEJKAI(LEPKAGCLFJO LFHNNNPIOJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x7C3B650", Offset = "0x7C3AA50", VA = "0x187C3B650", Slot = "8")]
	public bool DEALCPDHJBG(LEPKAGCLFJO LFHNNNPIOJD = LEPKAGCLFJO.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x7C3C620", Offset = "0x7C3BA20", VA = "0x187C3C620", Slot = "9")]
	public bool IABIEIENNLK(string MOIADMOIDPH, LEPKAGCLFJO ECIFGMDBCGD = LEPKAGCLFJO.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x7C3B4D0", Offset = "0x7C3A8D0", VA = "0x187C3B4D0", Slot = "10")]
	public bool CKLCCEFELFM(string MOIADMOIDPH, LEPKAGCLFJO ECIFGMDBCGD = LEPKAGCLFJO.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x7C3B1A0", Offset = "0x7C3A5A0", VA = "0x187C3B1A0", Slot = "11")]
	public string AJADNODIOJH(string MOIADMOIDPH, [Optional] string PFCPDJEHNAP, LEPKAGCLFJO ECIFGMDBCGD = LEPKAGCLFJO.CLOUD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x7C3D5A0", Offset = "0x7C3C9A0", VA = "0x187C3D5A0", Slot = "12")]
	public IIBMKOKAGAB NDAFMHMHHEJ(string MOIADMOIDPH, string FFOEEMKIKJO, LEPKAGCLFJO ECIFGMDBCGD = LEPKAGCLFJO.CLOUD)
	{
		return default(IIBMKOKAGAB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x7C3D9F0", Offset = "0x7C3CDF0", VA = "0x187C3D9F0", Slot = "13")]
	public int OBLBAOMFPDB(string MOIADMOIDPH, int PFCPDJEHNAP = 0, LEPKAGCLFJO ECIFGMDBCGD = LEPKAGCLFJO.CLOUD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x7C3D420", Offset = "0x7C3C820", VA = "0x187C3D420", Slot = "14")]
	public IIBMKOKAGAB NAEIJFAKDPC(string MOIADMOIDPH, int FFOEEMKIKJO, LEPKAGCLFJO ECIFGMDBCGD = LEPKAGCLFJO.CLOUD)
	{
		return default(IIBMKOKAGAB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x7C3C080", Offset = "0x7C3B480", VA = "0x187C3C080", Slot = "15")]
	public bool GKFKGCAPJOI(string MOIADMOIDPH, bool PFCPDJEHNAP, LEPKAGCLFJO ECIFGMDBCGD = LEPKAGCLFJO.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x7C3B350", Offset = "0x7C3A750", VA = "0x187C3B350", Slot = "16")]
	public IIBMKOKAGAB CKIAIGKOLGN(string MOIADMOIDPH, bool FFOEEMKIKJO, LEPKAGCLFJO ECIFGMDBCGD = LEPKAGCLFJO.CLOUD)
	{
		return default(IIBMKOKAGAB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x7C3DDE0", Offset = "0x7C3D1E0", VA = "0x187C3DDE0", Slot = "17")]
	public float PGKMLPKLPDP(string MOIADMOIDPH, float PFCPDJEHNAP = 0f, LEPKAGCLFJO ECIFGMDBCGD = LEPKAGCLFJO.CLOUD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x7C3BF00", Offset = "0x7C3B300", VA = "0x187C3BF00", Slot = "18")]
	public IIBMKOKAGAB GEBCAMMELMC(string MOIADMOIDPH, float FFOEEMKIKJO, LEPKAGCLFJO ECIFGMDBCGD = LEPKAGCLFJO.CLOUD)
	{
		return default(IIBMKOKAGAB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x7C3B2B0", Offset = "0x7C3A6B0", VA = "0x187C3B2B0", Slot = "19")]
	public DateTime CDNECFOIGGB(string MOIADMOIDPH, [Optional] DateTime PFCPDJEHNAP, LEPKAGCLFJO ECIFGMDBCGD = LEPKAGCLFJO.CLOUD)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x7C3C3E0", Offset = "0x7C3B7E0", VA = "0x187C3C3E0", Slot = "20")]
	public IIBMKOKAGAB HIGECBLJOOL(string MOIADMOIDPH, DateTime FFOEEMKIKJO, LEPKAGCLFJO ECIFGMDBCGD = LEPKAGCLFJO.CLOUD)
	{
		return default(IIBMKOKAGAB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x7C3CC80", Offset = "0x7C3C080", VA = "0x187C3CC80", Slot = "21")]
	public long INDANBLEGIC(string MOIADMOIDPH, long PFCPDJEHNAP = 0L, LEPKAGCLFJO ECIFGMDBCGD = LEPKAGCLFJO.CLOUD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x7C3DC60", Offset = "0x7C3D060", VA = "0x187C3DC60", Slot = "22")]
	public IIBMKOKAGAB PBNOFIBJMHM(string MOIADMOIDPH, long FFOEEMKIKJO, LEPKAGCLFJO ECIFGMDBCGD = LEPKAGCLFJO.CLOUD)
	{
		return default(IIBMKOKAGAB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x381EE40", Offset = "0x381E240", VA = "0x18381EE40", Slot = "23")]
	public T CKMICJOBICI<T>(string MOIADMOIDPH, [Optional] T PFCPDJEHNAP, LEPKAGCLFJO ECIFGMDBCGD = LEPKAGCLFJO.CLOUD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x381EE40", Offset = "0x381E240", VA = "0x18381EE40", Slot = "24")]
	public IIBMKOKAGAB IPHHHKKEBKI<T>(string MOIADMOIDPH, T FFOEEMKIKJO, LEPKAGCLFJO ECIFGMDBCGD = LEPKAGCLFJO.CLOUD)
	{
		return default(IIBMKOKAGAB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x7C3B240", Offset = "0x7C3A640", VA = "0x187C3B240", Slot = "25")]
	public bool BFDAPMFGDPA(string MOIADMOIDPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x7C3B9A0", Offset = "0x7C3ADA0", VA = "0x187C3B9A0", Slot = "26")]
	public bool EEGJPJONJAG(string MOIADMOIDPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x7C3BBE0", Offset = "0x7C3AFE0", VA = "0x187C3BBE0", Slot = "27")]
	public string FGLAJONGIFG(string MOIADMOIDPH, [Optional] string PFCPDJEHNAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x7C3BED0", Offset = "0x7C3B2D0", VA = "0x187C3BED0", Slot = "28")]
	public IIBMKOKAGAB FPBJINDFDCD(string MOIADMOIDPH, string FFOEEMKIKJO)
	{
		return default(IIBMKOKAGAB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x7C3B9B0", Offset = "0x7C3ADB0", VA = "0x187C3B9B0", Slot = "29")]
	public int EEMCNHOEPMK(string MOIADMOIDPH, int PFCPDJEHNAP = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x7C3DE90", Offset = "0x7C3D290", VA = "0x187C3DE90", Slot = "30")]
	public IIBMKOKAGAB PMAJOGJMPOO(string MOIADMOIDPH, int FFOEEMKIKJO)
	{
		return default(IIBMKOKAGAB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x7C3B8F0", Offset = "0x7C3ACF0", VA = "0x187C3B8F0", Slot = "31")]
	public bool DIMIGEONNDF(string MOIADMOIDPH, bool PFCPDJEHNAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x7C3CF90", Offset = "0x7C3C390", VA = "0x187C3CF90", Slot = "32")]
	public IIBMKOKAGAB JCDGJAMOLKE(string MOIADMOIDPH, bool FFOEEMKIKJO)
	{
		return default(IIBMKOKAGAB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x7C3D320", Offset = "0x7C3C720", VA = "0x187C3D320", Slot = "33")]
	public float LFNONFIEMMA(string MOIADMOIDPH, float PFCPDJEHNAP = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x7C3CB60", Offset = "0x7C3BF60", VA = "0x187C3CB60", Slot = "34")]
	public IIBMKOKAGAB IHOBJMOACID(string MOIADMOIDPH, float FFOEEMKIKJO)
	{
		return default(IIBMKOKAGAB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x7C3D130", Offset = "0x7C3C530", VA = "0x187C3D130", Slot = "35")]
	public DateTime JNIMEEDGKJP(string MOIADMOIDPH, [Optional] DateTime PFCPDJEHNAP)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x7C3C5F0", Offset = "0x7C3B9F0", VA = "0x187C3C5F0", Slot = "36")]
	public IIBMKOKAGAB HMNABFEJJCP(string MOIADMOIDPH, DateTime FFOEEMKIKJO)
	{
		return default(IIBMKOKAGAB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7C3CC10", Offset = "0x7C3C010", VA = "0x187C3CC10", Slot = "37")]
	public long IKKFACLAMPM(string MOIADMOIDPH, long PFCPDJEHNAP = 0L)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x7C3C8A0", Offset = "0x7C3BCA0", VA = "0x187C3C8A0", Slot = "38")]
	public IIBMKOKAGAB ICKGFECBIHK(string MOIADMOIDPH, long FFOEEMKIKJO)
	{
		return default(IIBMKOKAGAB);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7C3C230", Offset = "0x7C3B630", VA = "0x187C3C230")]
	private bool GNPHNKGMIKK(CEGEOIFFONJ AFKMCGKFGFH, string MOIADMOIDPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7C3D1A0", Offset = "0x7C3C5A0", VA = "0x187C3D1A0")]
	private bool KBJFPJIKGJG(CEGEOIFFONJ AFKMCGKFGFH, string MOIADMOIDPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7C3C290", Offset = "0x7C3B690", VA = "0x187C3C290")]
	private IIBMKOKAGAB HCKPNFACNME(CEGEOIFFONJ AFKMCGKFGFH, string MOIADMOIDPH, string FFOEEMKIKJO)
	{
		return default(IIBMKOKAGAB);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7C3C8D0", Offset = "0x7C3BCD0", VA = "0x187C3C8D0")]
	private IIBMKOKAGAB IEECFNONIFI(CEGEOIFFONJ AFKMCGKFGFH, string MOIADMOIDPH, int FFOEEMKIKJO)
	{
		return default(IIBMKOKAGAB);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x7C3BAA0", Offset = "0x7C3AEA0", VA = "0x187C3BAA0")]
	private IIBMKOKAGAB FBDHOOKGKCC(CEGEOIFFONJ AFKMCGKFGFH, string MOIADMOIDPH, bool FFOEEMKIKJO)
	{
		return default(IIBMKOKAGAB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x7C3CA10", Offset = "0x7C3BE10", VA = "0x187C3CA10")]
	private IIBMKOKAGAB IGOOJDBMDAJ(CEGEOIFFONJ AFKMCGKFGFH, string MOIADMOIDPH, float FFOEEMKIKJO)
	{
		return default(IIBMKOKAGAB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x7C3CFC0", Offset = "0x7C3C3C0", VA = "0x187C3CFC0")]
	private IIBMKOKAGAB JHKHKODDKNP(CEGEOIFFONJ AFKMCGKFGFH, string MOIADMOIDPH, DateTime FFOEEMKIKJO)
	{
		return default(IIBMKOKAGAB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7C3B060", Offset = "0x7C3A460", VA = "0x187C3B060")]
	private IIBMKOKAGAB ADPPMGKGKFA(CEGEOIFFONJ AFKMCGKFGFH, string MOIADMOIDPH, long FFOEEMKIKJO)
	{
		return default(IIBMKOKAGAB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x381F190", Offset = "0x381E590", VA = "0x18381F190")]
	private T GMDCBANMMDB<T>(CEGEOIFFONJ AFKMCGKFGFH, string MOIADMOIDPH, T PFCPDJEHNAP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x3820180", Offset = "0x381F580", VA = "0x183820180")]
	private IIBMKOKAGAB NIJMJOFBBFB<T>(CEGEOIFFONJ AFKMCGKFGFH, string MOIADMOIDPH, T FFOEEMKIKJO)
	{
		return default(IIBMKOKAGAB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x381F0E0", Offset = "0x381E4E0", VA = "0x18381F0E0", Slot = "39")]
	public void FMAMEEJIOAI<T>(HIHPOAELMHI<T> GCFHFJLLJMB, [Optional] IEqualityComparer<T> BJPBKLBLNPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x381F060", Offset = "0x381E460", VA = "0x18381F060", Slot = "40")]
	public void FGDFLPHMCDA<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x7C3B820", Offset = "0x7C3AC20", VA = "0x187C3B820")]
	[AsyncStateMachine(typeof(MOELKAKECPC))]
	private void DIKEMKPABJI(CEGEOIFFONJ MGLLGDPKDJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x7C3D900", Offset = "0x7C3CD00", VA = "0x187C3D900", Slot = "43")]
	[AsyncStateMachine(typeof(OMKGDJKDMLM))]
	public Task NPICDMIBHCO([Optional] CancellationToken HHGPJKKLNIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x7C3C6C0", Offset = "0x7C3BAC0", VA = "0x187C3C6C0")]
	private void IBDLILMONCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x7C3DB80", Offset = "0x7C3CF80", VA = "0x187C3DB80", Slot = "41")]
	public IDisposable OOGMIHGFMIC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x7C3B2A0", Offset = "0x7C3A6A0", VA = "0x187C3B2A0", Slot = "42")]
	public void BGNFNBLFFKO(float PCFGHPNONAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x7C3BC50", Offset = "0x7C3B050", VA = "0x187C3BC50")]
	private void FGPCLBBLDGD(float PFJAHIKHNID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x7C3D390", Offset = "0x7C3C790", VA = "0x187C3D390")]
	[IteratorStateMachine(typeof(DHPGNBMGKBK))]
	private IEnumerator<CIKDDGFOAFI> LKGCMDHLDDO(float PCFGHPNONAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x7C3D730", Offset = "0x7C3CB30", VA = "0x187C3D730")]
	[CompilerGenerated]
	private void NNIACDHDCLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class OCGBHLIKBFM : FICJNCNGGAA<bool>
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static OCGBHLIKBFM DNEPPKLGBFA
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x7C3A6A0", Offset = "0x7C39AA0", VA = "0x187C3A6A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x7C3A6F0", Offset = "0x7C39AF0", VA = "0x187C3A6F0", Slot = "9")]
	public override string PELCBGJOJPC(bool PJCOHHCODGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7C3A7E0", Offset = "0x7C39BE0", VA = "0x187C3A7E0", Slot = "10")]
	protected override bool PLIIBEGPKOB(string PJCOHHCODGF, [Out] bool FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x7C3AAF0", Offset = "0x7C39EF0", VA = "0x187C3AAF0")]
	public OCGBHLIKBFM()
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

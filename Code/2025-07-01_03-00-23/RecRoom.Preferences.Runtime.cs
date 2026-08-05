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
		[Cpp2IlInjected.Address(RVA = "0x8381E60", Offset = "0x8380460", VA = "0x188381E60", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x282D140", Offset = "0x282B740", VA = "0x18282D140")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum BLINJCMFIIA : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	CLOUD,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	DISK
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
internal static class KLKOKCEMLLM
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	internal delegate void IGFPMFHLHCK(NPDIDFHPAKC OIEADCGADLH);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x837D120", Offset = "0x837B720", VA = "0x18837D120")]
	private static void CPDPFIGABHG(NPDIDFHPAKC OIEADCGADLH, IGFPMFHLHCK HFPDACOPJPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x837D310", Offset = "0x837B910", VA = "0x18837D310")]
	public static bool EOGALHHIKJG(this NPDIDFHPAKC OIEADCGADLH, string ALIOJODOECN, [Optional] IGFPMFHLHCK HFPDACOPJPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x837D470", Offset = "0x837BA70", VA = "0x18837D470")]
	public static ICMIHDKAKPF FKCFCCGKBNC(this NPDIDFHPAKC OIEADCGADLH, string ALIOJODOECN, string KKGBKLFKCPO, [Optional] IGFPMFHLHCK HFPDACOPJPG)
	{
		return default(ICMIHDKAKPF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x837CFE0", Offset = "0x837B5E0", VA = "0x18837CFE0")]
	public static ICMIHDKAKPF CBMIPBGJIPH(this NPDIDFHPAKC OIEADCGADLH, string ALIOJODOECN, int KKGBKLFKCPO, [Optional] IGFPMFHLHCK HFPDACOPJPG)
	{
		return default(ICMIHDKAKPF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x837CEA0", Offset = "0x837B4A0", VA = "0x18837CEA0")]
	public static ICMIHDKAKPF CBJCBNIHFFM(this NPDIDFHPAKC OIEADCGADLH, string ALIOJODOECN, bool KKGBKLFKCPO, [Optional] IGFPMFHLHCK HFPDACOPJPG)
	{
		return default(ICMIHDKAKPF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x837D5C0", Offset = "0x837BBC0", VA = "0x18837D5C0")]
	public static ICMIHDKAKPF LDKKJAFNIEO(this NPDIDFHPAKC OIEADCGADLH, string ALIOJODOECN, float KKGBKLFKCPO, [Optional] IGFPMFHLHCK HFPDACOPJPG)
	{
		return default(ICMIHDKAKPF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x837D1A0", Offset = "0x837B7A0", VA = "0x18837D1A0")]
	public static ICMIHDKAKPF DJKOCCCMMAH(this NPDIDFHPAKC OIEADCGADLH, string ALIOJODOECN, DateTime KKGBKLFKCPO, [Optional] IGFPMFHLHCK HFPDACOPJPG)
	{
		return default(ICMIHDKAKPF);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x837CD60", Offset = "0x837B360", VA = "0x18837CD60")]
	public static ICMIHDKAKPF BENBPLIFMLB(this NPDIDFHPAKC OIEADCGADLH, string ALIOJODOECN, long KKGBKLFKCPO, [Optional] IGFPMFHLHCK HFPDACOPJPG)
	{
		return default(ICMIHDKAKPF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class FKEIJFEAEMO : ADOJOKKDCHB, NPDIDFHPAKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly JDKPNNELJCN KEBHLPKAEFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<string, byte> KMANJJDJDMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private Dictionary<string, string> ALJPNJBBKPB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool ICKKICKDNIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA603F0", Offset = "0xA5E9F0", VA = "0x180A603F0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Dictionary<string, string> APPOJJPDKGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x837AB40", Offset = "0x8379140", VA = "0x18837AB40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action AIFCBIKDGGH
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x837B940", Offset = "0x8379F40", VA = "0x18837B940")]
	[UnityEngine.Scripting.Preserve]
	public FKEIJFEAEMO([GGNLMCAPMLP(null)] JDKPNNELJCN KEBHLPKAEFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "8")]
	public void AMFNOLNIBCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x837A050", Offset = "0x8378650", VA = "0x18837A050")]
	private DirectoryInfo ADBLPOHIJHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x837A7C0", Offset = "0x8378DC0", VA = "0x18837A7C0", Slot = "6")]
	public Task HFJBIOKNKID(long CGDBPDKMKJE, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x837A5E0", Offset = "0x8378BE0", VA = "0x18837A5E0", Slot = "14")]
	public float ELJMFNPPGMA(string BLIBAMJKLIA, float COMAGLLDBOM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x837A570", Offset = "0x8378B70", VA = "0x18837A570", Slot = "13")]
	public void CHALDNMMAHO(string BLIBAMJKLIA, bool KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x837AA70", Offset = "0x8379070", VA = "0x18837AA70", Slot = "12")]
	public bool LFGBDKDJGDP(string BLIBAMJKLIA, bool COMAGLLDBOM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x837B8D0", Offset = "0x8379ED0", VA = "0x18837B8D0", Slot = "10")]
	public int PLDLILDNDAM(string BLIBAMJKLIA, int COMAGLLDBOM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x837A500", Offset = "0x8378B00", VA = "0x18837A500", Slot = "18")]
	public DateTime BFEJBNDJJON(string ALIOJODOECN, [Optional] DateTime COMAGLLDBOM)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x837A750", Offset = "0x8378D50", VA = "0x18837A750", Slot = "19")]
	public void HBNABDLODLL(string BLIBAMJKLIA, DateTime KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8379FE0", Offset = "0x83785E0", VA = "0x188379FE0", Slot = "15")]
	public void ACDPEGFMCPA(string BLIBAMJKLIA, float KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x837B860", Offset = "0x8379E60", VA = "0x18837B860", Slot = "11")]
	public void PKOANOGCJLL(string BLIBAMJKLIA, int KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x837A490", Offset = "0x8378A90", VA = "0x18837A490", Slot = "20")]
	public long BBAIDKGOOGA(string ALIOJODOECN, long COMAGLLDBOM)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x837A900", Offset = "0x8378F00", VA = "0x18837A900", Slot = "21")]
	public void JFFLNAGDBHO(string ALIOJODOECN, long KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x30ACC60", Offset = "0x30AB260", VA = "0x1830ACC60", Slot = "22")]
	public T PAMNADJEDCD<T>(string ALIOJODOECN, T COMAGLLDBOM, DAKEOIAHFIL<T> AEAMJBPHPKK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x30ABA70", Offset = "0x30AA070", VA = "0x1830ABA70", Slot = "23")]
	public void EGPMFCLEGCP<T>(string ALIOJODOECN, T KKGBKLFKCPO, DAKEOIAHFIL<T> AEAMJBPHPKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x837A850", Offset = "0x8378E50", VA = "0x18837A850", Slot = "16")]
	public string IEOBNAPBHHA(string BLIBAMJKLIA, string COMAGLLDBOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x837A970", Offset = "0x8378F70", VA = "0x18837A970", Slot = "17")]
	public void JLMMJCKBFAH(string BLIBAMJKLIA, string KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x837AB80", Offset = "0x8379180", VA = "0x18837AB80", Slot = "24")]
	public void NFPKPLJDNEP(string BLIBAMJKLIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x837A9E0", Offset = "0x8378FE0", VA = "0x18837A9E0", Slot = "9")]
	public bool KDGKPBGFFAC(string BLIBAMJKLIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x837A150", Offset = "0x8378750", VA = "0x18837A150", Slot = "25")]
	public Task AJPLOFDHMPK(CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x837ACD0", Offset = "0x83792D0", VA = "0x18837ACD0")]
	private void NHOEAABALCP(DirectoryInfo MBIACNNPHDF, string BGODHHMJDFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8379DE0", Offset = "0x83783E0", VA = "0x188379DE0")]
	private static string AACOBNLMFJG(string BLIBAMJKLIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x837A650", Offset = "0x8378C50", VA = "0x18837A650")]
	private static string EPLDLIGFKOK(byte[] IHNKIKDOAOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3B2EC00", Offset = "0x3B2D200", VA = "0x183B2EC00")]
	private T KBGIPADPFGF<T>(string ALIOJODOECN, T COMAGLLDBOM, [Optional] DAKEOIAHFIL<T> IHMPAIIHCAP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3B2D9B0", Offset = "0x3B2BFB0", VA = "0x183B2D9B0")]
	private void BNAKHNGOEHD<T>(string ALIOJODOECN, T KKGBKLFKCPO, [Optional] DAKEOIAHFIL<T> IHMPAIIHCAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x837B090", Offset = "0x8379690", VA = "0x18837B090")]
	private Dictionary<string, string> OODCDNAFGAE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal static class PMBMLHCHKIG
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8381C20", Offset = "0x8380220", VA = "0x188381C20")]
	[BNHIEDNKDNA.MLFEBCDGLFC]
	internal static void GLAOIPJFGAH(DCNOMJHNEOK FAIEEFHMPLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class GMOCCAKPBGA : LGLNGIEECML
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x837B9E0", Offset = "0x8379FE0", VA = "0x18837B9E0")]
	[UnityEngine.Scripting.Preserve]
	public GMOCCAKPBGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class LGLNGIEECML : ADOJOKKDCHB, NPDIDFHPAKC, EHJJFOJHNBH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<string, object> PFEFFNDKKBM;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool ICKKICKDNIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA603F0", Offset = "0xA5E9F0", VA = "0x180A603F0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action AIFCBIKDGGH
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "8")]
	public void AMFNOLNIBCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x837DE80", Offset = "0x837C480", VA = "0x18837DE80", Slot = "6")]
	public Task HFJBIOKNKID(long CGDBPDKMKJE, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x837E030", Offset = "0x837C630", VA = "0x18837E030", Slot = "9")]
	public bool KDGKPBGFFAC(string ALIOJODOECN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x837E1B0", Offset = "0x837C7B0", VA = "0x18837E1B0", Slot = "10")]
	public int PLDLILDNDAM(string ALIOJODOECN, int COMAGLLDBOM = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x837E150", Offset = "0x837C750", VA = "0x18837E150", Slot = "11")]
	public void PKOANOGCJLL(string ALIOJODOECN, int KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x837E090", Offset = "0x837C690", VA = "0x18837E090", Slot = "12")]
	public bool LFGBDKDJGDP(string ALIOJODOECN, bool COMAGLLDBOM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x837DD60", Offset = "0x837C360", VA = "0x18837DD60", Slot = "13")]
	public void CHALDNMMAHO(string ALIOJODOECN, bool KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x837DDC0", Offset = "0x837C3C0", VA = "0x18837DDC0", Slot = "14")]
	public float ELJMFNPPGMA(string ALIOJODOECN, float COMAGLLDBOM = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x837DBB0", Offset = "0x837C1B0", VA = "0x18837DBB0", Slot = "15")]
	public void ACDPEGFMCPA(string ALIOJODOECN, float KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x837DF10", Offset = "0x837C510", VA = "0x18837DF10", Slot = "16")]
	public string IEOBNAPBHHA(string ALIOJODOECN, [Optional] string COMAGLLDBOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x837DFD0", Offset = "0x837C5D0", VA = "0x18837DFD0", Slot = "17")]
	public void JLMMJCKBFAH(string ALIOJODOECN, string KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x837DD00", Offset = "0x837C300", VA = "0x18837DD00", Slot = "18")]
	public DateTime BFEJBNDJJON(string ALIOJODOECN, [Optional] DateTime COMAGLLDBOM)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x837DE20", Offset = "0x837C420", VA = "0x18837DE20", Slot = "19")]
	public void HBNABDLODLL(string ALIOJODOECN, DateTime KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x837DCA0", Offset = "0x837C2A0", VA = "0x18837DCA0", Slot = "20")]
	public long BBAIDKGOOGA(string ALIOJODOECN, long COMAGLLDBOM)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x837DF70", Offset = "0x837C570", VA = "0x18837DF70", Slot = "21")]
	public void JFFLNAGDBHO(string ALIOJODOECN, long KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3BF2000", Offset = "0x3BF0600", VA = "0x183BF2000", Slot = "22")]
	public T PAMNADJEDCD<T>(string ALIOJODOECN, T COMAGLLDBOM, DAKEOIAHFIL<T> AEAMJBPHPKK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3BF1720", Offset = "0x3BEFD20", VA = "0x183BF1720", Slot = "23")]
	public void EGPMFCLEGCP<T>(string ALIOJODOECN, T KKGBKLFKCPO, DAKEOIAHFIL<T> AEAMJBPHPKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3BF17C0", Offset = "0x3BEFDC0", VA = "0x183BF17C0")]
	public T KBGIPADPFGF<T>(string ALIOJODOECN, T COMAGLLDBOM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3BF1230", Offset = "0x3BEF830", VA = "0x183BF1230")]
	public void BNAKHNGOEHD<T>(string ALIOJODOECN, T KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x837E0F0", Offset = "0x837C6F0", VA = "0x18837E0F0", Slot = "24")]
	public void NFPKPLJDNEP(string ALIOJODOECN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x837DC10", Offset = "0x837C210", VA = "0x18837DC10", Slot = "25")]
	public Task AJPLOFDHMPK(CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x837B9E0", Offset = "0x8379FE0", VA = "0x18837B9E0")]
	public LGLNGIEECML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public abstract class GNPJKOCFIMH<TParent> where TParent : NPDIDFHPAKC
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly HashSet<GNPJKOCFIMH<TParent>> FIHHCGJCHBG;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4D9F560", Offset = "0x4D9DB60", VA = "0x184D9F560")]
	protected GNPJKOCFIMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract void HHCEOPNNHLH();

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void FLPENEOMLGG(string BLIBAMJKLIA);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4D9F1F0", Offset = "0x4D9D7F0", VA = "0x184D9F1F0")]
	public static void MHEACGHBNEC(string BLIBAMJKLIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4D9EFB0", Offset = "0x4D9D5B0", VA = "0x184D9EFB0")]
	public static void GPDNGNKKMHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class OJEHIECEHKH<TParent, TValue> : GNPJKOCFIMH<TParent> where TParent : NPDIDFHPAKC
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly OJEHIECEHKH<TParent, TValue> JLODNOEBAIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, TValue> KFMFAIFJGNJ;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x57D6460", Offset = "0x57D4A60", VA = "0x1857D6460")]
	public bool OMCPIMBCGII(string BIPFMGFLODL, [Out] TValue LCIJJPPIHFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x57D64D0", Offset = "0x57D4AD0", VA = "0x1857D64D0")]
	public void PKGBKNECINL(string BIPFMGFLODL, TValue KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4C54060", Offset = "0x4C52660", VA = "0x184C54060", Slot = "4")]
	protected override void HHCEOPNNHLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x4F3F570", Offset = "0x4F3DB70", VA = "0x184F3F570", Slot = "5")]
	protected override void FLPENEOMLGG(string BIPFMGFLODL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x57D66D0", Offset = "0x57D4CD0", VA = "0x1857D66D0")]
	public OJEHIECEHKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface NPDIDFHPAKC
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool ICKKICKDNIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AMFNOLNIBCI();

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KDGKPBGFFAC(string ALIOJODOECN);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int PLDLILDNDAM(string ALIOJODOECN, int COMAGLLDBOM = 0);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PKOANOGCJLL(string ALIOJODOECN, int KKGBKLFKCPO);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool LFGBDKDJGDP(string ALIOJODOECN, bool COMAGLLDBOM = false);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CHALDNMMAHO(string ALIOJODOECN, bool KKGBKLFKCPO);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	float ELJMFNPPGMA(string ALIOJODOECN, float COMAGLLDBOM = 0f);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void ACDPEGFMCPA(string ALIOJODOECN, float KKGBKLFKCPO);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	string IEOBNAPBHHA(string ALIOJODOECN, [Optional] string COMAGLLDBOM);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JLMMJCKBFAH(string ALIOJODOECN, string KKGBKLFKCPO);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	DateTime BFEJBNDJJON(string ALIOJODOECN, [Optional] DateTime DMHNLLDLAHC);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void HBNABDLODLL(string ALIOJODOECN, DateTime DMHNLLDLAHC);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "13")]
	long BBAIDKGOOGA(string ALIOJODOECN, long COMAGLLDBOM);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void JFFLNAGDBHO(string ALIOJODOECN, long KKGBKLFKCPO);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "15")]
	T PAMNADJEDCD<T>(string ALIOJODOECN, T COMAGLLDBOM, DAKEOIAHFIL<T> AEAMJBPHPKK);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void EGPMFCLEGCP<T>(string ALIOJODOECN, T KKGBKLFKCPO, DAKEOIAHFIL<T> AEAMJBPHPKK);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void NFPKPLJDNEP(string ALIOJODOECN);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task AJPLOFDHMPK([Optional] CancellationToken KMHHNOGHBLL);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface ADOJOKKDCHB : NPDIDFHPAKC
{
	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action AIFCBIKDGGH;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task HFJBIOKNKID(long CGDBPDKMKJE, CancellationToken KMHHNOGHBLL);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface EHJJFOJHNBH : NPDIDFHPAKC
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class HINNJIAILAD : ADOJOKKDCHB, NPDIDFHPAKC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct JGNNDKPKJIE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public HINNJIAILAD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x837C6B0", Offset = "0x837ACB0", VA = "0x18837C6B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x837CA90", Offset = "0x837B090", VA = "0x18837CA90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class FIKOFEHAFDH : IEnumerator<HPILNDONOCO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private HPILNDONOCO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public HINNJIAILAD <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private HPILNDONOCO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xA4C2C0", Offset = "0xA4A8C0", VA = "0x180A4C2C0")]
		[DebuggerHidden]
		public FIKOFEHAFDH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8379D20", Offset = "0x8378320", VA = "0x188379D20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8379D90", Offset = "0x8378390", VA = "0x188379D90", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly JDKPNNELJCN KEBHLPKAEFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool MEENJPIFDGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private bool NMOGFAOOFJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private PDDCOMLIBAI IEECLMDHIGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private LLKKGNCPLNM PNBMNGOHEMO;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool ICKKICKDNIH
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA603F0", Offset = "0xA5E9F0", VA = "0x180A603F0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action AIFCBIKDGGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x837C280", Offset = "0x837A880", VA = "0x18837C280")]
	[UnityEngine.Scripting.Preserve]
	public HINNJIAILAD([GGNLMCAPMLP(null)] JDKPNNELJCN KEBHLPKAEFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "8")]
	public void AMFNOLNIBCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x837BE80", Offset = "0x837A480", VA = "0x18837BE80", Slot = "6")]
	public Task HFJBIOKNKID(long CGDBPDKMKJE, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1CCC520", Offset = "0x1CCAB20", VA = "0x181CCC520")]
	private static int KDJGONDGGOH(bool KKGBKLFKCPO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x837BFE0", Offset = "0x837A5E0", VA = "0x18837BFE0", Slot = "9")]
	public bool KDGKPBGFFAC(string ALIOJODOECN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x837C250", Offset = "0x837A850", VA = "0x18837C250", Slot = "10")]
	public int PLDLILDNDAM(string ALIOJODOECN, int COMAGLLDBOM = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x837C220", Offset = "0x837A820", VA = "0x18837C220", Slot = "11")]
	public void PKOANOGCJLL(string ALIOJODOECN, int KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x837C070", Offset = "0x837A670", VA = "0x18837C070", Slot = "12")]
	public bool LFGBDKDJGDP(string ALIOJODOECN, bool COMAGLLDBOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x837BC70", Offset = "0x837A270", VA = "0x18837BC70", Slot = "13")]
	public void CHALDNMMAHO(string ALIOJODOECN, bool KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x837BCC0", Offset = "0x837A2C0", VA = "0x18837BCC0", Slot = "14")]
	public float ELJMFNPPGMA(string ALIOJODOECN, float COMAGLLDBOM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x837BA70", Offset = "0x837A070", VA = "0x18837BA70", Slot = "15")]
	public void ACDPEGFMCPA(string ALIOJODOECN, float KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x837BC00", Offset = "0x837A200", VA = "0x18837BC00", Slot = "18")]
	public DateTime BFEJBNDJJON(string ALIOJODOECN, [Optional] DateTime COMAGLLDBOM)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x837BE10", Offset = "0x837A410", VA = "0x18837BE10", Slot = "19")]
	public void HBNABDLODLL(string ALIOJODOECN, DateTime DMHNLLDLAHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x837BB90", Offset = "0x837A190", VA = "0x18837BB90", Slot = "20")]
	public long BBAIDKGOOGA(string ALIOJODOECN, long COMAGLLDBOM)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x837BF40", Offset = "0x837A540", VA = "0x18837BF40", Slot = "21")]
	public void JFFLNAGDBHO(string ALIOJODOECN, long KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3B64960", Offset = "0x3B62F60", VA = "0x183B64960", Slot = "22")]
	public T PAMNADJEDCD<T>(string ALIOJODOECN, T COMAGLLDBOM, DAKEOIAHFIL<T> AEAMJBPHPKK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3B637D0", Offset = "0x3B61DD0", VA = "0x183B637D0", Slot = "23")]
	public void EGPMFCLEGCP<T>(string ALIOJODOECN, T KKGBKLFKCPO, DAKEOIAHFIL<T> AEAMJBPHPKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3B63900", Offset = "0x3B61F00", VA = "0x183B63900")]
	private T IODAEBANBOD<T>(string ALIOJODOECN, T COMAGLLDBOM, [Optional] DAKEOIAHFIL<T> IHMPAIIHCAP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3B64350", Offset = "0x3B62950", VA = "0x183B64350")]
	private void MEIGMDJEEJA<T>(string ALIOJODOECN, T KKGBKLFKCPO, [Optional] DAKEOIAHFIL<T> IHMPAIIHCAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x837BF10", Offset = "0x837A510", VA = "0x18837BF10", Slot = "16")]
	public string IEOBNAPBHHA(string ALIOJODOECN, string COMAGLLDBOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x837BFB0", Offset = "0x837A5B0", VA = "0x18837BFB0", Slot = "17")]
	public void JLMMJCKBFAH(string ALIOJODOECN, string KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x837BCA0", Offset = "0x837A2A0", VA = "0x18837BCA0")]
	private void CNGDLBFGFFP(string ALIOJODOECN, string KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x837BCF0", Offset = "0x837A2F0", VA = "0x18837BCF0")]
	private string EOBEHGDEGDH(string ALIOJODOECN, string COMAGLLDBOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x837C0A0", Offset = "0x837A6A0", VA = "0x18837C0A0", Slot = "24")]
	public void NFPKPLJDNEP(string ALIOJODOECN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x837BD10", Offset = "0x837A310", VA = "0x18837BD10")]
	private string FJHFFAMDNIP(string BLIBAMJKLIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x837BAA0", Offset = "0x837A0A0", VA = "0x18837BAA0", Slot = "25")]
	[AsyncStateMachine(typeof(JGNNDKPKJIE))]
	public Task AJPLOFDHMPK(CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x837C130", Offset = "0x837A730", VA = "0x18837C130")]
	[IteratorStateMachine(typeof(FIKOFEHAFDH))]
	private IEnumerator<HPILNDONOCO> NHPHNAPBDKF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x837BDB0", Offset = "0x837A3B0", VA = "0x18837BDB0")]
	private void GCIOKMHDFPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x837C000", Offset = "0x837A600", VA = "0x18837C000")]
	private void LDFGCGMCCPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x837C1B0", Offset = "0x837A7B0", VA = "0x18837C1B0")]
	private void PEOBHJODONI(bool GCFPCCBIFGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class AABPAMOMIBM : ADOJOKKDCHB, NPDIDFHPAKC
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
	private Dictionary<string, string> ALJPNJBBKPB;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool ICKKICKDNIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xA603F0", Offset = "0xA5E9F0", VA = "0x180A603F0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private string AJPHBINIDML
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x83792D0", Offset = "0x83778D0", VA = "0x1883792D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private Dictionary<string, string> APPOJJPDKGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8379840", Offset = "0x8377E40", VA = "0x188379840")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action AIFCBIKDGGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	[UnityEngine.Scripting.Preserve]
	public AABPAMOMIBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "8")]
	public void AMFNOLNIBCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x8379490", Offset = "0x8377A90", VA = "0x188379490", Slot = "6")]
	public Task HFJBIOKNKID(long CGDBPDKMKJE, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x83793B0", Offset = "0x83779B0", VA = "0x1883793B0", Slot = "14")]
	public float ELJMFNPPGMA(string BLIBAMJKLIA, float COMAGLLDBOM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x8379340", Offset = "0x8377940", VA = "0x188379340", Slot = "13")]
	public void CHALDNMMAHO(string BLIBAMJKLIA, bool KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x8379770", Offset = "0x8377D70", VA = "0x188379770", Slot = "12")]
	public bool LFGBDKDJGDP(string BLIBAMJKLIA, bool COMAGLLDBOM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x8379CB0", Offset = "0x83782B0", VA = "0x188379CB0", Slot = "10")]
	public int PLDLILDNDAM(string BLIBAMJKLIA, int COMAGLLDBOM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x8379260", Offset = "0x8377860", VA = "0x188379260", Slot = "18")]
	public DateTime BFEJBNDJJON(string ALIOJODOECN, [Optional] DateTime COMAGLLDBOM)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x8379420", Offset = "0x8377A20", VA = "0x188379420", Slot = "19")]
	public void HBNABDLODLL(string BLIBAMJKLIA, DateTime KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x8378F10", Offset = "0x8377510", VA = "0x188378F10", Slot = "15")]
	public void ACDPEGFMCPA(string BLIBAMJKLIA, float KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x8379C40", Offset = "0x8378240", VA = "0x188379C40", Slot = "11")]
	public void PKOANOGCJLL(string BLIBAMJKLIA, int KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x83791F0", Offset = "0x83777F0", VA = "0x1883791F0", Slot = "20")]
	public long BBAIDKGOOGA(string ALIOJODOECN, long COMAGLLDBOM)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x83795D0", Offset = "0x8377BD0", VA = "0x1883795D0", Slot = "21")]
	public void JFFLNAGDBHO(string ALIOJODOECN, long KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x30ACC60", Offset = "0x30AB260", VA = "0x1830ACC60", Slot = "22")]
	public T PAMNADJEDCD<T>(string ALIOJODOECN, T COMAGLLDBOM, DAKEOIAHFIL<T> AEAMJBPHPKK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x30ABA70", Offset = "0x30AA070", VA = "0x1830ABA70", Slot = "23")]
	public void EGPMFCLEGCP<T>(string ALIOJODOECN, T KKGBKLFKCPO, DAKEOIAHFIL<T> AEAMJBPHPKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x8379520", Offset = "0x8377B20", VA = "0x188379520", Slot = "16")]
	public string IEOBNAPBHHA(string BLIBAMJKLIA, string COMAGLLDBOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x8379640", Offset = "0x8377C40", VA = "0x188379640", Slot = "17")]
	public void JLMMJCKBFAH(string BLIBAMJKLIA, string KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x8379880", Offset = "0x8377E80", VA = "0x188379880", Slot = "24")]
	public void NFPKPLJDNEP(string BLIBAMJKLIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x83796E0", Offset = "0x8377CE0", VA = "0x1883796E0", Slot = "9")]
	public bool KDGKPBGFFAC(string BLIBAMJKLIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x8378F80", Offset = "0x8377580", VA = "0x188378F80", Slot = "25")]
	public Task AJPLOFDHMPK(CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x30ABB10", Offset = "0x30AA110", VA = "0x1830ABB10")]
	private T KBGIPADPFGF<T>(string ALIOJODOECN, T COMAGLLDBOM, [Optional] DAKEOIAHFIL<T> IHMPAIIHCAP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x30AAB30", Offset = "0x30A9130", VA = "0x1830AAB30")]
	private void BNAKHNGOEHD<T>(string ALIOJODOECN, T KKGBKLFKCPO, [Optional] DAKEOIAHFIL<T> IHMPAIIHCAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x8379940", Offset = "0x8377F40", VA = "0x188379940")]
	private Dictionary<string, string> OODCDNAFGAE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface EBGNLCHEEDD
{
	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action AIFCBIKDGGH;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AMFNOLNIBCI();

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task HIMALIBDDPN(long CGDBPDKMKJE);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool AAMBDNEMKHL(BLINJCMFIIA BIDGGOOPHHO = BLINJCMFIIA.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool IOILCGGCCND(string ALIOJODOECN, BLINJCMFIIA HJHIEJIIPID = BLINJCMFIIA.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool FBJAIDPNIPA(string ALIOJODOECN, BLINJCMFIIA HJHIEJIIPID = BLINJCMFIIA.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "7")]
	string BBIGFNMEIPH(string ALIOJODOECN, [Optional] string COMAGLLDBOM, BLINJCMFIIA HJHIEJIIPID = BLINJCMFIIA.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	ICMIHDKAKPF LIJOKCDKEIA(string ALIOJODOECN, string KKGBKLFKCPO, BLINJCMFIIA HJHIEJIIPID = BLINJCMFIIA.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	int OKGBEBCANPA(string ALIOJODOECN, int COMAGLLDBOM = 0, BLINJCMFIIA HJHIEJIIPID = BLINJCMFIIA.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	ICMIHDKAKPF PHPAIDKJANK(string ALIOJODOECN, int KKGBKLFKCPO, BLINJCMFIIA HJHIEJIIPID = BLINJCMFIIA.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CHMHCDMKECE(string ALIOJODOECN, bool COMAGLLDBOM, BLINJCMFIIA HJHIEJIIPID = BLINJCMFIIA.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "12")]
	ICMIHDKAKPF OHKAPHALOGB(string ALIOJODOECN, bool KKGBKLFKCPO, BLINJCMFIIA HJHIEJIIPID = BLINJCMFIIA.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float KGKLJIKLOMI(string ALIOJODOECN, float COMAGLLDBOM = 0f, BLINJCMFIIA HJHIEJIIPID = BLINJCMFIIA.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "14")]
	ICMIHDKAKPF ONCAIEPPIKK(string ALIOJODOECN, float KKGBKLFKCPO, BLINJCMFIIA HJHIEJIIPID = BLINJCMFIIA.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "15")]
	DateTime BLJPCGPBHHI(string ALIOJODOECN, [Optional] DateTime COMAGLLDBOM, BLINJCMFIIA HJHIEJIIPID = BLINJCMFIIA.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	ICMIHDKAKPF EKEILAANPCM(string ALIOJODOECN, DateTime KKGBKLFKCPO, BLINJCMFIIA HJHIEJIIPID = BLINJCMFIIA.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "17")]
	long ODAJGPFPGJM(string ALIOJODOECN, long COMAGLLDBOM = 0L, BLINJCMFIIA HJHIEJIIPID = BLINJCMFIIA.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "18")]
	ICMIHDKAKPF JACLPKIJGCA(string ALIOJODOECN, long KKGBKLFKCPO, BLINJCMFIIA HJHIEJIIPID = BLINJCMFIIA.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "19")]
	T BNHLIMBNIJG<T>(string ALIOJODOECN, [Optional] T COMAGLLDBOM, BLINJCMFIIA HJHIEJIIPID = BLINJCMFIIA.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "20")]
	ICMIHDKAKPF DLLLDEIFFPB<T>(string ALIOJODOECN, T KKGBKLFKCPO, BLINJCMFIIA HJHIEJIIPID = BLINJCMFIIA.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool NOMEOCGBODN(string ALIOJODOECN);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool EFCEGNKBBNN(string ALIOJODOECN);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "23")]
	string CHPOBGGOGCB(string ALIOJODOECN, [Optional] string COMAGLLDBOM);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "24")]
	ICMIHDKAKPF OOAKOKDBINL(string ALIOJODOECN, string KKGBKLFKCPO);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "25")]
	int AIKJKMCPEAN(string ALIOJODOECN, int COMAGLLDBOM = 0);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "26")]
	ICMIHDKAKPF EIPJNODANNG(string ALIOJODOECN, int KKGBKLFKCPO);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool INFAPDEALGB(string ALIOJODOECN, bool COMAGLLDBOM);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "28")]
	ICMIHDKAKPF PKBIBOJCFMB(string ALIOJODOECN, bool KKGBKLFKCPO);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "29")]
	float IDJIECMCAHF(string ALIOJODOECN, float COMAGLLDBOM = 0f);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "30")]
	ICMIHDKAKPF FLPLOBFDNOL(string ALIOJODOECN, float KKGBKLFKCPO);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "31")]
	DateTime FILBMAKOIMN(string ALIOJODOECN, [Optional] DateTime COMAGLLDBOM);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "32")]
	ICMIHDKAKPF GKAHEJMJGFM(string ALIOJODOECN, DateTime KKGBKLFKCPO);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "33")]
	long NELPHOJBIBF(string ALIOJODOECN, long COMAGLLDBOM = 0L);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "34")]
	ICMIHDKAKPF FPGGLEHGILD(string ALIOJODOECN, long KKGBKLFKCPO);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void KLMFGLNCPJD<T>(DAKEOIAHFIL<T> AEAMJBPHPKK, [Optional] IEqualityComparer<T> NJKFJEICBEB);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void MBKPEAEOCEK<T>();

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "37")]
	IDisposable OPDBBIDEJIO();

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void FCBDAAOBHDD(float BKONJIDKCPP);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task GCIOKMHDFPF([Optional] CancellationToken KMHHNOGHBLL);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum ICMIHDKAKPF : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	Unchanged,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	New,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Changed
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class PFFGPHGFEEN : EBGNLCHEEDD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private abstract class OIDPHIGCNEB
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		protected static readonly HashSet<OIDPHIGCNEB> HCJLKANGAGJ;

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x837E820", Offset = "0x837CE20", VA = "0x18837E820")]
		public static void GPDNGNKKMHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void HHCEOPNNHLH();

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		protected OIDPHIGCNEB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private class HKDJNOFJEBA<T> : OIDPHIGCNEB
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly HKDJNOFJEBA<T> FNIBPMLJKFE;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public DAKEOIAHFIL<T> CGKCPPODIBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public IEqualityComparer<T> ODBLDJEIKGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool GMGELBLIAGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x47509B0", Offset = "0x474EFB0", VA = "0x1847509B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x4E19DD0", Offset = "0x4E183D0", VA = "0x184E19DD0")]
		private HKDJNOFJEBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x4E19AE0", Offset = "0x4E180E0", VA = "0x184E19AE0")]
		public void CCHHFLKMKEK(DAKEOIAHFIL<T> IHMPAIIHCAP, [Optional] IEqualityComparer<T> NJKFJEICBEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x4E19C50", Offset = "0x4E18250", VA = "0x184E19C50", Slot = "4")]
		public override void HHCEOPNNHLH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private class JLKFBJAAIGL : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private readonly PFFGPHGFEEN EBKIOEENHEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly object PIALHDCIFEN;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x837CCB0", Offset = "0x837B2B0", VA = "0x18837CCB0")]
		public JLKFBJAAIGL(PFFGPHGFEEN EBKIOEENHEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x837CC80", Offset = "0x837B280", VA = "0x18837CC80", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct IMAEEKDBACD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public PFFGPHGFEEN <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x837C370", Offset = "0x837A970", VA = "0x18837C370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x837C650", Offset = "0x837AC50", VA = "0x18837C650", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct JJMAMDHEMHF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public PFFGPHGFEEN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public NPDIDFHPAKC backingStoreToSave;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x837CAF0", Offset = "0x837B0F0", VA = "0x18837CAF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0xAA6DB0", Offset = "0xAA53B0", VA = "0x180AA6DB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private struct NAKGJEJCDGD : IAsyncStateMachine
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
		public PFFGPHGFEEN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x837E210", Offset = "0x837C810", VA = "0x18837E210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x837E6E0", Offset = "0x837CCE0", VA = "0x18837E6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class OGGFDDIPBLI : IEnumerator<HPILNDONOCO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private HPILNDONOCO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public PFFGPHGFEEN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public float seconds;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private HPILNDONOCO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xA4C2C0", Offset = "0xA4A8C0", VA = "0x180A4C2C0")]
		[DebuggerHidden]
		public OGGFDDIPBLI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x837E740", Offset = "0x837CD40", VA = "0x18837E740", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x837E7D0", Offset = "0x837CDD0", VA = "0x18837E7D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly ADOJOKKDCHB FAFBHOCIGPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly ADOJOKKDCHB MGOFHCFPAIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly EHJJFOJHNBH KAKDBENGGBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly PDDCOMLIBAI IEECLMDHIGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly KLKOKCEMLLM.IGFPMFHLHCK HFPDACOPJPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly GAEGCDCBFLB OACPKEKONGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly HashSet<NPDIDFHPAKC> IDLCOLAOAOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private Task EOCJFOIFDNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private Dictionary<string, string> OKPPBMDOHMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private LLKKGNCPLNM IBDGOICBMFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly object DIDJBHEEIGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly object BMLCBBHBENC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private long HOJABAOBPAP;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private bool OPIMGAPLOCN
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8380B90", Offset = "0x837F190", VA = "0x188380B90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private CancellationTokenSource MAMFKFONHEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xA44960", Offset = "0xA42F60", VA = "0x180A44960")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xA449C0", Offset = "0xA42FC0", VA = "0x180A449C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action AIFCBIKDGGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x837FD60", Offset = "0x837E360", VA = "0x18837FD60", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x837EE50", Offset = "0x837D450", VA = "0x18837EE50", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x8381030", Offset = "0x837F630", VA = "0x188381030")]
	[BNHIEDNKDNA.MLFEBCDGLFC]
	internal static void ODEMOKCFLLI(DCNOMJHNEOK FAIEEFHMPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x8381850", Offset = "0x837FE50", VA = "0x188381850")]
	[UnityEngine.Scripting.Preserve]
	public PFFGPHGFEEN([GGNLMCAPMLP("Disk")] ADOJOKKDCHB FAFBHOCIGPL, [GGNLMCAPMLP("Cloud")] ADOJOKKDCHB MGOFHCFPAIN, [GGNLMCAPMLP(null)] EHJJFOJHNBH KAKDBENGGBH, [GGNLMCAPMLP(null)] PDDCOMLIBAI IEECLMDHIGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x837F2A0", Offset = "0x837D8A0", VA = "0x18837F2A0", Slot = "44")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x837F0F0", Offset = "0x837D6F0", VA = "0x18837F0F0")]
	private void DPEPPCOKEGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x837ECA0", Offset = "0x837D2A0", VA = "0x18837ECA0", Slot = "6")]
	public void AMFNOLNIBCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x837FB20", Offset = "0x837E120", VA = "0x18837FB20", Slot = "7")]
	public Task HIMALIBDDPN(long CGDBPDKMKJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x837F990", Offset = "0x837DF90", VA = "0x18837F990")]
	[AsyncStateMachine(typeof(IMAEEKDBACD))]
	private Task HBEMEINLPLD(long CGDBPDKMKJE, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x837F070", Offset = "0x837D670", VA = "0x18837F070")]
	private void DFNMHKLJGLB(object DKFMAIJGPFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x837EAB0", Offset = "0x837D0B0", VA = "0x18837EAB0")]
	private void ABDDJAAMHOF(object DKFMAIJGPFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x837F010", Offset = "0x837D610", VA = "0x18837F010")]
	private string CMEKAOALADK(string OANHPIOJGDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x8380680", Offset = "0x837EC80", VA = "0x188380680")]
	private void KLKIJHILFIJ(BLINJCMFIIA BIDGGOOPHHO, string BLIBAMJKLIA, [Out] ADOJOKKDCHB OIEADCGADLH, [Out] string BHNEHBCNKJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x837FAA0", Offset = "0x837E0A0", VA = "0x18837FAA0")]
	private ADOJOKKDCHB HFDMDANAKHA(BLINJCMFIIA BIDGGOOPHHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x837E9F0", Offset = "0x837CFF0", VA = "0x18837E9F0", Slot = "8")]
	public bool AAMBDNEMKHL(BLINJCMFIIA BIDGGOOPHHO = BLINJCMFIIA.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x837FE70", Offset = "0x837E470", VA = "0x18837FE70", Slot = "9")]
	public bool IOILCGGCCND(string ALIOJODOECN, BLINJCMFIIA HJHIEJIIPID = BLINJCMFIIA.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x837F4C0", Offset = "0x837DAC0", VA = "0x18837F4C0", Slot = "10")]
	public bool FBJAIDPNIPA(string ALIOJODOECN, BLINJCMFIIA HJHIEJIIPID = BLINJCMFIIA.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x837ED10", Offset = "0x837D310", VA = "0x18837ED10", Slot = "11")]
	public string BBIGFNMEIPH(string ALIOJODOECN, [Optional] string COMAGLLDBOM, BLINJCMFIIA HJHIEJIIPID = BLINJCMFIIA.CLOUD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x8380A00", Offset = "0x837F000", VA = "0x188380A00", Slot = "12")]
	public ICMIHDKAKPF LIJOKCDKEIA(string ALIOJODOECN, string KKGBKLFKCPO, BLINJCMFIIA HJHIEJIIPID = BLINJCMFIIA.CLOUD)
	{
		return default(ICMIHDKAKPF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x8381360", Offset = "0x837F960", VA = "0x188381360", Slot = "13")]
	public int OKGBEBCANPA(string ALIOJODOECN, int COMAGLLDBOM = 0, BLINJCMFIIA HJHIEJIIPID = BLINJCMFIIA.CLOUD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x83816A0", Offset = "0x837FCA0", VA = "0x1883816A0", Slot = "14")]
	public ICMIHDKAKPF PHPAIDKJANK(string ALIOJODOECN, int KKGBKLFKCPO, BLINJCMFIIA HJHIEJIIPID = BLINJCMFIIA.CLOUD)
	{
		return default(ICMIHDKAKPF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x837EEF0", Offset = "0x837D4F0", VA = "0x18837EEF0", Slot = "15")]
	public bool CHMHCDMKECE(string ALIOJODOECN, bool COMAGLLDBOM, BLINJCMFIIA HJHIEJIIPID = BLINJCMFIIA.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x83811E0", Offset = "0x837F7E0", VA = "0x1883811E0", Slot = "16")]
	public ICMIHDKAKPF OHKAPHALOGB(string ALIOJODOECN, bool KKGBKLFKCPO, BLINJCMFIIA HJHIEJIIPID = BLINJCMFIIA.CLOUD)
	{
		return default(ICMIHDKAKPF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x8380320", Offset = "0x837E920", VA = "0x188380320", Slot = "17")]
	public float KGKLJIKLOMI(string ALIOJODOECN, float COMAGLLDBOM = 0f, BLINJCMFIIA HJHIEJIIPID = BLINJCMFIIA.CLOUD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x8381410", Offset = "0x837FA10", VA = "0x188381410", Slot = "18")]
	public ICMIHDKAKPF ONCAIEPPIKK(string ALIOJODOECN, float KKGBKLFKCPO, BLINJCMFIIA HJHIEJIIPID = BLINJCMFIIA.CLOUD)
	{
		return default(ICMIHDKAKPF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x837EDB0", Offset = "0x837D3B0", VA = "0x18837EDB0", Slot = "19")]
	public DateTime BLJPCGPBHHI(string ALIOJODOECN, [Optional] DateTime COMAGLLDBOM, BLINJCMFIIA HJHIEJIIPID = BLINJCMFIIA.CLOUD)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x837F320", Offset = "0x837D920", VA = "0x18837F320", Slot = "20")]
	public ICMIHDKAKPF EKEILAANPCM(string ALIOJODOECN, DateTime KKGBKLFKCPO, BLINJCMFIIA HJHIEJIIPID = BLINJCMFIIA.CLOUD)
	{
		return default(ICMIHDKAKPF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x8380F90", Offset = "0x837F590", VA = "0x188380F90", Slot = "21")]
	public long ODAJGPFPGJM(string ALIOJODOECN, long COMAGLLDBOM = 0L, BLINJCMFIIA HJHIEJIIPID = BLINJCMFIIA.CLOUD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x837FF10", Offset = "0x837E510", VA = "0x18837FF10", Slot = "22")]
	public ICMIHDKAKPF JACLPKIJGCA(string ALIOJODOECN, long KKGBKLFKCPO, BLINJCMFIIA HJHIEJIIPID = BLINJCMFIIA.CLOUD)
	{
		return default(ICMIHDKAKPF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x3CFA880", Offset = "0x3CF8E80", VA = "0x183CFA880", Slot = "23")]
	public T BNHLIMBNIJG<T>(string ALIOJODOECN, [Optional] T COMAGLLDBOM, BLINJCMFIIA HJHIEJIIPID = BLINJCMFIIA.CLOUD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x3CFA880", Offset = "0x3CF8E80", VA = "0x183CFA880", Slot = "24")]
	public ICMIHDKAKPF DLLLDEIFFPB<T>(string ALIOJODOECN, T KKGBKLFKCPO, BLINJCMFIIA HJHIEJIIPID = BLINJCMFIIA.CLOUD)
	{
		return default(ICMIHDKAKPF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x8380F30", Offset = "0x837F530", VA = "0x188380F30", Slot = "25")]
	public bool NOMEOCGBODN(string ALIOJODOECN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x837F2E0", Offset = "0x837D8E0", VA = "0x18837F2E0", Slot = "26")]
	public bool EFCEGNKBBNN(string ALIOJODOECN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x837EFA0", Offset = "0x837D5A0", VA = "0x18837EFA0", Slot = "27")]
	public string CHPOBGGOGCB(string ALIOJODOECN, [Optional] string COMAGLLDBOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x8381590", Offset = "0x837FB90", VA = "0x188381590", Slot = "28")]
	public ICMIHDKAKPF OOAKOKDBINL(string ALIOJODOECN, string KKGBKLFKCPO)
	{
		return default(ICMIHDKAKPF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x837EB60", Offset = "0x837D160", VA = "0x18837EB60", Slot = "29")]
	public int AIKJKMCPEAN(string ALIOJODOECN, int COMAGLLDBOM = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x837F2F0", Offset = "0x837D8F0", VA = "0x18837F2F0", Slot = "30")]
	public ICMIHDKAKPF EIPJNODANNG(string ALIOJODOECN, int KKGBKLFKCPO)
	{
		return default(ICMIHDKAKPF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x837FE00", Offset = "0x837E400", VA = "0x18837FE00", Slot = "31")]
	public bool INFAPDEALGB(string ALIOJODOECN, bool COMAGLLDBOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x8381820", Offset = "0x837FE20", VA = "0x188381820", Slot = "32")]
	public ICMIHDKAKPF PKBIBOJCFMB(string ALIOJODOECN, bool KKGBKLFKCPO)
	{
		return default(ICMIHDKAKPF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x837FCF0", Offset = "0x837E2F0", VA = "0x18837FCF0", Slot = "33")]
	public float IDJIECMCAHF(string ALIOJODOECN, float COMAGLLDBOM = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x837F6C0", Offset = "0x837DCC0", VA = "0x18837F6C0", Slot = "34")]
	public ICMIHDKAKPF FLPLOBFDNOL(string ALIOJODOECN, float KKGBKLFKCPO)
	{
		return default(ICMIHDKAKPF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x837F650", Offset = "0x837DC50", VA = "0x18837F650", Slot = "35")]
	public DateTime FILBMAKOIMN(string ALIOJODOECN, [Optional] DateTime COMAGLLDBOM)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x837F960", Offset = "0x837DF60", VA = "0x18837F960", Slot = "36")]
	public ICMIHDKAKPF GKAHEJMJGFM(string ALIOJODOECN, DateTime KKGBKLFKCPO)
	{
		return default(ICMIHDKAKPF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x8380E30", Offset = "0x837F430", VA = "0x188380E30", Slot = "37")]
	public long NELPHOJBIBF(string ALIOJODOECN, long COMAGLLDBOM = 0L)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x837F6F0", Offset = "0x837DCF0", VA = "0x18837F6F0", Slot = "38")]
	public ICMIHDKAKPF FPGGLEHGILD(string ALIOJODOECN, long KKGBKLFKCPO)
	{
		return default(ICMIHDKAKPF);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x837F090", Offset = "0x837D690", VA = "0x18837F090")]
	private bool DIHBJBKHMNI(NPDIDFHPAKC OIEADCGADLH, string ALIOJODOECN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x837F140", Offset = "0x837D740", VA = "0x18837F140")]
	private bool DPNBOAHKLBB(NPDIDFHPAKC OIEADCGADLH, string ALIOJODOECN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x837F810", Offset = "0x837DE10", VA = "0x18837F810")]
	private ICMIHDKAKPF GDBKJBMIKLN(NPDIDFHPAKC OIEADCGADLH, string ALIOJODOECN, string KKGBKLFKCPO)
	{
		return default(ICMIHDKAKPF);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x8380540", Offset = "0x837EB40", VA = "0x188380540")]
	private ICMIHDKAKPF KKOGIICLAIJ(NPDIDFHPAKC OIEADCGADLH, string ALIOJODOECN, int KKGBKLFKCPO)
	{
		return default(ICMIHDKAKPF);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x83810A0", Offset = "0x837F6A0", VA = "0x1883810A0")]
	private ICMIHDKAKPF OEFADIDFFOF(NPDIDFHPAKC OIEADCGADLH, string ALIOJODOECN, bool KKGBKLFKCPO)
	{
		return default(ICMIHDKAKPF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x8380090", Offset = "0x837E690", VA = "0x188380090")]
	private ICMIHDKAKPF JKBAOGAGMHH(NPDIDFHPAKC OIEADCGADLH, string ALIOJODOECN, float KKGBKLFKCPO)
	{
		return default(ICMIHDKAKPF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x83803D0", Offset = "0x837E9D0", VA = "0x1883803D0")]
	private ICMIHDKAKPF KJBKDOAEGCM(NPDIDFHPAKC OIEADCGADLH, string ALIOJODOECN, DateTime KKGBKLFKCPO)
	{
		return default(ICMIHDKAKPF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x83801E0", Offset = "0x837E7E0", VA = "0x1883801E0")]
	private ICMIHDKAKPF KEPFANOIFNI(NPDIDFHPAKC OIEADCGADLH, string ALIOJODOECN, long KKGBKLFKCPO)
	{
		return default(ICMIHDKAKPF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x3CFAC40", Offset = "0x3CF9240", VA = "0x183CFAC40")]
	private T KNLEHINGHJP<T>(NPDIDFHPAKC OIEADCGADLH, string ALIOJODOECN, T COMAGLLDBOM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x3CFB1C0", Offset = "0x3CF97C0", VA = "0x183CFB1C0")]
	private ICMIHDKAKPF PKINNDHAFPK<T>(NPDIDFHPAKC OIEADCGADLH, string ALIOJODOECN, T KKGBKLFKCPO)
	{
		return default(ICMIHDKAKPF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3CFABA0", Offset = "0x3CF91A0", VA = "0x183CFABA0", Slot = "39")]
	public void KLMFGLNCPJD<T>(DAKEOIAHFIL<T> AEAMJBPHPKK, [Optional] IEqualityComparer<T> NJKFJEICBEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3CFB140", Offset = "0x3CF9740", VA = "0x183CFB140", Slot = "40")]
	public void MBKPEAEOCEK<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x837EBD0", Offset = "0x837D1D0", VA = "0x18837EBD0")]
	[AsyncStateMachine(typeof(JJMAMDHEMHF))]
	private void AJPLOFDHMPK(NPDIDFHPAKC EMPEGIFMFNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x837F720", Offset = "0x837DD20", VA = "0x18837F720", Slot = "43")]
	[AsyncStateMachine(typeof(NAKGJEJCDGD))]
	public Task GCIOKMHDFPF([Optional] CancellationToken DKFMAIJGPFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x8380820", Offset = "0x837EE20", VA = "0x188380820")]
	private void KOILJCIBFME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x83815C0", Offset = "0x837FBC0", VA = "0x1883815C0", Slot = "41")]
	public IDisposable OPDBBIDEJIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x837F640", Offset = "0x837DC40", VA = "0x18837F640", Slot = "42")]
	public void FCBDAAOBHDD(float BKONJIDKCPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x8380BB0", Offset = "0x837F1B0", VA = "0x188380BB0")]
	private void NBNDOAPOOGN(float JOGLIEGMMNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x8380EA0", Offset = "0x837F4A0", VA = "0x188380EA0")]
	[IteratorStateMachine(typeof(OGGFDDIPBLI))]
	private IEnumerator<HPILNDONOCO> NJALKANNOHB(float BKONJIDKCPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x837EB30", Offset = "0x837D130", VA = "0x18837EB30")]
	[CompilerGenerated]
	private void ADDLMEMNMPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class KNEOPHMMHIJ : ODILPPNGKKC<bool>
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static KNEOPHMMHIJ FNIBPMLJKFE
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x837DA80", Offset = "0x837C080", VA = "0x18837DA80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x837D990", Offset = "0x837BF90", VA = "0x18837D990", Slot = "9")]
	public override string LGGJGPOGIBH(bool FCHACHIDAGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x837D710", Offset = "0x837BD10", VA = "0x18837D710", Slot = "10")]
	protected override bool JHKPHHHKKLH(string FCHACHIDAGA, [Out] bool KKGBKLFKCPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x837DB70", Offset = "0x837C170", VA = "0x18837DB70")]
	public KNEOPHMMHIJ()
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

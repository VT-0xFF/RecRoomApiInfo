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
		[Cpp2IlInjected.Address(RVA = "0x77C3660", Offset = "0x77C2A60", VA = "0x1877C3660", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x242AF30", Offset = "0x242A330", VA = "0x18242AF30")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum BELLPEALDFB : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	CLOUD,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	DISK
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
internal static class JLEJEHNECDC
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	internal delegate void LIGMHAMDHFC(OOIIJJALPGP IDIFDJHFLBD);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x77C06D0", Offset = "0x77BFAD0", VA = "0x1877C06D0")]
	private static void NEFGKHPAJJO(OOIIJJALPGP IDIFDJHFLBD, LIGMHAMDHFC DOPJJMLPPOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x77BFD90", Offset = "0x77BF190", VA = "0x1877BFD90")]
	public static bool ADMKFDOLBAC(this OOIIJJALPGP IDIFDJHFLBD, string BPEJALFMHHI, [Optional] LIGMHAMDHFC DOPJJMLPPOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x77BFEF0", Offset = "0x77BF2F0", VA = "0x1877BFEF0")]
	public static EFMPBLEPGLL AHBKMKLCAIA(this OOIIJJALPGP IDIFDJHFLBD, string BPEJALFMHHI, string KBGCCIOIGBD, [Optional] LIGMHAMDHFC DOPJJMLPPOB)
	{
		return default(EFMPBLEPGLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x77C0040", Offset = "0x77BF440", VA = "0x1877C0040")]
	public static EFMPBLEPGLL AMAPGPMJKEI(this OOIIJJALPGP IDIFDJHFLBD, string BPEJALFMHHI, int KBGCCIOIGBD, [Optional] LIGMHAMDHFC DOPJJMLPPOB)
	{
		return default(EFMPBLEPGLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x77C0410", Offset = "0x77BF810", VA = "0x1877C0410")]
	public static EFMPBLEPGLL MGBHBLMFDJP(this OOIIJJALPGP IDIFDJHFLBD, string BPEJALFMHHI, bool KBGCCIOIGBD, [Optional] LIGMHAMDHFC DOPJJMLPPOB)
	{
		return default(EFMPBLEPGLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x77C02C0", Offset = "0x77BF6C0", VA = "0x1877C02C0")]
	public static EFMPBLEPGLL KIHIGFFMPCH(this OOIIJJALPGP IDIFDJHFLBD, string BPEJALFMHHI, float KBGCCIOIGBD, [Optional] LIGMHAMDHFC DOPJJMLPPOB)
	{
		return default(EFMPBLEPGLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x77C0560", Offset = "0x77BF960", VA = "0x1877C0560")]
	public static EFMPBLEPGLL MJMGBIFCDDG(this OOIIJJALPGP IDIFDJHFLBD, string BPEJALFMHHI, DateTime KBGCCIOIGBD, [Optional] LIGMHAMDHFC DOPJJMLPPOB)
	{
		return default(EFMPBLEPGLL);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x77C0180", Offset = "0x77BF580", VA = "0x1877C0180")]
	public static EFMPBLEPGLL IOKPBGLFPJM(this OOIIJJALPGP IDIFDJHFLBD, string BPEJALFMHHI, long KBGCCIOIGBD, [Optional] LIGMHAMDHFC DOPJJMLPPOB)
	{
		return default(EFMPBLEPGLL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class KAEJPMKDCJD : BDNIPAJKPBI, OOIIJJALPGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly OMKIPBLMPOD LDNAHMLEOCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<string, byte> JJIDPDFEPGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private Dictionary<string, string> CFFOECLBAEB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool KFMLNKJFEGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x965500", Offset = "0x964900", VA = "0x180965500", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Dictionary<string, string> CEFDNNBHJAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x77C0750", Offset = "0x77BFB50", VA = "0x1877C0750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action LHNDGNLJDDE
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x77C22E0", Offset = "0x77C16E0", VA = "0x1877C22E0")]
	[UnityEngine.Scripting.Preserve]
	public KAEJPMKDCJD([IBJCGEMJMJL(null)] OMKIPBLMPOD LDNAHMLEOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "8")]
	public void ANIHLAKBIIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x77C1C40", Offset = "0x77C1040", VA = "0x1877C1C40")]
	private DirectoryInfo JMMJHDIBEBF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x77C1BB0", Offset = "0x77C0FB0", VA = "0x1877C1BB0", Slot = "6")]
	public Task JCPBIKGMJJI(long CCFNJEFBKEA, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x77C0800", Offset = "0x77BFC00", VA = "0x1877C0800", Slot = "14")]
	public float BOBHPPGGGMC(string LKMGECEEGEE, float IDJBNLNBJCD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x77C2020", Offset = "0x77C1420", VA = "0x1877C2020", Slot = "13")]
	public void LHIIHHKDLOM(string LKMGECEEGEE, bool KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x77C08E0", Offset = "0x77BFCE0", VA = "0x1877C08E0", Slot = "12")]
	public bool CEMGKHJAGPJ(string LKMGECEEGEE, bool IDJBNLNBJCD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x77C0790", Offset = "0x77BFB90", VA = "0x1877C0790", Slot = "10")]
	public int BBNEDFGFMOB(string LKMGECEEGEE, int IDJBNLNBJCD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x77C0CF0", Offset = "0x77C00F0", VA = "0x1877C0CF0", Slot = "18")]
	public DateTime DHKOJCMCFJB(string BPEJALFMHHI, [Optional] DateTime IDJBNLNBJCD)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x77C1F40", Offset = "0x77C1340", VA = "0x1877C1F40", Slot = "19")]
	public void KAENDLAFOKC(string LKMGECEEGEE, DateTime KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x77C1780", Offset = "0x77C0B80", VA = "0x1877C1780", Slot = "15")]
	public void HJMKDDGINCD(string LKMGECEEGEE, float KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x77C1FB0", Offset = "0x77C13B0", VA = "0x1877C1FB0", Slot = "11")]
	public void KBBNEDAEANH(string LKMGECEEGEE, int KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x77C0870", Offset = "0x77BFC70", VA = "0x1877C0870", Slot = "20")]
	public long CAOJMPHHFMP(string BPEJALFMHHI, long IDJBNLNBJCD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x77C21E0", Offset = "0x77C15E0", VA = "0x1877C21E0", Slot = "21")]
	public void NNABOHKGMBN(string BPEJALFMHHI, long KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3398EF0", Offset = "0x33982F0", VA = "0x183398EF0", Slot = "22")]
	public T PMCKFJMMAFM<T>(string BPEJALFMHHI, T IDJBNLNBJCD, GJIEELGOKJN<T> BKBAIIENGGA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3398EF0", Offset = "0x33982F0", VA = "0x183398EF0", Slot = "23")]
	public void DNHIDJHDEMJ<T>(string BPEJALFMHHI, T KBGCCIOIGBD, GJIEELGOKJN<T> BKBAIIENGGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x77C16D0", Offset = "0x77C0AD0", VA = "0x1877C16D0", Slot = "16")]
	public string HAPGJAEFBKP(string LKMGECEEGEE, string IDJBNLNBJCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x77C0D60", Offset = "0x77C0160", VA = "0x1877C0D60", Slot = "17")]
	public void ECDPEGOMPPC(string LKMGECEEGEE, string KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x77C2090", Offset = "0x77C1490", VA = "0x1877C2090", Slot = "24")]
	public void MNNNIAOKGHH(string LKMGECEEGEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x77C2250", Offset = "0x77C1650", VA = "0x1877C2250", Slot = "9")]
	public bool PIINNIDMGHH(string LKMGECEEGEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x77C09B0", Offset = "0x77BFDB0", VA = "0x1877C09B0", Slot = "25")]
	public Task COMDGOENGJF(CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x77C17F0", Offset = "0x77C0BF0", VA = "0x1877C17F0")]
	private void HNNANHENPPK(DirectoryInfo JHCPNLHCNOG, string DLBEKKMOGCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x77C1D40", Offset = "0x77C1140", VA = "0x1877C1D40")]
	private static string KABGNEPAEMH(string LKMGECEEGEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x77C0DD0", Offset = "0x77C01D0", VA = "0x1877C0DD0")]
	private static string FOKHFJHKCAH(byte[] HECJPBMFJGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x344B4A0", Offset = "0x344A8A0", VA = "0x18344B4A0")]
	private T NPPDIJEBOHO<T>(string BPEJALFMHHI, T IDJBNLNBJCD, [Optional] GJIEELGOKJN<T> KBFPIODOOCM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x344A0C0", Offset = "0x34494C0", VA = "0x18344A0C0")]
	private void ECFLGDLFBIO<T>(string BPEJALFMHHI, T KBGCCIOIGBD, [Optional] GJIEELGOKJN<T> KBFPIODOOCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x77C0ED0", Offset = "0x77C02D0", VA = "0x1877C0ED0")]
	private Dictionary<string, string> GELHKGIFPDO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal static class HNDPPKMMKNN
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x77BFBA0", Offset = "0x77BEFA0", VA = "0x1877BFBA0")]
	[HLOHOCOKELO.IDGFAEKKODB]
	internal static void AOKDCDMDNDH(GFKEMDIOCPC MGOKPJKELJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class IMONMOJBMCG : PKGAIODIMID
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x77BFD00", Offset = "0x77BF100", VA = "0x1877BFD00")]
	[UnityEngine.Scripting.Preserve]
	public IMONMOJBMCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class PKGAIODIMID : BDNIPAJKPBI, OOIIJJALPGP, DPNIFEIAIDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<string, object> AKGNILPCIHC;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool KFMLNKJFEGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x965500", Offset = "0x964900", VA = "0x180965500", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action LHNDGNLJDDE
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "8")]
	public void ANIHLAKBIIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x77C31C0", Offset = "0x77C25C0", VA = "0x1877C31C0", Slot = "6")]
	public Task JCPBIKGMJJI(long CCFNJEFBKEA, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x77C3430", Offset = "0x77C2830", VA = "0x1877C3430", Slot = "9")]
	public bool PIINNIDMGHH(string BPEJALFMHHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x77C2E30", Offset = "0x77C2230", VA = "0x1877C2E30", Slot = "10")]
	public int BBNEDFGFMOB(string BPEJALFMHHI, int IDJBNLNBJCD = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x77C32B0", Offset = "0x77C26B0", VA = "0x1877C32B0", Slot = "11")]
	public void KBBNEDAEANH(string BPEJALFMHHI, int KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x77C2F50", Offset = "0x77C2350", VA = "0x1877C2F50", Slot = "12")]
	public bool CEMGKHJAGPJ(string BPEJALFMHHI, bool IDJBNLNBJCD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x77C3310", Offset = "0x77C2710", VA = "0x1877C3310", Slot = "13")]
	public void LHIIHHKDLOM(string BPEJALFMHHI, bool KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x77C2E90", Offset = "0x77C2290", VA = "0x1877C2E90", Slot = "14")]
	public float BOBHPPGGGMC(string BPEJALFMHHI, float IDJBNLNBJCD = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x77C3160", Offset = "0x77C2560", VA = "0x1877C3160", Slot = "15")]
	public void HJMKDDGINCD(string BPEJALFMHHI, float KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x77C3100", Offset = "0x77C2500", VA = "0x1877C3100", Slot = "16")]
	public string HAPGJAEFBKP(string BPEJALFMHHI, [Optional] string IDJBNLNBJCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x77C30A0", Offset = "0x77C24A0", VA = "0x1877C30A0", Slot = "17")]
	public void ECDPEGOMPPC(string BPEJALFMHHI, string KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x77C3040", Offset = "0x77C2440", VA = "0x1877C3040", Slot = "18")]
	public DateTime DHKOJCMCFJB(string BPEJALFMHHI, [Optional] DateTime IDJBNLNBJCD)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x77C3250", Offset = "0x77C2650", VA = "0x1877C3250", Slot = "19")]
	public void KAENDLAFOKC(string BPEJALFMHHI, DateTime KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x77C2EF0", Offset = "0x77C22F0", VA = "0x1877C2EF0", Slot = "20")]
	public long CAOJMPHHFMP(string BPEJALFMHHI, long IDJBNLNBJCD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x77C33D0", Offset = "0x77C27D0", VA = "0x1877C33D0", Slot = "21")]
	public void NNABOHKGMBN(string BPEJALFMHHI, long KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x35C7FF0", Offset = "0x35C73F0", VA = "0x1835C7FF0", Slot = "22")]
	public T PMCKFJMMAFM<T>(string BPEJALFMHHI, T IDJBNLNBJCD, GJIEELGOKJN<T> BKBAIIENGGA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x35C7180", Offset = "0x35C6580", VA = "0x1835C7180", Slot = "23")]
	public void DNHIDJHDEMJ<T>(string BPEJALFMHHI, T KBGCCIOIGBD, GJIEELGOKJN<T> BKBAIIENGGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x35C7750", Offset = "0x35C6B50", VA = "0x1835C7750")]
	public T NPPDIJEBOHO<T>(string BPEJALFMHHI, T IDJBNLNBJCD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x35C7260", Offset = "0x35C6660", VA = "0x1835C7260")]
	public void ECFLGDLFBIO<T>(string BPEJALFMHHI, T KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x77C3370", Offset = "0x77C2770", VA = "0x1877C3370", Slot = "24")]
	public void MNNNIAOKGHH(string BPEJALFMHHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x77C2FB0", Offset = "0x77C23B0", VA = "0x1877C2FB0", Slot = "25")]
	public Task COMDGOENGJF(CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x77BFD00", Offset = "0x77BF100", VA = "0x1877BFD00")]
	public PKGAIODIMID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public abstract class HOMAPONDIPI<TParent> where TParent : OOIIJJALPGP
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly HashSet<HOMAPONDIPI<TParent>> DICABEBGPMF;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x466B100", Offset = "0x466A500", VA = "0x18466B100")]
	protected HOMAPONDIPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract void KKIOKOIHHPE();

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void DELLKJHCBFJ(string LKMGECEEGEE);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x466AB50", Offset = "0x4669F50", VA = "0x18466AB50")]
	public static void ACDEJNADHJA(string LKMGECEEGEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x466AD90", Offset = "0x466A190", VA = "0x18466AD90")]
	public static void IMBDFHKDIBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class AHCLFHNKEPP<TParent, TValue> : HOMAPONDIPI<TParent> where TParent : OOIIJJALPGP
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly AHCLFHNKEPP<TParent, TValue> MPDPNCAPBBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, TValue> JMLGDFMCDMI;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x479E850", Offset = "0x479DC50", VA = "0x18479E850")]
	public bool GMJNAAAPBAP(string MHOMJGNFGGL, [Out] TValue FOAKCJPCPOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x479E8B0", Offset = "0x479DCB0", VA = "0x18479E8B0")]
	public void HGJJHONLMGO(string MHOMJGNFGGL, TValue KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x401A560", Offset = "0x4019960", VA = "0x18401A560", Slot = "4")]
	protected override void KKIOKOIHHPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x401A5B0", Offset = "0x40199B0", VA = "0x18401A5B0", Slot = "5")]
	protected override void DELLKJHCBFJ(string MHOMJGNFGGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x479EB50", Offset = "0x479DF50", VA = "0x18479EB50")]
	public AHCLFHNKEPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface OOIIJJALPGP
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool KFMLNKJFEGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ANIHLAKBIIH();

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PIINNIDMGHH(string BPEJALFMHHI);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int BBNEDFGFMOB(string BPEJALFMHHI, int IDJBNLNBJCD = 0);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KBBNEDAEANH(string BPEJALFMHHI, int KBGCCIOIGBD);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool CEMGKHJAGPJ(string BPEJALFMHHI, bool IDJBNLNBJCD = false);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LHIIHHKDLOM(string BPEJALFMHHI, bool KBGCCIOIGBD);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	float BOBHPPGGGMC(string BPEJALFMHHI, float IDJBNLNBJCD = 0f);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HJMKDDGINCD(string BPEJALFMHHI, float KBGCCIOIGBD);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	string HAPGJAEFBKP(string BPEJALFMHHI, [Optional] string IDJBNLNBJCD);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void ECDPEGOMPPC(string BPEJALFMHHI, string KBGCCIOIGBD);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	DateTime DHKOJCMCFJB(string BPEJALFMHHI, [Optional] DateTime FLCMHPCNDLI);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void KAENDLAFOKC(string BPEJALFMHHI, DateTime FLCMHPCNDLI);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "13")]
	long CAOJMPHHFMP(string BPEJALFMHHI, long IDJBNLNBJCD);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void NNABOHKGMBN(string BPEJALFMHHI, long KBGCCIOIGBD);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "15")]
	T PMCKFJMMAFM<T>(string BPEJALFMHHI, T IDJBNLNBJCD, GJIEELGOKJN<T> BKBAIIENGGA);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void DNHIDJHDEMJ<T>(string BPEJALFMHHI, T KBGCCIOIGBD, GJIEELGOKJN<T> BKBAIIENGGA);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void MNNNIAOKGHH(string BPEJALFMHHI);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task COMDGOENGJF([Optional] CancellationToken LAEIHJHNGEK);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface BDNIPAJKPBI : OOIIJJALPGP
{
	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action LHNDGNLJDDE;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task JCPBIKGMJJI(long CCFNJEFBKEA, CancellationToken LAEIHJHNGEK);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface DPNIFEIAIDJ : OOIIJJALPGP
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class HEGMOHNNMAN : BDNIPAJKPBI, OOIIJJALPGP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct CEPNPHMIFNF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public HEGMOHNNMAN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x77BA700", Offset = "0x77B9B00", VA = "0x1877BA700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x77BAAD0", Offset = "0x77B9ED0", VA = "0x1877BAAD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class HJCLDKFGKOH : IEnumerator<FBLKJCIOKGP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private FBLKJCIOKGP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public HEGMOHNNMAN <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private FBLKJCIOKGP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x94B7A0", Offset = "0x94ABA0", VA = "0x18094B7A0")]
		[DebuggerHidden]
		public HJCLDKFGKOH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x77BC8F0", Offset = "0x77BBCF0", VA = "0x1877BC8F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x77BC960", Offset = "0x77BBD60", VA = "0x1877BC960", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly OMKIPBLMPOD LDNAHMLEOCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool OJDOKPHIEIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private bool CDGBHKDANBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private MEFKNEOFFHC JGFDBKNDMLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private HPLGDNGCOKN AMNANPDHCIJ;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool KFMLNKJFEGL
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x965500", Offset = "0x964900", VA = "0x180965500", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action LHNDGNLJDDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x77BC800", Offset = "0x77BBC00", VA = "0x1877BC800")]
	[UnityEngine.Scripting.Preserve]
	public HEGMOHNNMAN([IBJCGEMJMJL(null)] OMKIPBLMPOD LDNAHMLEOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "8")]
	public void ANIHLAKBIIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x77BC4A0", Offset = "0x77BB8A0", VA = "0x1877BC4A0", Slot = "6")]
	public Task JCPBIKGMJJI(long CCFNJEFBKEA, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x18A8EB0", Offset = "0x18A82B0", VA = "0x1818A8EB0")]
	private static int EIGBEOECKJJ(bool KBGCCIOIGBD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x77BC7E0", Offset = "0x77BBBE0", VA = "0x1877BC7E0", Slot = "9")]
	public bool PIINNIDMGHH(string BPEJALFMHHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x77BC0E0", Offset = "0x77BB4E0", VA = "0x1877BC0E0", Slot = "10")]
	public int BBNEDFGFMOB(string BPEJALFMHHI, int IDJBNLNBJCD = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x77BC5A0", Offset = "0x77BB9A0", VA = "0x1877BC5A0", Slot = "11")]
	public void KBBNEDAEANH(string BPEJALFMHHI, int KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x77BC1B0", Offset = "0x77BB5B0", VA = "0x1877BC1B0", Slot = "12")]
	public bool CEMGKHJAGPJ(string BPEJALFMHHI, bool IDJBNLNBJCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x77BC5F0", Offset = "0x77BB9F0", VA = "0x1877BC5F0", Slot = "13")]
	public void LHIIHHKDLOM(string BPEJALFMHHI, bool KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x77BC110", Offset = "0x77BB510", VA = "0x1877BC110", Slot = "14")]
	public float BOBHPPGGGMC(string BPEJALFMHHI, float IDJBNLNBJCD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x77BC470", Offset = "0x77BB870", VA = "0x1877BC470", Slot = "15")]
	public void HJMKDDGINCD(string BPEJALFMHHI, float KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x77BC2D0", Offset = "0x77BB6D0", VA = "0x1877BC2D0", Slot = "18")]
	public DateTime DHKOJCMCFJB(string BPEJALFMHHI, [Optional] DateTime IDJBNLNBJCD)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x77BC530", Offset = "0x77BB930", VA = "0x1877BC530", Slot = "19")]
	public void KAENDLAFOKC(string BPEJALFMHHI, DateTime FLCMHPCNDLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x77BC140", Offset = "0x77BB540", VA = "0x1877BC140", Slot = "20")]
	public long CAOJMPHHFMP(string BPEJALFMHHI, long IDJBNLNBJCD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x77BC6D0", Offset = "0x77BBAD0", VA = "0x1877BC6D0", Slot = "21")]
	public void NNABOHKGMBN(string BPEJALFMHHI, long KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x33A6400", Offset = "0x33A5800", VA = "0x1833A6400", Slot = "22")]
	public T PMCKFJMMAFM<T>(string BPEJALFMHHI, T IDJBNLNBJCD, GJIEELGOKJN<T> BKBAIIENGGA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x33A6400", Offset = "0x33A5800", VA = "0x1833A6400", Slot = "23")]
	public void DNHIDJHDEMJ<T>(string BPEJALFMHHI, T KBGCCIOIGBD, GJIEELGOKJN<T> BKBAIIENGGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x33A6D00", Offset = "0x33A6100", VA = "0x1833A6D00")]
	private T KNIFMCLGACA<T>(string BPEJALFMHHI, T IDJBNLNBJCD, [Optional] GJIEELGOKJN<T> KBFPIODOOCM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x33A6590", Offset = "0x33A5990", VA = "0x1833A6590")]
	private void EGEDJLHBFMP<T>(string BPEJALFMHHI, T KBGCCIOIGBD, [Optional] GJIEELGOKJN<T> KBFPIODOOCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x77BC3D0", Offset = "0x77BB7D0", VA = "0x1877BC3D0", Slot = "16")]
	public string HAPGJAEFBKP(string BPEJALFMHHI, string IDJBNLNBJCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x77BC3A0", Offset = "0x77BB7A0", VA = "0x1877BC3A0", Slot = "17")]
	public void ECDPEGOMPPC(string BPEJALFMHHI, string KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x77BC5D0", Offset = "0x77BB9D0", VA = "0x1877BC5D0")]
	private void LFOIJNFDLGM(string BPEJALFMHHI, string KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x77BC6B0", Offset = "0x77BBAB0", VA = "0x1877BC6B0")]
	private string NBKAIFOJBDP(string BPEJALFMHHI, string IDJBNLNBJCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x77BC620", Offset = "0x77BBA20", VA = "0x1877BC620", Slot = "24")]
	public void MNNNIAOKGHH(string BPEJALFMHHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x77BC740", Offset = "0x77BBB40", VA = "0x1877BC740")]
	private string ODMDNKLBBOD(string LKMGECEEGEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x77BC1E0", Offset = "0x77BB5E0", VA = "0x1877BC1E0", Slot = "25")]
	[AsyncStateMachine(typeof(CEPNPHMIFNF))]
	public Task COMDGOENGJF(CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x77BBFF0", Offset = "0x77BB3F0", VA = "0x1877BBFF0")]
	[IteratorStateMachine(typeof(HJCLDKFGKOH))]
	private IEnumerator<FBLKJCIOKGP> AHIBFFJNCCO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x77BC340", Offset = "0x77BB740", VA = "0x1877BC340")]
	private void DMGDEDLCGEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x77BC070", Offset = "0x77BB470", VA = "0x1877BC070")]
	private void AMPJOOHHMNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x77BC400", Offset = "0x77BB800", VA = "0x1877BC400")]
	private void HGLHLEJAELI(bool MHCADGKAJIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class GLNGLLGDMBK : BDNIPAJKPBI, OOIIJJALPGP
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
	private Dictionary<string, string> CFFOECLBAEB;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool KFMLNKJFEGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x965500", Offset = "0x964900", VA = "0x180965500", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private string GOCMPMDBMEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x77BBBE0", Offset = "0x77BAFE0", VA = "0x1877BBBE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private Dictionary<string, string> CEFDNNBHJAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x77BB1E0", Offset = "0x77BA5E0", VA = "0x1877BB1E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action LHNDGNLJDDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	[UnityEngine.Scripting.Preserve]
	public GLNGLLGDMBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "8")]
	public void ANIHLAKBIIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x77BBC50", Offset = "0x77BB050", VA = "0x1877BBC50", Slot = "6")]
	public Task JCPBIKGMJJI(long CCFNJEFBKEA, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x77BB290", Offset = "0x77BA690", VA = "0x1877BB290", Slot = "14")]
	public float BOBHPPGGGMC(string LKMGECEEGEE, float IDJBNLNBJCD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x77BBDC0", Offset = "0x77BB1C0", VA = "0x1877BBDC0", Slot = "13")]
	public void LHIIHHKDLOM(string LKMGECEEGEE, bool KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x77BB370", Offset = "0x77BA770", VA = "0x1877BB370", Slot = "12")]
	public bool CEMGKHJAGPJ(string LKMGECEEGEE, bool IDJBNLNBJCD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x77BB220", Offset = "0x77BA620", VA = "0x1877BB220", Slot = "10")]
	public int BBNEDFGFMOB(string LKMGECEEGEE, int IDJBNLNBJCD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x77BB6B0", Offset = "0x77BAAB0", VA = "0x1877BB6B0", Slot = "18")]
	public DateTime DHKOJCMCFJB(string BPEJALFMHHI, [Optional] DateTime IDJBNLNBJCD)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x77BBCE0", Offset = "0x77BB0E0", VA = "0x1877BBCE0", Slot = "19")]
	public void KAENDLAFOKC(string LKMGECEEGEE, DateTime KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x77BBB70", Offset = "0x77BAF70", VA = "0x1877BBB70", Slot = "15")]
	public void HJMKDDGINCD(string LKMGECEEGEE, float KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x77BBD50", Offset = "0x77BB150", VA = "0x1877BBD50", Slot = "11")]
	public void KBBNEDAEANH(string LKMGECEEGEE, int KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x77BB300", Offset = "0x77BA700", VA = "0x1877BB300", Slot = "20")]
	public long CAOJMPHHFMP(string BPEJALFMHHI, long IDJBNLNBJCD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x77BBEF0", Offset = "0x77BB2F0", VA = "0x1877BBEF0", Slot = "21")]
	public void NNABOHKGMBN(string BPEJALFMHHI, long KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3398EF0", Offset = "0x33982F0", VA = "0x183398EF0", Slot = "22")]
	public T PMCKFJMMAFM<T>(string BPEJALFMHHI, T IDJBNLNBJCD, GJIEELGOKJN<T> BKBAIIENGGA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3398EF0", Offset = "0x33982F0", VA = "0x183398EF0", Slot = "23")]
	public void DNHIDJHDEMJ<T>(string BPEJALFMHHI, T KBGCCIOIGBD, GJIEELGOKJN<T> BKBAIIENGGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x77BBAC0", Offset = "0x77BAEC0", VA = "0x1877BBAC0", Slot = "16")]
	public string HAPGJAEFBKP(string LKMGECEEGEE, string IDJBNLNBJCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x77BB720", Offset = "0x77BAB20", VA = "0x1877BB720", Slot = "17")]
	public void ECDPEGOMPPC(string LKMGECEEGEE, string KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x77BBE30", Offset = "0x77BB230", VA = "0x1877BBE30", Slot = "24")]
	public void MNNNIAOKGHH(string LKMGECEEGEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x77BBF60", Offset = "0x77BB360", VA = "0x1877BBF60", Slot = "9")]
	public bool PIINNIDMGHH(string LKMGECEEGEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x77BB440", Offset = "0x77BA840", VA = "0x1877BB440", Slot = "25")]
	public Task COMDGOENGJF(CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x339A060", Offset = "0x3399460", VA = "0x18339A060")]
	private T NPPDIJEBOHO<T>(string BPEJALFMHHI, T IDJBNLNBJCD, [Optional] GJIEELGOKJN<T> KBFPIODOOCM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3398FF0", Offset = "0x33983F0", VA = "0x183398FF0")]
	private void ECFLGDLFBIO<T>(string BPEJALFMHHI, T KBGCCIOIGBD, [Optional] GJIEELGOKJN<T> KBFPIODOOCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x77BB7C0", Offset = "0x77BABC0", VA = "0x1877BB7C0")]
	private Dictionary<string, string> GELHKGIFPDO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface CDIHIOEBGKL
{
	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action LHNDGNLJDDE;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ANIHLAKBIIH();

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task EAPGHIAENOD(long CCFNJEFBKEA);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool OKOPGOCCIEO(BELLPEALDFB EBMOJGOBHLD = BELLPEALDFB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool BNNDLIEHOJM(string BPEJALFMHHI, BELLPEALDFB JGLMDDGGLNH = BELLPEALDFB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool FLDKBJBGFFC(string BPEJALFMHHI, BELLPEALDFB JGLMDDGGLNH = BELLPEALDFB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "7")]
	string DDNMFHCABOE(string BPEJALFMHHI, [Optional] string IDJBNLNBJCD, BELLPEALDFB JGLMDDGGLNH = BELLPEALDFB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	EFMPBLEPGLL AMDKJKPFAJM(string BPEJALFMHHI, string KBGCCIOIGBD, BELLPEALDFB JGLMDDGGLNH = BELLPEALDFB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	int AAHIMAJGNPI(string BPEJALFMHHI, int IDJBNLNBJCD = 0, BELLPEALDFB JGLMDDGGLNH = BELLPEALDFB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	EFMPBLEPGLL AIFMJMAMCIJ(string BPEJALFMHHI, int KBGCCIOIGBD, BELLPEALDFB JGLMDDGGLNH = BELLPEALDFB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool HHPKMEEGFOO(string BPEJALFMHHI, bool IDJBNLNBJCD, BELLPEALDFB JGLMDDGGLNH = BELLPEALDFB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "12")]
	EFMPBLEPGLL HKPJKJFPPAO(string BPEJALFMHHI, bool KBGCCIOIGBD, BELLPEALDFB JGLMDDGGLNH = BELLPEALDFB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float EIFIOIMOBNB(string BPEJALFMHHI, float IDJBNLNBJCD = 0f, BELLPEALDFB JGLMDDGGLNH = BELLPEALDFB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "14")]
	EFMPBLEPGLL DJHOGAFGDLF(string BPEJALFMHHI, float KBGCCIOIGBD, BELLPEALDFB JGLMDDGGLNH = BELLPEALDFB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "15")]
	DateTime CEKEGGBOHHE(string BPEJALFMHHI, [Optional] DateTime IDJBNLNBJCD, BELLPEALDFB JGLMDDGGLNH = BELLPEALDFB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	EFMPBLEPGLL OGLFDDMCMPC(string BPEJALFMHHI, DateTime KBGCCIOIGBD, BELLPEALDFB JGLMDDGGLNH = BELLPEALDFB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "17")]
	long POGKBMAMAOC(string BPEJALFMHHI, long IDJBNLNBJCD = 0L, BELLPEALDFB JGLMDDGGLNH = BELLPEALDFB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "18")]
	EFMPBLEPGLL JFBGELIHOKA(string BPEJALFMHHI, long KBGCCIOIGBD, BELLPEALDFB JGLMDDGGLNH = BELLPEALDFB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "19")]
	T LKMNEJMJOCO<T>(string BPEJALFMHHI, [Optional] T IDJBNLNBJCD, BELLPEALDFB JGLMDDGGLNH = BELLPEALDFB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "20")]
	EFMPBLEPGLL FPOPKHNMJBH<T>(string BPEJALFMHHI, T KBGCCIOIGBD, BELLPEALDFB JGLMDDGGLNH = BELLPEALDFB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool AFDOGIDDPIA(string BPEJALFMHHI);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool EGGHNJGHADM(string BPEJALFMHHI);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "23")]
	string EHAMPKJDLCE(string BPEJALFMHHI, [Optional] string IDJBNLNBJCD);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "24")]
	EFMPBLEPGLL FEFIMAJPPHH(string BPEJALFMHHI, string KBGCCIOIGBD);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "25")]
	int KMILJHGEMCK(string BPEJALFMHHI, int IDJBNLNBJCD = 0);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "26")]
	EFMPBLEPGLL FFPDBLHGNEL(string BPEJALFMHHI, int KBGCCIOIGBD);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool OMACPJGINHK(string BPEJALFMHHI, bool IDJBNLNBJCD);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "28")]
	EFMPBLEPGLL EPFKANIGANB(string BPEJALFMHHI, bool KBGCCIOIGBD);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "29")]
	float BAOHNMCAPOG(string BPEJALFMHHI, float IDJBNLNBJCD = 0f);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "30")]
	EFMPBLEPGLL AALNPAOBJBE(string BPEJALFMHHI, float KBGCCIOIGBD);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "31")]
	DateTime IEOPPJCLJIN(string BPEJALFMHHI, [Optional] DateTime IDJBNLNBJCD);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "32")]
	EFMPBLEPGLL BFGIEBCEEME(string BPEJALFMHHI, DateTime KBGCCIOIGBD);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "33")]
	long GBNEGNGGBPO(string BPEJALFMHHI, long IDJBNLNBJCD = 0L);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "34")]
	EFMPBLEPGLL HNHPFFPIKML(string BPEJALFMHHI, long KBGCCIOIGBD);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void ILDCMDMNFPO<T>(GJIEELGOKJN<T> BKBAIIENGGA, [Optional] IEqualityComparer<T> BLMEGMHOING);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void LFMACMGMKKI<T>();

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "37")]
	IDisposable IPBCLKJGEAK();

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void CFDLOCCKDCB(float HKPDGGGHFLH);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task DMGDEDLCGEC([Optional] CancellationToken LAEIHJHNGEK);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum EFMPBLEPGLL : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	Unchanged,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	New,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Changed
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class HLPAHNEMLHA : CDIHIOEBGKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private abstract class EKENDNLNEND
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		protected static readonly HashSet<EKENDNLNEND> EDMOECAGMMB;

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x77BAB30", Offset = "0x77B9F30", VA = "0x1877BAB30")]
		public static void IMBDFHKDIBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void KKIOKOIHHPE();

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		protected EKENDNLNEND()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private class NHBKBBIPCMM<T> : EKENDNLNEND
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly NHBKBBIPCMM<T> IMFIEPMCPDC;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public GJIEELGOKJN<T> EPCGMNDAAEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x949410", Offset = "0x948810", VA = "0x180949410")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x949400", Offset = "0x948800", VA = "0x180949400")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public IEqualityComparer<T> NKHINAKIHME
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x94B9B0", Offset = "0x94ADB0", VA = "0x18094B9B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool BMMDOMLIOEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x3FF4A60", Offset = "0x3FF3E60", VA = "0x183FF4A60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x4E32EC0", Offset = "0x4E322C0", VA = "0x184E32EC0")]
		private NHBKBBIPCMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x4E329A0", Offset = "0x4E31DA0", VA = "0x184E329A0")]
		public void OCICFIBHEPA(GJIEELGOKJN<T> KBFPIODOOCM, [Optional] IEqualityComparer<T> BLMEGMHOING)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x4E32760", Offset = "0x4E31B60", VA = "0x184E32760", Slot = "4")]
		public override void KKIOKOIHHPE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private class PKMBDGFMDLE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private readonly HLPAHNEMLHA HFGMMHMEBAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly object CPFFHOCOOGA;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x77C34C0", Offset = "0x77C28C0", VA = "0x1877C34C0")]
		public PKMBDGFMDLE(HLPAHNEMLHA HFGMMHMEBAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x77C3490", Offset = "0x77C2890", VA = "0x1877C3490", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct EOAPFLIKDAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public HLPAHNEMLHA <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x77BAD00", Offset = "0x77BA100", VA = "0x1877BAD00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x77BAFF0", Offset = "0x77BA3F0", VA = "0x1877BAFF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct GAACAPEGGBG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public HLPAHNEMLHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public OOIIJJALPGP backingStoreToSave;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x77BB050", Offset = "0x77BA450", VA = "0x1877BB050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0xA48F40", Offset = "0xA48340", VA = "0x180A48F40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private struct NDFNIEOACAE : IAsyncStateMachine
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
		public HLPAHNEMLHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x77C2460", Offset = "0x77C1860", VA = "0x1877C2460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x77C2930", Offset = "0x77C1D30", VA = "0x1877C2930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class LIFCDMJMOLN : IEnumerator<FBLKJCIOKGP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private FBLKJCIOKGP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public HLPAHNEMLHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public float seconds;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private FBLKJCIOKGP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x94B7A0", Offset = "0x94ABA0", VA = "0x18094B7A0")]
		[DebuggerHidden]
		public LIFCDMJMOLN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x77C2380", Offset = "0x77C1780", VA = "0x1877C2380", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x77C2410", Offset = "0x77C1810", VA = "0x1877C2410", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly BDNIPAJKPBI HMGLFKGNOCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly BDNIPAJKPBI HHFKBHEFJOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly DPNIFEIAIDJ ABOGODOFAMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly MEFKNEOFFHC JGFDBKNDMLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly JLEJEHNECDC.LIGMHAMDHFC DOPJJMLPPOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly IFFCOANOBGF JKIAJMMGMJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly HashSet<OOIIJJALPGP> KKCAEICMHDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private Task PMKBHHHGFMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private Dictionary<string, string> KNOPBILFNFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private HPLGDNGCOKN FNDEOLALLGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly object BKDMBFKIPHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly object GAODLHEAPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private long DPOPOPAEIEJ;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private bool DNMOBNCJGDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x77BEDF0", Offset = "0x77BE1F0", VA = "0x1877BEDF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private CancellationTokenSource JPFEGFAMCEN
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x94FD70", Offset = "0x94F170", VA = "0x18094FD70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x94FB10", Offset = "0x94EF10", VA = "0x18094FB10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action LHNDGNLJDDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x77BF2B0", Offset = "0x77BE6B0", VA = "0x1877BF2B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x77BE480", Offset = "0x77BD880", VA = "0x1877BE480", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x77BCFF0", Offset = "0x77BC3F0", VA = "0x1877BCFF0")]
	[HLOHOCOKELO.IDGFAEKKODB]
	internal static void APJICGAGHJP(GFKEMDIOCPC MGOKPJKELJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x77BF7D0", Offset = "0x77BEBD0", VA = "0x1877BF7D0")]
	[UnityEngine.Scripting.Preserve]
	public HLPAHNEMLHA([IBJCGEMJMJL("Disk")] BDNIPAJKPBI HMGLFKGNOCN, [IBJCGEMJMJL("Cloud")] BDNIPAJKPBI HHFKBHEFJOH, [IBJCGEMJMJL(null)] DPNIFEIAIDJ ABOGODOFAMP, [IBJCGEMJMJL(null)] MEFKNEOFFHC JGFDBKNDMLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x77BDA10", Offset = "0x77BCE10", VA = "0x1877BDA10", Slot = "44")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x77BE7E0", Offset = "0x77BDBE0", VA = "0x1877BE7E0")]
	private void IOGHJJLHGPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x77BCF80", Offset = "0x77BC380", VA = "0x1877BCF80", Slot = "6")]
	public void ANIHLAKBIIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x77BDA50", Offset = "0x77BCE50", VA = "0x1877BDA50", Slot = "7")]
	public Task EAPGHIAENOD(long CCFNJEFBKEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x77BEE10", Offset = "0x77BE210", VA = "0x1877BEE10")]
	[AsyncStateMachine(typeof(EOAPFLIKDAK))]
	private Task LHJKNNGCHDL(long CCFNJEFBKEA, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x77BDCA0", Offset = "0x77BD0A0", VA = "0x1877BDCA0")]
	private void EICBHNPALML(object LAAJFAFNFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x77BF350", Offset = "0x77BE750", VA = "0x1877BF350")]
	private void NJINBFAIGDF(object LAAJFAFNFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x77BCF20", Offset = "0x77BC320", VA = "0x1877BCF20")]
	private string AMOCFIAGIBH(string JNIJNEHBMFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x77BE140", Offset = "0x77BD540", VA = "0x1877BE140")]
	private void GGHLHLCJBMF(BELLPEALDFB EBMOJGOBHLD, string LKMGECEEGEE, [Out] BDNIPAJKPBI IDIFDJHFLBD, [Out] string FKLOHECCGAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x77BEA80", Offset = "0x77BDE80", VA = "0x1877BEA80")]
	private BDNIPAJKPBI JPAFBGFHECA(BELLPEALDFB EBMOJGOBHLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x77BF570", Offset = "0x77BE970", VA = "0x1877BF570", Slot = "8")]
	public bool OKOPGOCCIEO(BELLPEALDFB EBMOJGOBHLD = BELLPEALDFB.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x77BD100", Offset = "0x77BC500", VA = "0x1877BD100", Slot = "9")]
	public bool BNNDLIEHOJM(string BPEJALFMHHI, BELLPEALDFB JGLMDDGGLNH = BELLPEALDFB.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x77BDE00", Offset = "0x77BD200", VA = "0x1877BDE00", Slot = "10")]
	public bool FLDKBJBGFFC(string BPEJALFMHHI, BELLPEALDFB JGLMDDGGLNH = BELLPEALDFB.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x77BD5A0", Offset = "0x77BC9A0", VA = "0x1877BD5A0", Slot = "11")]
	public string DDNMFHCABOE(string BPEJALFMHHI, [Optional] string IDJBNLNBJCD, BELLPEALDFB JGLMDDGGLNH = BELLPEALDFB.CLOUD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x77BCC60", Offset = "0x77BC060", VA = "0x1877BCC60", Slot = "12")]
	public EFMPBLEPGLL AMDKJKPFAJM(string BPEJALFMHHI, string KBGCCIOIGBD, BELLPEALDFB JGLMDDGGLNH = BELLPEALDFB.CLOUD)
	{
		return default(EFMPBLEPGLL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x77BC9B0", Offset = "0x77BBDB0", VA = "0x1877BC9B0", Slot = "13")]
	public int AAHIMAJGNPI(string BPEJALFMHHI, int IDJBNLNBJCD = 0, BELLPEALDFB JGLMDDGGLNH = BELLPEALDFB.CLOUD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x77BCAF0", Offset = "0x77BBEF0", VA = "0x1877BCAF0", Slot = "14")]
	public EFMPBLEPGLL AIFMJMAMCIJ(string BPEJALFMHHI, int KBGCCIOIGBD, BELLPEALDFB JGLMDDGGLNH = BELLPEALDFB.CLOUD)
	{
		return default(EFMPBLEPGLL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x77BE520", Offset = "0x77BD920", VA = "0x1877BE520", Slot = "15")]
	public bool HHPKMEEGFOO(string BPEJALFMHHI, bool IDJBNLNBJCD, BELLPEALDFB JGLMDDGGLNH = BELLPEALDFB.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x77BE5D0", Offset = "0x77BD9D0", VA = "0x1877BE5D0", Slot = "16")]
	public EFMPBLEPGLL HKPJKJFPPAO(string BPEJALFMHHI, bool KBGCCIOIGBD, BELLPEALDFB JGLMDDGGLNH = BELLPEALDFB.CLOUD)
	{
		return default(EFMPBLEPGLL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x77BDCC0", Offset = "0x77BD0C0", VA = "0x1877BDCC0", Slot = "17")]
	public float EIFIOIMOBNB(string BPEJALFMHHI, float IDJBNLNBJCD = 0f, BELLPEALDFB JGLMDDGGLNH = BELLPEALDFB.CLOUD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x77BD640", Offset = "0x77BCA40", VA = "0x1877BD640", Slot = "18")]
	public EFMPBLEPGLL DJHOGAFGDLF(string BPEJALFMHHI, float KBGCCIOIGBD, BELLPEALDFB JGLMDDGGLNH = BELLPEALDFB.CLOUD)
	{
		return default(EFMPBLEPGLL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x77BD420", Offset = "0x77BC820", VA = "0x1877BD420", Slot = "19")]
	public DateTime CEKEGGBOHHE(string BPEJALFMHHI, [Optional] DateTime IDJBNLNBJCD, BELLPEALDFB JGLMDDGGLNH = BELLPEALDFB.CLOUD)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x77BF3D0", Offset = "0x77BE7D0", VA = "0x1877BF3D0", Slot = "20")]
	public EFMPBLEPGLL OGLFDDMCMPC(string BPEJALFMHHI, DateTime KBGCCIOIGBD, BELLPEALDFB JGLMDDGGLNH = BELLPEALDFB.CLOUD)
	{
		return default(EFMPBLEPGLL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x77BF730", Offset = "0x77BEB30", VA = "0x1877BF730", Slot = "21")]
	public long POGKBMAMAOC(string BPEJALFMHHI, long IDJBNLNBJCD = 0L, BELLPEALDFB JGLMDDGGLNH = BELLPEALDFB.CLOUD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x77BE910", Offset = "0x77BDD10", VA = "0x1877BE910", Slot = "22")]
	public EFMPBLEPGLL JFBGELIHOKA(string BPEJALFMHHI, long KBGCCIOIGBD, BELLPEALDFB JGLMDDGGLNH = BELLPEALDFB.CLOUD)
	{
		return default(EFMPBLEPGLL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x33AAAC0", Offset = "0x33A9EC0", VA = "0x1833AAAC0", Slot = "23")]
	public T LKMNEJMJOCO<T>(string BPEJALFMHHI, [Optional] T IDJBNLNBJCD, BELLPEALDFB JGLMDDGGLNH = BELLPEALDFB.CLOUD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x33AAAC0", Offset = "0x33A9EC0", VA = "0x1833AAAC0", Slot = "24")]
	public EFMPBLEPGLL FPOPKHNMJBH<T>(string BPEJALFMHHI, T KBGCCIOIGBD, BELLPEALDFB JGLMDDGGLNH = BELLPEALDFB.CLOUD)
	{
		return default(EFMPBLEPGLL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x77BCA90", Offset = "0x77BBE90", VA = "0x1877BCA90", Slot = "25")]
	public bool AFDOGIDDPIA(string BPEJALFMHHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x77BDC20", Offset = "0x77BD020", VA = "0x1877BDC20", Slot = "26")]
	public bool EGGHNJGHADM(string BPEJALFMHHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x77BDC30", Offset = "0x77BD030", VA = "0x1877BDC30", Slot = "27")]
	public string EHAMPKJDLCE(string BPEJALFMHHI, [Optional] string IDJBNLNBJCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x77BDDA0", Offset = "0x77BD1A0", VA = "0x1877BDDA0", Slot = "28")]
	public EFMPBLEPGLL FEFIMAJPPHH(string BPEJALFMHHI, string KBGCCIOIGBD)
	{
		return default(EFMPBLEPGLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x77BEB00", Offset = "0x77BDF00", VA = "0x1877BEB00", Slot = "29")]
	public int KMILJHGEMCK(string BPEJALFMHHI, int IDJBNLNBJCD = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x77BDDD0", Offset = "0x77BD1D0", VA = "0x1877BDDD0", Slot = "30")]
	public EFMPBLEPGLL FFPDBLHGNEL(string BPEJALFMHHI, int KBGCCIOIGBD)
	{
		return default(EFMPBLEPGLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x77BF630", Offset = "0x77BEA30", VA = "0x1877BF630", Slot = "31")]
	public bool OMACPJGINHK(string BPEJALFMHHI, bool IDJBNLNBJCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x77BDD70", Offset = "0x77BD170", VA = "0x1877BDD70", Slot = "32")]
	public EFMPBLEPGLL EPFKANIGANB(string BPEJALFMHHI, bool KBGCCIOIGBD)
	{
		return default(EFMPBLEPGLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x77BD060", Offset = "0x77BC460", VA = "0x1877BD060", Slot = "33")]
	public float BAOHNMCAPOG(string BPEJALFMHHI, float IDJBNLNBJCD = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x77BCA60", Offset = "0x77BBE60", VA = "0x1877BCA60", Slot = "34")]
	public EFMPBLEPGLL AALNPAOBJBE(string BPEJALFMHHI, float KBGCCIOIGBD)
	{
		return default(EFMPBLEPGLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x77BE770", Offset = "0x77BDB70", VA = "0x1877BE770", Slot = "35")]
	public DateTime IEOPPJCLJIN(string BPEJALFMHHI, [Optional] DateTime IDJBNLNBJCD)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x77BD0D0", Offset = "0x77BC4D0", VA = "0x1877BD0D0", Slot = "36")]
	public EFMPBLEPGLL BFGIEBCEEME(string BPEJALFMHHI, DateTime KBGCCIOIGBD)
	{
		return default(EFMPBLEPGLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x77BDF80", Offset = "0x77BD380", VA = "0x1877BDF80", Slot = "37")]
	public long GBNEGNGGBPO(string BPEJALFMHHI, long IDJBNLNBJCD = 0L)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x77BE740", Offset = "0x77BDB40", VA = "0x1877BE740", Slot = "38")]
	public EFMPBLEPGLL HNHPFFPIKML(string BPEJALFMHHI, long KBGCCIOIGBD)
	{
		return default(EFMPBLEPGLL);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x77BEF20", Offset = "0x77BE320", VA = "0x1877BEF20")]
	private bool LPJOJNBKCPP(OOIIJJALPGP IDIFDJHFLBD, string BPEJALFMHHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x77BD7C0", Offset = "0x77BCBC0", VA = "0x1877BD7C0")]
	private bool DMCMNMBOCJB(OOIIJJALPGP IDIFDJHFLBD, string BPEJALFMHHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x77BEF80", Offset = "0x77BE380", VA = "0x1877BEF80")]
	private EFMPBLEPGLL MAAAKJKJGKO(OOIIJJALPGP IDIFDJHFLBD, string BPEJALFMHHI, string KBGCCIOIGBD)
	{
		return default(EFMPBLEPGLL);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x77BCDE0", Offset = "0x77BC1E0", VA = "0x1877BCDE0")]
	private EFMPBLEPGLL AMMCENHLLHK(OOIIJJALPGP IDIFDJHFLBD, string BPEJALFMHHI, int KBGCCIOIGBD)
	{
		return default(EFMPBLEPGLL);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x77BD2E0", Offset = "0x77BC6E0", VA = "0x1877BD2E0")]
	private EFMPBLEPGLL CBAKIPJAIKG(OOIIJJALPGP IDIFDJHFLBD, string BPEJALFMHHI, bool KBGCCIOIGBD)
	{
		return default(EFMPBLEPGLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x77BDFF0", Offset = "0x77BD3F0", VA = "0x1877BDFF0")]
	private EFMPBLEPGLL GEBEODEIJMF(OOIIJJALPGP IDIFDJHFLBD, string BPEJALFMHHI, float KBGCCIOIGBD)
	{
		return default(EFMPBLEPGLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x77BE2E0", Offset = "0x77BD6E0", VA = "0x1877BE2E0")]
	private EFMPBLEPGLL GGOIINNBGMM(OOIIJJALPGP IDIFDJHFLBD, string BPEJALFMHHI, DateTime KBGCCIOIGBD)
	{
		return default(EFMPBLEPGLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x77BD1A0", Offset = "0x77BC5A0", VA = "0x1877BD1A0")]
	private EFMPBLEPGLL CADDMOBKFIB(OOIIJJALPGP IDIFDJHFLBD, string BPEJALFMHHI, long KBGCCIOIGBD)
	{
		return default(EFMPBLEPGLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x33AA550", Offset = "0x33A9950", VA = "0x1833AA550")]
	private T FMCFCGJHJNE<T>(OOIIJJALPGP IDIFDJHFLBD, string BPEJALFMHHI, T IDJBNLNBJCD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x33A9970", Offset = "0x33A8D70", VA = "0x1833A9970")]
	private EFMPBLEPGLL CBMBAMOHGPD<T>(OOIIJJALPGP IDIFDJHFLBD, string BPEJALFMHHI, T KBGCCIOIGBD)
	{
		return default(EFMPBLEPGLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x33AAC90", Offset = "0x33AA090", VA = "0x1833AAC90", Slot = "39")]
	public void ILDCMDMNFPO<T>(GJIEELGOKJN<T> BKBAIIENGGA, [Optional] IEqualityComparer<T> BLMEGMHOING)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x33AAD40", Offset = "0x33AA140", VA = "0x1833AAD40", Slot = "40")]
	public void LFMACMGMKKI<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x77BD4D0", Offset = "0x77BC8D0", VA = "0x1877BD4D0")]
	[AsyncStateMachine(typeof(GAACAPEGGBG))]
	private void COMDGOENGJF(OOIIJJALPGP JGIFDLDMIED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x77BD920", Offset = "0x77BCD20", VA = "0x1877BD920", Slot = "43")]
	[AsyncStateMachine(typeof(NDFNIEOACAE))]
	public Task DMGDEDLCGEC([Optional] CancellationToken LAAJFAFNFCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x77BF0D0", Offset = "0x77BE4D0", VA = "0x1877BF0D0")]
	private void MDHHCOOHDDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x77BE830", Offset = "0x77BDC30", VA = "0x1877BE830", Slot = "41")]
	public IDisposable IPBCLKJGEAK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x77BD4C0", Offset = "0x77BC8C0", VA = "0x1877BD4C0", Slot = "42")]
	public void CFDLOCCKDCB(float HKPDGGGHFLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x77BEB70", Offset = "0x77BDF70", VA = "0x1877BEB70")]
	private void LCNKFEPPKOB(float CHCKMAHLBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x77BF6A0", Offset = "0x77BEAA0", VA = "0x1877BF6A0")]
	[IteratorStateMachine(typeof(LIFCDMJMOLN))]
	private IEnumerator<FBLKJCIOKGP> OMIBGAODABB(float HKPDGGGHFLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x77BE450", Offset = "0x77BD850", VA = "0x1877BE450")]
	[CompilerGenerated]
	private void GKDNKFDBIEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class OKIGOGGFBNF : OCNHMOLGBNC<bool>
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static OKIGOGGFBNF IMFIEPMCPDC
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x77C2A80", Offset = "0x77C1E80", VA = "0x1877C2A80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x77C2990", Offset = "0x77C1D90", VA = "0x1877C2990", Slot = "9")]
	public override string IMJDHHAECMF(bool IOJLNNHDMIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x77C2AD0", Offset = "0x77C1ED0", VA = "0x1877C2AD0", Slot = "10")]
	protected override bool OIOCMMLCKLE(string IOJLNNHDMIE, [Out] bool KBGCCIOIGBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x77C2DF0", Offset = "0x77C21F0", VA = "0x1877C2DF0")]
	public OKIGOGGFBNF()
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

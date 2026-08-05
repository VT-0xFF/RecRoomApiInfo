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
		[Cpp2IlInjected.Address(RVA = "0x7865AD0", Offset = "0x78640D0", VA = "0x187865AD0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x245DCB0", Offset = "0x245C2B0", VA = "0x18245DCB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x7862B40", Offset = "0x7861140", VA = "0x187862B40")]
	private static void NEFGKHPAJJO(OOIIJJALPGP IDIFDJHFLBD, LIGMHAMDHFC DOPJJMLPPOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7862200", Offset = "0x7860800", VA = "0x187862200")]
	public static bool ADMKFDOLBAC(this OOIIJJALPGP IDIFDJHFLBD, string BPEJALFMHHI, [Optional] LIGMHAMDHFC DOPJJMLPPOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7862360", Offset = "0x7860960", VA = "0x187862360")]
	public static EFMPBLEPGLL AHBKMKLCAIA(this OOIIJJALPGP IDIFDJHFLBD, string BPEJALFMHHI, string KBGCCIOIGBD, [Optional] LIGMHAMDHFC DOPJJMLPPOB)
	{
		return default(EFMPBLEPGLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x78624B0", Offset = "0x7860AB0", VA = "0x1878624B0")]
	public static EFMPBLEPGLL AMAPGPMJKEI(this OOIIJJALPGP IDIFDJHFLBD, string BPEJALFMHHI, int KBGCCIOIGBD, [Optional] LIGMHAMDHFC DOPJJMLPPOB)
	{
		return default(EFMPBLEPGLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7862880", Offset = "0x7860E80", VA = "0x187862880")]
	public static EFMPBLEPGLL MGBHBLMFDJP(this OOIIJJALPGP IDIFDJHFLBD, string BPEJALFMHHI, bool KBGCCIOIGBD, [Optional] LIGMHAMDHFC DOPJJMLPPOB)
	{
		return default(EFMPBLEPGLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7862730", Offset = "0x7860D30", VA = "0x187862730")]
	public static EFMPBLEPGLL KIHIGFFMPCH(this OOIIJJALPGP IDIFDJHFLBD, string BPEJALFMHHI, float KBGCCIOIGBD, [Optional] LIGMHAMDHFC DOPJJMLPPOB)
	{
		return default(EFMPBLEPGLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x78629D0", Offset = "0x7860FD0", VA = "0x1878629D0")]
	public static EFMPBLEPGLL MJMGBIFCDDG(this OOIIJJALPGP IDIFDJHFLBD, string BPEJALFMHHI, DateTime KBGCCIOIGBD, [Optional] LIGMHAMDHFC DOPJJMLPPOB)
	{
		return default(EFMPBLEPGLL);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x78625F0", Offset = "0x7860BF0", VA = "0x1878625F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x96C540", Offset = "0x96AB40", VA = "0x18096C540", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Dictionary<string, string> CEFDNNBHJAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7862BC0", Offset = "0x78611C0", VA = "0x187862BC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action LHNDGNLJDDE
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7864750", Offset = "0x7862D50", VA = "0x187864750")]
	[UnityEngine.Scripting.Preserve]
	public KAEJPMKDCJD([IBJCGEMJMJL(null)] OMKIPBLMPOD LDNAHMLEOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "8")]
	public void ANIHLAKBIIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x78640B0", Offset = "0x78626B0", VA = "0x1878640B0")]
	private DirectoryInfo JMMJHDIBEBF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7864020", Offset = "0x7862620", VA = "0x187864020", Slot = "6")]
	public Task JCPBIKGMJJI(long CCFNJEFBKEA, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7862C70", Offset = "0x7861270", VA = "0x187862C70", Slot = "14")]
	public float BOBHPPGGGMC(string LKMGECEEGEE, float IDJBNLNBJCD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7864490", Offset = "0x7862A90", VA = "0x187864490", Slot = "13")]
	public void LHIIHHKDLOM(string LKMGECEEGEE, bool KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7862D50", Offset = "0x7861350", VA = "0x187862D50", Slot = "12")]
	public bool CEMGKHJAGPJ(string LKMGECEEGEE, bool IDJBNLNBJCD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7862C00", Offset = "0x7861200", VA = "0x187862C00", Slot = "10")]
	public int BBNEDFGFMOB(string LKMGECEEGEE, int IDJBNLNBJCD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7863160", Offset = "0x7861760", VA = "0x187863160", Slot = "18")]
	public DateTime DHKOJCMCFJB(string BPEJALFMHHI, [Optional] DateTime IDJBNLNBJCD)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x78643B0", Offset = "0x78629B0", VA = "0x1878643B0", Slot = "19")]
	public void KAENDLAFOKC(string LKMGECEEGEE, DateTime KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7863BF0", Offset = "0x78621F0", VA = "0x187863BF0", Slot = "15")]
	public void HJMKDDGINCD(string LKMGECEEGEE, float KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7864420", Offset = "0x7862A20", VA = "0x187864420", Slot = "11")]
	public void KBBNEDAEANH(string LKMGECEEGEE, int KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7862CE0", Offset = "0x78612E0", VA = "0x187862CE0", Slot = "20")]
	public long CAOJMPHHFMP(string BPEJALFMHHI, long IDJBNLNBJCD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7864650", Offset = "0x7862C50", VA = "0x187864650", Slot = "21")]
	public void NNABOHKGMBN(string BPEJALFMHHI, long KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x33DD5C0", Offset = "0x33DBBC0", VA = "0x1833DD5C0", Slot = "22")]
	public T PMCKFJMMAFM<T>(string BPEJALFMHHI, T IDJBNLNBJCD, GJIEELGOKJN<T> BKBAIIENGGA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x33DD5C0", Offset = "0x33DBBC0", VA = "0x1833DD5C0", Slot = "23")]
	public void DNHIDJHDEMJ<T>(string BPEJALFMHHI, T KBGCCIOIGBD, GJIEELGOKJN<T> BKBAIIENGGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7863B40", Offset = "0x7862140", VA = "0x187863B40", Slot = "16")]
	public string HAPGJAEFBKP(string LKMGECEEGEE, string IDJBNLNBJCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x78631D0", Offset = "0x78617D0", VA = "0x1878631D0", Slot = "17")]
	public void ECDPEGOMPPC(string LKMGECEEGEE, string KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7864500", Offset = "0x7862B00", VA = "0x187864500", Slot = "24")]
	public void MNNNIAOKGHH(string LKMGECEEGEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x78646C0", Offset = "0x7862CC0", VA = "0x1878646C0", Slot = "9")]
	public bool PIINNIDMGHH(string LKMGECEEGEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7862E20", Offset = "0x7861420", VA = "0x187862E20", Slot = "25")]
	public Task COMDGOENGJF(CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7863C60", Offset = "0x7862260", VA = "0x187863C60")]
	private void HNNANHENPPK(DirectoryInfo JHCPNLHCNOG, string DLBEKKMOGCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x78641B0", Offset = "0x78627B0", VA = "0x1878641B0")]
	private static string KABGNEPAEMH(string LKMGECEEGEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7863240", Offset = "0x7861840", VA = "0x187863240")]
	private static string FOKHFJHKCAH(byte[] HECJPBMFJGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x34959C0", Offset = "0x3493FC0", VA = "0x1834959C0")]
	private T NPPDIJEBOHO<T>(string BPEJALFMHHI, T IDJBNLNBJCD, [Optional] GJIEELGOKJN<T> KBFPIODOOCM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x34945E0", Offset = "0x3492BE0", VA = "0x1834945E0")]
	private void ECFLGDLFBIO<T>(string BPEJALFMHHI, T KBGCCIOIGBD, [Optional] GJIEELGOKJN<T> KBFPIODOOCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7863340", Offset = "0x7861940", VA = "0x187863340")]
	private Dictionary<string, string> GELHKGIFPDO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal static class HNDPPKMMKNN
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7862010", Offset = "0x7860610", VA = "0x187862010")]
	[HLOHOCOKELO.IDGFAEKKODB]
	internal static void AOKDCDMDNDH(GFKEMDIOCPC MGOKPJKELJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class IMONMOJBMCG : PKGAIODIMID
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7862170", Offset = "0x7860770", VA = "0x187862170")]
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
		[Cpp2IlInjected.Address(RVA = "0x96C540", Offset = "0x96AB40", VA = "0x18096C540", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action LHNDGNLJDDE
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "8")]
	public void ANIHLAKBIIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7865630", Offset = "0x7863C30", VA = "0x187865630", Slot = "6")]
	public Task JCPBIKGMJJI(long CCFNJEFBKEA, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x78658A0", Offset = "0x7863EA0", VA = "0x1878658A0", Slot = "9")]
	public bool PIINNIDMGHH(string BPEJALFMHHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x78652A0", Offset = "0x78638A0", VA = "0x1878652A0", Slot = "10")]
	public int BBNEDFGFMOB(string BPEJALFMHHI, int IDJBNLNBJCD = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7865720", Offset = "0x7863D20", VA = "0x187865720", Slot = "11")]
	public void KBBNEDAEANH(string BPEJALFMHHI, int KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x78653C0", Offset = "0x78639C0", VA = "0x1878653C0", Slot = "12")]
	public bool CEMGKHJAGPJ(string BPEJALFMHHI, bool IDJBNLNBJCD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7865780", Offset = "0x7863D80", VA = "0x187865780", Slot = "13")]
	public void LHIIHHKDLOM(string BPEJALFMHHI, bool KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7865300", Offset = "0x7863900", VA = "0x187865300", Slot = "14")]
	public float BOBHPPGGGMC(string BPEJALFMHHI, float IDJBNLNBJCD = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x78655D0", Offset = "0x7863BD0", VA = "0x1878655D0", Slot = "15")]
	public void HJMKDDGINCD(string BPEJALFMHHI, float KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7865570", Offset = "0x7863B70", VA = "0x187865570", Slot = "16")]
	public string HAPGJAEFBKP(string BPEJALFMHHI, [Optional] string IDJBNLNBJCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7865510", Offset = "0x7863B10", VA = "0x187865510", Slot = "17")]
	public void ECDPEGOMPPC(string BPEJALFMHHI, string KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x78654B0", Offset = "0x7863AB0", VA = "0x1878654B0", Slot = "18")]
	public DateTime DHKOJCMCFJB(string BPEJALFMHHI, [Optional] DateTime IDJBNLNBJCD)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x78656C0", Offset = "0x7863CC0", VA = "0x1878656C0", Slot = "19")]
	public void KAENDLAFOKC(string BPEJALFMHHI, DateTime KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7865360", Offset = "0x7863960", VA = "0x187865360", Slot = "20")]
	public long CAOJMPHHFMP(string BPEJALFMHHI, long IDJBNLNBJCD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7865840", Offset = "0x7863E40", VA = "0x187865840", Slot = "21")]
	public void NNABOHKGMBN(string BPEJALFMHHI, long KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x360BC50", Offset = "0x360A250", VA = "0x18360BC50", Slot = "22")]
	public T PMCKFJMMAFM<T>(string BPEJALFMHHI, T IDJBNLNBJCD, GJIEELGOKJN<T> BKBAIIENGGA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x360ADE0", Offset = "0x36093E0", VA = "0x18360ADE0", Slot = "23")]
	public void DNHIDJHDEMJ<T>(string BPEJALFMHHI, T KBGCCIOIGBD, GJIEELGOKJN<T> BKBAIIENGGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x360B3B0", Offset = "0x36099B0", VA = "0x18360B3B0")]
	public T NPPDIJEBOHO<T>(string BPEJALFMHHI, T IDJBNLNBJCD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x360AEC0", Offset = "0x36094C0", VA = "0x18360AEC0")]
	public void ECFLGDLFBIO<T>(string BPEJALFMHHI, T KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x78657E0", Offset = "0x7863DE0", VA = "0x1878657E0", Slot = "24")]
	public void MNNNIAOKGHH(string BPEJALFMHHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7865420", Offset = "0x7863A20", VA = "0x187865420", Slot = "25")]
	public Task COMDGOENGJF(CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7862170", Offset = "0x7860770", VA = "0x187862170")]
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
	[Cpp2IlInjected.Address(RVA = "0x46C44D0", Offset = "0x46C2AD0", VA = "0x1846C44D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x46C3F20", Offset = "0x46C2520", VA = "0x1846C3F20")]
	public static void ACDEJNADHJA(string LKMGECEEGEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x46C4160", Offset = "0x46C2760", VA = "0x1846C4160")]
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
	[Cpp2IlInjected.Address(RVA = "0x47D37C0", Offset = "0x47D1DC0", VA = "0x1847D37C0")]
	public bool GMJNAAAPBAP(string MHOMJGNFGGL, [Out] TValue FOAKCJPCPOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x47D3820", Offset = "0x47D1E20", VA = "0x1847D3820")]
	public void HGJJHONLMGO(string MHOMJGNFGGL, TValue KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x40692C0", Offset = "0x40678C0", VA = "0x1840692C0", Slot = "4")]
	protected override void KKIOKOIHHPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x4069310", Offset = "0x4067910", VA = "0x184069310", Slot = "5")]
	protected override void DELLKJHCBFJ(string MHOMJGNFGGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x47D3AC0", Offset = "0x47D20C0", VA = "0x1847D3AC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x785CB70", Offset = "0x785B170", VA = "0x18785CB70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x785CF40", Offset = "0x785B540", VA = "0x18785CF40", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x9527A0", Offset = "0x950DA0", VA = "0x1809527A0")]
		[DebuggerHidden]
		public HJCLDKFGKOH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x785ED60", Offset = "0x785D360", VA = "0x18785ED60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x785EDD0", Offset = "0x785D3D0", VA = "0x18785EDD0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x96C540", Offset = "0x96AB40", VA = "0x18096C540", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action LHNDGNLJDDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x785EC70", Offset = "0x785D270", VA = "0x18785EC70")]
	[UnityEngine.Scripting.Preserve]
	public HEGMOHNNMAN([IBJCGEMJMJL(null)] OMKIPBLMPOD LDNAHMLEOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "8")]
	public void ANIHLAKBIIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x785E910", Offset = "0x785CF10", VA = "0x18785E910", Slot = "6")]
	public Task JCPBIKGMJJI(long CCFNJEFBKEA, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x18C1E50", Offset = "0x18C0450", VA = "0x1818C1E50")]
	private static int EIGBEOECKJJ(bool KBGCCIOIGBD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x785EC50", Offset = "0x785D250", VA = "0x18785EC50", Slot = "9")]
	public bool PIINNIDMGHH(string BPEJALFMHHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x785E550", Offset = "0x785CB50", VA = "0x18785E550", Slot = "10")]
	public int BBNEDFGFMOB(string BPEJALFMHHI, int IDJBNLNBJCD = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x785EA10", Offset = "0x785D010", VA = "0x18785EA10", Slot = "11")]
	public void KBBNEDAEANH(string BPEJALFMHHI, int KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x785E620", Offset = "0x785CC20", VA = "0x18785E620", Slot = "12")]
	public bool CEMGKHJAGPJ(string BPEJALFMHHI, bool IDJBNLNBJCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x785EA60", Offset = "0x785D060", VA = "0x18785EA60", Slot = "13")]
	public void LHIIHHKDLOM(string BPEJALFMHHI, bool KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x785E580", Offset = "0x785CB80", VA = "0x18785E580", Slot = "14")]
	public float BOBHPPGGGMC(string BPEJALFMHHI, float IDJBNLNBJCD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x785E8E0", Offset = "0x785CEE0", VA = "0x18785E8E0", Slot = "15")]
	public void HJMKDDGINCD(string BPEJALFMHHI, float KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x785E740", Offset = "0x785CD40", VA = "0x18785E740", Slot = "18")]
	public DateTime DHKOJCMCFJB(string BPEJALFMHHI, [Optional] DateTime IDJBNLNBJCD)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x785E9A0", Offset = "0x785CFA0", VA = "0x18785E9A0", Slot = "19")]
	public void KAENDLAFOKC(string BPEJALFMHHI, DateTime FLCMHPCNDLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x785E5B0", Offset = "0x785CBB0", VA = "0x18785E5B0", Slot = "20")]
	public long CAOJMPHHFMP(string BPEJALFMHHI, long IDJBNLNBJCD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x785EB40", Offset = "0x785D140", VA = "0x18785EB40", Slot = "21")]
	public void NNABOHKGMBN(string BPEJALFMHHI, long KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x33EAE20", Offset = "0x33E9420", VA = "0x1833EAE20", Slot = "22")]
	public T PMCKFJMMAFM<T>(string BPEJALFMHHI, T IDJBNLNBJCD, GJIEELGOKJN<T> BKBAIIENGGA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x33EAE20", Offset = "0x33E9420", VA = "0x1833EAE20", Slot = "23")]
	public void DNHIDJHDEMJ<T>(string BPEJALFMHHI, T KBGCCIOIGBD, GJIEELGOKJN<T> BKBAIIENGGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x33EB660", Offset = "0x33E9C60", VA = "0x1833EB660")]
	private T KNIFMCLGACA<T>(string BPEJALFMHHI, T IDJBNLNBJCD, [Optional] GJIEELGOKJN<T> KBFPIODOOCM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x33EAFB0", Offset = "0x33E95B0", VA = "0x1833EAFB0")]
	private void EGEDJLHBFMP<T>(string BPEJALFMHHI, T KBGCCIOIGBD, [Optional] GJIEELGOKJN<T> KBFPIODOOCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x785E840", Offset = "0x785CE40", VA = "0x18785E840", Slot = "16")]
	public string HAPGJAEFBKP(string BPEJALFMHHI, string IDJBNLNBJCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x785E810", Offset = "0x785CE10", VA = "0x18785E810", Slot = "17")]
	public void ECDPEGOMPPC(string BPEJALFMHHI, string KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x785EA40", Offset = "0x785D040", VA = "0x18785EA40")]
	private void LFOIJNFDLGM(string BPEJALFMHHI, string KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x785EB20", Offset = "0x785D120", VA = "0x18785EB20")]
	private string NBKAIFOJBDP(string BPEJALFMHHI, string IDJBNLNBJCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x785EA90", Offset = "0x785D090", VA = "0x18785EA90", Slot = "24")]
	public void MNNNIAOKGHH(string BPEJALFMHHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x785EBB0", Offset = "0x785D1B0", VA = "0x18785EBB0")]
	private string ODMDNKLBBOD(string LKMGECEEGEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x785E650", Offset = "0x785CC50", VA = "0x18785E650", Slot = "25")]
	[AsyncStateMachine(typeof(CEPNPHMIFNF))]
	public Task COMDGOENGJF(CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x785E460", Offset = "0x785CA60", VA = "0x18785E460")]
	[IteratorStateMachine(typeof(HJCLDKFGKOH))]
	private IEnumerator<FBLKJCIOKGP> AHIBFFJNCCO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x785E7B0", Offset = "0x785CDB0", VA = "0x18785E7B0")]
	private void DMGDEDLCGEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x785E4E0", Offset = "0x785CAE0", VA = "0x18785E4E0")]
	private void AMPJOOHHMNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x785E870", Offset = "0x785CE70", VA = "0x18785E870")]
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
		[Cpp2IlInjected.Address(RVA = "0x96C540", Offset = "0x96AB40", VA = "0x18096C540", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private string GOCMPMDBMEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x785E050", Offset = "0x785C650", VA = "0x18785E050")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private Dictionary<string, string> CEFDNNBHJAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x785D650", Offset = "0x785BC50", VA = "0x18785D650")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action LHNDGNLJDDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
	[UnityEngine.Scripting.Preserve]
	public GLNGLLGDMBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "8")]
	public void ANIHLAKBIIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x785E0C0", Offset = "0x785C6C0", VA = "0x18785E0C0", Slot = "6")]
	public Task JCPBIKGMJJI(long CCFNJEFBKEA, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x785D700", Offset = "0x785BD00", VA = "0x18785D700", Slot = "14")]
	public float BOBHPPGGGMC(string LKMGECEEGEE, float IDJBNLNBJCD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x785E230", Offset = "0x785C830", VA = "0x18785E230", Slot = "13")]
	public void LHIIHHKDLOM(string LKMGECEEGEE, bool KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x785D7E0", Offset = "0x785BDE0", VA = "0x18785D7E0", Slot = "12")]
	public bool CEMGKHJAGPJ(string LKMGECEEGEE, bool IDJBNLNBJCD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x785D690", Offset = "0x785BC90", VA = "0x18785D690", Slot = "10")]
	public int BBNEDFGFMOB(string LKMGECEEGEE, int IDJBNLNBJCD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x785DB20", Offset = "0x785C120", VA = "0x18785DB20", Slot = "18")]
	public DateTime DHKOJCMCFJB(string BPEJALFMHHI, [Optional] DateTime IDJBNLNBJCD)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x785E150", Offset = "0x785C750", VA = "0x18785E150", Slot = "19")]
	public void KAENDLAFOKC(string LKMGECEEGEE, DateTime KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x785DFE0", Offset = "0x785C5E0", VA = "0x18785DFE0", Slot = "15")]
	public void HJMKDDGINCD(string LKMGECEEGEE, float KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x785E1C0", Offset = "0x785C7C0", VA = "0x18785E1C0", Slot = "11")]
	public void KBBNEDAEANH(string LKMGECEEGEE, int KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x785D770", Offset = "0x785BD70", VA = "0x18785D770", Slot = "20")]
	public long CAOJMPHHFMP(string BPEJALFMHHI, long IDJBNLNBJCD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x785E360", Offset = "0x785C960", VA = "0x18785E360", Slot = "21")]
	public void NNABOHKGMBN(string BPEJALFMHHI, long KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x33DD5C0", Offset = "0x33DBBC0", VA = "0x1833DD5C0", Slot = "22")]
	public T PMCKFJMMAFM<T>(string BPEJALFMHHI, T IDJBNLNBJCD, GJIEELGOKJN<T> BKBAIIENGGA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x33DD5C0", Offset = "0x33DBBC0", VA = "0x1833DD5C0", Slot = "23")]
	public void DNHIDJHDEMJ<T>(string BPEJALFMHHI, T KBGCCIOIGBD, GJIEELGOKJN<T> BKBAIIENGGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x785DF30", Offset = "0x785C530", VA = "0x18785DF30", Slot = "16")]
	public string HAPGJAEFBKP(string LKMGECEEGEE, string IDJBNLNBJCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x785DB90", Offset = "0x785C190", VA = "0x18785DB90", Slot = "17")]
	public void ECDPEGOMPPC(string LKMGECEEGEE, string KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x785E2A0", Offset = "0x785C8A0", VA = "0x18785E2A0", Slot = "24")]
	public void MNNNIAOKGHH(string LKMGECEEGEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x785E3D0", Offset = "0x785C9D0", VA = "0x18785E3D0", Slot = "9")]
	public bool PIINNIDMGHH(string LKMGECEEGEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x785D8B0", Offset = "0x785BEB0", VA = "0x18785D8B0", Slot = "25")]
	public Task COMDGOENGJF(CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x33DE610", Offset = "0x33DCC10", VA = "0x1833DE610")]
	private T NPPDIJEBOHO<T>(string BPEJALFMHHI, T IDJBNLNBJCD, [Optional] GJIEELGOKJN<T> KBFPIODOOCM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x33DD6C0", Offset = "0x33DBCC0", VA = "0x1833DD6C0")]
	private void ECFLGDLFBIO<T>(string BPEJALFMHHI, T KBGCCIOIGBD, [Optional] GJIEELGOKJN<T> KBFPIODOOCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x785DC30", Offset = "0x785C230", VA = "0x18785DC30")]
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
		[Cpp2IlInjected.Address(RVA = "0x785CFA0", Offset = "0x785B5A0", VA = "0x18785CFA0")]
		public static void IMBDFHKDIBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void KKIOKOIHHPE();

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x950410", Offset = "0x94EA10", VA = "0x180950410")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x950400", Offset = "0x94EA00", VA = "0x180950400")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public IEqualityComparer<T> NKHINAKIHME
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x9529B0", Offset = "0x950FB0", VA = "0x1809529B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool BMMDOMLIOEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x4046ED0", Offset = "0x40454D0", VA = "0x184046ED0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x4E9D4D0", Offset = "0x4E9BAD0", VA = "0x184E9D4D0")]
		private NHBKBBIPCMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x4E9CFB0", Offset = "0x4E9B5B0", VA = "0x184E9CFB0")]
		public void OCICFIBHEPA(GJIEELGOKJN<T> KBFPIODOOCM, [Optional] IEqualityComparer<T> BLMEGMHOING)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x4E9CD70", Offset = "0x4E9B370", VA = "0x184E9CD70", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x7865930", Offset = "0x7863F30", VA = "0x187865930")]
		public PKMBDGFMDLE(HLPAHNEMLHA HFGMMHMEBAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x7865900", Offset = "0x7863F00", VA = "0x187865900", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x785D170", Offset = "0x785B770", VA = "0x18785D170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x785D460", Offset = "0x785BA60", VA = "0x18785D460", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x785D4C0", Offset = "0x785BAC0", VA = "0x18785D4C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0xA50FB0", Offset = "0xA4F5B0", VA = "0x180A50FB0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x78648D0", Offset = "0x7862ED0", VA = "0x1878648D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7864DA0", Offset = "0x78633A0", VA = "0x187864DA0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x9527A0", Offset = "0x950DA0", VA = "0x1809527A0")]
		[DebuggerHidden]
		public LIFCDMJMOLN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x78647F0", Offset = "0x7862DF0", VA = "0x1878647F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7864880", Offset = "0x7862E80", VA = "0x187864880", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x7861260", Offset = "0x785F860", VA = "0x187861260")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private CancellationTokenSource JPFEGFAMCEN
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x956D70", Offset = "0x955370", VA = "0x180956D70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x956B10", Offset = "0x955110", VA = "0x180956B10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action LHNDGNLJDDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7861720", Offset = "0x785FD20", VA = "0x187861720", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x78608F0", Offset = "0x785EEF0", VA = "0x1878608F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x785F460", Offset = "0x785DA60", VA = "0x18785F460")]
	[HLOHOCOKELO.IDGFAEKKODB]
	internal static void APJICGAGHJP(GFKEMDIOCPC MGOKPJKELJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7861C40", Offset = "0x7860240", VA = "0x187861C40")]
	[UnityEngine.Scripting.Preserve]
	public HLPAHNEMLHA([IBJCGEMJMJL("Disk")] BDNIPAJKPBI HMGLFKGNOCN, [IBJCGEMJMJL("Cloud")] BDNIPAJKPBI HHFKBHEFJOH, [IBJCGEMJMJL(null)] DPNIFEIAIDJ ABOGODOFAMP, [IBJCGEMJMJL(null)] MEFKNEOFFHC JGFDBKNDMLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x785FE80", Offset = "0x785E480", VA = "0x18785FE80", Slot = "44")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x7860C50", Offset = "0x785F250", VA = "0x187860C50")]
	private void IOGHJJLHGPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x785F3F0", Offset = "0x785D9F0", VA = "0x18785F3F0", Slot = "6")]
	public void ANIHLAKBIIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x785FEC0", Offset = "0x785E4C0", VA = "0x18785FEC0", Slot = "7")]
	public Task EAPGHIAENOD(long CCFNJEFBKEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x7861280", Offset = "0x785F880", VA = "0x187861280")]
	[AsyncStateMachine(typeof(EOAPFLIKDAK))]
	private Task LHJKNNGCHDL(long CCFNJEFBKEA, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x7860110", Offset = "0x785E710", VA = "0x187860110")]
	private void EICBHNPALML(object LAAJFAFNFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x78617C0", Offset = "0x785FDC0", VA = "0x1878617C0")]
	private void NJINBFAIGDF(object LAAJFAFNFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x785F390", Offset = "0x785D990", VA = "0x18785F390")]
	private string AMOCFIAGIBH(string JNIJNEHBMFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x78605B0", Offset = "0x785EBB0", VA = "0x1878605B0")]
	private void GGHLHLCJBMF(BELLPEALDFB EBMOJGOBHLD, string LKMGECEEGEE, [Out] BDNIPAJKPBI IDIFDJHFLBD, [Out] string FKLOHECCGAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x7860EF0", Offset = "0x785F4F0", VA = "0x187860EF0")]
	private BDNIPAJKPBI JPAFBGFHECA(BELLPEALDFB EBMOJGOBHLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x78619E0", Offset = "0x785FFE0", VA = "0x1878619E0", Slot = "8")]
	public bool OKOPGOCCIEO(BELLPEALDFB EBMOJGOBHLD = BELLPEALDFB.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x785F570", Offset = "0x785DB70", VA = "0x18785F570", Slot = "9")]
	public bool BNNDLIEHOJM(string BPEJALFMHHI, BELLPEALDFB JGLMDDGGLNH = BELLPEALDFB.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x7860270", Offset = "0x785E870", VA = "0x187860270", Slot = "10")]
	public bool FLDKBJBGFFC(string BPEJALFMHHI, BELLPEALDFB JGLMDDGGLNH = BELLPEALDFB.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x785FA10", Offset = "0x785E010", VA = "0x18785FA10", Slot = "11")]
	public string DDNMFHCABOE(string BPEJALFMHHI, [Optional] string IDJBNLNBJCD, BELLPEALDFB JGLMDDGGLNH = BELLPEALDFB.CLOUD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x785F0D0", Offset = "0x785D6D0", VA = "0x18785F0D0", Slot = "12")]
	public EFMPBLEPGLL AMDKJKPFAJM(string BPEJALFMHHI, string KBGCCIOIGBD, BELLPEALDFB JGLMDDGGLNH = BELLPEALDFB.CLOUD)
	{
		return default(EFMPBLEPGLL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x785EE20", Offset = "0x785D420", VA = "0x18785EE20", Slot = "13")]
	public int AAHIMAJGNPI(string BPEJALFMHHI, int IDJBNLNBJCD = 0, BELLPEALDFB JGLMDDGGLNH = BELLPEALDFB.CLOUD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x785EF60", Offset = "0x785D560", VA = "0x18785EF60", Slot = "14")]
	public EFMPBLEPGLL AIFMJMAMCIJ(string BPEJALFMHHI, int KBGCCIOIGBD, BELLPEALDFB JGLMDDGGLNH = BELLPEALDFB.CLOUD)
	{
		return default(EFMPBLEPGLL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x7860990", Offset = "0x785EF90", VA = "0x187860990", Slot = "15")]
	public bool HHPKMEEGFOO(string BPEJALFMHHI, bool IDJBNLNBJCD, BELLPEALDFB JGLMDDGGLNH = BELLPEALDFB.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x7860A40", Offset = "0x785F040", VA = "0x187860A40", Slot = "16")]
	public EFMPBLEPGLL HKPJKJFPPAO(string BPEJALFMHHI, bool KBGCCIOIGBD, BELLPEALDFB JGLMDDGGLNH = BELLPEALDFB.CLOUD)
	{
		return default(EFMPBLEPGLL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x7860130", Offset = "0x785E730", VA = "0x187860130", Slot = "17")]
	public float EIFIOIMOBNB(string BPEJALFMHHI, float IDJBNLNBJCD = 0f, BELLPEALDFB JGLMDDGGLNH = BELLPEALDFB.CLOUD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x785FAB0", Offset = "0x785E0B0", VA = "0x18785FAB0", Slot = "18")]
	public EFMPBLEPGLL DJHOGAFGDLF(string BPEJALFMHHI, float KBGCCIOIGBD, BELLPEALDFB JGLMDDGGLNH = BELLPEALDFB.CLOUD)
	{
		return default(EFMPBLEPGLL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x785F890", Offset = "0x785DE90", VA = "0x18785F890", Slot = "19")]
	public DateTime CEKEGGBOHHE(string BPEJALFMHHI, [Optional] DateTime IDJBNLNBJCD, BELLPEALDFB JGLMDDGGLNH = BELLPEALDFB.CLOUD)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x7861840", Offset = "0x785FE40", VA = "0x187861840", Slot = "20")]
	public EFMPBLEPGLL OGLFDDMCMPC(string BPEJALFMHHI, DateTime KBGCCIOIGBD, BELLPEALDFB JGLMDDGGLNH = BELLPEALDFB.CLOUD)
	{
		return default(EFMPBLEPGLL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x7861BA0", Offset = "0x78601A0", VA = "0x187861BA0", Slot = "21")]
	public long POGKBMAMAOC(string BPEJALFMHHI, long IDJBNLNBJCD = 0L, BELLPEALDFB JGLMDDGGLNH = BELLPEALDFB.CLOUD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x7860D80", Offset = "0x785F380", VA = "0x187860D80", Slot = "22")]
	public EFMPBLEPGLL JFBGELIHOKA(string BPEJALFMHHI, long KBGCCIOIGBD, BELLPEALDFB JGLMDDGGLNH = BELLPEALDFB.CLOUD)
	{
		return default(EFMPBLEPGLL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x33EF6C0", Offset = "0x33EDCC0", VA = "0x1833EF6C0", Slot = "23")]
	public T LKMNEJMJOCO<T>(string BPEJALFMHHI, [Optional] T IDJBNLNBJCD, BELLPEALDFB JGLMDDGGLNH = BELLPEALDFB.CLOUD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x33EF6C0", Offset = "0x33EDCC0", VA = "0x1833EF6C0", Slot = "24")]
	public EFMPBLEPGLL FPOPKHNMJBH<T>(string BPEJALFMHHI, T KBGCCIOIGBD, BELLPEALDFB JGLMDDGGLNH = BELLPEALDFB.CLOUD)
	{
		return default(EFMPBLEPGLL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x785EF00", Offset = "0x785D500", VA = "0x18785EF00", Slot = "25")]
	public bool AFDOGIDDPIA(string BPEJALFMHHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x7860090", Offset = "0x785E690", VA = "0x187860090", Slot = "26")]
	public bool EGGHNJGHADM(string BPEJALFMHHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x78600A0", Offset = "0x785E6A0", VA = "0x1878600A0", Slot = "27")]
	public string EHAMPKJDLCE(string BPEJALFMHHI, [Optional] string IDJBNLNBJCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x7860210", Offset = "0x785E810", VA = "0x187860210", Slot = "28")]
	public EFMPBLEPGLL FEFIMAJPPHH(string BPEJALFMHHI, string KBGCCIOIGBD)
	{
		return default(EFMPBLEPGLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x7860F70", Offset = "0x785F570", VA = "0x187860F70", Slot = "29")]
	public int KMILJHGEMCK(string BPEJALFMHHI, int IDJBNLNBJCD = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x7860240", Offset = "0x785E840", VA = "0x187860240", Slot = "30")]
	public EFMPBLEPGLL FFPDBLHGNEL(string BPEJALFMHHI, int KBGCCIOIGBD)
	{
		return default(EFMPBLEPGLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x7861AA0", Offset = "0x78600A0", VA = "0x187861AA0", Slot = "31")]
	public bool OMACPJGINHK(string BPEJALFMHHI, bool IDJBNLNBJCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x78601E0", Offset = "0x785E7E0", VA = "0x1878601E0", Slot = "32")]
	public EFMPBLEPGLL EPFKANIGANB(string BPEJALFMHHI, bool KBGCCIOIGBD)
	{
		return default(EFMPBLEPGLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x785F4D0", Offset = "0x785DAD0", VA = "0x18785F4D0", Slot = "33")]
	public float BAOHNMCAPOG(string BPEJALFMHHI, float IDJBNLNBJCD = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x785EED0", Offset = "0x785D4D0", VA = "0x18785EED0", Slot = "34")]
	public EFMPBLEPGLL AALNPAOBJBE(string BPEJALFMHHI, float KBGCCIOIGBD)
	{
		return default(EFMPBLEPGLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x7860BE0", Offset = "0x785F1E0", VA = "0x187860BE0", Slot = "35")]
	public DateTime IEOPPJCLJIN(string BPEJALFMHHI, [Optional] DateTime IDJBNLNBJCD)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x785F540", Offset = "0x785DB40", VA = "0x18785F540", Slot = "36")]
	public EFMPBLEPGLL BFGIEBCEEME(string BPEJALFMHHI, DateTime KBGCCIOIGBD)
	{
		return default(EFMPBLEPGLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x78603F0", Offset = "0x785E9F0", VA = "0x1878603F0", Slot = "37")]
	public long GBNEGNGGBPO(string BPEJALFMHHI, long IDJBNLNBJCD = 0L)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x7860BB0", Offset = "0x785F1B0", VA = "0x187860BB0", Slot = "38")]
	public EFMPBLEPGLL HNHPFFPIKML(string BPEJALFMHHI, long KBGCCIOIGBD)
	{
		return default(EFMPBLEPGLL);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7861390", Offset = "0x785F990", VA = "0x187861390")]
	private bool LPJOJNBKCPP(OOIIJJALPGP IDIFDJHFLBD, string BPEJALFMHHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x785FC30", Offset = "0x785E230", VA = "0x18785FC30")]
	private bool DMCMNMBOCJB(OOIIJJALPGP IDIFDJHFLBD, string BPEJALFMHHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x78613F0", Offset = "0x785F9F0", VA = "0x1878613F0")]
	private EFMPBLEPGLL MAAAKJKJGKO(OOIIJJALPGP IDIFDJHFLBD, string BPEJALFMHHI, string KBGCCIOIGBD)
	{
		return default(EFMPBLEPGLL);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x785F250", Offset = "0x785D850", VA = "0x18785F250")]
	private EFMPBLEPGLL AMMCENHLLHK(OOIIJJALPGP IDIFDJHFLBD, string BPEJALFMHHI, int KBGCCIOIGBD)
	{
		return default(EFMPBLEPGLL);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x785F750", Offset = "0x785DD50", VA = "0x18785F750")]
	private EFMPBLEPGLL CBAKIPJAIKG(OOIIJJALPGP IDIFDJHFLBD, string BPEJALFMHHI, bool KBGCCIOIGBD)
	{
		return default(EFMPBLEPGLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x7860460", Offset = "0x785EA60", VA = "0x187860460")]
	private EFMPBLEPGLL GEBEODEIJMF(OOIIJJALPGP IDIFDJHFLBD, string BPEJALFMHHI, float KBGCCIOIGBD)
	{
		return default(EFMPBLEPGLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x7860750", Offset = "0x785ED50", VA = "0x187860750")]
	private EFMPBLEPGLL GGOIINNBGMM(OOIIJJALPGP IDIFDJHFLBD, string BPEJALFMHHI, DateTime KBGCCIOIGBD)
	{
		return default(EFMPBLEPGLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x785F610", Offset = "0x785DC10", VA = "0x18785F610")]
	private EFMPBLEPGLL CADDMOBKFIB(OOIIJJALPGP IDIFDJHFLBD, string BPEJALFMHHI, long KBGCCIOIGBD)
	{
		return default(EFMPBLEPGLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x33EF150", Offset = "0x33ED750", VA = "0x1833EF150")]
	private T FMCFCGJHJNE<T>(OOIIJJALPGP IDIFDJHFLBD, string BPEJALFMHHI, T IDJBNLNBJCD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x33EE570", Offset = "0x33ECB70", VA = "0x1833EE570")]
	private EFMPBLEPGLL CBMBAMOHGPD<T>(OOIIJJALPGP IDIFDJHFLBD, string BPEJALFMHHI, T KBGCCIOIGBD)
	{
		return default(EFMPBLEPGLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x33EF890", Offset = "0x33EDE90", VA = "0x1833EF890", Slot = "39")]
	public void ILDCMDMNFPO<T>(GJIEELGOKJN<T> BKBAIIENGGA, [Optional] IEqualityComparer<T> BLMEGMHOING)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x33EF940", Offset = "0x33EDF40", VA = "0x1833EF940", Slot = "40")]
	public void LFMACMGMKKI<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x785F940", Offset = "0x785DF40", VA = "0x18785F940")]
	[AsyncStateMachine(typeof(GAACAPEGGBG))]
	private void COMDGOENGJF(OOIIJJALPGP JGIFDLDMIED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x785FD90", Offset = "0x785E390", VA = "0x18785FD90", Slot = "43")]
	[AsyncStateMachine(typeof(NDFNIEOACAE))]
	public Task DMGDEDLCGEC([Optional] CancellationToken LAAJFAFNFCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x7861540", Offset = "0x785FB40", VA = "0x187861540")]
	private void MDHHCOOHDDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x7860CA0", Offset = "0x785F2A0", VA = "0x187860CA0", Slot = "41")]
	public IDisposable IPBCLKJGEAK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x785F930", Offset = "0x785DF30", VA = "0x18785F930", Slot = "42")]
	public void CFDLOCCKDCB(float HKPDGGGHFLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x7860FE0", Offset = "0x785F5E0", VA = "0x187860FE0")]
	private void LCNKFEPPKOB(float CHCKMAHLBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x7861B10", Offset = "0x7860110", VA = "0x187861B10")]
	[IteratorStateMachine(typeof(LIFCDMJMOLN))]
	private IEnumerator<FBLKJCIOKGP> OMIBGAODABB(float HKPDGGGHFLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x78608C0", Offset = "0x785EEC0", VA = "0x1878608C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7864EF0", Offset = "0x78634F0", VA = "0x187864EF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x7864E00", Offset = "0x7863400", VA = "0x187864E00", Slot = "9")]
	public override string IMJDHHAECMF(bool IOJLNNHDMIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7864F40", Offset = "0x7863540", VA = "0x187864F40", Slot = "10")]
	protected override bool OIOCMMLCKLE(string IOJLNNHDMIE, [Out] bool KBGCCIOIGBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x7865260", Offset = "0x7863860", VA = "0x187865260")]
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

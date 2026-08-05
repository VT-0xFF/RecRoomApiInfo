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
		[Cpp2IlInjected.Address(RVA = "0x70C6250", Offset = "0x70C4C50", VA = "0x1870C6250", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2164780", Offset = "0x2163180", VA = "0x182164780")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum FCJAIBCGFCE : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	CLOUD,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	DISK
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
internal static class LIHFKABPNIB
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	internal delegate void HEHLABHAGGJ(GOIJOCKJDEC EKHCBDGNDCI);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x70C0060", Offset = "0x70BEA60", VA = "0x1870C0060")]
	private static void APMKAIIELKC(GOIJOCKJDEC EKHCBDGNDCI, HEHLABHAGGJ LAMJGNEGIAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x70C08C0", Offset = "0x70BF2C0", VA = "0x1870C08C0")]
	public static bool PGFHEJMPGLG(this GOIJOCKJDEC EKHCBDGNDCI, string NHDAMJEEJKD, [Optional] HEHLABHAGGJ LAMJGNEGIAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x70C0230", Offset = "0x70BEC30", VA = "0x1870C0230")]
	public static DEIDCEBOPPL EMPEIOJHINI(this GOIJOCKJDEC EKHCBDGNDCI, string NHDAMJEEJKD, string PKCLPFEIPFH, [Optional] HEHLABHAGGJ LAMJGNEGIAK)
	{
		return default(DEIDCEBOPPL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x70C0780", Offset = "0x70BF180", VA = "0x1870C0780")]
	public static DEIDCEBOPPL ODDLJDCANAL(this GOIJOCKJDEC EKHCBDGNDCI, string NHDAMJEEJKD, int PKCLPFEIPFH, [Optional] HEHLABHAGGJ LAMJGNEGIAK)
	{
		return default(DEIDCEBOPPL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x70C00E0", Offset = "0x70BEAE0", VA = "0x1870C00E0")]
	public static DEIDCEBOPPL BLGAOPCOCDM(this GOIJOCKJDEC EKHCBDGNDCI, string NHDAMJEEJKD, bool PKCLPFEIPFH, [Optional] HEHLABHAGGJ LAMJGNEGIAK)
	{
		return default(DEIDCEBOPPL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x70C0630", Offset = "0x70BF030", VA = "0x1870C0630")]
	public static DEIDCEBOPPL NJMKPHMPJFH(this GOIJOCKJDEC EKHCBDGNDCI, string NHDAMJEEJKD, float PKCLPFEIPFH, [Optional] HEHLABHAGGJ LAMJGNEGIAK)
	{
		return default(DEIDCEBOPPL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x70C0380", Offset = "0x70BED80", VA = "0x1870C0380")]
	public static DEIDCEBOPPL HIJGDFMAAEM(this GOIJOCKJDEC EKHCBDGNDCI, string NHDAMJEEJKD, DateTime PKCLPFEIPFH, [Optional] HEHLABHAGGJ LAMJGNEGIAK)
	{
		return default(DEIDCEBOPPL);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x70C04F0", Offset = "0x70BEEF0", VA = "0x1870C04F0")]
	public static DEIDCEBOPPL IFMNHNPJCPI(this GOIJOCKJDEC EKHCBDGNDCI, string NHDAMJEEJKD, long PKCLPFEIPFH, [Optional] HEHLABHAGGJ LAMJGNEGIAK)
	{
		return default(DEIDCEBOPPL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class DBJOMNPHDDO : GHHNONHHLCL, GOIJOCKJDEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly IHINPLAGANG MFKJDLKODED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<string, byte> OHKCENCJHJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private Dictionary<string, string> GHHPCEGCKMD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool NPNEBPFKOPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8C7620", Offset = "0x8C6020", VA = "0x1808C7620", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Dictionary<string, string> LPCKBJEHMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x70BC200", Offset = "0x70BAC00", VA = "0x1870BC200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action OCFIBDCMMML
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x70BD900", Offset = "0x70BC300", VA = "0x1870BD900")]
	[UnityEngine.Scripting.Preserve]
	public DBJOMNPHDDO([CCLEDEMDDDH(null)] IHINPLAGANG MFKJDLKODED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "8")]
	public void ODINFMEOMCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x70BCAB0", Offset = "0x70BB4B0", VA = "0x1870BCAB0")]
	private DirectoryInfo JLJMMFIFKOB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x70BCFC0", Offset = "0x70BB9C0", VA = "0x1870BCFC0", Slot = "6")]
	public Task MNHBJEIMBBP(long OIDHBBNCCGK, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x70BCA40", Offset = "0x70BB440", VA = "0x1870BCA40", Slot = "14")]
	public float HKBKEAAHDCP(string PNABAFEIDND, float PFGHNJEFBFP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x70BCF50", Offset = "0x70BB950", VA = "0x1870BCF50", Slot = "13")]
	public void LNEEBCEGPLI(string PNABAFEIDND, bool PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x70BBEF0", Offset = "0x70BA8F0", VA = "0x1870BBEF0", Slot = "12")]
	public bool ALIAOAINHJE(string PNABAFEIDND, bool PFGHNJEFBFP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x70BC020", Offset = "0x70BAA20", VA = "0x1870BC020", Slot = "10")]
	public int BIHENOJNHPE(string PNABAFEIDND, int PFGHNJEFBFP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x70BD890", Offset = "0x70BC290", VA = "0x1870BD890", Slot = "18")]
	public DateTime OJCEDGDFIPP(string NHDAMJEEJKD, [Optional] DateTime PFGHNJEFBFP)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x70BC190", Offset = "0x70BAB90", VA = "0x1870BC190", Slot = "19")]
	public void CPGECCFLHGH(string PNABAFEIDND, DateTime PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x70BBFB0", Offset = "0x70BA9B0", VA = "0x1870BBFB0", Slot = "15")]
	public void AMPECPLNBAC(string PNABAFEIDND, float PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x70BC9D0", Offset = "0x70BB3D0", VA = "0x1870BC9D0", Slot = "11")]
	public void HBAGOIPKKJK(string PNABAFEIDND, int PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x70BCEE0", Offset = "0x70BB8E0", VA = "0x1870BCEE0", Slot = "20")]
	public long LBHOMBOHPCA(string NHDAMJEEJKD, long PFGHNJEFBFP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x70BD820", Offset = "0x70BC220", VA = "0x1870BD820", Slot = "21")]
	public void NGNKEGODEAK(string NHDAMJEEJKD, long PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2D1AD30", Offset = "0x2D19730", VA = "0x182D1AD30", Slot = "22")]
	public T APDFIDCFCEH<T>(string NHDAMJEEJKD, T PFGHNJEFBFP, BEFNLLNODFL<T> GHJKDBADCID)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2D1AD30", Offset = "0x2D19730", VA = "0x182D1AD30", Slot = "23")]
	public void NPLIBAINPHC<T>(string NHDAMJEEJKD, T PKCLPFEIPFH, BEFNLLNODFL<T> GHJKDBADCID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x70BC890", Offset = "0x70BB290", VA = "0x1870BC890", Slot = "16")]
	public string FEKDNLKELGI(string PNABAFEIDND, string PFGHNJEFBFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x70BBE80", Offset = "0x70BA880", VA = "0x1870BBE80", Slot = "17")]
	public void AANGDCPKKLK(string PNABAFEIDND, string PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x70BC5D0", Offset = "0x70BAFD0", VA = "0x1870BC5D0", Slot = "24")]
	public void DLMJIDDEGNH(string PNABAFEIDND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x70BC940", Offset = "0x70BB340", VA = "0x1870BC940", Slot = "9")]
	public bool FKHCGPIKPHM(string PNABAFEIDND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x70BCBB0", Offset = "0x70BB5B0", VA = "0x1870BCBB0", Slot = "25")]
	public Task JOHPNGPBLEA(CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x70BC240", Offset = "0x70BAC40", VA = "0x1870BC240")]
	private void DEDKMHMAAFK(DirectoryInfo HNJBDDGCMKO, string BNEICEGFMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x70BC690", Offset = "0x70BB090", VA = "0x1870BC690")]
	private static string EBFLFBDHCKD(string PNABAFEIDND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x70BC090", Offset = "0x70BAA90", VA = "0x1870BC090")]
	private static string BOHDGGFGDGF(byte[] FFGGPAIGPAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2D1C200", Offset = "0x2D1AC00", VA = "0x182D1C200")]
	private T KJCABELIABF<T>(string NHDAMJEEJKD, T PFGHNJEFBFP, [Optional] BEFNLLNODFL<T> BNKGKLEPBGG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2D1AE70", Offset = "0x2D19870", VA = "0x182D1AE70")]
	private void CADIEIMFLMA<T>(string NHDAMJEEJKD, T PKCLPFEIPFH, [Optional] BEFNLLNODFL<T> BNKGKLEPBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x70BD050", Offset = "0x70BBA50", VA = "0x1870BD050")]
	private Dictionary<string, string> NCNENMPFOOO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal static class KHNDAPMBPCE
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x70BFBC0", Offset = "0x70BE5C0", VA = "0x1870BFBC0")]
	[EPFHFFCDLIN.KOJNBNLGEPK]
	internal static void DJJNDGGBFEG(KNPHAFHLPCE DNJEODDCEHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class HPFCOCJIEDE : OGIKFKGLOMC
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x70BE570", Offset = "0x70BCF70", VA = "0x1870BE570")]
	[UnityEngine.Scripting.Preserve]
	public HPFCOCJIEDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class OGIKFKGLOMC : GHHNONHHLCL, GOIJOCKJDEC, MGLDIFNFAJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<string, object> GMGLEJJLHOJ;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool NPNEBPFKOPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8C7620", Offset = "0x8C6020", VA = "0x1808C7620", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action OCFIBDCMMML
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "8")]
	public void ODINFMEOMCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x70C1EE0", Offset = "0x70C08E0", VA = "0x1870C1EE0", Slot = "6")]
	public Task MNHBJEIMBBP(long OIDHBBNCCGK, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x70C1C70", Offset = "0x70C0670", VA = "0x1870C1C70", Slot = "9")]
	public bool FKHCGPIKPHM(string NHDAMJEEJKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x70C1AF0", Offset = "0x70C04F0", VA = "0x1870C1AF0", Slot = "10")]
	public int BIHENOJNHPE(string NHDAMJEEJKD, int PFGHNJEFBFP = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x70C1CD0", Offset = "0x70C06D0", VA = "0x1870C1CD0", Slot = "11")]
	public void HBAGOIPKKJK(string NHDAMJEEJKD, int PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x70C1A30", Offset = "0x70C0430", VA = "0x1870C1A30", Slot = "12")]
	public bool ALIAOAINHJE(string NHDAMJEEJKD, bool PFGHNJEFBFP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x70C1E80", Offset = "0x70C0880", VA = "0x1870C1E80", Slot = "13")]
	public void LNEEBCEGPLI(string NHDAMJEEJKD, bool PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x70C1D30", Offset = "0x70C0730", VA = "0x1870C1D30", Slot = "14")]
	public float HKBKEAAHDCP(string NHDAMJEEJKD, float PFGHNJEFBFP = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x70C1A90", Offset = "0x70C0490", VA = "0x1870C1A90", Slot = "15")]
	public void AMPECPLNBAC(string NHDAMJEEJKD, float PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x70C1C10", Offset = "0x70C0610", VA = "0x1870C1C10", Slot = "16")]
	public string FEKDNLKELGI(string NHDAMJEEJKD, [Optional] string PFGHNJEFBFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x70C19D0", Offset = "0x70C03D0", VA = "0x1870C19D0", Slot = "17")]
	public void AANGDCPKKLK(string NHDAMJEEJKD, string PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x70C1FD0", Offset = "0x70C09D0", VA = "0x1870C1FD0", Slot = "18")]
	public DateTime OJCEDGDFIPP(string NHDAMJEEJKD, [Optional] DateTime PFGHNJEFBFP)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x70C1B50", Offset = "0x70C0550", VA = "0x1870C1B50", Slot = "19")]
	public void CPGECCFLHGH(string NHDAMJEEJKD, DateTime PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x70C1E20", Offset = "0x70C0820", VA = "0x1870C1E20", Slot = "20")]
	public long LBHOMBOHPCA(string NHDAMJEEJKD, long PFGHNJEFBFP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x70C1F70", Offset = "0x70C0970", VA = "0x1870C1F70", Slot = "21")]
	public void NGNKEGODEAK(string NHDAMJEEJKD, long PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3078BF0", Offset = "0x30775F0", VA = "0x183078BF0", Slot = "22")]
	public T APDFIDCFCEH<T>(string NHDAMJEEJKD, T PFGHNJEFBFP, BEFNLLNODFL<T> GHJKDBADCID)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3079A40", Offset = "0x3078440", VA = "0x183079A40", Slot = "23")]
	public void NPLIBAINPHC<T>(string NHDAMJEEJKD, T PKCLPFEIPFH, BEFNLLNODFL<T> GHJKDBADCID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3079200", Offset = "0x3077C00", VA = "0x183079200")]
	public T KJCABELIABF<T>(string NHDAMJEEJKD, T PFGHNJEFBFP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3078D10", Offset = "0x3077710", VA = "0x183078D10")]
	public void CADIEIMFLMA<T>(string NHDAMJEEJKD, T PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x70C1BB0", Offset = "0x70C05B0", VA = "0x1870C1BB0", Slot = "24")]
	public void DLMJIDDEGNH(string NHDAMJEEJKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x70C1D90", Offset = "0x70C0790", VA = "0x1870C1D90", Slot = "25")]
	public Task JOHPNGPBLEA(CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x70BE570", Offset = "0x70BCF70", VA = "0x1870BE570")]
	public OGIKFKGLOMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public abstract class AFKACDDFNLA<TParent> where TParent : GOIJOCKJDEC
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly HashSet<AFKACDDFNLA<TParent>> EGOIDCKKKAL;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x40B0DF0", Offset = "0x40AF7F0", VA = "0x1840B0DF0")]
	protected AFKACDDFNLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract void CFGGIHGKNGN();

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void PBLIMJBNIGH(string PNABAFEIDND);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x40B0A60", Offset = "0x40AF460", VA = "0x1840B0A60")]
	public static void GOCFFMFMNBC(string PNABAFEIDND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x40B0820", Offset = "0x40AF220", VA = "0x1840B0820")]
	public static void GBHOEAOEGED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class KKAGOMIMMKC<TParent, TValue> : AFKACDDFNLA<TParent> where TParent : GOIJOCKJDEC
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly KKAGOMIMMKC<TParent, TValue> JCFGJMCEKAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, TValue> NNNPHMAAAHP;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4560E20", Offset = "0x455F820", VA = "0x184560E20")]
	public bool HPCEHODMPGB(string OMLHPAPCOIC, [Out] TValue ADDBJKLLJPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4560E80", Offset = "0x455F880", VA = "0x184560E80")]
	public void PIIEDGJOJDM(string OMLHPAPCOIC, TValue PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3F15B50", Offset = "0x3F14550", VA = "0x183F15B50", Slot = "4")]
	protected override void CFGGIHGKNGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x4233710", Offset = "0x4232110", VA = "0x184233710", Slot = "5")]
	protected override void PBLIMJBNIGH(string OMLHPAPCOIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x4561150", Offset = "0x455FB50", VA = "0x184561150")]
	public KKAGOMIMMKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface GOIJOCKJDEC
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool NPNEBPFKOPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ODINFMEOMCI();

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FKHCGPIKPHM(string NHDAMJEEJKD);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int BIHENOJNHPE(string NHDAMJEEJKD, int PFGHNJEFBFP = 0);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HBAGOIPKKJK(string NHDAMJEEJKD, int PKCLPFEIPFH);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool ALIAOAINHJE(string NHDAMJEEJKD, bool PFGHNJEFBFP = false);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LNEEBCEGPLI(string NHDAMJEEJKD, bool PKCLPFEIPFH);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	float HKBKEAAHDCP(string NHDAMJEEJKD, float PFGHNJEFBFP = 0f);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void AMPECPLNBAC(string NHDAMJEEJKD, float PKCLPFEIPFH);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	string FEKDNLKELGI(string NHDAMJEEJKD, [Optional] string PFGHNJEFBFP);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void AANGDCPKKLK(string NHDAMJEEJKD, string PKCLPFEIPFH);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	DateTime OJCEDGDFIPP(string NHDAMJEEJKD, [Optional] DateTime ACONHILHCEK);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void CPGECCFLHGH(string NHDAMJEEJKD, DateTime ACONHILHCEK);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "13")]
	long LBHOMBOHPCA(string NHDAMJEEJKD, long PFGHNJEFBFP);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void NGNKEGODEAK(string NHDAMJEEJKD, long PKCLPFEIPFH);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "15")]
	T APDFIDCFCEH<T>(string NHDAMJEEJKD, T PFGHNJEFBFP, BEFNLLNODFL<T> GHJKDBADCID);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void NPLIBAINPHC<T>(string NHDAMJEEJKD, T PKCLPFEIPFH, BEFNLLNODFL<T> GHJKDBADCID);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void DLMJIDDEGNH(string NHDAMJEEJKD);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task JOHPNGPBLEA([Optional] CancellationToken PPLDCJFFMEP);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface GHHNONHHLCL : GOIJOCKJDEC
{
	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action OCFIBDCMMML;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task MNHBJEIMBBP(long OIDHBBNCCGK, CancellationToken PPLDCJFFMEP);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface MGLDIFNFAJO : GOIJOCKJDEC
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class IOPHCBHOEIP : GHHNONHHLCL, GOIJOCKJDEC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct PJFKALKLFNF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public IOPHCBHOEIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x70C51B0", Offset = "0x70C3BB0", VA = "0x1870C51B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x70C5340", Offset = "0x70C3D40", VA = "0x1870C5340", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct DLEHFGCCLPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public IOPHCBHOEIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public long playerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x70BDA80", Offset = "0x70BC480", VA = "0x1870BDA80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x70BDD70", Offset = "0x70BC770", VA = "0x1870BDD70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly GHHNONHHLCL LHCOMOIIFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public readonly DBJOMNPHDDO ALLODCGOGLH;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool NPNEBPFKOPN
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x70BEDE0", Offset = "0x70BD7E0", VA = "0x1870BEDE0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action OCFIBDCMMML
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x70BEEB0", Offset = "0x70BD8B0", VA = "0x1870BEEB0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x70BEA30", Offset = "0x70BD430", VA = "0x1870BEA30", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x70BF670", Offset = "0x70BE070", VA = "0x1870BF670")]
	[UnityEngine.Scripting.Preserve]
	public IOPHCBHOEIP([CCLEDEMDDDH(null)] IHINPLAGANG MFKJDLKODED, [CCLEDEMDDDH("Disk_Unity")] GHHNONHHLCL LHCOMOIIFDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x70BF4B0", Offset = "0x70BDEB0", VA = "0x1870BF4B0", Slot = "8")]
	public void ODINFMEOMCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x70BED50", Offset = "0x70BD750", VA = "0x1870BED50", Slot = "9")]
	public bool FKHCGPIKPHM(string NHDAMJEEJKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x70BE870", Offset = "0x70BD270", VA = "0x1870BE870", Slot = "10")]
	public int BIHENOJNHPE(string NHDAMJEEJKD, int PFGHNJEFBFP = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x70BEE40", Offset = "0x70BD840", VA = "0x1870BEE40", Slot = "11")]
	public void HBAGOIPKKJK(string NHDAMJEEJKD, int PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x70BE670", Offset = "0x70BD070", VA = "0x1870BE670", Slot = "12")]
	public bool ALIAOAINHJE(string NHDAMJEEJKD, bool PFGHNJEFBFP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x70BF2C0", Offset = "0x70BDCC0", VA = "0x1870BF2C0", Slot = "13")]
	public void LNEEBCEGPLI(string NHDAMJEEJKD, bool PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x70BEF10", Offset = "0x70BD910", VA = "0x1870BEF10", Slot = "14")]
	public float HKBKEAAHDCP(string NHDAMJEEJKD, float PFGHNJEFBFP = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x70BE800", Offset = "0x70BD200", VA = "0x1870BE800", Slot = "15")]
	public void AMPECPLNBAC(string NHDAMJEEJKD, float PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x70BEBB0", Offset = "0x70BD5B0", VA = "0x1870BEBB0", Slot = "16")]
	public string FEKDNLKELGI(string NHDAMJEEJKD, [Optional] string PFGHNJEFBFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x70BE600", Offset = "0x70BD000", VA = "0x1870BE600", Slot = "17")]
	public void AANGDCPKKLK(string NHDAMJEEJKD, string PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x70BF510", Offset = "0x70BDF10", VA = "0x1870BF510", Slot = "18")]
	public DateTime OJCEDGDFIPP(string NHDAMJEEJKD, [Optional] DateTime PFGHNJEFBFP)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x70BE9C0", Offset = "0x70BD3C0", VA = "0x1870BE9C0", Slot = "19")]
	public void CPGECCFLHGH(string NHDAMJEEJKD, DateTime ACONHILHCEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x70BF160", Offset = "0x70BDB60", VA = "0x1870BF160", Slot = "20")]
	public long LBHOMBOHPCA(string NHDAMJEEJKD, long PFGHNJEFBFP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x70BF440", Offset = "0x70BDE40", VA = "0x1870BF440", Slot = "21")]
	public void NGNKEGODEAK(string NHDAMJEEJKD, long PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2F30780", Offset = "0x2F2F180", VA = "0x182F30780", Slot = "22")]
	public T APDFIDCFCEH<T>(string NHDAMJEEJKD, T PFGHNJEFBFP, BEFNLLNODFL<T> GHJKDBADCID)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x2F30F10", Offset = "0x2F2F910", VA = "0x182F30F10", Slot = "23")]
	public void NPLIBAINPHC<T>(string NHDAMJEEJKD, T PKCLPFEIPFH, BEFNLLNODFL<T> GHJKDBADCID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x70BEAA0", Offset = "0x70BD4A0", VA = "0x1870BEAA0", Slot = "24")]
	public void DLMJIDDEGNH(string NHDAMJEEJKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x70BF070", Offset = "0x70BDA70", VA = "0x1870BF070", Slot = "25")]
	[AsyncStateMachine(typeof(PJFKALKLFNF))]
	public Task JOHPNGPBLEA([Optional] CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x70BF330", Offset = "0x70BDD30", VA = "0x1870BF330", Slot = "6")]
	[AsyncStateMachine(typeof(DLEHFGCCLPP))]
	public Task MNHBJEIMBBP(long OIDHBBNCCGK, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class ODDDFEAMHAG : GHHNONHHLCL, GOIJOCKJDEC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct KAGCCHAIPBP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public ODDDFEAMHAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x70BF780", Offset = "0x70BE180", VA = "0x1870BF780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x70BFB60", Offset = "0x70BE560", VA = "0x1870BFB60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class MKLGAHLDMBI : IEnumerator<BGFOJNANPKN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private BGFOJNANPKN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public ODDDFEAMHAG <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private BGFOJNANPKN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8B2330", Offset = "0x8B0D30", VA = "0x1808B2330")]
		[DebuggerHidden]
		public MKLGAHLDMBI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x70C0E40", Offset = "0x70BF840", VA = "0x1870C0E40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x70C0EB0", Offset = "0x70BF8B0", VA = "0x1870C0EB0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly IHINPLAGANG MFKJDLKODED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private bool AHEHIJBJGJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private bool MOMHJDNFNLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private MAADJEHCAPM MMJPGOGMMKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private OIMBFIPCENK OOMIKKHNBFK;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool NPNEBPFKOPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8C7620", Offset = "0x8C6020", VA = "0x1808C7620", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action OCFIBDCMMML
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x70C18E0", Offset = "0x70C02E0", VA = "0x1870C18E0")]
	[UnityEngine.Scripting.Preserve]
	public ODDDFEAMHAG([CCLEDEMDDDH(null)] IHINPLAGANG MFKJDLKODED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "8")]
	public void ODINFMEOMCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x70C16F0", Offset = "0x70C00F0", VA = "0x1870C16F0", Slot = "6")]
	public Task MNHBJEIMBBP(long OIDHBBNCCGK, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x154BB80", Offset = "0x154A580", VA = "0x18154BB80")]
	private static int OJFPHHMMKKJ(bool PKCLPFEIPFH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x70C1480", Offset = "0x70BFE80", VA = "0x1870C1480", Slot = "9")]
	public bool FKHCGPIKPHM(string NHDAMJEEJKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x70C11D0", Offset = "0x70BFBD0", VA = "0x1870C11D0", Slot = "10")]
	public int BIHENOJNHPE(string NHDAMJEEJKD, int PFGHNJEFBFP = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x70C1500", Offset = "0x70BFF00", VA = "0x1870C1500", Slot = "11")]
	public void HBAGOIPKKJK(string NHDAMJEEJKD, int PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x70C1100", Offset = "0x70BFB00", VA = "0x1870C1100", Slot = "12")]
	public bool ALIAOAINHJE(string NHDAMJEEJKD, bool PFGHNJEFBFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x70C16C0", Offset = "0x70C00C0", VA = "0x1870C16C0", Slot = "13")]
	public void LNEEBCEGPLI(string NHDAMJEEJKD, bool PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x70C1530", Offset = "0x70BFF30", VA = "0x1870C1530", Slot = "14")]
	public float HKBKEAAHDCP(string NHDAMJEEJKD, float PFGHNJEFBFP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x70C1130", Offset = "0x70BFB30", VA = "0x1870C1130", Slot = "15")]
	public void AMPECPLNBAC(string NHDAMJEEJKD, float PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x70C1870", Offset = "0x70C0270", VA = "0x1870C1870", Slot = "18")]
	public DateTime OJCEDGDFIPP(string NHDAMJEEJKD, [Optional] DateTime PFGHNJEFBFP)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x70C1310", Offset = "0x70BFD10", VA = "0x1870C1310", Slot = "19")]
	public void CPGECCFLHGH(string NHDAMJEEJKD, DateTime ACONHILHCEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x70C1650", Offset = "0x70C0050", VA = "0x1870C1650", Slot = "20")]
	public long LBHOMBOHPCA(string NHDAMJEEJKD, long PFGHNJEFBFP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x70C1780", Offset = "0x70C0180", VA = "0x1870C1780", Slot = "21")]
	public void NGNKEGODEAK(string NHDAMJEEJKD, long PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3076FD0", Offset = "0x30759D0", VA = "0x183076FD0", Slot = "22")]
	public T APDFIDCFCEH<T>(string NHDAMJEEJKD, T PFGHNJEFBFP, BEFNLLNODFL<T> GHJKDBADCID)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3076FD0", Offset = "0x30759D0", VA = "0x183076FD0", Slot = "23")]
	public void NPLIBAINPHC<T>(string NHDAMJEEJKD, T PKCLPFEIPFH, BEFNLLNODFL<T> GHJKDBADCID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3076470", Offset = "0x3074E70", VA = "0x183076470")]
	private T ACBIDDFKKBO<T>(string NHDAMJEEJKD, T PFGHNJEFBFP, [Optional] BEFNLLNODFL<T> BNKGKLEPBGG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x30771B0", Offset = "0x3075BB0", VA = "0x1830771B0")]
	private void HPMHHMDEFJD<T>(string NHDAMJEEJKD, T PKCLPFEIPFH, [Optional] BEFNLLNODFL<T> BNKGKLEPBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x70C1430", Offset = "0x70BFE30", VA = "0x1870C1430", Slot = "16")]
	public string FEKDNLKELGI(string NHDAMJEEJKD, string PFGHNJEFBFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x70C10D0", Offset = "0x70BFAD0", VA = "0x1870C10D0", Slot = "17")]
	public void AANGDCPKKLK(string NHDAMJEEJKD, string PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x70C1460", Offset = "0x70BFE60", VA = "0x1870C1460")]
	private void FHLPJCLBCGD(string NHDAMJEEJKD, string PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x70C1410", Offset = "0x70BFE10", VA = "0x1870C1410")]
	private string ECAFCCFBDMM(string NHDAMJEEJKD, string PFGHNJEFBFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x70C1380", Offset = "0x70BFD80", VA = "0x1870C1380", Slot = "24")]
	public void DLMJIDDEGNH(string NHDAMJEEJKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x70C1270", Offset = "0x70BFC70", VA = "0x1870C1270")]
	private string CBHHNMLJOCC(string PNABAFEIDND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x70C1560", Offset = "0x70BFF60", VA = "0x1870C1560", Slot = "25")]
	[AsyncStateMachine(typeof(KAGCCHAIPBP))]
	public Task JOHPNGPBLEA(CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x70C17F0", Offset = "0x70C01F0", VA = "0x1870C17F0")]
	[IteratorStateMachine(typeof(MKLGAHLDMBI))]
	private IEnumerator<BGFOJNANPKN> OALBCEILPAH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x70C14A0", Offset = "0x70BFEA0", VA = "0x1870C14A0")]
	private void GEJCDHINHPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x70C1160", Offset = "0x70BFB60", VA = "0x1870C1160")]
	private void AOGBOFGILLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x70C1200", Offset = "0x70BFC00", VA = "0x1870C1200")]
	private void CALOPMLLPII(bool AHHJDKMBCEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class PJPKDDPJPMC : GHHNONHHLCL, GOIJOCKJDEC
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct KVP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public string k;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public string v;
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private struct KVPs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public KVP[] kvps;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private Dictionary<string, string> GHHPCEGCKMD;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool NPNEBPFKOPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8C7620", Offset = "0x8C6020", VA = "0x1808C7620", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private string PPJEIANFKNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x70C5890", Offset = "0x70C4290", VA = "0x1870C5890")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private Dictionary<string, string> LPCKBJEHMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x70C5650", Offset = "0x70C4050", VA = "0x1870C5650")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action OCFIBDCMMML
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	[UnityEngine.Scripting.Preserve]
	public PJPKDDPJPMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "8")]
	public void ODINFMEOMCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x70C5D20", Offset = "0x70C4720", VA = "0x1870C5D20", Slot = "6")]
	public Task MNHBJEIMBBP(long OIDHBBNCCGK, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x70C5970", Offset = "0x70C4370", VA = "0x1870C5970", Slot = "14")]
	public float HKBKEAAHDCP(string PNABAFEIDND, float PFGHNJEFBFP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x70C5CB0", Offset = "0x70C46B0", VA = "0x1870C5CB0", Slot = "13")]
	public void LNEEBCEGPLI(string PNABAFEIDND, bool PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x70C5440", Offset = "0x70C3E40", VA = "0x1870C5440", Slot = "12")]
	public bool ALIAOAINHJE(string PNABAFEIDND, bool PFGHNJEFBFP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x70C5570", Offset = "0x70C3F70", VA = "0x1870C5570", Slot = "10")]
	public int BIHENOJNHPE(string PNABAFEIDND, int PFGHNJEFBFP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x70C6100", Offset = "0x70C4B00", VA = "0x1870C6100", Slot = "18")]
	public DateTime OJCEDGDFIPP(string NHDAMJEEJKD, [Optional] DateTime PFGHNJEFBFP)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x70C55E0", Offset = "0x70C3FE0", VA = "0x1870C55E0", Slot = "19")]
	public void CPGECCFLHGH(string PNABAFEIDND, DateTime PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x70C5500", Offset = "0x70C3F00", VA = "0x1870C5500", Slot = "15")]
	public void AMPECPLNBAC(string PNABAFEIDND, float PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x70C5900", Offset = "0x70C4300", VA = "0x1870C5900", Slot = "11")]
	public void HBAGOIPKKJK(string PNABAFEIDND, int PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x70C5C40", Offset = "0x70C4640", VA = "0x1870C5C40", Slot = "20")]
	public long LBHOMBOHPCA(string NHDAMJEEJKD, long PFGHNJEFBFP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x70C6090", Offset = "0x70C4A90", VA = "0x1870C6090", Slot = "21")]
	public void NGNKEGODEAK(string NHDAMJEEJKD, long PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x2D1AD30", Offset = "0x2D19730", VA = "0x182D1AD30", Slot = "22")]
	public T APDFIDCFCEH<T>(string NHDAMJEEJKD, T PFGHNJEFBFP, BEFNLLNODFL<T> GHJKDBADCID)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x2D1AD30", Offset = "0x2D19730", VA = "0x182D1AD30", Slot = "23")]
	public void NPLIBAINPHC<T>(string NHDAMJEEJKD, T PKCLPFEIPFH, BEFNLLNODFL<T> GHJKDBADCID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x70C5750", Offset = "0x70C4150", VA = "0x1870C5750", Slot = "16")]
	public string FEKDNLKELGI(string PNABAFEIDND, string PFGHNJEFBFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x70C53A0", Offset = "0x70C3DA0", VA = "0x1870C53A0", Slot = "17")]
	public void AANGDCPKKLK(string PNABAFEIDND, string PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x70C5690", Offset = "0x70C4090", VA = "0x1870C5690", Slot = "24")]
	public void DLMJIDDEGNH(string PNABAFEIDND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x70C5800", Offset = "0x70C4200", VA = "0x1870C5800", Slot = "9")]
	public bool FKHCGPIKPHM(string PNABAFEIDND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x70C59E0", Offset = "0x70C43E0", VA = "0x1870C59E0", Slot = "25")]
	public Task JOHPNGPBLEA(CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x3091800", Offset = "0x3090200", VA = "0x183091800")]
	private T KJCABELIABF<T>(string NHDAMJEEJKD, T PFGHNJEFBFP, [Optional] BEFNLLNODFL<T> BNKGKLEPBGG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x3090850", Offset = "0x308F250", VA = "0x183090850")]
	private void CADIEIMFLMA<T>(string NHDAMJEEJKD, T PKCLPFEIPFH, [Optional] BEFNLLNODFL<T> BNKGKLEPBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x70C5DB0", Offset = "0x70C47B0", VA = "0x1870C5DB0")]
	private Dictionary<string, string> NCNENMPFOOO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface PGAINGHNNBN
{
	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action OCFIBDCMMML;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ODINFMEOMCI();

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task JGKHHHOEHJC(long OIDHBBNCCGK);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IIBCIAMIFNF(FCJAIBCGFCE NEGFHBPCMND = FCJAIBCGFCE.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool CNPJBMCNIBG(string NHDAMJEEJKD, FCJAIBCGFCE DKBLACNMNIM = FCJAIBCGFCE.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool BIEPMKAOGON(string NHDAMJEEJKD, FCJAIBCGFCE DKBLACNMNIM = FCJAIBCGFCE.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "7")]
	string HABKOBBKKGE(string NHDAMJEEJKD, [Optional] string PFGHNJEFBFP, FCJAIBCGFCE DKBLACNMNIM = FCJAIBCGFCE.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	DEIDCEBOPPL AJFMBOPHJOO(string NHDAMJEEJKD, string PKCLPFEIPFH, FCJAIBCGFCE DKBLACNMNIM = FCJAIBCGFCE.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "9")]
	int OAJKJIEOMLM(string NHDAMJEEJKD, int PFGHNJEFBFP = 0, FCJAIBCGFCE DKBLACNMNIM = FCJAIBCGFCE.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "10")]
	DEIDCEBOPPL DFKJOMJCGLG(string NHDAMJEEJKD, int PKCLPFEIPFH, FCJAIBCGFCE DKBLACNMNIM = FCJAIBCGFCE.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool AOPAGFELDOL(string NHDAMJEEJKD, bool PFGHNJEFBFP, FCJAIBCGFCE DKBLACNMNIM = FCJAIBCGFCE.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "12")]
	DEIDCEBOPPL JJDHDKDFIAA(string NHDAMJEEJKD, bool PKCLPFEIPFH, FCJAIBCGFCE DKBLACNMNIM = FCJAIBCGFCE.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float OHALJJCNBBA(string NHDAMJEEJKD, float PFGHNJEFBFP = 0f, FCJAIBCGFCE DKBLACNMNIM = FCJAIBCGFCE.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "14")]
	DEIDCEBOPPL JHPEPBNMJOM(string NHDAMJEEJKD, float PKCLPFEIPFH, FCJAIBCGFCE DKBLACNMNIM = FCJAIBCGFCE.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "15")]
	DateTime PBCLDLILMAN(string NHDAMJEEJKD, [Optional] DateTime PFGHNJEFBFP, FCJAIBCGFCE DKBLACNMNIM = FCJAIBCGFCE.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "16")]
	DEIDCEBOPPL FDLHHHOIKNN(string NHDAMJEEJKD, DateTime PKCLPFEIPFH, FCJAIBCGFCE DKBLACNMNIM = FCJAIBCGFCE.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "17")]
	long AAIMENPHKAO(string NHDAMJEEJKD, long PFGHNJEFBFP = 0L, FCJAIBCGFCE DKBLACNMNIM = FCJAIBCGFCE.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "18")]
	DEIDCEBOPPL PAFFNGGCOCL(string NHDAMJEEJKD, long PKCLPFEIPFH, FCJAIBCGFCE DKBLACNMNIM = FCJAIBCGFCE.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "19")]
	T PCJCFPGPPPO<T>(string NHDAMJEEJKD, [Optional] T PFGHNJEFBFP, FCJAIBCGFCE DKBLACNMNIM = FCJAIBCGFCE.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "20")]
	DEIDCEBOPPL FFPIGPPPLCK<T>(string NHDAMJEEJKD, T PKCLPFEIPFH, FCJAIBCGFCE DKBLACNMNIM = FCJAIBCGFCE.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool JCHALPIAMFH(string NHDAMJEEJKD);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool MCNDMLKPNGB(string NHDAMJEEJKD);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "23")]
	string KPLPJCINNKE(string NHDAMJEEJKD, [Optional] string PFGHNJEFBFP);

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "24")]
	DEIDCEBOPPL OHDEOJLKJNL(string NHDAMJEEJKD, string PKCLPFEIPFH);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "25")]
	int DJBECKLMHEJ(string NHDAMJEEJKD, int PFGHNJEFBFP = 0);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "26")]
	DEIDCEBOPPL PJDBMICMIIM(string NHDAMJEEJKD, int PKCLPFEIPFH);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool FBMEPIAAKLG(string NHDAMJEEJKD, bool PFGHNJEFBFP);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "28")]
	DEIDCEBOPPL OBAFLIMANNK(string NHDAMJEEJKD, bool PKCLPFEIPFH);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "29")]
	float MPAMOLGIAJI(string NHDAMJEEJKD, float PFGHNJEFBFP = 0f);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "30")]
	DEIDCEBOPPL FBDKNFCJJHP(string NHDAMJEEJKD, float PKCLPFEIPFH);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "31")]
	DateTime COMGFPFKFED(string NHDAMJEEJKD, [Optional] DateTime PFGHNJEFBFP);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "32")]
	DEIDCEBOPPL HKAJOINKDGI(string NHDAMJEEJKD, DateTime PKCLPFEIPFH);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "33")]
	long IBGHPELMCPG(string NHDAMJEEJKD, long PFGHNJEFBFP = 0L);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "34")]
	DEIDCEBOPPL AHKBJMIGPBO(string NHDAMJEEJKD, long PKCLPFEIPFH);

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void GCPCOHNMJNE<T>(BEFNLLNODFL<T> GHJKDBADCID, [Optional] IEqualityComparer<T> FNBJNOCPAIF);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void IFMLGIGPLNE<T>();

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "37")]
	IDisposable FMBEGJLCGGP();

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void BNDFEBKNIMO(float FPEHIEEJIAO);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task GEJCDHINHPP([Optional] CancellationToken PPLDCJFFMEP);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum DEIDCEBOPPL : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Unchanged,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	New,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	Changed
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class ONGHCPBAFJL : PGAINGHNNBN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private abstract class ODAKAAIOEOH
	{
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		protected static readonly HashSet<ODAKAAIOEOH> MOCJKAOODCD;

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x70C0F00", Offset = "0x70BF900", VA = "0x1870C0F00")]
		public static void GBHOEAOEGED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void CFGGIHGKNGN();

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		protected ODAKAAIOEOH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private class PNINGNAKNBM<T> : ODAKAAIOEOH
	{
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public static readonly PNINGNAKNBM<T> JOLICDCBKGF;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public BEFNLLNODFL<T> KBPELHHCFFD
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x8AD560", Offset = "0x8ABF60", VA = "0x1808AD560")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x8AD970", Offset = "0x8AC370", VA = "0x1808AD970")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public IEqualityComparer<T> OPIMOPPIJBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x8ADB10", Offset = "0x8AC510", VA = "0x1808ADB10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool LOGGKDBGPIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x3B60A40", Offset = "0x3B5F440", VA = "0x183B60A40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x4B8B1A0", Offset = "0x4B89BA0", VA = "0x184B8B1A0")]
		private PNINGNAKNBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x4B8ACE0", Offset = "0x4B896E0", VA = "0x184B8ACE0")]
		public void KFMGLABNFNG(BEFNLLNODFL<T> BNKGKLEPBGG, [Optional] IEqualityComparer<T> FNBJNOCPAIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x4B8AA90", Offset = "0x4B89490", VA = "0x184B8AA90", Slot = "4")]
		public override void CFGGIHGKNGN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class FGFJEFLHMCF : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly ONGHCPBAFJL FMDNCGDLGEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly object DBMNOHDCBCC;

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x70BDE00", Offset = "0x70BC800", VA = "0x1870BDE00")]
		public FGFJEFLHMCF(ONGHCPBAFJL FMDNCGDLGEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x70BDDD0", Offset = "0x70BC7D0", VA = "0x1870BDDD0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct KNMIKBAJPJB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public ONGHCPBAFJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public long playerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x70BFD20", Offset = "0x70BE720", VA = "0x1870BFD20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x70C0000", Offset = "0x70BEA00", VA = "0x1870C0000", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private struct GBOPALBJBJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public ONGHCPBAFJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public GOIJOCKJDEC backingStoreToSave;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x70BE3E0", Offset = "0x70BCDE0", VA = "0x1870BE3E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x903690", Offset = "0x902090", VA = "0x180903690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct GBOFJHFHLGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public ONGHCPBAFJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x70BDEB0", Offset = "0x70BC8B0", VA = "0x1870BDEB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x70BE380", Offset = "0x70BCD80", VA = "0x1870BE380", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class DDKGEKGFLFF : IEnumerator<BGFOJNANPKN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private BGFOJNANPKN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public ONGHCPBAFJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public float seconds;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private BGFOJNANPKN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x8B2330", Offset = "0x8B0D30", VA = "0x1808B2330")]
		[DebuggerHidden]
		public DDKGEKGFLFF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x70BD9A0", Offset = "0x70BC3A0", VA = "0x1870BD9A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x70BDA30", Offset = "0x70BC430", VA = "0x1870BDA30", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly GHHNONHHLCL CGHIKEHHLJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly GHHNONHHLCL GCIGAAAKHEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly MGLDIFNFAJO PACGOOAKPBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly MAADJEHCAPM MMJPGOGMMKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly LIHFKABPNIB.HEHLABHAGGJ LAMJGNEGIAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly JKLEGNGEMOG LDLPEHAMBDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly HashSet<GOIJOCKJDEC> NJKJOKOFMHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private Task GIDBPPNIJIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private Dictionary<string, string> CPGJEDBKJJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private OIMBFIPCENK DLIAHBIBFFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly object NKBMCKLKMMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly object HHGIOPBODPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private long OIKDGLJDOAG;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private bool IHLKABCBMAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x70C2E30", Offset = "0x70C1830", VA = "0x1870C2E30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private CancellationTokenSource PAJDJIMIPDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x8AB1D0", Offset = "0x8A9BD0", VA = "0x1808AB1D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x8AB1E0", Offset = "0x8A9BE0", VA = "0x1808AB1E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action OCFIBDCMMML
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x70C3480", Offset = "0x70C1E80", VA = "0x1870C3480", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x70C2910", Offset = "0x70C1310", VA = "0x1870C2910", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x70C3370", Offset = "0x70C1D70", VA = "0x1870C3370")]
	[EPFHFFCDLIN.KOJNBNLGEPK]
	internal static void GHMBFHCIJHC(KNPHAFHLPCE DNJEODDCEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x70C4DE0", Offset = "0x70C37E0", VA = "0x1870C4DE0")]
	[UnityEngine.Scripting.Preserve]
	public ONGHCPBAFJL([CCLEDEMDDDH("Disk")] GHHNONHHLCL CGHIKEHHLJA, [CCLEDEMDDDH("Cloud")] GHHNONHHLCL GCIGAAAKHEJ, [CCLEDEMDDDH(null)] MGLDIFNFAJO PACGOOAKPBC, [CCLEDEMDDDH(null)] MAADJEHCAPM MMJPGOGMMKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x70C2BA0", Offset = "0x70C15A0", VA = "0x1870C2BA0", Slot = "44")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x70C43F0", Offset = "0x70C2DF0", VA = "0x1870C43F0")]
	private void MIGGMFBEKJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x70C4900", Offset = "0x70C3300", VA = "0x1870C4900", Slot = "6")]
	public void ODINFMEOMCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x70C39B0", Offset = "0x70C23B0", VA = "0x1870C39B0", Slot = "7")]
	public Task JGKHHHOEHJC(long OIDHBBNCCGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x70C37C0", Offset = "0x70C21C0", VA = "0x1870C37C0")]
	[AsyncStateMachine(typeof(KNMIKBAJPJB))]
	private Task IJAONIAEHCK(long OIDHBBNCCGK, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x70C3F50", Offset = "0x70C2950", VA = "0x1870C3F50")]
	private void KHABBAJNHDH(object AICEIDIHFDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x70C3F70", Offset = "0x70C2970", VA = "0x1870C3F70")]
	private void KLAMHOEPFHG(object AICEIDIHFDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x70C4390", Offset = "0x70C2D90", VA = "0x1870C4390")]
	private string MDFFDKLKBFF(string ALEAAAAOPLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x70C41B0", Offset = "0x70C2BB0", VA = "0x1870C41B0")]
	private void LNHIOAHFONC(FCJAIBCGFCE NEGFHBPCMND, string PNABAFEIDND, [Out] GHHNONHHLCL EKHCBDGNDCI, [Out] string MIPILJPEKFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x70C38D0", Offset = "0x70C22D0", VA = "0x1870C38D0")]
	private GHHNONHHLCL IOLADEDLFBA(FCJAIBCGFCE NEGFHBPCMND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x70C3700", Offset = "0x70C2100", VA = "0x1870C3700", Slot = "8")]
	public bool IIBCIAMIFNF(FCJAIBCGFCE NEGFHBPCMND = FCJAIBCGFCE.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x70C2800", Offset = "0x70C1200", VA = "0x1870C2800", Slot = "9")]
	public bool CNPJBMCNIBG(string NHDAMJEEJKD, FCJAIBCGFCE DKBLACNMNIM = FCJAIBCGFCE.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x70C2480", Offset = "0x70C0E80", VA = "0x1870C2480", Slot = "10")]
	public bool BIEPMKAOGON(string NHDAMJEEJKD, FCJAIBCGFCE DKBLACNMNIM = FCJAIBCGFCE.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x70C33E0", Offset = "0x70C1DE0", VA = "0x1870C33E0", Slot = "11")]
	public string HABKOBBKKGE(string NHDAMJEEJKD, [Optional] string PFGHNJEFBFP, FCJAIBCGFCE DKBLACNMNIM = FCJAIBCGFCE.CLOUD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x70C2240", Offset = "0x70C0C40", VA = "0x1870C2240", Slot = "12")]
	public DEIDCEBOPPL AJFMBOPHJOO(string NHDAMJEEJKD, string PKCLPFEIPFH, FCJAIBCGFCE DKBLACNMNIM = FCJAIBCGFCE.CLOUD)
	{
		return default(DEIDCEBOPPL);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x70C4820", Offset = "0x70C3220", VA = "0x1870C4820", Slot = "13")]
	public int OAJKJIEOMLM(string NHDAMJEEJKD, int PFGHNJEFBFP = 0, FCJAIBCGFCE DKBLACNMNIM = FCJAIBCGFCE.CLOUD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x70C29B0", Offset = "0x70C13B0", VA = "0x1870C29B0", Slot = "14")]
	public DEIDCEBOPPL DFKJOMJCGLG(string NHDAMJEEJKD, int PKCLPFEIPFH, FCJAIBCGFCE DKBLACNMNIM = FCJAIBCGFCE.CLOUD)
	{
		return default(DEIDCEBOPPL);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x70C23D0", Offset = "0x70C0DD0", VA = "0x1870C23D0", Slot = "15")]
	public bool AOPAGFELDOL(string NHDAMJEEJKD, bool PFGHNJEFBFP, FCJAIBCGFCE DKBLACNMNIM = FCJAIBCGFCE.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x70C3D00", Offset = "0x70C2700", VA = "0x1870C3D00", Slot = "16")]
	public DEIDCEBOPPL JJDHDKDFIAA(string NHDAMJEEJKD, bool PKCLPFEIPFH, FCJAIBCGFCE DKBLACNMNIM = FCJAIBCGFCE.CLOUD)
	{
		return default(DEIDCEBOPPL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x70C4970", Offset = "0x70C3370", VA = "0x1870C4970", Slot = "17")]
	public float OHALJJCNBBA(string NHDAMJEEJKD, float PFGHNJEFBFP = 0f, FCJAIBCGFCE DKBLACNMNIM = FCJAIBCGFCE.CLOUD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x70C3B80", Offset = "0x70C2580", VA = "0x1870C3B80", Slot = "18")]
	public DEIDCEBOPPL JHPEPBNMJOM(string NHDAMJEEJKD, float PKCLPFEIPFH, FCJAIBCGFCE DKBLACNMNIM = FCJAIBCGFCE.CLOUD)
	{
		return default(DEIDCEBOPPL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x70C4BD0", Offset = "0x70C35D0", VA = "0x1870C4BD0", Slot = "19")]
	public DateTime PBCLDLILMAN(string NHDAMJEEJKD, [Optional] DateTime PFGHNJEFBFP, FCJAIBCGFCE DKBLACNMNIM = FCJAIBCGFCE.CLOUD)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x70C2C80", Offset = "0x70C1680", VA = "0x1870C2C80", Slot = "20")]
	public DEIDCEBOPPL FDLHHHOIKNN(string NHDAMJEEJKD, DateTime PKCLPFEIPFH, FCJAIBCGFCE DKBLACNMNIM = FCJAIBCGFCE.CLOUD)
	{
		return default(DEIDCEBOPPL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x70C2030", Offset = "0x70C0A30", VA = "0x1870C2030", Slot = "21")]
	public long AAIMENPHKAO(string NHDAMJEEJKD, long PFGHNJEFBFP = 0L, FCJAIBCGFCE DKBLACNMNIM = FCJAIBCGFCE.CLOUD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x70C4A50", Offset = "0x70C3450", VA = "0x1870C4A50", Slot = "22")]
	public DEIDCEBOPPL PAFFNGGCOCL(string NHDAMJEEJKD, long PKCLPFEIPFH, FCJAIBCGFCE DKBLACNMNIM = FCJAIBCGFCE.CLOUD)
	{
		return default(DEIDCEBOPPL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3084460", Offset = "0x3082E60", VA = "0x183084460", Slot = "23")]
	public T PCJCFPGPPPO<T>(string NHDAMJEEJKD, [Optional] T PFGHNJEFBFP, FCJAIBCGFCE DKBLACNMNIM = FCJAIBCGFCE.CLOUD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3084460", Offset = "0x3082E60", VA = "0x183084460", Slot = "24")]
	public DEIDCEBOPPL FFPIGPPPLCK<T>(string NHDAMJEEJKD, T PKCLPFEIPFH, FCJAIBCGFCE DKBLACNMNIM = FCJAIBCGFCE.CLOUD)
	{
		return default(DEIDCEBOPPL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x70C3950", Offset = "0x70C2350", VA = "0x1870C3950", Slot = "25")]
	public bool JCHALPIAMFH(string NHDAMJEEJKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x70C4380", Offset = "0x70C2D80", VA = "0x1870C4380", Slot = "26")]
	public bool MCNDMLKPNGB(string NHDAMJEEJKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x70C4140", Offset = "0x70C2B40", VA = "0x1870C4140", Slot = "27")]
	public string KPLPJCINNKE(string NHDAMJEEJKD, [Optional] string PFGHNJEFBFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x70C4A20", Offset = "0x70C3420", VA = "0x1870C4A20", Slot = "28")]
	public DEIDCEBOPPL OHDEOJLKJNL(string NHDAMJEEJKD, string PKCLPFEIPFH)
	{
		return default(DEIDCEBOPPL);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x70C2B30", Offset = "0x70C1530", VA = "0x1870C2B30", Slot = "29")]
	public int DJBECKLMHEJ(string NHDAMJEEJKD, int PFGHNJEFBFP = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x70C4DB0", Offset = "0x70C37B0", VA = "0x1870C4DB0", Slot = "30")]
	public DEIDCEBOPPL PJDBMICMIIM(string NHDAMJEEJKD, int PKCLPFEIPFH)
	{
		return default(DEIDCEBOPPL);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x70C2C10", Offset = "0x70C1610", VA = "0x1870C2C10", Slot = "31")]
	public bool FBMEPIAAKLG(string NHDAMJEEJKD, bool PFGHNJEFBFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x70C48D0", Offset = "0x70C32D0", VA = "0x1870C48D0", Slot = "32")]
	public DEIDCEBOPPL OBAFLIMANNK(string NHDAMJEEJKD, bool PKCLPFEIPFH)
	{
		return default(DEIDCEBOPPL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x70C4530", Offset = "0x70C2F30", VA = "0x1870C4530", Slot = "33")]
	public float MPAMOLGIAJI(string NHDAMJEEJKD, float PFGHNJEFBFP = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x70C2BE0", Offset = "0x70C15E0", VA = "0x1870C2BE0", Slot = "34")]
	public DEIDCEBOPPL FBDKNFCJJHP(string NHDAMJEEJKD, float PKCLPFEIPFH)
	{
		return default(DEIDCEBOPPL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x70C28A0", Offset = "0x70C12A0", VA = "0x1870C28A0", Slot = "35")]
	public DateTime COMGFPFKFED(string NHDAMJEEJKD, [Optional] DateTime PFGHNJEFBFP)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x70C3660", Offset = "0x70C2060", VA = "0x1870C3660", Slot = "36")]
	public DEIDCEBOPPL HKAJOINKDGI(string NHDAMJEEJKD, DateTime PKCLPFEIPFH)
	{
		return default(DEIDCEBOPPL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x70C3690", Offset = "0x70C2090", VA = "0x1870C3690", Slot = "37")]
	public long IBGHPELMCPG(string NHDAMJEEJKD, long PFGHNJEFBFP = 0L)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x70C20D0", Offset = "0x70C0AD0", VA = "0x1870C20D0", Slot = "38")]
	public DEIDCEBOPPL AHKBJMIGPBO(string NHDAMJEEJKD, long PKCLPFEIPFH)
	{
		return default(DEIDCEBOPPL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x70C25B0", Offset = "0x70C0FB0", VA = "0x1870C25B0")]
	private bool BJOHDAGLAMF(GOIJOCKJDEC EKHCBDGNDCI, string NHDAMJEEJKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x70C4440", Offset = "0x70C2E40", VA = "0x1870C4440")]
	private bool MJJGGANIIAL(GOIJOCKJDEC EKHCBDGNDCI, string NHDAMJEEJKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x70C2EE0", Offset = "0x70C18E0", VA = "0x1870C2EE0")]
	private DEIDCEBOPPL FHIGGIDONGN(GOIJOCKJDEC EKHCBDGNDCI, string NHDAMJEEJKD, string PKCLPFEIPFH)
	{
		return default(DEIDCEBOPPL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x70C2100", Offset = "0x70C0B00", VA = "0x1870C2100")]
	private DEIDCEBOPPL AIMCPLNELPF(GOIJOCKJDEC EKHCBDGNDCI, string NHDAMJEEJKD, int PKCLPFEIPFH)
	{
		return default(DEIDCEBOPPL);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x70C4C70", Offset = "0x70C3670", VA = "0x1870C4C70")]
	private DEIDCEBOPPL PEFLKBOBHDJ(GOIJOCKJDEC EKHCBDGNDCI, string NHDAMJEEJKD, bool PKCLPFEIPFH)
	{
		return default(DEIDCEBOPPL);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x70C3FF0", Offset = "0x70C29F0", VA = "0x1870C3FF0")]
	private DEIDCEBOPPL KPGEJIMPACK(GOIJOCKJDEC EKHCBDGNDCI, string NHDAMJEEJKD, float PKCLPFEIPFH)
	{
		return default(DEIDCEBOPPL);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x70C3110", Offset = "0x70C1B10", VA = "0x1870C3110")]
	private DEIDCEBOPPL GCMDOBOOPDO(GOIJOCKJDEC EKHCBDGNDCI, string NHDAMJEEJKD, DateTime PKCLPFEIPFH)
	{
		return default(DEIDCEBOPPL);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x70C3520", Offset = "0x70C1F20", VA = "0x1870C3520")]
	private DEIDCEBOPPL HFOJMBDGFFF(GOIJOCKJDEC EKHCBDGNDCI, string NHDAMJEEJKD, long PKCLPFEIPFH)
	{
		return default(DEIDCEBOPPL);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x3084760", Offset = "0x3083160", VA = "0x183084760")]
	private T LODKEHKLAAP<T>(GOIJOCKJDEC EKHCBDGNDCI, string NHDAMJEEJKD, T PFGHNJEFBFP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x3083880", Offset = "0x3082280", VA = "0x183083880")]
	private DEIDCEBOPPL CFBJPMJEABE<T>(GOIJOCKJDEC EKHCBDGNDCI, string NHDAMJEEJKD, T PKCLPFEIPFH)
	{
		return default(DEIDCEBOPPL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x3084630", Offset = "0x3083030", VA = "0x183084630", Slot = "39")]
	public void GCPCOHNMJNE<T>(BEFNLLNODFL<T> GHJKDBADCID, [Optional] IEqualityComparer<T> FNBJNOCPAIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x30846E0", Offset = "0x30830E0", VA = "0x1830846E0", Slot = "40")]
	public void IFMLGIGPLNE<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x70C3E80", Offset = "0x70C2880", VA = "0x1870C3E80")]
	[AsyncStateMachine(typeof(GBOPALBJBJO))]
	private void JOHPNGPBLEA(GOIJOCKJDEC PBFLFEMANFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x70C3280", Offset = "0x70C1C80", VA = "0x1870C3280", Slot = "43")]
	[AsyncStateMachine(typeof(GBOFJHFHLGO))]
	public Task GEJCDHINHPP([Optional] CancellationToken AICEIDIHFDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x70C2620", Offset = "0x70C1020", VA = "0x1870C2620")]
	private void CDDLNALPCPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x70C3030", Offset = "0x70C1A30", VA = "0x1870C3030", Slot = "41")]
	public IDisposable FMBEGJLCGGP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x70C2610", Offset = "0x70C1010", VA = "0x1870C2610", Slot = "42")]
	public void BNDFEBKNIMO(float FPEHIEEJIAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x70C45A0", Offset = "0x70C2FA0", VA = "0x1870C45A0")]
	private void NJCPPAOFHMF(float PEGHNDGJFJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x70C2E50", Offset = "0x70C1850", VA = "0x1870C2E50")]
	[IteratorStateMachine(typeof(DDKGEKGFLFF))]
	private IEnumerator<BGFOJNANPKN> FFJLIFEMKPP(float FPEHIEEJIAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x70C4350", Offset = "0x70C2D50", VA = "0x1870C4350")]
	[CompilerGenerated]
	private void LNJJKMFEKLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class LJPEHDLMLIH : FJLCIGLEIHL<bool>
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static LJPEHDLMLIH JOLICDCBKGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x70C09B0", Offset = "0x70BF3B0", VA = "0x1870C09B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x70C0A00", Offset = "0x70BF400", VA = "0x1870C0A00", Slot = "9")]
	public override string HLGBFIEHJDG(bool CPOLINJHFNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x70C0AF0", Offset = "0x70BF4F0", VA = "0x1870C0AF0", Slot = "10")]
	protected override bool PBBPOFKEJPO(string CPOLINJHFNA, [Out] bool PKCLPFEIPFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x70C0E00", Offset = "0x70BF800", VA = "0x1870C0E00")]
	public LJPEHDLMLIH()
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

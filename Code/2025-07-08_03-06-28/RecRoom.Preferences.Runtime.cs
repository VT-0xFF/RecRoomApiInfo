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
		[Cpp2IlInjected.Address(RVA = "0x84940C0", Offset = "0x8492EC0", VA = "0x1884940C0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x286F3E0", Offset = "0x286E1E0", VA = "0x18286F3E0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum BFDFFBMBGDB : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	CLOUD,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	DISK
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
internal static class NEPEJFBAFOP
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	internal delegate void KPKJLKNICGF(HAMENAPMFLK GAKMAAEJPCH);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x848FEF0", Offset = "0x848ECF0", VA = "0x18848FEF0")]
	private static void LGDHFHJMFIM(HAMENAPMFLK GAKMAAEJPCH, KPKJLKNICGF FHGBOMLEDBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x848FF70", Offset = "0x848ED70", VA = "0x18848FF70")]
	public static bool MPKJIOOIIOM(this HAMENAPMFLK GAKMAAEJPCH, string EEMELICKMHH, [Optional] KPKJLKNICGF FHGBOMLEDBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x848FC30", Offset = "0x848EA30", VA = "0x18848FC30")]
	public static CIDGJKKNIKN GOCMFINOMKM(this HAMENAPMFLK GAKMAAEJPCH, string EEMELICKMHH, string BNECONOIKOE, [Optional] KPKJLKNICGF FHGBOMLEDBI)
	{
		return default(CIDGJKKNIKN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x848F9A0", Offset = "0x848E7A0", VA = "0x18848F9A0")]
	public static CIDGJKKNIKN CGODEPPNEHN(this HAMENAPMFLK GAKMAAEJPCH, string EEMELICKMHH, int BNECONOIKOE, [Optional] KPKJLKNICGF FHGBOMLEDBI)
	{
		return default(CIDGJKKNIKN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x84900D0", Offset = "0x848EED0", VA = "0x1884900D0")]
	public static CIDGJKKNIKN PCAOICNJPLP(this HAMENAPMFLK GAKMAAEJPCH, string EEMELICKMHH, bool BNECONOIKOE, [Optional] KPKJLKNICGF FHGBOMLEDBI)
	{
		return default(CIDGJKKNIKN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x848FAE0", Offset = "0x848E8E0", VA = "0x18848FAE0")]
	public static CIDGJKKNIKN FODOAHJCHHC(this HAMENAPMFLK GAKMAAEJPCH, string EEMELICKMHH, float BNECONOIKOE, [Optional] KPKJLKNICGF FHGBOMLEDBI)
	{
		return default(CIDGJKKNIKN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x848FD80", Offset = "0x848EB80", VA = "0x18848FD80")]
	public static CIDGJKKNIKN KIDCNCNAECK(this HAMENAPMFLK GAKMAAEJPCH, string EEMELICKMHH, DateTime BNECONOIKOE, [Optional] KPKJLKNICGF FHGBOMLEDBI)
	{
		return default(CIDGJKKNIKN);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x848F860", Offset = "0x848E660", VA = "0x18848F860")]
	public static CIDGJKKNIKN AJBLEGAAPKA(this HAMENAPMFLK GAKMAAEJPCH, string EEMELICKMHH, long BNECONOIKOE, [Optional] KPKJLKNICGF FHGBOMLEDBI)
	{
		return default(CIDGJKKNIKN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class EBKIBJLPGLO : NCEIKBPNBLF, HAMENAPMFLK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly JKBFKDEAACO APJNJDKEBPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<string, byte> HLMLEPLPMIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private Dictionary<string, string> IAHPMCOOLLK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool LJEKCHIHJOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA735B0", Offset = "0xA723B0", VA = "0x180A735B0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Dictionary<string, string> LAOEBAPNCFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x848BEB0", Offset = "0x848ACB0", VA = "0x18848BEB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action GDCPILOBJMB
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x848D9A0", Offset = "0x848C7A0", VA = "0x18848D9A0")]
	[UnityEngine.Scripting.Preserve]
	public EBKIBJLPGLO([OLOAAHJODHH(null)] JKBFKDEAACO APJNJDKEBPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "8")]
	public void NPCLOFDHOKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x848C3B0", Offset = "0x848B1B0", VA = "0x18848C3B0")]
	private DirectoryInfo HAAHMAPHPHD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x848BF60", Offset = "0x848AD60", VA = "0x18848BF60", Slot = "6")]
	public Task DFOOBOHDCED(long NKJBGOHOCHD, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x848CBD0", Offset = "0x848B9D0", VA = "0x18848CBD0", Slot = "14")]
	public float IPCPEDBIDLF(string MAHBBBBCDEL, float JILABBLHNAO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x848CCB0", Offset = "0x848BAB0", VA = "0x18848CCB0", Slot = "13")]
	public void KAAGNAGHLGO(string MAHBBBBCDEL, bool BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x848D680", Offset = "0x848C480", VA = "0x18848D680", Slot = "12")]
	public bool NENKLJHDJED(string MAHBBBBCDEL, bool JILABBLHNAO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x848D610", Offset = "0x848C410", VA = "0x18848D610", Slot = "10")]
	public int MKKMJKKDMJC(string MAHBBBBCDEL, int JILABBLHNAO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x848BEF0", Offset = "0x848ACF0", VA = "0x18848BEF0", Slot = "18")]
	public DateTime DFHGOHPBEEL(string EEMELICKMHH, [Optional] DateTime JILABBLHNAO)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x848C7B0", Offset = "0x848B5B0", VA = "0x18848C7B0", Slot = "19")]
	public void IHEELKDGCCI(string MAHBBBBCDEL, DateTime BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x848BE40", Offset = "0x848AC40", VA = "0x18848BE40", Slot = "15")]
	public void AMBMKJDLMAH(string MAHBBBBCDEL, float BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x848D8A0", Offset = "0x848C6A0", VA = "0x18848D8A0", Slot = "11")]
	public void ONPCDIAIBJC(string MAHBBBBCDEL, int BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x848CD20", Offset = "0x848BB20", VA = "0x18848CD20", Slot = "20")]
	public long LKKPCLAEMFC(string EEMELICKMHH, long JILABBLHNAO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x848CC40", Offset = "0x848BA40", VA = "0x18848CC40", Slot = "21")]
	public void JIJHENBMEPB(string EEMELICKMHH, long BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3A0A400", Offset = "0x3A09200", VA = "0x183A0A400", Slot = "22")]
	public T LCCLFFJPEFL<T>(string EEMELICKMHH, T JILABBLHNAO, FOKBKGDLDMH<T> JONIAFELDDF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3A0B660", Offset = "0x3A0A460", VA = "0x183A0B660", Slot = "23")]
	public void MDMBJINFFEM<T>(string EEMELICKMHH, T BNECONOIKOE, FOKBKGDLDMH<T> JONIAFELDDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x848D560", Offset = "0x848C360", VA = "0x18848D560", Slot = "16")]
	public string MEPOCCEKCCJ(string MAHBBBBCDEL, string JILABBLHNAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x848CB60", Offset = "0x848B960", VA = "0x18848CB60", Slot = "17")]
	public void INHPEEBOOGN(string MAHBBBBCDEL, string BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x848D750", Offset = "0x848C550", VA = "0x18848D750", Slot = "24")]
	public void OGIBJJNNNOH(string MAHBBBBCDEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x848D910", Offset = "0x848C710", VA = "0x18848D910", Slot = "9")]
	public bool OPDJGBCLGIL(string MAHBBBBCDEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x848C820", Offset = "0x848B620", VA = "0x18848C820", Slot = "25")]
	public Task IKPPEKBFHHK(CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x848BFF0", Offset = "0x848ADF0", VA = "0x18848BFF0")]
	private void FJBNAFPFBDG(DirectoryInfo CBEILGEDOBM, string LNHFFPJLCNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x848C5B0", Offset = "0x848B3B0", VA = "0x18848C5B0")]
	private static string HFEHEIGPDNN(string MAHBBBBCDEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x848C4B0", Offset = "0x848B2B0", VA = "0x18848C4B0")]
	private static string HDPKJCMNJAN(byte[] JMAPKDPGDHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3A0A510", Offset = "0x3A09310", VA = "0x183A0A510")]
	private T LHCLHJGACJJ<T>(string EEMELICKMHH, T JILABBLHNAO, [Optional] FOKBKGDLDMH<T> LHBIPOJIBEL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3A091B0", Offset = "0x3A07FB0", VA = "0x183A091B0")]
	private void LAGAMOKKAFA<T>(string EEMELICKMHH, T BNECONOIKOE, [Optional] FOKBKGDLDMH<T> LHBIPOJIBEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x848CD90", Offset = "0x848BB90", VA = "0x18848CD90")]
	private Dictionary<string, string> MAGCKOAIJEJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal static class IMLLFOBAFOP
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x848E4F0", Offset = "0x848D2F0", VA = "0x18848E4F0")]
	[ONLJNMLDJBD.KDDDMPKOLFO]
	internal static void NPDNKFNEHEP(LOAHJOOKLEP CHDHLAGMCKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class DFPJDCNFOLO : PHAJDKGEBDC
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x848B4B0", Offset = "0x848A2B0", VA = "0x18848B4B0")]
	[UnityEngine.Scripting.Preserve]
	public DFPJDCNFOLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class PHAJDKGEBDC : NCEIKBPNBLF, HAMENAPMFLK, PCOBGDKNNJA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<string, object> HECPADGABNL;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool LJEKCHIHJOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA735B0", Offset = "0xA723B0", VA = "0x180A735B0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action GDCPILOBJMB
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "8")]
	public void NPCLOFDHOKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8490800", Offset = "0x848F600", VA = "0x188490800", Slot = "6")]
	public Task DFOOBOHDCED(long NKJBGOHOCHD, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8490D40", Offset = "0x848FB40", VA = "0x188490D40", Slot = "9")]
	public bool OPDJGBCLGIL(string EEMELICKMHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8490BC0", Offset = "0x848F9C0", VA = "0x188490BC0", Slot = "10")]
	public int MKKMJKKDMJC(string EEMELICKMHH, int JILABBLHNAO = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x8490CE0", Offset = "0x848FAE0", VA = "0x188490CE0", Slot = "11")]
	public void ONPCDIAIBJC(string EEMELICKMHH, int BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x8490C20", Offset = "0x848FA20", VA = "0x188490C20", Slot = "12")]
	public bool NENKLJHDJED(string EEMELICKMHH, bool JILABBLHNAO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x8490AA0", Offset = "0x848F8A0", VA = "0x188490AA0", Slot = "13")]
	public void KAAGNAGHLGO(string EEMELICKMHH, bool BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x84909E0", Offset = "0x848F7E0", VA = "0x1884909E0", Slot = "14")]
	public float IPCPEDBIDLF(string EEMELICKMHH, float JILABBLHNAO = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x8490740", Offset = "0x848F540", VA = "0x188490740", Slot = "15")]
	public void AMBMKJDLMAH(string EEMELICKMHH, float BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8490B60", Offset = "0x848F960", VA = "0x188490B60", Slot = "16")]
	public string MEPOCCEKCCJ(string EEMELICKMHH, [Optional] string JILABBLHNAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x8490980", Offset = "0x848F780", VA = "0x188490980", Slot = "17")]
	public void INHPEEBOOGN(string EEMELICKMHH, string BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x84907A0", Offset = "0x848F5A0", VA = "0x1884907A0", Slot = "18")]
	public DateTime DFHGOHPBEEL(string EEMELICKMHH, [Optional] DateTime JILABBLHNAO)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8490890", Offset = "0x848F690", VA = "0x188490890", Slot = "19")]
	public void IHEELKDGCCI(string EEMELICKMHH, DateTime BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x8490B00", Offset = "0x848F900", VA = "0x188490B00", Slot = "20")]
	public long LKKPCLAEMFC(string EEMELICKMHH, long JILABBLHNAO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x8490A40", Offset = "0x848F840", VA = "0x188490A40", Slot = "21")]
	public void JIJHENBMEPB(string EEMELICKMHH, long BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3D58550", Offset = "0x3D57350", VA = "0x183D58550", Slot = "22")]
	public T LCCLFFJPEFL<T>(string EEMELICKMHH, T JILABBLHNAO, FOKBKGDLDMH<T> JONIAFELDDF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3D58EF0", Offset = "0x3D57CF0", VA = "0x183D58EF0", Slot = "23")]
	public void MDMBJINFFEM<T>(string EEMELICKMHH, T BNECONOIKOE, FOKBKGDLDMH<T> JONIAFELDDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3D58650", Offset = "0x3D57450", VA = "0x183D58650")]
	public T LHCLHJGACJJ<T>(string EEMELICKMHH, T JILABBLHNAO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3D58060", Offset = "0x3D56E60", VA = "0x183D58060")]
	public void LAGAMOKKAFA<T>(string EEMELICKMHH, T BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x8490C80", Offset = "0x848FA80", VA = "0x188490C80", Slot = "24")]
	public void OGIBJJNNNOH(string EEMELICKMHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x84908F0", Offset = "0x848F6F0", VA = "0x1884908F0", Slot = "25")]
	public Task IKPPEKBFHHK(CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x848B4B0", Offset = "0x848A2B0", VA = "0x18848B4B0")]
	public PHAJDKGEBDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public abstract class IOJGPAIKKLH<TParent> where TParent : HAMENAPMFLK
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly HashSet<IOJGPAIKKLH<TParent>> BFMJHOLMCKM;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4F7BC80", Offset = "0x4F7AA80", VA = "0x184F7BC80")]
	protected IOJGPAIKKLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract void MKDKKBLDFOH();

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void IOPPJHOKOPM(string MAHBBBBCDEL);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4F7B6D0", Offset = "0x4F7A4D0", VA = "0x184F7B6D0")]
	public static void ALCGMHCIONJ(string MAHBBBBCDEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4F7B910", Offset = "0x4F7A710", VA = "0x184F7B910")]
	public static void IMECOIAIDIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class FEEHCMDHANG<TParent, TValue> : IOJGPAIKKLH<TParent> where TParent : HAMENAPMFLK
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly FEEHCMDHANG<TParent, TValue> CLGJEJAIGBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, TValue> BJKEGBBLKHH;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4CA3A00", Offset = "0x4CA2800", VA = "0x184CA3A00")]
	public bool BNILIKGEJAF(string ANEBGMAHJJK, [Out] TValue IDCDCAHIEEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4CA3A40", Offset = "0x4CA2840", VA = "0x184CA3A40")]
	public void GFFKPAMEJAH(string ANEBGMAHJJK, TValue BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4CA3B70", Offset = "0x4CA2970", VA = "0x184CA3B70", Slot = "4")]
	protected override void MKDKKBLDFOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x4CA3B40", Offset = "0x4CA2940", VA = "0x184CA3B40", Slot = "5")]
	protected override void IOPPJHOKOPM(string ANEBGMAHJJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x4CA3CD0", Offset = "0x4CA2AD0", VA = "0x184CA3CD0")]
	public FEEHCMDHANG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface HAMENAPMFLK
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool LJEKCHIHJOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NPCLOFDHOKC();

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OPDJGBCLGIL(string EEMELICKMHH);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int MKKMJKKDMJC(string EEMELICKMHH, int JILABBLHNAO = 0);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ONPCDIAIBJC(string EEMELICKMHH, int BNECONOIKOE);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool NENKLJHDJED(string EEMELICKMHH, bool JILABBLHNAO = false);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KAAGNAGHLGO(string EEMELICKMHH, bool BNECONOIKOE);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	float IPCPEDBIDLF(string EEMELICKMHH, float JILABBLHNAO = 0f);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void AMBMKJDLMAH(string EEMELICKMHH, float BNECONOIKOE);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	string MEPOCCEKCCJ(string EEMELICKMHH, [Optional] string JILABBLHNAO);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void INHPEEBOOGN(string EEMELICKMHH, string BNECONOIKOE);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	DateTime DFHGOHPBEEL(string EEMELICKMHH, [Optional] DateTime HGDNMCAFKEP);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void IHEELKDGCCI(string EEMELICKMHH, DateTime HGDNMCAFKEP);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "13")]
	long LKKPCLAEMFC(string EEMELICKMHH, long JILABBLHNAO);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void JIJHENBMEPB(string EEMELICKMHH, long BNECONOIKOE);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "15")]
	T LCCLFFJPEFL<T>(string EEMELICKMHH, T JILABBLHNAO, FOKBKGDLDMH<T> JONIAFELDDF);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void MDMBJINFFEM<T>(string EEMELICKMHH, T BNECONOIKOE, FOKBKGDLDMH<T> JONIAFELDDF);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void OGIBJJNNNOH(string EEMELICKMHH);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task IKPPEKBFHHK([Optional] CancellationToken HIMDFBHMPLL);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface NCEIKBPNBLF : HAMENAPMFLK
{
	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action GDCPILOBJMB;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task DFOOBOHDCED(long NKJBGOHOCHD, CancellationToken HIMDFBHMPLL);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface PCOBGDKNNJA : HAMENAPMFLK
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class DJNNAFAFAFG : NCEIKBPNBLF, HAMENAPMFLK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct FOGONAJPIHM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public DJNNAFAFAFG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x848DA40", Offset = "0x848C840", VA = "0x18848DA40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x848DE20", Offset = "0x848CC20", VA = "0x18848DE20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class NCMDPIIHICH : IEnumerator<DMCHEKCEBGH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private DMCHEKCEBGH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public DJNNAFAFAFG <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private DMCHEKCEBGH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xA5BF60", Offset = "0xA5AD60", VA = "0x180A5BF60")]
		[DebuggerHidden]
		public NCMDPIIHICH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x848F7A0", Offset = "0x848E5A0", VA = "0x18848F7A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x848F810", Offset = "0x848E610", VA = "0x18848F810", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly JKBFKDEAACO APJNJDKEBPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool EGODDIPBGOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private bool GCEJEGECLCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private LHMDOGMGMKE IHGLFCAAADP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private IHBKINGAIAD BABGAOHGDCC;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool LJEKCHIHJOL
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA735B0", Offset = "0xA723B0", VA = "0x180A735B0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action GDCPILOBJMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x848BD50", Offset = "0x848AB50", VA = "0x18848BD50")]
	[UnityEngine.Scripting.Preserve]
	public DJNNAFAFAFG([OLOAAHJODHH(null)] JKBFKDEAACO APJNJDKEBPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "8")]
	public void NPCLOFDHOKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x848B700", Offset = "0x848A500", VA = "0x18848B700", Slot = "6")]
	public Task DFOOBOHDCED(long NKJBGOHOCHD, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1D4C6F0", Offset = "0x1D4B4F0", VA = "0x181D4C6F0")]
	private static int BMCLLKJBFOD(bool BNECONOIKOE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x848BCD0", Offset = "0x848AAD0", VA = "0x18848BCD0", Slot = "9")]
	public bool OPDJGBCLGIL(string EEMELICKMHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x848BBB0", Offset = "0x848A9B0", VA = "0x18848BBB0", Slot = "10")]
	public int MKKMJKKDMJC(string EEMELICKMHH, int JILABBLHNAO = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x848BCA0", Offset = "0x848AAA0", VA = "0x18848BCA0", Slot = "11")]
	public void ONPCDIAIBJC(string EEMELICKMHH, int BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x848BBE0", Offset = "0x848A9E0", VA = "0x18848BBE0", Slot = "12")]
	public bool NENKLJHDJED(string EEMELICKMHH, bool JILABBLHNAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x848BA40", Offset = "0x848A840", VA = "0x18848BA40", Slot = "13")]
	public void KAAGNAGHLGO(string EEMELICKMHH, bool BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x848B920", Offset = "0x848A720", VA = "0x18848B920", Slot = "14")]
	public float IPCPEDBIDLF(string EEMELICKMHH, float JILABBLHNAO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x848B560", Offset = "0x848A360", VA = "0x18848B560", Slot = "15")]
	public void AMBMKJDLMAH(string EEMELICKMHH, float BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x848B690", Offset = "0x848A490", VA = "0x18848B690", Slot = "18")]
	public DateTime DFHGOHPBEEL(string EEMELICKMHH, [Optional] DateTime JILABBLHNAO)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x848B790", Offset = "0x848A590", VA = "0x18848B790", Slot = "19")]
	public void IHEELKDGCCI(string EEMELICKMHH, DateTime HGDNMCAFKEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x848BB10", Offset = "0x848A910", VA = "0x18848BB10", Slot = "20")]
	public long LKKPCLAEMFC(string EEMELICKMHH, long JILABBLHNAO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x848B950", Offset = "0x848A750", VA = "0x18848B950", Slot = "21")]
	public void JIJHENBMEPB(string EEMELICKMHH, long BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x39E6CE0", Offset = "0x39E5AE0", VA = "0x1839E6CE0", Slot = "22")]
	public T LCCLFFJPEFL<T>(string EEMELICKMHH, T JILABBLHNAO, FOKBKGDLDMH<T> JONIAFELDDF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x39E6EA0", Offset = "0x39E5CA0", VA = "0x1839E6EA0", Slot = "23")]
	public void MDMBJINFFEM<T>(string EEMELICKMHH, T BNECONOIKOE, FOKBKGDLDMH<T> JONIAFELDDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x39E6290", Offset = "0x39E5090", VA = "0x1839E6290")]
	private T EEONLEBGKEP<T>(string EEMELICKMHH, T JILABBLHNAO, [Optional] FOKBKGDLDMH<T> LHBIPOJIBEL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x39E5BC0", Offset = "0x39E49C0", VA = "0x1839E5BC0")]
	private void BMPPFOCLLEB<T>(string EEMELICKMHH, T BNECONOIKOE, [Optional] FOKBKGDLDMH<T> LHBIPOJIBEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x848BB80", Offset = "0x848A980", VA = "0x18848BB80", Slot = "16")]
	public string MEPOCCEKCCJ(string EEMELICKMHH, string JILABBLHNAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x848B8F0", Offset = "0x848A6F0", VA = "0x18848B8F0", Slot = "17")]
	public void INHPEEBOOGN(string EEMELICKMHH, string BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x848B670", Offset = "0x848A470", VA = "0x18848B670")]
	private void DEIMKIPBFHP(string EEMELICKMHH, string BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x848B540", Offset = "0x848A340", VA = "0x18848B540")]
	private string AJHEPGDGALF(string EEMELICKMHH, string JILABBLHNAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x848BC10", Offset = "0x848AA10", VA = "0x18848BC10", Slot = "24")]
	public void OGIBJJNNNOH(string EEMELICKMHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x848BA70", Offset = "0x848A870", VA = "0x18848BA70")]
	private string KAKGHGIDMMP(string MAHBBBBCDEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x848B800", Offset = "0x848A600", VA = "0x18848B800", Slot = "25")]
	[AsyncStateMachine(typeof(FOGONAJPIHM))]
	public Task IKPPEKBFHHK(CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x848B9C0", Offset = "0x848A7C0", VA = "0x18848B9C0")]
	[IteratorStateMachine(typeof(NCMDPIIHICH))]
	private IEnumerator<DMCHEKCEBGH> JLCDIGGJAFE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x848BCF0", Offset = "0x848AAF0", VA = "0x18848BCF0")]
	private void PPJBCNOICJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x848B590", Offset = "0x848A390", VA = "0x18848B590")]
	private void APHEBBGGLNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x848B600", Offset = "0x848A400", VA = "0x18848B600")]
	private void CGHIKFOPEHB(bool PFEMGKBIHJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class LHHDNDKGIFP : NCEIKBPNBLF, HAMENAPMFLK
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
	private Dictionary<string, string> IAHPMCOOLLK;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool LJEKCHIHJOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xA735B0", Offset = "0xA723B0", VA = "0x180A735B0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private string FFKIOFOJKAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x848E7F0", Offset = "0x848D5F0", VA = "0x18848E7F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private Dictionary<string, string> LAOEBAPNCFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x848E6B0", Offset = "0x848D4B0", VA = "0x18848E6B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action GDCPILOBJMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	[UnityEngine.Scripting.Preserve]
	public LHHDNDKGIFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "8")]
	public void NPCLOFDHOKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x848E760", Offset = "0x848D560", VA = "0x18848E760", Slot = "6")]
	public Task DFOOBOHDCED(long NKJBGOHOCHD, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x848EBE0", Offset = "0x848D9E0", VA = "0x18848EBE0", Slot = "14")]
	public float IPCPEDBIDLF(string MAHBBBBCDEL, float JILABBLHNAO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x848ECC0", Offset = "0x848DAC0", VA = "0x18848ECC0", Slot = "13")]
	public void KAAGNAGHLGO(string MAHBBBBCDEL, bool BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x848F1C0", Offset = "0x848DFC0", VA = "0x18848F1C0", Slot = "12")]
	public bool NENKLJHDJED(string MAHBBBBCDEL, bool JILABBLHNAO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x848F150", Offset = "0x848DF50", VA = "0x18848F150", Slot = "10")]
	public int MKKMJKKDMJC(string MAHBBBBCDEL, int JILABBLHNAO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x848E6F0", Offset = "0x848D4F0", VA = "0x18848E6F0", Slot = "18")]
	public DateTime DFHGOHPBEEL(string EEMELICKMHH, [Optional] DateTime JILABBLHNAO)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x848E860", Offset = "0x848D660", VA = "0x18848E860", Slot = "19")]
	public void IHEELKDGCCI(string MAHBBBBCDEL, DateTime BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x848E640", Offset = "0x848D440", VA = "0x18848E640", Slot = "15")]
	public void AMBMKJDLMAH(string MAHBBBBCDEL, float BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x848F350", Offset = "0x848E150", VA = "0x18848F350", Slot = "11")]
	public void ONPCDIAIBJC(string MAHBBBBCDEL, int BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x848ED30", Offset = "0x848DB30", VA = "0x18848ED30", Slot = "20")]
	public long LKKPCLAEMFC(string EEMELICKMHH, long JILABBLHNAO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x848EC50", Offset = "0x848DA50", VA = "0x18848EC50", Slot = "21")]
	public void JIJHENBMEPB(string EEMELICKMHH, long BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3A0A400", Offset = "0x3A09200", VA = "0x183A0A400", Slot = "22")]
	public T LCCLFFJPEFL<T>(string EEMELICKMHH, T JILABBLHNAO, FOKBKGDLDMH<T> JONIAFELDDF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3A0B660", Offset = "0x3A0A460", VA = "0x183A0B660", Slot = "23")]
	public void MDMBJINFFEM<T>(string EEMELICKMHH, T BNECONOIKOE, FOKBKGDLDMH<T> JONIAFELDDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x848F0A0", Offset = "0x848DEA0", VA = "0x18848F0A0", Slot = "16")]
	public string MEPOCCEKCCJ(string MAHBBBBCDEL, string JILABBLHNAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x848EB40", Offset = "0x848D940", VA = "0x18848EB40", Slot = "17")]
	public void INHPEEBOOGN(string MAHBBBBCDEL, string BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x848F290", Offset = "0x848E090", VA = "0x18848F290", Slot = "24")]
	public void OGIBJJNNNOH(string MAHBBBBCDEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x848F3C0", Offset = "0x848E1C0", VA = "0x18848F3C0", Slot = "9")]
	public bool OPDJGBCLGIL(string MAHBBBBCDEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x848E8D0", Offset = "0x848D6D0", VA = "0x18848E8D0", Slot = "25")]
	public Task IKPPEKBFHHK(CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3C544B0", Offset = "0x3C532B0", VA = "0x183C544B0")]
	private T LHCLHJGACJJ<T>(string EEMELICKMHH, T JILABBLHNAO, [Optional] FOKBKGDLDMH<T> LHBIPOJIBEL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3C537B0", Offset = "0x3C525B0", VA = "0x183C537B0")]
	private void LAGAMOKKAFA<T>(string EEMELICKMHH, T BNECONOIKOE, [Optional] FOKBKGDLDMH<T> LHBIPOJIBEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x848EDA0", Offset = "0x848DBA0", VA = "0x18848EDA0")]
	private Dictionary<string, string> MAGCKOAIJEJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface BKIICIJGLFD
{
	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action GDCPILOBJMB;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NPCLOFDHOKC();

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task DPAICEOKCOA(long NKJBGOHOCHD);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool BPNGDBEHBAE(BFDFFBMBGDB KBHJODNDMIB = BFDFFBMBGDB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool MEFMNJALMFO(string EEMELICKMHH, BFDFFBMBGDB KMLNDEPOOFK = BFDFFBMBGDB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool BCGLLFBGPDL(string EEMELICKMHH, BFDFFBMBGDB KMLNDEPOOFK = BFDFFBMBGDB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "7")]
	string PEIBKAIEACE(string EEMELICKMHH, [Optional] string JILABBLHNAO, BFDFFBMBGDB KMLNDEPOOFK = BFDFFBMBGDB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	CIDGJKKNIKN LLCFFHHMAAK(string EEMELICKMHH, string BNECONOIKOE, BFDFFBMBGDB KMLNDEPOOFK = BFDFFBMBGDB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	int HEHLKKHGDEF(string EEMELICKMHH, int JILABBLHNAO = 0, BFDFFBMBGDB KMLNDEPOOFK = BFDFFBMBGDB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	CIDGJKKNIKN EJHPGIMDGNH(string EEMELICKMHH, int BNECONOIKOE, BFDFFBMBGDB KMLNDEPOOFK = BFDFFBMBGDB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool NFEMCBMFOOF(string EEMELICKMHH, bool JILABBLHNAO, BFDFFBMBGDB KMLNDEPOOFK = BFDFFBMBGDB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "12")]
	CIDGJKKNIKN PLBBAIGKJIC(string EEMELICKMHH, bool BNECONOIKOE, BFDFFBMBGDB KMLNDEPOOFK = BFDFFBMBGDB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float BLPGDBMGDMJ(string EEMELICKMHH, float JILABBLHNAO = 0f, BFDFFBMBGDB KMLNDEPOOFK = BFDFFBMBGDB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "14")]
	CIDGJKKNIKN HMDFDJNNGKI(string EEMELICKMHH, float BNECONOIKOE, BFDFFBMBGDB KMLNDEPOOFK = BFDFFBMBGDB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "15")]
	DateTime JDBBBBMBLDB(string EEMELICKMHH, [Optional] DateTime JILABBLHNAO, BFDFFBMBGDB KMLNDEPOOFK = BFDFFBMBGDB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	CIDGJKKNIKN MFDJNKNLNJG(string EEMELICKMHH, DateTime BNECONOIKOE, BFDFFBMBGDB KMLNDEPOOFK = BFDFFBMBGDB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "17")]
	long BOPKNILJLLH(string EEMELICKMHH, long JILABBLHNAO = 0L, BFDFFBMBGDB KMLNDEPOOFK = BFDFFBMBGDB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "18")]
	CIDGJKKNIKN MAJPOFFOPIJ(string EEMELICKMHH, long BNECONOIKOE, BFDFFBMBGDB KMLNDEPOOFK = BFDFFBMBGDB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "19")]
	T MILAEFJEHCD<T>(string EEMELICKMHH, [Optional] T JILABBLHNAO, BFDFFBMBGDB KMLNDEPOOFK = BFDFFBMBGDB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "20")]
	CIDGJKKNIKN HOHFDMADFKE<T>(string EEMELICKMHH, T BNECONOIKOE, BFDFFBMBGDB KMLNDEPOOFK = BFDFFBMBGDB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool JBIEHGOLOOF(string EEMELICKMHH);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool LEGDJDCNMHK(string EEMELICKMHH);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "23")]
	string BENAEMANKHI(string EEMELICKMHH, [Optional] string JILABBLHNAO);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "24")]
	CIDGJKKNIKN MBBCPODFHCK(string EEMELICKMHH, string BNECONOIKOE);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "25")]
	int DGGEJCILHCF(string EEMELICKMHH, int JILABBLHNAO = 0);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "26")]
	CIDGJKKNIKN DOIOJBCGKNN(string EEMELICKMHH, int BNECONOIKOE);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool CCNFFDHPBNI(string EEMELICKMHH, bool JILABBLHNAO);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "28")]
	CIDGJKKNIKN IPBOABBDOEL(string EEMELICKMHH, bool BNECONOIKOE);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "29")]
	float JGCFHLMBHBD(string EEMELICKMHH, float JILABBLHNAO = 0f);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "30")]
	CIDGJKKNIKN GFKCFMDOBDG(string EEMELICKMHH, float BNECONOIKOE);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "31")]
	DateTime PMBCPHGPJAE(string EEMELICKMHH, [Optional] DateTime JILABBLHNAO);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "32")]
	CIDGJKKNIKN FEINNPAJOKH(string EEMELICKMHH, DateTime BNECONOIKOE);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "33")]
	long HPLLELJBPOH(string EEMELICKMHH, long JILABBLHNAO = 0L);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "34")]
	CIDGJKKNIKN NMHMLCINHFE(string EEMELICKMHH, long BNECONOIKOE);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void JOFOPLEPFKP<T>(FOKBKGDLDMH<T> JONIAFELDDF, [Optional] IEqualityComparer<T> JPJEBIEBIKM);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void HJBFIKOOICC<T>();

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "37")]
	IDisposable FLDFMHEDIFN();

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void HPKALKJGGEF(float JMOMPNOKIIJ);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task PPJBCNOICJH([Optional] CancellationToken HIMDFBHMPLL);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum CIDGJKKNIKN : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	Unchanged,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	New,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Changed
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class PMNNLNHPINE : BKIICIJGLFD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private abstract class GBMMNPKKGGK
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		protected static readonly HashSet<GBMMNPKKGGK> PNCIHFJAGLB;

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x848DE80", Offset = "0x848CC80", VA = "0x18848DE80")]
		public static void IMECOIAIDIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void MKDKKBLDFOH();

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		protected GBMMNPKKGGK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private class MMMGMBKMPLL<T> : GBMMNPKKGGK
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly MMMGMBKMPLL<T> ODAOEPEFKDK;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public FOKBKGDLDMH<T> JBFMIKHGIHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0xA598A0", Offset = "0xA586A0", VA = "0x180A598A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0xA59840", Offset = "0xA58640", VA = "0x180A59840")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public IEqualityComparer<T> CIEGABALALH
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0xA595A0", Offset = "0xA583A0", VA = "0x180A595A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool JAMMIFBEHCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x47FDD20", Offset = "0x47FCB20", VA = "0x1847FDD20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x5684E00", Offset = "0x5683C00", VA = "0x185684E00")]
		private MMMGMBKMPLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x5684A10", Offset = "0x5683810", VA = "0x185684A10")]
		public void HIMDKAKGPHI(FOKBKGDLDMH<T> LHBIPOJIBEL, [Optional] IEqualityComparer<T> JPJEBIEBIKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x5684B80", Offset = "0x5683980", VA = "0x185684B80", Slot = "4")]
		public override void MKDKKBLDFOH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private class MJGPJBFIJKB : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private readonly PMNNLNHPINE MPEGOOGCJBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly object JPJOPBIFNCO;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x848F610", Offset = "0x848E410", VA = "0x18848F610")]
		public MJGPJBFIJKB(PMNNLNHPINE MPEGOOGCJBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x848F5E0", Offset = "0x848E3E0", VA = "0x18848F5E0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct DBKPLPHHELI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public PMNNLNHPINE <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x848B160", Offset = "0x8489F60", VA = "0x18848B160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x848B450", Offset = "0x848A250", VA = "0x18848B450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct LPNCMJLMOFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public PMNNLNHPINE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public HAMENAPMFLK backingStoreToSave;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x848F450", Offset = "0x848E250", VA = "0x18848F450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0xAAD270", Offset = "0xAAC070", VA = "0x180AAD270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private struct NHAHNJFLPJO : IAsyncStateMachine
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
		public PMNNLNHPINE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x8490210", Offset = "0x848F010", VA = "0x188490210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x84906E0", Offset = "0x848F4E0", VA = "0x1884906E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class MOODDBAOOIG : IEnumerator<DMCHEKCEBGH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private DMCHEKCEBGH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public PMNNLNHPINE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public float seconds;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private DMCHEKCEBGH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xA5BF60", Offset = "0xA5AD60", VA = "0x180A5BF60")]
		[DebuggerHidden]
		public MOODDBAOOIG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x848F6C0", Offset = "0x848E4C0", VA = "0x18848F6C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x848F750", Offset = "0x848E550", VA = "0x18848F750", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly NCEIKBPNBLF CNHMCMDEMDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly NCEIKBPNBLF KALPBOFEIGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly PCOBGDKNNJA MPKPHAADOKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly LHMDOGMGMKE IHGLFCAAADP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly NEPEJFBAFOP.KPKJLKNICGF FHGBOMLEDBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly JDCOMPLHBHF ANFKAIBGHAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly HashSet<HAMENAPMFLK> MIEPPGFFKFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private Task IPMEGEKDDOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private Dictionary<string, string> BMDBPDCNOOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private IHBKINGAIAD IFFKDFNDGDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly object DIOFMPECDML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly object ILIMDDHJFON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private long LOLAOCBGIKI;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private bool EKBNJIEKOND
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8491F60", Offset = "0x8490D60", VA = "0x188491F60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private CancellationTokenSource CHPFOGCGJHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xA5F360", Offset = "0xA5E160", VA = "0x180A5F360")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xA5F3A0", Offset = "0xA5E1A0", VA = "0x180A5F3A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action GDCPILOBJMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8492AF0", Offset = "0x84918F0", VA = "0x188492AF0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x8492980", Offset = "0x8491780", VA = "0x188492980", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x8491660", Offset = "0x8490460", VA = "0x188491660")]
	[ONLJNMLDJBD.KDDDMPKOLFO]
	internal static void DKGNAIFEGAN(LOAHJOOKLEP CHDHLAGMCKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x8493C00", Offset = "0x8492A00", VA = "0x188493C00")]
	[UnityEngine.Scripting.Preserve]
	public PMNNLNHPINE([OLOAAHJODHH("Disk")] NCEIKBPNBLF CNHMCMDEMDP, [OLOAAHJODHH("Cloud")] NCEIKBPNBLF KALPBOFEIGK, [OLOAAHJODHH(null)] PCOBGDKNNJA MPKPHAADOKA, [OLOAAHJODHH(null)] LHMDOGMGMKE IHGLFCAAADP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x8491950", Offset = "0x8490750", VA = "0x188491950", Slot = "44")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x8491280", Offset = "0x8490080", VA = "0x188491280")]
	private void CAKLGGOPIPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x8493810", Offset = "0x8492610", VA = "0x188493810", Slot = "6")]
	public void NPCLOFDHOKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x8491780", Offset = "0x8490580", VA = "0x188491780", Slot = "7")]
	public Task DPAICEOKCOA(long NKJBGOHOCHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x8491CB0", Offset = "0x8490AB0", VA = "0x188491CB0")]
	[AsyncStateMachine(typeof(DBKPLPHHELI))]
	private Task FOCOKMBAPLI(long NKJBGOHOCHD, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x8493540", Offset = "0x8492340", VA = "0x188493540")]
	private void MOIAPPHHFOE(object OCGDLEBGIMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x8490DA0", Offset = "0x848FBA0", VA = "0x188490DA0")]
	private void ANILMBCCDPP(object OCGDLEBGIMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x8491C50", Offset = "0x8490A50", VA = "0x188491C50")]
	private string FMGGLFPDJIK(string MILLFJGJOFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x84927E0", Offset = "0x84915E0", VA = "0x1884927E0")]
	private void IJCEPKCECOP(BFDFFBMBGDB KBHJODNDMIB, string MAHBBBBCDEL, [Out] NCEIKBPNBLF GAKMAAEJPCH, [Out] string ANMIFDPGNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x84916D0", Offset = "0x84904D0", VA = "0x1884916D0")]
	private NCEIKBPNBLF DMKCEJOADJO(BFDFFBMBGDB KBHJODNDMIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x84911C0", Offset = "0x848FFC0", VA = "0x1884911C0", Slot = "8")]
	public bool BPNGDBEHBAE(BFDFFBMBGDB KBHJODNDMIB = BFDFFBMBGDB.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x8493300", Offset = "0x8492100", VA = "0x188493300", Slot = "9")]
	public bool MEFMNJALMFO(string EEMELICKMHH, BFDFFBMBGDB KMLNDEPOOFK = BFDFFBMBGDB.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x8490E20", Offset = "0x848FC20", VA = "0x188490E20", Slot = "10")]
	public bool BCGLLFBGPDL(string EEMELICKMHH, BFDFFBMBGDB KMLNDEPOOFK = BFDFFBMBGDB.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x8493880", Offset = "0x8492680", VA = "0x188493880", Slot = "11")]
	public string PEIBKAIEACE(string EEMELICKMHH, [Optional] string JILABBLHNAO, BFDFFBMBGDB KMLNDEPOOFK = BFDFFBMBGDB.CLOUD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x8492E80", Offset = "0x8491C80", VA = "0x188492E80", Slot = "12")]
	public CIDGJKKNIKN LLCFFHHMAAK(string EEMELICKMHH, string BNECONOIKOE, BFDFFBMBGDB KMLNDEPOOFK = BFDFFBMBGDB.CLOUD)
	{
		return default(CIDGJKKNIKN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x8491F80", Offset = "0x8490D80", VA = "0x188491F80", Slot = "13")]
	public int HEHLKKHGDEF(string EEMELICKMHH, int JILABBLHNAO = 0, BFDFFBMBGDB KMLNDEPOOFK = BFDFFBMBGDB.CLOUD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x84919C0", Offset = "0x84907C0", VA = "0x1884919C0", Slot = "14")]
	public CIDGJKKNIKN EJHPGIMDGNH(string EEMELICKMHH, int BNECONOIKOE, BFDFFBMBGDB KMLNDEPOOFK = BFDFFBMBGDB.CLOUD)
	{
		return default(CIDGJKKNIKN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x8493560", Offset = "0x8492360", VA = "0x188493560", Slot = "15")]
	public bool NFEMCBMFOOF(string EEMELICKMHH, bool JILABBLHNAO, BFDFFBMBGDB KMLNDEPOOFK = BFDFFBMBGDB.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x8493920", Offset = "0x8492720", VA = "0x188493920", Slot = "16")]
	public CIDGJKKNIKN PLBBAIGKJIC(string EEMELICKMHH, bool BNECONOIKOE, BFDFFBMBGDB KMLNDEPOOFK = BFDFFBMBGDB.CLOUD)
	{
		return default(CIDGJKKNIKN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x8491070", Offset = "0x848FE70", VA = "0x188491070", Slot = "17")]
	public float BLPGDBMGDMJ(string EEMELICKMHH, float JILABBLHNAO = 0f, BFDFFBMBGDB KMLNDEPOOFK = BFDFFBMBGDB.CLOUD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x8492360", Offset = "0x8491160", VA = "0x188492360", Slot = "18")]
	public CIDGJKKNIKN HMDFDJNNGKI(string EEMELICKMHH, float BNECONOIKOE, BFDFFBMBGDB KMLNDEPOOFK = BFDFFBMBGDB.CLOUD)
	{
		return default(CIDGJKKNIKN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x8492C20", Offset = "0x8491A20", VA = "0x188492C20", Slot = "19")]
	public DateTime JDBBBBMBLDB(string EEMELICKMHH, [Optional] DateTime JILABBLHNAO, BFDFFBMBGDB KMLNDEPOOFK = BFDFFBMBGDB.CLOUD)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x84933A0", Offset = "0x84921A0", VA = "0x1884933A0", Slot = "20")]
	public CIDGJKKNIKN MFDJNKNLNJG(string EEMELICKMHH, DateTime BNECONOIKOE, BFDFFBMBGDB KMLNDEPOOFK = BFDFFBMBGDB.CLOUD)
	{
		return default(CIDGJKKNIKN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x8491120", Offset = "0x848FF20", VA = "0x188491120", Slot = "21")]
	public long BOPKNILJLLH(string EEMELICKMHH, long JILABBLHNAO = 0L, BFDFFBMBGDB KMLNDEPOOFK = BFDFFBMBGDB.CLOUD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x8493010", Offset = "0x8491E10", VA = "0x188493010", Slot = "22")]
	public CIDGJKKNIKN MAJPOFFOPIJ(string EEMELICKMHH, long BNECONOIKOE, BFDFFBMBGDB KMLNDEPOOFK = BFDFFBMBGDB.CLOUD)
	{
		return default(CIDGJKKNIKN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x3D72550", Offset = "0x3D71350", VA = "0x183D72550", Slot = "23")]
	public T MILAEFJEHCD<T>(string EEMELICKMHH, [Optional] T JILABBLHNAO, BFDFFBMBGDB KMLNDEPOOFK = BFDFFBMBGDB.CLOUD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x3D72550", Offset = "0x3D71350", VA = "0x183D72550", Slot = "24")]
	public CIDGJKKNIKN HOHFDMADFKE<T>(string EEMELICKMHH, T BNECONOIKOE, BFDFFBMBGDB KMLNDEPOOFK = BFDFFBMBGDB.CLOUD)
	{
		return default(CIDGJKKNIKN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x8492BC0", Offset = "0x84919C0", VA = "0x188492BC0", Slot = "25")]
	public bool JBIEHGOLOOF(string EEMELICKMHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x8492E70", Offset = "0x8491C70", VA = "0x188492E70", Slot = "26")]
	public bool LEGDJDCNMHK(string EEMELICKMHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x8491000", Offset = "0x848FE00", VA = "0x188491000", Slot = "27")]
	public string BENAEMANKHI(string EEMELICKMHH, [Optional] string JILABBLHNAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x8493190", Offset = "0x8491F90", VA = "0x188493190", Slot = "28")]
	public CIDGJKKNIKN MBBCPODFHCK(string EEMELICKMHH, string BNECONOIKOE)
	{
		return default(CIDGJKKNIKN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x84915F0", Offset = "0x84903F0", VA = "0x1884915F0", Slot = "29")]
	public int DGGEJCILHCF(string EEMELICKMHH, int JILABBLHNAO = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x8491750", Offset = "0x8490550", VA = "0x188491750", Slot = "30")]
	public CIDGJKKNIKN DOIOJBCGKNN(string EEMELICKMHH, int BNECONOIKOE)
	{
		return default(CIDGJKKNIKN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x84912D0", Offset = "0x84900D0", VA = "0x1884912D0", Slot = "31")]
	public bool CCNFFDHPBNI(string EEMELICKMHH, bool JILABBLHNAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x8492B90", Offset = "0x8491990", VA = "0x188492B90", Slot = "32")]
	public CIDGJKKNIKN IPBOABBDOEL(string EEMELICKMHH, bool BNECONOIKOE)
	{
		return default(CIDGJKKNIKN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x8492CC0", Offset = "0x8491AC0", VA = "0x188492CC0", Slot = "33")]
	public float JGCFHLMBHBD(string EEMELICKMHH, float JILABBLHNAO = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x8491DC0", Offset = "0x8490BC0", VA = "0x188491DC0", Slot = "34")]
	public CIDGJKKNIKN GFKCFMDOBDG(string EEMELICKMHH, float BNECONOIKOE)
	{
		return default(CIDGJKKNIKN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x8493AA0", Offset = "0x84928A0", VA = "0x188493AA0", Slot = "35")]
	public DateTime PMBCPHGPJAE(string EEMELICKMHH, [Optional] DateTime JILABBLHNAO)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x8491B40", Offset = "0x8490940", VA = "0x188491B40", Slot = "36")]
	public CIDGJKKNIKN FEINNPAJOKH(string EEMELICKMHH, DateTime BNECONOIKOE)
	{
		return default(CIDGJKKNIKN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x8492770", Offset = "0x8491570", VA = "0x188492770", Slot = "37")]
	public long HPLLELJBPOH(string EEMELICKMHH, long JILABBLHNAO = 0L)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x8493610", Offset = "0x8492410", VA = "0x188493610", Slot = "38")]
	public CIDGJKKNIKN NMHMLCINHFE(string EEMELICKMHH, long BNECONOIKOE)
	{
		return default(CIDGJKKNIKN);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x8490FA0", Offset = "0x848FDA0", VA = "0x188490FA0")]
	private bool BEHLJPJPDLE(HAMENAPMFLK GAKMAAEJPCH, string EEMELICKMHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x8491490", Offset = "0x8490290", VA = "0x188491490")]
	private bool CKCGAGHDLMG(HAMENAPMFLK GAKMAAEJPCH, string EEMELICKMHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x8492210", Offset = "0x8491010", VA = "0x188492210")]
	private CIDGJKKNIKN HJMEDGGPJLE(HAMENAPMFLK GAKMAAEJPCH, string EEMELICKMHH, string BNECONOIKOE)
	{
		return default(CIDGJKKNIKN);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x84931C0", Offset = "0x8491FC0", VA = "0x1884931C0")]
	private CIDGJKKNIKN MCNHGBDBKJG(HAMENAPMFLK GAKMAAEJPCH, string EEMELICKMHH, int BNECONOIKOE)
	{
		return default(CIDGJKKNIKN);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x84936D0", Offset = "0x84924D0", VA = "0x1884936D0")]
	private CIDGJKKNIKN NNDIGKADHKI(HAMENAPMFLK GAKMAAEJPCH, string EEMELICKMHH, bool BNECONOIKOE)
	{
		return default(CIDGJKKNIKN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x8491340", Offset = "0x8490140", VA = "0x188491340")]
	private CIDGJKKNIKN CCOHACJGNHN(HAMENAPMFLK GAKMAAEJPCH, string EEMELICKMHH, float BNECONOIKOE)
	{
		return default(CIDGJKKNIKN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x8491DF0", Offset = "0x8490BF0", VA = "0x188491DF0")]
	private CIDGJKKNIKN GGDFDLIALGO(HAMENAPMFLK GAKMAAEJPCH, string EEMELICKMHH, DateTime BNECONOIKOE)
	{
		return default(CIDGJKKNIKN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x8492D30", Offset = "0x8491B30", VA = "0x188492D30")]
	private CIDGJKKNIKN KKENEGOLHJK(HAMENAPMFLK GAKMAAEJPCH, string EEMELICKMHH, long BNECONOIKOE)
	{
		return default(CIDGJKKNIKN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x3D72910", Offset = "0x3D71710", VA = "0x183D72910")]
	private T NIHIGCIBPBO<T>(HAMENAPMFLK GAKMAAEJPCH, string EEMELICKMHH, T JILABBLHNAO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x3D719C0", Offset = "0x3D707C0", VA = "0x183D719C0")]
	private CIDGJKKNIKN AJPMKIFKLIF<T>(HAMENAPMFLK GAKMAAEJPCH, string EEMELICKMHH, T BNECONOIKOE)
	{
		return default(CIDGJKKNIKN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3D726F0", Offset = "0x3D714F0", VA = "0x183D726F0", Slot = "39")]
	public void JOFOPLEPFKP<T>(FOKBKGDLDMH<T> JONIAFELDDF, [Optional] IEqualityComparer<T> JPJEBIEBIKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3D724D0", Offset = "0x3D712D0", VA = "0x183D724D0", Slot = "40")]
	public void HJBFIKOOICC<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x8492A20", Offset = "0x8491820", VA = "0x188492A20")]
	[AsyncStateMachine(typeof(LPNCMJLMOFP))]
	private void IKPPEKBFHHK(HAMENAPMFLK NEBNEFCOPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x8493B10", Offset = "0x8492910", VA = "0x188493B10", Slot = "43")]
	[AsyncStateMachine(typeof(NHAHNJFLPJO))]
	public Task PPJBCNOICJH([Optional] CancellationToken OCGDLEBGIMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x8492030", Offset = "0x8490E30", VA = "0x188492030")]
	private void HFPFOOLCAFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x8491B70", Offset = "0x8490970", VA = "0x188491B70", Slot = "41")]
	public IDisposable FLDFMHEDIFN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x8492760", Offset = "0x8491560", VA = "0x188492760", Slot = "42")]
	public void HPKALKJGGEF(float JMOMPNOKIIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x84924E0", Offset = "0x84912E0", VA = "0x1884924E0")]
	private void HOMPHDIFOLI(float PDBMBGMNMDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x8493640", Offset = "0x8492440", VA = "0x188493640")]
	[IteratorStateMachine(typeof(MOODDBAOOIG))]
	private IEnumerator<DMCHEKCEBGH> NNANMOGCJFL(float JMOMPNOKIIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x8491990", Offset = "0x8490790", VA = "0x188491990")]
	[CompilerGenerated]
	private void EIKBBHNIKIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class HMKEJINMGJF : KKBKGFKIBLB<bool>
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static HMKEJINMGJF ODAOEPEFKDK
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x848E050", Offset = "0x848CE50", VA = "0x18848E050")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x848E0A0", Offset = "0x848CEA0", VA = "0x18848E0A0", Slot = "9")]
	public override string NEJFHFKCOKJ(bool PADDIEKMDDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x848E190", Offset = "0x848CF90", VA = "0x18848E190", Slot = "10")]
	protected override bool PCCJOMNBKIL(string PADDIEKMDDH, [Out] bool BNECONOIKOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x848E4B0", Offset = "0x848D2B0", VA = "0x18848E4B0")]
	public HMKEJINMGJF()
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

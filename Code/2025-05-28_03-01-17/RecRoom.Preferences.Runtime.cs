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
		[Cpp2IlInjected.Address(RVA = "0x81602C0", Offset = "0x815F0C0", VA = "0x1881602C0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x26D4E40", Offset = "0x26D3C40", VA = "0x1826D4E40")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum KNIMADMOBAJ : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	CLOUD,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	DISK
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
internal static class NKMLOHPJCLB
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	internal delegate void BIMFBBIFANJ(ELHLIGIPIAP GMOBINLCDFA);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x815D910", Offset = "0x815C710", VA = "0x18815D910")]
	private static void HLCGDLGIPAN(ELHLIGIPIAP GMOBINLCDFA, BIMFBBIFANJ LDDAMOKMFPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x815DAD0", Offset = "0x815C8D0", VA = "0x18815DAD0")]
	public static bool JKJLFIJKFFB(this ELHLIGIPIAP GMOBINLCDFA, string JDKAHLJOMHL, [Optional] BIMFBBIFANJ LDDAMOKMFPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x815DD80", Offset = "0x815CB80", VA = "0x18815DD80")]
	public static EMNHEBMJAHK JOANCCKMHDA(this ELHLIGIPIAP GMOBINLCDFA, string JDKAHLJOMHL, string OAIIHELJHLG, [Optional] BIMFBBIFANJ LDDAMOKMFPM)
	{
		return default(EMNHEBMJAHK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x815D7D0", Offset = "0x815C5D0", VA = "0x18815D7D0")]
	public static EMNHEBMJAHK FJJHKKEDLMC(this ELHLIGIPIAP GMOBINLCDFA, string JDKAHLJOMHL, int OAIIHELJHLG, [Optional] BIMFBBIFANJ LDDAMOKMFPM)
	{
		return default(EMNHEBMJAHK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x815DC30", Offset = "0x815CA30", VA = "0x18815DC30")]
	public static EMNHEBMJAHK JLKMPEANIEP(this ELHLIGIPIAP GMOBINLCDFA, string JDKAHLJOMHL, bool OAIIHELJHLG, [Optional] BIMFBBIFANJ LDDAMOKMFPM)
	{
		return default(EMNHEBMJAHK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x815E040", Offset = "0x815CE40", VA = "0x18815E040")]
	public static EMNHEBMJAHK ONFEHJMBJAO(this ELHLIGIPIAP GMOBINLCDFA, string JDKAHLJOMHL, float OAIIHELJHLG, [Optional] BIMFBBIFANJ LDDAMOKMFPM)
	{
		return default(EMNHEBMJAHK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x815DED0", Offset = "0x815CCD0", VA = "0x18815DED0")]
	public static EMNHEBMJAHK KBNANJJHAAH(this ELHLIGIPIAP GMOBINLCDFA, string JDKAHLJOMHL, DateTime OAIIHELJHLG, [Optional] BIMFBBIFANJ LDDAMOKMFPM)
	{
		return default(EMNHEBMJAHK);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x815D990", Offset = "0x815C790", VA = "0x18815D990")]
	public static EMNHEBMJAHK HNIGBGPOINL(this ELHLIGIPIAP GMOBINLCDFA, string JDKAHLJOMHL, long OAIIHELJHLG, [Optional] BIMFBBIFANJ LDDAMOKMFPM)
	{
		return default(EMNHEBMJAHK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class NPKPBBBEBFE : NHBNIILKLEE, ELHLIGIPIAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly CBALDPODIDE LGHJDEDPDHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<string, byte> EPHPDBFEOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private Dictionary<string, string> EOJAGMBEKEE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool KNAODMGEKMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA24630", Offset = "0xA23430", VA = "0x180A24630", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Dictionary<string, string> NMMPCPHCPPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x815E8E0", Offset = "0x815D6E0", VA = "0x18815E8E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action COEKAINBOLB
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x815FCF0", Offset = "0x815EAF0", VA = "0x18815FCF0")]
	[UnityEngine.Scripting.Preserve]
	public NPKPBBBEBFE([LCNEJNNIOGA(null)] CBALDPODIDE LGHJDEDPDHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "8")]
	public void GEEJLGGNEJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x815FBF0", Offset = "0x815E9F0", VA = "0x18815FBF0")]
	private DirectoryInfo PLPAIINNMIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x815E920", Offset = "0x815D720", VA = "0x18815E920", Slot = "6")]
	public Task JLNNKPMFNPG(long ODEENNIBBLF, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x815F760", Offset = "0x815E560", VA = "0x18815F760", Slot = "14")]
	public float MJNEICEGALO(string MAKJJJECHHB, float LDGCNLHOBMI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x815E870", Offset = "0x815D670", VA = "0x18815E870", Slot = "13")]
	public void HAKFPMDLKGD(string MAKJJJECHHB, bool OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x815E630", Offset = "0x815D430", VA = "0x18815E630", Slot = "12")]
	public bool BLFAHFGOMEP(string MAKJJJECHHB, bool LDGCNLHOBMI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x815F7D0", Offset = "0x815E5D0", VA = "0x18815F7D0", Slot = "10")]
	public int NOJNFBAMCMB(string MAKJJJECHHB, int LDGCNLHOBMI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x815F5A0", Offset = "0x815E3A0", VA = "0x18815F5A0", Slot = "18")]
	public DateTime MCCAFNEFCPL(string JDKAHLJOMHL, [Optional] DateTime LDGCNLHOBMI)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x815E5C0", Offset = "0x815D3C0", VA = "0x18815E5C0", Slot = "19")]
	public void BFJCINADNMI(string MAKJJJECHHB, DateTime OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x815EC60", Offset = "0x815DA60", VA = "0x18815EC60", Slot = "15")]
	public void LHMOMCNDCOB(string MAKJJJECHHB, float OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x815E550", Offset = "0x815D350", VA = "0x18815E550", Slot = "11")]
	public void BDDBKIBCHHO(string MAKJJJECHHB, int OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x815E800", Offset = "0x815D600", VA = "0x18815E800", Slot = "20")]
	public long GJJHPLCBPII(string JDKAHLJOMHL, long LDGCNLHOBMI)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x815E790", Offset = "0x815D590", VA = "0x18815E790", Slot = "21")]
	public void FINFLIDGHBP(string JDKAHLJOMHL, long OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3719560", Offset = "0x3718360", VA = "0x183719560", Slot = "22")]
	public T FNPABALCBIC<T>(string JDKAHLJOMHL, T LDGCNLHOBMI, LKFMLKMIODG<T> NPEOPDDENAH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3719560", Offset = "0x3718360", VA = "0x183719560", Slot = "23")]
	public void MJMBPDLGMIP<T>(string JDKAHLJOMHL, T OAIIHELJHLG, LKFMLKMIODG<T> NPEOPDDENAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x815E9B0", Offset = "0x815D7B0", VA = "0x18815E9B0", Slot = "16")]
	public string KFPCOCNPCHK(string MAKJJJECHHB, string LDGCNLHOBMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x815F840", Offset = "0x815E640", VA = "0x18815F840", Slot = "17")]
	public void ODKFNILPFOF(string MAKJJJECHHB, string OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x815F610", Offset = "0x815E410", VA = "0x18815F610", Slot = "24")]
	public void MIPLEHHOEBJ(string MAKJJJECHHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x815E700", Offset = "0x815D500", VA = "0x18815E700", Slot = "9")]
	public bool DKOOAPMFALJ(string MAKJJJECHHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x815F8B0", Offset = "0x815E6B0", VA = "0x18815F8B0", Slot = "25")]
	public Task PAEBNFGIHCG(CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x815E190", Offset = "0x815CF90", VA = "0x18815E190")]
	private void AGFFCHJAALF(DirectoryInfo JDOINLNGADI, string EICEBKKDCHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x815EA60", Offset = "0x815D860", VA = "0x18815EA60")]
	private static string LHBBFALNKIM(string MAKJJJECHHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x815ECD0", Offset = "0x815DAD0", VA = "0x18815ECD0")]
	private static string LKBBOPOCGNE(byte[] HNAKMABCJKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3AD0260", Offset = "0x3ACF060", VA = "0x183AD0260")]
	private T MBFFDPKOBBN<T>(string JDKAHLJOMHL, T LDGCNLHOBMI, [Optional] LKFMLKMIODG<T> GKMMJBGAFIO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3ACEE80", Offset = "0x3ACDC80", VA = "0x183ACEE80")]
	private void KDAEEABIJCL<T>(string JDKAHLJOMHL, T OAIIHELJHLG, [Optional] LKFMLKMIODG<T> GKMMJBGAFIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x815EDD0", Offset = "0x815DBD0", VA = "0x18815EDD0")]
	private Dictionary<string, string> MAPKEAHFJMN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal static class NINPKGBEJIK
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x815D670", Offset = "0x815C470", VA = "0x18815D670")]
	[ENKLKENGHAE.AANPNKKBMFF]
	internal static void JKEPFALEAEN(NAELDDAANND AHGNCOFKLHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class DGGKHBPHPFJ : DEJAMFAEHHM
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8159240", Offset = "0x8158040", VA = "0x188159240")]
	[UnityEngine.Scripting.Preserve]
	public DGGKHBPHPFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class DEJAMFAEHHM : NHBNIILKLEE, ELHLIGIPIAP, IECHINKIFLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<string, object> IJKGNBGFEOD;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool KNAODMGEKMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA24630", Offset = "0xA23430", VA = "0x180A24630", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action COEKAINBOLB
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "8")]
	public void GEEJLGGNEJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8158E80", Offset = "0x8157C80", VA = "0x188158E80", Slot = "6")]
	public Task JLNNKPMFNPG(long ODEENNIBBLF, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8158D00", Offset = "0x8157B00", VA = "0x188158D00", Slot = "9")]
	public bool DKOOAPMFALJ(string JDKAHLJOMHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x81590F0", Offset = "0x8157EF0", VA = "0x1881590F0", Slot = "10")]
	public int NOJNFBAMCMB(string JDKAHLJOMHL, int LDGCNLHOBMI = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x8158BE0", Offset = "0x81579E0", VA = "0x188158BE0", Slot = "11")]
	public void BDDBKIBCHHO(string JDKAHLJOMHL, int OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x8158CA0", Offset = "0x8157AA0", VA = "0x188158CA0", Slot = "12")]
	public bool BLFAHFGOMEP(string JDKAHLJOMHL, bool LDGCNLHOBMI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x8158E20", Offset = "0x8157C20", VA = "0x188158E20", Slot = "13")]
	public void HAKFPMDLKGD(string JDKAHLJOMHL, bool OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x8159090", Offset = "0x8157E90", VA = "0x188159090", Slot = "14")]
	public float MJNEICEGALO(string JDKAHLJOMHL, float LDGCNLHOBMI = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x8158F70", Offset = "0x8157D70", VA = "0x188158F70", Slot = "15")]
	public void LHMOMCNDCOB(string JDKAHLJOMHL, float OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8158F10", Offset = "0x8157D10", VA = "0x188158F10", Slot = "16")]
	public string KFPCOCNPCHK(string JDKAHLJOMHL, [Optional] string LDGCNLHOBMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x8159150", Offset = "0x8157F50", VA = "0x188159150", Slot = "17")]
	public void ODKFNILPFOF(string JDKAHLJOMHL, string OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x8158FD0", Offset = "0x8157DD0", VA = "0x188158FD0", Slot = "18")]
	public DateTime MCCAFNEFCPL(string JDKAHLJOMHL, [Optional] DateTime LDGCNLHOBMI)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8158C40", Offset = "0x8157A40", VA = "0x188158C40", Slot = "19")]
	public void BFJCINADNMI(string JDKAHLJOMHL, DateTime OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x8158DC0", Offset = "0x8157BC0", VA = "0x188158DC0", Slot = "20")]
	public long GJJHPLCBPII(string JDKAHLJOMHL, long LDGCNLHOBMI)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x8158D60", Offset = "0x8157B60", VA = "0x188158D60", Slot = "21")]
	public void FINFLIDGHBP(string JDKAHLJOMHL, long OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x37547B0", Offset = "0x37535B0", VA = "0x1837547B0", Slot = "22")]
	public T FNPABALCBIC<T>(string JDKAHLJOMHL, T LDGCNLHOBMI, LKFMLKMIODG<T> NPEOPDDENAH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3755600", Offset = "0x3754400", VA = "0x183755600", Slot = "23")]
	public void MJMBPDLGMIP<T>(string JDKAHLJOMHL, T OAIIHELJHLG, LKFMLKMIODG<T> NPEOPDDENAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3754DC0", Offset = "0x3753BC0", VA = "0x183754DC0")]
	public T MBFFDPKOBBN<T>(string JDKAHLJOMHL, T LDGCNLHOBMI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x37548D0", Offset = "0x37536D0", VA = "0x1837548D0")]
	public void KDAEEABIJCL<T>(string JDKAHLJOMHL, T OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x8159030", Offset = "0x8157E30", VA = "0x188159030", Slot = "24")]
	public void MIPLEHHOEBJ(string JDKAHLJOMHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x81591B0", Offset = "0x8157FB0", VA = "0x1881591B0", Slot = "25")]
	public Task PAEBNFGIHCG(CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8159240", Offset = "0x8158040", VA = "0x188159240")]
	public DEJAMFAEHHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public abstract class DAFNGPGJPAO<TParent> where TParent : ELHLIGIPIAP
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly HashSet<DAFNGPGJPAO<TParent>> HOKNNMCBPNH;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6AE5F20", Offset = "0x6AE4D20", VA = "0x186AE5F20")]
	protected DAFNGPGJPAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract void CCLJDABAPHP();

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void JAHKILGJOBC(string MAKJJJECHHB);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6AE5970", Offset = "0x6AE4770", VA = "0x186AE5970")]
	public static void FIBMMPHGOIB(string MAKJJJECHHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6AE5BB0", Offset = "0x6AE49B0", VA = "0x186AE5BB0")]
	public static void NEPAAJKBBIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class HGBOFICNNKN<TParent, TValue> : DAFNGPGJPAO<TParent> where TParent : ELHLIGIPIAP
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly HGBOFICNNKN<TParent, TValue> OOIHKAJEMOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, TValue> AKLLJDBCNAL;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4C26970", Offset = "0x4C25770", VA = "0x184C26970")]
	public bool GNFCCDJDLII(string PACALLJHMNM, [Out] TValue JPPNJDBELKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4C26A30", Offset = "0x4C25830", VA = "0x184C26A30")]
	public void LBOACNKKCEB(string PACALLJHMNM, TValue OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4C26920", Offset = "0x4C25720", VA = "0x184C26920", Slot = "4")]
	protected override void CCLJDABAPHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x4A61F60", Offset = "0x4A60D60", VA = "0x184A61F60", Slot = "5")]
	protected override void JAHKILGJOBC(string PACALLJHMNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x4C26C70", Offset = "0x4C25A70", VA = "0x184C26C70")]
	public HGBOFICNNKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface ELHLIGIPIAP
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool KNAODMGEKMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GEEJLGGNEJD();

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DKOOAPMFALJ(string JDKAHLJOMHL);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int NOJNFBAMCMB(string JDKAHLJOMHL, int LDGCNLHOBMI = 0);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BDDBKIBCHHO(string JDKAHLJOMHL, int OAIIHELJHLG);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool BLFAHFGOMEP(string JDKAHLJOMHL, bool LDGCNLHOBMI = false);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HAKFPMDLKGD(string JDKAHLJOMHL, bool OAIIHELJHLG);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	float MJNEICEGALO(string JDKAHLJOMHL, float LDGCNLHOBMI = 0f);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LHMOMCNDCOB(string JDKAHLJOMHL, float OAIIHELJHLG);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	string KFPCOCNPCHK(string JDKAHLJOMHL, [Optional] string LDGCNLHOBMI);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void ODKFNILPFOF(string JDKAHLJOMHL, string OAIIHELJHLG);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	DateTime MCCAFNEFCPL(string JDKAHLJOMHL, [Optional] DateTime LGDPMOOCLMA);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void BFJCINADNMI(string JDKAHLJOMHL, DateTime LGDPMOOCLMA);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "13")]
	long GJJHPLCBPII(string JDKAHLJOMHL, long LDGCNLHOBMI);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void FINFLIDGHBP(string JDKAHLJOMHL, long OAIIHELJHLG);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "15")]
	T FNPABALCBIC<T>(string JDKAHLJOMHL, T LDGCNLHOBMI, LKFMLKMIODG<T> NPEOPDDENAH);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void MJMBPDLGMIP<T>(string JDKAHLJOMHL, T OAIIHELJHLG, LKFMLKMIODG<T> NPEOPDDENAH);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void MIPLEHHOEBJ(string JDKAHLJOMHL);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task PAEBNFGIHCG([Optional] CancellationToken GHKBKDKNIOM);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface NHBNIILKLEE : ELHLIGIPIAP
{
	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action COEKAINBOLB;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task JLNNKPMFNPG(long ODEENNIBBLF, CancellationToken GHKBKDKNIOM);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface IECHINKIFLC : ELHLIGIPIAP
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class CDHDNFCLNGH : NHBNIILKLEE, ELHLIGIPIAP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct PCDOKHPKGOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public CDHDNFCLNGH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x815FD90", Offset = "0x815EB90", VA = "0x18815FD90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8160170", Offset = "0x815EF70", VA = "0x188160170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class DOGKIJOADIP : IEnumerator<GCOFLMDGPIM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private GCOFLMDGPIM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public CDHDNFCLNGH <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private GCOFLMDGPIM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xA10020", Offset = "0xA0EE20", VA = "0x180A10020")]
		[DebuggerHidden]
		public DOGKIJOADIP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x81592D0", Offset = "0x81580D0", VA = "0x1881592D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8159340", Offset = "0x8158140", VA = "0x188159340", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly CBALDPODIDE LGHJDEDPDHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool CLENDBGDLIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private bool NJDFMLCGPLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private NODJGDJJMNJ FPNMOHNEPFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private BGLABEGMMJM GAELCCEDPAE;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool KNAODMGEKMM
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA24630", Offset = "0xA23430", VA = "0x180A24630", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action COEKAINBOLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x8157B50", Offset = "0x8156950", VA = "0x188157B50")]
	[UnityEngine.Scripting.Preserve]
	public CDHDNFCLNGH([LCNEJNNIOGA(null)] CBALDPODIDE LGHJDEDPDHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "8")]
	public void GEEJLGGNEJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x81576D0", Offset = "0x81564D0", VA = "0x1881576D0", Slot = "6")]
	public Task JLNNKPMFNPG(long ODEENNIBBLF, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1B6CA90", Offset = "0x1B6B890", VA = "0x181B6CA90")]
	private static int CIMEDPDAMLH(bool OAIIHELJHLG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x8157540", Offset = "0x8156340", VA = "0x188157540", Slot = "9")]
	public bool DKOOAPMFALJ(string JDKAHLJOMHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x8157960", Offset = "0x8156760", VA = "0x188157960", Slot = "10")]
	public int NOJNFBAMCMB(string JDKAHLJOMHL, int LDGCNLHOBMI = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x81573B0", Offset = "0x81561B0", VA = "0x1881573B0", Slot = "11")]
	public void BDDBKIBCHHO(string JDKAHLJOMHL, int OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x8157450", Offset = "0x8156250", VA = "0x188157450", Slot = "12")]
	public bool BLFAHFGOMEP(string JDKAHLJOMHL, bool LDGCNLHOBMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x8157640", Offset = "0x8156440", VA = "0x188157640", Slot = "13")]
	public void HAKFPMDLKGD(string JDKAHLJOMHL, bool OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x81578C0", Offset = "0x81566C0", VA = "0x1881578C0", Slot = "14")]
	public float MJNEICEGALO(string JDKAHLJOMHL, float LDGCNLHOBMI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x8157790", Offset = "0x8156590", VA = "0x188157790", Slot = "15")]
	public void LHMOMCNDCOB(string JDKAHLJOMHL, float OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x81577C0", Offset = "0x81565C0", VA = "0x1881577C0", Slot = "18")]
	public DateTime MCCAFNEFCPL(string JDKAHLJOMHL, [Optional] DateTime LDGCNLHOBMI)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x81573E0", Offset = "0x81561E0", VA = "0x1881573E0", Slot = "19")]
	public void BFJCINADNMI(string JDKAHLJOMHL, DateTime LGDPMOOCLMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x81575D0", Offset = "0x81563D0", VA = "0x1881575D0", Slot = "20")]
	public long GJJHPLCBPII(string JDKAHLJOMHL, long LDGCNLHOBMI)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x8157560", Offset = "0x8156360", VA = "0x188157560", Slot = "21")]
	public void FINFLIDGHBP(string JDKAHLJOMHL, long OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x37083B0", Offset = "0x37071B0", VA = "0x1837083B0", Slot = "22")]
	public T FNPABALCBIC<T>(string JDKAHLJOMHL, T LDGCNLHOBMI, LKFMLKMIODG<T> NPEOPDDENAH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x37083B0", Offset = "0x37071B0", VA = "0x1837083B0", Slot = "23")]
	public void MJMBPDLGMIP<T>(string JDKAHLJOMHL, T OAIIHELJHLG, LKFMLKMIODG<T> NPEOPDDENAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3708D70", Offset = "0x3707B70", VA = "0x183708D70")]
	private T OKELBALMHHH<T>(string JDKAHLJOMHL, T LDGCNLHOBMI, [Optional] LKFMLKMIODG<T> GKMMJBGAFIO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3708590", Offset = "0x3707390", VA = "0x183708590")]
	private void HEEMDEDKLCG<T>(string JDKAHLJOMHL, T OAIIHELJHLG, [Optional] LKFMLKMIODG<T> GKMMJBGAFIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8157760", Offset = "0x8156560", VA = "0x188157760", Slot = "16")]
	public string KFPCOCNPCHK(string JDKAHLJOMHL, string LDGCNLHOBMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x8157990", Offset = "0x8156790", VA = "0x188157990", Slot = "17")]
	public void ODKFNILPFOF(string JDKAHLJOMHL, string OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x8157520", Offset = "0x8156320", VA = "0x188157520")]
	private void DIEPCNEEDIK(string JDKAHLJOMHL, string OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8157500", Offset = "0x8156300", VA = "0x188157500")]
	private string DEFKDNOFELL(string JDKAHLJOMHL, string LDGCNLHOBMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x8157830", Offset = "0x8156630", VA = "0x188157830", Slot = "24")]
	public void MIPLEHHOEBJ(string JDKAHLJOMHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x8157AB0", Offset = "0x81568B0", VA = "0x188157AB0")]
	private string PEPPJPPAIPL(string MAKJJJECHHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x81579C0", Offset = "0x81567C0", VA = "0x1881579C0", Slot = "25")]
	[AsyncStateMachine(typeof(PCDOKHPKGOC))]
	public Task PAEBNFGIHCG(CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x8157480", Offset = "0x8156280", VA = "0x188157480")]
	[IteratorStateMachine(typeof(DOGKIJOADIP))]
	private IEnumerator<GCOFLMDGPIM> CJPFHCHAFPB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x8157670", Offset = "0x8156470", VA = "0x188157670")]
	private void IFDCLMANBIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x81578F0", Offset = "0x81566F0", VA = "0x1881578F0")]
	private void MLLGOJEHKOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x8157340", Offset = "0x8156140", VA = "0x188157340")]
	private void AKCDKPBDEGP(bool OCGKAKAEMNM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class CPHGBHDEMAK : NHBNIILKLEE, ELHLIGIPIAP
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
	private Dictionary<string, string> EOJAGMBEKEE;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool KNAODMGEKMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xA24630", Offset = "0xA23430", VA = "0x180A24630", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private string BFINDKPOMBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8157EF0", Offset = "0x8156CF0", VA = "0x188157EF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private Dictionary<string, string> NMMPCPHCPPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8158040", Offset = "0x8156E40", VA = "0x188158040")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action COEKAINBOLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	[UnityEngine.Scripting.Preserve]
	public CPHGBHDEMAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "8")]
	public void GEEJLGGNEJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x8158080", Offset = "0x8156E80", VA = "0x188158080", Slot = "6")]
	public Task JLNNKPMFNPG(long ODEENNIBBLF, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x8158660", Offset = "0x8157460", VA = "0x188158660", Slot = "14")]
	public float MJNEICEGALO(string MAKJJJECHHB, float LDGCNLHOBMI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x8157FD0", Offset = "0x8156DD0", VA = "0x188157FD0", Slot = "13")]
	public void HAKFPMDLKGD(string MAKJJJECHHB, bool OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x8157D20", Offset = "0x8156B20", VA = "0x188157D20", Slot = "12")]
	public bool BLFAHFGOMEP(string MAKJJJECHHB, bool LDGCNLHOBMI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x81586D0", Offset = "0x81574D0", VA = "0x1881586D0", Slot = "10")]
	public int NOJNFBAMCMB(string MAKJJJECHHB, int LDGCNLHOBMI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x8158530", Offset = "0x8157330", VA = "0x188158530", Slot = "18")]
	public DateTime MCCAFNEFCPL(string JDKAHLJOMHL, [Optional] DateTime LDGCNLHOBMI)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x8157CB0", Offset = "0x8156AB0", VA = "0x188157CB0", Slot = "19")]
	public void BFJCINADNMI(string MAKJJJECHHB, DateTime OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x81581C0", Offset = "0x8156FC0", VA = "0x1881581C0", Slot = "15")]
	public void LHMOMCNDCOB(string MAKJJJECHHB, float OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x8157C40", Offset = "0x8156A40", VA = "0x188157C40", Slot = "11")]
	public void BDDBKIBCHHO(string MAKJJJECHHB, int OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x8157F60", Offset = "0x8156D60", VA = "0x188157F60", Slot = "20")]
	public long GJJHPLCBPII(string JDKAHLJOMHL, long LDGCNLHOBMI)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8157E80", Offset = "0x8156C80", VA = "0x188157E80", Slot = "21")]
	public void FINFLIDGHBP(string JDKAHLJOMHL, long OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3719560", Offset = "0x3718360", VA = "0x183719560", Slot = "22")]
	public T FNPABALCBIC<T>(string JDKAHLJOMHL, T LDGCNLHOBMI, LKFMLKMIODG<T> NPEOPDDENAH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3719560", Offset = "0x3718360", VA = "0x183719560", Slot = "23")]
	public void MJMBPDLGMIP<T>(string JDKAHLJOMHL, T OAIIHELJHLG, LKFMLKMIODG<T> NPEOPDDENAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x8158110", Offset = "0x8156F10", VA = "0x188158110", Slot = "16")]
	public string KFPCOCNPCHK(string MAKJJJECHHB, string LDGCNLHOBMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x8158740", Offset = "0x8157540", VA = "0x188158740", Slot = "17")]
	public void ODKFNILPFOF(string MAKJJJECHHB, string OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x81585A0", Offset = "0x81573A0", VA = "0x1881585A0", Slot = "24")]
	public void MIPLEHHOEBJ(string MAKJJJECHHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x8157DF0", Offset = "0x8156BF0", VA = "0x188157DF0", Slot = "9")]
	public bool DKOOAPMFALJ(string MAKJJJECHHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x81587E0", Offset = "0x81575E0", VA = "0x1881587E0", Slot = "25")]
	public Task PAEBNFGIHCG(CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x371A610", Offset = "0x3719410", VA = "0x18371A610")]
	private T MBFFDPKOBBN<T>(string JDKAHLJOMHL, T LDGCNLHOBMI, [Optional] LKFMLKMIODG<T> GKMMJBGAFIO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x37196A0", Offset = "0x37184A0", VA = "0x1837196A0")]
	private void KDAEEABIJCL<T>(string JDKAHLJOMHL, T OAIIHELJHLG, [Optional] LKFMLKMIODG<T> GKMMJBGAFIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x8158230", Offset = "0x8157030", VA = "0x188158230")]
	private Dictionary<string, string> MAPKEAHFJMN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface GLGKNJAKNPE
{
	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action COEKAINBOLB;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GEEJLGGNEJD();

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task BGJFCKOHALA(long ODEENNIBBLF);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool KIKBNMGCMFH(KNIMADMOBAJ MLLHHNOGIPF = KNIMADMOBAJ.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool NBHIJAPBIEB(string JDKAHLJOMHL, KNIMADMOBAJ BLMIGFKGFLH = KNIMADMOBAJ.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool GDMOOBNFGIA(string JDKAHLJOMHL, KNIMADMOBAJ BLMIGFKGFLH = KNIMADMOBAJ.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "7")]
	string JKNFIFPPCJF(string JDKAHLJOMHL, [Optional] string LDGCNLHOBMI, KNIMADMOBAJ BLMIGFKGFLH = KNIMADMOBAJ.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	EMNHEBMJAHK GLCICILCNIB(string JDKAHLJOMHL, string OAIIHELJHLG, KNIMADMOBAJ BLMIGFKGFLH = KNIMADMOBAJ.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	int CDOBEKJMBMC(string JDKAHLJOMHL, int LDGCNLHOBMI = 0, KNIMADMOBAJ BLMIGFKGFLH = KNIMADMOBAJ.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	EMNHEBMJAHK FNHALOBEMHK(string JDKAHLJOMHL, int OAIIHELJHLG, KNIMADMOBAJ BLMIGFKGFLH = KNIMADMOBAJ.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool FELMEKOCIGJ(string JDKAHLJOMHL, bool LDGCNLHOBMI, KNIMADMOBAJ BLMIGFKGFLH = KNIMADMOBAJ.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "12")]
	EMNHEBMJAHK CDGCILDJMCP(string JDKAHLJOMHL, bool OAIIHELJHLG, KNIMADMOBAJ BLMIGFKGFLH = KNIMADMOBAJ.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float AAFNBKGDPPK(string JDKAHLJOMHL, float LDGCNLHOBMI = 0f, KNIMADMOBAJ BLMIGFKGFLH = KNIMADMOBAJ.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "14")]
	EMNHEBMJAHK BNONCDKNMCL(string JDKAHLJOMHL, float OAIIHELJHLG, KNIMADMOBAJ BLMIGFKGFLH = KNIMADMOBAJ.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "15")]
	DateTime HFCDLAIFCFE(string JDKAHLJOMHL, [Optional] DateTime LDGCNLHOBMI, KNIMADMOBAJ BLMIGFKGFLH = KNIMADMOBAJ.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	EMNHEBMJAHK GJBIOMADAIA(string JDKAHLJOMHL, DateTime OAIIHELJHLG, KNIMADMOBAJ BLMIGFKGFLH = KNIMADMOBAJ.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "17")]
	long GAAFKLABALH(string JDKAHLJOMHL, long LDGCNLHOBMI = 0L, KNIMADMOBAJ BLMIGFKGFLH = KNIMADMOBAJ.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "18")]
	EMNHEBMJAHK NJPLOECPGOE(string JDKAHLJOMHL, long OAIIHELJHLG, KNIMADMOBAJ BLMIGFKGFLH = KNIMADMOBAJ.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "19")]
	T APMKPHFFEAF<T>(string JDKAHLJOMHL, [Optional] T LDGCNLHOBMI, KNIMADMOBAJ BLMIGFKGFLH = KNIMADMOBAJ.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "20")]
	EMNHEBMJAHK PLBFOAHIDLM<T>(string JDKAHLJOMHL, T OAIIHELJHLG, KNIMADMOBAJ BLMIGFKGFLH = KNIMADMOBAJ.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool OBDPANCGAOD(string JDKAHLJOMHL);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool JMPIBEMINBM(string JDKAHLJOMHL);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "23")]
	string JMPMJCPAPKA(string JDKAHLJOMHL, [Optional] string LDGCNLHOBMI);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "24")]
	EMNHEBMJAHK HJMOKHLHMJL(string JDKAHLJOMHL, string OAIIHELJHLG);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "25")]
	int NALDIGJIDHB(string JDKAHLJOMHL, int LDGCNLHOBMI = 0);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "26")]
	EMNHEBMJAHK AKFPFFMHHCF(string JDKAHLJOMHL, int OAIIHELJHLG);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool GKGCEGACBNH(string JDKAHLJOMHL, bool LDGCNLHOBMI);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "28")]
	EMNHEBMJAHK DPMBPHFMLIM(string JDKAHLJOMHL, bool OAIIHELJHLG);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "29")]
	float LAHILGINJHF(string JDKAHLJOMHL, float LDGCNLHOBMI = 0f);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "30")]
	EMNHEBMJAHK PPAPBNHCDBD(string JDKAHLJOMHL, float OAIIHELJHLG);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "31")]
	DateTime LPOCBPOGIGF(string JDKAHLJOMHL, [Optional] DateTime LDGCNLHOBMI);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "32")]
	EMNHEBMJAHK DJHMFPJDOCA(string JDKAHLJOMHL, DateTime OAIIHELJHLG);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "33")]
	long DFMJKKAEDJI(string JDKAHLJOMHL, long LDGCNLHOBMI = 0L);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "34")]
	EMNHEBMJAHK GOHCJOFKLOC(string JDKAHLJOMHL, long OAIIHELJHLG);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void IPEEHDLPLFG<T>(LKFMLKMIODG<T> NPEOPDDENAH, [Optional] IEqualityComparer<T> EDPFJJMAPIB);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void CJAKHCMNONL<T>();

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "37")]
	IDisposable PCLDOKMGOCG();

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void JCPDDAHFPKK(float POHFDNBLLPJ);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task IFDCLMANBIA([Optional] CancellationToken GHKBKDKNIOM);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum EMNHEBMJAHK : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	Unchanged,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	New,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Changed
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class HEODNCJNDAL : GLGKNJAKNPE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private abstract class LDNMFNGDDCM
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		protected static readonly HashSet<LDNMFNGDDCM> OEFCCPAHHIO;

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x815D4A0", Offset = "0x815C2A0", VA = "0x18815D4A0")]
		public static void NEPAAJKBBIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void CCLJDABAPHP();

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		protected LDNMFNGDDCM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private class DJENLGABJOP<T> : LDNMFNGDDCM
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly DJENLGABJOP<T> ICOFMPPJNFC;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public LKFMLKMIODG<T> AINIPPAACAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public IEqualityComparer<T> GNLKPLNAJPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool JMCNJLBDMIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x45C11D0", Offset = "0x45BFFD0", VA = "0x1845C11D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x6B17370", Offset = "0x6B16170", VA = "0x186B17370")]
		private DJENLGABJOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x6B16ED0", Offset = "0x6B15CD0", VA = "0x186B16ED0")]
		public void KEMEJJLNDFN(LKFMLKMIODG<T> GKMMJBGAFIO, [Optional] IEqualityComparer<T> EDPFJJMAPIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x6B16C90", Offset = "0x6B15A90", VA = "0x186B16C90", Slot = "4")]
		public override void CCLJDABAPHP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private class HFHCGCGKPOC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private readonly HEODNCJNDAL MDDHFLNPNGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly object MHBOEECGFJD;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x815C600", Offset = "0x815B400", VA = "0x18815C600")]
		public HFHCGCGKPOC(HEODNCJNDAL MDDHFLNPNGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x815C5D0", Offset = "0x815B3D0", VA = "0x18815C5D0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct IJGMBCLMGDM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public HEODNCJNDAL <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x815CBE0", Offset = "0x815B9E0", VA = "0x18815CBE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x815CEC0", Offset = "0x815BCC0", VA = "0x18815CEC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct DDNIKNAGIGJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public HEODNCJNDAL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public ELHLIGIPIAP backingStoreToSave;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8158A50", Offset = "0x8157850", VA = "0x188158A50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0xA5B8B0", Offset = "0xA5A6B0", VA = "0x180A5B8B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private struct HLJCELBPGPA : IAsyncStateMachine
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
		public HEODNCJNDAL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x815C6B0", Offset = "0x815B4B0", VA = "0x18815C6B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x815CB80", Offset = "0x815B980", VA = "0x18815CB80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class JPPDDCGHHFE : IEnumerator<GCOFLMDGPIM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private GCOFLMDGPIM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public HEODNCJNDAL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public float seconds;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private GCOFLMDGPIM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xA10020", Offset = "0xA0EE20", VA = "0x180A10020")]
		[DebuggerHidden]
		public JPPDDCGHHFE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x815CF20", Offset = "0x815BD20", VA = "0x18815CF20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x815CFB0", Offset = "0x815BDB0", VA = "0x18815CFB0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly NHBNIILKLEE DPEOCNNBIJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly NHBNIILKLEE IMKDELLBJDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly IECHINKIFLC CFMPPDMGOLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly NODJGDJJMNJ FPNMOHNEPFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly NKMLOHPJCLB.BIMFBBIFANJ LDDAMOKMFPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly GHLDACEJKIG NNFHDIBPKAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly HashSet<ELHLIGIPIAP> KICFLALKDEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private Task IKFAPGCPPPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private Dictionary<string, string> EONOFLPOKED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private BGLABEGMMJM NCEKEPHBCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly object DPMHMFAOOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly object BAOIAAPMBCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private long DGCFNHOOGIF;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private bool IDIABMHEHFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x815C160", Offset = "0x815AF60", VA = "0x18815C160")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private CancellationTokenSource HGGENDPACGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xA0D020", Offset = "0xA0BE20", VA = "0x180A0D020")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xA0D010", Offset = "0xA0BE10", VA = "0x180A0D010")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action COEKAINBOLB
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x815B910", Offset = "0x815A710", VA = "0x18815B910", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x815A1B0", Offset = "0x8158FB0", VA = "0x18815A1B0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x8159610", Offset = "0x8158410", VA = "0x188159610")]
	[ENKLKENGHAE.AANPNKKBMFF]
	internal static void BAEPNPABNEB(NAELDDAANND AHGNCOFKLHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x815C200", Offset = "0x815B000", VA = "0x18815C200")]
	[UnityEngine.Scripting.Preserve]
	public HEODNCJNDAL([LCNEJNNIOGA("Disk")] NHBNIILKLEE DPEOCNNBIJD, [LCNEJNNIOGA("Cloud")] NHBNIILKLEE IMKDELLBJDF, [LCNEJNNIOGA(null)] IECHINKIFLC CFMPPDMGOLP, [LCNEJNNIOGA(null)] NODJGDJJMNJ FPNMOHNEPFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x815A480", Offset = "0x8159280", VA = "0x18815A480", Slot = "44")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x815C180", Offset = "0x815AF80", VA = "0x18815C180")]
	private void PLMLFGCPFAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x815AC10", Offset = "0x8159A10", VA = "0x18815AC10", Slot = "6")]
	public void GEEJLGGNEJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x8159680", Offset = "0x8158480", VA = "0x188159680", Slot = "7")]
	public Task BGJFCKOHALA(long ODEENNIBBLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x815C050", Offset = "0x815AE50", VA = "0x18815C050")]
	[AsyncStateMachine(typeof(IJGMBCLMGDM))]
	private Task PHJAGKNDPKC(long ODEENNIBBLF, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x815AA70", Offset = "0x8159870", VA = "0x18815AA70")]
	private void GDHEAFJOJCN(object JLFLGDNCANL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x815B5B0", Offset = "0x815A3B0", VA = "0x18815B5B0")]
	private void KGMFKMDBIIA(object JLFLGDNCANL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x815BE40", Offset = "0x815AC40", VA = "0x18815BE40")]
	private string OEEJMKHIBJC(string EFIIAIMFFOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x8159440", Offset = "0x8158240", VA = "0x188159440")]
	private void AGPNGKLMDAP(KNIMADMOBAJ MLLHHNOGIPF, string MAKJJJECHHB, [Out] NHBNIILKLEE GMOBINLCDFA, [Out] string KKOBOOMKDKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x815B0C0", Offset = "0x8159EC0", VA = "0x18815B0C0")]
	private NHBNIILKLEE GOCDONNFLOM(KNIMADMOBAJ MLLHHNOGIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x815B630", Offset = "0x815A430", VA = "0x18815B630", Slot = "8")]
	public bool KIKBNMGCMFH(KNIMADMOBAJ MLLHHNOGIPF = KNIMADMOBAJ.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x815BA20", Offset = "0x815A820", VA = "0x18815BA20", Slot = "9")]
	public bool NBHIJAPBIEB(string JDKAHLJOMHL, KNIMADMOBAJ BLMIGFKGFLH = KNIMADMOBAJ.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x815AA90", Offset = "0x8159890", VA = "0x18815AA90", Slot = "10")]
	public bool GDMOOBNFGIA(string JDKAHLJOMHL, KNIMADMOBAJ BLMIGFKGFLH = KNIMADMOBAJ.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x815B490", Offset = "0x815A290", VA = "0x18815B490", Slot = "11")]
	public string JKNFIFPPCJF(string JDKAHLJOMHL, [Optional] string LDGCNLHOBMI, KNIMADMOBAJ BLMIGFKGFLH = KNIMADMOBAJ.CLOUD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x815AF30", Offset = "0x8159D30", VA = "0x18815AF30", Slot = "12")]
	public EMNHEBMJAHK GLCICILCNIB(string JDKAHLJOMHL, string OAIIHELJHLG, KNIMADMOBAJ BLMIGFKGFLH = KNIMADMOBAJ.CLOUD)
	{
		return default(EMNHEBMJAHK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x8159FB0", Offset = "0x8158DB0", VA = "0x188159FB0", Slot = "13")]
	public int CDOBEKJMBMC(string JDKAHLJOMHL, int LDGCNLHOBMI = 0, KNIMADMOBAJ BLMIGFKGFLH = KNIMADMOBAJ.CLOUD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x815A6E0", Offset = "0x81594E0", VA = "0x18815A6E0", Slot = "14")]
	public EMNHEBMJAHK FNHALOBEMHK(string JDKAHLJOMHL, int OAIIHELJHLG, KNIMADMOBAJ BLMIGFKGFLH = KNIMADMOBAJ.CLOUD)
	{
		return default(EMNHEBMJAHK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x815A4C0", Offset = "0x81592C0", VA = "0x18815A4C0", Slot = "15")]
	public bool FELMEKOCIGJ(string JDKAHLJOMHL, bool LDGCNLHOBMI, KNIMADMOBAJ BLMIGFKGFLH = KNIMADMOBAJ.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x8159E30", Offset = "0x8158C30", VA = "0x188159E30", Slot = "16")]
	public EMNHEBMJAHK CDGCILDJMCP(string JDKAHLJOMHL, bool OAIIHELJHLG, KNIMADMOBAJ BLMIGFKGFLH = KNIMADMOBAJ.CLOUD)
	{
		return default(EMNHEBMJAHK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x8159390", Offset = "0x8158190", VA = "0x188159390", Slot = "17")]
	public float AAFNBKGDPPK(string JDKAHLJOMHL, float LDGCNLHOBMI = 0f, KNIMADMOBAJ BLMIGFKGFLH = KNIMADMOBAJ.CLOUD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x8159AD0", Offset = "0x81588D0", VA = "0x188159AD0", Slot = "18")]
	public EMNHEBMJAHK BNONCDKNMCL(string JDKAHLJOMHL, float OAIIHELJHLG, KNIMADMOBAJ BLMIGFKGFLH = KNIMADMOBAJ.CLOUD)
	{
		return default(EMNHEBMJAHK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x815B170", Offset = "0x8159F70", VA = "0x18815B170", Slot = "19")]
	public DateTime HFCDLAIFCFE(string JDKAHLJOMHL, [Optional] DateTime LDGCNLHOBMI, KNIMADMOBAJ BLMIGFKGFLH = KNIMADMOBAJ.CLOUD)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x815AD10", Offset = "0x8159B10", VA = "0x18815AD10", Slot = "20")]
	public EMNHEBMJAHK GJBIOMADAIA(string JDKAHLJOMHL, DateTime OAIIHELJHLG, KNIMADMOBAJ BLMIGFKGFLH = KNIMADMOBAJ.CLOUD)
	{
		return default(EMNHEBMJAHK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x815A860", Offset = "0x8159660", VA = "0x18815A860", Slot = "21")]
	public long GAAFKLABALH(string JDKAHLJOMHL, long LDGCNLHOBMI = 0L, KNIMADMOBAJ BLMIGFKGFLH = KNIMADMOBAJ.CLOUD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x815BC00", Offset = "0x815AA00", VA = "0x18815BC00", Slot = "22")]
	public EMNHEBMJAHK NJPLOECPGOE(string JDKAHLJOMHL, long OAIIHELJHLG, KNIMADMOBAJ BLMIGFKGFLH = KNIMADMOBAJ.CLOUD)
	{
		return default(EMNHEBMJAHK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x39190D0", Offset = "0x3917ED0", VA = "0x1839190D0", Slot = "23")]
	public T APMKPHFFEAF<T>(string JDKAHLJOMHL, [Optional] T LDGCNLHOBMI, KNIMADMOBAJ BLMIGFKGFLH = KNIMADMOBAJ.CLOUD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x39190D0", Offset = "0x3917ED0", VA = "0x1839190D0", Slot = "24")]
	public EMNHEBMJAHK PLBFOAHIDLM<T>(string JDKAHLJOMHL, T OAIIHELJHLG, KNIMADMOBAJ BLMIGFKGFLH = KNIMADMOBAJ.CLOUD)
	{
		return default(EMNHEBMJAHK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x815BD80", Offset = "0x815AB80", VA = "0x18815BD80", Slot = "25")]
	public bool OBDPANCGAOD(string JDKAHLJOMHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x815B530", Offset = "0x815A330", VA = "0x18815B530", Slot = "26")]
	public bool JMPIBEMINBM(string JDKAHLJOMHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x815B540", Offset = "0x815A340", VA = "0x18815B540", Slot = "27")]
	public string JMPMJCPAPKA(string JDKAHLJOMHL, [Optional] string LDGCNLHOBMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x815B210", Offset = "0x815A010", VA = "0x18815B210", Slot = "28")]
	public EMNHEBMJAHK HJMOKHLHMJL(string JDKAHLJOMHL, string OAIIHELJHLG)
	{
		return default(EMNHEBMJAHK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x815B9B0", Offset = "0x815A7B0", VA = "0x18815B9B0", Slot = "29")]
	public int NALDIGJIDHB(string JDKAHLJOMHL, int LDGCNLHOBMI = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x81595E0", Offset = "0x81583E0", VA = "0x1881595E0", Slot = "30")]
	public EMNHEBMJAHK AKFPFFMHHCF(string JDKAHLJOMHL, int OAIIHELJHLG)
	{
		return default(EMNHEBMJAHK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x815AEC0", Offset = "0x8159CC0", VA = "0x18815AEC0", Slot = "31")]
	public bool GKGCEGACBNH(string JDKAHLJOMHL, bool LDGCNLHOBMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x815A450", Offset = "0x8159250", VA = "0x18815A450", Slot = "32")]
	public EMNHEBMJAHK DPMBPHFMLIM(string JDKAHLJOMHL, bool OAIIHELJHLG)
	{
		return default(EMNHEBMJAHK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x815B6F0", Offset = "0x815A4F0", VA = "0x18815B6F0", Slot = "33")]
	public float LAHILGINJHF(string JDKAHLJOMHL, float LDGCNLHOBMI = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x815C1D0", Offset = "0x815AFD0", VA = "0x18815C1D0", Slot = "34")]
	public EMNHEBMJAHK PPAPBNHCDBD(string JDKAHLJOMHL, float OAIIHELJHLG)
	{
		return default(EMNHEBMJAHK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x815B8A0", Offset = "0x815A6A0", VA = "0x18815B8A0", Slot = "35")]
	public DateTime LPOCBPOGIGF(string JDKAHLJOMHL, [Optional] DateTime LDGCNLHOBMI)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x815A2C0", Offset = "0x81590C0", VA = "0x18815A2C0", Slot = "36")]
	public EMNHEBMJAHK DJHMFPJDOCA(string JDKAHLJOMHL, DateTime OAIIHELJHLG)
	{
		return default(EMNHEBMJAHK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x815A250", Offset = "0x8159050", VA = "0x18815A250", Slot = "37")]
	public long DFMJKKAEDJI(string JDKAHLJOMHL, long LDGCNLHOBMI = 0L)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x815B140", Offset = "0x8159F40", VA = "0x18815B140", Slot = "38")]
	public EMNHEBMJAHK GOHCJOFKLOC(string JDKAHLJOMHL, long OAIIHELJHLG)
	{
		return default(EMNHEBMJAHK);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x815BDE0", Offset = "0x815ABE0", VA = "0x18815BDE0")]
	private bool ODEPEJMDEEL(ELHLIGIPIAP GMOBINLCDFA, string JDKAHLJOMHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x815A2F0", Offset = "0x81590F0", VA = "0x18815A2F0")]
	private bool DKFCCJBOGED(ELHLIGIPIAP GMOBINLCDFA, string JDKAHLJOMHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x815A060", Offset = "0x8158E60", VA = "0x18815A060")]
	private EMNHEBMJAHK CJDFNGHIGFC(ELHLIGIPIAP GMOBINLCDFA, string JDKAHLJOMHL, string OAIIHELJHLG)
	{
		return default(EMNHEBMJAHK);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x815B760", Offset = "0x815A560", VA = "0x18815B760")]
	private EMNHEBMJAHK LIIBAFFFAND(ELHLIGIPIAP GMOBINLCDFA, string JDKAHLJOMHL, int OAIIHELJHLG)
	{
		return default(EMNHEBMJAHK);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x815BAC0", Offset = "0x815A8C0", VA = "0x18815BAC0")]
	private EMNHEBMJAHK NGHKACHCKPC(ELHLIGIPIAP GMOBINLCDFA, string JDKAHLJOMHL, bool OAIIHELJHLG)
	{
		return default(EMNHEBMJAHK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x815B240", Offset = "0x815A040", VA = "0x18815B240")]
	private EMNHEBMJAHK ICNDFAPNPJA(ELHLIGIPIAP GMOBINLCDFA, string JDKAHLJOMHL, float OAIIHELJHLG)
	{
		return default(EMNHEBMJAHK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x815A900", Offset = "0x8159700", VA = "0x18815A900")]
	private EMNHEBMJAHK GALIBHFECJE(ELHLIGIPIAP GMOBINLCDFA, string JDKAHLJOMHL, DateTime OAIIHELJHLG)
	{
		return default(EMNHEBMJAHK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x815A5A0", Offset = "0x81593A0", VA = "0x18815A5A0")]
	private EMNHEBMJAHK FHEIDCFKIEB(ELHLIGIPIAP GMOBINLCDFA, string JDKAHLJOMHL, long OAIIHELJHLG)
	{
		return default(EMNHEBMJAHK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x391A190", Offset = "0x3918F90", VA = "0x18391A190")]
	private T KFOIBOFBNNE<T>(ELHLIGIPIAP GMOBINLCDFA, string JDKAHLJOMHL, T LDGCNLHOBMI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x39195A0", Offset = "0x39183A0", VA = "0x1839195A0")]
	private EMNHEBMJAHK KFNPAFMMOJF<T>(ELHLIGIPIAP GMOBINLCDFA, string JDKAHLJOMHL, T OAIIHELJHLG)
	{
		return default(EMNHEBMJAHK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x39194F0", Offset = "0x39182F0", VA = "0x1839194F0", Slot = "39")]
	public void IPEEHDLPLFG<T>(LKFMLKMIODG<T> NPEOPDDENAH, [Optional] IEqualityComparer<T> EDPFJJMAPIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3919470", Offset = "0x3918270", VA = "0x183919470", Slot = "40")]
	public void CJAKHCMNONL<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x815BEA0", Offset = "0x815ACA0", VA = "0x18815BEA0")]
	[AsyncStateMachine(typeof(DDNIKNAGIGJ))]
	private void PAEBNFGIHCG(ELHLIGIPIAP KCGOBOAAIMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x815B390", Offset = "0x815A190", VA = "0x18815B390", Slot = "43")]
	[AsyncStateMachine(typeof(HLJCELBPGPA))]
	public Task IFDCLMANBIA([Optional] CancellationToken JLFLGDNCANL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x8159C50", Offset = "0x8158A50", VA = "0x188159C50")]
	private void BPIICJOGFLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x815BF70", Offset = "0x815AD70", VA = "0x18815BF70", Slot = "41")]
	public IDisposable PCLDOKMGOCG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x815B480", Offset = "0x815A280", VA = "0x18815B480", Slot = "42")]
	public void JCPDDAHFPKK(float POHFDNBLLPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x8159850", Offset = "0x8158650", VA = "0x188159850")]
	private void BIMJFGGDAPF(float KFLBJGGKAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x815AC80", Offset = "0x8159A80", VA = "0x18815AC80")]
	[IteratorStateMachine(typeof(JPPDDCGHHFE))]
	private IEnumerator<GCOFLMDGPIM> GFOBEMDNMNI(float POHFDNBLLPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x815A570", Offset = "0x8159370", VA = "0x18815A570")]
	[CompilerGenerated]
	private void FFDIJFJMBKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class KPKBDDNLGJG : HCLLCDKNBCK<bool>
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static KPKBDDNLGJG ICOFMPPJNFC
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x815D000", Offset = "0x815BE00", VA = "0x18815D000")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x815D2D0", Offset = "0x815C0D0", VA = "0x18815D2D0", Slot = "9")]
	public override string KIDMEGDOMCG(bool DGDLKJDMLAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x815D050", Offset = "0x815BE50", VA = "0x18815D050", Slot = "10")]
	protected override bool HBBCFKILGIC(string DGDLKJDMLAD, [Out] bool OAIIHELJHLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x815D460", Offset = "0x815C260", VA = "0x18815D460")]
	public KPKBDDNLGJG()
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

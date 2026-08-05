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
		[Cpp2IlInjected.Address(RVA = "0x810DC10", Offset = "0x810C610", VA = "0x18810DC10", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2796C60", Offset = "0x2795660", VA = "0x182796C60")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum PJIKJAPLOHM : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	CLOUD,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	DISK
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
internal static class NDEPHFIEKHG
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	internal delegate void JPCNJCNMHIE(PCPNIGIECAB CPJJFIHIAEP);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x810D0A0", Offset = "0x810BAA0", VA = "0x18810D0A0")]
	private static void EKKFNNDFKKB(PCPNIGIECAB CPJJFIHIAEP, JPCNJCNMHIE AJDFKCMMLPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x810CB60", Offset = "0x810B560", VA = "0x18810CB60")]
	public static bool AEDFMHKFAIM(this PCPNIGIECAB CPJJFIHIAEP, string NJOLLKLCOEF, [Optional] JPCNJCNMHIE AJDFKCMMLPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x810CE00", Offset = "0x810B800", VA = "0x18810CE00")]
	public static EJIHFGKFBKD DLLIECDPDCD(this PCPNIGIECAB CPJJFIHIAEP, string NJOLLKLCOEF, string PCDAHJCDHHF, [Optional] JPCNJCNMHIE AJDFKCMMLPB)
	{
		return default(EJIHFGKFBKD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x810CCC0", Offset = "0x810B6C0", VA = "0x18810CCC0")]
	public static EJIHFGKFBKD AJHLABKBILN(this PCPNIGIECAB CPJJFIHIAEP, string NJOLLKLCOEF, int PCDAHJCDHHF, [Optional] JPCNJCNMHIE AJDFKCMMLPB)
	{
		return default(EJIHFGKFBKD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x810D120", Offset = "0x810BB20", VA = "0x18810D120")]
	public static EJIHFGKFBKD FMCOODOCPDD(this PCPNIGIECAB CPJJFIHIAEP, string NJOLLKLCOEF, bool PCDAHJCDHHF, [Optional] JPCNJCNMHIE AJDFKCMMLPB)
	{
		return default(EJIHFGKFBKD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x810CF50", Offset = "0x810B950", VA = "0x18810CF50")]
	public static EJIHFGKFBKD DNMPCMDPIAA(this PCPNIGIECAB CPJJFIHIAEP, string NJOLLKLCOEF, float PCDAHJCDHHF, [Optional] JPCNJCNMHIE AJDFKCMMLPB)
	{
		return default(EJIHFGKFBKD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x810D260", Offset = "0x810BC60", VA = "0x18810D260")]
	public static EJIHFGKFBKD KKEJDIPMMBH(this PCPNIGIECAB CPJJFIHIAEP, string NJOLLKLCOEF, DateTime PCDAHJCDHHF, [Optional] JPCNJCNMHIE AJDFKCMMLPB)
	{
		return default(EJIHFGKFBKD);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x810D3D0", Offset = "0x810BDD0", VA = "0x18810D3D0")]
	public static EJIHFGKFBKD LIFIBPCGDGG(this PCPNIGIECAB CPJJFIHIAEP, string NJOLLKLCOEF, long PCDAHJCDHHF, [Optional] JPCNJCNMHIE AJDFKCMMLPB)
	{
		return default(EJIHFGKFBKD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class DDBIFNCDKHE : FMDDNCLLKAK, PCPNIGIECAB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly KNGKHHLFAPN FHNNJHCBEGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<string, byte> FNNEABELFCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private Dictionary<string, string> DMCELOOPCEJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool ANNFNILDKLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA256B0", Offset = "0xA240B0", VA = "0x180A256B0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Dictionary<string, string> GMEOCJKMPFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8108F10", Offset = "0x8107910", VA = "0x188108F10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action LCAIFGCNODM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x810A9E0", Offset = "0x81093E0", VA = "0x18810A9E0")]
	[UnityEngine.Scripting.Preserve]
	public DDBIFNCDKHE([CNHMBDDCGKB(null)] KNGKHHLFAPN FHNNJHCBEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "8")]
	public void EJKOJJJNKAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x810A050", Offset = "0x8108A50", VA = "0x18810A050")]
	private DirectoryInfo MNLLBFPDCFE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x81092E0", Offset = "0x8107CE0", VA = "0x1881092E0", Slot = "6")]
	public Task KCJOCKPLPCC(long CHNHLFLCABO, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8109200", Offset = "0x8107C00", VA = "0x188109200", Slot = "14")]
	public float GENDHKLLGJN(string KJNEHANBOBO, float ALKDPGOIFPD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8109370", Offset = "0x8107D70", VA = "0x188109370", Slot = "13")]
	public void KHHBNDKAKKM(string KJNEHANBOBO, bool PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x810A1C0", Offset = "0x8108BC0", VA = "0x18810A1C0", Slot = "12")]
	public bool NCFJCMFAIOF(string KJNEHANBOBO, bool ALKDPGOIFPD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8109FE0", Offset = "0x81089E0", VA = "0x188109FE0", Slot = "10")]
	public int MJMDKPOHKJH(string KJNEHANBOBO, int ALKDPGOIFPD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x810A280", Offset = "0x8108C80", VA = "0x18810A280", Slot = "18")]
	public DateTime NLBAKCLDLGC(string NJOLLKLCOEF, [Optional] DateTime ALKDPGOIFPD)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8108EA0", Offset = "0x81078A0", VA = "0x188108EA0", Slot = "19")]
	public void BJPECMOKHIA(string KJNEHANBOBO, DateTime PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8109270", Offset = "0x8107C70", VA = "0x188109270", Slot = "15")]
	public void HIDAJKPOCDF(string KJNEHANBOBO, float PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8109530", Offset = "0x8107F30", VA = "0x188109530", Slot = "11")]
	public void LBNKLLPDKIC(string KJNEHANBOBO, int PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x810A150", Offset = "0x8108B50", VA = "0x18810A150", Slot = "20")]
	public long MPODGEFHBBE(string NJOLLKLCOEF, long ALKDPGOIFPD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8109090", Offset = "0x8107A90", VA = "0x188109090", Slot = "21")]
	public void ENNFHEMOIDM(string NJOLLKLCOEF, long PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x30085C0", Offset = "0x3006FC0", VA = "0x1830085C0", Slot = "22")]
	public T ACBBPJCHKGA<T>(string NJOLLKLCOEF, T ALKDPGOIFPD, FLKJAJBAEIJ<T> OLDMLIGDOND)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x300A420", Offset = "0x3008E20", VA = "0x18300A420", Slot = "23")]
	public void NHOIIIBMFDG<T>(string NJOLLKLCOEF, T PCDAHJCDHHF, FLKJAJBAEIJ<T> OLDMLIGDOND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8108F50", Offset = "0x8107950", VA = "0x188108F50", Slot = "16")]
	public string EBACJPNJKAA(string KJNEHANBOBO, string ALKDPGOIFPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8109D70", Offset = "0x8108770", VA = "0x188109D70", Slot = "17")]
	public void MAOBCIMENNO(string KJNEHANBOBO, string PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x81093E0", Offset = "0x8107DE0", VA = "0x1881093E0", Slot = "24")]
	public void KPMLIKEHCLP(string KJNEHANBOBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8109000", Offset = "0x8107A00", VA = "0x188109000", Slot = "9")]
	public bool EIGJJLAPGNF(string KJNEHANBOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x810A6B0", Offset = "0x81090B0", VA = "0x18810A6B0", Slot = "25")]
	public Task NPPAEEJAPAE(CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x810A2F0", Offset = "0x8108CF0", VA = "0x18810A2F0")]
	private void NMCDFBDKLNG(DirectoryInfo PBLKCFNBEDF, string AGNGALCBKIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8109DE0", Offset = "0x81087E0", VA = "0x188109DE0")]
	private static string MIKOAKPIKDJ(string KJNEHANBOBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8109100", Offset = "0x8107B00", VA = "0x188109100")]
	private static string FNMDPDMBFFN(byte[] OKLLDHNGOMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x38A2EB0", Offset = "0x38A18B0", VA = "0x1838A2EB0")]
	private T IBPMNADNGOO<T>(string NJOLLKLCOEF, T ALKDPGOIFPD, [Optional] FLKJAJBAEIJ<T> MJIHIFGLAJO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x38A1CB0", Offset = "0x38A06B0", VA = "0x1838A1CB0")]
	private void DGDFODDEBEH<T>(string NJOLLKLCOEF, T PCDAHJCDHHF, [Optional] FLKJAJBAEIJ<T> MJIHIFGLAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x81095A0", Offset = "0x8107FA0", VA = "0x1881095A0")]
	private Dictionary<string, string> LCIJIMNLNNJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal static class IMHAEIDGPBF
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x810C600", Offset = "0x810B000", VA = "0x18810C600")]
	[CGLGNCLDKHN.CKJOAALDIOP]
	internal static void JGOIPALGEOO(MHGNCMHMEKD DJGDNAKMFCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class BEMKPPIIFEN : EJFNGKFPPBM
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8105B00", Offset = "0x8104500", VA = "0x188105B00")]
	[UnityEngine.Scripting.Preserve]
	public BEMKPPIIFEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class EJFNGKFPPBM : FMDDNCLLKAK, PCPNIGIECAB, CNGANAHDFKG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<string, object> BNAFCLMGGOO;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool ANNFNILDKLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA256B0", Offset = "0xA240B0", VA = "0x180A256B0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action LCAIFGCNODM
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "8")]
	public void EJKOJJJNKAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x810ADA0", Offset = "0x81097A0", VA = "0x18810ADA0", Slot = "6")]
	public Task KCJOCKPLPCC(long CHNHLFLCABO, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x810AC20", Offset = "0x8109620", VA = "0x18810AC20", Slot = "9")]
	public bool EIGJJLAPGNF(string NJOLLKLCOEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x810AFB0", Offset = "0x81099B0", VA = "0x18810AFB0", Slot = "10")]
	public int MJMDKPOHKJH(string NJOLLKLCOEF, int ALKDPGOIFPD = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x810AEF0", Offset = "0x81098F0", VA = "0x18810AEF0", Slot = "11")]
	public void LBNKLLPDKIC(string NJOLLKLCOEF, int PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x810B070", Offset = "0x8109A70", VA = "0x18810B070", Slot = "12")]
	public bool NCFJCMFAIOF(string NJOLLKLCOEF, bool ALKDPGOIFPD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x810AE30", Offset = "0x8109830", VA = "0x18810AE30", Slot = "13")]
	public void KHHBNDKAKKM(string NJOLLKLCOEF, bool PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x810ACE0", Offset = "0x81096E0", VA = "0x18810ACE0", Slot = "14")]
	public float GENDHKLLGJN(string NJOLLKLCOEF, float ALKDPGOIFPD = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x810AD40", Offset = "0x8109740", VA = "0x18810AD40", Slot = "15")]
	public void HIDAJKPOCDF(string NJOLLKLCOEF, float PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x810ABC0", Offset = "0x81095C0", VA = "0x18810ABC0", Slot = "16")]
	public string EBACJPNJKAA(string NJOLLKLCOEF, [Optional] string ALKDPGOIFPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x810AF50", Offset = "0x8109950", VA = "0x18810AF50", Slot = "17")]
	public void MAOBCIMENNO(string NJOLLKLCOEF, string PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x810B0D0", Offset = "0x8109AD0", VA = "0x18810B0D0", Slot = "18")]
	public DateTime NLBAKCLDLGC(string NJOLLKLCOEF, [Optional] DateTime ALKDPGOIFPD)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x810AB60", Offset = "0x8109560", VA = "0x18810AB60", Slot = "19")]
	public void BJPECMOKHIA(string NJOLLKLCOEF, DateTime PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x810B010", Offset = "0x8109A10", VA = "0x18810B010", Slot = "20")]
	public long MPODGEFHBBE(string NJOLLKLCOEF, long ALKDPGOIFPD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x810AC80", Offset = "0x8109680", VA = "0x18810AC80", Slot = "21")]
	public void ENNFHEMOIDM(string NJOLLKLCOEF, long PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x38F9220", Offset = "0x38F7C20", VA = "0x1838F9220", Slot = "22")]
	public T ACBBPJCHKGA<T>(string NJOLLKLCOEF, T ALKDPGOIFPD, FLKJAJBAEIJ<T> OLDMLIGDOND)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x38FA0B0", Offset = "0x38F8AB0", VA = "0x1838FA0B0", Slot = "23")]
	public void NHOIIIBMFDG<T>(string NJOLLKLCOEF, T PCDAHJCDHHF, FLKJAJBAEIJ<T> OLDMLIGDOND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x38F9810", Offset = "0x38F8210", VA = "0x1838F9810")]
	public T IBPMNADNGOO<T>(string NJOLLKLCOEF, T ALKDPGOIFPD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x38F9320", Offset = "0x38F7D20", VA = "0x1838F9320")]
	public void DGDFODDEBEH<T>(string NJOLLKLCOEF, T PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x810AE90", Offset = "0x8109890", VA = "0x18810AE90", Slot = "24")]
	public void KPMLIKEHCLP(string NJOLLKLCOEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x810B130", Offset = "0x8109B30", VA = "0x18810B130", Slot = "25")]
	public Task NPPAEEJAPAE(CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8105B00", Offset = "0x8104500", VA = "0x188105B00")]
	public EJFNGKFPPBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public abstract class BFFDOKINAEC<TParent> where TParent : PCPNIGIECAB
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly HashSet<BFFDOKINAEC<TParent>> OGLFDJKBDOJ;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6033190", Offset = "0x6031B90", VA = "0x186033190")]
	protected BFFDOKINAEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract void MPMJEFEEPDP();

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void JPCKLFGAIKF(string KJNEHANBOBO);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6032E40", Offset = "0x6031840", VA = "0x186032E40")]
	public static void LHDNKEOOBJC(string KJNEHANBOBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6032C20", Offset = "0x6031620", VA = "0x186032C20")]
	public static void GMEFNOAKAKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class OPJGCIKILAB<TParent, TValue> : BFFDOKINAEC<TParent> where TParent : PCPNIGIECAB
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly OPJGCIKILAB<TParent, TValue> MCHDAMDLAPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, TValue> GLCIKDALFEG;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x56A7EA0", Offset = "0x56A68A0", VA = "0x1856A7EA0")]
	public bool EHEIJGNBGFA(string HFGGEJCIMIJ, [Out] TValue BDLDJILLEEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x56A7EE0", Offset = "0x56A68E0", VA = "0x1856A7EE0")]
	public void MDFCGBOBHJH(string HFGGEJCIMIJ, TValue PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x56A7FE0", Offset = "0x56A69E0", VA = "0x1856A7FE0", Slot = "4")]
	protected override void MPMJEFEEPDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x4DCBC50", Offset = "0x4DCA650", VA = "0x184DCBC50", Slot = "5")]
	protected override void JPCKLFGAIKF(string HFGGEJCIMIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x56A8130", Offset = "0x56A6B30", VA = "0x1856A8130")]
	public OPJGCIKILAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface PCPNIGIECAB
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool ANNFNILDKLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EJKOJJJNKAE();

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool EIGJJLAPGNF(string NJOLLKLCOEF);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int MJMDKPOHKJH(string NJOLLKLCOEF, int ALKDPGOIFPD = 0);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LBNKLLPDKIC(string NJOLLKLCOEF, int PCDAHJCDHHF);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool NCFJCMFAIOF(string NJOLLKLCOEF, bool ALKDPGOIFPD = false);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KHHBNDKAKKM(string NJOLLKLCOEF, bool PCDAHJCDHHF);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	float GENDHKLLGJN(string NJOLLKLCOEF, float ALKDPGOIFPD = 0f);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HIDAJKPOCDF(string NJOLLKLCOEF, float PCDAHJCDHHF);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	string EBACJPNJKAA(string NJOLLKLCOEF, [Optional] string ALKDPGOIFPD);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void MAOBCIMENNO(string NJOLLKLCOEF, string PCDAHJCDHHF);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	DateTime NLBAKCLDLGC(string NJOLLKLCOEF, [Optional] DateTime MGKAFAEPION);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void BJPECMOKHIA(string NJOLLKLCOEF, DateTime MGKAFAEPION);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "13")]
	long MPODGEFHBBE(string NJOLLKLCOEF, long ALKDPGOIFPD);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ENNFHEMOIDM(string NJOLLKLCOEF, long PCDAHJCDHHF);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "15")]
	T ACBBPJCHKGA<T>(string NJOLLKLCOEF, T ALKDPGOIFPD, FLKJAJBAEIJ<T> OLDMLIGDOND);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void NHOIIIBMFDG<T>(string NJOLLKLCOEF, T PCDAHJCDHHF, FLKJAJBAEIJ<T> OLDMLIGDOND);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void KPMLIKEHCLP(string NJOLLKLCOEF);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task NPPAEEJAPAE([Optional] CancellationToken JKPNCAGHEDI);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface FMDDNCLLKAK : PCPNIGIECAB
{
	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action LCAIFGCNODM;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task KCJOCKPLPCC(long CHNHLFLCABO, CancellationToken JKPNCAGHEDI);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface CNGANAHDFKG : PCPNIGIECAB
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class FAGKCFKKDMD : FMDDNCLLKAK, PCPNIGIECAB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct HMOHAKADOEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public FAGKCFKKDMD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x810BC90", Offset = "0x810A690", VA = "0x18810BC90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x810C070", Offset = "0x810AA70", VA = "0x18810C070", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class MLPBHEFGEFM : IEnumerator<HGOIDBIKHMF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private HGOIDBIKHMF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public FAGKCFKKDMD <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private HGOIDBIKHMF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xA12710", Offset = "0xA11110", VA = "0x180A12710")]
		[DebuggerHidden]
		public MLPBHEFGEFM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x810CAA0", Offset = "0x810B4A0", VA = "0x18810CAA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x810CB10", Offset = "0x810B510", VA = "0x18810CB10", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly KNGKHHLFAPN FHNNJHCBEGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool LEKKENNJCNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private bool GPOAPNEOPHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private CJCKCFOBOPF DBBKPFGHGAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private IDJIHHOMEIC FPNHHHODOJO;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool ANNFNILDKLH
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA256B0", Offset = "0xA240B0", VA = "0x180A256B0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action LCAIFGCNODM
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x810B9D0", Offset = "0x810A3D0", VA = "0x18810B9D0")]
	[UnityEngine.Scripting.Preserve]
	public FAGKCFKKDMD([CNHMBDDCGKB(null)] KNGKHHLFAPN FHNNJHCBEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "8")]
	public void EJKOJJJNKAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x810B4E0", Offset = "0x8109EE0", VA = "0x18810B4E0", Slot = "6")]
	public Task KCJOCKPLPCC(long CHNHLFLCABO, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1C36BD0", Offset = "0x1C355D0", VA = "0x181C36BD0")]
	private static int CHEJPDCJKCK(bool PCDAHJCDHHF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x810B3D0", Offset = "0x8109DD0", VA = "0x18810B3D0", Slot = "9")]
	public bool EIGJJLAPGNF(string NJOLLKLCOEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x810B690", Offset = "0x810A090", VA = "0x18810B690", Slot = "10")]
	public int MJMDKPOHKJH(string NJOLLKLCOEF, int ALKDPGOIFPD = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x810B630", Offset = "0x810A030", VA = "0x18810B630", Slot = "11")]
	public void LBNKLLPDKIC(string NJOLLKLCOEF, int PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x810B730", Offset = "0x810A130", VA = "0x18810B730", Slot = "12")]
	public bool NCFJCMFAIOF(string NJOLLKLCOEF, bool ALKDPGOIFPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x810B570", Offset = "0x8109F70", VA = "0x18810B570", Slot = "13")]
	public void KHHBNDKAKKM(string NJOLLKLCOEF, bool PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x810B480", Offset = "0x8109E80", VA = "0x18810B480", Slot = "14")]
	public float GENDHKLLGJN(string NJOLLKLCOEF, float ALKDPGOIFPD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x810B4B0", Offset = "0x8109EB0", VA = "0x18810B4B0", Slot = "15")]
	public void HIDAJKPOCDF(string NJOLLKLCOEF, float PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x810B760", Offset = "0x810A160", VA = "0x18810B760", Slot = "18")]
	public DateTime NLBAKCLDLGC(string NJOLLKLCOEF, [Optional] DateTime ALKDPGOIFPD)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x810B230", Offset = "0x8109C30", VA = "0x18810B230", Slot = "19")]
	public void BJPECMOKHIA(string NJOLLKLCOEF, DateTime MGKAFAEPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x810B6C0", Offset = "0x810A0C0", VA = "0x18810B6C0", Slot = "20")]
	public long MPODGEFHBBE(string NJOLLKLCOEF, long ALKDPGOIFPD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x810B410", Offset = "0x8109E10", VA = "0x18810B410", Slot = "21")]
	public void ENNFHEMOIDM(string NJOLLKLCOEF, long PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3A46210", Offset = "0x3A44C10", VA = "0x183A46210", Slot = "22")]
	public T ACBBPJCHKGA<T>(string NJOLLKLCOEF, T ALKDPGOIFPD, FLKJAJBAEIJ<T> OLDMLIGDOND)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3A46E00", Offset = "0x3A45800", VA = "0x183A46E00", Slot = "23")]
	public void NHOIIIBMFDG<T>(string NJOLLKLCOEF, T PCDAHJCDHHF, FLKJAJBAEIJ<T> OLDMLIGDOND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3A463D0", Offset = "0x3A44DD0", VA = "0x183A463D0")]
	private T NGCAGHCBDPD<T>(string NJOLLKLCOEF, T ALKDPGOIFPD, [Optional] FLKJAJBAEIJ<T> MJIHIFGLAJO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3A46F30", Offset = "0x3A45930", VA = "0x183A46F30")]
	private void ONBMBBHPDPN<T>(string NJOLLKLCOEF, T PCDAHJCDHHF, [Optional] FLKJAJBAEIJ<T> MJIHIFGLAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x810B320", Offset = "0x8109D20", VA = "0x18810B320", Slot = "16")]
	public string EBACJPNJKAA(string NJOLLKLCOEF, string ALKDPGOIFPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x810B660", Offset = "0x810A060", VA = "0x18810B660", Slot = "17")]
	public void MAOBCIMENNO(string NJOLLKLCOEF, string PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x810B300", Offset = "0x8109D00", VA = "0x18810B300")]
	private void DGNHMDPLLMJ(string NJOLLKLCOEF, string PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x810B3F0", Offset = "0x8109DF0", VA = "0x18810B3F0")]
	private string EKOGHEKDBIC(string NJOLLKLCOEF, string ALKDPGOIFPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x810B5A0", Offset = "0x8109FA0", VA = "0x18810B5A0", Slot = "24")]
	public void KPMLIKEHCLP(string NJOLLKLCOEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x810B8C0", Offset = "0x810A2C0", VA = "0x18810B8C0")]
	private string NPPJFLHDADK(string KJNEHANBOBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x810B7D0", Offset = "0x810A1D0", VA = "0x18810B7D0", Slot = "25")]
	[AsyncStateMachine(typeof(HMOHAKADOEF))]
	public Task NPPAEEJAPAE(CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x810B350", Offset = "0x8109D50", VA = "0x18810B350")]
	[IteratorStateMachine(typeof(MLPBHEFGEFM))]
	private IEnumerator<HGOIDBIKHMF> EDADGCIANGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x810B2A0", Offset = "0x8109CA0", VA = "0x18810B2A0")]
	private void DFIGFKBABFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x810B960", Offset = "0x810A360", VA = "0x18810B960")]
	private void ONOGMNDIOKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x810B1C0", Offset = "0x8109BC0", VA = "0x18810B1C0")]
	private void BCNJIPAMJFP(bool AFNAKFIHMNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class BCMPBLJOGDD : FMDDNCLLKAK, PCPNIGIECAB
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
	private Dictionary<string, string> DMCELOOPCEJ;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool ANNFNILDKLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xA256B0", Offset = "0xA240B0", VA = "0x180A256B0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private string AANIHPBPFJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8105580", Offset = "0x8103F80", VA = "0x188105580")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private Dictionary<string, string> GMEOCJKMPFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8104DA0", Offset = "0x81037A0", VA = "0x188104DA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action LCAIFGCNODM
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	[UnityEngine.Scripting.Preserve]
	public BCMPBLJOGDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "8")]
	public void EJKOJJJNKAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x8105070", Offset = "0x8103A70", VA = "0x188105070", Slot = "6")]
	public Task KCJOCKPLPCC(long CHNHLFLCABO, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x8104F90", Offset = "0x8103990", VA = "0x188104F90", Slot = "14")]
	public float GENDHKLLGJN(string KJNEHANBOBO, float ALKDPGOIFPD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x8105100", Offset = "0x8103B00", VA = "0x188105100", Slot = "13")]
	public void KHHBNDKAKKM(string KJNEHANBOBO, bool PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x8105770", Offset = "0x8104170", VA = "0x188105770", Slot = "12")]
	public bool NCFJCMFAIOF(string KJNEHANBOBO, bool ALKDPGOIFPD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x8105690", Offset = "0x8104090", VA = "0x188105690", Slot = "10")]
	public int MJMDKPOHKJH(string KJNEHANBOBO, int ALKDPGOIFPD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x8105830", Offset = "0x8104230", VA = "0x188105830", Slot = "18")]
	public DateTime NLBAKCLDLGC(string NJOLLKLCOEF, [Optional] DateTime ALKDPGOIFPD)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x8104D30", Offset = "0x8103730", VA = "0x188104D30", Slot = "19")]
	public void BJPECMOKHIA(string KJNEHANBOBO, DateTime PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x8105000", Offset = "0x8103A00", VA = "0x188105000", Slot = "15")]
	public void HIDAJKPOCDF(string KJNEHANBOBO, float PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x8105230", Offset = "0x8103C30", VA = "0x188105230", Slot = "11")]
	public void LBNKLLPDKIC(string KJNEHANBOBO, int PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x8105700", Offset = "0x8104100", VA = "0x188105700", Slot = "20")]
	public long MPODGEFHBBE(string NJOLLKLCOEF, long ALKDPGOIFPD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8104F20", Offset = "0x8103920", VA = "0x188104F20", Slot = "21")]
	public void ENNFHEMOIDM(string NJOLLKLCOEF, long PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x30085C0", Offset = "0x3006FC0", VA = "0x1830085C0", Slot = "22")]
	public T ACBBPJCHKGA<T>(string NJOLLKLCOEF, T ALKDPGOIFPD, FLKJAJBAEIJ<T> OLDMLIGDOND)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x300A420", Offset = "0x3008E20", VA = "0x18300A420", Slot = "23")]
	public void NHOIIIBMFDG<T>(string NJOLLKLCOEF, T PCDAHJCDHHF, FLKJAJBAEIJ<T> OLDMLIGDOND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x8104DE0", Offset = "0x81037E0", VA = "0x188104DE0", Slot = "16")]
	public string EBACJPNJKAA(string KJNEHANBOBO, string ALKDPGOIFPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x81055F0", Offset = "0x8103FF0", VA = "0x1881055F0", Slot = "17")]
	public void MAOBCIMENNO(string KJNEHANBOBO, string PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x8105170", Offset = "0x8103B70", VA = "0x188105170", Slot = "24")]
	public void KPMLIKEHCLP(string KJNEHANBOBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x8104E90", Offset = "0x8103890", VA = "0x188104E90", Slot = "9")]
	public bool EIGJJLAPGNF(string KJNEHANBOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x81058A0", Offset = "0x81042A0", VA = "0x1881058A0", Slot = "25")]
	public Task NPPAEEJAPAE(CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x37ECBF0", Offset = "0x37EB5F0", VA = "0x1837ECBF0")]
	private T IBPMNADNGOO<T>(string NJOLLKLCOEF, T ALKDPGOIFPD, [Optional] FLKJAJBAEIJ<T> MJIHIFGLAJO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x37EBCC0", Offset = "0x37EA6C0", VA = "0x1837EBCC0")]
	private void DGDFODDEBEH<T>(string NJOLLKLCOEF, T PCDAHJCDHHF, [Optional] FLKJAJBAEIJ<T> MJIHIFGLAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x81052A0", Offset = "0x8103CA0", VA = "0x1881052A0")]
	private Dictionary<string, string> LCIJIMNLNNJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface IEANCGLMOMK
{
	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action LCAIFGCNODM;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EJKOJJJNKAE();

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task KCBJOJDCANK(long CHNHLFLCABO);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool BONCKICDKGG(PJIKJAPLOHM HJNBAGDAAII = PJIKJAPLOHM.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool PIHHCPDKPDG(string NJOLLKLCOEF, PJIKJAPLOHM CIHFCKAGDFJ = PJIKJAPLOHM.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool PPHPIHBJMNM(string NJOLLKLCOEF, PJIKJAPLOHM CIHFCKAGDFJ = PJIKJAPLOHM.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "7")]
	string FDFDMBLDEKE(string NJOLLKLCOEF, [Optional] string ALKDPGOIFPD, PJIKJAPLOHM CIHFCKAGDFJ = PJIKJAPLOHM.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	EJIHFGKFBKD CBGAIAMIBLK(string NJOLLKLCOEF, string PCDAHJCDHHF, PJIKJAPLOHM CIHFCKAGDFJ = PJIKJAPLOHM.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	int BAABPOPCMOL(string NJOLLKLCOEF, int ALKDPGOIFPD = 0, PJIKJAPLOHM CIHFCKAGDFJ = PJIKJAPLOHM.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	EJIHFGKFBKD OMEPOKAAKDF(string NJOLLKLCOEF, int PCDAHJCDHHF, PJIKJAPLOHM CIHFCKAGDFJ = PJIKJAPLOHM.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool MGAKPAONDDI(string NJOLLKLCOEF, bool ALKDPGOIFPD, PJIKJAPLOHM CIHFCKAGDFJ = PJIKJAPLOHM.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "12")]
	EJIHFGKFBKD NILCBNNBFII(string NJOLLKLCOEF, bool PCDAHJCDHHF, PJIKJAPLOHM CIHFCKAGDFJ = PJIKJAPLOHM.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float NJNOFIDNOKD(string NJOLLKLCOEF, float ALKDPGOIFPD = 0f, PJIKJAPLOHM CIHFCKAGDFJ = PJIKJAPLOHM.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "14")]
	EJIHFGKFBKD MDKECNDAFJG(string NJOLLKLCOEF, float PCDAHJCDHHF, PJIKJAPLOHM CIHFCKAGDFJ = PJIKJAPLOHM.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "15")]
	DateTime EKNHHJHCEPH(string NJOLLKLCOEF, [Optional] DateTime ALKDPGOIFPD, PJIKJAPLOHM CIHFCKAGDFJ = PJIKJAPLOHM.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	EJIHFGKFBKD GFJLJEGIJBE(string NJOLLKLCOEF, DateTime PCDAHJCDHHF, PJIKJAPLOHM CIHFCKAGDFJ = PJIKJAPLOHM.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "17")]
	long OLNHKMNEHML(string NJOLLKLCOEF, long ALKDPGOIFPD = 0L, PJIKJAPLOHM CIHFCKAGDFJ = PJIKJAPLOHM.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "18")]
	EJIHFGKFBKD BADJEEGCIPL(string NJOLLKLCOEF, long PCDAHJCDHHF, PJIKJAPLOHM CIHFCKAGDFJ = PJIKJAPLOHM.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "19")]
	T NGOPFNFPPMD<T>(string NJOLLKLCOEF, [Optional] T ALKDPGOIFPD, PJIKJAPLOHM CIHFCKAGDFJ = PJIKJAPLOHM.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "20")]
	EJIHFGKFBKD LFHPIFAIHKD<T>(string NJOLLKLCOEF, T PCDAHJCDHHF, PJIKJAPLOHM CIHFCKAGDFJ = PJIKJAPLOHM.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool OPGEOEICHOM(string NJOLLKLCOEF);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool EMLGHECDFBE(string NJOLLKLCOEF);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "23")]
	string PFJGBIDEKGG(string NJOLLKLCOEF, [Optional] string ALKDPGOIFPD);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "24")]
	EJIHFGKFBKD FPCDGDEHIIA(string NJOLLKLCOEF, string PCDAHJCDHHF);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "25")]
	int AGGLOMLHELD(string NJOLLKLCOEF, int ALKDPGOIFPD = 0);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "26")]
	EJIHFGKFBKD LMPCDANGDEJ(string NJOLLKLCOEF, int PCDAHJCDHHF);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool PCDBFNKEODC(string NJOLLKLCOEF, bool ALKDPGOIFPD);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "28")]
	EJIHFGKFBKD FJCOLMMBJOK(string NJOLLKLCOEF, bool PCDAHJCDHHF);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "29")]
	float ABAFDLEKLPK(string NJOLLKLCOEF, float ALKDPGOIFPD = 0f);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "30")]
	EJIHFGKFBKD EKLFPAIDEOL(string NJOLLKLCOEF, float PCDAHJCDHHF);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "31")]
	DateTime HKMFBEEIEEA(string NJOLLKLCOEF, [Optional] DateTime ALKDPGOIFPD);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "32")]
	EJIHFGKFBKD LHJLECLHBGC(string NJOLLKLCOEF, DateTime PCDAHJCDHHF);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "33")]
	long EJKLJFADHAO(string NJOLLKLCOEF, long ALKDPGOIFPD = 0L);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "34")]
	EJIHFGKFBKD MDFCDKMDILA(string NJOLLKLCOEF, long PCDAHJCDHHF);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void CLMMGGDDAHF<T>(FLKJAJBAEIJ<T> OLDMLIGDOND, [Optional] IEqualityComparer<T> CHDLIFCANLJ);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void PHOKLCLIGOM<T>();

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "37")]
	IDisposable OKIICCDOMOE();

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void AJEMCPIFGEJ(float CAJJAMECEFA);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task DFIGFKBABFB([Optional] CancellationToken JKPNCAGHEDI);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum EJIHFGKFBKD : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	Unchanged,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	New,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Changed
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class BPHHMMGOLNM : IEANCGLMOMK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private abstract class FCGDEABOKLF
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		protected static readonly HashSet<FCGDEABOKLF> DKPEINKAPEC;

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x810BAC0", Offset = "0x810A4C0", VA = "0x18810BAC0")]
		public static void GMEFNOAKAKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void MPMJEFEEPDP();

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		protected FCGDEABOKLF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private class IANIBOHOCOO<T> : FCGDEABOKLF
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly IANIBOHOCOO<T> FDCAMNOGINK;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public FLKJAJBAEIJ<T> ALNKGDEGFEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0xA0A560", Offset = "0xA08F60", VA = "0x180A0A560")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0xA0A7A0", Offset = "0xA091A0", VA = "0x180A0A7A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public IEqualityComparer<T> BIMCOCMCONM
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0xA0A7B0", Offset = "0xA091B0", VA = "0x180A0A7B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool CEDIBDPPDJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x46834F0", Offset = "0x4681EF0", VA = "0x1846834F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x4DCE030", Offset = "0x4DCCA30", VA = "0x184DCE030")]
		private IANIBOHOCOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x4DCD9A0", Offset = "0x4DCC3A0", VA = "0x184DCD9A0")]
		public void EPIAMCEAEFP(FLKJAJBAEIJ<T> MJIHIFGLAJO, [Optional] IEqualityComparer<T> CHDLIFCANLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x4DCDDC0", Offset = "0x4DCC7C0", VA = "0x184DCDDC0", Slot = "4")]
		public override void MPMJEFEEPDP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private class DDKGLCBMOKD : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private readonly BPHHMMGOLNM AINKEENJLHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly object JPNMPJJDJFM;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x810AAB0", Offset = "0x81094B0", VA = "0x18810AAB0")]
		public DDKGLCBMOKD(BPHHMMGOLNM AINKEENJLHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x810AA80", Offset = "0x8109480", VA = "0x18810AA80", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct MHKDJHGCGAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public BPHHMMGOLNM <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x810C750", Offset = "0x810B150", VA = "0x18810C750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x810CA40", Offset = "0x810B440", VA = "0x18810CA40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct OCNIIKOGABH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public BPHHMMGOLNM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public PCPNIGIECAB backingStoreToSave;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x810D510", Offset = "0x810BF10", VA = "0x18810D510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0xA65B60", Offset = "0xA64560", VA = "0x180A65B60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private struct IBCAALGHIKL : IAsyncStateMachine
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
		public BPHHMMGOLNM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x810C0D0", Offset = "0x810AAD0", VA = "0x18810C0D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x810C5A0", Offset = "0x810AFA0", VA = "0x18810C5A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class CAGACJAOJGH : IEnumerator<HGOIDBIKHMF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private HGOIDBIKHMF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public BPHHMMGOLNM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public float seconds;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private HGOIDBIKHMF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xA12710", Offset = "0xA11110", VA = "0x180A12710")]
		[DebuggerHidden]
		public CAGACJAOJGH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x8108DC0", Offset = "0x81077C0", VA = "0x188108DC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8108E50", Offset = "0x8107850", VA = "0x188108E50", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly FMDDNCLLKAK MNEKNEMPICJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly FMDDNCLLKAK HCINKGAOPFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly CNGANAHDFKG HBKAMJOMBPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly CJCKCFOBOPF DBBKPFGHGAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly NDEPHFIEKHG.JPCNJCNMHIE AJDFKCMMLPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly MJPGDJKBEEA JAIPJCCCMDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly HashSet<PCPNIGIECAB> IPNDKMLOHJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private Task BJFAPADMDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private Dictionary<string, string> NBFILOMDMOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private IDJIHHOMEIC DNNJECHLHAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly object DJJLMPFNDBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly object MHHJHHKMENN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private long PPPBDKKGMGC;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private bool DIOICKALNNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8107AF0", Offset = "0x81064F0", VA = "0x188107AF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private CancellationTokenSource BCBOJMFAAFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xA10570", Offset = "0xA0EF70", VA = "0x180A10570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xA10560", Offset = "0xA0EF60", VA = "0x180A10560")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action LCAIFGCNODM
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8106B50", Offset = "0x8105550", VA = "0x188106B50", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x8106DC0", Offset = "0x81057C0", VA = "0x188106DC0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x8107C60", Offset = "0x8106660", VA = "0x188107C60")]
	[CGLGNCLDKHN.CKJOAALDIOP]
	internal static void NBDHNJGHJEB(MHGNCMHMEKD DJGDNAKMFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x81089F0", Offset = "0x81073F0", VA = "0x1881089F0")]
	[UnityEngine.Scripting.Preserve]
	public BPHHMMGOLNM([CNHMBDDCGKB("Disk")] FMDDNCLLKAK MNEKNEMPICJ, [CNHMBDDCGKB("Cloud")] FMDDNCLLKAK HCINKGAOPFN, [CNHMBDDCGKB(null)] CNGANAHDFKG HBKAMJOMBPK, [CNHMBDDCGKB(null)] CJCKCFOBOPF DBBKPFGHGAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x81068B0", Offset = "0x81052B0", VA = "0x1881068B0", Slot = "44")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x8105E30", Offset = "0x8104830", VA = "0x188105E30")]
	private void AKOLIHPBAKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x8106960", Offset = "0x8105360", VA = "0x188106960", Slot = "6")]
	public void EJKOJJJNKAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x8107360", Offset = "0x8105D60", VA = "0x188107360", Slot = "7")]
	public Task KCBJOJDCANK(long CHNHLFLCABO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x8107070", Offset = "0x8105A70", VA = "0x188107070")]
	[AsyncStateMachine(typeof(MHKDJHGCGAJ))]
	private Task IBFOBNOCBON(long CHNHLFLCABO, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x8107530", Offset = "0x8105F30", VA = "0x188107530")]
	private void LFPCEFDHJNC(object BECBHDDLOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x8108220", Offset = "0x8106C20", VA = "0x188108220")]
	private void OLBKFMCGEOE(object BECBHDDLOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x8106600", Offset = "0x8105000", VA = "0x188106600")]
	private string CFMCPGIMKEG(string AKIBNHMHOJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x8107950", Offset = "0x8106350", VA = "0x188107950")]
	private void MMLIGJFKGEB(PJIKJAPLOHM HJNBAGDAAII, string KJNEHANBOBO, [Out] FMDDNCLLKAK CPJJFIHIAEP, [Out] string IBCDAHPHDGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x81063F0", Offset = "0x8104DF0", VA = "0x1881063F0")]
	private FMDDNCLLKAK BPGBCCHIDGL(PJIKJAPLOHM HJNBAGDAAII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x8106330", Offset = "0x8104D30", VA = "0x188106330", Slot = "8")]
	public bool BONCKICDKGG(PJIKJAPLOHM HJNBAGDAAII = PJIKJAPLOHM.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x81087D0", Offset = "0x81071D0", VA = "0x1881087D0", Slot = "9")]
	public bool PIHHCPDKPDG(string NJOLLKLCOEF, PJIKJAPLOHM CIHFCKAGDFJ = PJIKJAPLOHM.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x8108870", Offset = "0x8107270", VA = "0x188108870", Slot = "10")]
	public bool PPHPIHBJMNM(string NJOLLKLCOEF, PJIKJAPLOHM CIHFCKAGDFJ = PJIKJAPLOHM.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x8106AB0", Offset = "0x81054B0", VA = "0x188106AB0", Slot = "11")]
	public string FDFDMBLDEKE(string NJOLLKLCOEF, [Optional] string ALKDPGOIFPD, PJIKJAPLOHM CIHFCKAGDFJ = PJIKJAPLOHM.CLOUD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x8106470", Offset = "0x8104E70", VA = "0x188106470", Slot = "12")]
	public EJIHFGKFBKD CBGAIAMIBLK(string NJOLLKLCOEF, string PCDAHJCDHHF, PJIKJAPLOHM CIHFCKAGDFJ = PJIKJAPLOHM.CLOUD)
	{
		return default(EJIHFGKFBKD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x8106100", Offset = "0x8104B00", VA = "0x188106100", Slot = "13")]
	public int BAABPOPCMOL(string NJOLLKLCOEF, int ALKDPGOIFPD = 0, PJIKJAPLOHM CIHFCKAGDFJ = PJIKJAPLOHM.CLOUD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x8108340", Offset = "0x8106D40", VA = "0x188108340", Slot = "14")]
	public EJIHFGKFBKD OMEPOKAAKDF(string NJOLLKLCOEF, int PCDAHJCDHHF, PJIKJAPLOHM CIHFCKAGDFJ = PJIKJAPLOHM.CLOUD)
	{
		return default(EJIHFGKFBKD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x81078A0", Offset = "0x81062A0", VA = "0x1881078A0", Slot = "15")]
	public bool MGAKPAONDDI(string NJOLLKLCOEF, bool ALKDPGOIFPD, PJIKJAPLOHM CIHFCKAGDFJ = PJIKJAPLOHM.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x8107E40", Offset = "0x8106840", VA = "0x188107E40", Slot = "16")]
	public EJIHFGKFBKD NILCBNNBFII(string NJOLLKLCOEF, bool PCDAHJCDHHF, PJIKJAPLOHM CIHFCKAGDFJ = PJIKJAPLOHM.CLOUD)
	{
		return default(EJIHFGKFBKD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x8107FC0", Offset = "0x81069C0", VA = "0x188107FC0", Slot = "17")]
	public float NJNOFIDNOKD(string NJOLLKLCOEF, float ALKDPGOIFPD = 0f, PJIKJAPLOHM CIHFCKAGDFJ = PJIKJAPLOHM.CLOUD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x8107720", Offset = "0x8106120", VA = "0x188107720", Slot = "18")]
	public EJIHFGKFBKD MDKECNDAFJG(string NJOLLKLCOEF, float PCDAHJCDHHF, PJIKJAPLOHM CIHFCKAGDFJ = PJIKJAPLOHM.CLOUD)
	{
		return default(EJIHFGKFBKD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x8106A00", Offset = "0x8105400", VA = "0x188106A00", Slot = "19")]
	public DateTime EKNHHJHCEPH(string NJOLLKLCOEF, [Optional] DateTime ALKDPGOIFPD, PJIKJAPLOHM CIHFCKAGDFJ = PJIKJAPLOHM.CLOUD)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x8106E60", Offset = "0x8105860", VA = "0x188106E60", Slot = "20")]
	public EJIHFGKFBKD GFJLJEGIJBE(string NJOLLKLCOEF, DateTime PCDAHJCDHHF, PJIKJAPLOHM CIHFCKAGDFJ = PJIKJAPLOHM.CLOUD)
	{
		return default(EJIHFGKFBKD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x81082A0", Offset = "0x8106CA0", VA = "0x1881082A0", Slot = "21")]
	public long OLNHKMNEHML(string NJOLLKLCOEF, long ALKDPGOIFPD = 0L, PJIKJAPLOHM CIHFCKAGDFJ = PJIKJAPLOHM.CLOUD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x81061B0", Offset = "0x8104BB0", VA = "0x1881061B0", Slot = "22")]
	public EJIHFGKFBKD BADJEEGCIPL(string NJOLLKLCOEF, long PCDAHJCDHHF, PJIKJAPLOHM CIHFCKAGDFJ = PJIKJAPLOHM.CLOUD)
	{
		return default(EJIHFGKFBKD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x37F7BA0", Offset = "0x37F65A0", VA = "0x1837F7BA0", Slot = "23")]
	public T NGOPFNFPPMD<T>(string NJOLLKLCOEF, [Optional] T ALKDPGOIFPD, PJIKJAPLOHM CIHFCKAGDFJ = PJIKJAPLOHM.CLOUD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x37F7BA0", Offset = "0x37F65A0", VA = "0x1837F7BA0", Slot = "24")]
	public EJIHFGKFBKD LFHPIFAIHKD<T>(string NJOLLKLCOEF, T PCDAHJCDHHF, PJIKJAPLOHM CIHFCKAGDFJ = PJIKJAPLOHM.CLOUD)
	{
		return default(EJIHFGKFBKD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x8108550", Offset = "0x8106F50", VA = "0x188108550", Slot = "25")]
	public bool OPGEOEICHOM(string NJOLLKLCOEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x8106AA0", Offset = "0x81054A0", VA = "0x188106AA0", Slot = "26")]
	public bool EMLGHECDFBE(string NJOLLKLCOEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x8108760", Offset = "0x8107160", VA = "0x188108760", Slot = "27")]
	public string PFJGBIDEKGG(string NJOLLKLCOEF, [Optional] string ALKDPGOIFPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x8106D90", Offset = "0x8105790", VA = "0x188106D90", Slot = "28")]
	public EJIHFGKFBKD FPCDGDEHIIA(string NJOLLKLCOEF, string PCDAHJCDHHF)
	{
		return default(EJIHFGKFBKD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x8105D50", Offset = "0x8104750", VA = "0x188105D50", Slot = "29")]
	public int AGGLOMLHELD(string NJOLLKLCOEF, int ALKDPGOIFPD = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x81076C0", Offset = "0x81060C0", VA = "0x1881076C0", Slot = "30")]
	public EJIHFGKFBKD LMPCDANGDEJ(string NJOLLKLCOEF, int PCDAHJCDHHF)
	{
		return default(EJIHFGKFBKD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x81085B0", Offset = "0x8106FB0", VA = "0x1881085B0", Slot = "31")]
	public bool PCDBFNKEODC(string NJOLLKLCOEF, bool ALKDPGOIFPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x8106D30", Offset = "0x8105730", VA = "0x188106D30", Slot = "32")]
	public EJIHFGKFBKD FJCOLMMBJOK(string NJOLLKLCOEF, bool PCDAHJCDHHF)
	{
		return default(EJIHFGKFBKD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x8105B90", Offset = "0x8104590", VA = "0x188105B90", Slot = "33")]
	public float ABAFDLEKLPK(string NJOLLKLCOEF, float ALKDPGOIFPD = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x81069D0", Offset = "0x81053D0", VA = "0x1881069D0", Slot = "34")]
	public EJIHFGKFBKD EKLFPAIDEOL(string NJOLLKLCOEF, float PCDAHJCDHHF)
	{
		return default(EJIHFGKFBKD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x8107000", Offset = "0x8105A00", VA = "0x188107000", Slot = "35")]
	public DateTime HKMFBEEIEEA(string NJOLLKLCOEF, [Optional] DateTime ALKDPGOIFPD)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x8107550", Offset = "0x8105F50", VA = "0x188107550", Slot = "36")]
	public EJIHFGKFBKD LHJLECLHBGC(string NJOLLKLCOEF, DateTime PCDAHJCDHHF)
	{
		return default(EJIHFGKFBKD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x81068F0", Offset = "0x81052F0", VA = "0x1881068F0", Slot = "37")]
	public long EJKLJFADHAO(string NJOLLKLCOEF, long ALKDPGOIFPD = 0L)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x81076F0", Offset = "0x81060F0", VA = "0x1881076F0", Slot = "38")]
	public EJIHFGKFBKD MDFCDKMDILA(string NJOLLKLCOEF, long PCDAHJCDHHF)
	{
		return default(EJIHFGKFBKD);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x8105DD0", Offset = "0x81047D0", VA = "0x188105DD0")]
	private bool AJJBOIPDBKN(PCPNIGIECAB CPJJFIHIAEP, string NJOLLKLCOEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x8106660", Offset = "0x8105060", VA = "0x188106660")]
	private bool DAKIAKOLMML(PCPNIGIECAB CPJJFIHIAEP, string NJOLLKLCOEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x8107B10", Offset = "0x8106510", VA = "0x188107B10")]
	private EJIHFGKFBKD NAFFPIKJGNA(PCPNIGIECAB CPJJFIHIAEP, string NJOLLKLCOEF, string PCDAHJCDHHF)
	{
		return default(EJIHFGKFBKD);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x8107580", Offset = "0x8105F80", VA = "0x188107580")]
	private EJIHFGKFBKD LMPAENNBKDO(PCPNIGIECAB CPJJFIHIAEP, string NJOLLKLCOEF, int PCDAHJCDHHF)
	{
		return default(EJIHFGKFBKD);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x8106BF0", Offset = "0x81055F0", VA = "0x188106BF0")]
	private EJIHFGKFBKD FIOMELHNFCK(PCPNIGIECAB CPJJFIHIAEP, string NJOLLKLCOEF, bool PCDAHJCDHHF)
	{
		return default(EJIHFGKFBKD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x8105C00", Offset = "0x8104600", VA = "0x188105C00")]
	private EJIHFGKFBKD AFFKHEKDKLM(PCPNIGIECAB CPJJFIHIAEP, string NJOLLKLCOEF, float PCDAHJCDHHF)
	{
		return default(EJIHFGKFBKD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x8107CD0", Offset = "0x81066D0", VA = "0x188107CD0")]
	private EJIHFGKFBKD NBKGFNBCKFK(PCPNIGIECAB CPJJFIHIAEP, string NJOLLKLCOEF, DateTime PCDAHJCDHHF)
	{
		return default(EJIHFGKFBKD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x8108620", Offset = "0x8107020", VA = "0x188108620")]
	private EJIHFGKFBKD PEELMEAHFKO(PCPNIGIECAB CPJJFIHIAEP, string NJOLLKLCOEF, long PCDAHJCDHHF)
	{
		return default(EJIHFGKFBKD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x37F7D40", Offset = "0x37F6740", VA = "0x1837F7D40")]
	private T LIJKFLACLCB<T>(PCPNIGIECAB CPJJFIHIAEP, string NJOLLKLCOEF, T ALKDPGOIFPD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x37F7000", Offset = "0x37F5A00", VA = "0x1837F7000")]
	private EJIHFGKFBKD CJKLFPCDMKD<T>(PCPNIGIECAB CPJJFIHIAEP, string NJOLLKLCOEF, T PCDAHJCDHHF)
	{
		return default(EJIHFGKFBKD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x37F7B10", Offset = "0x37F6510", VA = "0x1837F7B10", Slot = "39")]
	public void CLMMGGDDAHF<T>(FLKJAJBAEIJ<T> OLDMLIGDOND, [Optional] IEqualityComparer<T> CHDLIFCANLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x37F83C0", Offset = "0x37F6DC0", VA = "0x1837F83C0", Slot = "40")]
	public void PHOKLCLIGOM<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x8108070", Offset = "0x8106A70", VA = "0x188108070")]
	[AsyncStateMachine(typeof(OCNIIKOGABH))]
	private void NPPAEEJAPAE(PCPNIGIECAB LGMCGCPDBIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x81067C0", Offset = "0x81051C0", VA = "0x1881067C0", Slot = "43")]
	[AsyncStateMachine(typeof(IBCAALGHIKL))]
	public Task DFIGFKBABFB([Optional] CancellationToken BECBHDDLOHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x8107180", Offset = "0x8105B80", VA = "0x188107180")]
	private void JFMIEEHGACP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x8108140", Offset = "0x8106B40", VA = "0x188108140", Slot = "41")]
	public IDisposable OKIICCDOMOE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x8105DC0", Offset = "0x81047C0", VA = "0x188105DC0", Slot = "42")]
	public void AJEMCPIFGEJ(float CAJJAMECEFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x8105E80", Offset = "0x8104880", VA = "0x188105E80")]
	private void ALGCDKFCBKN(float KJCOJPLAPGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x81084C0", Offset = "0x8106EC0", VA = "0x1881084C0")]
	[IteratorStateMachine(typeof(CAGACJAOJGH))]
	private IEnumerator<HGOIDBIKHMF> OOAGDNGPFIA(float CAJJAMECEFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x8106D60", Offset = "0x8105760", VA = "0x188106D60")]
	[CompilerGenerated]
	private void FJEMDAONHHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class ONPPMEGFNGC : ECGDEBMFEJP<bool>
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static ONPPMEGFNGC FDCAMNOGINK
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x810D920", Offset = "0x810C320", VA = "0x18810D920")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x810D970", Offset = "0x810C370", VA = "0x18810D970", Slot = "9")]
	public override string PGPOMLMDCHO(bool OKFHNJPHDOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x810D6A0", Offset = "0x810C0A0", VA = "0x18810D6A0", Slot = "10")]
	protected override bool DAGDAPHHHDL(string OKFHNJPHDOP, [Out] bool PCDAHJCDHHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x810DAF0", Offset = "0x810C4F0", VA = "0x18810DAF0")]
	public ONPPMEGFNGC()
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

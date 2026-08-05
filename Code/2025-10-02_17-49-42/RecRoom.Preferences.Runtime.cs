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
using Microsoft.CodeAnalysis;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x88DA3A0", Offset = "0x88D8DA0", VA = "0x1888DA3A0")]
		public NullableAttribute(byte P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAD8600", Offset = "0xAD7000", VA = "0x180AD8600")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Preferences_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x88DAE10", Offset = "0x88D9810", VA = "0x1888DAE10", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x29CDED0", Offset = "0x29CC8D0", VA = "0x1829CDED0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum EGEFIPLILMI : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	CLOUD,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	DISK
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal static class HNMLCMDKEOJ
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal delegate void OPCNNKKKIOH(BBJILJGIOBH ADAENKCNBKF);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x88D33C0", Offset = "0x88D1DC0", VA = "0x1888D33C0")]
	private static void JJLILPCJEOK(BBJILJGIOBH ADAENKCNBKF, OPCNNKKKIOH OILMMGDAFJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x88D2E80", Offset = "0x88D1880", VA = "0x1888D2E80")]
	public static bool CGJNCFLIBFK(this BBJILJGIOBH ADAENKCNBKF, string BIHHMEFECFM, [Optional] OPCNNKKKIOH OILMMGDAFJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x88D3270", Offset = "0x88D1C70", VA = "0x1888D3270")]
	public static MINJHHBFOJA IMINNAMOPEC(this BBJILJGIOBH ADAENKCNBKF, string BIHHMEFECFM, string KMAFNKGMDCF, [Optional] OPCNNKKKIOH OILMMGDAFJI)
	{
		return default(MINJHHBFOJA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x88D3580", Offset = "0x88D1F80", VA = "0x1888D3580")]
	public static MINJHHBFOJA NLECFBCAPDD(this BBJILJGIOBH ADAENKCNBKF, string BIHHMEFECFM, int KMAFNKGMDCF, [Optional] OPCNNKKKIOH OILMMGDAFJI)
	{
		return default(MINJHHBFOJA);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x88D2FE0", Offset = "0x88D19E0", VA = "0x1888D2FE0")]
	public static MINJHHBFOJA GBFMOFMFJIC(this BBJILJGIOBH ADAENKCNBKF, string BIHHMEFECFM, bool KMAFNKGMDCF, [Optional] OPCNNKKKIOH OILMMGDAFJI)
	{
		return default(MINJHHBFOJA);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x88D3120", Offset = "0x88D1B20", VA = "0x1888D3120")]
	public static MINJHHBFOJA ICFBKDKOLNM(this BBJILJGIOBH ADAENKCNBKF, string BIHHMEFECFM, float KMAFNKGMDCF, [Optional] OPCNNKKKIOH OILMMGDAFJI)
	{
		return default(MINJHHBFOJA);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x88D36C0", Offset = "0x88D20C0", VA = "0x1888D36C0")]
	public static MINJHHBFOJA OEEPPBFDIGJ(this BBJILJGIOBH ADAENKCNBKF, string BIHHMEFECFM, DateTime KMAFNKGMDCF, [Optional] OPCNNKKKIOH OILMMGDAFJI)
	{
		return default(MINJHHBFOJA);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x88D3440", Offset = "0x88D1E40", VA = "0x1888D3440")]
	public static MINJHHBFOJA MDJEIBNKGLC(this BBJILJGIOBH ADAENKCNBKF, string BIHHMEFECFM, long KMAFNKGMDCF, [Optional] OPCNNKKKIOH OILMMGDAFJI)
	{
		return default(MINJHHBFOJA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class IBKPNKDKAGE : NELKDLJMAJF, BBJILJGIOBH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly JJMGGIPAAOC MNEMIAIJIKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<string, byte> MMPOGKFKIEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private Dictionary<string, string> CGPKLINALIG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool FHLCJJBHDMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xAC8240", Offset = "0xAC6C40", VA = "0x180AC8240", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Dictionary<string, string> IOPLCEKOPCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x88D3F10", Offset = "0x88D2910", VA = "0x1888D3F10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action BABOGPKIGPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x88D57D0", Offset = "0x88D41D0", VA = "0x1888D57D0")]
	[UnityEngine.Scripting.Preserve]
	public IBKPNKDKAGE([BMCONCJPCIA(null)] JJMGGIPAAOC MNEMIAIJIKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "8")]
	public void KCCGOIBALIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x88D48D0", Offset = "0x88D32D0", VA = "0x1888D48D0")]
	private DirectoryInfo LHBLGNNLIKG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x88D45F0", Offset = "0x88D2FF0", VA = "0x1888D45F0", Slot = "6")]
	public Task KMJNLNJOEOC(long AAPIKGHGGHH, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x88D4DE0", Offset = "0x88D37E0", VA = "0x1888D4DE0", Slot = "14")]
	public float NAANBCKCMPE(string HPFHOBCPNEF, float KJMOBDOKFBF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x88D3E30", Offset = "0x88D2830", VA = "0x1888D3E30", Slot = "13")]
	public void EHDEODPBOBM(string HPFHOBCPNEF, bool KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x88D49D0", Offset = "0x88D33D0", VA = "0x1888D49D0", Slot = "12")]
	public bool MNLLJDJONLE(string HPFHOBCPNEF, bool KJMOBDOKFBF = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x88D3CE0", Offset = "0x88D26E0", VA = "0x1888D3CE0", Slot = "10")]
	public int ADKFKLHDKCO(string HPFHOBCPNEF, int KJMOBDOKFBF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x88D3DC0", Offset = "0x88D27C0", VA = "0x1888D3DC0", Slot = "18")]
	public DateTime BIGJICEOCHM(string BIHHMEFECFM, [Optional] DateTime KJMOBDOKFBF)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x88D3EA0", Offset = "0x88D28A0", VA = "0x1888D3EA0", Slot = "19")]
	public void FIHGDJILMNL(string HPFHOBCPNEF, DateTime KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x88D3D50", Offset = "0x88D2750", VA = "0x1888D3D50", Slot = "15")]
	public void AGDLCINDKCG(string HPFHOBCPNEF, float KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x88D3F50", Offset = "0x88D2950", VA = "0x1888D3F50", Slot = "11")]
	public void HHAOFABEGAA(string HPFHOBCPNEF, int KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x88D4E50", Offset = "0x88D3850", VA = "0x1888D4E50", Slot = "20")]
	public long OBILMEDGFHB(string BIHHMEFECFM, long KJMOBDOKFBF)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x88D3C70", Offset = "0x88D2670", VA = "0x1888D3C70", Slot = "21")]
	public void ABOHGJPEFPD(string BIHHMEFECFM, long KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3DEB7A0", Offset = "0x3DEA1A0", VA = "0x183DEB7A0", Slot = "22")]
	public T NKGLDGAFKGA<T>(string BIHHMEFECFM, T KJMOBDOKFBF, ODMLNBEIIKD<T> JPKDLICIJEA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3DEB700", Offset = "0x3DEA100", VA = "0x183DEB700", Slot = "23")]
	public void INOOKCKOMOO<T>(string BIHHMEFECFM, T KMAFNKGMDCF, ODMLNBEIIKD<T> JPKDLICIJEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x88D5720", Offset = "0x88D4120", VA = "0x1888D5720", Slot = "16")]
	public string PBDJEFHBIMG(string HPFHOBCPNEF, string KJMOBDOKFBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x88D4580", Offset = "0x88D2F80", VA = "0x1888D4580", Slot = "17")]
	public void KGBGLNMAOAK(string HPFHOBCPNEF, string KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x88D4680", Offset = "0x88D3080", VA = "0x1888D4680", Slot = "24")]
	public void KOKCOKMODHF(string HPFHOBCPNEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x88D5690", Offset = "0x88D4090", VA = "0x1888D5690", Slot = "9")]
	public bool PBANNOABGEP(string HPFHOBCPNEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x88D4AA0", Offset = "0x88D34A0", VA = "0x1888D4AA0", Slot = "25")]
	public Task MNMGILKBLNG(CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x88D3FC0", Offset = "0x88D29C0", VA = "0x1888D3FC0")]
	private void JIBIOHNENMM(DirectoryInfo MOCPDCDIMBG, string FANAJACBNDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x88D4380", Offset = "0x88D2D80", VA = "0x1888D4380")]
	private static string JOFIDIPEGOC(string HPFHOBCPNEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x88D47D0", Offset = "0x88D31D0", VA = "0x1888D47D0")]
	private static string LELPGLEKJCN(byte[] BNICMFHPCJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3DEA5C0", Offset = "0x3DE8FC0", VA = "0x183DEA5C0")]
	private T GFFPJLNAMHB<T>(string BIHHMEFECFM, T KJMOBDOKFBF, [Optional] ODMLNBEIIKD<T> NMNKOOLBDMM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3DE9390", Offset = "0x3DE7D90", VA = "0x183DE9390")]
	private void FNAEMEPGHFK<T>(string BIHHMEFECFM, T KMAFNKGMDCF, [Optional] ODMLNBEIIKD<T> NMNKOOLBDMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x88D4EC0", Offset = "0x88D38C0", VA = "0x1888D4EC0")]
	private Dictionary<string, string> PAKMMIAPLAN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal static class DAGBKBOCKHK
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x88D25B0", Offset = "0x88D0FB0", VA = "0x1888D25B0")]
	[DMKNBLIJJON.EGFDFBOLNDK]
	internal static void HFPMPAAENFC(JBJKIIKOACK KLIEGJHNGPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class MGOAOOKKMJG : CNLGNAOOLIM
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x88D2520", Offset = "0x88D0F20", VA = "0x1888D2520")]
	[UnityEngine.Scripting.Preserve]
	public MGOAOOKKMJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class CNLGNAOOLIM : NELKDLJMAJF, BBJILJGIOBH, JAMLMMEEJEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Dictionary<string, object> OFMDJHJFJJM;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool FHLCJJBHDMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xAC8240", Offset = "0xAC6C40", VA = "0x180AC8240", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action BABOGPKIGPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "8")]
	public void KCCGOIBALIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x88D21C0", Offset = "0x88D0BC0", VA = "0x1888D21C0", Slot = "6")]
	public Task KMJNLNJOEOC(long AAPIKGHGGHH, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x88D2460", Offset = "0x88D0E60", VA = "0x1888D2460", Slot = "9")]
	public bool PBANNOABGEP(string BIHHMEFECFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x88D1F20", Offset = "0x88D0920", VA = "0x1888D1F20", Slot = "10")]
	public int ADKFKLHDKCO(string BIHHMEFECFM, int KJMOBDOKFBF = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x88D2100", Offset = "0x88D0B00", VA = "0x1888D2100", Slot = "11")]
	public void HHAOFABEGAA(string BIHHMEFECFM, int KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x88D22B0", Offset = "0x88D0CB0", VA = "0x1888D22B0", Slot = "12")]
	public bool MNLLJDJONLE(string BIHHMEFECFM, bool KJMOBDOKFBF = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x88D2040", Offset = "0x88D0A40", VA = "0x1888D2040", Slot = "13")]
	public void EHDEODPBOBM(string BIHHMEFECFM, bool KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x88D23A0", Offset = "0x88D0DA0", VA = "0x1888D23A0", Slot = "14")]
	public float NAANBCKCMPE(string BIHHMEFECFM, float KJMOBDOKFBF = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x88D1F80", Offset = "0x88D0980", VA = "0x1888D1F80", Slot = "15")]
	public void AGDLCINDKCG(string BIHHMEFECFM, float KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x88D24C0", Offset = "0x88D0EC0", VA = "0x1888D24C0", Slot = "16")]
	public string PBDJEFHBIMG(string BIHHMEFECFM, [Optional] string KJMOBDOKFBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x88D2160", Offset = "0x88D0B60", VA = "0x1888D2160", Slot = "17")]
	public void KGBGLNMAOAK(string BIHHMEFECFM, string KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x88D1FE0", Offset = "0x88D09E0", VA = "0x1888D1FE0", Slot = "18")]
	public DateTime BIGJICEOCHM(string BIHHMEFECFM, [Optional] DateTime KJMOBDOKFBF)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x88D20A0", Offset = "0x88D0AA0", VA = "0x1888D20A0", Slot = "19")]
	public void FIHGDJILMNL(string BIHHMEFECFM, DateTime KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x88D2400", Offset = "0x88D0E00", VA = "0x1888D2400", Slot = "20")]
	public long OBILMEDGFHB(string BIHHMEFECFM, long KJMOBDOKFBF)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x88D1EC0", Offset = "0x88D08C0", VA = "0x1888D1EC0", Slot = "21")]
	public void ABOHGJPEFPD(string BIHHMEFECFM, long KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3B90450", Offset = "0x3B8EE50", VA = "0x183B90450", Slot = "22")]
	public T NKGLDGAFKGA<T>(string BIHHMEFECFM, T KJMOBDOKFBF, ODMLNBEIIKD<T> JPKDLICIJEA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3B903B0", Offset = "0x3B8EDB0", VA = "0x183B903B0", Slot = "23")]
	public void INOOKCKOMOO<T>(string BIHHMEFECFM, T KMAFNKGMDCF, ODMLNBEIIKD<T> JPKDLICIJEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3B8FB70", Offset = "0x3B8E570", VA = "0x183B8FB70")]
	public T GFFPJLNAMHB<T>(string BIHHMEFECFM, T KJMOBDOKFBF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3B8F680", Offset = "0x3B8E080", VA = "0x183B8F680")]
	public void FNAEMEPGHFK<T>(string BIHHMEFECFM, T KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x88D2250", Offset = "0x88D0C50", VA = "0x1888D2250", Slot = "24")]
	public void KOKCOKMODHF(string BIHHMEFECFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x88D2310", Offset = "0x88D0D10", VA = "0x1888D2310", Slot = "25")]
	public Task MNMGILKBLNG(CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x88D2520", Offset = "0x88D0F20", VA = "0x1888D2520")]
	public CNLGNAOOLIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class IGCJOKDJOCE<TParent> where TParent : BBJILJGIOBH
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly HashSet<IGCJOKDJOCE<TParent>> GFLOBGIMOIO;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x52E4400", Offset = "0x52E2E00", VA = "0x1852E4400")]
	protected IGCJOKDJOCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract void EMMOLKMNHIK();

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void KIIEBKLAMLA(string HPFHOBCPNEF);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x52E4090", Offset = "0x52E2A90", VA = "0x1852E4090")]
	public static void JFEDJFOGJOC(string HPFHOBCPNEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x52E3E60", Offset = "0x52E2860", VA = "0x1852E3E60")]
	public static void HKNHMIPLHFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class FODOPFLCIBL<TParent, TValue> : IGCJOKDJOCE<TParent> where TParent : BBJILJGIOBH
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly FODOPFLCIBL<TParent, TValue> IIDHIFPMCOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Dictionary<string, TValue> JIENGADPHDH;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x50116D0", Offset = "0x50100D0", VA = "0x1850116D0")]
	public bool BMFHANOLGIO(string JLGLJMOGAHI, [Out] TValue MEMEJBJJBPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x50117E0", Offset = "0x50101E0", VA = "0x1850117E0")]
	public void FMNGLKGJINK(string JLGLJMOGAHI, TValue KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5011710", Offset = "0x5010110", VA = "0x185011710", Slot = "4")]
	protected override void EMMOLKMNHIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5011840", Offset = "0x5010240", VA = "0x185011840", Slot = "5")]
	protected override void KIIEBKLAMLA(string JLGLJMOGAHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x50119A0", Offset = "0x50103A0", VA = "0x1850119A0")]
	public FODOPFLCIBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface BBJILJGIOBH
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool FHLCJJBHDMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KCCGOIBALIC();

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PBANNOABGEP(string BIHHMEFECFM);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int ADKFKLHDKCO(string BIHHMEFECFM, int KJMOBDOKFBF = 0);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HHAOFABEGAA(string BIHHMEFECFM, int KMAFNKGMDCF);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool MNLLJDJONLE(string BIHHMEFECFM, bool KJMOBDOKFBF = false);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EHDEODPBOBM(string BIHHMEFECFM, bool KMAFNKGMDCF);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	float NAANBCKCMPE(string BIHHMEFECFM, float KJMOBDOKFBF = 0f);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void AGDLCINDKCG(string BIHHMEFECFM, float KMAFNKGMDCF);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	string PBDJEFHBIMG(string BIHHMEFECFM, [Optional] string KJMOBDOKFBF);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void KGBGLNMAOAK(string BIHHMEFECFM, string KMAFNKGMDCF);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "11")]
	DateTime BIGJICEOCHM(string BIHHMEFECFM, [Optional] DateTime PNMBHMMEFCI);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void FIHGDJILMNL(string BIHHMEFECFM, DateTime PNMBHMMEFCI);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "13")]
	long OBILMEDGFHB(string BIHHMEFECFM, long KJMOBDOKFBF);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ABOHGJPEFPD(string BIHHMEFECFM, long KMAFNKGMDCF);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "15")]
	T NKGLDGAFKGA<T>(string BIHHMEFECFM, T KJMOBDOKFBF, ODMLNBEIIKD<T> JPKDLICIJEA);

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void INOOKCKOMOO<T>(string BIHHMEFECFM, T KMAFNKGMDCF, ODMLNBEIIKD<T> JPKDLICIJEA);

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void KOKCOKMODHF(string BIHHMEFECFM);

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task MNMGILKBLNG([Optional] CancellationToken AHOMALKMHKK);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface NELKDLJMAJF : BBJILJGIOBH
{
	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action BABOGPKIGPA;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task KMJNLNJOEOC(long AAPIKGHGGHH, CancellationToken AHOMALKMHKK);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface JAMLMMEEJEF : BBJILJGIOBH
{
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class OFCLLMEPJJH : NELKDLJMAJF, BBJILJGIOBH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct HPNGFDONLIH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public OFCLLMEPJJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x88D3830", Offset = "0x88D2230", VA = "0x1888D3830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x88D3C10", Offset = "0x88D2610", VA = "0x1888D3C10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class FOHDJBBOJJF : IEnumerator<JFFMJDIOLAN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private JFFMJDIOLAN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public OFCLLMEPJJH <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private JFFMJDIOLAN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xAB33A0", Offset = "0xAB1DA0", VA = "0x180AB33A0")]
		[DebuggerHidden]
		public FOHDJBBOJJF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x88D2DC0", Offset = "0x88D17C0", VA = "0x1888D2DC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x88D2E30", Offset = "0x88D1830", VA = "0x1888D2E30", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly JJMGGIPAAOC MNEMIAIJIKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool HPKMLBEJMHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private bool NHCEFEBCADJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private BCONDBBGDGF JEHAFCLHOLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private LCOHCCBKPLJ OOPHFNDPFDF;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool FHLCJJBHDMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xAC8240", Offset = "0xAC6C40", VA = "0x180AC8240", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action BABOGPKIGPA
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x88DAC30", Offset = "0x88D9630", VA = "0x1888DAC30")]
	[UnityEngine.Scripting.Preserve]
	public OFCLLMEPJJH([BMCONCJPCIA(null)] JJMGGIPAAOC MNEMIAIJIKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "8")]
	public void KCCGOIBALIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x88DA7C0", Offset = "0x88D91C0", VA = "0x1888DA7C0", Slot = "6")]
	public Task KMJNLNJOEOC(long AAPIKGHGGHH, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x1E7AF50", Offset = "0x1E79950", VA = "0x181E7AF50")]
	private static int FFMBGMKCGPJ(bool KMAFNKGMDCF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x88DAB40", Offset = "0x88D9540", VA = "0x1888DAB40", Slot = "9")]
	public bool PBANNOABGEP(string BIHHMEFECFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x88DA490", Offset = "0x88D8E90", VA = "0x1888DA490", Slot = "10")]
	public int ADKFKLHDKCO(string BIHHMEFECFM, int KJMOBDOKFBF = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x88DA760", Offset = "0x88D9160", VA = "0x1888DA760", Slot = "11")]
	public void HHAOFABEGAA(string BIHHMEFECFM, int KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x88DA940", Offset = "0x88D9340", VA = "0x1888DA940", Slot = "12")]
	public bool MNLLJDJONLE(string BIHHMEFECFM, bool KJMOBDOKFBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x88DA650", Offset = "0x88D9050", VA = "0x1888DA650", Slot = "13")]
	public void EHDEODPBOBM(string BIHHMEFECFM, bool KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x88DAA60", Offset = "0x88D9460", VA = "0x1888DAA60", Slot = "14")]
	public float NAANBCKCMPE(string BIHHMEFECFM, float KJMOBDOKFBF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x88DA4C0", Offset = "0x88D8EC0", VA = "0x1888DA4C0", Slot = "15")]
	public void AGDLCINDKCG(string BIHHMEFECFM, float KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x88DA560", Offset = "0x88D8F60", VA = "0x1888DA560", Slot = "18")]
	public DateTime BIGJICEOCHM(string BIHHMEFECFM, [Optional] DateTime KJMOBDOKFBF)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x88DA6F0", Offset = "0x88D90F0", VA = "0x1888DA6F0", Slot = "19")]
	public void FIHGDJILMNL(string BIHHMEFECFM, DateTime PNMBHMMEFCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x88DAAD0", Offset = "0x88D94D0", VA = "0x1888DAAD0", Slot = "20")]
	public long OBILMEDGFHB(string BIHHMEFECFM, long KJMOBDOKFBF)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x88DA420", Offset = "0x88D8E20", VA = "0x1888DA420", Slot = "21")]
	public void ABOHGJPEFPD(string BIHHMEFECFM, long KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3F474B0", Offset = "0x3F45EB0", VA = "0x183F474B0", Slot = "22")]
	public T NKGLDGAFKGA<T>(string BIHHMEFECFM, T KJMOBDOKFBF, ODMLNBEIIKD<T> JPKDLICIJEA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x3F46CB0", Offset = "0x3F456B0", VA = "0x183F46CB0", Slot = "23")]
	public void INOOKCKOMOO<T>(string BIHHMEFECFM, T KMAFNKGMDCF, ODMLNBEIIKD<T> JPKDLICIJEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x3F46260", Offset = "0x3F44C60", VA = "0x183F46260")]
	private T GIHOGEKOFEL<T>(string BIHHMEFECFM, T KJMOBDOKFBF, [Optional] ODMLNBEIIKD<T> NMNKOOLBDMM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3F46DE0", Offset = "0x3F457E0", VA = "0x183F46DE0")]
	private void MHLBDLMJJPH<T>(string BIHHMEFECFM, T KMAFNKGMDCF, [Optional] ODMLNBEIIKD<T> NMNKOOLBDMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x88DAB60", Offset = "0x88D9560", VA = "0x1888DAB60", Slot = "16")]
	public string PBDJEFHBIMG(string BIHHMEFECFM, string KJMOBDOKFBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x88DA790", Offset = "0x88D9190", VA = "0x1888DA790", Slot = "17")]
	public void KGBGLNMAOAK(string BIHHMEFECFM, string KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x88DAA90", Offset = "0x88D9490", VA = "0x1888DAA90")]
	private void NCJBOHFJMGJ(string BIHHMEFECFM, string KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x88DAAB0", Offset = "0x88D94B0", VA = "0x1888DAAB0")]
	private string NKDPOPCIHAK(string BIHHMEFECFM, string KJMOBDOKFBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x88DA850", Offset = "0x88D9250", VA = "0x1888DA850", Slot = "24")]
	public void KOKCOKMODHF(string BIHHMEFECFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x88DAB90", Offset = "0x88D9590", VA = "0x1888DAB90")]
	private string PGMGJDJFHBH(string HPFHOBCPNEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x88DA970", Offset = "0x88D9370", VA = "0x1888DA970", Slot = "25")]
	[AsyncStateMachine(typeof(HPNGFDONLIH))]
	public Task MNMGILKBLNG(CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x88DA5D0", Offset = "0x88D8FD0", VA = "0x1888DA5D0")]
	[IteratorStateMachine(typeof(FOHDJBBOJJF))]
	private IEnumerator<JFFMJDIOLAN> ECPKGIJIJEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x88DA8E0", Offset = "0x88D92E0", VA = "0x1888DA8E0")]
	private void MAGLOMDBCGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x88DA4F0", Offset = "0x88D8EF0", VA = "0x1888DA4F0")]
	private void BHEEDFDEMIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x88DA680", Offset = "0x88D9080", VA = "0x1888DA680")]
	private void FEDLOIGHCCD(bool DKNJNIJNPNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class NCLGCPPBDEC : NELKDLJMAJF, BBJILJGIOBH
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct KVP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public string k;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public string v;
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private struct KVPs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public KVP[] kvps;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private Dictionary<string, string> CGPKLINALIG;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool FHLCJJBHDMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xAC8240", Offset = "0xAC6C40", VA = "0x180AC8240", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private string PJHNJGFIFCI
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x88D9790", Offset = "0x88D8190", VA = "0x1888D9790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private Dictionary<string, string> IOPLCEKOPCP
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x88D9750", Offset = "0x88D8150", VA = "0x1888D9750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action BABOGPKIGPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	[UnityEngine.Scripting.Preserve]
	public NCLGCPPBDEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "8")]
	public void KCCGOIBALIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x88D9910", Offset = "0x88D8310", VA = "0x1888D9910", Slot = "6")]
	public Task KMJNLNJOEOC(long AAPIKGHGGHH, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x88D9DA0", Offset = "0x88D87A0", VA = "0x1888D9DA0", Slot = "14")]
	public float NAANBCKCMPE(string HPFHOBCPNEF, float KJMOBDOKFBF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x88D9670", Offset = "0x88D8070", VA = "0x1888D9670", Slot = "13")]
	public void EHDEODPBOBM(string HPFHOBCPNEF, bool KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x88D9A60", Offset = "0x88D8460", VA = "0x1888D9A60", Slot = "12")]
	public bool MNLLJDJONLE(string HPFHOBCPNEF, bool KJMOBDOKFBF = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x88D9520", Offset = "0x88D7F20", VA = "0x1888D9520", Slot = "10")]
	public int ADKFKLHDKCO(string HPFHOBCPNEF, int KJMOBDOKFBF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x88D9600", Offset = "0x88D8000", VA = "0x1888D9600", Slot = "18")]
	public DateTime BIGJICEOCHM(string BIHHMEFECFM, [Optional] DateTime KJMOBDOKFBF)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x88D96E0", Offset = "0x88D80E0", VA = "0x1888D96E0", Slot = "19")]
	public void FIHGDJILMNL(string HPFHOBCPNEF, DateTime KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x88D9590", Offset = "0x88D7F90", VA = "0x1888D9590", Slot = "15")]
	public void AGDLCINDKCG(string HPFHOBCPNEF, float KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x88D9800", Offset = "0x88D8200", VA = "0x1888D9800", Slot = "11")]
	public void HHAOFABEGAA(string HPFHOBCPNEF, int KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x88D9E10", Offset = "0x88D8810", VA = "0x1888D9E10", Slot = "20")]
	public long OBILMEDGFHB(string BIHHMEFECFM, long KJMOBDOKFBF)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x88D94B0", Offset = "0x88D7EB0", VA = "0x1888D94B0", Slot = "21")]
	public void ABOHGJPEFPD(string BIHHMEFECFM, long KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3DEB7A0", Offset = "0x3DEA1A0", VA = "0x183DEB7A0", Slot = "22")]
	public T NKGLDGAFKGA<T>(string BIHHMEFECFM, T KJMOBDOKFBF, ODMLNBEIIKD<T> JPKDLICIJEA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x3DEB700", Offset = "0x3DEA100", VA = "0x183DEB700", Slot = "23")]
	public void INOOKCKOMOO<T>(string BIHHMEFECFM, T KMAFNKGMDCF, ODMLNBEIIKD<T> JPKDLICIJEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x88DA210", Offset = "0x88D8C10", VA = "0x1888DA210", Slot = "16")]
	public string PBDJEFHBIMG(string HPFHOBCPNEF, string KJMOBDOKFBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x88D9870", Offset = "0x88D8270", VA = "0x1888D9870", Slot = "17")]
	public void KGBGLNMAOAK(string HPFHOBCPNEF, string KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x88D99A0", Offset = "0x88D83A0", VA = "0x1888D99A0", Slot = "24")]
	public void KOKCOKMODHF(string HPFHOBCPNEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x88DA180", Offset = "0x88D8B80", VA = "0x1888DA180", Slot = "9")]
	public bool PBANNOABGEP(string HPFHOBCPNEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x88D9B30", Offset = "0x88D8530", VA = "0x1888D9B30", Slot = "25")]
	public Task MNMGILKBLNG(CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x3F05D90", Offset = "0x3F04790", VA = "0x183F05D90")]
	private T GFFPJLNAMHB<T>(string BIHHMEFECFM, T KJMOBDOKFBF, [Optional] ODMLNBEIIKD<T> NMNKOOLBDMM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x3F04E50", Offset = "0x3F03850", VA = "0x183F04E50")]
	private void FNAEMEPGHFK<T>(string BIHHMEFECFM, T KMAFNKGMDCF, [Optional] ODMLNBEIIKD<T> NMNKOOLBDMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x88D9E80", Offset = "0x88D8880", VA = "0x1888D9E80")]
	private Dictionary<string, string> PAKMMIAPLAN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface CNGDCLJNIFB
{
	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action BABOGPKIGPA;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KCCGOIBALIC();

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task FPDKNFFFPLI(long AAPIKGHGGHH);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool FPNAKCIPFDD(EGEFIPLILMI NPIGJAAJIIA = EGEFIPLILMI.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool BEKBJHMFLIL(string BIHHMEFECFM, EGEFIPLILMI NKEMINNCGCK = EGEFIPLILMI.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool DGJPKBBCGHE(string BIHHMEFECFM, EGEFIPLILMI NKEMINNCGCK = EGEFIPLILMI.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "7")]
	string NCPKLHLBJDG(string BIHHMEFECFM, [Optional] string KJMOBDOKFBF, EGEFIPLILMI NKEMINNCGCK = EGEFIPLILMI.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "8")]
	MINJHHBFOJA BHNFGOCMJDM(string BIHHMEFECFM, string KMAFNKGMDCF, EGEFIPLILMI NKEMINNCGCK = EGEFIPLILMI.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "9")]
	int KAEEHBOCBKC(string BIHHMEFECFM, int KJMOBDOKFBF = 0, EGEFIPLILMI NKEMINNCGCK = EGEFIPLILMI.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "10")]
	MINJHHBFOJA NAGBDGGFKMP(string BIHHMEFECFM, int KMAFNKGMDCF, EGEFIPLILMI NKEMINNCGCK = EGEFIPLILMI.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool ADLCGLLPGCH(string BIHHMEFECFM, bool KJMOBDOKFBF, EGEFIPLILMI NKEMINNCGCK = EGEFIPLILMI.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "12")]
	MINJHHBFOJA ELPEECMFNIP(string BIHHMEFECFM, bool KMAFNKGMDCF, EGEFIPLILMI NKEMINNCGCK = EGEFIPLILMI.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float AMLGHLJKPGO(string BIHHMEFECFM, float KJMOBDOKFBF = 0f, EGEFIPLILMI NKEMINNCGCK = EGEFIPLILMI.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "14")]
	MINJHHBFOJA DHPKBJJGNMA(string BIHHMEFECFM, float KMAFNKGMDCF, EGEFIPLILMI NKEMINNCGCK = EGEFIPLILMI.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "15")]
	DateTime JBGHHEMMAGB(string BIHHMEFECFM, [Optional] DateTime KJMOBDOKFBF, EGEFIPLILMI NKEMINNCGCK = EGEFIPLILMI.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "16")]
	MINJHHBFOJA JBPCGNNHLEC(string BIHHMEFECFM, DateTime KMAFNKGMDCF, EGEFIPLILMI NKEMINNCGCK = EGEFIPLILMI.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "17")]
	long HBAEFFFAPEL(string BIHHMEFECFM, long KJMOBDOKFBF = 0L, EGEFIPLILMI NKEMINNCGCK = EGEFIPLILMI.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "18")]
	MINJHHBFOJA FABBANMFDIB(string BIHHMEFECFM, long KMAFNKGMDCF, EGEFIPLILMI NKEMINNCGCK = EGEFIPLILMI.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "19")]
	T PDNLFEJCGMO<T>(string BIHHMEFECFM, [Optional] T KJMOBDOKFBF, EGEFIPLILMI NKEMINNCGCK = EGEFIPLILMI.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "20")]
	MINJHHBFOJA KAPAAMDHEJI<T>(string BIHHMEFECFM, T KMAFNKGMDCF, EGEFIPLILMI NKEMINNCGCK = EGEFIPLILMI.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool LDLDALJFENJ(string BIHHMEFECFM);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool HHNJLMGBPNO(string BIHHMEFECFM);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "23")]
	string GAJNBJINKFF(string BIHHMEFECFM, [Optional] string KJMOBDOKFBF);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "24")]
	MINJHHBFOJA MKFPCEJDLON(string BIHHMEFECFM, string KMAFNKGMDCF);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "25")]
	int MBPHLILCMNA(string BIHHMEFECFM, int KJMOBDOKFBF = 0);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "26")]
	MINJHHBFOJA JOFCHCEEEHE(string BIHHMEFECFM, int KMAFNKGMDCF);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool GGOACEIFONP(string BIHHMEFECFM, bool KJMOBDOKFBF);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "28")]
	MINJHHBFOJA GFCJIFKCODA(string BIHHMEFECFM, bool KMAFNKGMDCF);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "29")]
	float NCOHFEPOONN(string BIHHMEFECFM, float KJMOBDOKFBF = 0f);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "30")]
	MINJHHBFOJA PPHOBLPPIAB(string BIHHMEFECFM, float KMAFNKGMDCF);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "31")]
	DateTime KINEJIPPBJN(string BIHHMEFECFM, [Optional] DateTime KJMOBDOKFBF);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "32")]
	MINJHHBFOJA OHCHHCJKPEL(string BIHHMEFECFM, DateTime KMAFNKGMDCF);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "33")]
	long JDMCKMJODIB(string BIHHMEFECFM, long KJMOBDOKFBF = 0L);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "34")]
	MINJHHBFOJA FACILPACDIL(string BIHHMEFECFM, long KMAFNKGMDCF);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void PDHMDHPEHBA<T>(ODMLNBEIIKD<T> JPKDLICIJEA, [Optional] IEqualityComparer<T> MELOCBAJPHK);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void HGIOKEGOAIN<T>();

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "37")]
	IDisposable OPDOKMAJLAN();

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void BKINILNCIDM(float JHMKMDEDCJN);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task MAGLOMDBCGL([Optional] CancellationToken AHOMALKMHKK);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum MINJHHBFOJA : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Unchanged,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	New,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	Changed
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class KOEOLNOPNND : CNGDCLJNIFB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private abstract class MECDGKHELLO
	{
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		protected static readonly HashSet<MECDGKHELLO> LHPBEKCGELI;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x88D92E0", Offset = "0x88D7CE0", VA = "0x1888D92E0")]
		public static void HKNHMIPLHFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void EMMOLKMNHIK();

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		protected MECDGKHELLO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private class KAELOANDDJI<T> : MECDGKHELLO
	{
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public static readonly KAELOANDDJI<T> FLGHCDNLMND;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public ODMLNBEIIKD<T> BBMBADMLAAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public IEqualityComparer<T> DJHFPGAFGNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool ACNDEODDCOA
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x4AF1520", Offset = "0x4AEFF20", VA = "0x184AF1520")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x5634810", Offset = "0x5633210", VA = "0x185634810")]
		private KAELOANDDJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x5634380", Offset = "0x5632D80", VA = "0x185634380")]
		public void NFFNLBFBLBL(ODMLNBEIIKD<T> NMNKOOLBDMM, [Optional] IEqualityComparer<T> MELOCBAJPHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x56341C0", Offset = "0x5632BC0", VA = "0x1856341C0", Slot = "4")]
		public override void EMMOLKMNHIK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class KIFKDEGLMKE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly KOEOLNOPNND FPDNPINLOOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly object ALEFODLCLJE;

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x88D6000", Offset = "0x88D4A00", VA = "0x1888D6000")]
		public KIFKDEGLMKE(KOEOLNOPNND FPDNPINLOOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x88D5FD0", Offset = "0x88D49D0", VA = "0x1888D5FD0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct JHCKABPNAAP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public KOEOLNOPNND <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public long playerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x88D5870", Offset = "0x88D4270", VA = "0x1888D5870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x88D5B50", Offset = "0x88D4550", VA = "0x1888D5B50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private struct FOGGDDKACOG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public KOEOLNOPNND <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public BBJILJGIOBH backingStoreToSave;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x88D2C30", Offset = "0x88D1630", VA = "0x1888D2C30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xB082C0", Offset = "0xB06CC0", VA = "0x180B082C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct EAEGDAGFMDO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public KOEOLNOPNND <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x88D2700", Offset = "0x88D1100", VA = "0x1888D2700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x88D2BD0", Offset = "0x88D15D0", VA = "0x1888D2BD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class NEEKKMLKLLB : IEnumerator<JFFMJDIOLAN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private JFFMJDIOLAN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public KOEOLNOPNND <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public float seconds;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private JFFMJDIOLAN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0xAB33A0", Offset = "0xAB1DA0", VA = "0x180AB33A0")]
		[DebuggerHidden]
		public NEEKKMLKLLB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x88DA2C0", Offset = "0x88D8CC0", VA = "0x1888DA2C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x88DA350", Offset = "0x88D8D50", VA = "0x1888DA350", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly NELKDLJMAJF HCDPCPIOAHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly NELKDLJMAJF FKJJFOHBFCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly JAMLMMEEJEF CBPEPLJGION;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly BCONDBBGDGF JEHAFCLHOLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly HNMLCMDKEOJ.OPCNNKKKIOH OILMMGDAFJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly GBIFDHMBLCB KIIHPIPCBFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly HashSet<BBJILJGIOBH> HHLJMPENLJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private Task LNBNKNOAEFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private Dictionary<string, string> CBJFEGGAIMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private LCOHCCBKPLJ AIMGPPJDPFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly object ILBPLNOBPKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly object MABJFKGBJEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private long CCFFAICHDKJ;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private bool BBEHANJHNGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x88D6AC0", Offset = "0x88D54C0", VA = "0x1888D6AC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private CancellationTokenSource PMKLOOKLGMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0xAB4860", Offset = "0xAB3260", VA = "0x180AB4860")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0xAB4880", Offset = "0xAB3280", VA = "0x180AB4880")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action BABOGPKIGPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x88D63A0", Offset = "0x88D4DA0", VA = "0x1888D63A0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x88D7330", Offset = "0x88D5D30", VA = "0x1888D7330", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x88D6630", Offset = "0x88D5030", VA = "0x1888D6630")]
	[DMKNBLIJJON.EGFDFBOLNDK]
	internal static void BHAGPFKLBNG(JBJKIIKOACK KLIEGJHNGPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x88D8F10", Offset = "0x88D7910", VA = "0x1888D8F10")]
	[UnityEngine.Scripting.Preserve]
	public KOEOLNOPNND([BMCONCJPCIA("Disk")] NELKDLJMAJF HCDPCPIOAHM, [BMCONCJPCIA("Cloud")] NELKDLJMAJF FKJJFOHBFCF, [BMCONCJPCIA(null)] JAMLMMEEJEF CBPEPLJGION, [BMCONCJPCIA(null)] BCONDBBGDGF JEHAFCLHOLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x88D6DE0", Offset = "0x88D57E0", VA = "0x1888D6DE0", Slot = "44")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x88D7C80", Offset = "0x88D6680", VA = "0x1888D7C80")]
	private void IPDHLKMCPMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x88D8080", Offset = "0x88D6A80", VA = "0x1888D8080", Slot = "6")]
	public void KCCGOIBALIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x88D7650", Offset = "0x88D6050", VA = "0x1888D7650", Slot = "7")]
	public Task FPDKNFFFPLI(long AAPIKGHGGHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x88D6160", Offset = "0x88D4B60", VA = "0x1888D6160")]
	[AsyncStateMachine(typeof(JHCKABPNAAP))]
	private Task ADMGODCJNJM(long AAPIKGHGGHH, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x88D7F10", Offset = "0x88D6910", VA = "0x1888D7F10")]
	private void JDBAAHJEBFB(object MFKHKDDANII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x88D6320", Offset = "0x88D4D20", VA = "0x1888D6320")]
	private void ANKCDGAGLHB(object MFKHKDDANII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x88D79B0", Offset = "0x88D63B0", VA = "0x1888D79B0")]
	private string GFGLHIBJLBK(string BHMALBACMEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x88D8AC0", Offset = "0x88D74C0", VA = "0x1888D8AC0")]
	private void NKAEGIIAFAJ(EGEFIPLILMI NPIGJAAJIIA, string HPFHOBCPNEF, [Out] NELKDLJMAJF ADAENKCNBKF, [Out] string GKJKKANFEON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x88D8D80", Offset = "0x88D7780", VA = "0x1888D8D80")]
	private NELKDLJMAJF OLMBBFELHNO(EGEFIPLILMI NPIGJAAJIIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x88D7820", Offset = "0x88D6220", VA = "0x1888D7820", Slot = "8")]
	public bool FPNAKCIPFDD(EGEFIPLILMI NPIGJAAJIIA = EGEFIPLILMI.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x88D6440", Offset = "0x88D4E40", VA = "0x1888D6440", Slot = "9")]
	public bool BEKBJHMFLIL(string BIHHMEFECFM, EGEFIPLILMI NKEMINNCGCK = EGEFIPLILMI.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x88D6AE0", Offset = "0x88D54E0", VA = "0x1888D6AE0", Slot = "10")]
	public bool DGJPKBBCGHE(string BIHHMEFECFM, EGEFIPLILMI NKEMINNCGCK = EGEFIPLILMI.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x88D8A20", Offset = "0x88D7420", VA = "0x1888D8A20", Slot = "11")]
	public string NCPKLHLBJDG(string BIHHMEFECFM, [Optional] string KJMOBDOKFBF, EGEFIPLILMI NKEMINNCGCK = EGEFIPLILMI.CLOUD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x88D66A0", Offset = "0x88D50A0", VA = "0x1888D66A0", Slot = "12")]
	public MINJHHBFOJA BHNFGOCMJDM(string BIHHMEFECFM, string KMAFNKGMDCF, EGEFIPLILMI NKEMINNCGCK = EGEFIPLILMI.CLOUD)
	{
		return default(MINJHHBFOJA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x88D7FD0", Offset = "0x88D69D0", VA = "0x1888D7FD0", Slot = "13")]
	public int KAEEHBOCBKC(string BIHHMEFECFM, int KJMOBDOKFBF = 0, EGEFIPLILMI NKEMINNCGCK = EGEFIPLILMI.CLOUD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x88D8830", Offset = "0x88D7230", VA = "0x1888D8830", Slot = "14")]
	public MINJHHBFOJA NAGBDGGFKMP(string BIHHMEFECFM, int KMAFNKGMDCF, EGEFIPLILMI NKEMINNCGCK = EGEFIPLILMI.CLOUD)
	{
		return default(MINJHHBFOJA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x88D60B0", Offset = "0x88D4AB0", VA = "0x1888D60B0", Slot = "15")]
	public bool ADLCGLLPGCH(string BIHHMEFECFM, bool KJMOBDOKFBF, EGEFIPLILMI NKEMINNCGCK = EGEFIPLILMI.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x88D7000", Offset = "0x88D5A00", VA = "0x1888D7000", Slot = "16")]
	public MINJHHBFOJA ELPEECMFNIP(string BIHHMEFECFM, bool KMAFNKGMDCF, EGEFIPLILMI NKEMINNCGCK = EGEFIPLILMI.CLOUD)
	{
		return default(MINJHHBFOJA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x88D6270", Offset = "0x88D4C70", VA = "0x1888D6270", Slot = "17")]
	public float AMLGHLJKPGO(string BIHHMEFECFM, float KJMOBDOKFBF = 0f, EGEFIPLILMI NKEMINNCGCK = EGEFIPLILMI.CLOUD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x88D6C60", Offset = "0x88D5660", VA = "0x1888D6C60", Slot = "18")]
	public MINJHHBFOJA DHPKBJJGNMA(string BIHHMEFECFM, float KMAFNKGMDCF, EGEFIPLILMI NKEMINNCGCK = EGEFIPLILMI.CLOUD)
	{
		return default(MINJHHBFOJA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x88D7CD0", Offset = "0x88D66D0", VA = "0x1888D7CD0", Slot = "19")]
	public DateTime JBGHHEMMAGB(string BIHHMEFECFM, [Optional] DateTime KJMOBDOKFBF, EGEFIPLILMI NKEMINNCGCK = EGEFIPLILMI.CLOUD)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x88D7D70", Offset = "0x88D6770", VA = "0x1888D7D70", Slot = "20")]
	public MINJHHBFOJA JBPCGNNHLEC(string BIHHMEFECFM, DateTime KMAFNKGMDCF, EGEFIPLILMI NKEMINNCGCK = EGEFIPLILMI.CLOUD)
	{
		return default(MINJHHBFOJA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x88D7BD0", Offset = "0x88D65D0", VA = "0x1888D7BD0", Slot = "21")]
	public long HBAEFFFAPEL(string BIHHMEFECFM, long KJMOBDOKFBF = 0L, EGEFIPLILMI NKEMINNCGCK = EGEFIPLILMI.CLOUD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x88D7180", Offset = "0x88D5B80", VA = "0x1888D7180", Slot = "22")]
	public MINJHHBFOJA FABBANMFDIB(string BIHHMEFECFM, long KMAFNKGMDCF, EGEFIPLILMI NKEMINNCGCK = EGEFIPLILMI.CLOUD)
	{
		return default(MINJHHBFOJA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x3E5F5B0", Offset = "0x3E5DFB0", VA = "0x183E5F5B0", Slot = "23")]
	public T PDNLFEJCGMO<T>(string BIHHMEFECFM, [Optional] T KJMOBDOKFBF, EGEFIPLILMI NKEMINNCGCK = EGEFIPLILMI.CLOUD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x3E5F5B0", Offset = "0x3E5DFB0", VA = "0x183E5F5B0", Slot = "24")]
	public MINJHHBFOJA KAPAAMDHEJI<T>(string BIHHMEFECFM, T KMAFNKGMDCF, EGEFIPLILMI NKEMINNCGCK = EGEFIPLILMI.CLOUD)
	{
		return default(MINJHHBFOJA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x88D8400", Offset = "0x88D6E00", VA = "0x1888D8400", Slot = "25")]
	public bool LDLDALJFENJ(string BIHHMEFECFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x88D7C70", Offset = "0x88D6670", VA = "0x1888D7C70", Slot = "26")]
	public bool HHNJLMGBPNO(string BIHHMEFECFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x88D78E0", Offset = "0x88D62E0", VA = "0x1888D78E0", Slot = "27")]
	public string GAJNBJINKFF(string BIHHMEFECFM, [Optional] string KJMOBDOKFBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x88D8730", Offset = "0x88D7130", VA = "0x1888D8730", Slot = "28")]
	public MINJHHBFOJA MKFPCEJDLON(string BIHHMEFECFM, string KMAFNKGMDCF)
	{
		return default(MINJHHBFOJA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x88D86C0", Offset = "0x88D70C0", VA = "0x1888D86C0", Slot = "29")]
	public int MBPHLILCMNA(string BIHHMEFECFM, int KJMOBDOKFBF = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x88D7FA0", Offset = "0x88D69A0", VA = "0x1888D7FA0", Slot = "30")]
	public MINJHHBFOJA JOFCHCEEEHE(string BIHHMEFECFM, int KMAFNKGMDCF)
	{
		return default(MINJHHBFOJA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x88D7A10", Offset = "0x88D6410", VA = "0x1888D7A10", Slot = "31")]
	public bool GGOACEIFONP(string BIHHMEFECFM, bool KJMOBDOKFBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x88D7980", Offset = "0x88D6380", VA = "0x1888D7980", Slot = "32")]
	public MINJHHBFOJA GFCJIFKCODA(string BIHHMEFECFM, bool KMAFNKGMDCF)
	{
		return default(MINJHHBFOJA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x88D89B0", Offset = "0x88D73B0", VA = "0x1888D89B0", Slot = "33")]
	public float NCOHFEPOONN(string BIHHMEFECFM, float KJMOBDOKFBF = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x88D8EE0", Offset = "0x88D78E0", VA = "0x1888D8EE0", Slot = "34")]
	public MINJHHBFOJA PPHOBLPPIAB(string BIHHMEFECFM, float KMAFNKGMDCF)
	{
		return default(MINJHHBFOJA);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x88D8250", Offset = "0x88D6C50", VA = "0x1888D8250", Slot = "35")]
	public DateTime KINEJIPPBJN(string BIHHMEFECFM, [Optional] DateTime KJMOBDOKFBF)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x88D8D50", Offset = "0x88D7750", VA = "0x1888D8D50", Slot = "36")]
	public MINJHHBFOJA OHCHHCJKPEL(string BIHHMEFECFM, DateTime KMAFNKGMDCF)
	{
		return default(MINJHHBFOJA);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x88D7F30", Offset = "0x88D6930", VA = "0x1888D7F30", Slot = "37")]
	public long JDMCKMJODIB(string BIHHMEFECFM, long KJMOBDOKFBF = 0L)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x88D7300", Offset = "0x88D5D00", VA = "0x1888D7300", Slot = "38")]
	public MINJHHBFOJA FACILPACDIL(string BIHHMEFECFM, long KMAFNKGMDCF)
	{
		return default(MINJHHBFOJA);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x88D8C60", Offset = "0x88D7660", VA = "0x1888D8C60")]
	private bool OCDKGNCHEAI(BBJILJGIOBH ADAENKCNBKF, string BIHHMEFECFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x88D80F0", Offset = "0x88D6AF0", VA = "0x1888D80F0")]
	private bool KCJFFDLFOBI(BBJILJGIOBH ADAENKCNBKF, string BIHHMEFECFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x88D7A80", Offset = "0x88D6480", VA = "0x1888D7A80")]
	private MINJHHBFOJA GLEGJBBFIGN(BBJILJGIOBH ADAENKCNBKF, string BIHHMEFECFM, string KMAFNKGMDCF)
	{
		return default(MINJHHBFOJA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x88D82C0", Offset = "0x88D6CC0", VA = "0x1888D82C0")]
	private MINJHHBFOJA LBBLFMIBHIO(BBJILJGIOBH ADAENKCNBKF, string BIHHMEFECFM, int KMAFNKGMDCF)
	{
		return default(MINJHHBFOJA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x88D6840", Offset = "0x88D5240", VA = "0x1888D6840")]
	private MINJHHBFOJA BLFOLMENNHJ(BBJILJGIOBH ADAENKCNBKF, string BIHHMEFECFM, bool KMAFNKGMDCF)
	{
		return default(MINJHHBFOJA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x88D64E0", Offset = "0x88D4EE0", VA = "0x1888D64E0")]
	private MINJHHBFOJA BEPMBIFHFLN(BBJILJGIOBH ADAENKCNBKF, string BIHHMEFECFM, float KMAFNKGMDCF)
	{
		return default(MINJHHBFOJA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x88D8460", Offset = "0x88D6E60", VA = "0x1888D8460")]
	private MINJHHBFOJA LEHNALLNHHG(BBJILJGIOBH ADAENKCNBKF, string BIHHMEFECFM, DateTime KMAFNKGMDCF)
	{
		return default(MINJHHBFOJA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x88D6980", Offset = "0x88D5380", VA = "0x1888D6980")]
	private MINJHHBFOJA COMLADEFFLF(BBJILJGIOBH ADAENKCNBKF, string BIHHMEFECFM, long KMAFNKGMDCF)
	{
		return default(MINJHHBFOJA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3E5F0B0", Offset = "0x3E5DAB0", VA = "0x183E5F0B0")]
	private T IKGHKDCPKLF<T>(BBJILJGIOBH ADAENKCNBKF, string BIHHMEFECFM, T KJMOBDOKFBF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3E5E520", Offset = "0x3E5CF20", VA = "0x183E5E520")]
	private MINJHHBFOJA CKCNMAMCFOK<T>(BBJILJGIOBH ADAENKCNBKF, string BIHHMEFECFM, T KMAFNKGMDCF)
	{
		return default(MINJHHBFOJA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x3E5F740", Offset = "0x3E5E140", VA = "0x183E5F740", Slot = "39")]
	public void PDHMDHPEHBA<T>(ODMLNBEIIKD<T> JPKDLICIJEA, [Optional] IEqualityComparer<T> MELOCBAJPHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3E5F030", Offset = "0x3E5DA30", VA = "0x183E5F030", Slot = "40")]
	public void HGIOKEGOAIN<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x88D8760", Offset = "0x88D7160", VA = "0x1888D8760")]
	[AsyncStateMachine(typeof(FOGGDDKACOG))]
	private void MNMGILKBLNG(BBJILJGIOBH FGDKECCDMLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x88D85D0", Offset = "0x88D6FD0", VA = "0x1888D85D0", Slot = "43")]
	[AsyncStateMachine(typeof(EAEGDAGFMDO))]
	public Task MAGLOMDBCGL([Optional] CancellationToken MFKHKDDANII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x88D6E20", Offset = "0x88D5820", VA = "0x1888D6E20")]
	private void EHMOPCNAFMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x88D8E00", Offset = "0x88D7800", VA = "0x1888D8E00", Slot = "41")]
	public IDisposable OPDOKMAJLAN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x88D6830", Offset = "0x88D5230", VA = "0x1888D6830", Slot = "42")]
	public void BKINILNCIDM(float JHMKMDEDCJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x88D73D0", Offset = "0x88D5DD0", VA = "0x1888D73D0")]
	private void FDHPAFOOKFN(float ANHPHDKCAAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x88D8CC0", Offset = "0x88D76C0", VA = "0x1888D8CC0")]
	[IteratorStateMachine(typeof(NEEKKMLKLLB))]
	private IEnumerator<JFFMJDIOLAN> OFLODMJFAKO(float JHMKMDEDCJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x88D7950", Offset = "0x88D6350", VA = "0x1888D7950")]
	[CompilerGenerated]
	private void GBFJNKDNALN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class KHPBMINFBNP
{
	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x88D5D50", Offset = "0x88D4750", VA = "0x1888D5D50")]
	public static string DCANMPADLLO(this CNGDCLJNIFB DKGBCFDLMOI, string HPFHOBCPNEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x88D5BB0", Offset = "0x88D45B0", VA = "0x1888D5BB0")]
	public static byte[] COIJFDCOMOJ(this CNGDCLJNIFB DKGBCFDLMOI, string HPFHOBCPNEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x88D5EC0", Offset = "0x88D48C0", VA = "0x1888D5EC0")]
	public static MINJHHBFOJA JHLMLPOINGK(this CNGDCLJNIFB DKGBCFDLMOI, string HPFHOBCPNEF, ReadOnlySpan<byte> KMAFNKGMDCF)
	{
		return default(MINJHHBFOJA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class AFADKMECKCP : KFLMFFFNCPM<bool>
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static AFADKMECKCP FLGHCDNLMND
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x88D1D90", Offset = "0x88D0790", VA = "0x1888D1D90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x88D1A20", Offset = "0x88D0420", VA = "0x1888D1A20", Slot = "9")]
	public override string GCGCKFHBJPB(bool GHANLDMHBLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x88D1B10", Offset = "0x88D0510", VA = "0x1888D1B10", Slot = "10")]
	protected override bool LENGHMMDCBN(string GHANLDMHBLD, [Out] bool KMAFNKGMDCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x88D1E80", Offset = "0x88D0880", VA = "0x1888D1E80")]
	public AFADKMECKCP()
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

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using RecRoom.NoEngine.Common;
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
		[Cpp2IlInjected.Address(RVA = "0x8389E0", Offset = "0x8377E0", VA = "0x1808389E0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6802AC0", Offset = "0x68018C0", VA = "0x186802AC0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x917630", Offset = "0x916430", VA = "0x180917630")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xF6F160", Offset = "0xF6DF60", VA = "0x180F6F160")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum OCDELHMOFAN
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Vote,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Instant,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Off
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface IDFGMJAHNAL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	JHJJNANJBCJ OFANHDHFBBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IEnumerable<MHFDAJALDEH> ALFBOCKOMAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event AIIEIDLFJEA FANBPBKDCGG;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<MHFDAJALDEH> LBKGFFLOKCC(bool NMCBFGDEANM = false);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	MHFDAJALDEH DHOOFILKCID(PMEFCBBKLLD BLBBPGEKKJJ);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool LCBGDONNNAI(PMEFCBBKLLD BLBBPGEKKJJ);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<MHFDAJALDEH> IGKPBLBEDPP(PMEFCBBKLLD BLBBPGEKKJJ, bool NMILCGLLOPH = false);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool MJHMLGNCJIP(PMEFCBBKLLD CALHKIBOCCL, FKPEIHCGBMP AEOENFGOMPH);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	MHFDAJALDEH LIMKNFJBMLB(FKPEIHCGBMP AEOENFGOMPH);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool MBHOBMNGEEP<T>(FKPEIHCGBMP AEOENFGOMPH, AJPBEAOBCOA HFKDIMNPCFD, bool KHKMODGICCD, T GAECONBCCJH) where T : notnull;
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface FLBGFELPIBP
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task JNEENJFGINF(FOHHNNEFOIN ODBMILJBDKN, CancellationToken KIMBGNGMOGB);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IJKKHAFHEJJ(ref FOHHNNEFOIN ODBMILJBDKN);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface EEKGAGKPBAJ
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool OIOPDMPLGJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool MCLMEKJPKBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool PMJLBJKMKMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool AKFOKECHCGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool EKDDLGJBDAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool FGPGMJMNFOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class HOIPALEDEJH
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly IReadOnlyList<FKPEIHCGBMP> CECCNCKMECO;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x67FB530", Offset = "0x67FA330", VA = "0x1867FB530")]
	public static bool DJGFJMOPDGH(this PMEFCBBKLLD HGJNDNHNHJM, FKPEIHCGBMP AEOENFGOMPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x67FB620", Offset = "0x67FA420", VA = "0x1867FB620")]
	public static bool GMEKOOGKCID(this PMEFCBBKLLD HGJNDNHNHJM, FKPEIHCGBMP AEOENFGOMPH, PKPIHKEIHHL FKKABBFJNME)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal class DMGGJMJOGFM : MJOJCEGFLAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly IDFGMJAHNAL LOGCPAOAGLC;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8FF650", Offset = "0x8FE450", VA = "0x1808FF650")]
	[RecRoom.NoEngine.Common.Preserve]
	public DMGGJMJOGFM([DNPFPOCMFCA(null)] IDFGMJAHNAL FPCGIAMLGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x67F9A10", Offset = "0x67F8810", VA = "0x1867F9A10")]
	private static CDFMABNLGEJ? EPNAHEIDMMO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x67F9A60", Offset = "0x67F8860", VA = "0x1867F9A60", Slot = "4")]
	public bool HPFIEBGCMNF(PMEFCBBKLLD PJDCPIIMDAI, PMEFCBBKLLD DKAHMCICAOO, IEnumerable<PMEFCBBKLLD> MJGJIAAHCAL, out OCDELHMOFAN KNKBMGHCEJO, out DBEHIIFJBGP LGNBJKPOJPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x67F9B70", Offset = "0x67F8970", VA = "0x1867F9B70")]
	internal bool MFJPNJGGOKF(PMEFCBBKLLD PJDCPIIMDAI, PMEFCBBKLLD DKAHMCICAOO, IEnumerable<PMEFCBBKLLD> MJGJIAAHCAL, PKPIHKEIHHL FKKABBFJNME, CDFMABNLGEJ? HIJMNCEHMHA, out OCDELHMOFAN KNKBMGHCEJO, out DBEHIIFJBGP LGNBJKPOJPL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface KJKAAOEELOK<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	string DILJMOMBBOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event GLLBJKLIEPP<TPermission> MAAILLCFJII;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public delegate void GLLBJKLIEPP<TPermission>(TPermission HFKDIMNPCFD);
[Cpp2IlInjected.Token(Token = "0x200000E")]
public delegate void AIIEIDLFJEA(PMEFCBBKLLD BLBBPGEKKJJ);
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal class DMPHMKIHNDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly string EKLOELJJDOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public readonly Type PMPAOENAKGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public readonly GKAIFFACMCE BAFHMHMEINA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public readonly AJPBEAOBCOA DJPNLOENNJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public PJEOPNDLHPN IINLOPKHEBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public MANAAOAODLG MMGHCLHFDIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public DIJBDCCNABM EBHGABLCDML;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x67FA180", Offset = "0x67F8F80", VA = "0x1867FA180")]
	public DMPHMKIHNDH(Type OEEJLNJFFHM, string IEHCDBOLIOG, AJPBEAOBCOA HFKDIMNPCFD, PJEOPNDLHPN JNENKPPIHFN, MANAAOAODLG IECDMDNDFNO, DIJBDCCNABM LKJIPBKJIAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x67FA090", Offset = "0x67F8E90", VA = "0x1867FA090")]
	public object HBDINLADNNL(object? FGBEDAPNDEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2EEE8F0", Offset = "0x2EED6F0", VA = "0x182EEE8F0")]
	public void KLCFPMFPOAE<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x67FA0D0", Offset = "0x67F8ED0", VA = "0x1867FA0D0")]
	public void KLCFPMFPOAE(Type BOBFFKODHAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class DDCIJGHAHLN<T> : DMPHMKIHNDH where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal delegate string FMMHLBDGLFH(T KKLNCEHOHED);

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal delegate T EOAIBGOOEHL(string? GMMNKAHCOEK, T DGNBLLFJDJH);

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class KNFGIIIKILJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public FMMHLBDGLFH serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public EOAIBGOOEHL parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1C1AAB0", Offset = "0x1C198B0", VA = "0x181C1AAB0")]
		public KNFGIIIKILJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3C0A5C0", Offset = "0x3C093C0", VA = "0x183C0A5C0")]
		internal string GDMKBDPCNLA(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3C0A6B0", Offset = "0x3C094B0", VA = "0x183C0A6B0")]
		internal object OCHOGLINPCA(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2AC5100", Offset = "0x2AC3F00", VA = "0x182AC5100")]
	public DDCIJGHAHLN(AJPBEAOBCOA HFKDIMNPCFD, string IEHCDBOLIOG, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B3A30", Offset = "0x7B2E30")] DDCIJGHAHLN<T>.FMMHLBDGLFH JNENKPPIHFN, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B3A90", Offset = "0x7B2E90")] DDCIJGHAHLN<T>.EOAIBGOOEHL IECDMDNDFNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2AC3DA0", Offset = "0x2AC2BA0", VA = "0x182AC3DA0")]
	private static object? KMIKNNFPDOG([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B3AF0", Offset = "0x7B2EF0")] DDCIJGHAHLN<T?>.EOAIBGOOEHL? IECDMDNDFNO, string? GMMNKAHCOEK, object? DGNBLLFJDJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2AC4470", Offset = "0x2AC3270", VA = "0x182AC4470")]
	private static string LKKGLINHIKF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B3B50", Offset = "0x7B2F50")] DDCIJGHAHLN<T>.FMMHLBDGLFH HONEGGOMGKP, object? KKLNCEHOHED)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface KGHNLHILJBF
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	PMEFCBBKLLD EJGDLGDPKDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	OCLKGAACMKH BFNOMPHLMIN
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	PKPIHKEIHHL KKDJFAIBOLE
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<LMOPPMHLJAA> KBCBFNGIBPB;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action JBDNFPBJHKL;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FKPEIHCGBMP NDGPMFFGBKO(PMEFCBBKLLD BLBBPGEKKJJ);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<LMOPPMHLJAA> MGNFPMDPFPF(CancellationToken KIMBGNGMOGB);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task HHJMACHNFKB(long OFOPNAOLFGC, long KAOGEIEJOOE, IReadOnlyList<NMEDDPEPMIG> NLKBBLEPHLP);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<PMEFCBBKLLD> DNDOGCAFMGA();
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class NLLIMAEINIM
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6802A60", Offset = "0x6801860", VA = "0x186802A60")]
	public static FKPEIHCGBMP IOIHIPMGICI(this KGHNLHILJBF IOPIAHJBGMB)
	{
		return default(FKPEIHCGBMP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
internal class BCAANPEMEIM : MHFDAJALDEH, FHGKLOMLFEE, EEKGAGKPBAJ, KJKAAOEELOK<AJPBEAOBCOA>
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	internal static readonly LEBFBCJAHFO KGLNPAOENOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	internal readonly OLEBBGFHLAN EEMAEOJNLIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private string? DMOAADPMNCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private string? ENGNIOKEBMP;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private bool FEFAJDFLBBN
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x67F7AE0", Offset = "0x67F68E0", VA = "0x1867F7AE0", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private bool PCKKCHCICNB
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x67F6AB0", Offset = "0x67F58B0", VA = "0x1867F6AB0", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private bool IOOAKPAJOFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x67F7D40", Offset = "0x67F6B40", VA = "0x1867F7D40", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private bool PBMCIEMPPOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x67F69C0", Offset = "0x67F57C0", VA = "0x1867F69C0", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private bool BOEFJICMFDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x67F77B0", Offset = "0x67F65B0", VA = "0x1867F77B0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private bool NKOPJLIGNBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x67F7820", Offset = "0x67F6620", VA = "0x1867F7820", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public FKPEIHCGBMP IICLHJPPAMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x935A20", Offset = "0x934820", VA = "0x180935A20", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(FKPEIHCGBMP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7F2450", Offset = "0x7F1250", VA = "0x1807F2450")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string DILJMOMBBOC
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x67F7B80", Offset = "0x67F6980", VA = "0x1867F7B80", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x67F8950", Offset = "0x67F7750", VA = "0x1867F8950")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string CEGIIONMDEP
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x67F7B80", Offset = "0x67F6980", VA = "0x1867F7B80", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool BKMCHKMGOAE
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x9D8000", Offset = "0x9D6E00", VA = "0x1809D8000")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9D7FF0", Offset = "0x9D6DF0", VA = "0x1809D7FF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool HNMELPNCHIH
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x67F6A10", Offset = "0x67F5810", VA = "0x1867F6A10", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public OCDELHMOFAN NEGIGJEKODP
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x67F8900", Offset = "0x67F7700", VA = "0x1867F8900", Slot = "20")]
		get
		{
			return default(OCDELHMOFAN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool FDMKCJBGLLL
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x67F83E0", Offset = "0x67F71E0", VA = "0x1867F83E0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool JLNNAMGGGOK
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x67F7710", Offset = "0x67F6510", VA = "0x1867F7710", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public bool DMPIGPJDJEL
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x67F7870", Offset = "0x67F6670", VA = "0x1867F7870", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool JLJPIPBAEIG
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x67F7910", Offset = "0x67F6710", VA = "0x1867F7910", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool GJILLOCPPLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x67F82F0", Offset = "0x67F70F0", VA = "0x1867F82F0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool FJKLBKFHGAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x67F7B30", Offset = "0x67F6930", VA = "0x1867F7B30", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool PKFODGJFJLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x67F8190", Offset = "0x67F6F90", VA = "0x1867F8190", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool JNKNHCGPBJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x67F78C0", Offset = "0x67F66C0", VA = "0x1867F78C0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public IReadOnlyList<string> MIKBPGDLMCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x67F8130", Offset = "0x67F6F30", VA = "0x1867F8130", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool FAAPDNBCICJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x67F7AE0", Offset = "0x67F68E0", VA = "0x1867F7AE0", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool NPPOOBLGPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x67F77B0", Offset = "0x67F65B0", VA = "0x1867F77B0", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool JIPPBJGFJLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x67F6AB0", Offset = "0x67F58B0", VA = "0x1867F6AB0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool IIMHKFPCJND
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x67F6A60", Offset = "0x67F5860", VA = "0x1867F6A60", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool LDOGNCOAINF
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x67F7CF0", Offset = "0x67F6AF0", VA = "0x1867F7CF0", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool BLPMEFGBIHA
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x67F7D40", Offset = "0x67F6B40", VA = "0x1867F7D40", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool JIIHMPNEBIN
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x67F7760", Offset = "0x67F6560", VA = "0x1867F7760", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool OELICJMAEDP
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x67F69C0", Offset = "0x67F57C0", VA = "0x1867F69C0", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool IHBAKADLOHA
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x67F7820", Offset = "0x67F6620", VA = "0x1867F7820", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event GLLBJKLIEPP<AJPBEAOBCOA> MAAILLCFJII
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x67F6920", Offset = "0x67F5720", VA = "0x1867F6920", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x67F7C50", Offset = "0x67F6A50", VA = "0x1867F7C50", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x314D230", Offset = "0x314C030", VA = "0x18314D230", Slot = "6")]
	public (bool, T?) LIKJPMKLBEF<T>(AJPBEAOBCOA HFKDIMNPCFD) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x314D1F0", Offset = "0x314BFF0", VA = "0x18314D1F0")]
	public BCAANPEMEIM DOPNHJNDDJA<T>(AJPBEAOBCOA HFKDIMNPCFD, bool KHKMODGICCD, T KKLNCEHOHED) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x67F8A10", Offset = "0x67F7810", VA = "0x1867F8A10")]
	public BCAANPEMEIM(FKPEIHCGBMP AEOENFGOMPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x67F8B90", Offset = "0x67F7990", VA = "0x1867F8B90")]
	public BCAANPEMEIM(FKPEIHCGBMP AEOENFGOMPH, [Optional] string? DMOAADPMNCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x67F8BB0", Offset = "0x67F79B0", VA = "0x1867F8BB0")]
	public BCAANPEMEIM(BCAANPEMEIM JHNDDBJGJEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x67F8A30", Offset = "0x67F7830", VA = "0x1867F8A30")]
	internal BCAANPEMEIM(FKPEIHCGBMP DJJBBMHDENL, [Optional] string? DMOAADPMNCP, [Optional] BCAANPEMEIM? JHNDDBJGJEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x67F7BD0", Offset = "0x67F69D0", VA = "0x1867F7BD0")]
	public static GKAIFFACMCE HLBGONGBBKK(AJPBEAOBCOA HFKDIMNPCFD)
	{
		return default(GKAIFFACMCE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x67F7800", Offset = "0x67F6600", VA = "0x1867F7800")]
	public void BHKBGMIJGEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x67F8670", Offset = "0x67F7470", VA = "0x1867F8670")]
	internal BCAANPEMEIM NEIGJFGMEFM(BCAANPEMEIM LBFKPLENBBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x67F7D90", Offset = "0x67F6B90", VA = "0x1867F7D90")]
	internal IReadOnlyCollection<AJPBEAOBCOA> JJKBJMIFDEF(BCAANPEMEIM JHNDDBJGJEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x67F7A00", Offset = "0x67F6800", VA = "0x1867F7A00")]
	public bool FABKCKHOOPB(AJPBEAOBCOA HFKDIMNPCFD, bool KHKMODGICCD, string DHAPJLCANKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x67F81E0", Offset = "0x67F6FE0", VA = "0x1867F81E0")]
	public (bool, string) LAOEPCGEICC(AJPBEAOBCOA HFKDIMNPCFD)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x67F7960", Offset = "0x67F6760", VA = "0x1867F7960")]
	internal void EMEPBNFGOCK(AJPBEAOBCOA HFKDIMNPCFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x67F8430", Offset = "0x67F7230", VA = "0x1867F8430")]
	public GMLMJIJJFEL MMJMBJLHJFJ(Func<FKPEIHCGBMP, Guid> GLDKLDHBIKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x67F6B00", Offset = "0x67F5900", VA = "0x1867F6B00")]
	public void AHOMPLGFAFM(GMLMJIJJFEL HNBMONDKHFH, Func<Guid, FKPEIHCGBMP> EBJPPKHCIOB, [Optional] FKPEIHCGBMP? NIBNMENNCDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x67F8340", Offset = "0x67F7140", VA = "0x1867F8340")]
	[CompilerGenerated]
	private void MEGFGBPPJHH(AJPBEAOBCOA FJIHKOAOOOL, IKGJEKGKIIB DGCGBGAKHJD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface MJOJCEGFLAL
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HPFIEBGCMNF(PMEFCBBKLLD PJDCPIIMDAI, PMEFCBBKLLD DKAHMCICAOO, IEnumerable<PMEFCBBKLLD> MJGJIAAHCAL, out OCDELHMOFAN KNKBMGHCEJO, out DBEHIIFJBGP LGNBJKPOJPL);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum DBEHIIFJBGP : byte
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	InsufficientPermission,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	DisabledByRoom,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	CantKickEventOrganizer
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface FHGKLOMLFEE
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool HNMELPNCHIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool FDMKCJBGLLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	bool JLNNAMGGGOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	bool DMPIGPJDJEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	bool JLJPIPBAEIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	bool GJILLOCPPLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	bool FJKLBKFHGAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	bool PKFODGJFJLN
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	bool JNKNHCGPBJK
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool IIMHKFPCJND
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	bool LDOGNCOAINF
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	bool JIIHMPNEBIN
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	IReadOnlyList<string> MIKBPGDLMCK
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	OCDELHMOFAN NEGIGJEKODP
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface MHFDAJALDEH : FHGKLOMLFEE, EEKGAGKPBAJ, KJKAAOEELOK<AJPBEAOBCOA>
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	string CEGIIONMDEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	FKPEIHCGBMP IICLHJPPAMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) LIKJPMKLBEF<T>(AJPBEAOBCOA HFKDIMNPCFD) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal abstract class GBHONNLFJDG
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public object? DFJAICNEOII
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x86DAE0", Offset = "0x86C8E0", VA = "0x18086DAE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7F1B90", Offset = "0x7F0990", VA = "0x1807F1B90")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x8FF650", Offset = "0x8FE450", VA = "0x1808FF650")]
	protected GBHONNLFJDG(object? BBHFNCBKBIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool LOFJCELKDGG(object? KKLNCEHOHED);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class KECGOGAHOEP<T> : GBHONNLFJDG where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private T DAJJGAPHCEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly IEqualityComparer<T> PEBMGIGBOAF;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public T ODIKHJJHMMN
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x935A20", Offset = "0x934820", VA = "0x180935A20")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x41932E0", Offset = "0x41920E0", VA = "0x1841932E0", Slot = "4")]
	public override bool LOFJCELKDGG(object? KKLNCEHOHED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x4193940", Offset = "0x4192740", VA = "0x184193940")]
	public bool MGOMOGBCGMK(T FAIPCKHMHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4193C40", Offset = "0x4192A40", VA = "0x184193C40")]
	public KECGOGAHOEP(T DGNBLLFJDJH, IEqualityComparer<T> PEBMGIGBOAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal static class OFKCDDDJJHF
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[Flags]
	public enum MMPHDKNCJEB
	{
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		AG_EVERYONE = 0,
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		AG_CREATOR = 0x200000,
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		AG_COOWNER = 0x400000,
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		AG_HOST = 0x800000,
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		AG_MODERATOR = 0x1000000
	}

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public static readonly Guid CCFOLFFEFPA;

	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public static readonly Guid PCPCINBFKPG;

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public static readonly Guid CEIENNIJACL;

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public static readonly Guid BIJLLPKFGPP;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static readonly Guid MFBAMIHEPHB;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly LGNPNOJOALO<FKPEIHCGBMP, Guid> MGLIHANFAHM;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	internal static IEnumerable<FKPEIHCGBMP> DELOPCDMONG
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6802DD0", Offset = "0x6801BD0", VA = "0x186802DD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6802B50", Offset = "0x6801950", VA = "0x186802B50")]
	public static FKPEIHCGBMP AAAIBAKEDFN(Guid LOOGPKNLJEM)
	{
		return default(FKPEIHCGBMP);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6802E50", Offset = "0x6801C50", VA = "0x186802E50")]
	public static Guid NEKLGOGNEMK(FKPEIHCGBMP AEOENFGOMPH)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6802D30", Offset = "0x6801B30", VA = "0x186802D30")]
	public static bool FLAPFHKGAIN(FKPEIHCGBMP AEOENFGOMPH, out Guid LOOGPKNLJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6802BE0", Offset = "0x68019E0", VA = "0x186802BE0")]
	public static bool DBDGCDFDBME(Guid LOOGPKNLJEM, out FKPEIHCGBMP AEOENFGOMPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6802F00", Offset = "0x6801D00", VA = "0x186802F00")]
	public static FKPEIHCGBMP NOHMEAPFJHD(FKPEIHCGBMP AEOENFGOMPH)
	{
		return default(FKPEIHCGBMP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6802C80", Offset = "0x6801A80", VA = "0x186802C80")]
	public static MMPHDKNCJEB DDAADLGNCMB(FKPEIHCGBMP KMCPKFOKJNF)
	{
		return default(MMPHDKNCJEB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6802F30", Offset = "0x6801D30", VA = "0x186802F30")]
	internal static FKPEIHCGBMP ODPOOKEMNPF(MMPHDKNCJEB ONCGLJEDHJD)
	{
		return default(FKPEIHCGBMP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal delegate string PJEOPNDLHPN(object? KKLNCEHOHED);
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal delegate object MANAAOAODLG(string? GMMNKAHCOEK, [Optional] object DGNBLLFJDJH);
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal delegate GBHONNLFJDG DIJBDCCNABM();
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class LEBFBCJAHFO
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private class ILLJFEMLAJF : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		internal static ILLJFEMLAJF LNABDBHCENK;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x67FB870", Offset = "0x67FA670", VA = "0x1867FB870", Slot = "4")]
		public bool Equals(List<string> ELAKNHNBHMF, List<string> MNMNIIAFFPP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x67FB9D0", Offset = "0x67FA7D0", VA = "0x1867FB9D0", Slot = "5")]
		public int GetHashCode(List<string> GNOEFMFMEOO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public ILLJFEMLAJF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private class CBLKHEAFMLJ : HLPCPBHPKJH<OCDELHMOFAN>
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x67F8F80", Offset = "0x67F7D80", VA = "0x1867F8F80", Slot = "9")]
		public override string LKKGLINHIKF(OCDELHMOFAN CAHPHIOMEBI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x67F8D90", Offset = "0x67F7B90", VA = "0x1867F8D90", Slot = "10")]
		protected override bool INFOEFMMJIH(string CAHPHIOMEBI, out OCDELHMOFAN KKLNCEHOHED)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x67F9080", Offset = "0x67F7E80", VA = "0x1867F9080")]
		public CBLKHEAFMLJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static readonly PBKDLGICAOJ HDAIHNMAJLB;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly CBLKHEAFMLJ EHBEBJKOAAE;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static readonly List<DMPHMKIHNDH> HNBEMBJEFPE;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public IEnumerable<AJPBEAOBCOA> OBNNPCKGMGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x86DAE0", Offset = "0x86C8E0", VA = "0x18086DAE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public IReadOnlyDictionary<AJPBEAOBCOA, DMPHMKIHNDH> FEBNLODNFKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x67FC760", Offset = "0x67FB560", VA = "0x1867FC760")]
	public LEBFBCJAHFO([Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B3C30", Offset = "0x7B3030")] IList<DMPHMKIHNDH> DOJKMCAJGFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x67FBB70", Offset = "0x67FA970", VA = "0x1867FBB70")]
	public DMPHMKIHNDH HOADEEOGLFE(AJPBEAOBCOA HFKDIMNPCFD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class MJOGJNCMDCP : FLBGFELPIBP, IDFGMJAHNAL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class GEIFOINDHJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public BCAANPEMEIM newRole;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public GEIFOINDHJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x67FA210", Offset = "0x67F9010", VA = "0x1867FA210")]
		internal bool LLEJMAJHIDJ(BCAANPEMEIM rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class CPCBAMPKOLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public FKPEIHCGBMP roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public CPCBAMPKOLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x67F90C0", Offset = "0x67F7EC0", VA = "0x1867F90C0")]
		internal bool KHJCPMIJCAK(FKPEIHCGBMP r)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class HDEKAHCCMAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public FOHHNNEFOIN roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public MJOGJNCMDCP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private bool <isOffline>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private LMOPPMHLJAA <tokenAndPermissionsDto>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private bool <hasRoomRoles>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private LMOPPMHLJAA <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private bool <serverHasPermissions>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B41C0", Offset = "0x7B35C0")]
		private TaskAwaiter<LMOPPMHLJAA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public HDEKAHCCMAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x67FAD90", Offset = "0x67F9B90", VA = "0x1867FAD90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class MGCHPPFFOIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public MGCHPPFFOIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x67FD020", Offset = "0x67FBE20", VA = "0x1867FD020")]
		internal void KPAMFOENEMC(GMLMJIJJFEL r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x67FCEF0", Offset = "0x67FBCF0", VA = "0x1867FCEF0")]
		internal void IIBMLAPKPLL(GMLMJIJJFEL r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct PLCLCNGOCDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public FOHHNNEFOIN roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class BKMAAOPMALJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B4220", Offset = "0x7B3620")]
		public Func<GMLMJIJJFEL, IKGJEKGKIIB> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public BKMAAOPMALJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x67F8D20", Offset = "0x67F7B20", VA = "0x1867F8D20")]
		internal void OLCGOAIOGCK(GMLMJIJJFEL r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x67F8CB0", Offset = "0x67F7AB0", VA = "0x1867F8CB0")]
		internal void JHEIOJKHMJE(GMLMJIJJFEL r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x67F8C40", Offset = "0x67F7A40", VA = "0x1867F8C40")]
		internal void IJKFBPGKHAJ(GMLMJIJJFEL r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class OIDGGMFOAFP<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		private sealed class <<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public OIDGGMFOAFP<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private object <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			private int <>s__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			private Exception <ex>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B42E0", Offset = "0x7B36E0")]
			private TaskAwaiter<LMOPPMHLJAA> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x1C1AAB0", Offset = "0x1C198B0", VA = "0x181C1AAB0")]
			public <<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x2BA83D0", Offset = "0x2BA71D0", VA = "0x182BA83D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public MJOGJNCMDCP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public AJPBEAOBCOA rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public FKPEIHCGBMP accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public GKAIFFACMCE recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public string serializedNewValue;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x1C1AAB0", Offset = "0x1C198B0", VA = "0x181C1AAB0")]
		public OIDGGMFOAFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x3CD88C0", Offset = "0x3CD76C0", VA = "0x183CD88C0")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(OIDGGMFOAFP<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void BMKHFFOPIPA()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct AGDIKGHOGBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public IReadOnlyList<NMEDDPEPMIG> newPermissionOverrides;
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class GNNELOBILCD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public KGHNLHILJBF rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public FOHHNNEFOIN roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B4340", Offset = "0x7B3740")]
		public IReadOnlyDictionary<FKPEIHCGBMP, BCAANPEMEIM> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public CHFEFMDBOKH debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private StringBuilder <migrationLogBuilder>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B43A0", Offset = "0x7B37A0")]
		private List<NMEDDPEPMIG> <permissionsChangeBatch>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private IEnumerator<GMLMJIJJFEL> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private GMLMJIJJFEL <roleData>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private FKPEIHCGBMP <roleAccountType>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private BCAANPEMEIM <role>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private IReadOnlyList<AJPBEAOBCOA> <modifiedPermissions>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private IEnumerator<AJPBEAOBCOA> <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private AJPBEAOBCOA <permission>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private GKAIFFACMCE <recNetPermissionType>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B4400", Offset = "0x7B3800")]
		private (bool Overrides, string SerializedValue) <serializedData>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public GNNELOBILCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x67FA240", Offset = "0x67F9040", VA = "0x1867FA240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly KGHNLHILJBF IOPIAHJBGMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly DHNKBIJKPLF JDBELIKFEKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly CHFEFMDBOKH BFICOPHANKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly Dictionary<int, BCAANPEMEIM> IJOOMMAFDNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal readonly Dictionary<FKPEIHCGBMP, BCAANPEMEIM> NDHNOLDLJDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal readonly Dictionary<FKPEIHCGBMP, BCAANPEMEIM> EDCBNAJMALD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal readonly List<BCAANPEMEIM> IPMDNCNNCIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private bool MMDBJBPBACN;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static readonly AJPBEAOBCOA[] HLJJLPCKHKL;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public JHJJNANJBCJ OFANHDHFBBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public IEnumerable<MHFDAJALDEH> ALFBOCKOMAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6800480", Offset = "0x67FF280", VA = "0x186800480", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event AIIEIDLFJEA FANBPBKDCGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x68005A0", Offset = "0x67FF3A0", VA = "0x1868005A0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6801120", Offset = "0x67FFF20", VA = "0x186801120", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x67FE810", Offset = "0x67FD610", VA = "0x1867FE810")]
	[GIEEOCCBBIJ(EMJNPDDLMAF.Room, PFHGMCKNAFN.None)]
	private static void COJJPFAEHHI(OBEPLHILJNL ONJJGCPCIIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x68027D0", Offset = "0x68015D0", VA = "0x1868027D0")]
	[UnityEngine.Scripting.Preserve]
	internal MJOGJNCMDCP([DNPFPOCMFCA(null)] KGHNLHILJBF NPFIFLPIIJC, [DNPFPOCMFCA(null)] DHNKBIJKPLF BIBNPHMJJFK, [DNPFPOCMFCA(null)] CHFEFMDBOKH BFICOPHANKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x67FF340", Offset = "0x67FE140", VA = "0x1867FF340", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x67FF770", Offset = "0x67FE570", VA = "0x1867FF770")]
	private void GECJCPBAKIJ(IEnumerable<BCAANPEMEIM> CBFAJPOKKCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6800CB0", Offset = "0x67FFAB0", VA = "0x186800CB0", Slot = "12")]
	public bool LCBGDONNNAI(PMEFCBBKLLD BLBBPGEKKJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6800640", Offset = "0x67FF440", VA = "0x186800640")]
	private void JBDNFPBJHKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6802470", Offset = "0x6801270", VA = "0x186802470")]
	private void POMOMCOHGCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6800C30", Offset = "0x67FFA30", VA = "0x186800C30", Slot = "10")]
	public IReadOnlyList<MHFDAJALDEH> LBKGFFLOKCC(bool NMCBFGDEANM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x67FEDF0", Offset = "0x67FDBF0", VA = "0x1867FEDF0", Slot = "11")]
	public MHFDAJALDEH DHOOFILKCID(PMEFCBBKLLD BLBBPGEKKJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x68004D0", Offset = "0x67FF2D0", VA = "0x1868004D0")]
	private FKPEIHCGBMP IFEOJHNONOF(PMEFCBBKLLD BLBBPGEKKJJ)
	{
		return default(FKPEIHCGBMP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6801CA0", Offset = "0x6800AA0", VA = "0x186801CA0", Slot = "14")]
	public bool MJHMLGNCJIP(PMEFCBBKLLD CALHKIBOCCL, FKPEIHCGBMP AEOENFGOMPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x68011C0", Offset = "0x67FFFC0", VA = "0x1868011C0", Slot = "15")]
	public MHFDAJALDEH LIMKNFJBMLB(FKPEIHCGBMP AEOENFGOMPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6800820", Offset = "0x67FF620", VA = "0x186800820")]
	private static bool KDJEMFABMHD(GCDAKDEGJJA BAJHBJMNJLA, FKPEIHCGBMP AEOENFGOMPH, out GMLMJIJJFEL? OJBGPNMIFHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6800380", Offset = "0x67FF180", VA = "0x186800380")]
	private static void HDHOPCJHEMN(GCDAKDEGJJA BAJHBJMNJLA, Action<GMLMJIJJFEL> FPOANAADIKL, FKPEIHCGBMP KNDEFHJDBOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6800180", Offset = "0x67FEF80", VA = "0x186800180")]
	private static void HDHOPCJHEMN(GCDAKDEGJJA BAJHBJMNJLA, Action<GMLMJIJJFEL> FPOANAADIKL, Predicate<FKPEIHCGBMP> HPBADJJNIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6800650", Offset = "0x67FF450", VA = "0x186800650")]
	private void JMDIKODHIBL(PMEFCBBKLLD BLBBPGEKKJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x68006B0", Offset = "0x67FF4B0", VA = "0x1868006B0", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HDEKAHCCMAE))]
	public Task JNEENJFGINF([CanBeNull] FOHHNNEFOIN ODBMILJBDKN, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
	public void IJKKHAFHEJJ(ref FOHHNNEFOIN ODBMILJBDKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x67FEB70", Offset = "0x67FD970", VA = "0x1867FEB70")]
	private void DGGJFPILHJM(GCDAKDEGJJA FPMHFJFMKJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x67FF450", Offset = "0x67FE250", VA = "0x1867FF450")]
	internal static string GACEEDEIHMP(KGHNLHILJBF IOPIAHJBGMB, FOHHNNEFOIN ODBMILJBDKN, IReadOnlyDictionary<FKPEIHCGBMP, BCAANPEMEIM> NDHNOLDLJDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x67FD2E0", Offset = "0x67FC0E0", VA = "0x1867FD2E0")]
	private static void BIFIDIOBMJD(FOHHNNEFOIN ODBMILJBDKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6802150", Offset = "0x6800F50", VA = "0x186802150")]
	private static void PGPONHHKGCM(GCDAKDEGJJA ODOPIKGHOKD, IReadOnlyDictionary<FKPEIHCGBMP, BCAANPEMEIM> NDHNOLDLJDF, StringBuilder JLOFGNAKOFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x67FEF00", Offset = "0x67FDD00", VA = "0x1867FEF00")]
	private static bool DLNGGLBNEPN(string DBGKKACEOAI, out Guid AJEFACPKAPE, out FKPEIHCGBMP AEOENFGOMPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x67FE1F0", Offset = "0x67FCFF0", VA = "0x1867FE1F0")]
	private static void BPCALBEGGIO(FOHHNNEFOIN ODBMILJBDKN, StringBuilder JLOFGNAKOFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x281CA40", Offset = "0x281B840", VA = "0x18281CA40", Slot = "16")]
	public bool MBHOBMNGEEP<T>(FKPEIHCGBMP AEOENFGOMPH, AJPBEAOBCOA HFKDIMNPCFD, bool KHKMODGICCD, T GAECONBCCJH) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x67FD120", Offset = "0x67FBF20", VA = "0x1867FD120")]
	private void ALCPFBILOAG(FKPEIHCGBMP AEOENFGOMPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6800C10", Offset = "0x67FFA10", VA = "0x186800C10")]
	private bool KJHPBABOMEM(PMEFCBBKLLD BLBBPGEKKJJ, FKPEIHCGBMP AEOENFGOMPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6801E30", Offset = "0x6800C30", VA = "0x186801E30")]
	internal BCAANPEMEIM PFMMKEFOFLG(PMEFCBBKLLD BLBBPGEKKJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x6800590", Offset = "0x67FF390", VA = "0x186800590", Slot = "13")]
	public IReadOnlyList<MHFDAJALDEH> IGKPBLBEDPP(PMEFCBBKLLD BLBBPGEKKJJ, bool NMILCGLLOPH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x67FFF60", Offset = "0x67FED60", VA = "0x1867FFF60")]
	internal IReadOnlyList<BCAANPEMEIM> GEOOGDOAACO(PMEFCBBKLLD BLBBPGEKKJJ, bool NMILCGLLOPH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6801270", Offset = "0x6800070", VA = "0x186801270")]
	private void LJHFDGCFLNK(LMOPPMHLJAA OHOCKENDBDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x68019B0", Offset = "0x68007B0", VA = "0x1868019B0")]
	private static bool LPOAEGKONEN(BCAANPEMEIM LBFDLCFFEAJ, IReadOnlyDictionary<FKPEIHCGBMP, BCAANPEMEIM> NDHNOLDLJDF, out IReadOnlyList<AJPBEAOBCOA> PHLIPDJEHKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x67FE9D0", Offset = "0x67FD7D0", VA = "0x1867FE9D0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GNNELOBILCD))]
	private static Task DCBBPPGJBBB(KGHNLHILJBF IOPIAHJBGMB, FOHHNNEFOIN ODBMILJBDKN, IReadOnlyDictionary<FKPEIHCGBMP, BCAANPEMEIM> NDHNOLDLJDF, CHFEFMDBOKH BFICOPHANKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x67FF060", Offset = "0x67FDE60", VA = "0x1867FF060")]
	[CompilerGenerated]
	internal static void DPBODHKJJOB(Func<GMLMJIJJFEL, IKGJEKGKIIB> FOKJPMAPOKP, ref PLCLCNGOCDI P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x6800D80", Offset = "0x67FFB80", VA = "0x186800D80")]
	[CompilerGenerated]
	internal static bool LCJHKIDHDAC(FKPEIHCGBMP AEOENFGOMPH, AJPBEAOBCOA HFKDIMNPCFD, out NMEDDPEPMIG MMMCJIOHENC, ref AGDIKGHOGBJ P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public enum AJPBEAOBCOA
{
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	INVALID = -1,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	CAN_EDIT_ROOM_ROLES = 1,
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	VOTE_KICK_PERMISSION = 3,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	CAN_INVITE = 4,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	CAN_TALK = 6,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	CAN_PRINT_PHOTOS = 7,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	CAN_START_GAMES = 8,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	CAN_SELF_REVIVE = 9,
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	AUTO_ASSIGNED_GAME_ROLES = 11,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	CAN_CHANGE_GAME_MODE = 12,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	CAN_USE_MAKER_PEN = 13,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	CAN_USE_DELETE_ALL_BUTTON = 14,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	CAN_SAVE_INVENTIONS = 15,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	DISABLE_MIC_AUTO_MUTE = 16,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	CAN_END_GAMES_EARLY = 17,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	CAN_USE_SHARE_CAM = 18,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	DEPRECATED_CAN_EDIT_CIRCUITS = 19,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	CAN_SPAWN_INVENTIONS = 20,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	CAN_SPAWN_CONSUMABLES = 21,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	CAN_USE_ROOM_RESET_BUTTON = 22,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	CAN_USE_PLAY_GIZMOS_TOGGLE = 23
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal class OLEBBGFHLAN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly Dictionary<AJPBEAOBCOA, bool> JEOMKJCKDMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly Dictionary<AJPBEAOBCOA, GBHONNLFJDG> CGJAGBJJKGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly LEBFBCJAHFO FOEOCNJEIIO;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x68036E0", Offset = "0x68024E0", VA = "0x1868036E0")]
	public OLEBBGFHLAN(LEBFBCJAHFO FOEOCNJEIIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x68033E0", Offset = "0x68021E0", VA = "0x1868033E0")]
	public bool CNJHEFKGBAC(AJPBEAOBCOA HFKDIMNPCFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x3273660", Offset = "0x3272460", VA = "0x183273660")]
	public bool DAOKBLLBNAL<T>(AJPBEAOBCOA HFKDIMNPCFD, bool KHKMODGICCD, T KKLNCEHOHED) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x3273990", Offset = "0x3272790", VA = "0x183273990")]
	public (bool, T?) JDCKMCDMPKJ<T>(AJPBEAOBCOA HFKDIMNPCFD) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6803450", Offset = "0x6802250", VA = "0x186803450")]
	public bool DAOKBLLBNAL(AJPBEAOBCOA HFKDIMNPCFD, bool KHKMODGICCD, object KKLNCEHOHED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6803530", Offset = "0x6802330", VA = "0x186803530")]
	public (bool, object) JDCKMCDMPKJ(AJPBEAOBCOA HFKDIMNPCFD)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x3273BB0", Offset = "0x32729B0", VA = "0x183273BB0")]
	private void KLCFPMFPOAE<T>(AJPBEAOBCOA HFKDIMNPCFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6803620", Offset = "0x6802420", VA = "0x186803620")]
	private GBHONNLFJDG JLCMFFMDLMC(AJPBEAOBCOA HFKDIMNPCFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6803240", Offset = "0x6802040", VA = "0x186803240")]
	public void BHKBGMIJGEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface JHJJNANJBCJ
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	MHFDAJALDEH GMANNCNHFMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal class DHNKBIJKPLF : JHJJNANJBCJ
{
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public static DHNKBIJKPLF EBJKKPKMDKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	internal readonly BCAANPEMEIM GCDABKPLFJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	internal readonly IReadOnlyList<BCAANPEMEIM> GGBHDNPEDJP;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public MHFDAJALDEH GMANNCNHFMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x86DAE0", Offset = "0x86C8E0", VA = "0x18086DAE0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x67F9910", Offset = "0x67F8710", VA = "0x1867F9910")]
	public DHNKBIJKPLF(BCAANPEMEIM DHIKLGNALAI, IReadOnlyList<BCAANPEMEIM> ECPAAFLJCNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x67F90D0", Offset = "0x67F7ED0", VA = "0x1867F90D0")]
	private static DHNKBIJKPLF HIDPGLNOBMN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public enum EHNHDOMKBMK
{
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	Everyone
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

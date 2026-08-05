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
		[Cpp2IlInjected.Address(RVA = "0x78C450", Offset = "0x78B250", VA = "0x18078C450")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x62C1360", Offset = "0x62C0160", VA = "0x1862C1360")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x78C910", Offset = "0x78B710", VA = "0x18078C910")]
		public NullableAttribute(byte[] P_0)
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

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x78C950", Offset = "0x78B750", VA = "0x18078C950")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum LGKMCJOKOFM
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Vote,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Instant,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Off
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void EMKEILFKDIE<TPermission>(TPermission EEPEJGGJAGL);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void HKKAHAGADIH(GHMIEPPMENM NJAIFLCCJMF);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum PGDIJLHAMGK
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface ALFDIDKBCCJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool DALCOCLKJKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool NIIGOKJCDEM
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool IPFIELGGMKK
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool INEJMGKIJKD
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool FNLMBGGMHAH
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool AICAEMILCND
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal static class NAJJIHEOMID
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[Flags]
	public enum OEMAGCMDENJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		AG_EVERYONE = 0,
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		AG_CREATOR = 0x200000,
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		AG_COOWNER = 0x400000,
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		AG_HOST = 0x800000,
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		AG_MODERATOR = 0x1000000
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly Guid BALBMGPAICE;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid KBJMFGDIKFP;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid LOEHJBANHOA;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid HDCFDFLPPDB;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid BKCEHGOEPCA;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid INBHCNDMNHK;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly DODDJHOFOCN<NMOECCJMGEC, Guid> NFAKDLCGCOF;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal static IEnumerable<NMOECCJMGEC> NHOIIPGLPKI
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x62C0C80", Offset = "0x62BFA80", VA = "0x1862C0C80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x62C0BB0", Offset = "0x62BF9B0", VA = "0x1862C0BB0")]
	public static NMOECCJMGEC KIDLFDIHFMN(Guid FGCEIIELPBP)
	{
		return default(NMOECCJMGEC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x62C0B10", Offset = "0x62BF910", VA = "0x1862C0B10")]
	public static Guid JAGFEACHBMP(NMOECCJMGEC KPGLNKLFFEM)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x62C09D0", Offset = "0x62BF7D0", VA = "0x1862C09D0")]
	public static bool FHIPEIKOGFA(NMOECCJMGEC KPGLNKLFFEM, [Out] Guid FGCEIIELPBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x62C08F0", Offset = "0x62BF6F0", VA = "0x1862C08F0")]
	public static bool BBGLNKDEIOF(Guid FGCEIIELPBP, [Out] NMOECCJMGEC KPGLNKLFFEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x62C0990", Offset = "0x62BF790", VA = "0x1862C0990")]
	public static NMOECCJMGEC CCHLOBEFKEP(NMOECCJMGEC KPGLNKLFFEM)
	{
		return default(NMOECCJMGEC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x62C0A60", Offset = "0x62BF860", VA = "0x1862C0A60")]
	public static OEMAGCMDENJ IMGLGKMPDLJ(NMOECCJMGEC KFIFCPPKEME)
	{
		return default(OEMAGCMDENJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x62C0C40", Offset = "0x62BFA40", VA = "0x1862C0C40")]
	internal static NMOECCJMGEC OEKMOAIMFID(OEMAGCMDENJ AFPIABNEBDD)
	{
		return default(NMOECCJMGEC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface CKEMGNPJHKO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	BNCOCNPKLNI KHAKOBOGDFC
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IEnumerable<NJPAIBKKAEN> CCOFCMDOKHI
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event HKKAHAGADIH GDHGEGEBNJC;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<NJPAIBKKAEN> FOILFMICCHL(bool PAOAJDPBNOD = false);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NJPAIBKKAEN HDJHPIIFLMJ(GHMIEPPMENM NJAIFLCCJMF);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool NENNBPLHLFD(GHMIEPPMENM NJAIFLCCJMF);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<NJPAIBKKAEN> PBHCELFDPOO(GHMIEPPMENM NJAIFLCCJMF, bool PEJFJBPNFBN = false);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool FHCMIDLMNEE(GHMIEPPMENM HBIEPEPOFGC, NMOECCJMGEC KPGLNKLFFEM);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "9")]
	NJPAIBKKAEN EFLBMBCBKIM(NMOECCJMGEC KPGLNKLFFEM);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool DCCJILPPNHO<T>(NMOECCJMGEC KPGLNKLFFEM, OCAEFFBCEHG EEPEJGGJAGL, bool DBAFAPHLOHL, T OFPCPIFKKJA) where T : notnull;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface COLOAGDBCAJ
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task BMJNKFHEOIA(BNNAHCBMALA MFKPIJLKLHA, CancellationToken BIBHFGFDEGJ);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DFOMFLKDPBJ(BNNAHCBMALA MFKPIJLKLHA);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface DBCBLCPPACK
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	GHMIEPPMENM ICKPDINPLLD
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	JCOMCEDKFBJ FFIAPDMBNPM
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	OABHNCNHAAJ KECNBLJDMPF
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<CHMLGGBGCGD> PDNJMADBGAI;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action CNNJLNHJMME;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "4")]
	NMOECCJMGEC KOPBKGCGBLA(GHMIEPPMENM NJAIFLCCJMF);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<CHMLGGBGCGD> HICGLBCPNJJ(CancellationToken BIBHFGFDEGJ);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task LFLOMCKJJLF(long NGLNDFKLBFL, long PIJEGGFFPOI, IReadOnlyList<AOGDBFLKEHG> AIDLFENKHAE);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<GHMIEPPMENM> OLNOAFOKJJF();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class MKDELPGGDHH
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x62C0890", Offset = "0x62BF690", VA = "0x1862C0890")]
	public static NMOECCJMGEC PHMCIJLGMJG(this DBCBLCPPACK GAFMKBFLIEB)
	{
		return default(NMOECCJMGEC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface OOKLIPANNGO<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string GBEOPAAKBKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event EMKEILFKDIE<TPermission> NMBDJNHKKNE;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal abstract class JIEOAFHNKGA
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? PLPMHMAPIOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x763950", Offset = "0x762750", VA = "0x180763950")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x763960", Offset = "0x762760", VA = "0x180763960")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x763A40", Offset = "0x762840", VA = "0x180763A40")]
	protected JIEOAFHNKGA(object? KDEABNPACMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool KBFLDJGNINP(object? GNLEHBFFNFG);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal class JAADNKLBEOK<T> : JIEOAFHNKGA where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private T BMIFJMILHNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly IEqualityComparer<T> KBMCPEOIHOH;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T GMPOHOAMMIO
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7D0BF0", Offset = "0x7CF9F0", VA = "0x1807D0BF0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3811620", Offset = "0x3810420", VA = "0x183811620", Slot = "4")]
	public override bool KBFLDJGNINP(object? GNLEHBFFNFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3810FF0", Offset = "0x380FDF0", VA = "0x183810FF0")]
	public bool CADGJNILEEL(T EBMLELCBGCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3811820", Offset = "0x3810620", VA = "0x183811820")]
	public JAADNKLBEOK(T HEDIGKLLBHN, IEqualityComparer<T> KBMCPEOIHOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class KCMHHMNJGBH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<OCAEFFBCEHG, bool> CIBHGLCNDBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Dictionary<OCAEFFBCEHG, JIEOAFHNKGA> HGBIEFAFPJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly JBGECNLBMLD LGNFGCPFPCI;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x62BFF20", Offset = "0x62BED20", VA = "0x1862BFF20")]
	public KCMHHMNJGBH(JBGECNLBMLD LGNFGCPFPCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x62BFB00", Offset = "0x62BE900", VA = "0x1862BFB00")]
	public bool DEBIPILIDMB(OCAEFFBCEHG EEPEJGGJAGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x23F9FF0", Offset = "0x23F8DF0", VA = "0x1823F9FF0")]
	public bool JOJHMALCHAH<T>(OCAEFFBCEHG EEPEJGGJAGL, bool DBAFAPHLOHL, T GNLEHBFFNFG) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x23F9BE0", Offset = "0x23F89E0", VA = "0x1823F9BE0")]
	public (bool, T?) BGICFCFJHNH<T>(OCAEFFBCEHG EEPEJGGJAGL) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x62BFD70", Offset = "0x62BEB70", VA = "0x1862BFD70")]
	public bool JOJHMALCHAH(OCAEFFBCEHG EEPEJGGJAGL, bool DBAFAPHLOHL, object GNLEHBFFNFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x62BFA30", Offset = "0x62BE830", VA = "0x1862BFA30")]
	public (bool, object) BGICFCFJHNH(OCAEFFBCEHG EEPEJGGJAGL)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x23F9FB0", Offset = "0x23F8DB0", VA = "0x1823F9FB0")]
	private void EEMBJELGFHJ<T>(OCAEFFBCEHG EEPEJGGJAGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x62BFE50", Offset = "0x62BEC50", VA = "0x1862BFE50")]
	private JIEOAFHNKGA NCLBOLJMNEJ(OCAEFFBCEHG EEPEJGGJAGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x62BFB70", Offset = "0x62BE970", VA = "0x1862BFB70")]
	public void EKHLNJEJFOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class OAFMOKKDLNK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly string JDBNGHCMKPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly Type EAHOFICODDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly KNJFBPMPNFE NONGALCLAJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly OCAEFFBCEHG BPEAMMDEFCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public EIMKODCCPNO PAOHJKMOPJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public OEGPMDGAHCO BNFFGDGHNEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public DBBIJCKDOND IPGCFLAFFCB;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x62C14E0", Offset = "0x62C02E0", VA = "0x1862C14E0")]
	public OAFMOKKDLNK(Type EGMOOKINFJM, string JOOJCKANKDG, OCAEFFBCEHG EEPEJGGJAGL, EIMKODCCPNO GGFOOAFAEKC, OEGPMDGAHCO NMGFEGJLAPI, DBBIJCKDOND BKKFINIFCJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x62C1490", Offset = "0x62C0290", VA = "0x1862C1490")]
	public object FOOBJLNBEPC(object? MFMJJEFODHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x24EBDB0", Offset = "0x24EABB0", VA = "0x1824EBDB0")]
	public void EEMBJELGFHJ<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x62C13E0", Offset = "0x62C01E0", VA = "0x1862C13E0")]
	public void EEMBJELGFHJ(Type IDLCDPEENPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class CIFPAOODFME<T> : OAFMOKKDLNK where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal delegate string OBDJEPFAGLD(T GNLEHBFFNFG);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate T ANGGBNAEEPE(string? PNCFAADEKLD, T HEDIGKLLBHN);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class BFFLJHALOBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public OBDJEPFAGLD serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public ANGGBNAEEPE parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public BFFLJHALOBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x443F6B0", Offset = "0x443E4B0", VA = "0x18443F6B0")]
		internal string ALHPMIMOIKG(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x443F7F0", Offset = "0x443E5F0", VA = "0x18443F7F0")]
		internal object LCKCBPFJFIB(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4842CC0", Offset = "0x4841AC0", VA = "0x184842CC0")]
	public CIFPAOODFME(OCAEFFBCEHG EEPEJGGJAGL, string JOOJCKANKDG, [Optional] OBDJEPFAGLD? GGFOOAFAEKC, [Optional] ANGGBNAEEPE? NMGFEGJLAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4841890", Offset = "0x4840690", VA = "0x184841890")]
	private static object? EFHLMHLMFOG(ANGGBNAEEPE? NMGFEGJLAPI, string? PNCFAADEKLD, object? HEDIGKLLBHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4842120", Offset = "0x4840F20", VA = "0x184842120")]
	private static string GKMCGBDALGF(OBDJEPFAGLD? GGHNAKLECJB, object? GNLEHBFFNFG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal delegate string EIMKODCCPNO(object? GNLEHBFFNFG);
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate object OEGPMDGAHCO(string? PNCFAADEKLD, [Optional] object HEDIGKLLBHN);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate JIEOAFHNKGA DBBIJCKDOND();
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class JBGECNLBMLD
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class NMFIBBLMGIJ : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		internal static NMFIBBLMGIJ GOPCOAILBIE;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x62C1020", Offset = "0x62BFE20", VA = "0x1862C1020", Slot = "4")]
		public bool Equals(List<string> HOELCINBFKH, List<string> JOHINIOFBIJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x62C1170", Offset = "0x62BFF70", VA = "0x1862C1170", Slot = "5")]
		public int GetHashCode(List<string> HBDENJGMDDF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public NMFIBBLMGIJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class ANJBAFJEJFJ : GLMJIMIONAD<LGKMCJOKOFM>
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x62B7C20", Offset = "0x62B6A20", VA = "0x1862B7C20", Slot = "9")]
		public override string GKMCGBDALGF(LGKMCJOKOFM ENGEPLNNBDC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x62B7A40", Offset = "0x62B6840", VA = "0x1862B7A40", Slot = "10")]
		protected override bool FJDMAKEKAGF(string ENGEPLNNBDC, [Out] LGKMCJOKOFM GNLEHBFFNFG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x62B7D10", Offset = "0x62B6B10", VA = "0x1862B7D10")]
		public ANJBAFJEJFJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly ODOAHHLLHKM PIHBFCMBBMA;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static readonly ANJBAFJEJFJ CNGECNBFHNG;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly List<OAFMOKKDLNK> MKLNBDIBIBO;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<OCAEFFBCEHG> LBANEJLKAKL
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x763950", Offset = "0x762750", VA = "0x180763950")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<OCAEFFBCEHG, OAFMOKKDLNK> EJHFDOJGIAM
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x62BF3D0", Offset = "0x62BE1D0", VA = "0x1862BF3D0")]
	public JBGECNLBMLD([Optional] IList<OAFMOKKDLNK>? BHOGHFODEGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x62BE560", Offset = "0x62BD360", VA = "0x1862BE560")]
	public OAFMOKKDLNK PBKMKCPMMGM(OCAEFFBCEHG EEPEJGGJAGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface BNCOCNPKLNI
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	NJPAIBKKAEN DBMAFHJNLPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class FCKBDCIILKA : BNCOCNPKLNI
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static FCKBDCIILKA IEODCHODAMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly PNCJJNBMEKI IIBGACEIEGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal readonly IReadOnlyList<PNCJJNBMEKI> EJOLIJGAOBH;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public NJPAIBKKAEN DBMAFHJNLPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x763950", Offset = "0x762750", VA = "0x180763950", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x62BE250", Offset = "0x62BD050", VA = "0x1862BE250")]
	public FCKBDCIILKA(PNCJJNBMEKI APFJJEBDJAB, IReadOnlyList<PNCJJNBMEKI> FNECNFKMFNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x62BD820", Offset = "0x62BC620", VA = "0x1862BD820")]
	private static FCKBDCIILKA AIKFEMIPAMK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class JPJGIPFLLFI
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly IReadOnlyList<NMOECCJMGEC> FMDPONMGHOE;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x62BF720", Offset = "0x62BE520", VA = "0x1862BF720")]
	public static bool AMLBHBFLNOD(this GHMIEPPMENM GMGHMLHOMNF, NMOECCJMGEC KPGLNKLFFEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x62BF800", Offset = "0x62BE600", VA = "0x1862BF800")]
	public static bool CAPKJBPNCMF(this GHMIEPPMENM GMGHMLHOMNF, NMOECCJMGEC KPGLNKLFFEM, OABHNCNHAAJ GJLKFCILFEP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface BBLMLECCHEK
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool CBJGBJBIKHP
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool CCLJBFOAPGA
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool AAPKPPHLPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool LFLEIOGLICK
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool DIBMOJANHAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool DLJDPBNLEHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool JGJCBHIFACN
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool HHJLKFGECLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool NMDDPBHPAKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool JJEAFPLJEKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool COJKCHIPDDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool JBLHPGBFBDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IReadOnlyList<string> NDBFKFNAKBO
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	LGKMCJOKOFM MJKOCPPPMIA
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface NJPAIBKKAEN : BBLMLECCHEK, ALFDIDKBCCJ, OOKLIPANNGO<OCAEFFBCEHG>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string PEPNGNBNDPH
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	NMOECCJMGEC NPMIJBHFIJC
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) BDCHNNPJPBI<T>(OCAEFFBCEHG EEPEJGGJAGL) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public enum OCAEFFBCEHG
{
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	INVALID = -1,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	CAN_EDIT_ROOM_ROLES = 1,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	VOTE_KICK_PERMISSION = 3,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	CAN_INVITE = 4,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	CAN_TALK = 6,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	CAN_PRINT_PHOTOS = 7,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	CAN_START_GAMES = 8,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	CAN_SELF_REVIVE = 9,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	AUTO_ASSIGNED_GAME_ROLES = 11,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	CAN_CHANGE_GAME_MODE = 12,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	CAN_USE_MAKER_PEN = 13,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	CAN_USE_DELETE_ALL_BUTTON = 14,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	CAN_SAVE_INVENTIONS = 15,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	DISABLE_MIC_AUTO_MUTE = 16,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	CAN_END_GAMES_EARLY = 17,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	CAN_USE_SHARE_CAM = 18,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	DEPRECATED_CAN_EDIT_CIRCUITS = 19,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	CAN_SPAWN_INVENTIONS = 20,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	CAN_SPAWN_CONSUMABLES = 21,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	CAN_USE_ROOM_RESET_BUTTON = 22,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	CAN_USE_PLAY_GIZMOS_TOGGLE = 23,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	AUTO_ASSIGNED_PLAYER_TAGS = 24
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal class PNCJJNBMEKI : NJPAIBKKAEN, BBLMLECCHEK, ALFDIDKBCCJ, OOKLIPANNGO<OCAEFFBCEHG>
{
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal static readonly JBGECNLBMLD KLEHOPDJPEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal readonly KCMHHMNJGBH KABCJNDIKJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private string? LMBMPCFIABO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private string? DILHHCHKKDG;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool IPIBLMCPDPG
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x62C2A80", Offset = "0x62C1880", VA = "0x1862C2A80", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool GAPAAIMKBGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x62C3A70", Offset = "0x62C2870", VA = "0x1862C3A70", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private bool KNODICKHDFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x62C2A30", Offset = "0x62C1830", VA = "0x1862C2A30", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool HNBGCGJBGEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x62C37B0", Offset = "0x62C25B0", VA = "0x1862C37B0", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private bool KAKGCDEHBOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x62C3F30", Offset = "0x62C2D30", VA = "0x1862C3F30", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private bool FJFKPMIFPDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x62C3850", Offset = "0x62C2650", VA = "0x1862C3850", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public NMOECCJMGEC NPMIJBHFIJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7D0BF0", Offset = "0x7CF9F0", VA = "0x1807D0BF0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(NMOECCJMGEC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x764430", Offset = "0x763230", VA = "0x180764430")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string GBEOPAAKBKF
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x62C3760", Offset = "0x62C2560", VA = "0x1862C3760", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x62C3450", Offset = "0x62C2250", VA = "0x1862C3450")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string PEPNGNBNDPH
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x62C3760", Offset = "0x62C2560", VA = "0x1862C3760", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool PCBEAAEBGCK
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7D2B30", Offset = "0x7D1930", VA = "0x1807D2B30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7D2770", Offset = "0x7D1570", VA = "0x1807D2770")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool CBJGBJBIKHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x62C35A0", Offset = "0x62C23A0", VA = "0x1862C35A0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public LGKMCJOKOFM MJKOCPPPMIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x62C3F80", Offset = "0x62C2D80", VA = "0x1862C3F80", Slot = "20")]
		get
		{
			return default(LGKMCJOKOFM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool CCLJBFOAPGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x62C42B0", Offset = "0x62C30B0", VA = "0x1862C42B0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool AAPKPPHLPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x62C4460", Offset = "0x62C3260", VA = "0x1862C4460", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool LFLEIOGLICK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x62C3800", Offset = "0x62C2600", VA = "0x1862C3800", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool DIBMOJANHAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x62C39D0", Offset = "0x62C27D0", VA = "0x1862C39D0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool DLJDPBNLEHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x62C35F0", Offset = "0x62C23F0", VA = "0x1862C35F0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool JGJCBHIFACN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x62C48B0", Offset = "0x62C36B0", VA = "0x1862C48B0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool HHJLKFGECLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x62C3A20", Offset = "0x62C2820", VA = "0x1862C3A20", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool NMDDPBHPAKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x62C29E0", Offset = "0x62C17E0", VA = "0x1862C29E0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IReadOnlyList<string> NDBFKFNAKBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x62C4350", Offset = "0x62C3150", VA = "0x1862C4350", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool DEHDDLBAJLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x62C2A80", Offset = "0x62C1880", VA = "0x1862C2A80", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool ECIPOCEELEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x62C3F30", Offset = "0x62C2D30", VA = "0x1862C3F30", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool FNHHPCNONEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x62C3A70", Offset = "0x62C2870", VA = "0x1862C3A70", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool JJEAFPLJEKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x62C3980", Offset = "0x62C2780", VA = "0x1862C3980", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool COJKCHIPDDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x62C3640", Offset = "0x62C2440", VA = "0x1862C3640", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool FNLDPIBLCFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x62C2A30", Offset = "0x62C1830", VA = "0x1862C2A30", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool JBLHPGBFBDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x62C3930", Offset = "0x62C2730", VA = "0x1862C3930", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool AFNKGBADEKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x62C37B0", Offset = "0x62C25B0", VA = "0x1862C37B0", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool DECJFIMOPAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x62C3850", Offset = "0x62C2650", VA = "0x1862C3850", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event EMKEILFKDIE<OCAEFFBCEHG> NMBDJNHKKNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x62C43B0", Offset = "0x62C31B0", VA = "0x1862C43B0", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x62C3690", Offset = "0x62C2490", VA = "0x1862C3690", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x250D0C0", Offset = "0x250BEC0", VA = "0x18250D0C0", Slot = "6")]
	public (bool, T?) BDCHNNPJPBI<T>(OCAEFFBCEHG EEPEJGGJAGL) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x250D250", Offset = "0x250C050", VA = "0x18250D250")]
	public PNCJJNBMEKI EDLJFEMLFNN<T>(OCAEFFBCEHG EEPEJGGJAGL, bool DBAFAPHLOHL, T GNLEHBFFNFG) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x62C4A40", Offset = "0x62C3840", VA = "0x1862C4A40")]
	public PNCJJNBMEKI(NMOECCJMGEC KPGLNKLFFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x62C4990", Offset = "0x62C3790", VA = "0x1862C4990")]
	public PNCJJNBMEKI(NMOECCJMGEC KPGLNKLFFEM, [Optional] string? LMBMPCFIABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x62C49B0", Offset = "0x62C37B0", VA = "0x1862C49B0")]
	public PNCJJNBMEKI(PNCJJNBMEKI CBBBNJKLFAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x62C4A60", Offset = "0x62C3860", VA = "0x1862C4A60")]
	internal PNCJJNBMEKI(NMOECCJMGEC KEMCOAOOOBA, [Optional] string? LMBMPCFIABO, [Optional] PNCJJNBMEKI? CBBBNJKLFAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x62C4830", Offset = "0x62C3630", VA = "0x1862C4830")]
	public static KNJFBPMPNFE OPHFKOKFHNO(OCAEFFBCEHG EEPEJGGJAGL)
	{
		return default(KNJFBPMPNFE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x62C3740", Offset = "0x62C2540", VA = "0x1862C3740")]
	public void EKHLNJEJFOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x62C44B0", Offset = "0x62C32B0", VA = "0x1862C44B0")]
	internal PNCJJNBMEKI OPDJHGNMKDA(PNCJJNBMEKI JFJGHICCLBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x62C3AC0", Offset = "0x62C28C0", VA = "0x1862C3AC0")]
	internal IReadOnlyCollection<OCAEFFBCEHG> KBCPIACFDGK(PNCJJNBMEKI CBBBNJKLFAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x62C41D0", Offset = "0x62C2FD0", VA = "0x1862C41D0")]
	public bool MHDPLKNMLPK(OCAEFFBCEHG EEPEJGGJAGL, bool DBAFAPHLOHL, string LGNDMNGPHAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x62C34A0", Offset = "0x62C22A0", VA = "0x1862C34A0")]
	public (bool, string) DJFAGMBIIJN(OCAEFFBCEHG EEPEJGGJAGL)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x62C4300", Offset = "0x62C3100", VA = "0x1862C4300")]
	internal void NBMOJNANCMK(OCAEFFBCEHG EEPEJGGJAGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x62C3FD0", Offset = "0x62C2DD0", VA = "0x1862C3FD0")]
	public CBCPHNCNFHC MFFIMDELKOD(Func<NMOECCJMGEC, Guid> DNOOLJAMOGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x62C2AD0", Offset = "0x62C18D0", VA = "0x1862C2AD0")]
	public void CPABCFCEHMI(CBCPHNCNFHC IFKFPMFOBCO, Func<Guid, NMOECCJMGEC> JCMKIJKEOBB, [Optional] NMOECCJMGEC? GHKINHCBHAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x62C38A0", Offset = "0x62C26A0", VA = "0x1862C38A0")]
	[CompilerGenerated]
	private void HLGBGBKEFGO(OCAEFFBCEHG GNCCMFBDMAH, DICFOBFCAFN KJDNKOBOCCD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class CCJNODGEECM : COLOAGDBCAJ, CKEMGNPJHKO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class BPIFLPFGFAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public PNCJJNBMEKI newRole;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public BPIFLPFGFAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x62B7D50", Offset = "0x62B6B50", VA = "0x1862B7D50")]
		internal bool HFBKJBBBDGN(PNCJJNBMEKI rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class CFGLAGCHNGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public NMOECCJMGEC roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public CFGLAGCHNGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x62BD810", Offset = "0x62BC610", VA = "0x1862BD810")]
		internal bool EGNCAJFJGPI(NMOECCJMGEC r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct MDAEIILBJIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public CCJNODGEECM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public BNNAHCBMALA roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private TaskAwaiter<CHMLGGBGCGD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x62C01D0", Offset = "0x62BEFD0", VA = "0x1862C01D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x62C0830", Offset = "0x62BF630", VA = "0x1862C0830", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class IFDOHJAFKGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public IFDOHJAFKGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x62BE360", Offset = "0x62BD160", VA = "0x1862BE360")]
		internal void AIBLNFJIGAB(CBCPHNCNFHC r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x62BE440", Offset = "0x62BD240", VA = "0x1862BE440")]
		internal void PODGBGLPMCH(CBCPHNCNFHC r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct EILEHJNHMGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public BNNAHCBMALA roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class OHBMKHEEFDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public Func<CBCPHNCNFHC, DICFOBFCAFN> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public OHBMKHEEFDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x62C2120", Offset = "0x62C0F20", VA = "0x1862C2120")]
		internal void EHNEBJFOAMG(CBCPHNCNFHC r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x62C20F0", Offset = "0x62C0EF0", VA = "0x1862C20F0")]
		internal void DGGCLNELJAK(CBCPHNCNFHC r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x62C2150", Offset = "0x62C0F50", VA = "0x1862C2150")]
		internal void NKDNGKNGIHI(CBCPHNCNFHC r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class BCEJLANAGBB<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private struct <<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public BCEJLANAGBB<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			private object <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			private int <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			private TaskAwaiter<CHMLGGBGCGD> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x2E8CCB0", Offset = "0x2E8BAB0", VA = "0x182E8CCB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x841FE0", Offset = "0x840DE0", VA = "0x180841FE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public CCJNODGEECM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public OCAEFFBCEHG rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public NMOECCJMGEC accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public KNJFBPMPNFE recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public string serializedNewValue;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public BCEJLANAGBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x443BE20", Offset = "0x443AC20", VA = "0x18443BE20")]
		[AsyncStateMachine(typeof(BCEJLANAGBB<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void PGFNGKEBHKP()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct EIOBAOMJKEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public IReadOnlyList<AOGDBFLKEHG> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct OCLJLGEIDOE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public DBCBLCPPACK rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public BNNAHCBMALA roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public IReadOnlyDictionary<NMOECCJMGEC, PNCJJNBMEKI> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public BJLDAKNNLCA debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x62C1580", Offset = "0x62C0380", VA = "0x1862C1580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x62C2090", Offset = "0x62C0E90", VA = "0x1862C2090", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly DBCBLCPPACK GAFMKBFLIEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly FCKBDCIILKA KFGJMEMDLPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly BJLDAKNNLCA EADEHPCPKJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly Dictionary<int, PNCJJNBMEKI> EENMEDEECAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	internal readonly Dictionary<NMOECCJMGEC, PNCJJNBMEKI> NNDADOKGLIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	internal readonly Dictionary<NMOECCJMGEC, PNCJJNBMEKI> FEOKGABFPBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	internal readonly List<PNCJJNBMEKI> KCPJHGEOEMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private bool GJBDPCGIFLP;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly OCAEFFBCEHG[] EJCDGKBFPOO;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public BNCOCNPKLNI KHAKOBOGDFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<NJPAIBKKAEN> CCOFCMDOKHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x62B7D80", Offset = "0x62B6B80", VA = "0x1862B7D80", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event HKKAHAGADIH GDHGEGEBNJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x62BA030", Offset = "0x62B8E30", VA = "0x1862BA030", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x62B7E40", Offset = "0x62B6C40", VA = "0x1862B7E40", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x62BBCD0", Offset = "0x62BAAD0", VA = "0x1862BBCD0")]
	[GAPOPKHLLNB(KLEBEPKJPOL.Room, OGJCEJIMIKL.None)]
	private static void NHJLANHPGEE(OILPPPCALMB IDMCGGBGLJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x62BD550", Offset = "0x62BC350", VA = "0x1862BD550")]
	[UnityEngine.Scripting.Preserve]
	internal CCJNODGEECM([NMBHAKGIBHG(null)] DBCBLCPPACK NBOPCBIOMKI, [NMBHAKGIBHG(null)] FCKBDCIILKA DALNKGJFJKK, [NMBHAKGIBHG(null)] BJLDAKNNLCA EADEHPCPKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x62B9F20", Offset = "0x62B8D20", VA = "0x1862B9F20", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x62BCA30", Offset = "0x62BB830", VA = "0x1862BCA30")]
	private void PFNNJFAAFCC(IEnumerable<PNCJJNBMEKI> AAIKDJNKGLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x62BBC00", Offset = "0x62BAA00", VA = "0x1862BBC00", Slot = "12")]
	public bool NENNBPLHLFD(GHMIEPPMENM NJAIFLCCJMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x62B9900", Offset = "0x62B8700", VA = "0x1862B9900")]
	private void CNNJLNHJMME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x62BBA10", Offset = "0x62BA810", VA = "0x1862BBA10")]
	private void MELMKFHDNBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x62BAA40", Offset = "0x62B9840", VA = "0x1862BAA40", Slot = "10")]
	public IReadOnlyList<NJPAIBKKAEN> FOILFMICCHL(bool PAOAJDPBNOD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x62BB250", Offset = "0x62BA050", VA = "0x1862BB250", Slot = "11")]
	public NJPAIBKKAEN HDJHPIIFLMJ(GHMIEPPMENM NJAIFLCCJMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x62BD2B0", Offset = "0x62BC0B0", VA = "0x1862BD2B0")]
	private NMOECCJMGEC PLGAFGGKLHP(GHMIEPPMENM NJAIFLCCJMF)
	{
		return default(NMOECCJMGEC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x62BA8B0", Offset = "0x62B96B0", VA = "0x1862BA8B0", Slot = "14")]
	public bool FHCMIDLMNEE(GHMIEPPMENM HBIEPEPOFGC, NMOECCJMGEC KPGLNKLFFEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x62BA0D0", Offset = "0x62B8ED0", VA = "0x1862BA0D0", Slot = "15")]
	public NJPAIBKKAEN EFLBMBCBKIM(NMOECCJMGEC KPGLNKLFFEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x62B8CF0", Offset = "0x62B7AF0", VA = "0x1862B8CF0")]
	private static bool BBFIAPAMFME(AEPEKAHDAEA AKDBALDFEDJ, NMOECCJMGEC KPGLNKLFFEM, [Out] CBCPHNCNFHC? BACGLJFOGOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x62B9580", Offset = "0x62B8380", VA = "0x1862B9580")]
	private static void CMNMDCECLME(AEPEKAHDAEA AKDBALDFEDJ, Action<CBCPHNCNFHC> KOILCGGEPAI, NMOECCJMGEC PCJNHBPBDDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x62B9670", Offset = "0x62B8470", VA = "0x1862B9670")]
	private static void CMNMDCECLME(AEPEKAHDAEA AKDBALDFEDJ, Action<CBCPHNCNFHC> KOILCGGEPAI, Predicate<NMOECCJMGEC> DOCEIEINJCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x62B7DD0", Offset = "0x62B6BD0", VA = "0x1862B7DD0")]
	private void AIKOBEHEACK(GHMIEPPMENM NJAIFLCCJMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x62B9020", Offset = "0x62B7E20", VA = "0x1862B9020", Slot = "4")]
	[AsyncStateMachine(typeof(MDAEIILBJIA))]
	public Task BMJNKFHEOIA([CanBeNull] BNNAHCBMALA MFKPIJLKLHA, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "5")]
	public void DFOMFLKDPBJ(BNNAHCBMALA MFKPIJLKLHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x62BB6B0", Offset = "0x62BA4B0", VA = "0x1862BB6B0")]
	private void IKJONHDHIOM(AEPEKAHDAEA DOBPLEELPBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x62BAC00", Offset = "0x62B9A00", VA = "0x1862BAC00")]
	internal static string GAKHGFHMIOA(DBCBLCPPACK GAFMKBFLIEB, BNNAHCBMALA MFKPIJLKLHA, IReadOnlyDictionary<NMOECCJMGEC, PNCJJNBMEKI> NNDADOKGLIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x62B7EE0", Offset = "0x62B6CE0", VA = "0x1862B7EE0")]
	private static void AOBFNPMHDBC(BNNAHCBMALA MFKPIJLKLHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x62BB360", Offset = "0x62BA160", VA = "0x1862BB360")]
	private static void IHAOFBIAMIB(AEPEKAHDAEA KFKIOGCPBMF, IReadOnlyDictionary<NMOECCJMGEC, PNCJJNBMEKI> NNDADOKGLIJ, StringBuilder KAOKAOABEOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x62BC620", Offset = "0x62BB420", VA = "0x1862BC620")]
	private static bool NOIAAKLKBND(string OEPJGGFJMPP, [Out] Guid FKMIHFGPKBO, [Out] NMOECCJMGEC KPGLNKLFFEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x62BA170", Offset = "0x62B8F70", VA = "0x1862BA170")]
	private static void FAFJDFGNHOH(BNNAHCBMALA MFKPIJLKLHA, StringBuilder KAOKAOABEOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x21C9390", Offset = "0x21C8190", VA = "0x1821C9390", Slot = "16")]
	public bool DCCJILPPNHO<T>(NMOECCJMGEC KPGLNKLFFEM, OCAEFFBCEHG EEPEJGGJAGL, bool DBAFAPHLOHL, T OFPCPIFKKJA) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x62B9140", Offset = "0x62B7F40", VA = "0x1862B9140")]
	private void CFBIGPBLHHO(NMOECCJMGEC KPGLNKLFFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x62BB9F0", Offset = "0x62BA7F0", VA = "0x1862BB9F0")]
	private bool MDEBDKENKOO(GHMIEPPMENM NJAIFLCCJMF, NMOECCJMGEC KPGLNKLFFEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x62BAF00", Offset = "0x62B9D00", VA = "0x1862BAF00")]
	internal PNCJJNBMEKI HAGOKANCDEK(GHMIEPPMENM NJAIFLCCJMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x62BC730", Offset = "0x62BB530", VA = "0x1862BC730", Slot = "13")]
	public IReadOnlyList<NJPAIBKKAEN> PBHCELFDPOO(GHMIEPPMENM NJAIFLCCJMF, bool PEJFJBPNFBN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x62B9350", Offset = "0x62B8150", VA = "0x1862B9350")]
	internal IReadOnlyList<PNCJJNBMEKI> CFKFAEHMGAJ(GHMIEPPMENM NJAIFLCCJMF, bool PEJFJBPNFBN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x62BBE90", Offset = "0x62BAC90", VA = "0x1862BBE90")]
	private void NOHMODKJOGC(CHMLGGBGCGD HHBJOICGINO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x62BC740", Offset = "0x62BB540", VA = "0x1862BC740")]
	private static bool PCKAIHGKGAI(PNCJJNBMEKI CKFNHDOCDFL, IReadOnlyDictionary<NMOECCJMGEC, PNCJJNBMEKI> NNDADOKGLIJ, [Out] IReadOnlyList<OCAEFFBCEHG> EPEKCFJJEFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x62BAAC0", Offset = "0x62B98C0", VA = "0x1862BAAC0")]
	[AsyncStateMachine(typeof(OCLJLGEIDOE))]
	private static Task FPCAOGJOAEM(DBCBLCPPACK GAFMKBFLIEB, BNNAHCBMALA MFKPIJLKLHA, IReadOnlyDictionary<NMOECCJMGEC, PNCJJNBMEKI> NNDADOKGLIJ, BJLDAKNNLCA EADEHPCPKJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x62B9C80", Offset = "0x62B8A80", VA = "0x1862B9C80")]
	[CompilerGenerated]
	internal static void DFJAGFDKPJO(Func<CBCPHNCNFHC, DICFOBFCAFN> GLLBCBJJIJC, EILEHJNHMGC P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x62B9910", Offset = "0x62B8710", VA = "0x1862B9910")]
	[CompilerGenerated]
	internal static bool DDBGCFIAPHC(NMOECCJMGEC KPGLNKLFFEM, OCAEFFBCEHG EEPEJGGJAGL, [Out] AOGDBFLKEHG AIHLJMCIBEN, EIOBAOMJKEE P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface KKEMJEACAKD
{
	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LHDKNDMPNHG(GHMIEPPMENM IJKHFGAJCLB, GHMIEPPMENM KDMMEOLGEED, IEnumerable<GHMIEPPMENM> HHCDPALMOFF, [Out] LGKMCJOKOFM FNCEIGAHDFN, [Out] MLADFJLCFJI CFEAGBINJEJ);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string NKFODHDOPIN(MLADFJLCFJI EDBJDPCMLGL);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum MLADFJLCFJI : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	InsufficientPermission,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	DisabledByRoom,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	CantKickEventOrganizer,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	Broadcaster,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	GameInProgress,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	OpponentGameInProgress
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal class PIPJABBABEL : KKEMJEACAKD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly CKEMGNPJHKO EKECEODAKAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly MOLNJBDNPFD EHKKIODELJD;

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x76A6C0", Offset = "0x7694C0", VA = "0x18076A6C0")]
	[RecRoom.NoEngine.Common.Preserve]
	public PIPJABBABEL([NMBHAKGIBHG(null)] CKEMGNPJHKO GOCMHNPFHOF, [NMBHAKGIBHG(null)] MOLNJBDNPFD LCKHGHAKGMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x62C27A0", Offset = "0x62C15A0", VA = "0x1862C27A0")]
	private static BEEDJEMJFEF? JHPHKHLBEEA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x62C27E0", Offset = "0x62C15E0", VA = "0x1862C27E0", Slot = "4")]
	public bool LHDKNDMPNHG(GHMIEPPMENM IJKHFGAJCLB, GHMIEPPMENM KDMMEOLGEED, IEnumerable<GHMIEPPMENM> HHCDPALMOFF, [Out] LGKMCJOKOFM FNCEIGAHDFN, [Out] MLADFJLCFJI CFEAGBINJEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x62C28E0", Offset = "0x62C16E0", VA = "0x1862C28E0", Slot = "5")]
	public string NKFODHDOPIN(MLADFJLCFJI EDBJDPCMLGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x62C2180", Offset = "0x62C0F80", VA = "0x1862C2180")]
	internal bool FJNNFEDNMBO(GHMIEPPMENM IJKHFGAJCLB, GHMIEPPMENM KDMMEOLGEED, IEnumerable<GHMIEPPMENM> HHCDPALMOFF, OABHNCNHAAJ GJLKFCILFEP, BEEDJEMJFEF? MNIBJNOOIFI, [Out] LGKMCJOKOFM FNCEIGAHDFN, [Out] MLADFJLCFJI CFEAGBINJEJ)
	{
		return default(bool);
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

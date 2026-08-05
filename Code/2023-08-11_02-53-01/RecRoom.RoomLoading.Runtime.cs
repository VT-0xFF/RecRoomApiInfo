using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CodeStage.AntiCheat.ObscuredTypes;
using Cpp2IlInjected;
using ExitGames.Client.Photon;
using Google.Protobuf;
using Google.Protobuf.Collections;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using RecNet;
using RecRoom.NoEngine.Common;
using RecRoom.Persistence;
using UnityEngine;
using UnityEngine.SceneManagement;
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
		[Cpp2IlInjected.Address(RVA = "0x7E01F0", Offset = "0x7DE9F0", VA = "0x1807E01F0")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2670860", Offset = "0x266F060", VA = "0x182670860")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7EEC40", Offset = "0x7ED440", VA = "0x1807EEC40")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA14660", Offset = "0xA12E60", VA = "0x180A14660")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface ABKHNKAOKME
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<CCCEJDFLIPE> IBABNLLPCCL;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HKHEKGCJCLF(long AFGKPOPONBN, long OFFAGGOPNOB, OOGLJJBDKMP FHNPDPEPPGC, BNGCJDIPPAA FPAFDBDKHNA);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool EHALODCENNN(long AFGKPOPONBN, long OFFAGGOPNOB, out CCCEJDFLIPE NLFPMIFADDN);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool LDBOMIOHNFA(long AFGKPOPONBN, long OFFAGGOPNOB, BNGCJDIPPAA FPAFDBDKHNA, out CCCEJDFLIPE NLFPMIFADDN);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IDKEEHFPIFO(long AFGKPOPONBN, long OFFAGGOPNOB);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[UnityEngine.Scripting.Preserve]
internal class NGNBBAJDDFP : ELDHJAHLBAJ, DFDBGBPAMNI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class JDLGJALNIDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public COMIIGGELLE roomEvent;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public JDLGJALNIDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x36EB400", Offset = "0x36E9C00", VA = "0x1836EB400")]
		internal object CPCPELKKIFJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action OLPKJFMFFFC
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x266FA50", Offset = "0x266E250", VA = "0x18266FA50", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x26702E0", Offset = "0x266EAE0", VA = "0x1826702E0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event PGNFGNFCFOF PGMLJDEDCED
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x266FAF0", Offset = "0x266E2F0", VA = "0x18266FAF0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x266FF80", Offset = "0x266E780", VA = "0x18266FF80", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event PGNFGNFCFOF POOKHDDJIME
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x266FEE0", Offset = "0x266E6E0", VA = "0x18266FEE0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x26700D0", Offset = "0x266E8D0", VA = "0x1826700D0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event PGNFGNFCFOF ILLDGCMJCCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2670240", Offset = "0x266EA40", VA = "0x182670240", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2670170", Offset = "0x266E970", VA = "0x182670170", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action<IILIALHMONN, bool> EADBMBHKFHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x266FC30", Offset = "0x266E430", VA = "0x18266FC30", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x266FB90", Offset = "0x266E390", VA = "0x18266FB90", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "19")]
	public void BDCEDMLOOPD(IBHEBOMOMMF KPGFDADNAJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x266FCD0", Offset = "0x266E4D0", VA = "0x18266FCD0", Slot = "14")]
	public void IGFJKPHJJOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x26705B0", Offset = "0x266EDB0", VA = "0x1826705B0", Slot = "15")]
	public void OEOCIMPNCDK(COMIIGGELLE CAHMLNACFAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2670580", Offset = "0x266ED80", VA = "0x182670580", Slot = "16")]
	public void MDPEGLIAHPI(COMIIGGELLE CAHMLNACFAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2670210", Offset = "0x266EA10", VA = "0x182670210", Slot = "17")]
	public void LBJAMHJMKLK(COMIIGGELLE CAHMLNACFAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2670020", Offset = "0x266E820", VA = "0x182670020", Slot = "18")]
	public void JHKOGABFICI(IILIALHMONN AMDKOMACAKL, bool NFFGKDNLOEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2670380", Offset = "0x266EB80", VA = "0x182670380")]
	private void MADELAMLLLM(PGNFGNFCFOF FKHENLGIMDG, COMIIGGELLE CAHMLNACFAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public NGNBBAJDDFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal interface BGCDPENCIFP : DFDBGBPAMNI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	GBODBCPKFEK CKGNDMJMDFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LCMJIPJLHFB();

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PAFNGBGEGGI();
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal interface CKHEKCFEJBC : DFDBGBPAMNI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KHDFCDLHKAB OFOFNHIJBFM(GHGLDBKCJPG NKDCDCNCJMP);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IAAMIHKMJMI(Guid GMIOJDLOGJD, Task LCIAELPEAAE);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal struct BEIPDIGFAIE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly IDictionary<object, object> ANPGOOMAJOC;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x9E4D50", Offset = "0x9E3550", VA = "0x1809E4D50")]
	public BEIPDIGFAIE(IDictionary<object, object> ANPGOOMAJOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x20427C0", Offset = "0x2040FC0", VA = "0x1820427C0")]
	public bool MABLNOLLFGI(out GHGLDBKCJPG AKADEFDGONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x20425D0", Offset = "0x2040DD0", VA = "0x1820425D0")]
	public Guid FIDMOICFGNO()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x20426B0", Offset = "0x2040EB0", VA = "0x1820426B0")]
	public LIHOBIGHABN LBPILMFNGOB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2042880", Offset = "0x2041080", VA = "0x182042880")]
	public static ExitGames.Client.Photon.Hashtable OIAKNFDBOOD(GHGLDBKCJPG AKADEFDGONP, LIHOBIGHABN OOIDINBGEIP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface BPKBINKBDLP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MCPPLNGMKPA(FOAHAJNCECK.PBHBIMGLLFO CBMEOPBCJAI);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void COHGALMKBPP(FOAHAJNCECK.PBHBIMGLLFO CBMEOPBCJAI);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class FOAHAJNCECK : BPKBINKBDLP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public delegate LIHOBIGHABN PBHBIMGLLFO([NotNull] BNKEEFOCAMM KDDFEFMMFMP);

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class PCADOMCHLCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public BNKEEFOCAMM photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public PCADOMCHLCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3DC7290", Offset = "0x3DC5A90", VA = "0x183DC7290")]
		internal LIHOBIGHABN IBMOLOIPKND(PBHBIMGLLFO v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool PMADFOMNIPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	protected readonly HashSet<PBHBIMGLLFO> KBPFHLMABDE;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x20575F0", Offset = "0x2055DF0", VA = "0x1820575F0", Slot = "4")]
	public void MCPPLNGMKPA(PBHBIMGLLFO CBMEOPBCJAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2057540", Offset = "0x2055D40", VA = "0x182057540", Slot = "5")]
	public void COHGALMKBPP(PBHBIMGLLFO CBMEOPBCJAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x20575A0", Offset = "0x2055DA0", VA = "0x1820575A0", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2057320", Offset = "0x2055B20", VA = "0x182057320")]
	protected LIHOBIGHABN AHPBKCMGJFL(BNKEEFOCAMM BDEPDJCOMPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2057650", Offset = "0x2055E50", VA = "0x182057650")]
	protected FOAHAJNCECK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class DBCENNCFLCL
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class CKFBMOGOECM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public JDPJAFEOEAF subRoomSave;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public CKFBMOGOECM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2664DE0", Offset = "0x26635E0", VA = "0x182664DE0")]
		internal bool DNGJIENFLKH(CKNKGBNGABP s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x204A350", Offset = "0x2048B50", VA = "0x18204A350")]
	public static ACEIDINIJDO OIAKNFDBOOD(long ODIPAHCBICE, long HILPLFHHAPA, string ICCNANGPCBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2049F10", Offset = "0x2048710", VA = "0x182049F10")]
	public static ACEIDINIJDO OIAKNFDBOOD(long ODIPAHCBICE, long HILPLFHHAPA, CENNEHOCJAK GGGHMACDDAC, long GJGLINJHGOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2049FE0", Offset = "0x20487E0", VA = "0x182049FE0")]
	public static ACEIDINIJDO OIAKNFDBOOD(JHAJGBINBJN MALLKMNKCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x204A110", Offset = "0x2048910", VA = "0x18204A110")]
	public static ACEIDINIJDO OIAKNFDBOOD(JEELLOGMCHC OGAJHEHCNKG, JDPJAFEOEAF BBHLPMCCNHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2049C80", Offset = "0x2048480", VA = "0x182049C80")]
	public static ACEIDINIJDO AKGONGALJBM(this ACEIDINIJDO BKHMACKFNNF, JEELLOGMCHC ACHPPJINCLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2049D80", Offset = "0x2048580", VA = "0x182049D80")]
	public static ACEIDINIJDO HKBNBEIFMFA(this ACEIDINIJDO BKHMACKFNNF, JDPJAFEOEAF MFOLECMDMOK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public enum PFMHPNPHIHB
{
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum IILIALHMONN
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	InitialRoomLoad,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	AutoSave,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	SaveToDisk,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	SaveToRecNet,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	RestoreAutoSave,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct COMIIGGELLE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly long ODIPAHCBICE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly long HILPLFHHAPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly PFMHPNPHIHB EIOLDDJPDLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	[CanBeNull]
	public readonly Exception LOPBEBKKJFD;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2049140", Offset = "0x2047940", VA = "0x182049140")]
	public COMIIGGELLE(long ODIPAHCBICE, long HILPLFHHAPA, PFMHPNPHIHB EIOLDDJPDLH, [CanBeNull] Exception LOPBEBKKJFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x20490F0", Offset = "0x20478F0", VA = "0x1820490F0")]
	public static COMIIGGELLE LADHFHOPINH(EIEEEHDKLAP EJMPNJONADI, PFMHPNPHIHB EIOLDDJPDLH, [Optional] Exception LOPBEBKKJFD)
	{
		return default(COMIIGGELLE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public delegate void PGNFGNFCFOF(COMIIGGELLE CAHMLNACFAI);
[Cpp2IlInjected.Token(Token = "0x2000017")]
internal interface ELDHJAHLBAJ : DFDBGBPAMNI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action OLPKJFMFFFC;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event PGNFGNFCFOF PGMLJDEDCED;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event PGNFGNFCFOF POOKHDDJIME;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event PGNFGNFCFOF ILLDGCMJCCD;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<IILIALHMONN, bool> EADBMBHKFHB;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void IGFJKPHJJOH();

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void OEOCIMPNCDK(COMIIGGELLE CAHMLNACFAI);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void MDPEGLIAHPI(COMIIGGELLE CAHMLNACFAI);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void LBJAMHJMKLK(COMIIGGELLE CAHMLNACFAI);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void JHKOGABFICI(IILIALHMONN AMDKOMACAKL, bool NFFGKDNLOEK);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[UnityEngine.Scripting.Preserve]
internal class LFMFPFCFDDI : ENPMLALOKMM, DFDBGBPAMNI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class OFICDECOAON : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public LFMFPFCFDDI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private CINMLNOINGA<string> <timer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private CINMLNOINGA<string>.BIMPMJLMAHG <timerScope>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private FDDJBPFLAAL <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public OFICDECOAON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x36F26E0", Offset = "0x36F0EE0", VA = "0x1836F26E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private KGKEADDOPJG IELDLCCFOIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private IBHEBOMOMMF KPGFDADNAJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private LCPOKIJIEMA DCNEPGCFKGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private FAMMOPHBNLM HEIOEDDDCAM;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x266C230", Offset = "0x266AA30", VA = "0x18266C230", Slot = "6")]
	public void BDCEDMLOOPD(IBHEBOMOMMF KPGFDADNAJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x266C590", Offset = "0x266AD90", VA = "0x18266C590", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x266C440", Offset = "0x266AC40", VA = "0x18266C440", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OFICDECOAON))]
	public Task BDKLFIDAEEA(string NFJIPFJDKNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x266C5E0", Offset = "0x266ADE0", VA = "0x18266C5E0", Slot = "4")]
	public LIHOBIGHABN EDBBIIADPPN(BNKEEFOCAMM FONJCFDJEPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x266C6A0", Offset = "0x266AEA0", VA = "0x18266C6A0")]
	private FDDJBPFLAAL KNBLNLNMDMB(string NFJIPFJDKNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public LFMFPFCFDDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface PDMJIAEOMIP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool GFNPDCHBALL
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool NCHHJNHAEND
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	OBJPINOPCOH PDNPKIGMMFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action OLPKJFMFFFC;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event PGNFGNFCFOF PGMLJDEDCED;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event PGNFGNFCFOF POOKHDDJIME;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event PGNFGNFCFOF ILLDGCMJCCD;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<IILIALHMONN, bool> EADBMBHKFHB;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void IEOKGHKFEMG();

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "13")]
	DEENPPKGIPM LAEADEKPGCF();

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "14")]
	CGACAFDDLHA FJIIBFCMGKJ();

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task<LIHOBIGHABN> ABLKLOIIOPF(CCCEJDFLIPE AKBCGGCPLIB);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task NLIICNJBDCD(CancellationToken NNLBJPBEHPF);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal interface GJKACIJINNC : DFDBGBPAMNI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<LIHOBIGHABN> ABLKLOIIOPF(CCCEJDFLIPE NLFPMIFADDN);

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task NLIICNJBDCD(CancellationToken NNLBJPBEHPF);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[RecRoom.NoEngine.Common.Preserve]
internal class ENGFDHMKEAD : PHALJJCOPEE, DFDBGBPAMNI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class CNIMIODMFHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public EIEEEHDKLAP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public OBJPINOPCOH customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public ENGFDHMKEAD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private Task <task>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public CNIMIODMFHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x3DBA990", Offset = "0x3DB9190", VA = "0x183DBA990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class CDDEMJGOIFN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public EIEEEHDKLAP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public OBJPINOPCOH customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public ENGFDHMKEAD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private CINMLNOINGA<string> <timer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private CINMLNOINGA<string>.BIMPMJLMAHG <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private KODFOCGBOAL <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private JMKPANAMBHF <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private OperationCanceledException <oce>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private Exception <ex>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public CDDEMJGOIFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x3DB9790", Offset = "0x3DB7F90", VA = "0x183DB9790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class BOODLMMEFMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public Matchmaking.BGKGNKMMBHL result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public NNANMCHPHNH errorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public BOODLMMEFMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x3DB96E0", Offset = "0x3DB7EE0", VA = "0x183DB96E0")]
		internal object CEKFDOJPJDB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class NHGPJBENJEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Task<ACEIDINIJDO> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public NHGPJBENJEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7DF170", Offset = "0x7DD970", VA = "0x1807DF170")]
		internal Task<ACEIDINIJDO> MCCDDBBFIPI(CINMLNOINGA<string>.BIMPMJLMAHG _)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class AAOBHCMKLFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public CINMLNOINGA<string>.BIMPMJLMAHG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public EIEEEHDKLAP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public OBJPINOPCOH customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public KODFOCGBOAL joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public ENGFDHMKEAD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private LKCILEABLOB <multiProgressTracker>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private IDisposable <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private CINMLNOINGA<string>.BIMPMJLMAHG <connectToRoomAndRunLoadLogicTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private CancellationTokenSource <roomTokenSource>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private CancellationTokenRegistration <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private NHGPJBENJEC <>8__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private CancellationToken <roomCancellationToken>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private ALLKAECLDFK <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private Task<Matchmaking.PHILMNKPMEJ> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private LEPNKPNFGGL <>s__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private Matchmaking.PHILMNKPMEJ <serverConnectionInfo>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private CancellationTokenSource <cameraFadeCts>5__13;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private CINMLNOINGA<string>.BIMPMJLMAHG <>s__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private CancellationTokenSource <loadingScreenCts>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private CINMLNOINGA<string>.BIMPMJLMAHG <loadingScreenScope>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private Matchmaking.PHILMNKPMEJ <>s__17;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private CancellationTokenSource <photonJoinedTokenSource>5__18;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private CancellationToken <photonJoinedToken>5__19;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private ACEIDINIJDO <initialRoomLoadPayload>5__20;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private Task <roomLoadTask>5__21;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private ACEIDINIJDO <>s__22;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private CINMLNOINGA<string>.BIMPMJLMAHG <>s__23;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private TaskAwaiter<Matchmaking.PHILMNKPMEJ> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private TaskAwaiter<ACEIDINIJDO> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public AAOBHCMKLFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x3DB6440", Offset = "0x3DB4C40", VA = "0x183DB6440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class CPHOKKOJMKP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public CINMLNOINGA<string>.BIMPMJLMAHG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public ENGFDHMKEAD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private CINMLNOINGA<string>.BIMPMJLMAHG <disconnectTimerScope>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private object <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private int <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private Exception <ex>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private CINMLNOINGA<string>.BIMPMJLMAHG <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public CPHOKKOJMKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x3DBB4A0", Offset = "0x3DB9CA0", VA = "0x183DBB4A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class LIMMLJNENLG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public ENGFDHMKEAD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private LIFDIPFHEEA <roomContainer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public LIMMLJNENLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x3DC12C0", Offset = "0x3DBFAC0", VA = "0x183DC12C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class OHGILNGNCFM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public AsyncTaskMethodBuilder<Matchmaking.PHILMNKPMEJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public EIEEEHDKLAP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public CINMLNOINGA<string>.BIMPMJLMAHG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public ENGFDHMKEAD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private CINMLNOINGA<string>.BIMPMJLMAHG <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private Matchmaking.PHILMNKPMEJ <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private TaskAwaiter<Matchmaking.PHILMNKPMEJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public OHGILNGNCFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x3DC47B0", Offset = "0x3DC2FB0", VA = "0x183DC47B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class MGMEDIMIOLJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public Matchmaking.PHILMNKPMEJ serverConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public KODFOCGBOAL joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public CINMLNOINGA<string>.BIMPMJLMAHG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public ENGFDHMKEAD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private CINMLNOINGA<string>.BIMPMJLMAHG <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private BADGLKCOBEI <photonRoomConnectionInfo>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter<BADGLKCOBEI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public MGMEDIMIOLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x3DC29C0", Offset = "0x3DC11C0", VA = "0x183DC29C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class NOJNMAGFHLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public EIEEEHDKLAP targetInstance;

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public NOJNMAGFHLF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class CJGGBINBFAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public bool firstIsWhileInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public Task firstCompletedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public NOJNMAGFHLF CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public CJGGBINBFAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x3DBA3A0", Offset = "0x3DB8BA0", VA = "0x183DBA3A0")]
		internal object KHLJIMODHNO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x3DBA290", Offset = "0x3DB8A90", VA = "0x183DBA290")]
		internal string KHJPAJCFAEL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class KGCKFFOEEPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public EIEEEHDKLAP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public ENGFDHMKEAD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private NOJNMAGFHLF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private CJGGBINBFAJ <>8__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private Task <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private object <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private int <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private Exception <ex>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public KGCKFFOEEPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x3DBF870", Offset = "0x3DBE070", VA = "0x183DBF870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class KPHHHLILAHF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public ACEIDINIJDO initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public LKCILEABLOB progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public EIEEEHDKLAP targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public KODFOCGBOAL joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public CINMLNOINGA<string>.BIMPMJLMAHG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public ENGFDHMKEAD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private CINMLNOINGA<string>.BIMPMJLMAHG <roomLoadLogicTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private KODFOCGBOAL <initialLoadOpPauseToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private COOJADFPDLG <op>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public KPHHHLILAHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x3DC05C0", Offset = "0x3DBEDC0", VA = "0x183DC05C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class MANLJFMPICH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public CINMLNOINGA<string>.BIMPMJLMAHG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public ENGFDHMKEAD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private CINMLNOINGA<string>.BIMPMJLMAHG <spawnLocalPlayerTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private CINMLNOINGA<string>.BIMPMJLMAHG <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private CINMLNOINGA<string>.BIMPMJLMAHG <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private int <i>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private CINMLNOINGA<string>.BIMPMJLMAHG <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private CINMLNOINGA<string>.BIMPMJLMAHG <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private CancellationTokenSource <timeoutTcs>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private CancellationToken <timeoutToken>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public MANLJFMPICH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x3DC16F0", Offset = "0x3DBFEF0", VA = "0x183DC16F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class EAHFKICJCBF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public ALNDGPDOBOK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public ENGFDHMKEAD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private int <version>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private bool <canUpdateRoom>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x55")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private bool <shouldSave>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x56")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private bool <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private TaskAwaiter<LIHOBIGHABN> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public EAHFKICJCBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x3DBC580", Offset = "0x3DBAD80", VA = "0x183DBC580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class BLLLJJGPMKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public EIEEEHDKLAP targetInstance;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public BLLLJJGPMKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x3DB9510", Offset = "0x3DB7D10", VA = "0x183DB9510")]
		internal object KBINLFJIOLJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class JHJJCKIOCAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public JHJJCKIOCAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x3DBF6B0", Offset = "0x3DBDEB0", VA = "0x183DBF6B0")]
		internal void KGGLMOPEJBF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class PIGKAGALPEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public EIEEEHDKLAP targetInstance;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public PIGKAGALPEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x3DC84E0", Offset = "0x3DC6CE0", VA = "0x183DC84E0")]
		internal object HAJLALICHCB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class BDBPNPAMGBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public EIEEEHDKLAP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public BDBPNPAMGBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x3DB9410", Offset = "0x3DB7C10", VA = "0x183DB9410")]
		internal string LLEMDCLHJEG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static readonly JNGNMMOLKFF PJMEDLCOJMO;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static readonly JNGNMMOLKFF KBGIDOIANKB;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly JNGNMMOLKFF ALFJHCIPIBF;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static readonly string HPKFDLPEHNJ;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static readonly string DBOLCIBEJFL;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static readonly string IFKIINLPAHP;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public static readonly Guid KEKBKLEEJBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private JOBAJLNCBIL JMDLAHHNDMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private INMFNPDAJBI DMGPBGFJPMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private FMDMEJLHLEH NDDDHNPEAPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private IBHEBOMOMMF KPGFDADNAJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private CABGPNHLHHJ BOBHLPNKBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private ABCLHJLIAGN FGDOGJAGEEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private AJENGDNGBKE DIMNNKFLPIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private ELDHJAHLBAJ DPBIPCAHMMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private FPBEPBHJDBK DHCAGHDAJEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private EIOFPFLBFKO GALIFFFIOPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private IDisposable KEHEJLKHFFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly NHDFEEHHMNM JLIALGCGENJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly NHDFEEHHMNM EMDDKCMMPAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private LEPNKPNFGGL LLEBALEIPLC;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public TaskStatus FLGIHILCPIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x20279E0", Offset = "0x20261E0", VA = "0x1820279E0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2026620", Offset = "0x2024E20", VA = "0x182026620")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private ONNFMGINMGB LNIEMJIJJKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2053540", Offset = "0x2051D40", VA = "0x182053540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x2052900", Offset = "0x2051100", VA = "0x182052900", Slot = "6")]
	public void BDCEDMLOOPD(IBHEBOMOMMF KPGFDADNAJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2053590", Offset = "0x2051D90", VA = "0x182053590", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x2054770", Offset = "0x2052F70", VA = "0x182054770", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CNIMIODMFHC))]
	public Task JALFNFHDCCE(EIEEEHDKLAP AINNEBBNIGO, OBJPINOPCOH KFBCHHABIKI, CancellationToken MAGFBIFMOHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x20523E0", Offset = "0x2050BE0", VA = "0x1820523E0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CDDEMJGOIFN))]
	private Task AFNGAJBGLEC(EIEEEHDKLAP AINNEBBNIGO, OBJPINOPCOH KFBCHHABIKI, CancellationToken MAGFBIFMOHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x2054A10", Offset = "0x2053210", VA = "0x182054A10")]
	private static void JLAMIMELCAH(FPBEPBHJDBK DHCAGHDAJEP, EIEEEHDKLAP AINNEBBNIGO, Exception IDAOICDGJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2053DB0", Offset = "0x20525B0", VA = "0x182053DB0")]
	private static void IDBAKOGLEBD(JMKPANAMBHF DLGENIGIBHL, Exception IDAOICDGJBJ, [Optional] List<int> LJHFJNKOMJB, int DEAHCAOIPKN = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2052580", Offset = "0x2050D80", VA = "0x182052580")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AAOBHCMKLFG))]
	private Task AGHOBKLFHDP(CINMLNOINGA<string>.BIMPMJLMAHG FMGNKDAMMIM, EIEEEHDKLAP AINNEBBNIGO, OBJPINOPCOH KFBCHHABIKI, KODFOCGBOAL CNCNEHMAHFN, CancellationToken MAGFBIFMOHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2053AF0", Offset = "0x20522F0", VA = "0x182053AF0")]
	private void HAADCJKOCCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x2053C40", Offset = "0x2052440", VA = "0x182053C40")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CPHOKKOJMKP))]
	private Task ICFIHPOFPBB(CINMLNOINGA<string>.BIMPMJLMAHG FMGNKDAMMIM, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x2055850", Offset = "0x2054050", VA = "0x182055850")]
	private void OMCDPBIKCFB(EIEEEHDKLAP AINNEBBNIGO, CancellationToken MAGFBIFMOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2055390", Offset = "0x2053B90", VA = "0x182055390")]
	private void MCAGKIJKMGP(EIEEEHDKLAP AINNEBBNIGO, KODFOCGBOAL CNCNEHMAHFN, OperationCanceledException CBCJIGABOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2054DD0", Offset = "0x20535D0", VA = "0x182054DD0")]
	private void JOIJHDJGDOL(EIEEEHDKLAP AINNEBBNIGO, KODFOCGBOAL CNCNEHMAHFN, Exception IDAOICDGJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x2052E30", Offset = "0x2051630", VA = "0x182052E30")]
	private void CEMLPAPFEIJ(EIEEEHDKLAP AINNEBBNIGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2053040", Offset = "0x2051840", VA = "0x182053040")]
	private static COMIIGGELLE CGPNLHNDJLF(EIEEEHDKLAP AINNEBBNIGO)
	{
		return default(COMIIGGELLE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x2055730", Offset = "0x2053F30", VA = "0x182055730")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LIMMLJNENLG))]
	private Task MLEDELOOGCO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x2052C90", Offset = "0x2051490", VA = "0x182052C90")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OHGILNGNCFM))]
	private Task<Matchmaking.PHILMNKPMEJ> CEJJDEANFBO(EIEEEHDKLAP AINNEBBNIGO, CINMLNOINGA<string>.BIMPMJLMAHG FMGNKDAMMIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x20535E0", Offset = "0x2051DE0", VA = "0x1820535E0")]
	private static BADGLKCOBEI FHBEAFJODHG(Matchmaking.PHILMNKPMEJ LDEOKPDECEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2055010", Offset = "0x2053810", VA = "0x182055010")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MGMEDIMIOLJ))]
	private Task LLJPKIEDEAD(Matchmaking.PHILMNKPMEJ LDEOKPDECEJ, KODFOCGBOAL CNCNEHMAHFN, CINMLNOINGA<string>.BIMPMJLMAHG FMGNKDAMMIM, CancellationToken PJHDGNKPEHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2052760", Offset = "0x2050F60", VA = "0x182052760")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KGCKFFOEEPC))]
	private Task BDBEBEDBBBJ(EIEEEHDKLAP AINNEBBNIGO, CancellationTokenSource EOBMGAPECOA, Task LJEHHFGIACH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x20536F0", Offset = "0x2051EF0", VA = "0x1820536F0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KPHHHLILAHF))]
	private Task FIAGECOCLFP(ACEIDINIJDO CNDNBAHLIMJ, LKCILEABLOB BOGIMCCMKGE, EIEEEHDKLAP GIMIIDFNFBI, KODFOCGBOAL KMJEMLMBMFN, CINMLNOINGA<string>.BIMPMJLMAHG FMGNKDAMMIM, CancellationToken LDIIBMPGDDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x20551D0", Offset = "0x20539D0", VA = "0x1820551D0")]
	private KODFOCGBOAL MABOBMBGPIE(KODFOCGBOAL KMJEMLMBMFN, ref CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2052B20", Offset = "0x2051320", VA = "0x182052B20")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MANLJFMPICH))]
	private Task BDHONLKHMEK(CINMLNOINGA<string>.BIMPMJLMAHG FMGNKDAMMIM, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2053980", Offset = "0x2052180", VA = "0x182053980")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EAHFKICJCBF))]
	private Task GPAADCOMBIF(ALNDGPDOBOK NFBDMLCENEN, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x20532D0", Offset = "0x2051AD0", VA = "0x1820532D0")]
	private static void DANPMOELJMC(EIEEEHDKLAP AINNEBBNIGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x20521C0", Offset = "0x20509C0", VA = "0x1820521C0")]
	private void AADEONANBLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x20545E0", Offset = "0x2052DE0", VA = "0x1820545E0")]
	private void ILLEAIPDFKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x20538F0", Offset = "0x20520F0", VA = "0x1820538F0")]
	private void GHBLOGLOGIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2054910", Offset = "0x2053110", VA = "0x182054910")]
	private void JJHMIJMILEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2053440", Offset = "0x2051C40", VA = "0x182053440")]
	private static void DGGAMFGMGOC(EIEEEHDKLAP AINNEBBNIGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2055640", Offset = "0x2053E40", VA = "0x182055640")]
	private static CancellationTokenRegistration MGMBDOKLHLM(EIEEEHDKLAP AINNEBBNIGO, CancellationToken PJHDGNKPEHD)
	{
		return default(CancellationTokenRegistration);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2054670", Offset = "0x2052E70", VA = "0x182054670")]
	private static void IPKAFJMHCAM(EIEEEHDKLAP AINNEBBNIGO, Exception IDAOICDGJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x20530A0", Offset = "0x20518A0", VA = "0x1820530A0")]
	private void COCEIIALBFN(EIEEEHDKLAP AINNEBBNIGO, Task LJEHHFGIACH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x20555D0", Offset = "0x2053DD0", VA = "0x1820555D0")]
	private static void MFCLMPLONOJ(Func<string> DPFPLPFKKOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2055D60", Offset = "0x2054560", VA = "0x182055D60")]
	public ENGFDHMKEAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x20549A0", Offset = "0x20531A0", VA = "0x1820549A0")]
	[CompilerGenerated]
	internal static (int, int?) JKEGGENALMM(NNANMCHPHNH IBOCEJCODCK)
	{
		return default((int, int?));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface EAPMMHAANAI
{
	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<DLDMCIANGML<BHPHMLLBEJC, CFJKAHNEDBL>> BDGKHBFDHFM(string MOPJJOOHADC, long DFOMHFMOJCN, HIOOKNMCKLA.GFKEFMJAALB IADACIPJBBD, CancellationToken NNLBJPBEHPF);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal class EJPPOLCKFOB : JKHOFEILAGM<GHGLDBKCJPG>
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class OAOIKEEKCAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public GHGLDBKCJPG message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public OAOIKEEKCAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x3DC4250", Offset = "0x3DC2A50", VA = "0x183DC4250")]
		internal object OJFHNOFNKGF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public static readonly EJPPOLCKFOB OEFAOPMNMGM;

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x2051030", Offset = "0x204F830", VA = "0x182051030")]
	public ExitGames.Client.Photon.Hashtable CLIBMONIMNB(GHGLDBKCJPG AKADEFDGONP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x20516D0", Offset = "0x204FED0", VA = "0x1820516D0", Slot = "5")]
	protected override void NAFELMKFCII(GHGLDBKCJPG AKADEFDGONP, IDictionary<object, object> NFBDMLCENEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x20513B0", Offset = "0x204FBB0", VA = "0x1820513B0", Slot = "6")]
	public override GHGLDBKCJPG KLHPMPNNHAA(IDictionary<object, object> NFBDMLCENEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x20515B0", Offset = "0x204FDB0", VA = "0x1820515B0")]
	private static void MFCLMPLONOJ(string OMGIJLOIGMM, GHGLDBKCJPG AKADEFDGONP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x2051880", Offset = "0x2050080", VA = "0x182051880")]
	public EJPPOLCKFOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x20510B0", Offset = "0x204F8B0", VA = "0x1820510B0")]
	[CompilerGenerated]
	internal static string GOLAKGKGKGC(ACEIDINIJDO BKHMACKFNNF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface NFCAAPGFBFP<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<DLDMCIANGML<byte[], CFJKAHNEDBL>> EGLJOBOFNHM(TGetDataArg FFIGANEHPFB, CancellationToken NNLBJPBEHPF);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DLDMCIANGML<ONMENFLLGCG<TData>, CFJKAHNEDBL> DNFLMOLBGJA(byte[] NFBDMLCENEN);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface AAAFEFBBLED : BPKBINKBDLP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LIHOBIGHABN MPBDHCOLPGL(BNKEEFOCAMM BDEPDJCOMPP);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class PCLFFOPKLJN : BPOKJAJNIOA, JNMJMMBFBGE, ADEKDIENBAG, KJIBLJHFIIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly JNMJMMBFBGE FPECANCMAKH;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public BNKEEFOCAMM BPGDLLGCJBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x26776D0", Offset = "0x2675ED0", VA = "0x1826776D0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int NKALOEEELND
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x26773F0", Offset = "0x2675BF0", VA = "0x1826773F0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int CHDOGBHPJDH
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x26772E0", Offset = "0x2675AE0", VA = "0x1826772E0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool EGPOIODDEHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7EE860", Offset = "0x7ED060", VA = "0x1807EE860", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int HMBMOJFNBNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7F0C80", Offset = "0x7EF480", VA = "0x1807F0C80", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event BHDDGNMEPLD.HPIHNHGCJKI LHEODPMODLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event EGOCKILELOE MLEINEGOEFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2677440", Offset = "0x2675C40", VA = "0x182677440", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x2677720", Offset = "0x2675F20", VA = "0x182677720", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<bool> HPPKIBDHOEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<BNKEEFOCAMM> LNNJFODIKGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action HLICHGELIJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2677330", Offset = "0x2675B30", VA = "0x182677330", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x26777C0", Offset = "0x2675FC0", VA = "0x1826777C0", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0xE4E5C0", Offset = "0xE4CDC0", VA = "0x180E4E5C0")]
	public PCLFFOPKLJN(JNMJMMBFBGE FPECANCMAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2677620", Offset = "0x2675E20", VA = "0x182677620", Slot = "8")]
	public bool IFIPPCKPKGA(byte BCFOGCJCOLM, ExitGames.Client.Photon.Hashtable KNLBGBBLGBK, HGDKOAKIHHJ LMLDBOHFJJH, SendOptions IIAKGLFAGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x26774E0", Offset = "0x2675CE0", VA = "0x1826774E0", Slot = "16")]
	public BNKEEFOCAMM HOCNOOKFDGA(int PLCHDJPLMNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "19")]
	public void DBMGBFBKLMI(object AMCDGOPKAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "20")]
	public void DKMPNKONGCF(object AMCDGOPKAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "21")]
	public void NHIDFMGKPCD(object AMCDGOPKAOE, bool GNDINBDCKBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x26775C0", Offset = "0x2675DC0", VA = "0x1826775C0", Slot = "22")]
	public IDisposable IAFIPDGJKBJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x7EE870", Offset = "0x7ED070", VA = "0x1807EE870", Slot = "23")]
	private bool KLPPGCNJOCL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "24")]
	public void AJKDJHDFCPJ(StringBuilder PEDIPOMELEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x26773D0", Offset = "0x2675BD0", VA = "0x1826773D0", Slot = "25")]
	public bool EHOEJNOBPEJ(bool EKBBIHMFKLE, out string OABOGFOJNOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x7F43B0", Offset = "0x7F2BB0", VA = "0x1807F43B0", Slot = "28")]
	public void LPLOEODABEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal struct PPBILANGAJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly TaskCompletionSource<(LIHOBIGHABN, Task)> DOLGBOBMIIK;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Task<(LIHOBIGHABN, Task)> DPBOJKPJGAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x267BA20", Offset = "0x267A220", VA = "0x18267BA20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x267BA60", Offset = "0x267A260", VA = "0x18267BA60")]
	public PPBILANGAJG(TimeSpan FKDBGBDFJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x267B7C0", Offset = "0x2679FC0", VA = "0x18267B7C0")]
	public void AMDNOFMLDMC(Task LCIAELPEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x267B8B0", Offset = "0x267A0B0", VA = "0x18267B8B0")]
	public void BNKFMFPICBG(LIHOBIGHABN OOIDINBGEIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x267B9D0", Offset = "0x267A1D0", VA = "0x18267B9D0")]
	public void LKNHEGMHPJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x267B940", Offset = "0x267A140", VA = "0x18267B940")]
	internal void JGPDOKEEINO(string AKADEFDGONP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal class AKHFGIFOHKM : BGCDPENCIFP, DFDBGBPAMNI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private bool EFMAOBFLBNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private GBODBCPKFEK COCNHNCJFLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private FMDMEJLHLEH NDDDHNPEAPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private BGDBDLPLBMK GGGECKCCDMK;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public GBODBCPKFEK CKGNDMJMDFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x2042000", Offset = "0x2040800", VA = "0x182042000", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x2041EB0", Offset = "0x20406B0", VA = "0x182041EB0", Slot = "7")]
	public void BDCEDMLOOPD(IBHEBOMOMMF KPGFDADNAJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x2042070", Offset = "0x2040870", VA = "0x182042070", Slot = "5")]
	public void LCMJIPJLHFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2041FC0", Offset = "0x20407C0", VA = "0x182041FC0", Slot = "6")]
	public void PAFNGBGEGGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2042230", Offset = "0x2040A30", VA = "0x182042230")]
	private Task LDJPAONPKFJ(IHBJGBNJFJH FFEHKCANNDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x2041FC0", Offset = "0x20407C0", VA = "0x182041FC0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x97D940", Offset = "0x97C140", VA = "0x18097D940")]
	public AKHFGIFOHKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal struct ENNFAFOAHIC
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class DEJHNNDBPLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public IBHEBOMOMMF manager;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public DEJHNNDBPLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x3DBBD30", Offset = "0x3DBA530", VA = "0x183DBBD30")]
		internal Task BPEALCCJMBL(ALNDGPDOBOK data, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class COLNIFBKANM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public ENNFAFOAHIC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private long <roomId>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private long <subroomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private CCCEJDFLIPE <autosaveInfo>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private EAAEFPCAICM <response>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private EAAEFPCAICM <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private EAAEFPCAICM <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private TaskAwaiter<EAAEFPCAICM> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private TaskAwaiter<LIHOBIGHABN> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public COLNIFBKANM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x3DBAEE0", Offset = "0x3DB96E0", VA = "0x183DBAEE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class KHAOHGPHMOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public ENNFAFOAHIC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public KHAOHGPHMOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x3DC0340", Offset = "0x3DBEB40", VA = "0x183DC0340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly CancellationToken NNLBJPBEHPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private readonly IBHEBOMOMMF OAFFOBLPFIG;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private FMDMEJLHLEH EAFGHDBHBCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2056110", Offset = "0x2054910", VA = "0x182056110")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private CABGPNHLHHJ BKEEIANIHAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x20561E0", Offset = "0x20549E0", VA = "0x1820561E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private ONNFMGINMGB LNIEMJIJJKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x2056160", Offset = "0x2054960", VA = "0x182056160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private GJKACIJINNC HHCACHPEKNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x2056550", Offset = "0x2054D50", VA = "0x182056550")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x20565A0", Offset = "0x2054DA0", VA = "0x1820565A0")]
	public ENNFAFOAHIC(CancellationToken NNLBJPBEHPF, IBHEBOMOMMF OAFFOBLPFIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x2056230", Offset = "0x2054A30", VA = "0x182056230")]
	public static LAINJHKLPPK IDMDHINAMPE(IBHEBOMOMMF OAFFOBLPFIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x20562E0", Offset = "0x2054AE0", VA = "0x1820562E0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(COLNIFBKANM))]
	public Task<bool> JELDACCCIFL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x2055F70", Offset = "0x2054770", VA = "0x182055F70")]
	private bool CJELPKEGBIF(out CCCEJDFLIPE NLFPMIFADDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x2056430", Offset = "0x2054C30", VA = "0x182056430")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KHAOHGPHMOD))]
	private Task MFFDHCGDIBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x2055E40", Offset = "0x2054640", VA = "0x182055E40")]
	private Task<EAAEFPCAICM> AFFHIMPBGGN(CCCEJDFLIPE IAOAONGDBLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal class DDPGDIFKANG : BGDBDLPLBMK
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private class HLFGMBDJDGC<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private readonly LDOHJBCKEED FMKDNPLHJLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private readonly string EECINICJCLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private readonly T GFJIAKNDNMH;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public T PGHJLABHLGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x97D920", Offset = "0x97C120", VA = "0x18097D920")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x97D930", Offset = "0x97C130", VA = "0x18097D930")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x3F9F570", Offset = "0x3F9DD70", VA = "0x183F9F570")]
		public HLFGMBDJDGC(LDOHJBCKEED FMKDNPLHJLH, string EECINICJCLK, T GFJIAKNDNMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x3F9EF60", Offset = "0x3F9D760", VA = "0x183F9EF60")]
		private void LGDGKLHDDDG()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly LDOHJBCKEED FMKDNPLHJLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly HLFGMBDJDGC<TimeSpan> GFDMGBNEPMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private readonly HLFGMBDJDGC<TimeSpan> PBNHPIMICJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly HLFGMBDJDGC<TimeSpan> HDGHAJHHADB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly HLFGMBDJDGC<TimeSpan> CNONBODAFKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly HLFGMBDJDGC<bool> MBGGFCDOMJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly HLFGMBDJDGC<bool> FKLBBIGECPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private readonly HLFGMBDJDGC<bool> KCDLHCFOHPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private readonly HLFGMBDJDGC<int> HGIODPOIGCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly HLFGMBDJDGC<bool> NGGPOBOHMMJ;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TimeSpan NIHMNMPKKHN
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x204AEC0", Offset = "0x20496C0", VA = "0x18204AEC0", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public TimeSpan CIKIBKKMLBA
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x204ADC0", Offset = "0x20495C0", VA = "0x18204ADC0", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public TimeSpan MJIPKNFIADA
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x204AF00", Offset = "0x2049700", VA = "0x18204AF00", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public TimeSpan IPEGONALIFH
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x204AE40", Offset = "0x2049640", VA = "0x18204AE40", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool HMGHAEMOKMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x204AD80", Offset = "0x2049580", VA = "0x18204AD80", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool CJFFKMGOJDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x204AD00", Offset = "0x2049500", VA = "0x18204AD00", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool AGAHOJGLEIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x204AE80", Offset = "0x2049680", VA = "0x18204AE80", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public int HKEIOJHCKJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x204AD40", Offset = "0x2049540", VA = "0x18204AD40", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool LNJMHFJAOBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x204AE00", Offset = "0x2049600", VA = "0x18204AE00", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x204AF40", Offset = "0x2049740", VA = "0x18204AF40")]
	[UnityEngine.Scripting.Preserve]
	public DDPGDIFKANG([JHPEMCNOMHI(null)] LDOHJBCKEED FMKDNPLHJLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal struct HPCMLLFOALH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class KFGJHFOGFCF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public Func<CancellationToken, List<Task>> taskGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public HPCMLLFOALH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private List<Task> <tasks>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public KFGJHFOGFCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x36EC7B0", Offset = "0x36EAFB0", VA = "0x1836EC7B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private readonly CancellationTokenSource EFIOOPGMKMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private bool PMADFOMNIPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private Task KOOMIGAFDLJ;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool JHEOEEGHFGE
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x205C970", Offset = "0x205B170", VA = "0x18205C970")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x205C9A0", Offset = "0x205B1A0", VA = "0x18205C9A0")]
	public HPCMLLFOALH(CancellationToken NNLBJPBEHPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x205C810", Offset = "0x205B010", VA = "0x18205C810")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KFGJHFOGFCF))]
	public Task FJIFKDGLGDJ(Func<CancellationToken, List<Task>> AENDLDDONDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x205C7C0", Offset = "0x205AFC0", VA = "0x18205C7C0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal interface OLLHPABCOHM : DFDBGBPAMNI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KHDFCDLHKAB GLILACFFLBJ(Guid GMIOJDLOGJD);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FNJGHMKCCPI(Guid GMIOJDLOGJD);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OPNIPEFBDEP(Guid GMIOJDLOGJD, Task LCIAELPEAAE);

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MBCIHMJLFCI(Guid GMIOJDLOGJD, LIHOBIGHABN BPPBOBPCIGI);

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<(LIHOBIGHABN, Task)> MPMMGIOMEKI(Guid GMIOJDLOGJD);
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
internal interface LCPOKIJIEMA : DFDBGBPAMNI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LIHOBIGHABN HEBALHBEPLD(BNKEEFOCAMM FONJCFDJEPP, OPKDCMBHPLN MHMGOHONFHF);

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LIHOBIGHABN GGEPPGAFCMJ(BNKEEFOCAMM BDEPDJCOMPP);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal class HKAKMIICFFF : LIPIDPBDNHA
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class BNADNJAMACA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public HKAKMIICFFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private EIEEEHDKLAP <localRoomInstance>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private long <currentInstanceId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private bool <currentIsOffline>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private EIEEEHDKLAP <newPresenceRoomInstance>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private float <timeoutTime>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public BNADNJAMACA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x36E1B80", Offset = "0x36E0380", VA = "0x1836E1B80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private readonly IBHEBOMOMMF KPGFDADNAJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private readonly CABGPNHLHHJ BOBHLPNKBHC;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private ONNFMGINMGB LNIEMJIJJKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x205C520", Offset = "0x205AD20", VA = "0x18205C520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x8A72C0", Offset = "0x8A5AC0", VA = "0x1808A72C0")]
	public HKAKMIICFFF(IBHEBOMOMMF KPGFDADNAJA, CABGPNHLHHJ BOBHLPNKBHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x205C650", Offset = "0x205AE50", VA = "0x18205C650", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BNADNJAMACA))]
	public Task<bool> OIHALLMAEIO(CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x205C570", Offset = "0x205AD70", VA = "0x18205C570")]
	[CompilerGenerated]
	private object HAPFGHPOIHC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal interface NAOOCAMJKJD : DFDBGBPAMNI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DABOJJLFLCA(GHGLDBKCJPG AKADEFDGONP);

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BCGANAHFDNG(GHGLDBKCJPG AKADEFDGONP);

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<OPKDCMBHPLN> PAGPNKMAFLK(CancellationToken FKEBLKCLNOO);
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
internal interface ENPMLALOKMM : DFDBGBPAMNI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LIHOBIGHABN EDBBIIADPPN(BNKEEFOCAMM FONJCFDJEPP);

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task BDKLFIDAEEA(string NFJIPFJDKNL);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[UnityEngine.Scripting.Preserve]
internal class ICLPDEFJIOD : AJENGDNGBKE, DFDBGBPAMNI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class DMHMBKBCPBH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public ICLPDEFJIOD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private Exception <ex>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public DMHMBKBCPBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x36E4B80", Offset = "0x36E3380", VA = "0x1836E4B80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private readonly NHDFEEHHMNM KOILPKNHDGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private string BAGHGJGFCGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private Task GFCKKECEDMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private IBHEBOMOMMF KPGFDADNAJA;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool IHCOHBJBFMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x205CC80", Offset = "0x205B480", VA = "0x18205CC80", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public Task JEANKLIAKAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x205CCB0", Offset = "0x205B4B0", VA = "0x18205CCB0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x8A97C0", Offset = "0x8A7FC0", VA = "0x1808A97C0", Slot = "7")]
	public void BDCEDMLOOPD(IBHEBOMOMMF KPGFDADNAJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x205CAC0", Offset = "0x205B2C0", VA = "0x18205CAC0", Slot = "6")]
	public void BGCBBDHNGON(Task KOOMIGAFDLJ, string PPCPJBDPAGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x205CD10", Offset = "0x205B510", VA = "0x18205CD10")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DMHMBKBCPBH))]
	private Task NNGNKAGEMAE(Task FKECABLPCDN, string PPCPJBDPAGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x205CE80", Offset = "0x205B680", VA = "0x18205CE80")]
	public ICLPDEFJIOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal struct KHDFCDLHKAB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private readonly OLLHPABCOHM GKDHGMAFBJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private readonly Guid GMIOJDLOGJD;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private Task<(LIHOBIGHABN, Task)> DPBOJKPJGAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x2669800", Offset = "0x2668000", VA = "0x182669800")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x1AAF6E0", Offset = "0x1AADEE0", VA = "0x181AAF6E0")]
	public KHDFCDLHKAB(OLLHPABCOHM GKDHGMAFBJC, Guid GMIOJDLOGJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x26696E0", Offset = "0x2667EE0", VA = "0x1826696E0")]
	public TaskAwaiter<(LIHOBIGHABN, Task)> CAGNJFBILCM()
	{
		return default(TaskAwaiter<(LIHOBIGHABN, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x2669730", Offset = "0x2667F30", VA = "0x182669730", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[UnityEngine.Scripting.Preserve]
internal sealed class CGBMFHAILMC : GJKACIJINNC, DFDBGBPAMNI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class PEABCPAHJOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public AsyncTaskMethodBuilder<LIHOBIGHABN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public CCCEJDFLIPE autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public CGBMFHAILMC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private CINMLNOINGA<string> <timer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private CINMLNOINGA<string>.BIMPMJLMAHG <timerScope>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private OJHLGMKMOPA <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private CINMLNOINGA<string>.BIMPMJLMAHG <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private ACEIDINIJDO <roomLoadPayload>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private LIHOBIGHABN <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private TaskAwaiter<LIHOBIGHABN> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public PEABCPAHJOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x26780D0", Offset = "0x26768D0", VA = "0x1826780D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class CGDIMPJPKDM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public CGBMFHAILMC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private CancellationTokenSource <combinedTokenSource>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private Exception <ex>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public CGDIMPJPKDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x26647C0", Offset = "0x2662FC0", VA = "0x1826647C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class DIABKIHIHKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public ALNDGPDOBOK _;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public CGBMFHAILMC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public DIABKIHIHKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x2665880", Offset = "0x2664080", VA = "0x182665880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class BAHMDDKNHJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public CGBMFHAILMC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private object <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private int <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public BAHMDDKNHJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x2662BD0", Offset = "0x26613D0", VA = "0x182662BD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class PFNHBFMLMOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public CGBMFHAILMC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public PFNHBFMLMOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x2678E90", Offset = "0x2677690", VA = "0x182678E90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class DFNJNHMHEBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public CGBMFHAILMC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private CancellationToken <nextAutosaveToken>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private Exception <ex>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public DFNJNHMHEBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x26651C0", Offset = "0x26639C0", VA = "0x1826651C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class CFFFAGHALEL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public CancellationToken nextAutosaveToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public CGBMFHAILMC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private Task <delayTask>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private Task<int> <intervalChangedTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private Task <resultTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private Task <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public CFFFAGHALEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x2664350", Offset = "0x2662B50", VA = "0x182664350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class KGMJDFMOEAG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public BNGCJDIPPAA autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public CGBMFHAILMC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private CINMLNOINGA<string> <timer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private CINMLNOINGA<string>.BIMPMJLMAHG <timerScope>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private KODFOCGBOAL <operationPauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private BCMEKDMKGIJ <autosaveOp>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public KGMJDFMOEAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x26691C0", Offset = "0x26679C0", VA = "0x1826691C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private FMDMEJLHLEH NDDDHNPEAPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private IBHEBOMOMMF KPGFDADNAJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private CABGPNHLHHJ BOBHLPNKBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private FAMMOPHBNLM HEIOEDDDCAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private AJENGDNGBKE DIMNNKFLPIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private ODLNEEDDNIG NFPPHFNLMLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private CancellationTokenSource CFCKFPGGCIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private Task EOGHAPMNMOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private TaskCompletionSource<int> GLCNOIKNHCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private int CFEHLDJENHH;

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x20463A0", Offset = "0x2044BA0", VA = "0x1820463A0", Slot = "6")]
	public void BDCEDMLOOPD(IBHEBOMOMMF KPGFDADNAJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0xB1ACF0", Offset = "0xB194F0", VA = "0x180B1ACF0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x2046F40", Offset = "0x2045740", VA = "0x182046F40")]
	private void LLIIKDEMHJG(float CODAAKIJGNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x20460C0", Offset = "0x20448C0", VA = "0x1820460C0", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PEABCPAHJOO))]
	public Task<LIHOBIGHABN> ABLKLOIIOPF(CCCEJDFLIPE NLFPMIFADDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x2047170", Offset = "0x2045970", VA = "0x182047170", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CGDIMPJPKDM))]
	public Task NLIICNJBDCD([Optional] CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0xB1ACF0", Offset = "0xB194F0", VA = "0x180B1ACF0")]
	public void PFJMGIAIBNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x20465D0", Offset = "0x2044DD0", VA = "0x1820465D0")]
	private OJHLGMKMOPA BIOCMBGPBED(CCCEJDFLIPE NLFPMIFADDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x2046230", Offset = "0x2044A30", VA = "0x182046230")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DIABKIHIHKL))]
	private Task ALHIKDJDLDD(ALNDGPDOBOK FFEHKCANNDI, CancellationToken MAGFBIFMOHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x20472C0", Offset = "0x2045AC0", VA = "0x1820472C0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BAHMDDKNHJF))]
	private Task OKEGFNOLFNM(CancellationToken MAGFBIFMOHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x2046DF0", Offset = "0x20455F0", VA = "0x182046DF0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PFNHBFMLMOH))]
	private Task KDPLGOLBGHD([Optional] CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x2046790", Offset = "0x2044F90", VA = "0x182046790")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DFNJNHMHEBK))]
	private Task EAECAMFINID(CancellationToken MAGFBIFMOHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x2047020", Offset = "0x2045820", VA = "0x182047020")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CFFFAGHALEL))]
	private Task MAONLMOLOAB(CancellationToken FOCMHMNNCGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x20469F0", Offset = "0x20451F0", VA = "0x1820469F0")]
	private Task GBBOKJCJMDK(BNGCJDIPPAA FPAFDBDKHNA, CancellationToken MAGFBIFMOHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x2046C90", Offset = "0x2045490", VA = "0x182046C90")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KGMJDFMOEAG))]
	private Task IJJPBIAHHAB(BNGCJDIPPAA FPAFDBDKHNA, CancellationToken MAGFBIFMOHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x20468E0", Offset = "0x20450E0", VA = "0x1820468E0")]
	private bool EDBBIIADPPN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public CGBMFHAILMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface KGKEADDOPJG : BPKBINKBDLP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LIHOBIGHABN EDBBIIADPPN(BNKEEFOCAMM KIHPDBAJKAD);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[UnityEngine.Scripting.Preserve]
internal class EAMIIEBGIBJ : GCCDKLFKNBN, DFDBGBPAMNI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private class HKFMLGPBOAI : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private readonly EIEEEHDKLAP BMLLEHGGNOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private readonly CancellationTokenSource EFIOOPGMKMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public readonly CancellationToken JOINCANAKKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private bool KPNLHGPNNHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private bool DGDBOBKJJDN;

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x3DBED30", Offset = "0x3DBD530", VA = "0x183DBED30")]
		public HKFMLGPBOAI(EIEEEHDKLAP BMLLEHGGNOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x3DBEBA0", Offset = "0x3DBD3A0", VA = "0x183DBEBA0")]
		public void CCPAFFLIAHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x3DBED00", Offset = "0x3DBD500", VA = "0x183DBED00", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class AGAPFGDHIEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public IHBJGBNJFJH disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public AGAPFGDHIEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x3DB8FB0", Offset = "0x3DB77B0", VA = "0x183DB8FB0")]
		internal object EGPNHCJJJNI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class PCHOMLPENKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public IHBJGBNJFJH disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public EAMIIEBGIBJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private AGAPFGDHIEJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public PCHOMLPENKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x3DC72C0", Offset = "0x3DC5AC0", VA = "0x183DC72C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class DLLDLBGOEJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public int playerId;

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public DLLDLBGOEJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x3DBC3A0", Offset = "0x3DBABA0", VA = "0x183DBC3A0")]
		internal object EGLMKKKLDMA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class PDIGMONFBDM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public EAMIIEBGIBJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private DLLDLBGOEJO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private IDisposable <logFlagsScope>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private IDisposable <logTraceScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private IDisposable <logRegistryScope>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private IDisposable <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private IDisposable <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private IDisposable <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private IDisposable <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private EIEEEHDKLAP <newRoomInstance>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private OBJPINOPCOH <customRoomLoadPayload>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private Exception <ex>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public PDIGMONFBDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x3DC7700", Offset = "0x3DC5F00", VA = "0x183DC7700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class APFKNCJLDGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public EIEEEHDKLAP newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public APFKNCJLDGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3DB92F0", Offset = "0x3DB7AF0", VA = "0x183DB92F0")]
		internal object IDOPLHFIEPP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x3DB9390", Offset = "0x3DB7B90", VA = "0x183DB9390")]
		internal object NMNKIJFHMIH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x3DB93D0", Offset = "0x3DB7BD0", VA = "0x183DB93D0")]
		internal object OGJJMHHMFPM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class PDDMEDPACIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public long id;

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public PDDMEDPACIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x3DC7660", Offset = "0x3DC5E60", VA = "0x183DC7660")]
		internal void JLMMCNCIELJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class OPAOGBOPOLH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public EIEEEHDKLAP newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public OBJPINOPCOH customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public EAMIIEBGIBJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		private APFKNCJLDGH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private PDDMEDPACIN <>8__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private CancellationToken <token>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private CancellationTokenRegistration <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private object <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private int <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		private OperationCanceledException <oce>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private Exception <ex>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public OPAOGBOPOLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x3DC4DE0", Offset = "0x3DC35E0", VA = "0x183DC4DE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private static readonly PMAKGABFPKG.IOFADCPOMPA GOOMKEGHDEE;

	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private static readonly IAADJKKLEKO ILGEEDCFFII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private INMFNPDAJBI DMGPBGFJPMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private IBHEBOMOMMF KPGFDADNAJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private ABCLHJLIAGN FGDOGJAGEEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private CABGPNHLHHJ BOBHLPNKBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private BGDBDLPLBMK GGGECKCCDMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private PHALJJCOPEE BEOAGBDLIKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private long BLLPBCCLGBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private HKFMLGPBOAI EJGNPNHBHCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private bool ILOBKKNGANC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private Task EDJJBEHJDFE;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private ONNFMGINMGB LNIEMJIJJKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x204F340", Offset = "0x204DB40", VA = "0x18204F340")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool MFMEPINHOEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x94E330", Offset = "0x94CB30", VA = "0x18094E330")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x204F110", Offset = "0x204D910", VA = "0x18204F110")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x204EEC0", Offset = "0x204D6C0", VA = "0x18204EEC0", Slot = "4")]
	public void BDCEDMLOOPD(IBHEBOMOMMF KPGFDADNAJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x204F390", Offset = "0x204DB90", VA = "0x18204F390", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x204FBF0", Offset = "0x204E3F0", VA = "0x18204FBF0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PCHOMLPENKF))]
	private Task LKEAGHAFHEA(IHBJGBNJFJH GCCLJFGKBMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x204F1A0", Offset = "0x204D9A0", VA = "0x18204F1A0")]
	private void CMLBLEEGHOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x204F510", Offset = "0x204DD10", VA = "0x18204F510")]
	private void ECEFJFJMLJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x204F970", Offset = "0x204E170", VA = "0x18204F970")]
	private void KJJGMEDFMPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x204F120", Offset = "0x204D920", VA = "0x18204F120")]
	private bool BPHBOKJOKNI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x204EDD0", Offset = "0x204D5D0", VA = "0x18204EDD0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PDIGMONFBDM))]
	private void ALLMHEJNDJO(int LDFNOAINHMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x204F6B0", Offset = "0x204DEB0", VA = "0x18204F6B0")]
	private void JIGKJMBHMJO(out IDisposable JMFAIANMGFE, out IDisposable OFLPBMBCMDJ, out IDisposable NBLCCEPPFMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x204FB00", Offset = "0x204E300", VA = "0x18204FB00")]
	private bool LGANBHLOGJC(EIEEEHDKLAP BMLLEHGGNOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x204FD30", Offset = "0x204E530", VA = "0x18204FD30")]
	private void MLGFEPJNAPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x204EC60", Offset = "0x204D460", VA = "0x18204EC60")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OPAOGBOPOLH))]
	private Task AFNGAJBGLEC(EIEEEHDKLAP BMLLEHGGNOI, OBJPINOPCOH KFBCHHABIKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x20501C0", Offset = "0x204E9C0", VA = "0x1820501C0")]
	public EAMIIEBGIBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[UnityEngine.Scripting.Preserve]
internal sealed class ONFBHOKCCJH : CKHEKCFEJBC, DFDBGBPAMNI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class JDDOEBADPMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public JDDOEBADPMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x53697E0", Offset = "0x5367FE0", VA = "0x1853697E0")]
		internal object LKFDDKCIIML()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class IMOHBCOPAFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public IMOHBCOPAFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x53696C0", Offset = "0x5367EC0", VA = "0x1853696C0")]
		internal object PDFKOBNPFKG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private FMDMEJLHLEH NDDDHNPEAPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private LCPOKIJIEMA DCNEPGCFKGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private NAOOCAMJKJD HILGBMADMNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private OLLHPABCOHM GKDHGMAFBJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private DILLKHFEOGI FLIDPCKOPFM;

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x26738F0", Offset = "0x26720F0", VA = "0x1826738F0", Slot = "6")]
	public void BDCEDMLOOPD(IBHEBOMOMMF KPGFDADNAJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x2673C90", Offset = "0x2672490", VA = "0x182673C90", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x2674940", Offset = "0x2673140", VA = "0x182674940", Slot = "4")]
	public KHDFCDLHKAB OFOFNHIJBFM(GHGLDBKCJPG NKDCDCNCJMP)
	{
		return default(KHDFCDLHKAB);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x26741D0", Offset = "0x26729D0", VA = "0x1826741D0", Slot = "5")]
	public void IAAMIHKMJMI(Guid GMIOJDLOGJD, Task LCIAELPEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x26743E0", Offset = "0x2672BE0", VA = "0x1826743E0")]
	private void IHMOHEPKBDL(byte BCFOGCJCOLM, int BHOJLIDOGDH, object KIMMBGJFIBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x2674D80", Offset = "0x2673580", VA = "0x182674D80")]
	private void PBIHHFFLANK(BEIPDIGFAIE ANPGOOMAJOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x2673670", Offset = "0x2671E70", VA = "0x182673670")]
	private void AMJACDEKFIC(BEIPDIGFAIE ANPGOOMAJOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x2675390", Offset = "0x2673B90", VA = "0x182675390")]
	private void PIFNKEGPMEH(BEIPDIGFAIE ANPGOOMAJOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x2673F30", Offset = "0x2672730", VA = "0x182673F30")]
	private LIHOBIGHABN HBFFLGGOPHJ(GHGLDBKCJPG JHHCMCLGGPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x2673D30", Offset = "0x2672530", VA = "0x182673D30")]
	private void GMKGGLOBHFA(GHGLDBKCJPG JOLFHGIMGPL, LIHOBIGHABN OOIDINBGEIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x2674750", Offset = "0x2672F50", VA = "0x182674750")]
	private bool LNFKPJOPNEJ(GHGLDBKCJPG JOLFHGIMGPL, LIHOBIGHABN OOIDINBGEIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x2673A60", Offset = "0x2672260", VA = "0x182673A60")]
	private bool DKCDOIEMKAF(GHGLDBKCJPG LAGMMHIMPKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x26744B0", Offset = "0x2672CB0", VA = "0x1826744B0")]
	private bool LGLJPBJMBBB(byte BCFOGCJCOLM, ExitGames.Client.Photon.Hashtable ANPGOOMAJOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public ONFBHOKCCJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[UnityEngine.Scripting.Preserve]
internal sealed class BIDFKDMIJHP : NAOOCAMJKJD, DFDBGBPAMNI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private sealed class PAMDGINFHIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public AsyncTaskMethodBuilder<OPKDCMBHPLN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public BIDFKDMIJHP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private OPKDCMBHPLN <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private TaskAwaiter<OPKDCMBHPLN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public PAMDGINFHIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x2676750", Offset = "0x2674F50", VA = "0x182676750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private sealed class EKAOCBNACIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public GHGLDBKCJPG message;

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public EKAOCBNACIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x26660B0", Offset = "0x26648B0", VA = "0x1826660B0")]
		internal object EBGNNKECPOP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class EEEFGGOFEMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public GHGLDBKCJPG messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public EEEFGGOFEMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x2665C90", Offset = "0x2664490", VA = "0x182665C90")]
		internal object KDOLLEEIJLB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class IKBBIAHHOBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public GHGLDBKCJPG request;

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public IKBBIAHHOBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x2667630", Offset = "0x2665E30", VA = "0x182667630")]
		internal object PHBLIPFCAKI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class MHPHIHCLBKI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public GHGLDBKCJPG request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public BIDFKDMIJHP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		private IKBBIAHHOBF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private JKCDDAOJCAB <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private JKCDDAOJCAB <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		private TaskAwaiter<JKCDDAOJCAB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public MHPHIHCLBKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x266F2D0", Offset = "0x266DAD0", VA = "0x18266F2D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class NFILJONAHPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public GHGLDBKCJPG operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public NFILJONAHPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x266F9F0", Offset = "0x266E1F0", VA = "0x18266F9F0")]
		internal object GENHKLAGGAO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class PNKCNCKMCMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public GHGLDBKCJPG operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		public BIDFKDMIJHP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		private NFILJONAHPI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		private KODFOCGBOAL <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private GHGLDBKCJPG <syncedMessage>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private JKCDDAOJCAB <operation>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private GHGLDBKCJPG <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private IDisposable <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private TaskAwaiter<GHGLDBKCJPG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public PNKCNCKMCMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x267A7E0", Offset = "0x2678FE0", VA = "0x18267A7E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private sealed class EKIDFIONPPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public AsyncTaskMethodBuilder<JKCDDAOJCAB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public GHGLDBKCJPG request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		public BIDFKDMIJHP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private MKNBPKIBJIM.APHKFDBBGKO <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private KODFOCGBOAL <pauseToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private GHGLDBKCJPG <response>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private GHGLDBKCJPG <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		private TaskAwaiter<GHGLDBKCJPG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public EKIDFIONPPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x2666110", Offset = "0x2664910", VA = "0x182666110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class JAJNGPFPBJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public JKCDDAOJCAB operation;

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public JAJNGPFPBJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x2667690", Offset = "0x2665E90", VA = "0x182667690")]
		internal object GOOLJFDGLIO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private sealed class GBJMJJLFBLK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		public JKCDDAOJCAB operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		public BIDFKDMIJHP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private JAJNGPFPBJE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		private CINMLNOINGA<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		private CINMLNOINGA<string>.BIMPMJLMAHG <timerScope>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		private Task <task>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public GBJMJJLFBLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x2666D80", Offset = "0x2665580", VA = "0x182666D80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private sealed class LHDGJOIBMAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		public GHGLDBKCJPG request;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public LHDGJOIBMAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x266C9A0", Offset = "0x266B1A0", VA = "0x18266C9A0")]
		internal object CGNBAKIDGHE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class BFKDOKMMPKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		public GHGLDBKCJPG request;

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public BFKDOKMMPKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x2663220", Offset = "0x2661A20", VA = "0x182663220")]
		internal object DNKMJHKBHGP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	private IBHEBOMOMMF KPGFDADNAJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	private AJENGDNGBKE DIMNNKFLPIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	private CKHEKCFEJBC KNFMOMJMLCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	private FAMMOPHBNLM HEIOEDDDCAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private FMDMEJLHLEH NDDDHNPEAPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private TaskCompletionSource<OPKDCMBHPLN> GNKIOCHKLEA;

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x2042D50", Offset = "0x2041550", VA = "0x182042D50", Slot = "7")]
	public void BDCEDMLOOPD(IBHEBOMOMMF KPGFDADNAJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x2043F80", Offset = "0x2042780", VA = "0x182043F80", Slot = "6")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PAMDGINFHIA))]
	public Task<OPKDCMBHPLN> PAGPNKMAFLK(CancellationToken FKEBLKCLNOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x2042F80", Offset = "0x2041780", VA = "0x182042F80", Slot = "4")]
	public void DABOJJLFLCA(GHGLDBKCJPG AKADEFDGONP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x2042970", Offset = "0x2041170", VA = "0x182042970", Slot = "5")]
	public void BCGANAHFDNG(GHGLDBKCJPG MMBNHHFODKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x2042E30", Offset = "0x2041630", VA = "0x182042E30")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MHPHIHCLBKI))]
	private Task CNBKECLEMJP(GHGLDBKCJPG AJNIDCPPJGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x2043510", Offset = "0x2041D10", VA = "0x182043510")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PNKCNCKMCMM))]
	private Task DHBDGLFCAGC(GHGLDBKCJPG JOLFHGIMGPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x2043DE0", Offset = "0x20425E0", VA = "0x182043DE0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EKIDFIONPPN))]
	private Task<JKCDDAOJCAB> JKKFFOGHNBB(GHGLDBKCJPG AJNIDCPPJGC, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x2043CB0", Offset = "0x20424B0", VA = "0x182043CB0")]
	private KODFOCGBOAL INKFCKEDECO(GHGLDBKCJPG JHHCMCLGGPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x20433A0", Offset = "0x2041BA0", VA = "0x1820433A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GBJMJJLFBLK))]
	private Task DAPHGEJMEFD(JKCDDAOJCAB IKBOIGIEDJD, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x2043A90", Offset = "0x2042290", VA = "0x182043A90")]
	private JKCDDAOJCAB GLDBOJJPGMC(GHGLDBKCJPG AJNIDCPPJGC, KODFOCGBOAL GDLDNHJCBPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x1E65E30", Offset = "0x1E64630", VA = "0x181E65E30")]
	private T LIGJHBNAJLC<T>(T MENBIMCLIOI) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x2043660", Offset = "0x2041E60", VA = "0x182043660")]
	private JKCDDAOJCAB EEFHPIOIHKM(GHGLDBKCJPG AJNIDCPPJGC, KODFOCGBOAL GDLDNHJCBPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public BIDFKDMIJHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
internal interface BGDBDLPLBMK
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	TimeSpan NIHMNMPKKHN
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	TimeSpan CIKIBKKMLBA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	TimeSpan MJIPKNFIADA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	TimeSpan IPEGONALIFH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool HMGHAEMOKMA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool CJFFKMGOJDE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool AGAHOJGLEIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	int HKEIOJHCKJE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool LNJMHFJAOBK
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal interface ICPCKOBFFHD : DFDBGBPAMNI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<ACEIDINIJDO> IEHEMJKBMLE(CINMLNOINGA<string>.BIMPMJLMAHG KOKOCCCLBFO, EIEEEHDKLAP AINNEBBNIGO, CancellationToken NNLBJPBEHPF);
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
internal class ECHNBBDFCBC : LIPIDPBDNHA
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private sealed class OMJGHIKMLEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public ECHNBBDFCBC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public Matchmaking.GEKJHNHJMNF result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public EIEEEHDKLAP newPresenceRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public long currentInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public OMJGHIKMLEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x3DC4C90", Offset = "0x3DC3490", VA = "0x183DC4C90")]
		internal object NFDMBOJCOPF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x3DC4B80", Offset = "0x3DC3380", VA = "0x183DC4B80")]
		internal object EBEPDBIKJNK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x3DC4BF0", Offset = "0x3DC33F0", VA = "0x183DC4BF0")]
		internal object MEHNILECKLG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private sealed class HEEBOFEPEEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public ECHNBBDFCBC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		private OMJGHIKMLEL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		private Matchmaking.GEKJHNHJMNF <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		private TaskAwaiter<Matchmaking.GEKJHNHJMNF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public HEEBOFEPEEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x3DBE060", Offset = "0x3DBC860", VA = "0x183DBE060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private readonly IBHEBOMOMMF KPGFDADNAJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	private readonly CABGPNHLHHJ BOBHLPNKBHC;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private ONNFMGINMGB LNIEMJIJJKA
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x2050240", Offset = "0x204EA40", VA = "0x182050240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x8A72C0", Offset = "0x8A5AC0", VA = "0x1808A72C0")]
	public ECHNBBDFCBC(IBHEBOMOMMF KPGFDADNAJA, CABGPNHLHHJ BOBHLPNKBHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x2050290", Offset = "0x204EA90", VA = "0x182050290", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HEEBOFEPEEH))]
	public Task<bool> OIHALLMAEIO(CancellationToken NNLBJPBEHPF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
internal interface GCCDKLFKNBN : DFDBGBPAMNI, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal interface LIPIDPBDNHA
{
	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> OIHALLMAEIO(CancellationToken NNLBJPBEHPF);
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public interface JJLGDAGDHBD
{
	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ECPOPBIBECD(JMKPANAMBHF GHFLCALCPHG);

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GJECPNKKMGB(JMKPANAMBHF GHFLCALCPHG);

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NADELGDHBBB(JMKPANAMBHF GHFLCALCPHG);

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ADMDICPLIIO(JMKPANAMBHF GHFLCALCPHG);
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class JMKPANAMBHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public readonly EIEEEHDKLAP DIBHCEIDHAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private Dictionary<string, string> JGPJPMMLMEF;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public CINMLNOINGA<string> CDOFHNCOGPK
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x7EC6C0", Offset = "0x7EAEC0", VA = "0x1807EC6C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x8E74F0", Offset = "0x8E5CF0", VA = "0x1808E74F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x8BA230", Offset = "0x8B8A30", VA = "0x1808BA230")]
	public JMKPANAMBHF(EIEEEHDKLAP BDMCJDMKLJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x2060D40", Offset = "0x205F540", VA = "0x182060D40")]
	public JMKPANAMBHF BKDMKAAJMAM(string EECINICJCLK, string MENBIMCLIOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x2060E20", Offset = "0x205F620", VA = "0x182060E20")]
	public bool CNPNGMOJINH(out IEnumerable<KeyValuePair<string, string>> ABFKDMPIEEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x2060EC0", Offset = "0x205F6C0", VA = "0x182060EC0")]
	public JMKPANAMBHF IMNFGENEHNI(CINMLNOINGA<string> FMGNKDAMMIM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class EIKPEHKBEEP : TimeoutException
{
	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x1A18C20", Offset = "0x1A17420", VA = "0x181A18C20")]
	public EIKPEHKBEEP(string AKADEFDGONP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public interface ONNFMGINMGB
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	EIEEEHDKLAP OLAMOAGMFFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	JEELLOGMCHC DDMPEFJPIHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	CKNKGBNGABP MMPIGLBFFMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	bool MLEJIDDBOGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	bool MLDDFIJMCPG
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	int MELJJPHJHOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action CMLBLEEGHOP;

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event Action<int> ALLMHEJNDJO;

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BMPMJCKDEJP();

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.PHILMNKPMEJ> CEJJDEANFBO(long DFOMHFMOJCN, [Optional] CancellationToken NNLBJPBEHPF);

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<Matchmaking.GEKJHNHJMNF> BJPAOCDMHDC();

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task PNLGIPDGJCO();

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(Slot = "14")]
	(EIEEEHDKLAP, OBJPINOPCOH) FDHGABCHALC();

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(Slot = "15")]
	MCMNGPGPMDI HOOBBHKBDPB();

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void MHBDBKANMAE(long DFOMHFMOJCN);
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal interface FAMMOPHBNLM : DFDBGBPAMNI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<GHGLDBKCJPG> HNLDEGECMFD(GHGLDBKCJPG AJNIDCPPJGC, KODFOCGBOAL GDLDNHJCBPP, CancellationToken NNLBJPBEHPF);

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<GHGLDBKCJPG> FABDOBOHFFM(CancellationToken NNLBJPBEHPF, KODFOCGBOAL GDLDNHJCBPP);

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DOLCNHODOEC AENKFLJGIFL(JKCDDAOJCAB AABDJAEDFGA, CINMLNOINGA<string>.BIMPMJLMAHG KOKOCCCLBFO);

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DOLCNHODOEC MOJJDBKFGGL(JKCDDAOJCAB AABDJAEDFGA, CINMLNOINGA<string>.BIMPMJLMAHG KOKOCCCLBFO);
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal sealed class ONPOIHEDCMB : IBHEBOMOMMF, PDMJIAEOMIP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private sealed class BHDCOEBMBPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public AsyncTaskMethodBuilder<LIHOBIGHABN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public CCCEJDFLIPE autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public ONPOIHEDCMB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private LIHOBIGHABN <canRun>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		private LIHOBIGHABN <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private TaskAwaiter<LIHOBIGHABN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public BHDCOEBMBPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x5367240", Offset = "0x5365A40", VA = "0x185367240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private sealed class LENEGBDJJJM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		public ONPOIHEDCMB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		private LIHOBIGHABN <canRun>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public LENEGBDJJJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x536ABF0", Offset = "0x53693F0", VA = "0x18536ABF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private sealed class FCOEOCLOBMB : IEnumerable<DFDBGBPAMNI>, IEnumerable, IEnumerator<DFDBGBPAMNI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		private DFDBGBPAMNI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public ONPOIHEDCMB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		private DFDBGBPAMNI System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000287")]
			[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0xABFAA0", Offset = "0xABE2A0", VA = "0x180ABFAA0")]
		[DebuggerHidden]
		public FCOEOCLOBMB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x53681C0", Offset = "0x53669C0", VA = "0x1853681C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x5368640", Offset = "0x5366E40", VA = "0x185368640", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x53685A0", Offset = "0x5366DA0", VA = "0x1853685A0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<DFDBGBPAMNI> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x53685A0", Offset = "0x5366DA0", VA = "0x1853685A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private readonly CancellationTokenSource LPGDOGBAMLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private readonly LIFDIPFHEEA KEMGJJIKGPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	private bool PMADFOMNIPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private MNMANGPGGLN PNPOLHLBELD;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public FMDMEJLHLEH EAFGHDBHBCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x7DFCD0", Offset = "0x7DE4D0", VA = "0x1807DFCD0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x7ED760", Offset = "0x7EBF60", VA = "0x1807ED760")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public INMFNPDAJBI JNPMMEEPOKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x7ED770", Offset = "0x7EBF70", VA = "0x1807ED770", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x7ED750", Offset = "0x7EBF50", VA = "0x1807ED750")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public CABGPNHLHHJ BKEEIANIHAB
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x8A9ED0", Offset = "0x8A86D0", VA = "0x1808A9ED0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x8B28E0", Offset = "0x8B10E0", VA = "0x1808B28E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public GBAAIIHBBEB IOGBNHBHEDE
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x8A9EE0", Offset = "0x8A86E0", VA = "0x1808A9EE0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x8A9EF0", Offset = "0x8A86F0", VA = "0x1808A9EF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public AAAFEFBBLED OHMMGPOAINM
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x8E9050", Offset = "0x8E7850", VA = "0x1808E9050", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x8EAFC0", Offset = "0x8E97C0", VA = "0x1808EAFC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public KGKEADDOPJG ONMAONJHEDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x8E8B60", Offset = "0x8E7360", VA = "0x1808E8B60", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x939750", Offset = "0x937F50", VA = "0x180939750")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public JOBAJLNCBIL KGPDFLBOBJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x7DFD00", Offset = "0x7DE500", VA = "0x1807DFD00", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0xB3AA20", Offset = "0xB39220", VA = "0x180B3AA20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public AJENGDNGBKE BGPIOFMOJLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x7DFCF0", Offset = "0x7DE4F0", VA = "0x1807DFCF0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0xB39D50", Offset = "0xB38550", VA = "0x180B39D50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public GJKACIJINNC HHCACHPEKNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0xA51D10", Offset = "0xA50510", VA = "0x180A51D10", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0xA582E0", Offset = "0xA56AE0", VA = "0x180A582E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public ELDHJAHLBAJ IOJCDKJGAGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0xA51E50", Offset = "0xA50650", VA = "0x180A51E50", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0xA74D50", Offset = "0xA73550", VA = "0x180A74D50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public ABCLHJLIAGN EFFLKBNFEOA
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x7F0CD0", Offset = "0x7EF4D0", VA = "0x1807F0CD0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x7F0C70", Offset = "0x7EF470", VA = "0x1807F0C70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public PHALJJCOPEE GJJJONBPGNI
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x7F39B0", Offset = "0x7F21B0", VA = "0x1807F39B0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x7F3C00", Offset = "0x7F2400", VA = "0x1807F3C00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public ODLNEEDDNIG GHDIMLCEHDI
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0xA0BDA0", Offset = "0xA0A5A0", VA = "0x180A0BDA0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0xBB48C0", Offset = "0xBB30C0", VA = "0x180BB48C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public OLLHPABCOHM KHOKNNPIPMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0xA52590", Offset = "0xA50D90", VA = "0x180A52590", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0xBBFF70", Offset = "0xBBE770", VA = "0x180BBFF70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public GCCDKLFKNBN FMGFNFOABIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0xA4DA40", Offset = "0xA4C240", VA = "0x180A4DA40", Slot = "55")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x8EFCF0", Offset = "0x8EE4F0", VA = "0x1808EFCF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public NAOOCAMJKJD IOMDDAKGECL
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0xEBC510", Offset = "0xEBAD10", VA = "0x180EBC510", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x925B20", Offset = "0x924320", VA = "0x180925B20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public CKHEKCFEJBC JDIAPANBMMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x907500", Offset = "0x905D00", VA = "0x180907500", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0xD86930", Offset = "0xD85130", VA = "0x180D86930")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public PMNKKOGOEOL KOGLNPABFIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x92DCB0", Offset = "0x92C4B0", VA = "0x18092DCB0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x92D9E0", Offset = "0x92C1E0", VA = "0x18092D9E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public ICPCKOBFFHD FLIHALAFMHD
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x8FC280", Offset = "0x8FAA80", VA = "0x1808FC280", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x8FB0F0", Offset = "0x8F98F0", VA = "0x1808FB0F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public FAMMOPHBNLM MILBFLLDFIH
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x91A030", Offset = "0x918830", VA = "0x18091A030", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0xAEAE70", Offset = "0xAE9670", VA = "0x180AEAE70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public ENPMLALOKMM FCFEECMIGAD
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0xAE7B00", Offset = "0xAE6300", VA = "0x180AE7B00", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0xE9BD60", Offset = "0xE9A560", VA = "0x180E9BD60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public LCPOKIJIEMA FHANMGMEBIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x9F5010", Offset = "0x9F3810", VA = "0x1809F5010", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x9F8FF0", Offset = "0x9F77F0", VA = "0x1809F8FF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public JJLGDAGDHBD DGFEGGGNEFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x9073D0", Offset = "0x905BD0", VA = "0x1809073D0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x907490", Offset = "0x905C90", VA = "0x180907490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public DILLKHFEOGI AFPBIEEECFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x9073C0", Offset = "0x905BC0", VA = "0x1809073C0", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x907480", Offset = "0x905C80", VA = "0x180907480")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public BGCDPENCIFP COAOIACHOND
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x9284E0", Offset = "0x926CE0", VA = "0x1809284E0", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x9FDD90", Offset = "0x9FC590", VA = "0x1809FDD90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public BGDBDLPLBMK FNCGBIJEOBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0xA09C20", Offset = "0xA08420", VA = "0x180A09C20", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x9FA7C0", Offset = "0x9F8FC0", VA = "0x1809FA7C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public MPBDPAOGGJA CPMKCMIHMDD
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x8FC260", Offset = "0x8FAA60", VA = "0x1808FC260", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x8FB020", Offset = "0x8F9820", VA = "0x1808FB020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public ABKHNKAOKME MKEHBNFFPJI
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x8F2500", Offset = "0x8F0D00", VA = "0x1808F2500", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public EIOFPFLBFKO LLAGNJBGEOL
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x91C820", Offset = "0x91B020", VA = "0x18091C820", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public FPBEPBHJDBK PAFBMACNJAH
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x1177700", Offset = "0x1175F00", VA = "0x181177700", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public OBJPINOPCOH PDNPKIGMMFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0xC21850", Offset = "0xC20050", VA = "0x180C21850", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x932670", Offset = "0x930E70", VA = "0x180932670")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	private bool PKANJDFKDEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x2675B70", Offset = "0x2674370", VA = "0x182675B70", Slot = "46")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	private bool AJCLCOCDBOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x2675DD0", Offset = "0x26745D0", VA = "0x182675DD0", Slot = "47")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	private CancellationToken ELFBCPKHENM
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x2675FD0", Offset = "0x26747D0", VA = "0x182675FD0", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	private LIFDIPFHEEA NNAMLLDBKDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	private event Action BBKBCBKPPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x2675B10", Offset = "0x2674310", VA = "0x182675B10", Slot = "36")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x2675840", Offset = "0x2674040", VA = "0x182675840", Slot = "37")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	private event PGNFGNFCFOF FDGKACJJMED
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x2675F10", Offset = "0x2674710", VA = "0x182675F10", Slot = "38")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x2676060", Offset = "0x2674860", VA = "0x182676060", Slot = "39")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	private event PGNFGNFCFOF CGADAJJOKJO
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x26760C0", Offset = "0x26748C0", VA = "0x1826760C0", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x2675E50", Offset = "0x2674650", VA = "0x182675E50", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	private event PGNFGNFCFOF FFMDCAMKGKL
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x26761A0", Offset = "0x26749A0", VA = "0x1826761A0", Slot = "42")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x2675EB0", Offset = "0x26746B0", VA = "0x182675EB0", Slot = "43")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	private event Action<IILIALHMONN, bool> JGKICIBHOPO
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x2675F70", Offset = "0x2674770", VA = "0x182675F70", Slot = "44")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x2675D70", Offset = "0x2674570", VA = "0x182675D70", Slot = "45")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x932670", Offset = "0x930E70", VA = "0x180932670", Slot = "35")]
	public void KGJHOGNKGDD(OBJPINOPCOH CFLCJHPDPMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x2676200", Offset = "0x2674A00", VA = "0x182676200")]
	[UnityEngine.Scripting.Preserve]
	internal ONPOIHEDCMB([JHPEMCNOMHI(null)] LIFDIPFHEEA KEMGJJIKGPJ, [JHPEMCNOMHI(null)] FMDMEJLHLEH NDDDHNPEAPJ, [JHPEMCNOMHI(null)] INMFNPDAJBI DMGPBGFJPMN, [JHPEMCNOMHI(null)] CABGPNHLHHJ BOBHLPNKBHC, [JHPEMCNOMHI(null)] GBAAIIHBBEB NKNFNPJBGKA, [JHPEMCNOMHI(null)] AAAFEFBBLED PJOJCNMMMPL, [JHPEMCNOMHI(null)] KGKEADDOPJG IELDLCCFOIL, [JHPEMCNOMHI(null)] JOBAJLNCBIL JMDLAHHNDMP, [JHPEMCNOMHI(null)] AJENGDNGBKE DIMNNKFLPIE, [JHPEMCNOMHI(null)] GJKACIJINNC DNHPEJOEALK, [JHPEMCNOMHI(null)] ELDHJAHLBAJ DPBIPCAHMMJ, [JHPEMCNOMHI(null)] ABCLHJLIAGN FGDOGJAGEEG, [JHPEMCNOMHI(null)] PHALJJCOPEE BEOAGBDLIKI, [JHPEMCNOMHI(null)] ODLNEEDDNIG NFPPHFNLMLH, [JHPEMCNOMHI(null)] OLLHPABCOHM GKDHGMAFBJC, [JHPEMCNOMHI(null)] GCCDKLFKNBN KBJIIMMNOBN, [JHPEMCNOMHI(null)] NAOOCAMJKJD HILGBMADMNO, [JHPEMCNOMHI(null)] CKHEKCFEJBC KNFMOMJMLCM, [JHPEMCNOMHI(null)] PMNKKOGOEOL EIIHINMNLCC, [JHPEMCNOMHI(null)] ICPCKOBFFHD CPLKMBECHHE, [JHPEMCNOMHI(null)] ENPMLALOKMM PBJCLPJEIGE, [JHPEMCNOMHI(null)] FAMMOPHBNLM HEIOEDDDCAM, [JHPEMCNOMHI(null)] LCPOKIJIEMA DCNEPGCFKGA, [JHPEMCNOMHI(null)] JJLGDAGDHBD OEONAMNEEFC, [JHPEMCNOMHI(null)] DILLKHFEOGI FLIDPCKOPFM, [JHPEMCNOMHI(null)] BGDBDLPLBMK GGGECKCCDMK, [JHPEMCNOMHI(null)] MPBDPAOGGJA DAGIPIDMKID, [JHPEMCNOMHI(null)] ABKHNKAOKME CBCHMLLNOEJ, [JHPEMCNOMHI(null)] EIOFPFLBFKO GALIFFFIOPB, [JHPEMCNOMHI(null)] FPBEPBHJDBK DHCAGHDAJEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x26755E0", Offset = "0x2673DE0", VA = "0x1826755E0")]
	private void BDCEDMLOOPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x2675900", Offset = "0x2674100", VA = "0x182675900", Slot = "54")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x2675BD0", Offset = "0x26743D0", VA = "0x182675BD0", Slot = "48")]
	private void HJGOMEFADMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x2676120", Offset = "0x2674920", VA = "0x182676120", Slot = "49")]
	private DEENPPKGIPM PIHOHDJFNDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x2675A90", Offset = "0x2674290", VA = "0x182675A90", Slot = "50")]
	private CGACAFDDLHA EKOGAKFHCAI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x26756D0", Offset = "0x2673ED0", VA = "0x1826756D0", Slot = "51")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BHDCOEBMBPC))]
	private Task<LIHOBIGHABN> BLGHNHGFCMP(CCCEJDFLIPE NLFPMIFADDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x2675C20", Offset = "0x2674420", VA = "0x182675C20", Slot = "52")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LENEGBDJJJM))]
	private Task ILJHDPKCFBJ(CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x2675FF0", Offset = "0x26747F0", VA = "0x182675FF0")]
	[IteratorStateMachine(typeof(FCOEOCLOBMB))]
	private IEnumerable<DFDBGBPAMNI> OCHCGBCCBLK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x26758A0", Offset = "0x26740A0", VA = "0x1826758A0")]
	[CompilerGenerated]
	private void CPOLJOLKDNA(DFDBGBPAMNI CAOCJIHJELH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[RecRoom.NoEngine.Common.Preserve]
internal sealed class MALCIDECAOA : ICPCKOBFFHD, DFDBGBPAMNI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private sealed class MIFALNPGHBM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		public AsyncTaskMethodBuilder<ACEIDINIJDO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		public CINMLNOINGA<string>.BIMPMJLMAHG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public EIEEEHDKLAP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public MALCIDECAOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		private long <subRoomId>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		private JEELLOGMCHC <details>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		private JEELLOGMCHC <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		private TaskAwaiter<JEELLOGMCHC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public MIFALNPGHBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x36F1700", Offset = "0x36EFF00", VA = "0x1836F1700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private sealed class HHKLBHPMIDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public HHKLBHPMIDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x36E9C60", Offset = "0x36E8460", VA = "0x1836E9C60")]
		internal object ANEIGBBJMHF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class CHMCHDEOPAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public AsyncTaskMethodBuilder<JEELLOGMCHC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public EIEEEHDKLAP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public CINMLNOINGA<string>.BIMPMJLMAHG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public MALCIDECAOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		private HHKLBHPMIDJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		private CINMLNOINGA<string>.BIMPMJLMAHG <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		private JEELLOGMCHC <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		private TaskAwaiter<JEELLOGMCHC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public CHMCHDEOPAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x36E2960", Offset = "0x36E1160", VA = "0x1836E2960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private sealed class ADMCJNOEKEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public ADMCJNOEKEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0xA345C0", Offset = "0xA32DC0", VA = "0x180A345C0")]
		internal bool DCEDOHIFAOK(CKNKGBNGABP sr)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	private CABGPNHLHHJ BOBHLPNKBHC;

	[Cpp2IlInjected.Token(Token = "0x4000268")]
	private static readonly (CENNEHOCJAK superRoomData, long subRoomDataSaveId) HMOABIKNCKB;

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x266D590", Offset = "0x266BD90", VA = "0x18266D590", Slot = "5")]
	public void BDCEDMLOOPD(IBHEBOMOMMF KPGFDADNAJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x266D600", Offset = "0x266BE00", VA = "0x18266D600", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MIFALNPGHBM))]
	public Task<ACEIDINIJDO> IEHEMJKBMLE(CINMLNOINGA<string>.BIMPMJLMAHG KOKOCCCLBFO, EIEEEHDKLAP AINNEBBNIGO, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x266D7C0", Offset = "0x266BFC0", VA = "0x18266D7C0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CHMCHDEOPAJ))]
	private Task<JEELLOGMCHC> LNHAACDCPDD(EIEEEHDKLAP AINNEBBNIGO, CINMLNOINGA<string>.BIMPMJLMAHG KOKOCCCLBFO, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x266DD10", Offset = "0x266C510", VA = "0x18266DD10")]
	private ACEIDINIJDO PIJHJPGALJO(EIEEEHDKLAP AINNEBBNIGO, JEELLOGMCHC POGGBOCFANE, long OFFAGGOPNOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x266D980", Offset = "0x266C180", VA = "0x18266D980")]
	private (CENNEHOCJAK, long) PAPMHOACKFD(EIEEEHDKLAP AINNEBBNIGO, JEELLOGMCHC POGGBOCFANE, long OFFAGGOPNOB)
	{
		return default((CENNEHOCJAK, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public MALCIDECAOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public interface GBAAIIHBBEB
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	bool OINMKHCIBCL
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	string LEEBEKELKLB
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JDJJJPJCJBB(Scene CINKKNEJMNP);

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task LMNMMCDPMFI(BHPHMLLBEJC PODEBIIGMBC, CancellationToken NNLBJPBEHPF);

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task HEDGNNMKPMP();
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[UnityEngine.Scripting.Preserve]
internal sealed class EIMCMOPEGNP : FAMMOPHBNLM, DFDBGBPAMNI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	private sealed class DHNBBLJJHAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public GHGLDBKCJPG request;

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public DHNBBLJJHAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x3DBBD70", Offset = "0x3DBA570", VA = "0x183DBBD70")]
		internal object GIGLHCJHNAL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private sealed class POIDPJKPJNL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public AsyncTaskMethodBuilder<GHGLDBKCJPG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public GHGLDBKCJPG request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public KODFOCGBOAL pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public EIMCMOPEGNP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		private DHNBBLJJHAF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		private GHGLDBKCJPG <response>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		private GHGLDBKCJPG <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		private TaskAwaiter<GHGLDBKCJPG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public POIDPJKPJNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x3DC8950", Offset = "0x3DC7150", VA = "0x183DC8950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private sealed class DKCMKLHJLFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		public AsyncTaskMethodBuilder<GHGLDBKCJPG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		public KODFOCGBOAL pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		public EIMCMOPEGNP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		private GBODBCPKFEK.DLDANNIGHFL<GHGLDBKCJPG> <result>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		private LCKBMNOPIDB <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		private TaskAwaiter<LCKBMNOPIDB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public DKCMKLHJLFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x3DBBDD0", Offset = "0x3DBA5D0", VA = "0x183DBBDD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private sealed class IEHEAKGBAGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public GHGLDBKCJPG request;

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public IEHEAKGBAGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x3DBF360", Offset = "0x3DBDB60", VA = "0x183DBF360")]
		internal object DOIBAMOOBJD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class OPLNLDHHKNA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public AsyncTaskMethodBuilder<GHGLDBKCJPG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public GHGLDBKCJPG request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public KODFOCGBOAL pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public EIMCMOPEGNP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		private IEHEAKGBAGJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		private GLMLPFOGBAH <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		private PEFOHLEMBCD <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		private CancellationToken <masterSwitchCancellationToken>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private bool <sent>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		private GBODBCPKFEK.DLDANNIGHFL<GHGLDBKCJPG> <result>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		private GHGLDBKCJPG <response>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		private GLMLPFOGBAH <actualMessageKind>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		private LCKBMNOPIDB <>s__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		private TaskAwaiter<LCKBMNOPIDB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public OPLNLDHHKNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x3DC5B50", Offset = "0x3DC4350", VA = "0x183DC5B50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	private FMDMEJLHLEH NDDDHNPEAPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	private BGCDPENCIFP DPCNMCLHOBO;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	private GBODBCPKFEK CKGNDMJMDFO
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x20509A0", Offset = "0x204F1A0", VA = "0x1820509A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x2050740", Offset = "0x204EF40", VA = "0x182050740", Slot = "8")]
	public void BDCEDMLOOPD(IBHEBOMOMMF KPGFDADNAJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x2050BF0", Offset = "0x204F3F0", VA = "0x182050BF0", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(POIDPJKPJNL))]
	public Task<GHGLDBKCJPG> HNLDEGECMFD(GHGLDBKCJPG AJNIDCPPJGC, KODFOCGBOAL GDLDNHJCBPP, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x2050A50", Offset = "0x204F250", VA = "0x182050A50", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DKCMKLHJLFD))]
	public Task<GHGLDBKCJPG> FABDOBOHFFM(CancellationToken NNLBJPBEHPF, KODFOCGBOAL GDLDNHJCBPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x20504C0", Offset = "0x204ECC0", VA = "0x1820504C0", Slot = "6")]
	public DOLCNHODOEC AENKFLJGIFL(JKCDDAOJCAB AABDJAEDFGA, CINMLNOINGA<string>.BIMPMJLMAHG KOKOCCCLBFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x2050DB0", Offset = "0x204F5B0", VA = "0x182050DB0", Slot = "7")]
	public DOLCNHODOEC MOJJDBKFGGL(JKCDDAOJCAB AABDJAEDFGA, CINMLNOINGA<string>.BIMPMJLMAHG KOKOCCCLBFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x20507E0", Offset = "0x204EFE0", VA = "0x1820507E0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OPLNLDHHKNA))]
	private Task<GHGLDBKCJPG> ECJEPOOIOBF(GHGLDBKCJPG AJNIDCPPJGC, KODFOCGBOAL GDLDNHJCBPP, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x20507D0", Offset = "0x204EFD0", VA = "0x1820507D0")]
	private static byte[] DHOJPFJPJDI(GHGLDBKCJPG AKADEFDGONP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public EIMCMOPEGNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public readonly struct CODOOLJGMCM<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private sealed class LGMPLGHCAHP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public AsyncTaskMethodBuilder<DLDMCIANGML<ONMENFLLGCG<TData>, CFJKAHNEDBL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public CINMLNOINGA<string>.BIMPMJLMAHG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public CODOOLJGMCM<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		private byte[] <roomDataBytes>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		private CINMLNOINGA<string>.BIMPMJLMAHG <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private DLDMCIANGML<byte[], CFJKAHNEDBL> <res>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private DLDMCIANGML<byte[], CFJKAHNEDBL> <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private TaskAwaiter<DLDMCIANGML<byte[], CFJKAHNEDBL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0xC2D400", Offset = "0xC2BC00", VA = "0x180C2D400")]
		public LGMPLGHCAHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x20688F0", Offset = "0x20670F0", VA = "0x1820688F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	private readonly NFCAAPGFBFP<TGetDataArg, TData> PGKHJDIFGJI;

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x9E4D50", Offset = "0x9E3550", VA = "0x1809E4D50")]
	internal CODOOLJGMCM(NFCAAPGFBFP<TGetDataArg, TData> BPNALAJICIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x2446E50", Offset = "0x2445650", VA = "0x182446E50")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CODOOLJGMCM<, >.LGMPLGHCAHP))]
	public Task<DLDMCIANGML<ONMENFLLGCG<TData>, CFJKAHNEDBL>> NDGBNEMJOGM(TGetDataArg FFIGANEHPFB, string DHMHMNLPLMM, CINMLNOINGA<string>.BIMPMJLMAHG FMGNKDAMMIM, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public static class BLMDDCNJDOE
{
	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x12A5330", Offset = "0x12A3B30", VA = "0x1812A5330")]
	public static CODOOLJGMCM<TGetDataArg, TData> NKAIHPJAMOL<TGetDataArg, TData>(NFCAAPGFBFP<TGetDataArg, TData> BPNALAJICIC)
	{
		return default(CODOOLJGMCM<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[UnityEngine.Scripting.Preserve]
internal sealed class PPKDLEAPNEH : PMNKKOGOEOL, DFDBGBPAMNI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private sealed class OIJAKLFMMCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public OPKDCMBHPLN operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public PPKDLEAPNEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public GHGLDBKCJPG roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public OIJAKLFMMCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x536CE50", Offset = "0x536B650", VA = "0x18536CE50")]
		internal object DADHIMGMKCA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x536CD20", Offset = "0x536B520", VA = "0x18536CD20")]
		internal object AKGCGJDOPJK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class ALINNAHHGJG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public AsyncTaskMethodBuilder<LIHOBIGHABN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public GHGLDBKCJPG roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public PPKDLEAPNEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		private OIJAKLFMMCF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		private LIHOBIGHABN <result>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		private LIHOBIGHABN <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		private TaskAwaiter<LIHOBIGHABN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public ALINNAHHGJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x53667B0", Offset = "0x5364FB0", VA = "0x1853667B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private sealed class HNJMEGJHNOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public OPKDCMBHPLN operationType;

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public HNJMEGJHNOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x5369280", Offset = "0x5367A80", VA = "0x185369280")]
		internal object DGMLNJJKIAC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private sealed class LDFNMIPLCAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public GHGLDBKCJPG request;

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public LDFNMIPLCAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x536AB70", Offset = "0x5369370", VA = "0x18536AB70")]
		internal object HPFMCDNMEDA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x536AA70", Offset = "0x5369270", VA = "0x18536AA70")]
		internal object CMIKAJBDFLP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x536AAF0", Offset = "0x53692F0", VA = "0x18536AAF0")]
		internal object GJPEAFLDNBO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private sealed class NEEDBKCEAIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public AsyncTaskMethodBuilder<LIHOBIGHABN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public GHGLDBKCJPG request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public PPKDLEAPNEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		private LDFNMIPLCAK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		private KHDFCDLHKAB <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		private LIHOBIGHABN <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		private Task <operation>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		private (LIHOBIGHABN validationResult, Task operation) <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		private (LIHOBIGHABN validationResult, Task operation) <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		private TaskAwaiter<(LIHOBIGHABN validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public NEEDBKCEAIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x536BEF0", Offset = "0x536A6F0", VA = "0x18536BEF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	private FMDMEJLHLEH NDDDHNPEAPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	private LCPOKIJIEMA DCNEPGCFKGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	private CKHEKCFEJBC KNFMOMJMLCM;

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x267BBD0", Offset = "0x267A3D0", VA = "0x18267BBD0", Slot = "5")]
	public void BDCEDMLOOPD(IBHEBOMOMMF KPGFDADNAJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x267BFF0", Offset = "0x267A7F0", VA = "0x18267BFF0", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ALINNAHHGJG))]
	private Task<LIHOBIGHABN> JPCPINGIDJC(GHGLDBKCJPG JHHCMCLGGPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x267BDF0", Offset = "0x267A5F0", VA = "0x18267BDF0")]
	private bool HGAFJOANLCK(OPKDCMBHPLN AMDKOMACAKL, out LIHOBIGHABN LACIMGIMLFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x267BC80", Offset = "0x267A480", VA = "0x18267BC80")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NEEDBKCEAIJ))]
	private Task<LIHOBIGHABN> EDMPCDJPOLM(GHGLDBKCJPG AJNIDCPPJGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public PPKDLEAPNEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public static class OJIFPPBJHNM
{
	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public static LIHOBIGHABN FJNDLAIAPNH
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x2672D50", Offset = "0x2671550", VA = "0x182672D50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x2673280", Offset = "0x2671A80", VA = "0x182673280")]
	public static bool JPDPLLKAIJK(this LIHOBIGHABN OOIDINBGEIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x26732B0", Offset = "0x2671AB0", VA = "0x1826732B0")]
	public static LIHOBIGHABN PFAJPGBIPOB(IFCFBFPLHLH FDEHONHEHII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x2672DB0", Offset = "0x26715B0", VA = "0x182672DB0")]
	public static LIHOBIGHABN EHFDMGDGPBD(IEnumerable<LIHOBIGHABN> LCIGMEHPJNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x2672FD0", Offset = "0x26717D0", VA = "0x182672FD0")]
	public static string EPLCGEIDKDK(this LIHOBIGHABN LACIMGIMLFK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
[UnityEngine.Scripting.Preserve]
internal sealed class BJDHJOAKBNK : LCPOKIJIEMA, DFDBGBPAMNI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	private AAAFEFBBLED PJOJCNMMMPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	private FMDMEJLHLEH NDDDHNPEAPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	private AJENGDNGBKE DIMNNKFLPIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	private ENPMLALOKMM PBJCLPJEIGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	private CABGPNHLHHJ BOBHLPNKBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	private PHALJJCOPEE BEOAGBDLIKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	private ODLNEEDDNIG NFPPHFNLMLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	private BGDBDLPLBMK GGGECKCCDMK;

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	private ONNFMGINMGB LNIEMJIJJKA
	{
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x2044700", Offset = "0x2042F00", VA = "0x182044700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	private static LIHOBIGHABN FJNDLAIAPNH
	{
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x2044590", Offset = "0x2042D90", VA = "0x182044590")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x20445A0", Offset = "0x2042DA0", VA = "0x1820445A0", Slot = "6")]
	public void BDCEDMLOOPD(IBHEBOMOMMF KPGFDADNAJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x20449E0", Offset = "0x20431E0", VA = "0x1820449E0", Slot = "4")]
	public LIHOBIGHABN HEBALHBEPLD(BNKEEFOCAMM FONJCFDJEPP, OPKDCMBHPLN MHMGOHONFHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x2044750", Offset = "0x2042F50", VA = "0x182044750", Slot = "5")]
	public LIHOBIGHABN GGEPPGAFCMJ(BNKEEFOCAMM BDEPDJCOMPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x2044B70", Offset = "0x2043370", VA = "0x182044B70")]
	private static LIHOBIGHABN PFAJPGBIPOB(IFCFBFPLHLH LLLABGDENCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public BJDHJOAKBNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public delegate Task LAINJHKLPPK(ALNDGPDOBOK LHKEKFAGIAO, CancellationToken AMCDGOPKAOE);
[Cpp2IlInjected.Token(Token = "0x200009C")]
internal interface ODLNEEDDNIG : DFDBGBPAMNI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GJOBLJJGKOM(LAINJHKLPPK OLPDGDEMHJE);
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public interface DILLKHFEOGI
{
	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DDPOFFAMHNF(out IEnumerable<int> OOKELPAAALK);

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NKABPELKIEF(NHDFEEHHMNM AMCDGOPKAOE);

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NOCCNBKNPKJ(NHDFEEHHMNM AMCDGOPKAOE);
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public interface AHIAAMMJGHH
{
	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string HOIONFKDICO(LIHOBIGHABN OOIDINBGEIP);
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
internal interface PMNKKOGOEOL : DFDBGBPAMNI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<LIHOBIGHABN> KOGLNPABFIB(GHGLDBKCJPG JHHCMCLGGPM);
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
internal interface IBHEBOMOMMF : PDMJIAEOMIP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	CancellationToken NBOGMLIKDDO
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	LIFDIPFHEEA GGIICPPKOIN
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	FMDMEJLHLEH EAFGHDBHBCA
	{
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	INMFNPDAJBI JNPMMEEPOKP
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	CABGPNHLHHJ BKEEIANIHAB
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	GBAAIIHBBEB IOGBNHBHEDE
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	AAAFEFBBLED OHMMGPOAINM
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	KGKEADDOPJG ONMAONJHEDP
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	JOBAJLNCBIL KGPDFLBOBJP
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	AJENGDNGBKE BGPIOFMOJLG
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	GJKACIJINNC HHCACHPEKNK
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	ELDHJAHLBAJ IOJCDKJGAGD
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	ABCLHJLIAGN EFFLKBNFEOA
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	PHALJJCOPEE GJJJONBPGNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	ODLNEEDDNIG GHDIMLCEHDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	OLLHPABCOHM KHOKNNPIPMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	NAOOCAMJKJD IOMDDAKGECL
	{
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	CKHEKCFEJBC JDIAPANBMMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	PMNKKOGOEOL KOGLNPABFIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	ICPCKOBFFHD FLIHALAFMHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	FAMMOPHBNLM MILBFLLDFIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	ENPMLALOKMM FCFEECMIGAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	LCPOKIJIEMA FHANMGMEBIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	JJLGDAGDHBD DGFEGGGNEFD
	{
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	DILLKHFEOGI AFPBIEEECFO
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	BGCDPENCIFP COAOIACHOND
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	BGDBDLPLBMK FNCGBIJEOBC
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	MPBDPAOGGJA CPMKCMIHMDD
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	ABKHNKAOKME MKEHBNFFPJI
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	EIOFPFLBFKO LLAGNJBGEOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	FPBEPBHJDBK PAFBMACNJAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void KGJHOGNKGDD(OBJPINOPCOH CFLCJHPDPMD);
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
internal interface ABCLHJLIAGN : DFDBGBPAMNI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task KNNNINLDPHD();

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IEOKGHKFEMG();

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CCPAFFLIAHM();
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public static class OCMFDLJPJPP
{
	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x26710E0", Offset = "0x266F8E0", VA = "0x1826710E0")]
	public static void PGIJHHJLMPH(LIFDIPFHEEA KEMGJJIKGPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x2670FC0", Offset = "0x266F7C0", VA = "0x182670FC0")]
	internal static void OGHLIODPHGK(LIFDIPFHEEA KEMGJJIKGPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x2670EE0", Offset = "0x266F6E0", VA = "0x182670EE0")]
	internal static void OAIICFCDGOI(LIFDIPFHEEA KEMGJJIKGPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x2670A90", Offset = "0x266F290", VA = "0x182670A90")]
	internal static void IDFJGKKOMMB(LIFDIPFHEEA KEMGJJIKGPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public class DEKNIKAFGDI : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x204B510", Offset = "0x2049D10", VA = "0x18204B510")]
	public DEKNIKAFGDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x102AA30", Offset = "0x1029230", VA = "0x18102AA30")]
	public DEKNIKAFGDI(string AKADEFDGONP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
internal interface DFDBGBPAMNI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BDCEDMLOOPD(IBHEBOMOMMF KPGFDADNAJA);
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public interface CABGPNHLHHJ
{
	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	ONNFMGINMGB LNIEMJIJJKA
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	bool MJPOJJBCEPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	bool MCKHAJOOCOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	bool DANCBDADNKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	bool POBDMDIHGFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(Slot = "43")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	bool CIJODPOALCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	bool FMNPNMOJKKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	float MDDKBAEKBLC
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(Slot = "61")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	event Action<float> NDOBDACCPOF;

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LIFDIPFHEEA LNFIINLOMAG(LIFDIPFHEEA LECGLCGHAHI);

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MAIEFMMJADD(LIFDIPFHEEA KEMGJJIKGPJ);

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PPIICEDJENL();

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task ELLMILLFGPL(CINMLNOINGA<string>.BIMPMJLMAHG EFJEDEFMNFA, CancellationToken NNLBJPBEHPF);

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CPPEMIOBPNH(float HFPJIMMMMLO);

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BDIFADHBMNK(string NBKOLIOINOJ);

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IReadOnlyList<BCECPACDPCH> ENNPHPEEDIP();

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IDisposable MGMPLKJDPOI(object HNBDDLBIIOF, BCECPACDPCH FKHENLGIMDG);

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(Slot = "10")]
	PKMIHDKHPIO CHIEKKFAKHE(IEnumerable<GPPNCPPLGEE> IPPBOEDJIEJ);

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void GCHMLBNEPEO(int BENAEMLNMCF);

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task FALLABMNNCJ();

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void PFKHMGOKOMO();

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool JEFJKLPIGMD();

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task GHFIPKDFADM(CancellationToken NNLBJPBEHPF);

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task KFIPABLIJOD(CancellationToken NNLBJPBEHPF);

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task<EAAEFPCAICM> FLHPDFNPFOC(DateTime MBFAINBBPCK, CancellationToken NNLBJPBEHPF);

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task<bool> GANBIAKJKEP(CancellationToken NNLBJPBEHPF);

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void BOAPBJPJICB(string MNPBJDNKDNG = "", float DBCGMGMJHMI = 3f);

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(Slot = "22")]
	DDAOFGHLKDI OJJOCNFKFJF(FNOFEKPGFMA GGAFFNCHJDH, CACOFKKHDCM HDPBEFNDNDD, KHHPFHOAEJL LMDNFHKCFLI, IEnumerable<PersistenceView> ALGPCFOLEED, JDPGBMLKOMO PGHJDCNOLOE);

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void JFEOLGBGPHN(KHHPFHOAEJL LMDNFHKCFLI);

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void FIBDAHFBIPD(GPPNCPPLGEE AOPICFKOEII, in DDAOFGHLKDI OMCFDNJOAAE);

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Task FPAHFBOKFMG(KHHPFHOAEJL FINJDDGCGDL, bool HKIHCIOEKCI, CancellationToken NNLBJPBEHPF);

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Task BHHEIGFNDGH(CancellationToken NNLBJPBEHPF);

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void KMEGNMNNFMI(long AFGKPOPONBN, long HILPLFHHAPA, JEELLOGMCHC GMEHCBDKOIL, JDPJAFEOEAF BABFOLFKPAN, OOGLJJBDKMP FHNPDPEPPGC, FPDNLDMDEKC? OAFCKBHKKJO, CGHJAIDDPDJ? GHJJMKOKIIE);

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void NCOMMMDPOHN(long AFGKPOPONBN, long HILPLFHHAPA, CGHJAIDDPDJ? GHJJMKOKIIE);

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void PPECDBBAIHF(PersistenceView BMADHCKKBAA);

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool EIBINJIPPDK(PersistenceView DNMGFMBFODC);

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(Slot = "31")]
	bool KBKDCBFFAGI(GPPNCPPLGEE AOPICFKOEII, MIKHCJJNMEJ MKLKDNDCMFI, out MIGDMEODDAL KLBELENHOJG);

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(Slot = "32")]
	Task CAMIDMOAJJC(CancellationToken NNLBJPBEHPF);

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void CPBGKBHCKBB();

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(Slot = "34")]
	IDisposable EBPEPEMFCIN();

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void MDLEBHMBGNP(KHHPFHOAEJL FINJDDGCGDL, MIKHCJJNMEJ MKLKDNDCMFI);

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(Slot = "36")]
	Task<bool> FKFBLPKHMNH(FMDMEJLHLEH NDDDHNPEAPJ, CancellationToken NNLBJPBEHPF, CINMLNOINGA<string>.BIMPMJLMAHG KOKOCCCLBFO);

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void GHNPFAMPOEF(CancellationToken NNLBJPBEHPF);

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(Slot = "38")]
	Task<JHAJGBINBJN> GMCJPKDIKMJ(OEKAHMNFJPC AJNIDCPPJGC);

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task<JEELLOGMCHC> MAPOFFEMPEP(long AFGKPOPONBN, bool BKNKEKJJMKK, CancellationToken NNLBJPBEHPF);

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<JDPJAFEOEAF> LNDPCBPNNOK(long AFGKPOPONBN, long HILPLFHHAPA, long GJGLINJHGOI, CancellationToken NNLBJPBEHPF);

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task<FGPPKDDGLJL> GJKFKPFIDIA(string ICCNANGPCBP, CancellationToken NNLBJPBEHPF);

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<FGPPKDDGLJL> FDPCKLCOAEP(string ICCNANGPCBP, long AFGKPOPONBN, long HILPLFHHAPA, string MOPJJOOHADC, OJEPPNBNJAH.PIOMGEMFMGO LHKEKFAGIAO, OJEPPNBNJAH.PIOMGEMFMGO BLJOCIDGDDI, int PBBACJMGNAB);

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(Slot = "44")]
	bool MMGDMNNOFDE();

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool CJFGCMPEIIJ();

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(Slot = "46")]
	bool PMBCOCDACKH(IEnumerable<MIGDMEODDAL> HEGJIANKHLM);

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(Slot = "47")]
	void KBIGEPNOODD(List<GameObject> GHPOFAFDPGB);

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(Slot = "48")]
	float BKPHDJMMOBH();

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(Slot = "49")]
	Task<Scene> PHMDGEHGMAN(string EOFLALLFEDN, LoadSceneMode CHFOAPGNLAA, bool EMBCONAHFKN, CINMLNOINGA<string>.BIMPMJLMAHG FMGNKDAMMIM);

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(Slot = "50")]
	void HEDMFPJHALC();

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(Slot = "51")]
	bool DLMAIHLOBIE(ByteString BLAINNBNMDK);

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(Slot = "54")]
	void EKABLNLPGLL(bool HLEJICMEJHJ);

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(Slot = "55")]
	Task KMOEBOKJHAO();

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(Slot = "56")]
	Task OILLINLDEFD();

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void CFHLEJKGPHE();

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(Slot = "58")]
	void FJFGOJFMMHB();

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(Slot = "62")]
	void NJPFELIONBF(EIEEEHDKLAP BMLLEHGGNOI);

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(Slot = "63")]
	Task FPHELLCEFNF(CINMLNOINGA<string>.BIMPMJLMAHG KOKOCCCLBFO, CancellationToken NNLBJPBEHPF);

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(Slot = "64")]
	Task BCOCFNIMABA(CINMLNOINGA<string>.BIMPMJLMAHG KOKOCCCLBFO, CancellationToken NNLBJPBEHPF);

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(Slot = "65")]
	Task GKIFNNDNOAL(CINMLNOINGA<string>.BIMPMJLMAHG KOKOCCCLBFO, CancellationToken NNLBJPBEHPF);

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(Slot = "66")]
	IDisposable LPIFJFBCPHF();

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(Slot = "67")]
	NCMPBPMKDEC JKEMIGCHJGE();

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(Slot = "68")]
	Task HMEJCJPHJKA(CancellationToken NNLBJPBEHPF);
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public interface NCMPBPMKDEC
{
	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task AMLEAAHJAFE(CancellationToken NNLBJPBEHPF);

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task BEKLNFKKGFN(CancellationToken NNLBJPBEHPF);
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public struct DDAOFGHLKDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public HashSet<int> MPBNGCGNHEP;
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public enum EAAEFPCAICM : byte
{
	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	No,
	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public struct FNOFEKPGFMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public bool ICDHHPNNFDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public string AIMLAPGCGPK;
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
internal static class IKCFNEMPEML
{
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private sealed class ENCKOLPKINP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public CINMLNOINGA<string> timer;

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public ENCKOLPKINP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x36E5F80", Offset = "0x36E4780", VA = "0x1836E5F80")]
		internal object AJLNINEBNND()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x205FB90", Offset = "0x205E390", VA = "0x18205FB90")]
	public static CINMLNOINGA<string> PKILLMGIFHO(JNGNMMOLKFF MBNJNNGOKFP, [Optional] string FPPCBOPEDNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x205FAC0", Offset = "0x205E2C0", VA = "0x18205FAC0")]
	public static void LHDCEFABGOM(CINMLNOINGA<string> FMGNKDAMMIM, JNGNMMOLKFF MBNJNNGOKFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x205F9E0", Offset = "0x205E1E0", VA = "0x18205F9E0")]
	public static string IHPMCIPBCKB(GHGLDBKCJPG JHHCMCLGGPM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[UnityEngine.Scripting.Preserve]
internal class KKGBDKMDHPN : ODLNEEDDNIG, DFDBGBPAMNI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private sealed class OMGBLHBMELK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public ALNDGPDOBOK roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public KKGBDKMDHPN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		private Func<CancellationToken, List<Task>> <taskGenerator>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		private Exception <ex>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public OMGBLHBMELK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x36F30C0", Offset = "0x36F18C0", VA = "0x1836F30C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private sealed class HJFIPFCIFPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public KKGBDKMDHPN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public ALNDGPDOBOK roomData;

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public HJFIPFCIFPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x36E9D10", Offset = "0x36E8510", VA = "0x1836E9D10")]
		internal List<Task> ACNILJLIEHG(CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private sealed class LBDGDNCBLAL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public LAINJHKLPPK taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public ALNDGPDOBOK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public KKGBDKMDHPN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		private Exception <ex>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public LBDGDNCBLAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x36ED050", Offset = "0x36EB850", VA = "0x1836ED050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private sealed class FILIIPGNFIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public KKGBDKMDHPN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public FILIIPGNFIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x36E6300", Offset = "0x36E4B00", VA = "0x1836E6300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	private readonly HashSet<LAINJHKLPPK> NIFFHMGJAEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	private INMFNPDAJBI DMGPBGFJPMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	private IBHEBOMOMMF KPGFDADNAJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	private BCECPACDPCH MAJNKEDKHKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	private HPCMLLFOALH MJDDOINKHIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	private IDisposable KEHEJLKHFFA;

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x2669D20", Offset = "0x2668520", VA = "0x182669D20", Slot = "5")]
	public void BDCEDMLOOPD(IBHEBOMOMMF KPGFDADNAJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x266A590", Offset = "0x2668D90", VA = "0x18266A590", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x266A8E0", Offset = "0x26690E0", VA = "0x18266A8E0", Slot = "4")]
	public bool GJOBLJJGKOM(LAINJHKLPPK OLPDGDEMHJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x2669BD0", Offset = "0x26683D0", VA = "0x182669BD0")]
	private void ADDHOKNPLNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x266AA60", Offset = "0x2669260", VA = "0x18266AA60")]
	private void OAGLNNHLGGG(ALNDGPDOBOK LHKEKFAGIAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x266A5F0", Offset = "0x2668DF0", VA = "0x18266A5F0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OMGBLHBMELK))]
	private Task EEBJDNOAOOO(ALNDGPDOBOK LHKEKFAGIAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x266ACC0", Offset = "0x26694C0", VA = "0x18266ACC0")]
	private Func<CancellationToken, List<Task>> PIKJGBFDDHD(ALNDGPDOBOK LHKEKFAGIAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x266A070", Offset = "0x2668870", VA = "0x18266A070")]
	private List<Task> CGKCKFPAFNO(ALNDGPDOBOK LHKEKFAGIAO, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x266A740", Offset = "0x2668F40", VA = "0x18266A740")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LBDGDNCBLAL))]
	private Task EKNKIDBFCJO(LAINJHKLPPK CBENLGODNFP, ALNDGPDOBOK NFBDMLCENEN, CancellationToken AMCDGOPKAOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x266A940", Offset = "0x2669140", VA = "0x18266A940")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FILIIPGNFIG))]
	private Task IFEKFNODMHJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x2669FF0", Offset = "0x26687F0", VA = "0x182669FF0")]
	private void CCPAFFLIAHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x266ADA0", Offset = "0x26695A0", VA = "0x18266ADA0")]
	public KKGBDKMDHPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
internal interface AJENGDNGBKE : DFDBGBPAMNI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000086")]
	bool IHCOHBJBFMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	Task JEANKLIAKAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BGCBBDHNGON(Task KOOMIGAFDLJ, string PPCPJBDPAGE);
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
internal class IOCELNCIMFA : LIPIDPBDNHA
{
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private sealed class GFDBGFEOKMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public IOCELNCIMFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public GFDBGFEOKMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x36E76B0", Offset = "0x36E5EB0", VA = "0x1836E76B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000306")]
	private readonly IBHEBOMOMMF KPGFDADNAJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000307")]
	private readonly CABGPNHLHHJ BOBHLPNKBHC;

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x8A72C0", Offset = "0x8A5AC0", VA = "0x1808A72C0")]
	public IOCELNCIMFA(IBHEBOMOMMF KPGFDADNAJA, CABGPNHLHHJ BOBHLPNKBHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x205FD50", Offset = "0x205E550", VA = "0x18205FD50", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GFDBGFEOKMG))]
	public Task<bool> OIHALLMAEIO(CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x205FC70", Offset = "0x205E470", VA = "0x18205FC70")]
	[CompilerGenerated]
	private object IDICPMBBJKC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public class HDDCBPHKEBC : FOAHAJNCECK, AAAFEFBBLED, BPKBINKBDLP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private sealed class IKOIDPPFNCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public LIHOBIGHABN result;

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public IKOIDPPFNCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x3DBF530", Offset = "0x3DBDD30", VA = "0x183DBF530")]
		internal object AJFEINGAGCF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x2057650", Offset = "0x2055E50", VA = "0x182057650")]
	[UnityEngine.Scripting.Preserve]
	public HDDCBPHKEBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x205B560", Offset = "0x2059D60", VA = "0x18205B560", Slot = "8")]
	public LIHOBIGHABN MPBDHCOLPGL(BNKEEFOCAMM BDEPDJCOMPP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public interface MPBDPAOGGJA
{
	[Cpp2IlInjected.Token(Token = "0x17000088")]
	bool LAILIEJFDPK
	{
		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	string OMEKENLJMCC
	{
		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KCINFOABIHA();

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EAPMMHAANAI BFKBLBPJEFE(long DFOMHFMOJCN);

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(Slot = "4")]
	NFCAAPGFBFP<CENNEHOCJAK, PKMIHDKHPIO> LOCJCNOOGPP(long DFOMHFMOJCN);

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NFCAAPGFBFP<CENNEHOCJAK, KHHPFHOAEJL> FFMCHCMMLBJ(long DFOMHFMOJCN);

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NFCAAPGFBFP<long, KPJPJIKAGDF> LGINMIHKDBN();

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task<bool> HOANACCCDBE(byte[] GGGHMACDDAC, byte[] BLJOCIDGDDI, CancellationToken NNLBJPBEHPF);
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
[UnityEngine.Scripting.Preserve]
internal sealed class GMEEICAGGJL : OLLHPABCOHM, DFDBGBPAMNI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private sealed class FGAFIALFLEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public FGAFIALFLEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x3DBCC60", Offset = "0x3DBB460", VA = "0x183DBCC60")]
		internal object HCHLLPNBOGB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private sealed class ABAGCDPPEMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public ABAGCDPPEMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x3DB8F50", Offset = "0x3DB7750", VA = "0x183DB8F50")]
		internal object PEEKCEKGGIF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private sealed class ELBFIOHNDLD
	{
		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public ELBFIOHNDLD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private sealed class JEKPIOBILCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public JEKPIOBILCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x3DBF650", Offset = "0x3DBDE50", VA = "0x183DBF650")]
		internal object EBALFEJLFGI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private sealed class IDELIKKCFII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public IDELIKKCFII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x3DBEDE0", Offset = "0x3DBD5E0", VA = "0x183DBEDE0")]
		internal object IAOFFHPIFME()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400030E")]
	private readonly Dictionary<Guid, PPBILANGAJG> GKDHGMAFBJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400030F")]
	private readonly TimeSpan GOLDHCMCLPC;

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "9")]
	public void BDCEDMLOOPD(IBHEBOMOMMF KPGFDADNAJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x205A890", Offset = "0x2059090", VA = "0x18205A890", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x205AAB0", Offset = "0x20592B0", VA = "0x18205AAB0", Slot = "4")]
	public KHDFCDLHKAB GLILACFFLBJ(Guid GMIOJDLOGJD)
	{
		return default(KHDFCDLHKAB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x205A8A0", Offset = "0x20590A0", VA = "0x18205A8A0", Slot = "5")]
	public bool FNJGHMKCCPI(Guid GMIOJDLOGJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x205B140", Offset = "0x2059940", VA = "0x18205B140", Slot = "6")]
	public bool OPNIPEFBDEP(Guid GMIOJDLOGJD, Task LCIAELPEAAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x205ACE0", Offset = "0x20594E0", VA = "0x18205ACE0", Slot = "7")]
	public bool MBCIHMJLFCI(Guid GMIOJDLOGJD, LIHOBIGHABN OOIDINBGEIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x205AEC0", Offset = "0x20596C0", VA = "0x18205AEC0", Slot = "8")]
	public Task<(LIHOBIGHABN, Task)> MPMMGIOMEKI(Guid GMIOJDLOGJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x205AF30", Offset = "0x2059730", VA = "0x18205AF30")]
	private void OMLOEOMHEPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x205B4A0", Offset = "0x2059CA0", VA = "0x18205B4A0")]
	public GMEEICAGGJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public class MAILIKGBCKA : FOAHAJNCECK, KGKEADDOPJG, BPKBINKBDLP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private sealed class NOMMBOKEMJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public LIHOBIGHABN result;

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public NOMMBOKEMJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x36F1DA0", Offset = "0x36F05A0", VA = "0x1836F1DA0")]
		internal object MCHHHPGIPGF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x266D580", Offset = "0x266BD80", VA = "0x18266D580")]
	[UnityEngine.Scripting.Preserve]
	public MAILIKGBCKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x266D460", Offset = "0x266BC60", VA = "0x18266D460", Slot = "8")]
	public LIHOBIGHABN EDBBIIADPPN(BNKEEFOCAMM KIHPDBAJKAD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
internal interface PHALJJCOPEE : DFDBGBPAMNI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	TaskStatus FLGIHILCPIN
	{
		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task JALFNFHDCCE(EIEEEHDKLAP AINNEBBNIGO, OBJPINOPCOH KFBCHHABIKI, CancellationToken MAGFBIFMOHG);
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
internal static class LGBKJEABOCE
{
	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x266C7B0", Offset = "0x266AFB0", VA = "0x18266C7B0")]
	public static bool GFNPDCHBALL(this PHALJJCOPEE BEOAGBDLIKI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
internal static class LALFPKLNAKL
{
	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x266C1A0", Offset = "0x266A9A0", VA = "0x18266C1A0")]
	public static bool HGKPNJCDLIJ(this EIEEEHDKLAP BDMCJDMKLJB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
[UnityEngine.Scripting.Preserve]
internal class MFIIMCLGDLD : ABCLHJLIAGN, DFDBGBPAMNI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private sealed class MGLKDLCFGFF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public MFIIMCLGDLD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public MGLKDLCFGFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x36F0F90", Offset = "0x36EF790", VA = "0x1836F0F90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[CompilerGenerated]
	private sealed class HFKBFMAOIAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		public MFIIMCLGDLD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		private bool <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public HFKBFMAOIAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x36E98E0", Offset = "0x36E80E0", VA = "0x1836E98E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[CompilerGenerated]
	private sealed class HKIOJNJGFAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public HKIOJNJGFAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x36E9D40", Offset = "0x36E8540", VA = "0x1836E9D40")]
		internal object JHMPCLLABKL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[CompilerGenerated]
	private sealed class BBDMEKBLCDO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		public MFIIMCLGDLD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		private HKIOJNJGFAF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		private LIPIDPBDNHA <provider>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		private bool <success>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		private bool <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		private Exception <ex>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public BBDMEKBLCDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x36E15F0", Offset = "0x36DFDF0", VA = "0x1836E15F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	[CompilerGenerated]
	private sealed class GHMDBHHJGPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public GHMDBHHJGPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x36E8100", Offset = "0x36E6900", VA = "0x1836E8100")]
		internal object NCCMAJMHBMD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000315")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000316")]
	private IBHEBOMOMMF KPGFDADNAJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000317")]
	private CABGPNHLHHJ BOBHLPNKBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000318")]
	private LIPIDPBDNHA[] GENGDGANCDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000319")]
	private CancellationTokenSource EFIOOPGMKMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400031A")]
	private int DEAHCAOIPKN;

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x266DF20", Offset = "0x266C720", VA = "0x18266DF20", Slot = "7")]
	public void BDCEDMLOOPD(IBHEBOMOMMF KPGFDADNAJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x266E460", Offset = "0x266CC60", VA = "0x18266E460", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x266DFA0", Offset = "0x266C7A0", VA = "0x18266DFA0", Slot = "6")]
	public void CCPAFFLIAHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x266E9C0", Offset = "0x266D1C0", VA = "0x18266E9C0", Slot = "5")]
	public void IEOKGHKFEMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x266EAA0", Offset = "0x266D2A0", VA = "0x18266EAA0", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MGLKDLCFGFF))]
	public Task KNNNINLDPHD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x266E700", Offset = "0x266CF00", VA = "0x18266E700")]
	private void GKLAGANABGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x266E310", Offset = "0x266CB10", VA = "0x18266E310")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HFKBFMAOIAM))]
	private Task DCLPAOOAIGA(CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x266E470", Offset = "0x266CC70", VA = "0x18266E470")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BBDMEKBLCDO))]
	private Task<bool> EBEHKAEJJEB(int AMOEKOMGDLG, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x266EBC0", Offset = "0x266D3C0", VA = "0x18266EBC0")]
	private void PMKEFBNNONN(int AMOEKOMGDLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x266E600", Offset = "0x266CE00", VA = "0x18266E600")]
	private void EFDDHNKALAD(int AMOEKOMGDLG, bool NFFGKDNLOEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x266E0B0", Offset = "0x266C8B0", VA = "0x18266E0B0")]
	private void CEJGMBJFDGA(int AMOEKOMGDLG, Exception IDAOICDGJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x266E1F0", Offset = "0x266C9F0", VA = "0x18266E1F0")]
	private void CFHFNPDIFFC(CancellationToken NNLBJPBEHPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x266ED40", Offset = "0x266D540", VA = "0x18266ED40")]
	public MFIIMCLGDLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal static class GCPFDFHBINK
{
	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x2059990", Offset = "0x2058190", VA = "0x182059990")]
	public static void MJGCEPIDEHB(this FMDMEJLHLEH NDDDHNPEAPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x2059870", Offset = "0x2058070", VA = "0x182059870")]
	public static void DHLLMJDDFCB(this FMDMEJLHLEH NDDDHNPEAPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x2059880", Offset = "0x2058080", VA = "0x182059880")]
	private static void GCMHMIMGEKG(this FMDMEJLHLEH NDDDHNPEAPJ, bool NIMLCAGDNDA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public struct EHEGGLOKEKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public readonly NNANMCHPHNH FDEEAEDKNPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public readonly string JMFBOEHPDJF;

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x20504A0", Offset = "0x204ECA0", VA = "0x1820504A0")]
	public EHEGGLOKEKB(string EHMLDFGKOGJ, NNANMCHPHNH IBOCEJCODCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x2050400", Offset = "0x204EC00", VA = "0x182050400")]
	public string AIBGHNMNMGE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public delegate string FBCNLGCOMNK<in T>(T IDAOICDGJBJ) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public delegate int PGDPAAHOGLH<in T>(T IDAOICDGJBJ) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000CC")]
internal class GCNLLONBHHM : FPBEPBHJDBK
{
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	private delegate string BENNMGDCOGG(Exception IDAOICDGJBJ);

	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	private delegate int ELPHFCMDOAM(Exception IDAOICDGJBJ);

	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	private class GKBDNGMGGCC<T> : JMLIIOJMFMB<T> where T : notnull, Exception
	{
		[Cpp2IlInjected.Token(Token = "0x20000D0")]
		[CompilerGenerated]
		private sealed class PHAONHDEIAL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000340")]
			public string errorMessage;

			[Cpp2IlInjected.Token(Token = "0x60003F4")]
			[Cpp2IlInjected.Address(RVA = "0xC2D400", Offset = "0xC2BC00", VA = "0x180C2D400")]
			public PHAONHDEIAL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F5")]
			[Cpp2IlInjected.Address(RVA = "0x7DF170", Offset = "0x7DD970", VA = "0x1807DF170")]
			internal string DOONFMJEBDF(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D1")]
		[CompilerGenerated]
		private sealed class IGGLHEDIAGL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000341")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67D550", Offset = "0x67C950")]
			public FBCNLGCOMNK<T> errorMessageBuilder;

			[Cpp2IlInjected.Token(Token = "0x60003F6")]
			[Cpp2IlInjected.Address(RVA = "0xC2D400", Offset = "0xC2BC00", VA = "0x180C2D400")]
			public IGGLHEDIAGL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F7")]
			[Cpp2IlInjected.Address(RVA = "0x24998F0", Offset = "0x24980F0", VA = "0x1824998F0")]
			internal string OLHPJIDAMAH(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D2")]
		[CompilerGenerated]
		private sealed class IMDLEHMEPGI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000342")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67D5B0", Offset = "0x67C9B0")]
			public PGDPAAHOGLH<T> getSubCode;

			[Cpp2IlInjected.Token(Token = "0x60003F8")]
			[Cpp2IlInjected.Address(RVA = "0xC2D400", Offset = "0xC2BC00", VA = "0x180C2D400")]
			public IMDLEHMEPGI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F9")]
			[Cpp2IlInjected.Address(RVA = "0x24998F0", Offset = "0x24980F0", VA = "0x1824998F0")]
			internal int GIEENOPMJGF(Exception ex)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		private readonly GCNLLONBHHM DHCAGHDAJEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		private readonly Type HABHFBHFDID;

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x2081D60", Offset = "0x2080560", VA = "0x182081D60")]
		internal GKBDNGMGGCC(GCNLLONBHHM DHCAGHDAJEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x2081CF0", Offset = "0x20804F0", VA = "0x182081CF0", Slot = "4")]
		public void KAGNPIHHNIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x2081BF0", Offset = "0x20803F0", VA = "0x182081BF0", Slot = "5")]
		public JMLIIOJMFMB<T> HGIOBDGEEJB(string FHHEEEGOKNF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x2081AF0", Offset = "0x20802F0", VA = "0x182081AF0", Slot = "6")]
		public JMLIIOJMFMB<T> DFBDHBAMEKM(FBCNLGCOMNK<T> GCBGDOMMJMC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x2081D20", Offset = "0x2080520", VA = "0x182081D20", Slot = "7")]
		public JMLIIOJMFMB<T> OCGPOEDFHIJ(int IBOCEJCODCK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x20819D0", Offset = "0x20801D0", VA = "0x1820819D0", Slot = "8")]
		public JMLIIOJMFMB<T> DCDFMBIEIMF(int IBOCEJCODCK, PGDPAAHOGLH<T> FLKCBMJNNBL)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	private class ECCNMGINCDM<TVal> where TVal : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		private bool LONEDFKCIJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		private readonly List<Type> PAPBKCBPLNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		private readonly Dictionary<Type, TVal> PAODDIPCLGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		private readonly Dictionary<Type, int> FJBHGACDLAF;

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public IReadOnlyList<Type> KMIAMLCIAIF
		{
			[Cpp2IlInjected.Token(Token = "0x60003FC")]
			[Cpp2IlInjected.Address(RVA = "0x2D97D30", Offset = "0x2D96530", VA = "0x182D97D30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x2D97EF0", Offset = "0x2D966F0", VA = "0x182D97EF0")]
		public ECCNMGINCDM(Dictionary<Type, int> FJBHGACDLAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x2D97A60", Offset = "0x2D96260", VA = "0x182D97A60")]
		public void GLILACFFLBJ(Type EECINICJCLK, TVal BNMGNDJJNJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x2D97990", Offset = "0x2D96190", VA = "0x182D97990")]
		public bool BMMDLBHEFHE(Type HABHFBHFDID)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x2D97B00", Offset = "0x2D96300", VA = "0x182D97B00")]
		public bool INGPOKBKKKP(TVal MENBIMCLIOI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x211B490", Offset = "0x2119C90", VA = "0x18211B490")]
		public TVal LPKBLHIFLLL(Type EIOLDDJPDLH)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x2D97BD0", Offset = "0x2D963D0", VA = "0x182D97BD0")]
		[CompilerGenerated]
		private int JBLIGIKAHEM(Type EOBBPCIGEAD, Type KCPOKFKIBDC)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	[CompilerGenerated]
	private sealed class FLFDDODCPCM : IEnumerable<NNANMCHPHNH>, IEnumerable, IEnumerator<NNANMCHPHNH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		private NNANMCHPHNH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		private Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public Exception <>3__ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		public GCNLLONBHHM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		private AggregateException <aggregateException>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		private IEnumerator<Exception> <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		private Exception <innerException>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		private IEnumerator<NNANMCHPHNH> <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		private NNANMCHPHNH <innerErrorCode>5__5;

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		private NNANMCHPHNH System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.Errors.ErrorCode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000406")]
			[Cpp2IlInjected.Address(RVA = "0x291D730", Offset = "0x291BF30", VA = "0x18291D730", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(NNANMCHPHNH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000408")]
			[Cpp2IlInjected.Address(RVA = "0x3DBD730", Offset = "0x3DBBF30", VA = "0x183DBD730", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0xABFAA0", Offset = "0xABE2A0", VA = "0x180ABFAA0")]
		[DebuggerHidden]
		public FLFDDODCPCM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x3DBD780", Offset = "0x3DBBF80", VA = "0x183DBD780", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x3DBD180", Offset = "0x3DBB980", VA = "0x183DBD180", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x3DBD5F0", Offset = "0x3DBBDF0", VA = "0x183DBD5F0")]
		private void PPLJHCFFCFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x3DBD5A0", Offset = "0x3DBBDA0", VA = "0x183DBD5A0")]
		private void OFDJPHBKOEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x3DBD6F0", Offset = "0x3DBBEF0", VA = "0x183DBD6F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x3DBD640", Offset = "0x3DBBE40", VA = "0x183DBD640", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<NNANMCHPHNH> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.Errors.ErrorCode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x3DBD640", Offset = "0x3DBBE40", VA = "0x183DBD640", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	private static readonly NNANMCHPHNH LIHLACLHOIF;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	private static readonly Dictionary<Type, int> BEDJEAIMMIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400033A")]
	private readonly HashSet<Type> OCJNLKLMGBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400033B")]
	private readonly ECCNMGINCDM<int> PCBPFGPNDHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400033C")]
	private readonly ECCNMGINCDM<ELPHFCMDOAM> ODKDILJNNNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400033D")]
	private readonly ECCNMGINCDM<BENNMGDCOGG> PBEOKJACOKG;

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x20585E0", Offset = "0x2056DE0", VA = "0x1820585E0")]
	[NFOBBCLLFPP(BGPNPCEMJLD.GameOnly)]
	private static void EKIONAIJAEJ(LIFDIPFHEEA IPBKDPBLBEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x2059560", Offset = "0x2057D60", VA = "0x182059560")]
	[RecRoom.NoEngine.Common.Preserve]
	public GCNLLONBHHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x1AEE010", Offset = "0x1AEC810", VA = "0x181AEE010", Slot = "4")]
	public JMLIIOJMFMB<T> PGCKJFNFNEO<T>() where T : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x2059050", Offset = "0x2057850", VA = "0x182059050", Slot = "5")]
	public EHEGGLOKEKB OFPILGFKOAD(Exception IDAOICDGJBJ)
	{
		return default(EHEGGLOKEKB);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x2058650", Offset = "0x2056E50", VA = "0x182058650", Slot = "6")]
	public NNANMCHPHNH FJHNKGKCOID(Exception? IDAOICDGJBJ)
	{
		return default(NNANMCHPHNH);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x2058B00", Offset = "0x2057300", VA = "0x182058B00", Slot = "7")]
	[IteratorStateMachine(typeof(FLFDDODCPCM))]
	public IEnumerable<NNANMCHPHNH> KMLMFMGAFNE(Exception IDAOICDGJBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x2058F10", Offset = "0x2057710", VA = "0x182058F10", Slot = "8")]
	public string LPPJPMEJHIC(Exception? IDAOICDGJBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x2058B90", Offset = "0x2057390", VA = "0x182058B90")]
	private string KNCIKEMHMID(AggregateException MCOBNKJKADL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x2059100", Offset = "0x2057900", VA = "0x182059100")]
	private void PADEPLEPIIF(Type HABHFBHFDID, int IBOCEJCODCK, ELPHFCMDOAM? NGDLLEBGBAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x20583A0", Offset = "0x2056BA0", VA = "0x1820583A0")]
	private void BPADGMEBGGG(Type HABHFBHFDID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x20580E0", Offset = "0x20568E0", VA = "0x1820580E0")]
	private void ALDPPBBLKBN(Type HABHFBHFDID, BENNMGDCOGG EDDJNCIMDBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x2058870", Offset = "0x2057070", VA = "0x182058870")]
	private static int GPCMEBCHMKO(Type HABHFBHFDID, Dictionary<Type, int> FJBHGACDLAF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x1B8F220", Offset = "0x1B8DA20", VA = "0x181B8F220")]
	private static bool LHOJNFCIGGM<TVal>(ECCNMGINCDM<TVal> ONNFNOJDECI, Type HABHFBHFDID, out TVal MENBIMCLIOI) where TVal : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x2058A10", Offset = "0x2057210", VA = "0x182058A10")]
	[CompilerGenerated]
	internal static int IEOFNDNBIHM(Type IAGALHBKKMF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public struct NNANMCHPHNH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public readonly int EBKHAJCGNCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public readonly int? BMJMOFICAPE;

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x1AAFDF0", Offset = "0x1AAE5F0", VA = "0x181AAFDF0")]
	public NNANMCHPHNH(int BENAEMLNMCF, [Optional] int? NAJLMGIDLBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x26705E0", Offset = "0x266EDE0", VA = "0x1826705E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public interface FPBEPBHJDBK
{
	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JMLIIOJMFMB<T> PGCKJFNFNEO<T>() where T : Exception;

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EHEGGLOKEKB OFPILGFKOAD(Exception IDAOICDGJBJ);

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NNANMCHPHNH FJHNKGKCOID(Exception IDAOICDGJBJ);
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public interface JMLIIOJMFMB<T> where T : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KAGNPIHHNIP();

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JMLIIOJMFMB<T> HGIOBDGEEJB(string FHHEEEGOKNF);

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JMLIIOJMFMB<T> DFBDHBAMEKM(FBCNLGCOMNK<T> GCBGDOMMJMC);

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JMLIIOJMFMB<T> OCGPOEDFHIJ(int IBOCEJCODCK);

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JMLIIOJMFMB<T> DCDFMBIEIMF(int IBOCEJCODCK, PGDPAAHOGLH<T> FLKCBMJNNBL);
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public static class CFCFGIBFCMG
{
	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x2044ED0", Offset = "0x20436D0", VA = "0x182044ED0")]
	[NFOBBCLLFPP(BGPNPCEMJLD.GameOnly)]
	private static void EBMOAACPAFK(LIFDIPFHEEA IPBKDPBLBEN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public interface CCCEJDFLIPE : IEquatable<CCCEJDFLIPE>
{
	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	DateTime PDFKLPJFPIN
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LPHHKNADLHL();

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IPBMKEELDCG(long AFGKPOPONBN, long OFFAGGOPNOB, out OOGLJJBDKMP FHNPDPEPPGC);
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
internal class CKJIFEBIIIK : ABKHNKAOKME
{
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	[CompilerGenerated]
	private sealed class BMHDMDLCKCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public BNGCJDIPPAA autosaveType;

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public BMHDMDLCKCM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	[CompilerGenerated]
	private sealed class BFJKMBKIBNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		public BMHDMDLCKCM CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public BFJKMBKIBNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x26631A0", Offset = "0x26619A0", VA = "0x1826631A0")]
		internal object FHDKCMDECAN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000357")]
	private readonly EBBMGMLKIPO KGGIFPDECCH;

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event Action<CCCEJDFLIPE> IBABNLLPCCL
	{
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x2047640", Offset = "0x2045E40", VA = "0x182047640", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x2047410", Offset = "0x2045C10", VA = "0x182047410", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x8BA230", Offset = "0x8B8A30", VA = "0x1808BA230")]
	[UnityEngine.Scripting.Preserve]
	public CKJIFEBIIIK([JHPEMCNOMHI(null)] EBBMGMLKIPO KGGIFPDECCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x20476E0", Offset = "0x2045EE0", VA = "0x1820476E0", Slot = "6")]
	public bool HKHEKGCJCLF(long AFGKPOPONBN, long OFFAGGOPNOB, OOGLJJBDKMP FHNPDPEPPGC, BNGCJDIPPAA FPAFDBDKHNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x2047FF0", Offset = "0x20467F0", VA = "0x182047FF0")]
	private void NBONKABKKBI(CCCEJDFLIPE AKBCGGCPLIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x20474B0", Offset = "0x2045CB0", VA = "0x1820474B0", Slot = "7")]
	public bool EHALODCENNN(long AFGKPOPONBN, long OFFAGGOPNOB, out CCCEJDFLIPE NLFPMIFADDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x2047F40", Offset = "0x2046740", VA = "0x182047F40", Slot = "8")]
	public bool LDBOMIOHNFA(long AFGKPOPONBN, long OFFAGGOPNOB, BNGCJDIPPAA FPAFDBDKHNA, out CCCEJDFLIPE NLFPMIFADDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x2047B50", Offset = "0x2046350", VA = "0x182047B50")]
	private void KHDDPJDPJBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x2047A30", Offset = "0x2046230", VA = "0x182047A30", Slot = "9")]
	public void IDKEEHFPIFO(long AFGKPOPONBN, long OFFAGGOPNOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public enum MJGHCGBCOEO : byte
{
	[Cpp2IlInjected.Token(Token = "0x400035F")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x4000360")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x4000361")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
internal sealed class DPHILBKMLMO : EMOOCJHAFBI
{
	[Cpp2IlInjected.Token(Token = "0x4000362")]
	private static readonly byte[] EECINICJCLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000363")]
	private readonly byte[] NJAJKFDCEMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000364")]
	private readonly byte[] PBDJIBBGOHA;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public override MJGHCGBCOEO PEKPMBKDOHI
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x204E0F0", Offset = "0x204C8F0", VA = "0x18204E0F0", Slot = "8")]
		get
		{
			return default(MJGHCGBCOEO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x204EB00", Offset = "0x204D300", VA = "0x18204EB00")]
	public DPHILBKMLMO([Optional] string BMFEHEBAGIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x204DCF0", Offset = "0x204C4F0", VA = "0x18204DCF0", Slot = "9")]
	internal override void HNGLHAGGGIE(Stream CNNKBAAAPDL, long AFGKPOPONBN, long OFFAGGOPNOB, OOGLJJBDKMP FHNPDPEPPGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x204E100", Offset = "0x204C900", VA = "0x18204E100", Slot = "10")]
	internal override bool NHDIDCJJNID(Stream NHCPOFIKFIA, long AFGKPOPONBN, long OFFAGGOPNOB, ABHBOECJPIE HNCBAIHELBE, out OOGLJJBDKMP FHNPDPEPPGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x204DBE0", Offset = "0x204C3E0", VA = "0x18204DBE0")]
	private void CDDDCPPBOAK(byte[] IFGPPACGKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x204E950", Offset = "0x204D150", VA = "0x18204E950", Slot = "11")]
	protected override FileInfo PKPMKAMJMBE(long AFGKPOPONBN, long OFFAGGOPNOB, BNGCJDIPPAA FPAFDBDKHNA, FONFDGOFDAL IDHFKPFILIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x204DFD0", Offset = "0x204C7D0", VA = "0x18204DFD0", Slot = "12")]
	protected override DirectoryInfo JKPBKHCOOLP(BNGCJDIPPAA FPAFDBDKHNA, FONFDGOFDAL IDHFKPFILIL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
internal class DOBEEBCMNIH : EMOOCJHAFBI
{
	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public override MJGHCGBCOEO PEKPMBKDOHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x91D0B0", Offset = "0x91B8B0", VA = "0x18091D0B0", Slot = "8")]
		get
		{
			return default(MJGHCGBCOEO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x204C670", Offset = "0x204AE70", VA = "0x18204C670")]
	public DOBEEBCMNIH([Optional] string BMFEHEBAGIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x204BF00", Offset = "0x204A700", VA = "0x18204BF00")]
	private void LKPEFBBOBMK(BNGCJDIPPAA FPAFDBDKHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x204BB60", Offset = "0x204A360", VA = "0x18204BB60", Slot = "9")]
	internal override void HNGLHAGGGIE(Stream CNNKBAAAPDL, long AFGKPOPONBN, long OFFAGGOPNOB, OOGLJJBDKMP FHNPDPEPPGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x204BF90", Offset = "0x204A790", VA = "0x18204BF90", Slot = "10")]
	internal override bool NHDIDCJJNID(Stream NHCPOFIKFIA, long AFGKPOPONBN, long OFFAGGOPNOB, ABHBOECJPIE HNCBAIHELBE, out OOGLJJBDKMP FHNPDPEPPGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x204C580", Offset = "0x204AD80", VA = "0x18204C580", Slot = "11")]
	protected override FileInfo PKPMKAMJMBE(long AFGKPOPONBN, long OFFAGGOPNOB, BNGCJDIPPAA FPAFDBDKHNA, FONFDGOFDAL IDHFKPFILIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x204BDF0", Offset = "0x204A5F0", VA = "0x18204BDF0", Slot = "12")]
	protected override DirectoryInfo JKPBKHCOOLP(BNGCJDIPPAA FPAFDBDKHNA, FONFDGOFDAL IDHFKPFILIL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
internal abstract class EMOOCJHAFBI : EBBMGMLKIPO
{
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	protected enum FONFDGOFDAL : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	[CompilerGenerated]
	private sealed class MKAJDHNHAFK : IEnumerable<CCCEJDFLIPE>, IEnumerable, IEnumerator<CCCEJDFLIPE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		private CCCEJDFLIPE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		private BNGCJDIPPAA autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		public BNGCJDIPPAA <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		public EMOOCJHAFBI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		private DirectoryInfo <autosaveDirectory>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		private FileInfo[] <files>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		private FileInfo[] <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		private int <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		private FileInfo <file>5__5;

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		private CCCEJDFLIPE System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600044A")]
			[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600044C")]
			[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0xABFAA0", Offset = "0xABE2A0", VA = "0x180ABFAA0")]
		[DebuggerHidden]
		public MKAJDHNHAFK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x3DC2F40", Offset = "0x3DC1740", VA = "0x183DC2F40", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x3DC31A0", Offset = "0x3DC19A0", VA = "0x183DC31A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x3DC30F0", Offset = "0x3DC18F0", VA = "0x183DC30F0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<CCCEJDFLIPE> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x3DC30F0", Offset = "0x3DC18F0", VA = "0x183DC30F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	[CompilerGenerated]
	private sealed class CIMCANINJAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		public BNGCJDIPPAA autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public CIMCANINJAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x3DBA200", Offset = "0x3DB8A00", VA = "0x183DBA200")]
		internal object HFMPMHGCOJJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	[CompilerGenerated]
	private sealed class GCEBCNJDGOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public EMOOCJHAFBI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public GCEBCNJDGOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x3DBD860", Offset = "0x3DBC060", VA = "0x183DBD860")]
		internal void AAFBKBJBFOF(KPKCPBLDOGG.AFOKDFHLMAG ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000365")]
	protected readonly string ALJGAFCDKMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000366")]
	private readonly object BFFANNNGHEN;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public abstract MJGHCGBCOEO PEKPMBKDOHI
	{
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x2052120", Offset = "0x2050920", VA = "0x182052120")]
	protected EMOOCJHAFBI([CanBeNull] string BMFEHEBAGIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x2051C00", Offset = "0x2050400", VA = "0x182051C00", Slot = "5")]
	public bool OBNOGONJKKA(long AFGKPOPONBN, long OFFAGGOPNOB, BNGCJDIPPAA FPAFDBDKHNA, out CCCEJDFLIPE AKBCGGCPLIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x2051B80", Offset = "0x2050380", VA = "0x182051B80", Slot = "6")]
	[IteratorStateMachine(typeof(MKAJDHNHAFK))]
	public IEnumerable<CCCEJDFLIPE> MDPDBDDIHBF(BNGCJDIPPAA FPAFDBDKHNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void HNGLHAGGGIE(Stream CNNKBAAAPDL, long AFGKPOPONBN, long OFFAGGOPNOB, OOGLJJBDKMP FHNPDPEPPGC);

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool NHDIDCJJNID(Stream NHCPOFIKFIA, long AFGKPOPONBN, long OFFAGGOPNOB, ABHBOECJPIE HNCBAIHELBE, out OOGLJJBDKMP FHNPDPEPPGC);

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x2051DB0", Offset = "0x20505B0", VA = "0x182051DB0", Slot = "7")]
	public CCCEJDFLIPE ODMKFEIMIJH(long AFGKPOPONBN, long OFFAGGOPNOB, OOGLJJBDKMP FHNPDPEPPGC, BNGCJDIPPAA FPAFDBDKHNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo PKPMKAMJMBE(long AFGKPOPONBN, long OFFAGGOPNOB, BNGCJDIPPAA FPAFDBDKHNA, FONFDGOFDAL IDHFKPFILIL);

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo JKPBKHCOOLP(BNGCJDIPPAA FPAFDBDKHNA, FONFDGOFDAL IDHFKPFILIL);

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x20520B0", Offset = "0x20508B0", VA = "0x1820520B0")]
	protected void OFJNLFEMMPD(KPKCPBLDOGG.AFOKDFHLMAG CPCPBMLIINB, string DPFPLPFKKOM, FileInfo AJHNILFIFHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x20518C0", Offset = "0x20500C0", VA = "0x1820518C0")]
	internal bool FLGBIJCKJLD(FileInfo HEHFGOPPAOI, long AFGKPOPONBN, long OFFAGGOPNOB, out OOGLJJBDKMP FHNPDPEPPGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
	private void HHMDLBHMMHI(Exception EKDLDNFBEDD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
internal interface EBBMGMLKIPO
{
	[Cpp2IlInjected.Token(Token = "0x17000094")]
	MJGHCGBCOEO PEKPMBKDOHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OBNOGONJKKA(long AFGKPOPONBN, long OFFAGGOPNOB, BNGCJDIPPAA FPAFDBDKHNA, out CCCEJDFLIPE AKBCGGCPLIB);

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<CCCEJDFLIPE> MDPDBDDIHBF(BNGCJDIPPAA FPAFDBDKHNA);

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CCCEJDFLIPE ODMKFEIMIJH(long AFGKPOPONBN, long OFFAGGOPNOB, OOGLJJBDKMP FHNPDPEPPGC, BNGCJDIPPAA FPAFDBDKHNA);
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
internal class FPOCNKFIANG : EBBMGMLKIPO
{
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	[CompilerGenerated]
	private sealed class IEGOJIJBHGG : IEnumerable<CCCEJDFLIPE>, IEnumerable, IEnumerator<CCCEJDFLIPE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		private CCCEJDFLIPE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		private BNGCJDIPPAA autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public BNGCJDIPPAA <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public FPOCNKFIANG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		private MJGHCGBCOEO[] <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		private int <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		private MJGHCGBCOEO <autosaveVersion>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		private EBBMGMLKIPO <impl>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		private IEnumerable<CCCEJDFLIPE> <records>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		private IEnumerator<CCCEJDFLIPE> <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		private CCCEJDFLIPE <autosaveRecord>5__7;

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		private CCCEJDFLIPE System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000466")]
			[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000468")]
			[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0xABFAA0", Offset = "0xABE2A0", VA = "0x180ABFAA0")]
		[DebuggerHidden]
		public IEGOJIJBHGG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x3DBF2D0", Offset = "0x3DBDAD0", VA = "0x183DBF2D0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x3DBEE40", Offset = "0x3DBD640", VA = "0x183DBEE40", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x3DBF190", Offset = "0x3DBD990", VA = "0x183DBF190")]
		private void PPLJHCFFCFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x3DBF290", Offset = "0x3DBDA90", VA = "0x183DBF290", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x3DBF1E0", Offset = "0x3DBD9E0", VA = "0x183DBF1E0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<CCCEJDFLIPE> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x3DBF1E0", Offset = "0x3DBD9E0", VA = "0x183DBF1E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000379")]
	private readonly MJGHCGBCOEO[] JFKABLLFAML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400037A")]
	private readonly Dictionary<MJGHCGBCOEO, EBBMGMLKIPO> EIFPIHKPOAJ;

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public MJGHCGBCOEO PEKPMBKDOHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x2057830", Offset = "0x2056030", VA = "0x182057830", Slot = "4")]
		get
		{
			return default(MJGHCGBCOEO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x2057D70", Offset = "0x2056570", VA = "0x182057D70")]
	[UnityEngine.Scripting.Preserve]
	public FPOCNKFIANG(params EBBMGMLKIPO[] FEDJCHPPFLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x2057B20", Offset = "0x2056320", VA = "0x182057B20", Slot = "5")]
	public bool OBNOGONJKKA(long AFGKPOPONBN, long OFFAGGOPNOB, BNGCJDIPPAA FPAFDBDKHNA, out CCCEJDFLIPE AKBCGGCPLIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x20578F0", Offset = "0x20560F0", VA = "0x1820578F0")]
	private void MHDMENFLNEN(int CFPINJOCIHE, long AFGKPOPONBN, long OFFAGGOPNOB, BNGCJDIPPAA FPAFDBDKHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x2057870", Offset = "0x2056070", VA = "0x182057870", Slot = "6")]
	[IteratorStateMachine(typeof(IEGOJIJBHGG))]
	public IEnumerable<CCCEJDFLIPE> MDPDBDDIHBF(BNGCJDIPPAA FPAFDBDKHNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x2057C80", Offset = "0x2056480", VA = "0x182057C80", Slot = "7")]
	public CCCEJDFLIPE ODMKFEIMIJH(long AFGKPOPONBN, long OFFAGGOPNOB, OOGLJJBDKMP FHNPDPEPPGC, BNGCJDIPPAA FPAFDBDKHNA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
internal static class GDAHIJGFHPD
{
	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x2059B80", Offset = "0x2058380", VA = "0x182059B80")]
	internal static byte[] IJNJELGEOFG(byte[] IFGPPACGKDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x2059C20", Offset = "0x2058420", VA = "0x182059C20")]
	public static void OJDKHJPLLJC(Stream PCGLKMCPDAP, byte[] EGCNIBAFKII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x20599A0", Offset = "0x20581A0", VA = "0x1820599A0")]
	public static bool EFAOKIGHKFN(Stream PCGLKMCPDAP, long PKNJGALGDIH, ABHBOECJPIE OJIPPHADCPN, out byte[] MJBHGOEMPGB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public delegate void ABHBOECJPIE(KPKCPBLDOGG.AFOKDFHLMAG PMBBAODFMMM, string AKADEFDGONP);
[Cpp2IlInjected.Token(Token = "0x20000ED")]
internal sealed class PMBGHHNINKL : CCCEJDFLIPE, IEquatable<CCCEJDFLIPE>, IEquatable<PMBGHHNINKL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400038C")]
	private readonly EMOOCJHAFBI HOMAEEJKDOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400038D")]
	public readonly FileInfo DKDCDLLMCPA;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public MJGHCGBCOEO PEKPMBKDOHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x267A550", Offset = "0x2678D50", VA = "0x18267A550", Slot = "9")]
		get
		{
			return default(MJGHCGBCOEO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public DateTime PDFKLPJFPIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x267A140", Offset = "0x2678940", VA = "0x18267A140", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x267A6E0", Offset = "0x2678EE0", VA = "0x18267A6E0")]
	public PMBGHHNINKL(EMOOCJHAFBI DPAKMCNDCAC, FileInfo HEHFGOPPAOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x267A630", Offset = "0x2678E30", VA = "0x18267A630", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x267A580", Offset = "0x2678D80", VA = "0x18267A580", Slot = "5")]
	public void LPHHKNADLHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x267A510", Offset = "0x2678D10", VA = "0x18267A510", Slot = "6")]
	public bool IPBMKEELDCG(long AFGKPOPONBN, long OFFAGGOPNOB, out OOGLJJBDKMP FHNPDPEPPGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x267A390", Offset = "0x2678B90", VA = "0x18267A390", Slot = "7")]
	public bool Equals(CCCEJDFLIPE OALEAAIPGBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x267A2E0", Offset = "0x2678AE0", VA = "0x18267A2E0", Slot = "8")]
	public bool Equals(PMBGHHNINKL OALEAAIPGBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x267A1E0", Offset = "0x26789E0", VA = "0x18267A1E0", Slot = "0")]
	public override bool Equals(object CEPDEAHBHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x267A470", Offset = "0x2678C70", VA = "0x18267A470", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000EE")]
internal struct NNHNEFOOBAA
{
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	[CompilerGenerated]
	private sealed class CLJHIHKIONN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		public DOLCNHODOEC operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		public ALNDGPDOBOK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		public CINMLNOINGA<string>.BIMPMJLMAHG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		private IBHEBOMOMMF <roomManager>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		private CINMLNOINGA<string>.BIMPMJLMAHG <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public CLJHIHKIONN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x36E3570", Offset = "0x36E1D70", VA = "0x1836E3570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x26706C0", Offset = "0x266EEC0", VA = "0x1826706C0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CLJHIHKIONN))]
	public static Task JELDACCCIFL(DOLCNHODOEC HNPDANNACGJ, ALNDGPDOBOK NFBDMLCENEN, CINMLNOINGA<string>.BIMPMJLMAHG KOKOCCCLBFO, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000F0")]
internal struct LGEDDOKIKLM
{
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[CompilerGenerated]
	private sealed class BAEIGDAKHPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		public JKCDDAOJCAB operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		public ALNDGPDOBOK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		public CJPEEBFCFIN timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		private IBHEBOMOMMF <roomManager>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		private CABGPNHLHHJ <callbacks>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		private MIKHCJJNMEJ <DEPRECATED_version>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		private IDisposable <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		private IDisposable <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		private List<(PersistenceView, GPPNCPPLGEE)>.Enumerator <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		private PersistenceView <view>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		private GPPNCPPLGEE <viewData>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public BAEIGDAKHPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x36E0ED0", Offset = "0x36DF6D0", VA = "0x1836E0ED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x266C800", Offset = "0x266B000", VA = "0x18266C800")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BAEIGDAKHPK))]
	public static Task JELDACCCIFL(JKCDDAOJCAB IKBOIGIEDJD, ALNDGPDOBOK NFBDMLCENEN, CJPEEBFCFIN ILKAAHOKFLK, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000F2")]
internal struct GLJLJIADKGP
{
	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x7EE870", Offset = "0x7ED070", VA = "0x1807EE870")]
	public static GLJLJIADKGP OIAKNFDBOOD()
	{
		return default(GLJLJIADKGP);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
internal struct MGENBJMGLGB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	private IBHEBOMOMMF KPGFDADNAJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	private ALNDGPDOBOK NFBDMLCENEN;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	private CABGPNHLHHJ BKEEIANIHAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x266ED80", Offset = "0x266D580", VA = "0x18266ED80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x266EFB0", Offset = "0x266D7B0", VA = "0x18266EFB0")]
	public static Task JELDACCCIFL(IBHEBOMOMMF KPGFDADNAJA, ALNDGPDOBOK NFBDMLCENEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x266EDD0", Offset = "0x266D5D0", VA = "0x18266EDD0")]
	private void JELDACCCIFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
internal class FDDJBPFLAAL : JKCDDAOJCAB
{
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[CompilerGenerated]
	private sealed class CKHFNMMBIDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		public DOLCNHODOEC operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		public CINMLNOINGA<string>.BIMPMJLMAHG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		public FDDJBPFLAAL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		private long <subRoomId>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		private string <unityAssetId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		private KGLPJJELOMN <serializeLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		private FNOFEKPGFMA <roomSaveOptions>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		private CACOFKKHDCM <serializeType>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		private OOGLJJBDKMP <data>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		private OOGLJJBDKMP <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		private Exception <ex>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		private TaskAwaiter<OOGLJJBDKMP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public CKHFNMMBIDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x3DBA4A0", Offset = "0x3DB8CA0", VA = "0x183DBA4A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	private readonly string CDDPFJOANEJ;

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x2056B10", Offset = "0x2055310", VA = "0x182056B10")]
	public FDDJBPFLAAL(Guid GMIOJDLOGJD, IBHEBOMOMMF KPGFDADNAJA, KODFOCGBOAL JACMAPKOKAK, string CDDPFJOANEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x2056970", Offset = "0x2055170", VA = "0x182056970", Slot = "7")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CKHFNMMBIDH))]
	protected override Task LEKKIJPMDAF(DOLCNHODOEC HNPDANNACGJ, CINMLNOINGA<string>.BIMPMJLMAHG KOKOCCCLBFO, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
internal class KNBIFNDEGBD
{
	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	[CompilerGenerated]
	private sealed class MIANJGKCBAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		public GNLKPICAGOB operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		public ALNDGPDOBOK deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		public CINMLNOINGA<string>.BIMPMJLMAHG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		public KNBIFNDEGBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public MIANJGKCBAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x36F1370", Offset = "0x36EFB70", VA = "0x1836F1370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[CompilerGenerated]
	private sealed class NGHBOKDNMLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		public KNBIFNDEGBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		public ALNDGPDOBOK data;

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public NGHBOKDNMLE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	[CompilerGenerated]
	private sealed class KKENAAKMHLM
	{
		[Cpp2IlInjected.Token(Token = "0x20000FA")]
		private sealed class <<RunAuthorityHandler>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003C8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003C9")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003CA")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003CB")]
			public KKENAAKMHLM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003CC")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60004A1")]
			[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
			public <<RunAuthorityHandler>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A2")]
			[Cpp2IlInjected.Address(RVA = "0x5370130", Offset = "0x536E930", VA = "0x185370130", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A3")]
			[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		public CINMLNOINGA<string>.BIMPMJLMAHG handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		public NGHBOKDNMLE CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public KKENAAKMHLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x36ECB10", Offset = "0x36EB310", VA = "0x1836ECB10")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task GHGGDAALJMM(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private sealed class HLOEGEJPLBG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		public ALNDGPDOBOK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		public CINMLNOINGA<string>.BIMPMJLMAHG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		public KNBIFNDEGBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		private NGHBOKDNMLE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		private KKENAAKMHLM <>8__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public HLOEGEJPLBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x36EA440", Offset = "0x36E8C40", VA = "0x1836EA440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private sealed class DJCKFDPEIGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public ALNDGPDOBOK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public CINMLNOINGA<string>.BIMPMJLMAHG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public KNBIFNDEGBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		private CINMLNOINGA<string>.BIMPMJLMAHG <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		private Dictionary<Guid, List<ODJCNBPFKBG>>.Enumerator <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		private KeyValuePair<Guid, List<ODJCNBPFKBG>> <guidMethodPair>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public DJCKFDPEIGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x36E4690", Offset = "0x36E2E90", VA = "0x1836E4690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	[CompilerGenerated]
	private sealed class LEPCFHLDFOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public ALNDGPDOBOK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public CINMLNOINGA<string>.BIMPMJLMAHG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		public KNBIFNDEGBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		private FMDMEJLHLEH <networking>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		private CINMLNOINGA<string>.BIMPMJLMAHG <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		private Dictionary<Guid, List<ODJCNBPFKBG>>.Enumerator <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		private KeyValuePair<Guid, List<ODJCNBPFKBG>> <guidMethodPair>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public LEPCFHLDFOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x36EE790", Offset = "0x36ECF90", VA = "0x1836EE790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	[CompilerGenerated]
	private sealed class HBNLANHDANJ
	{
		[Cpp2IlInjected.Token(Token = "0x20000FF")]
		private sealed class <<InvokeMethodsInParallel>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003F0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003F1")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003F2")]
			public ODJCNBPFKBG handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003F3")]
			public HBNLANHDANJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003F4")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60004B1")]
			[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
			public <<InvokeMethodsInParallel>b__2>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B2")]
			[Cpp2IlInjected.Address(RVA = "0x536D8D0", Offset = "0x536C0D0", VA = "0x18536D8D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B3")]
			[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public DAHBLIBEFPK runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		public List<ODJCNBPFKBG> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public ALNDGPDOBOK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public HBNLANHDANJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x36E9250", Offset = "0x36E7A50", VA = "0x1836E9250")]
		internal object AHFMODHOGKM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x36E9430", Offset = "0x36E7C30", VA = "0x1836E9430")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task IAONELCPBHO(ODJCNBPFKBG handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x36E9340", Offset = "0x36E7B40", VA = "0x1836E9340")]
		internal object CIOPNFBNGHD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000100")]
	[CompilerGenerated]
	private sealed class OMCPHOHINCL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public List<ODJCNBPFKBG> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public DAHBLIBEFPK runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public ALNDGPDOBOK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public KNBIFNDEGBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		private HBNLANHDANJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		private IEnumerable<Task> <handlerTasks>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		private Exception <ex>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public OMCPHOHINCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x36F2B90", Offset = "0x36F1390", VA = "0x1836F2B90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000101")]
	[CompilerGenerated]
	private sealed class NDDBLPIKDEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public ALNDGPDOBOK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public CINMLNOINGA<string>.BIMPMJLMAHG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public KNBIFNDEGBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		private Guid <handlerIdToRun>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public NDDBLPIKDEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x36F1AF0", Offset = "0x36F02F0", VA = "0x1836F1AF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000102")]
	[CompilerGenerated]
	private sealed class EICGMEAPCCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public EICGMEAPCCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x36E5270", Offset = "0x36E3A70", VA = "0x1836E5270")]
		internal object LPINKPJPFAE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000103")]
	[CompilerGenerated]
	private sealed class GNIMNKLDIHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400040C")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		public ALNDGPDOBOK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public CINMLNOINGA<string>.BIMPMJLMAHG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public KNBIFNDEGBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		private EICGMEAPCCN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		private FMDMEJLHLEH <networking>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		private List<ODJCNBPFKBG> <handlerMethods>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public GNIMNKLDIHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x36E8590", Offset = "0x36E6D90", VA = "0x1836E8590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000104")]
	[CompilerGenerated]
	private sealed class JADDJAIAIJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public JADDJAIAIJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x36EB390", Offset = "0x36E9B90", VA = "0x1836EB390")]
		internal object HDGHPCJODCL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[CompilerGenerated]
	private sealed class CLADKCLJPNC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public CINMLNOINGA<string>.BIMPMJLMAHG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public KNBIFNDEGBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		private JADDJAIAIJO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		private GHGLDBKCJPG <completedMessage>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		private GHGLDBKCJPG <syncedCompletionMessage>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		private ByteString <authorityCompletedMark>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		private GHGLDBKCJPG <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		private TaskAwaiter<GHGLDBKCJPG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public CLADKCLJPNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x36E2F30", Offset = "0x36E1730", VA = "0x1836E2F30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000106")]
	[CompilerGenerated]
	private sealed class PBIMDHFHJEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public PBIMDHFHJEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x36F3510", Offset = "0x36F1D10", VA = "0x1836F3510")]
		internal object AEPMNCDINKH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	private readonly DOLCNHODOEC HNPDANNACGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	private DFKCEIMHBLM MALPFBBDGFO;

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	private JKCDDAOJCAB PNIGLPMNNLE
	{
		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x8BA210", Offset = "0x8B8A10", VA = "0x1808BA210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x8BA230", Offset = "0x8B8A30", VA = "0x1808BA230")]
	public KNBIFNDEGBD(DOLCNHODOEC HNPDANNACGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x266B7F0", Offset = "0x2669FF0", VA = "0x18266B7F0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MIANJGKCBAJ))]
	public Task JELDACCCIFL(GNLKPICAGOB IAHEILFDKDM, ALNDGPDOBOK BCLHHIMIKNN, CINMLNOINGA<string>.BIMPMJLMAHG FMGNKDAMMIM, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x266AFF0", Offset = "0x26697F0", VA = "0x18266AFF0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HLOEGEJPLBG))]
	private Task CDKLAJDIAJO(ALNDGPDOBOK NFBDMLCENEN, CINMLNOINGA<string>.BIMPMJLMAHG FMGNKDAMMIM, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x266BC10", Offset = "0x266A410", VA = "0x18266BC10")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DJCKFDPEIGE))]
	private Task LMLCAFGBLJJ(ALNDGPDOBOK NFBDMLCENEN, CINMLNOINGA<string>.BIMPMJLMAHG FMGNKDAMMIM, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x266B190", Offset = "0x2669990", VA = "0x18266B190")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LEPCFHLDFOA))]
	private Task CIGKABOLIDA(ALNDGPDOBOK NFBDMLCENEN, CINMLNOINGA<string>.BIMPMJLMAHG FMGNKDAMMIM, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x266AE20", Offset = "0x2669620", VA = "0x18266AE20")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OMCPHOHINCL))]
	private Task ALBNBHIFBDH(Guid NOJENAHIEBP, List<ODJCNBPFKBG> IFEBEMFPBNI, DAHBLIBEFPK LHLHDBHIHFN, ALNDGPDOBOK NFBDMLCENEN, CancellationToken AMCDGOPKAOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x266BDB0", Offset = "0x266A5B0", VA = "0x18266BDB0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NDDBLPIKDEM))]
	private Task OFINMFGHEGC(ALNDGPDOBOK NFBDMLCENEN, CINMLNOINGA<string>.BIMPMJLMAHG FMGNKDAMMIM, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x266BF50", Offset = "0x266A750", VA = "0x18266BF50")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GNIMNKLDIHE))]
	private Task POBJDKHEAAF(Guid CIKNJAIKHAL, ALNDGPDOBOK NFBDMLCENEN, CINMLNOINGA<string>.BIMPMJLMAHG FMGNKDAMMIM, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x266BA70", Offset = "0x266A270", VA = "0x18266BA70")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CLADKCLJPNC))]
	private Task KAKIKIEFONM(Guid CIKNJAIKHAL, CINMLNOINGA<string>.BIMPMJLMAHG KOKOCCCLBFO, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x266B330", Offset = "0x2669B30", VA = "0x18266B330")]
	private void CMMOOKOICPP(Guid CIKNJAIKHAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x266B9B0", Offset = "0x266A1B0", VA = "0x18266B9B0")]
	private void JPCNOAPAEEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x266B460", Offset = "0x2669C60", VA = "0x18266B460")]
	public Guid DINDPLPKKDA(GNLKPICAGOB FPDOEPFGAKP)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x266B620", Offset = "0x2669E20", VA = "0x18266B620")]
	[CompilerGenerated]
	private object IILMPGPNANB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
internal struct HDIFABCOJHG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000428")]
	private readonly DOLCNHODOEC HNPDANNACGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000429")]
	private readonly Guid COFCMMGDNFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400042A")]
	private bool NFFGKDNLOEK;

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x205B9A0", Offset = "0x205A1A0", VA = "0x18205B9A0")]
	public static HDIFABCOJHG PLGEOALJFON(DOLCNHODOEC HNPDANNACGJ)
	{
		return default(HDIFABCOJHG);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0xC6CE00", Offset = "0xC6B600", VA = "0x180C6CE00")]
	public void JEOKJFLAKGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x205B8E0", Offset = "0x205A0E0", VA = "0x18205B8E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x205B9D0", Offset = "0x205A1D0", VA = "0x18205B9D0")]
	private HDIFABCOJHG(DOLCNHODOEC HNPDANNACGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x205B680", Offset = "0x2059E80", VA = "0x18205B680")]
	private void AAMGNEIPNGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x205B8F0", Offset = "0x205A0F0", VA = "0x18205B8F0")]
	private Func<Guid, bool> GJNLIOGOPAA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
internal struct CFMBJPDHMLH
{
	[Cpp2IlInjected.Token(Token = "0x200010A")]
	[CompilerGenerated]
	private sealed class FDEFEBAAMBI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public AsyncTaskMethodBuilder<LPNELAFLFMK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public CFMBJPDHMLH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		private CINMLNOINGA<string>.BIMPMJLMAHG <subTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		private LPNELAFLFMK <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		private TaskAwaiter<LPNELAFLFMK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public FDEFEBAAMBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x26665E0", Offset = "0x2664DE0", VA = "0x1826665E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[CompilerGenerated]
	private sealed class KIPFFPLNPJN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		public AsyncTaskMethodBuilder<LPNELAFLFMK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		public CINMLNOINGA<string>.BIMPMJLMAHG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		public CFMBJPDHMLH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		private LPNELAFLFMK <roomDetails>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		private LPNELAFLFMK <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		private TaskAwaiter<LPNELAFLFMK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public KIPFFPLNPJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x26698D0", Offset = "0x26680D0", VA = "0x1826698D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010C")]
	[CompilerGenerated]
	private sealed class IBCANCDEDHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public IBCANCDEDHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0xA345C0", Offset = "0xA32DC0", VA = "0x180A345C0")]
		internal bool FMEBDJAEBGJ(CKNKGBNGABP sr)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010D")]
	[CompilerGenerated]
	private sealed class OEKAGKELFBM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public AsyncTaskMethodBuilder<LPNELAFLFMK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public CABGPNHLHHJ callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		public CENNEHOCJAK superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		public CINMLNOINGA<string>.BIMPMJLMAHG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		private IBCANCDEDHL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		private JEELLOGMCHC <roomDetails>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		private CKNKGBNGABP <subroom>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		private string <unityAssetId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		private CENNEHOCJAK <superRoomData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		private CENNEHOCJAK <subRoomData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		private CINMLNOINGA<string>.BIMPMJLMAHG <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		private JEELLOGMCHC <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		private CINMLNOINGA<string>.BIMPMJLMAHG <>s__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		private FGPPKDDGLJL <session>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		private FGPPKDDGLJL <>s__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		private CINMLNOINGA<string>.BIMPMJLMAHG <>s__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		private JDPJAFEOEAF <saveData>5__13;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		private JDPJAFEOEAF <>s__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		private TaskAwaiter<JEELLOGMCHC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		private TaskAwaiter<FGPPKDDGLJL> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		private TaskAwaiter<JDPJAFEOEAF> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public OEKAGKELFBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x26712E0", Offset = "0x266FAE0", VA = "0x1826712E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400042B")]
	private CABGPNHLHHJ BOBHLPNKBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400042C")]
	private JOBAJLNCBIL JMDLAHHNDMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400042D")]
	private CINMLNOINGA<string>.BIMPMJLMAHG FMGNKDAMMIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400042E")]
	private long AFGKPOPONBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400042F")]
	private long OFFAGGOPNOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000430")]
	private long GJGLINJHGOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000431")]
	private string ICCNANGPCBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000432")]
	private CENNEHOCJAK EOOBNJBECHK;

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x20455A0", Offset = "0x2043DA0", VA = "0x1820455A0")]
	public static Task<LPNELAFLFMK> NAABNLOLMIJ(IBHEBOMOMMF KPGFDADNAJA, ACEIDINIJDO AJNIDCPPJGC, CINMLNOINGA<string>.BIMPMJLMAHG FMGNKDAMMIM, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x2045410", Offset = "0x2043C10", VA = "0x182045410")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FDEFEBAAMBI))]
	private Task<LPNELAFLFMK> JELDACCCIFL(CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x2045990", Offset = "0x2044190", VA = "0x182045990")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KIPFFPLNPJN))]
	private Task<LPNELAFLFMK> PNJBAKNAGCM(CINMLNOINGA<string>.BIMPMJLMAHG KOKOCCCLBFO, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x2045760", Offset = "0x2043F60", VA = "0x182045760")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OEKAGKELFBM))]
	private static Task<LPNELAFLFMK> PNJBAKNAGCM(CABGPNHLHHJ BOBHLPNKBHC, long AFGKPOPONBN, long OFFAGGOPNOB, long GJGLINJHGOI, string ICCNANGPCBP, CENNEHOCJAK EOOBNJBECHK, CancellationToken NNLBJPBEHPF, CINMLNOINGA<string>.BIMPMJLMAHG KOKOCCCLBFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x2045380", Offset = "0x2043B80", VA = "0x182045380")]
	private void AHEHEIFKEHK(JEELLOGMCHC GMEHCBDKOIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
internal struct COLNKHDFAPJ
{
	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[CompilerGenerated]
	private sealed class PGOGOGEHIEL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		public IBHEBOMOMMF roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		public ALNDGPDOBOK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		public DOLCNHODOEC operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public bool isReloadingSceneForObjectModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public CINMLNOINGA<string>.BIMPMJLMAHG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public PGOGOGEHIEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x26793F0", Offset = "0x2677BF0", VA = "0x1826793F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000110")]
	[CompilerGenerated]
	private sealed class DBINFFODBIE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public CINMLNOINGA<string>.BIMPMJLMAHG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public COLNKHDFAPJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public DBINFFODBIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x2664E10", Offset = "0x2663610", VA = "0x182664E10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400045E")]
	private static readonly JNGNMMOLKFF FHEDCPDJOCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400045F")]
	private IBHEBOMOMMF KPGFDADNAJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000460")]
	private ALNDGPDOBOK NFBDMLCENEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000461")]
	private ByteString BHKNJJPGGCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000462")]
	private DOLCNHODOEC HNPDANNACGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000463")]
	private bool EANLDEFBIPK;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	private CABGPNHLHHJ BKEEIANIHAB
	{
		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x2048B40", Offset = "0x2047340", VA = "0x182048B40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private bool CIJODPOALCI
	{
		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x2048B90", Offset = "0x2047390", VA = "0x182048B90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	private bool HKMBPJFLFKG
	{
		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x2048C10", Offset = "0x2047410", VA = "0x182048C10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x2048D00", Offset = "0x2047500", VA = "0x182048D00")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PGOGOGEHIEL))]
	public static Task JELDACCCIFL(IBHEBOMOMMF KPGFDADNAJA, ALNDGPDOBOK NFBDMLCENEN, DOLCNHODOEC HNPDANNACGJ, bool EANLDEFBIPK, CINMLNOINGA<string>.BIMPMJLMAHG KOKOCCCLBFO, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x2048EE0", Offset = "0x20476E0", VA = "0x182048EE0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DBINFFODBIE))]
	private Task JELDACCCIFL(CINMLNOINGA<string>.BIMPMJLMAHG KOKOCCCLBFO, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
internal static class IJOKPGHHPKD
{
	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x205F810", Offset = "0x205E010", VA = "0x18205F810")]
	public static void BBDNIDMKONM(this MCMNGPGPMDI MPJIJADFFOK, EIEEEHDKLAP EKGJMJOMMAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x205F960", Offset = "0x205E160", VA = "0x18205F960")]
	public static void DANPMOELJMC(this EIEEEHDKLAP BDMCJDMKLJB, [Optional] string AKADEFDGONP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
internal struct HFGFBEDFPMI
{
	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CompilerGenerated]
	private sealed class NGLCBNMBKHI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public HFGFBEDFPMI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		private CINMLNOINGA<string>.BIMPMJLMAHG <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		private float <nextResendTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public NGLCBNMBKHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x3DC3E70", Offset = "0x3DC2670", VA = "0x183DC3E70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000474")]
	private CABGPNHLHHJ BOBHLPNKBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000475")]
	private ALNDGPDOBOK NFBDMLCENEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000476")]
	private CINMLNOINGA<string>.BIMPMJLMAHG FMGNKDAMMIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000477")]
	private float HOHBICKHKFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000478")]
	private float IHPDPABCKKA;

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x205BF30", Offset = "0x205A730", VA = "0x18205BF30")]
	public static Task MIDDMGOFFBC(IBHEBOMOMMF KPGFDADNAJA, ALNDGPDOBOK NFBDMLCENEN, CINMLNOINGA<string>.BIMPMJLMAHG KOKOCCCLBFO, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x205BBB0", Offset = "0x205A3B0", VA = "0x18205BBB0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NGLCBNMBKHI))]
	public Task JELDACCCIFL(CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x205C0C0", Offset = "0x205A8C0", VA = "0x18205C0C0")]
	private static void PEBAEJMOGGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x205BD00", Offset = "0x205A500", VA = "0x18205BD00")]
	private void KGPOIHBFBJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x205BE80", Offset = "0x205A680", VA = "0x18205BE80")]
	private static float LFBPHDBNCMD(CABGPNHLHHJ BOBHLPNKBHC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x205BB90", Offset = "0x205A390", VA = "0x18205BB90")]
	private static float BCBHACOPJAJ()
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
internal class DOLCNHODOEC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000116")]
	[CompilerGenerated]
	private sealed class PIPECJLMAPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public AsyncTaskMethodBuilder<GHGLDBKCJPG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public CINMLNOINGA<string>.BIMPMJLMAHG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public GHGLDBKCJPG roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public DOLCNHODOEC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		private CINMLNOINGA<string>.BIMPMJLMAHG <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		private GHGLDBKCJPG <message>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		private GBODBCPKFEK.DLDANNIGHFL<GHGLDBKCJPG> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		private TaskAwaiter<GBODBCPKFEK.DLDANNIGHFL<GHGLDBKCJPG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public PIPECJLMAPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x3DC8560", Offset = "0x3DC6D60", VA = "0x183DC8560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000117")]
	[CompilerGenerated]
	private struct FICMOPEEAMM<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x2000119")]
	[CompilerGenerated]
	private sealed class JKBJJJFJOEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public GHGLDBKCJPG roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public JKBJJJFJOEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x3DBF750", Offset = "0x3DBDF50", VA = "0x183DBF750")]
		internal GHGLDBKCJPG AGPEAPLEIKJ(byte[] msg)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[CompilerGenerated]
	private sealed class AACJJFCOOPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public AsyncTaskMethodBuilder<GBODBCPKFEK.DLDANNIGHFL<GHGLDBKCJPG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public GHGLDBKCJPG roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public DOLCNHODOEC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		private JKBJJJFJOEG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		private GLMLPFOGBAH <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		private GBODBCPKFEK.DLDANNIGHFL<GHGLDBKCJPG> <response>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		private GLMLPFOGBAH <actualMessageKind>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		private GBODBCPKFEK.DLDANNIGHFL<GHGLDBKCJPG> <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		private string <errorMessage>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		private ByteString <actualOperationId>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		private string <errorMessage>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		private TaskAwaiter<GBODBCPKFEK.DLDANNIGHFL<GHGLDBKCJPG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public AACJJFCOOPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x3DB5BF0", Offset = "0x3DB43F0", VA = "0x183DB5BF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011B")]
	[CompilerGenerated]
	private sealed class OMEDMIJIECF<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public Func<CancellationToken, Task<T>> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public DOLCNHODOEC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		private T <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0xC2D400", Offset = "0xC2BC00", VA = "0x180C2D400")]
		public OMEDMIJIECF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x2E9FA60", Offset = "0x2E9E260", VA = "0x182E9FA60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011C")]
	[CompilerGenerated]
	private sealed class OCHJLDEFHGD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public DOLCNHODOEC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public OCHJLDEFHGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x3DC4620", Offset = "0x3DC2E20", VA = "0x183DC4620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011D")]
	[CompilerGenerated]
	private sealed class DPDLCEBKCBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public DPDLCEBKCBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x3DBC520", Offset = "0x3DBAD20", VA = "0x183DBC520")]
		internal object NGPHNANPGGL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x3DBC410", Offset = "0x3DBAC10", VA = "0x183DBC410")]
		internal bool JILFKKLIIKC(Guid guid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011E")]
	[CompilerGenerated]
	private sealed class JKGLLNOBNIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public JKGLLNOBNIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x3DBF810", Offset = "0x3DBE010", VA = "0x183DBF810")]
		internal object JJEPLBFPPJA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011F")]
	[CompilerGenerated]
	private sealed class PGMNNJIEDAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public PGMNNJIEDAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x3DC8470", Offset = "0x3DC6C70", VA = "0x183DC8470")]
		internal object NENAEGAJIPD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000120")]
	[CompilerGenerated]
	private sealed class PJLAMPDAHNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public PJLAMPDAHNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x3DC88E0", Offset = "0x3DC70E0", VA = "0x183DC88E0")]
		internal object GDBIMFKIFPA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000122")]
	[CompilerGenerated]
	private sealed class MPNLHKLHJME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public DOLCNHODOEC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public MPNLHKLHJME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x3DC3BF0", Offset = "0x3DC23F0", VA = "0x183DC3BF0")]
		internal object OJFHNOFNKGF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000483")]
	private static readonly Guid FPFMIKOIBHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000484")]
	public readonly JKCDDAOJCAB PNIGLPMNNLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000485")]
	private readonly GBODBCPKFEK PAJHGANAIPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000486")]
	private readonly ADEKDIENBAG NDDDHNPEAPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000487")]
	private readonly KJIBLJHFIIJ LOLHJNJIFPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000488")]
	private bool BCIDFCDGLKA;

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x204D9D0", Offset = "0x204C1D0", VA = "0x18204D9D0")]
	public DOLCNHODOEC(JKCDDAOJCAB IKBOIGIEDJD, GBODBCPKFEK PAJHGANAIPN, ADEKDIENBAG NDDDHNPEAPJ, KJIBLJHFIIJ LOLHJNJIFPH, CINMLNOINGA<string>.BIMPMJLMAHG KOKOCCCLBFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x204CA00", Offset = "0x204B200", VA = "0x18204CA00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x204CA00", Offset = "0x204B200", VA = "0x18204CA00")]
	public void CPANEHCKKPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x204CC90", Offset = "0x204B490", VA = "0x18204CC90")]
	public void HAOLJPHFICP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x204D470", Offset = "0x204BC70", VA = "0x18204D470")]
	public void MFCHPICIMIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x204CEF0", Offset = "0x204B6F0", VA = "0x18204CEF0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PIPECJLMAPC))]
	internal Task<GHGLDBKCJPG> LINDCHGOAKG(CINMLNOINGA<string>.BIMPMJLMAHG KOKOCCCLBFO, GHGLDBKCJPG JHHCMCLGGPM, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x20507D0", Offset = "0x204EFD0", VA = "0x1820507D0")]
	private static byte[] GPLADFPAFCP<T>(T AKADEFDGONP) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x308B4F0", Offset = "0x3089CF0", VA = "0x18308B4F0")]
	private static T NCMELAFENJJ<T>(MessageParser<T> FCCPIMJEOPN, byte[] AKADEFDGONP, T EPFBMINCCNB) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x204D260", Offset = "0x204BA60", VA = "0x18204D260")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AACJJFCOOPF))]
	private Task<GBODBCPKFEK.DLDANNIGHFL<GHGLDBKCJPG>> MDCNNACHKLO(GHGLDBKCJPG JHHCMCLGGPM, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x308B210", Offset = "0x3089A10", VA = "0x18308B210")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OMEDMIJIECF<>))]
	internal Task<T> JDFKGHFDLLL<T>(CancellationToken MAGFBIFMOHG, Func<CancellationToken, Task<T>> BHGJJJMCLDO, int JCBJDKOJLPO = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x204CD60", Offset = "0x204B560", VA = "0x18204CD60")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OCHJLDEFHGD))]
	internal Task JDFKGHFDLLL(CancellationToken MAGFBIFMOHG, Func<CancellationToken, Task> BHGJJJMCLDO, int JCBJDKOJLPO = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x204C860", Offset = "0x204B060", VA = "0x18204C860")]
	public PBKLDGAICIL CCHOLKAKEPN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x204D400", Offset = "0x204BC00", VA = "0x18204D400")]
	public IEEHHHIAKBO MDDFCMFPNEK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x204D0B0", Offset = "0x204B8B0", VA = "0x18204D0B0")]
	public KGLPJJELOMN LLLKPOMOGGK([Optional] JNGNMMOLKFF? MBNJNNGOKFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x204CB20", Offset = "0x204B320", VA = "0x18204CB20")]
	public void EKMHHNBBMPE(Func<Guid, bool> AJLCELFFJOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x204C8D0", Offset = "0x204B0D0", VA = "0x18204C8D0")]
	public void CMPAIKMOJIC(Func<Guid, bool> KGMLPBEJDNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x204D7B0", Offset = "0x204BFB0", VA = "0x18204D7B0")]
	public Guid PLGEOALJFON()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x204C730", Offset = "0x204AF30", VA = "0x18204C730")]
	public void AAMGNEIPNGD(Guid COFCMMGDNFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x204D660", Offset = "0x204BE60", VA = "0x18204D660")]
	public void PEFPFNFBNIM(GHGLDBKCJPG NDADMEFBCHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x204D540", Offset = "0x204BD40", VA = "0x18204D540")]
	public void MFCLMPLONOJ(string AIONICHGEJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x308B410", Offset = "0x3089C10", VA = "0x18308B410")]
	private T LIGJHBNAJLC<T>(T MENBIMCLIOI) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x204D210", Offset = "0x204BA10", VA = "0x18204D210")]
	public void MBFNECIMNJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x308AD00", Offset = "0x3089500", VA = "0x18308AD00")]
	[CompilerGenerated]
	internal static string HFNNPGOCLHA<T>(byte[] IFGPPACGKDK, int GLAKJJLMGLI, ref FICMOPEEAMM<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
internal struct GDNPNCLBKOK
{
	[Cpp2IlInjected.Token(Token = "0x2000124")]
	[CompilerGenerated]
	private sealed class LIDOMOONFNA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public IBHEBOMOMMF roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public bool omShouldBeEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public CINMLNOINGA<string>.BIMPMJLMAHG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public LIDOMOONFNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x3DC1150", Offset = "0x3DBF950", VA = "0x183DC1150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000125")]
	[CompilerGenerated]
	private sealed class PBCHOAFNOOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public CINMLNOINGA<string>.BIMPMJLMAHG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public GDNPNCLBKOK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		private MCMNGPGPMDI <presence>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public PBCHOAFNOOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x3DC6BE0", Offset = "0x3DC53E0", VA = "0x183DC6BE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	private IBHEBOMOMMF KPGFDADNAJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	private bool DNNDIPFLODN;

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	private CABGPNHLHHJ BKEEIANIHAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x2059D20", Offset = "0x2058520", VA = "0x182059D20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	private ONNFMGINMGB LNIEMJIJJKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x2059CA0", Offset = "0x20584A0", VA = "0x182059CA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x2059EF0", Offset = "0x20586F0", VA = "0x182059EF0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LIDOMOONFNA))]
	public static Task JELDACCCIFL(IBHEBOMOMMF KPGFDADNAJA, bool DNNDIPFLODN, CINMLNOINGA<string>.BIMPMJLMAHG KOKOCCCLBFO, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x2059D70", Offset = "0x2058570", VA = "0x182059D70")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PBCHOAFNOOC))]
	private Task JELDACCCIFL(CINMLNOINGA<string>.BIMPMJLMAHG KOKOCCCLBFO, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x205A090", Offset = "0x2058890", VA = "0x18205A090")]
	private void MGPLGOGIABB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
internal struct PJIIMEAOIIK
{
	[Cpp2IlInjected.Token(Token = "0x2000127")]
	[CompilerGenerated]
	private sealed class HDIKLDPNJOE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		public IBHEBOMOMMF roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public ALNDGPDOBOK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public DOLCNHODOEC operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public CINMLNOINGA<string>.BIMPMJLMAHG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public HDIKLDPNJOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x53690D0", Offset = "0x53678D0", VA = "0x1853690D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000128")]
	[CompilerGenerated]
	private sealed class KKLHHOJPAIN
	{
		[Cpp2IlInjected.Token(Token = "0x2000129")]
		private sealed class <<Run>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004DF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004E0")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004E1")]
			public CINMLNOINGA<string>.BIMPMJLMAHG timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004E2")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004E3")]
			public KKLHHOJPAIN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40004E4")]
			private CINMLNOINGA<string>.BIMPMJLMAHG <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40004E5")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000549")]
			[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
			public <<Run>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600054A")]
			[Cpp2IlInjected.Address(RVA = "0x53702B0", Offset = "0x536EAB0", VA = "0x1853702B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600054B")]
			[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public KKLHHOJPAIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x536A860", Offset = "0x5369060", VA = "0x18536A860")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task AIEPNMIPKAI(CINMLNOINGA<string>.BIMPMJLMAHG timer, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[CompilerGenerated]
	private sealed class CPGBNAAOOEO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public CINMLNOINGA<string>.BIMPMJLMAHG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public PJIIMEAOIIK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		private AGRoomRuntimeConfig.Location <locationConfig>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		private KKLHHOJPAIN <>8__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		private GHGLDBKCJPG <completeMessage>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		private object <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		private int <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		private TaskAwaiter<GHGLDBKCJPG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public CPGBNAAOOEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x5367730", Offset = "0x5365F30", VA = "0x185367730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	private sealed class JKGLBGBJILL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public MIKHCJJNMEJ version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public bool preserveScoreboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public List<PersistenceView> existingViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public List<GameObject> objectsToDestroy;

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public JKGLBGBJILL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x5369A40", Offset = "0x5368240", VA = "0x185369A40")]
		internal object PBLKAHAMFIE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x5369B20", Offset = "0x5368320", VA = "0x185369B20")]
		internal object PEFPMOBKPPF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	private IBHEBOMOMMF KPGFDADNAJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	private ALNDGPDOBOK NFBDMLCENEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	private DOLCNHODOEC HNPDANNACGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	private bool LPGOMLBIPJD;

	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	private static readonly ByteString NCONOKGOICM;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	private CABGPNHLHHJ BKEEIANIHAB
	{
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x26796D0", Offset = "0x2677ED0", VA = "0x1826796D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	private ONNFMGINMGB LNIEMJIJJKA
	{
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x2679650", Offset = "0x2677E50", VA = "0x182679650")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x26798A0", Offset = "0x26780A0", VA = "0x1826798A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HDIKLDPNJOE))]
	public static Task JELDACCCIFL(IBHEBOMOMMF KPGFDADNAJA, ALNDGPDOBOK NFBDMLCENEN, DOLCNHODOEC HNPDANNACGJ, CINMLNOINGA<string>.BIMPMJLMAHG KOKOCCCLBFO, CancellationToken NNLBJPBEHPF, bool LPGOMLBIPJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x2679720", Offset = "0x2677F20", VA = "0x182679720")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CPGBNAAOOEO))]
	private Task JELDACCCIFL(CINMLNOINGA<string>.BIMPMJLMAHG KOKOCCCLBFO, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x2679A80", Offset = "0x2678280", VA = "0x182679A80")]
	private void KPMENDIIJCC([NotNull] KHHPFHOAEJL FINJDDGCGDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x26795F0", Offset = "0x2677DF0", VA = "0x1826795F0")]
	private bool CDAOOMOELDF(MIKHCJJNMEJ MNJCDKNLLPF, KHHPFHOAEJL FINJDDGCGDL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
internal abstract class FPFMDBHMGLL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	public readonly JKCDDAOJCAB PNIGLPMNNLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004F8")]
	public readonly DOLCNHODOEC EEKKFLDLOOB;

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public CABGPNHLHHJ BKEEIANIHAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x2057760", Offset = "0x2055F60", VA = "0x182057760")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public ONNFMGINMGB LNIEMJIJJKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0x20576D0", Offset = "0x2055ED0", VA = "0x1820576D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x20577D0", Offset = "0x2055FD0", VA = "0x1820577D0")]
	protected FPFMDBHMGLL(DOLCNHODOEC HNPDANNACGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x20577B0", Offset = "0x2055FB0", VA = "0x1820577B0")]
	protected void MFCLMPLONOJ(string AIONICHGEJE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
internal class IEEHHHIAKBO : FPFMDBHMGLL, MGGHJIKFILN
{
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	public delegate Task<GNLKPICAGOB> PFLKHECAMGD(ALNDGPDOBOK NFBDMLCENEN, CJPEEBFCFIN PODLFFJAHHM, ALLKAECLDFK BOGIMCCMKGE, CINMLNOINGA<string>.BIMPMJLMAHG KOKOCCCLBFO, CancellationToken NNLBJPBEHPF);

	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[CompilerGenerated]
	private sealed class GIDGIAGLMIF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public ACEIDINIJDO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public CINMLNOINGA<string>.BIMPMJLMAHG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		public IEEHHHIAKBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		private HDIFABCOJHG <lifetime>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		private GHGLDBKCJPG <synced>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		private GHGLDBKCJPG <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		private TaskAwaiter<GHGLDBKCJPG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public GIDGIAGLMIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x36E8170", Offset = "0x36E6970", VA = "0x1836E8170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[CompilerGenerated]
	private sealed class OCEKALMOELM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public AsyncTaskMethodBuilder<GHGLDBKCJPG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public ACEIDINIJDO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		public CINMLNOINGA<string>.BIMPMJLMAHG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		public IEEHHHIAKBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		private CINMLNOINGA<string>.BIMPMJLMAHG <syncTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		private GHGLDBKCJPG <message>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		private GHGLDBKCJPG <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		private TaskAwaiter<GHGLDBKCJPG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public OCEKALMOELM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x36F2360", Offset = "0x36F0B60", VA = "0x1836F2360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[CompilerGenerated]
	private sealed class LKCOMDFMHAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		public ACEIDINIJDO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		public CINMLNOINGA<string>.BIMPMJLMAHG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		public IEEHHHIAKBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		private CINMLNOINGA<string>.BIMPMJLMAHG <loadRoomLocalTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public LKCOMDFMHAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0x36EED60", Offset = "0x36ED560", VA = "0x1836EED60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000132")]
	[CompilerGenerated]
	private sealed class AIOPFHLDMDF
	{
		[Cpp2IlInjected.Token(Token = "0x2000133")]
		private sealed class <<LoadRoomLocal>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000525")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000526")]
			public AsyncTaskMethodBuilder<LPNELAFLFMK> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000527")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000528")]
			public AIOPFHLDMDF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000529")]
			private LPNELAFLFMK <innerData>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400052A")]
			private LPNELAFLFMK <>s__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x400052B")]
			private TaskAwaiter<GNLKPICAGOB> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x400052C")]
			private TaskAwaiter<LPNELAFLFMK> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000588")]
			[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
			public <<LoadRoomLocal>b__2>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000589")]
			[Cpp2IlInjected.Address(RVA = "0x536EEA0", Offset = "0x536D6A0", VA = "0x18536EEA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600058A")]
			[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000134")]
		private sealed class <<LoadRoomLocal>b__4>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400052D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400052E")]
			public AsyncTaskMethodBuilder<ALNDGPDOBOK> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400052F")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000530")]
			public AIOPFHLDMDF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000531")]
			private ALNDGPDOBOK <innerPhaseArgs>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000532")]
			private ALNDGPDOBOK <>s__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000533")]
			private TaskAwaiter<GNLKPICAGOB> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000534")]
			private TaskAwaiter<ALNDGPDOBOK> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600058B")]
			[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
			public <<LoadRoomLocal>b__4>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600058C")]
			[Cpp2IlInjected.Address(RVA = "0x536F5F0", Offset = "0x536DDF0", VA = "0x18536F5F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600058D")]
			[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000135")]
		private sealed class <<LoadRoomLocal>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000535")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000536")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000537")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000538")]
			public AIOPFHLDMDF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000539")]
			private bool <isReloadingSceneForObjectModel>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
			[Cpp2IlInjected.Token(Token = "0x400053A")]
			private bool <>s__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400053B")]
			private CJPEEBFCFIN <timedYielder>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400053C")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400053D")]
			private TaskAwaiter<GNLKPICAGOB> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400053E")]
			private TaskAwaiter <>u__3;

			[Cpp2IlInjected.Token(Token = "0x600058E")]
			[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
			public <<LoadRoomLocal>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600058F")]
			[Cpp2IlInjected.Address(RVA = "0x536DA30", Offset = "0x536C230", VA = "0x18536DA30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000590")]
			[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public IEEHHHIAKBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public ACEIDINIJDO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		public ALLKAECLDFK preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		public CINMLNOINGA<string>.BIMPMJLMAHG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		public ALLKAECLDFK downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		public LPNELAFLFMK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		public ALLKAECLDFK postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		public ALNDGPDOBOK phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		public HIOOKNMCKLA.GFKEFMJAALB <>9__6;

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public AIOPFHLDMDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x36E0B70", Offset = "0x36DF370", VA = "0x1836E0B70")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__2>d))]
		internal Task<LPNELAFLFMK> AKOLILCIIII(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x36E0CE0", Offset = "0x36DF4E0", VA = "0x1836E0CE0")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__4>d))]
		internal Task<ALNDGPDOBOK> NIKFGNOBNGH(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x36E0E50", Offset = "0x36DF650", VA = "0x1836E0E50")]
		internal void NOHEPAHAFHE(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x36E0A20", Offset = "0x36DF220", VA = "0x1836E0A20")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__0>d))]
		internal Task AKNAEBLHNHO(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[CompilerGenerated]
	private sealed class JKHPNFEGJCF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		public ACEIDINIJDO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		public CINMLNOINGA<string>.BIMPMJLMAHG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		public IEEHHHIAKBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		private AIOPFHLDMDF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		private bool <hasAssetBundle>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		private float <dataDownloadProgressRangeUpperBound>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		private LPNELAFLFMK <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		private ALNDGPDOBOK <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		private TaskAwaiter<LPNELAFLFMK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		private TaskAwaiter<ALNDGPDOBOK> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public JKHPNFEGJCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x36EB500", Offset = "0x36E9D00", VA = "0x1836EB500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000138")]
	[CompilerGenerated]
	private sealed class GHFJNDHKKON : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		public CINMLNOINGA<string>.BIMPMJLMAHG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		public IEEHHHIAKBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public GHFJNDHKKON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x36E7A00", Offset = "0x36E6200", VA = "0x1836E7A00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000139")]
	[CompilerGenerated]
	private sealed class GBCPEGMCCHP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public ALNDGPDOBOK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public ALLKAECLDFK progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public CINMLNOINGA<string>.BIMPMJLMAHG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public IEEHHHIAKBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		private CINMLNOINGA<string>.BIMPMJLMAHG <legacyLoadRoomDataTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		private TaskAwaiter<GNLKPICAGOB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public GBCPEGMCCHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x36E6CC0", Offset = "0x36E54C0", VA = "0x1836E6CC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013A")]
	[CompilerGenerated]
	private sealed class LMFFDOIEAAI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		public AsyncTaskMethodBuilder<GNLKPICAGOB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		public ALNDGPDOBOK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		public CJPEEBFCFIN timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		public ALLKAECLDFK progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		public CINMLNOINGA<string>.BIMPMJLMAHG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		public IEEHHHIAKBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		private CINMLNOINGA<string>.BIMPMJLMAHG <destroyAndRebuildObjectsTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		private TaskAwaiter<GNLKPICAGOB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public LMFFDOIEAAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x36EF440", Offset = "0x36EDC40", VA = "0x1836EF440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013B")]
	[CompilerGenerated]
	private sealed class DDCABMEGJFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		public AsyncTaskMethodBuilder<GNLKPICAGOB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		public ALNDGPDOBOK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		public CJPEEBFCFIN timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		public ALLKAECLDFK progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		public CINMLNOINGA<string>.BIMPMJLMAHG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		public IEEHHHIAKBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		private CINMLNOINGA<string>.BIMPMJLMAHG <deserializeAllObjectsTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		private TaskAwaiter<GNLKPICAGOB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public DDCABMEGJFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x36E39B0", Offset = "0x36E21B0", VA = "0x1836E39B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[CompilerGenerated]
	private sealed class FMFOHMMPDFF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public AsyncTaskMethodBuilder<GNLKPICAGOB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		public GNLKPICAGOB operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public ALNDGPDOBOK deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public ALLKAECLDFK progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		public CINMLNOINGA<string>.BIMPMJLMAHG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		public IEEHHHIAKBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		private GNLKPICAGOB <result>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		private GNLKPICAGOB <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		private TaskAwaiter<GNLKPICAGOB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public FMFOHMMPDFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x36E6580", Offset = "0x36E4D80", VA = "0x1836E6580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[CompilerGenerated]
	private sealed class GALNADNOPNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		public IEEHHHIAKBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		public ALNDGPDOBOK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		public ALLKAECLDFK progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		public CINMLNOINGA<string>.BIMPMJLMAHG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		public PFLKHECAMGD masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		public CJPEEBFCFIN timedYielder;

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public GALNADNOPNM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[CompilerGenerated]
	private sealed class HEKFJLBBHDG
	{
		[Cpp2IlInjected.Token(Token = "0x200013F")]
		private sealed class <<MasterLockedPhaseChangeBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400058C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400058D")]
			public AsyncTaskMethodBuilder<GNLKPICAGOB> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400058E")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400058F")]
			public HEKFJLBBHDG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000590")]
			private IDisposable <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000591")]
			private GNLKPICAGOB <result>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000592")]
			private GNLKPICAGOB <>s__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000593")]
			private TaskAwaiter<GNLKPICAGOB> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005AC")]
			[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
			public <<MasterLockedPhaseChangeBlock>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AD")]
			[Cpp2IlInjected.Address(RVA = "0x536FBE0", Offset = "0x536E3E0", VA = "0x18536FBE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AE")]
			[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		public GNLKPICAGOB originalRoomLoadPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		public GALNADNOPNM CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public HEKFJLBBHDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x36E9770", Offset = "0x36E7F70", VA = "0x1836E9770")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<GNLKPICAGOB> GABJJGMJOFL(CancellationToken mlToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000140")]
	[CompilerGenerated]
	private sealed class KCHMHHMCDBB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		public AsyncTaskMethodBuilder<GNLKPICAGOB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		public ALNDGPDOBOK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		public CJPEEBFCFIN timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		public ALLKAECLDFK progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		public CINMLNOINGA<string>.BIMPMJLMAHG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		public PFLKHECAMGD masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		public IEEHHHIAKBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		private GALNADNOPNM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		private HEKFJLBBHDG <>8__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		private GNLKPICAGOB <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		private TaskAwaiter<GNLKPICAGOB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public KCHMHHMCDBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x36EC250", Offset = "0x36EAA50", VA = "0x1836EC250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000141")]
	[CompilerGenerated]
	private sealed class PKDIGGHIFHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		public ALNDGPDOBOK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		public ALLKAECLDFK progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		public CINMLNOINGA<string>.BIMPMJLMAHG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		public IEEHHHIAKBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		private GNLKPICAGOB <legacyEndPhase>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		private IEnumerator<GNLKPICAGOB> <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		private GNLKPICAGOB <phase>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		private TaskAwaiter<GNLKPICAGOB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public PKDIGGHIFHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x36F3B30", Offset = "0x36F2330", VA = "0x1836F3B30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000142")]
	[CompilerGenerated]
	private sealed class HDPBFDCKLHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		public ALNDGPDOBOK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		public CINMLNOINGA<string>.BIMPMJLMAHG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		public IEEHHHIAKBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public HDPBFDCKLHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x36E9580", Offset = "0x36E7D80", VA = "0x1836E9580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000143")]
	[CompilerGenerated]
	private sealed class KGAKCHNHHGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		public ALNDGPDOBOK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		public IEEHHHIAKBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public KGAKCHNHHGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x36EC9C0", Offset = "0x36EB1C0", VA = "0x1836EC9C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	private readonly NHDFEEHHMNM EMNKCAJCIOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	private readonly NHDFEEHHMNM AAEKNGIKDDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	private readonly JOBAJLNCBIL JMDLAHHNDMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	private readonly KNBIFNDEGBD MALPFBBDGFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	private readonly BILBBHDALCD NNPNJHCLCIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	private readonly LKCILEABLOB APAKBJGNFHP;

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	private IBHEBOMOMMF PPOLOGJINGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x205E1B0", Offset = "0x205C9B0", VA = "0x18205E1B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event HMKKMGGIDLC APJENNAKHIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x205E980", Offset = "0x205D180", VA = "0x18205E980", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x205D3B0", Offset = "0x205BBB0", VA = "0x18205D3B0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x205EE90", Offset = "0x205D690", VA = "0x18205EE90")]
	public IEEHHHIAKBO(DOLCNHODOEC HNPDANNACGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x205E9A0", Offset = "0x205D1A0", VA = "0x18205E9A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GIDGIAGLMIF))]
	public Task OFIOIHEIFJM(ACEIDINIJDO AJNIDCPPJGC, CINMLNOINGA<string>.BIMPMJLMAHG KOKOCCCLBFO, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x205D140", Offset = "0x205B940", VA = "0x18205D140")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OCEKALMOELM))]
	private Task<GHGLDBKCJPG> AKNPOBEPDGK(ACEIDINIJDO AJNIDCPPJGC, CINMLNOINGA<string>.BIMPMJLMAHG KOKOCCCLBFO, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x205DE80", Offset = "0x205C680", VA = "0x18205DE80")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LKCOMDFMHAE))]
	private Task HIEPAOAOBOA(ACEIDINIJDO AJNIDCPPJGC, CINMLNOINGA<string>.BIMPMJLMAHG KOKOCCCLBFO, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x205ECB0", Offset = "0x205D4B0", VA = "0x18205ECB0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JKHPNFEGJCF))]
	private Task PLCGBKHFCCO(ACEIDINIJDO AJNIDCPPJGC, CINMLNOINGA<string>.BIMPMJLMAHG KOKOCCCLBFO, CancellationToken ABDFGAAFKAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x205DB50", Offset = "0x205C350", VA = "0x18205DB50")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GHFJNDHKKON))]
	private Task FPHELLCEFNF(CINMLNOINGA<string>.BIMPMJLMAHG FMGNKDAMMIM, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x205D950", Offset = "0x205C150", VA = "0x18205D950")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GBCPEGMCCHP))]
	private Task BNKKFNADEGF(ALNDGPDOBOK NFBDMLCENEN, ALLKAECLDFK BOGIMCCMKGE, CINMLNOINGA<string>.BIMPMJLMAHG KOKOCCCLBFO, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x205E390", Offset = "0x205CB90", VA = "0x18205E390")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LMFFDOIEAAI))]
	private Task<GNLKPICAGOB> LBEIJKKICLJ(ALNDGPDOBOK NFBDMLCENEN, CJPEEBFCFIN ILKAAHOKFLK, ALLKAECLDFK BOGIMCCMKGE, CINMLNOINGA<string>.BIMPMJLMAHG KOKOCCCLBFO, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x205CF30", Offset = "0x205B730", VA = "0x18205CF30")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DDCABMEGJFI))]
	private Task<GNLKPICAGOB> AEJJOCLPNMB(ALNDGPDOBOK NFBDMLCENEN, CJPEEBFCFIN ILKAAHOKFLK, ALLKAECLDFK BOGIMCCMKGE, CINMLNOINGA<string>.BIMPMJLMAHG KOKOCCCLBFO, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x205E5A0", Offset = "0x205CDA0", VA = "0x18205E5A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FMFOHMMPDFF))]
	private Task<GNLKPICAGOB> LJHGKFGADAM(GNLKPICAGOB IAHEILFDKDM, ALNDGPDOBOK BCLHHIMIKNN, ALLKAECLDFK BOGIMCCMKGE, CINMLNOINGA<string>.BIMPMJLMAHG KOKOCCCLBFO, CancellationToken NNLBJPBEHPF, bool HDPKINJCCIM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x205E220", Offset = "0x205CA20", VA = "0x18205E220")]
	private bool KCGDLOIIBJB(ALNDGPDOBOK OINKGHGPJKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x205D720", Offset = "0x205BF20", VA = "0x18205D720")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KCHMHHMCDBB))]
	protected Task<GNLKPICAGOB> BLLFDDJFBFM(ALNDGPDOBOK NFBDMLCENEN, CJPEEBFCFIN ILKAAHOKFLK, ALLKAECLDFK BOGIMCCMKGE, CINMLNOINGA<string>.BIMPMJLMAHG KOKOCCCLBFO, CancellationToken NNLBJPBEHPF, PFLKHECAMGD MKFGNBOEMOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x205DCC0", Offset = "0x205C4C0", VA = "0x18205DCC0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PKDIGGHIFHK))]
	private Task HFAABMCLAIL(ALNDGPDOBOK NFBDMLCENEN, ALLKAECLDFK BOGIMCCMKGE, CINMLNOINGA<string>.BIMPMJLMAHG KOKOCCCLBFO, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x205E7B0", Offset = "0x205CFB0", VA = "0x18205E7B0")]
	private void LNEDIMJIHIC(GNLKPICAGOB FPDOEPFGAKP, ALLKAECLDFK BOGIMCCMKGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x205E1E0", Offset = "0x205C9E0", VA = "0x18205E1E0")]
	private void JCCPFDPLILC(GNLKPICAGOB CEOACPFPBJE, out GNLKPICAGOB HHEAAMGNFOE, out GNLKPICAGOB GGAJJOCFBNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x205EE50", Offset = "0x205D650", VA = "0x18205EE50")]
	private Task<LPNELAFLFMK> PNJBAKNAGCM(ACEIDINIJDO AJNIDCPPJGC, CINMLNOINGA<string>.BIMPMJLMAHG KOKOCCCLBFO, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x205E940", Offset = "0x205D140", VA = "0x18205E940")]
	private Task<ALNDGPDOBOK> NMLFAJPPIFC(LPNELAFLFMK NFBDMLCENEN, HIOOKNMCKLA.GFKEFMJAALB IADACIPJBBD, CINMLNOINGA<string>.BIMPMJLMAHG KOKOCCCLBFO, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x205D560", Offset = "0x205BD60", VA = "0x18205D560")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HDPBFDCKLHK))]
	private Task BHNDOLMFBPF(ALNDGPDOBOK NFBDMLCENEN, CINMLNOINGA<string>.BIMPMJLMAHG KOKOCCCLBFO, CancellationToken NNLBJPBEHPF, bool LPGOMLBIPJD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x205EB40", Offset = "0x205D340", VA = "0x18205EB40")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KGAKCHNHHGE))]
	private Task PDIMALMMEHO(ALNDGPDOBOK NFBDMLCENEN, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x205D3D0", Offset = "0x205BBD0", VA = "0x18205D3D0")]
	private Task BCKPJDBANPN(ALNDGPDOBOK NFBDMLCENEN, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x205E020", Offset = "0x205C820", VA = "0x18205E020")]
	private Task HMLNAJKKLNM(ALNDGPDOBOK NFBDMLCENEN, CINMLNOINGA<string>.BIMPMJLMAHG KOKOCCCLBFO, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x205DB30", Offset = "0x205C330", VA = "0x18205DB30")]
	private Task DDJHNINCPEK(ALNDGPDOBOK NFBDMLCENEN, CJPEEBFCFIN ILKAAHOKFLK, CINMLNOINGA<string>.BIMPMJLMAHG KOKOCCCLBFO, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x205CF10", Offset = "0x205B710", VA = "0x18205CF10")]
	private Task AAHIEEFOFOL(ALNDGPDOBOK NFBDMLCENEN, CJPEEBFCFIN ILKAAHOKFLK, CINMLNOINGA<string>.BIMPMJLMAHG KOKOCCCLBFO, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x205E820", Offset = "0x205D020", VA = "0x18205E820")]
	private static Task MNOJBIBLGDP(CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x205E800", Offset = "0x205D000", VA = "0x18205E800")]
	private Task MKDFKCAHKDC(ALNDGPDOBOK NFBDMLCENEN, CJPEEBFCFIN ILKAAHOKFLK, CINMLNOINGA<string>.BIMPMJLMAHG KOKOCCCLBFO, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x205DB10", Offset = "0x205C310", VA = "0x18205DB10")]
	private Task DCPEEOANLPC(ALNDGPDOBOK NFBDMLCENEN, CINMLNOINGA<string>.BIMPMJLMAHG KOKOCCCLBFO, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x205E8C0", Offset = "0x205D0C0", VA = "0x18205E8C0")]
	private void MOHGCOMACJB(ACEIDINIJDO AJNIDCPPJGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x205D300", Offset = "0x205BB00", VA = "0x18205D300")]
	public void ANJCILPDLNI(long DFOMHFMOJCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
	private static void IMJKEKOLLBP(JEELLOGMCHC GMEHCBDKOIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000144")]
internal abstract class JKCDDAOJCAB : MGGHJIKFILN
{
	[Cpp2IlInjected.Token(Token = "0x2000145")]
	public delegate Task LMEFNOODKHB(CINMLNOINGA<string>.BIMPMJLMAHG KOKOCCCLBFO, CancellationToken NNLBJPBEHPF);

	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[CompilerGenerated]
	private sealed class OGEAJPIAPLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		public CINMLNOINGA<string>.BIMPMJLMAHG operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		public JKCDDAOJCAB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public OGEAJPIAPLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x36F2B60", Offset = "0x36F1360", VA = "0x1836F2B60")]
		internal Task PGMBJJFBAJH(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[CompilerGenerated]
	private sealed class MILPFIKBJAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		public OGEAJPIAPLA CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public MILPFIKBJAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x36F1970", Offset = "0x36F0170", VA = "0x1836F1970")]
		internal object BMCJIIFNPMF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x36F1A30", Offset = "0x36F0230", VA = "0x1836F1A30")]
		internal object LLGFNDLJCME()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000148")]
	[CompilerGenerated]
	private sealed class LOCPMCAOIJB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		public CINMLNOINGA<string>.BIMPMJLMAHG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		public Func<JKCDDAOJCAB, CINMLNOINGA<string>.BIMPMJLMAHG, DOLCNHODOEC> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		public JKCDDAOJCAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		private OGEAJPIAPLA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		private DOLCNHODOEC <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		private Task <drivenTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		private GHGLDBKCJPG <completeMessage>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		private MILPFIKBJAO <>8__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		private TaskAwaiter<GHGLDBKCJPG> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public LOCPMCAOIJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x36F0020", Offset = "0x36EE820", VA = "0x1836F0020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000149")]
	[CompilerGenerated]
	private sealed class FFCLBNCMGHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		public CINMLNOINGA<string>.BIMPMJLMAHG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		public JKCDDAOJCAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		private LMEFNOODKHB <taskBuilder>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public FFCLBNCMGHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x36E6000", Offset = "0x36E4800", VA = "0x1836E6000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005BB")]
	public readonly Guid POLNAEAIDMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005BC")]
	public readonly ByteString DCOMGAEALBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40005BD")]
	public readonly KODFOCGBOAL EJKGEFLKPPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40005BE")]
	protected readonly string CHIJKOEJPOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40005BF")]
	private readonly IBHEBOMOMMF KPGFDADNAJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40005C0")]
	private readonly bool LAJLHNDKGKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40005C1")]
	private readonly Queue<LMEFNOODKHB> KHEEKKKEECD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40005C2")]
	private readonly ALLKAECLDFK DHGKHNIJGLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40005C3")]
	private readonly IILIALHMONN AMDKOMACAKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40005C4")]
	private bool FDCCIPFIGHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40005C5")]
	public GNLKPICAGOB MIHKDPOMICM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40005C6")]
	public GNLKPICAGOB CCOKIOPGFLM;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public IBHEBOMOMMF PPOLOGJINGO
	{
		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x7ED740", Offset = "0x7EBF40", VA = "0x1807ED740")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public CABGPNHLHHJ BKEEIANIHAB
	{
		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x205FFE0", Offset = "0x205E7E0", VA = "0x18205FFE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public GBAAIIHBBEB IOGBNHBHEDE
	{
		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x20605F0", Offset = "0x205EDF0", VA = "0x1820605F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public ONNFMGINMGB LNIEMJIJJKA
	{
		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x205FF60", Offset = "0x205E760", VA = "0x18205FF60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event HMKKMGGIDLC APJENNAKHIL
	{
		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x2060990", Offset = "0x205F190", VA = "0x182060990", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x205FF40", Offset = "0x205E740", VA = "0x18205FF40", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(RVA = "0x20609B0", Offset = "0x205F1B0", VA = "0x1820609B0")]
	protected JKCDDAOJCAB(Guid GMIOJDLOGJD, IBHEBOMOMMF KPGFDADNAJA, KODFOCGBOAL JACMAPKOKAK, string IPNEDCOIPND, IILIALHMONN AMDKOMACAKL, bool LAJLHNDKGKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(RVA = "0x2060230", Offset = "0x205EA30", VA = "0x182060230", Slot = "6")]
	protected virtual string IOPJHGKDJCF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(RVA = "0x2060410", Offset = "0x205EC10", VA = "0x182060410")]
	public void JFABFALGBNN(LMEFNOODKHB CBENLGODNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(RVA = "0x2060720", Offset = "0x205EF20", VA = "0x182060720")]
	protected void LDCHMNMAKCK(float HLLBMEGLPCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(RVA = "0x2060270", Offset = "0x205EA70", VA = "0x182060270")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LOCPMCAOIJB))]
	public Task JELDACCCIFL(CancellationToken NNLBJPBEHPF, CINMLNOINGA<string>.BIMPMJLMAHG KOKOCCCLBFO, [Optional] Func<JKCDDAOJCAB, CINMLNOINGA<string>.BIMPMJLMAHG, DOLCNHODOEC> HHPAPMDJGAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C6")]
	[Cpp2IlInjected.Address(RVA = "0x2060470", Offset = "0x205EC70", VA = "0x182060470")]
	private void JJFNKLHKIHM(bool NFFGKDNLOEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(RVA = "0x2060740", Offset = "0x205EF40", VA = "0x182060740")]
	private void MAPNPOJNIOF(DOLCNHODOEC HNPDANNACGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract Task LEKKIJPMDAF(DOLCNHODOEC HNPDANNACGJ, CINMLNOINGA<string>.BIMPMJLMAHG KOKOCCCLBFO, CancellationToken NNLBJPBEHPF);

	[Cpp2IlInjected.Token(Token = "0x60005C9")]
	[Cpp2IlInjected.Address(RVA = "0x2060030", Offset = "0x205E830", VA = "0x182060030")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FFCLBNCMGHK))]
	private Task HHCIDJBPHCD(CINMLNOINGA<string>.BIMPMJLMAHG KOKOCCCLBFO, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(RVA = "0x20601A0", Offset = "0x205E9A0", VA = "0x1820601A0")]
	public GHGLDBKCJPG ILBKNMAMPLE(GLMLPFOGBAH CGBHAGJBDDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(RVA = "0x2060640", Offset = "0x205EE40", VA = "0x182060640")]
	[CompilerGenerated]
	private Task KEMILFANEEA(CancellationToken CIIALCPCBIG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200014A")]
internal abstract class FCLOIGABHLH : JKCDDAOJCAB
{
	[Cpp2IlInjected.Token(Token = "0x200014B")]
	[CompilerGenerated]
	private sealed class JCGKDNHFDJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		public FCLOIGABHLH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		public NCMPBPMKDEC playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public JCGKDNHFDJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x3DBF610", Offset = "0x3DBDE10", VA = "0x183DBF610")]
		internal Task HEFCNKJFOPI(CINMLNOINGA<string>.BIMPMJLMAHG postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x3DBF590", Offset = "0x3DBDD90", VA = "0x183DBF590")]
		internal object FOHDELNFPAE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[CompilerGenerated]
	private sealed class GINBPNPEOOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		public DOLCNHODOEC operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		public CINMLNOINGA<string>.BIMPMJLMAHG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		public FCLOIGABHLH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		private JCGKDNHFDJD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		private object <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		private int <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		private JGKCJOEACBD <recoverableRoomOperationException>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public GINBPNPEOOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x3DBD890", Offset = "0x3DBC090", VA = "0x183DBD890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[CompilerGenerated]
	private sealed class PANGFAACBKG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005F0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005F1")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		public NCMPBPMKDEC playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		public CINMLNOINGA<string>.BIMPMJLMAHG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		public FCLOIGABHLH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		private CINMLNOINGA<string>.BIMPMJLMAHG <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		private CINMLNOINGA<string>.BIMPMJLMAHG <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		private Exception <e>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public PANGFAACBKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x3DC66C0", Offset = "0x3DC4EC0", VA = "0x183DC66C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(RVA = "0x2056920", Offset = "0x2055120", VA = "0x182056920")]
	public FCLOIGABHLH(Guid GMIOJDLOGJD, IBHEBOMOMMF KPGFDADNAJA, KODFOCGBOAL JACMAPKOKAK, string IPNEDCOIPND, IILIALHMONN AMDKOMACAKL, bool LAJLHNDKGKN = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005DC")]
	[Cpp2IlInjected.Address(RVA = "0x20565E0", Offset = "0x2054DE0", VA = "0x1820565E0", Slot = "7")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GINBPNPEOOK))]
	protected override Task LEKKIJPMDAF(DOLCNHODOEC HNPDANNACGJ, CINMLNOINGA<string>.BIMPMJLMAHG KOKOCCCLBFO, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005DD")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task GPAMFCMMDKM(DOLCNHODOEC HNPDANNACGJ, CINMLNOINGA<string>.BIMPMJLMAHG KOKOCCCLBFO, CancellationToken NNLBJPBEHPF);

	[Cpp2IlInjected.Token(Token = "0x60005DE")]
	[Cpp2IlInjected.Address(RVA = "0x2056780", Offset = "0x2054F80", VA = "0x182056780")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PANGFAACBKG))]
	private Task LGCFALAMEMK(IDisposable GGJDHDCOOGC, NCMPBPMKDEC LHIIOAHEAEH, CINMLNOINGA<string>.BIMPMJLMAHG FMGNKDAMMIM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200014E")]
public readonly struct OOGLJJBDKMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005F9")]
	public readonly KHHPFHOAEJL? FHGLMIIICMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005FA")]
	public readonly AFMDIJCOACK KDMGLBEPCAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005FB")]
	public readonly string? AIMLAPGCGPK;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public IReadOnlyCollection<string> FHGDBOOJHHH
	{
		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x2676630", Offset = "0x2674E30", VA = "0x182676630")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public IReadOnlyDictionary<long, int> KHBHHKNCHHM
	{
		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x2676610", Offset = "0x2674E10", VA = "0x182676610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(RVA = "0x2676650", Offset = "0x2674E50", VA = "0x182676650")]
	public OOGLJJBDKMP(KHHPFHOAEJL? LHKEKFAGIAO, AFMDIJCOACK MOPJMJOBAGI, string? MOPJJOOHADC)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200014F")]
internal struct GJBOEKEEEMA
{
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[CompilerGenerated]
	private sealed class LFPDBJIPCEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		public DOLCNHODOEC operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		public ALNDGPDOBOK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		public CINMLNOINGA<string>.BIMPMJLMAHG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		private JKCDDAOJCAB <operation>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		private IBHEBOMOMMF <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		private CLKENBEKINM.KLEDDBBHAEL <instantiations>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		private TaskAwaiter<GHGLDBKCJPG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000607")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public LFPDBJIPCEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x3DC0C00", Offset = "0x3DBF400", VA = "0x183DC0C00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000151")]
	[CompilerGenerated]
	private sealed class AHGCHLANJHA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000608")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public AHGCHLANJHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x3DB9060", Offset = "0x3DB7860", VA = "0x183DB9060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(RVA = "0x205A6F0", Offset = "0x2058EF0", VA = "0x18205A6F0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LFPDBJIPCEP))]
	public static Task JELDACCCIFL(DOLCNHODOEC HNPDANNACGJ, ALNDGPDOBOK NFBDMLCENEN, CINMLNOINGA<string>.BIMPMJLMAHG KOKOCCCLBFO, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(RVA = "0x205A410", Offset = "0x2058C10", VA = "0x18205A410")]
	private static Task<GHGLDBKCJPG> BJOFKLDPAOO(DOLCNHODOEC HNPDANNACGJ, CINMLNOINGA<string>.BIMPMJLMAHG KOKOCCCLBFO, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(RVA = "0x205A5F0", Offset = "0x2058DF0", VA = "0x18205A5F0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AHGCHLANJHA))]
	private static Task BNALDEDCCEH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000152")]
internal class OJHLGMKMOPA : JKCDDAOJCAB
{
	[Cpp2IlInjected.Token(Token = "0x2000153")]
	[CompilerGenerated]
	private sealed class FFGLJDBONBO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		public DOLCNHODOEC operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000614")]
		public CINMLNOINGA<string>.BIMPMJLMAHG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000615")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000616")]
		public OJHLGMKMOPA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000617")]
		private long <roomId>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000618")]
		private long <subroomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000619")]
		private ObscuredInt <localPlayerAccountId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400061A")]
		private PBKLDGAICIL <uploadLogic>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		private bool <readSuccessfully>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400061C")]
		private OOGLJJBDKMP <data>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		private CINMLNOINGA<string>.BIMPMJLMAHG <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		private CINMLNOINGA<string>.BIMPMJLMAHG <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		private FPDNLDMDEKC <payload>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		private DateTime <localTime>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		private JHAJGBINBJN <>s__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		private TaskAwaiter<JHAJGBINBJN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public FFGLJDBONBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x5368680", Offset = "0x5366E80", VA = "0x185368680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400060C")]
	private readonly int PBONPDAFANK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400060D")]
	private readonly CCCEJDFLIPE AKBCGGCPLIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400060E")]
	public readonly long AELFDNGCHBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400060F")]
	public readonly long CGNHKFFBNHL;

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public JHAJGBINBJN KCGKICKCJKE
	{
		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0xA51D10", Offset = "0xA50510", VA = "0x180A51D10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0xA582E0", Offset = "0xA56AE0", VA = "0x180A582E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005F6")]
	[Cpp2IlInjected.Address(RVA = "0x2672250", Offset = "0x2670A50", VA = "0x182672250")]
	public OJHLGMKMOPA(Guid GMIOJDLOGJD, IBHEBOMOMMF KPGFDADNAJA, KODFOCGBOAL JACMAPKOKAK, int PBONPDAFANK, CCCEJDFLIPE AKBCGGCPLIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(RVA = "0x26720B0", Offset = "0x26708B0", VA = "0x1826720B0", Slot = "7")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FFGLJDBONBO))]
	protected override Task LEKKIJPMDAF(DOLCNHODOEC HNPDANNACGJ, CINMLNOINGA<string>.BIMPMJLMAHG KOKOCCCLBFO, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000154")]
internal struct BILBBHDALCD
{
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[CompilerGenerated]
	private sealed class OJIDHOKONBO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		public AsyncTaskMethodBuilder<GNLKPICAGOB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000628")]
		public GNLKPICAGOB nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000629")]
		public ALNDGPDOBOK deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400062A")]
		public CINMLNOINGA<string>.BIMPMJLMAHG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400062B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400062C")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400062D")]
		public BILBBHDALCD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400062E")]
		private CINMLNOINGA<string>.BIMPMJLMAHG <moveToPhaseTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400062F")]
		private Guid <handlersGuid>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000630")]
		private GNLKPICAGOB <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		private TaskAwaiter<GNLKPICAGOB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public OJIDHOKONBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x2672380", Offset = "0x2670B80", VA = "0x182672380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000156")]
	[CompilerGenerated]
	private sealed class OMNJFBADEIC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000633")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		public AsyncTaskMethodBuilder<GNLKPICAGOB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		public CINMLNOINGA<string>.BIMPMJLMAHG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000636")]
		public GNLKPICAGOB state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		public BILBBHDALCD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		private GHGLDBKCJPG <message>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		private GHGLDBKCJPG <returnMessage>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400063B")]
		private GNLKPICAGOB <authorityPhase>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		private GHGLDBKCJPG <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400063D")]
		private TaskAwaiter<GHGLDBKCJPG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public OMNJFBADEIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0x2673320", Offset = "0x2671B20", VA = "0x182673320", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000623")]
	private readonly DOLCNHODOEC HNPDANNACGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000624")]
	private readonly JOBAJLNCBIL JMDLAHHNDMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000625")]
	private readonly KNBIFNDEGBD MALPFBBDGFO;

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	private JKCDDAOJCAB PNIGLPMNNLE
	{
		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x2044320", Offset = "0x2042B20", VA = "0x182044320")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(RVA = "0x2044530", Offset = "0x2042D30", VA = "0x182044530")]
	public BILBBHDALCD(DOLCNHODOEC HNPDANNACGJ, JOBAJLNCBIL JMDLAHHNDMP, KNBIFNDEGBD MALPFBBDGFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(RVA = "0x2044120", Offset = "0x2042920", VA = "0x182044120")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OJIDHOKONBO))]
	public Task<GNLKPICAGOB> DAIIICJLOPF(GNLKPICAGOB IHAMOKOOKBA, ALNDGPDOBOK BCLHHIMIKNN, CINMLNOINGA<string>.BIMPMJLMAHG KOKOCCCLBFO, CancellationToken NNLBJPBEHPF, bool HDPKINJCCIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(RVA = "0x2044340", Offset = "0x2042B40", VA = "0x182044340")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OMNJFBADEIC))]
	private Task<GNLKPICAGOB> LJKKJDMLDNL(CINMLNOINGA<string>.BIMPMJLMAHG KOKOCCCLBFO, GNLKPICAGOB COOBJCJFHEP, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(RVA = "0x20440F0", Offset = "0x20428F0", VA = "0x1820440F0")]
	private bool BJFIKFDGNIG(GNLKPICAGOB DIOGCBJHHNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(RVA = "0x2044510", Offset = "0x2042D10", VA = "0x182044510")]
	private void MFCLMPLONOJ(string DPFPLPFKKOM)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000157")]
internal struct PDJBLPOPCGP
{
	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[CompilerGenerated]
	private sealed class KGCMGAINIEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400063F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000640")]
		public DOLCNHODOEC operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000641")]
		public ALNDGPDOBOK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		public CJPEEBFCFIN timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000643")]
		public CINMLNOINGA<string>.BIMPMJLMAHG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000644")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000645")]
		private JKCDDAOJCAB <operation>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		private GNLKPICAGOB <operationState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000647")]
		private IBHEBOMOMMF <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		private bool <isMaster>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		private CABGPNHLHHJ <callbacks>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400064A")]
		private GLJLJIADKGP <metrics>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400064B")]
		private IDisposable <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400064C")]
		private IDisposable <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400064D")]
		private List<(PersistenceView, GPPNCPPLGEE)>.Enumerator <>s__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400064E")]
		private PersistenceView <view>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400064F")]
		private GPPNCPPLGEE <viewData>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000650")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public KGCMGAINIEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x5369BD0", Offset = "0x53683D0", VA = "0x185369BD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(RVA = "0x2677A70", Offset = "0x2676270", VA = "0x182677A70")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KGCMGAINIEF))]
	public static Task JELDACCCIFL(DOLCNHODOEC HNPDANNACGJ, ALNDGPDOBOK NFBDMLCENEN, CJPEEBFCFIN ILKAAHOKFLK, CINMLNOINGA<string>.BIMPMJLMAHG KOKOCCCLBFO, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(RVA = "0x2677860", Offset = "0x2676060", VA = "0x182677860")]
	private static void ALHEHMFHJLO(PersistenceView DNMGFMBFODC, GPPNCPPLGEE AOPICFKOEII, ALNDGPDOBOK NFBDMLCENEN, GNLKPICAGOB IAHEILFDKDM, bool HKIHCIOEKCI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015A")]
internal class KGLPJJELOMN : FPFMDBHMGLL
{
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[CompilerGenerated]
	private sealed class IPLKGAIDJGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000656")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		public AsyncTaskMethodBuilder<OOGLJJBDKMP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		public FNOFEKPGFMA roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		public CACOFKKHDCM serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400065B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		public KGLPJJELOMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		private IEnumerable<PersistenceView> <activePersistenceViews>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		private StringBuilder <outputBuilder>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		private IDisposable <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public IPLKGAIDJGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x36EAEA0", Offset = "0x36E96A0", VA = "0x1836EAEA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015C")]
	[CompilerGenerated]
	private sealed class LEFJJFAKFDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000661")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		public CACOFKKHDCM serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000663")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000664")]
		public KGLPJJELOMN <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public LEFJJFAKFDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x36EDFD0", Offset = "0x36EC7D0", VA = "0x1836EDFD0")]
		internal Task NBJCHMJHMML(PersistenceView v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x36EDF00", Offset = "0x36EC700", VA = "0x1836EDF00")]
		internal Task KDHNLGDMNAM(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015D")]
	[CompilerGenerated]
	private sealed class CKLADFFLDHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		public float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		public LEFJJFAKFDO CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public CKLADFFLDHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x36E2EC0", Offset = "0x36E16C0", VA = "0x1836E2EC0")]
		internal object MHKMFDGKGDO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015E")]
	[CompilerGenerated]
	private sealed class AJPGABPMKKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000667")]
		public PersistenceView v;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		public LEFJJFAKFDO CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public AJPGABPMKKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0x36E0E90", Offset = "0x36DF690", VA = "0x1836E0E90")]
		internal Task DADJNILMIAE(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000160")]
	[CompilerGenerated]
	private sealed class GPNLAOJNKPE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400066E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400066F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000670")]
		public CACOFKKHDCM serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000671")]
		public IEnumerable<PersistenceView> activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000672")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000673")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000674")]
		public KGLPJJELOMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000675")]
		private LEFJJFAKFDO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000676")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000677")]
		private CKLADFFLDHH <>8__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000678")]
		private IEnumerable<Task> <pendingPreserializes>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000679")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public GPNLAOJNKPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x36E8A50", Offset = "0x36E7250", VA = "0x1836E8A50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000653")]
	private readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.Token(Token = "0x4000654")]
	private static readonly TimeSpan JDKDLNGFKOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000655")]
	private readonly PGBGDHIBGCE FCMEIJEGHAO;

	[Cpp2IlInjected.Token(Token = "0x600060F")]
	[Cpp2IlInjected.Address(RVA = "0x2669170", Offset = "0x2667970", VA = "0x182669170")]
	public KGLPJJELOMN(DOLCNHODOEC HNPDANNACGJ, PGBGDHIBGCE FCMEIJEGHAO, JNGNMMOLKFF MBNJNNGOKFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000610")]
	[Cpp2IlInjected.Address(RVA = "0x2667F40", Offset = "0x2666740", VA = "0x182667F40")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IPLKGAIDJGO))]
	public Task<OOGLJJBDKMP> CLIBMONIMNB(long OFFAGGOPNOB, FNOFEKPGFMA GGAFFNCHJDH, CACOFKKHDCM HDPBEFNDNDD, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000611")]
	[Cpp2IlInjected.Address(RVA = "0x2668120", Offset = "0x2666920", VA = "0x182668120")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GPNLAOJNKPE))]
	private Task EKPCCFIMBFE(CACOFKKHDCM HDPBEFNDNDD, IEnumerable<PersistenceView> ALGPCFOLEED, StringBuilder COHJIHLPBLO, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000612")]
	[Cpp2IlInjected.Address(RVA = "0x26684F0", Offset = "0x2666CF0", VA = "0x1826684F0")]
	private OOGLJJBDKMP IAPNOKDLAEI(long OFFAGGOPNOB, FNOFEKPGFMA GGAFFNCHJDH, CACOFKKHDCM HDPBEFNDNDD, IEnumerable<PersistenceView> ALGPCFOLEED, StringBuilder COHJIHLPBLO)
	{
		return default(OOGLJJBDKMP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000613")]
	[Cpp2IlInjected.Address(RVA = "0x2668F80", Offset = "0x2667780", VA = "0x182668F80")]
	private KHHPFHOAEJL PNNNCGEJABH(long OFFAGGOPNOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000614")]
	[Cpp2IlInjected.Address(RVA = "0x26682E0", Offset = "0x2666AE0", VA = "0x1826682E0")]
	private void GJNJHEIGCMO(KHHPFHOAEJL LMDNFHKCFLI, StringBuilder COHJIHLPBLO, IEnumerable<PersistenceView> ALGPCFOLEED, in DDAOFGHLKDI OMCFDNJOAAE, JDPGBMLKOMO PGHJDCNOLOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000615")]
	[Cpp2IlInjected.Address(RVA = "0x2668AB0", Offset = "0x26672B0", VA = "0x182668AB0")]
	private void KBMCFKLJJCE(KHHPFHOAEJL LMDNFHKCFLI, StringBuilder COHJIHLPBLO, PersistenceView DNMGFMBFODC, ref JDPGBMLKOMO PGHJDCNOLOE, in DDAOFGHLKDI OMCFDNJOAAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000161")]
internal class BCMEKDMKGIJ : JKCDDAOJCAB
{
	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private sealed class MAHOKHDODHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400067D")]
		public DOLCNHODOEC operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400067E")]
		public CINMLNOINGA<string>.BIMPMJLMAHG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400067F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000680")]
		public BCMEKDMKGIJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000681")]
		private long <roomId>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000682")]
		private long <subroomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000683")]
		private FNOFEKPGFMA <roomSaveOptions>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000684")]
		private KGLPJJELOMN <serializeLogic>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000685")]
		private CACOFKKHDCM <serializeType>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000686")]
		private OOGLJJBDKMP <data>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000687")]
		private OOGLJJBDKMP <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000688")]
		private Exception <ex>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000689")]
		private TaskAwaiter<OOGLJJBDKMP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public MAHOKHDODHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x266CBC0", Offset = "0x266B3C0", VA = "0x18266CBC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400067A")]
	private readonly BNGCJDIPPAA FPAFDBDKHNA;

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0x2042530", Offset = "0x2040D30", VA = "0x182042530")]
	public BCMEKDMKGIJ(Guid GMIOJDLOGJD, IBHEBOMOMMF KPGFDADNAJA, KODFOCGBOAL JACMAPKOKAK, BNGCJDIPPAA FPAFDBDKHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0x20422B0", Offset = "0x2040AB0", VA = "0x1820422B0", Slot = "6")]
	protected override string IOPJHGKDJCF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(RVA = "0x2042390", Offset = "0x2040B90", VA = "0x182042390", Slot = "7")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MAHOKHDODHO))]
	protected override Task LEKKIJPMDAF(DOLCNHODOEC HNPDANNACGJ, CINMLNOINGA<string>.BIMPMJLMAHG KOKOCCCLBFO, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000163")]
internal struct DFKCEIMHBLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400068A")]
	public Dictionary<Guid, List<ODJCNBPFKBG>> IHHIPDAAIGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400068B")]
	public Dictionary<Guid, List<ODJCNBPFKBG>> IBLFEMOFDCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400068C")]
	public Dictionary<Guid, List<ODJCNBPFKBG>> GHBLPEEGOEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400068D")]
	public List<Guid> NFBNHBEMKHG;

	[Cpp2IlInjected.Token(Token = "0x6000630")]
	[Cpp2IlInjected.Address(RVA = "0x204B550", Offset = "0x2049D50", VA = "0x18204B550")]
	public static DFKCEIMHBLM LPKBLHIFLLL(CABGPNHLHHJ BOBHLPNKBHC, GNLKPICAGOB IAHEILFDKDM, ALNDGPDOBOK BCLHHIMIKNN)
	{
		return default(DFKCEIMHBLM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000165")]
public readonly struct CGHJAIDDPDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000691")]
	public readonly bool ICOHNCCLKCO;

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(RVA = "0x123C7B0", Offset = "0x123AFB0", VA = "0x18123C7B0")]
	public CGHJAIDDPDJ(bool EIDNPHLLHJC)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000166")]
internal struct OALBBKDOJLF
{
	[Cpp2IlInjected.Token(Token = "0x2000167")]
	[CompilerGenerated]
	private sealed class IMIOAFBLPEI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000692")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000693")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000694")]
		public JKCDDAOJCAB operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000695")]
		public ALNDGPDOBOK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000696")]
		public CJPEEBFCFIN timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000697")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000698")]
		private GNLKPICAGOB <state>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000699")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400069A")]
		private IDisposable <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400069B")]
		private List<(PersistenceView, GPPNCPPLGEE)>.Enumerator <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400069C")]
		private (PersistenceView, GPPNCPPLGEE) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400069D")]
		private PersistenceView <view>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400069E")]
		private AIMEHLJHBHD <postDeserializeParams>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400069F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public IMIOAFBLPEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0x36EA950", Offset = "0x36E9150", VA = "0x1836EA950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(RVA = "0x26708F0", Offset = "0x266F0F0", VA = "0x1826708F0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IMIOAFBLPEI))]
	public static Task JELDACCCIFL(JKCDDAOJCAB IKBOIGIEDJD, ALNDGPDOBOK NFBDMLCENEN, CJPEEBFCFIN ILKAAHOKFLK, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000168")]
internal struct FDHLJLAEMCM
{
	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[CompilerGenerated]
	private sealed class MMOFMCBMANL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006AB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006AC")]
		public AsyncTaskMethodBuilder<ALNDGPDOBOK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006AD")]
		public HIOOKNMCKLA.GFKEFMJAALB downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006AE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006AF")]
		public FDHLJLAEMCM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40006B1")]
		private CINMLNOINGA<string>.BIMPMJLMAHG <downloadTimerScope>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40006B2")]
		private Task<DLDMCIANGML<BHPHMLLBEJC, CFJKAHNEDBL>> <assetBundleTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40006B3")]
		private Task<DLDMCIANGML<ONMENFLLGCG<KHHPFHOAEJL>, CFJKAHNEDBL>> <subRoomTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40006B4")]
		private Task<DLDMCIANGML<ONMENFLLGCG<PKMIHDKHPIO>, CFJKAHNEDBL>> <superRoomTask>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40006B5")]
		private Task<DLDMCIANGML<ONMENFLLGCG<KPJPJIKAGDF>, CFJKAHNEDBL>> <playerSaveTask>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40006B6")]
		private Task<(DLDMCIANGML<BHPHMLLBEJC, CFJKAHNEDBL>, DLDMCIANGML<ONMENFLLGCG<KHHPFHOAEJL>, CFJKAHNEDBL>, DLDMCIANGML<ONMENFLLGCG<PKMIHDKHPIO>, CFJKAHNEDBL>, DLDMCIANGML<ONMENFLLGCG<KPJPJIKAGDF>, CFJKAHNEDBL>)> <allTasks>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40006B7")]
		private DLDMCIANGML<BHPHMLLBEJC, CFJKAHNEDBL> <assetBundleSource>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40006B8")]
		private DLDMCIANGML<ONMENFLLGCG<KHHPFHOAEJL>, CFJKAHNEDBL> <subRoomDataRes>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40006B9")]
		private DLDMCIANGML<ONMENFLLGCG<PKMIHDKHPIO>, CFJKAHNEDBL> <superRoomDataRes>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40006BA")]
		private DLDMCIANGML<ONMENFLLGCG<KPJPJIKAGDF>, CFJKAHNEDBL> <playerSaveDataRes>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40006BB")]
		private ONMENFLLGCG<KHHPFHOAEJL> <room>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40006BC")]
		private (DLDMCIANGML<BHPHMLLBEJC, CFJKAHNEDBL>, DLDMCIANGML<ONMENFLLGCG<KHHPFHOAEJL>, CFJKAHNEDBL>, DLDMCIANGML<ONMENFLLGCG<PKMIHDKHPIO>, CFJKAHNEDBL>, DLDMCIANGML<ONMENFLLGCG<KPJPJIKAGDF>, CFJKAHNEDBL>) <>s__13;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40006BD")]
		private (DLDMCIANGML<BHPHMLLBEJC, CFJKAHNEDBL>, DLDMCIANGML<ONMENFLLGCG<KHHPFHOAEJL>, CFJKAHNEDBL>, DLDMCIANGML<ONMENFLLGCG<PKMIHDKHPIO>, CFJKAHNEDBL>, DLDMCIANGML<ONMENFLLGCG<KPJPJIKAGDF>, CFJKAHNEDBL>) <>s__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x40006BE")]
		private TaskAwaiter<(DLDMCIANGML<BHPHMLLBEJC, CFJKAHNEDBL>, DLDMCIANGML<ONMENFLLGCG<KHHPFHOAEJL>, CFJKAHNEDBL>, DLDMCIANGML<ONMENFLLGCG<PKMIHDKHPIO>, CFJKAHNEDBL>, DLDMCIANGML<ONMENFLLGCG<KPJPJIKAGDF>, CFJKAHNEDBL>)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public MMOFMCBMANL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x3DC31E0", Offset = "0x3DC19E0", VA = "0x183DC31E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[CompilerGenerated]
	private sealed class FINCFFENJIC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006BF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006C0")]
		public AsyncTaskMethodBuilder<DLDMCIANGML<BHPHMLLBEJC, CFJKAHNEDBL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006C1")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006C2")]
		public long roomInstanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006C3")]
		public HIOOKNMCKLA.GFKEFMJAALB downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006C4")]
		public CINMLNOINGA<string>.BIMPMJLMAHG downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006C5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006C6")]
		public FDHLJLAEMCM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40006C7")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40006C8")]
		private CINMLNOINGA<string>.BIMPMJLMAHG <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40006C9")]
		private DLDMCIANGML<BHPHMLLBEJC, CFJKAHNEDBL> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40006CA")]
		private TaskAwaiter<DLDMCIANGML<BHPHMLLBEJC, CFJKAHNEDBL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public FINCFFENJIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x3DBCCC0", Offset = "0x3DBB4C0", VA = "0x183DBCCC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006A0")]
	private CODOOLJGMCM<CENNEHOCJAK, PKMIHDKHPIO> NIAFFIKEMPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40006A1")]
	private CODOOLJGMCM<CENNEHOCJAK, KHHPFHOAEJL> GLGANEGPFIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006A2")]
	private CODOOLJGMCM<long, KPJPJIKAGDF> IOLCNODPGFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006A3")]
	private EAPMMHAANAI ODCFAKEMHLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006A4")]
	private JEELLOGMCHC GMEHCBDKOIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006A5")]
	private CKNKGBNGABP DDCPBKKGAOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40006A6")]
	private string MOPJJOOHADC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006A7")]
	private CENNEHOCJAK GGGHMACDDAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40006A8")]
	private CENNEHOCJAK BLJOCIDGDDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40006A9")]
	private long DFOMHFMOJCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40006AA")]
	private CINMLNOINGA<string>.BIMPMJLMAHG FMGNKDAMMIM;

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(RVA = "0x2056D90", Offset = "0x2055590", VA = "0x182056D90")]
	public static Task<ALNDGPDOBOK> NAABNLOLMIJ(IBHEBOMOMMF KPGFDADNAJA, in LPNELAFLFMK NFBDMLCENEN, HIOOKNMCKLA.GFKEFMJAALB IADACIPJBBD, CINMLNOINGA<string>.BIMPMJLMAHG FMGNKDAMMIM, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(RVA = "0x2056BC0", Offset = "0x20553C0", VA = "0x182056BC0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MMOFMCBMANL))]
	private Task<ALNDGPDOBOK> JELDACCCIFL(HIOOKNMCKLA.GFKEFMJAALB IADACIPJBBD, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(RVA = "0x20570F0", Offset = "0x20558F0", VA = "0x1820570F0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FINCFFENJIC))]
	private Task<DLDMCIANGML<BHPHMLLBEJC, CFJKAHNEDBL>> PPHJPHAEOKF(string MOPJJOOHADC, long DFOMHFMOJCN, HIOOKNMCKLA.GFKEFMJAALB IADACIPJBBD, CINMLNOINGA<string>.BIMPMJLMAHG PFLJPLJGEBM, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200016B")]
public class JOBAJLNCBIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006CB")]
	private readonly EPJPDLNCDIN GAPNJEJNFIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006CC")]
	private string MJNNKGFCPIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006CD")]
	private long? NAJHLAGIKLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40006CE")]
	private long? DHPODOCEDLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40006CF")]
	private long? CMHNMPDDOOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40006D0")]
	private string LNOMLFOCGNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40006D1")]
	private GNLKPICAGOB KGCMMKDIKHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40006D2")]
	private long? MDDCFDGMLDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40006D3")]
	private bool LBONMDBJGAM;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public string NFLKDGDNOKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public long JKLCDPKJCEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x2061690", Offset = "0x205FE90", VA = "0x182061690")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public long AGIHHNIHANF
	{
		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x2061550", Offset = "0x205FD50", VA = "0x182061550")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public long CEJPNONOJCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x20615B0", Offset = "0x205FDB0", VA = "0x1820615B0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public string JBACJOGHLPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x2061750", Offset = "0x205FF50", VA = "0x182061750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public GNLKPICAGOB EFOHGGJDBEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0x8B81A0", Offset = "0x8B69A0", VA = "0x1808B81A0")]
		get
		{
			return default(GNLKPICAGOB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0x2061470", Offset = "0x205FC70", VA = "0x182061470")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public long PHIAOLPJNLK
	{
		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0x20616F0", Offset = "0x205FEF0", VA = "0x1820616F0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600064B")]
	[Cpp2IlInjected.Address(RVA = "0x2061C80", Offset = "0x2060480", VA = "0x182061C80")]
	[UnityEngine.Scripting.Preserve]
	public JOBAJLNCBIL([JHPEMCNOMHI(null)] EPJPDLNCDIN GAPNJEJNFIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064C")]
	[Cpp2IlInjected.Address(RVA = "0x2060EE0", Offset = "0x205F6E0", VA = "0x182060EE0")]
	private void CIIJBEOIKMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(RVA = "0x2061830", Offset = "0x2060030", VA = "0x182061830")]
	public void MGDODJBJMLI(long AFGKPOPONBN, long OFFAGGOPNOB, [Optional] long? DFOMHFMOJCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(RVA = "0x2061790", Offset = "0x205FF90", VA = "0x182061790")]
	public void MCINLIANOJE(long DFOMHFMOJCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(RVA = "0x2061610", Offset = "0x205FE10", VA = "0x182061610")]
	public void FCOCJJNLDGE(string COLAHBLLFMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(RVA = "0x20610F0", Offset = "0x205F8F0", VA = "0x1820610F0")]
	public void DLELCHEGNKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016C")]
internal sealed class COOJADFPDLG : JKCDDAOJCAB
{
	[Cpp2IlInjected.Token(Token = "0x200016D")]
	[CompilerGenerated]
	private sealed class EDCLGBLPKON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006D9")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public EDCLGBLPKON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0x2665C20", Offset = "0x2664420", VA = "0x182665C20")]
		internal object DCAPKAENBHC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016E")]
	[CompilerGenerated]
	private sealed class JJDLFCKCIDK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006DA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006DB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006DC")]
		public DOLCNHODOEC operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006DD")]
		public CINMLNOINGA<string>.BIMPMJLMAHG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006DE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006DF")]
		public COOJADFPDLG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006E0")]
		private MCMNGPGPMDI <presence>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006E1")]
		private IEEHHHIAKBO <loadLogic>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006E2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006E3")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public JJDLFCKCIDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x2667710", Offset = "0x2665F10", VA = "0x182667710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[CompilerGenerated]
	private sealed class GDGFIACJFAL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006E5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006E6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006E7")]
		public COOJADFPDLG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006E8")]
		private byte <omSaveVersion>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x40006E9")]
		private bool <omShouldBeEnabled>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x42")]
		[Cpp2IlInjected.Token(Token = "0x40006EA")]
		private bool <omIsEnabled>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x43")]
		[Cpp2IlInjected.Token(Token = "0x40006EB")]
		private byte <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006EC")]
		private TaskAwaiter<byte> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public GDGFIACJFAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x2667360", Offset = "0x2665B60", VA = "0x182667360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000170")]
	[CompilerGenerated]
	private sealed class FLCOCMABPOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006ED")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006EE")]
		public AsyncTaskMethodBuilder<byte> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006EF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006F0")]
		public COOJADFPDLG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006F1")]
		private ACEIDINIJDO <loadInfo>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006F2")]
		private JDPJAFEOEAF <subRoomSaveData>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006F3")]
		private JDPJAFEOEAF <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006F4")]
		private TaskAwaiter<JDPJAFEOEAF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public FLCOCMABPOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0x2666A10", Offset = "0x2665210", VA = "0x182666A10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000171")]
	[CompilerGenerated]
	private sealed class LOEGFMHFIEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006F5")]
		public MCMNGPGPMDI presence;

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public LOEGFMHFIEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0x266CA00", Offset = "0x266B200", VA = "0x18266CA00")]
		internal object FNIFAMMKIFG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40006D4")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.Token(Token = "0x40006D5")]
	private static readonly JNGNMMOLKFF FHEDCPDJOCG;

	[Cpp2IlInjected.Token(Token = "0x40006D6")]
	private static readonly JNGNMMOLKFF EILJILOGCEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40006D7")]
	private readonly ACEIDINIJDO CNDNBAHLIMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40006D8")]
	private readonly EIEEEHDKLAP EKGJMJOMMAG;

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(RVA = "0x2049A80", Offset = "0x2048280", VA = "0x182049A80")]
	public COOJADFPDLG(ACEIDINIJDO CNDNBAHLIMJ, EIEEEHDKLAP EKGJMJOMMAG, Guid GMIOJDLOGJD, IBHEBOMOMMF KPGFDADNAJA, KODFOCGBOAL JACMAPKOKAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(RVA = "0x20497D0", Offset = "0x2047FD0", VA = "0x1820497D0", Slot = "7")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JJDLFCKCIDK))]
	protected override Task LEKKIJPMDAF(DOLCNHODOEC HNPDANNACGJ, CINMLNOINGA<string>.BIMPMJLMAHG KOKOCCCLBFO, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x2049160", Offset = "0x2047960", VA = "0x182049160")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GDGFIACJFAL))]
	protected Task EKABLNLPGLL(CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(RVA = "0x20492B0", Offset = "0x2047AB0", VA = "0x1820492B0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FLCOCMABPOO))]
	private Task<byte> HMDMKBGFGKI(CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(RVA = "0x2049420", Offset = "0x2047C20", VA = "0x182049420")]
	private MCMNGPGPMDI HOOBBHKBDPB()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000172")]
internal struct IIHNPFJADLN
{
	[Cpp2IlInjected.Token(Token = "0x2000173")]
	[CompilerGenerated]
	private sealed class KLLDCDNBKDM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006F6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006F7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006F8")]
		public IBHEBOMOMMF roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006F9")]
		public ALNDGPDOBOK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006FA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006FB")]
		private bool <isMaster>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006FC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public KLLDCDNBKDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x36ECC60", Offset = "0x36EB460", VA = "0x1836ECC60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0x205F6A0", Offset = "0x205DEA0", VA = "0x18205F6A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KLLDCDNBKDM))]
	public static Task JELDACCCIFL(IBHEBOMOMMF KPGFDADNAJA, ALNDGPDOBOK NFBDMLCENEN, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000174")]
internal struct PDJJFLHHGLC
{
	[Cpp2IlInjected.Token(Token = "0x2000175")]
	[CompilerGenerated]
	private sealed class KHCCBIMOHAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000702")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000703")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000704")]
		public PDJJFLHHGLC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000705")]
		private IMCPBFMNMJE <sceneLocation>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000706")]
		private CINMLNOINGA<string>.BIMPMJLMAHG <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000707")]
		private string <sceneName>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000708")]
		private Scene <mainScene>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000709")]
		private Scene <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400070A")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public KHCCBIMOHAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x536A3E0", Offset = "0x5368BE0", VA = "0x18536A3E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000176")]
	[CompilerGenerated]
	private sealed class LAFILOHMMGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400070B")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public LAFILOHMMGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0x536AA20", Offset = "0x5369220", VA = "0x18536AA20")]
		internal object OHAPGEPIJFI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000177")]
	[CompilerGenerated]
	private sealed class OCDCGLLLLFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400070C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400070D")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400070E")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400070F")]
		public PDJJFLHHGLC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000710")]
		private LAFILOHMMGH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000711")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000712")]
		private FJHOBEDEPPG <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000713")]
		private Scene <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000714")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public OCDCGLLLLFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x536C7D0", Offset = "0x536AFD0", VA = "0x18536C7D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006FD")]
	private IMCPBFMNMJE BKFNODIDMIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40006FE")]
	private CINMLNOINGA<string>.BIMPMJLMAHG FMGNKDAMMIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006FF")]
	private IBHEBOMOMMF KPGFDADNAJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000700")]
	private bool LPFJFIKNCNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000701")]
	private ALNDGPDOBOK NFBDMLCENEN;

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(RVA = "0x2677E50", Offset = "0x2676650", VA = "0x182677E50")]
	public static Task<Scene> DHCCEFKFNHG(IBHEBOMOMMF KPGFDADNAJA, IMCPBFMNMJE POGFBJGKIIH, CINMLNOINGA<string>.BIMPMJLMAHG FMGNKDAMMIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(RVA = "0x2677C30", Offset = "0x2676430", VA = "0x182677C30")]
	public static Task<Scene> ACOCDAAFFOB(IBHEBOMOMMF KPGFDADNAJA, ALNDGPDOBOK NFBDMLCENEN, CINMLNOINGA<string>.BIMPMJLMAHG FMGNKDAMMIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(RVA = "0x2677F40", Offset = "0x2676740", VA = "0x182677F40")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KHCCBIMOHAM))]
	private Task<Scene> JELDACCCIFL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(RVA = "0x26780A0", Offset = "0x26768A0", VA = "0x1826780A0")]
	private bool LCALJNJMOAP(ALNDGPDOBOK NFBDMLCENEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(RVA = "0x2677ED0", Offset = "0x26766D0", VA = "0x182677ED0")]
	private void HEDMFPJHALC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(RVA = "0x2677CD0", Offset = "0x26764D0", VA = "0x182677CD0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OCDCGLLLLFC))]
	private Task<Scene> AHCDNDDOIOM(string EOFLALLFEDN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000178")]
public abstract class IFCGGPDAEEN<T> where T : IFCGGPDAEEN<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000715")]
	internal readonly IBHEBOMOMMF KFBPIFANLHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000716")]
	private int? DBCCLFCGMCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000717")]
	protected readonly Guid POLNAEAIDMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000718")]
	protected readonly OPKDCMBHPLN JOODMOOHAKN;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	protected T NONPGAFNFEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x19D64A0", Offset = "0x19D4CA0", VA = "0x1819D64A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000677")]
	[Cpp2IlInjected.Address(RVA = "0x19D6760", Offset = "0x19D4F60", VA = "0x1819D6760")]
	internal IFCGGPDAEEN(IBHEBOMOMMF NEKLGMKJEBO, OPKDCMBHPLN MHMGOHONFHF, [Optional] Guid? GMIOJDLOGJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000678")]
	[Cpp2IlInjected.Address(RVA = "0x19D63B0", Offset = "0x19D4BB0", VA = "0x1819D63B0")]
	private GHGLDBKCJPG HAEDKJMLCHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000679")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "4")]
	protected virtual void KJNJCHDKFAO(GHGLDBKCJPG AKADEFDGONP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067A")]
	[Cpp2IlInjected.Address(RVA = "0x19D6500", Offset = "0x19D4D00", VA = "0x1819D6500")]
	public T LHDJABINBJF(BNKEEFOCAMM KIHPDBAJKAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600067B")]
	[Cpp2IlInjected.Address(RVA = "0x19D66E0", Offset = "0x19D4EE0", VA = "0x1819D66E0")]
	public T PDPJAONMLHK(int CEIABLADNLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600067C")]
	[Cpp2IlInjected.Address(RVA = "0x19D65E0", Offset = "0x19D4DE0", VA = "0x1819D65E0", Slot = "5")]
	public virtual Task<LIHOBIGHABN> OGJKKNGLNPB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000179")]
public class DEENPPKGIPM : IFCGGPDAEEN<DEENPPKGIPM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000719")]
	private ACEIDINIJDO BKHMACKFNNF;

	[Cpp2IlInjected.Token(Token = "0x600067D")]
	[Cpp2IlInjected.Address(RVA = "0x204B3F0", Offset = "0x2049BF0", VA = "0x18204B3F0")]
	internal DEENPPKGIPM(IBHEBOMOMMF NEKLGMKJEBO, OPKDCMBHPLN MHMGOHONFHF, [Optional] Guid? GMIOJDLOGJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067E")]
	[Cpp2IlInjected.Address(RVA = "0x204B3D0", Offset = "0x2049BD0", VA = "0x18204B3D0")]
	public DEENPPKGIPM PKKAOGNIKOJ(ACEIDINIJDO BKHMACKFNNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600067F")]
	[Cpp2IlInjected.Address(RVA = "0x204B300", Offset = "0x2049B00", VA = "0x18204B300", Slot = "4")]
	protected override void KJNJCHDKFAO(GHGLDBKCJPG AKADEFDGONP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017A")]
public class CGACAFDDLHA : IFCGGPDAEEN<CGACAFDDLHA>
{
	[Cpp2IlInjected.Token(Token = "0x200017B")]
	internal enum NOGCIOOGGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x400071E")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400071F")]
		Disk,
		[Cpp2IlInjected.Token(Token = "0x4000720")]
		RecNet
	}

	[Cpp2IlInjected.Token(Token = "0x200017C")]
	[CompilerGenerated]
	private sealed class EFEAOBJJOGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000721")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000722")]
		public AsyncTaskMethodBuilder<LIHOBIGHABN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000723")]
		public CGACAFDDLHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000724")]
		private LIHOBIGHABN <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000725")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000726")]
		private TaskAwaiter<LIHOBIGHABN> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public EFEAOBJJOGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x2665CF0", Offset = "0x26644F0", VA = "0x182665CF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400071A")]
	private NOGCIOOGGOJ ELPCFDMIHHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400071B")]
	private string NJNNNMGEIGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400071C")]
	private FPDNLDMDEKC BKHMACKFNNF;

	[Cpp2IlInjected.Token(Token = "0x6000680")]
	[Cpp2IlInjected.Address(RVA = "0x2045F10", Offset = "0x2044710", VA = "0x182045F10")]
	internal CGACAFDDLHA(IBHEBOMOMMF NEKLGMKJEBO, OPKDCMBHPLN MHMGOHONFHF, [Optional] Guid? GMIOJDLOGJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000681")]
	[Cpp2IlInjected.Address(RVA = "0x2045B50", Offset = "0x2044350", VA = "0x182045B50")]
	public CGACAFDDLHA BNKCCFCLJCP(string PNEPJANIHCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000682")]
	[Cpp2IlInjected.Address(RVA = "0x2045B80", Offset = "0x2044380", VA = "0x182045B80")]
	public CGACAFDDLHA BOILEIAJFGK(bool MNKIMOEKEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000683")]
	[Cpp2IlInjected.Address(RVA = "0x2045D90", Offset = "0x2044590", VA = "0x182045D90")]
	public CGACAFDDLHA OBHDBFPDFJB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000684")]
	[Cpp2IlInjected.Address(RVA = "0x2045BB0", Offset = "0x20443B0", VA = "0x182045BB0")]
	public CGACAFDDLHA JOANGKOCDKA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000685")]
	[Cpp2IlInjected.Address(RVA = "0x2045BE0", Offset = "0x20443E0", VA = "0x182045BE0", Slot = "4")]
	protected override void KJNJCHDKFAO(GHGLDBKCJPG AKADEFDGONP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000686")]
	[Cpp2IlInjected.Address(RVA = "0x2045DC0", Offset = "0x20445C0", VA = "0x182045DC0", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EFEAOBJJOGA))]
	public override Task<LIHOBIGHABN> OGJKKNGLNPB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000687")]
	[Cpp2IlInjected.Address(RVA = "0x2045D50", Offset = "0x2044550", VA = "0x182045D50")]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task<LIHOBIGHABN> MNEEMHPPIBM()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200017D")]
internal struct POGGCAKBIOB
{
	[Cpp2IlInjected.Token(Token = "0x200017E")]
	[CompilerGenerated]
	private sealed class IOKAHOECLFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000727")]
		public CLKENBEKINM.KLEDDBBHAEL instantiations;

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public IOKAHOECLFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0x5369730", Offset = "0x5367F30", VA = "0x185369730")]
		internal object AIEPNMIPKAI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017F")]
	[CompilerGenerated]
	private sealed class AHJAACNINCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000728")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000729")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public AHJAACNINCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0x5366720", Offset = "0x5364F20", VA = "0x185366720")]
		internal object PGMBJJFBAJH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600068B")]
	[Cpp2IlInjected.Address(RVA = "0x267B200", Offset = "0x2679A00", VA = "0x18267B200")]
	public static void JELDACCCIFL(JKCDDAOJCAB IKBOIGIEDJD, ALNDGPDOBOK NFBDMLCENEN, CLKENBEKINM.KLEDDBBHAEL PNIIEKIBDLE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000180")]
internal struct CLKENBEKINM
{
	[Cpp2IlInjected.Token(Token = "0x2000181")]
	public struct KLEDDBBHAEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400072C")]
		public List<MIGDMEODDAL> INBGALGGHPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400072D")]
		public List<GPPNCPPLGEE> GEAEBAKIJKC;

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0xB84550", Offset = "0xB82D50", VA = "0x180B84550")]
		public KLEDDBBHAEL(List<MIGDMEODDAL> INBGALGGHPP, List<GPPNCPPLGEE> GEAEBAKIJKC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000182")]
	[CompilerGenerated]
	private sealed class MNLDOEOGDCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400072E")]
		public IEnumerable<MIGDMEODDAL> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public MNLDOEOGDCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x266F970", Offset = "0x266E170", VA = "0x18266F970")]
		internal object PAGMPBMEJIO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400072A")]
	private IBHEBOMOMMF KPGFDADNAJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400072B")]
	private ALNDGPDOBOK NFBDMLCENEN;

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private CABGPNHLHHJ BKEEIANIHAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0x20487E0", Offset = "0x2046FE0", VA = "0x1820487E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000690")]
	[Cpp2IlInjected.Address(RVA = "0x2048830", Offset = "0x2047030", VA = "0x182048830")]
	public static KLEDDBBHAEL JELDACCCIFL(IBHEBOMOMMF KPGFDADNAJA, ALNDGPDOBOK NFBDMLCENEN)
	{
		return default(KLEDDBBHAEL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000692")]
	[Cpp2IlInjected.Address(RVA = "0x20488A0", Offset = "0x20470A0", VA = "0x1820488A0")]
	private KLEDDBBHAEL JELDACCCIFL()
	{
		return default(KLEDDBBHAEL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000693")]
	[Cpp2IlInjected.Address(RVA = "0x2048090", Offset = "0x2046890", VA = "0x182048090")]
	private KLEDDBBHAEL AJBEKNICBKN(KHHPFHOAEJL FINJDDGCGDL, MIKHCJJNMEJ MKLKDNDCMFI)
	{
		return default(KLEDDBBHAEL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000694")]
	[Cpp2IlInjected.Address(RVA = "0x2048600", Offset = "0x2046E00", VA = "0x182048600")]
	private bool BPFFGMEAJKI(IEnumerable<MIGDMEODDAL> INBGALGGHPP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000183")]
internal struct HICHNBMIAID
{
	[Cpp2IlInjected.Token(Token = "0x2000184")]
	[CompilerGenerated]
	private sealed class LEIGDIKMOOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000733")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000734")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000735")]
		public HICHNBMIAID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000736")]
		private bool <stopOnEmptyScene>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000737")]
		private string <preloadSceneName>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000738")]
		private CINMLNOINGA<string>.BIMPMJLMAHG <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000739")]
		private CINMLNOINGA<string>.BIMPMJLMAHG <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400073A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400073B")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public LEIGDIKMOOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(RVA = "0x36EE210", Offset = "0x36ECA10", VA = "0x1836EE210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000185")]
	[CompilerGenerated]
	private sealed class ILICENAHCEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400073C")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400073D")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public ILICENAHCEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0x36EA8D0", Offset = "0x36E90D0", VA = "0x1836EA8D0")]
		internal object OHAPGEPIJFI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000186")]
	[CompilerGenerated]
	private sealed class NPHJOPCJGKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400073E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400073F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000740")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000741")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000742")]
		public HICHNBMIAID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000743")]
		private ILICENAHCEC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000744")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000745")]
		private FJHOBEDEPPG <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000746")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public NPHJOPCJGKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0x36F1E00", Offset = "0x36F0600", VA = "0x1836F1E00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400072F")]
	private bool JBIKPBLAKHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000730")]
	private CINMLNOINGA<string>.BIMPMJLMAHG FMGNKDAMMIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000731")]
	private IBHEBOMOMMF KPGFDADNAJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000732")]
	private CancellationToken NNLBJPBEHPF;

	[Cpp2IlInjected.Token(Token = "0x6000698")]
	[Cpp2IlInjected.Address(RVA = "0x205C4B0", Offset = "0x205ACB0", VA = "0x18205C4B0")]
	public static Task JKBJEGHPCOK(IBHEBOMOMMF KPGFDADNAJA, bool JBIKPBLAKHC, CINMLNOINGA<string>.BIMPMJLMAHG FMGNKDAMMIM, CancellationToken PJHDGNKPEHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000699")]
	[Cpp2IlInjected.Address(RVA = "0x205C380", Offset = "0x205AB80", VA = "0x18205C380")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LEIGDIKMOOH))]
	private Task JELDACCCIFL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600069A")]
	[Cpp2IlInjected.Address(RVA = "0x205C210", Offset = "0x205AA10", VA = "0x18205C210")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NPHJOPCJGKF))]
	private Task AHCDNDDOIOM(bool EMBCONAHFKN, string EOFLALLFEDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600069B")]
	[Cpp2IlInjected.Address(RVA = "0x8A3C30", Offset = "0x8A2430", VA = "0x1808A3C30")]
	private bool EHEINMLAKFL(bool JBIKPBLAKHC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000187")]
internal struct LPNELAFLFMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000747")]
	public readonly JEELLOGMCHC GMEHCBDKOIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000748")]
	public readonly CKNKGBNGABP DDCPBKKGAOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000749")]
	public readonly string MOPJJOOHADC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400074A")]
	public readonly CENNEHOCJAK GGGHMACDDAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400074B")]
	public readonly CENNEHOCJAK BLJOCIDGDDI;

	[Cpp2IlInjected.Token(Token = "0x60006A4")]
	[Cpp2IlInjected.Address(RVA = "0x266CB40", Offset = "0x266B340", VA = "0x18266CB40")]
	public LPNELAFLFMK(JEELLOGMCHC GMEHCBDKOIL, CKNKGBNGABP DDCPBKKGAOI, string MOPJJOOHADC, CENNEHOCJAK GGGHMACDDAC, CENNEHOCJAK BLJOCIDGDDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000188")]
internal sealed class JLOOCMHIIPI : FCLOIGABHLH
{
	[Cpp2IlInjected.Token(Token = "0x2000189")]
	[CompilerGenerated]
	private sealed class HLDHKBICMEK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400074D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400074E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400074F")]
		public DOLCNHODOEC operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000750")]
		public CINMLNOINGA<string>.BIMPMJLMAHG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000751")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000752")]
		public JLOOCMHIIPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000753")]
		private COMIIGGELLE <roomEvent>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000754")]
		private IEEHHHIAKBO <loadLogic>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000755")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public HLDHKBICMEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(RVA = "0x36E9DB0", Offset = "0x36E85B0", VA = "0x1836E9DB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400074C")]
	private readonly ACEIDINIJDO PKGBINILALI;

	[Cpp2IlInjected.Token(Token = "0x60006A5")]
	[Cpp2IlInjected.Address(RVA = "0x2060C90", Offset = "0x205F490", VA = "0x182060C90")]
	public JLOOCMHIIPI(Guid GMIOJDLOGJD, IBHEBOMOMMF KPGFDADNAJA, ACEIDINIJDO PKGBINILALI, KODFOCGBOAL JACMAPKOKAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A6")]
	[Cpp2IlInjected.Address(RVA = "0x2060AF0", Offset = "0x205F2F0", VA = "0x182060AF0", Slot = "8")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HLDHKBICMEK))]
	protected override Task GPAMFCMMDKM(DOLCNHODOEC HNPDANNACGJ, CINMLNOINGA<string>.BIMPMJLMAHG KOKOCCCLBFO, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200018A")]
internal struct IOIAPGNAEGC
{
	[Cpp2IlInjected.Token(Token = "0x60006AA")]
	[Cpp2IlInjected.Address(RVA = "0x205E820", Offset = "0x205D020", VA = "0x18205E820")]
	public static Task JELDACCCIFL(CancellationToken NNLBJPBEHPF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018B")]
internal struct PEANNFINBBH
{
	[Cpp2IlInjected.Token(Token = "0x200018C")]
	[CompilerGenerated]
	private sealed class CFGJMOHCIPG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400075A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400075B")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400075C")]
		public IBHEBOMOMMF roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400075D")]
		public ALNDGPDOBOK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400075E")]
		public DOLCNHODOEC operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400075F")]
		public CINMLNOINGA<string>.BIMPMJLMAHG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000760")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000761")]
		private bool <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000762")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public CFGJMOHCIPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0x5367500", Offset = "0x5365D00", VA = "0x185367500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018D")]
	[CompilerGenerated]
	private sealed class BDGKKFHGNOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000763")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000764")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000765")]
		public CINMLNOINGA<string>.BIMPMJLMAHG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000766")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000767")]
		public PEANNFINBBH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000768")]
		private IDisposable <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000769")]
		private bool <shouldObjectModelBeEnabled>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x69")]
		[Cpp2IlInjected.Token(Token = "0x400076A")]
		private bool <isOMFlagChanging>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6A")]
		[Cpp2IlInjected.Token(Token = "0x400076B")]
		private bool <reloadSceneForObjectModel>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400076C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public BDGKKFHGNOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x5366D40", Offset = "0x5365540", VA = "0x185366D40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000756")]
	private IBHEBOMOMMF KPGFDADNAJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000757")]
	private ALNDGPDOBOK NFBDMLCENEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000758")]
	private ByteString BHKNJJPGGCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000759")]
	private DOLCNHODOEC HNPDANNACGJ;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	private CABGPNHLHHJ BKEEIANIHAB
	{
		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0x26788D0", Offset = "0x26770D0", VA = "0x1826788D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	private bool CIJODPOALCI
	{
		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(RVA = "0x2678920", Offset = "0x2677120", VA = "0x182678920")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	private bool HKMBPJFLFKG
	{
		[Cpp2IlInjected.Token(Token = "0x60006AE")]
		[Cpp2IlInjected.Address(RVA = "0x26789A0", Offset = "0x26771A0", VA = "0x1826789A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006AB")]
	[Cpp2IlInjected.Address(RVA = "0x2678CA0", Offset = "0x26774A0", VA = "0x182678CA0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CFGJMOHCIPG))]
	public static Task<bool> JELDACCCIFL(IBHEBOMOMMF KPGFDADNAJA, ALNDGPDOBOK NFBDMLCENEN, DOLCNHODOEC HNPDANNACGJ, CINMLNOINGA<string>.BIMPMJLMAHG KOKOCCCLBFO, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AF")]
	[Cpp2IlInjected.Address(RVA = "0x2678B00", Offset = "0x2677300", VA = "0x182678B00")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BDGKKFHGNOK))]
	private Task<bool> JELDACCCIFL(CINMLNOINGA<string>.BIMPMJLMAHG KOKOCCCLBFO, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018E")]
public static class KGEPNNCKMPB
{
	[Cpp2IlInjected.Token(Token = "0x60006B6")]
	[Cpp2IlInjected.Address(RVA = "0x2667E80", Offset = "0x2666680", VA = "0x182667E80")]
	public static CENNEHOCJAK OLBBPLCIGEL(this EJCPPDBCICE DBJHLFILLOC)
	{
		return default(CENNEHOCJAK);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B7")]
	[Cpp2IlInjected.Address(RVA = "0x2667DC0", Offset = "0x26665C0", VA = "0x182667DC0")]
	public static EJCPPDBCICE HLDLCNJPKOH(this CENNEHOCJAK MFAKEHLPKPD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018F")]
internal class PBKLDGAICIL : FPFMDBHMGLL
{
	[Cpp2IlInjected.Token(Token = "0x2000190")]
	[CompilerGenerated]
	private sealed class KKODNINPNHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000770")]
		public OJEPPNBNJAH.PIOMGEMFMGO roomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public KKODNINPNHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0x536A9D0", Offset = "0x53691D0", VA = "0x18536A9D0")]
		internal object ENCFHMEBLPA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000191")]
	[CompilerGenerated]
	private sealed class NDCJDEDGNKG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000771")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000772")]
		public AsyncTaskMethodBuilder<(OJEPPNBNJAH.PIOMGEMFMGO roomDataUpload, OJEPPNBNJAH.PIOMGEMFMGO subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000773")]
		public OOGLJJBDKMP roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000774")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000775")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000776")]
		public PBKLDGAICIL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000777")]
		private KKODNINPNHK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000778")]
		private byte[] <data>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000779")]
		private float <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400077A")]
		private PKMIHDKHPIO <roomMetadata>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400077B")]
		private OJEPPNBNJAH.PIOMGEMFMGO <subRoomDataUpload>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400077C")]
		private OJEPPNBNJAH.PIOMGEMFMGO <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400077D")]
		private OJEPPNBNJAH.PIOMGEMFMGO <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400077E")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400077F")]
		private TaskAwaiter<OJEPPNBNJAH.PIOMGEMFMGO> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public NDCJDEDGNKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(RVA = "0x536B630", Offset = "0x5369E30", VA = "0x18536B630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000192")]
	[CompilerGenerated]
	private sealed class MOHKLAMOCAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000780")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000781")]
		public AsyncTaskMethodBuilder<JHAJGBINBJN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000782")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000783")]
		public FPDNLDMDEKC roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000784")]
		public OOGLJJBDKMP roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000785")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000786")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000787")]
		public PBKLDGAICIL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000788")]
		private OJEPPNBNJAH.PIOMGEMFMGO <roomDataUpload>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000789")]
		private OJEPPNBNJAH.PIOMGEMFMGO <subRoomDataUpload>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400078A")]
		private int <persistenceVersion>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400078B")]
		private bool <objectModelEnabledInSave>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x85")]
		[Cpp2IlInjected.Token(Token = "0x400078C")]
		private byte <omVersion>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400078D")]
		private OEKAHMNFJPC <request>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400078E")]
		private JHAJGBINBJN <response>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400078F")]
		private (OJEPPNBNJAH.PIOMGEMFMGO roomDataUpload, OJEPPNBNJAH.PIOMGEMFMGO subRoomDataUpload) <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000790")]
		private (OJEPPNBNJAH.PIOMGEMFMGO roomDataUpload, OJEPPNBNJAH.PIOMGEMFMGO subRoomDataUpload) <>s__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000791")]
		private JHAJGBINBJN <>s__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000792")]
		private TaskAwaiter<(OJEPPNBNJAH.PIOMGEMFMGO roomDataUpload, OJEPPNBNJAH.PIOMGEMFMGO subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000793")]
		private TaskAwaiter<JHAJGBINBJN> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public MOHKLAMOCAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0x536AE50", Offset = "0x5369650", VA = "0x18536AE50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C6")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000193")]
	[CompilerGenerated]
	private sealed class PDIDNCGAJAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000794")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000795")]
		public AsyncTaskMethodBuilder<FGPPKDDGLJL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000796")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000797")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000798")]
		public OOGLJJBDKMP roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000799")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400079A")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400079B")]
		public PBKLDGAICIL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400079C")]
		private OJEPPNBNJAH.PIOMGEMFMGO <roomDataUpload>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400079D")]
		private OJEPPNBNJAH.PIOMGEMFMGO <subRoomDataUpload>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400079E")]
		private FGPPKDDGLJL <remoteRunDetails>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400079F")]
		private (OJEPPNBNJAH.PIOMGEMFMGO roomDataUpload, OJEPPNBNJAH.PIOMGEMFMGO subRoomDataUpload) <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40007A0")]
		private (OJEPPNBNJAH.PIOMGEMFMGO roomDataUpload, OJEPPNBNJAH.PIOMGEMFMGO subRoomDataUpload) <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40007A1")]
		private FGPPKDDGLJL <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40007A2")]
		private TaskAwaiter<(OJEPPNBNJAH.PIOMGEMFMGO roomDataUpload, OJEPPNBNJAH.PIOMGEMFMGO subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40007A3")]
		private TaskAwaiter<FGPPKDDGLJL> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public PDIDNCGAJAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0x536CEC0", Offset = "0x536B6C0", VA = "0x18536CEC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000194")]
	[CompilerGenerated]
	private sealed class OCAOEDOOJEI
	{
		[Cpp2IlInjected.Token(Token = "0x2000195")]
		private sealed class <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007AC")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007AD")]
			public AsyncTaskMethodBuilder<GHGLDBKCJPG> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007AE")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40007AF")]
			public OCAOEDOOJEI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40007B0")]
			private GHGLDBKCJPG <reloadMessage>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40007B1")]
			private RepeatedField<GPPNCPPLGEE> <persistenceViewsOpt>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40007B2")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67FB10", Offset = "0x67EF10")]
			private IEnumerable<GPPNCPPLGEE> <persistenceViews>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40007B3")]
			private bool <couldSaveLocalRoomData>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
			[Cpp2IlInjected.Token(Token = "0x40007B4")]
			private bool <>s__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40007B5")]
			private FGPPKDDGLJL <remoteRunDetails>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40007B6")]
			private FGPPKDDGLJL <>s__7;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40007B7")]
			private JHAJGBINBJN <saveDetails>5__8;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40007B8")]
			private JHAJGBINBJN <>s__9;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40007B9")]
			private GHGLDBKCJPG <>s__10;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40007BA")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40007BB")]
			private TaskAwaiter<FGPPKDDGLJL> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40007BC")]
			private TaskAwaiter<JHAJGBINBJN> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40007BD")]
			private TaskAwaiter<GHGLDBKCJPG> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60006CC")]
			[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
			public <<UploadRoomDataBlobAndSyncReload>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006CD")]
			[Cpp2IlInjected.Address(RVA = "0x5370990", Offset = "0x536F190", VA = "0x185370990", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006CE")]
			[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007A4")]
		public PBKLDGAICIL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007A5")]
		public OOGLJJBDKMP roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007A6")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007A7")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007A8")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40007A9")]
		public FPDNLDMDEKC roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40007AA")]
		public CGHJAIDDPDJ roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40007AB")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67FA50", Offset = "0x67EE50")]
		public CINMLNOINGA<string>.BIMPMJLMAHG stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public OCAOEDOOJEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0x536C660", Offset = "0x536AE60", VA = "0x18536C660")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<GHGLDBKCJPG> HHNHEKOKMJG(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000196")]
	[CompilerGenerated]
	private sealed class IKMGKNBOAFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007BE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007BF")]
		public AsyncTaskMethodBuilder<GHGLDBKCJPG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007C0")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007C1")]
		public FPDNLDMDEKC roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007C2")]
		public OOGLJJBDKMP roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40007C3")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40007C4")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40007C5")]
		public CGHJAIDDPDJ roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40007C6")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67FB70", Offset = "0x67EF70")]
		public CINMLNOINGA<string>.BIMPMJLMAHG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40007C7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40007C8")]
		public PBKLDGAICIL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40007C9")]
		private OCAOEDOOJEI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40007CA")]
		private GHGLDBKCJPG <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40007CB")]
		private TaskAwaiter<GHGLDBKCJPG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public IKMGKNBOAFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0x53692F0", Offset = "0x5367AF0", VA = "0x1853692F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400076D")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.Token(Token = "0x400076E")]
	private static readonly JNGNMMOLKFF FHEDCPDJOCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400076F")]
	private readonly ICPCKOBFFHD CPLKMBECHHE;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	private IBHEBOMOMMF PPOLOGJINGO
	{
		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0x205E1B0", Offset = "0x205C9B0", VA = "0x18205E1B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006B9")]
	[Cpp2IlInjected.Address(RVA = "0x2677250", Offset = "0x2675A50", VA = "0x182677250")]
	public PBKLDGAICIL(DOLCNHODOEC HNPDANNACGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BA")]
	[Cpp2IlInjected.Address(RVA = "0x2676980", Offset = "0x2675180", VA = "0x182676980")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NDCJDEDGNKG))]
	private Task<(OJEPPNBNJAH.PIOMGEMFMGO, OJEPPNBNJAH.PIOMGEMFMGO)> DENCDEIJIDE(OOGLJJBDKMP FHNPDPEPPGC, long AFGKPOPONBN, long HILPLFHHAPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006BB")]
	[Cpp2IlInjected.Address(RVA = "0x2676B40", Offset = "0x2675340", VA = "0x182676B40")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MOHKLAMOCAM))]
	public Task<JHAJGBINBJN> JGHPKHKPDKH(int PBBACJMGNAB, [CanBeNull] FPDNLDMDEKC OAFCKBHKKJO, OOGLJJBDKMP FHNPDPEPPGC, long AFGKPOPONBN, long HILPLFHHAPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006BC")]
	[Cpp2IlInjected.Address(RVA = "0x2676D30", Offset = "0x2675530", VA = "0x182676D30")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PDIDNCGAJAK))]
	private Task<FGPPKDDGLJL> KBNPCLKBNHN(string ICCNANGPCBP, int PBBACJMGNAB, OOGLJJBDKMP FHNPDPEPPGC, long AFGKPOPONBN, long HILPLFHHAPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006BD")]
	[Cpp2IlInjected.Address(RVA = "0x2676F30", Offset = "0x2675730", VA = "0x182676F30")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IKMGKNBOAFD))]
	public Task<GHGLDBKCJPG> NOCAIENCMPB(int PBBACJMGNAB, FPDNLDMDEKC? OAFCKBHKKJO, OOGLJJBDKMP FHNPDPEPPGC, long AFGKPOPONBN, long HILPLFHHAPA, CGHJAIDDPDJ GHJJMKOKIIE, CINMLNOINGA<string>.BIMPMJLMAHG KOKOCCCLBFO, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000197")]
internal class DDGCNPIEIDL : FCLOIGABHLH
{
	[Cpp2IlInjected.Token(Token = "0x2000198")]
	[CompilerGenerated]
	private sealed class IGBPGNCIMBK
	{
		[Cpp2IlInjected.Token(Token = "0x2000199")]
		private sealed class <<RunWhilePlayerDespawnedAsync>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007D8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007D9")]
			public AsyncTaskMethodBuilder<GHGLDBKCJPG> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007DA")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40007DB")]
			public IGBPGNCIMBK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40007DC")]
			private OOGLJJBDKMP <data>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40007DD")]
			private GHGLDBKCJPG <reloadMsg>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40007DE")]
			private OOGLJJBDKMP <>s__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40007DF")]
			private GHGLDBKCJPG <>s__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40007E0")]
			private TaskAwaiter<OOGLJJBDKMP> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40007E1")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67FD00", Offset = "0x67F100")]
			private TaskAwaiter<GHGLDBKCJPG> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60006DB")]
			[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
			public <<RunWhilePlayerDespawnedAsync>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006DC")]
			[Cpp2IlInjected.Address(RVA = "0x5370530", Offset = "0x536ED30", VA = "0x185370530", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006DD")]
			[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007D0")]
		public DDGCNPIEIDL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007D1")]
		public KGLPJJELOMN serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007D2")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007D3")]
		public FNOFEKPGFMA roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007D4")]
		public PBKLDGAICIL uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007D5")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40007D6")]
		public CGHJAIDDPDJ roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40007D7")]
		public CINMLNOINGA<string>.BIMPMJLMAHG stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public IGBPGNCIMBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x3DBF3C0", Offset = "0x3DBDBC0", VA = "0x183DBF3C0")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<GHGLDBKCJPG> EDJOGENLLDA(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200019A")]
	[CompilerGenerated]
	private sealed class BOJLEIGCOAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007E2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007E3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007E4")]
		public DOLCNHODOEC operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007E5")]
		public CINMLNOINGA<string>.BIMPMJLMAHG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007E6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40007E7")]
		public DDGCNPIEIDL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40007E8")]
		private IGBPGNCIMBK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40007E9")]
		private COMIIGGELLE <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40007EA")]
		private JDPJAFEOEAF <currentRoomSave>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40007EB")]
		private long <loadedSubroomSaveId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40007EC")]
		private bool <currentLoadedSaveIsPublished>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40007ED")]
		private IEEHHHIAKBO <loadLogic>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40007EE")]
		private GHGLDBKCJPG <saveReloadMessage>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40007EF")]
		private bool <omEnabledChanged>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40007F0")]
		private GHGLDBKCJPG <>s__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40007F1")]
		private Exception <ex>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40007F2")]
		private bool <>s__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40007F3")]
		private TaskAwaiter<GHGLDBKCJPG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40007F4")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40007F5")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public BOJLEIGCOAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x2663460", Offset = "0x2661C60", VA = "0x182663460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200019B")]
	[CompilerGenerated]
	private sealed class HGEMAFIGJJM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007F6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007F7")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007F8")]
		public ACEIDINIJDO loadInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007F9")]
		public CINMLNOINGA<string>.BIMPMJLMAHG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007FA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40007FB")]
		public DDGCNPIEIDL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40007FC")]
		private JDPJAFEOEAF <subRoomSaveData>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40007FD")]
		private bool <omShouldBeEnabled>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
		[Cpp2IlInjected.Token(Token = "0x40007FE")]
		private bool <omIsEnabled>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
		[Cpp2IlInjected.Token(Token = "0x40007FF")]
		private bool <omEnabledChanged>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000800")]
		private JDPJAFEOEAF <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000801")]
		private TaskAwaiter<JDPJAFEOEAF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000802")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public HGEMAFIGJJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x3DBE870", Offset = "0x3DBD070", VA = "0x183DBE870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40007CC")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.Token(Token = "0x40007CD")]
	private static readonly JNGNMMOLKFF FHEDCPDJOCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40007CE")]
	private readonly int PBBACJMGNAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40007CF")]
	[CanBeNull]
	private readonly FPDNLDMDEKC OAFCKBHKKJO;

	[Cpp2IlInjected.Token(Token = "0x60006D2")]
	[Cpp2IlInjected.Address(RVA = "0x204AC50", Offset = "0x2049450", VA = "0x18204AC50")]
	public DDGCNPIEIDL(Guid GMIOJDLOGJD, IBHEBOMOMMF KPGFDADNAJA, int PBBACJMGNAB, FPDNLDMDEKC OAFCKBHKKJO, KODFOCGBOAL JACMAPKOKAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D3")]
	[Cpp2IlInjected.Address(RVA = "0x204A800", Offset = "0x2049000", VA = "0x18204A800", Slot = "8")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BOJLEIGCOAA))]
	protected override Task GPAMFCMMDKM(DOLCNHODOEC HNPDANNACGJ, CINMLNOINGA<string>.BIMPMJLMAHG KOKOCCCLBFO, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D4")]
	[Cpp2IlInjected.Address(RVA = "0x204A3F0", Offset = "0x2048BF0", VA = "0x18204A3F0")]
	private void BOAPBJPJICB(bool EIKIFFBKJBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D5")]
	[Cpp2IlInjected.Address(RVA = "0x204A9A0", Offset = "0x20491A0", VA = "0x18204A9A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HGEMAFIGJJM))]
	protected Task<bool> LCHKPFNDNLN(ACEIDINIJDO COMGOIIMJEE, CINMLNOINGA<string>.BIMPMJLMAHG KOKOCCCLBFO, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D6")]
	[Cpp2IlInjected.Address(RVA = "0x204A560", Offset = "0x2048D60", VA = "0x18204A560")]
	private void EEKCECEAEPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D7")]
	[Cpp2IlInjected.Address(RVA = "0x204A660", Offset = "0x2048E60", VA = "0x18204A660")]
	private void GKKFECLHBGB(CINMLNOINGA<string>.BIMPMJLMAHG KOKOCCCLBFO, COMIIGGELLE CAHMLNACFAI)
	{
	}
}
namespace RecRoom.RoomLoading.RoomOperation.Validation
{
	[Cpp2IlInjected.Token(Token = "0x200019C")]
	public class ValidationResultConfig : ScriptableObject, ISerializationCallbackReceiver
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200019D")]
		public class ResultConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000806")]
			public IFCFBFPLHLH ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000807")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000808")]
			public IFCFBFPLHLH HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000809")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400080A")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400080B")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x60006EA")]
			[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000803")]
		private static IFCFBFPLHLH[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000804")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000805")]
		private Dictionary<IFCFBFPLHLH, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x267C440", Offset = "0x267AC40", VA = "0x18267C440")]
		public bool DHIBBBBLDDD(IFCFBFPLHLH FDEHONHEHII, out ResultConfig GGGECKCCDMK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0x267C330", Offset = "0x267AB30", VA = "0x18267C330")]
		public ResultConfig BNLMBCCIBLJ(IFCFBFPLHLH LLLABGDENCM, [Optional] HashSet<IFCFBFPLHLH> LMBBIDMHJEK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0x267CA20", Offset = "0x267B220", VA = "0x18267CA20", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x267C4B0", Offset = "0x267ACB0", VA = "0x18267C4B0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0x9176C0", Offset = "0x915EC0", VA = "0x1809176C0")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200019F")]
public class JGKCJOEACBD : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60006F1")]
	[Cpp2IlInjected.Address(RVA = "0x205FEC0", Offset = "0x205E6C0", VA = "0x18205FEC0")]
	public JGKCJOEACBD(string AKADEFDGONP, Exception JAOHDAGFJEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A0")]
public class IHMOKOKMEFB
{
	[Cpp2IlInjected.Token(Token = "0x20001A1")]
	private sealed class GDJEGLGMBKC : AMPLJNEEHDI, IEquatable<AMPLJNEEHDI>
	{
		[Cpp2IlInjected.Token(Token = "0x20001A2")]
		[CompilerGenerated]
		private sealed class PEBPDPLJICF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000818")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000819")]
			public AsyncTaskMethodBuilder<LIHOBIGHABN> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400081A")]
			public GDJEGLGMBKC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400081B")]
			private PDMJIAEOMIP <roomManager>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400081C")]
			private JEELLOGMCHC <newRoomDetails>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400081D")]
			private ACEIDINIJDO <roomLoadRequestPayload>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400081E")]
			private JEELLOGMCHC <>s__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400081F")]
			private LIHOBIGHABN <>s__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000820")]
			private TaskAwaiter<JEELLOGMCHC> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000821")]
			private TaskAwaiter<LIHOBIGHABN> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000702")]
			[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
			public PEBPDPLJICF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000703")]
			[Cpp2IlInjected.Address(RVA = "0x536D3E0", Offset = "0x536BBE0", VA = "0x18536D3E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000704")]
			[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000815")]
		private readonly JDPJAFEOEAF LALOLGFBNCN;

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public int LDNEDBPECPC
		{
			[Cpp2IlInjected.Token(Token = "0x60006F6")]
			[Cpp2IlInjected.Address(RVA = "0x90BAA0", Offset = "0x90A2A0", VA = "0x18090BAA0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public HPDPHGLDFIN GLBMHCAKNAI
		{
			[Cpp2IlInjected.Token(Token = "0x60006F7")]
			[Cpp2IlInjected.Address(RVA = "0x7EC6C0", Offset = "0x7EAEC0", VA = "0x1807EC6C0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		private DateTime ECMCCHJOLNF
		{
			[Cpp2IlInjected.Token(Token = "0x60006F8")]
			[Cpp2IlInjected.Address(RVA = "0x187A1D0", Offset = "0x18789D0", VA = "0x18187A1D0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		public FPFEIMEJDPP? IAHAOHABEFN
		{
			[Cpp2IlInjected.Token(Token = "0x60006F9")]
			[Cpp2IlInjected.Address(RVA = "0xCB86B0", Offset = "0xCB6EB0", VA = "0x180CB86B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		public ODJADAFJGIK? ADAJIBMPONK
		{
			[Cpp2IlInjected.Token(Token = "0x60006FA")]
			[Cpp2IlInjected.Address(RVA = "0x36E75E0", Offset = "0x36E5DE0", VA = "0x1836E75E0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		public AFCECGJNIAB HGGHBNLINJK
		{
			[Cpp2IlInjected.Token(Token = "0x60006FD")]
			[Cpp2IlInjected.Address(RVA = "0x7F0C80", Offset = "0x7EF480", VA = "0x1807F0C80", Slot = "10")]
			get
			{
				return default(AFCECGJNIAB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0x36E72C0", Offset = "0x36E5AC0", VA = "0x1836E72C0", Slot = "9")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(PEBPDPLJICF))]
		public Task<LIHOBIGHABN> EBFEIMHBMOO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0x36E7650", Offset = "0x36E5E50", VA = "0x1836E7650")]
		public GDJEGLGMBKC(int GKGDJDPABJE, HPDPHGLDFIN MOPIJFDNMEF, JDPJAFEOEAF LALOLGFBNCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0x36E74B0", Offset = "0x36E5CB0", VA = "0x1836E74B0", Slot = "11")]
		public bool Equals(AMPLJNEEHDI OALEAAIPGBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x36E7410", Offset = "0x36E5C10", VA = "0x1836E7410", Slot = "0")]
		public override bool Equals(object CEPDEAHBHLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x36E7600", Offset = "0x36E5E00", VA = "0x1836E7600")]
		private bool OCGPELPLBPE(GDJEGLGMBKC OALEAAIPGBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(RVA = "0x36E7550", Offset = "0x36E5D50", VA = "0x1836E7550", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A3")]
	private sealed class FNKNKBJGDKA : AMPLJNEEHDI, IEquatable<AMPLJNEEHDI>
	{
		[Cpp2IlInjected.Token(Token = "0x20001A4")]
		[CompilerGenerated]
		private sealed class JEDKNBIDCDL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000825")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000826")]
			public AsyncTaskMethodBuilder<LIHOBIGHABN> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000827")]
			public FNKNKBJGDKA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000828")]
			private LIHOBIGHABN <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000829")]
			private TaskAwaiter<LIHOBIGHABN> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000711")]
			[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
			public JEDKNBIDCDL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000712")]
			[Cpp2IlInjected.Address(RVA = "0x5369850", Offset = "0x5368050", VA = "0x185369850", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000713")]
			[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000822")]
		private readonly CCCEJDFLIPE EDMEEEOPNGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000823")]
		private readonly FPFEIMEJDPP PLPMPEIFDCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000824")]
		private readonly ODJADAFJGIK COMCMCKMNKE;

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		public int LDNEDBPECPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000705")]
			[Cpp2IlInjected.Address(RVA = "0x36E6B70", Offset = "0x36E5370", VA = "0x1836E6B70", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		public HPDPHGLDFIN GLBMHCAKNAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000706")]
			[Cpp2IlInjected.Address(RVA = "0x36E6A40", Offset = "0x36E5240", VA = "0x1836E6A40", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		private DateTime ECMCCHJOLNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000707")]
			[Cpp2IlInjected.Address(RVA = "0x36E6BC0", Offset = "0x36E53C0", VA = "0x1836E6BC0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C4")]
		public FPFEIMEJDPP? IAHAOHABEFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000708")]
			[Cpp2IlInjected.Address(RVA = "0x36E6C70", Offset = "0x36E5470", VA = "0x1836E6C70", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C5")]
		public ODJADAFJGIK? ADAJIBMPONK
		{
			[Cpp2IlInjected.Token(Token = "0x6000709")]
			[Cpp2IlInjected.Address(RVA = "0x36E6B20", Offset = "0x36E5320", VA = "0x1836E6B20", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		public AFCECGJNIAB HGGHBNLINJK
		{
			[Cpp2IlInjected.Token(Token = "0x600070C")]
			[Cpp2IlInjected.Address(RVA = "0x892A20", Offset = "0x891220", VA = "0x180892A20", Slot = "10")]
			get
			{
				return default(AFCECGJNIAB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0x34F8430", Offset = "0x34F6C30", VA = "0x1834F8430")]
		public FNKNKBJGDKA(CCCEJDFLIPE AKBCGGCPLIB, FPFEIMEJDPP LBOKDHAMHLI, ODJADAFJGIK POONGBEAKJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0x36E67A0", Offset = "0x36E4FA0", VA = "0x1836E67A0", Slot = "9")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(JEDKNBIDCDL))]
		public Task<LIHOBIGHABN> EBFEIMHBMOO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0x36E68F0", Offset = "0x36E50F0", VA = "0x1836E68F0", Slot = "11")]
		public bool Equals(AMPLJNEEHDI OALEAAIPGBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0x36E6990", Offset = "0x36E5190", VA = "0x1836E6990", Slot = "0")]
		public override bool Equals(object CEPDEAHBHLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0x36E6C10", Offset = "0x36E5410", VA = "0x1836E6C10")]
		private bool OCGPELPLBPE(FNKNKBJGDKA OALEAAIPGBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0x36E6A90", Offset = "0x36E5290", VA = "0x1836E6A90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A5")]
	private sealed class BPFNIJJKHPK : AMPLJNEEHDI, IEquatable<AMPLJNEEHDI>
	{
		[Cpp2IlInjected.Token(Token = "0x20001A6")]
		[CompilerGenerated]
		private sealed class FANLFMEBAFG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400082D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400082E")]
			public AsyncTaskMethodBuilder<LIHOBIGHABN> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400082F")]
			public BPFNIJJKHPK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000830")]
			private LIHOBIGHABN <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000831")]
			private TaskAwaiter<LIHOBIGHABN> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000720")]
			[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
			public FANLFMEBAFG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000721")]
			[Cpp2IlInjected.Address(RVA = "0x5367FC0", Offset = "0x53667C0", VA = "0x185367FC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000722")]
			[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400082A")]
		private readonly HPDPHGLDFIN GDHDDAFCKCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400082B")]
		private readonly FPFEIMEJDPP PLPMPEIFDCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400082C")]
		private readonly ODJADAFJGIK COMCMCKMNKE;

		[Cpp2IlInjected.Token(Token = "0x170000C7")]
		public int LDNEDBPECPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000714")]
			[Cpp2IlInjected.Address(RVA = "0x36E2770", Offset = "0x36E0F70", VA = "0x1836E2770", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C8")]
		[NotNull]
		public HPDPHGLDFIN GLBMHCAKNAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000715")]
			[Cpp2IlInjected.Address(RVA = "0x7DF170", Offset = "0x7DD970", VA = "0x1807DF170", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C9")]
		private DateTime ECMCCHJOLNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000716")]
			[Cpp2IlInjected.Address(RVA = "0x893100", Offset = "0x891900", VA = "0x180893100", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		public FPFEIMEJDPP? IAHAOHABEFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000717")]
			[Cpp2IlInjected.Address(RVA = "0x36E2910", Offset = "0x36E1110", VA = "0x1836E2910", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		public ODJADAFJGIK? ADAJIBMPONK
		{
			[Cpp2IlInjected.Token(Token = "0x6000718")]
			[Cpp2IlInjected.Address(RVA = "0x36E2720", Offset = "0x36E0F20", VA = "0x1836E2720", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		public AFCECGJNIAB HGGHBNLINJK
		{
			[Cpp2IlInjected.Token(Token = "0x600071B")]
			[Cpp2IlInjected.Address(RVA = "0x893100", Offset = "0x891900", VA = "0x180893100", Slot = "10")]
			get
			{
				return default(AFCECGJNIAB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0x34F8430", Offset = "0x34F6C30", VA = "0x1834F8430")]
		public BPFNIJJKHPK(HPDPHGLDFIN MOPIJFDNMEF, FPFEIMEJDPP LBOKDHAMHLI, ODJADAFJGIK POONGBEAKJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0x36E2290", Offset = "0x36E0A90", VA = "0x1836E2290", Slot = "9")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(FANLFMEBAFG))]
		public Task<LIHOBIGHABN> EBFEIMHBMOO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0x36E2530", Offset = "0x36E0D30", VA = "0x1836E2530", Slot = "11")]
		public bool Equals(AMPLJNEEHDI OALEAAIPGBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(RVA = "0x36E23E0", Offset = "0x36E0BE0", VA = "0x1836E23E0", Slot = "0")]
		public override bool Equals(object CEPDEAHBHLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(RVA = "0x36E2670", Offset = "0x36E0E70", VA = "0x1836E2670", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(RVA = "0x36E27F0", Offset = "0x36E0FF0", VA = "0x1836E27F0")]
		private bool OCGPELPLBPE(BPFNIJJKHPK OALEAAIPGBP)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A8")]
	[CompilerGenerated]
	private sealed class EJLGMLBOBIC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000838")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000839")]
		public AsyncTaskMethodBuilder<IList<AMPLJNEEHDI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400083A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400083B")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400083C")]
		public bool forceRefreshSaveHistoryCache;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400083D")]
		public IHMOKOKMEFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400083E")]
		private (long roomId, long subroomId) <cacheKey>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400083F")]
		private IReadOnlyList<JDPJAFEOEAF> <saveHistory>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000840")]
		private IReadOnlyList<(int accountId, HPDPHGLDFIN account, JDPJAFEOEAF roomDataSaveDto)> <saveHistoryWithAccounts>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000841")]
		private List<AMPLJNEEHDI> <restoreOptions>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000842")]
		private DateTime? <mostRecentSaveDate>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000843")]
		private CCCEJDFLIPE <autoSaveInfo>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000844")]
		private IReadOnlyList<JDPJAFEOEAF> <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000845")]
		private IReadOnlyList<(int accountId, HPDPHGLDFIN account, JDPJAFEOEAF roomDataSaveDto)> <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000846")]
		private IEnumerator<(int accountId, HPDPHGLDFIN account, JDPJAFEOEAF roomDataSaveDto)> <>s__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000847")]
		private (int accountId, HPDPHGLDFIN account, JDPJAFEOEAF roomDataSaveDto) <saveHistoryWithAccount>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000848")]
		private FNKNKBJGDKA <autosaveOption>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000849")]
		private TaskAwaiter<IReadOnlyList<JDPJAFEOEAF>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400084A")]
		private TaskAwaiter<IReadOnlyList<(int accountId, HPDPHGLDFIN account, JDPJAFEOEAF roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600072A")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public EJLGMLBOBIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072B")]
		[Cpp2IlInjected.Address(RVA = "0x36E52E0", Offset = "0x36E3AE0", VA = "0x1836E52E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072C")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A9")]
	[CompilerGenerated]
	private sealed class LBDMBEDEKDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400084B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400084C")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, HPDPHGLDFIN account, JDPJAFEOEAF roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400084D")]
		public IReadOnlyList<JDPJAFEOEAF> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400084E")]
		public IHMOKOKMEFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400084F")]
		private List<int> <accountIds>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000850")]
		private IReadOnlyList<HPDPHGLDFIN> <accounts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000851")]
		private Dictionary<ObscuredInt, HPDPHGLDFIN> <accountsDict>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000852")]
		private List<(int, HPDPHGLDFIN, JDPJAFEOEAF)> <finalHistory>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000853")]
		private IReadOnlyList<HPDPHGLDFIN> <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000854")]
		private IEnumerator<JDPJAFEOEAF> <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000855")]
		private JDPJAFEOEAF <historyItem>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000856")]
		private int <savedByAccountId>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000857")]
		private HPDPHGLDFIN <savedByAccount>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000858")]
		private HPDPHGLDFIN <account>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000859")]
		private TaskAwaiter<IReadOnlyList<HPDPHGLDFIN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600072D")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public LBDMBEDEKDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072E")]
		[Cpp2IlInjected.Address(RVA = "0x36ED390", Offset = "0x36EBB90", VA = "0x1836ED390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072F")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000811")]
	private readonly CHKPAGICHAJ OLPNBAIDNLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000812")]
	private readonly ONHADEFABHM OFDLKBHMHEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000813")]
	private readonly ABKHNKAOKME ANHBFPAJDIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000814")]
	private readonly HBJFLEBNBOB<(long, long), IReadOnlyList<JDPJAFEOEAF>> HDJDEHMAAMD;

	[Cpp2IlInjected.Token(Token = "0x60006F2")]
	[Cpp2IlInjected.Address(RVA = "0x205F580", Offset = "0x205DD80", VA = "0x18205F580")]
	[UnityEngine.Scripting.Preserve]
	public IHMOKOKMEFB([JHPEMCNOMHI(null)] ONHADEFABHM JDEGDKLAACB, [JHPEMCNOMHI(null)] ABKHNKAOKME IJEKBIABLBF, [JHPEMCNOMHI(null)] CHKPAGICHAJ JKAIHLJKJFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F3")]
	[Cpp2IlInjected.Address(RVA = "0x205F0D0", Offset = "0x205D8D0", VA = "0x18205F0D0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EJLGMLBOBIC))]
	public Task<IList<AMPLJNEEHDI>> OAJGIJMLBGG(long AFGKPOPONBN, long OFFAGGOPNOB, bool CHKJCIKNDGG = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006F4")]
	[Cpp2IlInjected.Address(RVA = "0x205F3E0", Offset = "0x205DBE0", VA = "0x18205F3E0")]
	private bool PKOEJFKICPO(DateTime? DOAAJKNIAHO, long AFGKPOPONBN, long OFFAGGOPNOB, out CCCEJDFLIPE NLFPMIFADDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F5")]
	[Cpp2IlInjected.Address(RVA = "0x205F270", Offset = "0x205DA70", VA = "0x18205F270")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LBDMBEDEKDH))]
	private Task<IReadOnlyList<(int, HPDPHGLDFIN, JDPJAFEOEAF)>> OILGGKFFPDJ(IReadOnlyList<JDPJAFEOEAF> BPHGEAGJDKN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AA")]
internal class CANBDNDLJPN : ONHADEFABHM
{
	[Cpp2IlInjected.Token(Token = "0x20001AB")]
	[CompilerGenerated]
	private sealed class MGLOCLPAHDF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400085A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400085B")]
		public AsyncTaskMethodBuilder<IReadOnlyList<JDPJAFEOEAF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400085C")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400085D")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400085E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400085F")]
		public CANBDNDLJPN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000860")]
		private CMCKFNBLBBF<JDPJAFEOEAF> <pagedResults>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000861")]
		private CMCKFNBLBBF<JDPJAFEOEAF> <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000862")]
		private TaskAwaiter<CMCKFNBLBBF<JDPJAFEOEAF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000733")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public MGLOCLPAHDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000734")]
		[Cpp2IlInjected.Address(RVA = "0x266F050", Offset = "0x266D850", VA = "0x18266F050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000735")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001AC")]
	[CompilerGenerated]
	private sealed class BINOMNJKHLN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000863")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000864")]
		public AsyncTaskMethodBuilder<IReadOnlyList<HPDPHGLDFIN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000865")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000866")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000867")]
		public CANBDNDLJPN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000868")]
		private List<HPDPHGLDFIN> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000869")]
		private TaskAwaiter<List<HPDPHGLDFIN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000736")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public BINOMNJKHLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000737")]
		[Cpp2IlInjected.Address(RVA = "0x2663280", Offset = "0x2661A80", VA = "0x182663280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000738")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000730")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	[UnityEngine.Scripting.Preserve]
	public CANBDNDLJPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000731")]
	[Cpp2IlInjected.Address(RVA = "0x2044B80", Offset = "0x2043380", VA = "0x182044B80", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MGLOCLPAHDF))]
	public Task<IReadOnlyList<JDPJAFEOEAF>> BNFCOPMGJPN(long AFGKPOPONBN, long HILPLFHHAPA, [Optional] CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000732")]
	[Cpp2IlInjected.Address(RVA = "0x2044D30", Offset = "0x2043530", VA = "0x182044D30", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BINOMNJKHLN))]
	public Task<IReadOnlyList<HPDPHGLDFIN>> CLJAGBCFEOB(IReadOnlyList<int> EMACEKCDODK, [Optional] CancellationToken NNLBJPBEHPF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AD")]
public interface ONHADEFABHM
{
	[Cpp2IlInjected.Token(Token = "0x6000739")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<JDPJAFEOEAF>> BNFCOPMGJPN(long AFGKPOPONBN, long HILPLFHHAPA, [Optional] CancellationToken NNLBJPBEHPF);

	[Cpp2IlInjected.Token(Token = "0x600073A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<HPDPHGLDFIN>> CLJAGBCFEOB(IReadOnlyList<int> EMACEKCDODK, [Optional] CancellationToken NNLBJPBEHPF);
}
[Cpp2IlInjected.Token(Token = "0x20001AE")]
public interface AMPLJNEEHDI : IEquatable<AMPLJNEEHDI>
{
	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	int LDNEDBPECPC
	{
		[Cpp2IlInjected.Token(Token = "0x600073B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	[CanBeNull]
	HPDPHGLDFIN GLBMHCAKNAI
	{
		[Cpp2IlInjected.Token(Token = "0x600073C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	DateTime ACKJNKEACML
	{
		[Cpp2IlInjected.Token(Token = "0x600073D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	FPFEIMEJDPP? IAHAOHABEFN
	{
		[Cpp2IlInjected.Token(Token = "0x600073E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	ODJADAFJGIK? ADAJIBMPONK
	{
		[Cpp2IlInjected.Token(Token = "0x600073F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	[CanBeNull]
	AFCECGJNIAB HGGHBNLINJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000741")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000740")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<LIHOBIGHABN> EBFEIMHBMOO();
}
[Cpp2IlInjected.Token(Token = "0x20001AF")]
public enum AFCECGJNIAB
{
	[Cpp2IlInjected.Token(Token = "0x400086B")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x400086C")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x400086D")]
	DiskAutosave
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

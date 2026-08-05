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
		[Cpp2IlInjected.Address(RVA = "0x956600", Offset = "0x954C00", VA = "0x180956600")]
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
		[Cpp2IlInjected.Address(RVA = "0x273A230", Offset = "0x2738830", VA = "0x18273A230")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xBD9AB0", Offset = "0xBD80B0", VA = "0x180BD9AB0")]
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
		[Cpp2IlInjected.Address(RVA = "0xEA93B0", Offset = "0xEA79B0", VA = "0x180EA93B0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface JEPKLFNGOMJ
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<KFADJCAHNKD> KBBNLIBBEIF;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IINFOGIOEJO(long EDDMGMBKEBK, long NCHHGHFPFDL, NLCCKHNECKK ADALNLFJHAF, ELOHJNEJPLG FLILMALMEBH);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IEEKAKLEKGG(long EDDMGMBKEBK, long NCHHGHFPFDL, out KFADJCAHNKD KBEMOJLMDPA);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool JELIOMIEJMN(long EDDMGMBKEBK, long NCHHGHFPFDL, ELOHJNEJPLG FLILMALMEBH, out KFADJCAHNKD KBEMOJLMDPA);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FNKCEHKIPDJ(long EDDMGMBKEBK, long NCHHGHFPFDL);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[UnityEngine.Scripting.Preserve]
internal class FEMAPIOLLOH : FPJPENDPCCA, BGBDFCFKDKN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class FMNAKJHNKOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public MEALHALACCD roomEvent;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public FMNAKJHNKOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x36B5B00", Offset = "0x36B4100", VA = "0x1836B5B00")]
		internal object KOCFGAMKFFE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action DLPEFEIPFHK
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x219DC50", Offset = "0x219C250", VA = "0x18219DC50", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x219E420", Offset = "0x219CA20", VA = "0x18219E420", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event GKPLIIPLMEH OFIPPMPEEIN
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x219E380", Offset = "0x219C980", VA = "0x18219E380", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x219E210", Offset = "0x219C810", VA = "0x18219E210", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event GKPLIIPLMEH OIFKJLFPDHN
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x219E2B0", Offset = "0x219C8B0", VA = "0x18219E2B0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x219DBB0", Offset = "0x219C1B0", VA = "0x18219DBB0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event GKPLIIPLMEH NANCDPCJNCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x219DAE0", Offset = "0x219C0E0", VA = "0x18219DAE0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x219E170", Offset = "0x219C770", VA = "0x18219E170", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action<PHANMBGDINN, bool> AKKPDJBGBFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x219DE70", Offset = "0x219C470", VA = "0x18219DE70", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x219DDA0", Offset = "0x219C3A0", VA = "0x18219DDA0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "19")]
	public void KGHKJOCLFMF(LCNJJEKDLHB LCPJEGLKADH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x219E4C0", Offset = "0x219CAC0", VA = "0x18219E4C0", Slot = "14")]
	public void OINFIEKOPIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x219E350", Offset = "0x219C950", VA = "0x18219E350", Slot = "15")]
	public void KGCIEFACAJB(MEALHALACCD CJBHPGFBNKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x219DB80", Offset = "0x219C180", VA = "0x18219DB80", Slot = "16")]
	public void AMEOBGFBPFJ(MEALHALACCD CJBHPGFBNKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x219DE40", Offset = "0x219C440", VA = "0x18219DE40", Slot = "17")]
	public void GKLDNHHNOIA(MEALHALACCD CJBHPGFBNKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x219DCF0", Offset = "0x219C2F0", VA = "0x18219DCF0", Slot = "18")]
	public void FMOOFKMNFEA(PHANMBGDINN PHBAINNDDIK, bool BMKKIDBNMCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x219DF10", Offset = "0x219C510", VA = "0x18219DF10")]
	private void HDLCFALLNOK(GKPLIIPLMEH LNBMEBPIDEB, MEALHALACCD CJBHPGFBNKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
	public FEMAPIOLLOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal interface MGDFKIMJGLA : BGBDFCFKDKN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	BKDLHCNELBM IMMDGJNNAGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EGJLOLFCDGF();

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FBANBNIJGMP();
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate LOJBOFKMJHM CILAJBHGPFE(IFFNBNNJJLC JMFJDNIANCF, AEHILIDANGI OHEOBBDEKJD);
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal interface OGKLPLJCFFC : BGBDFCFKDKN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JABIOEONLNK PECJCNFIBGD(IHCOLCCANMI JJJAGMMBGDH);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DIMIFBKKJPL(Guid MGMFLGBPLHJ, Task BNJGBDJALJP);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal struct EIGPMKDHLGJ
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public const string BBFNPCPAKAP = "v_result";

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public const string BCBGAAKHGAO = "oid";

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly IDictionary<object, object> OHLDPOJHAKH;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool PLFPHKBCLKH
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xE85150", Offset = "0xE83750", VA = "0x180E85150")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0xA7EC30", Offset = "0xA7D230", VA = "0x180A7EC30")]
	public EIGPMKDHLGJ(IDictionary<object, object> OHLDPOJHAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2199BF0", Offset = "0x21981F0", VA = "0x182199BF0")]
	public bool OENJPBFAKJF(out IHCOLCCANMI JIEHBANCLJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2199A00", Offset = "0x2198000", VA = "0x182199A00")]
	public Guid DFEGPBMEBFL()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2199AE0", Offset = "0x21980E0", VA = "0x182199AE0")]
	public LOJBOFKMJHM JIEMFALKCEI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2199CB0", Offset = "0x21982B0", VA = "0x182199CB0")]
	public static ExitGames.Client.Photon.Hashtable PJDMJLOGMBM(IHCOLCCANMI JIEHBANCLJP, LOJBOFKMJHM COGNPIMIJHL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface IAMLOLAILNM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KPFOBHODAAK(HGEFFFLNEEA.IKJIOKHIJHM LKMLHIEDCOG);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PDKPBOMIGPA(HGEFFFLNEEA.IKJIOKHIJHM LKMLHIEDCOG);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum JEOBGAELACB
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	Misc,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	LoadNewRoom,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	ReloadRoom
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class HGEFFFLNEEA : IAMLOLAILNM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public delegate LOJBOFKMJHM IKJIOKHIJHM([NotNull] IFFNBNNJJLC OABCKJAKNMD);

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class KEAOAKHADGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public IFFNBNNJJLC photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public KEAOAKHADGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x36BA2F0", Offset = "0x36B88F0", VA = "0x1836BA2F0")]
		internal LOJBOFKMJHM NLHMGIHCGAL(IKJIOKHIJHM v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool OCBEMDEOMOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected readonly HashSet<IKJIOKHIJHM> NOMPBMCHOFF;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x21A58C0", Offset = "0x21A3EC0", VA = "0x1821A58C0", Slot = "4")]
	public void KPFOBHODAAK(IKJIOKHIJHM LKMLHIEDCOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x21A5920", Offset = "0x21A3F20", VA = "0x1821A5920", Slot = "5")]
	public void PDKPBOMIGPA(IKJIOKHIJHM LKMLHIEDCOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x21A5600", Offset = "0x21A3C00", VA = "0x1821A5600", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x21A5650", Offset = "0x21A3C50", VA = "0x1821A5650")]
	protected LOJBOFKMJHM ELEPHJFLBDC(IFFNBNNJJLC OBBBOIELLGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x21A5980", Offset = "0x21A3F80", VA = "0x1821A5980")]
	protected HGEFFFLNEEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class MHDFCFNEAHB
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class IFEKDKOGFNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public PFODCGFLBLH subRoomSave;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public IFEKDKOGFNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3ECF0F0", Offset = "0x3ECD6F0", VA = "0x183ECF0F0")]
		internal bool OOBOIFPKFJN(GBCKOOBFABI s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x27356B0", Offset = "0x2733CB0", VA = "0x1827356B0")]
	public static FICOENLLCNC PJDMJLOGMBM(long MKKNAFDEBBK, long LKPOLLBAPFL, string JMDMGHGBHHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2735AD0", Offset = "0x27340D0", VA = "0x182735AD0")]
	public static FICOENLLCNC PJDMJLOGMBM(long MKKNAFDEBBK, long LKPOLLBAPFL, MFELEADOGIE PEGIFAKLECB, long MKOFDBDNAIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2735750", Offset = "0x2733D50", VA = "0x182735750")]
	public static FICOENLLCNC PJDMJLOGMBM(HKAJAMIEIHO NMCLKJJJIFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2735890", Offset = "0x2733E90", VA = "0x182735890")]
	public static FICOENLLCNC PJDMJLOGMBM(LMPJDKBMOBF PEMCADFCKIP, PFODCGFLBLH PKJAIPEMIMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2735BA0", Offset = "0x27341A0", VA = "0x182735BA0")]
	public static FICOENLLCNC PLKJLJEKGEL(this FICOENLLCNC OGLJJNFALNA, LMPJDKBMOBF GFLBLNHIIIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2735520", Offset = "0x2733B20", VA = "0x182735520")]
	public static FICOENLLCNC FENEHOBJBCL(this FICOENLLCNC OGLJJNFALNA, PFODCGFLBLH JAPEIABPJPI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum DEHEADPOCAB
{
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum PHANMBGDINN
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	InitialRoomLoad,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	AutoSave,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	SaveToDisk,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	SaveToRecNet,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	RestoreAutoSave,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct MEALHALACCD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly long MKKNAFDEBBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly long LKPOLLBAPFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly DEHEADPOCAB LFBJHCMDIAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[CanBeNull]
	public readonly Exception HJNLHIGNDCM;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2735500", Offset = "0x2733B00", VA = "0x182735500")]
	public MEALHALACCD(long MKKNAFDEBBK, long LKPOLLBAPFL, DEHEADPOCAB LFBJHCMDIAE, [CanBeNull] Exception HJNLHIGNDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x27354B0", Offset = "0x2733AB0", VA = "0x1827354B0")]
	public static MEALHALACCD ODIPKIECENO(LHJOLIPPMAL NIFJPMLBADM, DEHEADPOCAB LFBJHCMDIAE, [Optional] Exception HJNLHIGNDCM)
	{
		return default(MEALHALACCD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public delegate void GKPLIIPLMEH(MEALHALACCD CJBHPGFBNKH);
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal interface FPJPENDPCCA : BGBDFCFKDKN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action DLPEFEIPFHK;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event GKPLIIPLMEH OFIPPMPEEIN;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event GKPLIIPLMEH OIFKJLFPDHN;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event GKPLIIPLMEH NANCDPCJNCC;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<PHANMBGDINN, bool> AKKPDJBGBFP;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void OINFIEKOPIC();

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void KGCIEFACAJB(MEALHALACCD CJBHPGFBNKH);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void AMEOBGFBPFJ(MEALHALACCD CJBHPGFBNKH);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void GKLDNHHNOIA(MEALHALACCD CJBHPGFBNKH);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void FMOOFKMNFEA(PHANMBGDINN PHBAINNDDIK, bool BMKKIDBNMCL);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[UnityEngine.Scripting.Preserve]
internal class CDFDGADHFOC : KLKIBPNICGK, BGBDFCFKDKN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class IHGGBCPNNEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public CDFDGADHFOC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private NHNLOHOBNME<string> <timer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private NHNLOHOBNME<string>.NOELMCIDFEB <timerScope>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private LJLBCNODBNI <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public IHGGBCPNNEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2730E50", Offset = "0x272F450", VA = "0x182730E50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private CHOIGDNKNLL GFLBKLKGHCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private LCNJJEKDLHB LCPJEGLKADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private CHJKBIICEEH MLDBCLJMNLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private FAODONACOCN BLFDAKOGHLK;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2190350", Offset = "0x218E950", VA = "0x182190350", Slot = "6")]
	public void KGHKJOCLFMF(LCNJJEKDLHB LCPJEGLKADH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2190150", Offset = "0x218E750", VA = "0x182190150", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x21901A0", Offset = "0x218E7A0", VA = "0x1821901A0", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IHGGBCPNNEM))]
	public Task HKAOLLJNAJN(string PCCHHIAICLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x21902F0", Offset = "0x218E8F0", VA = "0x1821902F0", Slot = "4")]
	public LOJBOFKMJHM JBILOBDCJIC(IFFNBNNJJLC JMFJDNIANCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2190040", Offset = "0x218E640", VA = "0x182190040")]
	private LJLBCNODBNI AGDJBIOFAMM(string PCCHHIAICLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
	public CDFDGADHFOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface NJPEDPIBAHB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool CDAGMJHGMCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool LIJBMLEKAAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Task BMNFJGCOKOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	JALCPALKLOC FEEPOEEEOBO
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action DLPEFEIPFHK;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event GKPLIIPLMEH OFIPPMPEEIN;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event GKPLIIPLMEH OIFKJLFPDHN;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event GKPLIIPLMEH NANCDPCJNCC;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<PHANMBGDINN, bool> AKKPDJBGBFP;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void EDDOHEMBKMH();

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "14")]
	KBDFJCPGKLB DBBPJGOHBKM();

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "15")]
	OIDLEEHHLBJ NHCKCNIGKKM();

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task<LOJBOFKMJHM> MIFDCAFMPPK(KFADJCAHNKD IIIIEFFLPLO);

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task OEBDHLJDDAL(CancellationToken OOAGLCBNIOG);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal interface EKDLKAIMKEM : BGBDFCFKDKN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<LOJBOFKMJHM> MIFDCAFMPPK(KFADJCAHNKD KBEMOJLMDPA);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task OEBDHLJDDAL(CancellationToken OOAGLCBNIOG);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[RecRoom.NoEngine.Common.Preserve]
internal class OMFLCPIEIAC : AFOGPGOCCBM, BGBDFCFKDKN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class OMGDPADAGHP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public LHJOLIPPMAL targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public JALCPALKLOC customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public OMFLCPIEIAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private MLOCEEOLAMF.FNBAANFJAOH <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private Task <task>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public OMGDPADAGHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x3ED9B10", Offset = "0x3ED8110", VA = "0x183ED9B10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class DPEKEMMLAGN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public LHJOLIPPMAL targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public JALCPALKLOC customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public OMFLCPIEIAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private NHNLOHOBNME<string> <timer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private MLOCEEOLAMF.FNBAANFJAOH <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private NHNLOHOBNME<string>.NOELMCIDFEB <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private JMODPMGGFBH <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private FBHHHJLIPNP <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private OperationCanceledException <oce>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private Exception <ex>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public DPEKEMMLAGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x3EC9790", Offset = "0x3EC7D90", VA = "0x183EC9790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class ADJBCKFPCOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Matchmaking.NFNPONCBJHK result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public LCJCDJGDDFO errorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public ADJBCKFPCOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x3EC6590", Offset = "0x3EC4B90", VA = "0x183EC6590")]
		internal object IKGKPFPKFII()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class CFPLFIBAELI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Task<FICOENLLCNC> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public CFPLFIBAELI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x86D400", Offset = "0x86BA00", VA = "0x18086D400")]
		internal Task<FICOENLLCNC> KOMNDKAMOHF(NHNLOHOBNME<string>.NOELMCIDFEB _)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class NNLMLOPDLDP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public NHNLOHOBNME<string>.NOELMCIDFEB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public LHJOLIPPMAL targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public JALCPALKLOC customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public JMODPMGGFBH joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public OMFLCPIEIAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private MPHICIHCHHN <multiProgressTracker>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private MLOCEEOLAMF.FNBAANFJAOH <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private NHNLOHOBNME<string>.NOELMCIDFEB <connectToRoomAndRunLoadLogicTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private CancellationTokenSource <roomTokenSource>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private CancellationTokenRegistration <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private CFPLFIBAELI <>8__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private CancellationToken <roomCancellationToken>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private JALHEGJIFHN <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private Task<Matchmaking.OIJFDGIOOGH> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private DOIHJJLFIFJ <>s__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private Matchmaking.OIJFDGIOOGH <serverConnectionInfo>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private CancellationTokenSource <cameraFadeCts>5__13;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private NHNLOHOBNME<string>.NOELMCIDFEB <>s__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private CancellationTokenSource <loadingScreenCts>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private NHNLOHOBNME<string>.NOELMCIDFEB <loadingScreenScope>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private Matchmaking.OIJFDGIOOGH <>s__17;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private CancellationTokenSource <photonJoinedTokenSource>5__18;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private CancellationToken <photonJoinedToken>5__19;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private FICOENLLCNC <initialRoomLoadPayload>5__20;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private Task <roomLoadTask>5__21;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private FICOENLLCNC <>s__22;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private NHNLOHOBNME<string>.NOELMCIDFEB <>s__23;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private TaskAwaiter<Matchmaking.OIJFDGIOOGH> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private TaskAwaiter<FICOENLLCNC> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public NNLMLOPDLDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x3ED6B10", Offset = "0x3ED5110", VA = "0x183ED6B10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class FEPJIHCKLNL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public NHNLOHOBNME<string>.NOELMCIDFEB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public OMFLCPIEIAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private MLOCEEOLAMF.FNBAANFJAOH <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private NHNLOHOBNME<string>.NOELMCIDFEB <disconnectTimerScope>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private object <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private int <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private Exception <ex>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private NHNLOHOBNME<string>.NOELMCIDFEB <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public FEPJIHCKLNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x3ECC910", Offset = "0x3ECAF10", VA = "0x183ECC910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class JMLCHHKKKIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public OMFLCPIEIAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private EIHIACACEHJ <roomContainer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public JMLCHHKKKIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x3ED00B0", Offset = "0x3ECE6B0", VA = "0x183ED00B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class POCFPEFBMBP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public AsyncTaskMethodBuilder<Matchmaking.OIJFDGIOOGH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public LHJOLIPPMAL targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public NHNLOHOBNME<string>.NOELMCIDFEB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public OMFLCPIEIAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private NHNLOHOBNME<string>.NOELMCIDFEB <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private Matchmaking.OIJFDGIOOGH <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private TaskAwaiter<Matchmaking.OIJFDGIOOGH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public POCFPEFBMBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x3EDADB0", Offset = "0x3ED93B0", VA = "0x183EDADB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class PDKAODPBKMF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public LHJOLIPPMAL targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public Matchmaking.OIJFDGIOOGH serverConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public JMODPMGGFBH joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public NHNLOHOBNME<string>.NOELMCIDFEB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public OMFLCPIEIAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private MLOCEEOLAMF.FNBAANFJAOH <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private NHNLOHOBNME<string>.NOELMCIDFEB <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private GPHLAPCKOKM <photonRoomConnectionInfo>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private TaskAwaiter<GPHLAPCKOKM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public PDKAODPBKMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x3EDA690", Offset = "0x3ED8C90", VA = "0x183EDA690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class JPDNGAKFOGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public LHJOLIPPMAL targetInstance;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public JPDNGAKFOGD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class MBEHDDHGGAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public bool firstIsWhileInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public Task firstCompletedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public JPDNGAKFOGD CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public MBEHDDHGGAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x3ED2640", Offset = "0x3ED0C40", VA = "0x183ED2640")]
		internal object FGLAPCMOCBD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x3ED2740", Offset = "0x3ED0D40", VA = "0x183ED2740")]
		internal string IFFAEMAPGHO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class LKBOEEMHKMB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public LHJOLIPPMAL targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public OMFLCPIEIAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private JPDNGAKFOGD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private MLOCEEOLAMF.FNBAANFJAOH <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private MBEHDDHGGAM <>8__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private Task <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private object <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private int <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private Exception <ex>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public LKBOEEMHKMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x3ED0E40", Offset = "0x3ECF440", VA = "0x183ED0E40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class AADNLCKGKPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public FICOENLLCNC initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public MPHICIHCHHN progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public LHJOLIPPMAL targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public JMODPMGGFBH joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public NHNLOHOBNME<string>.NOELMCIDFEB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public OMFLCPIEIAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private NHNLOHOBNME<string>.NOELMCIDFEB <roomLoadLogicTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private JMODPMGGFBH <initialLoadOpPauseToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private BPFCDFJGKOE <op>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public AADNLCKGKPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x3EC5F10", Offset = "0x3EC4510", VA = "0x183EC5F10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class MDMKKFOOGAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public NHNLOHOBNME<string>.NOELMCIDFEB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public OMFLCPIEIAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private NHNLOHOBNME<string>.NOELMCIDFEB <spawnLocalPlayerTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private MLOCEEOLAMF.FNBAANFJAOH <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private NHNLOHOBNME<string>.NOELMCIDFEB <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private NHNLOHOBNME<string>.NOELMCIDFEB <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private int <i>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private NHNLOHOBNME<string>.NOELMCIDFEB <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private NHNLOHOBNME<string>.NOELMCIDFEB <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private CancellationTokenSource <timeoutTcs>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private CancellationToken <timeoutToken>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public MDMKKFOOGAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x3ED28C0", Offset = "0x3ED0EC0", VA = "0x183ED28C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class FOGPODABENF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public EPFFDDEKBCK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public OMFLCPIEIAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private MLOCEEOLAMF.FNBAANFJAOH <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private int <version>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private bool <canUpdateRoom>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6D")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private bool <shouldSave>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6E")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private bool <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private TaskAwaiter<LOJBOFKMJHM> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public FOGPODABENF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x3ECD360", Offset = "0x3ECB960", VA = "0x183ECD360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class OCEGOPJKMPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public LHJOLIPPMAL targetInstance;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public OCEGOPJKMPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x3ED9640", Offset = "0x3ED7C40", VA = "0x183ED9640")]
		internal object JCMPLEGPGAL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class AFHJGCBHMDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public AFHJGCBHMDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x3EC6640", Offset = "0x3EC4C40", VA = "0x183EC6640")]
		internal void LNIFMOGKAMM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class DFMLKPEMMDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public LHJOLIPPMAL targetInstance;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public DFMLKPEMMDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x3EC9710", Offset = "0x3EC7D10", VA = "0x183EC9710")]
		internal object JOEMLCKAMGN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class ANBBDPINGFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public LHJOLIPPMAL targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public ANBBDPINGFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x3EC6D10", Offset = "0x3EC5310", VA = "0x183EC6D10")]
		internal string NBGEHHPILNM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static readonly string HILJBNDHDKN;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static readonly string MFIPDAPIJFF;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static readonly string GHNEPIOFOCG;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly Guid HAGOHDEGCKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private GEIFDGGEAAC KFEFPLGAPED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private PDCFACENKHF MBHFEKHOEDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private HDOGFNJHJAM EGGPOCDMEIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private LCNJJEKDLHB LCPJEGLKADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private OPEIFKONHHI OODHPHIHFDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private IODPKOEAPFI EDJMKLNLNLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private JHPIEPEAANO FGADNKOBCHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private FPJPENDPCCA OECHOENAFHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private NBKCCEOGEEG EAMILPKKFHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private MGJNGDDEEII PCLDEBPBBEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private IDisposable KOMLMBBKMPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly KMGFNNFFDCD KDLMKFBMBJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly KMGFNNFFDCD HFIPFELIKEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private DOIHJJLFIFJ MLNMGOLOEDB;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public TaskStatus EKKNBDPALPM
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x21016E0", Offset = "0x20FFCE0", VA = "0x1821016E0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x20FF990", Offset = "0x20FDF90", VA = "0x1820FF990")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private CFIDKJEMCJA NNHNHPMAIMC
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2740AF0", Offset = "0x273F0F0", VA = "0x182740AF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x273FC40", Offset = "0x273E240", VA = "0x18273FC40", Slot = "6")]
	public void KGHKJOCLFMF(LCNJJEKDLHB LCPJEGLKADH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x273DDE0", Offset = "0x273C3E0", VA = "0x18273DDE0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x273D0A0", Offset = "0x273B6A0", VA = "0x18273D0A0", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OMGDPADAGHP))]
	public Task BDEIOEEDEAA(LHJOLIPPMAL HDHLHGPMFFE, JALCPALKLOC CIPBLKCJDGE, CancellationToken OHDMAIAEMEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x273FAA0", Offset = "0x273E0A0", VA = "0x18273FAA0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DPEKEMMLAGN))]
	private Task JMLHFCMMJMP(LHJOLIPPMAL HDHLHGPMFFE, JALCPALKLOC CIPBLKCJDGE, CancellationToken OHDMAIAEMEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x273F400", Offset = "0x273DA00", VA = "0x18273F400")]
	private static void IAOHNJILBKL(NBKCCEOGEEG EAMILPKKFHA, LHJOLIPPMAL HDHLHGPMFFE, Exception IOPPNPIHIME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x273E090", Offset = "0x273C690", VA = "0x18273E090")]
	private static void GFHAKHJBAEA(FBHHHJLIPNP AADLDJBAFLN, Exception IOPPNPIHIME, [Optional] List<int> CDBJKHHCPBN, int GLJBCEKFAIB = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x2740550", Offset = "0x273EB50", VA = "0x182740550")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NNLMLOPDLDP))]
	private Task LCADMHLIADC(NHNLOHOBNME<string>.NOELMCIDFEB BCLLAMGBKIH, LHJOLIPPMAL HDHLHGPMFFE, JALCPALKLOC CIPBLKCJDGE, JMODPMGGFBH GKLHBOFKBFE, CancellationToken OHDMAIAEMEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x273ED30", Offset = "0x273D330", VA = "0x18273ED30")]
	private void GMAGBAJIOOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x27403E0", Offset = "0x273E9E0", VA = "0x1827403E0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FEPJIHCKLNL))]
	private Task KPLEOMFFLNE(NHNLOHOBNME<string>.NOELMCIDFEB BCLLAMGBKIH, CancellationToken OOAGLCBNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x2740730", Offset = "0x273ED30", VA = "0x182740730")]
	private void OFHMOLLADAH(LHJOLIPPMAL HDHLHGPMFFE, CancellationToken OHDMAIAEMEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x273E8C0", Offset = "0x273CEC0", VA = "0x18273E8C0")]
	private void GIFLNLKJHDL(LHJOLIPPMAL HDHLHGPMFFE, JMODPMGGFBH GKLHBOFKBFE, OperationCanceledException LAEEGHNHMAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x273FE60", Offset = "0x273E460", VA = "0x18273FE60")]
	private void KMDLNLDFDHE(LHJOLIPPMAL HDHLHGPMFFE, JMODPMGGFBH GKLHBOFKBFE, Exception IOPPNPIHIME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x273DB40", Offset = "0x273C140", VA = "0x18273DB40")]
	private void DMFOCKCFFAM(LHJOLIPPMAL HDHLHGPMFFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x273E030", Offset = "0x273C630", VA = "0x18273E030")]
	private static MEALHALACCD FHDKPEAAKHM(LHJOLIPPMAL HDHLHGPMFFE)
	{
		return default(MEALHALACCD);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x273D240", Offset = "0x273B840", VA = "0x18273D240")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JMLCHHKKKIB))]
	private Task BGFPINLHOKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x273EE80", Offset = "0x273D480", VA = "0x18273EE80")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(POCFPEFBMBP))]
	private Task<Matchmaking.OIJFDGIOOGH> HCJCAGJMGGD(LHJOLIPPMAL HDHLHGPMFFE, NHNLOHOBNME<string>.NOELMCIDFEB BCLLAMGBKIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x273D7E0", Offset = "0x273BDE0", VA = "0x18273D7E0")]
	private static GPHLAPCKOKM CAPFIAMIIHP(LHJOLIPPMAL HDHLHGPMFFE, Matchmaking.OIJFDGIOOGH JLNMFGIPHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x273F0B0", Offset = "0x273D6B0", VA = "0x18273F0B0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PDKAODPBKMF))]
	private Task HHPODGBGGCA(LHJOLIPPMAL HDHLHGPMFFE, Matchmaking.OIJFDGIOOGH JLNMFGIPHCH, JMODPMGGFBH GKLHBOFKBFE, NHNLOHOBNME<string>.NOELMCIDFEB BCLLAMGBKIH, CancellationToken JGNPEACNFEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x273CD00", Offset = "0x273B300", VA = "0x18273CD00")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LKBOEEMHKMB))]
	private Task ADFAIPOJGLG(LHJOLIPPMAL HDHLHGPMFFE, CancellationTokenSource ACFMDLKHGAP, Task OHBLILHLGDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x273CEA0", Offset = "0x273B4A0", VA = "0x18273CEA0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AADNLCKGKPA))]
	private Task AOGAIEFICCP(FICOENLLCNC BCKHCBODBMN, MPHICIHCHHN KKCJEIMEMNE, LHJOLIPPMAL CCBHNEOCCLM, JMODPMGGFBH FKAMOFHEMHI, NHNLOHOBNME<string>.NOELMCIDFEB BCLLAMGBKIH, CancellationToken JEFBAIILJDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x273F840", Offset = "0x273DE40", VA = "0x18273F840")]
	private JMODPMGGFBH JCLCLCAFBCD(JMODPMGGFBH FKAMOFHEMHI, ref CancellationToken OOAGLCBNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x273F290", Offset = "0x273D890", VA = "0x18273F290")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MDMKKFOOGAM))]
	private Task HOPEDPIIMGH(NHNLOHOBNME<string>.NOELMCIDFEB BCLLAMGBKIH, CancellationToken OOAGLCBNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x273D360", Offset = "0x273B960", VA = "0x18273D360")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FOGPODABENF))]
	private Task BGICNLDOHIK(EPFFDDEKBCK GOMDNNCBLHP, CancellationToken OOAGLCBNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2740B40", Offset = "0x273F140", VA = "0x182740B40")]
	private static void PFLAFAGOHCF(LHJOLIPPMAL HDHLHGPMFFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x273D5C0", Offset = "0x273BBC0", VA = "0x18273D5C0")]
	private void CAEMLEFCJAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x273DAB0", Offset = "0x273C0B0", VA = "0x18273DAB0")]
	private void DKGNMIDHJAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x273D930", Offset = "0x273BF30", VA = "0x18273D930")]
	private void DBFGBEOABPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x273F020", Offset = "0x273D620", VA = "0x18273F020")]
	private void HDFCBIBJJAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x273DEA0", Offset = "0x273C4A0", VA = "0x18273DEA0")]
	private static void EMBCMFPOJNA(LHJOLIPPMAL HDHLHGPMFFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x273D9C0", Offset = "0x273BFC0", VA = "0x18273D9C0")]
	private static CancellationTokenRegistration DJLIEFJCMGH(LHJOLIPPMAL HDHLHGPMFFE, CancellationToken JGNPEACNFEC)
	{
		return default(CancellationTokenRegistration);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x273EB90", Offset = "0x273D190", VA = "0x18273EB90")]
	private static void GINLJJJKPJA(LHJOLIPPMAL HDHLHGPMFFE, Exception IOPPNPIHIME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2740130", Offset = "0x273E730", VA = "0x182740130")]
	private void KMIGNIKFFDF(LHJOLIPPMAL HDHLHGPMFFE, Task OHBLILHLGDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x273D4D0", Offset = "0x273BAD0", VA = "0x18273D4D0")]
	private static void BKMKBHBEAIO(Func<string> IFAPBJJLPAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2740DA0", Offset = "0x273F3A0", VA = "0x182740DA0")]
	public OMFLCPIEIAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x273DE30", Offset = "0x273C430", VA = "0x18273DE30")]
	[CompilerGenerated]
	internal static (int, int?) ECFIBPILKMF(LCJCDJGDDFO MGBNDHKGDLB)
	{
		return default((int, int?));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface JOACNNBBDGA
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<EGKNCMFMAMB<BHCGDDFBDAJ, BFLIDGJOJDI>> JIHFIELHEOI(string FMLPKHHAKIF, long JJCIAKAHHPE, CKOCLAJPHIF.FNBDNFIGDMM BNKAKELBBBG, CancellationToken OOAGLCBNIOG);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal class FILCLFEOPHI : CNCKLBJLJDM<IHCOLCCANMI>
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class MBEBJEMIHCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public IHCOLCCANMI message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public MBEBJEMIHCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x36BC740", Offset = "0x36BAD40", VA = "0x1836BC740")]
		internal object JGMCMOPEHCM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public static readonly FILCLFEOPHI FBBAELKBDJK;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private const string ADLBMKENNDI = "pl";

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x219EF90", Offset = "0x219D590", VA = "0x18219EF90")]
	public ExitGames.Client.Photon.Hashtable DHDFEGACAHE(IHCOLCCANMI JIEHBANCLJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x219F510", Offset = "0x219DB10", VA = "0x18219F510", Slot = "5")]
	protected override void IDOCKJIBDPO(IHCOLCCANMI JIEHBANCLJP, IDictionary<object, object> GOMDNNCBLHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x219F010", Offset = "0x219D610", VA = "0x18219F010", Slot = "6")]
	public override IHCOLCCANMI EMHFJGFFMPB(IDictionary<object, object> GOMDNNCBLHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x219EE00", Offset = "0x219D400", VA = "0x18219EE00")]
	private static void BKMKBHBEAIO(string HOPGNEBLALB, IHCOLCCANMI JIEHBANCLJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x219F6C0", Offset = "0x219DCC0", VA = "0x18219F6C0")]
	public FILCLFEOPHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x219F210", Offset = "0x219D810", VA = "0x18219F210")]
	[CompilerGenerated]
	internal static string FGEHPBNCJPJ(FICOENLLCNC OGLJJNFALNA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface IDCCJJOFNJF<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<EGKNCMFMAMB<byte[], BFLIDGJOJDI>> GPFLJKCKEKL(TGetDataArg NPIEBOHJFEN, CancellationToken OOAGLCBNIOG);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EGKNCMFMAMB<AIIIIIPEBCO<TData>, BFLIDGJOJDI> GBHOOLHFLDH(byte[] GOMDNNCBLHP);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface CHBGONFBKJD : IAMLOLAILNM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LOJBOFKMJHM GEFGJDMDPAK(IFFNBNNJJLC OBBBOIELLGM);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class GPEPNEFFPAA : BIILEFFLIAA, MINCKNFAMAH, DCFHCGLJFIC, BHMILIMCEBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly MINCKNFAMAH FCIACBBLJJO;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IFFNBNNJJLC JECPHNFACIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x21A25F0", Offset = "0x21A0BF0", VA = "0x1821A25F0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int ONFGNKIGPMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x21A2500", Offset = "0x21A0B00", VA = "0x1821A2500", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int LMLIENFPOIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x21A2270", Offset = "0x21A0870", VA = "0x1821A2270", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool CPFCCLPOFKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x9146D0", Offset = "0x912CD0", VA = "0x1809146D0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int NCFHGCIGLGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x923800", Offset = "0x921E00", VA = "0x180923800", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event JHMOEKCGHBE.FJDGKCKHPKE JCKHOAHANOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event NCMMPHNOBJC FLMDNJDEKKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x21A2400", Offset = "0x21A0A00", VA = "0x1821A2400", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x21A2360", Offset = "0x21A0960", VA = "0x1821A2360", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<bool> KFLOABFMPPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<IFFNBNNJJLC> ABDLHMKJJJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action FLGHAMCODBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x21A2120", Offset = "0x21A0720", VA = "0x1821A2120", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x21A2550", Offset = "0x21A0B50", VA = "0x1821A2550", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x1EE2010", Offset = "0x1EE0610", VA = "0x181EE2010")]
	public GPEPNEFFPAA(MINCKNFAMAH FCIACBBLJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x21A21C0", Offset = "0x21A07C0", VA = "0x1821A21C0", Slot = "8")]
	public bool AGIKDPLBPKN(byte JDOBIJECHGP, ExitGames.Client.Photon.Hashtable LHFGBLOHCDJ, OPNNNEOLELI CNLFKEHOJLK, SendOptions FJCHGKHPLBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x21A22C0", Offset = "0x21A08C0", VA = "0x1821A22C0", Slot = "29")]
	public IFFNBNNJJLC ELABINEJPCG(int AKLIDLAOPLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x21A2640", Offset = "0x21A0C40", VA = "0x1821A2640", Slot = "16")]
	public IFFNBNNJJLC MNJENCPHMNP(int DCMDLBGKIGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "19")]
	public void JOOCHNNOLJH(object LODBJLOKBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "20")]
	public void EIMPMKCCOPM(object LODBJLOKBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "21")]
	public void CAPFPAFPMHI(object LODBJLOKBLP, bool IIFGOHENMGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x21A24A0", Offset = "0x21A0AA0", VA = "0x1821A24A0", Slot = "22")]
	public IDisposable IKHBODAIDFJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x915250", Offset = "0x913850", VA = "0x180915250", Slot = "23")]
	private bool ADJLIEHCDIG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "24")]
	public void DPCJNLKOMJG(StringBuilder BPNDDLCMKHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x21A2720", Offset = "0x21A0D20", VA = "0x1821A2720", Slot = "25")]
	public bool MPLMBOLCFPA(bool ONPOICBLGCI, out string KAEDNDEPIBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750")]
	public void BOHEAABCJPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x94FF20", Offset = "0x94E520", VA = "0x18094FF20", Slot = "28")]
	public void BPJHPHILKHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal struct PPMBFMOHLAB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly TaskCompletionSource<(LOJBOFKMJHM, Task)> HGFADBJDJBI;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Task<(LOJBOFKMJHM, Task)> JKBDBBIEIDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x2744E80", Offset = "0x2743480", VA = "0x182744E80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x2744F50", Offset = "0x2743550", VA = "0x182744F50")]
	public PPMBFMOHLAB(TimeSpan FPFPGODCNAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x2744D50", Offset = "0x2743350", VA = "0x182744D50")]
	public void HGPDOGIBAIH(Task BNJGBDJALJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x2744DF0", Offset = "0x27433F0", VA = "0x182744DF0")]
	public void IMHCELFBHOJ(LOJBOFKMJHM COGNPIMIJHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2744D00", Offset = "0x2743300", VA = "0x182744D00")]
	public void FBBMHGGHIJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2744EC0", Offset = "0x27434C0", VA = "0x182744EC0")]
	internal void NEBLHPDCGIF(string JIEHBANCLJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal class KPGDKKBAEOE : MGDFKIMJGLA, BGBDFCFKDKN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private bool LGMMFDHHNEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private BKDLHCNELBM ALOLCPJNGKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private HDOGFNJHJAM EGGPOCDMEIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private FBHPBCKJNFM GKLJDKMPGML;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public BKDLHCNELBM IMMDGJNNAGB
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x21ABC30", Offset = "0x21AA230", VA = "0x1821ABC30", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x21ABEA0", Offset = "0x21AA4A0", VA = "0x1821ABEA0", Slot = "7")]
	public void KGHKJOCLFMF(LCNJJEKDLHB LCPJEGLKADH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x21ABCE0", Offset = "0x21AA2E0", VA = "0x1821ABCE0", Slot = "5")]
	public void EGJLOLFCDGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x21ABCA0", Offset = "0x21AA2A0", VA = "0x1821ABCA0", Slot = "6")]
	public void FBANBNIJGMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x21AC010", Offset = "0x21AA610", VA = "0x1821AC010")]
	private Task LLAEPOOBDLA(IJMIMPABEKF HHOBHGKDNLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x21ABCA0", Offset = "0x21AA2A0", VA = "0x1821ABCA0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0xA47430", Offset = "0xA45A30", VA = "0x180A47430")]
	public KPGDKKBAEOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal struct BOEOOPOGPHA
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class DKCKPCBMFMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public LCNJJEKDLHB manager;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public DKCKPCBMFMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x272F060", Offset = "0x272D660", VA = "0x18272F060")]
		internal Task DHNDGJEPFCG(EPFFDDEKBCK data, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class DBGBDLDCFAL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public BOEOOPOGPHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private long <roomId>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private long <subroomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private KFADJCAHNKD <autosaveInfo>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private HIMGEOONAEO <response>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private HIMGEOONAEO <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private HIMGEOONAEO <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private TaskAwaiter<HIMGEOONAEO> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private TaskAwaiter<LOJBOFKMJHM> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public DBGBDLDCFAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x272EA30", Offset = "0x272D030", VA = "0x18272EA30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class KCLHAEFAECA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public BOEOOPOGPHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public KCLHAEFAECA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x27320E0", Offset = "0x27306E0", VA = "0x1827320E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private readonly CancellationToken OOAGLCBNIOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private readonly LCNJJEKDLHB HGEKNDJMGCO;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private HDOGFNJHJAM NAKEOKLMHPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x218F5E0", Offset = "0x218DBE0", VA = "0x18218F5E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private OPEIFKONHHI JLLINPPOIKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x218F780", Offset = "0x218DD80", VA = "0x18218F780")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private CFIDKJEMCJA NNHNHPMAIMC
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x218F970", Offset = "0x218DF70", VA = "0x18218F970")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private EKDLKAIMKEM CNIOEPBDABP
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x218F590", Offset = "0x218DB90", VA = "0x18218F590")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x218F9F0", Offset = "0x218DFF0", VA = "0x18218F9F0")]
	public BOEOOPOGPHA(CancellationToken OOAGLCBNIOG, LCNJJEKDLHB HGEKNDJMGCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x218F4D0", Offset = "0x218DAD0", VA = "0x18218F4D0")]
	public static IHBKKDGIGFD HJDKALCGPMF(LCNJJEKDLHB HGEKNDJMGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x218F630", Offset = "0x218DC30", VA = "0x18218F630")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DBGBDLDCFAL))]
	public Task<bool> INHJMLKPHDN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x218F7D0", Offset = "0x218DDD0", VA = "0x18218F7D0")]
	private bool LNCNNOIMIPF(out KFADJCAHNKD KBEMOJLMDPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x218F3B0", Offset = "0x218D9B0", VA = "0x18218F3B0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KCLHAEFAECA))]
	private Task CLFPJNFFCGH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x218F280", Offset = "0x218D880", VA = "0x18218F280")]
	private Task<HIMGEOONAEO> ACAMDOCDJIM(KFADJCAHNKD FEBMBKEKLGM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal class MIHIELGFFCN : FBHPBCKJNFM
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private class FBJAGFCCAAP<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private readonly GOAKOJLIONO EPJKBBIHJJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private readonly string NAJDAPHOGEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private readonly T LLDPFOJMFMC;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public T CNODGJBIHLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0xA33AD0", Offset = "0xA320D0", VA = "0x180A33AD0")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0xA34370", Offset = "0xA32970", VA = "0x180A34370")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x16588D0", Offset = "0x1656ED0", VA = "0x1816588D0")]
		public FBJAGFCCAAP(GOAKOJLIONO EPJKBBIHJJH, string NAJDAPHOGEH, T LLDPFOJMFMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x1658580", Offset = "0x1656B80", VA = "0x181658580")]
		private void NONGPCFIHPP()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly GOAKOJLIONO EPJKBBIHJJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly FBJAGFCCAAP<TimeSpan> BDHABAKKOHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private readonly FBJAGFCCAAP<TimeSpan> NBOAIIGOGGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private readonly FBJAGFCCAAP<TimeSpan> BFEMDAHFAGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly FBJAGFCCAAP<TimeSpan> BKJDDHGDAHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly FBJAGFCCAAP<bool> JDHFHPGFKKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly FBJAGFCCAAP<bool> CNPJCLFBBKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly FBJAGFCCAAP<bool> IAAPIKJFDLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly FBJAGFCCAAP<int> PEPAJGKMJAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private readonly FBJAGFCCAAP<bool> CCOHNCOFDOM;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private const string CIMIPGCEKMC = "RoomLoadCameraFadeTimeout";

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public TimeSpan JINNNOIBFEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x2735FB0", Offset = "0x27345B0", VA = "0x182735FB0", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public TimeSpan MMIMMFGJHDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x2736070", Offset = "0x2734670", VA = "0x182736070", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public TimeSpan JICAFBFBENC
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x27360B0", Offset = "0x27346B0", VA = "0x1827360B0", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public TimeSpan HHOPMDODBBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x2735CB0", Offset = "0x27342B0", VA = "0x182735CB0", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool CGMONIFALJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x2736030", Offset = "0x2734630", VA = "0x182736030", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool CKJHAALMHHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x27360F0", Offset = "0x27346F0", VA = "0x1827360F0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool OGOKIFNDDAN
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x2735CF0", Offset = "0x27342F0", VA = "0x182735CF0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int CHDPKDLBDGE
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x2735D30", Offset = "0x2734330", VA = "0x182735D30", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool EIHFGJHAPII
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x2735FF0", Offset = "0x27345F0", VA = "0x182735FF0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool AEEEJHLJMOC
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x2735D70", Offset = "0x2734370", VA = "0x182735D70", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public TimeSpan EJHCLANDEEN
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x2735E60", Offset = "0x2734460", VA = "0x182735E60", Slot = "12")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x2736130", Offset = "0x2734730", VA = "0x182736130")]
	[UnityEngine.Scripting.Preserve]
	public MIHIELGFFCN([NALHKAIJJND(null)] GOAKOJLIONO EPJKBBIHJJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal struct HAILGCDDANM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class ILEFDFJBAEL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public Func<CancellationToken, List<Task>> taskGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public HAILGCDDANM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private List<Task> <tasks>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public ILEFDFJBAEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x36B8630", Offset = "0x36B6C30", VA = "0x1836B8630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private readonly CancellationTokenSource NAANFKJBCAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private bool OCBEMDEOMOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private Task DNEHMOFNGIO;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool PLFPHKBCLKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x21A4DB0", Offset = "0x21A33B0", VA = "0x1821A4DB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	internal Task JKBDBBIEIDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x21A4E30", Offset = "0x21A3430", VA = "0x1821A4E30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x21A5010", Offset = "0x21A3610", VA = "0x1821A5010")]
	public HAILGCDDANM(CancellationToken OOAGLCBNIOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x21A4EB0", Offset = "0x21A34B0", VA = "0x1821A4EB0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ILEFDFJBAEL))]
	public Task MBAELBBGANH(Func<CancellationToken, List<Task>> APDNFHFKHGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x21A4DE0", Offset = "0x21A33E0", VA = "0x1821A4DE0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal interface BLFLOOPKKNO : BGBDFCFKDKN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JABIOEONLNK PEECNHFNIGK(Guid MGMFLGBPLHJ);

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FAKCPBGGFBC(Guid MGMFLGBPLHJ);

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LNCKJIBGBBA(Guid MGMFLGBPLHJ, Task BNJGBDJALJP);

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JFEDOBBDBJM(Guid MGMFLGBPLHJ, LOJBOFKMJHM JDCJJJNPNGO);

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool HEJEPKMNJEJ(Guid MGMFLGBPLHJ);

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<(LOJBOFKMJHM, Task)> APGLAJPICBI(Guid MGMFLGBPLHJ);
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
internal interface CHJKBIICEEH : BGBDFCFKDKN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LOJBOFKMJHM HIPOAICLEDN(IFFNBNNJJLC JMFJDNIANCF, AEHILIDANGI OHEOBBDEKJD);

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LOJBOFKMJHM MMNLFGJAICL(IFFNBNNJJLC OBBBOIELLGM);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LOJBOFKMJHM GLGKHDPDNOM(IFFNBNNJJLC OBBBOIELLGM);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal class CMFLAOJGNGI : LPHHGEPCEJL
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class BGIMIAIAGAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public CMFLAOJGNGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private LHJOLIPPMAL <localRoomInstance>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private long <currentInstanceId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private bool <currentIsOffline>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private LHJOLIPPMAL <newPresenceRoomInstance>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private float <timeoutTime>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public BGIMIAIAGAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x36ADDD0", Offset = "0x36AC3D0", VA = "0x1836ADDD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private const float KEGPEMHCKJM = 300f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private readonly LCNJJEKDLHB LCPJEGLKADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private readonly OPEIFKONHHI OODHPHIHFDJ;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private CFIDKJEMCJA NNHNHPMAIMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x2193C60", Offset = "0x2192260", VA = "0x182193C60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x953E90", Offset = "0x952490", VA = "0x180953E90")]
	public CMFLAOJGNGI(LCNJJEKDLHB LCPJEGLKADH, OPEIFKONHHI OODHPHIHFDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x21939B0", Offset = "0x2191FB0", VA = "0x1821939B0", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BGIMIAIAGAF))]
	public Task<bool> ADNIBPILCBG(CancellationToken OOAGLCBNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x2193B20", Offset = "0x2192120", VA = "0x182193B20")]
	[CompilerGenerated]
	private object BNKGDNKLECJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal interface KBKKOEPHAMN : BGBDFCFKDKN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GEMKOAJKCAE(IHCOLCCANMI JIEHBANCLJP);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DFKPHPEFNEO(IHCOLCCANMI JIEHBANCLJP);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<AEHILIDANGI> IMBMDIJPJOL(CancellationToken HAJHODBJFLK);
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
internal interface KLKIBPNICGK : BGBDFCFKDKN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LOJBOFKMJHM JBILOBDCJIC(IFFNBNNJJLC JMFJDNIANCF);

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task HKAOLLJNAJN(string PCCHHIAICLC);
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[UnityEngine.Scripting.Preserve]
internal class MPALCABBFEM : JHPIEPEAANO, BGBDFCFKDKN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class CKECOIOEABK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public MPALCABBFEM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private MLOCEEOLAMF.FNBAANFJAOH <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private Exception <ex>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public CKECOIOEABK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x3EC81A0", Offset = "0x3EC67A0", VA = "0x183EC81A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private readonly KMGFNNFFDCD AJJFMJFEODB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private string LHEFLBKMJJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private Task DIACKKOOCIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private LCNJJEKDLHB LCPJEGLKADH;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool KGHKFCCBODD
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x2737360", Offset = "0x2735960", VA = "0x182737360", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public Task HIIELKDOEDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x2737550", Offset = "0x2735B50", VA = "0x182737550", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x943F60", Offset = "0x942560", VA = "0x180943F60", Slot = "7")]
	public void KGHKJOCLFMF(LCNJJEKDLHB LCPJEGLKADH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x2737390", Offset = "0x2735990", VA = "0x182737390", Slot = "6")]
	public void LBKCILFDIEO(Task DNEHMOFNGIO, string LOFLPEAOEIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x27371F0", Offset = "0x27357F0", VA = "0x1827371F0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CKECOIOEABK))]
	private Task DLPICBNOBCD(Task JNPJNKFEJCH, string LOFLPEAOEIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x27375B0", Offset = "0x2735BB0", VA = "0x1827375B0")]
	public MPALCABBFEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal struct JABIOEONLNK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly BLFLOOPKKNO LKBMOPHNNMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly Guid MGMFLGBPLHJ;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private Task<(LOJBOFKMJHM, Task)> JKBDBBIEIDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x21A8F70", Offset = "0x21A7570", VA = "0x1821A8F70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x15C38C0", Offset = "0x15C1EC0", VA = "0x1815C38C0")]
	public JABIOEONLNK(BLFLOOPKKNO LKBMOPHNNMK, Guid MGMFLGBPLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x21A8E50", Offset = "0x21A7450", VA = "0x1821A8E50")]
	public TaskAwaiter<(LOJBOFKMJHM, Task)> AHOLKDCPEHF()
	{
		return default(TaskAwaiter<(LOJBOFKMJHM, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x21A8EA0", Offset = "0x21A74A0", VA = "0x1821A8EA0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[UnityEngine.Scripting.Preserve]
internal sealed class NFDLMHGGMEG : EKDLKAIMKEM, BGBDFCFKDKN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class BEAALPLJPLA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public AsyncTaskMethodBuilder<LOJBOFKMJHM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public KFADJCAHNKD autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public NFDLMHGGMEG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private NHNLOHOBNME<string> <timer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private NHNLOHOBNME<string>.NOELMCIDFEB <timerScope>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private AOKPMOGMDBO <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private NHNLOHOBNME<string>.NOELMCIDFEB <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private FICOENLLCNC <roomLoadPayload>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private LOJBOFKMJHM <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private TaskAwaiter<LOJBOFKMJHM> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public BEAALPLJPLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x3EC6E10", Offset = "0x3EC5410", VA = "0x183EC6E10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class EOKOKMHGJGL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public NFDLMHGGMEG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private CancellationTokenSource <combinedTokenSource>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private Exception <ex>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public EOKOKMHGJGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x3ECB5C0", Offset = "0x3EC9BC0", VA = "0x183ECB5C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class AHPHHCKOPDA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public EPFFDDEKBCK _;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public NFDLMHGGMEG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public AHPHHCKOPDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x3EC66E0", Offset = "0x3EC4CE0", VA = "0x183EC66E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class PPHCEOJCBJM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public NFDLMHGGMEG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private object <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private int <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public PPHCEOJCBJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3EDB180", Offset = "0x3ED9780", VA = "0x183EDB180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class AMGMMJBCJGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public NFDLMHGGMEG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public AMGMMJBCJGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x3EC6BA0", Offset = "0x3EC51A0", VA = "0x183EC6BA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class MPPNHOIGNGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public NFDLMHGGMEG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private CancellationToken <nextAutosaveToken>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private Exception <ex>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public MPPNHOIGNGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3ED4AD0", Offset = "0x3ED30D0", VA = "0x183ED4AD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class BJPBNDCNFHI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public CancellationToken nextAutosaveToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public NFDLMHGGMEG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private Task <delayTask>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private Task<int> <intervalChangedTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private Task <resultTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private Task <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public BJPBNDCNFHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x3EC76A0", Offset = "0x3EC5CA0", VA = "0x183EC76A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class GOFLNAHPGDF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public ELOHJNEJPLG autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public NFDLMHGGMEG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private NHNLOHOBNME<string> <timer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		private NHNLOHOBNME<string>.NOELMCIDFEB <timerScope>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private JMODPMGGFBH <operationPauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private MLOMGBPGOKG <autosaveOp>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public GOFLNAHPGDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x3ECE250", Offset = "0x3ECC850", VA = "0x183ECE250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private HDOGFNJHJAM EGGPOCDMEIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private LCNJJEKDLHB LCPJEGLKADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private OPEIFKONHHI OODHPHIHFDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private FAODONACOCN BLFDAKOGHLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private JHPIEPEAANO FGADNKOBCHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private NCFNNACHIOO JHOJFHKAEBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private CancellationTokenSource NEHAAJCOKLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private Task ANBLGGLCMIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private TaskCompletionSource<int> DOBMEONGIMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private int PCGMHPPGOHB;

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x27382B0", Offset = "0x27368B0", VA = "0x1827382B0", Slot = "6")]
	public void KGHKJOCLFMF(LCNJJEKDLHB LCPJEGLKADH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0xCCBD00", Offset = "0xCCA300", VA = "0x180CCBD00", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x2737D90", Offset = "0x2736390", VA = "0x182737D90")]
	private void GILMBGDLJLN(float BLLLOHHMKLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x2738460", Offset = "0x2736A60", VA = "0x182738460", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BEAALPLJPLA))]
	public Task<LOJBOFKMJHM> MIFDCAFMPPK(KFADJCAHNKD KBEMOJLMDPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x2738790", Offset = "0x2736D90", VA = "0x182738790", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EOKOKMHGJGL))]
	public Task OEBDHLJDDAL([Optional] CancellationToken OOAGLCBNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0xCCBD00", Offset = "0xCCA300", VA = "0x180CCBD00")]
	public void OGBGABMDDEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x27385D0", Offset = "0x2736BD0", VA = "0x1827385D0")]
	private AOKPMOGMDBO OANNAGCFAIE(KFADJCAHNKD KBEMOJLMDPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x2737E70", Offset = "0x2736470", VA = "0x182737E70")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AHPHHCKOPDA))]
	private Task IPLOCIOIFLA(EPFFDDEKBCK HHOBHGKDNLP, CancellationToken OHDMAIAEMEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x27379A0", Offset = "0x2735FA0", VA = "0x1827379A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PPHCEOJCBJM))]
	private Task APDEKHOFPBJ(CancellationToken OHDMAIAEMEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x2738BF0", Offset = "0x27371F0", VA = "0x182738BF0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AMGMMJBCJGO))]
	private Task PMFEPHLGFCE([Optional] CancellationToken OOAGLCBNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x2737AF0", Offset = "0x27360F0", VA = "0x182737AF0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MPPNHOIGNGI))]
	private Task COOBCCPOJAL(CancellationToken OHDMAIAEMEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x2737C40", Offset = "0x2736240", VA = "0x182737C40")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BJPBNDCNFHI))]
	private Task FAJFOIEANMP(CancellationToken MHEPOCKLKHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x27388E0", Offset = "0x2736EE0", VA = "0x1827388E0")]
	private Task OLOEJEDGCBI(ELOHJNEJPLG FLILMALMEBH, CancellationToken OHDMAIAEMEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x2738150", Offset = "0x2736750", VA = "0x182738150")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GOFLNAHPGDF))]
	private Task JCMJMMIIJDB(ELOHJNEJPLG FLILMALMEBH, CancellationToken OHDMAIAEMEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x2737FE0", Offset = "0x27365E0", VA = "0x182737FE0")]
	private bool JBILOBDCJIC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
	public NFDLMHGGMEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface CHOIGDNKNLL : IAMLOLAILNM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LOJBOFKMJHM JBILOBDCJIC(IFFNBNNJJLC HIPPLAKEHCK);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[UnityEngine.Scripting.Preserve]
internal class MADHFCJLPGL : GAPOBIJHCCD, BGBDFCFKDKN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	private class CIEPABOHKHO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private readonly LHJOLIPPMAL IGLKGEMHDKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private readonly CancellationTokenSource NAANFKJBCAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public readonly CancellationToken DDBGPDFFCBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private bool NNCBNMBIJLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private bool EAOOMFEELLL;

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x3EC80F0", Offset = "0x3EC66F0", VA = "0x183EC80F0")]
		public CIEPABOHKHO(LHJOLIPPMAL IGLKGEMHDKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x3EC7FA0", Offset = "0x3EC65A0", VA = "0x183EC7FA0")]
		public void HEJEPKMNJEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3EC7F70", Offset = "0x3EC6570", VA = "0x183EC7F70", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class FDJAIMFLDKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public IJMIMPABEKF disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public FDJAIMFLDKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x3ECC860", Offset = "0x3ECAE60", VA = "0x183ECC860")]
		internal object IHGDAFMFHFH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class MFFKIIHLJPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public IJMIMPABEKF disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public MADHFCJLPGL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private FDJAIMFLDKB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private MLOCEEOLAMF.FNBAANFJAOH <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public MFFKIIHLJPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x3ED3BC0", Offset = "0x3ED21C0", VA = "0x183ED3BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class BJCDPEEBJEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public int playerId;

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public BJCDPEEBJEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x3EC7630", Offset = "0x3EC5C30", VA = "0x183EC7630")]
		internal object MCGAPOOOCNC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class NAGALHANCHF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public MADHFCJLPGL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private BJCDPEEBJEK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private IDisposable <logFlagsScope>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private IDisposable <logTraceScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private IDisposable <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private IDisposable <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private MLOCEEOLAMF.FNBAANFJAOH <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private LHJOLIPPMAL <newRoomInstance>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private JALCPALKLOC <customRoomLoadPayload>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		private Exception <ex>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public NAGALHANCHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x3ED5280", Offset = "0x3ED3880", VA = "0x183ED5280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class AJDIIOJANKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public LHJOLIPPMAL newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public AJDIIOJANKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x3EC6AC0", Offset = "0x3EC50C0", VA = "0x183EC6AC0")]
		internal object KKGOEIPCKBB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x3EC6A80", Offset = "0x3EC5080", VA = "0x183EC6A80")]
		internal object INMDPLLMGIN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x3EC6B60", Offset = "0x3EC5160", VA = "0x183EC6B60")]
		internal object LNELPFFEBPA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class OALENNONPAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public long id;

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public OALENNONPAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x3ED95A0", Offset = "0x3ED7BA0", VA = "0x183ED95A0")]
		internal void FBIOMFJMMMP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class IIFNLKEJIJM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public LHJOLIPPMAL newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public JALCPALKLOC customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public MADHFCJLPGL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private AJDIIOJANKA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private MLOCEEOLAMF.FNBAANFJAOH <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private OALENNONPAN <>8__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private CancellationToken <token>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private CancellationTokenRegistration <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		private object <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private int <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		private OperationCanceledException <oce>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private Exception <ex>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public IIFNLKEJIJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x3ECF120", Offset = "0x3ECD720", VA = "0x183ECF120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private PDCFACENKHF MBHFEKHOEDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private LCNJJEKDLHB LCPJEGLKADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private IODPKOEAPFI EDJMKLNLNLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private OPEIFKONHHI OODHPHIHFDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private FBHPBCKJNFM GKLJDKMPGML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private AFOGPGOCCBM FKJFMCGFCGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private long DPNEELHKLPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private CIEPABOHKHO DGFHDCEMJBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private bool NKLLOJJIIDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private Task HDENHGLIPHD;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private CFIDKJEMCJA NNHNHPMAIMC
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x2734A30", Offset = "0x2733030", VA = "0x182734A30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool KHMEOGFAHEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x9440C0", Offset = "0x9426C0", VA = "0x1809440C0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x2734A20", Offset = "0x2733020", VA = "0x182734A20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x2734490", Offset = "0x2732A90", VA = "0x182734490", Slot = "4")]
	public void KGHKJOCLFMF(LCNJJEKDLHB LCPJEGLKADH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x2733DD0", Offset = "0x27323D0", VA = "0x182733DD0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x2734A80", Offset = "0x2733080", VA = "0x182734A80")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MFFKIIHLJPK))]
	private Task PEDGEHCJONF(IJMIMPABEKF DBILKGILBCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x27340F0", Offset = "0x27326F0", VA = "0x1827340F0")]
	private void GFBKAMOBFAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x2734BC0", Offset = "0x27331C0", VA = "0x182734BC0")]
	private void PFLAPDDDOPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x2734780", Offset = "0x2732D80", VA = "0x182734780")]
	private void MDLEDDPNBNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x27349A0", Offset = "0x2732FA0", VA = "0x1827349A0")]
	private bool MGJBJNIHLLD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x27351A0", Offset = "0x27337A0", VA = "0x1827351A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NAGALHANCHF))]
	private void PNDFEKOILJE(int GEIGFOMNNFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x2734DF0", Offset = "0x27333F0", VA = "0x182734DF0")]
	private void PKIENAGNPFN(out IDisposable NCKJCLJAOJL, out IDisposable CBNBNAKKPIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x2733F50", Offset = "0x2732550", VA = "0x182733F50")]
	private bool FBKIJEGDLAE(LHJOLIPPMAL IGLKGEMHDKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x2734740", Offset = "0x2732D40", VA = "0x182734740")]
	private void MAKAEOPOIKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x2734320", Offset = "0x2732920", VA = "0x182734320")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IIFNLKEJIJM))]
	private Task JMLHFCMMJMP(LHJOLIPPMAL IGLKGEMHDKK, JALCPALKLOC CIPBLKCJDGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x2735290", Offset = "0x2733890", VA = "0x182735290")]
	public MADHFCJLPGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[UnityEngine.Scripting.Preserve]
internal sealed class GPGOMDACMDH : OGKLPLJCFFC, BGBDFCFKDKN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private sealed class KCEKLMIBJND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public KCEKLMIBJND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x36B9FE0", Offset = "0x36B85E0", VA = "0x1836B9FE0")]
		internal object NGNKLOIKIEM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private sealed class FFKKHODJDNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public FFKKHODJDNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x36B52C0", Offset = "0x36B38C0", VA = "0x1836B52C0")]
		internal object CNLGDHKCINF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private HDOGFNJHJAM EGGPOCDMEIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private CHJKBIICEEH MLDBCLJMNLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private KBKKOEPHAMN OFOCDFIEGPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private BLFLOOPKKNO LKBMOPHNNMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private KHACHKKFIMN JPDLCAKMPOF;

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x21A36E0", Offset = "0x21A1CE0", VA = "0x1821A36E0", Slot = "6")]
	public void KGHKJOCLFMF(LCNJJEKDLHB LCPJEGLKADH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x21A2C30", Offset = "0x21A1230", VA = "0x1821A2C30", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x21A48A0", Offset = "0x21A2EA0", VA = "0x1821A48A0", Slot = "4")]
	public JABIOEONLNK PECJCNFIBGD(IHCOLCCANMI JJJAGMMBGDH)
	{
		return default(JABIOEONLNK);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x21A29B0", Offset = "0x21A0FB0", VA = "0x1821A29B0", Slot = "5")]
	public void DIMIFBKKJPL(Guid MGMFLGBPLHJ, Task BNJGBDJALJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x21A32F0", Offset = "0x21A18F0", VA = "0x1821A32F0")]
	private void FGHHNJKCMFD(byte JDOBIJECHGP, int NNPKLLDAPNB, object OBHBDCGEPGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x21A3850", Offset = "0x21A1E50", VA = "0x1821A3850")]
	private void MDPGOHLFPHB(EIGPMKDHLGJ OHLDPOJHAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x21A2CD0", Offset = "0x21A12D0", VA = "0x1821A2CD0")]
	private void EBOKFHDAFNA(EIGPMKDHLGJ OHLDPOJHAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x21A4010", Offset = "0x21A2610", VA = "0x1821A4010")]
	private void MHIHAOMJKEH(EIGPMKDHLGJ OHLDPOJHAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x21A42E0", Offset = "0x21A28E0", VA = "0x1821A42E0")]
	private LOJBOFKMJHM NOBJPEMAFGM(IHCOLCCANMI IDIAJJIINJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x21A2740", Offset = "0x21A0D40", VA = "0x1821A2740")]
	private void BPJIODKNKGB(IHCOLCCANMI NBOHPBPLMJP, LOJBOFKMJHM COGNPIMIJHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x21A2FC0", Offset = "0x21A15C0", VA = "0x1821A2FC0")]
	private bool EMPOIEOPNFO(IHCOLCCANMI NBOHPBPLMJP, LOJBOFKMJHM COGNPIMIJHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x21A45B0", Offset = "0x21A2BB0", VA = "0x1821A45B0")]
	private bool PABMGNOFOEK(IHCOLCCANMI OMGNMHLGPJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x21A33C0", Offset = "0x21A19C0", VA = "0x1821A33C0")]
	private bool JLJLIDIJFND(byte JDOBIJECHGP, ExitGames.Client.Photon.Hashtable OHLDPOJHAKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
	public GPGOMDACMDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[UnityEngine.Scripting.Preserve]
internal sealed class DJBCLGKPEOD : KBKKOEPHAMN, BGBDFCFKDKN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class DLFBFNJPAED : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public AsyncTaskMethodBuilder<AEHILIDANGI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public DJBCLGKPEOD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private AEHILIDANGI <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private TaskAwaiter<AEHILIDANGI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public DLFBFNJPAED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x36B0940", Offset = "0x36AEF40", VA = "0x1836B0940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class APNGALKPMBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public IHCOLCCANMI message;

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public APNGALKPMBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x36ADD70", Offset = "0x36AC370", VA = "0x1836ADD70")]
		internal object OPCJMLLABHI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class CFNFBFBNIGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public IHCOLCCANMI messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public CFNFBFBNIGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x36AEAE0", Offset = "0x36AD0E0", VA = "0x1836AEAE0")]
		internal object DLHPMLGNMIN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class HOLMEEAHLCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public IHCOLCCANMI request;

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public HOLMEEAHLCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x36B7840", Offset = "0x36B5E40", VA = "0x1836B7840")]
		internal object PDDMAKPDCCA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class EEFFJMBHANI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public IHCOLCCANMI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		public DJBCLGKPEOD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private HOLMEEAHLCN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private MLOCEEOLAMF.FNBAANFJAOH <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		private CDNJKKMBNED <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		private CDNJKKMBNED <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		private TaskAwaiter<CDNJKKMBNED> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public EEFFJMBHANI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x36B21B0", Offset = "0x36B07B0", VA = "0x1836B21B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private sealed class CGAMJOFIAJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public IHCOLCCANMI operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public CGAMJOFIAJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x36AEB40", Offset = "0x36AD140", VA = "0x1836AEB40")]
		internal object PNPNFDEADCE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class AEKEDGDDPKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		public IHCOLCCANMI operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		public DJBCLGKPEOD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		private CGAMJOFIAJI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		private MLOCEEOLAMF.FNBAANFJAOH <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private JMODPMGGFBH <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private IHCOLCCANMI <syncedMessage>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private CDNJKKMBNED <operation>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private IHCOLCCANMI <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		private IDisposable <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		private TaskAwaiter<IHCOLCCANMI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public AEKEDGDDPKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x36AC630", Offset = "0x36AAC30", VA = "0x1836AC630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private sealed class EKDFAINCOLL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		public AsyncTaskMethodBuilder<CDNJKKMBNED> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		public IHCOLCCANMI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		public DJBCLGKPEOD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private MLOCEEOLAMF.FNBAANFJAOH <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private JMODPMGGFBH <pauseToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		private IHCOLCCANMI <response>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		private IHCOLCCANMI <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		private TaskAwaiter<IHCOLCCANMI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public EKDFAINCOLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x36B3180", Offset = "0x36B1780", VA = "0x1836B3180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private sealed class LAPFJAKMAGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		public CDNJKKMBNED operation;

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public LAPFJAKMAGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x36BBF80", Offset = "0x36BA580", VA = "0x1836BBF80")]
		internal object AFLCKOHGEKE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class FBBJJGALKAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		public CDNJKKMBNED operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public DJBCLGKPEOD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		private LAPFJAKMAGJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		private MLOCEEOLAMF.FNBAANFJAOH <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		private NHNLOHOBNME<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		private NHNLOHOBNME<string>.NOELMCIDFEB <timerScope>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private Task <task>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public FBBJJGALKAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x36B4940", Offset = "0x36B2F40", VA = "0x1836B4940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private sealed class CMFLOGOPNDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		public IHCOLCCANMI request;

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public CMFLOGOPNDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x36AEF80", Offset = "0x36AD580", VA = "0x1836AEF80")]
		internal object JGLBEMJCLIF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private sealed class EIAFPLIHPOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		public IHCOLCCANMI request;

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public EIAFPLIHPOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x36B2940", Offset = "0x36B0F40", VA = "0x1836B2940")]
		internal object LFFEGLKIIKN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	private LCNJJEKDLHB LCPJEGLKADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	private JHPIEPEAANO FGADNKOBCHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private OGKLPLJCFFC JNHPCABGHGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private FAODONACOCN BLFDAKOGHLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	private HDOGFNJHJAM EGGPOCDMEIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	private TaskCompletionSource<AEHILIDANGI> PCKFFNIAHPH;

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x2195B50", Offset = "0x2194150", VA = "0x182195B50", Slot = "7")]
	public void KGHKJOCLFMF(LCNJJEKDLHB LCPJEGLKADH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x21959E0", Offset = "0x2193FE0", VA = "0x1821959E0", Slot = "6")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DLFBFNJPAED))]
	public Task<AEHILIDANGI> IMBMDIJPJOL(CancellationToken HAJHODBJFLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x2195570", Offset = "0x2193B70", VA = "0x182195570", Slot = "4")]
	public void GEMKOAJKCAE(IHCOLCCANMI JIEHBANCLJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x2194980", Offset = "0x2192F80", VA = "0x182194980", Slot = "5")]
	public void DFKPHPEFNEO(IHCOLCCANMI DKGIGNINFAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x2194F50", Offset = "0x2193550", VA = "0x182194F50")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EEFFJMBHANI))]
	private Task ENINMPPLCNJ(IHCOLCCANMI PKNENDONMCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x2195C30", Offset = "0x2194230", VA = "0x182195C30")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AEKEDGDDPKM))]
	private Task NOIGAJDHAJK(IHCOLCCANMI NBOHPBPLMJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x2194DB0", Offset = "0x21933B0", VA = "0x182194DB0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EKDFAINCOLL))]
	private Task<CDNJKKMBNED> DKFHOEEMJAM(IHCOLCCANMI PKNENDONMCN, CancellationToken OOAGLCBNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x2195D80", Offset = "0x2194380", VA = "0x182195D80")]
	private JMODPMGGFBH PCAEOHKKDOB(IHCOLCCANMI IDIAJJIINJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x2194810", Offset = "0x2192E10", VA = "0x182194810")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FBBJJGALKAK))]
	private Task CHIBGLKLBHD(CDNJKKMBNED IDHOKMNCGAF, CancellationToken OOAGLCBNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x2194570", Offset = "0x2192B70", VA = "0x182194570")]
	private CDNJKKMBNED BGNLGAOPPBG(IHCOLCCANMI PKNENDONMCN, JMODPMGGFBH NKNKELDBCNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x299F010", Offset = "0x299D610", VA = "0x18299F010")]
	private T IKMGAMBOFBM<T>(T FEBHELIDNED) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x21950A0", Offset = "0x21936A0", VA = "0x1821950A0")]
	private CDNJKKMBNED FLJICPEGCII(IHCOLCCANMI PKNENDONMCN, JMODPMGGFBH NKNKELDBCNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
	public DJBCLGKPEOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
internal interface FBHPBCKJNFM
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	TimeSpan JINNNOIBFEA
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	TimeSpan MMIMMFGJHDN
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	TimeSpan JICAFBFBENC
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	TimeSpan HHOPMDODBBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool CGMONIFALJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	bool CKJHAALMHHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	bool OGOKIFNDDAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	bool AEEEJHLJMOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	TimeSpan EJHCLANDEEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	int CHDPKDLBDGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	bool EIHFGJHAPII
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal interface PMAIAKAPGOL : BGBDFCFKDKN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<FICOENLLCNC> LBFHBGMHFHD(NHNLOHOBNME<string>.NOELMCIDFEB FLAKFKAEKNJ, LHJOLIPPMAL HDHLHGPMFFE, CancellationToken OOAGLCBNIOG);
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
internal class IALKKLPKDFM : LPHHGEPCEJL
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private sealed class IBGMFFBDOIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public IALKKLPKDFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public Matchmaking.DBAPCAEDFLL result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public LHJOLIPPMAL newPresenceRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public long currentInstanceId;

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public IBGMFFBDOIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x36B7940", Offset = "0x36B5F40", VA = "0x1836B7940")]
		internal object LNMJOOMKPBG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x36B7A90", Offset = "0x36B6090", VA = "0x1836B7A90")]
		internal object NPHKCNFCAMJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x36B78A0", Offset = "0x36B5EA0", VA = "0x1836B78A0")]
		internal object KGMHKCNDJKD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private sealed class DBKGDNNKKPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public IALKKLPKDFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		private IBGMFFBDOIO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		private Matchmaking.DBAPCAEDFLL <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		private TaskAwaiter<Matchmaking.DBAPCAEDFLL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public DBKGDNNKKPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x36AF260", Offset = "0x36AD860", VA = "0x1836AF260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private const float KEGPEMHCKJM = 300f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private readonly LCNJJEKDLHB LCPJEGLKADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	private readonly OPEIFKONHHI OODHPHIHFDJ;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private CFIDKJEMCJA NNHNHPMAIMC
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x21A8240", Offset = "0x21A6840", VA = "0x1821A8240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x953E90", Offset = "0x952490", VA = "0x180953E90")]
	public IALKKLPKDFM(LCNJJEKDLHB LCPJEGLKADH, OPEIFKONHHI OODHPHIHFDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x21A80D0", Offset = "0x21A66D0", VA = "0x1821A80D0", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DBKGDNNKKPJ))]
	public Task<bool> ADNIBPILCBG(CancellationToken OOAGLCBNIOG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal interface GAPOBIJHCCD : BGBDFCFKDKN, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
internal interface LPHHGEPCEJL
{
	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> ADNIBPILCBG(CancellationToken OOAGLCBNIOG);
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public interface JGJNLLCMPJE
{
	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MEHGOAPAPCF(FBHHHJLIPNP BGNFJNOHNAK);

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ECNJNBIFNDH(FBHHHJLIPNP BGNFJNOHNAK);

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OHAHNIIDACA(FBHHHJLIPNP BGNFJNOHNAK);

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NPBLDEAMMPG(FBHHHJLIPNP BGNFJNOHNAK);
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class FBHHHJLIPNP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	public readonly LHJOLIPPMAL NHIDHENJEEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private Dictionary<string, string> HBJKCFLILBK;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public NHNLOHOBNME<string> JDIAMMHMPCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x86F2A0", Offset = "0x86D8A0", VA = "0x18086F2A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x9989D0", Offset = "0x996FD0", VA = "0x1809989D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x959E30", Offset = "0x958430", VA = "0x180959E30")]
	public FBHHHJLIPNP(LHJOLIPPMAL PMOFNJKBKJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x219D3B0", Offset = "0x219B9B0", VA = "0x18219D3B0")]
	public FBHHHJLIPNP PIGNICFKBMO(string NAJDAPHOGEH, string FEBHELIDNED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x219D310", Offset = "0x219B910", VA = "0x18219D310")]
	public bool MNPCHEBKCII(out IEnumerable<KeyValuePair<string, string>> CAOFDLECJJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x219D2F0", Offset = "0x219B8F0", VA = "0x18219D2F0")]
	public FBHHHJLIPNP IOLMBMJOOHM(NHNLOHOBNME<string> BCLLAMGBKIH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class PLNKGBAEGPO : TimeoutException
{
	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x9BD460", Offset = "0x9BBA60", VA = "0x1809BD460")]
	public PLNKGBAEGPO(string JIEHBANCLJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public interface CFIDKJEMCJA
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	LHJOLIPPMAL DDPIHOJNEMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	LMPJDKBMOBF HIEPDBPOODJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	GBCKOOBFABI LKMIBDEECCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool BPABAAJDNEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool BHOPJLGIBKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	int ABMLFDJIGFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action GFBKAMOBFAL;

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event Action<int> PNDFEKOILJE;

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JNALLNJBLNN();

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.OIJFDGIOOGH> HCJCAGJMGGD(long JJCIAKAHHPE, [Optional] CancellationToken OOAGLCBNIOG);

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<Matchmaking.DBAPCAEDFLL> BLOGNOIMPAM();

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task HJOPLJLNEIF();

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(Slot = "14")]
	(LHJOLIPPMAL, JALCPALKLOC) MOCIKCILLBD();

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(Slot = "15")]
	FEFAAKGBGKB OLEGPCKMMFF();

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void FEJCEOBONIE(long JJCIAKAHHPE);
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
internal interface FAODONACOCN : BGBDFCFKDKN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IHCOLCCANMI> IGBIGAANLFF(IHCOLCCANMI PKNENDONMCN, JMODPMGGFBH NKNKELDBCNG, CancellationToken OOAGLCBNIOG);

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IHCOLCCANMI> CKICAKGFLLD(CancellationToken OOAGLCBNIOG, JMODPMGGFBH NKNKELDBCNG);

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EJKLHKJLFLB ALNLCMGLFCA(CDNJKKMBNED CMDNKDMBJMJ, NHNLOHOBNME<string>.NOELMCIDFEB FLAKFKAEKNJ);

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EJKLHKJLFLB EFIIPBPFNGD(CDNJKKMBNED CMDNKDMBJMJ, NHNLOHOBNME<string>.NOELMCIDFEB FLAKFKAEKNJ);
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
internal sealed class EIHKCNHAPPO : LCNJJEKDLHB, NJPEDPIBAHB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private sealed class GGLIFMINOIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		public AsyncTaskMethodBuilder<LOJBOFKMJHM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public KFADJCAHNKD autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public EIHKCNHAPPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		private LOJBOFKMJHM <canRun>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		private LOJBOFKMJHM <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		private TaskAwaiter<LOJBOFKMJHM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public GGLIFMINOIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x36B6790", Offset = "0x36B4D90", VA = "0x1836B6790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[CompilerGenerated]
	private sealed class OBMKEOAPGHD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public EIHKCNHAPPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		private LOJBOFKMJHM <canRun>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public OBMKEOAPGHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x36BE590", Offset = "0x36BCB90", VA = "0x1836BE590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private sealed class JBFALFLACKD : IEnumerable<BGBDFCFKDKN>, IEnumerable, IEnumerator<BGBDFCFKDKN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private BGBDFCFKDKN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		public EIHKCNHAPPO <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		private BGBDFCFKDKN System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000296")]
			[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000298")]
			[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x9F3CA0", Offset = "0x9F22A0", VA = "0x1809F3CA0")]
		[DebuggerHidden]
		public JBFALFLACKD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x36B8840", Offset = "0x36B6E40", VA = "0x1836B8840", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x36B8CC0", Offset = "0x36B72C0", VA = "0x1836B8CC0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x36B8C20", Offset = "0x36B7220", VA = "0x1836B8C20", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<BGBDFCFKDKN> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x36B8C20", Offset = "0x36B7220", VA = "0x1836B8C20", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private readonly CancellationTokenSource IFAAADFJEGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	private readonly EIHIACACEHJ GEAGAOEEJFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	private bool OCBEMDEOMOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	private BKHDOODJDJC FCDCPGPBALC;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public HDOGFNJHJAM NAKEOKLMHPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x94F4E0", Offset = "0x94DAE0", VA = "0x18094F4E0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x94F4B0", Offset = "0x94DAB0", VA = "0x18094F4B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public PDCFACENKHF JJIBMDEFBIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x923330", Offset = "0x921930", VA = "0x180923330", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x943FB0", Offset = "0x9425B0", VA = "0x180943FB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public OPEIFKONHHI JLLINPPOIKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x9259E0", Offset = "0x923FE0", VA = "0x1809259E0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x920E90", Offset = "0x91F490", VA = "0x180920E90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public OEDMFBHOLOJ BCPPAOCIGFM
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x9259D0", Offset = "0x923FD0", VA = "0x1809259D0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x923340", Offset = "0x921940", VA = "0x180923340")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public CHBGONFBKJD OPHPLGMAOCL
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x940DB0", Offset = "0x93F3B0", VA = "0x180940DB0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0xA06C30", Offset = "0xA05230", VA = "0x180A06C30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public CHOIGDNKNLL NJOHKODHAJA
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x93F290", Offset = "0x93D890", VA = "0x18093F290", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0xA34DA0", Offset = "0xA333A0", VA = "0x180A34DA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public GEIFDGGEAAC JHOBCBDMBCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x9A2700", Offset = "0x9A0D00", VA = "0x1809A2700", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x922DE0", Offset = "0x9213E0", VA = "0x180922DE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public JHPIEPEAANO KEHEGNBMCDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x941250", Offset = "0x93F850", VA = "0x180941250", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0xA34ED0", Offset = "0xA334D0", VA = "0x180A34ED0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public EKDLKAIMKEM CNIOEPBDABP
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0xA503B0", Offset = "0xA4E9B0", VA = "0x180A503B0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0xA72E20", Offset = "0xA71420", VA = "0x180A72E20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public FPJPENDPCCA KKDKIKJKLFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0xAE6900", Offset = "0xAE4F00", VA = "0x180AE6900", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0xAE6920", Offset = "0xAE4F20", VA = "0x180AE6920")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public IODPKOEAPFI PFBJJJFAAGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0xD9A0A0", Offset = "0xD986A0", VA = "0x180D9A0A0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0xD9A090", Offset = "0xD98690", VA = "0x180D9A090")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public AFOGPGOCCBM PCLHBIHAAMP
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0xB01A80", Offset = "0xB00080", VA = "0x180B01A80", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0xD9A7F0", Offset = "0xD98DF0", VA = "0x180D9A7F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public NCFNNACHIOO BIHKNCOEGDP
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0xA509A0", Offset = "0xA4EFA0", VA = "0x180A509A0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0xD67260", Offset = "0xD65860", VA = "0x180D67260")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public BLFLOOPKKNO CGPHNEECPMC
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0xA4C150", Offset = "0xA4A750", VA = "0x180A4C150", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0xA4C300", Offset = "0xA4A900", VA = "0x180A4C300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public GAPOBIJHCCD MPLGKNAHCKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x1244180", Offset = "0x1242780", VA = "0x181244180", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0xF71A80", Offset = "0xF70080", VA = "0x180F71A80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public KBKKOEPHAMN KNNMHOKNHDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x921940", Offset = "0x91FF40", VA = "0x180921940", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0xE14800", Offset = "0xE12E00", VA = "0x180E14800")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public OGKLPLJCFFC EOMDLJKNJEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x9208D0", Offset = "0x91EED0", VA = "0x1809208D0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x91FAB0", Offset = "0x91E0B0", VA = "0x18091FAB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public CKDJAGKFMCE JLPKNBMMJHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x9208B0", Offset = "0x91EEB0", VA = "0x1809208B0", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x91F720", Offset = "0x91DD20", VA = "0x18091F720")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public PMAIAKAPGOL JDIHIBCCJDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x9A5980", Offset = "0x9A3F80", VA = "0x1809A5980", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0xAD8A30", Offset = "0xAD7030", VA = "0x180AD8A30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public FAODONACOCN CMBPJAAOPIN
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0xAD56F0", Offset = "0xAD3CF0", VA = "0x180AD56F0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0xBD6BB0", Offset = "0xBD51B0", VA = "0x180BD6BB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public KLKIBPNICGK FCOMBNDLMFB
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0xADD5F0", Offset = "0xADBBF0", VA = "0x180ADD5F0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0xF08C40", Offset = "0xF07240", VA = "0x180F08C40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public CHJKBIICEEH HEICLDPLPJF
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0xD77850", Offset = "0xD75E50", VA = "0x180D77850", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0xE04FC0", Offset = "0xE035C0", VA = "0x180E04FC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public JGJNLLCMPJE LPKONNLDJHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0xA04930", Offset = "0xA02F30", VA = "0x180A04930", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0xA4B5B0", Offset = "0xA49BB0", VA = "0x180A4B5B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public KHACHKKFIMN KCELIMEAJHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0xD77790", Offset = "0xD75D90", VA = "0x180D77790", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0xA450D0", Offset = "0xA436D0", VA = "0x180A450D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public MGDFKIMJGLA NKHCBBDEFOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0xD77700", Offset = "0xD75D00", VA = "0x180D77700", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0xF5EBD0", Offset = "0xF5D1D0", VA = "0x180F5EBD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public FBHPBCKJNFM AOFLGDJJKDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0xA049C0", Offset = "0xA02FC0", VA = "0x180A049C0", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x9FE060", Offset = "0x9FC660", VA = "0x1809FE060")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public HIAAMFFADEI KJOBIGFPPLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0xA046E0", Offset = "0xA02CE0", VA = "0x180A046E0", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0xA03100", Offset = "0xA01700", VA = "0x180A03100")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public JEPKLFNGOMJ CAPCEKLICLP
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x9146C0", Offset = "0x912CC0", VA = "0x1809146C0", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public MGJNGDDEEII BLIBCNPNLJP
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x1018D40", Offset = "0x1017340", VA = "0x181018D40", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public NBKCCEOGEEG KGKOCDFPANG
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x940BA0", Offset = "0x93F1A0", VA = "0x180940BA0", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public JALCPALKLOC FEEPOEEEOBO
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x14B1640", Offset = "0x14AFC40", VA = "0x1814B1640", Slot = "55")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x1061F50", Offset = "0x1060550", VA = "0x181061F50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	private bool OCCCCKEHCPB
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x219A730", Offset = "0x2198D30", VA = "0x18219A730", Slot = "47")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	private bool PGCJEBHPGEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x2199F90", Offset = "0x2198590", VA = "0x182199F90", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	private Task KJGECLKGAHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x219A530", Offset = "0x2198B30", VA = "0x18219A530", Slot = "49")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	private CancellationToken EHEHMDNGLNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x219A7F0", Offset = "0x2198DF0", VA = "0x18219A7F0", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	private EIHIACACEHJ BGLPMGEMNNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	private event Action CGFOIGGDHDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x2199F30", Offset = "0x2198530", VA = "0x182199F30", Slot = "37")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x2199DA0", Offset = "0x21983A0", VA = "0x182199DA0", Slot = "38")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	private event GKPLIIPLMEH ACLNFFKGGHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x219AAD0", Offset = "0x21990D0", VA = "0x18219AAD0", Slot = "39")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x219A790", Offset = "0x2198D90", VA = "0x18219A790", Slot = "40")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	private event GKPLIIPLMEH LJCLEEDBANK
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x219A450", Offset = "0x2198A50", VA = "0x18219A450", Slot = "41")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x219A2E0", Offset = "0x21988E0", VA = "0x18219A2E0", Slot = "42")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	private event GKPLIIPLMEH GGEACEFMPNG
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x2199E00", Offset = "0x2198400", VA = "0x182199E00", Slot = "43")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x219A390", Offset = "0x2198990", VA = "0x18219A390", Slot = "44")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	private event Action<PHANMBGDINN, bool> OHNIJNEJLBG
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x219A3F0", Offset = "0x21989F0", VA = "0x18219A3F0", Slot = "45")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x2199E60", Offset = "0x2198460", VA = "0x182199E60", Slot = "46")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x1061F50", Offset = "0x1060550", VA = "0x181061F50", Slot = "36")]
	public void PDOEGCLDBJM(JALCPALKLOC CHNLLPIBGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x219AB30", Offset = "0x2199130", VA = "0x18219AB30")]
	[UnityEngine.Scripting.Preserve]
	internal EIHKCNHAPPO([NALHKAIJJND(null)] EIHIACACEHJ GEAGAOEEJFO, [NALHKAIJJND(null)] HDOGFNJHJAM EGGPOCDMEIJ, [NALHKAIJJND(null)] PDCFACENKHF MBHFEKHOEDI, [NALHKAIJJND(null)] OPEIFKONHHI OODHPHIHFDJ, [NALHKAIJJND(null)] OEDMFBHOLOJ FNDMDPPJPCH, [NALHKAIJJND(null)] CHBGONFBKJD FKMGFCFIIMA, [NALHKAIJJND(null)] CHOIGDNKNLL GFLBKLKGHCO, [NALHKAIJJND(null)] GEIFDGGEAAC KFEFPLGAPED, [NALHKAIJJND(null)] JHPIEPEAANO FGADNKOBCHA, [NALHKAIJJND(null)] EKDLKAIMKEM HDNMPEFINGE, [NALHKAIJJND(null)] FPJPENDPCCA OECHOENAFHO, [NALHKAIJJND(null)] IODPKOEAPFI EDJMKLNLNLH, [NALHKAIJJND(null)] AFOGPGOCCBM FKJFMCGFCGF, [NALHKAIJJND(null)] NCFNNACHIOO JHOJFHKAEBK, [NALHKAIJJND(null)] BLFLOOPKKNO LKBMOPHNNMK, [NALHKAIJJND(null)] GAPOBIJHCCD HOBPPGABGAO, [NALHKAIJJND(null)] KBKKOEPHAMN OFOCDFIEGPA, [NALHKAIJJND(null)] OGKLPLJCFFC JNHPCABGHGP, [NALHKAIJJND(null)] CKDJAGKFMCE IJOFLHABEEO, [NALHKAIJJND(null)] PMAIAKAPGOL OGBBOOPHMPN, [NALHKAIJJND(null)] KLKIBPNICGK LAKCOBCDPCH, [NALHKAIJJND(null)] FAODONACOCN BLFDAKOGHLK, [NALHKAIJJND(null)] CHJKBIICEEH MLDBCLJMNLC, [NALHKAIJJND(null)] JGJNLLCMPJE JJINKIFJOKO, [NALHKAIJJND(null)] KHACHKKFIMN JPDLCAKMPOF, [NALHKAIJJND(null)] FBHPBCKJNFM GKLJDKMPGML, [NALHKAIJJND(null)] HIAAMFFADEI FBMCHANALNB, [NALHKAIJJND(null)] JEPKLFNGOMJ FLBPPEGIPLG, [NALHKAIJJND(null)] MGJNGDDEEII PCLDEBPBBEG, [NALHKAIJJND(null)] NBKCCEOGEEG EAMILPKKFHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x219A5E0", Offset = "0x2198BE0", VA = "0x18219A5E0")]
	private void KGHKJOCLFMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x219A010", Offset = "0x2198610", VA = "0x18219A010", Slot = "56")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x219A340", Offset = "0x2198940", VA = "0x18219A340", Slot = "50")]
	private void FKCOMBPOMLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x219A1A0", Offset = "0x21987A0", VA = "0x18219A1A0", Slot = "51")]
	private KBDFJCPGKLB ELLJKJFBILI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x219A4B0", Offset = "0x2198AB0", VA = "0x18219A4B0", Slot = "52")]
	private OIDLEEHHLBJ JAPFKJLLCOG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x219A810", Offset = "0x2198E10", VA = "0x18219A810", Slot = "53")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GGLIFMINOIG))]
	private Task<LOJBOFKMJHM> MNBKEEMICMK(KFADJCAHNKD KBEMOJLMDPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x219A980", Offset = "0x2198F80", VA = "0x18219A980", Slot = "54")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OBMKEOAPGHD))]
	private Task OLHAAJPKNMH(CancellationToken OOAGLCBNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x2199EC0", Offset = "0x21984C0", VA = "0x182199EC0")]
	[IteratorStateMachine(typeof(JBFALFLACKD))]
	private IEnumerable<BGBDFCFKDKN> BMBGNEPPDJK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x219A6D0", Offset = "0x2198CD0", VA = "0x18219A6D0")]
	[CompilerGenerated]
	private void KNOPEKIOHLI(BGBDFCFKDKN AEKHFLGBLPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[RecRoom.NoEngine.Common.Preserve]
internal sealed class LAIOEAPDBNF : PMAIAKAPGOL, BGBDFCFKDKN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class FCCELPCCAPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public AsyncTaskMethodBuilder<FICOENLLCNC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public NHNLOHOBNME<string>.NOELMCIDFEB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public LHJOLIPPMAL targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public LAIOEAPDBNF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		private long <subRoomId>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		private LMPJDKBMOBF <details>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		private LMPJDKBMOBF <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		private TaskAwaiter<LMPJDKBMOBF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public FCCELPCCAPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x36B4FC0", Offset = "0x36B35C0", VA = "0x1836B4FC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private sealed class EOMIHEKBKGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public EOMIHEKBKGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x36B45F0", Offset = "0x36B2BF0", VA = "0x1836B45F0")]
		internal object APMELJKAIDH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private sealed class DPOBOIHKABK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public AsyncTaskMethodBuilder<LMPJDKBMOBF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public LHJOLIPPMAL targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public NHNLOHOBNME<string>.NOELMCIDFEB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public LAIOEAPDBNF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		private EOMIHEKBKGJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		private NHNLOHOBNME<string>.NOELMCIDFEB <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		private LMPJDKBMOBF <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		private TaskAwaiter<LMPJDKBMOBF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public DPOBOIHKABK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x36B0B70", Offset = "0x36AF170", VA = "0x1836B0B70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	private sealed class BDONOCLCIKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public BDONOCLCIKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0xF9C2D0", Offset = "0xF9A8D0", VA = "0x180F9C2D0")]
		internal bool BCKIPLJBHEE(GBCKOOBFABI sr)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	private OPEIFKONHHI OODHPHIHFDJ;

	[Cpp2IlInjected.Token(Token = "0x400026B")]
	private static readonly (MFELEADOGIE superRoomData, long subRoomDataSaveId) BBDKHNFONKE;

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x21ACF70", Offset = "0x21AB570", VA = "0x1821ACF70", Slot = "5")]
	public void KGHKJOCLFMF(LCNJJEKDLHB LCPJEGLKADH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x21ACFE0", Offset = "0x21AB5E0", VA = "0x1821ACFE0", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FCCELPCCAPD))]
	public Task<FICOENLLCNC> LBFHBGMHFHD(NHNLOHOBNME<string>.NOELMCIDFEB FLAKFKAEKNJ, LHJOLIPPMAL HDHLHGPMFFE, CancellationToken OOAGLCBNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x21AD1A0", Offset = "0x21AB7A0", VA = "0x1821AD1A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DPOBOIHKABK))]
	private Task<LMPJDKBMOBF> NHCBLBLHEBM(LHJOLIPPMAL HDHLHGPMFFE, NHNLOHOBNME<string>.NOELMCIDFEB FLAKFKAEKNJ, CancellationToken OOAGLCBNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x21ACE20", Offset = "0x21AB420", VA = "0x1821ACE20")]
	private FICOENLLCNC DAGLNJOGFDC(LHJOLIPPMAL HDHLHGPMFFE, LMPJDKBMOBF LOCFBHICLIH, long NCHHGHFPFDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x21ACA90", Offset = "0x21AB090", VA = "0x1821ACA90")]
	private (MFELEADOGIE, long) CACBGOCNFMG(LHJOLIPPMAL HDHLHGPMFFE, LMPJDKBMOBF LOCFBHICLIH, long NCHHGHFPFDL)
	{
		return default((MFELEADOGIE, long));
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
	public LAIOEAPDBNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public interface OEDMFBHOLOJ
{
	[Cpp2IlInjected.Token(Token = "0x17000061")]
	bool OOEEFHCAEEM
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	string OELGDLJGAAA
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EJGFFAKKLEJ(Scene AEOGNKOMBHC);

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task PLFBGMHFDKB(BHCGDDFBDAJ LNMAGGNONBJ, CancellationToken OOAGLCBNIOG);

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task EOIMICMPNJJ();
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[UnityEngine.Scripting.Preserve]
internal sealed class HMNGOKIOJFH : FAODONACOCN, BGBDFCFKDKN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private sealed class PEOOIPCKJID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public IHCOLCCANMI request;

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public PEOOIPCKJID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x36BEEE0", Offset = "0x36BD4E0", VA = "0x1836BEEE0")]
		internal object GLLACIDKLFI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private sealed class MEDEGAGCHDJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public AsyncTaskMethodBuilder<IHCOLCCANMI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public IHCOLCCANMI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public JMODPMGGFBH pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public HMNGOKIOJFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		private PEOOIPCKJID <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		private MLOCEEOLAMF.FNBAANFJAOH <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		private IHCOLCCANMI <response>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		private IHCOLCCANMI <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		private TaskAwaiter<IHCOLCCANMI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public MEDEGAGCHDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x36BCB10", Offset = "0x36BB110", VA = "0x1836BCB10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class FFNLGJAIJIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		public AsyncTaskMethodBuilder<IHCOLCCANMI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		public JMODPMGGFBH pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		public HMNGOKIOJFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		private MLOCEEOLAMF.FNBAANFJAOH <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		private BKDLHCNELBM.MKDJFBMHGFF<IHCOLCCANMI> <result>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		private PAFECDGJGCB <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		private TaskAwaiter<PAFECDGJGCB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public FFNLGJAIJIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x36B5330", Offset = "0x36B3930", VA = "0x1836B5330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private sealed class OENHIIEGGAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public IHCOLCCANMI request;

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public OENHIIEGGAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x36BE7F0", Offset = "0x36BCDF0", VA = "0x1836BE7F0")]
		internal object BCICLFBOIPJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private sealed class DCBJBCAJBOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public AsyncTaskMethodBuilder<IHCOLCCANMI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public IHCOLCCANMI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public JMODPMGGFBH pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public HMNGOKIOJFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		private OENHIIEGGAF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		private MLOCEEOLAMF.FNBAANFJAOH <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private ONKPGICOKGI <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		private APDICNEBNBF <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		private CancellationToken <masterSwitchCancellationToken>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		private bool <sent>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		private BKDLHCNELBM.MKDJFBMHGFF<IHCOLCCANMI> <result>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		private IHCOLCCANMI <response>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		private ONKPGICOKGI <actualMessageKind>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		private PAFECDGJGCB <>s__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		private TaskAwaiter<PAFECDGJGCB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public DCBJBCAJBOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x36AFBC0", Offset = "0x36AE1C0", VA = "0x1836AFBC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	private HDOGFNJHJAM EGGPOCDMEIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	private MGDFKIMJGLA ANGMBPBHKEP;

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	private BKDLHCNELBM IMMDGJNNAGB
	{
		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x21A7890", Offset = "0x21A5E90", VA = "0x1821A7890")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x21A8040", Offset = "0x21A6640", VA = "0x1821A8040", Slot = "8")]
	public void KGHKJOCLFMF(LCNJJEKDLHB LCPJEGLKADH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x21A7D80", Offset = "0x21A6380", VA = "0x1821A7D80", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MEDEGAGCHDJ))]
	public Task<IHCOLCCANMI> IGBIGAANLFF(IHCOLCCANMI PKNENDONMCN, JMODPMGGFBH NKNKELDBCNG, CancellationToken OOAGLCBNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x21A76F0", Offset = "0x21A5CF0", VA = "0x1821A76F0", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FFNLGJAIJIJ))]
	public Task<IHCOLCCANMI> CKICAKGFLLD(CancellationToken OOAGLCBNIOG, JMODPMGGFBH NKNKELDBCNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x21A7460", Offset = "0x21A5A60", VA = "0x1821A7460", Slot = "6")]
	public EJKLHKJLFLB ALNLCMGLFCA(CDNJKKMBNED CMDNKDMBJMJ, NHNLOHOBNME<string>.NOELMCIDFEB FLAKFKAEKNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x21A7940", Offset = "0x21A5F40", VA = "0x1821A7940", Slot = "7")]
	public EJKLHKJLFLB EFIIPBPFNGD(CDNJKKMBNED CMDNKDMBJMJ, NHNLOHOBNME<string>.NOELMCIDFEB FLAKFKAEKNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x21A7BC0", Offset = "0x21A61C0", VA = "0x1821A7BC0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DCBJBCAJBOC))]
	private Task<IHCOLCCANMI> EJGOKHKJHGC(IHCOLCCANMI PKNENDONMCN, JMODPMGGFBH NKNKELDBCNG, CancellationToken OOAGLCBNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x21A76E0", Offset = "0x21A5CE0", VA = "0x1821A76E0")]
	private static byte[] BPAHDIPABED(IHCOLCCANMI JIEHBANCLJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x21A7F40", Offset = "0x21A6540", VA = "0x1821A7F40")]
	private static string KEHGAELAFNJ(byte[] NPIEBOHJFEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
	public HMNGOKIOJFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public readonly struct KPBMNABNLAG<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private sealed class CNNOEFHJGKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public AsyncTaskMethodBuilder<EGKNCMFMAMB<AIIIIIPEBCO<TData>, BFLIDGJOJDI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public NHNLOHOBNME<string>.NOELMCIDFEB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public KPBMNABNLAG<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private MLOCEEOLAMF.FNBAANFJAOH <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private byte[] <roomDataBytes>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private NHNLOHOBNME<string>.NOELMCIDFEB <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		private EGKNCMFMAMB<byte[], BFLIDGJOJDI> <res>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		private EGKNCMFMAMB<byte[], BFLIDGJOJDI> <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		private TaskAwaiter<EGKNCMFMAMB<byte[], BFLIDGJOJDI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x97F990", Offset = "0x97DF90", VA = "0x18097F990")]
		public CNNOEFHJGKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x32A47B0", Offset = "0x32A2DB0", VA = "0x1832A47B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	private readonly IDCCJJOFNJF<TGetDataArg, TData> NENKFPBEKNA;

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0xA7EC30", Offset = "0xA7D230", VA = "0x180A7EC30")]
	internal KPBMNABNLAG(IDCCJJOFNJF<TGetDataArg, TData> OBBCAGMEJPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x334E1F0", Offset = "0x334C7F0", VA = "0x18334E1F0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KPBMNABNLAG<, >.CNNOEFHJGKL))]
	public Task<EGKNCMFMAMB<AIIIIIPEBCO<TData>, BFLIDGJOJDI>> ENIBNGGGLII(TGetDataArg NPIEBOHJFEN, string IGBJGNPEAII, NHNLOHOBNME<string>.NOELMCIDFEB BCLLAMGBKIH, CancellationToken OOAGLCBNIOG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public static class OOKHOPKPJHI
{
	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x178DF20", Offset = "0x178C520", VA = "0x18178DF20")]
	public static KPBMNABNLAG<TGetDataArg, TData> JBGFDEKBNPE<TGetDataArg, TData>(IDCCJJOFNJF<TGetDataArg, TData> OBBCAGMEJPG)
	{
		return default(KPBMNABNLAG<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[UnityEngine.Scripting.Preserve]
internal sealed class PCLFGNHNBBA : CKDJAGKFMCE, BGBDFCFKDKN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private sealed class OLMAJNMIOJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public AEHILIDANGI operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public PCLFGNHNBBA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public IHCOLCCANMI roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public OLMAJNMIOJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x612A630", Offset = "0x6128C30", VA = "0x18612A630")]
		internal object PJBEDPHCKCJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x612A500", Offset = "0x6128B00", VA = "0x18612A500")]
		internal object LKBPBEEDEJB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private sealed class GEJGFAOCMLJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public AsyncTaskMethodBuilder<LOJBOFKMJHM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public IHCOLCCANMI roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public PCLFGNHNBBA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		private OLMAJNMIOJI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		private MLOCEEOLAMF.FNBAANFJAOH <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		private LOJBOFKMJHM <result>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		private LOJBOFKMJHM <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		private TaskAwaiter<LOJBOFKMJHM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public GEJGFAOCMLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x3ECDAE0", Offset = "0x3ECC0E0", VA = "0x183ECDAE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private sealed class CEIAPEDMFJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public AEHILIDANGI operationType;

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public CEIAPEDMFJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x3EC7F00", Offset = "0x3EC6500", VA = "0x183EC7F00")]
		internal object KBFNGPLIHAC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private sealed class NABNOMCHPIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public IHCOLCCANMI request;

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public NABNOMCHPIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x6129670", Offset = "0x6127C70", VA = "0x186129670")]
		internal object MIFBFCKEJCB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x61296F0", Offset = "0x6127CF0", VA = "0x1861296F0")]
		internal object OLJBFAGKNEB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x61295F0", Offset = "0x6127BF0", VA = "0x1861295F0")]
		internal object GPBGPMBOODF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private sealed class CLIJEHMFEJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public AsyncTaskMethodBuilder<LOJBOFKMJHM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public IHCOLCCANMI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public PCLFGNHNBBA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		private NABNOMCHPIM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		private MLOCEEOLAMF.FNBAANFJAOH <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		private JABIOEONLNK <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		private LOJBOFKMJHM <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		private Task <operation>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		private (LOJBOFKMJHM validationResult, Task operation) <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		private (LOJBOFKMJHM validationResult, Task operation) <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		private TaskAwaiter<(LOJBOFKMJHM validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public CLIJEHMFEJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x3EC8930", Offset = "0x3EC6F30", VA = "0x183EC8930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	private HDOGFNJHJAM EGGPOCDMEIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	private CHJKBIICEEH MLDBCLJMNLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	private OGKLPLJCFFC JNHPCABGHGP;

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x27415A0", Offset = "0x273FBA0", VA = "0x1827415A0", Slot = "5")]
	public void KGHKJOCLFMF(LCNJJEKDLHB LCPJEGLKADH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x2741430", Offset = "0x273FA30", VA = "0x182741430", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GEJGFAOCMLJ))]
	private Task<LOJBOFKMJHM> INOFKPCHOEC(IHCOLCCANMI IDIAJJIINJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x2741160", Offset = "0x273F760", VA = "0x182741160")]
	private bool ANDAKOKLMEM(AEHILIDANGI PHBAINNDDIK, out LOJBOFKMJHM COGPMIAOIBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x2740FF0", Offset = "0x273F5F0", VA = "0x182740FF0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CLIJEHMFEJK))]
	private Task<LOJBOFKMJHM> ADGNEINNIAC(IHCOLCCANMI PKNENDONMCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
	public PCLFGNHNBBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public static class KPHMJBHPMLO
{
	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public static LOJBOFKMJHM FMOCBOFNDAP
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x21A6090", Offset = "0x21A4690", VA = "0x1821A6090")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x21AC570", Offset = "0x21AAB70", VA = "0x1821AC570")]
	public static bool KFNPFFBAANC(this LOJBOFKMJHM COGNPIMIJHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x21A6020", Offset = "0x21A4620", VA = "0x1821A6020")]
	public static LOJBOFKMJHM KHBIFKIGCHA(LEMOGBKGIOO FJFNPILHBBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x21AC560", Offset = "0x21AAB60", VA = "0x1821AC560")]
	public static LOJBOFKMJHM GPODONFFNLA(params LOJBOFKMJHM[] ACNBHIJHKPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x21AC090", Offset = "0x21AA690", VA = "0x1821AC090")]
	public static LOJBOFKMJHM BIDNAEKPOBE(IEnumerable<LOJBOFKMJHM> ACNBHIJHKPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x21AC2B0", Offset = "0x21AA8B0", VA = "0x1821AC2B0")]
	public static string FEHMOBDDDOI(this LOJBOFKMJHM COGPMIAOIBF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[UnityEngine.Scripting.Preserve]
internal sealed class HJLHIEKAKGB : CHJKBIICEEH, BGBDFCFKDKN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	private CHBGONFBKJD FKMGFCFIIMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	private HDOGFNJHJAM EGGPOCDMEIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	private JHPIEPEAANO FGADNKOBCHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	private KLKIBPNICGK LAKCOBCDPCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	private OPEIFKONHHI OODHPHIHFDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	private AFOGPGOCCBM FKJFMCGFCGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	private NCFNNACHIOO JHOJFHKAEBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	private FBHPBCKJNFM GKLJDKMPGML;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	private CFIDKJEMCJA NNHNHPMAIMC
	{
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x21A6440", Offset = "0x21A4A40", VA = "0x1821A6440")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	private static LOJBOFKMJHM FMOCBOFNDAP
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x21A6090", Offset = "0x21A4690", VA = "0x1821A6090")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x21A5EC0", Offset = "0x21A44C0", VA = "0x1821A5EC0", Slot = "7")]
	public void KGHKJOCLFMF(LCNJJEKDLHB LCPJEGLKADH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x21A5D30", Offset = "0x21A4330", VA = "0x1821A5D30", Slot = "4")]
	public LOJBOFKMJHM HIPOAICLEDN(IFFNBNNJJLC JMFJDNIANCF, AEHILIDANGI OHEOBBDEKJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x21A60F0", Offset = "0x21A46F0", VA = "0x1821A60F0", Slot = "5")]
	public LOJBOFKMJHM MMNLFGJAICL(IFFNBNNJJLC OBBBOIELLGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x21A5A80", Offset = "0x21A4080", VA = "0x1821A5A80", Slot = "6")]
	public LOJBOFKMJHM GLGKHDPDNOM(IFFNBNNJJLC OBBBOIELLGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x21A6020", Offset = "0x21A4620", VA = "0x1821A6020")]
	private static LOJBOFKMJHM KHBIFKIGCHA(LEMOGBKGIOO HBPMAEHGPOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
	public HJLHIEKAKGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public delegate Task IHBKKDGIGFD(EPFFDDEKBCK DNCLKGCICOE, CancellationToken LODBJLOKBLP);
[Cpp2IlInjected.Token(Token = "0x200009E")]
internal interface NCFNNACHIOO : BGBDFCFKDKN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000067")]
	bool DPKKLIEPPDH
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GHPHDGJOBCM(IHBKKDGIGFD JMBBMLHHLIA);
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public interface KHACHKKFIMN
{
	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CELDANEGMNP(out IEnumerable<int> DAHNKFLLFJF);

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FCGBFNOELIP(KMGFNNFFDCD LODBJLOKBLP);

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LKPKPNDKOKA(KMGFNNFFDCD LODBJLOKBLP);
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public interface LNKMHCEHILG
{
	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string OLJGGMLIMOF(LOJBOFKMJHM COGNPIMIJHL);
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
internal interface CKDJAGKFMCE : BGBDFCFKDKN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<LOJBOFKMJHM> JLPKNBMMJHH(IHCOLCCANMI IDIAJJIINJH);
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
internal interface LCNJJEKDLHB : NJPEDPIBAHB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000068")]
	CancellationToken IIACEJOHFGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	EIHIACACEHJ FBIDEBDCKAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	HDOGFNJHJAM NAKEOKLMHPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	PDCFACENKHF JJIBMDEFBIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	OPEIFKONHHI JLLINPPOIKE
	{
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	OEDMFBHOLOJ BCPPAOCIGFM
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	CHBGONFBKJD OPHPLGMAOCL
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	CHOIGDNKNLL NJOHKODHAJA
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	GEIFDGGEAAC JHOBCBDMBCM
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	JHPIEPEAANO KEHEGNBMCDF
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	EKDLKAIMKEM CNIOEPBDABP
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	FPJPENDPCCA KKDKIKJKLFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	IODPKOEAPFI PFBJJJFAAGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	AFOGPGOCCBM PCLHBIHAAMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	NCFNNACHIOO BIHKNCOEGDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	BLFLOOPKKNO CGPHNEECPMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	GAPOBIJHCCD MPLGKNAHCKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	KBKKOEPHAMN KNNMHOKNHDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	OGKLPLJCFFC EOMDLJKNJEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	CKDJAGKFMCE JLPKNBMMJHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	PMAIAKAPGOL JDIHIBCCJDN
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	FAODONACOCN CMBPJAAOPIN
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	KLKIBPNICGK FCOMBNDLMFB
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	CHJKBIICEEH HEICLDPLPJF
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	JGJNLLCMPJE LPKONNLDJHI
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	KHACHKKFIMN KCELIMEAJHA
	{
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	MGDFKIMJGLA NKHCBBDEFOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	FBHPBCKJNFM AOFLGDJJKDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	HIAAMFFADEI KJOBIGFPPLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	JEPKLFNGOMJ CAPCEKLICLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	MGJNGDDEEII BLIBCNPNLJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	NBKCCEOGEEG KGKOCDFPANG
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void PDOEGCLDBJM(JALCPALKLOC CHNLLPIBGBJ);
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
internal interface IODPKOEAPFI : BGBDFCFKDKN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task OBIBDLBNLDN();

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EDDOHEMBKMH();

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HEJEPKMNJEJ();
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public static class EMPLOMHFGIL
{
	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x219CBC0", Offset = "0x219B1C0", VA = "0x18219CBC0")]
	public static void DFIDEJHKHGN(EIHIACACEHJ GEAGAOEEJFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x219CAA0", Offset = "0x219B0A0", VA = "0x18219CAA0")]
	internal static void AEOPKOENANH(EIHIACACEHJ GEAGAOEEJFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x219CDC0", Offset = "0x219B3C0", VA = "0x18219CDC0")]
	internal static void ECBHNIOEAPJ(EIHIACACEHJ GEAGAOEEJFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x219CEA0", Offset = "0x219B4A0", VA = "0x18219CEA0")]
	internal static void NBJJBIAKGDM(EIHIACACEHJ GEAGAOEEJFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public class LLJODIMJBHL : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x2732970", Offset = "0x2730F70", VA = "0x182732970")]
	public LLJODIMJBHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0xE852C0", Offset = "0xE838C0", VA = "0x180E852C0")]
	public LLJODIMJBHL(string JIEHBANCLJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
internal interface BGBDFCFKDKN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KGHKJOCLFMF(LCNJJEKDLHB LCPJEGLKADH);
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public interface OPEIFKONHHI
{
	[Cpp2IlInjected.Token(Token = "0x17000088")]
	CFIDKJEMCJA NNHNHPMAIMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	int ABMLFDJIGFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	bool CJDCLCELGKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	bool LNHCNLENLBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	bool JAJDIEEEJAD
	{
		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	bool LLECMJJMFNG
	{
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	IFFNBNNJJLC JECPHNFACIC
	{
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(Slot = "45")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	bool MMHHOIHHODP
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	float LPHPBIGOHDB
	{
		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	event Action<float> EBPCBNAELMH;

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EIHIACACEHJ MGNKNJMBIMI(EIHIACACEHJ HABLHGJIEJK);

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EPADPMFKLOL(EIHIACACEHJ GEAGAOEEJFO);

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ALEIDMAFGMD();

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task LGAOMLIGMON(NHNLOHOBNME<string>.NOELMCIDFEB OLJBCAFPPHF, CancellationToken OOAGLCBNIOG);

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DGFPJLHKDKN(float GGDCBMCKFDG);

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void IKMOLGANGFK(string PLKIEMDKNHI);

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IReadOnlyList<JAEANCGJHOM> ABANEILECNF();

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IDisposable NLIBFENLHKD(object JHAKINLMMJL, JAEANCGJHOM LNBMEBPIDEB);

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	PPJKDKMANPD FGPKKJECLHL(IEnumerable<NFFPAONFDAO> FBODAKFKGIM);

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void MNADLOODNIJ(int DHCDJONFBKH);

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task CBMALKJBPNE();

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void CJCGGOPMCFJ();

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool CDIJABDKBGN();

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task MOCIFDIBOKB(CancellationToken OOAGLCBNIOG);

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task KBDKLHMMLEN(CancellationToken OOAGLCBNIOG);

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task<HIMGEOONAEO> GFODANJGMIO(DateTime EODONHNLLHN, CancellationToken OOAGLCBNIOG);

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task<bool> NCDGDKAHMHA(CancellationToken OOAGLCBNIOG);

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void FENLCCMEGHG();

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(Slot = "23")]
	ODFLLKNBMLP GHGGICFAFFI(KBDALPDHODH EGNEHPMLPBH, NGDMEJFKJLL GDHNOLIKMFN, IEnumerable<PersistenceView> GDAIHLDMDKJ, KLEMKCCNPOG MKEELMOMMCF);

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void AICHPOOIPBI(NGDMEJFKJLL GDHNOLIKMFN);

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void EAEMGKJEEAO(NFFPAONFDAO MAEAOOFFCNL, in ODFLLKNBMLP BJPEOONPLEM);

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Task JMLALKLFDCE(NGDMEJFKJLL CJLLNAEEKIK, bool EAFHDNGHHGG, CancellationToken OOAGLCBNIOG);

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(Slot = "27")]
	Task AMBCEPDKKMK(CancellationToken OOAGLCBNIOG);

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void FEAJECKIBLO(long EDDMGMBKEBK, long LKPOLLBAPFL, LMPJDKBMOBF MIDAGNGFEKI, PFODCGFLBLH GCHODDBHJLG, NLCCKHNECKK ADALNLFJHAF, FINMCLAFJIC? MEADLMEKHNC, GPKGCDHOKFN? GLMGHMOCMAF);

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void NLJECHEMCGO(long EDDMGMBKEBK, long LKPOLLBAPFL, GPKGCDHOKFN? GLMGHMOCMAF);

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void JBJNPCGNPKD(PersistenceView IBDOOCBPKKA);

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(Slot = "31")]
	bool AJJEMBKPFPI(PersistenceView NJJAKKNEINE);

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(Slot = "32")]
	bool FFAKLOLJLOP(NFFPAONFDAO MAEAOOFFCNL, PJLOEOJDLAF LFJINLKFDEO, out LAKBDNKOKOG LHOCOAOLOBF);

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(Slot = "33")]
	Task DMEPFOIKHGA(CancellationToken OOAGLCBNIOG);

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void EOEHCKHFMMO();

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(Slot = "35")]
	IDisposable JCBEIFJFDLB();

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void HJELBNDMEDL(NGDMEJFKJLL CJLLNAEEKIK, PJLOEOJDLAF LFJINLKFDEO);

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(Slot = "37")]
	Task<bool> PBLPCOFAFEL(HDOGFNJHJAM EGGPOCDMEIJ, CancellationToken OOAGLCBNIOG, NHNLOHOBNME<string>.NOELMCIDFEB FLAKFKAEKNJ);

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void KBANAOCGDAI(CancellationToken OOAGLCBNIOG);

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task<HKAJAMIEIHO> POGHHHLOFOL(MGFMAPEPLBA PKNENDONMCN);

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<LMPJDKBMOBF> LEELCPGLPOK(long EDDMGMBKEBK, bool CCFCJBJKFKE, CancellationToken OOAGLCBNIOG);

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task<PFODCGFLBLH> FCMJIOFLHFG(long EDDMGMBKEBK, long LKPOLLBAPFL, long MKOFDBDNAIC, CancellationToken OOAGLCBNIOG);

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<KKHNIHINLHD> DLNPBCBHOEE(string JMDMGHGBHHM, CancellationToken OOAGLCBNIOG);

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task<KKHNIHINLHD> DHJKJOGJLIB(string JMDMGHGBHHM, long EDDMGMBKEBK, long LKPOLLBAPFL, string FMLPKHHAKIF, BCMCCDAIONP.JGFOAOPLFGA DNCLKGCICOE, BCMCCDAIONP.JGFOAOPLFGA JAFBNEJOKKL, int ALKJHDBDIOA);

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(Slot = "46")]
	bool EECIGABILOF();

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool IPALAFIHDMK();

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(Slot = "48")]
	bool CAGDEMJENDG(IEnumerable<LAKBDNKOKOG> KMOCMMFJPBH);

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void OIDCIEGHAGI(List<GameObject> NAPDHBHLFPO);

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(Slot = "50")]
	float IEPMNIOHHAD();

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(Slot = "51")]
	bool OCFPGFOEMCP(string HBJAIAIJNHL, out Scene FBIOKCENGMH);

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(Slot = "52")]
	Task<Scene> KAPIHEOHGBP(string HBJAIAIJNHL, LoadSceneMode NJFNIPEKLGG, bool PDMFAMLNECL, NHNLOHOBNME<string>.NOELMCIDFEB BCLLAMGBKIH);

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void ODFCHANMBKH();

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(Slot = "54")]
	bool BJBKFPJIAGP(ByteString FBJCGAGDCPB);

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void NNIDJMEDMLC();

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void PNNMHNIADFE();

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(Slot = "61")]
	void FJNDFPEEGCH(LHJOLIPPMAL IGLKGEMHDKK);

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(Slot = "62")]
	Task EJEGGCKCKOJ(NHNLOHOBNME<string>.NOELMCIDFEB FLAKFKAEKNJ, CancellationToken OOAGLCBNIOG);

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(Slot = "63")]
	Task JKHMBDDKPIJ(NHNLOHOBNME<string>.NOELMCIDFEB FLAKFKAEKNJ, CancellationToken OOAGLCBNIOG);

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(Slot = "64")]
	Task KBBIAPOBICE(NHNLOHOBNME<string>.NOELMCIDFEB FLAKFKAEKNJ, CancellationToken OOAGLCBNIOG);

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void PAOLGNIAJBI();

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(Slot = "66")]
	IDisposable LAKKCGDPOGL();

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(Slot = "67")]
	NLPNILGFGNL DLDEPCBKPLJ();

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(Slot = "68")]
	Task FNLBKDPNJLH(CancellationToken OOAGLCBNIOG);
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public interface NLPNILGFGNL
{
	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task JOFCLIJNPJL(CancellationToken OOAGLCBNIOG);

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task MBCPLGAANOE(CancellationToken OOAGLCBNIOG);
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public struct ODFLLKNBMLP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public HashSet<int> LKBICMKELJL;
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public enum HIMGEOONAEO : byte
{
	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	No,
	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
internal static class FHNLJEJBFCH
{
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private sealed class IHHFNJMPECM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public LMNLAEPPONM finalTimerLogFlags;

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public IHHFNJMPECM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x36B8580", Offset = "0x36B6B80", VA = "0x1836B8580")]
		internal void HLMIPHNCGAD(GLGLBCADGJK t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private sealed class NFBDFBEMHGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public NHNLOHOBNME<string> timer;

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public NFBDFBEMHGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x36BE3A0", Offset = "0x36BC9A0", VA = "0x1836BE3A0")]
		internal object NACMGHAEOBO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public const string PGADBJAHCLL = "START: ";

	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	public const string KJINBFNEKKK = "END: ";

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x219E740", Offset = "0x219CD40", VA = "0x18219E740")]
	public static NHNLOHOBNME<string> EILFBKCOFJC([Optional] string BLGFPHFOPDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x219E8B0", Offset = "0x219CEB0", VA = "0x18219E8B0")]
	public static NHNLOHOBNME<string> EILFBKCOFJC(LMNLAEPPONM GIONCKIEHLP, [Optional] string BLGFPHFOPDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x219ECF0", Offset = "0x219D2F0", VA = "0x18219ECF0")]
	private static void LNFJCGGPCKF(string NAJDAPHOGEH, NHNLOHOBNME<string>.GPGKHJOCCPD BCLLAMGBKIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x219EBE0", Offset = "0x219D1E0", VA = "0x18219EBE0")]
	private static void JMAJKNONPHA(string NAJDAPHOGEH, NHNLOHOBNME<string>.GPGKHJOCCPD BCLLAMGBKIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x219E9C0", Offset = "0x219CFC0", VA = "0x18219E9C0")]
	public static void IJCGAALBLIC(NHNLOHOBNME<string> BCLLAMGBKIH, LMNLAEPPONM OFHAEKEDPCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x219EB00", Offset = "0x219D100", VA = "0x18219EB00")]
	public static string JGKKEOENKIF(IHCOLCCANMI IDIAJJIINJH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[UnityEngine.Scripting.Preserve]
internal class EIEHNGPMDLI : NCFNNACHIOO, BGBDFCFKDKN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private sealed class HHHHJGKNAKG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public EPFFDDEKBCK roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public EIEHNGPMDLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		private Func<CancellationToken, List<Task>> <taskGenerator>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		private Exception <ex>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public HHHHJGKNAKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x36B6B50", Offset = "0x36B5150", VA = "0x1836B6B50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private sealed class EFMGJGBNCCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public EIEHNGPMDLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public EPFFDDEKBCK roomData;

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public EFMGJGBNCCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x36B2910", Offset = "0x36B0F10", VA = "0x1836B2910")]
		internal List<Task> DCJPBCDEEFB(CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private sealed class IFBHBELFDPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public IHBKKDGIGFD taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public EPFFDDEKBCK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public EIEHNGPMDLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		private MLOCEEOLAMF.FNBAANFJAOH <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		private Exception <ex>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public IFBHBELFDPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x36B7BC0", Offset = "0x36B61C0", VA = "0x1836B7BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private sealed class MMGHMFOKHAD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public EIEHNGPMDLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public MMGHMFOKHAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x36BD2A0", Offset = "0x36BB8A0", VA = "0x1836BD2A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	private readonly HashSet<IHBKKDGIGFD> OBFKDDOMEEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	private PDCFACENKHF MBHFEKHOEDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	private LCNJJEKDLHB LCPJEGLKADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	private JAEANCGJHOM JENAHHPMDDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	private HAILGCDDANM HGLFNDGIOEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	private IDisposable KOMLMBBKMPP;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public bool DPKKLIEPPDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x2199870", Offset = "0x2197E70", VA = "0x182199870", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	internal Task JKBDBBIEIDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x21995F0", Offset = "0x2197BF0", VA = "0x1821995F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x2199300", Offset = "0x2197900", VA = "0x182199300", Slot = "6")]
	public void KGHKJOCLFMF(LCNJJEKDLHB LCPJEGLKADH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x2198420", Offset = "0x2196A20", VA = "0x182198420", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x2198640", Offset = "0x2196C40", VA = "0x182198640", Slot = "5")]
	public bool GHPHDGJOBCM(IHBKKDGIGFD JMBBMLHHLIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x2199600", Offset = "0x2197C00", VA = "0x182199600")]
	private void KMBEHFHOFIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x2199000", Offset = "0x2197600", VA = "0x182199000")]
	private void KAHILHAGLAG(EPFFDDEKBCK DNCLKGCICOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x21988F0", Offset = "0x2196EF0", VA = "0x1821988F0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HHHHJGKNAKG))]
	private Task IKIBCPCFPBP(EPFFDDEKBCK DNCLKGCICOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x21998A0", Offset = "0x2197EA0", VA = "0x1821998A0")]
	private Func<CancellationToken, List<Task>> PIDNJHHEBEB(EPFFDDEKBCK DNCLKGCICOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x2198A40", Offset = "0x2197040", VA = "0x182198A40")]
	private List<Task> KABLGFNGBKC(EPFFDDEKBCK DNCLKGCICOE, CancellationToken OOAGLCBNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x21984A0", Offset = "0x2196AA0", VA = "0x1821984A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IFBHBELFDPA))]
	private Task EPIACGOPPFJ(IHBKKDGIGFD BGJNBHJEKMF, EPFFDDEKBCK GOMDNNCBLHP, CancellationToken LODBJLOKBLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x21987D0", Offset = "0x2196DD0", VA = "0x1821987D0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MMGHMFOKHAD))]
	private Task HKBGLLOBJAN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x21986A0", Offset = "0x2196CA0", VA = "0x1821986A0")]
	private void HEJEPKMNJEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x2199980", Offset = "0x2197F80", VA = "0x182199980")]
	public EIEHNGPMDLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal interface JHPIEPEAANO : BGBDFCFKDKN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000093")]
	bool KGHKFCCBODD
	{
		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	Task HIIELKDOEDK
	{
		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LBKCILFDIEO(Task DNEHMOFNGIO, string LOFLPEAOEIJ);
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
internal class PIONEPKKIKI : LPHHGEPCEJL
{
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private sealed class BJNJHJOJGIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public PIONEPKKIKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public BJNJHJOJGIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x61236D0", Offset = "0x6121CD0", VA = "0x1861236D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400030A")]
	private readonly LCNJJEKDLHB LCPJEGLKADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400030B")]
	private readonly OPEIFKONHHI OODHPHIHFDJ;

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x953E90", Offset = "0x952490", VA = "0x180953E90")]
	public PIONEPKKIKI(LCNJJEKDLHB LCPJEGLKADH, OPEIFKONHHI OODHPHIHFDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x2742220", Offset = "0x2740820", VA = "0x182742220", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BJNJHJOJGIM))]
	public Task<bool> ADNIBPILCBG(CancellationToken OOAGLCBNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x2742390", Offset = "0x2740990", VA = "0x182742390")]
	[CompilerGenerated]
	private object BPNONNHPANA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public class FDPCBIJCOEP : HGEFFFLNEEA, CHBGONFBKJD, IAMLOLAILNM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private sealed class BKJMJDJCJMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		public LOJBOFKMJHM result;

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public BKJMJDJCJMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x36AE510", Offset = "0x36ACB10", VA = "0x1836AE510")]
		internal object FIHNBGLGBOJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x219D620", Offset = "0x219BC20", VA = "0x18219D620")]
	[UnityEngine.Scripting.Preserve]
	public FDPCBIJCOEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x219D490", Offset = "0x219BA90", VA = "0x18219D490", Slot = "8")]
	public LOJBOFKMJHM GEFGJDMDPAK(IFFNBNNJJLC OBBBOIELLGM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public interface HIAAMFFADEI
{
	[Cpp2IlInjected.Token(Token = "0x17000095")]
	bool AHKPOHHIEFD
	{
		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	string GIFAMLMPKGG
	{
		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KHJGPHILIBD();

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JOACNNBBDGA DMEJOBBGJFE(long JJCIAKAHHPE);

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IDCCJJOFNJF<MFELEADOGIE, PPJKDKMANPD> NEABODJMJDP(long JJCIAKAHHPE);

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IDCCJJOFNJF<MFELEADOGIE, NGDMEJFKJLL> CAOKNCAIKNL(long JJCIAKAHHPE);

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	IDCCJJOFNJF<long, GIDMOOPDLFC> CJPAFAMKIEE();

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task<bool> JJLPHMMJIIO(byte[] PEGIFAKLECB, byte[] JAFBNEJOKKL, CancellationToken OOAGLCBNIOG);
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[UnityEngine.Scripting.Preserve]
internal sealed class OJBDNHKIGCD : BLFLOOPKKNO, BGBDFCFKDKN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private sealed class FLAPFLCDBAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public FLAPFLCDBAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x3ECD300", Offset = "0x3ECB900", VA = "0x183ECD300")]
		internal object NFFECLIMPCB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private sealed class GLLMCFDCGPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public GLLMCFDCGPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x3ECE1F0", Offset = "0x3ECC7F0", VA = "0x183ECE1F0")]
		internal object ADHHKPMGLKP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private sealed class FAFOMEDGOFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public FAFOMEDGOFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x3ECC130", Offset = "0x3ECA730", VA = "0x183ECC130")]
		internal object PNAJIOLDKDL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private sealed class IBIDNFBCCCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public IBIDNFBCCCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x3ECF090", Offset = "0x3ECD690", VA = "0x183ECF090")]
		internal object POJJKNEIDIC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private sealed class GAMBDHHNMHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public GAMBDHHNMHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x3ECDA80", Offset = "0x3ECC080", VA = "0x183ECDA80")]
		internal object ODAFDOICDMH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000312")]
	private readonly Dictionary<Guid, PPMBFMOHLAB> LKBMOPHNNMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000313")]
	private readonly TimeSpan EFGCHLNPEBA;

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "10")]
	public void KGHKJOCLFMF(LCNJJEKDLHB LCPJEGLKADH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x273B320", Offset = "0x2739920", VA = "0x18273B320", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x273C230", Offset = "0x273A830", VA = "0x18273C230", Slot = "4")]
	public JABIOEONLNK PEECNHFNIGK(Guid MGMFLGBPLHJ)
	{
		return default(JABIOEONLNK);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x273B330", Offset = "0x2739930", VA = "0x18273B330", Slot = "5")]
	public bool FAKCPBGGFBC(Guid MGMFLGBPLHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x273B8D0", Offset = "0x2739ED0", VA = "0x18273B8D0", Slot = "8")]
	public bool HEJEPKMNJEJ(Guid MGMFLGBPLHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x273BE40", Offset = "0x273A440", VA = "0x18273BE40", Slot = "6")]
	public bool LNCKJIBGBBA(Guid MGMFLGBPLHJ, Task BNJGBDJALJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x273BB60", Offset = "0x273A160", VA = "0x18273BB60", Slot = "7")]
	public bool JFEDOBBDBJM(Guid MGMFLGBPLHJ, LOJBOFKMJHM COGNPIMIJHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x273B290", Offset = "0x2739890", VA = "0x18273B290", Slot = "9")]
	public Task<(LOJBOFKMJHM, Task)> APGLAJPICBI(Guid MGMFLGBPLHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x273B600", Offset = "0x2739C00", VA = "0x18273B600")]
	private void GNEMHEOCAIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x273C4E0", Offset = "0x273AAE0", VA = "0x18273C4E0")]
	public OJBDNHKIGCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public class HJNHLEGKBAP : HGEFFFLNEEA, CHOIGDNKNLL, IAMLOLAILNM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	private sealed class OMPADKKFKNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public LOJBOFKMJHM result;

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public OMPADKKFKNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x36BE910", Offset = "0x36BCF10", VA = "0x1836BE910")]
		internal object KEFBCBGKAAO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x219D620", Offset = "0x219BC20", VA = "0x18219D620")]
	[UnityEngine.Scripting.Preserve]
	public HJNHLEGKBAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x21A6490", Offset = "0x21A4A90", VA = "0x1821A6490", Slot = "8")]
	public LOJBOFKMJHM JBILOBDCJIC(IFFNBNNJJLC HIPPLAKEHCK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
internal interface AFOGPGOCCBM : BGBDFCFKDKN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000097")]
	TaskStatus EKKNBDPALPM
	{
		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task BDEIOEEDEAA(LHJOLIPPMAL HDHLHGPMFFE, JALCPALKLOC CIPBLKCJDGE, CancellationToken OHDMAIAEMEE);
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
internal static class KIHJPDIFEBF
{
	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x21ABBE0", Offset = "0x21AA1E0", VA = "0x1821ABBE0")]
	public static bool CDAGMJHGMCI(this AFOGPGOCCBM FKJFMCGFCGF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
internal static class GJBMGPGBHNA
{
	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x21A1AE0", Offset = "0x21A00E0", VA = "0x1821A1AE0")]
	public static string IGILOOCBMGP(this LHJOLIPPMAL PMOFNJKBKJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x21A1A50", Offset = "0x21A0050", VA = "0x1821A1A50")]
	public static bool IAEOAFAAPHH(this LHJOLIPPMAL PMOFNJKBKJI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
[UnityEngine.Scripting.Preserve]
internal class NLCEIBIGLHC : IODPKOEAPFI, BGBDFCFKDKN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[CompilerGenerated]
	private sealed class EPKGNKKLOPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		public NLCEIBIGLHC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		private MLOCEEOLAMF.FNBAANFJAOH <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public EPKGNKKLOPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x3ECBCC0", Offset = "0x3ECA2C0", VA = "0x183ECBCC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[CompilerGenerated]
	private sealed class HAHKHPCLACI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public NLCEIBIGLHC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		private MLOCEEOLAMF.FNBAANFJAOH <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		private bool <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public HAHKHPCLACI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x3ECEC60", Offset = "0x3ECD260", VA = "0x183ECEC60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	[CompilerGenerated]
	private sealed class GGKPNCLLBLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public GGKPNCLLBLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x3ECE180", Offset = "0x3ECC780", VA = "0x183ECE180")]
		internal object ABGLHACJMCK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[CompilerGenerated]
	private sealed class COCALFFLHLL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		public int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		public NLCEIBIGLHC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		private GGKPNCLLBLF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		private MLOCEEOLAMF.FNBAANFJAOH <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		private LPHHGEPCEJL <provider>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		private bool <success>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		private bool <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		private Exception <ex>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public COCALFFLHLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x3EC9140", Offset = "0x3EC7740", VA = "0x183EC9140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[CompilerGenerated]
	private sealed class MCKODPPNBGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public MCKODPPNBGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x3ED2850", Offset = "0x3ED0E50", VA = "0x183ED2850")]
		internal object CDNMPCKPCHM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400031A")]
	private LCNJJEKDLHB LCPJEGLKADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400031B")]
	private OPEIFKONHHI OODHPHIHFDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400031C")]
	private LPHHGEPCEJL[] ANNOHMGJMDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400031D")]
	private CancellationTokenSource NAANFKJBCAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400031E")]
	private int GLJBCEKFAIB;

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x2739D70", Offset = "0x2738370", VA = "0x182739D70", Slot = "7")]
	public void KGHKJOCLFMF(LCNJJEKDLHB LCPJEGLKADH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x2739430", Offset = "0x2737A30", VA = "0x182739430", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x2739AD0", Offset = "0x27380D0", VA = "0x182739AD0", Slot = "6")]
	public void HEJEPKMNJEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x2739440", Offset = "0x2737A40", VA = "0x182739440", Slot = "5")]
	public void EDDOHEMBKMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x2739DF0", Offset = "0x27383F0", VA = "0x182739DF0", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EPKGNKKLOPL))]
	public Task OBIBDLBNLDN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x2739770", Offset = "0x2737D70", VA = "0x182739770")]
	private void HCKICELFJKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x2739180", Offset = "0x2737780", VA = "0x182739180")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HAHKHPCLACI))]
	private Task AICBCFLALKL(CancellationToken OOAGLCBNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x273A060", Offset = "0x2738660", VA = "0x18273A060")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(COCALFFLHLL))]
	private Task<bool> PNJIJHAAMDN(int IIOMOLKAONM, CancellationToken OOAGLCBNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x27392D0", Offset = "0x27378D0", VA = "0x1827392D0")]
	private void BCBGINCKAGL(int IIOMOLKAONM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x2739F10", Offset = "0x2738510", VA = "0x182739F10")]
	private void ODKPLCEFIDP(int IIOMOLKAONM, bool BMKKIDBNMCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x27395B0", Offset = "0x2737BB0", VA = "0x1827395B0")]
	private void GBBLHGPLJNB(int IIOMOLKAONM, Exception IOPPNPIHIME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x2739C60", Offset = "0x2738260", VA = "0x182739C60")]
	private void KBHNLMDEMMD(CancellationToken OOAGLCBNIOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x273A1F0", Offset = "0x27387F0", VA = "0x18273A1F0")]
	public NLCEIBIGLHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal static class AABJHBAKLAK
{
	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x218CFC0", Offset = "0x218B5C0", VA = "0x18218CFC0")]
	public static void DFODJINAEOL(this HDOGFNJHJAM EGGPOCDMEIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x218CFB0", Offset = "0x218B5B0", VA = "0x18218CFB0")]
	public static void CEMCGHEJAKI(this HDOGFNJHJAM EGGPOCDMEIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x218CFD0", Offset = "0x218B5D0", VA = "0x18218CFD0")]
	private static void OPAGBOEBEPA(this HDOGFNJHJAM EGGPOCDMEIJ, bool OAMGLAEGENA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public struct LANLCLMIION
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public readonly LCJCDJGDDFO NLLBMEKCHPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public readonly string CEJPPJCPOCA;

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x21AD550", Offset = "0x21ABB50", VA = "0x1821AD550")]
	public LANLCLMIION(string JAPDIKLPGNI, LCJCDJGDDFO MGBNDHKGDLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x21AD4D0", Offset = "0x21ABAD0", VA = "0x1821AD4D0")]
	public string MEFJPBDADDB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x21AD430", Offset = "0x21ABA30", VA = "0x1821AD430")]
	public string FHJBCIMKHHJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public delegate string GHHPINFLHFG<in T>(T IOPPNPIHIME) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public delegate int DPDIKFPAHJB<in T>(T IOPPNPIHIME) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal class CGJBECIEMMH : NBKCCEOGEEG
{
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	private delegate string HKFKCEIADGP(Exception IOPPNPIHIME);

	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	private delegate int PJLNCICGGGH(Exception IOPPNPIHIME);

	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	private class JALDIOKHFPA<T> : FKGIAELEOFJ<T> where T : notnull, Exception
	{
		[Cpp2IlInjected.Token(Token = "0x20000D2")]
		[CompilerGenerated]
		private sealed class EHLPLPENPMN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000347")]
			public string errorMessage;

			[Cpp2IlInjected.Token(Token = "0x6000413")]
			[Cpp2IlInjected.Address(RVA = "0x97F990", Offset = "0x97DF90", VA = "0x18097F990")]
			public EHLPLPENPMN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000414")]
			[Cpp2IlInjected.Address(RVA = "0x86D400", Offset = "0x86BA00", VA = "0x18086D400")]
			internal string NDEGJOCNCJN(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D3")]
		[CompilerGenerated]
		private sealed class AEDDPNGIPHL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000348")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6D88F0", Offset = "0x6D7CF0")]
			public GHHPINFLHFG<T> errorMessageBuilder;

			[Cpp2IlInjected.Token(Token = "0x6000415")]
			[Cpp2IlInjected.Address(RVA = "0x97F990", Offset = "0x97DF90", VA = "0x18097F990")]
			public AEDDPNGIPHL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000416")]
			[Cpp2IlInjected.Address(RVA = "0x26DEDB0", Offset = "0x26DD3B0", VA = "0x1826DEDB0")]
			internal string HDKLELABLML(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D4")]
		[CompilerGenerated]
		private sealed class NFGLMCCNHGF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000349")]
			public int subCode;

			[Cpp2IlInjected.Token(Token = "0x6000417")]
			[Cpp2IlInjected.Address(RVA = "0x97F990", Offset = "0x97DF90", VA = "0x18097F990")]
			public NFGLMCCNHGF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000418")]
			[Cpp2IlInjected.Address(RVA = "0x86D470", Offset = "0x86BA70", VA = "0x18086D470")]
			internal int IKMLDJBPPII(Exception _)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D5")]
		[CompilerGenerated]
		private sealed class BJFGPINCFNJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400034A")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6D8950", Offset = "0x6D7D50")]
			public DPDIKFPAHJB<T> getSubCode;

			[Cpp2IlInjected.Token(Token = "0x6000419")]
			[Cpp2IlInjected.Address(RVA = "0x97F990", Offset = "0x97DF90", VA = "0x18097F990")]
			public BJFGPINCFNJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600041A")]
			[Cpp2IlInjected.Address(RVA = "0x26DEDB0", Offset = "0x26DD3B0", VA = "0x1826DEDB0")]
			internal int FINNOJEBLNN(Exception ex)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		private readonly CGJBECIEMMH EAMILPKKFHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		private readonly Type JNAOBIEGPIB;

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x23D6E20", Offset = "0x23D5420", VA = "0x1823D6E20")]
		internal JALDIOKHFPA(CGJBECIEMMH EAMILPKKFHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x23D6BC0", Offset = "0x23D51C0", VA = "0x1823D6BC0", Slot = "4")]
		public void EKEHOGAIKHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x23D6A80", Offset = "0x23D5080", VA = "0x1823D6A80", Slot = "5")]
		public FKGIAELEOFJ<T> DLHNAHDIGML(string LOGAJGGPPBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x23D6980", Offset = "0x23D4F80", VA = "0x1823D6980", Slot = "6")]
		public FKGIAELEOFJ<T> BBNLEJKMAAA(GHHPINFLHFG<T> KLGGMOPDILE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x23D6B80", Offset = "0x23D5180", VA = "0x1823D6B80", Slot = "7")]
		public FKGIAELEOFJ<T> EEDJLMEIFLD(int MGBNDHKGDLB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x23D6BF0", Offset = "0x23D51F0", VA = "0x1823D6BF0", Slot = "8")]
		public FKGIAELEOFJ<T> HHIEMNMJCIB(int MGBNDHKGDLB, int JOAGMDJCBJO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x23D6D00", Offset = "0x23D5300", VA = "0x1823D6D00", Slot = "9")]
		public FKGIAELEOFJ<T> NNAONMNPAEH(int MGBNDHKGDLB, DPDIKFPAHJB<T> ADHHILAJLLB)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	private class OOPJHFBJKIA<TVal> where TVal : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		private bool JLECGBNPLCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		private readonly List<Type> EHMBHFJCNOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		private readonly Dictionary<Type, TVal> JCCEJGOBBKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		private readonly Dictionary<Type, int> KJPGHECDIJL;

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		public IReadOnlyList<Type> EJJMMOINPGA
		{
			[Cpp2IlInjected.Token(Token = "0x600041D")]
			[Cpp2IlInjected.Address(RVA = "0x3507650", Offset = "0x3505C50", VA = "0x183507650")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x3507910", Offset = "0x3505F10", VA = "0x183507910")]
		public OOPJHFBJKIA(Dictionary<Type, int> KJPGHECDIJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x35077D0", Offset = "0x3505DD0", VA = "0x1835077D0")]
		public void PEECNHFNIGK(Type NAJDAPHOGEH, TVal CHEGNIOHCDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x35075F0", Offset = "0x3505BF0", VA = "0x1835075F0")]
		public bool GBLPAFIJCMF(Type JNAOBIEGPIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x3507620", Offset = "0x3505C20", VA = "0x183507620")]
		public bool KEJFMNBGEKJ(TVal FEBHELIDNED)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x21FD520", Offset = "0x21FBB20", VA = "0x1821FD520")]
		public TVal PIDCPOPDLLJ(Type LFBJHCMDIAE)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x3507550", Offset = "0x3505B50", VA = "0x183507550")]
		[CompilerGenerated]
		private int FLPBBBHGAKK(Type LHHJEKOCAKM, Type PJOIMACLDBG)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	[CompilerGenerated]
	private sealed class CBLJFINBNFB : IEnumerable<LCJCDJGDDFO>, IEnumerable, IEnumerator<LCJCDJGDDFO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		private LCJCDJGDDFO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		private Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public Exception <>3__ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		public CGJBECIEMMH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		private AggregateException <aggregateException>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		private IEnumerator<Exception> <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		private Exception <innerException>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		private IEnumerator<LCJCDJGDDFO> <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		private LCJCDJGDDFO <innerErrorCode>5__5;

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		private LCJCDJGDDFO System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.Errors.ErrorCode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000427")]
			[Cpp2IlInjected.Address(RVA = "0x272B550", Offset = "0x2729B50", VA = "0x18272B550", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(LCJCDJGDDFO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000429")]
			[Cpp2IlInjected.Address(RVA = "0x272B5B0", Offset = "0x2729BB0", VA = "0x18272B5B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x9F3CA0", Offset = "0x9F22A0", VA = "0x1809F3CA0")]
		[DebuggerHidden]
		public CBLJFINBNFB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x272B600", Offset = "0x2729C00", VA = "0x18272B600", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x272B030", Offset = "0x2729630", VA = "0x18272B030", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x272B450", Offset = "0x2729A50", VA = "0x18272B450")]
		private void PIAHDKPIMOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x272AFE0", Offset = "0x27295E0", VA = "0x18272AFE0")]
		private void MIAFNIDKODF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x272B570", Offset = "0x2729B70", VA = "0x18272B570", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x272B4A0", Offset = "0x2729AA0", VA = "0x18272B4A0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<LCJCDJGDDFO> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.Errors.ErrorCode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x272B4A0", Offset = "0x2729AA0", VA = "0x18272B4A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	internal const int IDAGGABKOMJ = 8700;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	private static readonly LCJCDJGDDFO NFKPGGEMJGA;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	internal const string HLCDBNLIGED = "Unknown error loading room";

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	internal const int CHGDCGEGMPP = 8708;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	private static readonly Dictionary<Type, int> MBGJDIELPHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000341")]
	private readonly HashSet<Type> HCLLINOGOPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000342")]
	private readonly OOPJHFBJKIA<int> EMHHLMALKMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000343")]
	private readonly OOPJHFBJKIA<PJLNCICGGGH> BFBDDOLJGPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000344")]
	private readonly OOPJHFBJKIA<HKFKCEIADGP> OBPOENCDEIH;

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x2192160", Offset = "0x2190760", VA = "0x182192160")]
	[PJEDGFFEDPC(PDIHHCLCNFI.GameOnly)]
	private static void NLFBANBIGIE(EIHIACACEHJ FBBMHADLAOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x21925B0", Offset = "0x2190BB0", VA = "0x1821925B0")]
	[RecRoom.NoEngine.Common.Preserve]
	public CGJBECIEMMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x15F9BA0", Offset = "0x15F81A0", VA = "0x1815F9BA0", Slot = "4")]
	public FKGIAELEOFJ<T> LOAJBLBLEJP<T>() where T : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x2191D50", Offset = "0x2190350", VA = "0x182191D50", Slot = "5")]
	public LANLCLMIION HDGKIJEGHBF(Exception IOPPNPIHIME)
	{
		return default(LANLCLMIION);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x2191B40", Offset = "0x2190140", VA = "0x182191B40", Slot = "6")]
	public LCJCDJGDDFO GJDPKHMLKMA(Exception? IOPPNPIHIME)
	{
		return default(LCJCDJGDDFO);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x2191970", Offset = "0x218FF70", VA = "0x182191970", Slot = "7")]
	[IteratorStateMachine(typeof(CBLJFINBNFB))]
	public IEnumerable<LCJCDJGDDFO> CFOHLDCEGKP(Exception IOPPNPIHIME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x2191A00", Offset = "0x2190000", VA = "0x182191A00", Slot = "8")]
	public string CNGFGCFADIN(Exception? IOPPNPIHIME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x2191E00", Offset = "0x2190400", VA = "0x182191E00")]
	private string JNCBIHBHHEL(AggregateException LBOEDEMPAAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x2191430", Offset = "0x218FA30", VA = "0x182191430")]
	private void CANIAEJNNIL(Type JNAOBIEGPIB, int MGBNDHKGDLB, PJLNCICGGGH? HFKGJDNFLJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x21922C0", Offset = "0x21908C0", VA = "0x1821922C0")]
	private void PAHLJJKPGCA(Type JNAOBIEGPIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x2191170", Offset = "0x218F770", VA = "0x182191170")]
	private void BHIAJILCGDD(Type JNAOBIEGPIB, HKFKCEIADGP CAIFCNEAPNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x21917D0", Offset = "0x218FDD0", VA = "0x1821917D0")]
	private static int CEOBPNCILJF(Type JNAOBIEGPIB, Dictionary<Type, int> KJPGHECDIJL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x16A3F00", Offset = "0x16A2500", VA = "0x1816A3F00")]
	private static bool LFMNGFAOPAK<TVal>(OOPJHFBJKIA<TVal> BCDJFNKOFCL, Type JNAOBIEGPIB, out TVal FEBHELIDNED) where TVal : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x21921D0", Offset = "0x21907D0", VA = "0x1821921D0")]
	[CompilerGenerated]
	internal static int ONHJKEKFBCN(Type AILPEPFEGAC)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public struct LCJCDJGDDFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public readonly int NCFFFPLAKGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public readonly int? NEIBFMBKOCL;

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x15C4040", Offset = "0x15C2640", VA = "0x1815C4040")]
	public LCJCDJGDDFO(int DHCDJONFBKH, [Optional] int? JOAGMDJCBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x21AD570", Offset = "0x21ABB70", VA = "0x1821AD570", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public interface NBKCCEOGEEG
{
	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FKGIAELEOFJ<T> LOAJBLBLEJP<T>() where T : Exception;

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LANLCLMIION HDGKIJEGHBF(Exception IOPPNPIHIME);

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LCJCDJGDDFO GJDPKHMLKMA(Exception IOPPNPIHIME);

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IEnumerable<LCJCDJGDDFO> CFOHLDCEGKP(Exception IOPPNPIHIME);

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(Slot = "4")]
	string CNGFGCFADIN(Exception IOPPNPIHIME);
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public interface FKGIAELEOFJ<T> where T : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EKEHOGAIKHN();

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FKGIAELEOFJ<T> DLHNAHDIGML(string LOGAJGGPPBP);

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FKGIAELEOFJ<T> BBNLEJKMAAA(GHHPINFLHFG<T> KLGGMOPDILE);

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FKGIAELEOFJ<T> EEDJLMEIFLD(int MGBNDHKGDLB);

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FKGIAELEOFJ<T> HHIEMNMJCIB(int MGBNDHKGDLB, int JOAGMDJCBJO);

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	FKGIAELEOFJ<T> NNAONMNPAEH(int MGBNDHKGDLB, DPDIKFPAHJB<T> ADHHILAJLLB);
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public static class HKIOCKEIAIF
{
	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x21A6620", Offset = "0x21A4C20", VA = "0x1821A6620")]
	[PJEDGFFEDPC(PDIHHCLCNFI.GameOnly)]
	private static void ACDBAIMHKIG(EIHIACACEHJ FBBMHADLAOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public interface KFADJCAHNKD : IEquatable<KFADJCAHNKD>
{
	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	GOHELBFBNBD NKKDLCAFGDE
	{
		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	DateTime NCJEGHIFHNN
	{
		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EOKKOFLNCPG();

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OKKFEDNACDK(long EDDMGMBKEBK, long NCHHGHFPFDL, out NLCCKHNECKK ADALNLFJHAF);
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
internal class LFBAIOINMOD : JEPKLFNGOMJ
{
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	[CompilerGenerated]
	private sealed class MHCHDEDCBAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		public ELOHJNEJPLG autosaveType;

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public MHCHDEDCBAI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	[CompilerGenerated]
	private sealed class FGINJCOKCIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public MHCHDEDCBAI CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public FGINJCOKCIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x36B5990", Offset = "0x36B3F90", VA = "0x1836B5990")]
		internal object PHLOLJOFEFK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400035F")]
	private readonly NHDOFLFMALI COIGHHBMBJC;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	private const int KKGADBANKKA = 5;

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event Action<KFADJCAHNKD> KBBNLIBBEIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x21ADAE0", Offset = "0x21AC0E0", VA = "0x1821ADAE0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x21AD650", Offset = "0x21ABC50", VA = "0x1821AD650", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x959E30", Offset = "0x958430", VA = "0x180959E30")]
	[UnityEngine.Scripting.Preserve]
	public LFBAIOINMOD([NALHKAIJJND(null)] NHDOFLFMALI COIGHHBMBJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x21ADED0", Offset = "0x21AC4D0", VA = "0x1821ADED0", Slot = "6")]
	public bool IINFOGIOEJO(long EDDMGMBKEBK, long NCHHGHFPFDL, NLCCKHNECKK ADALNLFJHAF, ELOHJNEJPLG FLILMALMEBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x21ADCA0", Offset = "0x21AC2A0", VA = "0x1821ADCA0")]
	private void GMJDLBOEECH(KFADJCAHNKD IIIIEFFLPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x21ADD40", Offset = "0x21AC340", VA = "0x1821ADD40", Slot = "7")]
	public bool IEEKAKLEKGG(long EDDMGMBKEBK, long NCHHGHFPFDL, out KFADJCAHNKD KBEMOJLMDPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x21AE220", Offset = "0x21AC820", VA = "0x1821AE220", Slot = "8")]
	public bool JELIOMIEJMN(long EDDMGMBKEBK, long NCHHGHFPFDL, ELOHJNEJPLG FLILMALMEBH, out KFADJCAHNKD KBEMOJLMDPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x21AD6F0", Offset = "0x21ABCF0", VA = "0x1821AD6F0")]
	private void DCOGNFIKCCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x21ADB80", Offset = "0x21AC180", VA = "0x1821ADB80", Slot = "9")]
	public void FNKCEHKIPDJ(long EDDMGMBKEBK, long NCHHGHFPFDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public enum GOHELBFBNBD : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000368")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x4000369")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x400036A")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
internal sealed class LLLHLGLHFEI : EHPADDBIPHL
{
	[Cpp2IlInjected.Token(Token = "0x400036B")]
	private static readonly byte[] NAJDAPHOGEH;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	private const string HLFMFBDLPPP = "Autosaves";

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	private const string CKCDBJKIPOG = "Recovery";

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	private const string MEGMGIMCMAB = "Autosaves";

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400036F")]
	private readonly byte[] OGPJLCLPAKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000370")]
	private readonly byte[] EDECHGAKGKM;

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public override GOHELBFBNBD NKKDLCAFGDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x914D90", Offset = "0x913390", VA = "0x180914D90", Slot = "8")]
		get
		{
			return default(GOHELBFBNBD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x2733950", Offset = "0x2731F50", VA = "0x182733950")]
	public LLLHLGLHFEI([Optional] string OBNNICKDIAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x27329B0", Offset = "0x2730FB0", VA = "0x1827329B0", Slot = "9")]
	internal override void CADPGEKPANE(Stream GDADJALHBHM, long EDDMGMBKEBK, long NCHHGHFPFDL, NLCCKHNECKK ADALNLFJHAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x2732FE0", Offset = "0x27315E0", VA = "0x182732FE0", Slot = "10")]
	internal override bool MOPKNIHAIDB(Stream FFHILDDAKKP, long EDDMGMBKEBK, long NCHHGHFPFDL, HMBOAJICCDI GANAJOHDEFK, out NLCCKHNECKK ADALNLFJHAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x2732C80", Offset = "0x2731280", VA = "0x182732C80")]
	private void EEEPFMMFAGO(byte[] FBHPMOOILJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x2732EB0", Offset = "0x27314B0", VA = "0x182732EB0", Slot = "11")]
	protected override FileInfo LGDJGJBHJLE(long EDDMGMBKEBK, long NCHHGHFPFDL, ELOHJNEJPLG FLILMALMEBH, OBDKAGGMHGF DBKDDEMCPFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x2732D90", Offset = "0x2731390", VA = "0x182732D90", Slot = "12")]
	protected override DirectoryInfo GAEPNAEDAEL(ELOHJNEJPLG FLILMALMEBH, OBDKAGGMHGF DBKDDEMCPFC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
internal class HLHGGELDFAJ : EHPADDBIPHL
{
	[Cpp2IlInjected.Token(Token = "0x4000371")]
	private const string DFIJPLCICGE = "V2";

	[Cpp2IlInjected.Token(Token = "0x4000372")]
	private const string HLFMFBDLPPP = "AutosavesV2";

	[Cpp2IlInjected.Token(Token = "0x4000373")]
	private const string CKCDBJKIPOG = "RecoveryV2";

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public override GOHELBFBNBD NKKDLCAFGDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x9A91E0", Offset = "0x9A77E0", VA = "0x1809A91E0", Slot = "8")]
		get
		{
			return default(GOHELBFBNBD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x21A7310", Offset = "0x21A5910", VA = "0x1821A7310")]
	public HLHGGELDFAJ([Optional] string OBNNICKDIAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x21A6D00", Offset = "0x21A5300", VA = "0x1821A6D00")]
	private void JBIHEJKJHME(ELOHJNEJPLG FLILMALMEBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x21A69C0", Offset = "0x21A4FC0", VA = "0x1821A69C0", Slot = "9")]
	internal override void CADPGEKPANE(Stream GDADJALHBHM, long EDDMGMBKEBK, long NCHHGHFPFDL, NLCCKHNECKK ADALNLFJHAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x21A6E80", Offset = "0x21A5480", VA = "0x1821A6E80", Slot = "10")]
	internal override bool MOPKNIHAIDB(Stream FFHILDDAKKP, long EDDMGMBKEBK, long NCHHGHFPFDL, HMBOAJICCDI GANAJOHDEFK, out NLCCKHNECKK ADALNLFJHAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x21A6D90", Offset = "0x21A5390", VA = "0x1821A6D90", Slot = "11")]
	protected override FileInfo LGDJGJBHJLE(long EDDMGMBKEBK, long NCHHGHFPFDL, ELOHJNEJPLG FLILMALMEBH, OBDKAGGMHGF DBKDDEMCPFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x21A6BF0", Offset = "0x21A51F0", VA = "0x1821A6BF0", Slot = "12")]
	protected override DirectoryInfo GAEPNAEDAEL(ELOHJNEJPLG FLILMALMEBH, OBDKAGGMHGF DBKDDEMCPFC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
internal abstract class EHPADDBIPHL : NHDOFLFMALI
{
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	protected enum OBDKAGGMHGF : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	[CompilerGenerated]
	private sealed class KDINLAFFDCM : IEnumerable<KFADJCAHNKD>, IEnumerable, IEnumerator<KFADJCAHNKD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		private KFADJCAHNKD <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		private ELOHJNEJPLG autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		public ELOHJNEJPLG <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		public EHPADDBIPHL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		private DirectoryInfo <autosaveDirectory>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		private FileInfo[] <files>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		private FileInfo[] <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		private int <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		private FileInfo <file>5__5;

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		private KFADJCAHNKD System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600046F")]
			[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000471")]
			[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x9F3CA0", Offset = "0x9F22A0", VA = "0x1809F3CA0")]
		[DebuggerHidden]
		public KDINLAFFDCM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x36BA050", Offset = "0x36B8650", VA = "0x1836BA050", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x36BA2B0", Offset = "0x36B88B0", VA = "0x1836BA2B0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x36BA200", Offset = "0x36B8800", VA = "0x1836BA200", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<KFADJCAHNKD> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x36BA200", Offset = "0x36B8800", VA = "0x1836BA200", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	[CompilerGenerated]
	private sealed class HAEFEGAPOMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public ELOHJNEJPLG autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public HAEFEGAPOMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x36B6AC0", Offset = "0x36B50C0", VA = "0x1836B6AC0")]
		internal object LPPKMPPJKLH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	[CompilerGenerated]
	private sealed class KMKACDONDGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		public EHPADDBIPHL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public KMKACDONDGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x36BAC70", Offset = "0x36B9270", VA = "0x1836BAC70")]
		internal void ECENDJMPBGL(BENAIJFLELP.IFCNBCFDCIL ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000374")]
	protected readonly string JBDCKJHAEPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000375")]
	private readonly object DODOCIDLCCB;

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public abstract GOHELBFBNBD NKKDLCAFGDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x2198380", Offset = "0x2196980", VA = "0x182198380")]
	protected EHPADDBIPHL([CanBeNull] string OBNNICKDIAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x2198130", Offset = "0x2196730", VA = "0x182198130", Slot = "5")]
	public bool NDPJBKKPNJJ(long EDDMGMBKEBK, long NCHHGHFPFDL, ELOHJNEJPLG FLILMALMEBH, out KFADJCAHNKD IIIIEFFLPLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x2198300", Offset = "0x2196900", VA = "0x182198300", Slot = "6")]
	[IteratorStateMachine(typeof(KDINLAFFDCM))]
	public IEnumerable<KFADJCAHNKD> NOLLJKCBNJE(ELOHJNEJPLG FLILMALMEBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void CADPGEKPANE(Stream GDADJALHBHM, long EDDMGMBKEBK, long NCHHGHFPFDL, NLCCKHNECKK ADALNLFJHAF);

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool MOPKNIHAIDB(Stream FFHILDDAKKP, long EDDMGMBKEBK, long NCHHGHFPFDL, HMBOAJICCDI GANAJOHDEFK, out NLCCKHNECKK ADALNLFJHAF);

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x2197DC0", Offset = "0x21963C0", VA = "0x182197DC0", Slot = "7")]
	public KFADJCAHNKD GJCAEGADJFM(long EDDMGMBKEBK, long NCHHGHFPFDL, NLCCKHNECKK ADALNLFJHAF, ELOHJNEJPLG FLILMALMEBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo LGDJGJBHJLE(long EDDMGMBKEBK, long NCHHGHFPFDL, ELOHJNEJPLG FLILMALMEBH, OBDKAGGMHGF DBKDDEMCPFC);

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo GAEPNAEDAEL(ELOHJNEJPLG FLILMALMEBH, OBDKAGGMHGF DBKDDEMCPFC);

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x2197D50", Offset = "0x2196350", VA = "0x182197D50")]
	protected void DJJLGHIFFHM(BENAIJFLELP.IFCNBCFDCIL GNDPDNFMDAL, string IFAPBJJLPAM, FileInfo AAONFIOOJNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x2197A90", Offset = "0x2196090", VA = "0x182197A90")]
	internal bool CGPBDPELLNI(FileInfo PAOEJEJEGNA, long EDDMGMBKEBK, long NCHHGHFPFDL, out NLCCKHNECKK ADALNLFJHAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750")]
	private void MDJDBKHGPCK(Exception NFOPOEMEOGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
internal interface NHDOFLFMALI
{
	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	GOHELBFBNBD NKKDLCAFGDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NDPJBKKPNJJ(long EDDMGMBKEBK, long NCHHGHFPFDL, ELOHJNEJPLG FLILMALMEBH, out KFADJCAHNKD IIIIEFFLPLO);

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<KFADJCAHNKD> NOLLJKCBNJE(ELOHJNEJPLG FLILMALMEBH);

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KFADJCAHNKD GJCAEGADJFM(long EDDMGMBKEBK, long NCHHGHFPFDL, NLCCKHNECKK ADALNLFJHAF, ELOHJNEJPLG FLILMALMEBH);
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
internal class EDBOAGNMOGP : NHDOFLFMALI
{
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	[CompilerGenerated]
	private sealed class ECEOGBGBPJD : IEnumerable<KFADJCAHNKD>, IEnumerable, IEnumerator<KFADJCAHNKD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		private KFADJCAHNKD <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		private ELOHJNEJPLG autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		public ELOHJNEJPLG <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		public EDBOAGNMOGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		private GOHELBFBNBD[] <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		private int <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		private GOHELBFBNBD <autosaveVersion>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		private NHDOFLFMALI <impl>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		private IEnumerable<KFADJCAHNKD> <records>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		private IEnumerator<KFADJCAHNKD> <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		private KFADJCAHNKD <autosaveRecord>5__7;

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		private KFADJCAHNKD System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600048B")]
			[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600048D")]
			[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x9F3CA0", Offset = "0x9F22A0", VA = "0x1809F3CA0")]
		[DebuggerHidden]
		public ECEOGBGBPJD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x36B2120", Offset = "0x36B0720", VA = "0x1836B2120", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x36B1C90", Offset = "0x36B0290", VA = "0x1836B1C90", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x36B1FE0", Offset = "0x36B05E0", VA = "0x1836B1FE0")]
		private void PIAHDKPIMOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x36B20E0", Offset = "0x36B06E0", VA = "0x1836B20E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x36B2030", Offset = "0x36B0630", VA = "0x1836B2030", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<KFADJCAHNKD> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x36B2030", Offset = "0x36B0630", VA = "0x1836B2030", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000388")]
	private readonly GOHELBFBNBD[] IPMINEBGCHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000389")]
	private readonly Dictionary<GOHELBFBNBD, NHDOFLFMALI> KGEFMPBMCMI;

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public GOHELBFBNBD NKKDLCAFGDE
	{
		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x21970A0", Offset = "0x21956A0", VA = "0x1821970A0", Slot = "4")]
		get
		{
			return default(GOHELBFBNBD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x2197600", Offset = "0x2195C00", VA = "0x182197600")]
	[UnityEngine.Scripting.Preserve]
	public EDBOAGNMOGP(params NHDOFLFMALI[] PBGKMKMOCGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x2197420", Offset = "0x2195A20", VA = "0x182197420", Slot = "5")]
	public bool NDPJBKKPNJJ(long EDDMGMBKEBK, long NCHHGHFPFDL, ELOHJNEJPLG FLILMALMEBH, out KFADJCAHNKD IIIIEFFLPLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x21971D0", Offset = "0x21957D0", VA = "0x1821971D0")]
	private void LLJOFHEJNLO(int AOFHMNHECDD, long EDDMGMBKEBK, long NCHHGHFPFDL, ELOHJNEJPLG FLILMALMEBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x2197580", Offset = "0x2195B80", VA = "0x182197580", Slot = "6")]
	[IteratorStateMachine(typeof(ECEOGBGBPJD))]
	public IEnumerable<KFADJCAHNKD> NOLLJKCBNJE(ELOHJNEJPLG FLILMALMEBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x21970E0", Offset = "0x21956E0", VA = "0x1821970E0", Slot = "7")]
	public KFADJCAHNKD GJCAEGADJFM(long EDDMGMBKEBK, long NCHHGHFPFDL, NLCCKHNECKK ADALNLFJHAF, ELOHJNEJPLG FLILMALMEBH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
internal static class NIGAHFONAOM
{
	[Cpp2IlInjected.Token(Token = "0x400039B")]
	internal const int BLIKFDHONGP = 32;

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x2738FA0", Offset = "0x27375A0", VA = "0x182738FA0")]
	internal static byte[] PPKPKPHGCAG(byte[] FBHPMOOILJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x2738F20", Offset = "0x2737520", VA = "0x182738F20")]
	public static void CBGBBOPNJKK(Stream PEBOKJGIJDP, byte[] CDBILDIMKOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x2738D40", Offset = "0x2737340", VA = "0x182738D40")]
	public static bool BJLPFNFGJJA(Stream PEBOKJGIJDP, long AGHHEKLGKAB, HMBOAJICCDI PMGFNBJOIAD, out byte[] OFNEFPMFPPC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public delegate void HMBOAJICCDI(BENAIJFLELP.IFCNBCFDCIL LDPCMNKOBNM, string JIEHBANCLJP);
[Cpp2IlInjected.Token(Token = "0x20000F0")]
internal sealed class KEMODEDLMNN : KFADJCAHNKD, IEquatable<KFADJCAHNKD>, IEquatable<KEMODEDLMNN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400039C")]
	private readonly EHPADDBIPHL HIGICIBCDPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400039D")]
	public readonly FileInfo PPAFJLCFKDD;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public GOHELBFBNBD NKKDLCAFGDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x21AB5E0", Offset = "0x21A9BE0", VA = "0x1821AB5E0", Slot = "4")]
		get
		{
			return default(GOHELBFBNBD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public DateTime NCJEGHIFHNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x21AB540", Offset = "0x21A9B40", VA = "0x1821AB540", Slot = "5")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x21ABAE0", Offset = "0x21AA0E0", VA = "0x1821ABAE0")]
	public KEMODEDLMNN(EHPADDBIPHL PPACOEMIGJH, FileInfo PAOEJEJEGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x21ABA30", Offset = "0x21AA030", VA = "0x1821ABA30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x21AB610", Offset = "0x21A9C10", VA = "0x1821AB610", Slot = "6")]
	public void EOKKOFLNCPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x21AB9F0", Offset = "0x21A9FF0", VA = "0x1821AB9F0", Slot = "7")]
	public bool OKKFEDNACDK(long EDDMGMBKEBK, long NCHHGHFPFDL, out NLCCKHNECKK ADALNLFJHAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x21AB7C0", Offset = "0x21A9DC0", VA = "0x1821AB7C0", Slot = "8")]
	public bool Equals(KFADJCAHNKD EJECOGCICOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x21AB8A0", Offset = "0x21A9EA0", VA = "0x1821AB8A0", Slot = "9")]
	public bool Equals(KEMODEDLMNN EJECOGCICOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x21AB6C0", Offset = "0x21A9CC0", VA = "0x1821AB6C0", Slot = "0")]
	public override bool Equals(object IAMEECMGPIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x21AB950", Offset = "0x21A9F50", VA = "0x1821AB950", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x1816570", Offset = "0x1814B70", VA = "0x181816570")]
	public static bool MOJFGPLDDKP(KEMODEDLMNN CNCLMHODMJG, KEMODEDLMNN ECNLMNDOGCG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x18164F0", Offset = "0x1814AF0", VA = "0x1818164F0")]
	public static bool LFBHPMALHHK(KEMODEDLMNN CNCLMHODMJG, KEMODEDLMNN ECNLMNDOGCG)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000F1")]
internal struct IKEOGHGAEDJ
{
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[CompilerGenerated]
	private sealed class MOLOLONBFFN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		public EJKLHKJLFLB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public EPFFDDEKBCK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		public NHNLOHOBNME<string>.NOELMCIDFEB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		private MLOCEEOLAMF.FNBAANFJAOH <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		private LCNJJEKDLHB <roomManager>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		private NHNLOHOBNME<string>.NOELMCIDFEB <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public MOLOLONBFFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x36BDA50", Offset = "0x36BC050", VA = "0x1836BDA50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x21A8CB0", Offset = "0x21A72B0", VA = "0x1821A8CB0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MOLOLONBFFN))]
	public static Task INHJMLKPHDN(EJKLHKJLFLB GONKAHKFNDA, EPFFDDEKBCK GOMDNNCBLHP, NHNLOHOBNME<string>.NOELMCIDFEB FLAKFKAEKNJ, CancellationToken OOAGLCBNIOG)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000F3")]
internal struct KPOHFLFDIJB
{
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private sealed class GDBKBDKKEML : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		public CDNJKKMBNED operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		public EPFFDDEKBCK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		public KOMFNDJENBN timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		private LCNJJEKDLHB <roomManager>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		private OPEIFKONHHI <callbacks>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		private PJLOEOJDLAF <DEPRECATED_version>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		private MLOCEEOLAMF.FNBAANFJAOH <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		private IDisposable <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		private List<(PersistenceView, NFFPAONFDAO)>.Enumerator <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		private PersistenceView <view>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		private NFFPAONFDAO <viewData>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public GDBKBDKKEML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x36B5F90", Offset = "0x36B4590", VA = "0x1836B5F90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x21AC8F0", Offset = "0x21AAEF0", VA = "0x1821AC8F0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GDBKBDKKEML))]
	public static Task INHJMLKPHDN(CDNJKKMBNED IDHOKMNCGAF, EPFFDDEKBCK GOMDNNCBLHP, KOMFNDJENBN LEPCLCJIPJF, CancellationToken OOAGLCBNIOG)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000F5")]
internal struct EPMCJAPOJGN
{
	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x915250", Offset = "0x913850", VA = "0x180915250")]
	public static EPMCJAPOJGN PJDMJLOGMBM()
	{
		return default(EPMCJAPOJGN);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void MFEOKKCLFBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void GCMFNEFHFAE(EPFFDDEKBCK GOMDNNCBLHP, object MAEAOOFFCNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void IGCKCIMKOEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
internal struct DPELNFIKLAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	private LCNJJEKDLHB LCPJEGLKADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	private EPFFDDEKBCK GOMDNNCBLHP;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	private OPEIFKONHHI JLLINPPOIKE
	{
		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x2197050", Offset = "0x2195650", VA = "0x182197050")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x2196D40", Offset = "0x2195340", VA = "0x182196D40")]
	public static Task INHJMLKPHDN(LCNJJEKDLHB LCPJEGLKADH, EPFFDDEKBCK GOMDNNCBLHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x2196DE0", Offset = "0x21953E0", VA = "0x182196DE0")]
	private void INHJMLKPHDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
internal class LJLBCNODBNI : CDNJKKMBNED
{
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[CompilerGenerated]
	private sealed class MPECLHDCPAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		public EJKLHKJLFLB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		public NHNLOHOBNME<string>.NOELMCIDFEB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		public LJLBCNODBNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		private long <subRoomId>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		private string <unityAssetId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		private JOHHPAJAAMJ <serializeLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		private KBDALPDHODH <serializeType>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		private NLCCKHNECKK <data>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		private NLCCKHNECKK <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		private Exception <ex>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		private TaskAwaiter<NLCCKHNECKK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public MPECLHDCPAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x36BDF50", Offset = "0x36BC550", VA = "0x1836BDF50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	private readonly string EAABNHLCFED;

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x2732740", Offset = "0x2730D40", VA = "0x182732740")]
	public LJLBCNODBNI(Guid MGMFLGBPLHJ, LCNJJEKDLHB LCPJEGLKADH, JMODPMGGFBH OIHIMIHAFFJ, string EAABNHLCFED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x27325A0", Offset = "0x2730BA0", VA = "0x1827325A0", Slot = "8")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MPECLHDCPAH))]
	protected override Task CKKDHFNBKAN(EJKLHKJLFLB GONKAHKFNDA, NHNLOHOBNME<string>.NOELMCIDFEB FLAKFKAEKNJ, CancellationToken OOAGLCBNIOG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
internal class BLDODCCBCMF
{
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class LOEKOJNAKHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		public BBBKKMMJPEP operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		public EPFFDDEKBCK deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		public NHNLOHOBNME<string>.NOELMCIDFEB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		public BLDODCCBCMF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public LOEKOJNAKHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x2733A40", Offset = "0x2732040", VA = "0x182733A40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private sealed class NEOLMNOIGCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		public BLDODCCBCMF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		public EPFFDDEKBCK data;

		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public NEOLMNOIGCJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private sealed class JMAEGMFJDDN
	{
		[Cpp2IlInjected.Token(Token = "0x20000FD")]
		private sealed class <<RunAuthorityHandler>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003D7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003D8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003D9")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003DA")]
			public JMAEGMFJDDN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003DB")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60004CB")]
			[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
			public <<RunAuthorityHandler>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004CC")]
			[Cpp2IlInjected.Address(RVA = "0x612D150", Offset = "0x612B750", VA = "0x18612D150", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004CD")]
			[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		public NHNLOHOBNME<string>.NOELMCIDFEB handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		public NEOLMNOIGCJ CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public JMAEGMFJDDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x2731870", Offset = "0x272FE70", VA = "0x182731870")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task KGBOPMHCKJE(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	[CompilerGenerated]
	private sealed class DPPJGMLMHKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public EPFFDDEKBCK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public NHNLOHOBNME<string>.NOELMCIDFEB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public BLDODCCBCMF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		private NEOLMNOIGCJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		private JMAEGMFJDDN <>8__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public DPPJGMLMHKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x272F600", Offset = "0x272DC00", VA = "0x18272F600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	[CompilerGenerated]
	private sealed class EOJNBGDKELD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public EPFFDDEKBCK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public NHNLOHOBNME<string>.NOELMCIDFEB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public BLDODCCBCMF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		private NHNLOHOBNME<string>.NOELMCIDFEB <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		private Dictionary<Guid, List<DLCALGBFBPE>>.Enumerator <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		private KeyValuePair<Guid, List<DLCALGBFBPE>> <guidMethodPair>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public EOJNBGDKELD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x272FB10", Offset = "0x272E110", VA = "0x18272FB10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000100")]
	[CompilerGenerated]
	private sealed class JJOACBALBNA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		public EPFFDDEKBCK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		public NHNLOHOBNME<string>.NOELMCIDFEB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		public BLDODCCBCMF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		private HDOGFNJHJAM <networking>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		private NHNLOHOBNME<string>.NOELMCIDFEB <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		private Dictionary<Guid, List<DLCALGBFBPE>>.Enumerator <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		private KeyValuePair<Guid, List<DLCALGBFBPE>> <guidMethodPair>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public JJOACBALBNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x2731290", Offset = "0x272F890", VA = "0x182731290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000101")]
	[CompilerGenerated]
	private sealed class NDDHNLHPPND
	{
		[Cpp2IlInjected.Token(Token = "0x2000102")]
		private sealed class <<InvokeMethodsInParallel>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003FF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000400")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000401")]
			public DLCALGBFBPE handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000402")]
			public NDDHNLHPPND <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000403")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60004DB")]
			[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
			public <<InvokeMethodsInParallel>b__2>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004DC")]
			[Cpp2IlInjected.Address(RVA = "0x612A8A0", Offset = "0x6128EA0", VA = "0x18612A8A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004DD")]
			[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public KOFNMPLHJEJ runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public List<DLCALGBFBPE> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public EPFFDDEKBCK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public NDDHNLHPPND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x2737790", Offset = "0x2735D90", VA = "0x182737790")]
		internal object FOLODKBPAIH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x2737640", Offset = "0x2735C40", VA = "0x182737640")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task EJNDNFNAKNF(DLCALGBFBPE handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x2737880", Offset = "0x2735E80", VA = "0x182737880")]
		internal object OFBCGJBOEKO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000103")]
	[CompilerGenerated]
	private sealed class CPMCMPACLEB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public List<DLCALGBFBPE> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public KOFNMPLHJEJ runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public EPFFDDEKBCK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		public BLDODCCBCMF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400040C")]
		private NDDHNLHPPND <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		private IEnumerable<Task> <handlerTasks>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		private Exception <ex>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public CPMCMPACLEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x272C670", Offset = "0x272AC70", VA = "0x18272C670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000104")]
	[CompilerGenerated]
	private sealed class HANKNOKPJPI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public EPFFDDEKBCK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public NHNLOHOBNME<string>.NOELMCIDFEB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public BLDODCCBCMF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		private Guid <handlerIdToRun>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public HANKNOKPJPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x2730440", Offset = "0x272EA40", VA = "0x182730440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[CompilerGenerated]
	private sealed class HFCNMDDJNKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public HFCNMDDJNKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x2730DE0", Offset = "0x272F3E0", VA = "0x182730DE0")]
		internal object GBJAHIBLCDH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000106")]
	[CompilerGenerated]
	private sealed class DLCOJKLMBGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public EPFFDDEKBCK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public NHNLOHOBNME<string>.NOELMCIDFEB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public BLDODCCBCMF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		private HFCNMDDJNKF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		private MLOCEEOLAMF.FNBAANFJAOH <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		private HDOGFNJHJAM <networking>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		private List<DLCALGBFBPE> <handlerMethods>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public DLCOJKLMBGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x272F0A0", Offset = "0x272D6A0", VA = "0x18272F0A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000107")]
	[CompilerGenerated]
	private sealed class ENGPLPNLOHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public ENGPLPNLOHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x272FAA0", Offset = "0x272E0A0", VA = "0x18272FAA0")]
		internal object GPFCCCDEBOL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000108")]
	[CompilerGenerated]
	private sealed class JNGPAAPGOHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		public NHNLOHOBNME<string>.NOELMCIDFEB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		public BLDODCCBCMF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		private ENGPLPNLOHA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		private MLOCEEOLAMF.FNBAANFJAOH <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		private IHCOLCCANMI <completedMessage>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		private IHCOLCCANMI <syncedCompletionMessage>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		private ByteString <authorityCompletedMark>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		private IHCOLCCANMI <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		private TaskAwaiter<IHCOLCCANMI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public JNGPAAPGOHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x27319C0", Offset = "0x272FFC0", VA = "0x1827319C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000109")]
	[CompilerGenerated]
	private sealed class DJINNJHELLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public DJINNJHELLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x272EFF0", Offset = "0x272D5F0", VA = "0x18272EFF0")]
		internal object OLFLBFKNPHK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	private readonly EJKLHKJLFLB GONKAHKFNDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	private JIIFINDGMPB AMJALHDPDON;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	private CDNJKKMBNED HBBJBEIDKBO
	{
		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0xBF20E0", Offset = "0xBF06E0", VA = "0x180BF20E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x959E30", Offset = "0x958430", VA = "0x180959E30")]
	public BLDODCCBCMF(EJKLHKJLFLB GONKAHKFNDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x218E4F0", Offset = "0x218CAF0", VA = "0x18218E4F0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LOEKOJNAKHC))]
	public Task INHJMLKPHDN(BBBKKMMJPEP EHHKMOGNNNP, EPFFDDEKBCK EHBDJPBNDDH, NHNLOHOBNME<string>.NOELMCIDFEB BCLLAMGBKIH, CancellationToken OOAGLCBNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x218E870", Offset = "0x218CE70", VA = "0x18218E870")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DPPJGMLMHKH))]
	private Task KGPJPMGONFG(EPFFDDEKBCK GOMDNNCBLHP, NHNLOHOBNME<string>.NOELMCIDFEB BCLLAMGBKIH, CancellationToken OOAGLCBNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x218F0E0", Offset = "0x218D6E0", VA = "0x18218F0E0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EOJNBGDKELD))]
	private Task OBOOMIBAHMP(EPFFDDEKBCK GOMDNNCBLHP, NHNLOHOBNME<string>.NOELMCIDFEB BCLLAMGBKIH, CancellationToken OOAGLCBNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x218EA10", Offset = "0x218D010", VA = "0x18218EA10")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JJOACBALBNA))]
	private Task KIGNGOIPLFL(EPFFDDEKBCK GOMDNNCBLHP, NHNLOHOBNME<string>.NOELMCIDFEB BCLLAMGBKIH, CancellationToken OOAGLCBNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x218EBB0", Offset = "0x218D1B0", VA = "0x18218EBB0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CPMCMPACLEB))]
	private Task LHKOHGENDDD(Guid ABIEJAANDCN, List<DLCALGBFBPE> KCMKAAFGDIJ, KOFNMPLHJEJ KILBEAHOPEK, EPFFDDEKBCK GOMDNNCBLHP, CancellationToken LODBJLOKBLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x218E080", Offset = "0x218C680", VA = "0x18218E080")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HANKNOKPJPI))]
	private Task CMDJKGJDICC(EPFFDDEKBCK GOMDNNCBLHP, NHNLOHOBNME<string>.NOELMCIDFEB BCLLAMGBKIH, CancellationToken OOAGLCBNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x218EF20", Offset = "0x218D520", VA = "0x18218EF20")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DLCOJKLMBGE))]
	private Task MBODMKMCEAE(Guid DNDNCPMDJHB, EPFFDDEKBCK GOMDNNCBLHP, NHNLOHOBNME<string>.NOELMCIDFEB BCLLAMGBKIH, CancellationToken OOAGLCBNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x218E350", Offset = "0x218C950", VA = "0x18218E350")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JNGPAAPGOHG))]
	private Task IGGMBLGJJKJ(Guid DNDNCPMDJHB, NHNLOHOBNME<string>.NOELMCIDFEB FLAKFKAEKNJ, CancellationToken OOAGLCBNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x218ED80", Offset = "0x218D380", VA = "0x18218ED80")]
	private void LIHNAPECBFP(Guid DNDNCPMDJHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x218E220", Offset = "0x218C820", VA = "0x18218E220")]
	private void DINBIFKDHOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x218E6B0", Offset = "0x218CCB0", VA = "0x18218E6B0")]
	public Guid JJEFLDAFPJK(BBBKKMMJPEP AKICLOPICEN)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x218DEB0", Offset = "0x218C4B0", VA = "0x18218DEB0")]
	[CompilerGenerated]
	private object AHLIJLNINDL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
internal struct FEGACIBFFJD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000437")]
	private readonly EJKLHKJLFLB GONKAHKFNDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000438")]
	private readonly Guid EIAFMCFHBGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000439")]
	private bool BMKKIDBNMCL;

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x219D980", Offset = "0x219BF80", VA = "0x18219D980")]
	public static FEGACIBFFJD EHPFAIHEPCI(EJKLHKJLFLB GONKAHKFNDA)
	{
		return default(FEGACIBFFJD);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0xED1070", Offset = "0xECF670", VA = "0x180ED1070")]
	public void FJMDLJCPACF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x219D970", Offset = "0x219BF70", VA = "0x18219D970", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x219DA90", Offset = "0x219C090", VA = "0x18219DA90")]
	private FEGACIBFFJD(EJKLHKJLFLB GONKAHKFNDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x219D630", Offset = "0x219BC30", VA = "0x18219D630")]
	private void DLEAFFMCCAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x219D9E0", Offset = "0x219BFE0", VA = "0x18219D9E0")]
	private Func<Guid, bool> LJGBFOCBENC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
internal struct BIDJJIIPLHP
{
	[Cpp2IlInjected.Token(Token = "0x200010D")]
	[CompilerGenerated]
	private sealed class PINOMFGGPDO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public AsyncTaskMethodBuilder<BFIGLLFHPEJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public BIDJJIIPLHP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		private NHNLOHOBNME<string>.NOELMCIDFEB <subTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		private BFIGLLFHPEJ <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		private TaskAwaiter<BFIGLLFHPEJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public PINOMFGGPDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x2741DF0", Offset = "0x27403F0", VA = "0x182741DF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010E")]
	[CompilerGenerated]
	private sealed class PHNNDCJMHHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		public AsyncTaskMethodBuilder<BFIGLLFHPEJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		public NHNLOHOBNME<string>.NOELMCIDFEB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		public BIDJJIIPLHP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		private BFIGLLFHPEJ <roomDetails>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		private BFIGLLFHPEJ <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		private TaskAwaiter<BFIGLLFHPEJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public PHNNDCJMHHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x2741AF0", Offset = "0x27400F0", VA = "0x182741AF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[CompilerGenerated]
	private sealed class HCGFMPEELMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public HCGFMPEELMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0xF9C2D0", Offset = "0xF9A8D0", VA = "0x180F9C2D0")]
		internal bool KGKBGLLDKNG(GBCKOOBFABI sr)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000110")]
	[CompilerGenerated]
	private sealed class CPNFAAMFEMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public AsyncTaskMethodBuilder<BFIGLLFHPEJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public OPEIFKONHHI callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public MFELEADOGIE superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public NHNLOHOBNME<string>.NOELMCIDFEB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		private HCGFMPEELMB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		private LMPJDKBMOBF <roomDetails>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		private GBCKOOBFABI <subroom>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		private string <unityAssetId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		private MFELEADOGIE <superRoomData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		private MFELEADOGIE <subRoomData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		private NHNLOHOBNME<string>.NOELMCIDFEB <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		private LMPJDKBMOBF <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		private NHNLOHOBNME<string>.NOELMCIDFEB <>s__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		private KKHNIHINLHD <session>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		private KKHNIHINLHD <>s__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		private NHNLOHOBNME<string>.NOELMCIDFEB <>s__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		private PFODCGFLBLH <saveData>5__13;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		private PFODCGFLBLH <>s__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		private TaskAwaiter<LMPJDKBMOBF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		private TaskAwaiter<KKHNIHINLHD> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		private TaskAwaiter<PFODCGFLBLH> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public CPNFAAMFEMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x272CC80", Offset = "0x272B280", VA = "0x18272CC80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400043A")]
	private OPEIFKONHHI OODHPHIHFDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400043B")]
	private GEIFDGGEAAC KFEFPLGAPED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400043C")]
	private NHNLOHOBNME<string>.NOELMCIDFEB BCLLAMGBKIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400043D")]
	private long EDDMGMBKEBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400043E")]
	private long NCHHGHFPFDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400043F")]
	private long MKOFDBDNAIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000440")]
	private string JMDMGHGBHHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000441")]
	private MFELEADOGIE DEICAOMJMAB;

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x218DC90", Offset = "0x218C290", VA = "0x18218DC90")]
	public static Task<BFIGLLFHPEJ> LIHPLAIKEFA(LCNJJEKDLHB LCPJEGLKADH, FICOENLLCNC PKNENDONMCN, NHNLOHOBNME<string>.NOELMCIDFEB BCLLAMGBKIH, CancellationToken OOAGLCBNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x218DB00", Offset = "0x218C100", VA = "0x18218DB00")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PINOMFGGPDO))]
	private Task<BFIGLLFHPEJ> INHJMLKPHDN(CancellationToken OOAGLCBNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x218D940", Offset = "0x218BF40", VA = "0x18218D940")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PHNNDCJMHHC))]
	private Task<BFIGLLFHPEJ> HFBDMBJKDLL(NHNLOHOBNME<string>.NOELMCIDFEB FLAKFKAEKNJ, CancellationToken OOAGLCBNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x218D710", Offset = "0x218BD10", VA = "0x18218D710")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CPNFAAMFEMG))]
	private static Task<BFIGLLFHPEJ> HFBDMBJKDLL(OPEIFKONHHI OODHPHIHFDJ, long EDDMGMBKEBK, long NCHHGHFPFDL, long MKOFDBDNAIC, string JMDMGHGBHHM, MFELEADOGIE DEICAOMJMAB, CancellationToken OOAGLCBNIOG, NHNLOHOBNME<string>.NOELMCIDFEB FLAKFKAEKNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x218D680", Offset = "0x218BC80", VA = "0x18218D680")]
	private void COKLDFHILCB(LMPJDKBMOBF MIDAGNGFEKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
internal struct HEKEMMEEOCI
{
	[Cpp2IlInjected.Token(Token = "0x2000112")]
	[CompilerGenerated]
	private sealed class HJCPAGILLFK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public LCNJJEKDLHB roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public EPFFDDEKBCK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public EJKLHKJLFLB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public bool isReloadingSceneForObjectModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public NHNLOHOBNME<string>.NOELMCIDFEB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public HJCPAGILLFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x36B7030", Offset = "0x36B5630", VA = "0x1836B7030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CompilerGenerated]
	private sealed class PLOCFHLJHOG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public NHNLOHOBNME<string>.NOELMCIDFEB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public HEKEMMEEOCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		private MLOCEEOLAMF.FNBAANFJAOH <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public PLOCFHLJHOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x36BF3C0", Offset = "0x36BD9C0", VA = "0x1836BF3C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400046D")]
	private LCNJJEKDLHB LCPJEGLKADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400046E")]
	private EPFFDDEKBCK GOMDNNCBLHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400046F")]
	private ByteString PPOIHABECKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000470")]
	private EJKLHKJLFLB GONKAHKFNDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000471")]
	private bool ANBMJHGGJBH;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	private OPEIFKONHHI JLLINPPOIKE
	{
		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x21A5530", Offset = "0x21A3B30", VA = "0x1821A5530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	private bool MMHHOIHHODP
	{
		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x21A5580", Offset = "0x21A3B80", VA = "0x1821A5580")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	private bool LCKFDKHAHDB
	{
		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x21A5130", Offset = "0x21A3730", VA = "0x1821A5130")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x21A5350", Offset = "0x21A3950", VA = "0x1821A5350")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HJCPAGILLFK))]
	public static Task INHJMLKPHDN(LCNJJEKDLHB LCPJEGLKADH, EPFFDDEKBCK GOMDNNCBLHP, EJKLHKJLFLB GONKAHKFNDA, bool ANBMJHGGJBH, NHNLOHOBNME<string>.NOELMCIDFEB FLAKFKAEKNJ, CancellationToken OOAGLCBNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x21A51C0", Offset = "0x21A37C0", VA = "0x1821A51C0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PLOCFHLJHOG))]
	private Task INHJMLKPHDN(NHNLOHOBNME<string>.NOELMCIDFEB FLAKFKAEKNJ, CancellationToken OOAGLCBNIOG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
internal static class LGKNIADMOPL
{
	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x27323D0", Offset = "0x27309D0", VA = "0x1827323D0")]
	public static void CBNCEMFEODF(this FEFAAKGBGKB EIDDIFBENKM, LHJOLIPPMAL ECOIBMDGMFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x2732520", Offset = "0x2730B20", VA = "0x182732520")]
	public static void PFLAFAGOHCF(this LHJOLIPPMAL PMOFNJKBKJI, [Optional] string JIEHBANCLJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
internal struct GDOEPJCMKMH
{
	[Cpp2IlInjected.Token(Token = "0x2000116")]
	[CompilerGenerated]
	private sealed class CLKPEFBPGMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public GDOEPJCMKMH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		private NHNLOHOBNME<string>.NOELMCIDFEB <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		private float <nextResendTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public CLKPEFBPGMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x36AEBA0", Offset = "0x36AD1A0", VA = "0x1836AEBA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000482")]
	private const int IGOFCKIANJF = 20;

	[Cpp2IlInjected.Token(Token = "0x4000483")]
	private const float DPEEEGNAEGC = 15f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000484")]
	private OPEIFKONHHI OODHPHIHFDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000485")]
	private EPFFDDEKBCK GOMDNNCBLHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000486")]
	private NHNLOHOBNME<string>.NOELMCIDFEB BCLLAMGBKIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000487")]
	private float IDOPJIJAADK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000488")]
	private float FACHBEHNBEA;

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x21A01A0", Offset = "0x219E7A0", VA = "0x1821A01A0")]
	public static Task GDFLNNKAFEE(LCNJJEKDLHB LCPJEGLKADH, EPFFDDEKBCK GOMDNNCBLHP, NHNLOHOBNME<string>.NOELMCIDFEB FLAKFKAEKNJ, CancellationToken OOAGLCBNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x21A0330", Offset = "0x219E930", VA = "0x1821A0330")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CLKPEFBPGMG))]
	public Task INHJMLKPHDN(CancellationToken OOAGLCBNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x21A0480", Offset = "0x219EA80", VA = "0x1821A0480")]
	private static void KNPHOENJBIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x21A0630", Offset = "0x219EC30", VA = "0x1821A0630")]
	private void ONLKOAAGFDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x21A00D0", Offset = "0x219E6D0", VA = "0x1821A00D0")]
	private static float BPEMOPNHCII(OPEIFKONHHI OODHPHIHFDJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x21A0180", Offset = "0x219E780", VA = "0x1821A0180")]
	private static float DHLMEANKOLI()
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
internal class EJKLHKJLFLB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	[CompilerGenerated]
	private sealed class JPGJFFIICPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public AsyncTaskMethodBuilder<IHCOLCCANMI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public NHNLOHOBNME<string>.NOELMCIDFEB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public IHCOLCCANMI roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public EJKLHKJLFLB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		private NHNLOHOBNME<string>.NOELMCIDFEB <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		private IHCOLCCANMI <message>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		private BKDLHCNELBM.MKDJFBMHGFF<IHCOLCCANMI> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		private TaskAwaiter<BKDLHCNELBM.MKDJFBMHGFF<IHCOLCCANMI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public JPGJFFIICPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x36B9C70", Offset = "0x36B8270", VA = "0x1836B9C70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[CompilerGenerated]
	private struct KOHGEDHJNDC<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x200011C")]
	[CompilerGenerated]
	private sealed class OMLNBJFCHPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public IHCOLCCANMI roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public OMLNBJFCHPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x36BE850", Offset = "0x36BCE50", VA = "0x1836BE850")]
		internal IHCOLCCANMI IHLNOLPGKLI(byte[] msg)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011D")]
	[CompilerGenerated]
	private sealed class KOFDJPJHBEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public AsyncTaskMethodBuilder<BKDLHCNELBM.MKDJFBMHGFF<IHCOLCCANMI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public IHCOLCCANMI roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public EJKLHKJLFLB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		private OMLNBJFCHPI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		private ONKPGICOKGI <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		private BKDLHCNELBM.MKDJFBMHGFF<IHCOLCCANMI> <response>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		private ONKPGICOKGI <actualMessageKind>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		private BKDLHCNELBM.MKDJFBMHGFF<IHCOLCCANMI> <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		private string <errorMessage>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		private ByteString <actualOperationId>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		private string <errorMessage>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		private TaskAwaiter<BKDLHCNELBM.MKDJFBMHGFF<IHCOLCCANMI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public KOFDJPJHBEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x36BACA0", Offset = "0x36B92A0", VA = "0x1836BACA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011E")]
	[CompilerGenerated]
	private sealed class IKJPGENNKKC<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public Func<CancellationToken, Task<T>> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public EJKLHKJLFLB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		private T <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x97F990", Offset = "0x97DF90", VA = "0x18097F990")]
		public IKJPGENNKKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x1FF3E30", Offset = "0x1FF2430", VA = "0x181FF3E30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011F")]
	[CompilerGenerated]
	private sealed class OPDPKFFLOAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public EJKLHKJLFLB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public OPDPKFFLOAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x36BEB20", Offset = "0x36BD120", VA = "0x1836BEB20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000120")]
	[CompilerGenerated]
	private sealed class ENMLOKLBPNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public ENMLOKLBPNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x36B4480", Offset = "0x36B2A80", VA = "0x1836B4480")]
		internal object DHOLPOCMDJP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x36B44E0", Offset = "0x36B2AE0", VA = "0x1836B44E0")]
		internal bool LFPOODFDMII(Guid guid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000121")]
	[CompilerGenerated]
	private sealed class PKCHPGKNIDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public PKCHPGKNIDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0x36BF360", Offset = "0x36BD960", VA = "0x1836BF360")]
		internal object DINBOKFMMJD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000122")]
	[CompilerGenerated]
	private sealed class FJCLNOBJMII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public FJCLNOBJMII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x36B5A10", Offset = "0x36B4010", VA = "0x1836B5A10")]
		internal object LGIOCADNGHO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000123")]
	[CompilerGenerated]
	private sealed class KMCILNBOPIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public KMCILNBOPIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x36BA320", Offset = "0x36B8920", VA = "0x1836BA320")]
		internal object DPGHDCHODBB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000125")]
	[CompilerGenerated]
	private sealed class CNPANDFDHFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public EJKLHKJLFLB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public CNPANDFDHFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x36AEFE0", Offset = "0x36AD5E0", VA = "0x1836AEFE0")]
		internal object JGMCMOPEHCM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[CompilerGenerated]
	private sealed class EPINECNCHBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public Func<string> stepMessageGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public EJKLHKJLFLB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public EPINECNCHBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x36B46A0", Offset = "0x36B2CA0", VA = "0x1836B46A0")]
		internal object JGMCMOPEHCM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000493")]
	private static readonly Guid PFKCPIPMBGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000494")]
	public readonly CDNJKKMBNED HBBJBEIDKBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000495")]
	private readonly BKDLHCNELBM HAGECEOMFGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000496")]
	private readonly DCFHCGLJFIC EGGPOCDMEIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000497")]
	private readonly BHMILIMCEBF EOELGHNBBEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000498")]
	private bool NOHAMBOLGJK;

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x219C890", Offset = "0x219AE90", VA = "0x18219C890")]
	public EJKLHKJLFLB(CDNJKKMBNED IDHOKMNCGAF, BKDLHCNELBM HAGECEOMFGC, DCFHCGLJFIC EGGPOCDMEIJ, BHMILIMCEBF EOELGHNBBEL, NHNLOHOBNME<string>.NOELMCIDFEB FLAKFKAEKNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x219B270", Offset = "0x2199870", VA = "0x18219B270", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x219B270", Offset = "0x2199870", VA = "0x18219B270")]
	public void CCPJAFNMDCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x219C4F0", Offset = "0x219AAF0", VA = "0x18219C4F0")]
	public void KBDKNGCGNHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x219BE50", Offset = "0x219A450", VA = "0x18219BE50")]
	public void HIPBLIFNHBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x219C190", Offset = "0x219A790", VA = "0x18219C190")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JPGJFFIICPA))]
	internal Task<IHCOLCCANMI> IMIOEFGBFOE(NHNLOHOBNME<string>.NOELMCIDFEB FLAKFKAEKNJ, IHCOLCCANMI IDIAJJIINJH, CancellationToken OOAGLCBNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(RVA = "0x21A76E0", Offset = "0x21A5CE0", VA = "0x1821A76E0")]
	private static byte[] KMJDBNKLOMF<T>(T JIEHBANCLJP) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(RVA = "0x295A730", Offset = "0x2958D30", VA = "0x18295A730")]
	private static T ELGACKNLIJC<T>(MessageParser<T> JKGECHDDOMG, byte[] JIEHBANCLJP, T JGGIONOLNIC) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x219B950", Offset = "0x2199F50", VA = "0x18219B950")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KOFDJPJHBEM))]
	private Task<BKDLHCNELBM.MKDJFBMHGFF<IHCOLCCANMI>> EJAJFIFKHNP(IHCOLCCANMI IDIAJJIINJH, CancellationToken OOAGLCBNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x295A8E0", Offset = "0x2958EE0", VA = "0x18295A8E0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IKJPGENNKKC<>))]
	internal Task<T> EMMBEPHOFCI<T>(CancellationToken OHDMAIAEMEE, Func<CancellationToken, Task<T>> BFBBDEDIBGM, int GKGAMPKFFKF = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x219BAF0", Offset = "0x219A0F0", VA = "0x18219BAF0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OPDPKFFLOAM))]
	internal Task EMMBEPHOFCI(CancellationToken OHDMAIAEMEE, Func<CancellationToken, Task> BFBBDEDIBGM, int GKGAMPKFFKF = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x219BDC0", Offset = "0x219A3C0", VA = "0x18219BDC0")]
	public IHCOLCCANMI HEBEPEPCNDI(ONKPGICOKGI KPMDHOFHNBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x219BCF0", Offset = "0x219A2F0", VA = "0x18219BCF0")]
	public DIHBOGADNHJ GIGHOHGNCJK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x219BC80", Offset = "0x219A280", VA = "0x18219BC80")]
	public PNCAOKGAGKF FLBKNECHJCH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x219B420", Offset = "0x2199A20", VA = "0x18219B420")]
	public JOHHPAJAAMJ CPNGCDBFJDP([Optional] LMNLAEPPONM? OFHAEKEDPCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x219C7F0", Offset = "0x219ADF0", VA = "0x18219C7F0")]
	public void PCJAHKCMDPG(Func<Guid, bool> GHPPJEFLOKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x219BFB0", Offset = "0x219A5B0", VA = "0x18219BFB0")]
	public void HJMCMGHGHNJ(Func<Guid, bool> PCMAIJKJJOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x219C650", Offset = "0x219AC50", VA = "0x18219C650")]
	public void NODDCCBOLEP(Func<Guid, bool> GHPPJEFLOKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x219B730", Offset = "0x2199D30", VA = "0x18219B730")]
	public Guid EHPFAIHEPCI()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x219B590", Offset = "0x2199B90", VA = "0x18219B590")]
	public void DLEAFFMCCAE(Guid EIAFMCFHBGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x219C3A0", Offset = "0x219A9A0", VA = "0x18219C3A0")]
	public void JPOMEMMEDIM(IHCOLCCANMI NELKGLJILCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x219AF50", Offset = "0x2199550", VA = "0x18219AF50")]
	public void BKMKBHBEAIO(string GDMGFCEAIEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x219B0E0", Offset = "0x21996E0", VA = "0x18219B0E0")]
	public void BKMKBHBEAIO(Func<string> DOJMKKOFCAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x295ACE0", Offset = "0x29592E0", VA = "0x18295ACE0")]
	private T IKMGAMBOFBM<T>(T FEBHELIDNED) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x219C350", Offset = "0x219A950", VA = "0x18219C350")]
	public void JCOCNDBHADA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x295A420", Offset = "0x2958A20", VA = "0x18295A420")]
	[CompilerGenerated]
	internal static string DGBEFKCPLFE<T>(byte[] FBHPMOOILJP, int FJHPIDCEGNP, ref KOHGEDHJNDC<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
internal struct CMBEDLEABGN
{
	[Cpp2IlInjected.Token(Token = "0x2000128")]
	[CompilerGenerated]
	private sealed class ONJEABLHBCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public LCNJJEKDLHB roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		public EPFFDDEKBCK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public EJKLHKJLFLB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public NHNLOHOBNME<string>.NOELMCIDFEB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public ONJEABLHBCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x36BE970", Offset = "0x36BCF70", VA = "0x1836BE970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[CompilerGenerated]
	private sealed class BFMGCAEDPGK
	{
		[Cpp2IlInjected.Token(Token = "0x200012A")]
		private sealed class <<Run>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004DE")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004DF")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004E0")]
			public NHNLOHOBNME<string>.NOELMCIDFEB timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004E1")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004E2")]
			public BFMGCAEDPGK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40004E3")]
			private NHNLOHOBNME<string>.NOELMCIDFEB <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40004E4")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600056B")]
			[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
			public <<Run>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600056C")]
			[Cpp2IlInjected.Address(RVA = "0x612D2D0", Offset = "0x612B8D0", VA = "0x18612D2D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600056D")]
			[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public BFMGCAEDPGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x272ACE0", Offset = "0x27292E0", VA = "0x18272ACE0")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task JBNKCBLFIIL(NHNLOHOBNME<string>.NOELMCIDFEB timer, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	private sealed class CIIOGAACKLC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public NHNLOHOBNME<string>.NOELMCIDFEB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public CMBEDLEABGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		private MLOCEEOLAMF.FNBAANFJAOH <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		private AGRoomRuntimeConfig.Location <locationConfig>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		private BFMGCAEDPGK <>8__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		private IHCOLCCANMI <completeMessage>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		private object <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		private int <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		private TaskAwaiter<IHCOLCCANMI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public CIIOGAACKLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x272B6E0", Offset = "0x2729CE0", VA = "0x18272B6E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[CompilerGenerated]
	private sealed class BHJPOHJONKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		public PJLOEOJDLAF version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public bool preserveScoreboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public List<PersistenceView> existingViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public List<GameObject> objectsToDestroy;

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public BHJPOHJONKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x272AE50", Offset = "0x2729450", VA = "0x18272AE50")]
		internal object KAKAJHNOKDA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x272AF30", Offset = "0x2729530", VA = "0x18272AF30")]
		internal object MFNHBLEMGAI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	private LCNJJEKDLHB LCPJEGLKADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	private EPFFDDEKBCK GOMDNNCBLHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	private EJKLHKJLFLB GONKAHKFNDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	private bool OCODNLPHOBE;

	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	private static readonly ByteString CBMIFDJIFEK;

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	private OPEIFKONHHI JLLINPPOIKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x2193120", Offset = "0x2191720", VA = "0x182193120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	private CFIDKJEMCJA NNHNHPMAIMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x21938B0", Offset = "0x2191EB0", VA = "0x1821938B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x2192F40", Offset = "0x2191540", VA = "0x182192F40")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ONJEABLHBCM))]
	public static Task INHJMLKPHDN(LCNJJEKDLHB LCPJEGLKADH, EPFFDDEKBCK GOMDNNCBLHP, EJKLHKJLFLB GONKAHKFNDA, NHNLOHOBNME<string>.NOELMCIDFEB FLAKFKAEKNJ, CancellationToken OOAGLCBNIOG, bool OCODNLPHOBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x2192DC0", Offset = "0x21913C0", VA = "0x182192DC0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CIIOGAACKLC))]
	private Task INHJMLKPHDN(NHNLOHOBNME<string>.NOELMCIDFEB FLAKFKAEKNJ, CancellationToken OOAGLCBNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x2193170", Offset = "0x2191770", VA = "0x182193170")]
	private void PAHANCPOOCL([NotNull] NGDMEJFKJLL CJLLNAEEKIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x2192D60", Offset = "0x2191360", VA = "0x182192D60")]
	private bool FDNHDPMIGCL(PJLOEOJDLAF BOBBHCFAPPK, NGDMEJFKJLL CJLLNAEEKIK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
internal abstract class POHLAOINFCI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	public readonly CDNJKKMBNED HBBJBEIDKBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	public readonly EJKLHKJLFLB ONIPCIDGADK;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public OPEIFKONHHI JLLINPPOIKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x2744C20", Offset = "0x2743220", VA = "0x182744C20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public CFIDKJEMCJA NNHNHPMAIMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x2744C40", Offset = "0x2743240", VA = "0x182744C40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x2744CA0", Offset = "0x27432A0", VA = "0x182744CA0")]
	protected POHLAOINFCI(EJKLHKJLFLB GONKAHKFNDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x2744C00", Offset = "0x2743200", VA = "0x182744C00")]
	protected void BKMKBHBEAIO(string GDMGFCEAIEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x2744BE0", Offset = "0x27431E0", VA = "0x182744BE0")]
	public void BKMKBHBEAIO(Func<string> DOJMKKOFCAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
internal class PNCAOKGAGKF : POHLAOINFCI, LLONGIMPABL
{
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	public delegate Task<BBBKKMMJPEP> LEHKGCOAJEC(EPFFDDEKBCK GOMDNNCBLHP, KOMFNDJENBN FAMDHGBJAHD, JALHEGJIFHN KKCJEIMEMNE, NHNLOHOBNME<string>.NOELMCIDFEB FLAKFKAEKNJ, CancellationToken OOAGLCBNIOG);

	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[CompilerGenerated]
	private sealed class FAMJKAJBLEG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public FICOENLLCNC request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public NHNLOHOBNME<string>.NOELMCIDFEB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		public PNCAOKGAGKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		private FEGACIBFFJD <lifetime>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		private IHCOLCCANMI <synced>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		private IHCOLCCANMI <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		private TaskAwaiter<IHCOLCCANMI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public FAMJKAJBLEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x6126FE0", Offset = "0x61255E0", VA = "0x186126FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[CompilerGenerated]
	private sealed class IBDGOEMNLIH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public AsyncTaskMethodBuilder<IHCOLCCANMI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public FICOENLLCNC request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public NHNLOHOBNME<string>.NOELMCIDFEB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		public PNCAOKGAGKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		private NHNLOHOBNME<string>.NOELMCIDFEB <syncTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		private IHCOLCCANMI <message>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		private IHCOLCCANMI <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		private TaskAwaiter<IHCOLCCANMI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public IBDGOEMNLIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x6127400", Offset = "0x6125A00", VA = "0x186127400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000132")]
	[CompilerGenerated]
	private sealed class CDNKEBAANEN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		public FICOENLLCNC request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		public NHNLOHOBNME<string>.NOELMCIDFEB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		public PNCAOKGAGKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		private NHNLOHOBNME<string>.NOELMCIDFEB <loadRoomLocalTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public CDNKEBAANEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x6124B00", Offset = "0x6123100", VA = "0x186124B00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000133")]
	[CompilerGenerated]
	private sealed class KJJLBPHOKMI
	{
		[Cpp2IlInjected.Token(Token = "0x2000134")]
		private sealed class <<LoadRoomLocal>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000524")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000525")]
			public AsyncTaskMethodBuilder<BFIGLLFHPEJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000526")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000527")]
			public KJJLBPHOKMI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000528")]
			private BFIGLLFHPEJ <innerData>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000529")]
			private BFIGLLFHPEJ <>s__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x400052A")]
			private TaskAwaiter<BBBKKMMJPEP> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x400052B")]
			private TaskAwaiter<BFIGLLFHPEJ> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005AC")]
			[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
			public <<LoadRoomLocal>b__2>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AD")]
			[Cpp2IlInjected.Address(RVA = "0x612BE40", Offset = "0x612A440", VA = "0x18612BE40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AE")]
			[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000135")]
		private sealed class <<LoadRoomLocal>b__4>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400052C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400052D")]
			public AsyncTaskMethodBuilder<EPFFDDEKBCK> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400052E")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400052F")]
			public KJJLBPHOKMI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000530")]
			private EPFFDDEKBCK <innerPhaseArgs>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000531")]
			private EPFFDDEKBCK <>s__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000532")]
			private TaskAwaiter<BBBKKMMJPEP> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000533")]
			private TaskAwaiter<EPFFDDEKBCK> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005AF")]
			[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
			public <<LoadRoomLocal>b__4>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B0")]
			[Cpp2IlInjected.Address(RVA = "0x612C590", Offset = "0x612AB90", VA = "0x18612C590", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B1")]
			[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000136")]
		private sealed class <<LoadRoomLocal>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000534")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000535")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000536")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000537")]
			public KJJLBPHOKMI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000538")]
			private bool <isReloadingSceneForObjectModel>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
			[Cpp2IlInjected.Token(Token = "0x4000539")]
			private bool <>s__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400053A")]
			private KOMFNDJENBN <timedYielder>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400053B")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400053C")]
			private TaskAwaiter<BBBKKMMJPEP> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400053D")]
			private TaskAwaiter <>u__3;

			[Cpp2IlInjected.Token(Token = "0x60005B2")]
			[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
			public <<LoadRoomLocal>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B3")]
			[Cpp2IlInjected.Address(RVA = "0x612AA00", Offset = "0x6129000", VA = "0x18612AA00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B4")]
			[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public PNCAOKGAGKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public FICOENLLCNC request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public JALHEGJIFHN preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		public NHNLOHOBNME<string>.NOELMCIDFEB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		public JALHEGJIFHN downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		public BFIGLLFHPEJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		public JALHEGJIFHN postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		public EPFFDDEKBCK phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		public CKOCLAJPHIF.FNBDNFIGDMM <>9__6;

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public KJJLBPHOKMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x61286D0", Offset = "0x6126CD0", VA = "0x1861286D0")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__2>d))]
		internal Task<BFIGLLFHPEJ> NDNAMJKENJD(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x6128560", Offset = "0x6126B60", VA = "0x186128560")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__4>d))]
		internal Task<EPFFDDEKBCK> JIJJLEGCIJA(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x61283D0", Offset = "0x61269D0", VA = "0x1861283D0")]
		internal void BMDAPECHMJG(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x6128410", Offset = "0x6126A10", VA = "0x186128410")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__0>d))]
		internal Task EPJAAAINLBK(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000138")]
	[CompilerGenerated]
	private sealed class BPDOLICMJFL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		public FICOENLLCNC request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		public NHNLOHOBNME<string>.NOELMCIDFEB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		public PNCAOKGAGKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		private KJJLBPHOKMI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		private bool <hasAssetBundle>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		private float <dataDownloadProgressRangeUpperBound>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		private BFIGLLFHPEJ <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		private EPFFDDEKBCK <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		private TaskAwaiter<BFIGLLFHPEJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		private TaskAwaiter<EPFFDDEKBCK> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public BPDOLICMJFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x6123DB0", Offset = "0x61223B0", VA = "0x186123DB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000139")]
	[CompilerGenerated]
	private sealed class OKMHIMFOLAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		public NHNLOHOBNME<string>.NOELMCIDFEB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		public PNCAOKGAGKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public OKMHIMFOLAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x6129E00", Offset = "0x6128400", VA = "0x186129E00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013A")]
	[CompilerGenerated]
	private sealed class IPLLAFGFFNO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		public EPFFDDEKBCK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public JALHEGJIFHN progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public NHNLOHOBNME<string>.NOELMCIDFEB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public PNCAOKGAGKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		private NHNLOHOBNME<string>.NOELMCIDFEB <legacyLoadRoomDataTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		private TaskAwaiter<BBBKKMMJPEP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public IPLLAFGFFNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x6127C60", Offset = "0x6126260", VA = "0x186127C60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013B")]
	[CompilerGenerated]
	private sealed class CNCLOMKKJBJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		public AsyncTaskMethodBuilder<BBBKKMMJPEP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		public EPFFDDEKBCK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		public KOMFNDJENBN timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		public JALHEGJIFHN progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		public NHNLOHOBNME<string>.NOELMCIDFEB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		public PNCAOKGAGKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		private NHNLOHOBNME<string>.NOELMCIDFEB <destroyAndRebuildObjectsTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		private TaskAwaiter<BBBKKMMJPEP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public CNCLOMKKJBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x61253E0", Offset = "0x61239E0", VA = "0x1861253E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[CompilerGenerated]
	private sealed class EBKGANBJPLG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		public AsyncTaskMethodBuilder<BBBKKMMJPEP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		public EPFFDDEKBCK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		public KOMFNDJENBN timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		public JALHEGJIFHN progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		public NHNLOHOBNME<string>.NOELMCIDFEB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		public PNCAOKGAGKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		private NHNLOHOBNME<string>.NOELMCIDFEB <deserializeAllObjectsTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		private TaskAwaiter<BBBKKMMJPEP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public EBKGANBJPLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x6126300", Offset = "0x6124900", VA = "0x186126300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[CompilerGenerated]
	private sealed class NIMNIEHDKCD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public AsyncTaskMethodBuilder<BBBKKMMJPEP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public BBBKKMMJPEP operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		public EPFFDDEKBCK deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public JALHEGJIFHN progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public NHNLOHOBNME<string>.NOELMCIDFEB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		public PNCAOKGAGKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		private BBBKKMMJPEP <result>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		private BBBKKMMJPEP <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		private TaskAwaiter<BBBKKMMJPEP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public NIMNIEHDKCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x6129770", Offset = "0x6127D70", VA = "0x186129770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[CompilerGenerated]
	private sealed class ODJDDPMHIJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		public PNCAOKGAGKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		public EPFFDDEKBCK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		public JALHEGJIFHN progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		public NHNLOHOBNME<string>.NOELMCIDFEB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		public LEHKGCOAJEC masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		public KOMFNDJENBN timedYielder;

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public ODJDDPMHIJE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013F")]
	[CompilerGenerated]
	private sealed class JOKNFPGBDHH
	{
		[Cpp2IlInjected.Token(Token = "0x2000140")]
		private sealed class <<MasterLockedPhaseChangeBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400058B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400058C")]
			public AsyncTaskMethodBuilder<BBBKKMMJPEP> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400058D")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400058E")]
			public JOKNFPGBDHH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400058F")]
			private MLOCEEOLAMF.FNBAANFJAOH <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000590")]
			private BBBKKMMJPEP <result>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x4000591")]
			private BBBKKMMJPEP <>s__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000592")]
			private TaskAwaiter<BBBKKMMJPEP> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005D0")]
			[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
			public <<MasterLockedPhaseChangeBlock>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D1")]
			[Cpp2IlInjected.Address(RVA = "0x612CB80", Offset = "0x612B180", VA = "0x18612CB80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D2")]
			[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		public BBBKKMMJPEP originalRoomLoadPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		public ODJDDPMHIJE CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public JOKNFPGBDHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x6128260", Offset = "0x6126860", VA = "0x186128260")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<BBBKKMMJPEP> DOGNHOBDGOH(CancellationToken mlToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000141")]
	[CompilerGenerated]
	private sealed class KLMIKBKNABE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		public AsyncTaskMethodBuilder<BBBKKMMJPEP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		public EPFFDDEKBCK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		public KOMFNDJENBN timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		public JALHEGJIFHN progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		public NHNLOHOBNME<string>.NOELMCIDFEB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		public LEHKGCOAJEC masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		public PNCAOKGAGKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		private ODJDDPMHIJE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		private MLOCEEOLAMF.FNBAANFJAOH <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		private JOKNFPGBDHH <>8__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		private BBBKKMMJPEP <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		private TaskAwaiter<BBBKKMMJPEP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public KLMIKBKNABE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x6128840", Offset = "0x6126E40", VA = "0x186128840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000142")]
	[CompilerGenerated]
	private sealed class NLPCHCNPIBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		public EPFFDDEKBCK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		public JALHEGJIFHN progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		public NHNLOHOBNME<string>.NOELMCIDFEB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		public PNCAOKGAGKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		private BBBKKMMJPEP <legacyEndPhase>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		private IEnumerator<BBBKKMMJPEP> <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		private BBBKKMMJPEP <phase>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		private TaskAwaiter<BBBKKMMJPEP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public NLPCHCNPIBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x6129990", Offset = "0x6127F90", VA = "0x186129990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000143")]
	[CompilerGenerated]
	private sealed class LIFJCJIPCPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		public EPFFDDEKBCK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		public NHNLOHOBNME<string>.NOELMCIDFEB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		public PNCAOKGAGKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public LIFJCJIPCPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x6129400", Offset = "0x6127A00", VA = "0x186129400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000144")]
	[CompilerGenerated]
	private sealed class ABJCNOJFEAI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		public EPFFDDEKBCK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		public PNCAOKGAGKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public ABJCNOJFEAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x61232F0", Offset = "0x61218F0", VA = "0x1861232F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000145")]
	[CompilerGenerated]
	private sealed class BMKOBLMPEAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		public LMPJDKBMOBF roomDetails;

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public BMKOBLMPEAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x6123B20", Offset = "0x6122120", VA = "0x186123B20")]
		internal object IOIOGIKMHOB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004F8")]
	private readonly KMGFNNFFDCD BIBIABBBBMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	private readonly KMGFNNFFDCD EMCFOFLAADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	private readonly GEIFDGGEAAC KFEFPLGAPED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	private readonly BLDODCCBCMF AMJALHDPDON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	private readonly PELNLIJKBFI PAMJANCDGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	private readonly MPHICIHCHHN NCCAJKPFHCL;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public float KDIDPAPKBOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x2742F20", Offset = "0x2741520", VA = "0x182742F20", Slot = "6")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	private LCNJJEKDLHB CHKGBBHIKAG
	{
		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x2193F00", Offset = "0x2192500", VA = "0x182193F00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event DKDDDDIDIBP GFJOGDKDKBE
	{
		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x2743D60", Offset = "0x2742360", VA = "0x182743D60", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x27444F0", Offset = "0x2742AF0", VA = "0x1827444F0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x2744510", Offset = "0x2742B10", VA = "0x182744510")]
	public PNCAOKGAGKF(EJKLHKJLFLB GONKAHKFNDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x2742860", Offset = "0x2740E60", VA = "0x182742860")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FAMJKAJBLEG))]
	public Task EBKBCCPLCBG(FICOENLLCNC PKNENDONMCN, NHNLOHOBNME<string>.NOELMCIDFEB FLAKFKAEKNJ, CancellationToken OOAGLCBNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x2742BD0", Offset = "0x27411D0", VA = "0x182742BD0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IBDGOEMNLIH))]
	private Task<IHCOLCCANMI> EIBECOKNIHG(FICOENLLCNC PKNENDONMCN, NHNLOHOBNME<string>.NOELMCIDFEB FLAKFKAEKNJ, CancellationToken OOAGLCBNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x27431E0", Offset = "0x27417E0", VA = "0x1827431E0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CDNKEBAANEN))]
	private Task HGBINOGFMHH(FICOENLLCNC PKNENDONMCN, NHNLOHOBNME<string>.NOELMCIDFEB FLAKFKAEKNJ, CancellationToken OOAGLCBNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x2742470", Offset = "0x2740A70", VA = "0x182742470")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BPDOLICMJFL))]
	private Task ACCFELPJOIJ(FICOENLLCNC PKNENDONMCN, NHNLOHOBNME<string>.NOELMCIDFEB FLAKFKAEKNJ, CancellationToken PCHCGDABLPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x2742D90", Offset = "0x2741390", VA = "0x182742D90")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OKMHIMFOLAO))]
	private Task EJEGGCKCKOJ(NHNLOHOBNME<string>.NOELMCIDFEB BCLLAMGBKIH, CancellationToken OOAGLCBNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x2743990", Offset = "0x2741F90", VA = "0x182743990")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IPLLAFGFFNO))]
	private Task IPBCNKADEKK(EPFFDDEKBCK GOMDNNCBLHP, JALHEGJIFHN KKCJEIMEMNE, NHNLOHOBNME<string>.NOELMCIDFEB FLAKFKAEKNJ, CancellationToken OOAGLCBNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x2743540", Offset = "0x2741B40", VA = "0x182743540")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CNCLOMKKJBJ))]
	private Task<BBBKKMMJPEP> HIMNOPEOLPG(EPFFDDEKBCK GOMDNNCBLHP, KOMFNDJENBN LEPCLCJIPJF, JALHEGJIFHN KKCJEIMEMNE, NHNLOHOBNME<string>.NOELMCIDFEB FLAKFKAEKNJ, CancellationToken OOAGLCBNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0x2743D80", Offset = "0x2742380", VA = "0x182743D80")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EBKGANBJPLG))]
	private Task<BBBKKMMJPEP> KKIKIGMPPHO(EPFFDDEKBCK GOMDNNCBLHP, KOMFNDJENBN LEPCLCJIPJF, JALHEGJIFHN KKCJEIMEMNE, NHNLOHOBNME<string>.NOELMCIDFEB FLAKFKAEKNJ, CancellationToken OOAGLCBNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x2743B50", Offset = "0x2742150", VA = "0x182743B50")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NIMNIEHDKCD))]
	private Task<BBBKKMMJPEP> IPGMNMBDKLE(BBBKKMMJPEP EHHKMOGNNNP, EPFFDDEKBCK EHBDJPBNDDH, JALHEGJIFHN KKCJEIMEMNE, NHNLOHOBNME<string>.NOELMCIDFEB FLAKFKAEKNJ, CancellationToken OOAGLCBNIOG, bool OCFGKKELKCM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x2742F40", Offset = "0x2741540", VA = "0x182742F40")]
	private bool HCPKBKDBDLF(EPFFDDEKBCK AHOCGEANOLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x2743F90", Offset = "0x2742590", VA = "0x182743F90")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KLMIKBKNABE))]
	protected Task<BBBKKMMJPEP> LFJAKPBJGDF(EPFFDDEKBCK GOMDNNCBLHP, KOMFNDJENBN LEPCLCJIPJF, JALHEGJIFHN KKCJEIMEMNE, NHNLOHOBNME<string>.NOELMCIDFEB FLAKFKAEKNJ, CancellationToken OOAGLCBNIOG, LEHKGCOAJEC FIKPDFDHBGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x2743380", Offset = "0x2741980", VA = "0x182743380")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NLPCHCNPIBC))]
	private Task HHAPFNBFOEG(EPFFDDEKBCK GOMDNNCBLHP, JALHEGJIFHN KKCJEIMEMNE, NHNLOHOBNME<string>.NOELMCIDFEB FLAKFKAEKNJ, CancellationToken OOAGLCBNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x27427D0", Offset = "0x2740DD0", VA = "0x1827427D0")]
	private void DLCBMEPGJDO(BBBKKMMJPEP AKICLOPICEN, JALHEGJIFHN KKCJEIMEMNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x2742B90", Offset = "0x2741190", VA = "0x182742B90")]
	private void EHFNIAIOIBN(BBBKKMMJPEP CLPOJAGJOOO, out BBBKKMMJPEP JOADIGMBMKG, out BBBKKMMJPEP OODJPEHNJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x2743010", Offset = "0x2741610", VA = "0x182743010")]
	private Task<BFIGLLFHPEJ> HFBDMBJKDLL(FICOENLLCNC PKNENDONMCN, NHNLOHOBNME<string>.NOELMCIDFEB FLAKFKAEKNJ, CancellationToken OOAGLCBNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x2742820", Offset = "0x2740E20", VA = "0x182742820")]
	private Task<EPFFDDEKBCK> DNCGKDJKEML(BFIGLLFHPEJ GOMDNNCBLHP, CKOCLAJPHIF.FNBDNFIGDMM BNKAKELBBBG, NHNLOHOBNME<string>.NOELMCIDFEB FLAKFKAEKNJ, CancellationToken OOAGLCBNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x2743750", Offset = "0x2741D50", VA = "0x182743750")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LIFJCJIPCPJ))]
	private Task HOJFBIDGAMO(EPFFDDEKBCK GOMDNNCBLHP, NHNLOHOBNME<string>.NOELMCIDFEB FLAKFKAEKNJ, CancellationToken OOAGLCBNIOG, bool OCODNLPHOBE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x2742610", Offset = "0x2740C10", VA = "0x182742610")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ABJCNOJFEAI))]
	private Task ANCJABLALCK(EPFFDDEKBCK GOMDNNCBLHP, CancellationToken OOAGLCBNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x2743050", Offset = "0x2741650", VA = "0x182743050")]
	private Task HFKGHAHNEJL(EPFFDDEKBCK GOMDNNCBLHP, CancellationToken OOAGLCBNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x2742A00", Offset = "0x2741000", VA = "0x182742A00")]
	private Task EDPDNHEJJGP(EPFFDDEKBCK GOMDNNCBLHP, NHNLOHOBNME<string>.NOELMCIDFEB FLAKFKAEKNJ, CancellationToken OOAGLCBNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x2742F00", Offset = "0x2741500", VA = "0x182742F00")]
	private Task FIBNHFDJAEJ(EPFFDDEKBCK GOMDNNCBLHP, KOMFNDJENBN LEPCLCJIPJF, NHNLOHOBNME<string>.NOELMCIDFEB FLAKFKAEKNJ, CancellationToken OOAGLCBNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x27427A0", Offset = "0x2740DA0", VA = "0x1827427A0")]
	private Task BLHJODDEPLM(EPFFDDEKBCK GOMDNNCBLHP, KOMFNDJENBN LEPCLCJIPJF, NHNLOHOBNME<string>.NOELMCIDFEB FLAKFKAEKNJ, CancellationToken OOAGLCBNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x27427C0", Offset = "0x2740DC0", VA = "0x1827427C0")]
	private static Task DFDKGHEKMMF(CancellationToken OOAGLCBNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x27441E0", Offset = "0x27427E0", VA = "0x1827441E0")]
	private Task LMGOHLCGINK(EPFFDDEKBCK GOMDNNCBLHP, KOMFNDJENBN LEPCLCJIPJF, NHNLOHOBNME<string>.NOELMCIDFEB FLAKFKAEKNJ, CancellationToken OOAGLCBNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x2742780", Offset = "0x2740D80", VA = "0x182742780")]
	private Task APPFHOCDKGD(EPFFDDEKBCK GOMDNNCBLHP, NHNLOHOBNME<string>.NOELMCIDFEB FLAKFKAEKNJ, CancellationToken OOAGLCBNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x2743910", Offset = "0x2741F10", VA = "0x182743910")]
	private void IKGGIIEHNDD(FICOENLLCNC PKNENDONMCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x27441C0", Offset = "0x27427C0", VA = "0x1827441C0")]
	public void LFLMEOJEJIC(long JJCIAKAHHPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x2744380", Offset = "0x2742980", VA = "0x182744380")]
	private static void MBHCDACKOFH(LMPJDKBMOBF MIDAGNGFEKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000146")]
internal abstract class CDNJKKMBNED : LLONGIMPABL
{
	[Cpp2IlInjected.Token(Token = "0x2000147")]
	public delegate Task PNCLMCIGDGF(NHNLOHOBNME<string>.NOELMCIDFEB FLAKFKAEKNJ, CancellationToken OOAGLCBNIOG);

	[Cpp2IlInjected.Token(Token = "0x2000148")]
	[CompilerGenerated]
	private sealed class NDGFOJNPACD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		public NHNLOHOBNME<string>.NOELMCIDFEB operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		public CDNJKKMBNED <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public NDGFOJNPACD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x2737970", Offset = "0x2735F70", VA = "0x182737970")]
		internal Task PMFMOKHJDND(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000149")]
	[CompilerGenerated]
	private sealed class LLAPIIENNBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		public NDGFOJNPACD CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public LLAPIIENNBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x27328B0", Offset = "0x2730EB0", VA = "0x1827328B0")]
		internal object ODENKKJPOJM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x27327F0", Offset = "0x2730DF0", VA = "0x1827327F0")]
		internal object GDGKCJFKOMI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014A")]
	[CompilerGenerated]
	private sealed class DABBNELOALJ : IAsyncStateMachine
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
		public NHNLOHOBNME<string>.NOELMCIDFEB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		public Func<CDNJKKMBNED, NHNLOHOBNME<string>.NOELMCIDFEB, EJKLHKJLFLB> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		public CDNJKKMBNED <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		private NDGFOJNPACD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		private EJKLHKJLFLB <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		private Task <drivenTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		private IHCOLCCANMI <completeMessage>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		private LLAPIIENNBK <>8__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		private TaskAwaiter<IHCOLCCANMI> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public DABBNELOALJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x272DA90", Offset = "0x272C090", VA = "0x18272DA90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014B")]
	[CompilerGenerated]
	private sealed class FMEHHLCPEMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		public NHNLOHOBNME<string>.NOELMCIDFEB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		public CDNJKKMBNED <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		private PNCLMCIGDGF <taskBuilder>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public FMEHHLCPEMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0x2730000", Offset = "0x272E600", VA = "0x182730000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005BB")]
	public readonly Guid EFHOBDBDECD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005BC")]
	public readonly ByteString LDAOKIHLICL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40005BD")]
	public readonly JMODPMGGFBH CBNPAJGGFJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40005BE")]
	protected readonly string GDOKJNHMBIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40005BF")]
	private readonly LCNJJEKDLHB LCPJEGLKADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40005C0")]
	private readonly bool NEODFCLEJIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40005C1")]
	private readonly Queue<PNCLMCIGDGF> CKKNOJFNNMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40005C2")]
	private readonly JALHEGJIFHN KEPJKNOPJLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40005C3")]
	private readonly PHANMBGDINN PHBAINNDDIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40005C4")]
	private bool EIKGHAKBFJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40005C5")]
	public BBBKKMMJPEP MLBCLFOMOND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40005C6")]
	public BBBKKMMJPEP GBEBNADKDFL;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public LCNJJEKDLHB CHKGBBHIKAG
	{
		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x944080", Offset = "0x942680", VA = "0x180944080")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public OPEIFKONHHI JLLINPPOIKE
	{
		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x2190880", Offset = "0x218EE80", VA = "0x182190880")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public OEDMFBHOLOJ BCPPAOCIGFM
	{
		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x2190560", Offset = "0x218EB60", VA = "0x182190560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public CFIDKJEMCJA NNHNHPMAIMC
	{
		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x2190FB0", Offset = "0x218F5B0", VA = "0x182190FB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public float KDIDPAPKBOK
	{
		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x21905D0", Offset = "0x218EBD0", VA = "0x1821905D0", Slot = "6")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event DKDDDDIDIBP GFJOGDKDKBE
	{
		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x2190860", Offset = "0x218EE60", VA = "0x182190860", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x2190F90", Offset = "0x218F590", VA = "0x182190F90", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(RVA = "0x2191030", Offset = "0x218F630", VA = "0x182191030")]
	protected CDNJKKMBNED(Guid MGMFLGBPLHJ, LCNJJEKDLHB LCPJEGLKADH, JMODPMGGFBH OIHIMIHAFFJ, string DIMIKOJAFMI, PHANMBGDINN PHBAINNDDIK, bool NEODFCLEJIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(RVA = "0x2190680", Offset = "0x218EC80", VA = "0x182190680", Slot = "7")]
	protected virtual string HMCBBAFGGFF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(RVA = "0x2190CD0", Offset = "0x218F2D0", VA = "0x182190CD0")]
	public void KHGJKGPCFHJ(PNCLMCIGDGF BGJNBHJEKMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(RVA = "0x21905B0", Offset = "0x218EBB0", VA = "0x1821905B0")]
	protected void FBDHLALEDMM(float KMJAIGGLKJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(RVA = "0x21906C0", Offset = "0x218ECC0", VA = "0x1821906C0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DABBNELOALJ))]
	public Task INHJMLKPHDN(CancellationToken OOAGLCBNIOG, NHNLOHOBNME<string>.NOELMCIDFEB FLAKFKAEKNJ, [Optional] Func<CDNJKKMBNED, NHNLOHOBNME<string>.NOELMCIDFEB, EJKLHKJLFLB> EGJLNCPJBCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(RVA = "0x2190E10", Offset = "0x218F410", VA = "0x182190E10")]
	private void LGDCNKDHBKH(bool BMKKIDBNMCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(RVA = "0x2190A40", Offset = "0x218F040", VA = "0x182190A40")]
	private void KCNKLAKEBCJ(EJKLHKJLFLB GONKAHKFNDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task CKKDHFNBKAN(EJKLHKJLFLB GONKAHKFNDA, NHNLOHOBNME<string>.NOELMCIDFEB FLAKFKAEKNJ, CancellationToken OOAGLCBNIOG);

	[Cpp2IlInjected.Token(Token = "0x60005F0")]
	[Cpp2IlInjected.Address(RVA = "0x21908D0", Offset = "0x218EED0", VA = "0x1821908D0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FMEHHLCPEMG))]
	private Task KBOLAEPBIHJ(NHNLOHOBNME<string>.NOELMCIDFEB FLAKFKAEKNJ, CancellationToken OOAGLCBNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(RVA = "0x21905F0", Offset = "0x218EBF0", VA = "0x1821905F0")]
	public IHCOLCCANMI HEBEPEPCNDI(ONKPGICOKGI KPMDHOFHNBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F2")]
	[Cpp2IlInjected.Address(RVA = "0x2190D30", Offset = "0x218F330", VA = "0x182190D30")]
	[CompilerGenerated]
	private Task LBKEODDIJHM(CancellationToken KIJLBFEDEPN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200014C")]
internal abstract class DOJJHPANDDM : CDNJKKMBNED
{
	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[CompilerGenerated]
	private sealed class ICGIFALDENC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		public DOJJHPANDDM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		public NLPNILGFGNL playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public ICGIFALDENC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x36B7B00", Offset = "0x36B6100", VA = "0x1836B7B00")]
		internal Task CGPIHHPMBAM(NHNLOHOBNME<string>.NOELMCIDFEB postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x36B7B40", Offset = "0x36B6140", VA = "0x1836B7B40")]
		internal object MFNDAAKBKOA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014E")]
	[CompilerGenerated]
	private sealed class EIHPLEGHCGN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		public EJKLHKJLFLB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		public NHNLOHOBNME<string>.NOELMCIDFEB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		public DOJJHPANDDM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		private ICGIFALDENC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		private object <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		private int <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		private HGMJGDOBAKJ <recoverableRoomOperationException>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public EIHPLEGHCGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x36B29A0", Offset = "0x36B0FA0", VA = "0x1836B29A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[CompilerGenerated]
	private sealed class MOHAGALNNIL : IAsyncStateMachine
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
		public NLPNILGFGNL playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		public NHNLOHOBNME<string>.NOELMCIDFEB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		public DOJJHPANDDM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		private NHNLOHOBNME<string>.NOELMCIDFEB <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		private NHNLOHOBNME<string>.NOELMCIDFEB <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		private Exception <e>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public MOHAGALNNIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x36BD520", Offset = "0x36BBB20", VA = "0x1836BD520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(RVA = "0x2196140", Offset = "0x2194740", VA = "0x182196140")]
	public DOJJHPANDDM(Guid MGMFLGBPLHJ, LCNJJEKDLHB LCPJEGLKADH, JMODPMGGFBH OIHIMIHAFFJ, string DIMIKOJAFMI, PHANMBGDINN PHBAINNDDIK, bool NEODFCLEJIJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000603")]
	[Cpp2IlInjected.Address(RVA = "0x2195E00", Offset = "0x2194400", VA = "0x182195E00", Slot = "8")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EIHPLEGHCGN))]
	protected override Task CKKDHFNBKAN(EJKLHKJLFLB GONKAHKFNDA, NHNLOHOBNME<string>.NOELMCIDFEB FLAKFKAEKNJ, CancellationToken OOAGLCBNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract Task ACJEBFNONKN(EJKLHKJLFLB GONKAHKFNDA, NHNLOHOBNME<string>.NOELMCIDFEB FLAKFKAEKNJ, CancellationToken OOAGLCBNIOG);

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(RVA = "0x2195FA0", Offset = "0x21945A0", VA = "0x182195FA0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MOHAGALNNIL))]
	private Task EMBDHCBOJBO(IDisposable ICJOLKPEDMD, NLPNILGFGNL FLMLLIOLCGH, NHNLOHOBNME<string>.NOELMCIDFEB BCLLAMGBKIH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000150")]
public readonly struct NLCCKHNECKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005F9")]
	public readonly NGDMEJFKJLL? PLIDCAFDGGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005FA")]
	public readonly NHPFOPDJGLN PMGEIKPFEGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005FB")]
	public readonly string? JMNKGCIDOMO;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public IReadOnlyCollection<string> OHNBHGGBNEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x2739040", Offset = "0x2737640", VA = "0x182739040")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public IReadOnlyDictionary<long, int> CPOGGANPHKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x2739060", Offset = "0x2737660", VA = "0x182739060")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000611")]
	[Cpp2IlInjected.Address(RVA = "0x2739080", Offset = "0x2737680", VA = "0x182739080")]
	public NLCCKHNECKK(NGDMEJFKJLL? DNCLKGCICOE, NHPFOPDJGLN OLAALOHBKOP, string? FMLPKHHAKIF)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000151")]
internal struct OAGIFAAELGG
{
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	[CompilerGenerated]
	private sealed class ENCMFBPGCBI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		public EJKLHKJLFLB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		public EPFFDDEKBCK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		public NHNLOHOBNME<string>.NOELMCIDFEB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		private MLOCEEOLAMF.FNBAANFJAOH <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		private CDNJKKMBNED <operation>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		private LCNJJEKDLHB <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		private DOMPEFCEFAD.PBGLPHPOFAN <instantiations>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		private TaskAwaiter<IHCOLCCANMI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000607")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public ENCMFBPGCBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x3ECAFA0", Offset = "0x3EC95A0", VA = "0x183ECAFA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000153")]
	[CompilerGenerated]
	private sealed class OJDJMEJIIEO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000608")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		private MLOCEEOLAMF.JGEGOJIGPML <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public OJDJMEJIIEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x3ED9810", Offset = "0x3ED7E10", VA = "0x183ED9810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000612")]
	[Cpp2IlInjected.Address(RVA = "0x273A3C0", Offset = "0x27389C0", VA = "0x18273A3C0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ENCMFBPGCBI))]
	public static Task INHJMLKPHDN(EJKLHKJLFLB GONKAHKFNDA, EPFFDDEKBCK GOMDNNCBLHP, NHNLOHOBNME<string>.NOELMCIDFEB FLAKFKAEKNJ, CancellationToken OOAGLCBNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000613")]
	[Cpp2IlInjected.Address(RVA = "0x273A560", Offset = "0x2738B60", VA = "0x18273A560")]
	private static Task<IHCOLCCANMI> KJILAKEJCND(EJKLHKJLFLB GONKAHKFNDA, NHNLOHOBNME<string>.NOELMCIDFEB FLAKFKAEKNJ, CancellationToken OOAGLCBNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000614")]
	[Cpp2IlInjected.Address(RVA = "0x273A2C0", Offset = "0x27388C0", VA = "0x18273A2C0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OJDJMEJIIEO))]
	private static Task BLJFCOBEHAE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000154")]
internal class AOKPMOGMDBO : CDNJKKMBNED
{
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[CompilerGenerated]
	private sealed class MOHEBPECHAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		public EJKLHKJLFLB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000614")]
		public NHNLOHOBNME<string>.NOELMCIDFEB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000615")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000616")]
		public AOKPMOGMDBO <>4__this;

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
		private DIHBOGADNHJ <uploadLogic>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		private bool <readSuccessfully>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400061C")]
		private NLCCKHNECKK <data>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		private NHNLOHOBNME<string>.NOELMCIDFEB <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		private NHNLOHOBNME<string>.NOELMCIDFEB <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		private FINMCLAFJIC <payload>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		private DateTime <localTime>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		private HKAJAMIEIHO <>s__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		private TaskAwaiter<HKAJAMIEIHO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public MOHEBPECHAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0x2736810", Offset = "0x2734E10", VA = "0x182736810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400060C")]
	private readonly int PPHGCNABBDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400060D")]
	private readonly KFADJCAHNKD IIIIEFFLPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400060E")]
	public readonly long PIFPGIGMIPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400060F")]
	public readonly long EPCJBBCGFII;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public HKAJAMIEIHO GBNFBMIPDEM
	{
		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x941250", Offset = "0x93F850", VA = "0x180941250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0xA34ED0", Offset = "0xA334D0", VA = "0x180A34ED0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600061D")]
	[Cpp2IlInjected.Address(RVA = "0x218D4D0", Offset = "0x218BAD0", VA = "0x18218D4D0")]
	public AOKPMOGMDBO(Guid MGMFLGBPLHJ, LCNJJEKDLHB LCPJEGLKADH, JMODPMGGFBH OIHIMIHAFFJ, int PPHGCNABBDL, KFADJCAHNKD IIIIEFFLPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061E")]
	[Cpp2IlInjected.Address(RVA = "0x218D330", Offset = "0x218B930", VA = "0x18218D330", Slot = "8")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MOHEBPECHAN))]
	protected override Task CKKDHFNBKAN(EJKLHKJLFLB GONKAHKFNDA, NHNLOHOBNME<string>.NOELMCIDFEB FLAKFKAEKNJ, CancellationToken OOAGLCBNIOG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000156")]
internal struct PELNLIJKBFI
{
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[CompilerGenerated]
	private sealed class CHIKEGHKOPO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		public AsyncTaskMethodBuilder<BBBKKMMJPEP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000628")]
		public BBBKKMMJPEP nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000629")]
		public EPFFDDEKBCK deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400062A")]
		public NHNLOHOBNME<string>.NOELMCIDFEB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400062B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400062C")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400062D")]
		public PELNLIJKBFI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400062E")]
		private NHNLOHOBNME<string>.NOELMCIDFEB <moveToPhaseTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400062F")]
		private Guid <handlersGuid>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000630")]
		private BBBKKMMJPEP <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		private TaskAwaiter<BBBKKMMJPEP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public CHIKEGHKOPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0x6124DA0", Offset = "0x61233A0", VA = "0x186124DA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[CompilerGenerated]
	private sealed class DPFAKKJNDBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000633")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		public AsyncTaskMethodBuilder<BBBKKMMJPEP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		public NHNLOHOBNME<string>.NOELMCIDFEB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000636")]
		public BBBKKMMJPEP state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		public PELNLIJKBFI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		private IHCOLCCANMI <message>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		private IHCOLCCANMI <returnMessage>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400063B")]
		private BBBKKMMJPEP <authorityPhase>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		private IHCOLCCANMI <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400063D")]
		private TaskAwaiter<IHCOLCCANMI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public DPFAKKJNDBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x6125FB0", Offset = "0x61245B0", VA = "0x186125FB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000623")]
	private readonly EJKLHKJLFLB GONKAHKFNDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000624")]
	private readonly GEIFDGGEAAC KFEFPLGAPED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000625")]
	private readonly BLDODCCBCMF AMJALHDPDON;

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	private CDNJKKMBNED HBBJBEIDKBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0x2741A70", Offset = "0x2740070", VA = "0x182741A70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(RVA = "0x2741A90", Offset = "0x2740090", VA = "0x182741A90")]
	public PELNLIJKBFI(EJKLHKJLFLB GONKAHKFNDA, GEIFDGGEAAC KFEFPLGAPED, BLDODCCBCMF AMJALHDPDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(RVA = "0x2741820", Offset = "0x273FE20", VA = "0x182741820")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CHIKEGHKOPO))]
	public Task<BBBKKMMJPEP> BCDBHEHJHBG(BBBKKMMJPEP LHLJOAKNIAL, EPFFDDEKBCK EHBDJPBNDDH, NHNLOHOBNME<string>.NOELMCIDFEB FLAKFKAEKNJ, CancellationToken OOAGLCBNIOG, bool OCFGKKELKCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(RVA = "0x2741650", Offset = "0x273FC50", VA = "0x182741650")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DPFAKKJNDBE))]
	private Task<BBBKKMMJPEP> BBPPFDCNFCF(NHNLOHOBNME<string>.NOELMCIDFEB FLAKFKAEKNJ, BBBKKMMJPEP EHDAGCNJKHK, CancellationToken OOAGLCBNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(RVA = "0x2741A40", Offset = "0x2740040", VA = "0x182741A40")]
	private bool FEOHINELNOM(BBBKKMMJPEP EIMMDNBGDFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000627")]
	[Cpp2IlInjected.Address(RVA = "0x2741A20", Offset = "0x2740020", VA = "0x182741A20")]
	private void BKMKBHBEAIO(string IFAPBJJLPAM)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000159")]
internal struct GFPJLKHPPLN
{
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	[CompilerGenerated]
	private sealed class KMJGCBOKDMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400063F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000640")]
		public EJKLHKJLFLB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000641")]
		public EPFFDDEKBCK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		public KOMFNDJENBN timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000643")]
		public NHNLOHOBNME<string>.NOELMCIDFEB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000644")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000645")]
		private CDNJKKMBNED <operation>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		private BBBKKMMJPEP <operationState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000647")]
		private LCNJJEKDLHB <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		private bool <isMaster>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		private OPEIFKONHHI <callbacks>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400064A")]
		private EPMCJAPOJGN <metrics>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400064B")]
		private MLOCEEOLAMF.FNBAANFJAOH <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400064C")]
		private IDisposable <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400064D")]
		private List<(PersistenceView, NFFPAONFDAO)>.Enumerator <>s__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400064E")]
		private PersistenceView <view>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400064F")]
		private NFFPAONFDAO <viewData>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000650")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public KMJGCBOKDMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x36BA390", Offset = "0x36B8990", VA = "0x1836BA390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600062E")]
	[Cpp2IlInjected.Address(RVA = "0x21A1620", Offset = "0x219FC20", VA = "0x1821A1620")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KMJGCBOKDMM))]
	public static Task INHJMLKPHDN(EJKLHKJLFLB GONKAHKFNDA, EPFFDDEKBCK GOMDNNCBLHP, KOMFNDJENBN LEPCLCJIPJF, NHNLOHOBNME<string>.NOELMCIDFEB FLAKFKAEKNJ, CancellationToken OOAGLCBNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062F")]
	[Cpp2IlInjected.Address(RVA = "0x21A17E0", Offset = "0x219FDE0", VA = "0x1821A17E0")]
	private static void NEDJKDJHMOJ(PersistenceView NJJAKKNEINE, NFFPAONFDAO MAEAOOFFCNL, EPFFDDEKBCK GOMDNNCBLHP, BBBKKMMJPEP EHHKMOGNNNP, bool EAFHDNGHHGG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015C")]
internal class JOHHPAJAAMJ : POHLAOINFCI
{
	[Cpp2IlInjected.Token(Token = "0x200015D")]
	[CompilerGenerated]
	private sealed class HKICOLMKGFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000656")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		public AsyncTaskMethodBuilder<NLCCKHNECKK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		public KBDALPDHODH serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400065B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		public JOHHPAJAAMJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		private IEnumerable<PersistenceView> <activePersistenceViews>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		private StringBuilder <outputBuilder>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		private MLOCEEOLAMF.FNBAANFJAOH <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public HKICOLMKGFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x36B7230", Offset = "0x36B5830", VA = "0x1836B7230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015E")]
	[CompilerGenerated]
	private sealed class JGBKICHFPEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000661")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		public KBDALPDHODH serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000663")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000664")]
		public JOHHPAJAAMJ <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public JGBKICHFPEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x36B9220", Offset = "0x36B7820", VA = "0x1836B9220")]
		internal Task FKOKJGGHNOH(PersistenceView v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x36B9460", Offset = "0x36B7A60", VA = "0x1836B9460")]
		internal Task JGOMHEADEEC(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015F")]
	[CompilerGenerated]
	private sealed class MJNPEDBMDEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		public float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		public JGBKICHFPEG CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public MJNPEDBMDEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x36BD230", Offset = "0x36BB830", VA = "0x1836BD230")]
		internal object IFMOMLPDIGM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000160")]
	[CompilerGenerated]
	private sealed class JOJLOAAIBEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000667")]
		public PersistenceView v;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		public JGBKICHFPEG CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public JOJLOAAIBEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x36B9C30", Offset = "0x36B8230", VA = "0x1836B9C30")]
		internal Task PNAABEDDGFF(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private sealed class LAGDEDGFOJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400066E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400066F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000670")]
		public KBDALPDHODH serializeType;

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
		public JOHHPAJAAMJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000675")]
		private JGBKICHFPEG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000676")]
		private MLOCEEOLAMF.FNBAANFJAOH <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000677")]
		private MJNPEDBMDEE <>8__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000678")]
		private IEnumerable<Task> <pendingPreserializes>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000679")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public LAGDEDGFOJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x36BB650", Offset = "0x36B9C50", VA = "0x1836BB650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000653")]
	private readonly LMNLAEPPONM OFHAEKEDPCK;

	[Cpp2IlInjected.Token(Token = "0x4000654")]
	private static readonly TimeSpan HKDLDMHCGOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000655")]
	private readonly PKMMECKHDCL FAGOPMAGEKB;

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(RVA = "0x21AAF40", Offset = "0x21A9540", VA = "0x1821AAF40")]
	public JOHHPAJAAMJ(EJKLHKJLFLB GONKAHKFNDA, PKMMECKHDCL FAGOPMAGEKB, [Optional] LMNLAEPPONM? OFHAEKEDPCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(RVA = "0x21A9D20", Offset = "0x21A8320", VA = "0x1821A9D20")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HKICOLMKGFO))]
	public Task<NLCCKHNECKK> DHDFEGACAHE(long NCHHGHFPFDL, string FMLPKHHAKIF, KBDALPDHODH EGNEHPMLPBH, CancellationToken OOAGLCBNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(RVA = "0x21AA7A0", Offset = "0x21A8DA0", VA = "0x1821AA7A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LAGDEDGFOJI))]
	private Task MBKANKCAJHE(KBDALPDHODH EGNEHPMLPBH, IEnumerable<PersistenceView> GDAIHLDMDKJ, StringBuilder NJDDEGANGJH, CancellationToken OOAGLCBNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000639")]
	[Cpp2IlInjected.Address(RVA = "0x21AA960", Offset = "0x21A8F60", VA = "0x1821AA960")]
	private NLCCKHNECKK PAMNIDGGNKP(long NCHHGHFPFDL, string FMLPKHHAKIF, KBDALPDHODH EGNEHPMLPBH, IEnumerable<PersistenceView> GDAIHLDMDKJ, StringBuilder NJDDEGANGJH)
	{
		return default(NLCCKHNECKK);
	}

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(RVA = "0x21A9EF0", Offset = "0x21A84F0", VA = "0x1821A9EF0")]
	private NGDMEJFKJLL FBKFBLKDIFP(long NCHHGHFPFDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(RVA = "0x21AA590", Offset = "0x21A8B90", VA = "0x1821AA590")]
	private void IGJPBNCHJAD(NGDMEJFKJLL GDHNOLIKMFN, StringBuilder NJDDEGANGJH, IEnumerable<PersistenceView> GDAIHLDMDKJ, in ODFLLKNBMLP BJPEOONPLEM, KLEMKCCNPOG MKEELMOMMCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(RVA = "0x21AA070", Offset = "0x21A8670", VA = "0x1821AA070")]
	private void FNLOCFGONOL(NGDMEJFKJLL GDHNOLIKMFN, StringBuilder NJDDEGANGJH, PersistenceView NJJAKKNEINE, ref KLEMKCCNPOG MKEELMOMMCF, in ODFLLKNBMLP BJPEOONPLEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000163")]
internal class MLOMGBPGOKG : CDNJKKMBNED
{
	[Cpp2IlInjected.Token(Token = "0x2000164")]
	[CompilerGenerated]
	private sealed class MAEJNEELKEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400067D")]
		public EJKLHKJLFLB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400067E")]
		public NHNLOHOBNME<string>.NOELMCIDFEB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400067F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000680")]
		public MLOMGBPGOKG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000681")]
		private long <roomId>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000682")]
		private long <subroomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000683")]
		private string <unityAssetId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000684")]
		private JOHHPAJAAMJ <serializeLogic>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000685")]
		private KBDALPDHODH <serializeType>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000686")]
		private NLCCKHNECKK <data>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000687")]
		private NLCCKHNECKK <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000688")]
		private Exception <ex>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000689")]
		private TaskAwaiter<NLCCKHNECKK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public MAEJNEELKEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0x3ED1AA0", Offset = "0x3ED00A0", VA = "0x183ED1AA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400067A")]
	private readonly ELOHJNEJPLG FLILMALMEBH;

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(RVA = "0x2736770", Offset = "0x2734D70", VA = "0x182736770")]
	public MLOMGBPGOKG(Guid MGMFLGBPLHJ, LCNJJEKDLHB LCPJEGLKADH, JMODPMGGFBH OIHIMIHAFFJ, ELOHJNEJPLG FLILMALMEBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(RVA = "0x2736690", Offset = "0x2734C90", VA = "0x182736690", Slot = "7")]
	protected override string HMCBBAFGGFF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x27364F0", Offset = "0x2734AF0", VA = "0x1827364F0", Slot = "8")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MAEJNEELKEF))]
	protected override Task CKKDHFNBKAN(EJKLHKJLFLB GONKAHKFNDA, NHNLOHOBNME<string>.NOELMCIDFEB FLAKFKAEKNJ, CancellationToken OOAGLCBNIOG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000165")]
internal struct JIIFINDGMPB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400068A")]
	public Dictionary<Guid, List<DLCALGBFBPE>> HKFPJOIDOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400068B")]
	public Dictionary<Guid, List<DLCALGBFBPE>> BDCCDMFHJGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400068C")]
	public Dictionary<Guid, List<DLCALGBFBPE>> POJDOMOEIOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400068D")]
	public List<Guid> GDNFHDDHNBP;

	[Cpp2IlInjected.Token(Token = "0x6000657")]
	[Cpp2IlInjected.Address(RVA = "0x21A9710", Offset = "0x21A7D10", VA = "0x1821A9710")]
	public static JIIFINDGMPB PIDCPOPDLLJ(OPEIFKONHHI OODHPHIHFDJ, BBBKKMMJPEP EHHKMOGNNNP, EPFFDDEKBCK EHBDJPBNDDH)
	{
		return default(JIIFINDGMPB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000167")]
public readonly struct GPKGCDHOKFN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000691")]
	public readonly bool DLKFPKOMCGK;

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(RVA = "0xBEC150", Offset = "0xBEA750", VA = "0x180BEC150")]
	public GPKGCDHOKFN(bool KEGNPPCDBOB)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000168")]
internal struct MDBJFGCCCEI
{
	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[CompilerGenerated]
	private sealed class LCKPGHCGIHD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000692")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000693")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000694")]
		public CDNJKKMBNED operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000695")]
		public EPFFDDEKBCK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000696")]
		public KOMFNDJENBN timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000697")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000698")]
		private BBBKKMMJPEP <state>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000699")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400069A")]
		private MLOCEEOLAMF.FNBAANFJAOH <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400069B")]
		private List<(PersistenceView, NFFPAONFDAO)>.Enumerator <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400069C")]
		private (PersistenceView, NFFPAONFDAO) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400069D")]
		private PersistenceView <view>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400069E")]
		private LEJDGPCAPOD <postDeserializeParams>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400069F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public LCKPGHCGIHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0x3ED04E0", Offset = "0x3ECEAE0", VA = "0x183ED04E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(RVA = "0x2735310", Offset = "0x2733910", VA = "0x182735310")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LCKPGHCGIHD))]
	public static Task INHJMLKPHDN(CDNJKKMBNED IDHOKMNCGAF, EPFFDDEKBCK GOMDNNCBLHP, KOMFNDJENBN LEPCLCJIPJF, CancellationToken OOAGLCBNIOG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200016A")]
internal struct OLGKEMJLJKE
{
	[Cpp2IlInjected.Token(Token = "0x200016B")]
	[CompilerGenerated]
	private sealed class MMAHPGELFMF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006AB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006AC")]
		public AsyncTaskMethodBuilder<EPFFDDEKBCK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006AD")]
		public CKOCLAJPHIF.FNBDNFIGDMM downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006AE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006AF")]
		public OLGKEMJLJKE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		private MLOCEEOLAMF.FNBAANFJAOH <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40006B1")]
		private NHNLOHOBNME<string>.NOELMCIDFEB <downloadTimerScope>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40006B2")]
		private Task<EGKNCMFMAMB<BHCGDDFBDAJ, BFLIDGJOJDI>> <assetBundleTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40006B3")]
		private Task<EGKNCMFMAMB<AIIIIIPEBCO<NGDMEJFKJLL>, BFLIDGJOJDI>> <subRoomTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40006B4")]
		private Task<EGKNCMFMAMB<AIIIIIPEBCO<PPJKDKMANPD>, BFLIDGJOJDI>> <superRoomTask>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40006B5")]
		private Task<EGKNCMFMAMB<AIIIIIPEBCO<GIDMOOPDLFC>, BFLIDGJOJDI>> <playerSaveTask>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40006B6")]
		private Task<(EGKNCMFMAMB<BHCGDDFBDAJ, BFLIDGJOJDI>, EGKNCMFMAMB<AIIIIIPEBCO<NGDMEJFKJLL>, BFLIDGJOJDI>, EGKNCMFMAMB<AIIIIIPEBCO<PPJKDKMANPD>, BFLIDGJOJDI>, EGKNCMFMAMB<AIIIIIPEBCO<GIDMOOPDLFC>, BFLIDGJOJDI>)> <allTasks>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40006B7")]
		private EGKNCMFMAMB<BHCGDDFBDAJ, BFLIDGJOJDI> <assetBundleSource>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40006B8")]
		private EGKNCMFMAMB<AIIIIIPEBCO<NGDMEJFKJLL>, BFLIDGJOJDI> <subRoomDataRes>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40006B9")]
		private EGKNCMFMAMB<AIIIIIPEBCO<PPJKDKMANPD>, BFLIDGJOJDI> <superRoomDataRes>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40006BA")]
		private EGKNCMFMAMB<AIIIIIPEBCO<GIDMOOPDLFC>, BFLIDGJOJDI> <playerSaveDataRes>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40006BB")]
		private AIIIIIPEBCO<NGDMEJFKJLL> <room>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40006BC")]
		private (EGKNCMFMAMB<BHCGDDFBDAJ, BFLIDGJOJDI>, EGKNCMFMAMB<AIIIIIPEBCO<NGDMEJFKJLL>, BFLIDGJOJDI>, EGKNCMFMAMB<AIIIIIPEBCO<PPJKDKMANPD>, BFLIDGJOJDI>, EGKNCMFMAMB<AIIIIIPEBCO<GIDMOOPDLFC>, BFLIDGJOJDI>) <>s__13;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40006BD")]
		private (EGKNCMFMAMB<BHCGDDFBDAJ, BFLIDGJOJDI>, EGKNCMFMAMB<AIIIIIPEBCO<NGDMEJFKJLL>, BFLIDGJOJDI>, EGKNCMFMAMB<AIIIIIPEBCO<PPJKDKMANPD>, BFLIDGJOJDI>, EGKNCMFMAMB<AIIIIIPEBCO<GIDMOOPDLFC>, BFLIDGJOJDI>) <>s__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x40006BE")]
		private TaskAwaiter<(EGKNCMFMAMB<BHCGDDFBDAJ, BFLIDGJOJDI>, EGKNCMFMAMB<AIIIIIPEBCO<NGDMEJFKJLL>, BFLIDGJOJDI>, EGKNCMFMAMB<AIIIIIPEBCO<PPJKDKMANPD>, BFLIDGJOJDI>, EGKNCMFMAMB<AIIIIIPEBCO<GIDMOOPDLFC>, BFLIDGJOJDI>)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public MMAHPGELFMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0x3ED4000", Offset = "0x3ED2600", VA = "0x183ED4000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016C")]
	[CompilerGenerated]
	private sealed class PBBJKKKADHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006BF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006C0")]
		public AsyncTaskMethodBuilder<EGKNCMFMAMB<BHCGDDFBDAJ, BFLIDGJOJDI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006C1")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006C2")]
		public long roomInstanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006C3")]
		public CKOCLAJPHIF.FNBDNFIGDMM downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006C4")]
		public NHNLOHOBNME<string>.NOELMCIDFEB downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006C5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006C6")]
		public OLGKEMJLJKE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40006C7")]
		private MLOCEEOLAMF.FNBAANFJAOH <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40006C8")]
		private NHNLOHOBNME<string>.NOELMCIDFEB <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40006C9")]
		private EGKNCMFMAMB<BHCGDDFBDAJ, BFLIDGJOJDI> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40006CA")]
		private TaskAwaiter<EGKNCMFMAMB<BHCGDDFBDAJ, BFLIDGJOJDI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public PBBJKKKADHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x3EDA120", Offset = "0x3ED8720", VA = "0x183EDA120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006A0")]
	private KPBMNABNLAG<MFELEADOGIE, PPJKDKMANPD> DIDKCGDNMAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40006A1")]
	private KPBMNABNLAG<MFELEADOGIE, NGDMEJFKJLL> GIHHJBJFEKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006A2")]
	private KPBMNABNLAG<long, GIDMOOPDLFC> INJMJPHMIPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006A3")]
	private JOACNNBBDGA BDCJLJFEJHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006A4")]
	private LMPJDKBMOBF MIDAGNGFEKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006A5")]
	private GBCKOOBFABI EOLPBMGICLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40006A6")]
	private string FMLPKHHAKIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006A7")]
	private MFELEADOGIE PEGIFAKLECB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40006A8")]
	private MFELEADOGIE JAFBNEJOKKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40006A9")]
	private long JJCIAKAHHPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40006AA")]
	private NHNLOHOBNME<string>.NOELMCIDFEB BCLLAMGBKIH;

	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(RVA = "0x273C9A0", Offset = "0x273AFA0", VA = "0x18273C9A0")]
	public static Task<EPFFDDEKBCK> LIHPLAIKEFA(LCNJJEKDLHB LCPJEGLKADH, in BFIGLLFHPEJ GOMDNNCBLHP, CKOCLAJPHIF.FNBDNFIGDMM BNKAKELBBBG, NHNLOHOBNME<string>.NOELMCIDFEB BCLLAMGBKIH, CancellationToken OOAGLCBNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(RVA = "0x273C7D0", Offset = "0x273ADD0", VA = "0x18273C7D0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MMAHPGELFMF))]
	private Task<EPFFDDEKBCK> INHJMLKPHDN(CKOCLAJPHIF.FNBDNFIGDMM BNKAKELBBBG, CancellationToken OOAGLCBNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0x273C5A0", Offset = "0x273ABA0", VA = "0x18273C5A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PBBJKKKADHL))]
	private Task<EGKNCMFMAMB<BHCGDDFBDAJ, BFLIDGJOJDI>> FKIBFGMBENC(string FMLPKHHAKIF, long JJCIAKAHHPE, CKOCLAJPHIF.FNBDNFIGDMM BNKAKELBBBG, NHNLOHOBNME<string>.NOELMCIDFEB DDLNLFBBDMJ, CancellationToken OOAGLCBNIOG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200016D")]
public class GEIFDGGEAAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006CB")]
	private readonly LCECFIIKLCN JIJLPLHOMHH;

	[Cpp2IlInjected.Token(Token = "0x40006CC")]
	private const string AICIENKMEOA = "RL_LastSetOperationState";

	[Cpp2IlInjected.Token(Token = "0x40006CD")]
	private const string KBMLDMFFDDH = "RL_LastLoadedRoomName";

	[Cpp2IlInjected.Token(Token = "0x40006CE")]
	private const string JFAACAJMNPF = "RL_LastLoadedRoomId";

	[Cpp2IlInjected.Token(Token = "0x40006CF")]
	private const string MAEEPFONLGG = "RL_LastLoadedSubroomId";

	[Cpp2IlInjected.Token(Token = "0x40006D0")]
	private const string ECGFLPEEKLK = "RL_LastLoadedRoomInstanceId";

	[Cpp2IlInjected.Token(Token = "0x40006D1")]
	private const string EMKAINFEAJA = "RL_LastHeartbeatSessionData";

	[Cpp2IlInjected.Token(Token = "0x40006D2")]
	private const string IEDOOIFADHN = "RL_LastRoomLoadStartTime";

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006D3")]
	private string LGINMFMMGDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006D4")]
	private long? BGNAENFPLMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40006D5")]
	private long? NJKIICLFODF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40006D6")]
	private long? BKDIIHLFAIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40006D7")]
	private string DJCMGPNDDLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40006D8")]
	private BBBKKMMJPEP BNDIAHHJMPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40006D9")]
	private long? HEELNJDCHHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40006DA")]
	private bool FPNNLLFMKGF;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public string OJJPHJJDIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public long LBKIOELJKLP
	{
		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0x21A1550", Offset = "0x219FB50", VA = "0x1821A1550")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public long JKLALPCAPBN
	{
		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x21A0810", Offset = "0x219EE10", VA = "0x1821A0810")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public long CCEONMPJFDL
	{
		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0x21A0BE0", Offset = "0x219F1E0", VA = "0x1821A0BE0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public string JANPPHPBJFK
	{
		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0x21A0870", Offset = "0x219EE70", VA = "0x1821A0870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public BBBKKMMJPEP HLNHANKMDNI
	{
		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0xBF04E0", Offset = "0xBEEAE0", VA = "0x180BF04E0")]
		get
		{
			return default(BBBKKMMJPEP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0x21A1470", Offset = "0x219FA70", VA = "0x1821A1470")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public long HKPFDPHCKBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0x21A0C40", Offset = "0x219F240", VA = "0x1821A0C40")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(RVA = "0x21A15B0", Offset = "0x219FBB0", VA = "0x1821A15B0")]
	[UnityEngine.Scripting.Preserve]
	public GEIFDGGEAAC([NALHKAIJJND(null)] LCECFIIKLCN JIJLPLHOMHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(RVA = "0x21A0950", Offset = "0x219EF50", VA = "0x1821A0950")]
	private void FHOEKBHBKOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000674")]
	[Cpp2IlInjected.Address(RVA = "0x21A0CA0", Offset = "0x219F2A0", VA = "0x1821A0CA0")]
	public void LGIOENAJEGP(long EDDMGMBKEBK, long NCHHGHFPFDL, [Optional] long? JJCIAKAHHPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000675")]
	[Cpp2IlInjected.Address(RVA = "0x21A08B0", Offset = "0x219EEB0", VA = "0x1821A08B0")]
	public void EBNPIJNCGNG(long JJCIAKAHHPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000676")]
	[Cpp2IlInjected.Address(RVA = "0x21A0B60", Offset = "0x219F160", VA = "0x1821A0B60")]
	public void IDBGJNBKJHL(string AHPMMONGEKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000677")]
	[Cpp2IlInjected.Address(RVA = "0x21A10F0", Offset = "0x219F6F0", VA = "0x1821A10F0")]
	public void NAJOHCPKDFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016E")]
internal sealed class BPFCDFJGKOE : CDNJKKMBNED
{
	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[CompilerGenerated]
	private sealed class KDCHLIFMFPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006DE")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public KDCHLIFMFPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0x2732360", Offset = "0x2730960", VA = "0x182732360")]
		internal object BLEGJCHBHJP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000170")]
	[CompilerGenerated]
	private sealed class CPEBFEGHNAG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006DF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006E0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006E1")]
		public EJKLHKJLFLB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006E2")]
		public NHNLOHOBNME<string>.NOELMCIDFEB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006E3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006E4")]
		public BPFCDFJGKOE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006E5")]
		private FEFAAKGBGKB <presence>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006E6")]
		private PNCAOKGAGKF <loadLogic>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006E7")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006E8")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public CPEBFEGHNAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x272C110", Offset = "0x272A710", VA = "0x18272C110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000171")]
	[CompilerGenerated]
	private sealed class GHAGHLOOPJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006E9")]
		public FEFAAKGBGKB presence;

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public GHAGHLOOPJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0x2730300", Offset = "0x272E900", VA = "0x182730300")]
		internal object EDIDIPGCPGF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40006DB")]
	private readonly FICOENLLCNC BCKHCBODBMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40006DC")]
	private readonly LHJOLIPPMAL ECOIBMDGMFB;

	[Cpp2IlInjected.Token(Token = "0x40006DD")]
	private const bool KFELACFPICM = false;

	[Cpp2IlInjected.Token(Token = "0x6000678")]
	[Cpp2IlInjected.Address(RVA = "0x218FE20", Offset = "0x218E420", VA = "0x18218FE20")]
	public BPFCDFJGKOE(FICOENLLCNC BCKHCBODBMN, LHJOLIPPMAL ECOIBMDGMFB, Guid MGMFLGBPLHJ, LCNJJEKDLHB LCPJEGLKADH, JMODPMGGFBH OIHIMIHAFFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000679")]
	[Cpp2IlInjected.Address(RVA = "0x218FA30", Offset = "0x218E030", VA = "0x18218FA30", Slot = "8")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CPEBFEGHNAG))]
	protected override Task CKKDHFNBKAN(EJKLHKJLFLB GONKAHKFNDA, NHNLOHOBNME<string>.NOELMCIDFEB FLAKFKAEKNJ, CancellationToken OOAGLCBNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600067A")]
	[Cpp2IlInjected.Address(RVA = "0x218FBD0", Offset = "0x218E1D0", VA = "0x18218FBD0")]
	private FEFAAKGBGKB OLEGPCKMMFF()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000172")]
internal struct PABPMLOCBCH
{
	[Cpp2IlInjected.Token(Token = "0x2000173")]
	[CompilerGenerated]
	private sealed class MAKBMPILENL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006EA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006EB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006EC")]
		public LCNJJEKDLHB roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006ED")]
		public EPFFDDEKBCK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006EE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006EF")]
		private bool <isMaster>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006F0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public MAKBMPILENL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0x3ED21D0", Offset = "0x3ED07D0", VA = "0x183ED21D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000682")]
	[Cpp2IlInjected.Address(RVA = "0x2740E80", Offset = "0x273F480", VA = "0x182740E80")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MAKBMPILENL))]
	public static Task INHJMLKPHDN(LCNJJEKDLHB LCPJEGLKADH, EPFFDDEKBCK GOMDNNCBLHP, CancellationToken OOAGLCBNIOG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000174")]
internal struct FMNCIMFFGLD
{
	[Cpp2IlInjected.Token(Token = "0x2000175")]
	[CompilerGenerated]
	private sealed class JKNDIOEFMOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006F6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006F7")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006F8")]
		public FMNCIMFFGLD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006F9")]
		private JGAKGFIFMKG <sceneLocation>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006FA")]
		private NHNLOHOBNME<string>.NOELMCIDFEB <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006FB")]
		private string <sceneName>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40006FC")]
		private Scene <mainScene>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x40006FD")]
		private Scene <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006FE")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public JKNDIOEFMOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0x36B97B0", Offset = "0x36B7DB0", VA = "0x1836B97B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000176")]
	[CompilerGenerated]
	private sealed class PGDBCJODING
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006FF")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public PGDBCJODING()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0x36BEF40", Offset = "0x36BD540", VA = "0x1836BEF40")]
		internal object ECPFGKPKKLI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000177")]
	[CompilerGenerated]
	private sealed class EBAKODODOEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000700")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000701")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000702")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000703")]
		public FMNCIMFFGLD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000704")]
		private PGDBCJODING <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000705")]
		private MLOCEEOLAMF.FNBAANFJAOH <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000706")]
		private FMCJEDGGDPG <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000707")]
		private Scene <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000708")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public EBAKODODOEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0x36B1160", Offset = "0x36AF760", VA = "0x1836B1160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006F1")]
	private JGAKGFIFMKG OELOHACAGJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40006F2")]
	private NHNLOHOBNME<string>.NOELMCIDFEB BCLLAMGBKIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006F3")]
	private LCNJJEKDLHB LCPJEGLKADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006F4")]
	private bool PMABBABNICO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006F5")]
	private EPFFDDEKBCK GOMDNNCBLHP;

	[Cpp2IlInjected.Token(Token = "0x6000686")]
	[Cpp2IlInjected.Address(RVA = "0x219F950", Offset = "0x219DF50", VA = "0x18219F950")]
	public static Task<Scene> GBGJKJBEAKJ(LCNJJEKDLHB LCPJEGLKADH, JGAKGFIFMKG MPMAOBOCIBE, NHNLOHOBNME<string>.NOELMCIDFEB BCLLAMGBKIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000687")]
	[Cpp2IlInjected.Address(RVA = "0x219F700", Offset = "0x219DD00", VA = "0x18219F700")]
	public static Task<Scene> AFBGCDNGION(LCNJJEKDLHB LCPJEGLKADH, EPFFDDEKBCK GOMDNNCBLHP, NHNLOHOBNME<string>.NOELMCIDFEB BCLLAMGBKIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000688")]
	[Cpp2IlInjected.Address(RVA = "0x219F9D0", Offset = "0x219DFD0", VA = "0x18219F9D0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JKNDIOEFMOJ))]
	private Task<Scene> INHJMLKPHDN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000689")]
	[Cpp2IlInjected.Address(RVA = "0x219F920", Offset = "0x219DF20", VA = "0x18219F920")]
	private bool GBFMHECBCAE(EPFFDDEKBCK GOMDNNCBLHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600068A")]
	[Cpp2IlInjected.Address(RVA = "0x219FB30", Offset = "0x219E130", VA = "0x18219FB30")]
	private void ODFCHANMBKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068B")]
	[Cpp2IlInjected.Address(RVA = "0x219F7A0", Offset = "0x219DDA0", VA = "0x18219F7A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EBAKODODOEA))]
	private Task<Scene> CNDDECNJPCL(string HBJAIAIJNHL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000178")]
public abstract class MBBBNFPNCIM<T> where T : MBBBNFPNCIM<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000709")]
	internal readonly LCNJJEKDLHB ELAKOEGJGME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400070A")]
	private int? MFOBAPPKEHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400070B")]
	protected readonly Guid EFHOBDBDECD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400070C")]
	protected readonly AEHILIDANGI APFBDHODAJP;

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	protected T OFPPCLFGNHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0x25CE410", Offset = "0x25CCA10", VA = "0x1825CE410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000695")]
	[Cpp2IlInjected.Address(RVA = "0x25CE6E0", Offset = "0x25CCCE0", VA = "0x1825CE6E0")]
	internal MBBBNFPNCIM(LCNJJEKDLHB DFCHOKLNHGB, AEHILIDANGI OHEOBBDEKJD, [Optional] Guid? MGMFLGBPLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000696")]
	[Cpp2IlInjected.Address(RVA = "0x25CE4F0", Offset = "0x25CCAF0", VA = "0x1825CE4F0")]
	private IHCOLCCANMI HIIKAFGMGAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000697")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "4")]
	protected virtual void ADPCIAKJHAE(IHCOLCCANMI JIEHBANCLJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000698")]
	[Cpp2IlInjected.Address(RVA = "0x25CE380", Offset = "0x25CC980", VA = "0x1825CE380")]
	public T APPOADIEFEM(IFFNBNNJJLC HIPPLAKEHCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000699")]
	[Cpp2IlInjected.Address(RVA = "0x25CE470", Offset = "0x25CCA70", VA = "0x1825CE470")]
	public T EJFMJDCPDMK(int DPEHKAJECIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600069A")]
	[Cpp2IlInjected.Address(RVA = "0x25CE5E0", Offset = "0x25CCBE0", VA = "0x1825CE5E0", Slot = "5")]
	public virtual Task<LOJBOFKMJHM> MFDLFGMGOPG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000179")]
public class KBDFJCPGKLB : MBBBNFPNCIM<KBDFJCPGKLB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400070D")]
	private FICOENLLCNC OGLJJNFALNA;

	[Cpp2IlInjected.Token(Token = "0x600069B")]
	[Cpp2IlInjected.Address(RVA = "0x21AB110", Offset = "0x21A9710", VA = "0x1821AB110")]
	internal KBDFJCPGKLB(LCNJJEKDLHB DFCHOKLNHGB, AEHILIDANGI OHEOBBDEKJD, [Optional] Guid? MGMFLGBPLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069C")]
	[Cpp2IlInjected.Address(RVA = "0x21AB0F0", Offset = "0x21A96F0", VA = "0x1821AB0F0")]
	public KBDFJCPGKLB BHDNEJIONBF(FICOENLLCNC OGLJJNFALNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600069D")]
	[Cpp2IlInjected.Address(RVA = "0x21AB020", Offset = "0x21A9620", VA = "0x1821AB020", Slot = "4")]
	protected override void ADPCIAKJHAE(IHCOLCCANMI JIEHBANCLJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017A")]
public class OIDLEEHHLBJ : MBBBNFPNCIM<OIDLEEHHLBJ>
{
	[Cpp2IlInjected.Token(Token = "0x200017B")]
	internal enum IGPLCCJIMHG
	{
		[Cpp2IlInjected.Token(Token = "0x4000712")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000713")]
		Disk,
		[Cpp2IlInjected.Token(Token = "0x4000714")]
		RecNet
	}

	[Cpp2IlInjected.Token(Token = "0x200017C")]
	[CompilerGenerated]
	private sealed class LCLACMNBHJB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000715")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000716")]
		public AsyncTaskMethodBuilder<LOJBOFKMJHM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000717")]
		public OIDLEEHHLBJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000718")]
		private LOJBOFKMJHM <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000719")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400071A")]
		private TaskAwaiter<LOJBOFKMJHM> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public LCLACMNBHJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0x3ED0AD0", Offset = "0x3ECF0D0", VA = "0x183ED0AD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400070E")]
	private IGPLCCJIMHG HOBEOGFMILC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400070F")]
	private string MOCNNONJHLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000710")]
	private FINMCLAFJIC OGLJJNFALNA;

	[Cpp2IlInjected.Token(Token = "0x600069E")]
	[Cpp2IlInjected.Address(RVA = "0x273B0E0", Offset = "0x27396E0", VA = "0x18273B0E0")]
	internal OIDLEEHHLBJ(LCNJJEKDLHB DFCHOKLNHGB, AEHILIDANGI OHEOBBDEKJD, [Optional] Guid? MGMFLGBPLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069F")]
	[Cpp2IlInjected.Address(RVA = "0x273AE90", Offset = "0x2739490", VA = "0x18273AE90")]
	public OIDLEEHHLBJ FJBDHICLNLB(string DEBBCDLKFEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A0")]
	[Cpp2IlInjected.Address(RVA = "0x273B0B0", Offset = "0x27396B0", VA = "0x18273B0B0")]
	public OIDLEEHHLBJ PNJFBLCILJD(bool JMFHKNEBNBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A1")]
	[Cpp2IlInjected.Address(RVA = "0x273B080", Offset = "0x2739680", VA = "0x18273B080")]
	public OIDLEEHHLBJ PBALKPOCMJF(string PCCHHIAICLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A2")]
	[Cpp2IlInjected.Address(RVA = "0x273AEC0", Offset = "0x27394C0", VA = "0x18273AEC0")]
	public OIDLEEHHLBJ KKCLIMCFCAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A3")]
	[Cpp2IlInjected.Address(RVA = "0x273AD20", Offset = "0x2739320", VA = "0x18273AD20", Slot = "4")]
	protected override void ADPCIAKJHAE(IHCOLCCANMI JIEHBANCLJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A4")]
	[Cpp2IlInjected.Address(RVA = "0x273AEF0", Offset = "0x27394F0", VA = "0x18273AEF0", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LCLACMNBHJB))]
	public override Task<LOJBOFKMJHM> MFDLFGMGOPG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A5")]
	[Cpp2IlInjected.Address(RVA = "0x273B040", Offset = "0x2739640", VA = "0x18273B040")]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task<LOJBOFKMJHM> NJFEJMLFLNJ()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200017D")]
internal struct JGOOBMDEGPJ
{
	[Cpp2IlInjected.Token(Token = "0x200017E")]
	[CompilerGenerated]
	private sealed class HNJHEHMHHJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400071B")]
		public DOMPEFCEFAD.PBGLPHPOFAN instantiations;

		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public HNJHEHMHHJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(RVA = "0x36B7790", Offset = "0x36B5D90", VA = "0x1836B7790")]
		internal object JBNKCBLFIIL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017F")]
	[CompilerGenerated]
	private sealed class FCPNGGJDDDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400071C")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400071D")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public FCPNGGJDDDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(RVA = "0x36B5230", Offset = "0x36B3830", VA = "0x1836B5230")]
		internal object PMFMOKHJDND()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006A9")]
	[Cpp2IlInjected.Address(RVA = "0x21A9040", Offset = "0x21A7640", VA = "0x1821A9040")]
	public static void INHJMLKPHDN(CDNJKKMBNED IDHOKMNCGAF, EPFFDDEKBCK GOMDNNCBLHP, DOMPEFCEFAD.PBGLPHPOFAN CHCBGKHIKCD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000180")]
internal struct DOMPEFCEFAD
{
	[Cpp2IlInjected.Token(Token = "0x2000181")]
	public struct PBGLPHPOFAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000720")]
		public List<LAKBDNKOKOG> PJCAONGFBBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000721")]
		public List<NFFPAONFDAO> BLJLEHFMOEM;

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0xBBF9D0", Offset = "0xBBDFD0", VA = "0x180BBF9D0")]
		public PBGLPHPOFAN(List<LAKBDNKOKOG> PJCAONGFBBI, List<NFFPAONFDAO> BLJLEHFMOEM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000182")]
	[CompilerGenerated]
	private sealed class IHKEFKNOHCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000722")]
		public IEnumerable<LAKBDNKOKOG> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public IHKEFKNOHCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0x36B85B0", Offset = "0x36B6BB0", VA = "0x1836B85B0")]
		internal object OFPPNDJJJNJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400071E")]
	private LCNJJEKDLHB LCPJEGLKADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400071F")]
	private EPFFDDEKBCK GOMDNNCBLHP;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	private OPEIFKONHHI JLLINPPOIKE
	{
		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(RVA = "0x2196CF0", Offset = "0x21952F0", VA = "0x182196CF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006AE")]
	[Cpp2IlInjected.Address(RVA = "0x2196C80", Offset = "0x2195280", VA = "0x182196C80")]
	public static PBGLPHPOFAN INHJMLKPHDN(LCNJJEKDLHB LCPJEGLKADH, EPFFDDEKBCK GOMDNNCBLHP)
	{
		return default(PBGLPHPOFAN);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B0")]
	[Cpp2IlInjected.Address(RVA = "0x2196950", Offset = "0x2194F50", VA = "0x182196950")]
	private PBGLPHPOFAN INHJMLKPHDN()
	{
		return default(PBGLPHPOFAN);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B1")]
	[Cpp2IlInjected.Address(RVA = "0x2196190", Offset = "0x2194790", VA = "0x182196190")]
	private PBGLPHPOFAN FNFCCPNHMPJ(NGDMEJFKJLL CJLLNAEEKIK, PJLOEOJDLAF LFJINLKFDEO)
	{
		return default(PBGLPHPOFAN);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B2")]
	[Cpp2IlInjected.Address(RVA = "0x2196700", Offset = "0x2194D00", VA = "0x182196700")]
	private bool GFHDMIBCMKM(IEnumerable<LAKBDNKOKOG> PJCAONGFBBI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000183")]
internal struct KDKMGNPDNHK
{
	[Cpp2IlInjected.Token(Token = "0x2000184")]
	[CompilerGenerated]
	private sealed class CDJOIAGKNAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000727")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000728")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000729")]
		public KDKMGNPDNHK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400072A")]
		private bool <stopOnEmptyScene>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400072B")]
		private string <preloadSceneName>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400072C")]
		private NHNLOHOBNME<string>.NOELMCIDFEB <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400072D")]
		private NHNLOHOBNME<string>.NOELMCIDFEB <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400072E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400072F")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public CDJOIAGKNAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0x36AE570", Offset = "0x36ACB70", VA = "0x1836AE570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000185")]
	[CompilerGenerated]
	private sealed class FLNFHPOBGMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000730")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000731")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public FLNFHPOBGMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0x36B5A80", Offset = "0x36B4080", VA = "0x1836B5A80")]
		internal object ECPFGKPKKLI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000186")]
	[CompilerGenerated]
	private sealed class EBOHDHOBBKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000732")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000733")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000734")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000735")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000736")]
		public KDKMGNPDNHK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000737")]
		private FLNFHPOBGMG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000738")]
		private MLOCEEOLAMF.FNBAANFJAOH <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000739")]
		private FMCJEDGGDPG <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400073A")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public EBOHDHOBBKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0x36B16E0", Offset = "0x36AFCE0", VA = "0x1836B16E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000723")]
	private bool BHPOAGMAMNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000724")]
	private NHNLOHOBNME<string>.NOELMCIDFEB BCLLAMGBKIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000725")]
	private LCNJJEKDLHB LCPJEGLKADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000726")]
	private CancellationToken OOAGLCBNIOG;

	[Cpp2IlInjected.Token(Token = "0x60006B6")]
	[Cpp2IlInjected.Address(RVA = "0x21AB230", Offset = "0x21A9830", VA = "0x1821AB230")]
	public static Task CLHIKNIGBNA(LCNJJEKDLHB LCPJEGLKADH, bool BHPOAGMAMNA, NHNLOHOBNME<string>.NOELMCIDFEB BCLLAMGBKIH, CancellationToken JGNPEACNFEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B7")]
	[Cpp2IlInjected.Address(RVA = "0x21AB410", Offset = "0x21A9A10", VA = "0x1821AB410")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CDJOIAGKNAN))]
	private Task INHJMLKPHDN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B8")]
	[Cpp2IlInjected.Address(RVA = "0x21AB2A0", Offset = "0x21A98A0", VA = "0x1821AB2A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EBOHDHOBBKA))]
	private Task CNDDECNJPCL(bool PDMFAMLNECL, string HBJAIAIJNHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B9")]
	[Cpp2IlInjected.Address(RVA = "0x921810", Offset = "0x91FE10", VA = "0x180921810")]
	private bool AMJGIPDBHJP(bool BHPOAGMAMNA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000187")]
internal struct BFIGLLFHPEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400073B")]
	public readonly LMPJDKBMOBF MIDAGNGFEKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400073C")]
	public readonly GBCKOOBFABI EOLPBMGICLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400073D")]
	public readonly string FMLPKHHAKIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400073E")]
	public readonly MFELEADOGIE PEGIFAKLECB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400073F")]
	public readonly MFELEADOGIE JAFBNEJOKKL;

	[Cpp2IlInjected.Token(Token = "0x60006C2")]
	[Cpp2IlInjected.Address(RVA = "0x218D600", Offset = "0x218BC00", VA = "0x18218D600")]
	public BFIGLLFHPEJ(LMPJDKBMOBF MIDAGNGFEKI, GBCKOOBFABI EOLPBMGICLJ, string FMLPKHHAKIF, MFELEADOGIE PEGIFAKLECB, MFELEADOGIE JAFBNEJOKKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000188")]
internal sealed class AGNAFAIINCF : DOJJHPANDDM
{
	[Cpp2IlInjected.Token(Token = "0x2000189")]
	[CompilerGenerated]
	private sealed class HDPJAMPMJKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000741")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000742")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000743")]
		public EJKLHKJLFLB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000744")]
		public NHNLOHOBNME<string>.NOELMCIDFEB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000745")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000746")]
		public AGNAFAIINCF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000747")]
		private MEALHALACCD <roomEvent>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000748")]
		private PNCAOKGAGKF <loadLogic>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000749")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public HDPJAMPMJKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C6")]
		[Cpp2IlInjected.Address(RVA = "0x27306F0", Offset = "0x272ECF0", VA = "0x1827306F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000740")]
	private readonly FICOENLLCNC IHGJIOGALEB;

	[Cpp2IlInjected.Token(Token = "0x60006C3")]
	[Cpp2IlInjected.Address(RVA = "0x218D280", Offset = "0x218B880", VA = "0x18218D280")]
	public AGNAFAIINCF(Guid MGMFLGBPLHJ, LCNJJEKDLHB LCPJEGLKADH, FICOENLLCNC IHGJIOGALEB, JMODPMGGFBH OIHIMIHAFFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C4")]
	[Cpp2IlInjected.Address(RVA = "0x218D0E0", Offset = "0x218B6E0", VA = "0x18218D0E0", Slot = "9")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HDPJAMPMJKE))]
	protected override Task ACJEBFNONKN(EJKLHKJLFLB GONKAHKFNDA, NHNLOHOBNME<string>.NOELMCIDFEB FLAKFKAEKNJ, CancellationToken OOAGLCBNIOG)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200018A")]
internal struct EDIADJDMAPD
{
	[Cpp2IlInjected.Token(Token = "0x60006C8")]
	[Cpp2IlInjected.Address(RVA = "0x2197970", Offset = "0x2195F70", VA = "0x182197970")]
	public static Task INHJMLKPHDN(CancellationToken OOAGLCBNIOG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018B")]
internal struct GDMHGJJMJHE
{
	[Cpp2IlInjected.Token(Token = "0x200018C")]
	[CompilerGenerated]
	private sealed class PAFHLCPIBCP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400074E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400074F")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000750")]
		public LCNJJEKDLHB roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000751")]
		public EPFFDDEKBCK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000752")]
		public EJKLHKJLFLB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000753")]
		public NHNLOHOBNME<string>.NOELMCIDFEB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000754")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000755")]
		private bool <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000756")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public PAFHLCPIBCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0x36BECB0", Offset = "0x36BD2B0", VA = "0x1836BECB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018D")]
	[CompilerGenerated]
	private sealed class IGOCOOHABGB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000757")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000758")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000759")]
		public NHNLOHOBNME<string>.NOELMCIDFEB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400075A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400075B")]
		public GDMHGJJMJHE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400075C")]
		private MLOCEEOLAMF.FNBAANFJAOH <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400075D")]
		private bool <shouldObjectModelBeEnabled>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x81")]
		[Cpp2IlInjected.Token(Token = "0x400075E")]
		private bool <isOMFlagChanging>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x82")]
		[Cpp2IlInjected.Token(Token = "0x400075F")]
		private bool <reloadSceneForObjectModel>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000760")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public IGOCOOHABGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0x36B7FA0", Offset = "0x36B65A0", VA = "0x1836B7FA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400074A")]
	private LCNJJEKDLHB LCPJEGLKADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400074B")]
	private EPFFDDEKBCK GOMDNNCBLHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400074C")]
	private ByteString PPOIHABECKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400074D")]
	private EJKLHKJLFLB GONKAHKFNDA;

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	private OPEIFKONHHI JLLINPPOIKE
	{
		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0x21A0000", Offset = "0x219E600", VA = "0x1821A0000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	private bool MMHHOIHHODP
	{
		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0x21A0050", Offset = "0x219E650", VA = "0x1821A0050")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	private bool LCKFDKHAHDB
	{
		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0x219FBA0", Offset = "0x219E1A0", VA = "0x18219FBA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	private bool CMDIGIADCIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0x219FC30", Offset = "0x219E230", VA = "0x18219FC30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006C9")]
	[Cpp2IlInjected.Address(RVA = "0x219FE10", Offset = "0x219E410", VA = "0x18219FE10")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PAFHLCPIBCP))]
	public static Task<bool> INHJMLKPHDN(LCNJJEKDLHB LCPJEGLKADH, EPFFDDEKBCK GOMDNNCBLHP, EJKLHKJLFLB GONKAHKFNDA, NHNLOHOBNME<string>.NOELMCIDFEB FLAKFKAEKNJ, CancellationToken OOAGLCBNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006CE")]
	[Cpp2IlInjected.Address(RVA = "0x219FC70", Offset = "0x219E270", VA = "0x18219FC70")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IGOCOOHABGB))]
	private Task<bool> INHJMLKPHDN(NHNLOHOBNME<string>.NOELMCIDFEB FLAKFKAEKNJ, CancellationToken OOAGLCBNIOG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018E")]
public static class OBNGNGPJHDH
{
	[Cpp2IlInjected.Token(Token = "0x60006D5")]
	[Cpp2IlInjected.Address(RVA = "0x273A690", Offset = "0x2738C90", VA = "0x18273A690")]
	public static MFELEADOGIE MFNBHICJNMC(this DNHFONHECAI KICDHJODCEP)
	{
		return default(MFELEADOGIE);
	}

	[Cpp2IlInjected.Token(Token = "0x60006D6")]
	[Cpp2IlInjected.Address(RVA = "0x273A5D0", Offset = "0x2738BD0", VA = "0x18273A5D0")]
	public static DNHFONHECAI GLMLIDNLLLP(this MFELEADOGIE APLCBEFBPPC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018F")]
internal class DIHBOGADNHJ : POHLAOINFCI
{
	[Cpp2IlInjected.Token(Token = "0x2000190")]
	[CompilerGenerated]
	private sealed class FOKENACBAHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000763")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000764")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000765")]
		public BCMCCDAIONP.JGFOAOPLFGA roomDataUpload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000766")]
		public byte[] data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000767")]
		public BCMCCDAIONP.JGFOAOPLFGA subRoomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public FOKENACBAHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x36B5F00", Offset = "0x36B4500", VA = "0x1836B5F00")]
		internal object PKCLMADCONL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x36B5E40", Offset = "0x36B4440", VA = "0x1836B5E40")]
		internal object BMLPDONKGFK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x36B5E90", Offset = "0x36B4490", VA = "0x1836B5E90")]
		internal object PCCPICABELC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x36B5C00", Offset = "0x36B4200", VA = "0x1836B5C00")]
		internal object BCCBKBKGMJB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000191")]
	[CompilerGenerated]
	private sealed class ANNBEMJPEPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000768")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000769")]
		public AsyncTaskMethodBuilder<(BCMCCDAIONP.JGFOAOPLFGA roomDataUpload, BCMCCDAIONP.JGFOAOPLFGA subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400076A")]
		public NLCCKHNECKK roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400076B")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400076C")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400076D")]
		public DIHBOGADNHJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400076E")]
		private FOKENACBAHN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400076F")]
		private float <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000770")]
		private PPJKDKMANPD <roomMetadata>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000771")]
		private BCMCCDAIONP.JGFOAOPLFGA <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000772")]
		private BCMCCDAIONP.JGFOAOPLFGA <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000773")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000774")]
		private TaskAwaiter<BCMCCDAIONP.JGFOAOPLFGA> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public ANNBEMJPEPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x36AD130", Offset = "0x36AB730", VA = "0x1836AD130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000192")]
	[CompilerGenerated]
	private sealed class LOCPJEIPOMK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000775")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000776")]
		public AsyncTaskMethodBuilder<HKAJAMIEIHO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000777")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000778")]
		public FINMCLAFJIC roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000779")]
		public NLCCKHNECKK roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400077A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400077B")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400077C")]
		public DIHBOGADNHJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400077D")]
		private BCMCCDAIONP.JGFOAOPLFGA <roomDataUpload>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400077E")]
		private BCMCCDAIONP.JGFOAOPLFGA <subRoomDataUpload>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400077F")]
		private int <persistenceVersion>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000780")]
		private byte <omVersion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000781")]
		private MGFMAPEPLBA <request>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000782")]
		private HKAJAMIEIHO <response>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000783")]
		private (BCMCCDAIONP.JGFOAOPLFGA roomDataUpload, BCMCCDAIONP.JGFOAOPLFGA subRoomDataUpload) <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000784")]
		private (BCMCCDAIONP.JGFOAOPLFGA roomDataUpload, BCMCCDAIONP.JGFOAOPLFGA subRoomDataUpload) <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000785")]
		private HKAJAMIEIHO <>s__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000786")]
		private TaskAwaiter<(BCMCCDAIONP.JGFOAOPLFGA roomDataUpload, BCMCCDAIONP.JGFOAOPLFGA subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000787")]
		private TaskAwaiter<HKAJAMIEIHO> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public LOCPJEIPOMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0x36BC000", Offset = "0x36BA600", VA = "0x1836BC000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000193")]
	[CompilerGenerated]
	private sealed class JDBPAIOGOOE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000788")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000789")]
		public AsyncTaskMethodBuilder<KKHNIHINLHD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400078A")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400078B")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400078C")]
		public NLCCKHNECKK roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400078D")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400078E")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400078F")]
		public DIHBOGADNHJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000790")]
		private BCMCCDAIONP.JGFOAOPLFGA <roomDataUpload>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000791")]
		private BCMCCDAIONP.JGFOAOPLFGA <subRoomDataUpload>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000792")]
		private KKHNIHINLHD <remoteRunDetails>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000793")]
		private (BCMCCDAIONP.JGFOAOPLFGA roomDataUpload, BCMCCDAIONP.JGFOAOPLFGA subRoomDataUpload) <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000794")]
		private (BCMCCDAIONP.JGFOAOPLFGA roomDataUpload, BCMCCDAIONP.JGFOAOPLFGA subRoomDataUpload) <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000795")]
		private KKHNIHINLHD <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000796")]
		private TaskAwaiter<(BCMCCDAIONP.JGFOAOPLFGA roomDataUpload, BCMCCDAIONP.JGFOAOPLFGA subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000797")]
		private TaskAwaiter<KKHNIHINLHD> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public JDBPAIOGOOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0x36B8D00", Offset = "0x36B7300", VA = "0x1836B8D00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000194")]
	[CompilerGenerated]
	private sealed class DJEJLMDIBGA
	{
		[Cpp2IlInjected.Token(Token = "0x2000195")]
		private sealed class <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007A0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007A1")]
			public AsyncTaskMethodBuilder<IHCOLCCANMI> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007A2")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40007A3")]
			public DJEJLMDIBGA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40007A4")]
			private IHCOLCCANMI <reloadMessage>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40007A5")]
			private RepeatedField<NFFPAONFDAO> <persistenceViewsOpt>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40007A6")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6D6220", Offset = "0x6D5620")]
			private IEnumerable<NFFPAONFDAO> <persistenceViews>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40007A7")]
			private bool <couldSaveLocalRoomData>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
			[Cpp2IlInjected.Token(Token = "0x40007A8")]
			private bool <>s__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40007A9")]
			private KKHNIHINLHD <remoteRunDetails>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40007AA")]
			private KKHNIHINLHD <>s__7;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40007AB")]
			private HKAJAMIEIHO <saveDetails>5__8;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40007AC")]
			private HKAJAMIEIHO <>s__9;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40007AD")]
			private IHCOLCCANMI <>s__10;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40007AE")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40007AF")]
			private TaskAwaiter<KKHNIHINLHD> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40007B0")]
			private TaskAwaiter<HKAJAMIEIHO> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40007B1")]
			private TaskAwaiter<IHCOLCCANMI> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60006ED")]
			[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
			public <<UploadRoomDataBlobAndSyncReload>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006EE")]
			[Cpp2IlInjected.Address(RVA = "0x612D9C0", Offset = "0x612BFC0", VA = "0x18612D9C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006EF")]
			[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000798")]
		public DIHBOGADNHJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000799")]
		public NLCCKHNECKK roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400079A")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400079B")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400079C")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400079D")]
		public FINMCLAFJIC roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400079E")]
		public GPKGCDHOKFN roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400079F")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6D6150", Offset = "0x6D5550")]
		public NHNLOHOBNME<string>.NOELMCIDFEB stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public DJEJLMDIBGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0x36B07D0", Offset = "0x36AEDD0", VA = "0x1836B07D0")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<IHCOLCCANMI> AILCGPHOCMB(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000196")]
	[CompilerGenerated]
	private sealed class PGKKMKGDNHN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007B2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007B3")]
		public AsyncTaskMethodBuilder<IHCOLCCANMI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007B4")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007B5")]
		public FINMCLAFJIC roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007B6")]
		public NLCCKHNECKK roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40007B7")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40007B8")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40007B9")]
		public GPKGCDHOKFN roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40007BA")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6D6280", Offset = "0x6D5680")]
		public NHNLOHOBNME<string>.NOELMCIDFEB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40007BB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40007BC")]
		public DIHBOGADNHJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40007BD")]
		private DJEJLMDIBGA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40007BE")]
		private IHCOLCCANMI <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40007BF")]
		private TaskAwaiter<IHCOLCCANMI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public PGKKMKGDNHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0x36BEF90", Offset = "0x36BD590", VA = "0x1836BEF90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000761")]
	private const float BHNEHDKFBMG = 10f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000762")]
	private readonly PMAIAKAPGOL OGBBOOPHMPN;

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	private LCNJJEKDLHB CHKGBBHIKAG
	{
		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x2193F00", Offset = "0x2192500", VA = "0x182193F00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006D8")]
	[Cpp2IlInjected.Address(RVA = "0x21944E0", Offset = "0x2192AE0", VA = "0x1821944E0")]
	public DIHBOGADNHJ(EJKLHKJLFLB GONKAHKFNDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D9")]
	[Cpp2IlInjected.Address(RVA = "0x2194120", Offset = "0x2192720", VA = "0x182194120")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ANNBEMJPEPP))]
	private Task<(BCMCCDAIONP.JGFOAOPLFGA, BCMCCDAIONP.JGFOAOPLFGA)> KKKCPMFEMAN(NLCCKHNECKK ADALNLFJHAF, long EDDMGMBKEBK, long LKPOLLBAPFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006DA")]
	[Cpp2IlInjected.Address(RVA = "0x2193F30", Offset = "0x2192530", VA = "0x182193F30")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LOCPJEIPOMK))]
	public Task<HKAJAMIEIHO> IDFPMLPCLML(int ALKJHDBDIOA, [CanBeNull] FINMCLAFJIC MEADLMEKHNC, NLCCKHNECKK ADALNLFJHAF, long EDDMGMBKEBK, long LKPOLLBAPFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006DB")]
	[Cpp2IlInjected.Address(RVA = "0x21942E0", Offset = "0x21928E0", VA = "0x1821942E0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JDBPAIOGOOE))]
	private Task<KKHNIHINLHD> OCDPMFHHOHC(string JMDMGHGBHHM, int ALKJHDBDIOA, NLCCKHNECKK ADALNLFJHAF, long EDDMGMBKEBK, long LKPOLLBAPFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006DC")]
	[Cpp2IlInjected.Address(RVA = "0x2193CB0", Offset = "0x21922B0", VA = "0x182193CB0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PGKKMKGDNHN))]
	public Task<IHCOLCCANMI> CJDOKEJEBNH(int ALKJHDBDIOA, FINMCLAFJIC? MEADLMEKHNC, NLCCKHNECKK ADALNLFJHAF, long EDDMGMBKEBK, long LKPOLLBAPFL, GPKGCDHOKFN GLMGHMOCMAF, NHNLOHOBNME<string>.NOELMCIDFEB FLAKFKAEKNJ, CancellationToken OOAGLCBNIOG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000197")]
internal class ICAIJMEDOJK : DOJJHPANDDM
{
	[Cpp2IlInjected.Token(Token = "0x2000198")]
	[CompilerGenerated]
	private sealed class NGMCJALDCCF
	{
		[Cpp2IlInjected.Token(Token = "0x2000199")]
		private sealed class <<RunWhilePlayerDespawnedAsync>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007CA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007CB")]
			public AsyncTaskMethodBuilder<IHCOLCCANMI> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007CC")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40007CD")]
			public NGMCJALDCCF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40007CE")]
			private NLCCKHNECKK <data>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40007CF")]
			private IHCOLCCANMI <reloadMsg>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40007D0")]
			private NLCCKHNECKK <>s__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40007D1")]
			private IHCOLCCANMI <>s__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40007D2")]
			private TaskAwaiter<NLCCKHNECKK> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40007D3")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6D63C0", Offset = "0x6D57C0")]
			private TaskAwaiter<IHCOLCCANMI> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60006F9")]
			[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
			public <<RunWhilePlayerDespawnedAsync>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006FA")]
			[Cpp2IlInjected.Address(RVA = "0x612D550", Offset = "0x612BB50", VA = "0x18612D550", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006FB")]
			[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007C2")]
		public ICAIJMEDOJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007C3")]
		public JOHHPAJAAMJ serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007C4")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007C5")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007C6")]
		public DIHBOGADNHJ uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007C7")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007C8")]
		public GPKGCDHOKFN roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40007C9")]
		public NHNLOHOBNME<string>.NOELMCIDFEB stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public NGMCJALDCCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0x36BE420", Offset = "0x36BCA20", VA = "0x1836BE420")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<IHCOLCCANMI> ENLEKBBPNCM(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200019A")]
	[CompilerGenerated]
	private sealed class ELIFEOJAMIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007D4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007D5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007D6")]
		public EJKLHKJLFLB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007D7")]
		public NHNLOHOBNME<string>.NOELMCIDFEB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007D8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40007D9")]
		public ICAIJMEDOJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40007DA")]
		private NGMCJALDCCF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40007DB")]
		private MEALHALACCD <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40007DC")]
		private PFODCGFLBLH <currentRoomSave>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40007DD")]
		private long <loadedSubroomSaveId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40007DE")]
		private bool <currentLoadedSaveIsPublished>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40007DF")]
		private PNCAOKGAGKF <loadLogic>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40007E0")]
		private IHCOLCCANMI <saveReloadMessage>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40007E1")]
		private IHCOLCCANMI <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40007E2")]
		private Exception <ex>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40007E3")]
		private TaskAwaiter<IHCOLCCANMI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40007E4")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public ELIFEOJAMIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0x36B3650", Offset = "0x36B1C50", VA = "0x1836B3650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40007C0")]
	private readonly int ALKJHDBDIOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40007C1")]
	[CanBeNull]
	private readonly FINMCLAFJIC MEADLMEKHNC;

	[Cpp2IlInjected.Token(Token = "0x60006F3")]
	[Cpp2IlInjected.Address(RVA = "0x21A8700", Offset = "0x21A6D00", VA = "0x1821A8700")]
	public ICAIJMEDOJK(Guid MGMFLGBPLHJ, LCNJJEKDLHB LCPJEGLKADH, int ALKJHDBDIOA, FINMCLAFJIC MEADLMEKHNC, JMODPMGGFBH OIHIMIHAFFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F4")]
	[Cpp2IlInjected.Address(RVA = "0x21A8290", Offset = "0x21A6890", VA = "0x1821A8290", Slot = "9")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ELIFEOJAMIM))]
	protected override Task ACJEBFNONKN(EJKLHKJLFLB GONKAHKFNDA, NHNLOHOBNME<string>.NOELMCIDFEB FLAKFKAEKNJ, CancellationToken OOAGLCBNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006F5")]
	[Cpp2IlInjected.Address(RVA = "0x21A8430", Offset = "0x21A6A30", VA = "0x1821A8430")]
	private void CIAKKHMBLJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F6")]
	[Cpp2IlInjected.Address(RVA = "0x21A8560", Offset = "0x21A6B60", VA = "0x1821A8560")]
	private void EFODOCNGINM(NHNLOHOBNME<string>.NOELMCIDFEB FLAKFKAEKNJ, MEALHALACCD CJBHPGFBNKH)
	{
	}
}
namespace RecRoom.RoomLoading.RoomOperation.Validation
{
	[Cpp2IlInjected.Token(Token = "0x200019B")]
	public class ValidationResultConfig : ScriptableObject, ISerializationCallbackReceiver
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200019C")]
		public class ResultConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007E8")]
			public LEMOGBKGIOO ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40007E9")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007EA")]
			public LEMOGBKGIOO HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007EB")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40007EC")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007ED")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x6000705")]
			[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40007E5")]
		private static LEMOGBKGIOO[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007E6")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007E7")]
		private Dictionary<LEMOGBKGIOO, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x27451A0", Offset = "0x27437A0", VA = "0x1827451A0")]
		public bool FBHDCCFJNBN(LEMOGBKGIOO FJFNPILHBBM, out ResultConfig GKLJDKMPGML)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x2745980", Offset = "0x2743F80", VA = "0x182745980")]
		public ResultConfig PLICOONMCLD(LEMOGBKGIOO HBPMAEHGPOI, [Optional] HashSet<LEMOGBKGIOO> FHBGLICPIAI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(RVA = "0x2745780", Offset = "0x2743D80", VA = "0x182745780", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0x2745210", Offset = "0x2743810", VA = "0x182745210", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(RVA = "0x9A2FF0", Offset = "0x9A15F0", VA = "0x1809A2FF0")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200019E")]
public class HGMJGDOBAKJ : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600070C")]
	[Cpp2IlInjected.Address(RVA = "0x21A5A00", Offset = "0x21A4000", VA = "0x1821A5A00")]
	public HGMJGDOBAKJ(string JIEHBANCLJP, Exception CLMDDJKOHJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019F")]
public class OGBDGADJIBK
{
	[Cpp2IlInjected.Token(Token = "0x20001A0")]
	private sealed class BOICGLHANHO : LGMKGJHIJBM, IEquatable<LGMKGJHIJBM>
	{
		[Cpp2IlInjected.Token(Token = "0x20001A1")]
		[CompilerGenerated]
		private sealed class IKODAKLGGPE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007FA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007FB")]
			public AsyncTaskMethodBuilder<LOJBOFKMJHM> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007FC")]
			public BOICGLHANHO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40007FD")]
			private NJPEDPIBAHB <roomManager>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40007FE")]
			private LMPJDKBMOBF <newRoomDetails>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40007FF")]
			private FICOENLLCNC <roomLoadRequestPayload>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000800")]
			private LMPJDKBMOBF <>s__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000801")]
			private LOJBOFKMJHM <>s__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000802")]
			private TaskAwaiter<LMPJDKBMOBF> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000803")]
			private TaskAwaiter<LOJBOFKMJHM> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600071D")]
			[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
			public IKODAKLGGPE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600071E")]
			[Cpp2IlInjected.Address(RVA = "0x6127770", Offset = "0x6125D70", VA = "0x186127770", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600071F")]
			[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007F7")]
		private readonly PFODCGFLBLH NIELCKIDILC;

		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		public int IEKODLFBIHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000711")]
			[Cpp2IlInjected.Address(RVA = "0x944070", Offset = "0x942670", VA = "0x180944070", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		public GEMBAKICDNB NCJFOHFBGAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000712")]
			[Cpp2IlInjected.Address(RVA = "0x86F2A0", Offset = "0x86D8A0", VA = "0x18086F2A0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		private DateTime CKPKNEDEDJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000713")]
			[Cpp2IlInjected.Address(RVA = "0x21016C0", Offset = "0x20FFCC0", VA = "0x1821016C0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		public OLPFOKKGNMJ? ODAFEHOAKLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000714")]
			[Cpp2IlInjected.Address(RVA = "0xBC45A0", Offset = "0xBC2BA0", VA = "0x180BC45A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		public PJGLGJGGBCH? IJGBDCPKIFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000715")]
			[Cpp2IlInjected.Address(RVA = "0x3EC7E80", Offset = "0x3EC6480", VA = "0x183EC7E80", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		public CCOMKLMEFAE CNONMNKBDFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000718")]
			[Cpp2IlInjected.Address(RVA = "0x923800", Offset = "0x921E00", VA = "0x180923800", Slot = "10")]
			get
			{
				return default(CCOMKLMEFAE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000716")]
		[Cpp2IlInjected.Address(RVA = "0x3EC7D30", Offset = "0x3EC6330", VA = "0x183EC7D30", Slot = "9")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(IKODAKLGGPE))]
		public Task<LOJBOFKMJHM> INNMOLOBMLF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000717")]
		[Cpp2IlInjected.Address(RVA = "0x3EC7EA0", Offset = "0x3EC64A0", VA = "0x183EC7EA0")]
		public BOICGLHANHO(int HKDACDLACEO, GEMBAKICDNB IMJJKHBKMJM, PFODCGFLBLH NIELCKIDILC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0x3EC7B10", Offset = "0x3EC6110", VA = "0x183EC7B10", Slot = "11")]
		public bool Equals(LGMKGJHIJBM EJECOGCICOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0x3EC7BB0", Offset = "0x3EC61B0", VA = "0x183EC7BB0", Slot = "0")]
		public override bool Equals(object IAMEECMGPIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(RVA = "0x3EC7CE0", Offset = "0x3EC62E0", VA = "0x183EC7CE0")]
		private bool HHKDFMPBCME(BOICGLHANHO EJECOGCICOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0x3EC7C50", Offset = "0x3EC6250", VA = "0x183EC7C50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A2")]
	private sealed class GOLEBLPPOHF : LGMKGJHIJBM, IEquatable<LGMKGJHIJBM>
	{
		[Cpp2IlInjected.Token(Token = "0x20001A3")]
		[CompilerGenerated]
		private sealed class ALKLIJIPCBM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000807")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000808")]
			public AsyncTaskMethodBuilder<LOJBOFKMJHM> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000809")]
			public GOLEBLPPOHF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400080A")]
			private LOJBOFKMJHM <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400080B")]
			private TaskAwaiter<LOJBOFKMJHM> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600072C")]
			[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
			public ALKLIJIPCBM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072D")]
			[Cpp2IlInjected.Address(RVA = "0x6123440", Offset = "0x6121A40", VA = "0x186123440", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072E")]
			[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000804")]
		private readonly KFADJCAHNKD MHLPPHEPLOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000805")]
		private readonly OLPFOKKGNMJ ACIECMNEIIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000806")]
		private readonly PJGLGJGGBCH IPMLNJCLNPD;

		[Cpp2IlInjected.Token(Token = "0x170000D0")]
		public int IEKODLFBIHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000720")]
			[Cpp2IlInjected.Address(RVA = "0x3ECE740", Offset = "0x3ECCD40", VA = "0x183ECE740", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		public GEMBAKICDNB NCJFOHFBGAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000721")]
			[Cpp2IlInjected.Address(RVA = "0x3ECEB70", Offset = "0x3ECD170", VA = "0x183ECEB70", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		private DateTime CKPKNEDEDJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000722")]
			[Cpp2IlInjected.Address(RVA = "0x3ECEB20", Offset = "0x3ECD120", VA = "0x183ECEB20", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		public OLPFOKKGNMJ? ODAFEHOAKLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000723")]
			[Cpp2IlInjected.Address(RVA = "0x3ECEBC0", Offset = "0x3ECD1C0", VA = "0x183ECEBC0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		public PJGLGJGGBCH? IJGBDCPKIFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000724")]
			[Cpp2IlInjected.Address(RVA = "0x3ECEC10", Offset = "0x3ECD210", VA = "0x183ECEC10", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		public CCOMKLMEFAE CNONMNKBDFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000727")]
			[Cpp2IlInjected.Address(RVA = "0x914DA0", Offset = "0x9133A0", VA = "0x180914DA0", Slot = "10")]
			get
			{
				return default(CCOMKLMEFAE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000725")]
		[Cpp2IlInjected.Address(RVA = "0x3807960", Offset = "0x3805F60", VA = "0x183807960")]
		public GOLEBLPPOHF(KFADJCAHNKD IIIIEFFLPLO, OLPFOKKGNMJ LOGLLLOOMAL, PJGLGJGGBCH BNOPHOMGHAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000726")]
		[Cpp2IlInjected.Address(RVA = "0x3ECE9D0", Offset = "0x3ECCFD0", VA = "0x183ECE9D0", Slot = "9")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(ALKLIJIPCBM))]
		public Task<LOJBOFKMJHM> INNMOLOBMLF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000728")]
		[Cpp2IlInjected.Address(RVA = "0x3ECE790", Offset = "0x3ECCD90", VA = "0x183ECE790", Slot = "11")]
		public bool Equals(LGMKGJHIJBM EJECOGCICOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000729")]
		[Cpp2IlInjected.Address(RVA = "0x3ECE830", Offset = "0x3ECCE30", VA = "0x183ECE830", Slot = "0")]
		public override bool Equals(object IAMEECMGPIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600072A")]
		[Cpp2IlInjected.Address(RVA = "0x3ECE970", Offset = "0x3ECCF70", VA = "0x183ECE970")]
		private bool HHKDFMPBCME(GOLEBLPPOHF EJECOGCICOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600072B")]
		[Cpp2IlInjected.Address(RVA = "0x3ECE8E0", Offset = "0x3ECCEE0", VA = "0x183ECE8E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A4")]
	private sealed class FBJMJBNCJDF : LGMKGJHIJBM, IEquatable<LGMKGJHIJBM>
	{
		[Cpp2IlInjected.Token(Token = "0x20001A5")]
		[CompilerGenerated]
		private sealed class PJMEKKGIGFD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400080F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000810")]
			public AsyncTaskMethodBuilder<LOJBOFKMJHM> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000811")]
			public FBJMJBNCJDF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000812")]
			private LOJBOFKMJHM <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000813")]
			private TaskAwaiter<LOJBOFKMJHM> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600073B")]
			[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
			public PJMEKKGIGFD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073C")]
			[Cpp2IlInjected.Address(RVA = "0x612A6A0", Offset = "0x6128CA0", VA = "0x18612A6A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073D")]
			[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400080C")]
		private readonly GEMBAKICDNB CKALHHCGNFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400080D")]
		private readonly OLPFOKKGNMJ ACIECMNEIIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400080E")]
		private readonly PJGLGJGGBCH IPMLNJCLNPD;

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		public int IEKODLFBIHP
		{
			[Cpp2IlInjected.Token(Token = "0x600072F")]
			[Cpp2IlInjected.Address(RVA = "0x3ECC190", Offset = "0x3ECA790", VA = "0x183ECC190", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		[NotNull]
		public GEMBAKICDNB NCJFOHFBGAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000730")]
			[Cpp2IlInjected.Address(RVA = "0x86D400", Offset = "0x86BA00", VA = "0x18086D400", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		private DateTime CKPKNEDEDJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000731")]
			[Cpp2IlInjected.Address(RVA = "0x9149B0", Offset = "0x912FB0", VA = "0x1809149B0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D9")]
		public OLPFOKKGNMJ? ODAFEHOAKLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000732")]
			[Cpp2IlInjected.Address(RVA = "0x3ECC7C0", Offset = "0x3ECADC0", VA = "0x183ECC7C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DA")]
		public PJGLGJGGBCH? IJGBDCPKIFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000733")]
			[Cpp2IlInjected.Address(RVA = "0x3ECC810", Offset = "0x3ECAE10", VA = "0x183ECC810", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DB")]
		public CCOMKLMEFAE CNONMNKBDFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000736")]
			[Cpp2IlInjected.Address(RVA = "0x9149B0", Offset = "0x912FB0", VA = "0x1809149B0", Slot = "10")]
			get
			{
				return default(CCOMKLMEFAE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000734")]
		[Cpp2IlInjected.Address(RVA = "0x3807960", Offset = "0x3805F60", VA = "0x183807960")]
		public FBJMJBNCJDF(GEMBAKICDNB IMJJKHBKMJM, OLPFOKKGNMJ LOGLLLOOMAL, PJGLGJGGBCH BNOPHOMGHAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000735")]
		[Cpp2IlInjected.Address(RVA = "0x3ECC670", Offset = "0x3ECAC70", VA = "0x183ECC670", Slot = "9")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(PJMEKKGIGFD))]
		public Task<LOJBOFKMJHM> INNMOLOBMLF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000737")]
		[Cpp2IlInjected.Address(RVA = "0x3ECC210", Offset = "0x3ECA810", VA = "0x183ECC210", Slot = "11")]
		public bool Equals(LGMKGJHIJBM EJECOGCICOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000738")]
		[Cpp2IlInjected.Address(RVA = "0x3ECC350", Offset = "0x3ECA950", VA = "0x183ECC350", Slot = "0")]
		public override bool Equals(object IAMEECMGPIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000739")]
		[Cpp2IlInjected.Address(RVA = "0x3ECC4A0", Offset = "0x3ECAAA0", VA = "0x183ECC4A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600073A")]
		[Cpp2IlInjected.Address(RVA = "0x3ECC550", Offset = "0x3ECAB50", VA = "0x183ECC550")]
		private bool HHKDFMPBCME(FBJMJBNCJDF EJECOGCICOM)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A7")]
	[CompilerGenerated]
	private sealed class ECKGNDJDHJM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400081A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400081B")]
		public AsyncTaskMethodBuilder<IList<LGMKGJHIJBM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400081C")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400081D")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400081E")]
		public bool forceRefreshSaveHistoryCache;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400081F")]
		public OGBDGADJIBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000820")]
		private (long roomId, long subroomId) <cacheKey>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000821")]
		private IReadOnlyList<PFODCGFLBLH> <saveHistory>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000822")]
		private IReadOnlyList<(int accountId, GEMBAKICDNB account, PFODCGFLBLH roomDataSaveDto)> <saveHistoryWithAccounts>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000823")]
		private List<LGMKGJHIJBM> <restoreOptions>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000824")]
		private DateTime? <mostRecentSaveDate>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000825")]
		private KFADJCAHNKD <autoSaveInfo>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000826")]
		private IReadOnlyList<PFODCGFLBLH> <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000827")]
		private IReadOnlyList<(int accountId, GEMBAKICDNB account, PFODCGFLBLH roomDataSaveDto)> <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000828")]
		private IEnumerator<(int accountId, GEMBAKICDNB account, PFODCGFLBLH roomDataSaveDto)> <>s__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000829")]
		private (int accountId, GEMBAKICDNB account, PFODCGFLBLH roomDataSaveDto) <saveHistoryWithAccount>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400082A")]
		private GOLEBLPPOHF <autosaveOption>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400082B")]
		private TaskAwaiter<IReadOnlyList<PFODCGFLBLH>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400082C")]
		private TaskAwaiter<IReadOnlyList<(int accountId, GEMBAKICDNB account, PFODCGFLBLH roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000745")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public ECKGNDJDHJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000746")]
		[Cpp2IlInjected.Address(RVA = "0x3ECA300", Offset = "0x3EC8900", VA = "0x183ECA300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A8")]
	[CompilerGenerated]
	private sealed class NALNACNGEHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400082D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400082E")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, GEMBAKICDNB account, PFODCGFLBLH roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400082F")]
		public IReadOnlyList<PFODCGFLBLH> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000830")]
		public OGBDGADJIBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000831")]
		private List<int> <accountIds>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000832")]
		private IReadOnlyList<GEMBAKICDNB> <accounts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000833")]
		private Dictionary<ObscuredInt, GEMBAKICDNB> <accountsDict>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000834")]
		private List<(int, GEMBAKICDNB, PFODCGFLBLH)> <finalHistory>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000835")]
		private IReadOnlyList<GEMBAKICDNB> <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000836")]
		private IEnumerator<PFODCGFLBLH> <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000837")]
		private PFODCGFLBLH <historyItem>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000838")]
		private int <savedByAccountId>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000839")]
		private GEMBAKICDNB <savedByAccount>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400083A")]
		private GEMBAKICDNB <account>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400083B")]
		private TaskAwaiter<IReadOnlyList<GEMBAKICDNB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000748")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public NALNACNGEHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(RVA = "0x3ED5FA0", Offset = "0x3ED45A0", VA = "0x183ED5FA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074A")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007F3")]
	private readonly FHMOGJGGEFL IKADPDMNLCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40007F4")]
	private readonly IJGHBGBGJPJ DNHEBDFCKJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40007F5")]
	private readonly JEPKLFNGOMJ LCABLOEKPFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40007F6")]
	private readonly LLFPEOCCHAO<(long, long), IReadOnlyList<PFODCGFLBLH>> JFNLGFLCONH;

	[Cpp2IlInjected.Token(Token = "0x600070D")]
	[Cpp2IlInjected.Address(RVA = "0x273AC00", Offset = "0x2739200", VA = "0x18273AC00")]
	[UnityEngine.Scripting.Preserve]
	public OGBDGADJIBK([NALHKAIJJND(null)] IJGHBGBGJPJ HAILLBAMDFI, [NALHKAIJJND(null)] JEPKLFNGOMJ ADOHIKNIOHC, [NALHKAIJJND(null)] FHMOGJGGEFL AKCMPKIIFDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070E")]
	[Cpp2IlInjected.Address(RVA = "0x273AA60", Offset = "0x2739060", VA = "0x18273AA60")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ECKGNDJDHJM))]
	public Task<IList<LGMKGJHIJBM>> NLAKNFPNJDB(long EDDMGMBKEBK, long NCHHGHFPFDL, bool OPMHDCEALEI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600070F")]
	[Cpp2IlInjected.Address(RVA = "0x273A750", Offset = "0x2738D50", VA = "0x18273A750")]
	private bool FFNJEIMMOLF(DateTime? BNAPDEOOEOB, long EDDMGMBKEBK, long NCHHGHFPFDL, out KFADJCAHNKD KBEMOJLMDPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000710")]
	[Cpp2IlInjected.Address(RVA = "0x273A8F0", Offset = "0x2738EF0", VA = "0x18273A8F0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NALNACNGEHH))]
	private Task<IReadOnlyList<(int, GEMBAKICDNB, PFODCGFLBLH)>> HNDBJFCFJLD(IReadOnlyList<PFODCGFLBLH> PFFCJKPHOAK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A9")]
internal class KPIOCDKIBOI : IJGHBGBGJPJ
{
	[Cpp2IlInjected.Token(Token = "0x20001AA")]
	[CompilerGenerated]
	private sealed class JJFMGAPKKMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400083C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400083D")]
		public AsyncTaskMethodBuilder<IReadOnlyList<PFODCGFLBLH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400083E")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400083F")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000840")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000841")]
		public KPIOCDKIBOI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000842")]
		private ENHAEHDJDBB<PFODCGFLBLH> <pagedResults>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000843")]
		private ENHAEHDJDBB<PFODCGFLBLH> <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000844")]
		private TaskAwaiter<ENHAEHDJDBB<PFODCGFLBLH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600074E")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public JJFMGAPKKMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(RVA = "0x36B9530", Offset = "0x36B7B30", VA = "0x1836B9530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000750")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001AB")]
	[CompilerGenerated]
	private sealed class MGKBDCIFHNA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000845")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000846")]
		public AsyncTaskMethodBuilder<IReadOnlyList<GEMBAKICDNB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000847")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000848")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000849")]
		public KPIOCDKIBOI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400084A")]
		private List<GEMBAKICDNB> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400084B")]
		private TaskAwaiter<List<GEMBAKICDNB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000751")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public MGKBDCIFHNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(RVA = "0x36BD050", Offset = "0x36BB650", VA = "0x1836BD050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000753")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600074B")]
	[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
	[UnityEngine.Scripting.Preserve]
	public KPIOCDKIBOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074C")]
	[Cpp2IlInjected.Address(RVA = "0x21AC5A0", Offset = "0x21AABA0", VA = "0x1821AC5A0", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JJFMGAPKKMM))]
	public Task<IReadOnlyList<PFODCGFLBLH>> IAJFNIPKLLH(long EDDMGMBKEBK, long LKPOLLBAPFL, [Optional] CancellationToken OOAGLCBNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600074D")]
	[Cpp2IlInjected.Address(RVA = "0x21AC750", Offset = "0x21AAD50", VA = "0x1821AC750", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MGKBDCIFHNA))]
	public Task<IReadOnlyList<GEMBAKICDNB>> PDMOEKKIGKK(IReadOnlyList<int> LLMJJFOJHOL, [Optional] CancellationToken OOAGLCBNIOG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AC")]
public interface IJGHBGBGJPJ
{
	[Cpp2IlInjected.Token(Token = "0x6000754")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<PFODCGFLBLH>> IAJFNIPKLLH(long EDDMGMBKEBK, long LKPOLLBAPFL, [Optional] CancellationToken OOAGLCBNIOG);

	[Cpp2IlInjected.Token(Token = "0x6000755")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<GEMBAKICDNB>> PDMOEKKIGKK(IReadOnlyList<int> LLMJJFOJHOL, [Optional] CancellationToken OOAGLCBNIOG);
}
[Cpp2IlInjected.Token(Token = "0x20001AD")]
public interface LGMKGJHIJBM : IEquatable<LGMKGJHIJBM>
{
	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	int IEKODLFBIHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000756")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	[CanBeNull]
	GEMBAKICDNB NCJFOHFBGAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000757")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	DateTime LNLGGFEJFEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	OLPFOKKGNMJ? ODAFEHOAKLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	PJGLGJGGBCH? IJGBDCPKIFD
	{
		[Cpp2IlInjected.Token(Token = "0x600075A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	[CanBeNull]
	CCOMKLMEFAE CNONMNKBDFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600075B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<LOJBOFKMJHM> INNMOLOBMLF();
}
[Cpp2IlInjected.Token(Token = "0x20001AE")]
public enum CCOMKLMEFAE
{
	[Cpp2IlInjected.Token(Token = "0x400084D")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x400084E")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x400084F")]
	DiskAutosave
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20001B1")]
public class IMLHFCPJGKL
{
	[Cpp2IlInjected.Token(Token = "0x600075D")]
	[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
	public IMLHFCPJGKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600075E")]
	[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD111C0", VA = "0x180D12BC0")]
	public static string GOMDFOEHABF(byte[] CEBGDHINIFO, byte[] FGJCLMKLDKK)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20001B2")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
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
